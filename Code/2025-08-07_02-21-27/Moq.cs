using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Moq.Async;
using Moq.Behaviors;
using Moq.Language.Flow;

[assembly: AssemblyVersion("4.18.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
namespace TypeNameFormatter
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static class TypeName
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<Type, string> typeKeywords;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x792ADD0", Offset = "0x79299D0", VA = "0x18792ADD0")]
		static TypeName()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7929C30", Offset = "0x7928830", VA = "0x187929C30")]
		public static StringBuilder AppendFormattedName(this StringBuilder stringBuilder, Type type, TypeNameFormatOptions options = TypeNameFormatOptions.Default)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x792AA70", Offset = "0x7929670", VA = "0x18792AA70")]
		public static string GetFormattedName(this Type type, TypeNameFormatOptions options = TypeNameFormatOptions.Default)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7929CB0", Offset = "0x79288B0", VA = "0x187929CB0")]
		private static void AppendFormattedName(this StringBuilder stringBuilder, Type type, TypeNameFormatOptions options, Type typeWithGenericTypeArgs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x792AC20", Offset = "0x7929820", VA = "0x18792AC20")]
		private static bool IsSet(TypeNameFormatOptions option, TypeNameFormatOptions options)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x792AA40", Offset = "0x7929640", VA = "0x18792AA40")]
		private static IEnumerable<PropertyInfo> GetDeclaredProperties(Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x792AB60", Offset = "0x7929760", VA = "0x18792AB60")]
		private static Type[] GetGenericTypeArguments(Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x792ABF0", Offset = "0x79297F0", VA = "0x18792ABF0")]
		private static bool IsGenericType(Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x792AB90", Offset = "0x7929790", VA = "0x18792AB90")]
		private static bool IsConstructedGenericType(Type type)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	internal enum TypeNameFormatOptions
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Namespaces = 1,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		NoAnonymousTypes = 2,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		NoGenericParameterNames = 4,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		NoKeywords = 8,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		NoNullableQuestionMark = 0x10,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		NoTuple = 0x20
	}
}
namespace Moq
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class AsInterface<TInterface> : Mock<TInterface> where TInterface : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Mock owner;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal override List<Type> AdditionalInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x736C8A0", Offset = "0x736B4A0", VA = "0x18736C8A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal override Dictionary<Type, object> ConfiguredDefaultValues
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x736C900", Offset = "0x736B500", VA = "0x18736C900", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal override InvocationCollection MutableInvocations
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x736CA20", Offset = "0x736B620", VA = "0x18736CA20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal override bool IsObjectInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x736C9C0", Offset = "0x736B5C0", VA = "0x18736C9C0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal override Type MockedType
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x736C9F0", Offset = "0x736B5F0", VA = "0x18736C9F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override MockBehavior Behavior
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x736C8D0", Offset = "0x736B4D0", VA = "0x18736C8D0", Slot = "6")]
			get
			{
				return default(MockBehavior);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override bool CallBase
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3007D10", Offset = "0x3006910", VA = "0x183007D10", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x736CB10", Offset = "0x736B710", VA = "0x18736CB10", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override DefaultValueProvider DefaultValueProvider
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x736C930", Offset = "0x736B530", VA = "0x18736C930", Slot = "15")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x736CB40", Offset = "0x736B740", VA = "0x18736CB40", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		internal override EventHandlerCollection EventHandlers
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x736C960", Offset = "0x736B560", VA = "0x18736C960", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		internal override Type[] InheritedInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x736C990", Offset = "0x736B590", VA = "0x18736C990", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override TInterface Object
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x736CA80", Offset = "0x736B680", VA = "0x18736CA80", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		internal override SetupCollection MutableSetups
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x736CA50", Offset = "0x736B650", VA = "0x18736CA50", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override Switches Switches
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x736CAE0", Offset = "0x736B6E0", VA = "0x18736CAE0", Slot = "18")]
			get
			{
				return default(Switches);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x736CB70", Offset = "0x736B770", VA = "0x18736CB70", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x736C820", Offset = "0x736B420", VA = "0x18736C820")]
		public AsInterface(Mock owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x350BB80", Offset = "0x350A780", VA = "0x18350BB80", Slot = "20")]
		public override Mock<TNewInterface> As<TNewInterface>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x736C7D0", Offset = "0x736B3D0", VA = "0x18736C7D0", Slot = "13")]
		protected override object OnGetObject()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x736C7F0", Offset = "0x736B3F0", VA = "0x18736C7F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal abstract class Behavior
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected Behavior()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void Execute(Invocation invocation);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal sealed class Condition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Action success;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IsTrue
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x790F860", Offset = "0x790E460", VA = "0x18790F860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1057A70", Offset = "0x1056670", VA = "0x181057A70")]
		public void SetupEvaluatedSuccessfully()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal sealed class DefaultExpressionCompiler : ExpressionCompiler
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public new static readonly DefaultExpressionCompiler Instance;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x790FB80", Offset = "0x790E780", VA = "0x18790FB80")]
		private DefaultExpressionCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x790FAC0", Offset = "0x790E6C0", VA = "0x18790FAC0", Slot = "4")]
		public override Delegate Compile(LambdaExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AB6880", Offset = "0x3AB5480", VA = "0x183AB6880", Slot = "5")]
		public override TDelegate Compile<TDelegate>(Expression<TDelegate> expression)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class DefaultValueProvider
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static DefaultValueProvider Empty
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x790FD00", Offset = "0x790E900", VA = "0x18790FD00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static DefaultValueProvider Mock
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x790FD50", Offset = "0x790E950", VA = "0x18790FD50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected DefaultValueProvider()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected internal abstract object GetDefaultValue(Type type, Mock mock);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x790FBD0", Offset = "0x790E7D0", VA = "0x18790FBD0", Slot = "5")]
		protected internal virtual object GetDefaultReturnValue(MethodInfo method, Mock mock)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal sealed class EmptyDefaultValueProvider : LookupOrFallbackDefaultValueProvider
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7910230", Offset = "0x790EE30", VA = "0x187910230")]
		internal EmptyDefaultValueProvider()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x790FDA0", Offset = "0x790E9A0", VA = "0x18790FDA0")]
		private static object CreateArray(Type type, Mock mock)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x790FE80", Offset = "0x790EA80", VA = "0x18790FE80")]
		private static object CreateEnumerable(Type type, Mock mock)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x790FE30", Offset = "0x790EA30", VA = "0x18790FE30")]
		private static object CreateEnumerableOf(Type type, Mock mock)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x79101E0", Offset = "0x790EDE0", VA = "0x1879101E0")]
		private static object CreateQueryable(Type type, Mock mock)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x790FEC0", Offset = "0x790EAC0", VA = "0x18790FEC0")]
		private static object CreateQueryableOf(Type type, Mock mock)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class Evaluator
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class SubtreeEvaluator : ExpressionVisitor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private HashSet<Expression> candidates;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
			internal SubtreeEvaluator(HashSet<Expression> candidates)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7928EC0", Offset = "0x7927AC0", VA = "0x187928EC0")]
			internal Expression Eval(Expression exp)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7929060", Offset = "0x7927C60", VA = "0x187929060", Slot = "4")]
			public override Expression Visit(Expression exp)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7928EE0", Offset = "0x7927AE0", VA = "0x187928EE0")]
			private static Expression Evaluate(Expression e)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private class Nominator : ExpressionVisitor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Func<Expression, bool> fnCanBeEvaluated;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private HashSet<Expression> candidates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private bool cannotBeEvaluated;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
			internal Nominator(Func<Expression, bool> fnCanBeEvaluated)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7922480", Offset = "0x7921080", VA = "0x187922480")]
			internal HashSet<Expression> Nominate(Expression expression)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7922520", Offset = "0x7921120", VA = "0x187922520", Slot = "4")]
			public override Expression Visit(Expression expression)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7910810", Offset = "0x790F410", VA = "0x187910810")]
		public static Expression PartialEval(Expression expression, Func<Expression, bool> fnCanBeEvaluated)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7910940", Offset = "0x790F540", VA = "0x187910940")]
		public static Expression PartialEval(Expression expression)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal sealed class EventHandlerCollection
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Dictionary<EventInfo, Delegate> eventHandlers;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7910D00", Offset = "0x790F900", VA = "0x187910D00")]
		public EventHandlerCollection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7910A40", Offset = "0x790F640", VA = "0x187910A40")]
		public void Add(EventInfo @event, Delegate eventHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7910B60", Offset = "0x790F760", VA = "0x187910B60")]
		public void Remove(EventInfo @event, Delegate eventHandler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7910C80", Offset = "0x790F880", VA = "0x187910C80")]
		private Delegate TryGet(EventInfo @event)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal abstract class Expectation : IEquatable<Expectation>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract LambdaExpression Expression
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1E6CE10", Offset = "0x1E6BA10", VA = "0x181E6CE10", Slot = "6")]
		public virtual bool HasResultExpression([Out] IAwaitableFactory awaitableFactory)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7910D80", Offset = "0x790F980", VA = "0x187910D80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(Expectation other);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		public abstract override int GetHashCode();

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool IsMatch(Invocation invocation);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
		public virtual void SetupEvaluatedSuccessfully(Invocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7910E20", Offset = "0x790FA20", VA = "0x187910E20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected Expectation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal sealed class ExpressionComparer : IEqualityComparer<Expression>
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly ExpressionComparer Default;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[ThreadStatic]
		private static int quoteDepth;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private ExpressionComparer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7912200", Offset = "0x7910E00", VA = "0x187912200", Slot = "4")]
		public bool Equals(Expression x, Expression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7913460", Offset = "0x7912060", VA = "0x187913460", Slot = "5")]
		public int GetHashCode(Expression obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3B92AE0", Offset = "0x3B916E0", VA = "0x183B92AE0")]
		private static bool Equals<T>(ReadOnlyCollection<T> x, ReadOnlyCollection<T> y, Func<T, T, bool> comparer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7910E50", Offset = "0x790FA50", VA = "0x187910E50")]
		private bool EqualsBinary(BinaryExpression x, BinaryExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7910F20", Offset = "0x790FB20", VA = "0x187910F20")]
		private bool EqualsConditional(ConditionalExpression x, ConditionalExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7910FC0", Offset = "0x790FBC0", VA = "0x187910FC0")]
		private static bool EqualsConstant(ConstantExpression x, ConstantExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7910FF0", Offset = "0x790FBF0", VA = "0x187910FF0")]
		private bool EqualsElementInit(ElementInit x, ElementInit y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7911150", Offset = "0x790FD50", VA = "0x187911150")]
		private bool EqualsIndex(IndexExpression x, IndexExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7911280", Offset = "0x790FE80", VA = "0x187911280")]
		private bool EqualsInvocation(InvocationExpression x, InvocationExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7911390", Offset = "0x790FF90", VA = "0x187911390")]
		private bool EqualsLambda(LambdaExpression x, LambdaExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x79114F0", Offset = "0x79100F0", VA = "0x1879114F0")]
		private bool EqualsListInit(ListInitExpression x, ListInitExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7911600", Offset = "0x7910200", VA = "0x187911600")]
		private bool EqualsMemberAssignment(MemberAssignment x, MemberAssignment y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7911630", Offset = "0x7910230", VA = "0x187911630")]
		private bool EqualsMemberBinding(MemberBinding x, MemberBinding y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7911C20", Offset = "0x7910820", VA = "0x187911C20")]
		private bool EqualsMember(MemberExpression x, MemberExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7911950", Offset = "0x7910550", VA = "0x187911950")]
		private bool EqualsMemberInit(MemberInitExpression x, MemberInitExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7911A60", Offset = "0x7910660", VA = "0x187911A60")]
		private bool EqualsMemberListBinding(MemberListBinding x, MemberListBinding y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7911B40", Offset = "0x7910740", VA = "0x187911B40")]
		private bool EqualsMemberMemberBinding(MemberMemberBinding x, MemberMemberBinding y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7911CA0", Offset = "0x79108A0", VA = "0x187911CA0")]
		private bool EqualsMethodCall(MethodCallExpression x, MethodCallExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7911DE0", Offset = "0x79109E0", VA = "0x187911DE0")]
		private bool EqualsNewArray(NewArrayExpression x, NewArrayExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7911F30", Offset = "0x7910B30", VA = "0x187911F30")]
		private bool EqualsNew(NewExpression x, NewExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7912070", Offset = "0x7910C70", VA = "0x187912070")]
		private bool EqualsParameter(ParameterExpression x, ParameterExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x79120F0", Offset = "0x7910CF0", VA = "0x1879120F0")]
		private bool EqualsTypeBinary(TypeBinaryExpression x, TypeBinaryExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7912190", Offset = "0x7910D90", VA = "0x187912190")]
		private bool EqualsUnary(UnaryExpression x, UnaryExpression y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x79110F0", Offset = "0x790FCF0", VA = "0x1879110F0")]
		private bool EqualsExtension(Expression x, Expression y)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public abstract class ExpressionCompiler
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static ExpressionCompiler instance;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static ExpressionCompiler Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7913590", Offset = "0x7912190", VA = "0x187913590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected ExpressionCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract Delegate Compile(LambdaExpression expression);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract TDelegate Compile<TDelegate>(Expression<TDelegate> expression) where TDelegate : Delegate;
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class ExpressionExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7913970", Offset = "0x7912570", VA = "0x187913970")]
		internal static Expression ConvertIfNeeded(this Expression expression, Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x79138C0", Offset = "0x79124C0", VA = "0x1879138C0")]
		internal static Delegate CompileUsingExpressionCompiler(this LambdaExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3B95370", Offset = "0x3B93F70", VA = "0x183B95370")]
		internal static TDelegate CompileUsingExpressionCompiler<TDelegate>(this Expression<TDelegate> expression) where TDelegate : Delegate
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7913EC0", Offset = "0x7912AC0", VA = "0x187913EC0")]
		public static bool IsMatch(this Expression expression, [Out] Match match)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7913610", Offset = "0x7912210", VA = "0x187913610")]
		public static bool CanSplit(this Expression e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x79144D0", Offset = "0x79130D0", VA = "0x1879144D0")]
		internal static Stack<MethodExpectation> Split(this LambdaExpression expression, bool allowNonOverridableLastProperty = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7913AB0", Offset = "0x79126B0", VA = "0x187913AB0")]
		internal static PropertyInfo GetReboundProperty(this MemberExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x79146F0", Offset = "0x79132F0", VA = "0x1879146F0")]
		public static PropertyInfo ToPropertyInfo(this LambdaExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x79141B0", Offset = "0x7912DB0", VA = "0x1879141B0")]
		public static bool IsProperty(this LambdaExpression expression)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x79142B0", Offset = "0x7912EB0", VA = "0x1879142B0")]
		public static Expression PartialEval(this Expression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7914460", Offset = "0x7913060", VA = "0x187914460")]
		public static Expression PartialMatcherAwareEval(this Expression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x79142C0", Offset = "0x7912EC0", VA = "0x1879142C0")]
		private static bool PartialMatcherAwareEval_ShouldEvaluate(Expression expression)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7914810", Offset = "0x7913410", VA = "0x187914810")]
		public static string ToStringFixed(this Expression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x79135E0", Offset = "0x79121E0", VA = "0x1879135E0")]
		public static Expression Apply(this Expression expression, ExpressionVisitor visitor)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	internal static class Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x79160F0", Offset = "0x7914CF0", VA = "0x1879160F0")]
		public static bool CanCreateInstance(this Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7916450", Offset = "0x7915050", VA = "0x187916450")]
		public static bool CanRead(this PropertyInfo property, [Out] MethodInfo getter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x79161F0", Offset = "0x7914DF0", VA = "0x1879161F0")]
		public static bool CanRead(this PropertyInfo property, [Out] MethodInfo getter, [Out] PropertyInfo getterProperty)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x79166D0", Offset = "0x79152D0", VA = "0x1879166D0")]
		public static bool CanWrite(this PropertyInfo property, [Out] MethodInfo setter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7916470", Offset = "0x7915070", VA = "0x187916470")]
		public static bool CanWrite(this PropertyInfo property, [Out] MethodInfo setter, [Out] PropertyInfo setterProperty)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7916800", Offset = "0x7915400", VA = "0x187916800")]
		public static object GetDefaultValue(this Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7916840", Offset = "0x7915440", VA = "0x187916840")]
		public static MethodInfo GetImplementingMethod(this MethodInfo method, Type proxyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7916B70", Offset = "0x7915770", VA = "0x187916B70")]
		public static object InvokePreserveStack(this Delegate del, [Optional] IReadOnlyList<object> args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7916DD0", Offset = "0x79159D0", VA = "0x187916DD0")]
		public static bool IsExtensionMethod(this MethodInfo method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7916E60", Offset = "0x7915A60", VA = "0x187916E60")]
		public static bool IsGetAccessor(this MethodInfo method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7917230", Offset = "0x7915E30", VA = "0x187917230")]
		public static bool IsSetAccessor(this MethodInfo method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7917100", Offset = "0x7915D00", VA = "0x187917100")]
		public static bool IsPropertyAccessor(this MethodInfo method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7916CF0", Offset = "0x79158F0", VA = "0x187916CF0")]
		public static bool IsEventAddAccessor(this MethodInfo method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7916D60", Offset = "0x7915960", VA = "0x187916D60")]
		public static bool IsEventRemoveAccessor(this MethodInfo method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7916C60", Offset = "0x7915860", VA = "0x187916C60")]
		public static bool IsDelegateType(this Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7916EE0", Offset = "0x7915AE0", VA = "0x187916EE0")]
		public static bool IsMockable(this Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x79172B0", Offset = "0x7915EB0", VA = "0x1879172B0")]
		public static bool IsTypeMatcher(this Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7917320", Offset = "0x7915F20", VA = "0x187917320")]
		public static bool IsTypeMatcher(this Type type, [Out] Type typeMatcherType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7916F90", Offset = "0x7915B90", VA = "0x187916F90")]
		public static bool IsOrContainsTypeMatcher(this Type type)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x79161A0", Offset = "0x7914DA0", VA = "0x1879161A0")]
		public static bool CanOverride(this MethodBase method)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7916AD0", Offset = "0x79156D0", VA = "0x187916AD0")]
		public static IEnumerable<MethodInfo> GetMethods(this Type type, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3B997A0", Offset = "0x3B983A0", VA = "0x183B997A0")]
		public static bool CompareTo<TTypes, TOtherTypes>(this TTypes types, TOtherTypes otherTypes, bool exact, bool considerTypeMatchers) where TTypes : IReadOnlyList<Type> where TOtherTypes : IReadOnlyList<Type>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7916B30", Offset = "0x7915730", VA = "0x187916B30")]
		public static ParameterTypes GetParameterTypes(this MethodInfo method)
		{
			return default(ParameterTypes);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3B98D80", Offset = "0x3B97980", VA = "0x183B98D80")]
		public static bool CompareParameterTypesTo<TOtherTypes>(this Delegate function, TOtherTypes otherTypes) where TOtherTypes : IReadOnlyList<Type>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7916A60", Offset = "0x7915660", VA = "0x187916A60")]
		private static MethodInfo GetInvokeMethodFromUntypedDelegateCallback(Delegate callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7917480", Offset = "0x7916080", VA = "0x187917480")]
		public static Type SubstituteTypeMatchers(this Type type, Type other)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x79166F0", Offset = "0x79152F0", VA = "0x1879166F0")]
		public static Mock FindLastInnerMock(this SetupCollection setups, Func<Setup, bool> predicate)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DebuggerStepThrough]
	internal static class Guard
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7917C50", Offset = "0x7916850", VA = "0x187917C50")]
		public static void CanCreateInstance(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7917ED0", Offset = "0x7916AD0", VA = "0x187917ED0")]
		public static void ImplementsInterface(Type interfaceType, Type type, [Optional] string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7917FF0", Offset = "0x7916BF0", VA = "0x187917FF0")]
		public static void ImplementsTypeMatcherProtocol(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x79183B0", Offset = "0x7916FB0", VA = "0x1879183B0")]
		public static void IsOverridable(MethodInfo method, Expression expression)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x79186B0", Offset = "0x79172B0", VA = "0x1879186B0")]
		public static void IsVisibleToProxyFactory(MethodInfo method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7918860", Offset = "0x7917460", VA = "0x187918860")]
		public static void NotNull(object value, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7918280", Offset = "0x7916E80", VA = "0x187918280")]
		public static void IsMockable(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7917DB0", Offset = "0x79169B0", VA = "0x187917DB0")]
		public static void CanRead(PropertyInfo property)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface IInvocation
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		IReadOnlyList<object> Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal interface IMatcher
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Matches(object argument, Type parameterType);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SetupEvaluatedSuccessfully(object argument, Type parameterType);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IMocked<T> : IMocked where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		new Mock<T> Mock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IMocked
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Mock Mock
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal sealed class InnerMockSetup : SetupWithOutParameterSupport
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class <get_InnerMocks>d__3 : IEnumerable<Mock>, IEnumerable, IEnumerator<Mock>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private Mock <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public InnerMockSetup <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Mock IEnumerator<Mock>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <get_InnerMocks>d__3(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x792D210", Offset = "0x792BE10", VA = "0x18792D210", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x792D370", Offset = "0x792BF70", VA = "0x18792D370", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x792D2D0", Offset = "0x792BED0", VA = "0x18792D2D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Mock> IEnumerable<Mock>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x792D2D0", Offset = "0x792BED0", VA = "0x18792D2D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly object returnValue;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override IEnumerable<Mock> InnerMocks
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7919970", Offset = "0x7918570", VA = "0x187919970", Slot = "6")]
			[IteratorStateMachine(typeof(<get_InnerMocks>d__3))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7919930", Offset = "0x7918530", VA = "0x187919930")]
		public InnerMockSetup(Expression originalExpression, Mock mock, MethodExpectation expectation, object returnValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7919900", Offset = "0x7918500", VA = "0x187919900", Slot = "10")]
		protected override void ExecuteCore(Invocation invocation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal sealed class CastleProxyFactory : ProxyFactory
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private sealed class Interceptor : Castle.DynamicProxy.IInterceptor
		{
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static readonly MethodInfo proxyInterceptorGetter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private IInterceptor interceptor;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
			internal Interceptor(IInterceptor interceptor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x79199F0", Offset = "0x79185F0", VA = "0x1879199F0", Slot = "4")]
			public void Intercept(Castle.DynamicProxy.IInvocation underlying)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private sealed class Invocation : Moq.Invocation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private Castle.DynamicProxy.IInvocation underlying;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x791A9B0", Offset = "0x79195B0", VA = "0x18791A9B0")]
			internal Invocation(Castle.DynamicProxy.IInvocation underlying)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x791A440", Offset = "0x7919040", VA = "0x18791A440", Slot = "8")]
			protected internal override object CallBase()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x787E6B0", Offset = "0x787D2B0", VA = "0x18787E6B0")]
			public void DetachFromUnderlying()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class IncludeObjectMethodsHook : AllMethodsHook
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7919750", Offset = "0x7918350", VA = "0x187919750", Slot = "7")]
			public override bool ShouldInterceptMethod(Type type, MethodInfo method)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7919600", Offset = "0x7918200", VA = "0x187919600")]
			private static bool IsRelevantObjectMethod(MethodInfo method)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x79198B0", Offset = "0x79184B0", VA = "0x1879198B0")]
			public IncludeObjectMethodsHook()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private ProxyGenerationOptions generationOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private ProxyGenerator generator;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x790F6E0", Offset = "0x790E2E0", VA = "0x18790F6E0")]
		public CastleProxyFactory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x790F070", Offset = "0x790DC70", VA = "0x18790F070", Slot = "4")]
		public override object CreateProxy(Type mockType, IInterceptor interceptor, Type[] interfaces, object[] arguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x790F630", Offset = "0x790E230", VA = "0x18790F630", Slot = "5")]
		public override bool IsMethodVisible(MethodInfo method, [Out] string messageIfNotVisible)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x790F690", Offset = "0x790E290", VA = "0x18790F690", Slot = "6")]
		public override bool IsTypeVisible(Type type)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal interface IInterceptor
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Intercept(Invocation invocation);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class HandleWellKnownMethods
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static Dictionary<string, Func<Invocation, Mock, bool>> specialMethods;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7919180", Offset = "0x7917D80", VA = "0x187919180")]
		public static bool Handle(Invocation invocation, Mock mock)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7918E30", Offset = "0x7917A30", VA = "0x187918E30")]
		private static bool HandleEquals(Invocation invocation, Mock mock)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7918F20", Offset = "0x7917B20", VA = "0x187918F20")]
		private static bool HandleGetHashCode(Invocation invocation, Mock mock)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x79190C0", Offset = "0x7917CC0", VA = "0x1879190C0")]
		private static bool HandleToString(Invocation invocation, Mock mock)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7918FE0", Offset = "0x7917BE0", VA = "0x187918FE0")]
		private static bool HandleMockGetter(Invocation invocation, Mock mock)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7919280", Offset = "0x7917E80", VA = "0x187919280")]
		private static bool IsObjectMethodWithoutSetup(Invocation invocation, Mock mock)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal static class FindAndExecuteMatchingSetup
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7917B40", Offset = "0x7916740", VA = "0x187917B40")]
		public static bool Handle(Invocation invocation, Mock mock)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal static class HandleEventSubscription
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x79188C0", Offset = "0x79174C0", VA = "0x1879188C0")]
		public static bool Handle(Invocation invocation, Mock mock)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class RecordInvocation
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7923000", Offset = "0x7921C00", VA = "0x187923000")]
		public static void Handle(Invocation invocation, Mock mock)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal static class Return
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7924600", Offset = "0x7923200", VA = "0x187924600")]
		public static void Handle(Invocation invocation, Mock mock)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class FailForStrictMock
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7917AE0", Offset = "0x79166E0", VA = "0x187917AE0")]
		public static void Handle(Invocation invocation, Mock mock)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public abstract class Mock : IInterceptor
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal static readonly MethodInfo GetMethod;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		internal static readonly MethodInfo SetupReturnsMethod;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		internal abstract List<Type> AdditionalInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract MockBehavior Behavior
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract bool CallBase
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		internal abstract EventHandlerCollection EventHandlers
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public object Object
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x300A6B0", Offset = "0x30092B0", VA = "0x18300A6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal abstract Type[] InheritedInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		internal abstract bool IsObjectInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal abstract InvocationCollection MutableInvocations
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal abstract Type MockedType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract DefaultValueProvider DefaultValueProvider
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(Slot = "16")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal abstract SetupCollection MutableSetups
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public abstract Switches Switches
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		internal abstract Dictionary<Type, object> ConfiguredDefaultValues
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7921D90", Offset = "0x7920990", VA = "0x187921D90", Slot = "4")]
		void IInterceptor.Intercept(Invocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected Mock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3DAD970", Offset = "0x3DAC570", VA = "0x183DAD970")]
		public static Mock<T> Get<T>(T mocked) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract object OnGetObject();

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x79221F0", Offset = "0x7920DF0", VA = "0x1879221F0")]
		internal static MethodCall Setup(Mock mock, LambdaExpression expression, Condition condition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7922080", Offset = "0x7920C80", VA = "0x187922080")]
		internal static bool SetupReturns(Mock mock, LambdaExpression expression, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3DAEAA0", Offset = "0x3DAD6A0", VA = "0x183DAEAA0")]
		private static TSetup SetupRecursive<TSetup>(Mock mock, LambdaExpression expression, Func<Mock, Expression, MethodExpectation, TSetup> setupLast, bool allowNonOverridableLastProperty = false) where TSetup : ISetup
		{
			return (TSetup)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE620", Offset = "0x3DAD220", VA = "0x183DAE620")]
		private static TSetup SetupRecursive<TSetup>(Mock mock, LambdaExpression originalExpression, Stack<MethodExpectation> parts, Func<Mock, Expression, MethodExpectation, TSetup> setupLast) where TSetup : ISetup
		{
			return (TSetup)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract Mock<TInterface> As<TInterface>() where TInterface : class;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7921CE0", Offset = "0x79208E0", VA = "0x187921CE0")]
		internal bool ImplementsInterface(Type interfaceType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7921B70", Offset = "0x7920770", VA = "0x187921B70")]
		internal object GetDefaultValue(MethodInfo method, [Out] Mock candidateInnerMock, [Optional] DefaultValueProvider useAlternateProvider)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal abstract class ProxyFactory
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static ProxyFactory Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7922FB0", Offset = "0x7921BB0", VA = "0x187922FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract object CreateProxy(Type mockType, IInterceptor interceptor, Type[] interfaces, object[] arguments);

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool IsMethodVisible(MethodInfo method, [Out] string messageIfNotVisible);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract bool IsTypeVisible(Type type);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected ProxyFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal abstract class Invocation : IInvocation
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private readonly struct ExceptionResult
		{
			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public Exception Exception
			{
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
			public ExceptionResult(Exception exception)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private MethodInfo method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private MethodInfo methodImplementation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Type proxyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private object result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Setup matchingSetup;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public MethodInfo Method
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MethodInfo MethodImplementation
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x791AB90", Offset = "0x7919790", VA = "0x18791AB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		IReadOnlyList<object> IInvocation.Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public ISetup MatchingSetup
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Type ProxyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public object ReturnValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x791ABE0", Offset = "0x79197E0", VA = "0x18791ABE0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Exception Exception
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x791AC40", Offset = "0x7919840", VA = "0x18791AC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x791AB20", Offset = "0x7919720", VA = "0x18791AB20")]
		protected Invocation(Type proxyType, MethodInfo method, params object[] arguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x791A4B0", Offset = "0x79190B0", VA = "0x18791A4B0")]
		public void ConvertResultToAwaitable(IAwaitableFactory awaitableFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected internal abstract object CallBase();

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
		internal void MarkAsMatchedBy(Setup setup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x791A670", Offset = "0x7919270", VA = "0x18791A670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal sealed class InvocationCollection : IReadOnlyList<IInvocation>, IReadOnlyCollection<IInvocation>, IEnumerable<IInvocation>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__14 : IEnumerator<IInvocation>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private IInvocation <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public InvocationCollection <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private Invocation[] <collection>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private int <count>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <i>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			IInvocation IEnumerator<IInvocation>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x792B210", Offset = "0x7929E10", VA = "0x18792B210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x792B350", Offset = "0x7929F50", VA = "0x18792B350", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Invocation[] invocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly object invocationsLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Mock owner;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x791A290", Offset = "0x7918E90", VA = "0x18791A290", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IInvocation this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x791A330", Offset = "0x7918F30", VA = "0x18791A330", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x791A200", Offset = "0x7918E00", VA = "0x18791A200")]
		public InvocationCollection(Mock owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x791A020", Offset = "0x7918C20", VA = "0x18791A020")]
		public void Add(Invocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x791A190", Offset = "0x7918D90", VA = "0x18791A190", Slot = "6")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__14))]
		public IEnumerator<IInvocation> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x791A190", Offset = "0x7918D90", VA = "0x18791A190", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface ISetup
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public static class It
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class Ref<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly MethodInfo isAnyMethod;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x3C41160", Offset = "0x3C3FD60", VA = "0x183C41160")]
		public static TValue IsAny<TValue>()
		{
			return (TValue)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface ITypeMatcher
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Matches(Type typeArgument);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public abstract class LookupOrFallbackDefaultValueProvider : DefaultValueProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Dictionary<object, Func<Type, Mock, object>> factories;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x791B410", Offset = "0x791A010", VA = "0x18791B410")]
		protected LookupOrFallbackDefaultValueProvider()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x791B3A0", Offset = "0x7919FA0", VA = "0x18791B3A0")]
		protected void Register(Type factoryKey, Func<Type, Mock, object> factory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x790FBD0", Offset = "0x790E7D0", VA = "0x18790FBD0", Slot = "5")]
		protected internal sealed override object GetDefaultReturnValue(MethodInfo method, Mock mock)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x791B100", Offset = "0x7919D00", VA = "0x18791B100", Slot = "4")]
		protected internal sealed override object GetDefaultValue(Type type, Mock mock)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x791B360", Offset = "0x7919F60", VA = "0x18791B360", Slot = "6")]
		protected virtual object GetFallbackDefaultValue(Type type, Mock mock)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x791AFB0", Offset = "0x7919BB0", VA = "0x18791AFB0")]
		private object CreateValueTupleOf(Type type, Mock mock)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class Match : IMatcher
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		internal Expression RenderExpression
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "6")]
		internal abstract bool Matches(object argument, Type parameterType);

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "7")]
		internal abstract void SetupEvaluatedSuccessfully(object argument, Type parameterType);

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x791BAA0", Offset = "0x791A6A0", VA = "0x18791BAA0", Slot = "4")]
		bool IMatcher.Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x791BAC0", Offset = "0x791A6C0", VA = "0x18791BAC0", Slot = "5")]
		void IMatcher.SetupEvaluatedSuccessfully(object value, Type parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F4D0", Offset = "0x3D9E0D0", VA = "0x183D9F4D0")]
		public static T Create<T>(Predicate<T> condition, Expression<Func<T>> renderExpression)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F560", Offset = "0x3D9E160", VA = "0x183D9F560")]
		public static T Create<T>(Func<object, Type, bool> condition, Expression<Func<T>> renderExpression)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x791BAE0", Offset = "0x791A6E0", VA = "0x18791BAE0")]
		internal static void Register(Match match)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected Match()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class Match<T> : Match, IEquatable<Match<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		internal Predicate<T> Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		internal Action<T> Success
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5F279B0", Offset = "0x5F265B0", VA = "0x185F279B0")]
		internal Match(Predicate<T> condition, Expression<Func<T>> renderExpression, [Optional] Action<T> success)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5F27640", Offset = "0x5F26240", VA = "0x185F27640", Slot = "6")]
		internal override bool Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5F27830", Offset = "0x5F26430", VA = "0x185F27830", Slot = "7")]
		internal override void SetupEvaluatedSuccessfully(object argument, Type parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5F26CB0", Offset = "0x5F258B0", VA = "0x185F26CB0")]
		private static bool CanCast(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5F26F70", Offset = "0x5F25B70", VA = "0x185F26F70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5F27320", Offset = "0x5F25F20", VA = "0x185F27320", Slot = "8")]
		public bool Equals(Match<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class MatchFactory : Match
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly Func<object, Type, bool> condition;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly MethodInfo canCastMethod;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x791B9E0", Offset = "0x791A5E0", VA = "0x18791B9E0")]
		internal MatchFactory(Func<object, Type, bool> condition, LambdaExpression renderExpression)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x791B760", Offset = "0x791A360", VA = "0x18791B760", Slot = "6")]
		internal override bool Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
		internal override void SetupEvaluatedSuccessfully(object argument, Type parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F100", Offset = "0x3D9DD00", VA = "0x183D9F100")]
		private static bool CanCast<T>(object value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	internal static class MatcherFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x791D960", Offset = "0x791C560", VA = "0x18791D960")]
		public static Pair<IMatcher[], Expression[]> CreateMatchers(IReadOnlyList<Expression> arguments, ParameterInfo[] parameters)
		{
			return default(Pair<IMatcher[], Expression[]>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x791CE10", Offset = "0x791BA10", VA = "0x18791CE10")]
		public static Pair<IMatcher, Expression> CreateMatcher(Expression argument, ParameterInfo parameter)
		{
			return default(Pair<IMatcher, Expression>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x791C8C0", Offset = "0x791B4C0", VA = "0x18791C8C0")]
		public static Pair<IMatcher, Expression> CreateMatcher(Expression expression)
		{
			return default(Pair<IMatcher, Expression>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal sealed class MatcherObserver : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private readonly struct Observation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly Match Match;

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xF7DA70", Offset = "0xF7C670", VA = "0x180F7DA70")]
			public Observation(int timestamp, Match match)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ThreadStatic]
		private static Stack<MatcherObserver> activations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int timestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private List<Observation> observations;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x791DC20", Offset = "0x791C820", VA = "0x18791DC20")]
		public static MatcherObserver Activate()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x791DD80", Offset = "0x791C980", VA = "0x18791DD80")]
		public static bool IsActive([Out] MatcherObserver observer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private MatcherObserver()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x791DD10", Offset = "0x791C910", VA = "0x18791DD10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x791DD70", Offset = "0x791C970", VA = "0x18791DD70")]
		public int GetNextTimestamp()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x791DE20", Offset = "0x791CA20", VA = "0x18791DE20")]
		public void OnMatch(Match match)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x791DFC0", Offset = "0x791CBC0", VA = "0x18791DFC0")]
		public bool TryGetLastMatch([Out] Match match)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class MatchExpression : Expression
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly Match Match;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal sealed class MethodCall : SetupWithOutParameterSupport
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class <get_InnerMocks>d__14 : IEnumerable<Mock>, IEnumerable, IEnumerator<Mock>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private Mock <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public MethodCall <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			Mock IEnumerator<Mock>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000173")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <get_InnerMocks>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x792D030", Offset = "0x792BC30", VA = "0x18792D030", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x792D1D0", Offset = "0x792BDD0", VA = "0x18792D1D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x792D130", Offset = "0x792BD30", VA = "0x18792D130", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Mock> IEnumerable<Mock>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x792D130", Offset = "0x792BD30", VA = "0x18792D130", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private LimitInvocationCount limitInvocationCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Behavior callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private Behavior raiseEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private Behavior returnOrThrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private Behavior afterReturnCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private Condition condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private string failMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private string declarationSite;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string FailMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xB13280", Offset = "0xB11E80", VA = "0x180B13280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Condition Condition
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xB14930", Offset = "0xB13530", VA = "0x180B14930", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override IEnumerable<Mock> InnerMocks
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x791F2E0", Offset = "0x791DEE0", VA = "0x18791F2E0", Slot = "6")]
			[IteratorStateMachine(typeof(<get_InnerMocks>d__14))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x791F250", Offset = "0x791DE50", VA = "0x18791F250")]
		public MethodCall(Expression originalExpression, Mock mock, Condition condition, MethodExpectation expectation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x791E260", Offset = "0x791CE60", VA = "0x18791E260")]
		private static string GetUserCodeCallSite()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x791E060", Offset = "0x791CC60", VA = "0x18791E060", Slot = "10")]
		protected override void ExecuteCore(Invocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x791EB20", Offset = "0x791D720", VA = "0x18791EB20")]
		public void SetReturnValueBehavior(object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x791E690", Offset = "0x791D290", VA = "0x18791E690")]
		public void SetReturnComputedValueBehavior(Delegate valueFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x791EB90", Offset = "0x791D790", VA = "0x18791EB90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x791F030", Offset = "0x791DC30", VA = "0x18791F030")]
		private void ValidateNumberOfCallbackParameters(Delegate callback, MethodInfo callbackMethod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x791EE00", Offset = "0x791DA00", VA = "0x18791EE00")]
		private void ValidateCallbackReturnType(MethodInfo callbackMethod, Type expectedReturnType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	internal sealed class MethodExpectation : Expectation
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly Expression[] noArguments;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly IMatcher[] noArgumentMatchers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private LambdaExpression expression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly MethodInfo Method;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly IReadOnlyList<Expression> Arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly IMatcher[] argumentMatchers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private IAwaitableFactory awaitableFactory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private MethodInfo methodImplementation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private Expression[] partiallyEvaluatedArguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly bool exactGenericTypeArguments;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override LambdaExpression Expression
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x791F460", Offset = "0x791E060", VA = "0x18791F460")]
		public static MethodExpectation CreateFrom(Invocation invocation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x79208B0", Offset = "0x791F4B0", VA = "0x1879208B0")]
		public MethodExpectation(LambdaExpression expression, MethodInfo method, [Optional] IReadOnlyList<Expression> arguments, bool exactGenericTypeArguments = false, bool skipMatcherInitialization = false, bool allowNonOverridable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x791F360", Offset = "0x791DF60", VA = "0x18791F360")]
		public void AddResultExpression(Func<Expression, Expression> add, IAwaitableFactory awaitableFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7920040", Offset = "0x791EC40", VA = "0x187920040", Slot = "6")]
		public override bool HasResultExpression([Out] IAwaitableFactory awaitableFactory)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x791FA70", Offset = "0x791E670", VA = "0x18791FA70")]
		public void Deconstruct([Out] LambdaExpression expression, [Out] MethodInfo method, [Out] IReadOnlyList<Expression> arguments)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7920070", Offset = "0x791EC70", VA = "0x187920070", Slot = "8")]
		public override bool IsMatch(Invocation invocation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7920610", Offset = "0x791F210", VA = "0x187920610", Slot = "9")]
		public override void SetupEvaluatedSuccessfully(Invocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7920210", Offset = "0x791EE10", VA = "0x187920210")]
		private bool IsOverride(Invocation invocation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x791FAF0", Offset = "0x791E6F0", VA = "0x18791FAF0", Slot = "7")]
		public override bool Equals(Expectation obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x79203A0", Offset = "0x791EFA0", VA = "0x1879203A0")]
		private static Expression[] PartiallyEvaluateArguments(IReadOnlyList<Expression> arguments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7920010", Offset = "0x791EC10", VA = "0x187920010", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal abstract class MethodSetup : Setup
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MethodInfo Method
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x7920AE0", Offset = "0x791F6E0", VA = "0x187920AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7920A70", Offset = "0x791F670", VA = "0x187920A70")]
		protected MethodSetup(Expression originalExpression, Mock mock, MethodExpectation expectation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum MockBehavior
	{
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Strict = 0,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Loose = 1,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Default = 1
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class MockDefaultValueProvider : LookupOrFallbackDefaultValueProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x79211C0", Offset = "0x791FDC0", VA = "0x1879211C0")]
		internal MockDefaultValueProvider()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7920B50", Offset = "0x791F750", VA = "0x187920B50", Slot = "6")]
		protected override object GetFallbackDefaultValue(Type type, Mock mock)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class MockException : Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly MockExceptionReasons reasons;

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x79214A0", Offset = "0x79200A0", VA = "0x1879214A0")]
		internal static MockException MoreThanOneCall(MethodCall setup, int invocationCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7921280", Offset = "0x791FE80", VA = "0x187921280")]
		internal static MockException MoreThanNCalls(MethodCall setup, int maxInvocationCount, int invocationCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7921660", Offset = "0x7920260", VA = "0x187921660")]
		internal static MockException NoSetup(Invocation invocation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7921820", Offset = "0x7920420", VA = "0x187921820")]
		internal static MockException ReturnValueRequired(Invocation invocation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7921B00", Offset = "0x7920700", VA = "0x187921B00")]
		private MockException(MockExceptionReasons reasons, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x79219E0", Offset = "0x79205E0", VA = "0x1879219E0")]
		protected MockException(SerializationInfo info, StreamingContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x79211D0", Offset = "0x791FDD0", VA = "0x1879211D0", Slot = "12")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[Flags]
	internal enum MockExceptionReasons
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		MoreThanOneCall = 1,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		MoreThanNCalls = 2,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		NoMatchingCalls = 4,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		NoSetup = 8,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		ReturnValueRequired = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		UnmatchedSetup = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		UnverifiedInvocations = 0x40
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class Mock<T> : Mock where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static Type[] inheritedInterfaces;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static int serialNumberCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private T instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private List<Type> additionalInterfaces;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Dictionary<Type, object> configuredDefaultValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private object[] constructorArguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private DefaultValueProvider defaultValueProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private EventHandlerCollection eventHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private InvocationCollection invocations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private SetupCollection setups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MockBehavior behavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool callBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private Switches switches;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override MockBehavior Behavior
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xE1C0C0", Offset = "0xE1ACC0", VA = "0x180E1C0C0", Slot = "6")]
			get
			{
				return default(MockBehavior);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool CallBase
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xDD5500", Offset = "0xDD4100", VA = "0x180DD5500", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x5F380B0", Offset = "0x5F36CB0", VA = "0x185F380B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal override Dictionary<Type, object> ConfiguredDefaultValues
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override DefaultValueProvider DefaultValueProvider
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "15")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x5F38150", Offset = "0x5F36D50", VA = "0x185F38150", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		internal override EventHandlerCollection EventHandlers
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal override List<Type> AdditionalInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal override InvocationCollection MutableInvocations
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		internal override bool IsObjectInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xCAEF50", Offset = "0xCADB50", VA = "0x180CAEF50", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public new virtual T Object
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5F38030", Offset = "0x5F36C30", VA = "0x185F38030", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal override Type MockedType
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4697CE0", Offset = "0x46968E0", VA = "0x184697CE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		internal override SetupCollection MutableSetups
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		internal override Type[] InheritedInterfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x5F37FB0", Offset = "0x5F36BB0", VA = "0x185F37FB0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override Switches Switches
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB6E220", Offset = "0xB6CE20", VA = "0x180B6E220", Slot = "18")]
			get
			{
				return default(Switches);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xF7CAF0", Offset = "0xF7B6F0", VA = "0x180F7CAF0", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5F37810", Offset = "0x5F36410", VA = "0x185F37810")]
		static Mock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5F37F40", Offset = "0x5F36B40", VA = "0x185F37F40")]
		internal Mock(bool skipInitialize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5F37ED0", Offset = "0x5F36AD0", VA = "0x185F37ED0")]
		public Mock()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5F37F90", Offset = "0x5F36B90", VA = "0x185F37F90")]
		public Mock(params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5F37A60", Offset = "0x5F36660", VA = "0x185F37A60")]
		public Mock(MockBehavior behavior)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5F37AD0", Offset = "0x5F366D0", VA = "0x185F37AD0")]
		public Mock(MockBehavior behavior, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5F37350", Offset = "0x5F35F50", VA = "0x185F37350")]
		private static string CreateUniqueDefaultMockName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5F37210", Offset = "0x5F35E10", VA = "0x185F37210")]
		private void CheckParameters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5F37500", Offset = "0x5F36100", VA = "0x185F37500")]
		private void InitializeInstance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F377D0", Offset = "0x5F363D0", VA = "0x185F377D0", Slot = "13")]
		protected override object OnGetObject()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x41B0650", Offset = "0x41AF250", VA = "0x1841B0650", Slot = "20")]
		public override Mock<TInterface> As<TInterface>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x41B0A00", Offset = "0x41AF600", VA = "0x1841B0A00")]
		public ISetup<T, TResult> Setup<TResult>(Expression<Func<T, TResult>> expression)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[AttributeUsage(AttributeTargets.Method, Inherited = true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("This feature has been deprecated in favor of `Match.Create`.")]
	public sealed class MatcherAttribute : Attribute
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	internal readonly struct Pair<T1, T2> : IEquatable<Pair<T1, T2>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public readonly T1 Item1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public readonly T2 Item2;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xCC7910", Offset = "0xCC6510", VA = "0x180CC7910")]
		public Pair(T1 item1, T2 item2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x33DC020", Offset = "0x33DAC20", VA = "0x1833DC020")]
		public void Deconstruct([Out] T1 item1, [Out] T2 item2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x619E3E0", Offset = "0x619CFE0", VA = "0x18619E3E0", Slot = "4")]
		public bool Equals(Pair<T1, T2> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x619E2B0", Offset = "0x619CEB0", VA = "0x18619E2B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x619EC20", Offset = "0x619D820", VA = "0x18619EC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal readonly struct ParameterTypes : IReadOnlyList<Type>, IReadOnlyCollection<Type>, IEnumerable<Type>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__6 : IEnumerator<Type>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private Type <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public ParameterTypes <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private int <i>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private int <n>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			Type IEnumerator<Type>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public <GetEnumerator>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x792B390", Offset = "0x7929F90", VA = "0x18792B390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x792B440", Offset = "0x792A040", VA = "0x18792B440", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly ParameterInfo[] parameters;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Type this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x79229A0", Offset = "0x79215A0", VA = "0x1879229A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x2DD0660", Offset = "0x2DCF260", VA = "0x182DD0660", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public ParameterTypes(ParameterInfo[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7922930", Offset = "0x7921530", VA = "0x187922930", Slot = "6")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__6))]
		public IEnumerator<Type> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7922930", Offset = "0x7921530", VA = "0x187922930", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal abstract class Setup : ISetup
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[Flags]
		private enum Flags : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			Matched = 1,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			Overridden = 2,
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			Verifiable = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Expectation expectation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly Expression originalExpression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly Mock mock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Flags flags;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual Condition Condition
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Expectation Expectation
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public LambdaExpression Expression
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x7925920", Offset = "0x7924520", VA = "0x187925920", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual IEnumerable<Mock> InnerMocks
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7925950", Offset = "0x7924550", VA = "0x187925950", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool IsConditional
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x79259F0", Offset = "0x79245F0", VA = "0x1879259F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool IsOverridden
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x7925A20", Offset = "0x7924620", VA = "0x187925A20", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Mock Mock
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7920A70", Offset = "0x791F670", VA = "0x187920A70")]
		protected Setup(Expression originalExpression, Mock mock, Expectation expectation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7925490", Offset = "0x7924090", VA = "0x187925490")]
		public void Execute(Invocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void ExecuteCore(Invocation invocation);

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7925680", Offset = "0x7924280", VA = "0x187925680")]
		public void MarkAsOverridden()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7925690", Offset = "0x7924290", VA = "0x187925690")]
		public void MarkAsVerifiable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x79256D0", Offset = "0x79242D0", VA = "0x1879256D0")]
		public bool Matches(Invocation invocation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x79256A0", Offset = "0x79242A0", VA = "0x1879256A0")]
		public bool Matches(MethodExpectation expectation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "11")]
		public virtual void SetOutParameters(Invocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7925770", Offset = "0x7924370", VA = "0x187925770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x79258C0", Offset = "0x79244C0", VA = "0x1879258C0")]
		protected static Mock TryGetInnerMockFrom(object returnValue)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal sealed class SetupCollection : IReadOnlyList<ISetup>, IReadOnlyCollection<ISetup>, IEnumerable<ISetup>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private List<Setup> setups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HashSet<Expectation> activeSetups;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x7924DC0", Offset = "0x79239C0", VA = "0x187924DC0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ISetup this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x7924E90", Offset = "0x7923A90", VA = "0x187924E90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7924D00", Offset = "0x7923900", VA = "0x187924D00")]
		public SetupCollection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7924680", Offset = "0x7923280", VA = "0x187924680")]
		public void Add(Setup setup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7924BD0", Offset = "0x79237D0", VA = "0x187924BD0")]
		private void MarkOverriddenSetups()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7924920", Offset = "0x7923520", VA = "0x187924920")]
		public Setup FindLast(Func<Setup, bool> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7924AD0", Offset = "0x79236D0", VA = "0x187924AD0", Slot = "6")]
		public IEnumerator<ISetup> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7924CF0", Offset = "0x79238F0", VA = "0x187924CF0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal abstract class SetupWithOutParameterSupport : MethodSetup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly List<KeyValuePair<int, object>> outValues;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x79253D0", Offset = "0x7923FD0", VA = "0x1879253D0")]
		protected SetupWithOutParameterSupport(Expression originalExpression, Mock mock, MethodExpectation expectation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7925230", Offset = "0x7923E30", VA = "0x187925230", Slot = "11")]
		public sealed override void SetOutParameters(Invocation invocation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7924FD0", Offset = "0x7923BD0", VA = "0x187924FD0")]
		private static List<KeyValuePair<int, object>> GetOutValues(IReadOnlyList<Expression> arguments, ParameterInfo[] parameters)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal static class StringBuilderExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7926110", Offset = "0x7924D10", VA = "0x187926110")]
		public static StringBuilder AppendExpression(this StringBuilder builder, Expression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7925A30", Offset = "0x7924630", VA = "0x187925A30")]
		private static StringBuilder AppendElementInit(this StringBuilder builder, ElementInit initializer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7926EF0", Offset = "0x7925AF0", VA = "0x187926EF0")]
		private static StringBuilder AppendExpression(this StringBuilder builder, UnaryExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x7925CF0", Offset = "0x79248F0", VA = "0x187925CF0")]
		private static StringBuilder AppendExpression(this StringBuilder builder, BinaryExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7926D10", Offset = "0x7925910", VA = "0x187926D10")]
		private static StringBuilder AppendExpression(this StringBuilder builder, TypeBinaryExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7925B00", Offset = "0x7924700", VA = "0x187925B00")]
		private static StringBuilder AppendExpression(this StringBuilder builder, ConditionalExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7926E80", Offset = "0x7925A80", VA = "0x187926E80")]
		private static StringBuilder AppendExpression(this StringBuilder builder, ParameterExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7927A60", Offset = "0x7926660", VA = "0x187927A60")]
		private static StringBuilder AppendExpression(this StringBuilder builder, MemberExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7927320", Offset = "0x7925F20", VA = "0x187927320")]
		private static StringBuilder AppendExpression(this StringBuilder builder, MethodCallExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7926D90", Offset = "0x7925990", VA = "0x187926D90")]
		private static StringBuilder AppendExpression(this StringBuilder builder, IndexExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7927150", Offset = "0x7925D50", VA = "0x187927150")]
		private static StringBuilder AppendExpression(this StringBuilder builder, LambdaExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7927C50", Offset = "0x7926850", VA = "0x187927C50")]
		private static StringBuilder AppendExpression(this StringBuilder builder, NewExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7925F20", Offset = "0x7924B20", VA = "0x187925F20")]
		private static StringBuilder AppendExpression(this StringBuilder builder, NewArrayExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7925E30", Offset = "0x7924A30", VA = "0x187925E30")]
		private static StringBuilder AppendExpression(this StringBuilder builder, InvocationExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7925BC0", Offset = "0x79247C0", VA = "0x187925BC0")]
		private static StringBuilder AppendExpression(this StringBuilder builder, MemberInitExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7927DE0", Offset = "0x79269E0", VA = "0x187927DE0")]
		private static StringBuilder AppendExpression(this StringBuilder builder, ListInitExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7927ED0", Offset = "0x7926AD0", VA = "0x187927ED0")]
		private static StringBuilder AppendExpression(this StringBuilder builder, MatchExpression expression)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x79285A0", Offset = "0x79271A0", VA = "0x1879285A0")]
		public static StringBuilder Append(this StringBuilder stringBuilder, string str, int startIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4010510", Offset = "0x400F110", VA = "0x184010510")]
		public static StringBuilder AppendCommaSeparated<T>(this StringBuilder stringBuilder, string prefix, IEnumerable<T> source, Func<StringBuilder, T, StringBuilder> append, string suffix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x40105B0", Offset = "0x400F1B0", VA = "0x1840105B0")]
		public static StringBuilder AppendCommaSeparated<T>(this StringBuilder stringBuilder, IEnumerable<T> source, Func<StringBuilder, T, StringBuilder> append)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7927F00", Offset = "0x7926B00", VA = "0x187927F00")]
		public static StringBuilder AppendNameOf(this StringBuilder stringBuilder, MethodBase method, bool includeGenericArgumentList)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x7928040", Offset = "0x7926C40", VA = "0x187928040")]
		public static StringBuilder AppendNameOf(this StringBuilder stringBuilder, Type type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x79280E0", Offset = "0x7926CE0", VA = "0x1879280E0")]
		public static StringBuilder AppendValueOf(this StringBuilder stringBuilder, object obj)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal sealed class StubbedPropertiesSetup : Setup
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		private sealed class PropertyAccessorExpectation : Expectation
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private readonly LambdaExpression expression;

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public override LambdaExpression Expression
			{
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x7922B50", Offset = "0x7921750", VA = "0x187922B50")]
			public PropertyAccessorExpectation(Mock mock)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x79229F0", Offset = "0x79215F0", VA = "0x1879229F0", Slot = "7")]
			public override bool Equals(Expectation other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x7922AB0", Offset = "0x79216B0", VA = "0x187922AB0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7922B20", Offset = "0x7921720", VA = "0x187922B20", Slot = "8")]
			public override bool IsMatch(Invocation invocation)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class <get_InnerMocks>d__6 : IEnumerable<Mock>, IEnumerable, IEnumerator<Mock>, IDisposable, IEnumerator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Mock <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public StubbedPropertiesSetup <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<object> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			Mock IEnumerator<Mock>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600020D")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public <get_InnerMocks>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x792D710", Offset = "0x792C310", VA = "0x18792D710", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x792D3B0", Offset = "0x792BFB0", VA = "0x18792D3B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x792D7A0", Offset = "0x792C3A0", VA = "0x18792D7A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x792D6D0", Offset = "0x792C2D0", VA = "0x18792D6D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x792D630", Offset = "0x792C230", VA = "0x18792D630", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Mock> IEnumerable<Mock>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x792D630", Offset = "0x792C230", VA = "0x18792D630", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly ConcurrentDictionary<string, object> values;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly DefaultValueProvider defaultValueProvider;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public DefaultValueProvider DefaultValueProvider
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override IEnumerable<Mock> InnerMocks
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x7928E40", Offset = "0x7927A40", VA = "0x187928E40", Slot = "6")]
			[IteratorStateMachine(typeof(<get_InnerMocks>d__6))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7928D10", Offset = "0x7927910", VA = "0x187928D10")]
		public StubbedPropertiesSetup(Mock mock, [Optional] DefaultValueProvider defaultValueProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7928CA0", Offset = "0x79278A0", VA = "0x187928CA0")]
		public void SetProperty(string propertyName, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7928A40", Offset = "0x7927640", VA = "0x187928A40", Slot = "10")]
		protected override void ExecuteCore(Invocation invocation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[Flags]
	public enum Switches
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		CollectDiagnosticFileInfoForSetups = 1
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public readonly struct Times : IEquatable<Times>
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		private enum Kind
		{
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			AtLeastOnce,
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			AtLeast,
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			AtMost,
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			AtMostOnce,
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			BetweenExclusive,
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			BetweenInclusive,
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			Exactly,
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			Once,
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			Never
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly int from;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly int to;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly Kind kind;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7929C20", Offset = "0x7928820", VA = "0x187929C20")]
		private Times(Kind kind, int from, int to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x79292E0", Offset = "0x7927EE0", VA = "0x1879292E0")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public void Deconstruct([Out] int from, [Out] int to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7929260", Offset = "0x7927E60", VA = "0x187929260")]
		public static Times AtMost(int callCount)
		{
			return default(Times);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7929240", Offset = "0x7927E40", VA = "0x187929240")]
		public static Times AtMostOnce()
		{
			return default(Times);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7929300", Offset = "0x7927F00", VA = "0x187929300", Slot = "4")]
		public bool Equals(Times other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7929370", Offset = "0x7927F70", VA = "0x187929370", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7929920", Offset = "0x7928520", VA = "0x187929920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7929980", Offset = "0x7928580", VA = "0x187929980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7929460", Offset = "0x7928060", VA = "0x187929460")]
		internal string GetExceptionMessage(int callCount)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = true)]
	public class TypeMatcherAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Type type;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		internal Type Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}
	}
}
namespace Moq.Properties
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static ResourceManager resourceMan;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static CultureInfo resourceCulture;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x7923E60", Offset = "0x7922A60", VA = "0x187923E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		internal static string AlreadyInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x79230E0", Offset = "0x7921CE0", VA = "0x1879230E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		internal static string ArgumentMatcherWillNeverMatch
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7923160", Offset = "0x7921D60", VA = "0x187923160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		internal static string AsMustBeInterface
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x79231E0", Offset = "0x7921DE0", VA = "0x1879231E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		internal static string CallBaseCannotBeUsedWithDelegateMocks
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7923260", Offset = "0x7921E60", VA = "0x187923260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		internal static string ConstructorArgsForDelegate
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x79232E0", Offset = "0x7921EE0", VA = "0x1879232E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		internal static string ConstructorArgsForInterface
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x7923360", Offset = "0x7921F60", VA = "0x187923360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		internal static string ConstructorNotFound
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x79233E0", Offset = "0x7921FE0", VA = "0x1879233E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		internal static string InvalidCallbackParameterCountMismatch
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7923460", Offset = "0x7922060", VA = "0x187923460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		internal static string InvalidCallbackReturnTypeMismatch
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x79234E0", Offset = "0x79220E0", VA = "0x1879234E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		internal static string InvalidMockGetType
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x7923560", Offset = "0x7922160", VA = "0x187923560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		internal static string InvalidReturnsCallbackNotADelegateWithReturnType
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x79235E0", Offset = "0x79221E0", VA = "0x1879235E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		internal static string MethodNotVisibleToProxyFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x7923660", Offset = "0x7922260", VA = "0x187923660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		internal static string MockExceptionMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x79236E0", Offset = "0x79222E0", VA = "0x1879236E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		internal static string NoMatchingCallsAtLeast
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x79237E0", Offset = "0x79223E0", VA = "0x1879237E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		internal static string NoMatchingCallsAtLeastOnce
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7923760", Offset = "0x7922360", VA = "0x187923760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		internal static string NoMatchingCallsAtMost
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x79238E0", Offset = "0x79224E0", VA = "0x1879238E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		internal static string NoMatchingCallsAtMostOnce
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7923860", Offset = "0x7922460", VA = "0x187923860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		internal static string NoMatchingCallsBetweenExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7923960", Offset = "0x7922560", VA = "0x187923960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		internal static string NoMatchingCallsBetweenInclusive
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x79239E0", Offset = "0x79225E0", VA = "0x1879239E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		internal static string NoMatchingCallsExactly
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7923A60", Offset = "0x7922660", VA = "0x187923A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		internal static string NoMatchingCallsNever
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7923AE0", Offset = "0x79226E0", VA = "0x187923AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		internal static string NoMatchingCallsOnce
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7923B60", Offset = "0x7922760", VA = "0x187923B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		internal static string NoSetup
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7923BE0", Offset = "0x79227E0", VA = "0x187923BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		internal static string ObjectInstanceNotMock
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x7923C60", Offset = "0x7922860", VA = "0x187923C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		internal static string OutExpressionMustBeConstantValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x7923CE0", Offset = "0x79228E0", VA = "0x187923CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		internal static string PropertyGetNotFound
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x7923D60", Offset = "0x7922960", VA = "0x187923D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		internal static string RefExpressionMustBeConstantValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x7923DE0", Offset = "0x79229E0", VA = "0x187923DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		internal static string ReturnValueRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7923F80", Offset = "0x7922B80", VA = "0x187923F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		internal static string SetupNotProperty
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7924000", Offset = "0x7922C00", VA = "0x187924000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		internal static string TypeHasNoDefaultConstructor
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7924080", Offset = "0x7922C80", VA = "0x187924080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		internal static string TypeMatchersMayNotBeUsedWithCallbacks
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7924100", Offset = "0x7922D00", VA = "0x187924100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		internal static string TypeNotImplementInterface
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7924180", Offset = "0x7922D80", VA = "0x187924180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		internal static string TypeNotMockable
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x7924200", Offset = "0x7922E00", VA = "0x187924200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		internal static string UnhandledBindingType
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x7924280", Offset = "0x7922E80", VA = "0x187924280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		internal static string UnhandledExpressionType
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x7924300", Offset = "0x7922F00", VA = "0x187924300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		internal static string UnsupportedExpression
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7924400", Offset = "0x7923000", VA = "0x187924400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		internal static string UnsupportedExpressionWithHint
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x7924380", Offset = "0x7922F80", VA = "0x187924380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		internal static string UnsupportedExtensionMethod
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7924480", Offset = "0x7923080", VA = "0x187924480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		internal static string UnsupportedNonOverridableMember
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7924500", Offset = "0x7923100", VA = "0x187924500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		internal static string UnsupportedStaticMember
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7924580", Offset = "0x7923180", VA = "0x187924580")]
			get
			{
				return null;
			}
		}
	}
}
namespace Moq.Matchers
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal sealed class AnyMatcher : IMatcher
	{
		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public static AnyMatcher Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x790F020", Offset = "0x790DC20", VA = "0x18790F020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private AnyMatcher()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "4")]
		public bool Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void SetupEvaluatedSuccessfully(object argument, Type parameterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal class ConstantMatcher : IMatcher
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private object constantValue;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public ConstantMatcher(object constantValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x790F940", Offset = "0x790E540", VA = "0x18790F940", Slot = "4")]
		public bool Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void SetupEvaluatedSuccessfully(object argument, Type parameterType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x790F880", Offset = "0x790E480", VA = "0x18790F880")]
		private bool MatchesEnumerable(IEnumerable enumerable)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal class ExpressionMatcher : IMatcher
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private Expression expression;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public ExpressionMatcher(Expression expression)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7916000", Offset = "0x7914C00", VA = "0x187916000", Slot = "4")]
		public bool Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void SetupEvaluatedSuccessfully(object argument, Type parameterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal class LazyEvalMatcher : IMatcher
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Expression expression;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public LazyEvalMatcher(Expression expression)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x791AD70", Offset = "0x7919970", VA = "0x18791AD70", Slot = "4")]
		public bool Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void SetupEvaluatedSuccessfully(object argument, Type parameterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal class MatcherAttributeMatcher : IMatcher
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private MethodInfo validatorMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private MethodCallExpression expression;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x791C870", Offset = "0x791B470", VA = "0x18791C870")]
		public MatcherAttributeMatcher(MethodCallExpression expression)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x791C010", Offset = "0x791AC10", VA = "0x18791C010")]
		private static MethodInfo ResolveValidatorMethod(MethodCallExpression call)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x791BD20", Offset = "0x791A920", VA = "0x18791BD20", Slot = "4")]
		public bool Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void SetupEvaluatedSuccessfully(object argument, Type parameterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal class ParamArrayMatcher : IMatcher
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private IMatcher[] matchers;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public ParamArrayMatcher(IMatcher[] matchers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7922610", Offset = "0x7921210", VA = "0x187922610", Slot = "4")]
		public bool Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7922770", Offset = "0x7921370", VA = "0x187922770", Slot = "5")]
		public void SetupEvaluatedSuccessfully(object argument, Type parameterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal class RefMatcher : IMatcher
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly object reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly bool referenceIsValueType;

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7923070", Offset = "0x7921C70", VA = "0x187923070")]
		public RefMatcher(object reference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7923050", Offset = "0x7921C50", VA = "0x187923050", Slot = "4")]
		public bool Matches(object argument, Type parameterType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void SetupEvaluatedSuccessfully(object value, Type parameterType)
		{
		}
	}
}
namespace Moq.Language
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IReturns<TMock, TResult> where TMock : class
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReturnsResult<TMock> Returns(Func<TResult> valueFunction);
	}
}
namespace Moq.Language.Flow
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IReturnsResult<TMock>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface ISetup<TMock, TResult> : IReturns<TMock, TResult> where TMock : class
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	internal class NonVoidSetupPhrase<T, TResult> : SetupPhrase, ISetup<T, TResult>, IReturns<T, TResult>, IReturnsResult<T> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6060B70", Offset = "0x605F770", VA = "0x186060B70")]
		public NonVoidSetupPhrase(MethodCall setup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6060B40", Offset = "0x605F740", VA = "0x186060B40", Slot = "4")]
		public IReturnsResult<T> Returns(Func<TResult> valueExpression)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal abstract class SetupPhrase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private MethodCall setup;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public MethodCall Setup
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		protected SetupPhrase(MethodCall setup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7924F90", Offset = "0x7923B90", VA = "0x187924F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Moq.Internals
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class InterfaceProxy
	{
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static MethodInfo equalsMethod;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static MethodInfo getHashCodeMethod;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static MethodInfo toStringMethod;
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public interface IProxy
	{
		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		object Interceptor
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
}
namespace Moq.Expressions.Visitors
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal sealed class EvaluateCaptures : ExpressionVisitor
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public static readonly ExpressionVisitor Rewriter;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		private EvaluateCaptures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7910530", Offset = "0x790F130", VA = "0x187910530", Slot = "17")]
		protected override Expression VisitMember(MemberExpression node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7910740", Offset = "0x790F340", VA = "0x187910740", Slot = "25")]
		protected override Expression VisitUnary(UnaryExpression node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	internal sealed class UpgradePropertyAccessorMethods : ExpressionVisitor
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly ExpressionVisitor Rewriter;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		private UpgradePropertyAccessorMethods()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x792D7F0", Offset = "0x792C3F0", VA = "0x18792D7F0", Slot = "19")]
		protected override Expression VisitMethodCall(MethodCallExpression node)
		{
			return null;
		}
	}
}
namespace Moq.Behaviors
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	internal sealed class LimitInvocationCount : Behavior
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly MethodCall setup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly int maxCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private int count;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x792E5C0", Offset = "0x792D1C0", VA = "0x18792E5C0", Slot = "4")]
		public override void Execute(Invocation invocation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	internal sealed class ReturnBaseOrDefaultValue : Behavior
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly Mock mock;

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
		public ReturnBaseOrDefaultValue(Mock mock)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x792E640", Offset = "0x792D240", VA = "0x18792E640", Slot = "4")]
		public override void Execute(Invocation invocation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	internal sealed class ReturnComputedValue : Behavior
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly Func<IInvocation, object> valueFactory;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
		public ReturnComputedValue(Func<IInvocation, object> valueFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x792E940", Offset = "0x792D540", VA = "0x18792E940", Slot = "4")]
		public override void Execute(Invocation invocation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	internal sealed class ReturnValue : Behavior
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly object value;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public object Value
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
		public ReturnValue(object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x792E980", Offset = "0x792D580", VA = "0x18792E980", Slot = "4")]
		public override void Execute(Invocation invocation)
		{
		}
	}
}
namespace Moq.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	internal static class Awaitable
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x792E3B0", Offset = "0x792CFB0", VA = "0x18792E3B0")]
		public static object TryGetResultRecursive(object obj)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	internal static class AwaitableFactory
	{
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static readonly Dictionary<Type, Func<Type, IAwaitableFactory>> Providers;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x792E0D0", Offset = "0x792CCD0", VA = "0x18792E0D0")]
		static AwaitableFactory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x792DF20", Offset = "0x792CB20", VA = "0x18792DF20")]
		private static IAwaitableFactory Create(Type awaitableFactoryType, Type awaitableType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x792DFD0", Offset = "0x792CBD0", VA = "0x18792DFD0")]
		public static IAwaitableFactory TryGet(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	internal abstract class AwaitableFactory<TAwaitable> : IAwaitableFactory
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		Type IAwaitableFactory.ResultType
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x76DC200", Offset = "0x76DAE00", VA = "0x1876DC200", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract TAwaitable CreateCompleted();

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5679630", Offset = "0x5678230", VA = "0x185679630", Slot = "5")]
		object IAwaitableFactory.CreateCompleted(object result)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract TAwaitable CreateFaulted(Exception exception);

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x76DC130", Offset = "0x76DAD30", VA = "0x1876DC130", Slot = "6")]
		object IAwaitableFactory.CreateFaulted(Exception exception)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xFF2990", Offset = "0xFF1590", VA = "0x180FF2990", Slot = "7")]
		bool IAwaitableFactory.TryGetResult(object awaitable, [Out] object result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected AwaitableFactory()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	internal abstract class AwaitableFactory<TAwaitable, TResult>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	internal interface IAwaitableFactory
	{
		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		Type ResultType
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		object CreateCompleted([Optional] object result);

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		object CreateFaulted(Exception exception);

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool TryGetResult(object awaitable, [Out] object result);
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	internal sealed class TaskFactory : AwaitableFactory<Task>
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public static readonly TaskFactory Instance;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x792EB40", Offset = "0x792D740", VA = "0x18792EB40")]
		private TaskFactory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x792E9B0", Offset = "0x792D5B0", VA = "0x18792E9B0", Slot = "8")]
		public override Task CreateCompleted()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x792EA10", Offset = "0x792D610", VA = "0x18792EA10", Slot = "9")]
		public override Task CreateFaulted(Exception exception)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	internal sealed class TaskFactory<TResult> : AwaitableFactory<Task<TResult>, TResult>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	internal sealed class ValueTaskFactory : AwaitableFactory<ValueTask>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly ValueTaskFactory Instance;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x792F040", Offset = "0x792DC40", VA = "0x18792F040")]
		private ValueTaskFactory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x11C8B60", Offset = "0x11C7760", VA = "0x1811C8B60", Slot = "8")]
		public override ValueTask CreateCompleted()
		{
			return default(ValueTask);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x792EED0", Offset = "0x792DAD0", VA = "0x18792EED0", Slot = "9")]
		public override ValueTask CreateFaulted(Exception exception)
		{
			return default(ValueTask);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	internal sealed class ValueTaskFactory<TResult> : AwaitableFactory<ValueTask<TResult>, TResult>
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

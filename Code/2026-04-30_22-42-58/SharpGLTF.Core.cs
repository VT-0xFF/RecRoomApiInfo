using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using SharpGLTF.Animations;
using SharpGLTF.Collections;
using SharpGLTF.Diagnostics;
using SharpGLTF.IO;
using SharpGLTF.Memory;
using SharpGLTF.Reflection;
using SharpGLTF.Schema2;
using SharpGLTF.Transforms;
using SharpGLTF.Validation;

[assembly: AssemblyVersion("1.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public IsReadOnlyAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace SharpGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DebuggerStepThrough]
	internal static class Guard
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly IReadOnlyList<char> _InvalidRelativePathChars;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA45F760", Offset = "0xA45EB60", VA = "0x18A45F760")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA45E740", Offset = "0xA45DB40", VA = "0x18A45E740")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA45E9B0", Offset = "0xA45DDB0", VA = "0x18A45E9B0")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA45EC00", Offset = "0xA45E000", VA = "0x18A45EC00")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA45E6A0", Offset = "0xA45DAA0", VA = "0x18A45E6A0")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA45F3E0", Offset = "0xA45E7E0", VA = "0x18A45F3E0")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA45F2C0", Offset = "0xA45E6C0", VA = "0x18A45F2C0")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA45F8B0", Offset = "0xA45ECB0", VA = "0x18A45F8B0")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA45F850", Offset = "0xA45EC50", VA = "0x18A45F850")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA45F100", Offset = "0xA45E500", VA = "0x18A45F100")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC290", Offset = "0x3ACB690", VA = "0x183ACC290")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3ACACE0", Offset = "0x3ACA0E0", VA = "0x183ACACE0")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA45F160", Offset = "0xA45E560", VA = "0x18A45F160")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBD20", Offset = "0x3ACB120", VA = "0x183ACBD20")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBC30", Offset = "0x3ACB030", VA = "0x183ACBC30")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB490", Offset = "0x3ACA890", VA = "0x183ACB490")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB290", Offset = "0x3ACA690", VA = "0x183ACB290")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3AC74A0", Offset = "0x3AC68A0", VA = "0x183AC74A0")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA45ED00", Offset = "0xA45E100", VA = "0x18A45ED00")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA45ECA0", Offset = "0xA45E0A0", VA = "0x18A45ECA0")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA45ED60", Offset = "0xA45E160", VA = "0x18A45ED60")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA45F500", Offset = "0xA45E900", VA = "0x18A45F500")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA45F660", Offset = "0xA45EA60", VA = "0x18A45F660")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3ACA010", Offset = "0x3AC9410", VA = "0x183ACA010")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA45E410", Offset = "0xA45D810", VA = "0x18A45E410")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9650", Offset = "0x3AC8A50", VA = "0x183AC9650")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AC92A0", Offset = "0x3AC86A0", VA = "0x183AC92A0")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AC92A0", Offset = "0x3AC86A0", VA = "0x183AC92A0")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AC92A0", Offset = "0x3AC86A0", VA = "0x183AC92A0")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AC92A0", Offset = "0x3AC86A0", VA = "0x183AC92A0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8720", Offset = "0x3AC7B20", VA = "0x183AC8720")]
		public static void MustBeBetweenOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class _Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct _ListSelect<TSource, TResult> : IReadOnlyList<TResult>, IEnumerable<TResult>, IEnumerable, IReadOnlyCollection<TResult>
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__7 : IEnumerator<TResult>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				private TResult <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public _ListSelect<TSource, TResult> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000D")]
				private IEnumerator<TSource> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				TResult IEnumerator<TResult>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600007C")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return (TResult)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600007E")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x668D4C0", Offset = "0x668C8C0", VA = "0x18668D4C0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6688910", Offset = "0x6687D10", VA = "0x186688910", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x668D920", Offset = "0x668CD20", VA = "0x18668D920")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class <System-Collections-IEnumerable-GetEnumerator>d__8 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				private object <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000010")]
				public _ListSelect<TSource, TResult> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				private IEnumerator<TSource> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				object IEnumerator<object>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000083")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000085")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6EF5150", Offset = "0x6EF4550", VA = "0x186EF5150", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6EF0C60", Offset = "0x6EF0060", VA = "0x186EF0C60", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x6EF5620", Offset = "0x6EF4A20", VA = "0x186EF5620")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			private readonly IReadOnlyList<TSource> _List;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<TSource, TResult> _Selector;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public TResult this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x513ED40", Offset = "0x513E140", VA = "0x18513ED40", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x513EB10", Offset = "0x513DF10", VA = "0x18513EB10", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x513E7C0", Offset = "0x513DBC0", VA = "0x18513E7C0", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x513EA60", Offset = "0x513DE60", VA = "0x18513EA60", Slot = "7")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<System-Collections-IEnumerable-GetEnumerator>d__8))]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private readonly struct _CollectionSelect<TSource, TResult> : IReadOnlyCollection<TResult>, IEnumerable<TResult>, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__5 : IEnumerator<TResult>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				private TResult <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public _CollectionSelect<TSource, TResult> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				private IEnumerator<TSource> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				TResult IEnumerator<TResult>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0x662DCD0", Offset = "0x662D0D0", VA = "0x18662DCD0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return (TResult)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0x6631080", Offset = "0x6630480", VA = "0x186631080", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x4E974F0", Offset = "0x4E968F0", VA = "0x184E974F0")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x6688050", Offset = "0x6687450", VA = "0x186688050", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x66865D0", Offset = "0x66859D0", VA = "0x1866865D0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6688720", Offset = "0x6687B20", VA = "0x186688720")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class <System-Collections-IEnumerable-GetEnumerator>d__6 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				private object <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public _CollectionSelect<TSource, TResult> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				private IEnumerator<TSource> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				object IEnumerator<object>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6EEBE40", Offset = "0x6EEB240", VA = "0x186EEBE40", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6EEB2B0", Offset = "0x6EEA6B0", VA = "0x186EEB2B0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6EEC3A0", Offset = "0x6EEB7A0", VA = "0x186EEC3A0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			private readonly IReadOnlyCollection<TSource> _List;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<TSource, TResult> _Selector;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x5135CE0", Offset = "0x51350E0", VA = "0x185135CE0", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5135A40", Offset = "0x5134E40", VA = "0x185135A40", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5135C10", Offset = "0x5135010", VA = "0x185135C10", Slot = "6")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<System-Collections-IEnumerable-GetEnumerator>d__6))]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class <GetLinesIndices>d__66 : IEnumerable<(int, int)>, IEnumerable, IEnumerator<(int, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private (int A, int B) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private PrimitiveType ptype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public PrimitiveType <>3__ptype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private IEnumerable<uint> sourceIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public IEnumerable<uint> <>3__sourceIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private IEnumerator<uint> <ptr>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			(int, int) IEnumerator<(int, int)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x13F81B0", Offset = "0x13F75B0", VA = "0x1813F81B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0xA46DA70", Offset = "0xA46CE70", VA = "0x18A46DA70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x64B5AB0", Offset = "0x64B4EB0", VA = "0x1864B5AB0")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA46DAC0", Offset = "0xA46CEC0", VA = "0x18A46DAC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA46D720", Offset = "0xA46CB20", VA = "0x18A46D720", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA46DB80", Offset = "0xA46CF80", VA = "0x18A46DB80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA46DA30", Offset = "0xA46CE30", VA = "0x18A46DA30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA46D980", Offset = "0xA46CD80", VA = "0x18A46D980", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA46D980", Offset = "0xA46CD80", VA = "0x18A46D980", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class <GetTrianglesIndices>d__67 : IEnumerable<(int, int, int)>, IEnumerable, IEnumerator<(int, int, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private (int A, int B, int C) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private PrimitiveType ptype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public PrimitiveType <>3__ptype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private IEnumerable<uint> sourceIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public IEnumerable<uint> <>3__sourceIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private IEnumerator<uint> <ptr>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private uint <a>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private uint <c>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private bool <reversed>5__5;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			(int, int, int) IEnumerator<(int, int, int)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x1A14640", Offset = "0x1A13A40", VA = "0x181A14640", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0xA46E560", Offset = "0xA46D960", VA = "0x18A46E560", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA46E5B0", Offset = "0xA46D9B0", VA = "0x18A46E5B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA46DBD0", Offset = "0xA46CFD0", VA = "0x18A46DBD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA46E7A0", Offset = "0xA46DBA0", VA = "0x18A46E7A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA46E7F0", Offset = "0xA46DBF0", VA = "0x18A46E7F0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA46E840", Offset = "0xA46DC40", VA = "0x18A46E840")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA46E520", Offset = "0xA46D920", VA = "0x18A46E520", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA46E470", Offset = "0xA46D870", VA = "0x18A46E470", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA46E470", Offset = "0xA46D870", VA = "0x18A46E470", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float _UnitLengthThresholdVec3 = 0.00674f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float _UnitLengthThresholdVec4 = 0.00769f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float _UnitSumThresholdStep = 0.0039216f;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA472700", Offset = "0xA471B00", VA = "0x18A472700")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA474100", Offset = "0xA473500", VA = "0x18A474100")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA474230", Offset = "0xA473630", VA = "0x18A474230")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA474140", Offset = "0xA473540", VA = "0x18A474140")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA474260", Offset = "0xA473660", VA = "0x18A474260")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA4741A0", Offset = "0xA4735A0", VA = "0x18A4741A0")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA4742D0", Offset = "0xA4736D0", VA = "0x18A4742D0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA4741A0", Offset = "0xA4735A0", VA = "0x18A4741A0")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA474030", Offset = "0xA473430", VA = "0x18A474030")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA472830", Offset = "0xA471C30", VA = "0x18A472830")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA472710", Offset = "0xA471B10", VA = "0x18A472710")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA471AA0", Offset = "0xA470EA0", VA = "0x18A471AA0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA4731D0", Offset = "0xA4725D0", VA = "0x18A4731D0")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA4726B0", Offset = "0xA471AB0", VA = "0x18A4726B0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA472650", Offset = "0xA471A50", VA = "0x18A472650")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA472930", Offset = "0xA471D30", VA = "0x18A472930")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA473CB0", Offset = "0xA4730B0", VA = "0x18A473CB0")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA473E30", Offset = "0xA473230", VA = "0x18A473E30")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA472B10", Offset = "0xA471F10", VA = "0x18A472B10")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA472A20", Offset = "0xA471E20", VA = "0x18A472A20")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA472DF0", Offset = "0xA4721F0", VA = "0x18A472DF0")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA4724C0", Offset = "0xA4718C0", VA = "0x18A4724C0")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA4637E0", Offset = "0xA462BE0", VA = "0x18A4637E0")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA473230", Offset = "0xA472630", VA = "0x18A473230")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA472AA0", Offset = "0xA471EA0", VA = "0x18A472AA0")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA472420", Offset = "0xA471820", VA = "0x18A472420")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA472360", Offset = "0xA471760", VA = "0x18A472360")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41469B0", Offset = "0x4145DB0", VA = "0x1841469B0")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA471C10", Offset = "0xA471010", VA = "0x18A471C10")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA471D80", Offset = "0xA471180", VA = "0x18A471D80")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4147D50", Offset = "0x4147150", VA = "0x184147D50")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4148E80", Offset = "0x4148280", VA = "0x184148E80")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4148FB0", Offset = "0x41483B0", VA = "0x184148FB0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4148F00", Offset = "0x4148300", VA = "0x184148F00")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x41469D0", Offset = "0x4145DD0", VA = "0x1841469D0")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4147B90", Offset = "0x4146F90", VA = "0x184147B90")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4147A80", Offset = "0x4146E80", VA = "0x184147A80")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4147850", Offset = "0x4146C50", VA = "0x184147850")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4148DA0", Offset = "0x41481A0", VA = "0x184148DA0")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4148710", Offset = "0x4147B10", VA = "0x184148710")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4148CB0", Offset = "0x41480B0", VA = "0x184148CB0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x41488B0", Offset = "0x4147CB0", VA = "0x1841488B0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4147070", Offset = "0x4146470", VA = "0x184147070")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4146E20", Offset = "0x4146220", VA = "0x184146E20")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4146630", Offset = "0x4145A30", VA = "0x184146630")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4146A60", Offset = "0x4145E60", VA = "0x184146A60")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA472BE0", Offset = "0xA471FE0", VA = "0x18A472BE0")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA472F50", Offset = "0xA472350", VA = "0x18A472F50")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4148E00", Offset = "0x4148200", VA = "0x184148E00")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4148E00", Offset = "0x4148200", VA = "0x184148E00")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA4733C0", Offset = "0xA4727C0", VA = "0x18A4733C0")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA471AE0", Offset = "0xA470EE0", VA = "0x18A471AE0")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA471B60", Offset = "0xA470F60", VA = "0x18A471B60")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA473340", Offset = "0xA472740", VA = "0x18A473340")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA473A80", Offset = "0xA472E80", VA = "0x18A473A80")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA471CC0", Offset = "0xA4710C0", VA = "0x18A471CC0")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA4739B0", Offset = "0xA472DB0", VA = "0x18A4739B0")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA4735C0", Offset = "0xA4729C0", VA = "0x18A4735C0")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA4720B0", Offset = "0xA4714B0", VA = "0x18A4720B0")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA471E80", Offset = "0xA471280", VA = "0x18A471E80")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA472150", Offset = "0xA471550", VA = "0x18A472150")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA471E00", Offset = "0xA471200", VA = "0x18A471E00")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA4722E0", Offset = "0xA4716E0", VA = "0x18A4722E0")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x238B330", Offset = "0x238A730", VA = "0x18238B330")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA474120", Offset = "0xA473520", VA = "0x18A474120")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4149200", Offset = "0x4148600", VA = "0x184149200")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA473280", Offset = "0xA472680", VA = "0x18A473280")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA472010", Offset = "0xA471410", VA = "0x18A472010")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA473C00", Offset = "0xA473000", VA = "0x18A473C00")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA474570", Offset = "0xA473970", VA = "0x18A474570")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA473B00", Offset = "0xA472F00", VA = "0x18A473B00")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA471CB0", Offset = "0xA4710B0", VA = "0x18A471CB0")]
		public static bool DeepEquals(this JsonNode x, JsonNode y, double precission)
		{
			return default(bool);
		}
	}
}
namespace SharpGLTF.Validation
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ModelException : Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly JsonSerializable _Target;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		internal string MessageSuffix
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCF7A30", Offset = "0xCF6E30", VA = "0x180CF7A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B00", Offset = "0xCF6F00", VA = "0x180CF7B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string Message
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA465220", Offset = "0xA464620", VA = "0x18A465220", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private string _Generator
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA465270", Offset = "0xA464670", VA = "0x18A465270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA465190", Offset = "0xA464590", VA = "0x18A465190")]
		internal ModelException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA4650E0", Offset = "0xA4644E0", VA = "0x18A4650E0")]
		internal ModelException(JsonSerializable target, Exception ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA464D40", Offset = "0xA464140", VA = "0x18A464D40")]
		private static string _CreateBaseMessage(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA464EE0", Offset = "0xA4642E0", VA = "0x18A464EE0")]
		internal static void _Decorate(Exception ex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SchemaException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA45E400", Offset = "0xA45D800", VA = "0x18A45E400")]
		internal SchemaException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA4650E0", Offset = "0xA4644E0", VA = "0x18A4650E0")]
		internal SchemaException(JsonSerializable target, JsonException rex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class SemanticException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA45E400", Offset = "0xA45D800", VA = "0x18A45E400")]
		internal SemanticException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class LinkException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA45E400", Offset = "0xA45D800", VA = "0x18A45E400")]
		internal LinkException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DataException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA45E400", Offset = "0xA45D800", VA = "0x18A45E400")]
		internal DataException(JsonSerializable target, string message)
		{
		}
	}
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DebuggerDisplay("{_Current}")]
	[DebuggerStepThrough]
	public readonly struct ValidationContext
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly ModelRoot _Root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly ValidationMode _Mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly JsonSerializable _Current;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public ModelRoot Root
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xED9420", Offset = "0xED8820", VA = "0x180ED9420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool TryFix
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA470FB0", Offset = "0xA4703B0", VA = "0x18A470FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA470ED0", Offset = "0xA4702D0", VA = "0x18A470ED0")]
		public ValidationContext(ValidationResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA470E80", Offset = "0xA470280", VA = "0x18A470E80")]
		internal ValidationContext(ValidationContext context, JsonSerializable target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA46FCA0", Offset = "0xA46F0A0", VA = "0x18A46FCA0")]
		public ValidationContext GetContext(JsonSerializable target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA470DE0", Offset = "0xA4701E0", VA = "0x18A470DE0")]
		[DebuggerStepThrough]
		internal void _SchemaThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA470710", Offset = "0xA46FB10", VA = "0x18A470710")]
		public ValidationContext IsTrue(ValueLocation parameterName, bool value, string msg)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA470A50", Offset = "0xA46FE50", VA = "0x18A470A50")]
		public ValidationContext NotNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA470930", Offset = "0xA46FD30", VA = "0x18A470930")]
		public ValidationContext MustBeNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x40BD110", Offset = "0x40BC510", VA = "0x1840BD110")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x40BD070", Offset = "0x40BC470", VA = "0x1840BD070")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x40BF210", Offset = "0x40BE610", VA = "0x1840BF210")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x40BF0C0", Offset = "0x40BE4C0", VA = "0x1840BF0C0")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x40BBED0", Offset = "0x40BB2D0", VA = "0x1840BBED0")]
		public ValidationContext AreSameReference<TRef>(ValueLocation parameterName, TRef value, TRef expected) where TRef : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x40BBDD0", Offset = "0x40BB1D0", VA = "0x1840BBDD0")]
		public ValidationContext AreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : IEquatable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x40BE590", Offset = "0x40BD990", VA = "0x1840BE590")]
		public ValidationContext IsLess<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x40BE220", Offset = "0x40BD620", VA = "0x1840BE220")]
		public ValidationContext IsLessOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x40BD8D0", Offset = "0x40BCCD0", VA = "0x1840BD8D0")]
		public ValidationContext IsGreater<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x40BC780", Offset = "0x40BBB80", VA = "0x1840BC780")]
		public ValidationContext IsDefaultOrWithin<TValue>(ValueLocation parameterName, TValue? value, TValue minInclusive, TValue maxInclusive) where TValue : struct, IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x40BD410", Offset = "0x40BC810", VA = "0x1840BD410")]
		public ValidationContext IsGreaterOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA470100", Offset = "0xA46F500", VA = "0x18A470100")]
		public ValidationContext IsMultipleOf(ValueLocation parameterName, int value, int multiple)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA4709C0", Offset = "0xA46FDC0", VA = "0x18A4709C0")]
		public ValidationContext NonNegative(ValueLocation parameterName, int? value)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA470500", Offset = "0xA46F900", VA = "0x18A470500")]
		public ValidationContext IsNullOrValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA470760", Offset = "0xA46FB60", VA = "0x18A470760")]
		public ValidationContext IsValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA470D40", Offset = "0xA470140", VA = "0x18A470D40")]
		[DebuggerStepThrough]
		internal void _LinkThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x40BC160", Offset = "0x40BB560", VA = "0x1840BC160")]
		public ValidationContext EnumsAreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : Enum
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x40BEB20", Offset = "0x40BDF20", VA = "0x1840BEB20")]
		public ValidationContext IsNullOrIndex<T>(ValueLocation parameterName, int? index, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x40BE6B0", Offset = "0x40BDAB0", VA = "0x1840BE6B0")]
		public ValidationContext IsNullOrInRange<T>(ValueLocation parameterName, int? offset, int length, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x40BC580", Offset = "0x40BB980", VA = "0x1840BC580")]
		public ValidationContext IsAnyOf<T>(ValueLocation parameterName, T value, params T[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA46FD00", Offset = "0xA46F100", VA = "0x18A46FD00")]
		public ValidationContext IsAnyOf(ValueLocation parameterName, AttributeFormat value, params AttributeFormat[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x40BEBD0", Offset = "0x40BDFD0", VA = "0x1840BEBD0")]
		public ValidationContext IsSetCollection<T>(ValueLocation parameterName, IEnumerable<T> collection) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA470CA0", Offset = "0xA4700A0", VA = "0x18A470CA0")]
		[DebuggerStepThrough]
		private void _DataThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x40BDE20", Offset = "0x40BD220", VA = "0x1840BDE20")]
		public ValidationContext IsInRange<T>(ValueLocation pname, T value, T minInclusive, T maxInclusive) where T : IComparable<T>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA4703C0", Offset = "0xA46F7C0", VA = "0x18A4703C0")]
		public ValidationContext IsNullOrMatrix(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA470280", Offset = "0xA46F680", VA = "0x18A470280")]
		public ValidationContext IsNullOrMatrix4x3(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA470570", Offset = "0xA46F970", VA = "0x18A470570")]
		public ValidationContext IsPosition(ValueLocation pname, [In] Vector3 position)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA4701D0", Offset = "0xA46F5D0", VA = "0x18A4701D0")]
		public ValidationContext IsNormal(ValueLocation pname, [In] Vector3 normal)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA470670", Offset = "0xA46FA70", VA = "0x18A470670")]
		public ValidationContext IsRotation(ValueLocation pname, [In] Quaternion rotation)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA470050", Offset = "0xA46F450", VA = "0x18A470050")]
		public ValidationContext IsMatrix(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA46FFA0", Offset = "0xA46F3A0", VA = "0x18A46FFA0")]
		public ValidationContext IsMatrix4x3(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA46F390", Offset = "0xA46E790", VA = "0x18A46F390")]
		public ValidationContext ArePositions(ValueLocation pname, IReadOnlyList<Vector3> positions)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA46F020", Offset = "0xA46E420", VA = "0x18A46F020")]
		public ValidationContext AreNormals(ValueLocation pname, IReadOnlyList<Vector3> normals)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA46F9C0", Offset = "0xA46EDC0", VA = "0x18A46F9C0")]
		public ValidationContext AreTangents(ValueLocation pname, IReadOnlyList<Vector4> tangents)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA46F770", Offset = "0xA46EB70", VA = "0x18A46F770")]
		public ValidationContext AreRotations(ValueLocation pname, IReadOnlyList<Quaternion> rotations)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA46EB10", Offset = "0xA46DF10", VA = "0x18A46EB10")]
		public ValidationContext AreJoints(ValueLocation pname, IReadOnlyList<Vector4> joints, int skinsMaxJointCount)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA470AE0", Offset = "0xA46FEE0", VA = "0x18A470AE0")]
		public ValidationContext That(Action action)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA470C40", Offset = "0xA470040", VA = "0x18A470C40")]
		public ValidationContext That(bool result, string paramName, string msg)
		{
			return default(ValidationContext);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct ValueLocation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string _Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int _Index;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA471A10", Offset = "0xA470E10", VA = "0x18A471A10")]
		public static implicit operator ValueLocation(int index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA4719B0", Offset = "0xA470DB0", VA = "0x18A4719B0")]
		public static implicit operator ValueLocation(int? index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B7BC50", Offset = "0x2B7B050", VA = "0x182B7BC50")]
		public static implicit operator ValueLocation(string name)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA471A50", Offset = "0xA470E50", VA = "0x18A471A50")]
		public static implicit operator ValueLocation((string name, int index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA471950", Offset = "0xA470D50", VA = "0x18A471950")]
		public static implicit operator ValueLocation((string name, int? index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA471A90", Offset = "0xA470E90", VA = "0x18A471A90")]
		public static implicit operator string(ValueLocation location)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xDACAB0", Offset = "0xDABEB0", VA = "0x180DACAB0")]
		private ValueLocation(string name, int idx1 = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA4718D0", Offset = "0xA470CD0", VA = "0x18A4718D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA471860", Offset = "0xA470C60", VA = "0x18A471860")]
		public string ToString(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA471730", Offset = "0xA470B30", VA = "0x18A471730")]
		public string ToString(JsonSerializable target)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum ValidationMode
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Skip,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		TryFix,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Strict
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DebuggerStepThrough]
	public sealed class ValidationResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly ModelRoot _Root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly ValidationMode _Mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly bool _InstantThrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly List<Exception> _Errors;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public ModelRoot Root
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ValidationMode Mode
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50")]
			get
			{
				return default(ValidationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IEnumerable<Exception> Errors
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool HasErrors
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xA4716E0", Offset = "0xA470AE0", VA = "0x18A4716E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA471620", Offset = "0xA470A20", VA = "0x18A471620")]
		public ValidationResult(ModelRoot root, ValidationMode mode, bool instantThrow = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA470FC0", Offset = "0xA4703C0", VA = "0x18A470FC0")]
		public ValidationContext GetContext()
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA471520", Offset = "0xA470920", VA = "0x18A471520")]
		public void SetSchemaError(EndOfStreamException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA4714A0", Offset = "0xA4708A0", VA = "0x18A4714A0")]
		public void SetSchemaError(ModelRoot model, string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA4713A0", Offset = "0xA4707A0", VA = "0x18A4713A0")]
		public void SetSchemaError(ModelRoot model, JsonException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA471280", Offset = "0xA470680", VA = "0x18A471280")]
		public void SetModelError(FormatException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA471180", Offset = "0xA470580", VA = "0x18A471180")]
		public void SetModelError(ModelRoot model, ArgumentException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA4710B0", Offset = "0xA4704B0", VA = "0x18A4710B0")]
		public void SetError(ModelException ex)
		{
		}
	}
}
namespace SharpGLTF.Transforms
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[DebuggerDisplay("AffineTransform {ToDebuggerDisplayString(),nq}")]
	public readonly struct AffineTransform : IEquatable<AffineTransform>
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const string _CannotDecomposeError = "Matrix is invalid or skewed.";

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private const string _RequiresSRTError = "Needs to be in SRT representation. Call GetDecomposed() first.";

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly AffineTransform Identity;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const int DATA_UNDEFINED = 0;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private const int DATA_SRT = 1;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const int DATA_MAT = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _Representation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float _M11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float _M12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float _M13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float _M21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float _M22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float _M23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float _M31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float _M32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly float _M33;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector3 _Translation;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA45DC70", Offset = "0xA45D070", VA = "0x18A45DC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA45DC50", Offset = "0xA45D050", VA = "0x18A45DC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IsSRT
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA45DC60", Offset = "0xA45D060", VA = "0x18A45DC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA45DFB0", Offset = "0xA45D3B0", VA = "0x18A45DFB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Quaternion Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA45DF40", Offset = "0xA45D340", VA = "0x18A45DF40")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xEC42E0", Offset = "0xEC36E0", VA = "0x180EC42E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA45DEC0", Offset = "0xA45D2C0", VA = "0x18A45DEC0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IsLosslessDecomposable
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA45DB40", Offset = "0xA45CF40", VA = "0x18A45DB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IsIdentity
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA45D8A0", Offset = "0xA45CCA0", VA = "0x18A45D8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA45A2E0", Offset = "0xA4596E0", VA = "0x18A45A2E0")]
		internal string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA45E0D0", Offset = "0xA45D4D0", VA = "0x18A45E0D0")]
		public static implicit operator AffineTransform((Quaternion r, Vector3 t) xform)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA45E260", Offset = "0xA45D660", VA = "0x18A45E260")]
		public static implicit operator AffineTransform(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA45E220", Offset = "0xA45D620", VA = "0x18A45E220")]
		public static implicit operator AffineTransform(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA459380", Offset = "0xA458780", VA = "0x18A459380")]
		public static AffineTransform CreateDecomposed(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA4594F0", Offset = "0xA4588F0", VA = "0x18A4594F0")]
		public static AffineTransform CreateFromAny(Matrix4x4? matrix, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA45C250", Offset = "0xA45B650", VA = "0x18A45C250")]
		public AffineTransform WithScale(Vector3 scale)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA45BED0", Offset = "0xA45B2D0", VA = "0x18A45BED0")]
		public AffineTransform WithRotation(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA45C600", Offset = "0xA45BA00", VA = "0x18A45C600")]
		public AffineTransform WithTranslation(Vector3 translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA45D0B0", Offset = "0xA45C4B0", VA = "0x18A45D0B0")]
		public AffineTransform(Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA45D3F0", Offset = "0xA45C7F0", VA = "0x18A45D3F0")]
		public AffineTransform(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA45CFE0", Offset = "0xA45C3E0", VA = "0x18A45CFE0")]
		public AffineTransform(Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA45D4D0", Offset = "0xA45C8D0", VA = "0x18A45D4D0")]
		public AffineTransform(Vector3 scale, Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA45D240", Offset = "0xA45C640", VA = "0x18A45D240")]
		public AffineTransform(Matrix4x4 matrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA459B30", Offset = "0xA458F30", VA = "0x18A459B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA4597E0", Offset = "0xA458BE0", VA = "0x18A4597E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA4598E0", Offset = "0xA458CE0", VA = "0x18A4598E0", Slot = "4")]
		public bool Equals(AffineTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA45E020", Offset = "0xA45D420", VA = "0x18A45E020")]
		public static bool operator ==([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA45E2C0", Offset = "0xA45D6C0", VA = "0x18A45E2C0")]
		public static bool operator !=([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA458B60", Offset = "0xA457F60", VA = "0x18A458B60")]
		public static bool AreGeometricallyEquivalent([In] AffineTransform a, [In] AffineTransform b, float tolerance = 1E-05f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA459A70", Offset = "0xA458E70", VA = "0x18A459A70")]
		public AffineTransform GetDecomposed()
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA45B250", Offset = "0xA45A650", VA = "0x18A45B250")]
		public bool TryDecompose([Out] AffineTransform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA45B010", Offset = "0xA45A410", VA = "0x18A45B010")]
		public bool TryDecompose([Out] Vector3 scale, [Out] Quaternion rotation, [Out] Vector3 translation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA458DF0", Offset = "0xA4581F0", VA = "0x18A458DF0")]
		public static AffineTransform Blend(ReadOnlySpan<AffineTransform> transforms, ReadOnlySpan<float> weights)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA45E370", Offset = "0xA45D770", VA = "0x18A45E370")]
		public static AffineTransform operator *([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA459B60", Offset = "0xA458F60", VA = "0x18A459B60")]
		public static AffineTransform Multiply([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA45B5A0", Offset = "0xA45A9A0", VA = "0x18A45B5A0")]
		public static bool TryInvert([In] AffineTransform xform, [Out] AffineTransform inverse)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA45ABF0", Offset = "0xA459FF0", VA = "0x18A45ABF0")]
		private static Vector3 Transform(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA45A810", Offset = "0xA459C10", VA = "0x18A45A810")]
		public static Vector3 TransformNormal(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA45CEC0", Offset = "0xA45C2C0", VA = "0x18A45CEC0")]
		private void _VerifyDefined()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA45C970", Offset = "0xA45BD70", VA = "0x18A45C970")]
		private Matrix4x4 _GetMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA45CDF0", Offset = "0xA45C1F0", VA = "0x18A45CDF0")]
		private Vector3 _GetScale()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA45CD20", Offset = "0xA45C120", VA = "0x18A45CD20")]
		private Quaternion _GetRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA458670", Offset = "0xA457A70", VA = "0x18A458670")]
		private static Vector3 _Vector3Transform(Vector3 v, Quaternion q)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[DebuggerDisplay("{Index} = {Weight}")]
	internal readonly struct IndexWeight : IEquatable<IndexWeight>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly float Weight;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA460F00", Offset = "0xA460300", VA = "0x18A460F00")]
		public static implicit operator IndexWeight((int Index, float Weight) pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA460EB0", Offset = "0xA4602B0", VA = "0x18A460EB0")]
		public static implicit operator IndexWeight(KeyValuePair<int, float> pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA460DE0", Offset = "0xA4601E0", VA = "0x18A460DE0")]
		public IndexWeight((int Index, float Weight) pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA460D70", Offset = "0xA460170", VA = "0x18A460D70")]
		public IndexWeight(KeyValuePair<int, float> pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x686FD00", Offset = "0x686F100", VA = "0x18686FD00")]
		public IndexWeight(int i, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA4601C0", Offset = "0xA45F5C0", VA = "0x18A4601C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA460100", Offset = "0xA45F500", VA = "0x18A460100", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA4601A0", Offset = "0xA45F5A0", VA = "0x18A4601A0", Slot = "4")]
		public bool Equals(IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA460B90", Offset = "0xA45FF90", VA = "0x18A460B90")]
		public bool IsGreaterThan([In] IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA460E20", Offset = "0xA460220", VA = "0x18A460E20")]
		public static IndexWeight operator +(IndexWeight a, IndexWeight b)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA460E00", Offset = "0xA460200", VA = "0x18A460E00")]
		public static IndexWeight operator +(IndexWeight a, float w)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA460C30", Offset = "0xA460030", VA = "0x18A460C30")]
		public static bool IsWellFormed(ReadOnlySpan<IndexWeight> iw, [Out] string err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA460210", Offset = "0xA45F610", VA = "0x18A460210")]
		public static int InsertSorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA4606E0", Offset = "0xA45FAE0", VA = "0x18A4606E0")]
		public static int InsertUnsorted(Span<IndexWeight> sparse, [In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA4604E0", Offset = "0xA45F8E0", VA = "0x18A4604E0")]
		public static int InsertUnsorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA45FCC0", Offset = "0xA45F0C0", VA = "0x18A45FCC0")]
		public static int CopyTo([In] SparseWeight8 src, Span<int> dstIndices, Span<float> dstWeights, int dstLength)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA45FB20", Offset = "0xA45EF20", VA = "0x18A45FB20")]
		public static void BubbleSortByWeight(Span<IndexWeight> pairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA45FA40", Offset = "0xA45EE40", VA = "0x18A45FA40")]
		public static void BubbleSortByIndex(Span<IndexWeight> pairs)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[DebuggerTypeProxy(typeof(_Matrix4x4DoubleProxy))]
	public struct Matrix4x4Double : IEquatable<Matrix4x4Double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly Matrix4x4Double _identity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public double M11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public double M12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public double M13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public double M14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public double M21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public double M22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public double M23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public double M24;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public double M31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public double M32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public double M33;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public double M34;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public double M41;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public double M42;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public double M43;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public double M44;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static Matrix4x4Double Identity
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0xA462980", Offset = "0xA461D80", VA = "0x18A462980")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public (double x, double y, double z) Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA462A10", Offset = "0xA461E10", VA = "0x18A462A10")]
			get
			{
				return default((double, double, double));
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA4633C0", Offset = "0xA4627C0", VA = "0x18A4633C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA4628D0", Offset = "0xA461CD0", VA = "0x18A4628D0")]
		public Matrix4x4Double(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA462810", Offset = "0xA461C10", VA = "0x18A462810")]
		public Matrix4x4Double(Matrix4x4 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA4617F0", Offset = "0xA460BF0", VA = "0x18A4617F0")]
		public static Matrix4x4Double CreateTranslation(double xPosition, double yPosition, double zPosition)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA461790", Offset = "0xA460B90", VA = "0x18A461790")]
		public static Matrix4x4Double CreateScale(double xScale, double yScale, double zScale)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA461600", Offset = "0xA460A00", VA = "0x18A461600")]
		public static Matrix4x4Double CreateFromQuaternion(Quaternion quaternion)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA462BD0", Offset = "0xA461FD0", VA = "0x18A462BD0")]
		public static explicit operator Matrix4x4(Matrix4x4Double mat)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA462D80", Offset = "0xA462180", VA = "0x18A462D80")]
		public static implicit operator Matrix4x4Double(Matrix4x4 mat)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA461D10", Offset = "0xA461110", VA = "0x18A461D10", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA462A80", Offset = "0xA461E80", VA = "0x18A462A80")]
		public static bool operator ==(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA462E60", Offset = "0xA462260", VA = "0x18A462E60")]
		public static bool operator !=(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA461B80", Offset = "0xA460F80", VA = "0x18A461B80", Slot = "4")]
		public readonly bool Equals(Matrix4x4Double other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA461850", Offset = "0xA460C50", VA = "0x18A461850", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA461F70", Offset = "0xA461370", VA = "0x18A461F70")]
		public static bool Invert(Matrix4x4Double matrix, [Out] Matrix4x4Double result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA462630", Offset = "0xA461A30", VA = "0x18A462630")]
		public static Matrix4x4Double Multiply(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA462FB0", Offset = "0xA4623B0", VA = "0x18A462FB0")]
		public static Matrix4x4Double operator *(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(Matrix4x4Double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class Matrix4x4Factory
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[Flags]
		public enum MatrixCheck
		{
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			Finite = 1,
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			NonZero = 2,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			Identity = 4,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			IdentityColumn4 = 8,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			Invertible = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Decomposable = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			PositiveDeterminant = 0x40,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			LocalTransform = 0x3A,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			WorldTransform = 0x1A,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			InverseBindMatrix = 0x1A
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA464930", Offset = "0xA463D30", VA = "0x18A464930")]
		private static MatrixCheck _Validate([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(MatrixCheck);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA4637E0", Offset = "0xA462BE0", VA = "0x18A4637E0")]
		public static bool IsValid([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA463720", Offset = "0xA462B20", VA = "0x18A463720")]
		[DebuggerStepThrough]
		public static void GuardMatrix(string argName, Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA4634C0", Offset = "0xA4628C0", VA = "0x18A4634C0")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA4633E0", Offset = "0xA4627E0", VA = "0x18A4633E0")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ, Vector3 translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA463580", Offset = "0xA462980", VA = "0x18A463580")]
		public static Matrix4x4 CreateFrom(Matrix4x4? transform, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA463800", Offset = "0xA462C00", VA = "0x18A463800")]
		public static Matrix4x4 LocalToWorld([In] Matrix4x4 parentWorld, [In] Matrix4x4 childLocal)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA4645F0", Offset = "0xA4639F0", VA = "0x18A4645F0")]
		public static Matrix4x4 WorldToLocal([In] Matrix4x4 parentWorld, [In] Matrix4x4 childWorld)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA463B30", Offset = "0xA462F30", VA = "0x18A463B30")]
		public static void NormalizeMatrix(Matrix4x4 xform)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface IMaterialTransform
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector2 MorphTexCoord(Vector2 texCoord, IReadOnlyList<Vector2> morphTargets);

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Vector4 MorphColors(Vector4 color, IReadOnlyList<Vector4> morphTargets);
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface IGeometryTransform
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool Visible
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights);

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights);

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface IGeometryInstancing
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		int InstancesCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		IReadOnlyList<RigidTransform> WorldTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public abstract class MorphTransform : IMaterialTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SparseWeight8 _Weights;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public const int COMPLEMENT_INDEX = 65536;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _AbsoluteMorphTargets;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public SparseWeight8 MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x514A430", Offset = "0x5149830", VA = "0x18514A430")]
			get
			{
				return default(SparseWeight8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool AbsoluteMorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD995E0", Offset = "0xD989E0", VA = "0x180D995E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA466360", Offset = "0xA465760", VA = "0x18A466360")]
		protected MorphTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA4663A0", Offset = "0xA4657A0", VA = "0x18A4663A0")]
		protected MorphTransform(SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA466250", Offset = "0xA465650", VA = "0x18A466250")]
		public void Update([In] SparseWeight8 morphWeights, bool useAbsoluteMorphTargets = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA465910", Offset = "0xA464D10", VA = "0x18A465910")]
		protected Vector2 MorphVectors(Vector2 value, IReadOnlyList<Vector2> morphTargets)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA465380", Offset = "0xA464780", VA = "0x18A465380")]
		protected Vector3 MorphVectors(Vector3 value, IReadOnlyList<Vector3> morphTargets)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA465CE0", Offset = "0xA4650E0", VA = "0x18A465CE0")]
		protected Vector4 MorphVectors(Vector4 value, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA465330", Offset = "0xA464730", VA = "0x18A465330", Slot = "5")]
		public Vector4 MorphColors(Vector4 color, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA465370", Offset = "0xA464770", VA = "0x18A465370", Slot = "4")]
		public Vector2 MorphTexCoord(Vector2 texCoord, IReadOnlyList<Vector2> morphTargets)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RigidTransform : MorphTransform, IGeometryTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Matrix4x4 _WorldMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _Visible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _FlipFaces;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool Visible
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xD23EA0", Offset = "0xD232A0", VA = "0x180D23EA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x20B1390", Offset = "0x20B0790", VA = "0x1820B1390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA467560", Offset = "0xA466960", VA = "0x18A467560")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA467470", Offset = "0xA466870", VA = "0x18A467470")]
		public RigidTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA4673C0", Offset = "0xA4667C0", VA = "0x18A4673C0")]
		public RigidTransform(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA467310", Offset = "0xA466710", VA = "0x18A467310")]
		public RigidTransform(Matrix4x4 worldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA467160", Offset = "0xA466560", VA = "0x18A467160")]
		public void Update(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA466DC0", Offset = "0xA4661C0", VA = "0x18A466DC0")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA466C30", Offset = "0xA466030", VA = "0x18A466C30")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA466F60", Offset = "0xA466360", VA = "0x18A466F60")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA466A30", Offset = "0xA465E30", VA = "0x18A466A30", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA4668A0", Offset = "0xA465CA0", VA = "0x18A4668A0", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA466BE0", Offset = "0xA465FE0", VA = "0x18A466BE0", Slot = "10")]
		Vector4 IGeometryTransform.TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SkinnedTransform : MorphTransform, IGeometryTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Matrix4x4[] _SkinTransforms;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool Visible
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public IReadOnlyList<Matrix4x4> SkinMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF4020", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA466360", Offset = "0xA465760", VA = "0x18A466360")]
		public SkinnedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA469280", Offset = "0xA468680", VA = "0x18A469280")]
		public SkinnedTransform(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA469310", Offset = "0xA468710", VA = "0x18A469310")]
		public SkinnedTransform(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA468ED0", Offset = "0xA4682D0", VA = "0x18A468ED0")]
		public void Update(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA468BC0", Offset = "0xA467FC0", VA = "0x18A468BC0")]
		public void Update(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA468160", Offset = "0xA467560", VA = "0x18A468160")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA467CC0", Offset = "0xA4670C0", VA = "0x18A467CC0")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA4686E0", Offset = "0xA467AE0", VA = "0x18A4686E0")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA467990", Offset = "0xA466D90", VA = "0x18A467990")]
		public static Matrix4x4 CalculateInverseBinding(Matrix4x4 meshWorldTransform, Matrix4x4 jointWorldTransform)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA467590", Offset = "0xA466990", VA = "0x18A467590")]
		public static Matrix4x4Double CalculateInverseBinding(Matrix4x4Double meshWorldTransform, Matrix4x4Double jointWorldTransform)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA467C10", Offset = "0xA467010", VA = "0x18A467C10", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA467BB0", Offset = "0xA466FB0", VA = "0x18A467BB0", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA467C70", Offset = "0xA467070", VA = "0x18A467C70", Slot = "10")]
		Vector4 IGeometryTransform.TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class InstancingTransform : RigidTransform, IGeometryInstancing
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class <Evaluate>d__11 : IEnumerable<IGeometryTransform>, IEnumerable, IEnumerator<IGeometryTransform>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private IGeometryTransform <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private IGeometryTransform xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public IGeometryTransform <>3__xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private IEnumerator<RigidTransform> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			IGeometryTransform IEnumerator<IGeometryTransform>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <Evaluate>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA46D610", Offset = "0xA46CA10", VA = "0x18A46D610", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA46D270", Offset = "0xA46C670", VA = "0x18A46D270", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA46D6D0", Offset = "0xA46CAD0", VA = "0x18A46D6D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA46D5D0", Offset = "0xA46C9D0", VA = "0x18A46D5D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA46D530", Offset = "0xA46C930", VA = "0x18A46D530", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IGeometryTransform> IEnumerable<IGeometryTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA46D530", Offset = "0xA46C930", VA = "0x18A46D530", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly Matrix4x4[] _LocalMatrices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private Lazy<RigidTransform[]> _WorldTransforms;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int InstancesCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA4615E0", Offset = "0xA4609E0", VA = "0x18A4615E0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IReadOnlyList<Matrix4x4> LocalMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xDCCCD0", Offset = "0xDCC0D0", VA = "0x180DCCCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public IReadOnlyList<RigidTransform> WorldTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA460FA0", Offset = "0xA4603A0", VA = "0x18A460FA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA461350", Offset = "0xA460750", VA = "0x18A461350")]
		public InstancingTransform(AffineTransform[] instances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA461260", Offset = "0xA460660", VA = "0x18A461260")]
		private RigidTransform[] _CreateTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA460FA0", Offset = "0xA4603A0", VA = "0x18A460FA0")]
		public RigidTransform[] UpdateInstances()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA460F20", Offset = "0xA460320", VA = "0x18A460F20")]
		[IteratorStateMachine(typeof(<Evaluate>d__11))]
		public static IEnumerable<IGeometryTransform> Evaluate(IGeometryTransform xform)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class Projection
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA4663F0", Offset = "0xA4657F0", VA = "0x18A4663F0")]
		public static Matrix4x4 CreateOrthographicMatrix(float xmag, float ymag, float znear, float zfar)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA4665F0", Offset = "0xA4659F0", VA = "0x18A4665F0")]
		public static Matrix4x4 CreatePerspectiveMatrix(float aspectRatio, float yfov, float znear, float zfar = 1f / 0f)
		{
			return default(Matrix4x4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public readonly struct SparseWeight8 : IEquatable<SparseWeight8>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class <Expand>d__51 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private float <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public SparseWeight8 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public SparseWeight8 <>3__<>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private int count;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int <>3__count;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			float IEnumerator<float>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0xEC6BC0", Offset = "0xEC5FC0", VA = "0x180EC6BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0x2081D70", Offset = "0x2081170", VA = "0x182081D70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x15B8830", Offset = "0x15B7C30", VA = "0x1815B8830")]
			[DebuggerHidden]
			public <Expand>d__51(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xA481600", Offset = "0xA480A00", VA = "0x18A481600", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA481730", Offset = "0xA480B30", VA = "0x18A481730", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA481670", Offset = "0xA480A70", VA = "0x18A481670", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<float> IEnumerable<float>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA481670", Offset = "0xA480A70", VA = "0x18A481670", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class <GetIndexedWeights>d__52 : IEnumerable<(int, float)>, IEnumerable, IEnumerator<(int, float)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private (int Index, float Weight) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public SparseWeight8 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public SparseWeight8 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			(int, float) IEnumerator<(int, float)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0x13F81B0", Offset = "0x13F75B0", VA = "0x1813F81B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, float));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EA")]
				[Cpp2IlInjected.Address(RVA = "0xA484750", Offset = "0xA483B50", VA = "0x18A484750", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x64B5AB0", Offset = "0x64B4EB0", VA = "0x1864B5AB0")]
			[DebuggerHidden]
			public <GetIndexedWeights>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA4843B0", Offset = "0xA4837B0", VA = "0x18A4843B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xA484710", Offset = "0xA483B10", VA = "0x18A484710", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xA484650", Offset = "0xA483A50", VA = "0x18A484650", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xA484650", Offset = "0xA483A50", VA = "0x18A484650", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class <GetNonZeroWeights>d__53 : IEnumerable<(int, float)>, IEnumerable, IEnumerator<(int, float)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private (int Index, float Weight) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public SparseWeight8 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public SparseWeight8 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			(int, float) IEnumerator<(int, float)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0x13F81B0", Offset = "0x13F75B0", VA = "0x1813F81B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, float));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F2")]
				[Cpp2IlInjected.Address(RVA = "0xA484B90", Offset = "0xA483F90", VA = "0x18A484B90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x64B5AB0", Offset = "0x64B4EB0", VA = "0x1864B5AB0")]
			[DebuggerHidden]
			public <GetNonZeroWeights>d__53(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA4847A0", Offset = "0xA483BA0", VA = "0x18A4847A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA484B50", Offset = "0xA483F50", VA = "0x18A484B50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA484A90", Offset = "0xA483E90", VA = "0x18A484A90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xA484A90", Offset = "0xA483E90", VA = "0x18A484A90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class <_GetPairs>d__64 : IEnumerable<IndexWeight>, IEnumerable, IEnumerator<IndexWeight>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private IndexWeight <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public SparseWeight8 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public SparseWeight8 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			IndexWeight IEnumerator<IndexWeight>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001F8")]
				[Cpp2IlInjected.Address(RVA = "0x13F81B0", Offset = "0x13F75B0", VA = "0x1813F81B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(IndexWeight);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0xA48BCD0", Offset = "0xA48B0D0", VA = "0x18A48BCD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x64B5AB0", Offset = "0x64B4EB0", VA = "0x1864B5AB0")]
			[DebuggerHidden]
			public <_GetPairs>d__64(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA48B910", Offset = "0xA48AD10", VA = "0x18A48B910", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA48BC90", Offset = "0xA48B090", VA = "0x18A48BC90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xA48BBD0", Offset = "0xA48AFD0", VA = "0x18A48BBD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IndexWeight> IEnumerable<IndexWeight>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xA48BBD0", Offset = "0xA48AFD0", VA = "0x18A48BBD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly int Index0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly float Weight0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly int Index1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly float Weight1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public readonly int Index2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public readonly float Weight2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public readonly int Index3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly float Weight3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly int Index4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public readonly float Weight4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly int Index5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public readonly float Weight5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly int Index6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly float Weight6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public readonly int Index7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly float Weight7;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA46D0C0", Offset = "0xA46C4C0", VA = "0x18A46D0C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA46AB30", Offset = "0xA469F30", VA = "0x18A46AB30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool IsWeightless
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA46D0D0", Offset = "0xA46C4D0", VA = "0x18A46D0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float WeightSum
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA46D1C0", Offset = "0xA46C5C0", VA = "0x18A46D1C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int MaxIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA46D1B0", Offset = "0xA46C5B0", VA = "0x18A46D1B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA46C2E0", Offset = "0xA46B6E0", VA = "0x18A46C2E0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA46A0A0", Offset = "0xA4694A0", VA = "0x18A46A0A0")]
		public static SparseWeight8 Create(params float[] weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA46A5A0", Offset = "0xA4699A0", VA = "0x18A46A5A0")]
		public static SparseWeight8 Create(IEnumerable<float> weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA46A060", Offset = "0xA469460", VA = "0x18A46A060")]
		public static SparseWeight8 Create(params (int Index, float Weight)[] indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA46A0E0", Offset = "0xA4694E0", VA = "0x18A46A0E0")]
		public static SparseWeight8 Create(IEnumerable<(int Index, float Weight)> indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA46A4A0", Offset = "0xA4698A0", VA = "0x18A46A4A0")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA469E00", Offset = "0xA469200", VA = "0x18A469E00")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA469D70", Offset = "0xA469170", VA = "0x18A469D70")]
		public static SparseWeight8 CreateUnchecked([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA46CFA0", Offset = "0xA46C3A0", VA = "0x18A46CFA0")]
		private SparseWeight8([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA46CEE0", Offset = "0xA46C2E0", VA = "0x18A46CEE0")]
		private SparseWeight8(ReadOnlySpan<IndexWeight> iw)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA46D020", Offset = "0xA46C420", VA = "0x18A46D020")]
		private SparseWeight8([In] SparseWeight8 sparse, float scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA46AC50", Offset = "0xA46A050", VA = "0x18A46AC50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA46A9C0", Offset = "0xA469DC0", VA = "0x18A46A9C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA46AA70", Offset = "0xA469E70", VA = "0x18A46AA70", Slot = "4")]
		public bool Equals(SparseWeight8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA46D1F0", Offset = "0xA46C5F0", VA = "0x18A46D1F0")]
		public static bool operator ==(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA46D230", Offset = "0xA46C630", VA = "0x18A46D230")]
		public static bool operator !=(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA469500", Offset = "0xA468900", VA = "0x18A469500")]
		internal static bool AreEqual([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA46BCD0", Offset = "0xA46B0D0", VA = "0x18A46BCD0")]
		public static SparseWeight8 OrderedByWeight([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA46BAF0", Offset = "0xA46AEF0", VA = "0x18A46BAF0")]
		public static SparseWeight8 OrderedByIndex([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA4693B0", Offset = "0xA4687B0", VA = "0x18A4693B0")]
		public static SparseWeight8 Add([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA46C0A0", Offset = "0xA46B4A0", VA = "0x18A46C0A0")]
		public static SparseWeight8 Subtract([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA46B9A0", Offset = "0xA46ADA0", VA = "0x18A46B9A0")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA46B900", Offset = "0xA46AD00", VA = "0x18A46B900")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, float y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA46B7D0", Offset = "0xA46ABD0", VA = "0x18A46B7D0")]
		public static SparseWeight8 InterpolateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA46B690", Offset = "0xA46AA90", VA = "0x18A46B690")]
		public static SparseWeight8 InterpolateCubic([In] SparseWeight8 x, [In] SparseWeight8 xt, [In] SparseWeight8 y, [In] SparseWeight8 yt, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA46AA90", Offset = "0xA469E90", VA = "0x18A46AA90")]
		[IteratorStateMachine(typeof(<Expand>d__51))]
		public IEnumerable<float> Expand(int count)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA46AE40", Offset = "0xA46A240", VA = "0x18A46AE40")]
		[IteratorStateMachine(typeof(<GetIndexedWeights>d__52))]
		public IEnumerable<(int, float)> GetIndexedWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA46AED0", Offset = "0xA46A2D0", VA = "0x18A46AED0")]
		[IteratorStateMachine(typeof(<GetNonZeroWeights>d__53))]
		public IEnumerable<(int, float)> GetNonZeroWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA469880", Offset = "0xA468C80", VA = "0x18A469880")]
		public static SparseWeight8 Blend(ReadOnlySpan<SparseWeight8> sparses, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA46B240", Offset = "0xA46A640", VA = "0x18A46B240")]
		public SparseWeight8 GetTrimmed(int maxWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA46B0F0", Offset = "0xA46A4F0", VA = "0x18A46B0F0")]
		public SparseWeight8 GetNormalized()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA46C1F0", Offset = "0xA46B5F0", VA = "0x18A46C1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA46CB70", Offset = "0xA46BF70", VA = "0x18A46CB70")]
		private static SparseWeight8 _OperateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, Func<float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA46C6C0", Offset = "0xA46BAC0", VA = "0x18A46C6C0")]
		private static SparseWeight8 _OperateCubic([In] SparseWeight8 x, [In] SparseWeight8 y, [In] SparseWeight8 z, [In] SparseWeight8 w, Func<float, float, float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA46AB30", Offset = "0xA469F30", VA = "0x18A46AB30")]
		private float GetExpandedAt(int idx)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA46AB90", Offset = "0xA469F90", VA = "0x18A46AB90")]
		private int GetExpandedCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA46AF60", Offset = "0xA46A360", VA = "0x18A46AF60")]
		internal SparseWeight8 GetNormalizedWithComplement(int complementIndex)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA46C440", Offset = "0xA46B840", VA = "0x18A46C440")]
		internal int _GetMaxIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA46C630", Offset = "0xA46BA30", VA = "0x18A46C630")]
		[IteratorStateMachine(typeof(<_GetPairs>d__64))]
		internal IEnumerable<IndexWeight> _GetPairs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA46B380", Offset = "0xA46A780", VA = "0x18A46B380")]
		internal int InsertTo(Span<IndexWeight> dst)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA469AF0", Offset = "0xA468EF0", VA = "0x18A469AF0")]
		internal void CopyTo(Span<IndexWeight> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA469680", Offset = "0xA468A80", VA = "0x18A469680")]
		internal static (SparseWeight8, SparseWeight8, SparseWeight8) AsTuple(float[] tangentIn, float[] value, float[] tangentOut)
		{
			return default((SparseWeight8, SparseWeight8, SparseWeight8));
		}
	}
}
namespace SharpGLTF.Schema2
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	public class XmpPackets : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__6 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public XmpPackets <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600020D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600020F")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xA48A2E0", Offset = "0xA4896E0", VA = "0x18A48A2E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xA489FB0", Offset = "0xA4893B0", VA = "0x18A489FB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA48A3A0", Offset = "0xA4897A0", VA = "0x18A48A3A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xA48A2A0", Offset = "0xA4896A0", VA = "0x18A48A2A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA48A200", Offset = "0xA489600", VA = "0x18A48A200", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xA48A200", Offset = "0xA489600", VA = "0x18A48A200", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public new const string SCHEMANAME = "KHR_xmp_json_ld";

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private const int _packetsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private List<JsonNode> _packets;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public IReadOnlyList<JsonNode> JsonPackets
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA48C950", Offset = "0xA48BD50", VA = "0x18A48C950")]
		internal XmpPackets(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA48C460", Offset = "0xA48B860", VA = "0x18A48C460")]
		public int AddPacket(JsonNode packet)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA48C650", Offset = "0xA48BA50", VA = "0x18A48C650", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA48C680", Offset = "0xA48BA80", VA = "0x18A48C680", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__6))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA48C7B0", Offset = "0xA48BBB0", VA = "0x18A48C7B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA48C700", Offset = "0xA48BB00", VA = "0x18A48C700", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA48C5B0", Offset = "0xA48B9B0", VA = "0x18A48C5B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	public class XmpPacketReference : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__11 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public XmpPacketReference <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA484F10", Offset = "0xA484310", VA = "0x18A484F10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA484BE0", Offset = "0xA483FE0", VA = "0x18A484BE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA484FD0", Offset = "0xA4843D0", VA = "0x18A484FD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xA484ED0", Offset = "0xA4842D0", VA = "0x18A484ED0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xA484E30", Offset = "0xA484230", VA = "0x18A484E30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xA484E30", Offset = "0xA484230", VA = "0x18A484E30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private ExtraProperties _Owner;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public new const string SCHEMANAME = "KHR_xmp_json_ld";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private int _packet;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int PacketLogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xCFB3C0", Offset = "0xCFA7C0", VA = "0x180CFB3C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public JsonNode JsonPacket
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xA48C380", Offset = "0xA48B780", VA = "0x18A48C380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA48C340", Offset = "0xA48B740", VA = "0x18A48C340")]
		internal XmpPacketReference(ExtraProperties owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA48C210", Offset = "0xA48B610", VA = "0x18A48C210")]
		private ModelRoot _FindRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA48C290", Offset = "0xA48B690", VA = "0x18A48C290")]
		private XmpPackets _GetPackets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA48BF00", Offset = "0xA48B300", VA = "0x18A48BF00")]
		public void SetPacket(int logicalIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA48BDC0", Offset = "0xA48B1C0", VA = "0x18A48BDC0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA48BDF0", Offset = "0xA48B1F0", VA = "0x18A48BDF0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__11))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA48C070", Offset = "0xA48B470", VA = "0x18A48C070", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA48BE70", Offset = "0xA48B270", VA = "0x18A48BE70", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA48BD20", Offset = "0xA48B120", VA = "0x18A48BD20", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class AnimationPointer : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AnimationPointer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA489220", Offset = "0xA488620", VA = "0x18A489220", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA486110", Offset = "0xA485510", VA = "0x18A486110", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA489D80", Offset = "0xA489180", VA = "0x18A489D80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA4889A0", Offset = "0xA487DA0", VA = "0x18A4889A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA4880A0", Offset = "0xA4874A0", VA = "0x18A4880A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA4880A0", Offset = "0xA4874A0", VA = "0x18A4880A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public new const string SCHEMANAME = "KHR_animation_pointer";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private string _pointer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private AnimationChannelTarget _LogicalParent;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string Pointer
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA4750C0", Offset = "0xA4744C0", VA = "0x18A4750C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA4750F0", Offset = "0xA4744F0", VA = "0x18A4750F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA475520", Offset = "0xA474920", VA = "0x18A475520", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA475170", Offset = "0xA474570", VA = "0x18A475170", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA475020", Offset = "0xA474420", VA = "0x18A475020", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA4756D0", Offset = "0xA474AD0", VA = "0x18A4756D0")]
		public AnimationPointer(AnimationChannelTarget parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA4752E0", Offset = "0xA4746E0", VA = "0x18A4752E0")]
		public static bool TryParseNodeTransform(string pointerPath, [Out] int nodeIndex, [Out] PropertyPath property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA4751D0", Offset = "0xA4745D0", VA = "0x18A4751D0")]
		public static bool TryParseNodeIndex(string pointerPath, [Out] int nodeIndex)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialAnisotropy : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__21 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public MaterialAnisotropy <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0xA481C60", Offset = "0xA481060", VA = "0x18A481C60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xA481770", Offset = "0xA480B70", VA = "0x18A481770", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xA481C20", Offset = "0xA481020", VA = "0x18A481C20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xA481B70", Offset = "0xA480F70", VA = "0x18A481B70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xA481B70", Offset = "0xA480F70", VA = "0x18A481B70", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public MaterialAnisotropy <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000050")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000051")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xA489820", Offset = "0xA488C20", VA = "0x18A489820", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xA4853A0", Offset = "0xA4847A0", VA = "0x18A4853A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xA489C90", Offset = "0xA489090", VA = "0x18A489C90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xA488C20", Offset = "0xA488020", VA = "0x18A488C20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA487EC0", Offset = "0xA4872C0", VA = "0x18A487EC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA487EC0", Offset = "0xA4872C0", VA = "0x18A487EC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public new const string SCHEMANAME = "KHR_materials_anisotropy";

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private const double _anisotropyRotationDefault = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private double? _anisotropyRotation;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private const double _anisotropyStrengthDefault = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private const double _anisotropyStrengthMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private const double _anisotropyStrengthMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private double? _anisotropyStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private TextureInfo _anisotropyTexture;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float AnisotropyStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xA475FC0", Offset = "0xA4753C0", VA = "0x18A475FC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA476010", Offset = "0xA475410", VA = "0x18A476010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float AnisotropyRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA476090", Offset = "0xA475490", VA = "0x18A476090")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA4760E0", Offset = "0xA4754E0", VA = "0x18A4760E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA4758C0", Offset = "0xA474CC0", VA = "0x18A4758C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA4759E0", Offset = "0xA474DE0", VA = "0x18A4759E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA475BB0", Offset = "0xA474FB0", VA = "0x18A475BB0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA475A60", Offset = "0xA474E60", VA = "0x18A475A60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA475710", Offset = "0xA474B10", VA = "0x18A475710", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA476190", Offset = "0xA475590", VA = "0x18A476190")]
		internal MaterialAnisotropy(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA4758F0", Offset = "0xA474CF0", VA = "0x18A4758F0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA475830", Offset = "0xA474C30", VA = "0x18A475830")]
		[IteratorStateMachine(typeof(<GetChannels>d__21))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialClearCoat : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__28 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public MaterialClearCoat <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x17000054")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0xA483AB0", Offset = "0xA482EB0", VA = "0x18A483AB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__28(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xA483260", Offset = "0xA482660", VA = "0x18A483260", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA483A70", Offset = "0xA482E70", VA = "0x18A483A70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xA4839C0", Offset = "0xA482DC0", VA = "0x18A4839C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xA4839C0", Offset = "0xA482DC0", VA = "0x18A4839C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public MaterialClearCoat <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xA489460", Offset = "0xA488860", VA = "0x18A489460", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xA485020", Offset = "0xA484420", VA = "0x18A485020", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xA489E20", Offset = "0xA489220", VA = "0x18A489E20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA488A60", Offset = "0xA487E60", VA = "0x18A488A60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA487F60", Offset = "0xA487360", VA = "0x18A487F60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA487F60", Offset = "0xA487360", VA = "0x18A487F60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public new const string SCHEMANAME = "KHR_materials_clearcoat";

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private const double _clearcoatFactorDefault = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private const double _clearcoatFactorMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private const double _clearcoatFactorMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private double? _clearcoatFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private MaterialNormalTextureInfo _clearcoatNormalTexture;

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private const double _clearcoatRoughnessFactorDefault = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private const double _clearcoatRoughnessFactorMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private const double _clearcoatRoughnessFactorMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private double? _clearcoatRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TextureInfo _clearcoatRoughnessTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private TextureInfo _clearcoatTexture;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float ClearCoatFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xA476D70", Offset = "0xA476170", VA = "0x18A476D70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA476DC0", Offset = "0xA4761C0", VA = "0x18A476DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA476EE0", Offset = "0xA4762E0", VA = "0x18A476EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xA476F30", Offset = "0xA476330", VA = "0x18A476F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA476440", Offset = "0xA475840", VA = "0x18A476440", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA4765C0", Offset = "0xA4759C0", VA = "0x18A4765C0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA4767E0", Offset = "0xA475BE0", VA = "0x18A4767E0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA476640", Offset = "0xA475A40", VA = "0x18A476640", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA476210", Offset = "0xA475610", VA = "0x18A476210", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA477290", Offset = "0xA476690", VA = "0x18A477290")]
		internal MaterialClearCoat(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA476470", Offset = "0xA475870", VA = "0x18A476470", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA477200", Offset = "0xA476600", VA = "0x18A477200")]
		private TextureInfo _GetClearCoatTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA477170", Offset = "0xA476570", VA = "0x18A477170")]
		private TextureInfo _GetClearCoatRoughnessTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA4770E0", Offset = "0xA4764E0", VA = "0x18A4770E0")]
		private MaterialNormalTextureInfo _GetClearCoatNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA4763B0", Offset = "0xA4757B0", VA = "0x18A4763B0")]
		[IteratorStateMachine(typeof(<GetChannels>d__28))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialDiffuseTransmission : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__22 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public MaterialDiffuseTransmission <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xA482A00", Offset = "0xA481E00", VA = "0x18A482A00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA482270", Offset = "0xA481670", VA = "0x18A482270", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xA4829C0", Offset = "0xA481DC0", VA = "0x18A4829C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA4828D0", Offset = "0xA481CD0", VA = "0x18A4828D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA4828D0", Offset = "0xA481CD0", VA = "0x18A4828D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public MaterialDiffuseTransmission <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xA489160", Offset = "0xA488560", VA = "0x18A489160", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA487BA0", Offset = "0xA486FA0", VA = "0x18A487BA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xA489BA0", Offset = "0xA488FA0", VA = "0x18A489BA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA488C60", Offset = "0xA488060", VA = "0x18A488C60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA488280", Offset = "0xA487680", VA = "0x18A488280", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xA488280", Offset = "0xA487680", VA = "0x18A488280", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public new const string SCHEMANAME = "KHR_materials_diffuse_transmission";

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly Vector3 _diffuseTransmissionColorFactorDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private Vector3? _diffuseTransmissionColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TextureInfo _diffuseTransmissionColorTexture;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private const double _diffuseTransmissionFactorDefault = 0.0;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private const double _diffuseTransmissionFactorMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private const double _diffuseTransmissionFactorMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private double? _diffuseTransmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private TextureInfo _diffuseTransmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public float DiffuseTransmissionFactor
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA477D60", Offset = "0xA477160", VA = "0x18A477D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA477DB0", Offset = "0xA4771B0", VA = "0x18A477DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 DiffuseTransmissionColorFactor
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xA477EA0", Offset = "0xA4772A0", VA = "0x18A477EA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xA477F60", Offset = "0xA477360", VA = "0x18A477F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA477510", Offset = "0xA476910", VA = "0x18A477510", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA477630", Offset = "0xA476A30", VA = "0x18A477630", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xA477870", Offset = "0xA476C70", VA = "0x18A477870", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xA4776B0", Offset = "0xA476AB0", VA = "0x18A4776B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA477310", Offset = "0xA476710", VA = "0x18A477310", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA478060", Offset = "0xA477460", VA = "0x18A478060")]
		internal MaterialDiffuseTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA477540", Offset = "0xA476940", VA = "0x18A477540", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA477480", Offset = "0xA476880", VA = "0x18A477480")]
		[IteratorStateMachine(typeof(<GetChannels>d__22))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialDispersion : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public MaterialDispersion <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xA4899A0", Offset = "0xA488DA0", VA = "0x18A4899A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xA4858F0", Offset = "0xA484CF0", VA = "0x18A4858F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xA489C40", Offset = "0xA489040", VA = "0x18A489C40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA488CA0", Offset = "0xA4880A0", VA = "0x18A488CA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA488500", Offset = "0xA487900", VA = "0x18A488500", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA488500", Offset = "0xA487900", VA = "0x18A488500", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public new const string SCHEMANAME = "KHR_materials_dispersion";

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private const double _dispersionDefault = 0.0;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private const double _dispersionMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private double? _dispersion;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static float DefaultDispersion
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xD44BF0", Offset = "0xD43FF0", VA = "0x180D44BF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA478610", Offset = "0xA477A10", VA = "0x18A478610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA478660", Offset = "0xA477A60", VA = "0x18A478660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA4781D0", Offset = "0xA4775D0", VA = "0x18A4781D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA4782D0", Offset = "0xA4776D0", VA = "0x18A4782D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA478410", Offset = "0xA477810", VA = "0x18A478410", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA478350", Offset = "0xA477750", VA = "0x18A478350", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA478130", Offset = "0xA477530", VA = "0x18A478130", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA4785B0", Offset = "0xA4779B0", VA = "0x18A4785B0")]
		internal MaterialDispersion(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA478200", Offset = "0xA477600", VA = "0x18A478200", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialIOR : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public MaterialIOR <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002F2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002F4")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xA4896A0", Offset = "0xA488AA0", VA = "0x18A4896A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xA486850", Offset = "0xA485C50", VA = "0x18A486850", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xA489B50", Offset = "0xA488F50", VA = "0x18A489B50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xA488CE0", Offset = "0xA4880E0", VA = "0x18A488CE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xA488140", Offset = "0xA487540", VA = "0x18A488140", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA488140", Offset = "0xA487540", VA = "0x18A488140", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public new const string SCHEMANAME = "KHR_materials_ior";

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private const double _iorDefault = 1.5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private double? _ior;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public static float DefaultIndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xA4792F0", Offset = "0xA4786F0", VA = "0x18A4792F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xA479300", Offset = "0xA478700", VA = "0x18A479300")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xA479350", Offset = "0xA478750", VA = "0x18A479350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA478E80", Offset = "0xA478280", VA = "0x18A478E80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA478FB0", Offset = "0xA4783B0", VA = "0x18A478FB0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA4790F0", Offset = "0xA4784F0", VA = "0x18A4790F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA479030", Offset = "0xA478430", VA = "0x18A479030", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA478DE0", Offset = "0xA4781E0", VA = "0x18A478DE0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA479290", Offset = "0xA478690", VA = "0x18A479290")]
		internal MaterialIOR(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA478EB0", Offset = "0xA4782B0", VA = "0x18A478EB0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialIridescence : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__35 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public MaterialIridescence <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000321")]
				[Cpp2IlInjected.Address(RVA = "0xA484350", Offset = "0xA483750", VA = "0x18A484350", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__35(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA483B10", Offset = "0xA482F10", VA = "0x18A483B10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA484310", Offset = "0xA483710", VA = "0x18A484310", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA484260", Offset = "0xA483660", VA = "0x18A484260", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA484260", Offset = "0xA483660", VA = "0x18A484260", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public MaterialIridescence <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600032A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xA489520", Offset = "0xA488920", VA = "0x18A489520", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0xA4877D0", Offset = "0xA486BD0", VA = "0x18A4877D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xA489A60", Offset = "0xA488E60", VA = "0x18A489A60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xA488BE0", Offset = "0xA487FE0", VA = "0x18A488BE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xA4886E0", Offset = "0xA487AE0", VA = "0x18A4886E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xA4886E0", Offset = "0xA487AE0", VA = "0x18A4886E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public new const string SCHEMANAME = "KHR_materials_iridescence";

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private const double _iridescenceFactorDefault = 0.0;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private const double _iridescenceFactorMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private const double _iridescenceFactorMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private double? _iridescenceFactor;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private const double _iridescenceIorDefault = 1.3;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private const double _iridescenceIorMinimum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private double? _iridescenceIor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private TextureInfo _iridescenceTexture;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private const double _iridescenceThicknessMaximumDefault = 400.0;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private const double _iridescenceThicknessMaximumMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private double? _iridescenceThicknessMaximum;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private const double _iridescenceThicknessMinimumDefault = 100.0;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private const double _iridescenceThicknessMinimumMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private double? _iridescenceThicknessMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TextureInfo _iridescenceThicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public float IridescenceFactor
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xA47A270", Offset = "0xA479670", VA = "0x18A47A270")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA47A2C0", Offset = "0xA4796C0", VA = "0x18A47A2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float IridescenceIndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xA47A340", Offset = "0xA479740", VA = "0x18A47A340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xA47A3A0", Offset = "0xA4797A0", VA = "0x18A47A3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float IridescenceThicknessMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xA47A490", Offset = "0xA479890", VA = "0x18A47A490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xA47A4F0", Offset = "0xA4798F0", VA = "0x18A47A4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float IridescenceThicknessMaximum
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xA47A120", Offset = "0xA479520", VA = "0x18A47A120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xA47A180", Offset = "0xA479580", VA = "0x18A47A180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA4795F0", Offset = "0xA4789F0", VA = "0x18A4795F0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA479850", Offset = "0xA478C50", VA = "0x18A479850", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA479B00", Offset = "0xA478F00", VA = "0x18A479B00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA4798D0", Offset = "0xA478CD0", VA = "0x18A4798D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4793C0", Offset = "0xA4787C0", VA = "0x18A4793C0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA47A570", Offset = "0xA479970", VA = "0x18A47A570")]
		internal MaterialIridescence(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA479620", Offset = "0xA478A20", VA = "0x18A479620", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA479560", Offset = "0xA478960", VA = "0x18A479560")]
		[IteratorStateMachine(typeof(<GetChannels>d__35))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialEmissiveStrength : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			public MaterialEmissiveStrength <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000342")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000344")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xA488E60", Offset = "0xA488260", VA = "0x18A488E60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xA4856A0", Offset = "0xA484AA0", VA = "0x18A4856A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xA489D30", Offset = "0xA489130", VA = "0x18A489D30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA488AE0", Offset = "0xA487EE0", VA = "0x18A488AE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xA488820", Offset = "0xA487C20", VA = "0x18A488820", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA488820", Offset = "0xA487C20", VA = "0x18A488820", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public new const string SCHEMANAME = "KHR_materials_emissive_strength";

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private const double _emissiveStrengthDefault = 1.0;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private const double _emissiveStrengthMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private double? _emissiveStrength;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public const float DefaultEmissiveStrength = 1f;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float EmissiveStrength
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0xA478D10", Offset = "0xA478110", VA = "0x18A478D10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xA478D60", Offset = "0xA478160", VA = "0x18A478D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA4788D0", Offset = "0xA477CD0", VA = "0x18A4788D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA4789D0", Offset = "0xA477DD0", VA = "0x18A4789D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA478B10", Offset = "0xA477F10", VA = "0x18A478B10", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA478A50", Offset = "0xA477E50", VA = "0x18A478A50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA4786F0", Offset = "0xA477AF0", VA = "0x18A4786F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA478CB0", Offset = "0xA4780B0", VA = "0x18A478CB0")]
		internal MaterialEmissiveStrength(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA478900", Offset = "0xA477D00", VA = "0x18A478900", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA478790", Offset = "0xA477B90", VA = "0x18A478790")]
		public static _MaterialParameter<float> GetParameter(Material material)
		{
			return default(_MaterialParameter<float>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialVolume : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__25 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public MaterialVolume <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000368")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600036A")]
				[Cpp2IlInjected.Address(RVA = "0xA483200", Offset = "0xA482600", VA = "0x18A483200", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA482AC0", Offset = "0xA481EC0", VA = "0x18A482AC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA4831C0", Offset = "0xA4825C0", VA = "0x18A4831C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xA483110", Offset = "0xA482510", VA = "0x18A483110", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA483110", Offset = "0xA482510", VA = "0x18A483110", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public MaterialVolume <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000371")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA489760", Offset = "0xA488B60", VA = "0x18A489760", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA486AA0", Offset = "0xA485EA0", VA = "0x18A486AA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA489AB0", Offset = "0xA488EB0", VA = "0x18A489AB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA488A20", Offset = "0xA487E20", VA = "0x18A488A20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA488640", Offset = "0xA487A40", VA = "0x18A488640", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA488640", Offset = "0xA487A40", VA = "0x18A488640", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public new const string SCHEMANAME = "KHR_materials_volume";

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly Vector3 _attenuationColorDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private Vector3? _attenuationColor;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private const double _attenuationDistanceExclusiveMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private double? _attenuationDistance;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private const double _thicknessFactorDefault = 0.0;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private const double _thicknessFactorMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private double? _thicknessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TextureInfo _thicknessTexture;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float ThicknessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA47D410", Offset = "0xA47C810", VA = "0x18A47D410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA47D460", Offset = "0xA47C860", VA = "0x18A47D460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 AttenuationColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA47D4E0", Offset = "0xA47C8E0", VA = "0x18A47D4E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0xA47D5A0", Offset = "0xA47C9A0", VA = "0x18A47D5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float AttenuationDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA47D650", Offset = "0xA47CA50", VA = "0x18A47D650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xA47D6B0", Offset = "0xA47CAB0", VA = "0x18A47D6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA47CA80", Offset = "0xA47BE80", VA = "0x18A47CA80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA47CCA0", Offset = "0xA47C0A0", VA = "0x18A47CCA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA47CF00", Offset = "0xA47C300", VA = "0x18A47CF00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA47CD20", Offset = "0xA47C120", VA = "0x18A47CD20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA47C880", Offset = "0xA47BC80", VA = "0x18A47C880", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA47D770", Offset = "0xA47CB70", VA = "0x18A47D770")]
		internal MaterialVolume(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA47CAB0", Offset = "0xA47BEB0", VA = "0x18A47CAB0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA47C9F0", Offset = "0xA47BDF0", VA = "0x18A47C9F0")]
		[IteratorStateMachine(typeof(<GetChannels>d__25))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("{Count}")]
	public class MeshGpuInstancing : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public MeshGpuInstancing <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000394")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xA4895E0", Offset = "0xA4889E0", VA = "0x18A4895E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xA485B40", Offset = "0xA484F40", VA = "0x18A485B40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xA489B00", Offset = "0xA488F00", VA = "0x18A489B00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA488960", Offset = "0xA487D60", VA = "0x18A488960", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xA488320", Offset = "0xA487720", VA = "0x18A488320", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xA488320", Offset = "0xA487720", VA = "0x18A488320", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class <_GetLocalTransforms>d__21 : IEnumerable<AffineTransform>, IEnumerable, IEnumerator<AffineTransform>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			private AffineTransform <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public MeshGpuInstancing <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			private int <c>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private int <i>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			AffineTransform IEnumerator<AffineTransform>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600039C")]
				[Cpp2IlInjected.Address(RVA = "0x5B73F20", Offset = "0x5B73320", VA = "0x185B73F20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(AffineTransform);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xA48B8B0", Offset = "0xA48ACB0", VA = "0x18A48B8B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x64B5A80", Offset = "0x64B4E80", VA = "0x1864B5A80")]
			[DebuggerHidden]
			public <_GetLocalTransforms>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA48B710", Offset = "0xA48AB10", VA = "0x18A48B710", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA48B870", Offset = "0xA48AC70", VA = "0x18A48B870", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xA48B7D0", Offset = "0xA48ABD0", VA = "0x18A48B7D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<AffineTransform> IEnumerable<AffineTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xA48B7D0", Offset = "0xA48ABD0", VA = "0x18A48B7D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public new const string SCHEMANAME = "EXT_mesh_gpu_instancing";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private Dictionary<string, int> _attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private readonly Node _Owner;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Node LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Node VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xA47E8C0", Offset = "0xA47DCC0", VA = "0x18A47E8C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IReadOnlyDictionary<string, Accessor> Accessors
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0xA47E5F0", Offset = "0xA47D9F0", VA = "0x18A47E5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public IEnumerable<AffineTransform> LocalTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xA47E7B0", Offset = "0xA47DBB0", VA = "0x18A47E7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE60", Offset = "0xA47D260", VA = "0x18A47DE60", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA47E0B0", Offset = "0xA47D4B0", VA = "0x18A47E0B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA47E370", Offset = "0xA47D770", VA = "0x18A47E370", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA47E130", Offset = "0xA47D530", VA = "0x18A47E130", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA47D890", Offset = "0xA47CC90", VA = "0x18A47D890", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA47E830", Offset = "0xA47DC30", VA = "0x18A47E830")]
		internal MeshGpuInstancing(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA47E6C0", Offset = "0xA47DAC0", VA = "0x18A47E6C0")]
		private int _GetCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA47E5F0", Offset = "0xA47D9F0", VA = "0x18A47E5F0")]
		private IReadOnlyDictionary<string, Accessor> _GetAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA47E7B0", Offset = "0xA47DBB0", VA = "0x18A47E7B0")]
		[IteratorStateMachine(typeof(<_GetLocalTransforms>d__21))]
		private IEnumerable<AffineTransform> _GetLocalTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA47D840", Offset = "0xA47CC40", VA = "0x18A47D840")]
		public void ClearAccessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA47D930", Offset = "0xA47CD30", VA = "0x18A47D930")]
		public Accessor GetAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA47E1A0", Offset = "0xA47D5A0", VA = "0x18A47E1A0")]
		public void SetAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA47DB10", Offset = "0xA47CF10", VA = "0x18A47DB10")]
		public AffineTransform GetLocalTransform(int index)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA47DA30", Offset = "0xA47CE30", VA = "0x18A47DA30")]
		public Matrix4x4 GetLocalMatrix(int index)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE90", Offset = "0xA47D290", VA = "0x18A47DE90")]
		public Matrix4x4 GetWorldMatrix(int index)
		{
			return default(Matrix4x4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal class PunctualLightSpot : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public PunctualLightSpot <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003B5")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003B7")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xA488F20", Offset = "0xA488320", VA = "0x18A488F20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xA486360", Offset = "0xA485760", VA = "0x18A486360", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xA489F60", Offset = "0xA489360", VA = "0x18A489F60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xA488D20", Offset = "0xA488120", VA = "0x18A488D20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xA4888C0", Offset = "0xA487CC0", VA = "0x18A4888C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xA4888C0", Offset = "0xA487CC0", VA = "0x18A4888C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public new const string SCHEMANAME = "spot";

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private const double _innerConeAngleDefault = 0.0;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private const double _innerConeAngleMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private const double _innerConeAngleExclusiveMaximum = Math.PI / 2.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private double? _innerConeAngle;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private const double _outerConeAngleDefault = Math.PI / 4.0;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private const double _outerConeAngleExclusiveMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private const double _outerConeAngleMaximum = Math.PI / 2.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private double? _outerConeAngle;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float InnerConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xA47F180", Offset = "0xA47E580", VA = "0x18A47F180")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA47F230", Offset = "0xA47E630", VA = "0x18A47F230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA47F1D0", Offset = "0xA47E5D0", VA = "0x18A47F1D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA47F350", Offset = "0xA47E750", VA = "0x18A47F350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA47E9A0", Offset = "0xA47DDA0", VA = "0x18A47E9A0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA47ECC0", Offset = "0xA47E0C0", VA = "0x18A47ECC0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA47EE60", Offset = "0xA47E260", VA = "0x18A47EE60", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA47ED40", Offset = "0xA47E140", VA = "0x18A47ED40", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA47E8D0", Offset = "0xA47DCD0", VA = "0x18A47E8D0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA47E9D0", Offset = "0xA47DDD0", VA = "0x18A47E9D0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA47F0F0", Offset = "0xA47E4F0", VA = "0x18A47F0F0")]
		public PunctualLightSpot()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("{LightType} {Color} {Intensity} {Range}")]
	public sealed class PunctualLight : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public PunctualLight <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003DC")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003DE")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xA488FE0", Offset = "0xA4883E0", VA = "0x18A488FE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA485D90", Offset = "0xA485190", VA = "0x18A485D90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xA489CE0", Offset = "0xA4890E0", VA = "0x18A489CE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xA488B60", Offset = "0xA487F60", VA = "0x18A488B60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xA488780", Offset = "0xA487B80", VA = "0x18A488780", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xA488780", Offset = "0xA487B80", VA = "0x18A488780", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public new const string SCHEMANAME = "light";

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private static readonly Vector3 _colorDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private Vector3? _color;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private const double _intensityDefault = 1.0;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private const double _intensityMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private double? _intensity;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private const double _rangeExclusiveMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private double? _range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private PunctualLightSpot _spot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private string _type;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private const double _rangeDefault = 1.0 / 0.0;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0xA480C60", Offset = "0xA480060", VA = "0x18A480C60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public PunctualLightType LightType
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xA480B80", Offset = "0xA47FF80", VA = "0x18A480B80")]
			get
			{
				return default(PunctualLightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public float InnerConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xA480AC0", Offset = "0xA47FEC0", VA = "0x18A480AC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xA480D00", Offset = "0xA480100", VA = "0x18A480D00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xA480A00", Offset = "0xA47FE00", VA = "0x18A480A00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA480DC0", Offset = "0xA4801C0", VA = "0x18A480DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xA480B20", Offset = "0xA47FF20", VA = "0x18A480B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xA480EE0", Offset = "0xA4802E0", VA = "0x18A480EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float Range
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xA480D60", Offset = "0xA480160", VA = "0x18A480D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0xA480F60", Offset = "0xA480360", VA = "0x18A480F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA47F630", Offset = "0xA47EA30", VA = "0x18A47F630", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA47F920", Offset = "0xA47ED20", VA = "0x18A47F920", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA480140", Offset = "0xA47F540", VA = "0x18A480140", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA47F9A0", Offset = "0xA47EDA0", VA = "0x18A47F9A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA47F470", Offset = "0xA47E870", VA = "0x18A47F470", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA480920", Offset = "0xA47FD20", VA = "0x18A480920")]
		internal PunctualLight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA480730", Offset = "0xA47FB30", VA = "0x18A480730")]
		internal PunctualLight(PunctualLightType ltype)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA47FDF0", Offset = "0xA47F1F0", VA = "0x18A47FDF0")]
		public void SetSpotCone(float innerConeAngle, float outerConeAngle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA47FBA0", Offset = "0xA47EFA0", VA = "0x18A47FBA0")]
		public void SetColor(Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA47F730", Offset = "0xA47EB30", VA = "0x18A47F730", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA47F660", Offset = "0xA47EA60", VA = "0x18A47F660", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal class _ModelPunctualLights : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public _ModelPunctualLights <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003F3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xA4898E0", Offset = "0xA488CE0", VA = "0x18A4898E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xA486600", Offset = "0xA485A00", VA = "0x18A486600", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xA489EC0", Offset = "0xA4892C0", VA = "0x18A489EC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xA488AA0", Offset = "0xA487EA0", VA = "0x18A488AA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xA488000", Offset = "0xA487400", VA = "0x18A488000", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xA488000", Offset = "0xA487400", VA = "0x18A488000", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public new const string SCHEMANAME = "KHR_lights_punctual";

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private const int _lightsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private ChildrenList<PunctualLight, ModelRoot> _lights;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public IReadOnlyList<PunctualLight> Lights
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA48CB20", Offset = "0xA48BF20", VA = "0x18A48CB20", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA48CB50", Offset = "0xA48BF50", VA = "0x18A48CB50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA48CC80", Offset = "0xA48C080", VA = "0x18A48CC80", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA48CBD0", Offset = "0xA48BFD0", VA = "0x18A48CBD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA48CA80", Offset = "0xA48BE80", VA = "0x18A48CA80", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA48CE20", Offset = "0xA48C220", VA = "0x18A48CE20")]
		internal _ModelPunctualLights(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA48C9D0", Offset = "0xA48BDD0", VA = "0x18A48C9D0")]
		public PunctualLight CreateLight(string name, PunctualLightType ltype)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal class TextureDDS : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public TextureDDS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000408")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA4893A0", Offset = "0xA4887A0", VA = "0x18A4893A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA487580", Offset = "0xA486980", VA = "0x18A487580", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA489E70", Offset = "0xA489270", VA = "0x18A489E70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA4889E0", Offset = "0xA487DE0", VA = "0x18A4889E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA4885A0", Offset = "0xA4879A0", VA = "0x18A4885A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA4885A0", Offset = "0xA4879A0", VA = "0x18A4885A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public new const string SCHEMANAME = "MSFT_texture_dds";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private int? _source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private readonly Texture _Parent;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Image Image
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xA4813A0", Offset = "0xA4807A0", VA = "0x18A4813A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xA4814C0", Offset = "0xA4808C0", VA = "0x18A4814C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA4810E0", Offset = "0xA4804E0", VA = "0x18A4810E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA481110", Offset = "0xA480510", VA = "0x18A481110", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA481200", Offset = "0xA480600", VA = "0x18A481200", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA481190", Offset = "0xA480590", VA = "0x18A481190", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA481040", Offset = "0xA480440", VA = "0x18A481040", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4756D0", Offset = "0xA474AD0", VA = "0x18A4756D0")]
		internal TextureDDS(Texture parent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal class _NodePunctualLight : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public _NodePunctualLight <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA488DA0", Offset = "0xA4881A0", VA = "0x18A488DA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA487330", Offset = "0xA486730", VA = "0x18A487330", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xA489F10", Offset = "0xA489310", VA = "0x18A489F10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA488B20", Offset = "0xA487F20", VA = "0x18A488B20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA4881E0", Offset = "0xA4875E0", VA = "0x18A4881E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA4881E0", Offset = "0xA4875E0", VA = "0x18A4881E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public new const string SCHEMANAME = "KHR_lights_punctual";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private int _light;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public int LightIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xD47A90", Offset = "0xD46E90", VA = "0x180D47A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xA48CF50", Offset = "0xA48C350", VA = "0x18A48CF50", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xA48CF80", Offset = "0xA48C380", VA = "0x18A48CF80", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xA48D090", Offset = "0xA48C490", VA = "0x18A48D090", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xA48D000", Offset = "0xA48C400", VA = "0x18A48D000", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xA48CEB0", Offset = "0xA48C2B0", VA = "0x18A48CEB0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xA48D230", Offset = "0xA48C630", VA = "0x18A48D230")]
		internal _NodePunctualLight(Node node)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal class _NodeVisibility : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public _NodeVisibility <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000431")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000433")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA4892E0", Offset = "0xA4886E0", VA = "0x18A4892E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA4870E0", Offset = "0xA4864E0", VA = "0x18A4870E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA489DD0", Offset = "0xA4891D0", VA = "0x18A489DD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA488D60", Offset = "0xA488160", VA = "0x18A488D60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA488460", Offset = "0xA487860", VA = "0x18A488460", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA488460", Offset = "0xA487860", VA = "0x18A488460", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public new const string SCHEMANAME = "KHR_node_visibility";

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private static readonly bool _visibleDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private bool? _visible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private readonly Node _Owner;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xA48D6F0", Offset = "0xA48CAF0", VA = "0x18A48D6F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xA48D770", Offset = "0xA48CB70", VA = "0x18A48D770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA48D2E0", Offset = "0xA48C6E0", VA = "0x18A48D2E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xA48D310", Offset = "0xA48C710", VA = "0x18A48D310", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA48D460", Offset = "0xA48C860", VA = "0x18A48D460", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xA48D390", Offset = "0xA48C790", VA = "0x18A48D390", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xA48D240", Offset = "0xA48C640", VA = "0x18A48D240", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xA48D640", Offset = "0xA48CA40", VA = "0x18A48D640")]
		internal _NodeVisibility(Node node)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialSpecular : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__22 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public MaterialSpecular <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000455")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000457")]
				[Cpp2IlInjected.Address(RVA = "0xA482A60", Offset = "0xA481E60", VA = "0x18A482A60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xA481CC0", Offset = "0xA4810C0", VA = "0x18A481CC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA482980", Offset = "0xA481D80", VA = "0x18A482980", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA482820", Offset = "0xA481C20", VA = "0x18A482820", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA482820", Offset = "0xA481C20", VA = "0x18A482820", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public MaterialSpecular <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xA4890A0", Offset = "0xA4884A0", VA = "0x18A4890A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA486DC0", Offset = "0xA4861C0", VA = "0x18A486DC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA489BF0", Offset = "0xA488FF0", VA = "0x18A489BF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xA488BA0", Offset = "0xA487FA0", VA = "0x18A488BA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xA4883C0", Offset = "0xA4877C0", VA = "0x18A4883C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xA4883C0", Offset = "0xA4877C0", VA = "0x18A4883C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public new const string SCHEMANAME = "KHR_materials_specular";

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly Vector3 _specularColorFactorDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private Vector3? _specularColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private TextureInfo _specularColorTexture;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private const double _specularFactorDefault = 1.0;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private const double _specularFactorMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private const double _specularFactorMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private double? _specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private TextureInfo _specularTexture;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public Vector3 SpecularColor
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xA47C4A0", Offset = "0xA47B8A0", VA = "0x18A47C4A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA47C560", Offset = "0xA47B960", VA = "0x18A47C560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public float SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xA47C680", Offset = "0xA47BA80", VA = "0x18A47C680")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xA47C6E0", Offset = "0xA47BAE0", VA = "0x18A47C6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xA47BB40", Offset = "0xA47AF40", VA = "0x18A47BB40", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xA47BD60", Offset = "0xA47B160", VA = "0x18A47BD60", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA47BFB0", Offset = "0xA47B3B0", VA = "0x18A47BFB0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA47BDE0", Offset = "0xA47B1E0", VA = "0x18A47BDE0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xA47B940", Offset = "0xA47AD40", VA = "0x18A47B940", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xA47C7A0", Offset = "0xA47BBA0", VA = "0x18A47C7A0")]
		internal MaterialSpecular(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA47BB70", Offset = "0xA47AF70", VA = "0x18A47BB70", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA47BAB0", Offset = "0xA47AEB0", VA = "0x18A47BAB0")]
		[IteratorStateMachine(typeof(<GetChannels>d__22))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialPBRSpecularGlossiness : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__27 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public MaterialPBRSpecularGlossiness <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0xA4A56B0", Offset = "0xA4A4AB0", VA = "0x18A4A56B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4E90", Offset = "0xA4A4290", VA = "0x18A4A4E90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA4A5670", Offset = "0xA4A4A70", VA = "0x18A4A5670", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xA4A55C0", Offset = "0xA4A49C0", VA = "0x18A4A55C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xA4A55C0", Offset = "0xA4A49C0", VA = "0x18A4A55C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public MaterialPBRSpecularGlossiness <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8B80", Offset = "0xA4A7F80", VA = "0x18A4A8B80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xA4A5B50", Offset = "0xA4A4F50", VA = "0x18A4A5B50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9880", Offset = "0xA4A8C80", VA = "0x18A4A9880")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8B00", Offset = "0xA4A7F00", VA = "0x18A4A8B00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8300", Offset = "0xA4A7700", VA = "0x18A4A8300", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8300", Offset = "0xA4A7700", VA = "0x18A4A8300", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public new const string SCHEMANAME = "KHR_materials_pbrSpecularGlossiness";

		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private static readonly Vector4 _diffuseFactorDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private Vector4? _diffuseFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private TextureInfo _diffuseTexture;

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private const double _glossinessFactorDefault = 1.0;

		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private const double _glossinessFactorMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private const double _glossinessFactorMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private double? _glossinessFactor;

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private static readonly Vector3 _specularFactorDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private Vector3? _specularFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private TextureInfo _specularGlossinessTexture;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public Vector4 DiffuseFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xA47B390", Offset = "0xA47A790", VA = "0x18A47B390")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA47B440", Offset = "0xA47A840", VA = "0x18A47B440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA47B560", Offset = "0xA47A960", VA = "0x18A47B560")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA47B620", Offset = "0xA47AA20", VA = "0x18A47B620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public float GlossinessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA47B6D0", Offset = "0xA47AAD0", VA = "0x18A47B6D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xA47B730", Offset = "0xA47AB30", VA = "0x18A47B730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xA47A8A0", Offset = "0xA479CA0", VA = "0x18A47A8A0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xA47AAC0", Offset = "0xA479EC0", VA = "0x18A47AAC0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA47AD90", Offset = "0xA47A190", VA = "0x18A47AD90", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xA47AB40", Offset = "0xA479F40", VA = "0x18A47AB40", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xA47A650", Offset = "0xA479A50", VA = "0x18A47A650", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA47B810", Offset = "0xA47AC10", VA = "0x18A47B810")]
		internal MaterialPBRSpecularGlossiness(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA47A8D0", Offset = "0xA479CD0", VA = "0x18A47A8D0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA47A810", Offset = "0xA479C10", VA = "0x18A47A810")]
		[IteratorStateMachine(typeof(<GetChannels>d__27))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialSheen : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__22 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public MaterialSheen <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B4")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B6")]
				[Cpp2IlInjected.Address(RVA = "0xA4A4E30", Offset = "0xA4A4230", VA = "0x18A4A4E30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4790", Offset = "0xA4A3B90", VA = "0x18A4A4790", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4DF0", Offset = "0xA4A41F0", VA = "0x18A4A4DF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4D40", Offset = "0xA4A4140", VA = "0x18A4A4D40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4D40", Offset = "0xA4A4140", VA = "0x18A4A4D40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public MaterialSheen <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004BD")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004BF")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xA4A90C0", Offset = "0xA4A84C0", VA = "0x18A4A90C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xA4A66B0", Offset = "0xA4A5AB0", VA = "0x18A4A66B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9650", Offset = "0xA4A8A50", VA = "0x18A4A9650")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8800", Offset = "0xA4A7C00", VA = "0x18A4A8800", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8440", Offset = "0xA4A7840", VA = "0x18A4A8440", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8440", Offset = "0xA4A7840", VA = "0x18A4A8440", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public new const string SCHEMANAME = "KHR_materials_sheen";

		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private static readonly Vector3 _sheenColorFactorDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private Vector3? _sheenColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private TextureInfo _sheenColorTexture;

		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private const float _sheenRoughnessFactorDefault = 0f;

		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private const float _sheenRoughnessFactorMinimum = 0f;

		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private const float _sheenRoughnessFactorMaximum = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private float? _sheenRoughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private TextureInfo _sheenRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Vector3 ColorFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0xA4A1B00", Offset = "0xA4A0F00", VA = "0x18A4A1B00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xA4A1BC0", Offset = "0xA4A0FC0", VA = "0x18A4A1BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xA4A1CE0", Offset = "0xA4A10E0", VA = "0x18A4A1CE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xA4A1D20", Offset = "0xA4A1120", VA = "0x18A4A1D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xA4A11B0", Offset = "0xA4A05B0", VA = "0x18A4A11B0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xA4A13D0", Offset = "0xA4A07D0", VA = "0x18A4A13D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1610", Offset = "0xA4A0A10", VA = "0x18A4A1610", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1450", Offset = "0xA4A0850", VA = "0x18A4A1450", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0FB0", Offset = "0xA4A03B0", VA = "0x18A4A0FB0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1DC0", Offset = "0xA4A11C0", VA = "0x18A4A1DC0")]
		internal MaterialSheen(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xA4A11E0", Offset = "0xA4A05E0", VA = "0x18A4A11E0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1120", Offset = "0xA4A0520", VA = "0x18A4A1120")]
		[IteratorStateMachine(typeof(<GetChannels>d__22))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal class TextureKTX2 : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			public TextureKTX2 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000231")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9180", Offset = "0xA4A8580", VA = "0x18A4A9180", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xA4A5710", Offset = "0xA4A4B10", VA = "0x18A4A5710", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9740", Offset = "0xA4A8B40", VA = "0x18A4A9740")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8880", Offset = "0xA4A7C80", VA = "0x18A4A8880", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8120", Offset = "0xA4A7520", VA = "0x18A4A8120", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8120", Offset = "0xA4A7520", VA = "0x18A4A8120", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public new const string SCHEMANAME = "KHR_texture_basisu";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private int? _source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private readonly Texture _Parent;

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public Image Image
		{
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0xA4A2B40", Offset = "0xA4A1F40", VA = "0x18A4A2B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xA4A2BE0", Offset = "0xA4A1FE0", VA = "0x18A4A2BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2880", Offset = "0xA4A1C80", VA = "0x18A4A2880", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA4A28B0", Offset = "0xA4A1CB0", VA = "0x18A4A28B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA4A29A0", Offset = "0xA4A1DA0", VA = "0x18A4A29A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2930", Offset = "0xA4A1D30", VA = "0x18A4A2930", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA4A27E0", Offset = "0xA4A1BE0", VA = "0x18A4A27E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA4756D0", Offset = "0xA474AD0", VA = "0x18A4756D0")]
		internal TextureKTX2(Texture parent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("TextureTransform {Offset} {Scale} {Rotation} {TextureCoordinate}")]
	public sealed class TextureTransform : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			public TextureTransform <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000B6")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004F5")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9240", Offset = "0xA4A8640", VA = "0x18A4A9240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0xA4A6C20", Offset = "0xA4A6020", VA = "0x18A4A6C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9830", Offset = "0xA4A8C30", VA = "0x18A4A9830")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8840", Offset = "0xA4A7C40", VA = "0x18A4A8840", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0xA4A7FE0", Offset = "0xA4A73E0", VA = "0x18A4A7FE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0xA4A7FE0", Offset = "0xA4A73E0", VA = "0x18A4A7FE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public new const string SCHEMANAME = "KHR_texture_transform";

		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private static readonly Vector2 _offsetDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private Vector2? _offset;

		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private const double _rotationDefault = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private double? _rotation;

		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private static readonly Vector2 _scaleDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private Vector2? _scale;

		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private const int _texCoordMinimum = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private int? _texCoord;

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public Vector2 Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60004DD")]
			[Cpp2IlInjected.Address(RVA = "0xA4A3A70", Offset = "0xA4A2E70", VA = "0x18A4A3A70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xA4A3C00", Offset = "0xA4A3000", VA = "0x18A4A3C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xA4A3B60", Offset = "0xA4A2F60", VA = "0x18A4A3B60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xA4A3D10", Offset = "0xA4A3110", VA = "0x18A4A3D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xA4A3B10", Offset = "0xA4A2F10", VA = "0x18A4A3B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xA4A3CB0", Offset = "0xA4A30B0", VA = "0x18A4A3CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public int? TextureCoordinateOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0x89C3470", Offset = "0x89C2870", VA = "0x1889C3470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xA4A3DC0", Offset = "0xA4A31C0", VA = "0x18A4A3DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xA4A3760", Offset = "0xA4A2B60", VA = "0x18A4A3760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public Matrix3x2 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xA4A37D0", Offset = "0xA4A2BD0", VA = "0x18A4A37D0")]
			get
			{
				return default(Matrix3x2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2E90", Offset = "0xA4A2290", VA = "0x18A4A2E90", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2EC0", Offset = "0xA4A22C0", VA = "0x18A4A2EC0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3160", Offset = "0xA4A2560", VA = "0x18A4A3160", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2F40", Offset = "0xA4A2340", VA = "0x18A4A2F40", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2D20", Offset = "0xA4A2120", VA = "0x18A4A2D20", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3640", Offset = "0xA4A2A40", VA = "0x18A4A3640")]
		internal TextureTransform(TextureInfo parent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal class TextureWEBP : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			public TextureWEBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9000", Offset = "0xA4A8400", VA = "0x18A4A9000", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0xA4A69D0", Offset = "0xA4A5DD0", VA = "0x18A4A69D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0xA4A98D0", Offset = "0xA4A8CD0", VA = "0x18A4A98D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8B40", Offset = "0xA4A7F40", VA = "0x18A4A8B40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8620", Offset = "0xA4A7A20", VA = "0x18A4A8620", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8620", Offset = "0xA4A7A20", VA = "0x18A4A8620", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public new const string SCHEMANAME = "EXT_texture_webp";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private int? _source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private readonly Texture _Parent;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Image Image
		{
			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4130", Offset = "0xA4A3530", VA = "0x18A4A4130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0xA4A41D0", Offset = "0xA4A35D0", VA = "0x18A4A41D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3E70", Offset = "0xA4A3270", VA = "0x18A4A3E70", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3EA0", Offset = "0xA4A32A0", VA = "0x18A4A3EA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3F90", Offset = "0xA4A3390", VA = "0x18A4A3F90", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3F20", Offset = "0xA4A3320", VA = "0x18A4A3F20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xA4A3DD0", Offset = "0xA4A31D0", VA = "0x18A4A3DD0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA4756D0", Offset = "0xA474AD0", VA = "0x18A4756D0")]
		internal TextureWEBP(Texture parent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialTransmission : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__16 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			public MaterialTransmission <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x170000BC")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000525")]
				[Cpp2IlInjected.Address(RVA = "0xA4A4730", Offset = "0xA4A3B30", VA = "0x18A4A4730", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4310", Offset = "0xA4A3710", VA = "0x18A4A4310", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xA4A46F0", Offset = "0xA4A3AF0", VA = "0x18A4A46F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4640", Offset = "0xA4A3A40", VA = "0x18A4A4640", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xA4A4640", Offset = "0xA4A3A40", VA = "0x18A4A4640", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			public MaterialTransmission <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000BE")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600052E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9300", Offset = "0xA4A8700", VA = "0x18A4A9300", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0xA4A5ED0", Offset = "0xA4A52D0", VA = "0x18A4A5ED0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0xA4A96F0", Offset = "0xA4A8AF0", VA = "0x18A4A96F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8A80", Offset = "0xA4A7E80", VA = "0x18A4A8A80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xA4A81C0", Offset = "0xA4A75C0", VA = "0x18A4A81C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0xA4A81C0", Offset = "0xA4A75C0", VA = "0x18A4A81C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public new const string SCHEMANAME = "KHR_materials_transmission";

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private const double _transmissionFactorDefault = 0.0;

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private const double _transmissionFactorMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private const double _transmissionFactorMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private double? _transmissionFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TextureInfo _transmissionTexture;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public float TransmissionFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0xA4A25A0", Offset = "0xA4A19A0", VA = "0x18A4A25A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0xA4A25F0", Offset = "0xA4A19F0", VA = "0x18A4A25F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2010", Offset = "0xA4A1410", VA = "0x18A4A2010", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2130", Offset = "0xA4A1530", VA = "0x18A4A2130", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA4A22A0", Offset = "0xA4A16A0", VA = "0x18A4A22A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA4A21B0", Offset = "0xA4A15B0", VA = "0x18A4A21B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1E90", Offset = "0xA4A1290", VA = "0x18A4A1E90", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xA4A26A0", Offset = "0xA4A1AA0", VA = "0x18A4A26A0")]
		internal MaterialTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2040", Offset = "0xA4A1440", VA = "0x18A4A2040", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA4A1F80", Offset = "0xA4A1380", VA = "0x18A4A1F80")]
		[IteratorStateMachine(typeof(<GetChannels>d__16))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialUnlit : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public MaterialUnlit <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000C0")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C1")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8DC0", Offset = "0xA4A81C0", VA = "0x18A4A8DC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0xA4A5960", Offset = "0xA4A4D60", VA = "0x18A4A5960", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9600", Offset = "0xA4A8A00", VA = "0x18A4A9600")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8A00", Offset = "0xA4A7E00", VA = "0x18A4A8A00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8760", Offset = "0xA4A7B60", VA = "0x18A4A8760", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8760", Offset = "0xA4A7B60", VA = "0x18A4A8760", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public new const string SCHEMANAME = "KHR_materials_unlit";

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2710", Offset = "0xA4A1B10", VA = "0x18A4A2710", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2740", Offset = "0xA4A1B40", VA = "0x18A4A2740", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xA4A27D0", Offset = "0xA4A1BD0", VA = "0x18A4A27D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA4A27C0", Offset = "0xA4A1BC0", VA = "0x18A4A27C0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA4A2700", Offset = "0xA4A1B00", VA = "0x18A4A2700", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA48D230", Offset = "0xA48C630", VA = "0x18A48D230")]
		internal MaterialUnlit(Material material)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public enum IndexEncodingType
	{
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		UNSIGNED_BYTE = 5121,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		UNSIGNED_SHORT = 5123,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		UNSIGNED_INT = 5125
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum EncodingType
	{
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		BYTE = 5120,
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		UNSIGNED_BYTE = 5121,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		SHORT = 5122,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		UNSIGNED_SHORT = 5123,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		UNSIGNED_INT = 5125,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		FLOAT = 5126
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public enum DimensionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		SCALAR,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		VEC2,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		VEC3,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		VEC4,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		MAT2,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		MAT3,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		MAT4,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		CUSTOM
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum PropertyPath
	{
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		translation,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		rotation,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		scale,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		weights,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		pointer
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum AnimationInterpolationMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		LINEAR,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		STEP,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		CUBICSPLINE
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum BufferMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		ARRAY_BUFFER = 34962,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		ELEMENT_ARRAY_BUFFER
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public enum CameraType
	{
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		perspective,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		orthographic
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum AlphaMode
	{
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		OPAQUE,
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		MASK,
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		BLEND
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public enum PrimitiveType
	{
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		POINTS,
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		LINES,
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		LINE_LOOP,
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		LINE_STRIP,
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		TRIANGLES,
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		TRIANGLE_STRIP,
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		TRIANGLE_FAN
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public enum TextureInterpolationFilter
	{
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		NEAREST = 9728,
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		LINEAR = 9729,
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum TextureMipMapFilter
	{
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		NEAREST = 9728,
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		LINEAR = 9729,
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		NEAREST_MIPMAP_NEAREST = 9984,
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		LINEAR_MIPMAP_NEAREST = 9985,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		NEAREST_MIPMAP_LINEAR = 9986,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		LINEAR_MIPMAP_LINEAR = 9987,
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public enum TextureWrapMode
	{
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		CLAMP_TO_EDGE = 33071,
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		MIRRORED_REPEAT = 33648,
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		REPEAT = 10497
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	public abstract class LogicalChildOfRoot : ExtraProperties, IChildOfList<ModelRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public LogicalChildOfRoot <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000C5")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C6")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600055C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0xA4A93C0", Offset = "0xA4A87C0", VA = "0x18A4A93C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0xA4A6F40", Offset = "0xA4A6340", VA = "0x18A4A6F40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9920", Offset = "0xA4A8D20", VA = "0x18A4A9920")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8AC0", Offset = "0xA4A7EC0", VA = "0x18A4A8AC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8080", Offset = "0xA4A7480", VA = "0x18A4A8080", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8080", Offset = "0xA4A7480", VA = "0x18A4A8080", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public new const string SCHEMANAME = "glTFChildOfRootProperty";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private string _name;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ModelRoot LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0xD01820", Offset = "0xD00C20", VA = "0x180D01820", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0xD01480", Offset = "0xD00880", VA = "0x180D01480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0BF0", Offset = "0xA49FFF0", VA = "0x18A4A0BF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA4943B0", Offset = "0xA4937B0", VA = "0x18A4943B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0DF0", Offset = "0xA4A01F0", VA = "0x18A4A0DF0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0CD0", Offset = "0xA4A00D0", VA = "0x18A4A0CD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0B50", Offset = "0xA49FF50", VA = "0x18A4A0B50", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0DC0", Offset = "0xA4A01C0", VA = "0x18A4A0DC0", Slot = "18")]
		void IChildOfList<ModelRoot>.SetLogicalParent(ModelRoot parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0D30", Offset = "0xA4A0130", VA = "0x18A4A0D30")]
		protected bool SharesLogicalParent(params LogicalChildOfRoot[] items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6110", Offset = "0x3BF5510", VA = "0x183BF6110")]
		public static void RenameLogicalElements<T>(IEnumerable<T> collection, string namePrefix) where T : LogicalChildOfRoot
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0C20", Offset = "0xA4A0020", VA = "0x18A4A0C20")]
		private bool RenameIfAvailable(string newName, HashSet<string> usedNames)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA499220", Offset = "0xA498620", VA = "0x18A499220")]
		protected LogicalChildOfRoot()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	public sealed class AccessorSparseIndices : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public AccessorSparseIndices <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000C7")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000573")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C8")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000575")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8C40", Offset = "0xA4A8040", VA = "0x18A4A8C40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xA4A76A0", Offset = "0xA4A6AA0", VA = "0x18A4A76A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9970", Offset = "0xA4A8D70", VA = "0x18A4A9970")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8900", Offset = "0xA4A7D00", VA = "0x18A4A8900", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8580", Offset = "0xA4A7980", VA = "0x18A4A8580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8580", Offset = "0xA4A7980", VA = "0x18A4A8580", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public new const string SCHEMANAME = "indices";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private int _bufferView;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private const int _byteOffsetDefault = 0;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private const int _byteOffsetMinimum = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private int? _byteOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private IndexEncodingType _componentType;

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xA48DF70", Offset = "0xA48D370", VA = "0x18A48DF70", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA48E120", Offset = "0xA48D520", VA = "0x18A48E120", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA48E2D0", Offset = "0xA48D6D0", VA = "0x18A48E2D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA48E1A0", Offset = "0xA48D5A0", VA = "0x18A48E1A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA48DE30", Offset = "0xA48D230", VA = "0x18A48DE30", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA48E900", Offset = "0xA48DD00", VA = "0x18A48E900")]
		internal AccessorSparseIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xA48E960", Offset = "0xA48DD60", VA = "0x18A48E960")]
		internal AccessorSparseIndices(BufferView bv, int byteOffset, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA48E7F0", Offset = "0xA48DBF0", VA = "0x18A48E7F0")]
		internal IntegerArray _GetIndicesArray(ModelRoot root, int sparseCount)
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xA48DFA0", Offset = "0xA48D3A0", VA = "0x18A48DFA0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA48E670", Offset = "0xA48DA70", VA = "0x18A48E670")]
		internal void ValidateIndices(ValidationContext validate, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	public sealed class AccessorSparseValues : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			public AccessorSparseValues <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000C9")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600058B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600058D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8E80", Offset = "0xA4A8280", VA = "0x18A4A8E80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xA4A6410", Offset = "0xA4A5810", VA = "0x18A4A6410", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xA4A97E0", Offset = "0xA4A8BE0", VA = "0x18A4A97E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8980", Offset = "0xA4A7D80", VA = "0x18A4A8980", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0xA4A7F40", Offset = "0xA4A7340", VA = "0x18A4A7F40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0xA4A7F40", Offset = "0xA4A7340", VA = "0x18A4A7F40", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public new const string SCHEMANAME = "values";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private int _bufferView;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private const int _byteOffsetDefault = 0;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private const int _byteOffsetMinimum = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private int? _byteOffset;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xA48EBA0", Offset = "0xA48DFA0", VA = "0x18A48EBA0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA48ED50", Offset = "0xA48E150", VA = "0x18A48ED50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xA48EEB0", Offset = "0xA48E2B0", VA = "0x18A48EEB0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xA48EDD0", Offset = "0xA48E1D0", VA = "0x18A48EDD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xA48EAB0", Offset = "0xA48DEB0", VA = "0x18A48EAB0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xA48F550", Offset = "0xA48E950", VA = "0x18A48F550")]
		internal AccessorSparseValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xA48F400", Offset = "0xA48E800", VA = "0x18A48F400")]
		internal AccessorSparseValues(BufferView bv, int byteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xA48F1A0", Offset = "0xA48E5A0", VA = "0x18A48F1A0")]
		internal MemoryAccessor _GetMemoryAccessor(ModelRoot root, int sparseCount, Accessor baseAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA48EBD0", Offset = "0xA48DFD0", VA = "0x18A48EBD0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xA48F140", Offset = "0xA48E540", VA = "0x18A48F140")]
		internal void ValidateValues(ValidationContext validate, int count)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	public sealed class AccessorSparse : ExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public AccessorSparse <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005A5")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005A7")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8F40", Offset = "0xA4A8340", VA = "0x18A4A8F40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0xA4A7C40", Offset = "0xA4A7040", VA = "0x18A4A7C40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9A10", Offset = "0xA4A8E10", VA = "0x18A4A9A10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0xA4A89C0", Offset = "0xA4A7DC0", VA = "0x18A4A89C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xA4A83A0", Offset = "0xA4A77A0", VA = "0x18A4A83A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0xA4A83A0", Offset = "0xA4A77A0", VA = "0x18A4A83A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public new const string SCHEMANAME = "sparse";

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private const int _countMinimum = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private int _count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private AccessorSparseIndices _indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private AccessorSparseValues _values;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xA48F700", Offset = "0xA48EB00", VA = "0x18A48F700", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xA48FB40", Offset = "0xA48EF40", VA = "0x18A48FB40", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xA48FCC0", Offset = "0xA48F0C0", VA = "0x18A48FCC0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xA48FBC0", Offset = "0xA48EFC0", VA = "0x18A48FBC0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA48F5B0", Offset = "0xA48E9B0", VA = "0x18A48F5B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xA48D230", Offset = "0xA48C630", VA = "0x18A48D230")]
		internal AccessorSparse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xA490230", Offset = "0xA48F630", VA = "0x18A490230")]
		internal AccessorSparse(int sparseCount, BufferView indices, int indicesOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xA490040", Offset = "0xA48F440", VA = "0x18A490040")]
		internal KeyValuePair<IntegerArray, MemoryAccessor> _CreateMemoryAccessors(Accessor baseAccessor)
		{
			return default(KeyValuePair<IntegerArray, MemoryAccessor>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA48F960", Offset = "0xA48ED60", VA = "0x18A48F960", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xA48F730", Offset = "0xA48EB30", VA = "0x18A48F730", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	[DebuggerTypeProxy(typeof(_AccessorDebugProxy))]
	public sealed class Accessor : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public Accessor <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000D9")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000609")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000DA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600060B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9540", Offset = "0xA4A8940", VA = "0x18A4A9540", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xA4A7190", Offset = "0xA4A6590", VA = "0x18A4A7190", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9790", Offset = "0xA4A8B90", VA = "0x18A4A9790")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8A40", Offset = "0xA4A7E40", VA = "0x18A4A8A40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8260", Offset = "0xA4A7660", VA = "0x18A4A8260", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8260", Offset = "0xA4A7660", VA = "0x18A4A8260", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public new const string SCHEMANAME = "accessor";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private int? _bufferView;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private const int _byteOffsetDefault = 0;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private const int _byteOffsetMinimum = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private int? _byteOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EncodingType _componentType;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private const int _countMinimum = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private int _count;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private const int _maxMinItems = 1;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private const int _maxMaxItems = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private List<double> _max;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private const int _minMinItems = 1;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private const int _minMaxItems = 16;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private List<double> _min;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private static readonly bool _normalizedDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private bool? _normalized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private AccessorSparse _sparse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private string _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private DimensionType? _CachedType;

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x1685040", Offset = "0x1684440", VA = "0x181685040")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public DimensionType Dimensions
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xA4960A0", Offset = "0xA4954A0", VA = "0x18A4960A0")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xD6C420", Offset = "0xD6B820", VA = "0x180D6C420")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0xA497E40", Offset = "0xA497240", VA = "0x18A497E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xA497F20", Offset = "0xA497320", VA = "0x18A497F20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xA497CC0", Offset = "0xA4970C0", VA = "0x18A497CC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public BufferView SourceBufferView
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xA497E80", Offset = "0xA497280", VA = "0x18A497E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public int ByteOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xA497D70", Offset = "0xA497170", VA = "0x18A497D70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool IsSparse
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x8629550", Offset = "0x8628950", VA = "0x188629550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public AttributeFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xA497DB0", Offset = "0xA4971B0", VA = "0x18A497DB0")]
			get
			{
				return default(AttributeFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public (IReadOnlyList<double> Min, IReadOnlyList<double> Max) Bounds
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xA497C20", Offset = "0xA497020", VA = "0x18A497C20")]
			get
			{
				return default((IReadOnlyList<double>, IReadOnlyList<double>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xA491590", Offset = "0xA490990", VA = "0x18A491590", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA491B10", Offset = "0xA490F10", VA = "0x18A491B10", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA4938D0", Offset = "0xA492CD0", VA = "0x18A4938D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xA491BC0", Offset = "0xA490FC0", VA = "0x18A491BC0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xA4911A0", Offset = "0xA4905A0", VA = "0x18A4911A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xA490A10", Offset = "0xA48FE10", VA = "0x18A490A10")]
		public IAccessorArray<Matrix3x2> AsMatrix2x2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xA490AF0", Offset = "0xA48FEF0", VA = "0x18A490AF0")]
		public IAccessorArray<Matrix4x4> AsMatrix3x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xA490BD0", Offset = "0xA48FFD0", VA = "0x18A490BD0")]
		public IAccessorArray<Matrix4x4> AsMatrix4x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xA490CB0", Offset = "0xA4900B0", VA = "0x18A490CB0")]
		public IAccessorArray<Matrix4x4> AsMatrix4x4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xA490D50", Offset = "0xA490150", VA = "0x18A490D50")]
		[Obsolete("Use AsMatrix4x4Array instead", true)]
		internal IReadOnlyList<Matrix4x4> AsMatrix4x4ReadOnlyList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xA490F30", Offset = "0xA490330", VA = "0x18A490F30")]
		public IAccessorArray<Quaternion> AsQuaternionArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xA490DF0", Offset = "0xA4901F0", VA = "0x18A490DF0")]
		public IAccessorArray<float[]> AsMultiArray(int dimensions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xA4907C0", Offset = "0xA48FBC0", VA = "0x18A4907C0")]
		public IAccessorArray<uint> AsIndicesArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xA490780", Offset = "0xA48FB80", VA = "0x18A490780")]
		public IAccessorArray<uint> AsIndexArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xA4910A0", Offset = "0xA4904A0", VA = "0x18A4910A0")]
		public IAccessorArray<float> AsScalarArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xA4910E0", Offset = "0xA4904E0", VA = "0x18A4910E0")]
		public IAccessorArray<Vector2> AsVector2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xA491120", Offset = "0xA490520", VA = "0x18A491120")]
		public IAccessorArray<Vector3> AsVector3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA491160", Offset = "0xA490560", VA = "0x18A491160")]
		public IAccessorArray<Vector4> AsVector4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x3366110", Offset = "0x3365510", VA = "0x183366110")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xA490590", Offset = "0xA48F990", VA = "0x18A490590")]
		public IAccessorArray<Vector4> AsColorArray(float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xA4936E0", Offset = "0xA492AE0", VA = "0x18A4936E0")]
		public ArraySegment<byte> TryGetVertexBytes(int vertexIdx)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xA496090", Offset = "0xA495490", VA = "0x18A496090")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xA497AF0", Offset = "0xA496EF0", VA = "0x18A497AF0")]
		internal Accessor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xA4960A0", Offset = "0xA4954A0", VA = "0x18A4960A0")]
		private DimensionType _GetDimensions()
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xA4965B0", Offset = "0xA4959B0", VA = "0x18A4965B0")]
		internal bool _TryGetMemoryAccessor([Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xA496300", Offset = "0xA495700", VA = "0x18A496300")]
		internal bool _TryGetMemoryAccessor(string name, [Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA493610", Offset = "0xA492A10", VA = "0x18A493610")]
		public bool TryGetBufferView([Out] BufferView bv)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xA494430", Offset = "0xA493830", VA = "0x18A494430")]
		public void UpdateBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA496190", Offset = "0xA495590", VA = "0x18A496190")]
		private void _ResetBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x3367690", Offset = "0x3366A90", VA = "0x183367690")]
		private void _AppendToBounds<T>(T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA495EC0", Offset = "0xA4952C0", VA = "0x18A495EC0")]
		private void _AppendToBounds(params float[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA491EC0", Offset = "0xA4912C0", VA = "0x18A491EC0")]
		public void SetDataFrom(Accessor other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xA493440", Offset = "0xA492840", VA = "0x18A493440")]
		public void SetZeros(MemoryAccessInfo accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xA493470", Offset = "0xA492870", VA = "0x18A493470")]
		public void SetZeros(int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xA492190", Offset = "0xA491590", VA = "0x18A492190")]
		[Obsolete("Use SetData with AttributeFormat. This will be removed soon.")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xA492290", Offset = "0xA491690", VA = "0x18A492290")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xA491B90", Offset = "0xA490F90", VA = "0x18A491B90")]
		public void RemoveSparseData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3366840", Offset = "0x3365C40", VA = "0x183366840")]
		public void CreateSparseData<T>(IReadOnlyDictionary<int, T> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA492D90", Offset = "0xA492190", VA = "0x18A492D90")]
		public void SetSparseData(MemoryAccessor sparseIndices, MemoryAccessor sparseValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xA4929C0", Offset = "0xA491DC0", VA = "0x18A4929C0")]
		public void SetSparseData(int sparseCount, BufferView indices, int indicesByteOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesByteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA492530", Offset = "0xA491930", VA = "0x18A492530")]
		public void SetIndexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xA492840", Offset = "0xA491C40", VA = "0x18A492840")]
		public void SetIndexData(BufferView buffer, int bufferByteOffset, int itemCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xA4930C0", Offset = "0xA4924C0", VA = "0x18A4930C0")]
		public void SetVertexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xA492FC0", Offset = "0xA4923C0", VA = "0x18A492FC0")]
		[Obsolete("Use SetVertexData with AttributeFormat. This will be removed soon.")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions = DimensionType.VEC3, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xA4932D0", Offset = "0xA4926D0", VA = "0x18A4932D0")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xA4919D0", Offset = "0xA490DD0", VA = "0x18A4919D0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4915C0", Offset = "0xA4909C0", VA = "0x18A4915C0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xA494B10", Offset = "0xA493F10", VA = "0x18A494B10")]
		internal void ValidateIndices(ValidationContext validate, uint vertexCount, PrimitiveType drawingType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xA495450", Offset = "0xA494850", VA = "0x18A495450")]
		internal static void ValidateVertexAttributes(ValidationContext validate, IReadOnlyDictionary<string, Accessor> attributes, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xA496EF0", Offset = "0xA4962F0", VA = "0x18A496EF0")]
		private void _ValidatePositions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xA496B90", Offset = "0xA495F90", VA = "0x18A496B90")]
		private void _ValidateNormals(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xA497210", Offset = "0xA496610", VA = "0x18A497210")]
		private void _ValidateTangents(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xA496870", Offset = "0xA495C70", VA = "0x18A496870")]
		private void _ValidateJoints(ValidationContext validate, string attributeName, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xA497680", Offset = "0xA496A80", VA = "0x18A497680")]
		private static void _ValidateWeights(ValidationContext validate, Accessor weights0, Accessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xA497830", Offset = "0xA496C30", VA = "0x18A497830")]
		private void _ValidateWeights(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xA494EC0", Offset = "0xA4942C0", VA = "0x18A494EC0")]
		internal void ValidateMatrices4x3(ValidationContext validate, bool mustInvert = true, bool mustDecompose = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xA4948A0", Offset = "0xA493CA0", VA = "0x18A4948A0")]
		internal void ValidateAnimationInput(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xA4949C0", Offset = "0xA493DC0", VA = "0x18A4949C0")]
		internal void ValidateAnimationOutput(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class AnimationChannelTarget : ExtraProperties, IChildOf<AnimationChannel>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public AnimationChannelTarget <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000DD")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000626")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000DE")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000628")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xA4A9480", Offset = "0xA4A8880", VA = "0x18A4A9480", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xA4A6170", Offset = "0xA4A5570", VA = "0x18A4A6170", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xA4A99C0", Offset = "0xA4A8DC0", VA = "0x18A4A99C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8940", Offset = "0xA4A7D40", VA = "0x18A4A8940", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA4A86C0", Offset = "0xA4A7AC0", VA = "0x18A4A86C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA4A86C0", Offset = "0xA4A7AC0", VA = "0x18A4A86C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public new const string SCHEMANAME = "target";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private int? _node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private PropertyPath _path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private AnimationChannel _Parent;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		AnimationChannel IChildOf<AnimationChannel>.LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal PropertyPath _NodePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0xCFB3C0", Offset = "0xCFA7C0", VA = "0x180CFB3C0")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA498270", Offset = "0xA497670", VA = "0x18A498270", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xA498380", Offset = "0xA497780", VA = "0x18A498380", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xA4984D0", Offset = "0xA4978D0", VA = "0x18A4984D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xA498400", Offset = "0xA497800", VA = "0x18A498400", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xA497F60", Offset = "0xA497360", VA = "0x18A497F60", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xA48D230", Offset = "0xA48C630", VA = "0x18A48D230")]
		internal AnimationChannelTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA498760", Offset = "0xA497B60", VA = "0x18A498760")]
		internal AnimationChannelTarget(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA4987F0", Offset = "0xA497BF0", VA = "0x18A4987F0")]
		internal AnimationChannelTarget(string pointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0", Slot = "17")]
		void IChildOf<AnimationChannel>.SetLogicalParent(AnimationChannel parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA498050", Offset = "0xA497450", VA = "0x18A498050")]
		public int GetNodeIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA498100", Offset = "0xA497500", VA = "0x18A498100")]
		public PropertyPath GetNodePath()
		{
			return default(PropertyPath);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA498170", Offset = "0xA497570", VA = "0x18A498170")]
		public string GetPointerPath()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA4982A0", Offset = "0xA4976A0", VA = "0x18A4982A0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("AnimChannel {TargetPointerPath}")]
	public sealed class AnimationChannel : ExtraProperties, IChildOfList<Animation>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public AnimationChannel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000E4")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600064E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000650")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xA4A8D00", Offset = "0xA4A8100", VA = "0x18A4A8D00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0xA4A79A0", Offset = "0xA4A6DA0", VA = "0x18A4A79A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0xA4A96A0", Offset = "0xA4A8AA0", VA = "0x18A4A96A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0xA4A88C0", Offset = "0xA4A7CC0", VA = "0x18A4A88C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0xA4A84E0", Offset = "0xA4A78E0", VA = "0x18A4A84E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xA4A84E0", Offset = "0xA4A78E0", VA = "0x18A4A84E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public new const string SCHEMANAME = "channel";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private int _sampler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private AnimationChannelTarget _target;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0xD01820", Offset = "0xD00C20", VA = "0x180D01820", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xD01480", Offset = "0xD00880", VA = "0x180D01480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Animation LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E50", Offset = "0xCF4250", VA = "0x180CF4E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public string TargetPointerPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0xA499670", Offset = "0xA498A70", VA = "0x18A499670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public Node TargetNode
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0xA4994E0", Offset = "0xA4988E0", VA = "0x18A4994E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public PropertyPath TargetNodePath
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xA499460", Offset = "0xA498860", VA = "0x18A499460")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA498A80", Offset = "0xA497E80", VA = "0x18A498A80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xA498BF0", Offset = "0xA497FF0", VA = "0x18A498BF0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA498E40", Offset = "0xA498240", VA = "0x18A498E40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xA498C70", Offset = "0xA498070", VA = "0x18A498C70", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA498900", Offset = "0xA497D00", VA = "0x18A498900", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA499220", Offset = "0xA498620", VA = "0x18A499220")]
		internal AnimationChannel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xA499310", Offset = "0xA498710", VA = "0x18A499310")]
		internal AnimationChannel(string pointerPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xA499230", Offset = "0xA498630", VA = "0x18A499230")]
		internal AnimationChannel(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xA498D30", Offset = "0xA498130", VA = "0x18A498D30")]
		internal void SetSampler(AnimationSampler sampler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xA498E10", Offset = "0xA498210", VA = "0x18A498E10", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xA499190", Offset = "0xA498590", VA = "0x18A499190")]
		private void _SetChannelTarget(AnimationChannelTarget target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x3385E30", Offset = "0x3385230", VA = "0x183385E30")]
		public IAnimationSampler<T> GetSamplerOrNull<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA4990D0", Offset = "0xA4984D0", VA = "0x18A4990D0")]
		internal AnimationSampler _GetSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xA498A50", Offset = "0xA497E50", VA = "0x18A498A50")]
		public IAnimationSampler<Vector3> GetScaleSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA498A20", Offset = "0xA497E20", VA = "0x18A498A20")]
		public IAnimationSampler<Quaternion> GetRotationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA498AB0", Offset = "0xA497EB0", VA = "0x18A498AB0")]
		public IAnimationSampler<Vector3> GetTranslationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA4989F0", Offset = "0xA497DF0", VA = "0x18A4989F0")]
		public IAnimationSampler<SparseWeight8> GetSparseMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA4989F0", Offset = "0xA497DF0", VA = "0x18A4989F0")]
		public IAnimationSampler<float[]> GetMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xA498AE0", Offset = "0xA497EE0", VA = "0x18A498AE0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class AnimationSampler : ExtraProperties, IChildOfList<Animation>, IAnimationSampler<bool>, IAnimationSampler<float>, IAnimationSampler<Vector2>, IAnimationSampler<Vector3>, IAnimationSampler<Vector4>, IAnimationSampler<Quaternion>, IAnimationSampler<SparseWeight8>, IAnimationSampler<ArraySegment<float>>, IAnimationSampler<float[]>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public AnimationSampler <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000EC")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006C5")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000ED")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006C7")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0CD0", Offset = "0xA4C00D0", VA = "0x18A4C0CD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0xA4BE2D0", Offset = "0xA4BD6D0", VA = "0x18A4BE2D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0xA4C14A0", Offset = "0xA4C08A0", VA = "0x18A4C14A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0810", Offset = "0xA4BFC10", VA = "0x18A4C0810", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0xA4C06B0", Offset = "0xA4BFAB0", VA = "0x18A4C06B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0xA4C06B0", Offset = "0xA4BFAB0", VA = "0x18A4C06B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class <_GroupByTangentValueTangent>d__84<T> : IEnumerable<(T, T, T)>, IEnumerable, IEnumerator<(T, T, T)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			private (T TangentIn, T Value, T TangentOut) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			private IEnumerable<T> collection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public IEnumerable<T> <>3__collection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private IEnumerator<T> <ptr>5__2;

			[Cpp2IlInjected.Token(Token = "0x170000EE")]
			(T, T, T) IEnumerator<(T, T, T)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006CE")]
				[Cpp2IlInjected.Address(RVA = "0x12C93E0", Offset = "0x12C87E0", VA = "0x1812C93E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((T, T, T));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006D0")]
				[Cpp2IlInjected.Address(RVA = "0x64BAEF0", Offset = "0x64BA2F0", VA = "0x1864BAEF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x13A7D40", Offset = "0x13A7140", VA = "0x1813A7D40")]
			[DebuggerHidden]
			public <_GroupByTangentValueTangent>d__84(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x7224970", Offset = "0x7223D70", VA = "0x187224970", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x72241B0", Offset = "0x72235B0", VA = "0x1872241B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x7224AA0", Offset = "0x7223EA0", VA = "0x187224AA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x6A71DD0", Offset = "0x6A711D0", VA = "0x186A71DD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(T, T, T)> IEnumerable<(T, T, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x7224610", Offset = "0x7223A10", VA = "0x187224610", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public new const string SCHEMANAME = "sampler";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private int _input;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private const AnimationInterpolationMode _interpolationDefault = AnimationInterpolationMode.LINEAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private AnimationInterpolationMode? _interpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private int _output;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public Animation LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x600065A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xD24210", Offset = "0xD23610", VA = "0x180D24210", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xE09150", Offset = "0xE08550", VA = "0x180E09150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public AnimationInterpolationMode InterpolationMode
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0xA4A0A60", Offset = "0xA49FE60", VA = "0x18A4A0A60", Slot = "51")]
			get
			{
				return default(AnimationInterpolationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0xA4A0B00", Offset = "0xA49FF00", VA = "0x18A4A0B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public Accessor Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xA4A0A00", Offset = "0xA49FE00", VA = "0x18A4A0A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public Accessor Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xA4A0AA0", Offset = "0xA49FEA0", VA = "0x18A4A0AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0xA4A08F0", Offset = "0xA49FCF0", VA = "0x18A4A08F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xA4998D0", Offset = "0xA498CD0", VA = "0x18A4998D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xA499FF0", Offset = "0xA4993F0", VA = "0x18A499FF0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA49F0F0", Offset = "0xA49E4F0", VA = "0x18A49F0F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xA49A070", Offset = "0xA499470", VA = "0x18A49A070", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA499780", Offset = "0xA498B80", VA = "0x18A499780", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA4A07F0", Offset = "0xA49FBF0", VA = "0x18A4A07F0")]
		internal AnimationSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0860", Offset = "0xA49FC60", VA = "0x18A4A0860")]
		internal AnimationSampler(AnimationInterpolationMode interpolation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xA49B2D0", Offset = "0xA49A6D0", VA = "0x18A49B2D0", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xA49F450", Offset = "0xA49E850", VA = "0x18A49F450")]
		private Accessor _CreateInputAccessor(IReadOnlyList<float> input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xA49F6A0", Offset = "0xA49EAA0", VA = "0x18A49F6A0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<bool> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xA49F8D0", Offset = "0xA49ECD0", VA = "0x18A49F8D0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xA49FD70", Offset = "0xA49F170", VA = "0x18A49FD70")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector2> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xA49FFC0", Offset = "0xA49F3C0", VA = "0x18A49FFC0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector3> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xA49FB20", Offset = "0xA49EF20", VA = "0x18A49FB20")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector4> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xA4A04B0", Offset = "0xA49F8B0", VA = "0x18A4A04B0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Quaternion> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xA4A06E0", Offset = "0xA49FAE0", VA = "0x18A4A06E0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<SparseWeight8> output, int itemsStride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x3386C10", Offset = "0x3386010", VA = "0x183386C10")]
		private Accessor _CreateOutputAccessor<T>(IReadOnlyList<T> output, int itemsStride) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xA4A0210", Offset = "0xA49F610", VA = "0x18A4A0210")]
		private Accessor _CreateOutputAccessor(int itemCount, int itemsStride, Func<int, int, float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x33875F0", Offset = "0x33869F0", VA = "0x1833875F0")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, TValue> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x3387200", Offset = "0x3386600", VA = "0x183387200")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, (TValue TangentIn, TValue Value, TValue TangentOut)> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xA49ADC0", Offset = "0xA49A1C0", VA = "0x18A49ADC0")]
		internal void SetKeys(IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA49ACC0", Offset = "0xA49A0C0", VA = "0x18A49ACC0")]
		internal void SetKeys(IReadOnlyDictionary<float, float> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xA49B0D0", Offset = "0xA49A4D0", VA = "0x18A49B0D0")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector2> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA49B1D0", Offset = "0xA49A5D0", VA = "0x18A49B1D0")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector3> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xA49ABC0", Offset = "0xA499FC0", VA = "0x18A49ABC0")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector4> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xA49AFD0", Offset = "0xA49A3D0", VA = "0x18A49AFD0")]
		internal void SetKeys(IReadOnlyDictionary<float, Quaternion> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x33863F0", Offset = "0x33857F0", VA = "0x1833863F0")]
		internal void SetKeys<TWeights>(IReadOnlyDictionary<float, TWeights> keyframes, int itemsStride) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA49AEC0", Offset = "0xA49A2C0", VA = "0x18A49AEC0")]
		internal void SetKeys(IReadOnlyDictionary<float, SparseWeight8> keyframes, int itemsStride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA49A820", Offset = "0xA499C20", VA = "0x18A49A820")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (float TangentIn, float Value, float TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xA49A9D0", Offset = "0xA499DD0", VA = "0x18A49A9D0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector2 TangentIn, Vector2 Value, Vector2 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA49A380", Offset = "0xA499780", VA = "0x18A49A380")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xA49A1A0", Offset = "0xA4995A0", VA = "0x18A49A1A0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector4 TangentIn, Vector4 Value, Vector4 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA49A6F0", Offset = "0xA499AF0", VA = "0x18A49A6F0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x3386020", Offset = "0x3385420", VA = "0x183386020")]
		internal void SetCubicKeys<TWeights>(IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int expandedCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xA49A560", Offset = "0xA499960", VA = "0x18A49A560")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int expandedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xA49C450", Offset = "0xA49B850", VA = "0x18A49C450", Slot = "20")]
		IEnumerable<(float, bool)> IAnimationSampler<bool>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA49E610", Offset = "0xA49DA10", VA = "0x18A49E610", Slot = "24")]
		IEnumerable<(float, float)> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA49D1D0", Offset = "0xA49C5D0", VA = "0x18A49D1D0", Slot = "28")]
		IEnumerable<(float, Vector2)> IAnimationSampler<Vector2>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA49D890", Offset = "0xA49CC90", VA = "0x18A49D890", Slot = "32")]
		IEnumerable<(float, Vector3)> IAnimationSampler<Vector3>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA49DF50", Offset = "0xA49D350", VA = "0x18A49DF50", Slot = "36")]
		IEnumerable<(float, Vector4)> IAnimationSampler<Vector4>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA49CB30", Offset = "0xA49BF30", VA = "0x18A49CB30", Slot = "40")]
		IEnumerable<(float, Quaternion)> IAnimationSampler<Quaternion>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA49B7B0", Offset = "0xA49ABB0", VA = "0x18A49B7B0", Slot = "44")]
		IEnumerable<(float, SparseWeight8)> IAnimationSampler<SparseWeight8>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA49BFD0", Offset = "0xA49B3D0", VA = "0x18A49BFD0", Slot = "48")]
		IEnumerable<(float, ArraySegment<float>)> IAnimationSampler<ArraySegment<float>>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xA49ED80", Offset = "0xA49E180", VA = "0x18A49ED80", Slot = "52")]
		IEnumerable<(float, float[])> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA49C410", Offset = "0xA49B810", VA = "0x18A49C410", Slot = "21")]
		IEnumerable<(float, (bool, bool, bool))> IAnimationSampler<bool>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xA49E330", Offset = "0xA49D730", VA = "0x18A49E330", Slot = "25")]
		IEnumerable<(float, (float, float, float))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA49CEF0", Offset = "0xA49C2F0", VA = "0x18A49CEF0", Slot = "29")]
		IEnumerable<(float, (Vector2, Vector2, Vector2))> IAnimationSampler<Vector2>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xA49D5B0", Offset = "0xA49C9B0", VA = "0x18A49D5B0", Slot = "33")]
		IEnumerable<(float, (Vector3, Vector3, Vector3))> IAnimationSampler<Vector3>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA49DC70", Offset = "0xA49D070", VA = "0x18A49DC70", Slot = "37")]
		IEnumerable<(float, (Vector4, Vector4, Vector4))> IAnimationSampler<Vector4>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xA49C870", Offset = "0xA49BC70", VA = "0x18A49C870", Slot = "41")]
		IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> IAnimationSampler<Quaternion>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA49E9F0", Offset = "0xA49DDF0", VA = "0x18A49E9F0", Slot = "53")]
		IEnumerable<(float, (float[], float[], float[]))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA49BC40", Offset = "0xA49B040", VA = "0x18A49BC40", Slot = "49")]
		IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> IAnimationSampler<ArraySegment<float>>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xA49B420", Offset = "0xA49A820", VA = "0x18A49B420", Slot = "45")]
		IEnumerable<(float, (SparseWeight8, SparseWeight8, SparseWeight8))> IAnimationSampler<SparseWeight8>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xA49C340", Offset = "0xA49B740", VA = "0x18A49C340", Slot = "22")]
		ICurveSampler<bool> IAnimationSampler<bool>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA49E210", Offset = "0xA49D610", VA = "0x18A49E210", Slot = "26")]
		ICurveSampler<float> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA49CDD0", Offset = "0xA49C1D0", VA = "0x18A49CDD0", Slot = "30")]
		ICurveSampler<Vector2> IAnimationSampler<Vector2>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA49D490", Offset = "0xA49C890", VA = "0x18A49D490", Slot = "34")]
		ICurveSampler<Vector3> IAnimationSampler<Vector3>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xA49DB50", Offset = "0xA49CF50", VA = "0x18A49DB50", Slot = "38")]
		ICurveSampler<Vector4> IAnimationSampler<Vector4>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xA49C750", Offset = "0xA49BB50", VA = "0x18A49C750", Slot = "42")]
		ICurveSampler<Quaternion> IAnimationSampler<Quaternion>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xA49B300", Offset = "0xA49A700", VA = "0x18A49B300", Slot = "46")]
		ICurveSampler<SparseWeight8> IAnimationSampler<SparseWeight8>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xA49E8D0", Offset = "0xA49DCD0", VA = "0x18A49E8D0", Slot = "54")]
		ICurveSampler<float[]> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xA49BB20", Offset = "0xA49AF20", VA = "0x18A49BB20", Slot = "50")]
		ICurveSampler<ArraySegment<float>> IAnimationSampler<ArraySegment<float>>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x3386FC0", Offset = "0x33863C0", VA = "0x183386FC0")]
		[IteratorStateMachine(typeof(<_GroupByTangentValueTangent>d__84<>))]
		private static IEnumerable<(T, T, T)> _GroupByTangentValueTangent<T>(IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xA499E30", Offset = "0xA499230", VA = "0x18A499E30", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xA499900", Offset = "0xA498D00", VA = "0x18A499900", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Animation[{LogicalIndex}] {Name}")]
	public sealed class Animation : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public Animation <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000708")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600070A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1090", Offset = "0xA4C0490", VA = "0x18A4C1090", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0xA4BE8F0", Offset = "0xA4BDCF0", VA = "0x18A4BE8F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xA4C16D0", Offset = "0xA4C0AD0", VA = "0x18A4C16D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0750", Offset = "0xA4BFB50", VA = "0x18A4C0750", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0250", Offset = "0xA4BF650", VA = "0x18A4C0250", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0250", Offset = "0xA4BF650", VA = "0x18A4C0250", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public new const string SCHEMANAME = "animation";

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private const int _channelsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private ChildrenList<AnimationChannel, Animation> _channels;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private const int _samplersMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private ChildrenList<AnimationSampler, Animation> _samplers;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		internal IReadOnlyList<AnimationSampler> _Samplers
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public IReadOnlyList<AnimationChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0xA4ACD80", Offset = "0xA4AC180", VA = "0x18A4ACD80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC200", Offset = "0xA4AB600", VA = "0x18A4AC200", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC380", Offset = "0xA4AB780", VA = "0x18A4AC380", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC510", Offset = "0xA4AB910", VA = "0x18A4AC510", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC400", Offset = "0xA4AB800", VA = "0x18A4AC400", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xA4ABD50", Offset = "0xA4AB150", VA = "0x18A4ABD50", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xA4ACCB0", Offset = "0xA4AC0B0", VA = "0x18A4ACCB0")]
		internal Animation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA4ABFB0", Offset = "0xA4AB3B0", VA = "0x18A4ABFB0")]
		public IEnumerable<AnimationChannel> FindChannels(string rootPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA4ABE40", Offset = "0xA4AB240", VA = "0x18A4ABE40")]
		public IEnumerable<AnimationChannel> FindChannels(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC1E0", Offset = "0xA4AB5E0", VA = "0x18A4AC1E0")]
		public AnimationChannel FindScaleChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC1D0", Offset = "0xA4AB5D0", VA = "0x18A4AC1D0")]
		public AnimationChannel FindRotationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC1F0", Offset = "0xA4AB5F0", VA = "0x18A4AC1F0")]
		public AnimationChannel FindTranslationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC1C0", Offset = "0xA4AB5C0", VA = "0x18A4AC1C0")]
		public AnimationChannel FindMorphChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC820", Offset = "0xA4ABC20", VA = "0x18A4AC820")]
		private AnimationChannel _FindChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC790", Offset = "0xA4ABB90", VA = "0x18A4AC790")]
		private AnimationSampler _CreateSampler(AnimationInterpolationMode interpolation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA4ACAD0", Offset = "0xA4ABED0", VA = "0x18A4ACAD0")]
		private AnimationChannel _UseChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA4ACA40", Offset = "0xA4ABE40", VA = "0x18A4ACA40")]
		private AnimationChannel _UseChannel(string pointerPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x338BBD0", Offset = "0x338AFD0", VA = "0x18338BBD0")]
		public void CreateMaterialPropertyChannel<T>(Material material, string propertyName, IReadOnlyDictionary<float, T> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x338C8A0", Offset = "0x338BCA0", VA = "0x18338C8A0")]
		public void DangerousCreatePointerChannel<T>(string pointerPath, IReadOnlyDictionary<float, T> keyframes, bool linear = true, bool verifyBackingFieldExists = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xA4AB6C0", Offset = "0xA4AAAC0", VA = "0x18A4AB6C0")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA4AB550", Offset = "0xA4AA950", VA = "0x18A4AB550")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA4AB260", Offset = "0xA4AA660", VA = "0x18A4AB260")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, Quaternion> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xA4AB3E0", Offset = "0xA4AA7E0", VA = "0x18A4AB3E0")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA4AB840", Offset = "0xA4AAC40", VA = "0x18A4AB840")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xA4AB9C0", Offset = "0xA4AADC0", VA = "0x18A4AB9C0")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x338BFF0", Offset = "0x338B3F0", VA = "0x18338BFF0")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, TWeights> keyframes, int morphCount, bool linear = true) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x338BD70", Offset = "0x338B170", VA = "0x18338BD70")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int morphCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA4AB0E0", Offset = "0xA4AA4E0", VA = "0x18A4AB0E0")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, SparseWeight8> keyframes, int morphCount, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xA4AAF60", Offset = "0xA4AA360", VA = "0x18A4AAF60")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int morphCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xA4ABB30", Offset = "0xA4AAF30", VA = "0x18A4ABB30")]
		public void CreateVisibilityChannel(Node node, IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC260", Offset = "0xA4AB660", VA = "0x18A4AC260", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xA4AC230", Offset = "0xA4AB630", VA = "0x18A4AC230", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("{Version} {MinVersion} {Generator} {Copyright}")]
	public sealed class Asset : ExtraProperties, IChildOf<ModelRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public Asset <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000FB")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600072B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600072D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0FD0", Offset = "0xA4C03D0", VA = "0x18A4C0FD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0xA4BEE30", Offset = "0xA4BE230", VA = "0x18A4BEE30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1770", Offset = "0xA4C0B70", VA = "0x18A4C1770")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0xA4C07D0", Offset = "0xA4BFBD0", VA = "0x18A4C07D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0430", Offset = "0xA4BF830", VA = "0x18A4C0430", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0430", Offset = "0xA4BF830", VA = "0x18A4C0430", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public new const string SCHEMANAME = "asset";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private string _copyright;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private string _generator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private string _minVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private string _version;

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly Version ZEROVERSION;

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly Version MINVERSION;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly Version MAXVERSION;

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public ModelRoot LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DE0", Offset = "0xCF41E0", VA = "0x180CF4DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public static string AssemblyInformationalVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xA4ADB00", Offset = "0xA4ACF00", VA = "0x18A4ADB00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public string Copyright
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0xA4ADCE0", Offset = "0xA4AD0E0", VA = "0x18A4ADCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public string Generator
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xA4ADD10", Offset = "0xA4AD110", VA = "0x18A4ADD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Version Version
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0xA4ADC60", Offset = "0xA4AD060", VA = "0x18A4ADC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Version MinVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xA4ADBE0", Offset = "0xA4ACFE0", VA = "0x18A4ADBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA4AD1D0", Offset = "0xA4AC5D0", VA = "0x18A4AD1D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA4AD400", Offset = "0xA4AC800", VA = "0x18A4AD400", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA4AD540", Offset = "0xA4AC940", VA = "0x18A4AD540", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xA4AD480", Offset = "0xA4AC880", VA = "0x18A4AD480", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA4AD0B0", Offset = "0xA4AC4B0", VA = "0x18A4AD0B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA48D230", Offset = "0xA48C630", VA = "0x18A48D230")]
		internal Asset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xA4ACE90", Offset = "0xA4AC290", VA = "0x18A4ACE90")]
		internal static Asset CreateDefault(string copyright)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xCF4DE0", Offset = "0xCF41E0", VA = "0x180CF4DE0", Slot = "17")]
		void IChildOf<ModelRoot>.SetLogicalParent(ModelRoot parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA4AD200", Offset = "0xA4AC600", VA = "0x18A4AD200", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Buffer[{LogicalIndex}] {Name} Bytes:{_Content?.Length ?? 0}")]
	public sealed class Buffer : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Buffer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000FE")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600074A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600074C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0F10", Offset = "0xA4C0310", VA = "0x18A4C0F10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF910", Offset = "0xA4BED10", VA = "0x18A4BF910", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1680", Offset = "0xA4C0A80", VA = "0x18A4C1680")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0990", Offset = "0xA4BFD90", VA = "0x18A4C0990", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xA4C01B0", Offset = "0xA4BF5B0", VA = "0x18A4C01B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C01B0", Offset = "0xA4BF5B0", VA = "0x18A4C01B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public new const string SCHEMANAME = "buffer";

		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private const int _byteLengthMinimum = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private int _byteLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private string _uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private byte[] _Content;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private const string EMBEDDEDOCTETSTREAM = "data:application/octet-stream";

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private const string EMBEDDEDGLTFBUFFER = "data:application/gltf-buffer";

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public byte[] Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0350", Offset = "0xA4AF750", VA = "0x18A4B0350", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0780", Offset = "0xA4AFB80", VA = "0x18A4B0780", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA4B08B0", Offset = "0xA4AFCB0", VA = "0x18A4B08B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0800", Offset = "0xA4AFC00", VA = "0x18A4B0800", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0260", Offset = "0xA4AF660", VA = "0x18A4B0260", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1030", Offset = "0xA4B0430", VA = "0x18A4B1030")]
		internal Buffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1040", Offset = "0xA4B0440", VA = "0x18A4B1040")]
		internal Buffer(byte[] content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0D70", Offset = "0xA4B0170", VA = "0x18A4B0D70")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0BF0", Offset = "0xA4AFFF0", VA = "0x18A4B0BF0")]
		private static byte[] _LoadBinaryBufferUnchecked(string uri, ReadContext context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0F60", Offset = "0xA4B0360", VA = "0x18A4B0F60")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0F20", Offset = "0xA4B0320", VA = "0x18A4B0F20")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0B40", Offset = "0xA4AFF40", VA = "0x18A4B0B40")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0B70", Offset = "0xA4AFF70", VA = "0x18A4B0B70")]
		internal void _IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0380", Offset = "0xA4AF780", VA = "0x18A4B0380")]
		internal void OnValidateBinaryChunk(ValidationContext validate, byte[] binaryChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xA4B06D0", Offset = "0xA4AFAD0", VA = "0x18A4B06D0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xA4B05A0", Offset = "0xA4AF9A0", VA = "0x18A4B05A0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerTypeProxy(typeof(_BufferViewDebugProxy))]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public sealed class BufferView : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public BufferView <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000106")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000778")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000107")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600077A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0A90", Offset = "0xA4BFE90", VA = "0x18A4C0A90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0xA4BD7E0", Offset = "0xA4BCBE0", VA = "0x18A4BD7E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1590", Offset = "0xA4C0990", VA = "0x18A4C1590")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0950", Offset = "0xA4BFD50", VA = "0x18A4C0950", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C04D0", Offset = "0xA4BF8D0", VA = "0x18A4C04D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0xA4C04D0", Offset = "0xA4BF8D0", VA = "0x18A4C04D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public new const string SCHEMANAME = "bufferView";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private int _buffer;

		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private const int _byteLengthMinimum = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private int _byteLength;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private const int _byteOffsetDefault = 0;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private const int _byteOffsetMinimum = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private int? _byteOffset;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private const int _byteStrideMinimum = 4;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private const int _byteStrideMaximum = 252;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private int? _byteStride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private BufferMode? _target;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public bool IsVertexBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0xA4B0220", Offset = "0xA4AF620", VA = "0x18A4B0220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public bool IsIndexBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0xA4B01E0", Offset = "0xA4AF5E0", VA = "0x18A4B01E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public bool IsDataBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA4B01A0", Offset = "0xA4AF5A0", VA = "0x18A4B01A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xA4B0090", Offset = "0xA4AF490", VA = "0x18A4B0090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public ArraySegment<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA4B00D0", Offset = "0xA4AF4D0", VA = "0x18A4B00D0")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		internal int LogicalBufferIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0xD24210", Offset = "0xD23610", VA = "0x180D24210")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA4AE2F0", Offset = "0xA4AD6F0", VA = "0x18A4AE2F0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA4AEB50", Offset = "0xA4ADF50", VA = "0x18A4AEB50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA4AED50", Offset = "0xA4AE150", VA = "0x18A4AED50", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA4AEBD0", Offset = "0xA4ADFD0", VA = "0x18A4AEBD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xA4ADEE0", Offset = "0xA4AD2E0", VA = "0x18A4ADEE0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA4AFB40", Offset = "0xA4AEF40", VA = "0x18A4AFB40")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA4B0030", Offset = "0xA4AF430", VA = "0x18A4B0030")]
		internal BufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA4AFC80", Offset = "0xA4AF080", VA = "0x18A4AFC80")]
		internal BufferView(Buffer buffer, int byteOffset, int? byteLength, int byteStride, BufferMode? target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xA4AE170", Offset = "0xA4AD570", VA = "0x18A4AE170")]
		public IEnumerable<Image> FindImages()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0xA4AE0A0", Offset = "0xA4AD4A0", VA = "0x18A4AE0A0")]
		public IEnumerable<Accessor> FindAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA4AFB50", Offset = "0xA4AEF50", VA = "0x18A4AFB50")]
		internal void _IsolateBufferMemory(_StaticBufferBuilder targetBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA4AE320", Offset = "0xA4AD720", VA = "0x18A4AE320")]
		public bool IsInterleaved(IEnumerable<Accessor> accessors)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xA4ADD40", Offset = "0xA4AD140", VA = "0x18A4ADD40")]
		internal static bool AreEqual(BufferView bv, ArraySegment<byte> content, int byteStride, BufferMode? target)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA4AE240", Offset = "0xA4AD640", VA = "0x18A4AE240")]
		internal static int GetAccessorByteLength([In] AttributeFormat fmt, int count, BufferView bv)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA4AF560", Offset = "0xA4AE960", VA = "0x18A4AF560")]
		internal static void VerifyAccess(ValidationContext validate, BufferView bv, int accessorByteOffset, AttributeFormat format, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xA4AE790", Offset = "0xA4ADB90", VA = "0x18A4AE790", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xA4AE5C0", Offset = "0xA4AD9C0", VA = "0x18A4AE5C0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA4AF300", Offset = "0xA4AE700", VA = "0x18A4AF300")]
		internal void ValidateBufferUsageGPU(ValidationContext validate, BufferMode usingMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA4AF400", Offset = "0xA4AE800", VA = "0x18A4AF400")]
		internal void ValidateBufferUsagePlainData(ValidationContext validate, bool supportsStride = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Orthographic ({XMag},{YMag})  {ZNear} < {ZFar}")]
	public sealed class CameraOrthographic : ExtraProperties, ICamera
	{
		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public CameraOrthographic <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700010F")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000799")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000110")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600079B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0E50", Offset = "0xA4C0250", VA = "0x18A4C0E50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xA4BE5D0", Offset = "0xA4BD9D0", VA = "0x18A4BE5D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xA4C17C0", Offset = "0xA4C0BC0", VA = "0x18A4C17C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0890", Offset = "0xA4BFC90", VA = "0x18A4C0890", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xA4BFFD0", Offset = "0xA4BF3D0", VA = "0x18A4BFFD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xA4BFFD0", Offset = "0xA4BF3D0", VA = "0x18A4BFFD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public new const string SCHEMANAME = "orthographic";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private double _xmag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private double _ymag;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private const double _zfarExclusiveMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private double _zfar;

		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private const double _znearMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private double _znear;

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public bool IsPerspective
		{
			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool IsOrthographic
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public float XMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xA4B1C10", Offset = "0xA4B1010", VA = "0x18A4B1C10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public float YMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xA4B1C20", Offset = "0xA4B1020", VA = "0x18A4B1C20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xA4B1C40", Offset = "0xA4B1040", VA = "0x18A4B1C40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xA4B1C30", Offset = "0xA4B1030", VA = "0x18A4B1C30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xA4B1BA0", Offset = "0xA4B0FA0", VA = "0x18A4B1BA0", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xA4B11A0", Offset = "0xA4B05A0", VA = "0x18A4B11A0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1280", Offset = "0xA4B0680", VA = "0x18A4B1280", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA4B14C0", Offset = "0xA4B08C0", VA = "0x18A4B14C0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1300", Offset = "0xA4B0700", VA = "0x18A4B1300", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1080", Offset = "0xA4B0480", VA = "0x18A4B1080", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA48D230", Offset = "0xA48C630", VA = "0x18A48D230")]
		internal CameraOrthographic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1B20", Offset = "0xA4B0F20", VA = "0x18A4B1B20")]
		internal CameraOrthographic(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA4B19B0", Offset = "0xA4B0DB0", VA = "0x18A4B19B0")]
		public static void VerifyParameters(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA4B11D0", Offset = "0xA4B05D0", VA = "0x18A4B11D0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Perspective {AspectRatio} {VerticalFOV}   {ZNear} < {ZFar}")]
	public sealed class CameraPerspective : ExtraProperties, ICamera
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public CameraPerspective <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000118")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007BA")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000119")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007BC")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0C10", Offset = "0xA4C0010", VA = "0x18A4C0C10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF3A0", Offset = "0xA4BE7A0", VA = "0x18A4BF3A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xA4C15E0", Offset = "0xA4C09E0", VA = "0x18A4C15E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0850", Offset = "0xA4BFC50", VA = "0x18A4C0850", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0110", Offset = "0xA4BF510", VA = "0x18A4C0110", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0110", Offset = "0xA4BF510", VA = "0x18A4C0110", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public new const string SCHEMANAME = "perspective";

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private const double _aspectRatioExclusiveMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private double? _aspectRatio;

		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private const double _yfovExclusiveMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private double _yfov;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const double _zfarExclusiveMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private double? _zfar;

		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private const double _znearExclusiveMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private double _znear;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		public bool IsOrthographic
		{
			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public bool IsPerspective
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public float? AspectRatio
		{
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xA4B2830", Offset = "0xA4B1C30", VA = "0x18A4B2830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public float VerticalFOV
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xA4B1C30", Offset = "0xA4B1030", VA = "0x18A4B1C30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x9B750A0", Offset = "0x9B744A0", VA = "0x189B750A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xA4B29F0", Offset = "0xA4B1DF0", VA = "0x18A4B29F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0xA4B28C0", Offset = "0xA4B1CC0", VA = "0x18A4B28C0", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1D90", Offset = "0xA4B1190", VA = "0x18A4B1D90", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1E70", Offset = "0xA4B1270", VA = "0x18A4B1E70", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2080", Offset = "0xA4B1480", VA = "0x18A4B2080", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1EF0", Offset = "0xA4B12F0", VA = "0x18A4B1EF0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1C50", Offset = "0xA4B1050", VA = "0x18A4B1C50", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA48D230", Offset = "0xA48C630", VA = "0x18A48D230")]
		internal CameraPerspective()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA4B26E0", Offset = "0xA4B1AE0", VA = "0x18A4B26E0")]
		internal CameraPerspective(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2580", Offset = "0xA4B1980", VA = "0x18A4B2580")]
		public static void VerifyParameters(float? aspectRatio, float yfov, float znear, float zfar = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1DC0", Offset = "0xA4B11C0", VA = "0x18A4B1DC0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Camera[{LogicalIndex}] {Name} {_type}")]
	public sealed class Camera : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public Camera <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700011C")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007D5")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700011D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007D7")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0xA4C12D0", Offset = "0xA4C06D0", VA = "0x18A4C12D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xA4BDB60", Offset = "0xA4BCF60", VA = "0x18A4BDB60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1450", Offset = "0xA4C0850", VA = "0x18A4C1450")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xA4C08D0", Offset = "0xA4BFCD0", VA = "0x18A4C08D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0xA4BFF30", Offset = "0xA4BF330", VA = "0x18A4BFF30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xA4BFF30", Offset = "0xA4BF330", VA = "0x18A4BFF30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		public new const string SCHEMANAME = "camera";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private CameraOrthographic _orthographic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private CameraPerspective _perspective;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private CameraType _type;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		public ICamera Settings
		{
			[Cpp2IlInjected.Token(Token = "0x60007C5")]
			[Cpp2IlInjected.Address(RVA = "0xA4B36B0", Offset = "0xA4B2AB0", VA = "0x18A4B36B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0xA4B35C0", Offset = "0xA4B29C0", VA = "0x18A4B35C0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2C20", Offset = "0xA4B2020", VA = "0x18A4B2C20", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2DF0", Offset = "0xA4B21F0", VA = "0x18A4B2DF0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3240", Offset = "0xA4B2640", VA = "0x18A4B3240", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2E70", Offset = "0xA4B2270", VA = "0x18A4B2E70", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2A50", Offset = "0xA4B1E50", VA = "0x18A4B2A50", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1030", Offset = "0xA4B0430", VA = "0x18A4B1030")]
		internal Camera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2B90", Offset = "0xA4B1F90", VA = "0x18A4B2B90")]
		internal ICamera GetCamera()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2F80", Offset = "0xA4B2380", VA = "0x18A4B2F80")]
		public void SetOrthographicMode(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3080", Offset = "0xA4B2480", VA = "0x18A4B3080")]
		public void SetPerspectiveMode(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2C50", Offset = "0xA4B2050", VA = "0x18A4B2C50", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("LogicalTexture[{_LogicalTextureIndex}]")]
	public class TextureInfo : ExtraProperties, IChildOf<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public TextureInfo <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000122")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007F3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000123")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007F5")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0D90", Offset = "0xA4C0190", VA = "0x18A4C0D90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xA4BEB90", Offset = "0xA4BDF90", VA = "0x18A4BEB90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1810", Offset = "0xA4C0C10", VA = "0x18A4C1810")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0790", Offset = "0xA4BFB90", VA = "0x18A4C0790", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0570", Offset = "0xA4BF970", VA = "0x18A4C0570", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0570", Offset = "0xA4BF970", VA = "0x18A4C0570", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public new const string SCHEMANAME = "textureInfo";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private int _index;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private const int _texCoordDefault = 0;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private const int _texCoordMinimum = 0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private int? _texCoord;

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Material LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public int LogicalTextureIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0xD47A90", Offset = "0xD46E90", VA = "0x180D47A90")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA4BCEF0", Offset = "0xA4BC2F0", VA = "0x18A4BCEF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0xA4BCF70", Offset = "0xA4BC370", VA = "0x18A4BCF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public TextureTransform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA4BCF30", Offset = "0xA4BC330", VA = "0x18A4BCF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA4BC850", Offset = "0xA4BBC50", VA = "0x18A4BC850", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA4BC990", Offset = "0xA4BBD90", VA = "0x18A4BC990", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA4BCC00", Offset = "0xA4BC000", VA = "0x18A4BCC00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA4BCA10", Offset = "0xA4BBE10", VA = "0x18A4BCA10", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA4BC760", Offset = "0xA4BBB60", VA = "0x18A4BC760", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA4BCE90", Offset = "0xA4BC290", VA = "0x18A4BCE90")]
		public TextureInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xCFD4D0", Offset = "0xCFC8D0", VA = "0x180CFD4D0", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA4BCAF0", Offset = "0xA4BBEF0", VA = "0x18A4BCAF0")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA4BC880", Offset = "0xA4BBC80", VA = "0x18A4BC880", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	internal sealed class MaterialPBRMetallicRoughness : ExtraProperties, IChildOf<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private sealed class <GetChannels>d__32 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public MaterialPBRMetallicRoughness <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public Material <>3__material;

			[Cpp2IlInjected.Token(Token = "0x17000128")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600081E")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000129")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000820")]
				[Cpp2IlInjected.Address(RVA = "0xA4BD780", Offset = "0xA4BCB80", VA = "0x18A4BD780", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <GetChannels>d__32(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA4BCFD0", Offset = "0xA4BC3D0", VA = "0x18A4BCFD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA4BD740", Offset = "0xA4BCB40", VA = "0x18A4BD740", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA4BD690", Offset = "0xA4BCA90", VA = "0x18A4BD690", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA4BD690", Offset = "0xA4BCA90", VA = "0x18A4BD690", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public MaterialPBRMetallicRoughness <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700012A")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000827")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700012B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000829")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1150", Offset = "0xA4C0550", VA = "0x18A4C1150", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xA4BFBB0", Offset = "0xA4BEFB0", VA = "0x18A4BFBB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1540", Offset = "0xA4C0940", VA = "0x18A4C1540")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0A10", Offset = "0xA4BFE10", VA = "0x18A4C0A10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0390", Offset = "0xA4BF790", VA = "0x18A4C0390", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0390", Offset = "0xA4BF790", VA = "0x18A4C0390", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public new const string SCHEMANAME = "pbrMetallicRoughness";

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly Vector4 _baseColorFactorDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private Vector4? _baseColorFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TextureInfo _baseColorTexture;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private const double _metallicFactorDefault = 1.0;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private const double _metallicFactorMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private const double _metallicFactorMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private double? _metallicFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private TextureInfo _metallicRoughnessTexture;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private const double _roughnessFactorDefault = 1.0;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private const double _roughnessFactorMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private const double _roughnessFactorMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private double? _roughnessFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private Material _Parent;

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		Material IChildOf<Material>.LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DD0", Offset = "0xCF41D0", VA = "0x180CF4DD0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xA4B4E70", Offset = "0xA4B4270", VA = "0x18A4B4E70")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0xA4B4F20", Offset = "0xA4B4320", VA = "0x18A4B4F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public float MetallicFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA4B5090", Offset = "0xA4B4490", VA = "0x18A4B5090")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0xA4B50F0", Offset = "0xA4B44F0", VA = "0x18A4B50F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA4B5160", Offset = "0xA4B4560", VA = "0x18A4B5160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0xA4B51C0", Offset = "0xA4B45C0", VA = "0x18A4B51C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA4B4340", Offset = "0xA4B3740", VA = "0x18A4B4340", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA4B45A0", Offset = "0xA4B39A0", VA = "0x18A4B45A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA4B4840", Offset = "0xA4B3C40", VA = "0x18A4B4840", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4B4620", Offset = "0xA4B3A20", VA = "0x18A4B4620", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA4B4110", Offset = "0xA4B3510", VA = "0x18A4B4110", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xCF4C90", Offset = "0xCF4090", VA = "0x180CF4C90", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA4B4370", Offset = "0xA4B3770", VA = "0x18A4B4370", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xA4B42B0", Offset = "0xA4B36B0", VA = "0x18A4B42B0")]
		[IteratorStateMachine(typeof(<GetChannels>d__32))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA4B5280", Offset = "0xA4B4680", VA = "0x18A4B5280")]
		public MaterialPBRMetallicRoughness()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Normal LogicalTexture[{_LogicalTextureIndex}] x {Scale}")]
	internal sealed class MaterialNormalTextureInfo : TextureInfo
	{
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public MaterialNormalTextureInfo <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700012E")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600083D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700012F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600083F")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083A")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1390", Offset = "0xA4C0790", VA = "0x18A4C1390", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083B")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF150", Offset = "0xA4BE550", VA = "0x18A4BF150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600083C")]
			[Cpp2IlInjected.Address(RVA = "0xA4C14F0", Offset = "0xA4C08F0", VA = "0x18A4C14F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0910", Offset = "0xA4BFD10", VA = "0x18A4C0910", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0070", Offset = "0xA4BF470", VA = "0x18A4C0070", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0070", Offset = "0xA4BF470", VA = "0x18A4C0070", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public new const string SCHEMANAME = "normalTextureInfo";

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private const double _scaleDefault = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private double? _scale;

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		public static float ScaleDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0xD9F580", Offset = "0xD9E980", VA = "0x180D9F580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public float Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0xA4B3B20", Offset = "0xA4B2F20", VA = "0x18A4B3B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0xA4B3B80", Offset = "0xA4B2F80", VA = "0x18A4B3B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3760", Offset = "0xA4B2B60", VA = "0x18A4B3760", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3790", Offset = "0xA4B2B90", VA = "0x18A4B3790", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B38D0", Offset = "0xA4B2CD0", VA = "0x18A4B38D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3810", Offset = "0xA4B2C10", VA = "0x18A4B3810", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA4B36C0", Offset = "0xA4B2AC0", VA = "0x18A4B36C0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3A80", Offset = "0xA4B2E80", VA = "0x18A4B3A80")]
		public MaterialNormalTextureInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Occlusion LogicalTexture[{_LogicalTextureIndex}] x {Strength}")]
	internal sealed class MaterialOcclusionTextureInfo : TextureInfo
	{
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public MaterialOcclusionTextureInfo <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000132")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000853")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000133")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000855")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1210", Offset = "0xA4C0610", VA = "0x18A4C1210", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA4BF6C0", Offset = "0xA4BEAC0", VA = "0x18A4BF6C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1630", Offset = "0xA4C0A30", VA = "0x18A4C1630")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0xA4C09D0", Offset = "0xA4BFDD0", VA = "0x18A4C09D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xA4C02F0", Offset = "0xA4BF6F0", VA = "0x18A4C02F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xA4C02F0", Offset = "0xA4BF6F0", VA = "0x18A4C02F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public new const string SCHEMANAME = "occlusionTextureInfo";

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private const double _strengthDefault = 1.0;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private const double _strengthMinimum = 0.0;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private const double _strengthMaximum = 1.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private double? _strength;

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		public static float StrengthDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0xD9F580", Offset = "0xD9E980", VA = "0x180D9F580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public float Strength
		{
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0xA4B4040", Offset = "0xA4B3440", VA = "0x18A4B4040")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xA4B40A0", Offset = "0xA4B34A0", VA = "0x18A4B40A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3C90", Offset = "0xA4B3090", VA = "0x18A4B3C90", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3CC0", Offset = "0xA4B30C0", VA = "0x18A4B3CC0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3E00", Offset = "0xA4B3200", VA = "0x18A4B3E00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3D40", Offset = "0xA4B3140", VA = "0x18A4B3D40", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3BF0", Offset = "0xA4B2FF0", VA = "0x18A4B3BF0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3FA0", Offset = "0xA4B33A0", VA = "0x18A4B3FA0")]
		public MaterialOcclusionTextureInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Material[{LogicalIndex}] {Name}")]
	public sealed class Material : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public Material <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600088A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600088C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0B50", Offset = "0xA4BFF50", VA = "0x18A4C0B50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA4BDE60", Offset = "0xA4BD260", VA = "0x18A4BDE60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xA4C1720", Offset = "0xA4C0B20", VA = "0x18A4C1720")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0A50", Offset = "0xA4BFE50", VA = "0x18A4C0A50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0610", Offset = "0xA4BFA10", VA = "0x18A4C0610", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C0610", Offset = "0xA4BFA10", VA = "0x18A4C0610", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class <_GetChannels>d__45 : IEnumerable<MaterialChannel>, IEnumerable, IEnumerator<MaterialChannel>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private MaterialChannel <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			public Material <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			private _MaterialParameter<float> <occlusionParam>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			private _MaterialParameter<Vector3> <emissiveFactorParam>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			private IEnumerator<MaterialChannel> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x1700013D")]
			MaterialChannel IEnumerator<MaterialChannel>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600089C")]
				[Cpp2IlInjected.Address(RVA = "0x10DDBC0", Offset = "0x10DCFC0", VA = "0x1810DDBC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MaterialChannel);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600089E")]
				[Cpp2IlInjected.Address(RVA = "0xA4C4CA0", Offset = "0xA4C40A0", VA = "0x18A4C4CA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x1428360", Offset = "0x1427760", VA = "0x181428360")]
			[DebuggerHidden]
			public <_GetChannels>d__45(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4D00", Offset = "0xA4C4100", VA = "0x18A4C4D00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xA4C30B0", Offset = "0xA4C24B0", VA = "0x18A4C30B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0xA4C50F0", Offset = "0xA4C44F0", VA = "0x18A4C50F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0xA4C5150", Offset = "0xA4C4550", VA = "0x18A4C5150")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0xA4C51B0", Offset = "0xA4C45B0", VA = "0x18A4C51B0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xA4C5210", Offset = "0xA4C4610", VA = "0x18A4C5210")]
			private void <>m__Finally4()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0xA4C5270", Offset = "0xA4C4670", VA = "0x18A4C5270")]
			private void <>m__Finally5()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0xA4C52D0", Offset = "0xA4C46D0", VA = "0x18A4C52D0")]
			private void <>m__Finally6()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0xA4C5330", Offset = "0xA4C4730", VA = "0x18A4C5330")]
			private void <>m__Finally7()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0xA4C5390", Offset = "0xA4C4790", VA = "0x18A4C5390")]
			private void <>m__Finally8()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0xA4C53F0", Offset = "0xA4C47F0", VA = "0x18A4C53F0")]
			private void <>m__Finally9()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C5090", Offset = "0xA4C4490", VA = "0x18A4C5090")]
			private void <>m__Finally10()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4C60", Offset = "0xA4C4060", VA = "0x18A4C4C60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4BC0", Offset = "0xA4C3FC0", VA = "0x18A4C4BC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4BC0", Offset = "0xA4C3FC0", VA = "0x18A4C4BC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public new const string SCHEMANAME = "material";

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private const double _alphaCutoffDefault = 0.5;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private const double _alphaCutoffMinimum = 0.0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private double? _alphaCutoff;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private const AlphaMode _alphaModeDefault = AlphaMode.OPAQUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private AlphaMode? _alphaMode;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly bool _doubleSidedDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private bool? _doubleSided;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly Vector3 _emissiveFactorDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private Vector3? _emissiveFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private TextureInfo _emissiveTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private MaterialNormalTextureInfo _normalTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private MaterialOcclusionTextureInfo _occlusionTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private MaterialPBRMetallicRoughness _pbrMetallicRoughness;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		public AlphaMode Alpha
		{
			[Cpp2IlInjected.Token(Token = "0x600085E")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7810", Offset = "0xA4B6C10", VA = "0x18A4B7810")]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7A40", Offset = "0xA4B6E40", VA = "0x18A4B7A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0xA4B77B0", Offset = "0xA4B6BB0", VA = "0x18A4B77B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0xA4B79C0", Offset = "0xA4B6DC0", VA = "0x18A4B79C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0xA4B78B0", Offset = "0xA4B6CB0", VA = "0x18A4B78B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7B70", Offset = "0xA4B6F70", VA = "0x18A4B7B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public bool Unlit
		{
			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7980", Offset = "0xA4B6D80", VA = "0x18A4B7980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public IEnumerable<MaterialChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7260", Offset = "0xA4B6660", VA = "0x18A4B7260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7920", Offset = "0xA4B6D20", VA = "0x18A4B7920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7BF0", Offset = "0xA4B6FF0", VA = "0x18A4B7BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7850", Offset = "0xA4B6C50", VA = "0x18A4B7850")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0xA4B7A90", Offset = "0xA4B6E90", VA = "0x18A4B7A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xA4B5B40", Offset = "0xA4B4F40", VA = "0x18A4B5B40", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA4B61E0", Offset = "0xA4B55E0", VA = "0x18A4B61E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA4B6570", Offset = "0xA4B5970", VA = "0x18A4B6570", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA4B6260", Offset = "0xA4B5660", VA = "0x18A4B6260", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA4B54E0", Offset = "0xA4B48E0", VA = "0x18A4B54E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7660", Offset = "0xA4B6A60", VA = "0x18A4B7660")]
		internal Material()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xA4B5890", Offset = "0xA4B4C90", VA = "0x18A4B5890")]
		[DebuggerStepThrough]
		public MaterialChannel? FindChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xA4B6010", Offset = "0xA4B5410", VA = "0x18A4B6010", Slot = "5")]
		protected override void OnValidateContent(ValidationContext result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xA4B5390", Offset = "0xA4B4790", VA = "0x18A4B5390")]
		internal void ClearExtensions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xA4B5F70", Offset = "0xA4B5370", VA = "0x18A4B5F70")]
		public void InitializeUnlit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA4B5B70", Offset = "0xA4B4F70", VA = "0x18A4B5B70")]
		public void InitializePBRMetallicRoughness(params string[] extensionNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA4B5EA0", Offset = "0xA4B52A0", VA = "0x18A4B5EA0")]
		public void InitializePBRSpecularGlossiness(bool useFallback = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7260", Offset = "0xA4B6660", VA = "0x18A4B7260")]
		[IteratorStateMachine(typeof(<_GetChannels>d__45))]
		private IEnumerable<MaterialChannel> _GetChannels()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA4B73C0", Offset = "0xA4B67C0", VA = "0x18A4B73C0")]
		private MaterialNormalTextureInfo _GetNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA4B74E0", Offset = "0xA4B68E0", VA = "0x18A4B74E0")]
		private MaterialOcclusionTextureInfo _GetOcclusionTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xA4B72E0", Offset = "0xA4B66E0", VA = "0x18A4B72E0")]
		private TextureInfo _GetEmissiveTexture(bool create)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("{_DebuggerDisplay(),nq}")]
	public sealed class MeshPrimitive : ExtraProperties, IChildOfList<Mesh>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public MeshPrimitive <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000146")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008EA")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000147")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008EC")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1E10", Offset = "0xA4E1210", VA = "0x18A4E1E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xA4E12D0", Offset = "0xA4E06D0", VA = "0x18A4E12D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0xA4E23F0", Offset = "0xA4E17F0", VA = "0x18A4E23F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1C50", Offset = "0xA4E1050", VA = "0x18A4E1C50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xA4E18D0", Offset = "0xA4E0CD0", VA = "0x18A4E18D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0xA4E18D0", Offset = "0xA4E0CD0", VA = "0x18A4E18D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public new const string SCHEMANAME = "primitive";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private Dictionary<string, int> _attributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private int? _indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private int? _material;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private const PrimitiveType _modeDefault = PrimitiveType.TRIANGLES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private PrimitiveType? _mode;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private const int _targetsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private List<Dictionary<string, int>> _targets;

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60008A8")]
			[Cpp2IlInjected.Address(RVA = "0xD6C420", Offset = "0xD6B820", VA = "0x180D6C420", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD6D6D0", Offset = "0xD6CAD0", VA = "0x180D6D6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public Mesh LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DF0", Offset = "0xCF41F0", VA = "0x180CF4DF0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E00", Offset = "0xCF4200", VA = "0x180CF4E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0xA4BC3F0", Offset = "0xA4BB7F0", VA = "0x18A4BC3F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0xA4BC670", Offset = "0xA4BBA70", VA = "0x18A4BC670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public PrimitiveType DrawPrimitiveType
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xA4BC300", Offset = "0xA4BB700", VA = "0x18A4BC300")]
			get
			{
				return default(PrimitiveType);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0xA4BC620", Offset = "0xA4BBA20", VA = "0x18A4BC620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0xA4BC510", Offset = "0xA4BB910", VA = "0x18A4BC510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public IReadOnlyDictionary<string, Accessor> VertexAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0xA4BC550", Offset = "0xA4BB950", VA = "0x18A4BC550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public Accessor IndexAccessor
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0xA4BC340", Offset = "0xA4BB740", VA = "0x18A4BC340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xA4BADB0", Offset = "0xA4BA1B0", VA = "0x18A4BADB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xA4B8C50", Offset = "0xA4B8050", VA = "0x18A4B8C50", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xA4BABA0", Offset = "0xA4B9FA0", VA = "0x18A4BABA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xA4BB650", Offset = "0xA4BAA50", VA = "0x18A4BB650", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA4BAC20", Offset = "0xA4BA020", VA = "0x18A4BAC20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7F50", Offset = "0xA4B7350", VA = "0x18A4B7F50", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA4BC190", Offset = "0xA4BB590", VA = "0x18A4BC190")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA4BC200", Offset = "0xA4BB600", VA = "0x18A4BC200")]
		internal MeshPrimitive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA4BB620", Offset = "0xA4BAA20", VA = "0x18A4BB620", Slot = "18")]
		void IChildOfList<Mesh>.SetLogicalParent(Mesh parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA4B8140", Offset = "0xA4B7540", VA = "0x18A4B8140")]
		public IEnumerable<BufferView> GetBufferViews(bool includeIndices, bool includeVertices, bool includeMorphs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA4B8F70", Offset = "0xA4B8370", VA = "0x18A4B8F70")]
		public IReadOnlyList<KeyValuePair<string, Accessor>> GetVertexAccessorsByBuffer(BufferView vb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0xA4B8E70", Offset = "0xA4B8270", VA = "0x18A4B8E70")]
		public Accessor GetVertexAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0xA4BB4C0", Offset = "0xA4BA8C0", VA = "0x18A4BB4C0")]
		public void SetVertexAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D03E70", Offset = "0x3D03270", VA = "0x183D03E70")]
		internal IReadOnlyList<T> GetVertices<T>(string attributeKey) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xA4B85E0", Offset = "0xA4B79E0", VA = "0x18A4B85E0")]
		public Accessor GetIndexAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xA4BADB0", Offset = "0xA4BA1B0", VA = "0x18A4BADB0")]
		public void SetIndexAccessor(Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xA4B8680", Offset = "0xA4B7A80", VA = "0x18A4B8680")]
		public IList<uint> GetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0xA4B89F0", Offset = "0xA4B7DF0", VA = "0x18A4B89F0")]
		public IEnumerable<int> GetPointIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xA4B86B0", Offset = "0xA4B7AB0", VA = "0x18A4B86B0")]
		public IEnumerable<(int, int)> GetLineIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA4B8C80", Offset = "0xA4B8080", VA = "0x18A4B8C80")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA4B88A0", Offset = "0xA4B7CA0", VA = "0x18A4B88A0")]
		public IReadOnlyDictionary<string, Accessor> GetMorphTargetAccessors(int targetIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA4BAEB0", Offset = "0xA4BA2B0", VA = "0x18A4BAEB0")]
		public void SetMorphTargetAccessors(int targetIdx, IReadOnlyDictionary<string, Accessor> accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7CD0", Offset = "0xA4B70D0", VA = "0x18A4B7CD0")]
		internal static bool CheckAttributesQuantizationRequired(ModelRoot root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA4B7EC0", Offset = "0xA4B72C0", VA = "0x18A4B7EC0")]
		private bool CheckAttributesQuantizationRequired()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA4BA540", Offset = "0xA4B9940", VA = "0x18A4BA540", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA4B91F0", Offset = "0xA4B85F0", VA = "0x18A4B91F0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("{_DebuggerDisplay(),nq}")]
	[DebuggerTypeProxy(typeof(_MeshDebugProxy))]
	public sealed class Mesh : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public Mesh <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700014C")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600090C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700014D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600090E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1D50", Offset = "0xA4E1150", VA = "0x18A4E1D50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF8F0", Offset = "0xA4DECF0", VA = "0x18A4DF8F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2490", Offset = "0xA4E1890", VA = "0x18A4E2490")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1BD0", Offset = "0xA4E0FD0", VA = "0x18A4E1BD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1790", Offset = "0xA4E0B90", VA = "0x18A4E1790", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1790", Offset = "0xA4E0B90", VA = "0x18A4E1790", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public new const string SCHEMANAME = "mesh";

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private const int _primitivesMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private ChildrenList<MeshPrimitive, Mesh> _primitives;

		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private const int _weightsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private List<double> _weights;

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public IEnumerable<Node> VisualParents
		{
			[Cpp2IlInjected.Token(Token = "0x60008F6")]
			[Cpp2IlInjected.Address(RVA = "0xA4C81F0", Offset = "0xA4C75F0", VA = "0x18A4C81F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public IReadOnlyList<MeshPrimitive> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60008F8")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7320", Offset = "0xA4C6720", VA = "0x18A4C7320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public bool AllPrimitivesHaveJoints
		{
			[Cpp2IlInjected.Token(Token = "0x60008F9")]
			[Cpp2IlInjected.Address(RVA = "0xA4C80E0", Offset = "0xA4C74E0", VA = "0x18A4C80E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7490", Offset = "0xA4C6890", VA = "0x18A4C7490", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xA4C79A0", Offset = "0xA4C6DA0", VA = "0x18A4C79A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7CA0", Offset = "0xA4C70A0", VA = "0x18A4C7CA0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7A20", Offset = "0xA4C6E20", VA = "0x18A4C7A20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7230", Offset = "0xA4C6630", VA = "0x18A4C7230", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7F20", Offset = "0xA4C7320", VA = "0x18A4C7F20")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8020", Offset = "0xA4C7420", VA = "0x18A4C8020")]
		internal Mesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7320", Offset = "0xA4C6720", VA = "0x18A4C7320")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7B30", Offset = "0xA4C6F30", VA = "0x18A4C7B30")]
		public void SetMorphWeights(IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7B40", Offset = "0xA4C6F40", VA = "0x18A4C7B40")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0xA4C71B0", Offset = "0xA4C65B0", VA = "0x18A4C71B0")]
		public MeshPrimitive CreatePrimitive()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7840", Offset = "0xA4C6C40", VA = "0x18A4C7840", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C74C0", Offset = "0xA4C68C0", VA = "0x18A4C74C0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public sealed class Node : LogicalChildOfRoot, IVisualNodeContainer
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[CompilerGenerated]
		private sealed class <Flatten>d__70 : IEnumerable<Node>, IEnumerable, IEnumerator<Node>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			private Node <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			private IVisualNodeContainer container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public IVisualNodeContainer <>3__container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private IEnumerator<Node> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private IEnumerator<Node> <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			Node IEnumerator<Node>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000971")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000973")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <Flatten>d__70(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF6B0", Offset = "0xA4DEAB0", VA = "0x18A4DF6B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF1E0", Offset = "0xA4DE5E0", VA = "0x18A4DF1E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF850", Offset = "0xA4DEC50", VA = "0x18A4DF850")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF8A0", Offset = "0xA4DECA0", VA = "0x18A4DF8A0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF670", Offset = "0xA4DEA70", VA = "0x18A4DF670", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF5D0", Offset = "0xA4DE9D0", VA = "0x18A4DF5D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF5D0", Offset = "0xA4DE9D0", VA = "0x18A4DF5D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public Node <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000162")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600097A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000163")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600097C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2290", Offset = "0xA4E1690", VA = "0x18A4E2290", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0xA4E01B0", Offset = "0xA4DF5B0", VA = "0x18A4E01B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2580", Offset = "0xA4E1980", VA = "0x18A4E2580")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1B90", Offset = "0xA4E0F90", VA = "0x18A4E1B90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E16F0", Offset = "0xA4E0AF0", VA = "0x18A4E16F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xA4E16F0", Offset = "0xA4E0AF0", VA = "0x18A4E16F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public new const string SCHEMANAME = "node";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private int? _camera;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private const int _childrenMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private List<int> _children;

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private static readonly Matrix4x4 _matrixDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private Matrix4x4? _matrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private int? _mesh;

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private static readonly Quaternion _rotationDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private Quaternion? _rotation;

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private static readonly Vector3 _scaleDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private Vector3? _scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private int? _skin;

		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private static readonly Vector3 _translationDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private Vector3? _translation;

		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private const int _weightsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private List<double> _weights;

		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private const string _NOTRANSFORMMESSAGE = "Node instances with a Skin must not contain spatial transformations.";

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Node VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000918")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8470", Offset = "0xA4D7870", VA = "0x18A4D8470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Node VisualRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8580", Offset = "0xA4D7980", VA = "0x18A4D8580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<Scene> VisualScenes
		{
			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0xA4D85F0", Offset = "0xA4D79F0", VA = "0x18A4D85F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0xA4D5780", Offset = "0xA4D4B80", VA = "0x18A4D5780", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public bool IsSkinJoint
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7560", Offset = "0xA4D6960", VA = "0x18A4D7560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public bool IsSkinSkeleton
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7670", Offset = "0xA4D6A70", VA = "0x18A4D7670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public Camera Camera
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7450", Offset = "0xA4D6850", VA = "0x18A4D7450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8B10", Offset = "0xA4D7F10", VA = "0x18A4D8B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public Mesh Mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0xA4D80A0", Offset = "0xA4D74A0", VA = "0x18A4D80A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8CF0", Offset = "0xA4D80F0", VA = "0x18A4D8CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public Skin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8360", Offset = "0xA4D7760", VA = "0x18A4D8360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8EE0", Offset = "0xA4D82E0", VA = "0x18A4D8EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0xA4D81B0", Offset = "0xA4D75B0", VA = "0x18A4D81B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0xA4D89F0", Offset = "0xA4D7DF0", VA = "0x18A4D89F0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0xA4D9080", Offset = "0xA4D8480", VA = "0x18A4D9080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7F30", Offset = "0xA4D7330", VA = "0x18A4D7F30")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8CB0", Offset = "0xA4D80B0", VA = "0x18A4D8CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000929")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7E50", Offset = "0xA4D7250", VA = "0x18A4D7E50")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600092A")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8BF0", Offset = "0xA4D7FF0", VA = "0x18A4D8BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(RVA = "0xA4D79C0", Offset = "0xA4D6DC0", VA = "0x18A4D79C0")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8730", Offset = "0xA4D7B30", VA = "0x18A4D8730")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool IsTransformAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7780", Offset = "0xA4D6B80", VA = "0x18A4D7780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		internal bool IsTransformDecomposed
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7960", Offset = "0xA4D6D60", VA = "0x18A4D7960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public PunctualLight PunctualLight
		{
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0xA4D81C0", Offset = "0xA4D75C0", VA = "0x18A4D81C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0xA4D8DE0", Offset = "0xA4D81E0", VA = "0x18A4D8DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3140", Offset = "0xA4D2540", VA = "0x18A4D3140", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3990", Offset = "0xA4D2D90", VA = "0x18A4D3990", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0xA4D41C0", Offset = "0xA4D35C0", VA = "0x18A4D41C0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3A50", Offset = "0xA4D2E50", VA = "0x18A4D3A50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA4D25E0", Offset = "0xA4D19E0", VA = "0x18A4D25E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5240", Offset = "0xA4D4640", VA = "0x18A4D5240")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xA4D71A0", Offset = "0xA4D65A0", VA = "0x18A4D71A0")]
		internal Node()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2D30", Offset = "0xA4D2130", VA = "0x18A4D2D30")]
		public AffineTransform GetLocalTransform(Animation animation, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3170", Offset = "0xA4D2570", VA = "0x18A4D3170")]
		public Matrix4x4 GetWorldMatrix(Animation animation, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2E70", Offset = "0xA4D2270", VA = "0x18A4D2E70")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3EC0", Offset = "0xA4D32C0", VA = "0x18A4D3EC0")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5120", Offset = "0xA4D4520", VA = "0x18A4D5120")]
		internal static Node _FindVisualRootNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2580", Offset = "0xA4D1980", VA = "0x18A4D2580", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2B70", Offset = "0xA4D1F70", VA = "0x18A4D2B70")]
		[IteratorStateMachine(typeof(<Flatten>d__70))]
		public static IEnumerable<Node> Flatten(IVisualNodeContainer container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2970", Offset = "0xA4D1D70", VA = "0x18A4D2970")]
		public static IEnumerable<Node> FindNodesUsingMesh(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2A70", Offset = "0xA4D1E70", VA = "0x18A4D2A70")]
		public static IEnumerable<Node> FindNodesUsingSkin(Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA4D4FB0", Offset = "0xA4D43B0", VA = "0x18A4D4FB0")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5810", Offset = "0xA4D4C10", VA = "0x18A4D5810")]
		internal bool _HasVisualChild(int nodeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5780", Offset = "0xA4D4B80", VA = "0x18A4D5780")]
		internal IEnumerable<Node> _GetVisualChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5DD0", Offset = "0xA4D51D0", VA = "0x18A4D5DD0")]
		internal void _SetVisualParent(Node parentNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA4D5870", Offset = "0xA4D4C70", VA = "0x18A4D5870")]
		internal void _RemoveFromVisualParent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2BF0", Offset = "0xA4D1FF0", VA = "0x18A4D2BF0")]
		public NodeCurveSamplers GetCurveSamplers(Animation animation)
		{
			return default(NodeCurveSamplers);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA4D58D0", Offset = "0xA4D4CD0", VA = "0x18A4D58D0")]
		private void _SetLocalTransform(AffineTransform value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA4D35E0", Offset = "0xA4D29E0", VA = "0x18A4D35E0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6530", Offset = "0xA4D5930", VA = "0x18A4D6530")]
		internal static void _ValidateParentHierarchy(IEnumerable<Node> nodes, ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3400", Offset = "0xA4D2800", VA = "0x18A4D3400", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0xA4D61B0", Offset = "0xA4D55B0", VA = "0x18A4D61B0")]
		private void _ValidateChildrenHierarchy(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xA4D6C30", Offset = "0xA4D6030", VA = "0x18A4D6C30")]
		private void _ValidateTransforms(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xA4D62B0", Offset = "0xA4D56B0", VA = "0x18A4D62B0")]
		private static void _ValidateMeshAndSkin(ValidationContext validate, Mesh mesh, Skin skin, List<double> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0xA4D2CF0", Offset = "0xA4D20F0", VA = "0x18A4D2CF0")]
		public MeshGpuInstancing GetGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA4D4F00", Offset = "0xA4D4300", VA = "0x18A4D4F00")]
		public MeshGpuInstancing UseGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA4D3A10", Offset = "0xA4D2E10", VA = "0x18A4D3A10")]
		public void RemoveGpuInstancing()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D4150", Offset = "0xA4D3550", VA = "0x18A4D4150")]
		public bool TryGetVisibility([Out] bool isVisible)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0xA4D40A0", Offset = "0xA4D34A0", VA = "0x18A4D40A0")]
		public void SetVisibility(bool? isVisible)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("TextureSampler[{LogicalIndex}] {Name}")]
	public sealed class TextureSampler : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private class _ContentComparer : IEqualityComparer<TextureSampler>
		{
			[Cpp2IlInjected.Token(Token = "0x6000992")]
			[Cpp2IlInjected.Address(RVA = "0xA4E39A0", Offset = "0xA4E2DA0", VA = "0x18A4E39A0", Slot = "4")]
			public bool Equals(TextureSampler x, TextureSampler y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xA4E3B40", Offset = "0xA4E2F40", VA = "0x18A4E3B40", Slot = "5")]
			public int GetHashCode(TextureSampler obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _ContentComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			public TextureSampler <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000169")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600099F")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700016A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60009A1")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099C")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1ED0", Offset = "0xA4E12D0", VA = "0x18A4E1ED0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFE90", Offset = "0xA4DF290", VA = "0x18A4DFE90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2350", Offset = "0xA4E1750", VA = "0x18A4E2350")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1B50", Offset = "0xA4E0F50", VA = "0x18A4E1B50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1830", Offset = "0xA4E0C30", VA = "0x18A4E1830", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1830", Offset = "0xA4E0C30", VA = "0x18A4E1830", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public new const string SCHEMANAME = "sampler";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private TextureInterpolationFilter? _magFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TextureMipMapFilter? _minFilter;

		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private const TextureWrapMode _wrapSDefault = TextureWrapMode.REPEAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private TextureWrapMode? _wrapS;

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private const TextureWrapMode _wrapTDefault = TextureWrapMode.REPEAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private TextureWrapMode? _wrapT;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public TextureMipMapFilter MinFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000986")]
			[Cpp2IlInjected.Address(RVA = "0xA4DDBA0", Offset = "0xA4DCFA0", VA = "0x18A4DDBA0")]
			get
			{
				return default(TextureMipMapFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000987")]
			[Cpp2IlInjected.Address(RVA = "0xA4DDB60", Offset = "0xA4DCF60", VA = "0x18A4DDB60")]
			get
			{
				return default(TextureInterpolationFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0xA4DDBE0", Offset = "0xA4DCFE0", VA = "0x18A4DDBE0")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0xA4DDC20", Offset = "0xA4DD020", VA = "0x18A4DDC20")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public static IEqualityComparer<TextureSampler> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xA4DDB10", Offset = "0xA4DCF10", VA = "0x18A4DDB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xA4DDC60", Offset = "0xA4DD060", VA = "0x18A4DDC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD130", Offset = "0xA4DC530", VA = "0x18A4DD130", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD270", Offset = "0xA4DC670", VA = "0x18A4DD270", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD470", Offset = "0xA4DC870", VA = "0x18A4DD470", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD2F0", Offset = "0xA4DC6F0", VA = "0x18A4DD2F0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xA4DCDE0", Offset = "0xA4DC1E0", VA = "0x18A4DCDE0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD950", Offset = "0xA4DCD50", VA = "0x18A4DD950")]
		internal TextureSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD9E0", Offset = "0xA4DCDE0", VA = "0x18A4DD9E0")]
		internal TextureSampler(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD160", Offset = "0xA4DC560", VA = "0x18A4DD160")]
		internal static bool IsDefault(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xA4DCC80", Offset = "0xA4DC080", VA = "0x18A4DCC80")]
		public static bool AreEqualByContent(TextureSampler x, TextureSampler y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD180", Offset = "0xA4DC580", VA = "0x18A4DD180")]
		internal bool IsEqualTo(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD010", Offset = "0xA4DC410", VA = "0x18A4DD010")]
		public int GetContentHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Scene[{LogicalIndex}] {Name}")]
	public sealed class Scene : LogicalChildOfRoot, IVisualNodeContainer
	{
		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			public Scene <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700016D")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60009BE")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700016E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60009C0")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1F90", Offset = "0xA4E1390", VA = "0x18A4E1F90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0680", Offset = "0xA4DFA80", VA = "0x18A4E0680", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0xA4E23A0", Offset = "0xA4E17A0", VA = "0x18A4E23A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1CD0", Offset = "0xA4E10D0", VA = "0x18A4E1CD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1A10", Offset = "0xA4E0E10", VA = "0x18A4E1A10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1A10", Offset = "0xA4E0E10", VA = "0x18A4E1A10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public new const string SCHEMANAME = "scene";

		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private const int _nodesMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private List<int> _nodes;

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal IReadOnlyList<int> _VisualChildrenIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60009AA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0xA4DA100", Offset = "0xA4D9500", VA = "0x18A4DA100", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xA4D92E0", Offset = "0xA4D86E0", VA = "0x18A4D92E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9860", Offset = "0xA4D8C60", VA = "0x18A4D9860", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9990", Offset = "0xA4D8D90", VA = "0x18A4D9990", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0xA4D98E0", Offset = "0xA4D8CE0", VA = "0x18A4D98E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9240", Offset = "0xA4D8640", VA = "0x18A4D9240", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA080", Offset = "0xA4D9480", VA = "0x18A4DA080")]
		internal Scene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0xA4D91E0", Offset = "0xA4D85E0", VA = "0x18A4D91E0", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9B90", Offset = "0xA4D8F90", VA = "0x18A4D9B90")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9DD0", Offset = "0xA4D91D0", VA = "0x18A4D9DD0")]
		internal void _RemoveVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9EC0", Offset = "0xA4D92C0", VA = "0x18A4D9EC0")]
		internal void _UseVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9310", Offset = "0xA4D8710", VA = "0x18A4D9310", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Skin[{LogicalIndex}] {Name}")]
	public sealed class Skin : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			public Skin <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000174")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60009F0")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000175")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60009F2")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2050", Offset = "0xA4E1450", VA = "0x18A4E2050", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0xA4DFB90", Offset = "0xA4DEF90", VA = "0x18A4DFB90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2530", Offset = "0xA4E1930", VA = "0x18A4E2530")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F1")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1D10", Offset = "0xA4E1110", VA = "0x18A4E1D10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1650", Offset = "0xA4E0A50", VA = "0x18A4E1650", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1650", Offset = "0xA4E0A50", VA = "0x18A4E1650", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public new const string SCHEMANAME = "skin";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private int? _inverseBindMatrices;

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private const int _jointsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private List<int> _joints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private int? _skeleton;

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		public IEnumerable<Node> VisualParents
		{
			[Cpp2IlInjected.Token(Token = "0x60009C9")]
			[Cpp2IlInjected.Address(RVA = "0xA4DCA70", Offset = "0xA4DBE70", VA = "0x18A4DCA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public int JointsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC900", Offset = "0xA4DBD00", VA = "0x18A4DC900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public IReadOnlyList<Node> Joints
		{
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC940", Offset = "0xA4DBD40", VA = "0x18A4DC940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public IReadOnlyList<Matrix4x4> InverseBindMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC850", Offset = "0xA4DBC50", VA = "0x18A4DC850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public Node Skeleton
		{
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xA4DC9D0", Offset = "0xA4DBDD0", VA = "0x18A4DC9D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0xA4DCBA0", Offset = "0xA4DBFA0", VA = "0x18A4DCBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB320", Offset = "0xA4DA720", VA = "0x18A4DB320", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBC60", Offset = "0xA4DB060", VA = "0x18A4DBC60", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBDF0", Offset = "0xA4DB1F0", VA = "0x18A4DBDF0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBCE0", Offset = "0xA4DB0E0", VA = "0x18A4DBCE0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0xA4DAD00", Offset = "0xA4DA100", VA = "0x18A4DAD00", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC7D0", Offset = "0xA4DBBD0", VA = "0x18A4DC7D0")]
		internal Skin()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC2B0", Offset = "0xA4DB6B0", VA = "0x18A4DC2B0")]
		public Accessor UseInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xA4DAFE0", Offset = "0xA4DA3E0", VA = "0x18A4DAFE0")]
		public Accessor GetInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB0F0", Offset = "0xA4DA4F0", VA = "0x18A4DB0F0")]
		public (Node, Matrix4x4) GetJoint(int idx)
		{
			return default((Node, Matrix4x4));
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA820", Offset = "0xA4D9C20", VA = "0x18A4DA820")]
		public void BindJoints(params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA8A0", Offset = "0xA4D9CA0", VA = "0x18A4DA8A0")]
		public void BindJoints(Matrix4x4 meshBindTransform, params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA190", Offset = "0xA4D9590", VA = "0x18A4DA190")]
		public void BindJoints(IReadOnlyList<(Node Joint, Matrix4x4 InverseBindMatrix)> joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB350", Offset = "0xA4DA750", VA = "0x18A4DB350")]
		internal bool IsMatch(Node skeleton, KeyValuePair<Node, Matrix4x4>[] joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xA4DAE20", Offset = "0xA4DA220", VA = "0x18A4DAE20")]
		internal static IEnumerable<Skin> FindSkinsUsingJoint(Node jointNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0xA4DAF00", Offset = "0xA4DA300", VA = "0x18A4DAF00")]
		internal static IEnumerable<Skin> FindSkinsUsingSkeleton(Node skeletonNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC3D0", Offset = "0xA4DB7D0", VA = "0x18A4DC3D0")]
		private Node _FindCommonAncestor(IEnumerable<Node> nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB770", Offset = "0xA4DAB70", VA = "0x18A4DB770", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB540", Offset = "0xA4DA940", VA = "0x18A4DB540", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Texture[{LogicalIndex}] {Name}")]
	public sealed class Texture : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			public Texture <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000179")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A12")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700017A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A14")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2110", Offset = "0xA4E1510", VA = "0x18A4E2110", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1030", Offset = "0xA4E0430", VA = "0x18A4E1030", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0xA4E24E0", Offset = "0xA4E18E0", VA = "0x18A4E24E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1C10", Offset = "0xA4E1010", VA = "0x18A4E1C10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1AB0", Offset = "0xA4E0EB0", VA = "0x18A4E1AB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1AB0", Offset = "0xA4E0EB0", VA = "0x18A4E1AB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public new const string SCHEMANAME = "texture";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private int? _sampler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private int? _source;

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		public TextureSampler Sampler
		{
			[Cpp2IlInjected.Token(Token = "0x60009FB")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF010", Offset = "0xA4DE410", VA = "0x18A4DF010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF120", Offset = "0xA4DE520", VA = "0x18A4DF120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public Image PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0xA4DF000", Offset = "0xA4DE400", VA = "0x18A4DF000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public Image FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0xA4DEF40", Offset = "0xA4DE340", VA = "0x18A4DEF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xA4DDE20", Offset = "0xA4DD220", VA = "0x18A4DDE20", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xA4DDFA0", Offset = "0xA4DD3A0", VA = "0x18A4DDFA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE790", Offset = "0xA4DDB90", VA = "0x18A4DE790", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE020", Offset = "0xA4DD420", VA = "0x18A4DE020", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0xA4DDD50", Offset = "0xA4DD150", VA = "0x18A4DDD50", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1030", Offset = "0xA4B0430", VA = "0x18A4B1030")]
		internal Texture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xA4DEAE0", Offset = "0xA4DDEE0", VA = "0x18A4DEAE0")]
		private Image _GetPrimaryImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0xA4DEA20", Offset = "0xA4DDE20", VA = "0x18A4DEA20")]
		private Image _GetFallbackImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE0B0", Offset = "0xA4DD4B0", VA = "0x18A4DE0B0")]
		public void SetImage(Image primaryImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE2E0", Offset = "0xA4DD6E0", VA = "0x18A4DE2E0")]
		public void SetImages(Image primaryImage, Image fallbackImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xA4DDCD0", Offset = "0xA4DD0D0", VA = "0x18A4DDCD0")]
		public void ClearImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0xA4DEDF0", Offset = "0xA4DE1F0", VA = "0x18A4DEDF0")]
		private TextureDDS _UseDDSTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xA4DEED0", Offset = "0xA4DE2D0", VA = "0x18A4DEED0")]
		private TextureWEBP _UseWEBPTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xA4DEE60", Offset = "0xA4DE260", VA = "0x18A4DEE60")]
		private TextureKTX2 _UseKTX2Texture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xA4DEC10", Offset = "0xA4DE010", VA = "0x18A4DEC10")]
		internal bool _IsEqualentTo(Image primary, Image fallback, TextureSampler sampler)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xA4DDE50", Offset = "0xA4DD250", VA = "0x18A4DDE50", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("Model Root")]
	public sealed class ModelRoot : ExtraProperties, IConvertibleToGltf2
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			public ModelRoot <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700018F")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A9A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000190")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A9C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0xA4E21D0", Offset = "0xA4E15D0", VA = "0x18A4E21D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0xA4E08D0", Offset = "0xA4DFCD0", VA = "0x18A4E08D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2440", Offset = "0xA4E1840", VA = "0x18A4E2440")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1C90", Offset = "0xA4E1090", VA = "0x18A4E1C90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1970", Offset = "0xA4E0D70", VA = "0x18A4E1970", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9E")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1970", Offset = "0xA4E0D70", VA = "0x18A4E1970", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public new const string SCHEMANAME = "glTF";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private Asset _asset;

		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private const int _extensionsRequiredMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private List<string> _extensionsRequired;

		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private const int _extensionsUsedMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private List<string> _extensionsUsed;

		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private const int _accessorsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private ChildrenList<Accessor, ModelRoot> _accessors;

		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private const int _animationsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private ChildrenList<Animation, ModelRoot> _animations;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private const int _bufferViewsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private ChildrenList<BufferView, ModelRoot> _bufferViews;

		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private const int _buffersMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private ChildrenList<Buffer, ModelRoot> _buffers;

		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private const int _camerasMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private ChildrenList<Camera, ModelRoot> _cameras;

		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private const int _imagesMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private ChildrenList<Image, ModelRoot> _images;

		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private const int _materialsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private ChildrenList<Material, ModelRoot> _materials;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private const int _meshesMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private ChildrenList<Mesh, ModelRoot> _meshes;

		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private const int _nodesMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private ChildrenList<Node, ModelRoot> _nodes;

		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private const int _samplersMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private ChildrenList<TextureSampler, ModelRoot> _samplers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private int? _scene;

		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private const int _scenesMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private ChildrenList<Scene, ModelRoot> _scenes;

		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private const int _skinsMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private ChildrenList<Skin, ModelRoot> _skins;

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private const int _texturesMinItems = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private ChildrenList<Texture, ModelRoot> _textures;

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		public Asset Asset
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xA4D2450", Offset = "0xA4D1850", VA = "0x18A4D2450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public bool MeshQuantizationAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xA4D23F0", Offset = "0xA4D17F0", VA = "0x18A4D23F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public IEnumerable<string> ExtensionsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public IEnumerable<string> ExtensionsRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public IEnumerable<string> IncompatibleExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0xA4D22A0", Offset = "0xA4D16A0", VA = "0x18A4D22A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public IReadOnlyList<Material> LogicalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DD0", Offset = "0xCF41D0", VA = "0x180CF4DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public IReadOnlyList<Texture> LogicalTextures
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0xDCCCD0", Offset = "0xDCC0D0", VA = "0x180DCCCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public IReadOnlyList<TextureSampler> LogicalTextureSamplers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B70", Offset = "0xCF6F70", VA = "0x180CF7B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public IReadOnlyList<Image> LogicalImages
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0xCF8C40", Offset = "0xCF8040", VA = "0x180CF8C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public IReadOnlyList<Buffer> LogicalBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DF0", Offset = "0xCF41F0", VA = "0x180CF4DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public IReadOnlyList<BufferView> LogicalBufferViews
		{
			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public IReadOnlyList<Accessor> LogicalAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public IReadOnlyList<Mesh> LogicalMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0xCF5540", Offset = "0xCF4940", VA = "0x180CF5540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public IReadOnlyList<Skin> LogicalSkins
		{
			[Cpp2IlInjected.Token(Token = "0x6000A47")]
			[Cpp2IlInjected.Address(RVA = "0xCF7A30", Offset = "0xCF6E30", VA = "0x180CF7A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public IReadOnlyList<Camera> LogicalCameras
		{
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF4020", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public IReadOnlyList<Node> LogicalNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xCF8190", Offset = "0xCF7590", VA = "0x180CF8190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public IReadOnlyList<Scene> LogicalScenes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xD23EB0", Offset = "0xD232B0", VA = "0x180D23EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public IReadOnlyList<Animation> LogicalAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public Scene DefaultScene
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0xA4D21F0", Offset = "0xA4D15F0", VA = "0x18A4D21F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0xA4D24A0", Offset = "0xA4D18A0", VA = "0x18A4D24A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public IReadOnlyList<PunctualLight> LogicalPunctualLights
		{
			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0xA4D2330", Offset = "0xA4D1730", VA = "0x18A4D2330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA4CAC90", Offset = "0xA4CA090", VA = "0x18A4CAC90", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA4CC7C0", Offset = "0xA4CBBC0", VA = "0x18A4CC7C0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0xA4CD2F0", Offset = "0xA4CC6F0", VA = "0x18A4CD2F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xA4CCD20", Offset = "0xA4CC120", VA = "0x18A4CCD20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9AE0", Offset = "0xA4C8EE0", VA = "0x18A4C9AE0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8D10", Offset = "0xA4C8110", VA = "0x18A4C8D10")]
		public Accessor CreateAccessor([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8DB0", Offset = "0xA4C81B0", VA = "0x18A4C8DB0")]
		public Animation CreateAnimation([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8FE0", Offset = "0xA4C83E0", VA = "0x18A4C8FE0")]
		public Buffer CreateBuffer(int byteCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0xA4CEE70", Offset = "0xA4CE270", VA = "0x18A4CEE70")]
		public Buffer UseBuffer(byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0xA4CB050", Offset = "0xA4CA450", VA = "0x18A4CB050")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0xA4CB480", Offset = "0xA4CA880", VA = "0x18A4CB480")]
		public void MergeBuffers(int maxSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0xA4CACC0", Offset = "0xA4CA0C0", VA = "0x18A4CACC0")]
		public void IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8E50", Offset = "0xA4C8250", VA = "0x18A4C8E50")]
		public BufferView CreateBufferView(int byteSize, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0xA4CE780", Offset = "0xA4CDB80", VA = "0x18A4CE780")]
		public BufferView UseBufferView(ArraySegment<byte> data, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0xA4CE980", Offset = "0xA4CDD80", VA = "0x18A4CE980")]
		public BufferView UseBufferView(byte[] buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0xA4CEA80", Offset = "0xA4CDE80", VA = "0x18A4CEA80")]
		public BufferView UseBufferView(Buffer buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9090", Offset = "0xA4C8490", VA = "0x18A4C9090")]
		public Camera CreateCamera([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0xA4CE5B0", Offset = "0xA4CD9B0", VA = "0x18A4CE5B0")]
		internal void UpdateExtensionsSupport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0xA4CA210", Offset = "0xA4C9610", VA = "0x18A4CA210")]
		internal IEnumerable<string> GatherUsedExtensions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1420", Offset = "0xA4D0820", VA = "0x18A4D1420")]
		private void _SetExtensionUsage(string extension, bool used, bool required)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1540", Offset = "0xA4D0940", VA = "0x18A4D1540")]
		internal void _ValidateExtensions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9130", Offset = "0xA4C8530", VA = "0x18A4C9130")]
		public Image CreateImage([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF0D0", Offset = "0xA4CE4D0", VA = "0x18A4CF0D0")]
		public Image UseImage(MemoryImage imageContent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0xA4CBA40", Offset = "0xA4CAE40", VA = "0x18A4CBA40")]
		public void MergeImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9250", Offset = "0xA4C8650", VA = "0x18A4C9250")]
		public Material CreateMaterial([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0xA4C92F0", Offset = "0xA4C86F0", VA = "0x18A4C92F0")]
		public Mesh CreateMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0810", Offset = "0xA4CFC10", VA = "0x18A4D0810")]
		internal Node _FindVisualParentNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0xA4C91D0", Offset = "0xA4C85D0", VA = "0x18A4C91D0")]
		public Node CreateLogicalNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0730", Offset = "0xA4CFB30", VA = "0x18A4D0730")]
		internal Node _CreateVisualNode(IList<int> parentChildren)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0xA4C8320", Offset = "0xA4C7720", VA = "0x18A4C8320")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9430", Offset = "0xA4C8830", VA = "0x18A4C9430")]
		public static ModelRoot CreateModel()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1D70", Offset = "0xA4D1170", VA = "0x18A4D1D70")]
		internal ModelRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C96D0", Offset = "0xA4C8AD0", VA = "0x18A4C96D0")]
		public ModelRoot DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0xE18120", Offset = "0xE17520", VA = "0x180E18120", Slot = "16")]
		ModelRoot IConvertibleToGltf2.ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0xA4CAA10", Offset = "0xA4C9E10", VA = "0x18A4CAA10")]
		internal IEnumerable<ExtraProperties> GetLogicalChildrenFlattened()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0xA4CBC60", Offset = "0xA4CB060", VA = "0x18A4CBC60", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0xA4CBBF0", Offset = "0xA4CAFF0", VA = "0x18A4CBBF0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9500", Offset = "0xA4C8900", VA = "0x18A4C9500")]
		public PunctualLight CreatePunctualLight(PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0xA4C9560", Offset = "0xA4C8960", VA = "0x18A4C9560")]
		public PunctualLight CreatePunctualLight(string name, PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF4F0", Offset = "0xA4CE8F0", VA = "0x18A4CF4F0")]
		public Scene UseScene(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF3A0", Offset = "0xA4CE7A0", VA = "0x18A4CF3A0")]
		public Scene UseScene(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0xA4C95D0", Offset = "0xA4C89D0", VA = "0x18A4C95D0")]
		public Skin CreateSkin([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0xA4CF6A0", Offset = "0xA4CEAA0", VA = "0x18A4CF6A0")]
		public TextureSampler UseTextureSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min, TextureInterpolationFilter mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0xA4CFB00", Offset = "0xA4CEF00", VA = "0x18A4CFB00")]
		public Texture UseTexture(Image primary, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0xA4CFB30", Offset = "0xA4CEF30", VA = "0x18A4CFB30")]
		public Texture UseTexture(Image primary, Image fallback, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0xA4CFEC0", Offset = "0xA4CF2C0", VA = "0x18A4CFEC0")]
		public static ValidationResult Validate(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0xA4CAE70", Offset = "0xA4CA270", VA = "0x18A4CAE70")]
		public static ModelRoot Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0xA4CBE20", Offset = "0xA4CB220", VA = "0x18A4CBE20")]
		public static ModelRoot ParseGLB(ArraySegment<byte> glb, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0xA4CC5D0", Offset = "0xA4CB9D0", VA = "0x18A4CC5D0")]
		public static ModelRoot ReadGLB(Stream stream, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0xA4CAB30", Offset = "0xA4C9F30", VA = "0x18A4CAB30")]
		public static string[] GetSatellitePaths(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0xA4CC000", Offset = "0xA4CB400", VA = "0x18A4CC000")]
		private static string[] ParseSatellitePaths(ReadOnlyMemory<byte> json)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		internal void OnDeserializationCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xA4D1010", Offset = "0xA4D0410", VA = "0x18A4D1010")]
		internal void _ResolveSatelliteDependencies(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0xA4CCC20", Offset = "0xA4CC020", VA = "0x18A4CCC20")]
		public void Save(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xA4CC840", Offset = "0xA4CBC40", VA = "0x18A4CC840")]
		public void SaveGLB(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0xA4CCA30", Offset = "0xA4CBE30", VA = "0x18A4CCA30")]
		public void SaveGLTF(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0xA4CAA00", Offset = "0xA4C9E00", VA = "0x18A4CAA00")]
		[Obsolete("Use GetJsonPreview", true)]
		public string GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0xA4CAA00", Offset = "0xA4C9E00", VA = "0x18A4CAA00")]
		public string GetJsonPreview()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0910", Offset = "0xA4CFD10", VA = "0x18A4D0910")]
		internal string _GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0010", Offset = "0xA4CF410", VA = "0x18A4D0010")]
		public ArraySegment<byte> WriteGLB([Optional] WriteSettings settings)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0250", Offset = "0xA4CF650", VA = "0x18A4D0250")]
		public void WriteGLB(Stream stream, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D19D0", Offset = "0xA4D0DD0", VA = "0x18A4D19D0")]
		internal void _WriteJSON(Stream sw, JsonWriterOptions options, JsonFilterCallback filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0C30", Offset = "0xA4D0030", VA = "0x18A4D0C30")]
		internal void _PrepareBuffersForSatelliteWriting(WriteContext context, string baseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0B80", Offset = "0xA4CFF80", VA = "0x18A4D0B80")]
		internal void _PrepareBuffersForInternalWriting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0xA4D0D80", Offset = "0xA4D0180", VA = "0x18A4D0D80")]
		internal void _PrepareImagesForWriting(WriteContext context, string baseName, bool isBinary, ResourceWriteMode rmode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0xA4D03A0", Offset = "0xA4CF7A0", VA = "0x18A4D03A0")]
		internal void _AfterWriting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[GeneratedCode("SharpGLTF.CodeGen", "1.0.0.0")]
	[DebuggerDisplay("{_DebuggerDisplay(),nq}")]
	public sealed class Image : LogicalChildOfRoot
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__2 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000531")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			public Image <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000195")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000AC1")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000196")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000AC3")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABD")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0xA4FCA90", Offset = "0xA4FBE90", VA = "0x18A4FCA90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC6B0", Offset = "0xA4FBAB0", VA = "0x18A4FC6B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0xA4FCB50", Offset = "0xA4FBF50", VA = "0x18A4FCB50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0xA4FCA50", Offset = "0xA4FBE50", VA = "0x18A4FCA50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC9B0", Offset = "0xA4FBDB0", VA = "0x18A4FC9B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC9B0", Offset = "0xA4FBDB0", VA = "0x18A4FC9B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public new const string SCHEMANAME = "image";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private int? _bufferView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private string _mimeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private string _uri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private MemoryImage? _SatelliteContent;

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public MemoryImage Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0xA4C6F40", Offset = "0xA4C6340", VA = "0x18A4C6F40")]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0xA4C5FC0", Offset = "0xA4C53C0", VA = "0x18A4C5FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA8")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DD0", Offset = "0xCF41D0", VA = "0x180CF4DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C90", Offset = "0xCF4090", VA = "0x180CF4C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7170", Offset = "0xA4C6570", VA = "0x18A4C7170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		internal bool _HasContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0xA4C70D0", Offset = "0xA4C64D0", VA = "0x18A4C70D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C5B60", Offset = "0xA4C4F60", VA = "0x18A4C5B60", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0xA4C5E90", Offset = "0xA4C5290", VA = "0x18A4C5E90", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0xA4C63B0", Offset = "0xA4C57B0", VA = "0x18A4C63B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xA4C5F10", Offset = "0xA4C5310", VA = "0x18A4C5F10", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0xA4C58A0", Offset = "0xA4C4CA0", VA = "0x18A4C58A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6770", Offset = "0xA4C5B70", VA = "0x18A4C6770")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1030", Offset = "0xA4B0430", VA = "0x18A4B1030")]
		internal Image()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0xA4C59C0", Offset = "0xA4C4DC0", VA = "0x18A4C59C0")]
		private MemoryImage GetSatelliteContent()
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0xA4C5FC0", Offset = "0xA4C53C0", VA = "0x18A4C5FC0")]
		private void SetSatelliteContent(MemoryImage content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAE")]
		[Cpp2IlInjected.Address(RVA = "0xA4C60D0", Offset = "0xA4C54D0", VA = "0x18A4C60D0")]
		internal void TransferToInternalBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6890", Offset = "0xA4C5C90", VA = "0x18A4C6890")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB0")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6840", Offset = "0xA4C5C40", VA = "0x18A4C6840")]
		internal void _DiscardContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6B80", Offset = "0xA4C5F80", VA = "0x18A4C6B80")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6C80", Offset = "0xA4C6080", VA = "0x18A4C6C80")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6A50", Offset = "0xA4C5E50", VA = "0x18A4C6A50")]
		private void _WriteAsBufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0xA4C6730", Offset = "0xA4C5B30", VA = "0x18A4C6730")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0xA4C5D10", Offset = "0xA4C5110", VA = "0x18A4C5D10", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xA4C5B90", Offset = "0xA4C4F90", VA = "0x18A4C5B90", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	public interface IAnimationSampler<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000197")]
		AnimationInterpolationMode InterpolationMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<(float, T)> GetLinearKeys();

		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IEnumerable<(float, (T, T, T))> GetCubicKeys();

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ICurveSampler<T> CreateCurveSampler(bool isolateMemory = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	internal sealed class _StaticBufferBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private readonly int _BufferIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private readonly List<byte> _Data;

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		public int BufferIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACB")]
			[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACC")]
			[Cpp2IlInjected.Address(RVA = "0xA504E30", Offset = "0xA504230", VA = "0x18A504E30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA504DA0", Offset = "0xA5041A0", VA = "0x18A504DA0")]
		public _StaticBufferBuilder(int bufferIndex, int initialCapacity = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA504BA0", Offset = "0xA503FA0", VA = "0x18A504BA0")]
		public int Append(byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA504D00", Offset = "0xA504100", VA = "0x18A504D00")]
		public byte[] ToArray()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	public interface ICamera
	{
		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		bool IsOrthographic
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		bool IsPerspective
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	public static class ExtensionsFactory
	{
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[DebuggerDisplay("{Name} {ParentType} {ExtType}")]
		internal readonly struct ExtensionEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			public readonly string Name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			public readonly Type ParentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			public readonly Type ExtType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			public readonly Func<JsonSerializable, JsonSerializable> Factory;

			[Cpp2IlInjected.Token(Token = "0x6000AD8")]
			[Cpp2IlInjected.Address(RVA = "0x414E520", Offset = "0x414D920", VA = "0x18414E520")]
			public static ExtensionEntry Create<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
			{
				return default(ExtensionEntry);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AD9")]
			[Cpp2IlInjected.Address(RVA = "0x23E3EE0", Offset = "0x23E32E0", VA = "0x1823E3EE0")]
			public ExtensionEntry(string n, Type p, Type e, Func<JsonSerializable, JsonSerializable> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADA")]
			[Cpp2IlInjected.Address(RVA = "0xA4E6060", Offset = "0xA4E5460", VA = "0x18A4E6060")]
			public bool IsMatch(Type parentType, string extensionName)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADB")]
			[Cpp2IlInjected.Address(RVA = "0xA4E5FE0", Offset = "0xA4E53E0", VA = "0x18A4E5FE0")]
			public bool IsMatch(Type parentType, Type extensionType)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private static readonly List<ExtensionEntry> _Extensions;

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		public static IEnumerable<string> SupportedExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0xA4E6F80", Offset = "0xA4E6380", VA = "0x18A4E6F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA4E6470", Offset = "0xA4E5870", VA = "0x18A4E6470")]
		static ExtensionsFactory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3A9A9D0", Offset = "0x3A99DD0", VA = "0x183A9A9D0")]
		[Obsolete("Use RegisterExtension(name, factory) instead.")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x3A9A6D0", Offset = "0x3A99AD0", VA = "0x183A9A6D0")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName, Func<TParent, JsonSerializable> factory) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA4E60C0", Offset = "0xA4E54C0", VA = "0x18A4E60C0")]
		internal static JsonSerializable Create(JsonSerializable parent, string extensionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E6290", Offset = "0xA4E5690", VA = "0x18A4E6290")]
		internal static string Identify(Type parentType, Type extensionType)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	public interface IExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		IReadOnlyCollection<JsonSerializable> Extensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000AFE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000AFF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public abstract class ExtraProperties : JsonReflectable, IExtraProperties
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private readonly struct _ExtensionsReflection : IReflectionObject
		{
			[Cpp2IlInjected.Token(Token = "0x2000121")]
			[CompilerGenerated]
			private sealed class <GetFields>d__3 : IEnumerable<SharpGLTF.Reflection.FieldInfo>, IEnumerable, IEnumerator<SharpGLTF.Reflection.FieldInfo>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000549")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400054A")]
				private SharpGLTF.Reflection.FieldInfo <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400054B")]
				private int <>l__initialThreadId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400054C")]
				public _ExtensionsReflection <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x400054D")]
				public _ExtensionsReflection <>3__<>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x400054E")]
				private IEnumerator<JsonSerializable> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				SharpGLTF.Reflection.FieldInfo IEnumerator<SharpGLTF.Reflection.FieldInfo>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000B24")]
					[Cpp2IlInjected.Address(RVA = "0x4E874C0", Offset = "0x4E868C0", VA = "0x184E874C0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return default(SharpGLTF.Reflection.FieldInfo);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000B26")]
					[Cpp2IlInjected.Address(RVA = "0xA4FBB90", Offset = "0xA4FAF90", VA = "0x18A4FBB90", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000B20")]
				[Cpp2IlInjected.Address(RVA = "0x65D8650", Offset = "0x65D7A50", VA = "0x1865D8650")]
				[DebuggerHidden]
				public <GetFields>d__3(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B21")]
				[Cpp2IlInjected.Address(RVA = "0xA4FBBE0", Offset = "0xA4FAFE0", VA = "0x18A4FBBE0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B22")]
				[Cpp2IlInjected.Address(RVA = "0xA4FB770", Offset = "0xA4FAB70", VA = "0x18A4FB770", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B23")]
				[Cpp2IlInjected.Address(RVA = "0xA4FBCA0", Offset = "0xA4FB0A0", VA = "0x18A4FBCA0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B25")]
				[Cpp2IlInjected.Address(RVA = "0xA4FBB50", Offset = "0xA4FAF50", VA = "0x18A4FBB50", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B27")]
				[Cpp2IlInjected.Address(RVA = "0xA4FBAB0", Offset = "0xA4FAEB0", VA = "0x18A4FBAB0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B28")]
				[Cpp2IlInjected.Address(RVA = "0xA4FBAB0", Offset = "0xA4FAEB0", VA = "0x18A4FBAB0", Slot = "5")]
				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private readonly IReadOnlyList<JsonSerializable> _Extensions;

			[Cpp2IlInjected.Token(Token = "0x6000B17")]
			[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
			public _ExtensionsReflection(IReadOnlyList<JsonSerializable> extensions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B18")]
			[Cpp2IlInjected.Address(RVA = "0xA5034B0", Offset = "0xA5028B0", VA = "0x18A5034B0", Slot = "5")]
			public bool TryGetField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0xA503430", Offset = "0xA502830", VA = "0x18A503430", Slot = "4")]
			[IteratorStateMachine(typeof(<GetFields>d__3))]
			public IEnumerable<SharpGLTF.Reflection.FieldInfo> GetFields()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[CompilerGenerated]
		private sealed class <Flatten>d__12 : IEnumerable<ExtraProperties>, IEnumerable, IEnumerator<ExtraProperties>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			private ExtraProperties <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			private ExtraProperties container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			public ExtraProperties <>3__container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			private IEnumerator<ExtraProperties> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			private IEnumerator<ExtraProperties> <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170001A4")]
			ExtraProperties IEnumerator<ExtraProperties>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B3A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B3C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B35")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <Flatten>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B36")]
			[Cpp2IlInjected.Address(RVA = "0xA4FB450", Offset = "0xA4FA850", VA = "0x18A4FB450", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B37")]
			[Cpp2IlInjected.Address(RVA = "0xA4FAFD0", Offset = "0xA4FA3D0", VA = "0x18A4FAFD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0xA4FB5F0", Offset = "0xA4FA9F0", VA = "0x18A4FB5F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0xA4FB640", Offset = "0xA4FAA40", VA = "0x18A4FB640")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0xA4FB410", Offset = "0xA4FA810", VA = "0x18A4FB410", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3D")]
			[Cpp2IlInjected.Address(RVA = "0xA4FB370", Offset = "0xA4FA770", VA = "0x18A4FB370", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3E")]
			[Cpp2IlInjected.Address(RVA = "0xA4FB370", Offset = "0xA4FA770", VA = "0x18A4FB370", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[CompilerGenerated]
		private sealed class <GetLogicalChildren>d__11 : IEnumerable<ExtraProperties>, IEnumerable, IEnumerator<ExtraProperties>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private ExtraProperties <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public ExtraProperties <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			private IEnumerator<ExtraProperties> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			private IEnumerator<SharpGLTF.Reflection.FieldInfo> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			private IReflectionArray <array>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private int <i>5__5;

			[Cpp2IlInjected.Token(Token = "0x170001A6")]
			ExtraProperties IEnumerator<ExtraProperties>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B44")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B46")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3F")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <GetLogicalChildren>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B40")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC470", Offset = "0xA4FB870", VA = "0x18A4FC470", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0xA4FBCF0", Offset = "0xA4FB0F0", VA = "0x18A4FBCF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC610", Offset = "0xA4FBA10", VA = "0x18A4FC610")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC660", Offset = "0xA4FBA60", VA = "0x18A4FC660")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B45")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC430", Offset = "0xA4FB830", VA = "0x18A4FC430", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC390", Offset = "0xA4FB790", VA = "0x18A4FC390", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B48")]
			[Cpp2IlInjected.Address(RVA = "0xA4FC390", Offset = "0xA4FB790", VA = "0x18A4FC390", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000128")]
		[CompilerGenerated]
		private sealed class <ReflectFieldsNames>d__9 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			private string <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			public ExtraProperties <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400056A")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170001A8")]
			string IEnumerator<string>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B4D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A9")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B4F")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B49")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0xA4FCFA0", Offset = "0xA4FC3A0", VA = "0x18A4FCFA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0xA4FCBA0", Offset = "0xA4FBFA0", VA = "0x18A4FCBA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4C")]
			[Cpp2IlInjected.Address(RVA = "0xA4FD060", Offset = "0xA4FC460", VA = "0x18A4FD060")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0xA4FCF60", Offset = "0xA4FC360", VA = "0x18A4FCF60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B50")]
			[Cpp2IlInjected.Address(RVA = "0xA4FCEC0", Offset = "0xA4FC2C0", VA = "0x18A4FCEC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0xA4FCEC0", Offset = "0xA4FC2C0", VA = "0x18A4FCEC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private readonly List<JsonSerializable> _extensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private JsonNode _extras;

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public new const string SCHEMANAME = "ExtraProperties";

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public IReadOnlyCollection<JsonSerializable> Extensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000B00")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "14")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0xA4E8460", Offset = "0xA4E7860", VA = "0x18A4E8460", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7360", Offset = "0xA4E6760", VA = "0x18A4E7360", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0xA4E79C0", Offset = "0xA4E6DC0", VA = "0x18A4E79C0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__9))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7B00", Offset = "0xA4E6F00", VA = "0x18A4E7B00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0xA4E72E0", Offset = "0xA4E66E0", VA = "0x18A4E72E0")]
		[IteratorStateMachine(typeof(<GetLogicalChildren>d__11))]
		protected IEnumerable<ExtraProperties> GetLogicalChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7260", Offset = "0xA4E6660", VA = "0x18A4E7260")]
		[IteratorStateMachine(typeof(<Flatten>d__12))]
		protected static IEnumerable<ExtraProperties> Flatten(ExtraProperties container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D4B0", Offset = "0x3A9C8B0", VA = "0x183A9D4B0")]
		protected static void SetProperty<TParent, TProperty, TValue>(TParent parent, TProperty property, TValue value) where TParent : ExtraProperties where TProperty : class where TValue : TProperty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x3A9CDE0", Offset = "0x3A9C1E0", VA = "0x183A9CDE0")]
		protected static ChildSetter<T> GetChildSetter<T>(T owner) where T : ExtraProperties
		{
			return default(ChildSetter<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x3A9CE30", Offset = "0x3A9C230", VA = "0x183A9CE30")]
		public T GetExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D530", Offset = "0x3A9C930", VA = "0x183A9D530")]
		public T UseExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x3A9D100", Offset = "0x3A9C500", VA = "0x183A9D100")]
		public void SetExtension<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x3A9CE80", Offset = "0x3A9C280", VA = "0x183A9CE80")]
		public void RemoveExtensions<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x3A9CF70", Offset = "0x3A9C370", VA = "0x183A9CF70")]
		public void RemoveExtensions<T>() where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E75A0", Offset = "0xA4E69A0", VA = "0x18A4E75A0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7390", Offset = "0xA4E6790", VA = "0x18A4E7390", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7A40", Offset = "0xA4E6E40", VA = "0x18A4E7A40", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8100", Offset = "0xA4E7500", VA = "0x18A4E8100")]
		private static Dictionary<string, JsonSerializable> _ToDictionary(JsonSerializable context, IEnumerable<JsonSerializable> serializables)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7130", Offset = "0xA4E6530", VA = "0x18A4E7130", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7E30", Offset = "0xA4E7230", VA = "0x18A4E7E30")]
		private static void _DeserializeExtensions(JsonSerializable parent, Utf8JsonReader reader, List<JsonSerializable> extensions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0xA4E83E0", Offset = "0xA4E77E0", VA = "0x18A4E83E0")]
		protected ExtraProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[DebuggerDisplay("Channel {_Key}")]
	public readonly struct MaterialChannel : IEquatable<MaterialChannel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Material _Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _Key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly _MaterialTexture _TextureInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly IReadOnlyList<IMaterialParameter> _Parameters;

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		public Material LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B58")]
			[Cpp2IlInjected.Address(RVA = "0xED9420", Offset = "0xED8820", VA = "0x180ED9420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000B59")]
			[Cpp2IlInjected.Address(RVA = "0xF3E410", Offset = "0xF3D810", VA = "0x180F3E410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public bool HasDefaultContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC660", Offset = "0xA4EBA60", VA = "0x18A4EC660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		[Obsolete("Use Parameters[]")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Vector4 Parameter
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5B")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC670", Offset = "0xA4EBA70", VA = "0x18A4EC670")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xA4ECA10", Offset = "0xA4EBE10", VA = "0x18A4ECA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public IReadOnlyList<IMaterialParameter> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public Texture Texture
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC750", Offset = "0xA4EBB50", VA = "0x18A4EC750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public TextureSampler TextureSampler
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC6E0", Offset = "0xA4EBAE0", VA = "0x18A4EC6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC6D0", Offset = "0xA4EBAD0", VA = "0x18A4EC6D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC710", Offset = "0xA4EBB10", VA = "0x18A4EC710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC430", Offset = "0xA4EB830", VA = "0x18A4EC430")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC7E0", Offset = "0xA4EBBE0", VA = "0x18A4EC7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC210", Offset = "0xA4EB610", VA = "0x18A4EC210")]
		internal MaterialChannel(Material m, string key, _MaterialTexture texInfo, params IMaterialParameter[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBA60", Offset = "0xA4EAE60", VA = "0x18A4EBA60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB830", Offset = "0xA4EAC30", VA = "0x18A4EB830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB8F0", Offset = "0xA4EACF0", VA = "0x18A4EB8F0", Slot = "4")]
		public bool Equals(MaterialChannel other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC760", Offset = "0xA4EBB60", VA = "0x18A4EC760")]
		public static bool operator ==([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC7A0", Offset = "0xA4EBBA0", VA = "0x18A4EC7A0")]
		public static bool operator !=([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB930", Offset = "0xA4EAD30", VA = "0x18A4EB930")]
		public float GetFactor(string key)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBAC0", Offset = "0xA4EAEC0", VA = "0x18A4EBAC0")]
		public void SetFactor(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC100", Offset = "0xA4EB500", VA = "0x18A4EC100")]
		private Texture _GetTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBC00", Offset = "0xA4EB000", VA = "0x18A4EBC00")]
		public Texture SetTexture(int texCoord, Image primaryImg, [Optional] Image fallbackImg, TextureWrapMode ws = TextureWrapMode.REPEAT, TextureWrapMode wt = TextureWrapMode.REPEAT, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBDB0", Offset = "0xA4EB1B0", VA = "0x18A4EBDB0")]
		public void SetTexture(int texSet, Texture tex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBF00", Offset = "0xA4EB300", VA = "0x18A4EBF00")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBFD0", Offset = "0xA4EB3D0", VA = "0x18A4EBFD0")]
		private bool _CheckHasDefaultContent()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	internal readonly struct _MaterialTexture
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private readonly Func<TextureInfo> _Getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private readonly Func<TextureInfo> _Using;

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000B75")]
			[Cpp2IlInjected.Address(RVA = "0x3AD5C00", Offset = "0x3AD5000", VA = "0x183AD5C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public TextureInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000B76")]
			[Cpp2IlInjected.Address(RVA = "0xA5038F0", Offset = "0xA502CF0", VA = "0x18A5038F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B77")]
			[Cpp2IlInjected.Address(RVA = "0xA503910", Offset = "0xA502D10", VA = "0x18A503910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0xA5039A0", Offset = "0xA502DA0", VA = "0x18A5039A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0xA5039E0", Offset = "0xA502DE0", VA = "0x18A5039E0")]
		public static implicit operator _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
			return default(_MaterialTexture);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0xA5036F0", Offset = "0xA502AF0", VA = "0x18A5036F0")]
		public _MaterialTexture(Func<TextureInfo> getter, Action initialize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0xA5037E0", Offset = "0xA502BE0", VA = "0x18A5037E0")]
		public _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xA5036D0", Offset = "0xA502AD0", VA = "0x18A5036D0")]
		public TextureInfo Use()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	public interface IMaterialParameter
	{
		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000B80")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000B81")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		object Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	internal enum _MaterialParameterKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		RGB,
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		RGBA,
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		Minimum,
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		Maximum,
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		NormalScale,
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		OcclusionStrength,
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		EmissiveStrength,
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		IndexOfRefraction,
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		MetallicFactor,
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		RoughnessFactor,
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		SpecularFactor,
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		GlossinessFactor,
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		ClearCoatFactor,
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		ThicknessFactor,
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		TransmissionFactor,
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		IridescenceFactor,
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		AttenuationDistance,
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		DiffuseTransmissionFactor,
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		AnisotropyStrength,
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		AnisotropyRotation
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[DebuggerDisplay("{_Key} = {Value}")]
	internal readonly struct _MaterialParameter<T> : IMaterialParameter where T : struct, IEquatable<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private readonly _MaterialParameterKey _Key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private readonly T _ValueDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private readonly Func<T> _ValueGetter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private readonly Action<T> _ValueSetter;

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000B85")]
			[Cpp2IlInjected.Address(RVA = "0x5145160", Offset = "0x5144560", VA = "0x185145160", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x5144CD0", Offset = "0x51440D0", VA = "0x185144CD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000B87")]
			[Cpp2IlInjected.Address(RVA = "0x5145560", Offset = "0x5144960", VA = "0x185145560", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x5145820", Offset = "0x5144C20", VA = "0x185145820")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x5145A40", Offset = "0x5144E40", VA = "0x185145A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		object IMaterialParameter.Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0x51439C0", Offset = "0x5142DC0", VA = "0x1851439C0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8B")]
			[Cpp2IlInjected.Address(RVA = "0x5143DF0", Offset = "0x51431F0", VA = "0x185143DF0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x5144720", Offset = "0x5143B20", VA = "0x185144720")]
		internal _MaterialParameter(_MaterialParameterKey key, T defval, Func<T> getter, Action<T> setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x5142960", Offset = "0x5141D60", VA = "0x185142960")]
		internal static Vector4 Combine(IReadOnlyList<IMaterialParameter> parameters)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x51406B0", Offset = "0x513FAB0", VA = "0x1851406B0")]
		internal static void Apply(IReadOnlyList<IMaterialParameter> parameters, Vector4 value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	public interface IVisualNodeContainer
	{
		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x6000B91")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Node CreateNode([Optional] string name);
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public readonly struct NodeCurveSamplers : IEquatable<NodeCurveSamplers>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public readonly Node TargetNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public readonly Animation Animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private readonly AnimationSampler _ScaleSampler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private readonly AnimationSampler _RotationSampler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private readonly AnimationSampler _TranslationSampler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private readonly AnimationSampler _MorphSampler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private readonly AnimationSampler _VisibilitySampler;

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public bool HasTransformCurves
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0xA4F73B0", Offset = "0xA4F67B0", VA = "0x18A4F73B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public bool HasMorphingCurves
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0xE359D0", Offset = "0xE34DD0", VA = "0x180E359D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public IAnimationSampler<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public IAnimationSampler<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public IAnimationSampler<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		[Obsolete("Use GetMorphingSampler<T>()", true)]
		public IAnimationSampler<float[]> Morphing
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0xA4F7410", Offset = "0xA4F6810", VA = "0x18A4F7410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		[Obsolete("Use GetMorphingSampler<T>()", true)]
		public IAnimationSampler<SparseWeight8> MorphingSparse
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0xA4F73D0", Offset = "0xA4F67D0", VA = "0x18A4F73D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public IAnimationSampler<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6E90", Offset = "0xA4F6290", VA = "0x18A4F6E90")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7040", Offset = "0xA4F6440", VA = "0x18A4F7040")]
		internal NodeCurveSamplers(Node node, Animation animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x7D18570", Offset = "0x7D17970", VA = "0x187D18570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6700", Offset = "0xA4F5B00", VA = "0x18A4F6700", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7450", Offset = "0xA4F6850", VA = "0x18A4F7450")]
		public static bool operator ==([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7480", Offset = "0xA4F6880", VA = "0x18A4F7480")]
		public static bool operator !=([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0xA4F66D0", Offset = "0xA4F5AD0", VA = "0x18A4F66D0", Slot = "4")]
		public bool Equals(NodeCurveSamplers other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x37C5FE0", Offset = "0x37C53E0", VA = "0x1837C5FE0")]
		public IAnimationSampler<TWeights> GetMorphingSampler<TWeights>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6780", Offset = "0xA4F5B80", VA = "0x18A4F6780")]
		public AffineTransform GetLocalTransform(float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A1B0", Offset = "0x3D395B0", VA = "0x183D3A1B0")]
		public IReadOnlyList<float> GetMorphingWeights<TWeight>(float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6C40", Offset = "0xA4F6040", VA = "0x18A4F6C40")]
		public SparseWeight8 GetSparseMorphingWeights(float time)
		{
			return default(SparseWeight8);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	public enum PunctualLightType
	{
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		Directional,
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		Point,
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		Spot
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	public interface IConvertibleToGltf2
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ModelRoot ToGltf2();
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	internal static class _BinarySerialization
	{
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		public const uint GLTFHEADER = 1179937895u;

		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		public const uint GLTFVERSION2 = 2u;

		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public const uint CHUNKJSON = 1313821514u;

		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public const uint CHUNKBIN = 5130562u;

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0xA5028C0", Offset = "0xA501CC0", VA = "0x18A5028C0")]
		public static Memory<byte> ReadBytesToEnd(this Stream s)
		{
			return default(Memory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0xA5033E0", Offset = "0xA5027E0", VA = "0x18A5033E0")]
		internal static bool _TryReadUInt32(this BinaryReader r, [Out] uint result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0xA502F20", Offset = "0xA502320", VA = "0x18A502F20")]
		internal static bool _Identify(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0xA502270", Offset = "0xA501670", VA = "0x18A502270")]
		internal static bool IsBinaryHeader(ReadOnlySpan<byte> span)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0xA502300", Offset = "0xA501700", VA = "0x18A502300")]
		public static bool IsBinaryHeader(byte a, byte b, byte c, byte d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0xA502330", Offset = "0xA501730", VA = "0x18A502330")]
		public static IReadOnlyDictionary<uint, byte[]> ReadBinaryFile(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0xA5030E0", Offset = "0xA5024E0", VA = "0x18A5030E0")]
		private static long _ReadBinaryHeader(BinaryReader binaryReader)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0xA5020F0", Offset = "0xA5014F0", VA = "0x18A5020F0")]
		public static Exception IsBinaryCompatible(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0xA502BF0", Offset = "0xA501FF0", VA = "0x18A502BF0")]
		public static void WriteBinaryModel(this BinaryWriter binaryWriter, ModelRoot model)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	public delegate ArraySegment<byte> FileReaderCallback(string assetName);
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	public delegate string UriResolver(string relativeUri);
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public class ReadContext : ReadSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private UriResolver _UriResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private FileReaderCallback _FileReader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private byte[] _BinaryChunk;

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		internal bool _CheckSupportedExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBF")]
			[Cpp2IlInjected.Address(RVA = "0xF6BC90", Offset = "0xF6B090", VA = "0x180F6BC90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(RVA = "0xF6B830", Offset = "0xF6AC30", VA = "0x180F6B830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0xA4F8070", Offset = "0xA4F7470", VA = "0x18A4F8070")]
		public static ReadContext Create(FileReaderCallback callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7DB0", Offset = "0xA4F71B0", VA = "0x18A4F7DB0")]
		public static ReadContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7C30", Offset = "0xA4F7030", VA = "0x18A4F7C30")]
		public static ReadContext CreateFromDictionary(IReadOnlyDictionary<string, ArraySegment<byte>> dictionary, bool checkExtensions = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0xA4FA420", Offset = "0xA4F9820", VA = "0x18A4FA420")]
		private ReadContext(FileReaderCallback reader, [Optional] UriResolver uriResolver, bool checkExtensions = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0xA4F9530", Offset = "0xA4F8930", VA = "0x18A4F9530")]
		public ReadContext WithSettingsFrom(ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0xA4FA490", Offset = "0xA4F9890", VA = "0x18A4FA490")]
		internal ReadContext(ReadContext other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0xA4F9140", Offset = "0xA4F8540", VA = "0x18A4F9140")]
		public bool TryGetFullPath(string relativeUri, [Out] string fullPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0xA4F8230", Offset = "0xA4F7630", VA = "0x18A4F8230")]
		public Stream OpenFile(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0xA4F8360", Offset = "0xA4F7760", VA = "0x18A4F8360")]
		public ArraySegment<byte> ReadAllBytesToEnd(string resourceName)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0xA4F91A0", Offset = "0xA4F85A0", VA = "0x18A4F91A0")]
		public ValidationResult Validate(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0xA4F89A0", Offset = "0xA4F7DA0", VA = "0x18A4F89A0")]
		public ModelRoot ReadSchema2(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0xA4F8C00", Offset = "0xA4F8000", VA = "0x18A4F8C00")]
		public ModelRoot ReadSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0xA4F8F70", Offset = "0xA4F8370", VA = "0x18A4F8F70")]
		public ModelRoot ReadTextSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0xA4F8420", Offset = "0xA4F7820", VA = "0x18A4F8420")]
		public ModelRoot ReadBinarySchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0xA4F9610", Offset = "0xA4F8A10", VA = "0x18A4F9610")]
		private static ModelRoot _FilterErrors((ModelRoot Model, ValidationResult Validation) mv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0xA4F97D0", Offset = "0xA4F8BD0", VA = "0x18A4F97D0")]
		private (ModelRoot, ValidationResult) _ReadGLB(Stream stream)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0xA4F9C10", Offset = "0xA4F9010", VA = "0x18A4F9C10")]
		private (ModelRoot, ValidationResult) _Read(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0xA4F9690", Offset = "0xA4F8A90", VA = "0x18A4F9690")]
		private ReadOnlyMemory<byte> _Preprocess(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default(ReadOnlyMemory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0xA4F8180", Offset = "0xA4F7580", VA = "0x18A4F8180")]
		public static bool IdentifyBinaryContainer(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0xA4F8750", Offset = "0xA4F7B50", VA = "0x18A4F8750")]
		public static string ReadJson(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0xA4F85B0", Offset = "0xA4F79B0", VA = "0x18A4F85B0")]
		public static ReadOnlyMemory<byte> ReadJsonBytes(Stream stream)
		{
			return default(ReadOnlyMemory<byte>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public delegate bool ImageDecodeCallback(Image image);
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	public delegate string JsonFilterCallback(string json);
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public class ReadSettings
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public ValidationMode Validation
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE0")]
			[Cpp2IlInjected.Address(RVA = "0xCF3110", Offset = "0xCF2510", VA = "0x180CF3110")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0xCFB380", Offset = "0xCFA780", VA = "0x180CFB380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public ImageDecodeCallback ImageDecoder
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C10", Offset = "0xCF4010", VA = "0x180CF4C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public JsonFilterCallback JsonPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0xCF6630", Offset = "0xCF5A30", VA = "0x180CF6630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0xA4FA7F0", Offset = "0xA4F9BF0", VA = "0x18A4FA7F0")]
		public static implicit operator ReadSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0xA4FA7E0", Offset = "0xA4F9BE0", VA = "0x18A4FA7E0")]
		public ReadSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0xA4FA6C0", Offset = "0xA4F9AC0", VA = "0x18A4FA6C0")]
		public ReadSettings(ReadSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0xA4FA5E0", Offset = "0xA4F99E0", VA = "0x18A4FA5E0")]
		public void CopyTo(ReadSettings other)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public delegate void FileWriterCallback(string assetName, ArraySegment<byte> assetData);
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public delegate string ImageWriterCallback(WriteContext context, string assetName, MemoryImage image);
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	public class WriteContext : WriteSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private readonly FileWriterCallback _ByteWriter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private readonly Func<string, Stream> _StreamWriter;

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public DirectoryInfo CurrentDirectory
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF4020", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0xCF5520", Offset = "0xCF4920", VA = "0x180CF5520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		internal bool _UpdateSupportedExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E30", Offset = "0xCF4230", VA = "0x180CF4E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFB")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C80", Offset = "0xCF4080", VA = "0x180CF4C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		internal bool _NoCloneWatchdog
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFC")]
			[Cpp2IlInjected.Address(RVA = "0xCF5510", Offset = "0xCF4910", VA = "0x180CF5510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DA0", Offset = "0xCF41A0", VA = "0x180CF4DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0xA5009C0", Offset = "0xA4FFDC0", VA = "0x18A5009C0")]
		public static WriteContext Create(FileWriterCallback fileCallback, [Optional] Func<string, Stream> streamWriteCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0xA500540", Offset = "0xA4FF940", VA = "0x18A500540")]
		public static WriteContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0xA500370", Offset = "0xA4FF770", VA = "0x18A500370")]
		public static WriteContext CreateFromDictionary(IDictionary<string, ArraySegment<byte>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0xA500780", Offset = "0xA4FFB80", VA = "0x18A500780")]
		public static WriteContext CreateFromStream(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0xA500B60", Offset = "0xA4FFF60", VA = "0x18A500B60")]
		public WriteContext WithTextSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0xA500AE0", Offset = "0xA4FFEE0", VA = "0x18A500AE0")]
		public WriteContext WithBinarySettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0xA500B30", Offset = "0xA4FFF30", VA = "0x18A500B30")]
		public WriteContext WithSettingsFrom(WriteSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0xA500B20", Offset = "0xA4FFF20", VA = "0x18A500B20")]
		internal WriteContext WithDeepCloneSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0xA501DF0", Offset = "0xA5011F0", VA = "0x18A501DF0")]
		private WriteContext(FileWriterCallback byteWriteCallback, Func<string, Stream> streamWriteCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0xA500B80", Offset = "0xA4FFF80", VA = "0x18A500B80")]
		public void WriteAllBytesToEnd(string fileName, ArraySegment<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0xA501180", Offset = "0xA500580", VA = "0x18A501180")]
		public string WriteImage(string assetName, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0xA5013B0", Offset = "0xA5007B0", VA = "0x18A5013B0")]
		public void WriteTextSchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0xA500BC0", Offset = "0xA4FFFC0", VA = "0x18A500BC0")]
		public void WriteBinarySchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0xA501C70", Offset = "0xA501070", VA = "0x18A501C70")]
		private void _ValidateBeforeWriting(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0xA501850", Offset = "0xA500C50", VA = "0x18A501850")]
		private ModelRoot _PreprocessSchema2(ModelRoot model, bool imagesAsBufferViews, bool mergeBuffers, int buffersMaxSize)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	public enum ResourceWriteMode
	{
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		SatelliteFile,
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		EmbeddedAsBase64,
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		BufferView
	}
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	public class WriteSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private JsonWriterOptions _JsonOptions;

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public ResourceWriteMode ImageWriting
		{
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550")]
			[CompilerGenerated]
			get
			{
				return default(ResourceWriteMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0xD47A90", Offset = "0xD46E90", VA = "0x180D47A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public ImageWriterCallback ImageWriteCallback
		{
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CF0", Offset = "0xCF40F0", VA = "0x180CF4CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0xCF6640", Offset = "0xCF5A40", VA = "0x180CF6640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000C15")]
			[Cpp2IlInjected.Address(RVA = "0xD4DA50", Offset = "0xD4CE50", VA = "0x180D4DA50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C16")]
			[Cpp2IlInjected.Address(RVA = "0xD4E320", Offset = "0xD4D720", VA = "0x180D4E320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public int BuffersMaxSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000C17")]
			[Cpp2IlInjected.Address(RVA = "0xD442D0", Offset = "0xD436D0", VA = "0x180D442D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C18")]
			[Cpp2IlInjected.Address(RVA = "0x16E0DF0", Offset = "0x16E01F0", VA = "0x1816E0DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public bool JsonIndented
		{
			[Cpp2IlInjected.Token(Token = "0x6000C19")]
			[Cpp2IlInjected.Address(RVA = "0xA502060", Offset = "0xA501460", VA = "0x18A502060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1A")]
			[Cpp2IlInjected.Address(RVA = "0xA5020E0", Offset = "0xA5014E0", VA = "0x18A5020E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public JsonWriterOptions JsonOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1B")]
			[Cpp2IlInjected.Address(RVA = "0xF151B0", Offset = "0xF145B0", VA = "0x180F151B0")]
			get
			{
				return default(JsonWriterOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0x4B53640", Offset = "0x4B52A40", VA = "0x184B53640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public ValidationMode Validation
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(RVA = "0xD24210", Offset = "0xD23610", VA = "0x180D24210")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(RVA = "0xE09150", Offset = "0xE08550", VA = "0x180E09150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public JsonFilterCallback JsonPostprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C20")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DE0", Offset = "0xCF41E0", VA = "0x180CF4DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0xA502070", Offset = "0xA501470", VA = "0x18A502070")]
		public static implicit operator WriteSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0xA501F60", Offset = "0xA501360", VA = "0x18A501F60")]
		public WriteSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0xA501F80", Offset = "0xA501380", VA = "0x18A501F80")]
		public WriteSettings(WriteSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0xA501E60", Offset = "0xA501260", VA = "0x18A501E60")]
		public void CopyTo(WriteSettings other)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	internal static class _Schema2Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0xA504500", Offset = "0xA503900", VA = "0x18A504500")]
		public static void SetMorphWeights(this IList<double> list, int maxCount, SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0xA503EF0", Offset = "0xA5032F0", VA = "0x18A503EF0")]
		public static void SetMorphWeights(this IList<double> list, IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0xA503A00", Offset = "0xA502E00", VA = "0x18A503A00")]
		internal static string AsName(this string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x414BB30", Offset = "0x414AF30", VA = "0x18414BB30")]
		internal static T AsValue<T>(this T? value, T defval) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x414A8F0", Offset = "0x4149CF0", VA = "0x18414A8F0")]
		internal static T? AsNullable<T>(this T value, T defval) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x414A9A0", Offset = "0x4149DA0", VA = "0x18414A9A0")]
		internal static T? AsNullable<T>(this T value, T defval, T minval, T maxval) where T : struct, IEquatable<T>, IComparable<T>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0xA503A30", Offset = "0xA502E30", VA = "0x18A503A30")]
		internal static Vector2? AsNullable(this Vector2 value, Vector2 defval, Vector2 minval, Vector2 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0xA503B60", Offset = "0xA502F60", VA = "0x18A503B60")]
		internal static Vector3? AsNullable(this Vector3 value, Vector3 defval, Vector3 minval, Vector3 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0xA503CF0", Offset = "0xA5030F0", VA = "0x18A503CF0")]
		internal static Vector4? AsNullable(this Vector4 value, Vector4 defval, Vector4 minval, Vector4 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0xA503EC0", Offset = "0xA5032C0", VA = "0x18A503EC0")]
		internal static string AsNullable(this string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0xA503A00", Offset = "0xA502E00", VA = "0x18A503A00")]
		internal static string AsEmptyNullable(this string value)
		{
			return null;
		}
	}
}
namespace SharpGLTF.Reflection
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[DebuggerDisplay("({ValueType}) {Name} = {Value}")]
	public readonly struct FieldInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private readonly Func<object, object> _Getter;

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0xED9420", Offset = "0xED8820", VA = "0x180ED9420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public object Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000C32")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0xA4E87E0", Offset = "0xA4E7BE0", VA = "0x18A4E87E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public object Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0xA4E87F0", Offset = "0xA4E7BF0", VA = "0x18A4E87F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8680", Offset = "0xA4E7A80", VA = "0x18A4E8680")]
		public static void Verify(IReflectionObject reflectionObject, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E84A0", Offset = "0xA4E78A0", VA = "0x18A4E84A0")]
		public static FieldInfo From(IReflectionObject reflectionObject, string path)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2790", Offset = "0x3AB1B90", VA = "0x183AB2790")]
		public static FieldInfo From<TInstance, TValue>(string name, TInstance instance, Func<TInstance, TValue> getter)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8770", Offset = "0xA4E7B70", VA = "0x18A4E8770")]
		private FieldInfo(string name, Type valueType, object instance, Func<object, object> getter)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	public interface IReflectionObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<FieldInfo> GetFields();

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TryGetField(string name, [Out] FieldInfo value);
	}
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public interface IReflectionArray : IReflectionObject
	{
		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000C3A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FieldInfo GetField(int index);
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	public abstract class JsonReflectable : JsonSerializable, IReflectionObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Reflection-IReflectionObject-GetFields>d__4 : IEnumerable<FieldInfo>, IEnumerable, IEnumerator<FieldInfo>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private FieldInfo <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public JsonReflectable <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			private IEnumerator<string> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170001DF")]
			FieldInfo IEnumerator<FieldInfo>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C48")]
				[Cpp2IlInjected.Address(RVA = "0x4E874C0", Offset = "0x4E868C0", VA = "0x184E874C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(FieldInfo);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001E0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4A")]
				[Cpp2IlInjected.Address(RVA = "0xA4FD3F0", Offset = "0xA4FC7F0", VA = "0x18A4FD3F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C44")]
			[Cpp2IlInjected.Address(RVA = "0x65D8650", Offset = "0x65D7A50", VA = "0x1865D8650")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C45")]
			[Cpp2IlInjected.Address(RVA = "0xA4FD440", Offset = "0xA4FC840", VA = "0x18A4FD440", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0xA4FD0B0", Offset = "0xA4FC4B0", VA = "0x18A4FD0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0xA4FD500", Offset = "0xA4FC900", VA = "0x18A4FD500")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0xA4FD3B0", Offset = "0xA4FC7B0", VA = "0x18A4FD3B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4B")]
			[Cpp2IlInjected.Address(RVA = "0xA4FD310", Offset = "0xA4FC710", VA = "0x18A4FD310", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0xA4FD310", Offset = "0xA4FC710", VA = "0x18A4FD310", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public const string SCHEMANAME = "Object";

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB750", Offset = "0xA4EAB50", VA = "0x18A4EB750", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7D90", Offset = "0xA4E7190", VA = "0x18A4E7D90", Slot = "11")]
		protected virtual IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB820", Offset = "0xA4EAC20", VA = "0x18A4EB820", Slot = "12")]
		protected virtual bool TryReflectField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB780", Offset = "0xA4EAB80", VA = "0x18A4EB780", Slot = "9")]
		[IteratorStateMachine(typeof(<SharpGLTF-Reflection-IReflectionObject-GetFields>d__4))]
		IEnumerable<FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB800", Offset = "0xA4EAC00", VA = "0x18A4EB800", Slot = "10")]
		bool IReflectionObject.TryGetField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB740", Offset = "0xA4EAB40", VA = "0x18A4EB740", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
		protected JsonReflectable()
		{
		}
	}
}
namespace SharpGLTF.Memory
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public readonly struct AttributeFormat : IEquatable<AttributeFormat>
	{
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public static readonly AttributeFormat Byte1;

		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public static readonly AttributeFormat Float1;

		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public static readonly AttributeFormat Float2;

		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		public static readonly AttributeFormat Float3;

		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		public static readonly AttributeFormat Float4;

		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public static readonly AttributeFormat Float2x2;

		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public static readonly AttributeFormat Float3x3;

		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public static readonly AttributeFormat Float4x4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public readonly EncodingType Encoding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public readonly DimensionType Dimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public readonly bool Normalized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		public readonly int ByteSize;

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public int ByteSizePadded
		{
			[Cpp2IlInjected.Token(Token = "0x6000C5A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E47C0", Offset = "0xA4E3BC0", VA = "0x18A4E47C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E41F0", Offset = "0xA4E35F0", VA = "0x18A4E41F0")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4920", Offset = "0xA4E3D20", VA = "0x18A4E4920")]
		public static implicit operator AttributeFormat(IndexEncodingType indexer)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4850", Offset = "0xA4E3C50", VA = "0x18A4E4850")]
		public static implicit operator AttributeFormat(EncodingType enc)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0xA4E48D0", Offset = "0xA4E3CD0", VA = "0x18A4E48D0")]
		public static implicit operator AttributeFormat(DimensionType dim)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4970", Offset = "0xA4E3D70", VA = "0x18A4E4970")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4890", Offset = "0xA4E3C90", VA = "0x18A4E4890")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc, bool nrm) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4720", Offset = "0xA4E3B20", VA = "0x18A4E4720")]
		public AttributeFormat(IndexEncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0xA4E45D0", Offset = "0xA4E39D0", VA = "0x18A4E45D0")]
		public AttributeFormat(EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4770", Offset = "0xA4E3B70", VA = "0x18A4E4770")]
		public AttributeFormat(DimensionType dim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4610", Offset = "0xA4E3A10", VA = "0x18A4E4610")]
		public AttributeFormat(DimensionType dim, EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4650", Offset = "0xA4E3A50", VA = "0x18A4E4650")]
		public AttributeFormat(DimensionType dim, EncodingType enc, bool nrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4180", Offset = "0xA4E3580", VA = "0x18A4E4180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3FE0", Offset = "0xA4E33E0", VA = "0x18A4E3FE0")]
		public static bool AreEqual(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4000", Offset = "0xA4E3400", VA = "0x18A4E4000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E40F0", Offset = "0xA4E34F0", VA = "0x18A4E40F0", Slot = "4")]
		public bool Equals(AttributeFormat other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E47D0", Offset = "0xA4E3BD0", VA = "0x18A4E47D0")]
		public static bool operator ==(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E49C0", Offset = "0xA4E3DC0", VA = "0x18A4E49C0")]
		public static bool operator !=(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[DebuggerDisplay("Color4[{Count}]")]
	public readonly struct ColorArray : IAccessorArray<Vector4>, IReadOnlyList<Vector4>, IEnumerable<Vector4>, IEnumerable, IReadOnlyCollection<Vector4>, IList<Vector4>, ICollection<Vector4>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private readonly int _Dimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private readonly float _DefaultW;

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Vector4[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000C62")]
			[Cpp2IlInjected.Address(RVA = "0xA4E58A0", Offset = "0xA4E4CA0", VA = "0x18A4E58A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000C63")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0xA4E5770", Offset = "0xA4E4B70", VA = "0x18A4E5770", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0xA4E5920", Offset = "0xA4E4D20", VA = "0x18A4E5920", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5710", Offset = "0xA4E4B10", VA = "0x18A4E5710")]
		public ColorArray(Memory<byte> source, int byteStride = 0, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0xA4E55B0", Offset = "0xA4E49B0", VA = "0x18A4E55B0")]
		public ColorArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5250", Offset = "0xA4E4650", VA = "0x18A4E5250", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0xA4E54F0", Offset = "0xA4E48F0", VA = "0x18A4E54F0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4F70", Offset = "0xA4E4370", VA = "0x18A4E4F70", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5310", Offset = "0xA4E4710", VA = "0x18A4E5310", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5010", Offset = "0xA4E4410", VA = "0x18A4E5010", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5130", Offset = "0xA4E4530", VA = "0x18A4E5130")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5470", Offset = "0xA4E4870", VA = "0x18A4E5470", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E54B0", Offset = "0xA4E48B0", VA = "0x18A4E54B0", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E53B0", Offset = "0xA4E47B0", VA = "0x18A4E53B0", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0xA4E53F0", Offset = "0xA4E47F0", VA = "0x18A4E53F0", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5430", Offset = "0xA4E4830", VA = "0x18A4E5430", Slot = "22")]
		bool ICollection<Vector4>.Remove(Vector4 item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	internal struct EncodedArrayEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private readonly IReadOnlyList<T> _Accessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private readonly int _Count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private int _Index;

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D630", Offset = "0x5B3CA30", VA = "0x185B3D630", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x5B3CED0", Offset = "0x5B3C2D0", VA = "0x185B3CED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D370", Offset = "0x5B3C770", VA = "0x185B3D370")]
		public EncodedArrayEnumerator(IReadOnlyList<T> accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CCA0", Offset = "0x5B3C0A0", VA = "0x185B3CCA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CCB0", Offset = "0x5B3C0B0", VA = "0x185B3CCB0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	internal static class EncodedArrayUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0xA4E59C0", Offset = "0xA4E4DC0", VA = "0x18A4E59C0")]
		public static void _CopyTo(this IEnumerable<int> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5CD0", Offset = "0xA4E50D0", VA = "0x18A4E5CD0")]
		public static void _CopyTo(this IEnumerable<bool> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x392A6A0", Offset = "0x3929AA0", VA = "0x18392A6A0")]
		public static void _CopyTo<T>(this IEnumerable<T> src, IList<T> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x392C2C0", Offset = "0x392B6C0", VA = "0x18392C2C0")]
		public static int _FirstIndexOf<T>(this IReadOnlyList<T> src, T value)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	internal readonly struct FloatingAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000157")]
		private delegate float _GetterCallback(int byteOffset);

		[Cpp2IlInjected.Token(Token = "0x2000158")]
		private delegate void _SetterCallback(int byteOffset, float value);

		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private const string ERR_UNSUPPORTEDENCODING = "Unsupported encoding.";

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private readonly Memory<byte> _Data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private readonly int _ByteStride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private readonly int _EncodedLen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private readonly int _ItemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private readonly _GetterCallback _Getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private readonly _SetterCallback _Setter;

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000C91")]
			[Cpp2IlInjected.Address(RVA = "0xA4EA580", Offset = "0xA4E9980", VA = "0x18A4EA580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000C92")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C93")]
			[Cpp2IlInjected.Address(RVA = "0xA4EA600", Offset = "0xA4E9A00", VA = "0x18A4EA600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C94")]
			[Cpp2IlInjected.Address(RVA = "0xA4EA6F0", Offset = "0xA4E9AF0", VA = "0x18A4EA6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public float this[int rowIndex, int subIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C95")]
			[Cpp2IlInjected.Address(RVA = "0xA4EA5C0", Offset = "0xA4E99C0", VA = "0x18A4EA5C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C96")]
			[Cpp2IlInjected.Address(RVA = "0xA4EA630", Offset = "0xA4E9A30", VA = "0x18A4EA630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E99A0", Offset = "0xA4E8DA0", VA = "0x18A4E99A0")]
		public FloatingAccessor(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9070", Offset = "0xA4E8470", VA = "0x18A4E9070")]
		private float _GetValueU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9850", Offset = "0xA4E8C50", VA = "0x18A4E9850")]
		private void _SetValueU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8C20", Offset = "0xA4E8020", VA = "0x18A4E8C20")]
		private float _GetValueS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9450", Offset = "0xA4E8850", VA = "0x18A4E9450")]
		private void _SetValueS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8D90", Offset = "0xA4E8190", VA = "0x18A4E8D90")]
		private float _GetValueU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0xA4E95A0", Offset = "0xA4E89A0", VA = "0x18A4E95A0")]
		private void _SetValueU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8AB0", Offset = "0xA4E7EB0", VA = "0x18A4E8AB0")]
		private float _GetValueS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9300", Offset = "0xA4E8700", VA = "0x18A4E9300")]
		private void _SetValueS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8F00", Offset = "0xA4E8300", VA = "0x18A4E8F00")]
		private float _GetValueU32(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0xA4E96F0", Offset = "0xA4E8AF0", VA = "0x18A4E96F0")]
		private void _SetValueU32(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8A90", Offset = "0xA4E7E90", VA = "0x18A4E8A90")]
		private float _GetNormalizedU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0xA4E92F0", Offset = "0xA4E86F0", VA = "0x18A4E92F0")]
		private void _SetNormalizedU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0xA4E89F0", Offset = "0xA4E7DF0", VA = "0x18A4E89F0")]
		private float _GetNormalizedS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9260", Offset = "0xA4E8660", VA = "0x18A4E9260")]
		private void _SetNormalizedS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8A70", Offset = "0xA4E7E70", VA = "0x18A4E8A70")]
		private float _GetNormalizedU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E92E0", Offset = "0xA4E86E0", VA = "0x18A4E92E0")]
		private void _SetNormalizedU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8970", Offset = "0xA4E7D70", VA = "0x18A4E8970")]
		private float _GetNormalizedS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E91E0", Offset = "0xA4E85E0", VA = "0x18A4E91E0")]
		private void _SetNormalizedS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8C50", Offset = "0x3AB8050", VA = "0x183AB8C50")]
		private T _GetValue<T>(int byteOffset) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x3AB9540", Offset = "0x3AB8940", VA = "0x183AB9540")]
		private void _SetValue<T>(int byteOffset, T value) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[DebuggerDisplay("Float[{Count}]")]
	public readonly struct ScalarArray : IAccessorArray<float>, IReadOnlyList<float>, IEnumerable<float>, IEnumerable, IReadOnlyCollection<float>, IList<float>, ICollection<float>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private float[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0xA4FAF30", Offset = "0xA4FA330", VA = "0x18A4FAF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA2")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA3")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA4")]
			[Cpp2IlInjected.Address(RVA = "0xA4FAF00", Offset = "0xA4FA300", VA = "0x18A4FAF00", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA5")]
			[Cpp2IlInjected.Address(RVA = "0xA4FAFB0", Offset = "0xA4FA3B0", VA = "0x18A4FAFB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0xA4FAE60", Offset = "0xA4FA260", VA = "0x18A4FAE60")]
		public ScalarArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA0")]
		[Cpp2IlInjected.Address(RVA = "0xA4FADC0", Offset = "0xA4FA1C0", VA = "0x18A4FADC0")]
		public ScalarArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0xA4FAA90", Offset = "0xA4F9E90", VA = "0x18A4FAA90", Slot = "9")]
		public IEnumerator<float> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0xA4FAD10", Offset = "0xA4FA110", VA = "0x18A4FAD10", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0xA4FA850", Offset = "0xA4F9C50", VA = "0x18A4FA850", Slot = "20")]
		public bool Contains(float item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0xA4FAB40", Offset = "0xA4F9F40", VA = "0x18A4FAB40", Slot = "13")]
		public int IndexOf(float item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0xA4FA870", Offset = "0xA4F9C70", VA = "0x18A4FA870", Slot = "21")]
		public void CopyTo(float[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0xA4FA980", Offset = "0xA4F9D80", VA = "0x18A4FA980")]
		public void Fill(IEnumerable<float> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0xA4FAC90", Offset = "0xA4FA090", VA = "0x18A4FAC90", Slot = "14")]
		void IList<float>.Insert(int index, float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAD")]
		[Cpp2IlInjected.Address(RVA = "0xA4FACD0", Offset = "0xA4FA0D0", VA = "0x18A4FACD0", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0xA4FABD0", Offset = "0xA4F9FD0", VA = "0x18A4FABD0", Slot = "18")]
		void ICollection<float>.Add(float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAF")]
		[Cpp2IlInjected.Address(RVA = "0xA4FAC10", Offset = "0xA4FA010", VA = "0x18A4FAC10", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0xA4FAC50", Offset = "0xA4FA050", VA = "0x18A4FAC50", Slot = "22")]
		bool ICollection<float>.Remove(float item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[DebuggerDisplay("Vector2[{Count}]")]
	public readonly struct Vector2Array : IAccessorArray<Vector2>, IReadOnlyList<Vector2>, IEnumerable<Vector2>, IEnumerable, IReadOnlyCollection<Vector2>, IList<Vector2>, ICollection<Vector2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Vector2[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB3")]
			[Cpp2IlInjected.Address(RVA = "0xA4FF320", Offset = "0xA4FE720", VA = "0x18A4FF320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB4")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		bool ICollection<Vector2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB5")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public Vector2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB6")]
			[Cpp2IlInjected.Address(RVA = "0xA4FF290", Offset = "0xA4FE690", VA = "0x18A4FF290", Slot = "11")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB7")]
			[Cpp2IlInjected.Address(RVA = "0xA4FF3A0", Offset = "0xA4FE7A0", VA = "0x18A4FF3A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF1F0", Offset = "0xA4FE5F0", VA = "0x18A4FF1F0")]
		public Vector2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF150", Offset = "0xA4FE550", VA = "0x18A4FF150")]
		public Vector2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0xA4FEE20", Offset = "0xA4FE220", VA = "0x18A4FEE20", Slot = "9")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB9")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF0A0", Offset = "0xA4FE4A0", VA = "0x18A4FF0A0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBA")]
		[Cpp2IlInjected.Address(RVA = "0xA4FEBE0", Offset = "0xA4FDFE0", VA = "0x18A4FEBE0", Slot = "20")]
		public bool Contains(Vector2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBB")]
		[Cpp2IlInjected.Address(RVA = "0xA4FEED0", Offset = "0xA4FE2D0", VA = "0x18A4FEED0", Slot = "13")]
		public int IndexOf(Vector2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBC")]
		[Cpp2IlInjected.Address(RVA = "0xA4FEC00", Offset = "0xA4FE000", VA = "0x18A4FEC00", Slot = "21")]
		public void CopyTo(Vector2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBD")]
		[Cpp2IlInjected.Address(RVA = "0xA4FED10", Offset = "0xA4FE110", VA = "0x18A4FED10")]
		public void Fill(IEnumerable<Vector2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBE")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF020", Offset = "0xA4FE420", VA = "0x18A4FF020", Slot = "14")]
		void IList<Vector2>.Insert(int index, Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBF")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF060", Offset = "0xA4FE460", VA = "0x18A4FF060", Slot = "15")]
		void IList<Vector2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC0")]
		[Cpp2IlInjected.Address(RVA = "0xA4FEF60", Offset = "0xA4FE360", VA = "0x18A4FEF60", Slot = "18")]
		void ICollection<Vector2>.Add(Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC1")]
		[Cpp2IlInjected.Address(RVA = "0xA4FEFA0", Offset = "0xA4FE3A0", VA = "0x18A4FEFA0", Slot = "19")]
		void ICollection<Vector2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC2")]
		[Cpp2IlInjected.Address(RVA = "0xA4FEFE0", Offset = "0xA4FE3E0", VA = "0x18A4FEFE0", Slot = "22")]
		bool ICollection<Vector2>.Remove(Vector2 item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[DebuggerDisplay("Vector3[{Count}]")]
	public readonly struct Vector3Array : IAccessorArray<Vector3>, IReadOnlyList<Vector3>, IEnumerable<Vector3>, IEnumerable, IReadOnlyCollection<Vector3>, IList<Vector3>, ICollection<Vector3>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Vector3[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC5")]
			[Cpp2IlInjected.Address(RVA = "0xA4FFC10", Offset = "0xA4FF010", VA = "0x18A4FFC10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC6")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		bool ICollection<Vector3>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC7")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public Vector3 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0xA4FFB40", Offset = "0xA4FEF40", VA = "0x18A4FFB40", Slot = "11")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC9")]
			[Cpp2IlInjected.Address(RVA = "0xA4FFC90", Offset = "0xA4FF090", VA = "0x18A4FFC90", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC3")]
		[Cpp2IlInjected.Address(RVA = "0xA4FFA00", Offset = "0xA4FEE00", VA = "0x18A4FFA00")]
		public Vector3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC4")]
		[Cpp2IlInjected.Address(RVA = "0xA4FFAA0", Offset = "0xA4FEEA0", VA = "0x18A4FFAA0")]
		public Vector3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCA")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF6C0", Offset = "0xA4FEAC0", VA = "0x18A4FF6C0", Slot = "9")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF950", Offset = "0xA4FED50", VA = "0x18A4FF950", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF400", Offset = "0xA4FE800", VA = "0x18A4FF400", Slot = "20")]
		public bool Contains(Vector3 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF770", Offset = "0xA4FEB70", VA = "0x18A4FF770", Slot = "13")]
		public int IndexOf(Vector3 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF4A0", Offset = "0xA4FE8A0", VA = "0x18A4FF4A0", Slot = "21")]
		public void CopyTo(Vector3[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCF")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF5B0", Offset = "0xA4FE9B0", VA = "0x18A4FF5B0")]
		public void Fill(IEnumerable<Vector3> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD0")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF8D0", Offset = "0xA4FECD0", VA = "0x18A4FF8D0", Slot = "14")]
		void IList<Vector3>.Insert(int index, Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF910", Offset = "0xA4FED10", VA = "0x18A4FF910", Slot = "15")]
		void IList<Vector3>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF810", Offset = "0xA4FEC10", VA = "0x18A4FF810", Slot = "18")]
		void ICollection<Vector3>.Add(Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF850", Offset = "0xA4FEC50", VA = "0x18A4FF850", Slot = "19")]
		void ICollection<Vector3>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0xA4FF890", Offset = "0xA4FEC90", VA = "0x18A4FF890", Slot = "22")]
		bool ICollection<Vector3>.Remove(Vector3 item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[DebuggerDisplay("Vector4[{Count}]")]
	public readonly struct Vector4Array : IAccessorArray<Vector4>, IReadOnlyList<Vector4>, IEnumerable<Vector4>, IEnumerable, IReadOnlyCollection<Vector4>, IList<Vector4>, ICollection<Vector4>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Vector4[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD7")]
			[Cpp2IlInjected.Address(RVA = "0xA5002F0", Offset = "0xA4FF6F0", VA = "0x18A5002F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD8")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD9")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDA")]
			[Cpp2IlInjected.Address(RVA = "0xA4F7A90", Offset = "0xA4F6E90", VA = "0x18A4F7A90", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDB")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED360", Offset = "0xA4EC760", VA = "0x18A4ED360", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED070", Offset = "0xA4EC470", VA = "0x18A4ED070")]
		public Vector4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED110", Offset = "0xA4EC510", VA = "0x18A4ED110")]
		public Vector4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDC")]
		[Cpp2IlInjected.Address(RVA = "0xA4FFFC0", Offset = "0xA4FF3C0", VA = "0x18A4FFFC0", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDD")]
		[Cpp2IlInjected.Address(RVA = "0xA500240", Offset = "0xA4FF640", VA = "0x18A500240", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDE")]
		[Cpp2IlInjected.Address(RVA = "0xA4FFD10", Offset = "0xA4FF110", VA = "0x18A4FFD10", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDF")]
		[Cpp2IlInjected.Address(RVA = "0xA500070", Offset = "0xA4FF470", VA = "0x18A500070", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE0")]
		[Cpp2IlInjected.Address(RVA = "0xA4FFDA0", Offset = "0xA4FF1A0", VA = "0x18A4FFDA0", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE1")]
		[Cpp2IlInjected.Address(RVA = "0xA4FFEB0", Offset = "0xA4FF2B0", VA = "0x18A4FFEB0")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE2")]
		[Cpp2IlInjected.Address(RVA = "0xA5001C0", Offset = "0xA4FF5C0", VA = "0x18A5001C0", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE3")]
		[Cpp2IlInjected.Address(RVA = "0xA500200", Offset = "0xA4FF600", VA = "0x18A500200", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE4")]
		[Cpp2IlInjected.Address(RVA = "0xA500100", Offset = "0xA4FF500", VA = "0x18A500100", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE5")]
		[Cpp2IlInjected.Address(RVA = "0xA500140", Offset = "0xA4FF540", VA = "0x18A500140", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0xA500180", Offset = "0xA4FF580", VA = "0x18A500180", Slot = "22")]
		bool ICollection<Vector4>.Remove(Vector4 item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[DebuggerDisplay("Quaternion[{Count}]")]
	public readonly struct QuaternionArray : IAccessorArray<Quaternion>, IReadOnlyList<Quaternion>, IEnumerable<Quaternion>, IEnumerable, IReadOnlyCollection<Quaternion>, IList<Quaternion>, ICollection<Quaternion>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Quaternion[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000CE9")]
			[Cpp2IlInjected.Address(RVA = "0xA4F7BB0", Offset = "0xA4F6FB0", VA = "0x18A4F7BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEA")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		bool ICollection<Quaternion>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEB")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public Quaternion this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEC")]
			[Cpp2IlInjected.Address(RVA = "0xA4F7A90", Offset = "0xA4F6E90", VA = "0x18A4F7A90", Slot = "11")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CED")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED360", Offset = "0xA4EC760", VA = "0x18A4ED360", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED070", Offset = "0xA4EC470", VA = "0x18A4ED070")]
		public QuaternionArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED110", Offset = "0xA4EC510", VA = "0x18A4ED110")]
		public QuaternionArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7760", Offset = "0xA4F6B60", VA = "0x18A4F7760", Slot = "9")]
		public IEnumerator<Quaternion> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0xA4F79E0", Offset = "0xA4F6DE0", VA = "0x18A4F79E0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0xA4F74B0", Offset = "0xA4F68B0", VA = "0x18A4F74B0", Slot = "20")]
		public bool Contains(Quaternion item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7810", Offset = "0xA4F6C10", VA = "0x18A4F7810", Slot = "13")]
		public int IndexOf(Quaternion item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7540", Offset = "0xA4F6940", VA = "0x18A4F7540", Slot = "21")]
		public void CopyTo(Quaternion[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7650", Offset = "0xA4F6A50", VA = "0x18A4F7650")]
		public void Fill(IEnumerable<Quaternion> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7960", Offset = "0xA4F6D60", VA = "0x18A4F7960", Slot = "14")]
		void IList<Quaternion>.Insert(int index, Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0xA4F79A0", Offset = "0xA4F6DA0", VA = "0x18A4F79A0", Slot = "15")]
		void IList<Quaternion>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF6")]
		[Cpp2IlInjected.Address(RVA = "0xA4F78A0", Offset = "0xA4F6CA0", VA = "0x18A4F78A0", Slot = "18")]
		void ICollection<Quaternion>.Add(Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF7")]
		[Cpp2IlInjected.Address(RVA = "0xA4F78E0", Offset = "0xA4F6CE0", VA = "0x18A4F78E0", Slot = "19")]
		void ICollection<Quaternion>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF8")]
		[Cpp2IlInjected.Address(RVA = "0xA4F7920", Offset = "0xA4F6D20", VA = "0x18A4F7920", Slot = "22")]
		bool ICollection<Quaternion>.Remove(Quaternion item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[DebuggerDisplay("Matrix2x2[{Count}]")]
	public readonly struct Matrix2x2Array : IAccessorArray<Matrix3x2>, IReadOnlyList<Matrix3x2>, IEnumerable<Matrix3x2>, IEnumerable, IReadOnlyCollection<Matrix3x2>, IList<Matrix3x2>, ICollection<Matrix3x2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Matrix3x2[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFB")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED2E0", Offset = "0xA4EC6E0", VA = "0x18A4ED2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFC")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFD")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFE")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED1B0", Offset = "0xA4EC5B0", VA = "0x18A4ED1B0", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFF")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED360", Offset = "0xA4EC760", VA = "0x18A4ED360", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF9")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED070", Offset = "0xA4EC470", VA = "0x18A4ED070")]
		public Matrix2x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFA")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED110", Offset = "0xA4EC510", VA = "0x18A4ED110")]
		public Matrix2x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D00")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECD30", Offset = "0xA4EC130", VA = "0x18A4ECD30", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D01")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECFC0", Offset = "0xA4EC3C0", VA = "0x18A4ECFC0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D02")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECA70", Offset = "0xA4EBE70", VA = "0x18A4ECA70", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D03")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECDE0", Offset = "0xA4EC1E0", VA = "0x18A4ECDE0", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D04")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECB10", Offset = "0xA4EBF10", VA = "0x18A4ECB10", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D05")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECC20", Offset = "0xA4EC020", VA = "0x18A4ECC20")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECF40", Offset = "0xA4EC340", VA = "0x18A4ECF40", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D07")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECF80", Offset = "0xA4EC380", VA = "0x18A4ECF80", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D08")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECE80", Offset = "0xA4EC280", VA = "0x18A4ECE80", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D09")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECEC0", Offset = "0xA4EC2C0", VA = "0x18A4ECEC0", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0A")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECF00", Offset = "0xA4EC300", VA = "0x18A4ECF00", Slot = "22")]
		bool ICollection<Matrix3x2>.Remove(Matrix3x2 item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[DebuggerDisplay("Matrix3x2[{Count}]")]
	public readonly struct Matrix3x2Array : IAccessorArray<Matrix3x2>, IReadOnlyList<Matrix3x2>, IEnumerable<Matrix3x2>, IEnumerable, IReadOnlyCollection<Matrix3x2>, IList<Matrix3x2>, ICollection<Matrix3x2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Matrix3x2[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0D")]
			[Cpp2IlInjected.Address(RVA = "0xA4EDCE0", Offset = "0xA4ED0E0", VA = "0x18A4EDCE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0E")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0F")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D10")]
			[Cpp2IlInjected.Address(RVA = "0xA4EDB40", Offset = "0xA4ECF40", VA = "0x18A4EDB40", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D11")]
			[Cpp2IlInjected.Address(RVA = "0xA4EDD60", Offset = "0xA4ED160", VA = "0x18A4EDD60", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0B")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDA00", Offset = "0xA4ECE00", VA = "0x18A4EDA00")]
		public Matrix3x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0C")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDAA0", Offset = "0xA4ECEA0", VA = "0x18A4EDAA0")]
		public Matrix3x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D12")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED6C0", Offset = "0xA4ECAC0", VA = "0x18A4ED6C0", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D13")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED950", Offset = "0xA4ECD50", VA = "0x18A4ED950", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D14")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED400", Offset = "0xA4EC800", VA = "0x18A4ED400", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D15")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED770", Offset = "0xA4ECB70", VA = "0x18A4ED770", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D16")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED4A0", Offset = "0xA4EC8A0", VA = "0x18A4ED4A0", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D17")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED5B0", Offset = "0xA4EC9B0", VA = "0x18A4ED5B0")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D18")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED8D0", Offset = "0xA4ECCD0", VA = "0x18A4ED8D0", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D19")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED910", Offset = "0xA4ECD10", VA = "0x18A4ED910", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1A")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED810", Offset = "0xA4ECC10", VA = "0x18A4ED810", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1B")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED850", Offset = "0xA4ECC50", VA = "0x18A4ED850", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1C")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED890", Offset = "0xA4ECC90", VA = "0x18A4ED890", Slot = "22")]
		bool ICollection<Matrix3x2>.Remove(Matrix3x2 item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[DebuggerDisplay("Matrix3x3[{Count}]")]
	public readonly struct Matrix3x3Array : IAccessorArray<Matrix4x4>, IReadOnlyList<Matrix4x4>, IEnumerable<Matrix4x4>, IEnumerable, IReadOnlyCollection<Matrix4x4>, IList<Matrix4x4>, ICollection<Matrix4x4>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Matrix4x4[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D1F")]
			[Cpp2IlInjected.Address(RVA = "0xA4EE7E0", Offset = "0xA4EDBE0", VA = "0x18A4EE7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D20")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D21")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D22")]
			[Cpp2IlInjected.Address(RVA = "0xA4EE530", Offset = "0xA4ED930", VA = "0x18A4EE530", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D23")]
			[Cpp2IlInjected.Address(RVA = "0xA4EE860", Offset = "0xA4EDC60", VA = "0x18A4EE860", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1D")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE3F0", Offset = "0xA4ED7F0", VA = "0x18A4EE3F0")]
		public Matrix3x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1E")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE490", Offset = "0xA4ED890", VA = "0x18A4EE490")]
		public Matrix3x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D24")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE090", Offset = "0xA4ED490", VA = "0x18A4EE090", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D25")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE340", Offset = "0xA4ED740", VA = "0x18A4EE340", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D26")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDE30", Offset = "0xA4ED230", VA = "0x18A4EDE30", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D27")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE140", Offset = "0xA4ED540", VA = "0x18A4EE140", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDE70", Offset = "0xA4ED270", VA = "0x18A4EDE70", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDF80", Offset = "0xA4ED380", VA = "0x18A4EDF80")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE2C0", Offset = "0xA4ED6C0", VA = "0x18A4EE2C0", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2B")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE300", Offset = "0xA4ED700", VA = "0x18A4EE300", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2C")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE200", Offset = "0xA4ED600", VA = "0x18A4EE200", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2D")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE240", Offset = "0xA4ED640", VA = "0x18A4EE240", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2E")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE280", Offset = "0xA4ED680", VA = "0x18A4EE280", Slot = "22")]
		bool ICollection<Matrix4x4>.Remove(Matrix4x4 item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[DebuggerDisplay("Matrix4x3[{Count}]")]
	public readonly struct Matrix4x3Array : IAccessorArray<Matrix4x4>, IReadOnlyList<Matrix4x4>, IEnumerable<Matrix4x4>, IEnumerable, IReadOnlyCollection<Matrix4x4>, IList<Matrix4x4>, ICollection<Matrix4x4>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Matrix4x4[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D31")]
			[Cpp2IlInjected.Address(RVA = "0xA4EF3E0", Offset = "0xA4EE7E0", VA = "0x18A4EF3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D32")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D33")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D34")]
			[Cpp2IlInjected.Address(RVA = "0xA4EF080", Offset = "0xA4EE480", VA = "0x18A4EF080", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D35")]
			[Cpp2IlInjected.Address(RVA = "0xA4EF460", Offset = "0xA4EE860", VA = "0x18A4EF460", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2F")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEFE0", Offset = "0xA4EE3E0", VA = "0x18A4EEFE0")]
		public Matrix4x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D30")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEF40", Offset = "0xA4EE340", VA = "0x18A4EEF40")]
		public Matrix4x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D36")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEBE0", Offset = "0xA4EDFE0", VA = "0x18A4EEBE0", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D37")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEE90", Offset = "0xA4EE290", VA = "0x18A4EEE90", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D38")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE980", Offset = "0xA4EDD80", VA = "0x18A4EE980", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D39")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEC90", Offset = "0xA4EE090", VA = "0x18A4EEC90", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3A")]
		[Cpp2IlInjected.Address(RVA = "0xA4EE9C0", Offset = "0xA4EDDC0", VA = "0x18A4EE9C0", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3B")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEAD0", Offset = "0xA4EDED0", VA = "0x18A4EEAD0")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3C")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEE10", Offset = "0xA4EE210", VA = "0x18A4EEE10", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3D")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEE50", Offset = "0xA4EE250", VA = "0x18A4EEE50", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3E")]
		[Cpp2IlInjected.Address(RVA = "0xA4EED50", Offset = "0xA4EE150", VA = "0x18A4EED50", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3F")]
		[Cpp2IlInjected.Address(RVA = "0xA4EED90", Offset = "0xA4EE190", VA = "0x18A4EED90", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D40")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEDD0", Offset = "0xA4EE1D0", VA = "0x18A4EEDD0", Slot = "22")]
		bool ICollection<Matrix4x4>.Remove(Matrix4x4 item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[DebuggerDisplay("Matrix4x4[{Count}]")]
	public readonly struct Matrix4x4Array : IAccessorArray<Matrix4x4>, IReadOnlyList<Matrix4x4>, IEnumerable<Matrix4x4>, IEnumerable, IReadOnlyCollection<Matrix4x4>, IList<Matrix4x4>, ICollection<Matrix4x4>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Matrix4x4[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D43")]
			[Cpp2IlInjected.Address(RVA = "0xA4F0100", Offset = "0xA4EF500", VA = "0x18A4F0100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D44")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D45")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D46")]
			[Cpp2IlInjected.Address(RVA = "0xA4EFCD0", Offset = "0xA4EF0D0", VA = "0x18A4EFCD0", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D47")]
			[Cpp2IlInjected.Address(RVA = "0xA4F0180", Offset = "0xA4EF580", VA = "0x18A4F0180", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D41")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFC30", Offset = "0xA4EF030", VA = "0x18A4EFC30")]
		public Matrix4x4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D42")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFB90", Offset = "0xA4EEF90", VA = "0x18A4EFB90")]
		public Matrix4x4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF830", Offset = "0xA4EEC30", VA = "0x18A4EF830", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFAE0", Offset = "0xA4EEEE0", VA = "0x18A4EFAE0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4A")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF5D0", Offset = "0xA4EE9D0", VA = "0x18A4EF5D0", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4B")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF8E0", Offset = "0xA4EECE0", VA = "0x18A4EF8E0", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4C")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF610", Offset = "0xA4EEA10", VA = "0x18A4EF610", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4D")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF720", Offset = "0xA4EEB20", VA = "0x18A4EF720")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4E")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFA60", Offset = "0xA4EEE60", VA = "0x18A4EFA60", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4F")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFAA0", Offset = "0xA4EEEA0", VA = "0x18A4EFAA0", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D50")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF9A0", Offset = "0xA4EEDA0", VA = "0x18A4EF9A0", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D51")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF9E0", Offset = "0xA4EEDE0", VA = "0x18A4EF9E0", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D52")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFA20", Offset = "0xA4EEE20", VA = "0x18A4EFA20", Slot = "22")]
		bool ICollection<Matrix4x4>.Remove(Matrix4x4 item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[DebuggerDisplay("Float[][{Count}]")]
	public readonly struct MultiArray : IAccessorArray<float[]>, IReadOnlyList<float[]>, IEnumerable<float[]>, IEnumerable, IReadOnlyCollection<float[]>, IList<float[]>, ICollection<float[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _Dimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly FloatingAccessor _Accessor;

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private float[][] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D54")]
			[Cpp2IlInjected.Address(RVA = "0xA4F6520", Offset = "0xA4F5920", VA = "0x18A4F6520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D55")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Dimensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000D56")]
			[Cpp2IlInjected.Address(RVA = "0xF6C9A0", Offset = "0xF6BDA0", VA = "0x180F6C9A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D57")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public float[] this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D58")]
			[Cpp2IlInjected.Address(RVA = "0xA4F64B0", Offset = "0xA4F58B0", VA = "0x18A4F64B0", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D59")]
			[Cpp2IlInjected.Address(RVA = "0xA4F65A0", Offset = "0xA4F59A0", VA = "0x18A4F65A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D53")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6410", Offset = "0xA4F5810", VA = "0x18A4F6410")]
		public MultiArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5A")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5D50", Offset = "0xA4F5150", VA = "0x18A4F5D50")]
		public void CopyItemTo(int index, float[] dstItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5B")]
		[Cpp2IlInjected.Address(RVA = "0xA4F60C0", Offset = "0xA4F54C0", VA = "0x18A4F60C0", Slot = "9")]
		public IEnumerator<float[]> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5C")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6350", Offset = "0xA4F5750", VA = "0x18A4F6350", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5D")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5D30", Offset = "0xA4F5130", VA = "0x18A4F5D30", Slot = "20")]
		public bool Contains(float[] item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5E")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6180", Offset = "0xA4F5580", VA = "0x18A4F6180", Slot = "13")]
		public int IndexOf(float[] item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5F")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5E80", Offset = "0xA4F5280", VA = "0x18A4F5E80", Slot = "21")]
		public void CopyTo(float[][] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D60")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5FA0", Offset = "0xA4F53A0", VA = "0x18A4F5FA0")]
		public void Fill(IEnumerable<float[]> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D61")]
		[Cpp2IlInjected.Address(RVA = "0xA4F62D0", Offset = "0xA4F56D0", VA = "0x18A4F62D0", Slot = "14")]
		void IList<float>.Insert(int index, float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6310", Offset = "0xA4F5710", VA = "0x18A4F6310", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6210", Offset = "0xA4F5610", VA = "0x18A4F6210", Slot = "18")]
		void ICollection<float>.Add(float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6250", Offset = "0xA4F5650", VA = "0x18A4F6250", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D65")]
		[Cpp2IlInjected.Address(RVA = "0xA4F6290", Offset = "0xA4F5690", VA = "0x18A4F6290", Slot = "22")]
		bool ICollection<float>.Remove(float[] item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	public interface IAccessorArray<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IList<T>, ICollection<T>
	{
		[Cpp2IlInjected.Token(Token = "0x17000219")]
		new T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D66")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000D67")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		new int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D68")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	public readonly struct ZeroAccessorArray<T> : IAccessorArray<T>, IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IList<T>, ICollection<T>
	{
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private static readonly T _Default;

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6B")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6C")]
			[Cpp2IlInjected.Address(RVA = "0x5135280", Offset = "0x5134680", VA = "0x185135280", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D6D")]
			[Cpp2IlInjected.Address(RVA = "0x5133F20", Offset = "0x5133320", VA = "0x185133F20", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6E")]
			[Cpp2IlInjected.Address(RVA = "0xF6C9A0", Offset = "0xF6BDA0", VA = "0x180F6C9A0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x5134EE0", Offset = "0x51342E0", VA = "0x185134EE0")]
		static ZeroAccessorArray()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6A")]
		[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
		public ZeroAccessorArray(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6F")]
		[Cpp2IlInjected.Address(RVA = "0x5133340", Offset = "0x5132740", VA = "0x185133340", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D70")]
		[Cpp2IlInjected.Address(RVA = "0x5131150", Offset = "0x5130550", VA = "0x185131150", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D71")]
		[Cpp2IlInjected.Address(RVA = "0x5132470", Offset = "0x5131870", VA = "0x185132470", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D72")]
		[Cpp2IlInjected.Address(RVA = "0x5132D90", Offset = "0x5132190", VA = "0x185132D90", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D73")]
		[Cpp2IlInjected.Address(RVA = "0x5132D90", Offset = "0x5132190", VA = "0x185132D90", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D74")]
		[Cpp2IlInjected.Address(RVA = "0x5133F20", Offset = "0x5133320", VA = "0x185133F20", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D75")]
		[Cpp2IlInjected.Address(RVA = "0x4F98C30", Offset = "0x4F98030", VA = "0x184F98C30", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D76")]
		[Cpp2IlInjected.Address(RVA = "0x4F98C30", Offset = "0x4F98030", VA = "0x184F98C30", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D77")]
		[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D78")]
		[Cpp2IlInjected.Address(RVA = "0x4F98C30", Offset = "0x4F98030", VA = "0x184F98C30", Slot = "22")]
		bool ICollection<T>.Remove(T item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	internal readonly struct BooleanArrayOverIntegerArray : IAccessorArray<bool>, IReadOnlyList<bool>, IEnumerable<bool>, IEnumerable, IReadOnlyCollection<bool>, IList<bool>, ICollection<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__12 : IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			private bool <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005F8")]
			public BooleanArrayOverIntegerArray <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F9")]
			private int <c>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40005FA")]
			private int <i>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000221")]
			bool IEnumerator<bool>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000D8B")]
				[Cpp2IlInjected.Address(RVA = "0x135B8F0", Offset = "0x135ACF0", VA = "0x18135B8F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000222")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000D8D")]
				[Cpp2IlInjected.Address(RVA = "0x8B65410", Offset = "0x8B64810", VA = "0x188B65410", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D88")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D89")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8A")]
			[Cpp2IlInjected.Address(RVA = "0xA4FB690", Offset = "0xA4FAA90", VA = "0x18A4FB690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8C")]
			[Cpp2IlInjected.Address(RVA = "0xA4FB730", Offset = "0xA4FAB30", VA = "0x18A4FB730", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000168")]
		[CompilerGenerated]
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005FB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005FC")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005FD")]
			public BooleanArrayOverIntegerArray <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005FE")]
			private int <c>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005FF")]
			private int <i>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000223")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000D91")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000224")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000D93")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8E")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8F")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D90")]
			[Cpp2IlInjected.Address(RVA = "0xA4FD550", Offset = "0xA4FC950", VA = "0x18A4FD550", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D92")]
			[Cpp2IlInjected.Address(RVA = "0xA4FD620", Offset = "0xA4FCA20", VA = "0x18A4FD620", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private readonly IAccessorArray<uint> _Source;

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public bool this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4E40", Offset = "0xA4E4240", VA = "0x18A4E4E40", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D7B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4F00", Offset = "0xA4E4300", VA = "0x18A4E4F00", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7C")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4DF0", Offset = "0xA4E41F0", VA = "0x18A4E4DF0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D79")]
		[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
		public BooleanArrayOverIntegerArray(IAccessorArray<uint> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4A40", Offset = "0xA4E3E40", VA = "0x18A4E4A40", Slot = "20")]
		public bool Contains(bool item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4B80", Offset = "0xA4E3F80", VA = "0x18A4E4B80", Slot = "13")]
		public int IndexOf(bool item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D80")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4A60", Offset = "0xA4E3E60", VA = "0x18A4E4A60", Slot = "21")]
		public void CopyTo(bool[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D81")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4B10", Offset = "0xA4E3F10", VA = "0x18A4E4B10", Slot = "9")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__12))]
		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D82")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4D80", Offset = "0xA4E4180", VA = "0x18A4E4D80", Slot = "10")]
		[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__13))]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D83")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4D00", Offset = "0xA4E4100", VA = "0x18A4E4D00", Slot = "14")]
		void IList<bool>.Insert(int index, bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D84")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4D40", Offset = "0xA4E4140", VA = "0x18A4E4D40", Slot = "15")]
		void IList<bool>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D85")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C40", Offset = "0xA4E4040", VA = "0x18A4E4C40", Slot = "18")]
		void ICollection<bool>.Add(bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D86")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C80", Offset = "0xA4E4080", VA = "0x18A4E4C80", Slot = "19")]
		void ICollection<bool>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D87")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4CC0", Offset = "0xA4E40C0", VA = "0x18A4E4CC0", Slot = "22")]
		bool ICollection<bool>.Remove(bool item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[DebuggerDisplay("Integer[{Count}]")]
	public readonly struct IntegerArray : IAccessorArray<uint>, IReadOnlyList<uint>, IEnumerable<uint>, IEnumerable, IReadOnlyCollection<uint>, IList<uint>, ICollection<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		private delegate uint _GetterCallback(int index);

		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private delegate void _SetterCallback(int index, uint value);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Memory<byte> _Data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _ByteStride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly _GetterCallback _Getter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly _SetterCallback _Setter;

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private uint[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9C")]
			[Cpp2IlInjected.Address(RVA = "0xA4EB6C0", Offset = "0xA4EAAC0", VA = "0x18A4EB6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9D")]
			[Cpp2IlInjected.Address(RVA = "0xA4EB680", Offset = "0xA4EAA80", VA = "0x18A4EB680", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		bool ICollection<uint>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9E")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public uint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B10E70", Offset = "0x2B10270", VA = "0x182B10E70", Slot = "11")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DA0")]
			[Cpp2IlInjected.Address(RVA = "0x864EBA0", Offset = "0x864DFA0", VA = "0x18864EBA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D94")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB640", Offset = "0xA4EAA40", VA = "0x18A4EB640")]
		public IntegerArray(Memory<byte> source, IndexEncodingType encoding = IndexEncodingType.UNSIGNED_INT)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D95")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB170", Offset = "0xA4EA570", VA = "0x18A4EB170")]
		public IntegerArray(Memory<byte> source, int byteOffset, int itemsCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D96")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB060", Offset = "0xA4EA460", VA = "0x18A4EB060")]
		private uint _GetValueU8(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D97")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB110", Offset = "0xA4EA510", VA = "0x18A4EB110")]
		private void _SetValueU8(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D98")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB010", Offset = "0xA4EA410", VA = "0x18A4EB010")]
		private uint _GetValueU16(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D99")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB0B0", Offset = "0xA4EA4B0", VA = "0x18A4EB0B0")]
		private void _SetValueU16(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9A")]
		[Cpp2IlInjected.Address(RVA = "0x3B3EEA0", Offset = "0x3B3E2A0", VA = "0x183B3EEA0")]
		private T _GetValue<T>(int index) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9B")]
		[Cpp2IlInjected.Address(RVA = "0x3B3F170", Offset = "0x3B3E570", VA = "0x183B3F170")]
		private void _SetValue<T>(int index, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA1")]
		[Cpp2IlInjected.Address(RVA = "0xA4EACF0", Offset = "0xA4EA0F0", VA = "0x18A4EACF0", Slot = "9")]
		public IEnumerator<uint> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA2")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAF60", Offset = "0xA4EA360", VA = "0x18A4EAF60", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA3")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA980", Offset = "0xA4E9D80", VA = "0x18A4EA980", Slot = "20")]
		public bool Contains(uint item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA4")]
		[Cpp2IlInjected.Address(RVA = "0xA4EADA0", Offset = "0xA4EA1A0", VA = "0x18A4EADA0", Slot = "13")]
		public int IndexOf(uint item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA5")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA9A0", Offset = "0xA4E9DA0", VA = "0x18A4EA9A0", Slot = "21")]
		public void CopyTo(uint[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA6")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAAC0", Offset = "0xA4E9EC0", VA = "0x18A4EAAC0")]
		public void Fill(IEnumerable<int> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA7")]
		[Cpp2IlInjected.Address(RVA = "0xA4EABD0", Offset = "0xA4E9FD0", VA = "0x18A4EABD0")]
		public void Fill(IEnumerable<uint> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA8")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAEE0", Offset = "0xA4EA2E0", VA = "0x18A4EAEE0", Slot = "14")]
		void IList<uint>.Insert(int index, uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA9")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAF20", Offset = "0xA4EA320", VA = "0x18A4EAF20", Slot = "15")]
		void IList<uint>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAA")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAE20", Offset = "0xA4EA220", VA = "0x18A4EAE20", Slot = "18")]
		void ICollection<uint>.Add(uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAB")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAE60", Offset = "0xA4EA260", VA = "0x18A4EAE60", Slot = "19")]
		void ICollection<uint>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAC")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAEA0", Offset = "0xA4EA2A0", VA = "0x18A4EAEA0", Slot = "22")]
		bool ICollection<uint>.Remove(uint item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public sealed class MemoryAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000172")]
		[CompilerGenerated]
		private sealed class <GetItemsAsRawBytes>d__26 : IEnumerable<ArraySegment<byte>>, IEnumerable, IEnumerator<ArraySegment<byte>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			private ArraySegment<byte> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			public MemoryAccessor <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			private int <itemSize>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			private int <rowStride>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400061A")]
			private int <rowOffset>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			private int <i>5__5;

			[Cpp2IlInjected.Token(Token = "0x1700022B")]
			ArraySegment<byte> IEnumerator<ArraySegment<byte>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000DF4")]
				[Cpp2IlInjected.Address(RVA = "0xD88E90", Offset = "0xD88290", VA = "0x180D88E90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ArraySegment<byte>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700022C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000DF6")]
				[Cpp2IlInjected.Address(RVA = "0xA5124A0", Offset = "0xA5118A0", VA = "0x18A5124A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF1")]
			[Cpp2IlInjected.Address(RVA = "0x1D1C970", Offset = "0x1D1BD70", VA = "0x181D1C970")]
			[DebuggerHidden]
			public <GetItemsAsRawBytes>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF2")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF3")]
			[Cpp2IlInjected.Address(RVA = "0xA512230", Offset = "0xA511630", VA = "0x18A512230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF5")]
			[Cpp2IlInjected.Address(RVA = "0xA512460", Offset = "0xA511860", VA = "0x18A512460", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF7")]
			[Cpp2IlInjected.Address(RVA = "0xA5123C0", Offset = "0xA5117C0", VA = "0x18A5123C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ArraySegment<byte>> IEnumerable<ArraySegment<byte>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF8")]
			[Cpp2IlInjected.Address(RVA = "0xA5123C0", Offset = "0xA5117C0", VA = "0x18A5123C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000229")]
		public MemoryAccessInfo Attribute
		{
			[Cpp2IlInjected.Token(Token = "0x6000DB9")]
			[Cpp2IlInjected.Address(RVA = "0xF3FB20", Offset = "0xF3EF20", VA = "0x180F3FB20")]
			[CompilerGenerated]
			get
			{
				return default(MemoryAccessInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBA")]
			[Cpp2IlInjected.Address(RVA = "0x4FBB290", Offset = "0x4FBA690", VA = "0x184FBB290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public ArraySegment<byte> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000DBB")]
			[Cpp2IlInjected.Address(RVA = "0x1678900", Offset = "0x1677D00", VA = "0x181678900")]
			[CompilerGenerated]
			get
			{
				return default(ArraySegment<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBC")]
			[Cpp2IlInjected.Address(RVA = "0xA4F5D10", Offset = "0xA4F5110", VA = "0x18A4F5D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB5")]
		[Cpp2IlInjected.Address(RVA = "0xA4F58A0", Offset = "0xA4F4CA0", VA = "0x18A4F58A0")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB6")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5B90", Offset = "0xA4F4F90", VA = "0x18A4F5B90")]
		public MemoryAccessor(byte[] data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB7")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5CA0", Offset = "0xA4F50A0", VA = "0x18A4F5CA0")]
		public MemoryAccessor(ArraySegment<byte> data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB8")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5C40", Offset = "0xA4F5040", VA = "0x18A4F5C40")]
		public MemoryAccessor(MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBD")]
		[Cpp2IlInjected.Address(RVA = "0xA4F3D70", Offset = "0xA4F3170", VA = "0x18A4F3D70")]
		public void Update(ArraySegment<byte> data, MemoryAccessInfo encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBE")]
		[Cpp2IlInjected.Address(RVA = "0x3CF0A30", Offset = "0x3CEFE30", VA = "0x183CF0A30")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBF")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0620", Offset = "0xA4EFA20", VA = "0x18A4F0620")]
		public IntegerArray AsIntegerArray()
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC0")]
		[Cpp2IlInjected.Address(RVA = "0xA4F1690", Offset = "0xA4F0A90", VA = "0x18A4F1690")]
		public ScalarArray AsScalarArray()
		{
			return default(ScalarArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC1")]
		[Cpp2IlInjected.Address(RVA = "0xA4F1900", Offset = "0xA4F0D00", VA = "0x18A4F1900")]
		public Vector2Array AsVector2Array()
		{
			return default(Vector2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC2")]
		[Cpp2IlInjected.Address(RVA = "0xA4F1B70", Offset = "0xA4F0F70", VA = "0x18A4F1B70")]
		public Vector3Array AsVector3Array()
		{
			return default(Vector3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC3")]
		[Cpp2IlInjected.Address(RVA = "0xA4F1DE0", Offset = "0xA4F11E0", VA = "0x18A4F1DE0")]
		public Vector4Array AsVector4Array()
		{
			return default(Vector4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC4")]
		[Cpp2IlInjected.Address(RVA = "0xA4F1420", Offset = "0xA4F0820", VA = "0x18A4F1420")]
		public QuaternionArray AsQuaternionArray()
		{
			return default(QuaternionArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC5")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0800", Offset = "0xA4EFC00", VA = "0x18A4F0800")]
		public Matrix2x2Array AsMatrix2x2Array()
		{
			return default(Matrix2x2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC6")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0A70", Offset = "0xA4EFE70", VA = "0x18A4F0A70")]
		public Matrix3x3Array AsMatrix3x3Array()
		{
			return default(Matrix3x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC7")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0CE0", Offset = "0xA4F00E0", VA = "0x18A4F0CE0")]
		public Matrix4x3Array AsMatrix4x3Array()
		{
			return default(Matrix4x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC8")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0F10", Offset = "0xA4F0310", VA = "0x18A4F0F10")]
		public Matrix4x4Array AsMatrix4x4Array()
		{
			return default(Matrix4x4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC9")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0350", Offset = "0xA4EF750", VA = "0x18A4F0350")]
		public ColorArray AsColorArray(float defaultW = 1f)
		{
			return default(ColorArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCA")]
		[Cpp2IlInjected.Address(RVA = "0xA4F1180", Offset = "0xA4F0580", VA = "0x18A4F1180")]
		public MultiArray AsMultiArray(int dimensions)
		{
			return default(MultiArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCB")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2C20", Offset = "0xA4F2020", VA = "0x18A4F2C20")]
		[IteratorStateMachine(typeof(<GetItemsAsRawBytes>d__26))]
		public IEnumerable<ArraySegment<byte>> GetItemsAsRawBytes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCC")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2050", Offset = "0xA4F1450", VA = "0x18A4F2050")]
		public (MemoryAccessor, MemoryAccessor) ConvertToSparse()
		{
			return default((MemoryAccessor, MemoryAccessor));
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCD")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2FA0", Offset = "0xA4F23A0", VA = "0x18A4F2FA0")]
		private bool RepresentsZeroValue(ArraySegment<byte> bytes)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCE")]
		[Cpp2IlInjected.Address(RVA = "0x3CF39D0", Offset = "0x3CF2DD0", VA = "0x183CF39D0")]
		public static IAccessorArray<T> CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCF")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3B90", Offset = "0x3CF2F90", VA = "0x183CF3B90")]
		public static IAccessorArray<T> CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD0")]
		[Cpp2IlInjected.Address(RVA = "0xA4F29E0", Offset = "0xA4F1DE0", VA = "0x18A4F29E0")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD1")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2B00", Offset = "0xA4F1F00", VA = "0x18A4F2B00")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD2")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5370", Offset = "0x3CF4770", VA = "0x183CF5370")]
		private static IAccessorArray<T> _CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD3")]
		[Cpp2IlInjected.Address(RVA = "0x3CF50B0", Offset = "0x3CF44B0", VA = "0x183CF50B0")]
		private static IAccessorArray<T> _CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD4")]
		[Cpp2IlInjected.Address(RVA = "0xA4F31E0", Offset = "0xA4F25E0", VA = "0x18A4F31E0")]
		public static void SanitizeVertexAttributes(MemoryAccessor[] vertexAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD5")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2D80", Offset = "0xA4F2180", VA = "0x18A4F2D80")]
		public static bool HaveOverlappingBuffers(MemoryAccessor a, MemoryAccessor b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD6")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5720", Offset = "0xA4F4B20", VA = "0x18A4F5720")]
		internal ArraySegment<byte> _GetBytes()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD7")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2CA0", Offset = "0xA4F20A0", VA = "0x18A4F2CA0")]
		public static bool HaveOverlappingBuffers(IEnumerable<MemoryAccessor> abc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD8")]
		[Cpp2IlInjected.Address(RVA = "0xA4F33B0", Offset = "0xA4F27B0", VA = "0x18A4F33B0")]
		public static void SanitizeWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD9")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5910", Offset = "0xA4F4D10", VA = "0x18A4F5910")]
		private static bool _SanitizeWeightSum(Span<byte> dst, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDA")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4B70", Offset = "0xA4F3F70", VA = "0x18A4F4B70")]
		public static void VerifyWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDB")]
		[Cpp2IlInjected.Address(RVA = "0xA4F54E0", Offset = "0xA4F48E0", VA = "0x18A4F54E0")]
		private static bool _CheckWeightSum(ReadOnlySpan<byte> src, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDC")]
		[Cpp2IlInjected.Address(RVA = "0xA4F3DD0", Offset = "0xA4F31D0", VA = "0x18A4F3DD0")]
		public static void VerifyAccessorBounds(MemoryAccessor memory, IReadOnlyList<double> min, IReadOnlyList<double> max)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDD")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4840", Offset = "0xA4F3C40", VA = "0x18A4F4840")]
		public static void VerifyVertexIndices(MemoryAccessor memory, uint vertexCount)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct MemoryAccessInfo
	{
		[Cpp2IlInjected.Token(Token = "0x2000174")]
		private class AttributeComparer : IComparer<string>
		{
			[Cpp2IlInjected.Token(Token = "0x6000E0D")]
			[Cpp2IlInjected.Address(RVA = "0xA505020", Offset = "0xA504420", VA = "0x18A505020", Slot = "4")]
			public int Compare(string x, string y)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0E")]
			[Cpp2IlInjected.Address(RVA = "0xA505060", Offset = "0xA504460", VA = "0x18A505060")]
			private static int _GetSortingScore(string attribute)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0F")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public AttributeComparer()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int ByteOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public int ItemsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public int ByteStride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public AttributeFormat Format;

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		public readonly DimensionType Dimensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000E00")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B50", Offset = "0xCF6F50", VA = "0x180CF7B50")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public readonly EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000E01")]
			[Cpp2IlInjected.Address(RVA = "0xDE68B0", Offset = "0xDE5CB0", VA = "0x180DE68B0")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public readonly bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x6000E02")]
			[Cpp2IlInjected.Address(RVA = "0xE8DE30", Offset = "0xE8D230", VA = "0x180E8DE30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public readonly int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E03")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public readonly int PaddedByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E04")]
			[Cpp2IlInjected.Address(RVA = "0xA50E1D0", Offset = "0xA50D5D0", VA = "0x18A50E1D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public readonly int StepByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E05")]
			[Cpp2IlInjected.Address(RVA = "0xA50E220", Offset = "0xA50D620", VA = "0x18A50E220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public readonly bool IsValidVertexAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x6000E06")]
			[Cpp2IlInjected.Address(RVA = "0xA50E0D0", Offset = "0xA50D4D0", VA = "0x18A50E0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public readonly bool IsValidIndexer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E07")]
			[Cpp2IlInjected.Address(RVA = "0xA50E030", Offset = "0xA50D430", VA = "0x18A50E030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		internal static IComparer<string> NameComparer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E0A")]
			[Cpp2IlInjected.Address(RVA = "0xA50E180", Offset = "0xA50D580", VA = "0x18A50E180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E0B")]
			[Cpp2IlInjected.Address(RVA = "0xA50E280", Offset = "0xA50D680", VA = "0x18A50E280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF9")]
		[Cpp2IlInjected.Address(RVA = "0xA50DCC0", Offset = "0xA50D0C0", VA = "0x18A50DCC0")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFA")]
		[Cpp2IlInjected.Address(RVA = "0xA50D5F0", Offset = "0xA50C9F0", VA = "0x18A50D5F0")]
		public static MemoryAccessInfo[] Create(params string[] attributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFB")]
		[Cpp2IlInjected.Address(RVA = "0xA50CE30", Offset = "0xA50C230", VA = "0x18A50CE30")]
		public static MemoryAccessInfo CreateDefaultElement(string attribute)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFC")]
		[Cpp2IlInjected.Address(RVA = "0xA50DFE0", Offset = "0xA50D3E0", VA = "0x18A50DFE0")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFD")]
		[Cpp2IlInjected.Address(RVA = "0xA50DEE0", Offset = "0xA50D2E0", VA = "0x18A50DEE0")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, DimensionType dimensions, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFE")]
		[Cpp2IlInjected.Address(RVA = "0xA50DB20", Offset = "0xA50CF20", VA = "0x18A50DB20")]
		public readonly MemoryAccessInfo Slice(int itemStart, int itemCount)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFF")]
		[Cpp2IlInjected.Address(RVA = "0xA50DC40", Offset = "0xA50D040", VA = "0x18A50DC40")]
		public readonly MemoryAccessInfo WithFormat(AttributeFormat newFormat)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E08")]
		[Cpp2IlInjected.Address(RVA = "0xA50D710", Offset = "0xA50CB10", VA = "0x18A50D710")]
		public static int SetInterleavedInfo(MemoryAccessInfo[] attributes, int byteOffset, int itemsCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E09")]
		[Cpp2IlInjected.Address(RVA = "0xA50D960", Offset = "0xA50CD60", VA = "0x18A50D960")]
		public static MemoryAccessInfo[] Slice(MemoryAccessInfo[] attributes, int start, int count)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[DebuggerDisplay("{ToDebuggerDisplay(),nq}")]
	public readonly struct MemoryImage : IEquatable<MemoryImage>
	{
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private const string EMBEDDED_OCTET_STREAM = "data:application/octet-stream";

		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private const string EMBEDDED_GLTF_BUFFER = "data:application/gltf-buffer";

		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private const string EMBEDDED_JPEG_BUFFER = "data:image/jpeg";

		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private const string EMBEDDED_PNG_BUFFER = "data:image/png";

		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private const string EMBEDDED_DDS_BUFFER = "data:image/vnd-ms.dds";

		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private const string EMBEDDED_WEBP_BUFFER = "data:image/webp";

		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private const string EMBEDDED_KTX2_BUFFER = "data:image/ktx2";

		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private const string MIME_PNG = "image/png";

		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private const string MIME_JPG = "image/jpeg";

		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private const string MIME_DDS = "image/vnd-ms.dds";

		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private const string MIME_WEBP = "image/webp";

		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private const string MIME_KTX2 = "image/ktx2";

		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private const string DEFAULT_PNG_IMAGE = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAIAAACQkWg2AAAACXBIWXMAAA7DAAAOwwHHb6hkAAAAHXpUWHRUaXRsZQAACJlzSU1LLM0pCUmtKCktSgUAKVIFt/VCuZ8AAAAoelRYdEF1dGhvcgAACJkLy0xOzStJVQhIzUtMSS1WcCzKTc1Lzy8BAG89CQyAoFAQAAAANElEQVQoz2O8cuUKAwxoa2vD2VevXsUqzsRAIqC9Bsb///8TdDey+CD0Awsx7h6NB5prAADPsx0VAB8VRQAAAABJRU5ErkJggg==";

		[Cpp2IlInjected.Token(Token = "0x4000631")]
		internal static readonly string[] _EmbeddedHeaders;

		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private const string GuardError_MustBeValidImage = "Must be a valid image: Png, Jpg, etc...";

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private readonly Lazy<ArraySegment<byte>> _LazyImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _SourcePathHint;

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		internal static byte[] DefaultPngImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000E14")]
			[Cpp2IlInjected.Address(RVA = "0xA511300", Offset = "0xA510700", VA = "0x18A511300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public static MemoryImage Empty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E15")]
			[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
			get
			{
				return default(MemoryImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		private ArraySegment<byte> _Image
		{
			[Cpp2IlInjected.Token(Token = "0x6000E25")]
			[Cpp2IlInjected.Address(RVA = "0xA511D30", Offset = "0xA511130", VA = "0x18A511D30")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2C")]
			[Cpp2IlInjected.Address(RVA = "0xA511600", Offset = "0xA510A00", VA = "0x18A511600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public ReadOnlyMemory<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2D")]
			[Cpp2IlInjected.Address(RVA = "0xA511230", Offset = "0xA510630", VA = "0x18A511230")]
			get
			{
				return default(ReadOnlyMemory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public string SourcePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2E")]
			[Cpp2IlInjected.Address(RVA = "0xF3E410", Offset = "0xF3D810", VA = "0x180F3E410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public bool IsPng
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2F")]
			[Cpp2IlInjected.Address(RVA = "0xA511950", Offset = "0xA510D50", VA = "0x18A511950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public bool IsJpg
		{
			[Cpp2IlInjected.Token(Token = "0x6000E30")]
			[Cpp2IlInjected.Address(RVA = "0xA511770", Offset = "0xA510B70", VA = "0x18A511770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public bool IsDds
		{
			[Cpp2IlInjected.Token(Token = "0x6000E31")]
			[Cpp2IlInjected.Address(RVA = "0xA511540", Offset = "0xA510940", VA = "0x18A511540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public bool IsWebp
		{
			[Cpp2IlInjected.Token(Token = "0x6000E32")]
			[Cpp2IlInjected.Address(RVA = "0xA511A90", Offset = "0xA510E90", VA = "0x18A511A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public bool IsKtx2
		{
			[Cpp2IlInjected.Token(Token = "0x6000E33")]
			[Cpp2IlInjected.Address(RVA = "0xA511890", Offset = "0xA510C90", VA = "0x18A511890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public bool IsExtendedFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000E34")]
			[Cpp2IlInjected.Address(RVA = "0xA5116D0", Offset = "0xA510AD0", VA = "0x18A5116D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000E35")]
			[Cpp2IlInjected.Address(RVA = "0xA511A10", Offset = "0xA510E10", VA = "0x18A511A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public string FileExtension
		{
			[Cpp2IlInjected.Token(Token = "0x6000E36")]
			[Cpp2IlInjected.Address(RVA = "0xA511360", Offset = "0xA510760", VA = "0x18A511360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public string MimeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000E37")]
			[Cpp2IlInjected.Address(RVA = "0xA511B50", Offset = "0xA510F50", VA = "0x18A511B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E13")]
		[Cpp2IlInjected.Address(RVA = "0xA50F120", Offset = "0xA50E520", VA = "0x18A50F120")]
		public string ToDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E16")]
		[Cpp2IlInjected.Address(RVA = "0xA511E20", Offset = "0xA511220", VA = "0x18A511E20")]
		public static implicit operator MemoryImage(ArraySegment<byte> image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E17")]
		[Cpp2IlInjected.Address(RVA = "0xA511EB0", Offset = "0xA5112B0", VA = "0x18A511EB0")]
		public static implicit operator MemoryImage(byte[] image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E18")]
		[Cpp2IlInjected.Address(RVA = "0xA511ED0", Offset = "0xA5112D0", VA = "0x18A511ED0")]
		public static implicit operator MemoryImage(string filePath)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E19")]
		[Cpp2IlInjected.Address(RVA = "0xA510110", Offset = "0xA50F510", VA = "0x18A510110")]
		public static bool TryParseMime64(Uri mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1A")]
		[Cpp2IlInjected.Address(RVA = "0xA50FC40", Offset = "0xA50F040", VA = "0x18A50FC40")]
		public static bool TryParseMime64(string mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1B")]
		[Cpp2IlInjected.Address(RVA = "0xA511020", Offset = "0xA510420", VA = "0x18A511020")]
		public MemoryImage(ArraySegment<byte> image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1C")]
		[Cpp2IlInjected.Address(RVA = "0xA510E30", Offset = "0xA510230", VA = "0x18A510E30")]
		public MemoryImage(byte[] image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1D")]
		[Cpp2IlInjected.Address(RVA = "0xA511180", Offset = "0xA510580", VA = "0x18A511180")]
		public MemoryImage(Func<ArraySegment<byte>> factory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1E")]
		[Cpp2IlInjected.Address(RVA = "0xA510EB0", Offset = "0xA5102B0", VA = "0x18A510EB0")]
		public MemoryImage(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1F")]
		[Cpp2IlInjected.Address(RVA = "0xA510DB0", Offset = "0xA5101B0", VA = "0x18A510DB0")]
		internal MemoryImage(byte[] image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E20")]
		[Cpp2IlInjected.Address(RVA = "0xA5110F0", Offset = "0xA5104F0", VA = "0x18A5110F0")]
		internal MemoryImage(ArraySegment<byte> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E21")]
		[Cpp2IlInjected.Address(RVA = "0xA5110A0", Offset = "0xA5104A0", VA = "0x18A5110A0")]
		internal MemoryImage(MemoryImage image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E22")]
		[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
		internal MemoryImage(Lazy<ArraySegment<byte>> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E23")]
		[Cpp2IlInjected.Address(RVA = "0xA5107F0", Offset = "0xA50FBF0", VA = "0x18A5107F0")]
		private static Lazy<ArraySegment<byte>> _ToLazy(byte[] bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E24")]
		[Cpp2IlInjected.Address(RVA = "0xA510700", Offset = "0xA50FB00", VA = "0x18A510700")]
		private static Lazy<ArraySegment<byte>> _ToLazy(ArraySegment<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E26")]
		[Cpp2IlInjected.Address(RVA = "0xA50E870", Offset = "0xA50DC70", VA = "0x18A50E870", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E27")]
		[Cpp2IlInjected.Address(RVA = "0xA50E2F0", Offset = "0xA50D6F0", VA = "0x18A50E2F0")]
		public static bool AreEqual(MemoryImage a, MemoryImage b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E28")]
		[Cpp2IlInjected.Address(RVA = "0xA50E720", Offset = "0xA50DB20", VA = "0x18A50E720", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E29")]
		[Cpp2IlInjected.Address(RVA = "0xA50E7F0", Offset = "0xA50DBF0", VA = "0x18A50E7F0", Slot = "4")]
		public bool Equals(MemoryImage other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2A")]
		[Cpp2IlInjected.Address(RVA = "0xA511DB0", Offset = "0xA5111B0", VA = "0x18A511DB0")]
		public static bool operator ==(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2B")]
		[Cpp2IlInjected.Address(RVA = "0xA511EF0", Offset = "0xA5112F0", VA = "0x18A511EF0")]
		public static bool operator !=(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E38")]
		[Cpp2IlInjected.Address(RVA = "0xA50FA60", Offset = "0xA50EE60", VA = "0x18A50FA60")]
		public static string TrimImageExtension(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E39")]
		[Cpp2IlInjected.Address(RVA = "0xA510870", Offset = "0xA50FC70", VA = "0x18A510870")]
		internal static void _Verify(MemoryImage image, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3A")]
		[Cpp2IlInjected.Address(RVA = "0xA50EC60", Offset = "0xA50E060", VA = "0x18A50EC60")]
		public Stream Open()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3B")]
		[Cpp2IlInjected.Address(RVA = "0xA50EEC0", Offset = "0xA50E2C0", VA = "0x18A50EEC0")]
		public void SaveToFile(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3C")]
		[Cpp2IlInjected.Address(RVA = "0xA510180", Offset = "0xA50F580", VA = "0x18A510180")]
		internal ArraySegment<byte> _GetBuffer()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3D")]
		[Cpp2IlInjected.Address(RVA = "0xA50F680", Offset = "0xA50EA80", VA = "0x18A50F680")]
		internal string ToMime64(bool withPrefix = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3E")]
		[Cpp2IlInjected.Address(RVA = "0xA50E950", Offset = "0xA50DD50", VA = "0x18A50E950")]
		public bool IsImageOfType(string format)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3F")]
		[Cpp2IlInjected.Address(RVA = "0xA510520", Offset = "0xA50F920", VA = "0x18A510520")]
		private static bool _IsPngImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E40")]
		[Cpp2IlInjected.Address(RVA = "0xA510440", Offset = "0xA50F840", VA = "0x18A510440")]
		private static bool _IsJpgImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E41")]
		[Cpp2IlInjected.Address(RVA = "0xA510230", Offset = "0xA50F630", VA = "0x18A510230")]
		private static bool _IsDdsImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E42")]
		[Cpp2IlInjected.Address(RVA = "0xA5105D0", Offset = "0xA50F9D0", VA = "0x18A5105D0")]
		private static bool _IsWebpImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E43")]
		[Cpp2IlInjected.Address(RVA = "0xA5104C0", Offset = "0xA50F8C0", VA = "0x18A5104C0")]
		private static bool _IsKtx2Image(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E44")]
		[Cpp2IlInjected.Address(RVA = "0xA5102E0", Offset = "0xA50F6E0", VA = "0x18A5102E0")]
		private static bool _IsImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[DebuggerDisplay("{PixelWidth}x{PixelHeight}x{PixelDepth}")]
	internal readonly struct Ktx2Header
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public readonly ulong Header0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public readonly uint Header1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public readonly uint VkFormat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public readonly uint TypeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public readonly uint PixelWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public readonly uint PixelHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		public readonly uint PixelDepth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public readonly uint LayerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public readonly uint FaceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public readonly uint LevelCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public readonly uint SupercompressionScheme;

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		public bool IsValidHeader
		{
			[Cpp2IlInjected.Token(Token = "0x6000E48")]
			[Cpp2IlInjected.Address(RVA = "0xA50CE10", Offset = "0xA50C210", VA = "0x18A50CE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E49")]
		[Cpp2IlInjected.Address(RVA = "0xA50CA90", Offset = "0xA50BE90", VA = "0x18A50CA90")]
		public static bool TryGetHeader(IReadOnlyList<byte> data, [Out] Ktx2Header header)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4A")]
		[Cpp2IlInjected.Address(RVA = "0xA50CC20", Offset = "0xA50C020", VA = "0x18A50CC20")]
		public static void Verify(IReadOnlyList<byte> data, string paramName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[DebuggerDisplay("Sparse {typeof(T).Name} Accessor {Count}")]
	public sealed class SparseArray<T> : IAccessorArray<T>, IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IList<T>, ICollection<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IReadOnlyList<T> _DenseItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IReadOnlyList<T> _SparseItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Dictionary<int, int> _SparseIndices;

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private T[] _DebugItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4C")]
			[Cpp2IlInjected.Address(RVA = "0x7A4C650", Offset = "0x7A4BA50", VA = "0x187A4C650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4D")]
			[Cpp2IlInjected.Address(RVA = "0x7A4C0A0", Offset = "0x7A4B4A0", VA = "0x187A4C0A0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4E")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4F")]
			[Cpp2IlInjected.Address(RVA = "0x7A4C4F0", Offset = "0x7A4B8F0", VA = "0x187A4C4F0", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E50")]
			[Cpp2IlInjected.Address(RVA = "0x7A4C6F0", Offset = "0x7A4BAF0", VA = "0x187A4C6F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4B")]
		[Cpp2IlInjected.Address(RVA = "0x7A4B940", Offset = "0x7A4AD40", VA = "0x187A4B940")]
		public SparseArray(IReadOnlyList<T> denseValues, IReadOnlyList<T> sparseValues, IReadOnlyList<uint> sparseKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E51")]
		[Cpp2IlInjected.Address(RVA = "0x7A4A6B0", Offset = "0x7A49AB0", VA = "0x187A4A6B0", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E52")]
		[Cpp2IlInjected.Address(RVA = "0x7A4A6B0", Offset = "0x7A49AB0", VA = "0x187A4A6B0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E53")]
		[Cpp2IlInjected.Address(RVA = "0x7A4A030", Offset = "0x7A49430", VA = "0x187A4A030", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E54")]
		[Cpp2IlInjected.Address(RVA = "0x7A4A790", Offset = "0x7A49B90", VA = "0x187A4A790", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E55")]
		[Cpp2IlInjected.Address(RVA = "0x7A4A5D0", Offset = "0x7A499D0", VA = "0x187A4A5D0", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E56")]
		[Cpp2IlInjected.Address(RVA = "0x5133F20", Offset = "0x5133320", VA = "0x185133F20", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E57")]
		[Cpp2IlInjected.Address(RVA = "0x4F98C30", Offset = "0x4F98030", VA = "0x184F98C30", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E58")]
		[Cpp2IlInjected.Address(RVA = "0x4F98C30", Offset = "0x4F98030", VA = "0x184F98C30", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E59")]
		[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5A")]
		[Cpp2IlInjected.Address(RVA = "0x4F98C30", Offset = "0x4F98030", VA = "0x184F98C30", Slot = "22")]
		bool ICollection<T>.Remove(T item)
		{
			return default(bool);
		}
	}
}
namespace SharpGLTF.IO
{
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	public abstract class JsonSerializable
	{
		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		internal string _SchemaName
		{
			[Cpp2IlInjected.Token(Token = "0x6000E5F")]
			[Cpp2IlInjected.Address(RVA = "0x501BA30", Offset = "0x501AE30", VA = "0x18501BA30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5B")]
		[Cpp2IlInjected.Address(RVA = "0xA50C0F0", Offset = "0xA50B4F0", VA = "0x18A50C0F0")]
		internal void ValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5C")]
		[Cpp2IlInjected.Address(RVA = "0xA50C090", Offset = "0xA50B490", VA = "0x18A50C090")]
		internal void ValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5D")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
		protected virtual void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5E")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
		protected virtual void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E60")]
		[Cpp2IlInjected.Address(RVA = "0xA50B090", Offset = "0xA50A490", VA = "0x18A50B090", Slot = "6")]
		protected virtual string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E61")]
		[Cpp2IlInjected.Address(RVA = "0xA50BFB0", Offset = "0xA50B3B0", VA = "0x18A50BFB0")]
		internal void Serialize(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E62")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void SerializeProperties(Utf8JsonWriter writer);

		[Cpp2IlInjected.Token(Token = "0x6000E63")]
		[Cpp2IlInjected.Address(RVA = "0xA50BD90", Offset = "0xA50B190", VA = "0x18A50BD90")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E64")]
		[Cpp2IlInjected.Address(RVA = "0xA50B0C0", Offset = "0xA50A4C0", VA = "0x18A50B0C0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, bool? value, [Optional] bool? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E65")]
		[Cpp2IlInjected.Address(RVA = "0xA50BE60", Offset = "0xA50B260", VA = "0x18A50BE60")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, int? value, [Optional] int? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E66")]
		[Cpp2IlInjected.Address(RVA = "0xA50B570", Offset = "0xA50A970", VA = "0x18A50B570")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, float? value, [Optional] float? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E67")]
		[Cpp2IlInjected.Address(RVA = "0xA50B880", Offset = "0xA50AC80", VA = "0x18A50B880")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, double? value, [Optional] double? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E68")]
		[Cpp2IlInjected.Address(RVA = "0xA50B230", Offset = "0xA50A630", VA = "0x18A50B230")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector2? value, [Optional] Vector2? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E69")]
		[Cpp2IlInjected.Address(RVA = "0xA50B3B0", Offset = "0xA50A7B0", VA = "0x18A50B3B0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector3? value, [Optional] Vector3? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6A")]
		[Cpp2IlInjected.Address(RVA = "0xA50B6C0", Offset = "0xA50AAC0", VA = "0x18A50B6C0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector4? value, [Optional] Vector4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6B")]
		[Cpp2IlInjected.Address(RVA = "0xA50B9C0", Offset = "0xA50ADC0", VA = "0x18A50B9C0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Quaternion? value, [Optional] Quaternion? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6C")]
		[Cpp2IlInjected.Address(RVA = "0xA50BB80", Offset = "0xA50AF80", VA = "0x18A50BB80")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Matrix4x4? value, [Optional] Matrix4x4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6D")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC100", Offset = "0x3BAB500", VA = "0x183BAC100")]
		protected static void SerializePropertyEnumValue<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6E")]
		[Cpp2IlInjected.Address(RVA = "0x3BABB00", Offset = "0x3BAAF00", VA = "0x183BABB00")]
		protected static void SerializePropertyEnumSymbol<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6F")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC350", Offset = "0x3BAB750", VA = "0x183BAC350")]
		protected static void SerializePropertyObject<T>(Utf8JsonWriter writer, string name, T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E70")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC420", Offset = "0x3BAB820", VA = "0x183BAC420")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyList<T> collection, [Optional] int? minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E71")]
		[Cpp2IlInjected.Address(RVA = "0x3BACEC0", Offset = "0x3BAC2C0", VA = "0x183BACEC0")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyDictionary<string, T> collection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E72")]
		[Cpp2IlInjected.Address(RVA = "0xA50C1C0", Offset = "0xA50B5C0", VA = "0x18A50C1C0")]
		private static void _SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E73")]
		[Cpp2IlInjected.Address(RVA = "0xA50C150", Offset = "0xA50B550", VA = "0x18A50C150")]
		private static bool _IsNullOrEmpty(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E74")]
		[Cpp2IlInjected.Address(RVA = "0xA50C350", Offset = "0xA50B750", VA = "0x18A50C350")]
		private static void _SerializeValue(Utf8JsonWriter writer, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E75")]
		[Cpp2IlInjected.Address(RVA = "0xA50AF50", Offset = "0xA50A350", VA = "0x18A50AF50")]
		internal void Deserialize(Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E76")]
		[Cpp2IlInjected.Address(RVA = "0xA50AA40", Offset = "0xA509E40", VA = "0x18A50AA40")]
		protected static object DeserializeUnknownObject(Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E77")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader);

		[Cpp2IlInjected.Token(Token = "0x6000E78")]
		[Cpp2IlInjected.Address(RVA = "0x3BAAA70", Offset = "0x3BA9E70", VA = "0x183BAAA70")]
		protected static T DeserializePropertyValue<T>(Utf8JsonReader reader)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E79")]
		[Cpp2IlInjected.Address(RVA = "0x3BAB370", Offset = "0x3BAA770", VA = "0x183BAB370")]
		protected static void DeserializePropertyValue<TParent, T>(Utf8JsonReader reader, TParent owner, [Out] T property) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7A")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA400", Offset = "0x3BA9800", VA = "0x183BAA400")]
		protected static void DeserializePropertyList<TParent, T>(Utf8JsonReader reader, TParent owner, IList<T> list) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7B")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9D00", Offset = "0x3BA9100", VA = "0x183BA9D00")]
		protected static void DeserializePropertyList<T>(Utf8JsonReader reader, IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7C")]
		[Cpp2IlInjected.Address(RVA = "0x3BA9CB0", Offset = "0x3BA90B0", VA = "0x183BA9CB0")]
		protected static void DeserializePropertyDictionary<TParent, T>(Utf8JsonReader reader, TParent owner, IDictionary<string, T> dict) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7D")]
		[Cpp2IlInjected.Address(RVA = "0x3BA99D0", Offset = "0x3BA8DD0", VA = "0x183BA99D0")]
		protected static void DeserializePropertyDictionary<T>(Utf8JsonReader reader, IDictionary<string, T> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7E")]
		[Cpp2IlInjected.Address(RVA = "0x3BADA20", Offset = "0x3BACE20", VA = "0x183BADA20")]
		private static bool _TryCastValue<T>(Utf8JsonReader reader, [Out] object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7F")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected JsonSerializable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal static class _JSonSerializationExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000E80")]
		[Cpp2IlInjected.Address(RVA = "0xA513660", Offset = "0xA512A60", VA = "0x18A513660")]
		public static bool AsBoolean([In] this Utf8JsonReader reader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E81")]
		[Cpp2IlInjected.Address(RVA = "0xA513C80", Offset = "0xA513080", VA = "0x18A513C80")]
		public static string AsString([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E82")]
		[Cpp2IlInjected.Address(RVA = "0xA513790", Offset = "0xA512B90", VA = "0x18A513790")]
		public static object AsEnum([In] this Utf8JsonReader reader, Type enumType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E83")]
		[Cpp2IlInjected.Address(RVA = "0xA513FE0", Offset = "0xA5133E0", VA = "0x18A513FE0")]
		public static object GetAnyValue([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E84")]
		[Cpp2IlInjected.Address(RVA = "0xA5142F0", Offset = "0xA5136F0", VA = "0x18A5142F0")]
		public static object GetValueAs([In] this Utf8JsonReader reader, Type vtype)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E85")]
		[Cpp2IlInjected.Address(RVA = "0x41494B0", Offset = "0x41488B0", VA = "0x1841494B0")]
		public static T GetValueAs<T>([In] this Utf8JsonReader reader) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E86")]
		[Cpp2IlInjected.Address(RVA = "0xA515390", Offset = "0xA514790", VA = "0x18A515390")]
		public static bool TryWriteProperty(this Utf8JsonWriter writer, string property, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E87")]
		[Cpp2IlInjected.Address(RVA = "0xA515BC0", Offset = "0xA514FC0", VA = "0x18A515BC0")]
		public static bool TryWriteValue(this Utf8JsonWriter writer, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E88")]
		[Cpp2IlInjected.Address(RVA = "0xA516560", Offset = "0xA515960", VA = "0x18A516560")]
		public static void WriteVector2(this Utf8JsonWriter writer, Vector2 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E89")]
		[Cpp2IlInjected.Address(RVA = "0xA5165C0", Offset = "0xA5159C0", VA = "0x18A5165C0")]
		public static void WriteVector3(this Utf8JsonWriter writer, Vector3 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8A")]
		[Cpp2IlInjected.Address(RVA = "0xA516490", Offset = "0xA515890", VA = "0x18A516490")]
		public static void WriteVector4(this Utf8JsonWriter writer, Vector4 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8B")]
		[Cpp2IlInjected.Address(RVA = "0xA516490", Offset = "0xA515890", VA = "0x18A516490")]
		public static void WriteQuaternion(this Utf8JsonWriter writer, Quaternion q)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8C")]
		[Cpp2IlInjected.Address(RVA = "0xA516350", Offset = "0xA515750", VA = "0x18A516350")]
		public static void WriteMatrix4x4(this Utf8JsonWriter writer, Matrix4x4 m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8D")]
		[Cpp2IlInjected.Address(RVA = "0xA513B30", Offset = "0xA512F30", VA = "0x18A513B30")]
		public static Uri AsStringUri([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8E")]
		[Cpp2IlInjected.Address(RVA = "0xA516510", Offset = "0xA515910", VA = "0x18A516510")]
		public static void WriteUri(this Utf8JsonWriter writer, Uri value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[DebuggerDisplay("Unknown {_Name}")]
	internal class UnknownNode : JsonSerializable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private readonly string _Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private readonly Dictionary<string, JsonNode> _Properties;

		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000E90")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public IReadOnlyDictionary<string, JsonNode> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000E91")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8F")]
		[Cpp2IlInjected.Address(RVA = "0xA512E70", Offset = "0xA512270", VA = "0x18A512E70")]
		public UnknownNode(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E92")]
		[Cpp2IlInjected.Address(RVA = "0xA512C00", Offset = "0xA512000", VA = "0x18A512C00", Slot = "8")]
		protected override void DeserializeProperty(string property, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E93")]
		[Cpp2IlInjected.Address(RVA = "0xA512C80", Offset = "0xA512080", VA = "0x18A512C80", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}
	}
}
namespace SharpGLTF.Diagnostics
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	internal static class DebuggerDisplay
	{
		[Cpp2IlInjected.Token(Token = "0x6000E94")]
		[Cpp2IlInjected.Address(RVA = "0xA509420", Offset = "0xA508820", VA = "0x18A509420")]
		internal static string GetAttributeShortName(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E95")]
		[Cpp2IlInjected.Address(RVA = "0xA509E50", Offset = "0xA509250", VA = "0x18A509E50")]
		public static string ToReport(this MemoryAccessInfo minfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E96")]
		[Cpp2IlInjected.Address(RVA = "0xA509C60", Offset = "0xA509060", VA = "0x18A509C60")]
		public static string ToReport(this BufferView bv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E97")]
		[Cpp2IlInjected.Address(RVA = "0xA509BB0", Offset = "0xA508FB0", VA = "0x18A509BB0")]
		public static string ToReportShort(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E98")]
		[Cpp2IlInjected.Address(RVA = "0xA509940", Offset = "0xA508D40", VA = "0x18A509940")]
		public static string ToReportLong(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E99")]
		[Cpp2IlInjected.Address(RVA = "0xA509FC0", Offset = "0xA5093C0", VA = "0x18A509FC0")]
		public static string ToReport(this MeshPrimitive prim, string txt)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	internal sealed class _CollectionDebugProxy<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private readonly ICollection<T> _Collection;

		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA3")]
			[Cpp2IlInjected.Address(RVA = "0x5135860", Offset = "0x5134C60", VA = "0x185135860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA2")]
		[Cpp2IlInjected.Address(RVA = "0x51357D0", Offset = "0x5134BD0", VA = "0x1851357D0")]
		public _CollectionDebugProxy(ICollection<T> collection)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	internal sealed class _BufferViewDebugProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		private readonly BufferView _Value;

		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA5")]
			[Cpp2IlInjected.Address(RVA = "0xA513640", Offset = "0xA512A40", VA = "0x18A513640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA6")]
			[Cpp2IlInjected.Address(RVA = "0xA513620", Offset = "0xA512A20", VA = "0x18A513620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA7")]
			[Cpp2IlInjected.Address(RVA = "0xA5135A0", Offset = "0xA5129A0", VA = "0x18A5135A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public Accessor[] Accessors
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA8")]
			[Cpp2IlInjected.Address(RVA = "0xA513550", Offset = "0xA512950", VA = "0x18A513550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA4")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public _BufferViewDebugProxy(BufferView value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	internal sealed class _AccessorDebugProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		private readonly Accessor _Value;

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		public string Identity
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAA")]
			[Cpp2IlInjected.Address(RVA = "0xA512FC0", Offset = "0xA5123C0", VA = "0x18A512FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public BufferView Source
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAB")]
			[Cpp2IlInjected.Address(RVA = "0xA513400", Offset = "0xA512800", VA = "0x18A513400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public (DimensionType Dimensions, EncodingType Encoding, bool Normalized) Format
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAC")]
			[Cpp2IlInjected.Address(RVA = "0xA512F10", Offset = "0xA512310", VA = "0x18A512F10")]
			get
			{
				return default((DimensionType, EncodingType, bool));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		public object[] Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAD")]
			[Cpp2IlInjected.Address(RVA = "0xA513040", Offset = "0xA512440", VA = "0x18A513040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA9")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public _AccessorDebugProxy(Accessor value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	internal sealed class _MeshDebugProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Mesh _Value;

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAF")]
			[Cpp2IlInjected.Address(RVA = "0x1FABF50", Offset = "0x1FAB350", VA = "0x181FABF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public MeshPrimitive[] Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB0")]
			[Cpp2IlInjected.Address(RVA = "0xA5168A0", Offset = "0xA515CA0", VA = "0x18A5168A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAE")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public _MeshDebugProxy(Mesh value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	internal sealed class _Matrix4x4DoubleProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		private Matrix4x4Double _Value;

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		public (double X, double Y, double Z, double W) Row1
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB2")]
			[Cpp2IlInjected.Address(RVA = "0xA5166A0", Offset = "0xA515AA0", VA = "0x18A5166A0")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public (double X, double Y, double Z, double W) Row2
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB3")]
			[Cpp2IlInjected.Address(RVA = "0xA516720", Offset = "0xA515B20", VA = "0x18A516720")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public (double X, double Y, double Z, double W) Row3
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB4")]
			[Cpp2IlInjected.Address(RVA = "0xA5167A0", Offset = "0xA515BA0", VA = "0x18A5167A0")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public (double X, double Y, double Z, double W) Row4
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB5")]
			[Cpp2IlInjected.Address(RVA = "0xA516820", Offset = "0xA515C20", VA = "0x18A516820")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB1")]
		[Cpp2IlInjected.Address(RVA = "0xA516630", Offset = "0xA515A30", VA = "0x18A516630")]
		public _Matrix4x4DoubleProxy(Matrix4x4Double value)
		{
		}
	}
}
namespace SharpGLTF.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[DebuggerDisplay("{Count}")]
	public sealed class ChildrenDictionary<T, TParent> : IReadOnlyDictionary<string, T>, IEnumerable<KeyValuePair<string, T>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, T>>, IDictionary<string, T>, ICollection<KeyValuePair<string, T>>, IReflectionObject where T : class, IChildOfDictionary<TParent> where TParent : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly TParent _Parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private Dictionary<string, T> _Collection;

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		IEnumerable<string> IReadOnlyDictionary<string, T>.Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB7")]
			[Cpp2IlInjected.Address(RVA = "0x4FDEFA0", Offset = "0x4FDE3A0", VA = "0x184FDEFA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public ICollection<string> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB8")]
			[Cpp2IlInjected.Address(RVA = "0x4FDF740", Offset = "0x4FDEB40", VA = "0x184FDF740", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		IEnumerable<T> IReadOnlyDictionary<string, T>.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB9")]
			[Cpp2IlInjected.Address(RVA = "0x4FDF020", Offset = "0x4FDE420", VA = "0x184FDF020", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public ICollection<T> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBA")]
			[Cpp2IlInjected.Address(RVA = "0x4FDF7C0", Offset = "0x4FDEBC0", VA = "0x184FDF7C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBB")]
			[Cpp2IlInjected.Address(RVA = "0x4FDF690", Offset = "0x4FDEA90", VA = "0x184FDF690", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBC")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		public T this[string key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBD")]
			[Cpp2IlInjected.Address(RVA = "0x4FDF6B0", Offset = "0x4FDEAB0", VA = "0x184FDF6B0", Slot = "12")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EBE")]
			[Cpp2IlInjected.Address(RVA = "0x4FDF810", Offset = "0x4FDEC10", VA = "0x184FDF810", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB6")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF5C0", Offset = "0x4FDE9C0", VA = "0x184FDF5C0")]
		public ChildrenDictionary(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBF")]
		[Cpp2IlInjected.Address(RVA = "0x4FDE950", Offset = "0x4FDDD50", VA = "0x184FDE950", Slot = "23")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC0")]
		[Cpp2IlInjected.Address(RVA = "0x4FDE810", Offset = "0x4FDDC10", VA = "0x184FDE810", Slot = "17")]
		public void Add(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC1")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEE70", Offset = "0x4FDE270", VA = "0x184FDEE70", Slot = "18")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC2")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEB60", Offset = "0x4FDDF60", VA = "0x184FDEB60", Slot = "16")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC3")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF200", Offset = "0x4FDE600", VA = "0x184FDF200", Slot = "19")]
		public bool TryGetValue(string key, [Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC4")]
		[Cpp2IlInjected.Address(RVA = "0x4FDED50", Offset = "0x4FDE150", VA = "0x184FDED50", Slot = "10")]
		public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC5")]
		[Cpp2IlInjected.Address(RVA = "0x4FDED50", Offset = "0x4FDE150", VA = "0x184FDED50", Slot = "11")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC6")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF360", Offset = "0x4FDE760", VA = "0x184FDF360")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC7")]
		[Cpp2IlInjected.Address(RVA = "0x1099DF0", Offset = "0x10991F0", VA = "0x181099DF0")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC8")]
		[Cpp2IlInjected.Address(RVA = "0x4FDE7F0", Offset = "0x4FDDBF0", VA = "0x184FDE7F0", Slot = "22")]
		public void Add(KeyValuePair<string, T> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC9")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEB90", Offset = "0x4FDDF90", VA = "0x184FDEB90", Slot = "24")]
		public bool Contains(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECA")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEE50", Offset = "0x4FDE250", VA = "0x184FDEE50", Slot = "26")]
		public bool Remove(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECB")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEBD0", Offset = "0x4FDDFD0", VA = "0x184FDEBD0", Slot = "25")]
		public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECC")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEDC0", Offset = "0x4FDE1C0", VA = "0x184FDEDC0", Slot = "27")]
		public IEnumerable<SharpGLTF.Reflection.FieldInfo> GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECD")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF070", Offset = "0x4FDE470", VA = "0x184FDF070", Slot = "28")]
		public bool TryGetField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[DebuggerDisplay("{Count}")]
	public sealed class ChildrenList<T, TParent> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>, IReflectionArray, IReflectionObject where T : class, IChildOfList<TParent> where TParent : class
	{
		[Cpp2IlInjected.Token(Token = "0x200018A")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Reflection-IReflectionObject-GetFields>d__22 : IEnumerable<SharpGLTF.Reflection.FieldInfo>, IEnumerable, IEnumerator<SharpGLTF.Reflection.FieldInfo>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000659")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400065A")]
			private SharpGLTF.Reflection.FieldInfo <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400065B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400065C")]
			public ChildrenList<T, TParent> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400065D")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000266")]
			SharpGLTF.Reflection.FieldInfo IEnumerator<SharpGLTF.Reflection.FieldInfo>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000EEE")]
				[Cpp2IlInjected.Address(RVA = "0x4E874C0", Offset = "0x4E868C0", VA = "0x184E874C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(SharpGLTF.Reflection.FieldInfo);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000267")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000EF0")]
				[Cpp2IlInjected.Address(RVA = "0x6D06190", Offset = "0x6D05590", VA = "0x186D06190", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEB")]
			[Cpp2IlInjected.Address(RVA = "0x65D8650", Offset = "0x65D7A50", VA = "0x1865D8650")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEC")]
			[Cpp2IlInjected.Address(RVA = "0x6681250", Offset = "0x6680650", VA = "0x186681250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EED")]
			[Cpp2IlInjected.Address(RVA = "0x6D05F80", Offset = "0x6D05380", VA = "0x186D05F80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEF")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF1")]
			[Cpp2IlInjected.Address(RVA = "0x65D8160", Offset = "0x65D7560", VA = "0x1865D8160", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF2")]
			[Cpp2IlInjected.Address(RVA = "0x6D060D0", Offset = "0x6D054D0", VA = "0x186D060D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly TParent _Parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private List<T> _Collection;

		[Cpp2IlInjected.Token(Token = "0x17000263")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED4")]
			[Cpp2IlInjected.Address(RVA = "0x4FE07D0", Offset = "0x4FDFBD0", VA = "0x184FE07D0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ED5")]
			[Cpp2IlInjected.Address(RVA = "0x4FE0840", Offset = "0x4FDFC40", VA = "0x184FE0840", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED6")]
			[Cpp2IlInjected.Address(RVA = "0x4FE07B0", Offset = "0x4FDFBB0", VA = "0x184FE07B0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED7")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED3")]
		[Cpp2IlInjected.Address(RVA = "0x4FE06E0", Offset = "0x4FDFAE0", VA = "0x184FE06E0")]
		public ChildrenList(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED8")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFBB0", Offset = "0x4FDEFB0", VA = "0x184FDFBB0", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED9")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFD20", Offset = "0x4FDF120", VA = "0x184FDFD20", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDA")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFBD0", Offset = "0x4FDEFD0", VA = "0x184FDFBD0", Slot = "14")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDB")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF830", Offset = "0x4FDEC30", VA = "0x184FDF830", Slot = "11")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDC")]
		[Cpp2IlInjected.Address(RVA = "0x4FDF9A0", Offset = "0x4FDEDA0", VA = "0x184FDF9A0", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDD")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFD40", Offset = "0x4FDF140", VA = "0x184FDFD40", Slot = "7")]
		public void Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDE")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0110", Offset = "0x4FDF510", VA = "0x184FE0110", Slot = "15")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDF")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFEA0", Offset = "0x4FDF2A0", VA = "0x184FDFEA0", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE0")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFBF0", Offset = "0x4FDEFF0", VA = "0x184FDFBF0", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE1")]
		[Cpp2IlInjected.Address(RVA = "0x4FDFBF0", Offset = "0x4FDEFF0", VA = "0x184FDFBF0", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE2")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0510", Offset = "0x4FDF910", VA = "0x184FE0510")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE3")]
		[Cpp2IlInjected.Address(RVA = "0x1099DF0", Offset = "0x10991F0", VA = "0x181099DF0")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE4")]
		[Cpp2IlInjected.Address(RVA = "0x4FE02F0", Offset = "0x4FDF6F0", VA = "0x184FE02F0", Slot = "22")]
		[IteratorStateMachine(typeof(ChildrenList<, >.<SharpGLTF-Reflection-IReflectionObject-GetFields>d__22))]
		IEnumerable<SharpGLTF.Reflection.FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE5")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0180", Offset = "0x4FDF580", VA = "0x184FE0180", Slot = "21")]
		SharpGLTF.Reflection.FieldInfo IReflectionArray.GetField(int index)
		{
			return default(SharpGLTF.Reflection.FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE6")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0380", Offset = "0x4FDF780", VA = "0x184FE0380", Slot = "23")]
		public bool TryGetField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	public readonly struct ChildSetter<TParent> where TParent : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly TParent _Parent;

		[Cpp2IlInjected.Token(Token = "0x6000EF3")]
		[Cpp2IlInjected.Address(RVA = "0x4FDE730", Offset = "0x4FDDB30", VA = "0x184FDE730")]
		public ChildSetter(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF4")]
		[Cpp2IlInjected.Address(RVA = "0x36D4AF0", Offset = "0x36D3EF0", VA = "0x1836D4AF0")]
		public void SetProperty<TProperty, TValue>(TProperty target, TValue value) where TProperty : class where TValue : TProperty
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	public interface IChildOf<TParent> where TParent : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000268")]
		TParent LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000EF5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SetLogicalParent(TParent parent);
	}
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	public interface IChildOfDictionary<TParent> where TParent : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000269")]
		TParent LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000EF7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		string LogicalKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000EF8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetLogicalParent(TParent parent, string key);
	}
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	public interface IChildOfList<TParent> where TParent : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		TParent LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000EFA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000EFB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetLogicalParent(TParent parent, int index);
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	public readonly struct ReadOnlyLinqDictionary<TKey, TValueIn, TValueOut> : IReadOnlyDictionary<TKey, TValueOut>, IEnumerable<KeyValuePair<TKey, TValueOut>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TValueOut>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private readonly IReadOnlyDictionary<TKey, TValueIn> _Source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private readonly Converter<TValueIn, TValueOut> _ValueConverter;

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		public TValueOut this[TKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000EFE")]
			[Cpp2IlInjected.Address(RVA = "0x781A1E0", Offset = "0x78195E0", VA = "0x18781A1E0", Slot = "6")]
			get
			{
				return (TValueOut)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EFF")]
			[Cpp2IlInjected.Address(RVA = "0x781A570", Offset = "0x7819970", VA = "0x18781A570", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public IEnumerable<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F00")]
			[Cpp2IlInjected.Address(RVA = "0x781A5D0", Offset = "0x78199D0", VA = "0x18781A5D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F01")]
			[Cpp2IlInjected.Address(RVA = "0x781A180", Offset = "0x7819580", VA = "0x18781A180", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFD")]
		[Cpp2IlInjected.Address(RVA = "0x10F9A40", Offset = "0x10F8E40", VA = "0x1810F9A40")]
		public ReadOnlyLinqDictionary(IReadOnlyDictionary<TKey, TValueIn> dict, Converter<TValueIn, TValueOut> valConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F02")]
		[Cpp2IlInjected.Address(RVA = "0x78194E0", Offset = "0x78188E0", VA = "0x1878194E0", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F03")]
		[Cpp2IlInjected.Address(RVA = "0x781A030", Offset = "0x7819430", VA = "0x18781A030", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F04")]
		[Cpp2IlInjected.Address(RVA = "0x7819770", Offset = "0x7818B70", VA = "0x187819770", Slot = "10")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F05")]
		[Cpp2IlInjected.Address(RVA = "0x7819930", Offset = "0x7818D30", VA = "0x187819930", Slot = "11")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	public readonly struct LinqDictionary<TKey, TValueIn, TValueOut> : IDictionary<TKey, TValueOut>, ICollection<KeyValuePair<TKey, TValueOut>>, IEnumerable<KeyValuePair<TKey, TValueOut>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private readonly IDictionary<TKey, TValueIn> _Source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private readonly Converter<TValueOut, TValueIn> _InConverter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private readonly Converter<TValueIn, TValueOut> _OutConverter;

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		public TValueOut this[TKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000F0D")]
			[Cpp2IlInjected.Address(RVA = "0x6A0BF40", Offset = "0x6A0B340", VA = "0x186A0BF40", Slot = "4")]
			get
			{
				return (TValueOut)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000F0E")]
			[Cpp2IlInjected.Address(RVA = "0x6A0C500", Offset = "0x6A0B900", VA = "0x186A0C500", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public ICollection<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000F0F")]
			[Cpp2IlInjected.Address(RVA = "0x6A0C230", Offset = "0x6A0B630", VA = "0x186A0C230", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public ICollection<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F10")]
			[Cpp2IlInjected.Address(RVA = "0x6A0C290", Offset = "0x6A0B690", VA = "0x186A0C290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F11")]
			[Cpp2IlInjected.Address(RVA = "0x6A0BE70", Offset = "0x6A0B270", VA = "0x186A0BE70", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000F12")]
			[Cpp2IlInjected.Address(RVA = "0x651BDE0", Offset = "0x651B1E0", VA = "0x18651BDE0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0C")]
		[Cpp2IlInjected.Address(RVA = "0x1F2B580", Offset = "0x1F2A980", VA = "0x181F2B580")]
		public LinqDictionary(IDictionary<TKey, TValueIn> dict, Converter<TValueOut, TValueIn> inConverter, Converter<TValueIn, TValueOut> outConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F13")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B410", Offset = "0x6A0A810", VA = "0x186A0B410", Slot = "8")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F14")]
		[Cpp2IlInjected.Address(RVA = "0x6A0BAD0", Offset = "0x6A0AED0", VA = "0x186A0BAD0", Slot = "11")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F15")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B550", Offset = "0x6A0A950", VA = "0x186A0B550", Slot = "19")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F16")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B8B0", Offset = "0x6A0ACB0", VA = "0x186A0B8B0", Slot = "20")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F17")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B1B0", Offset = "0x6A0A5B0", VA = "0x186A0B1B0", Slot = "9")]
		public void Add(TKey key, TValueOut value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F18")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B770", Offset = "0x6A0AB70", VA = "0x186A0B770", Slot = "10")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F19")]
		[Cpp2IlInjected.Address(RVA = "0x6A0AF80", Offset = "0x6A0A380", VA = "0x186A0AF80", Slot = "14")]
		public void Add(KeyValuePair<TKey, TValueOut> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1A")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B3B0", Offset = "0x6A0A7B0", VA = "0x186A0B3B0", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1B")]
		[Cpp2IlInjected.Address(RVA = "0x3BEAF40", Offset = "0x3BEA340", VA = "0x183BEAF40", Slot = "16")]
		public bool Contains(KeyValuePair<TKey, TValueOut> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1C")]
		[Cpp2IlInjected.Address(RVA = "0x3BEAD80", Offset = "0x3BEA180", VA = "0x183BEAD80", Slot = "17")]
		public void CopyTo(KeyValuePair<TKey, TValueOut>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1D")]
		[Cpp2IlInjected.Address(RVA = "0x3BEAF40", Offset = "0x3BEA340", VA = "0x183BEAF40", Slot = "18")]
		public bool Remove(KeyValuePair<TKey, TValueOut> item)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	internal sealed class ReferenceComparer<T> : IEqualityComparer<T> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		public static readonly ReferenceComparer<T> Instance;

		[Cpp2IlInjected.Token(Token = "0x6000F24")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private ReferenceComparer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F25")]
		[Cpp2IlInjected.Address(RVA = "0x1731BC0", Offset = "0x1730FC0", VA = "0x181731BC0", Slot = "4")]
		public bool Equals(T x, T y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F26")]
		[Cpp2IlInjected.Address(RVA = "0x78B6ED0", Offset = "0x78B62D0", VA = "0x1878B6ED0", Slot = "5")]
		public int GetHashCode(T obj)
		{
			return default(int);
		}
	}
}
namespace SharpGLTF.Animations
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	public static class CurveSampler
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		[CompilerGenerated]
		private sealed class <SplitByTime>d__11<T> : IEnumerable<(float, T)[]>, IEnumerable, IEnumerator<(float, T)[]>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			private (float, T)[] <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000671")]
			private IEnumerable<(float Time, T Value)> sequence;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000672")]
			public IEnumerable<(float Time, T Value)> <>3__sequence;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000673")]
			private List<(float, T)> <segment>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000674")]
			private int <time>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000675")]
			private (float Time, T Value) <last>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000676")]
			private bool <isFirst>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000677")]
			private IEnumerator<(float Time, T Value)> <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000678")]
			private (float Time, T Value) <item>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			private int <t>5__8;

			[Cpp2IlInjected.Token(Token = "0x17000276")]
			(float, T)[] IEnumerator<(float, T)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000F50")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000277")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000F52")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4C")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public <SplitByTime>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4D")]
			[Cpp2IlInjected.Address(RVA = "0x6DA5860", Offset = "0x6DA4C60", VA = "0x186DA5860", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4E")]
			[Cpp2IlInjected.Address(RVA = "0x6D9D9E0", Offset = "0x6D9CDE0", VA = "0x186D9D9E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4F")]
			[Cpp2IlInjected.Address(RVA = "0x6DA6510", Offset = "0x6DA5910", VA = "0x186DA6510")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F51")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F53")]
			[Cpp2IlInjected.Address(RVA = "0x64B49E0", Offset = "0x64B3DE0", VA = "0x1864B49E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(float, T)[]> IEnumerable<(float, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000F54")]
			[Cpp2IlInjected.Address(RVA = "0x6DA4F00", Offset = "0x6DA4300", VA = "0x186DA4F00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400066B")]
		internal const string StepCurveError = "This is a step curve (MaxDegree = 0), use ToStepCurve(); instead.";

		[Cpp2IlInjected.Token(Token = "0x400066C")]
		internal const string LinearCurveError = "This is a linear curve (MaxDegree = 1), use ToLinearCurve(); instead.";

		[Cpp2IlInjected.Token(Token = "0x400066D")]
		internal const string SplineCurveError = "This is a spline curve (MaxDegree = 3), use ToSplineCurve(); instead.";

		[Cpp2IlInjected.Token(Token = "0x6000F28")]
		[Cpp2IlInjected.Address(RVA = "0xA507770", Offset = "0xA506B70", VA = "0x18A507770")]
		internal static string CurveError(int maxDegree)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F29")]
		[Cpp2IlInjected.Address(RVA = "0xA507350", Offset = "0xA506750", VA = "0x18A507350")]
		public static Vector3 CreateTangent(Vector3 fromValue, Vector3 toValue, float scale = 1f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2A")]
		[Cpp2IlInjected.Address(RVA = "0xA507430", Offset = "0xA506830", VA = "0x18A507430")]
		public static Quaternion CreateTangent(Quaternion fromValue, Quaternion toValue, float scale = 1f)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5075B0", Offset = "0xA5069B0", VA = "0x18A5075B0")]
		public static float[] CreateTangent(float[] fromValue, float[] toValue, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2C")]
		[Cpp2IlInjected.Address(RVA = "0xA505410", Offset = "0xA504810", VA = "0x18A505410")]
		public static (float, float, float, float) CreateHermitePointWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2D")]
		[Cpp2IlInjected.Address(RVA = "0xA5054B0", Offset = "0xA5048B0", VA = "0x18A5054B0")]
		public static (float, float, float, float) CreateHermiteTangentWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2E")]
		[Cpp2IlInjected.Address(RVA = "0x38AF720", Offset = "0x38AEB20", VA = "0x1838AF720")]
		public static (T, T, float) FindRangeContainingOffset<T>(this IEnumerable<(float Key, T Value)> sequence, float offset)
		{
			return default((T, T, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2F")]
		[Cpp2IlInjected.Address(RVA = "0xA507800", Offset = "0xA506C00", VA = "0x18A507800")]
		public static (float, float, float) FindRangeContainingOffset(IEnumerable<float> sequence, float offset)
		{
			return default((float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F30")]
		[Cpp2IlInjected.Address(RVA = "0x3387050", Offset = "0x3386450", VA = "0x183387050")]
		[IteratorStateMachine(typeof(<SplitByTime>d__11<>))]
		internal static IEnumerable<(float, T)[]> SplitByTime<T>(this IEnumerable<(float Time, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F31")]
		[Cpp2IlInjected.Address(RVA = "0xA509130", Offset = "0xA508530", VA = "0x18A509130")]
		public static float[] Subtract(IReadOnlyList<float> left, IReadOnlyList<float> right)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F32")]
		[Cpp2IlInjected.Address(RVA = "0xA508E50", Offset = "0xA508250", VA = "0x18A508E50")]
		public static float[] InterpolateLinear(IReadOnlyList<float> start, IReadOnlyList<float> end, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F33")]
		[Cpp2IlInjected.Address(RVA = "0xA508270", Offset = "0xA507670", VA = "0x18A508270")]
		public static float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F34")]
		[Cpp2IlInjected.Address(RVA = "0xA507D50", Offset = "0xA507150", VA = "0x18A507D50")]
		public static Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F35")]
		[Cpp2IlInjected.Address(RVA = "0xA507F70", Offset = "0xA507370", VA = "0x18A507F70")]
		public static Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F36")]
		[Cpp2IlInjected.Address(RVA = "0xA508390", Offset = "0xA507790", VA = "0x18A508390")]
		public static Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F37")]
		[Cpp2IlInjected.Address(RVA = "0xA508C70", Offset = "0xA508070", VA = "0x18A508C70")]
		public static Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F38")]
		[Cpp2IlInjected.Address(RVA = "0xA5086D0", Offset = "0xA507AD0", VA = "0x18A5086D0")]
		public static float[] InterpolateCubic(IReadOnlyList<float> start, IReadOnlyList<float> outgoingTangent, IReadOnlyList<float> end, IReadOnlyList<float> incomingTangent, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F39")]
		[Cpp2IlInjected.Address(RVA = "0x38BAFF0", Offset = "0x38BA3F0", VA = "0x1838BAFF0")]
		private static bool _HasZero<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3A")]
		[Cpp2IlInjected.Address(RVA = "0x38BAB70", Offset = "0x38B9F70", VA = "0x1838BAB70")]
		private static bool _HasOne<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3B")]
		[Cpp2IlInjected.Address(RVA = "0xA506970", Offset = "0xA505D70", VA = "0x18A506970")]
		public static ICurveSampler<bool> CreateSampler(this IEnumerable<(float, bool)> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3C")]
		[Cpp2IlInjected.Address(RVA = "0xA505D60", Offset = "0xA505160", VA = "0x18A505D60")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, float)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3D")]
		[Cpp2IlInjected.Address(RVA = "0xA5060F0", Offset = "0xA5054F0", VA = "0x18A5060F0")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, Vector2)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3E")]
		[Cpp2IlInjected.Address(RVA = "0xA506740", Offset = "0xA505B40", VA = "0x18A506740")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, Vector3)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3F")]
		[Cpp2IlInjected.Address(RVA = "0xA506AD0", Offset = "0xA505ED0", VA = "0x18A506AD0")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, Vector4)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F40")]
		[Cpp2IlInjected.Address(RVA = "0xA505900", Offset = "0xA504D00", VA = "0x18A505900")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, Quaternion)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F41")]
		[Cpp2IlInjected.Address(RVA = "0xA506D00", Offset = "0xA506100", VA = "0x18A506D00")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, float[])> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F42")]
		[Cpp2IlInjected.Address(RVA = "0xA505570", Offset = "0xA504970", VA = "0x18A505570")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, ArraySegment<float>)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F43")]
		[Cpp2IlInjected.Address(RVA = "0xA505B30", Offset = "0xA504F30", VA = "0x18A505B30")]
		public static ICurveSampler<SparseWeight8> CreateSampler(this IEnumerable<(float, SparseWeight8)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F44")]
		[Cpp2IlInjected.Address(RVA = "0xA506F30", Offset = "0xA506330", VA = "0x18A506F30")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, (float, float, float))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F45")]
		[Cpp2IlInjected.Address(RVA = "0xA5065E0", Offset = "0xA5059E0", VA = "0x18A5065E0")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, (Vector2, Vector2, Vector2))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F46")]
		[Cpp2IlInjected.Address(RVA = "0xA506480", Offset = "0xA505880", VA = "0x18A506480")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, (Vector3, Vector3, Vector3))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F47")]
		[Cpp2IlInjected.Address(RVA = "0xA5071F0", Offset = "0xA5065F0", VA = "0x18A5071F0")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, (Vector4, Vector4, Vector4))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F48")]
		[Cpp2IlInjected.Address(RVA = "0xA507090", Offset = "0xA506490", VA = "0x18A507090")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F49")]
		[Cpp2IlInjected.Address(RVA = "0xA505F90", Offset = "0xA505390", VA = "0x18A505F90")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, (float[], float[], float[]))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4A")]
		[Cpp2IlInjected.Address(RVA = "0xA5057A0", Offset = "0xA504BA0", VA = "0x18A5057A0")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4B")]
		[Cpp2IlInjected.Address(RVA = "0xA506320", Offset = "0xA505720", VA = "0x18A506320")]
		public static ICurveSampler<SparseWeight8> CreateSampler(this IEnumerable<(float, (SparseWeight8, SparseWeight8, SparseWeight8))> collection, bool optimize = false)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	internal readonly struct CubicSampler<T> : ICurveSampler<T>, IConvertibleCurve<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ISamplerTraits<T> _Traits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly IEnumerable<(float Key, (T TangentIn, T Value, T TangentOut))> _Sequence;

		[Cpp2IlInjected.Token(Token = "0x17000278")]
		public int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000F57")]
			[Cpp2IlInjected.Address(RVA = "0xD78F80", Offset = "0xD78380", VA = "0x180D78F80", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F55")]
		[Cpp2IlInjected.Address(RVA = "0x530E440", Offset = "0x530D840", VA = "0x18530E440", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F56")]
		[Cpp2IlInjected.Address(RVA = "0x53138C0", Offset = "0x5312CC0", VA = "0x1853138C0")]
		public CubicSampler(IEnumerable<(float, (T, T, T))> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F58")]
		[Cpp2IlInjected.Address(RVA = "0x53102B0", Offset = "0x530F6B0", VA = "0x1853102B0", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F59")]
		[Cpp2IlInjected.Address(RVA = "0x5310A80", Offset = "0x530FE80", VA = "0x185310A80", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5A")]
		[Cpp2IlInjected.Address(RVA = "0x5310A80", Offset = "0x530FE80", VA = "0x185310A80", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5B")]
		[Cpp2IlInjected.Address(RVA = "0x53123E0", Offset = "0x53117E0", VA = "0x1853123E0", Slot = "9")]
		IReadOnlyDictionary<float, (T, T, T)> IConvertibleCurve<T>.ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5C")]
		[Cpp2IlInjected.Address(RVA = "0x5312F60", Offset = "0x5312360", VA = "0x185312F60")]
		public ICurveSampler<T> ToFastSampler()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	internal readonly struct FixedSampler<T> : ICurveSampler<T>, IConvertibleCurve<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private readonly T _Value;

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		public int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000F6A")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F66")]
		[Cpp2IlInjected.Address(RVA = "0x62D0970", Offset = "0x62CFD70", VA = "0x1862D0970")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F67")]
		[Cpp2IlInjected.Address(RVA = "0x62D0220", Offset = "0x62CF620", VA = "0x1862D0220")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, (T, T, T) Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F68")]
		[Cpp2IlInjected.Address(RVA = "0x62CFD10", Offset = "0x62CF110", VA = "0x1862CFD10", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F69")]
		[Cpp2IlInjected.Address(RVA = "0x12C9430", Offset = "0x12C8830", VA = "0x1812C9430")]
		private FixedSampler(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6B")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6C")]
		[Cpp2IlInjected.Address(RVA = "0x62D1240", Offset = "0x62D0640", VA = "0x1862D1240", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6D")]
		[Cpp2IlInjected.Address(RVA = "0x62D1240", Offset = "0x62D0640", VA = "0x1862D1240", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6E")]
		[Cpp2IlInjected.Address(RVA = "0x62D1D80", Offset = "0x62D1180", VA = "0x1862D1D80", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	internal readonly struct LinearSampler<T> : ICurveSampler<T>, IConvertibleCurve<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ISamplerTraits<T> _Traits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly IEnumerable<(float Key, T Value)> _Sequence;

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		public int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000F71")]
			[Cpp2IlInjected.Address(RVA = "0xD60C60", Offset = "0xD60060", VA = "0x180D60C60", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6F")]
		[Cpp2IlInjected.Address(RVA = "0x69996B0", Offset = "0x6998AB0", VA = "0x1869996B0", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F70")]
		[Cpp2IlInjected.Address(RVA = "0x53138C0", Offset = "0x5312CC0", VA = "0x1853138C0")]
		public LinearSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F72")]
		[Cpp2IlInjected.Address(RVA = "0x699A930", Offset = "0x6999D30", VA = "0x18699A930", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F73")]
		[Cpp2IlInjected.Address(RVA = "0x699E390", Offset = "0x699D790", VA = "0x18699E390", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F74")]
		[Cpp2IlInjected.Address(RVA = "0x699E010", Offset = "0x699D410", VA = "0x18699E010", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F75")]
		[Cpp2IlInjected.Address(RVA = "0x699E390", Offset = "0x699D790", VA = "0x18699E390", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F76")]
		[Cpp2IlInjected.Address(RVA = "0x699C200", Offset = "0x699B600", VA = "0x18699C200")]
		public ICurveSampler<T> ToFastSampler()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	internal readonly struct StepSampler<T> : ICurveSampler<T>, IConvertibleCurve<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ISamplerTraits<T> _Traits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly IEnumerable<(float Key, T Value)> _Sequence;

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		public int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000F82")]
			[Cpp2IlInjected.Address(RVA = "0xCF41A0", Offset = "0xCF35A0", VA = "0x180CF41A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F80")]
		[Cpp2IlInjected.Address(RVA = "0x69996B0", Offset = "0x6998AB0", VA = "0x1869996B0", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F81")]
		[Cpp2IlInjected.Address(RVA = "0x53138C0", Offset = "0x5312CC0", VA = "0x1853138C0")]
		public StepSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F83")]
		[Cpp2IlInjected.Address(RVA = "0x7A58B10", Offset = "0x7A57F10", VA = "0x187A58B10", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F84")]
		[Cpp2IlInjected.Address(RVA = "0x7A59BC0", Offset = "0x7A58FC0", VA = "0x187A59BC0", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F85")]
		[Cpp2IlInjected.Address(RVA = "0x7A59AA0", Offset = "0x7A58EA0", VA = "0x187A59AA0", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F86")]
		[Cpp2IlInjected.Address(RVA = "0x7A59AA0", Offset = "0x7A58EA0", VA = "0x187A59AA0", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F87")]
		[Cpp2IlInjected.Address(RVA = "0x699C200", Offset = "0x699B600", VA = "0x18699C200")]
		public ICurveSampler<T> ToFastSampler()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	internal interface ISamplerTraits<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000F91")]
		[Cpp2IlInjected.Address(Slot = "0")]
		T Clone(T value);

		[Cpp2IlInjected.Token(Token = "0x6000F92")]
		[Cpp2IlInjected.Address(Slot = "1")]
		T InterpolateLinear(T left, T right, float amount);

		[Cpp2IlInjected.Token(Token = "0x6000F93")]
		[Cpp2IlInjected.Address(Slot = "2")]
		T InterpolateCubic(T start, T outgoingTangent, T end, T incomingTangent, float amount);
	}
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	internal static class SamplerTraits
	{
		[Cpp2IlInjected.Token(Token = "0x20001AC")]
		private sealed class _Boolean : ISamplerTraits<bool>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F95")]
			[Cpp2IlInjected.Address(RVA = "0x140F500", Offset = "0x140E900", VA = "0x18140F500", Slot = "4")]
			public bool Clone(bool value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F96")]
			[Cpp2IlInjected.Address(RVA = "0xA513530", Offset = "0xA512930", VA = "0x18A513530", Slot = "5")]
			public bool InterpolateLinear(bool left, bool right, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F97")]
			[Cpp2IlInjected.Address(RVA = "0xA513510", Offset = "0xA512910", VA = "0x18A513510", Slot = "6")]
			public bool InterpolateCubic(bool start, bool outgoingTangent, bool end, bool incomingTangent, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F98")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _Boolean()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		private sealed class _Scalar : ISamplerTraits<float>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F99")]
			[Cpp2IlInjected.Address(RVA = "0xF210A0", Offset = "0xF204A0", VA = "0x180F210A0", Slot = "4")]
			public float Clone(float value)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9A")]
			[Cpp2IlInjected.Address(RVA = "0xA516C20", Offset = "0xA516020", VA = "0x18A516C20", Slot = "5")]
			public float InterpolateLinear(float left, float right, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9B")]
			[Cpp2IlInjected.Address(RVA = "0xA516B10", Offset = "0xA515F10", VA = "0x18A516B10", Slot = "6")]
			public float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9C")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _Scalar()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		private sealed class _Vector2 : ISamplerTraits<Vector2>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F9D")]
			[Cpp2IlInjected.Address(RVA = "0xD59C20", Offset = "0xD59020", VA = "0x180D59C20", Slot = "4")]
			public Vector2 Clone(Vector2 value)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9E")]
			[Cpp2IlInjected.Address(RVA = "0xA516FE0", Offset = "0xA5163E0", VA = "0x18A516FE0", Slot = "5")]
			public Vector2 InterpolateLinear(Vector2 left, Vector2 right, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9F")]
			[Cpp2IlInjected.Address(RVA = "0xA516FA0", Offset = "0xA5163A0", VA = "0x18A516FA0", Slot = "6")]
			public Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA0")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _Vector2()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private sealed class _Vector3 : ISamplerTraits<Vector3>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA1")]
			[Cpp2IlInjected.Address(RVA = "0x1068160", Offset = "0x1067560", VA = "0x181068160", Slot = "4")]
			public Vector3 Clone(Vector3 value)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA2")]
			[Cpp2IlInjected.Address(RVA = "0xA517100", Offset = "0xA516500", VA = "0x18A517100", Slot = "5")]
			public Vector3 InterpolateLinear(Vector3 left, Vector3 right, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA3")]
			[Cpp2IlInjected.Address(RVA = "0xA517040", Offset = "0xA516440", VA = "0x18A517040", Slot = "6")]
			public Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA4")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _Vector3()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B0")]
		private sealed class _Vector4 : ISamplerTraits<Vector4>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA5")]
			[Cpp2IlInjected.Address(RVA = "0x12BDAE0", Offset = "0x12BCEE0", VA = "0x1812BDAE0", Slot = "4")]
			public Vector4 Clone(Vector4 value)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA6")]
			[Cpp2IlInjected.Address(RVA = "0xA517200", Offset = "0xA516600", VA = "0x18A517200", Slot = "5")]
			public Vector4 InterpolateLinear(Vector4 left, Vector4 right, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA7")]
			[Cpp2IlInjected.Address(RVA = "0xA517170", Offset = "0xA516570", VA = "0x18A517170", Slot = "6")]
			public Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA8")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _Vector4()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B1")]
		private sealed class _Quaternion : ISamplerTraits<Quaternion>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA9")]
			[Cpp2IlInjected.Address(RVA = "0x12BDAE0", Offset = "0x12BCEE0", VA = "0x1812BDAE0", Slot = "4")]
			public Quaternion Clone(Quaternion value)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAA")]
			[Cpp2IlInjected.Address(RVA = "0xA516AC0", Offset = "0xA515EC0", VA = "0x18A516AC0", Slot = "5")]
			public Quaternion InterpolateLinear(Quaternion left, Quaternion right, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAB")]
			[Cpp2IlInjected.Address(RVA = "0xA5168F0", Offset = "0xA515CF0", VA = "0x18A5168F0", Slot = "6")]
			public Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAC")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _Quaternion()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		private sealed class _Array : ISamplerTraits<float[]>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FAD")]
			[Cpp2IlInjected.Address(RVA = "0xA513440", Offset = "0xA512840", VA = "0x18A513440", Slot = "4")]
			public float[] Clone(float[] value)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAE")]
			[Cpp2IlInjected.Address(RVA = "0xA5134F0", Offset = "0xA5128F0", VA = "0x18A5134F0", Slot = "5")]
			public float[] InterpolateLinear(float[] left, float[] right, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAF")]
			[Cpp2IlInjected.Address(RVA = "0xA5134C0", Offset = "0xA5128C0", VA = "0x18A5134C0", Slot = "6")]
			public float[] InterpolateCubic(float[] start, float[] outgoingTangent, float[] end, float[] incomingTangent, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB0")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _Array()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		private sealed class _Segment : ISamplerTraits<ArraySegment<float>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB1")]
			[Cpp2IlInjected.Address(RVA = "0xA516C40", Offset = "0xA516040", VA = "0x18A516C40", Slot = "4")]
			public ArraySegment<float> Clone(ArraySegment<float> value)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB2")]
			[Cpp2IlInjected.Address(RVA = "0xA516E00", Offset = "0xA516200", VA = "0x18A516E00", Slot = "5")]
			public ArraySegment<float> InterpolateLinear(ArraySegment<float> left, ArraySegment<float> right, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB3")]
			[Cpp2IlInjected.Address(RVA = "0xA516CE0", Offset = "0xA5160E0", VA = "0x18A516CE0", Slot = "6")]
			public ArraySegment<float> InterpolateCubic(ArraySegment<float> start, ArraySegment<float> outgoingTangent, ArraySegment<float> end, ArraySegment<float> incomingTangent, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB4")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _Segment()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		private sealed class _Sparse : ISamplerTraits<SparseWeight8>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB5")]
			[Cpp2IlInjected.Address(RVA = "0x56A6C50", Offset = "0x56A6050", VA = "0x1856A6C50", Slot = "4")]
			public SparseWeight8 Clone(SparseWeight8 value)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB6")]
			[Cpp2IlInjected.Address(RVA = "0xA516F40", Offset = "0xA516340", VA = "0x18A516F40", Slot = "5")]
			public SparseWeight8 InterpolateLinear(SparseWeight8 left, SparseWeight8 right, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB7")]
			[Cpp2IlInjected.Address(RVA = "0xA516EC0", Offset = "0xA5162C0", VA = "0x18A516EC0", Slot = "6")]
			public SparseWeight8 InterpolateCubic(SparseWeight8 start, SparseWeight8 outgoingTangent, SparseWeight8 end, SparseWeight8 incomingTangent, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB8")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public _Sparse()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public static readonly ISamplerTraits<bool> Boolean;

		[Cpp2IlInjected.Token(Token = "0x4000691")]
		public static readonly ISamplerTraits<float> Scalar;

		[Cpp2IlInjected.Token(Token = "0x4000692")]
		public static readonly ISamplerTraits<Vector2> Vector2;

		[Cpp2IlInjected.Token(Token = "0x4000693")]
		public static readonly ISamplerTraits<Vector3> Vector3;

		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public static readonly ISamplerTraits<Vector4> Vector4;

		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public static readonly ISamplerTraits<Quaternion> Quaternion;

		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public static readonly ISamplerTraits<float[]> Array;

		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public static readonly ISamplerTraits<SparseWeight8> Sparse;

		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public static readonly ISamplerTraits<ArraySegment<float>> Segment;
	}
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	internal readonly struct FastCurveSampler<T> : ICurveSampler<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly ICurveSampler<T>[] _Samplers;

		[Cpp2IlInjected.Token(Token = "0x6000FB9")]
		[Cpp2IlInjected.Address(RVA = "0x37C60C0", Offset = "0x37C54C0", VA = "0x1837C60C0")]
		public static ICurveSampler<T> CreateFrom<TKey>(IEnumerable<(float, TKey)> sequence, Func<(float, TKey)[], ICurveSampler<T>> chunkFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBA")]
		[Cpp2IlInjected.Address(RVA = "0x62855B0", Offset = "0x62849B0", VA = "0x1862855B0")]
		private FastCurveSampler(IEnumerable<ICurveSampler<T>> samplers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBB")]
		[Cpp2IlInjected.Address(RVA = "0x6284F40", Offset = "0x6284340", VA = "0x186284F40", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	public interface ICurveSampler<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000FBE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		T GetPoint(float offset);
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	public interface IConvertibleCurve<T>
	{
		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000FBF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FC0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IConvertibleCurve<T> Clone();

		[Cpp2IlInjected.Token(Token = "0x6000FC1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IReadOnlyDictionary<float, T> ToStepCurve();

		[Cpp2IlInjected.Token(Token = "0x6000FC2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyDictionary<float, T> ToLinearCurve();

		[Cpp2IlInjected.Token(Token = "0x6000FC3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve();
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

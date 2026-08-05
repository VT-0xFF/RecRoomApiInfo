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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53D850", Offset = "0xA53C250", VA = "0x18A53D850")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA53C820", Offset = "0xA53B220", VA = "0x18A53C820")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA53CA90", Offset = "0xA53B490", VA = "0x18A53CA90")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA53CCE0", Offset = "0xA53B6E0", VA = "0x18A53CCE0")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA53C780", Offset = "0xA53B180", VA = "0x18A53C780")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA53D4D0", Offset = "0xA53BED0", VA = "0x18A53D4D0")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA53D3B0", Offset = "0xA53BDB0", VA = "0x18A53D3B0")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA53D9A0", Offset = "0xA53C3A0", VA = "0x18A53D9A0")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA53D940", Offset = "0xA53C340", VA = "0x18A53D940")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA53D1F0", Offset = "0xA53BBF0", VA = "0x18A53D1F0")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8140", Offset = "0x3AD6B40", VA = "0x183AD8140")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6B80", Offset = "0x3AD5580", VA = "0x183AD6B80")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA53D250", Offset = "0xA53BC50", VA = "0x18A53D250")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7BD0", Offset = "0x3AD65D0", VA = "0x183AD7BD0")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7AE0", Offset = "0x3AD64E0", VA = "0x183AD7AE0")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7330", Offset = "0x3AD5D30", VA = "0x183AD7330")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7130", Offset = "0x3AD5B30", VA = "0x183AD7130")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3340", Offset = "0x3AD1D40", VA = "0x183AD3340")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA53CDE0", Offset = "0xA53B7E0", VA = "0x18A53CDE0")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA53CD80", Offset = "0xA53B780", VA = "0x18A53CD80")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA53CE40", Offset = "0xA53B840", VA = "0x18A53CE40")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA53D5F0", Offset = "0xA53BFF0", VA = "0x18A53D5F0")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA53D750", Offset = "0xA53C150", VA = "0x18A53D750")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5EC0", Offset = "0x3AD48C0", VA = "0x183AD5EC0")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA53C4F0", Offset = "0xA53AEF0", VA = "0x18A53C4F0")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5500", Offset = "0x3AD3F00", VA = "0x183AD5500")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5150", Offset = "0x3AD3B50", VA = "0x183AD5150")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5150", Offset = "0x3AD3B50", VA = "0x183AD5150")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5150", Offset = "0x3AD3B50", VA = "0x183AD5150")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5150", Offset = "0x3AD3B50", VA = "0x183AD5150")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AD45D0", Offset = "0x3AD2FD0", VA = "0x183AD45D0")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x67101E0", Offset = "0x670EBE0", VA = "0x1867101E0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x670B580", Offset = "0x6709F80", VA = "0x18670B580", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x6710640", Offset = "0x670F040", VA = "0x186710640")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6F850F0", Offset = "0x6F83AF0", VA = "0x186F850F0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6F80B50", Offset = "0x6F7F550", VA = "0x186F80B50", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x6F855C0", Offset = "0x6F83FC0", VA = "0x186F855C0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x51BF990", Offset = "0x51BE390", VA = "0x1851BF990", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x51BF760", Offset = "0x51BE160", VA = "0x1851BF760", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x51BF410", Offset = "0x51BDE10", VA = "0x1851BF410", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x51BF6B0", Offset = "0x51BE0B0", VA = "0x1851BF6B0", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x66B81E0", Offset = "0x66B6BE0", VA = "0x1866B81E0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x66BB590", Offset = "0x66B9F90", VA = "0x1866BB590", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x4F166D0", Offset = "0x4F150D0", VA = "0x184F166D0")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x670ACC0", Offset = "0x67096C0", VA = "0x18670ACC0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x67091E0", Offset = "0x6707BE0", VA = "0x1867091E0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x670B390", Offset = "0x6709D90", VA = "0x18670B390")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6F7BD30", Offset = "0x6F7A730", VA = "0x186F7BD30", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6F7B140", Offset = "0x6F79B40", VA = "0x186F7B140", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6F7C290", Offset = "0x6F7AC90", VA = "0x186F7C290")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x51B6920", Offset = "0x51B5320", VA = "0x1851B6920", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x51B6680", Offset = "0x51B5080", VA = "0x1851B6680", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x51B6850", Offset = "0x51B5250", VA = "0x1851B6850", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x13E5630", Offset = "0x13E4030", VA = "0x1813E5630", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA54BB70", Offset = "0xA54A570", VA = "0x18A54BB70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x653C0B0", Offset = "0x653AAB0", VA = "0x18653C0B0")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA54BBC0", Offset = "0xA54A5C0", VA = "0x18A54BBC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA54B820", Offset = "0xA54A220", VA = "0x18A54B820", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA54BC80", Offset = "0xA54A680", VA = "0x18A54BC80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA54BB30", Offset = "0xA54A530", VA = "0x18A54BB30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA54BA80", Offset = "0xA54A480", VA = "0x18A54BA80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA54BA80", Offset = "0xA54A480", VA = "0x18A54BA80", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A06E20", Offset = "0x1A05820", VA = "0x181A06E20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA54C660", Offset = "0xA54B060", VA = "0x18A54C660", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA54C6B0", Offset = "0xA54B0B0", VA = "0x18A54C6B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA54BCD0", Offset = "0xA54A6D0", VA = "0x18A54BCD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA54C8A0", Offset = "0xA54B2A0", VA = "0x18A54C8A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA54C8F0", Offset = "0xA54B2F0", VA = "0x18A54C8F0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA54C940", Offset = "0xA54B340", VA = "0x18A54C940")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA54C620", Offset = "0xA54B020", VA = "0x18A54C620", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA54C570", Offset = "0xA54AF70", VA = "0x18A54C570", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA54C570", Offset = "0xA54AF70", VA = "0x18A54C570", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA550800", Offset = "0xA54F200", VA = "0x18A550800")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA5521F0", Offset = "0xA550BF0", VA = "0x18A5521F0")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA552320", Offset = "0xA550D20", VA = "0x18A552320")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA552230", Offset = "0xA550C30", VA = "0x18A552230")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA552350", Offset = "0xA550D50", VA = "0x18A552350")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA552290", Offset = "0xA550C90", VA = "0x18A552290")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA5523C0", Offset = "0xA550DC0", VA = "0x18A5523C0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA552290", Offset = "0xA550C90", VA = "0x18A552290")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA552120", Offset = "0xA550B20", VA = "0x18A552120")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA550930", Offset = "0xA54F330", VA = "0x18A550930")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA550810", Offset = "0xA54F210", VA = "0x18A550810")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA54FBA0", Offset = "0xA54E5A0", VA = "0x18A54FBA0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA5512A0", Offset = "0xA54FCA0", VA = "0x18A5512A0")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA5507B0", Offset = "0xA54F1B0", VA = "0x18A5507B0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA550750", Offset = "0xA54F150", VA = "0x18A550750")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA550A30", Offset = "0xA54F430", VA = "0x18A550A30")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA551DA0", Offset = "0xA5507A0", VA = "0x18A551DA0")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA551F20", Offset = "0xA550920", VA = "0x18A551F20")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA550C10", Offset = "0xA54F610", VA = "0x18A550C10")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA550B20", Offset = "0xA54F520", VA = "0x18A550B20")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA550EE0", Offset = "0xA54F8E0", VA = "0x18A550EE0")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA5505C0", Offset = "0xA54EFC0", VA = "0x18A5505C0")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA5418F0", Offset = "0xA5402F0", VA = "0x18A5418F0")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA551300", Offset = "0xA54FD00", VA = "0x18A551300")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA550BA0", Offset = "0xA54F5A0", VA = "0x18A550BA0")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA550520", Offset = "0xA54EF20", VA = "0x18A550520")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA550460", Offset = "0xA54EE60", VA = "0x18A550460")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4152280", Offset = "0x4150C80", VA = "0x184152280")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA54FD10", Offset = "0xA54E710", VA = "0x18A54FD10")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA54FE80", Offset = "0xA54E880", VA = "0x18A54FE80")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4153630", Offset = "0x4152030", VA = "0x184153630")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4154760", Offset = "0x4153160", VA = "0x184154760")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4154890", Offset = "0x4153290", VA = "0x184154890")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x41547E0", Offset = "0x41531E0", VA = "0x1841547E0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x41522A0", Offset = "0x4150CA0", VA = "0x1841522A0")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4153460", Offset = "0x4151E60", VA = "0x184153460")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4153350", Offset = "0x4151D50", VA = "0x184153350")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4153120", Offset = "0x4151B20", VA = "0x184153120")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4154680", Offset = "0x4153080", VA = "0x184154680")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4153FE0", Offset = "0x41529E0", VA = "0x184153FE0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4154590", Offset = "0x4152F90", VA = "0x184154590")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4154180", Offset = "0x4152B80", VA = "0x184154180")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4152940", Offset = "0x4151340", VA = "0x184152940")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x41526F0", Offset = "0x41510F0", VA = "0x1841526F0")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4151F00", Offset = "0x4150900", VA = "0x184151F00")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4152330", Offset = "0x4150D30", VA = "0x184152330")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA550CE0", Offset = "0xA54F6E0", VA = "0x18A550CE0")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA551040", Offset = "0xA54FA40", VA = "0x18A551040")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x41546E0", Offset = "0x41530E0", VA = "0x1841546E0")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x41546E0", Offset = "0x41530E0", VA = "0x1841546E0")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA551490", Offset = "0xA54FE90", VA = "0x18A551490")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA54FBE0", Offset = "0xA54E5E0", VA = "0x18A54FBE0")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA54FC60", Offset = "0xA54E660", VA = "0x18A54FC60")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA551410", Offset = "0xA54FE10", VA = "0x18A551410")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA551B70", Offset = "0xA550570", VA = "0x18A551B70")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA54FDC0", Offset = "0xA54E7C0", VA = "0x18A54FDC0")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA551AA0", Offset = "0xA5504A0", VA = "0x18A551AA0")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA551690", Offset = "0xA550090", VA = "0x18A551690")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA5501B0", Offset = "0xA54EBB0", VA = "0x18A5501B0")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA54FF80", Offset = "0xA54E980", VA = "0x18A54FF80")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA550250", Offset = "0xA54EC50", VA = "0x18A550250")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA54FF00", Offset = "0xA54E900", VA = "0x18A54FF00")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA5503E0", Offset = "0xA54EDE0", VA = "0x18A5503E0")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x23855B0", Offset = "0x2383FB0", VA = "0x1823855B0")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA552210", Offset = "0xA550C10", VA = "0x18A552210")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4154AE0", Offset = "0x41534E0", VA = "0x184154AE0")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA551350", Offset = "0xA54FD50", VA = "0x18A551350")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA550110", Offset = "0xA54EB10", VA = "0x18A550110")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA551CF0", Offset = "0xA5506F0", VA = "0x18A551CF0")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA552660", Offset = "0xA551060", VA = "0x18A552660")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA551BF0", Offset = "0xA5505F0", VA = "0x18A551BF0")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA54FDB0", Offset = "0xA54E7B0", VA = "0x18A54FDB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9A10", Offset = "0xCD8410", VA = "0x180CD9A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCD9AE0", Offset = "0xCD84E0", VA = "0x180CD9AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string Message
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA543330", Offset = "0xA541D30", VA = "0x18A543330", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private string _Generator
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA543380", Offset = "0xA541D80", VA = "0x18A543380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5432A0", Offset = "0xA541CA0", VA = "0x18A5432A0")]
		internal ModelException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA5431F0", Offset = "0xA541BF0", VA = "0x18A5431F0")]
		internal ModelException(JsonSerializable target, Exception ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA542E50", Offset = "0xA541850", VA = "0x18A542E50")]
		private static string _CreateBaseMessage(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA542FF0", Offset = "0xA5419F0", VA = "0x18A542FF0")]
		internal static void _Decorate(Exception ex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SchemaException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA53C4E0", Offset = "0xA53AEE0", VA = "0x18A53C4E0")]
		internal SchemaException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5431F0", Offset = "0xA541BF0", VA = "0x18A5431F0")]
		internal SchemaException(JsonSerializable target, JsonException rex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class SemanticException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA53C4E0", Offset = "0xA53AEE0", VA = "0x18A53C4E0")]
		internal SemanticException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class LinkException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA53C4E0", Offset = "0xA53AEE0", VA = "0x18A53C4E0")]
		internal LinkException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DataException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA53C4E0", Offset = "0xA53AEE0", VA = "0x18A53C4E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool TryFix
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA54F0A0", Offset = "0xA54DAA0", VA = "0x18A54F0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA54EFC0", Offset = "0xA54D9C0", VA = "0x18A54EFC0")]
		public ValidationContext(ValidationResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA54EF70", Offset = "0xA54D970", VA = "0x18A54EF70")]
		internal ValidationContext(ValidationContext context, JsonSerializable target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA54DD90", Offset = "0xA54C790", VA = "0x18A54DD90")]
		public ValidationContext GetContext(JsonSerializable target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA54EED0", Offset = "0xA54D8D0", VA = "0x18A54EED0")]
		[DebuggerStepThrough]
		internal void _SchemaThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA54E800", Offset = "0xA54D200", VA = "0x18A54E800")]
		public ValidationContext IsTrue(ValueLocation parameterName, bool value, string msg)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA54EB40", Offset = "0xA54D540", VA = "0x18A54EB40")]
		public ValidationContext NotNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA54EA20", Offset = "0xA54D420", VA = "0x18A54EA20")]
		public ValidationContext MustBeNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x40C8500", Offset = "0x40C6F00", VA = "0x1840C8500")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x40C8460", Offset = "0x40C6E60", VA = "0x1840C8460")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x40CA660", Offset = "0x40C9060", VA = "0x1840CA660")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x40CA510", Offset = "0x40C8F10", VA = "0x1840CA510")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x40C72B0", Offset = "0x40C5CB0", VA = "0x1840C72B0")]
		public ValidationContext AreSameReference<TRef>(ValueLocation parameterName, TRef value, TRef expected) where TRef : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x40C71B0", Offset = "0x40C5BB0", VA = "0x1840C71B0")]
		public ValidationContext AreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : IEquatable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x40C99E0", Offset = "0x40C83E0", VA = "0x1840C99E0")]
		public ValidationContext IsLess<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x40C9660", Offset = "0x40C8060", VA = "0x1840C9660")]
		public ValidationContext IsLessOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x40C8CE0", Offset = "0x40C76E0", VA = "0x1840C8CE0")]
		public ValidationContext IsGreater<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x40C7B70", Offset = "0x40C6570", VA = "0x1840C7B70")]
		public ValidationContext IsDefaultOrWithin<TValue>(ValueLocation parameterName, TValue? value, TValue minInclusive, TValue maxInclusive) where TValue : struct, IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x40C8810", Offset = "0x40C7210", VA = "0x1840C8810")]
		public ValidationContext IsGreaterOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA54E1F0", Offset = "0xA54CBF0", VA = "0x18A54E1F0")]
		public ValidationContext IsMultipleOf(ValueLocation parameterName, int value, int multiple)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA54EAB0", Offset = "0xA54D4B0", VA = "0x18A54EAB0")]
		public ValidationContext NonNegative(ValueLocation parameterName, int? value)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA54E5F0", Offset = "0xA54CFF0", VA = "0x18A54E5F0")]
		public ValidationContext IsNullOrValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA54E850", Offset = "0xA54D250", VA = "0x18A54E850")]
		public ValidationContext IsValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA54EE30", Offset = "0xA54D830", VA = "0x18A54EE30")]
		[DebuggerStepThrough]
		internal void _LinkThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x40C7540", Offset = "0x40C5F40", VA = "0x1840C7540")]
		public ValidationContext EnumsAreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : Enum
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x40C9F70", Offset = "0x40C8970", VA = "0x1840C9F70")]
		public ValidationContext IsNullOrIndex<T>(ValueLocation parameterName, int? index, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x40C9B00", Offset = "0x40C8500", VA = "0x1840C9B00")]
		public ValidationContext IsNullOrInRange<T>(ValueLocation parameterName, int? offset, int length, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x40C7970", Offset = "0x40C6370", VA = "0x1840C7970")]
		public ValidationContext IsAnyOf<T>(ValueLocation parameterName, T value, params T[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA54DDF0", Offset = "0xA54C7F0", VA = "0x18A54DDF0")]
		public ValidationContext IsAnyOf(ValueLocation parameterName, AttributeFormat value, params AttributeFormat[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x40CA020", Offset = "0x40C8A20", VA = "0x1840CA020")]
		public ValidationContext IsSetCollection<T>(ValueLocation parameterName, IEnumerable<T> collection) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA54ED90", Offset = "0xA54D790", VA = "0x18A54ED90")]
		[DebuggerStepThrough]
		private void _DataThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x40C9250", Offset = "0x40C7C50", VA = "0x1840C9250")]
		public ValidationContext IsInRange<T>(ValueLocation pname, T value, T minInclusive, T maxInclusive) where T : IComparable<T>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA54E4B0", Offset = "0xA54CEB0", VA = "0x18A54E4B0")]
		public ValidationContext IsNullOrMatrix(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA54E370", Offset = "0xA54CD70", VA = "0x18A54E370")]
		public ValidationContext IsNullOrMatrix4x3(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA54E660", Offset = "0xA54D060", VA = "0x18A54E660")]
		public ValidationContext IsPosition(ValueLocation pname, [In] Vector3 position)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA54E2C0", Offset = "0xA54CCC0", VA = "0x18A54E2C0")]
		public ValidationContext IsNormal(ValueLocation pname, [In] Vector3 normal)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA54E760", Offset = "0xA54D160", VA = "0x18A54E760")]
		public ValidationContext IsRotation(ValueLocation pname, [In] Quaternion rotation)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA54E140", Offset = "0xA54CB40", VA = "0x18A54E140")]
		public ValidationContext IsMatrix(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA54E090", Offset = "0xA54CA90", VA = "0x18A54E090")]
		public ValidationContext IsMatrix4x3(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA54D490", Offset = "0xA54BE90", VA = "0x18A54D490")]
		public ValidationContext ArePositions(ValueLocation pname, IReadOnlyList<Vector3> positions)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA54D120", Offset = "0xA54BB20", VA = "0x18A54D120")]
		public ValidationContext AreNormals(ValueLocation pname, IReadOnlyList<Vector3> normals)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA54DAB0", Offset = "0xA54C4B0", VA = "0x18A54DAB0")]
		public ValidationContext AreTangents(ValueLocation pname, IReadOnlyList<Vector4> tangents)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA54D860", Offset = "0xA54C260", VA = "0x18A54D860")]
		public ValidationContext AreRotations(ValueLocation pname, IReadOnlyList<Quaternion> rotations)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA54CC10", Offset = "0xA54B610", VA = "0x18A54CC10")]
		public ValidationContext AreJoints(ValueLocation pname, IReadOnlyList<Vector4> joints, int skinsMaxJointCount)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA54EBD0", Offset = "0xA54D5D0", VA = "0x18A54EBD0")]
		public ValidationContext That(Action action)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA54ED30", Offset = "0xA54D730", VA = "0x18A54ED30")]
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
		[Cpp2IlInjected.Address(RVA = "0xA54FB00", Offset = "0xA54E500", VA = "0x18A54FB00")]
		public static implicit operator ValueLocation(int index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA54FAA0", Offset = "0xA54E4A0", VA = "0x18A54FAA0")]
		public static implicit operator ValueLocation(int? index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B7B770", Offset = "0x2B7A170", VA = "0x182B7B770")]
		public static implicit operator ValueLocation(string name)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA54FB50", Offset = "0xA54E550", VA = "0x18A54FB50")]
		public static implicit operator ValueLocation((string name, int index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA54FA40", Offset = "0xA54E440", VA = "0x18A54FA40")]
		public static implicit operator ValueLocation((string name, int? index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA54FB90", Offset = "0xA54E590", VA = "0x18A54FB90")]
		public static implicit operator string(ValueLocation location)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8D750", VA = "0x180D8ED50")]
		private ValueLocation(string name, int idx1 = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA54F9C0", Offset = "0xA54E3C0", VA = "0x18A54F9C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA54F950", Offset = "0xA54E350", VA = "0x18A54F950")]
		public string ToString(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA54F820", Offset = "0xA54E220", VA = "0x18A54F820")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ValidationMode Mode
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30")]
			get
			{
				return default(ValidationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IEnumerable<Exception> Errors
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool HasErrors
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xA54F7D0", Offset = "0xA54E1D0", VA = "0x18A54F7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA54F710", Offset = "0xA54E110", VA = "0x18A54F710")]
		public ValidationResult(ModelRoot root, ValidationMode mode, bool instantThrow = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA54F0B0", Offset = "0xA54DAB0", VA = "0x18A54F0B0")]
		public ValidationContext GetContext()
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA54F610", Offset = "0xA54E010", VA = "0x18A54F610")]
		public void SetSchemaError(EndOfStreamException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA54F590", Offset = "0xA54DF90", VA = "0x18A54F590")]
		public void SetSchemaError(ModelRoot model, string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA54F490", Offset = "0xA54DE90", VA = "0x18A54F490")]
		public void SetSchemaError(ModelRoot model, JsonException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA54F370", Offset = "0xA54DD70", VA = "0x18A54F370")]
		public void SetModelError(FormatException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA54F270", Offset = "0xA54DC70", VA = "0x18A54F270")]
		public void SetModelError(ModelRoot model, ArgumentException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA54F1A0", Offset = "0xA54DBA0", VA = "0x18A54F1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA53BD50", Offset = "0xA53A750", VA = "0x18A53BD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA53BD30", Offset = "0xA53A730", VA = "0x18A53BD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IsSRT
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA53BD40", Offset = "0xA53A740", VA = "0x18A53BD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA53C090", Offset = "0xA53AA90", VA = "0x18A53C090")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Quaternion Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA53C020", Offset = "0xA53AA20", VA = "0x18A53C020")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xEA9E80", Offset = "0xEA8880", VA = "0x180EA9E80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA53BFA0", Offset = "0xA53A9A0", VA = "0x18A53BFA0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IsLosslessDecomposable
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA53BC20", Offset = "0xA53A620", VA = "0x18A53BC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IsIdentity
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA53B980", Offset = "0xA53A380", VA = "0x18A53B980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA5383C0", Offset = "0xA536DC0", VA = "0x18A5383C0")]
		internal string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA53C1B0", Offset = "0xA53ABB0", VA = "0x18A53C1B0")]
		public static implicit operator AffineTransform((Quaternion r, Vector3 t) xform)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA53C340", Offset = "0xA53AD40", VA = "0x18A53C340")]
		public static implicit operator AffineTransform(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA53C300", Offset = "0xA53AD00", VA = "0x18A53C300")]
		public static implicit operator AffineTransform(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA537460", Offset = "0xA535E60", VA = "0x18A537460")]
		public static AffineTransform CreateDecomposed(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA5375D0", Offset = "0xA535FD0", VA = "0x18A5375D0")]
		public static AffineTransform CreateFromAny(Matrix4x4? matrix, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA53A330", Offset = "0xA538D30", VA = "0x18A53A330")]
		public AffineTransform WithScale(Vector3 scale)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA539FB0", Offset = "0xA5389B0", VA = "0x18A539FB0")]
		public AffineTransform WithRotation(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA53A6E0", Offset = "0xA5390E0", VA = "0x18A53A6E0")]
		public AffineTransform WithTranslation(Vector3 translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA53B190", Offset = "0xA539B90", VA = "0x18A53B190")]
		public AffineTransform(Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA53B4D0", Offset = "0xA539ED0", VA = "0x18A53B4D0")]
		public AffineTransform(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA53B0C0", Offset = "0xA539AC0", VA = "0x18A53B0C0")]
		public AffineTransform(Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA53B5B0", Offset = "0xA539FB0", VA = "0x18A53B5B0")]
		public AffineTransform(Vector3 scale, Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA53B320", Offset = "0xA539D20", VA = "0x18A53B320")]
		public AffineTransform(Matrix4x4 matrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA537C10", Offset = "0xA536610", VA = "0x18A537C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA5378C0", Offset = "0xA5362C0", VA = "0x18A5378C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA5379C0", Offset = "0xA5363C0", VA = "0x18A5379C0", Slot = "4")]
		public bool Equals(AffineTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA53C100", Offset = "0xA53AB00", VA = "0x18A53C100")]
		public static bool operator ==([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA53C3A0", Offset = "0xA53ADA0", VA = "0x18A53C3A0")]
		public static bool operator !=([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA536C40", Offset = "0xA535640", VA = "0x18A536C40")]
		public static bool AreGeometricallyEquivalent([In] AffineTransform a, [In] AffineTransform b, float tolerance = 1E-05f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA537B50", Offset = "0xA536550", VA = "0x18A537B50")]
		public AffineTransform GetDecomposed()
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA539330", Offset = "0xA537D30", VA = "0x18A539330")]
		public bool TryDecompose([Out] AffineTransform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA5390F0", Offset = "0xA537AF0", VA = "0x18A5390F0")]
		public bool TryDecompose([Out] Vector3 scale, [Out] Quaternion rotation, [Out] Vector3 translation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA536ED0", Offset = "0xA5358D0", VA = "0x18A536ED0")]
		public static AffineTransform Blend(ReadOnlySpan<AffineTransform> transforms, ReadOnlySpan<float> weights)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA53C450", Offset = "0xA53AE50", VA = "0x18A53C450")]
		public static AffineTransform operator *([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA537C40", Offset = "0xA536640", VA = "0x18A537C40")]
		public static AffineTransform Multiply([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA539680", Offset = "0xA538080", VA = "0x18A539680")]
		public static bool TryInvert([In] AffineTransform xform, [Out] AffineTransform inverse)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA538CD0", Offset = "0xA5376D0", VA = "0x18A538CD0")]
		private static Vector3 Transform(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA5388F0", Offset = "0xA5372F0", VA = "0x18A5388F0")]
		public static Vector3 TransformNormal(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA53AFA0", Offset = "0xA5399A0", VA = "0x18A53AFA0")]
		private void _VerifyDefined()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA53AA50", Offset = "0xA539450", VA = "0x18A53AA50")]
		private Matrix4x4 _GetMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA53AED0", Offset = "0xA5398D0", VA = "0x18A53AED0")]
		private Vector3 _GetScale()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA53AE00", Offset = "0xA539800", VA = "0x18A53AE00")]
		private Quaternion _GetRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA536750", Offset = "0xA535150", VA = "0x18A536750")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53F000", Offset = "0xA53DA00", VA = "0x18A53F000")]
		public static implicit operator IndexWeight((int Index, float Weight) pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA53EFB0", Offset = "0xA53D9B0", VA = "0x18A53EFB0")]
		public static implicit operator IndexWeight(KeyValuePair<int, float> pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA53EEE0", Offset = "0xA53D8E0", VA = "0x18A53EEE0")]
		public IndexWeight((int Index, float Weight) pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA53EE70", Offset = "0xA53D870", VA = "0x18A53EE70")]
		public IndexWeight(KeyValuePair<int, float> pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6900C50", Offset = "0x68FF650", VA = "0x186900C50")]
		public IndexWeight(int i, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA53E2C0", Offset = "0xA53CCC0", VA = "0x18A53E2C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA53E200", Offset = "0xA53CC00", VA = "0x18A53E200", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA53E2A0", Offset = "0xA53CCA0", VA = "0x18A53E2A0", Slot = "4")]
		public bool Equals(IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA53EC90", Offset = "0xA53D690", VA = "0x18A53EC90")]
		public bool IsGreaterThan([In] IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA53EF20", Offset = "0xA53D920", VA = "0x18A53EF20")]
		public static IndexWeight operator +(IndexWeight a, IndexWeight b)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA53EF00", Offset = "0xA53D900", VA = "0x18A53EF00")]
		public static IndexWeight operator +(IndexWeight a, float w)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA53ED30", Offset = "0xA53D730", VA = "0x18A53ED30")]
		public static bool IsWellFormed(ReadOnlySpan<IndexWeight> iw, [Out] string err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA53E310", Offset = "0xA53CD10", VA = "0x18A53E310")]
		public static int InsertSorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA53E7E0", Offset = "0xA53D1E0", VA = "0x18A53E7E0")]
		public static int InsertUnsorted(Span<IndexWeight> sparse, [In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA53E5E0", Offset = "0xA53CFE0", VA = "0x18A53E5E0")]
		public static int InsertUnsorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA53DDC0", Offset = "0xA53C7C0", VA = "0x18A53DDC0")]
		public static int CopyTo([In] SparseWeight8 src, Span<int> dstIndices, Span<float> dstWeights, int dstLength)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA53DC20", Offset = "0xA53C620", VA = "0x18A53DC20")]
		public static void BubbleSortByWeight(Span<IndexWeight> pairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA53DB40", Offset = "0xA53C540", VA = "0x18A53DB40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA540A80", Offset = "0xA53F480", VA = "0x18A540A80")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public (double x, double y, double z) Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA540B20", Offset = "0xA53F520", VA = "0x18A540B20")]
			get
			{
				return default((double, double, double));
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA5414D0", Offset = "0xA53FED0", VA = "0x18A5414D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA5409D0", Offset = "0xA53F3D0", VA = "0x18A5409D0")]
		public Matrix4x4Double(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA540910", Offset = "0xA53F310", VA = "0x18A540910")]
		public Matrix4x4Double(Matrix4x4 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA53F8F0", Offset = "0xA53E2F0", VA = "0x18A53F8F0")]
		public static Matrix4x4Double CreateTranslation(double xPosition, double yPosition, double zPosition)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA53F890", Offset = "0xA53E290", VA = "0x18A53F890")]
		public static Matrix4x4Double CreateScale(double xScale, double yScale, double zScale)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA53F700", Offset = "0xA53E100", VA = "0x18A53F700")]
		public static Matrix4x4Double CreateFromQuaternion(Quaternion quaternion)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA540CE0", Offset = "0xA53F6E0", VA = "0x18A540CE0")]
		public static explicit operator Matrix4x4(Matrix4x4Double mat)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA540E90", Offset = "0xA53F890", VA = "0x18A540E90")]
		public static implicit operator Matrix4x4Double(Matrix4x4 mat)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA53FE10", Offset = "0xA53E810", VA = "0x18A53FE10", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA540B90", Offset = "0xA53F590", VA = "0x18A540B90")]
		public static bool operator ==(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA540F70", Offset = "0xA53F970", VA = "0x18A540F70")]
		public static bool operator !=(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA53FC80", Offset = "0xA53E680", VA = "0x18A53FC80", Slot = "4")]
		public readonly bool Equals(Matrix4x4Double other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA53F950", Offset = "0xA53E350", VA = "0x18A53F950", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA540070", Offset = "0xA53EA70", VA = "0x18A540070")]
		public static bool Invert(Matrix4x4Double matrix, [Out] Matrix4x4Double result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA540730", Offset = "0xA53F130", VA = "0x18A540730")]
		public static Matrix4x4Double Multiply(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA5410C0", Offset = "0xA53FAC0", VA = "0x18A5410C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA542A40", Offset = "0xA541440", VA = "0x18A542A40")]
		private static MatrixCheck _Validate([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(MatrixCheck);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA5418F0", Offset = "0xA5402F0", VA = "0x18A5418F0")]
		public static bool IsValid([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA541830", Offset = "0xA540230", VA = "0x18A541830")]
		[DebuggerStepThrough]
		public static void GuardMatrix(string argName, Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA5415D0", Offset = "0xA53FFD0", VA = "0x18A5415D0")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA5414F0", Offset = "0xA53FEF0", VA = "0x18A5414F0")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ, Vector3 translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA541690", Offset = "0xA540090", VA = "0x18A541690")]
		public static Matrix4x4 CreateFrom(Matrix4x4? transform, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA541910", Offset = "0xA540310", VA = "0x18A541910")]
		public static Matrix4x4 LocalToWorld([In] Matrix4x4 parentWorld, [In] Matrix4x4 childLocal)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA542700", Offset = "0xA541100", VA = "0x18A542700")]
		public static Matrix4x4 WorldToLocal([In] Matrix4x4 parentWorld, [In] Matrix4x4 childWorld)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA541C40", Offset = "0xA540640", VA = "0x18A541C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x51CB030", Offset = "0x51C9A30", VA = "0x1851CB030")]
			get
			{
				return default(SparseWeight8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool AbsoluteMorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD7B870", Offset = "0xD7A270", VA = "0x180D7B870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA544480", Offset = "0xA542E80", VA = "0x18A544480")]
		protected MorphTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA5444C0", Offset = "0xA542EC0", VA = "0x18A5444C0")]
		protected MorphTransform(SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA544370", Offset = "0xA542D70", VA = "0x18A544370")]
		public void Update([In] SparseWeight8 morphWeights, bool useAbsoluteMorphTargets = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA543A30", Offset = "0xA542430", VA = "0x18A543A30")]
		protected Vector2 MorphVectors(Vector2 value, IReadOnlyList<Vector2> morphTargets)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA5434A0", Offset = "0xA541EA0", VA = "0x18A5434A0")]
		protected Vector3 MorphVectors(Vector3 value, IReadOnlyList<Vector3> morphTargets)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA543E00", Offset = "0xA542800", VA = "0x18A543E00")]
		protected Vector4 MorphVectors(Vector4 value, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA543450", Offset = "0xA541E50", VA = "0x18A543450", Slot = "5")]
		public Vector4 MorphColors(Vector4 color, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA543490", Offset = "0xA541E90", VA = "0x18A543490", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD05C00", Offset = "0xD04600", VA = "0x180D05C00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x20A9B60", Offset = "0x20A8560", VA = "0x1820A9B60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA545680", Offset = "0xA544080", VA = "0x18A545680")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA545590", Offset = "0xA543F90", VA = "0x18A545590")]
		public RigidTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA5454E0", Offset = "0xA543EE0", VA = "0x18A5454E0")]
		public RigidTransform(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA545430", Offset = "0xA543E30", VA = "0x18A545430")]
		public RigidTransform(Matrix4x4 worldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA545280", Offset = "0xA543C80", VA = "0x18A545280")]
		public void Update(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA544EE0", Offset = "0xA5438E0", VA = "0x18A544EE0")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA544D50", Offset = "0xA543750", VA = "0x18A544D50")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA545080", Offset = "0xA543A80", VA = "0x18A545080")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA544B50", Offset = "0xA543550", VA = "0x18A544B50", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA5449C0", Offset = "0xA5433C0", VA = "0x18A5449C0", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA544D00", Offset = "0xA543700", VA = "0x18A544D00", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public IReadOnlyList<Matrix4x4> SkinMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C10", Offset = "0xCD5610", VA = "0x180CD6C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA544480", Offset = "0xA542E80", VA = "0x18A544480")]
		public SkinnedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA547380", Offset = "0xA545D80", VA = "0x18A547380")]
		public SkinnedTransform(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA547410", Offset = "0xA545E10", VA = "0x18A547410")]
		public SkinnedTransform(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA546FD0", Offset = "0xA5459D0", VA = "0x18A546FD0")]
		public void Update(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA546CC0", Offset = "0xA5456C0", VA = "0x18A546CC0")]
		public void Update(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA546280", Offset = "0xA544C80", VA = "0x18A546280")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA545DE0", Offset = "0xA5447E0", VA = "0x18A545DE0")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA5467F0", Offset = "0xA5451F0", VA = "0x18A5467F0")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA545AB0", Offset = "0xA5444B0", VA = "0x18A545AB0")]
		public static Matrix4x4 CalculateInverseBinding(Matrix4x4 meshWorldTransform, Matrix4x4 jointWorldTransform)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA5456B0", Offset = "0xA5440B0", VA = "0x18A5456B0")]
		public static Matrix4x4Double CalculateInverseBinding(Matrix4x4Double meshWorldTransform, Matrix4x4Double jointWorldTransform)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA545D30", Offset = "0xA544730", VA = "0x18A545D30", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA545CD0", Offset = "0xA5446D0", VA = "0x18A545CD0", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA545D90", Offset = "0xA544790", VA = "0x18A545D90", Slot = "10")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <Evaluate>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA54B710", Offset = "0xA54A110", VA = "0x18A54B710", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA54B370", Offset = "0xA549D70", VA = "0x18A54B370", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA54B7D0", Offset = "0xA54A1D0", VA = "0x18A54B7D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA54B6D0", Offset = "0xA54A0D0", VA = "0x18A54B6D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA54B630", Offset = "0xA54A030", VA = "0x18A54B630", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IGeometryTransform> IEnumerable<IGeometryTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA54B630", Offset = "0xA54A030", VA = "0x18A54B630", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA53F6E0", Offset = "0xA53E0E0", VA = "0x18A53F6E0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IReadOnlyList<Matrix4x4> LocalMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xDB03C0", Offset = "0xDAEDC0", VA = "0x180DB03C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public IReadOnlyList<RigidTransform> WorldTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA53F0A0", Offset = "0xA53DAA0", VA = "0x18A53F0A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA53F450", Offset = "0xA53DE50", VA = "0x18A53F450")]
		public InstancingTransform(AffineTransform[] instances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA53F360", Offset = "0xA53DD60", VA = "0x18A53F360")]
		private RigidTransform[] _CreateTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA53F0A0", Offset = "0xA53DAA0", VA = "0x18A53F0A0")]
		public RigidTransform[] UpdateInstances()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA53F020", Offset = "0xA53DA20", VA = "0x18A53F020")]
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
		[Cpp2IlInjected.Address(RVA = "0xA544510", Offset = "0xA542F10", VA = "0x18A544510")]
		public static Matrix4x4 CreateOrthographicMatrix(float xmag, float ymag, float znear, float zfar)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA544710", Offset = "0xA543110", VA = "0x18A544710")]
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
				[Cpp2IlInjected.Address(RVA = "0xEC8FA0", Offset = "0xEC79A0", VA = "0x180EC8FA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x207A220", Offset = "0x2078C20", VA = "0x18207A220", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x15A6EB0", Offset = "0x15A58B0", VA = "0x1815A6EB0")]
			[DebuggerHidden]
			public <Expand>d__51(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xA55F8A0", Offset = "0xA55E2A0", VA = "0x18A55F8A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA55F9D0", Offset = "0xA55E3D0", VA = "0x18A55F9D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA55F910", Offset = "0xA55E310", VA = "0x18A55F910", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<float> IEnumerable<float>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA55F910", Offset = "0xA55E310", VA = "0x18A55F910", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x13E5630", Offset = "0x13E4030", VA = "0x1813E5630", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5629F0", Offset = "0xA5613F0", VA = "0x18A5629F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x653C0B0", Offset = "0x653AAB0", VA = "0x18653C0B0")]
			[DebuggerHidden]
			public <GetIndexedWeights>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA562650", Offset = "0xA561050", VA = "0x18A562650", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xA5629B0", Offset = "0xA5613B0", VA = "0x18A5629B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xA5628F0", Offset = "0xA5612F0", VA = "0x18A5628F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xA5628F0", Offset = "0xA5612F0", VA = "0x18A5628F0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x13E5630", Offset = "0x13E4030", VA = "0x1813E5630", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA562E30", Offset = "0xA561830", VA = "0x18A562E30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x653C0B0", Offset = "0x653AAB0", VA = "0x18653C0B0")]
			[DebuggerHidden]
			public <GetNonZeroWeights>d__53(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA562A40", Offset = "0xA561440", VA = "0x18A562A40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA562DF0", Offset = "0xA5617F0", VA = "0x18A562DF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA562D30", Offset = "0xA561730", VA = "0x18A562D30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xA562D30", Offset = "0xA561730", VA = "0x18A562D30", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x13E5630", Offset = "0x13E4030", VA = "0x1813E5630", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA569F70", Offset = "0xA568970", VA = "0x18A569F70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x653C0B0", Offset = "0x653AAB0", VA = "0x18653C0B0")]
			[DebuggerHidden]
			public <_GetPairs>d__64(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA569BB0", Offset = "0xA5685B0", VA = "0x18A569BB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA569F30", Offset = "0xA568930", VA = "0x18A569F30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xA569E70", Offset = "0xA568870", VA = "0x18A569E70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IndexWeight> IEnumerable<IndexWeight>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xA569E70", Offset = "0xA568870", VA = "0x18A569E70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54B1C0", Offset = "0xA549BC0", VA = "0x18A54B1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA548C20", Offset = "0xA547620", VA = "0x18A548C20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54B1D0", Offset = "0xA549BD0", VA = "0x18A54B1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float WeightSum
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA54B2C0", Offset = "0xA549CC0", VA = "0x18A54B2C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int MaxIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA54B2B0", Offset = "0xA549CB0", VA = "0x18A54B2B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA54A3D0", Offset = "0xA548DD0", VA = "0x18A54A3D0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5481A0", Offset = "0xA546BA0", VA = "0x18A5481A0")]
		public static SparseWeight8 Create(params float[] weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA548690", Offset = "0xA547090", VA = "0x18A548690")]
		public static SparseWeight8 Create(IEnumerable<float> weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA548160", Offset = "0xA546B60", VA = "0x18A548160")]
		public static SparseWeight8 Create(params (int Index, float Weight)[] indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA5481E0", Offset = "0xA546BE0", VA = "0x18A5481E0")]
		public static SparseWeight8 Create(IEnumerable<(int Index, float Weight)> indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA548590", Offset = "0xA546F90", VA = "0x18A548590")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA547F00", Offset = "0xA546900", VA = "0x18A547F00")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA547E70", Offset = "0xA546870", VA = "0x18A547E70")]
		public static SparseWeight8 CreateUnchecked([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA54B0A0", Offset = "0xA549AA0", VA = "0x18A54B0A0")]
		private SparseWeight8([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA54AFE0", Offset = "0xA5499E0", VA = "0x18A54AFE0")]
		private SparseWeight8(ReadOnlySpan<IndexWeight> iw)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA54B120", Offset = "0xA549B20", VA = "0x18A54B120")]
		private SparseWeight8([In] SparseWeight8 sparse, float scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA548D40", Offset = "0xA547740", VA = "0x18A548D40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA548AB0", Offset = "0xA5474B0", VA = "0x18A548AB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA548B60", Offset = "0xA547560", VA = "0x18A548B60", Slot = "4")]
		public bool Equals(SparseWeight8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA54B2F0", Offset = "0xA549CF0", VA = "0x18A54B2F0")]
		public static bool operator ==(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA54B330", Offset = "0xA549D30", VA = "0x18A54B330")]
		public static bool operator !=(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA547600", Offset = "0xA546000", VA = "0x18A547600")]
		internal static bool AreEqual([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA549DC0", Offset = "0xA5487C0", VA = "0x18A549DC0")]
		public static SparseWeight8 OrderedByWeight([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA549BE0", Offset = "0xA5485E0", VA = "0x18A549BE0")]
		public static SparseWeight8 OrderedByIndex([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5474B0", Offset = "0xA545EB0", VA = "0x18A5474B0")]
		public static SparseWeight8 Add([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA54A190", Offset = "0xA548B90", VA = "0x18A54A190")]
		public static SparseWeight8 Subtract([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA549A90", Offset = "0xA548490", VA = "0x18A549A90")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5499F0", Offset = "0xA5483F0", VA = "0x18A5499F0")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, float y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5498C0", Offset = "0xA5482C0", VA = "0x18A5498C0")]
		public static SparseWeight8 InterpolateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA549780", Offset = "0xA548180", VA = "0x18A549780")]
		public static SparseWeight8 InterpolateCubic([In] SparseWeight8 x, [In] SparseWeight8 xt, [In] SparseWeight8 y, [In] SparseWeight8 yt, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA548B80", Offset = "0xA547580", VA = "0x18A548B80")]
		[IteratorStateMachine(typeof(<Expand>d__51))]
		public IEnumerable<float> Expand(int count)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA548F30", Offset = "0xA547930", VA = "0x18A548F30")]
		[IteratorStateMachine(typeof(<GetIndexedWeights>d__52))]
		public IEnumerable<(int, float)> GetIndexedWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA548FC0", Offset = "0xA5479C0", VA = "0x18A548FC0")]
		[IteratorStateMachine(typeof(<GetNonZeroWeights>d__53))]
		public IEnumerable<(int, float)> GetNonZeroWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA547980", Offset = "0xA546380", VA = "0x18A547980")]
		public static SparseWeight8 Blend(ReadOnlySpan<SparseWeight8> sparses, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA549330", Offset = "0xA547D30", VA = "0x18A549330")]
		public SparseWeight8 GetTrimmed(int maxWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5491E0", Offset = "0xA547BE0", VA = "0x18A5491E0")]
		public SparseWeight8 GetNormalized()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA54A2E0", Offset = "0xA548CE0", VA = "0x18A54A2E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA54AC70", Offset = "0xA549670", VA = "0x18A54AC70")]
		private static SparseWeight8 _OperateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, Func<float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA54A7C0", Offset = "0xA5491C0", VA = "0x18A54A7C0")]
		private static SparseWeight8 _OperateCubic([In] SparseWeight8 x, [In] SparseWeight8 y, [In] SparseWeight8 z, [In] SparseWeight8 w, Func<float, float, float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA548C20", Offset = "0xA547620", VA = "0x18A548C20")]
		private float GetExpandedAt(int idx)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA548C80", Offset = "0xA547680", VA = "0x18A548C80")]
		private int GetExpandedCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA549050", Offset = "0xA547A50", VA = "0x18A549050")]
		internal SparseWeight8 GetNormalizedWithComplement(int complementIndex)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA54A540", Offset = "0xA548F40", VA = "0x18A54A540")]
		internal int _GetMaxIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA54A730", Offset = "0xA549130", VA = "0x18A54A730")]
		[IteratorStateMachine(typeof(<_GetPairs>d__64))]
		internal IEnumerable<IndexWeight> _GetPairs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA549470", Offset = "0xA547E70", VA = "0x18A549470")]
		internal int InsertTo(Span<IndexWeight> dst)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA547BF0", Offset = "0xA5465F0", VA = "0x18A547BF0")]
		internal void CopyTo(Span<IndexWeight> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA547780", Offset = "0xA546180", VA = "0x18A547780")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xA568580", Offset = "0xA566F80", VA = "0x18A568580", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xA568250", Offset = "0xA566C50", VA = "0x18A568250", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA568640", Offset = "0xA567040", VA = "0x18A568640")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xA568540", Offset = "0xA566F40", VA = "0x18A568540", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA5684A0", Offset = "0xA566EA0", VA = "0x18A5684A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xA5684A0", Offset = "0xA566EA0", VA = "0x18A5684A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA56ABE0", Offset = "0xA5695E0", VA = "0x18A56ABE0")]
		internal XmpPackets(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA56A6F0", Offset = "0xA5690F0", VA = "0x18A56A6F0")]
		public int AddPacket(JsonNode packet)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA56A8E0", Offset = "0xA5692E0", VA = "0x18A56A8E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA56A910", Offset = "0xA569310", VA = "0x18A56A910", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__6))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA56AA40", Offset = "0xA569440", VA = "0x18A56AA40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA56A990", Offset = "0xA569390", VA = "0x18A56A990", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA56A840", Offset = "0xA569240", VA = "0x18A56A840", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA5631B0", Offset = "0xA561BB0", VA = "0x18A5631B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA562E80", Offset = "0xA561880", VA = "0x18A562E80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA563270", Offset = "0xA561C70", VA = "0x18A563270")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xA563170", Offset = "0xA561B70", VA = "0x18A563170", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xA5630D0", Offset = "0xA561AD0", VA = "0x18A5630D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xA5630D0", Offset = "0xA561AD0", VA = "0x18A5630D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDD3A0", Offset = "0xCDBDA0", VA = "0x180CDD3A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public JsonNode JsonPacket
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xA56A620", Offset = "0xA569020", VA = "0x18A56A620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA56A5E0", Offset = "0xA568FE0", VA = "0x18A56A5E0")]
		internal XmpPacketReference(ExtraProperties owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA56A4B0", Offset = "0xA568EB0", VA = "0x18A56A4B0")]
		private ModelRoot _FindRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA56A530", Offset = "0xA568F30", VA = "0x18A56A530")]
		private XmpPackets _GetPackets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA56A1A0", Offset = "0xA568BA0", VA = "0x18A56A1A0")]
		public void SetPacket(int logicalIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA56A060", Offset = "0xA568A60", VA = "0x18A56A060", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA56A090", Offset = "0xA568A90", VA = "0x18A56A090", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__11))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA56A310", Offset = "0xA568D10", VA = "0x18A56A310", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA56A110", Offset = "0xA568B10", VA = "0x18A56A110", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA569FC0", Offset = "0xA5689C0", VA = "0x18A569FC0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA5674C0", Offset = "0xA565EC0", VA = "0x18A5674C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA5643B0", Offset = "0xA562DB0", VA = "0x18A5643B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA568020", Offset = "0xA566A20", VA = "0x18A568020")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA566C40", Offset = "0xA565640", VA = "0x18A566C40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA566340", Offset = "0xA564D40", VA = "0x18A566340", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA566340", Offset = "0xA564D40", VA = "0x18A566340", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA5531B0", Offset = "0xA551BB0", VA = "0x18A5531B0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA5531E0", Offset = "0xA551BE0", VA = "0x18A5531E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA553610", Offset = "0xA552010", VA = "0x18A553610", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA553260", Offset = "0xA551C60", VA = "0x18A553260", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA553110", Offset = "0xA551B10", VA = "0x18A553110", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA5537C0", Offset = "0xA5521C0", VA = "0x18A5537C0")]
		public AnimationPointer(AnimationChannelTarget parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA5533D0", Offset = "0xA551DD0", VA = "0x18A5533D0")]
		public static bool TryParseNodeTransform(string pointerPath, [Out] int nodeIndex, [Out] PropertyPath property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA5532C0", Offset = "0xA551CC0", VA = "0x18A5532C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA55FF00", Offset = "0xA55E900", VA = "0x18A55FF00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xA55FA10", Offset = "0xA55E410", VA = "0x18A55FA10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xA55FEC0", Offset = "0xA55E8C0", VA = "0x18A55FEC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xA55FE10", Offset = "0xA55E810", VA = "0x18A55FE10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xA55FE10", Offset = "0xA55E810", VA = "0x18A55FE10", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xA567AC0", Offset = "0xA5664C0", VA = "0x18A567AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xA563640", Offset = "0xA562040", VA = "0x18A563640", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xA567F30", Offset = "0xA566930", VA = "0x18A567F30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xA566EC0", Offset = "0xA5658C0", VA = "0x18A566EC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA566160", Offset = "0xA564B60", VA = "0x18A566160", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA566160", Offset = "0xA564B60", VA = "0x18A566160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5540D0", Offset = "0xA552AD0", VA = "0x18A5540D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA554120", Offset = "0xA552B20", VA = "0x18A554120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float AnisotropyRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA5541A0", Offset = "0xA552BA0", VA = "0x18A5541A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA5541F0", Offset = "0xA552BF0", VA = "0x18A5541F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA5539B0", Offset = "0xA5523B0", VA = "0x18A5539B0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA553AD0", Offset = "0xA5524D0", VA = "0x18A553AD0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA553CA0", Offset = "0xA5526A0", VA = "0x18A553CA0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA553B50", Offset = "0xA552550", VA = "0x18A553B50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA553800", Offset = "0xA552200", VA = "0x18A553800", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA5542A0", Offset = "0xA552CA0", VA = "0x18A5542A0")]
		internal MaterialAnisotropy(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA5539E0", Offset = "0xA5523E0", VA = "0x18A5539E0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA553920", Offset = "0xA552320", VA = "0x18A553920")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA561D50", Offset = "0xA560750", VA = "0x18A561D50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__28(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xA561500", Offset = "0xA55FF00", VA = "0x18A561500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA561D10", Offset = "0xA560710", VA = "0x18A561D10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xA561C60", Offset = "0xA560660", VA = "0x18A561C60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xA561C60", Offset = "0xA560660", VA = "0x18A561C60", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xA567700", Offset = "0xA566100", VA = "0x18A567700", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xA5632C0", Offset = "0xA561CC0", VA = "0x18A5632C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xA5680C0", Offset = "0xA566AC0", VA = "0x18A5680C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA566D00", Offset = "0xA565700", VA = "0x18A566D00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA566200", Offset = "0xA564C00", VA = "0x18A566200", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA566200", Offset = "0xA564C00", VA = "0x18A566200", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA554EC0", Offset = "0xA5538C0", VA = "0x18A554EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA554F10", Offset = "0xA553910", VA = "0x18A554F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA555030", Offset = "0xA553A30", VA = "0x18A555030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xA555080", Offset = "0xA553A80", VA = "0x18A555080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA554550", Offset = "0xA552F50", VA = "0x18A554550", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA5546D0", Offset = "0xA5530D0", VA = "0x18A5546D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA5548F0", Offset = "0xA5532F0", VA = "0x18A5548F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA554750", Offset = "0xA553150", VA = "0x18A554750", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA554320", Offset = "0xA552D20", VA = "0x18A554320", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA5553E0", Offset = "0xA553DE0", VA = "0x18A5553E0")]
		internal MaterialClearCoat(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA554580", Offset = "0xA552F80", VA = "0x18A554580", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA555350", Offset = "0xA553D50", VA = "0x18A555350")]
		private TextureInfo _GetClearCoatTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA5552C0", Offset = "0xA553CC0", VA = "0x18A5552C0")]
		private TextureInfo _GetClearCoatRoughnessTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA555230", Offset = "0xA553C30", VA = "0x18A555230")]
		private MaterialNormalTextureInfo _GetClearCoatNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA5544C0", Offset = "0xA552EC0", VA = "0x18A5544C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA560CA0", Offset = "0xA55F6A0", VA = "0x18A560CA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA560510", Offset = "0xA55EF10", VA = "0x18A560510", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xA560C60", Offset = "0xA55F660", VA = "0x18A560C60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA560B70", Offset = "0xA55F570", VA = "0x18A560B70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA560B70", Offset = "0xA55F570", VA = "0x18A560B70", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xA567400", Offset = "0xA565E00", VA = "0x18A567400", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA565E40", Offset = "0xA564840", VA = "0x18A565E40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xA567E40", Offset = "0xA566840", VA = "0x18A567E40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA566F00", Offset = "0xA565900", VA = "0x18A566F00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA566520", Offset = "0xA564F20", VA = "0x18A566520", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xA566520", Offset = "0xA564F20", VA = "0x18A566520", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA555EE0", Offset = "0xA5548E0", VA = "0x18A555EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA555F30", Offset = "0xA554930", VA = "0x18A555F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 DiffuseTransmissionColorFactor
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xA556020", Offset = "0xA554A20", VA = "0x18A556020")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xA5560E0", Offset = "0xA554AE0", VA = "0x18A5560E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA555660", Offset = "0xA554060", VA = "0x18A555660", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA555780", Offset = "0xA554180", VA = "0x18A555780", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xA5559C0", Offset = "0xA5543C0", VA = "0x18A5559C0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xA555800", Offset = "0xA554200", VA = "0x18A555800", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA555460", Offset = "0xA553E60", VA = "0x18A555460", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA5561E0", Offset = "0xA554BE0", VA = "0x18A5561E0")]
		internal MaterialDiffuseTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA555690", Offset = "0xA554090", VA = "0x18A555690", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5555D0", Offset = "0xA553FD0", VA = "0x18A5555D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xA567C40", Offset = "0xA566640", VA = "0x18A567C40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xA563B90", Offset = "0xA562590", VA = "0x18A563B90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xA567EE0", Offset = "0xA5668E0", VA = "0x18A567EE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA566F40", Offset = "0xA565940", VA = "0x18A566F40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA5667A0", Offset = "0xA5651A0", VA = "0x18A5667A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA5667A0", Offset = "0xA5651A0", VA = "0x18A5667A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD26890", Offset = "0xD25290", VA = "0x180D26890")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA556790", Offset = "0xA555190", VA = "0x18A556790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA5567E0", Offset = "0xA5551E0", VA = "0x18A5567E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA556350", Offset = "0xA554D50", VA = "0x18A556350", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA556450", Offset = "0xA554E50", VA = "0x18A556450", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA556590", Offset = "0xA554F90", VA = "0x18A556590", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5564D0", Offset = "0xA554ED0", VA = "0x18A5564D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5562B0", Offset = "0xA554CB0", VA = "0x18A5562B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA556730", Offset = "0xA555130", VA = "0x18A556730")]
		internal MaterialDispersion(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA556380", Offset = "0xA554D80", VA = "0x18A556380", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xA567940", Offset = "0xA566340", VA = "0x18A567940", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xA564AF0", Offset = "0xA5634F0", VA = "0x18A564AF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xA567DF0", Offset = "0xA5667F0", VA = "0x18A567DF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xA566F80", Offset = "0xA565980", VA = "0x18A566F80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xA5663E0", Offset = "0xA564DE0", VA = "0x18A5663E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA5663E0", Offset = "0xA564DE0", VA = "0x18A5663E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA557470", Offset = "0xA555E70", VA = "0x18A557470")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xA557480", Offset = "0xA555E80", VA = "0x18A557480")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xA5574D0", Offset = "0xA555ED0", VA = "0x18A5574D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA557000", Offset = "0xA555A00", VA = "0x18A557000", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA557130", Offset = "0xA555B30", VA = "0x18A557130", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA557270", Offset = "0xA555C70", VA = "0x18A557270", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5571B0", Offset = "0xA555BB0", VA = "0x18A5571B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA556F60", Offset = "0xA555960", VA = "0x18A556F60", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA557410", Offset = "0xA555E10", VA = "0x18A557410")]
		internal MaterialIOR(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA557030", Offset = "0xA555A30", VA = "0x18A557030", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5625F0", Offset = "0xA560FF0", VA = "0x18A5625F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__35(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA561DB0", Offset = "0xA5607B0", VA = "0x18A561DB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA5625B0", Offset = "0xA560FB0", VA = "0x18A5625B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA562500", Offset = "0xA560F00", VA = "0x18A562500", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA562500", Offset = "0xA560F00", VA = "0x18A562500", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xA5677C0", Offset = "0xA5661C0", VA = "0x18A5677C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0xA565A70", Offset = "0xA564470", VA = "0x18A565A70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xA567D00", Offset = "0xA566700", VA = "0x18A567D00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xA566E80", Offset = "0xA565880", VA = "0x18A566E80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xA566980", Offset = "0xA565380", VA = "0x18A566980", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xA566980", Offset = "0xA565380", VA = "0x18A566980", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA558430", Offset = "0xA556E30", VA = "0x18A558430")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA558480", Offset = "0xA556E80", VA = "0x18A558480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float IridescenceIndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xA558500", Offset = "0xA556F00", VA = "0x18A558500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xA558560", Offset = "0xA556F60", VA = "0x18A558560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float IridescenceThicknessMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xA558650", Offset = "0xA557050", VA = "0x18A558650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xA5586B0", Offset = "0xA5570B0", VA = "0x18A5586B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float IridescenceThicknessMaximum
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xA5582E0", Offset = "0xA556CE0", VA = "0x18A5582E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xA558340", Offset = "0xA556D40", VA = "0x18A558340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA557770", Offset = "0xA556170", VA = "0x18A557770", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5579D0", Offset = "0xA5563D0", VA = "0x18A5579D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA557C80", Offset = "0xA556680", VA = "0x18A557C80", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA557A50", Offset = "0xA556450", VA = "0x18A557A50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA557540", Offset = "0xA555F40", VA = "0x18A557540", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA558730", Offset = "0xA557130", VA = "0x18A558730")]
		internal MaterialIridescence(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA5577A0", Offset = "0xA5561A0", VA = "0x18A5577A0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA5576E0", Offset = "0xA5560E0", VA = "0x18A5576E0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xA567100", Offset = "0xA565B00", VA = "0x18A567100", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xA563940", Offset = "0xA562340", VA = "0x18A563940", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xA567FD0", Offset = "0xA5669D0", VA = "0x18A567FD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA566D80", Offset = "0xA565780", VA = "0x18A566D80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xA566AC0", Offset = "0xA5654C0", VA = "0x18A566AC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA566AC0", Offset = "0xA5654C0", VA = "0x18A566AC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA556E90", Offset = "0xA555890", VA = "0x18A556E90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xA556EE0", Offset = "0xA5558E0", VA = "0x18A556EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA556A50", Offset = "0xA555450", VA = "0x18A556A50", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA556B50", Offset = "0xA555550", VA = "0x18A556B50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA556C90", Offset = "0xA555690", VA = "0x18A556C90", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA556BD0", Offset = "0xA5555D0", VA = "0x18A556BD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA556870", Offset = "0xA555270", VA = "0x18A556870", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA556E30", Offset = "0xA555830", VA = "0x18A556E30")]
		internal MaterialEmissiveStrength(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA556A80", Offset = "0xA555480", VA = "0x18A556A80", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA556910", Offset = "0xA555310", VA = "0x18A556910")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5614A0", Offset = "0xA55FEA0", VA = "0x18A5614A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA560D60", Offset = "0xA55F760", VA = "0x18A560D60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA561460", Offset = "0xA55FE60", VA = "0x18A561460", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xA5613B0", Offset = "0xA55FDB0", VA = "0x18A5613B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA5613B0", Offset = "0xA55FDB0", VA = "0x18A5613B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA567A00", Offset = "0xA566400", VA = "0x18A567A00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA564D40", Offset = "0xA563740", VA = "0x18A564D40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA567D50", Offset = "0xA566750", VA = "0x18A567D50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA566CC0", Offset = "0xA5656C0", VA = "0x18A566CC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA5668E0", Offset = "0xA5652E0", VA = "0x18A5668E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA5668E0", Offset = "0xA5652E0", VA = "0x18A5668E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA55B670", Offset = "0xA55A070", VA = "0x18A55B670")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA55B6C0", Offset = "0xA55A0C0", VA = "0x18A55B6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 AttenuationColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA55B740", Offset = "0xA55A140", VA = "0x18A55B740")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0xA55B800", Offset = "0xA55A200", VA = "0x18A55B800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float AttenuationDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA55B8B0", Offset = "0xA55A2B0", VA = "0x18A55B8B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xA55B910", Offset = "0xA55A310", VA = "0x18A55B910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA55ACB0", Offset = "0xA5596B0", VA = "0x18A55ACB0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA55AED0", Offset = "0xA5598D0", VA = "0x18A55AED0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA55B130", Offset = "0xA559B30", VA = "0x18A55B130", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA55AF50", Offset = "0xA559950", VA = "0x18A55AF50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA55AAB0", Offset = "0xA5594B0", VA = "0x18A55AAB0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA55B9D0", Offset = "0xA55A3D0", VA = "0x18A55B9D0")]
		internal MaterialVolume(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA55ACE0", Offset = "0xA5596E0", VA = "0x18A55ACE0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA55AC20", Offset = "0xA559620", VA = "0x18A55AC20")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xA567880", Offset = "0xA566280", VA = "0x18A567880", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xA563DE0", Offset = "0xA5627E0", VA = "0x18A563DE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xA567DA0", Offset = "0xA5667A0", VA = "0x18A567DA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA566C00", Offset = "0xA565600", VA = "0x18A566C00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xA5665C0", Offset = "0xA564FC0", VA = "0x18A5665C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xA5665C0", Offset = "0xA564FC0", VA = "0x18A5665C0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x5BFC650", Offset = "0x5BFB050", VA = "0x185BFC650", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA569B50", Offset = "0xA568550", VA = "0x18A569B50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x653C080", Offset = "0x653AA80", VA = "0x18653C080")]
			[DebuggerHidden]
			public <_GetLocalTransforms>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA5699B0", Offset = "0xA5683B0", VA = "0x18A5699B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA569B10", Offset = "0xA568510", VA = "0x18A569B10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xA569A70", Offset = "0xA568470", VA = "0x18A569A70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<AffineTransform> IEnumerable<AffineTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xA569A70", Offset = "0xA568470", VA = "0x18A569A70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Node VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xA55CB20", Offset = "0xA55B520", VA = "0x18A55CB20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IReadOnlyDictionary<string, Accessor> Accessors
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0xA55C850", Offset = "0xA55B250", VA = "0x18A55C850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public IEnumerable<AffineTransform> LocalTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xA55CA10", Offset = "0xA55B410", VA = "0x18A55CA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA55C0C0", Offset = "0xA55AAC0", VA = "0x18A55C0C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA55C310", Offset = "0xA55AD10", VA = "0x18A55C310", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA55C5D0", Offset = "0xA55AFD0", VA = "0x18A55C5D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA55C390", Offset = "0xA55AD90", VA = "0x18A55C390", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA55BAF0", Offset = "0xA55A4F0", VA = "0x18A55BAF0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA55CA90", Offset = "0xA55B490", VA = "0x18A55CA90")]
		internal MeshGpuInstancing(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA55C920", Offset = "0xA55B320", VA = "0x18A55C920")]
		private int _GetCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA55C850", Offset = "0xA55B250", VA = "0x18A55C850")]
		private IReadOnlyDictionary<string, Accessor> _GetAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA55CA10", Offset = "0xA55B410", VA = "0x18A55CA10")]
		[IteratorStateMachine(typeof(<_GetLocalTransforms>d__21))]
		private IEnumerable<AffineTransform> _GetLocalTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA55BAA0", Offset = "0xA55A4A0", VA = "0x18A55BAA0")]
		public void ClearAccessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA55BB90", Offset = "0xA55A590", VA = "0x18A55BB90")]
		public Accessor GetAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA55C400", Offset = "0xA55AE00", VA = "0x18A55C400")]
		public void SetAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA55BD70", Offset = "0xA55A770", VA = "0x18A55BD70")]
		public AffineTransform GetLocalTransform(int index)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA55BC90", Offset = "0xA55A690", VA = "0x18A55BC90")]
		public Matrix4x4 GetLocalMatrix(int index)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA55C0F0", Offset = "0xA55AAF0", VA = "0x18A55C0F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xA5671C0", Offset = "0xA565BC0", VA = "0x18A5671C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xA564600", Offset = "0xA563000", VA = "0x18A564600", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xA568200", Offset = "0xA566C00", VA = "0x18A568200")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xA566FC0", Offset = "0xA5659C0", VA = "0x18A566FC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xA566B60", Offset = "0xA565560", VA = "0x18A566B60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xA566B60", Offset = "0xA565560", VA = "0x18A566B60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA55D400", Offset = "0xA55BE00", VA = "0x18A55D400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA55D4B0", Offset = "0xA55BEB0", VA = "0x18A55D4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA55D450", Offset = "0xA55BE50", VA = "0x18A55D450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA55D5D0", Offset = "0xA55BFD0", VA = "0x18A55D5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA55CC00", Offset = "0xA55B600", VA = "0x18A55CC00", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA55CF20", Offset = "0xA55B920", VA = "0x18A55CF20", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA55D0C0", Offset = "0xA55BAC0", VA = "0x18A55D0C0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA55CFA0", Offset = "0xA55B9A0", VA = "0x18A55CFA0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA55CB30", Offset = "0xA55B530", VA = "0x18A55CB30", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA55CC30", Offset = "0xA55B630", VA = "0x18A55CC30", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA55D370", Offset = "0xA55BD70", VA = "0x18A55D370")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xA567280", Offset = "0xA565C80", VA = "0x18A567280", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA564030", Offset = "0xA562A30", VA = "0x18A564030", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xA567F80", Offset = "0xA566980", VA = "0x18A567F80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xA566E00", Offset = "0xA565800", VA = "0x18A566E00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xA566A20", Offset = "0xA565420", VA = "0x18A566A20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xA566A20", Offset = "0xA565420", VA = "0x18A566A20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA55EF10", Offset = "0xA55D910", VA = "0x18A55EF10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public PunctualLightType LightType
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xA55EE30", Offset = "0xA55D830", VA = "0x18A55EE30")]
			get
			{
				return default(PunctualLightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public float InnerConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xA55ED70", Offset = "0xA55D770", VA = "0x18A55ED70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xA55EFB0", Offset = "0xA55D9B0", VA = "0x18A55EFB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xA55ECB0", Offset = "0xA55D6B0", VA = "0x18A55ECB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA55F070", Offset = "0xA55DA70", VA = "0x18A55F070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xA55EDD0", Offset = "0xA55D7D0", VA = "0x18A55EDD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xA55F190", Offset = "0xA55DB90", VA = "0x18A55F190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float Range
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xA55F010", Offset = "0xA55DA10", VA = "0x18A55F010")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0xA55F210", Offset = "0xA55DC10", VA = "0x18A55F210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA55D8B0", Offset = "0xA55C2B0", VA = "0x18A55D8B0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA55DBA0", Offset = "0xA55C5A0", VA = "0x18A55DBA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA55E3C0", Offset = "0xA55CDC0", VA = "0x18A55E3C0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA55DC20", Offset = "0xA55C620", VA = "0x18A55DC20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA55D6F0", Offset = "0xA55C0F0", VA = "0x18A55D6F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA55EBD0", Offset = "0xA55D5D0", VA = "0x18A55EBD0")]
		internal PunctualLight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA55E9E0", Offset = "0xA55D3E0", VA = "0x18A55E9E0")]
		internal PunctualLight(PunctualLightType ltype)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA55E070", Offset = "0xA55CA70", VA = "0x18A55E070")]
		public void SetSpotCone(float innerConeAngle, float outerConeAngle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA55DE20", Offset = "0xA55C820", VA = "0x18A55DE20")]
		public void SetColor(Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA55D9B0", Offset = "0xA55C3B0", VA = "0x18A55D9B0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA55D8E0", Offset = "0xA55C2E0", VA = "0x18A55D8E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xA567B80", Offset = "0xA566580", VA = "0x18A567B80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xA5648A0", Offset = "0xA5632A0", VA = "0x18A5648A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xA568160", Offset = "0xA566B60", VA = "0x18A568160")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xA566D40", Offset = "0xA565740", VA = "0x18A566D40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xA5662A0", Offset = "0xA564CA0", VA = "0x18A5662A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xA5662A0", Offset = "0xA564CA0", VA = "0x18A5662A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA56ADB0", Offset = "0xA5697B0", VA = "0x18A56ADB0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA56ADE0", Offset = "0xA5697E0", VA = "0x18A56ADE0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA56AF10", Offset = "0xA569910", VA = "0x18A56AF10", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA56AE60", Offset = "0xA569860", VA = "0x18A56AE60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA56AD10", Offset = "0xA569710", VA = "0x18A56AD10", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA56B0B0", Offset = "0xA569AB0", VA = "0x18A56B0B0")]
		internal _ModelPunctualLights(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA56AC60", Offset = "0xA569660", VA = "0x18A56AC60")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA567640", Offset = "0xA566040", VA = "0x18A567640", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA565820", Offset = "0xA564220", VA = "0x18A565820", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA568110", Offset = "0xA566B10", VA = "0x18A568110")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA566C80", Offset = "0xA565680", VA = "0x18A566C80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA566840", Offset = "0xA565240", VA = "0x18A566840", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA566840", Offset = "0xA565240", VA = "0x18A566840", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA55F650", Offset = "0xA55E050", VA = "0x18A55F650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xA55F760", Offset = "0xA55E160", VA = "0x18A55F760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA55F390", Offset = "0xA55DD90", VA = "0x18A55F390", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA55F3C0", Offset = "0xA55DDC0", VA = "0x18A55F3C0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA55F4B0", Offset = "0xA55DEB0", VA = "0x18A55F4B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA55F440", Offset = "0xA55DE40", VA = "0x18A55F440", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA55F2F0", Offset = "0xA55DCF0", VA = "0x18A55F2F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5537C0", Offset = "0xA5521C0", VA = "0x18A5537C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA567040", Offset = "0xA565A40", VA = "0x18A567040", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA5655D0", Offset = "0xA563FD0", VA = "0x18A5655D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xA5681B0", Offset = "0xA566BB0", VA = "0x18A5681B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA566DC0", Offset = "0xA5657C0", VA = "0x18A566DC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA566480", Offset = "0xA564E80", VA = "0x18A566480", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA566480", Offset = "0xA564E80", VA = "0x18A566480", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xD29750", Offset = "0xD28150", VA = "0x180D29750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xA56B1E0", Offset = "0xA569BE0", VA = "0x18A56B1E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xA56B210", Offset = "0xA569C10", VA = "0x18A56B210", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xA56B320", Offset = "0xA569D20", VA = "0x18A56B320", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xA56B290", Offset = "0xA569C90", VA = "0x18A56B290", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xA56B140", Offset = "0xA569B40", VA = "0x18A56B140", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xA56B4C0", Offset = "0xA569EC0", VA = "0x18A56B4C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA567580", Offset = "0xA565F80", VA = "0x18A567580", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA565380", Offset = "0xA563D80", VA = "0x18A565380", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA568070", Offset = "0xA566A70", VA = "0x18A568070")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA567000", Offset = "0xA565A00", VA = "0x18A567000", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA566700", Offset = "0xA565100", VA = "0x18A566700", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA566700", Offset = "0xA565100", VA = "0x18A566700", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA56B980", Offset = "0xA56A380", VA = "0x18A56B980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xA56BA00", Offset = "0xA56A400", VA = "0x18A56BA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA56B570", Offset = "0xA569F70", VA = "0x18A56B570", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xA56B5A0", Offset = "0xA569FA0", VA = "0x18A56B5A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA56B6F0", Offset = "0xA56A0F0", VA = "0x18A56B6F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xA56B620", Offset = "0xA56A020", VA = "0x18A56B620", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xA56B4D0", Offset = "0xA569ED0", VA = "0x18A56B4D0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xA56B8D0", Offset = "0xA56A2D0", VA = "0x18A56B8D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA560D00", Offset = "0xA55F700", VA = "0x18A560D00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xA55FF60", Offset = "0xA55E960", VA = "0x18A55FF60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA560C20", Offset = "0xA55F620", VA = "0x18A560C20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA560AC0", Offset = "0xA55F4C0", VA = "0x18A560AC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA560AC0", Offset = "0xA55F4C0", VA = "0x18A560AC0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xA567340", Offset = "0xA565D40", VA = "0x18A567340", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA565060", Offset = "0xA563A60", VA = "0x18A565060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA567E90", Offset = "0xA566890", VA = "0x18A567E90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xA566E40", Offset = "0xA565840", VA = "0x18A566E40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xA566660", Offset = "0xA565060", VA = "0x18A566660", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xA566660", Offset = "0xA565060", VA = "0x18A566660", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA55A6D0", Offset = "0xA5590D0", VA = "0x18A55A6D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA55A790", Offset = "0xA559190", VA = "0x18A55A790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public float SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xA55A8B0", Offset = "0xA5592B0", VA = "0x18A55A8B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xA55A910", Offset = "0xA559310", VA = "0x18A55A910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xA559D40", Offset = "0xA558740", VA = "0x18A559D40", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xA559F60", Offset = "0xA558960", VA = "0x18A559F60", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA55A1B0", Offset = "0xA558BB0", VA = "0x18A55A1B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA559FE0", Offset = "0xA5589E0", VA = "0x18A559FE0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xA559B40", Offset = "0xA558540", VA = "0x18A559B40", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xA55A9D0", Offset = "0xA5593D0", VA = "0x18A55A9D0")]
		internal MaterialSpecular(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA559D70", Offset = "0xA558770", VA = "0x18A559D70", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA559CB0", Offset = "0xA5586B0", VA = "0x18A559CB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA583C50", Offset = "0xA582650", VA = "0x18A583C50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xA583430", Offset = "0xA581E30", VA = "0x18A583430", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA583C10", Offset = "0xA582610", VA = "0x18A583C10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xA583B60", Offset = "0xA582560", VA = "0x18A583B60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xA583B60", Offset = "0xA582560", VA = "0x18A583B60", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xA587120", Offset = "0xA585B20", VA = "0x18A587120", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xA5840F0", Offset = "0xA582AF0", VA = "0x18A5840F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xA587E20", Offset = "0xA586820", VA = "0x18A587E20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xA5870A0", Offset = "0xA585AA0", VA = "0x18A5870A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xA5868A0", Offset = "0xA5852A0", VA = "0x18A5868A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xA5868A0", Offset = "0xA5852A0", VA = "0x18A5868A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA559580", Offset = "0xA557F80", VA = "0x18A559580")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA559640", Offset = "0xA558040", VA = "0x18A559640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA559760", Offset = "0xA558160", VA = "0x18A559760")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA559820", Offset = "0xA558220", VA = "0x18A559820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public float GlossinessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA5598D0", Offset = "0xA5582D0", VA = "0x18A5598D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xA559930", Offset = "0xA558330", VA = "0x18A559930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xA558A60", Offset = "0xA557460", VA = "0x18A558A60", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xA558C80", Offset = "0xA557680", VA = "0x18A558C80", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA558F50", Offset = "0xA557950", VA = "0x18A558F50", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xA558D00", Offset = "0xA557700", VA = "0x18A558D00", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xA558810", Offset = "0xA557210", VA = "0x18A558810", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA559A10", Offset = "0xA558410", VA = "0x18A559A10")]
		internal MaterialPBRSpecularGlossiness(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA558A90", Offset = "0xA557490", VA = "0x18A558A90", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA5589D0", Offset = "0xA5573D0", VA = "0x18A5589D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5833D0", Offset = "0xA581DD0", VA = "0x18A5833D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xA582D30", Offset = "0xA581730", VA = "0x18A582D30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xA583390", Offset = "0xA581D90", VA = "0x18A583390", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xA5832E0", Offset = "0xA581CE0", VA = "0x18A5832E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xA5832E0", Offset = "0xA581CE0", VA = "0x18A5832E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xA587660", Offset = "0xA586060", VA = "0x18A587660", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xA584C50", Offset = "0xA583650", VA = "0x18A584C50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xA587BF0", Offset = "0xA5865F0", VA = "0x18A587BF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xA586DA0", Offset = "0xA5857A0", VA = "0x18A586DA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xA5869E0", Offset = "0xA5853E0", VA = "0x18A5869E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xA5869E0", Offset = "0xA5853E0", VA = "0x18A5869E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA580000", Offset = "0xA57EA00", VA = "0x18A580000")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xA5800C0", Offset = "0xA57EAC0", VA = "0x18A5800C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xA5801E0", Offset = "0xA57EBE0", VA = "0x18A5801E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xA580220", Offset = "0xA57EC20", VA = "0x18A580220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xA57F680", Offset = "0xA57E080", VA = "0x18A57F680", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xA57F8A0", Offset = "0xA57E2A0", VA = "0x18A57F8A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA57FAE0", Offset = "0xA57E4E0", VA = "0x18A57FAE0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA57F920", Offset = "0xA57E320", VA = "0x18A57F920", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA57F480", Offset = "0xA57DE80", VA = "0x18A57F480", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA5802C0", Offset = "0xA57ECC0", VA = "0x18A5802C0")]
		internal MaterialSheen(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xA57F6B0", Offset = "0xA57E0B0", VA = "0x18A57F6B0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xA57F5F0", Offset = "0xA57DFF0", VA = "0x18A57F5F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xA587720", Offset = "0xA586120", VA = "0x18A587720", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xA583CB0", Offset = "0xA5826B0", VA = "0x18A583CB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xA587CE0", Offset = "0xA5866E0", VA = "0x18A587CE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xA586E20", Offset = "0xA585820", VA = "0x18A586E20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xA5866C0", Offset = "0xA5850C0", VA = "0x18A5866C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xA5866C0", Offset = "0xA5850C0", VA = "0x18A5866C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA581070", Offset = "0xA57FA70", VA = "0x18A581070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xA581110", Offset = "0xA57FB10", VA = "0x18A581110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA580DB0", Offset = "0xA57F7B0", VA = "0x18A580DB0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA580DE0", Offset = "0xA57F7E0", VA = "0x18A580DE0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA580ED0", Offset = "0xA57F8D0", VA = "0x18A580ED0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA580E60", Offset = "0xA57F860", VA = "0x18A580E60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA580D10", Offset = "0xA57F710", VA = "0x18A580D10", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5537C0", Offset = "0xA5521C0", VA = "0x18A5537C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0xA5877E0", Offset = "0xA5861E0", VA = "0x18A5877E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0xA5851C0", Offset = "0xA583BC0", VA = "0x18A5851C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xA587DD0", Offset = "0xA5867D0", VA = "0x18A587DD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0xA586DE0", Offset = "0xA5857E0", VA = "0x18A586DE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0xA586580", Offset = "0xA584F80", VA = "0x18A586580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0xA586580", Offset = "0xA584F80", VA = "0x18A586580", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA582010", Offset = "0xA580A10", VA = "0x18A582010")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xA5821A0", Offset = "0xA580BA0", VA = "0x18A5821A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xA582100", Offset = "0xA580B00", VA = "0x18A582100")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xA5822B0", Offset = "0xA580CB0", VA = "0x18A5822B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xA5820B0", Offset = "0xA580AB0", VA = "0x18A5820B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xA582250", Offset = "0xA580C50", VA = "0x18A582250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public int? TextureCoordinateOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A77AA0", Offset = "0x8A764A0", VA = "0x188A77AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xA582360", Offset = "0xA580D60", VA = "0x18A582360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xA581CF0", Offset = "0xA5806F0", VA = "0x18A581CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public Matrix3x2 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xA581D60", Offset = "0xA580760", VA = "0x18A581D60")]
			get
			{
				return default(Matrix3x2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5813C0", Offset = "0xA57FDC0", VA = "0x18A5813C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5813F0", Offset = "0xA57FDF0", VA = "0x18A5813F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5816A0", Offset = "0xA5800A0", VA = "0x18A5816A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xA581470", Offset = "0xA57FE70", VA = "0x18A581470", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA581250", Offset = "0xA57FC50", VA = "0x18A581250", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA581BC0", Offset = "0xA5805C0", VA = "0x18A581BC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xA5875A0", Offset = "0xA585FA0", VA = "0x18A5875A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0xA584F70", Offset = "0xA583970", VA = "0x18A584F70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0xA587E70", Offset = "0xA586870", VA = "0x18A587E70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xA5870E0", Offset = "0xA585AE0", VA = "0x18A5870E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0xA586BC0", Offset = "0xA5855C0", VA = "0x18A586BC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xA586BC0", Offset = "0xA5855C0", VA = "0x18A586BC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5826D0", Offset = "0xA5810D0", VA = "0x18A5826D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0xA582770", Offset = "0xA581170", VA = "0x18A582770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xA582410", Offset = "0xA580E10", VA = "0x18A582410", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA582440", Offset = "0xA580E40", VA = "0x18A582440", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA582530", Offset = "0xA580F30", VA = "0x18A582530", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5824C0", Offset = "0xA580EC0", VA = "0x18A5824C0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xA582370", Offset = "0xA580D70", VA = "0x18A582370", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA5537C0", Offset = "0xA5521C0", VA = "0x18A5537C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA582CD0", Offset = "0xA5816D0", VA = "0x18A582CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0xA5828B0", Offset = "0xA5812B0", VA = "0x18A5828B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xA582C90", Offset = "0xA581690", VA = "0x18A582C90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0xA582BE0", Offset = "0xA5815E0", VA = "0x18A582BE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xA582BE0", Offset = "0xA5815E0", VA = "0x18A582BE0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xA5878A0", Offset = "0xA5862A0", VA = "0x18A5878A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0xA584470", Offset = "0xA582E70", VA = "0x18A584470", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0xA587C90", Offset = "0xA586690", VA = "0x18A587C90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xA587020", Offset = "0xA585A20", VA = "0x18A587020", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xA586760", Offset = "0xA585160", VA = "0x18A586760", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0xA586760", Offset = "0xA585160", VA = "0x18A586760", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA580AD0", Offset = "0xA57F4D0", VA = "0x18A580AD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0xA580B20", Offset = "0xA57F520", VA = "0x18A580B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA580520", Offset = "0xA57EF20", VA = "0x18A580520", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xA580640", Offset = "0xA57F040", VA = "0x18A580640", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA5807B0", Offset = "0xA57F1B0", VA = "0x18A5807B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA5806C0", Offset = "0xA57F0C0", VA = "0x18A5806C0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA5803A0", Offset = "0xA57EDA0", VA = "0x18A5803A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xA580BD0", Offset = "0xA57F5D0", VA = "0x18A580BD0")]
		internal MaterialTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xA580550", Offset = "0xA57EF50", VA = "0x18A580550", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA580490", Offset = "0xA57EE90", VA = "0x18A580490")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0xA587360", Offset = "0xA585D60", VA = "0x18A587360", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0xA583F00", Offset = "0xA582900", VA = "0x18A583F00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xA587BA0", Offset = "0xA5865A0", VA = "0x18A587BA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0xA586FA0", Offset = "0xA5859A0", VA = "0x18A586FA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0xA586D00", Offset = "0xA585700", VA = "0x18A586D00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xA586D00", Offset = "0xA585700", VA = "0x18A586D00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public new const string SCHEMANAME = "KHR_materials_unlit";

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA580C40", Offset = "0xA57F640", VA = "0x18A580C40", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA580C70", Offset = "0xA57F670", VA = "0x18A580C70", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xA580D00", Offset = "0xA57F700", VA = "0x18A580D00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA580CF0", Offset = "0xA57F6F0", VA = "0x18A580CF0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA580C30", Offset = "0xA57F630", VA = "0x18A580C30", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA56B4C0", Offset = "0xA569EC0", VA = "0x18A56B4C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0xA587960", Offset = "0xA586360", VA = "0x18A587960", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0xA5854E0", Offset = "0xA583EE0", VA = "0x18A5854E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0xA587EC0", Offset = "0xA5868C0", VA = "0x18A587EC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xA587060", Offset = "0xA585A60", VA = "0x18A587060", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xA586620", Offset = "0xA585020", VA = "0x18A586620", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0xA586620", Offset = "0xA585020", VA = "0x18A586620", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ModelRoot LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0xCE3800", Offset = "0xCE2200", VA = "0x180CE3800", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0xCE3460", Offset = "0xCE1E60", VA = "0x180CE3460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA57F0C0", Offset = "0xA57DAC0", VA = "0x18A57F0C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA572750", Offset = "0xA571150", VA = "0x18A572750", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xA57F2C0", Offset = "0xA57DCC0", VA = "0x18A57F2C0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA57F1A0", Offset = "0xA57DBA0", VA = "0x18A57F1A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xA57F020", Offset = "0xA57DA20", VA = "0x18A57F020", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xA57F290", Offset = "0xA57DC90", VA = "0x18A57F290", Slot = "18")]
		void IChildOfList<ModelRoot>.SetLogicalParent(ModelRoot parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xA57F200", Offset = "0xA57DC00", VA = "0x18A57F200")]
		protected bool SharesLogicalParent(params LogicalChildOfRoot[] items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3C01C10", Offset = "0x3C00610", VA = "0x183C01C10")]
		public static void RenameLogicalElements<T>(IEnumerable<T> collection, string namePrefix) where T : LogicalChildOfRoot
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA57F0F0", Offset = "0xA57DAF0", VA = "0x18A57F0F0")]
		private bool RenameIfAvailable(string newName, HashSet<string> usedNames)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA5775D0", Offset = "0xA575FD0", VA = "0x18A5775D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0xA5871E0", Offset = "0xA585BE0", VA = "0x18A5871E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xA585C40", Offset = "0xA584640", VA = "0x18A585C40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0xA587F10", Offset = "0xA586910", VA = "0x18A587F10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xA586EA0", Offset = "0xA5858A0", VA = "0x18A586EA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xA586B20", Offset = "0xA585520", VA = "0x18A586B20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xA586B20", Offset = "0xA585520", VA = "0x18A586B20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA56C210", Offset = "0xA56AC10", VA = "0x18A56C210", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA56C3C0", Offset = "0xA56ADC0", VA = "0x18A56C3C0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA56C570", Offset = "0xA56AF70", VA = "0x18A56C570", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA56C440", Offset = "0xA56AE40", VA = "0x18A56C440", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA56C0D0", Offset = "0xA56AAD0", VA = "0x18A56C0D0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA56CBC0", Offset = "0xA56B5C0", VA = "0x18A56CBC0")]
		internal AccessorSparseIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xA56CC20", Offset = "0xA56B620", VA = "0x18A56CC20")]
		internal AccessorSparseIndices(BufferView bv, int byteOffset, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA56CAB0", Offset = "0xA56B4B0", VA = "0x18A56CAB0")]
		internal IntegerArray _GetIndicesArray(ModelRoot root, int sparseCount)
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xA56C240", Offset = "0xA56AC40", VA = "0x18A56C240", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA56C930", Offset = "0xA56B330", VA = "0x18A56C930")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xA587420", Offset = "0xA585E20", VA = "0x18A587420", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xA5849B0", Offset = "0xA5833B0", VA = "0x18A5849B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xA587D80", Offset = "0xA586780", VA = "0x18A587D80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xA586F20", Offset = "0xA585920", VA = "0x18A586F20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0xA5864E0", Offset = "0xA584EE0", VA = "0x18A5864E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0xA5864E0", Offset = "0xA584EE0", VA = "0x18A5864E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA56CE60", Offset = "0xA56B860", VA = "0x18A56CE60", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA56D010", Offset = "0xA56BA10", VA = "0x18A56D010", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xA56D170", Offset = "0xA56BB70", VA = "0x18A56D170", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xA56D090", Offset = "0xA56BA90", VA = "0x18A56D090", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xA56CD70", Offset = "0xA56B770", VA = "0x18A56CD70", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xA56D830", Offset = "0xA56C230", VA = "0x18A56D830")]
		internal AccessorSparseValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xA56D6E0", Offset = "0xA56C0E0", VA = "0x18A56D6E0")]
		internal AccessorSparseValues(BufferView bv, int byteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xA56D480", Offset = "0xA56BE80", VA = "0x18A56D480")]
		internal MemoryAccessor _GetMemoryAccessor(ModelRoot root, int sparseCount, Accessor baseAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA56CE90", Offset = "0xA56B890", VA = "0x18A56CE90", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xA56D420", Offset = "0xA56BE20", VA = "0x18A56D420")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xA5874E0", Offset = "0xA585EE0", VA = "0x18A5874E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0xA5861E0", Offset = "0xA584BE0", VA = "0x18A5861E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xA587FB0", Offset = "0xA5869B0", VA = "0x18A587FB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0xA586F60", Offset = "0xA585960", VA = "0x18A586F60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xA586940", Offset = "0xA585340", VA = "0x18A586940", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0xA586940", Offset = "0xA585340", VA = "0x18A586940", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xA56D9E0", Offset = "0xA56C3E0", VA = "0x18A56D9E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xA56DE20", Offset = "0xA56C820", VA = "0x18A56DE20", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xA56DFA0", Offset = "0xA56C9A0", VA = "0x18A56DFA0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xA56DEA0", Offset = "0xA56C8A0", VA = "0x18A56DEA0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA56D890", Offset = "0xA56C290", VA = "0x18A56D890", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xA56B4C0", Offset = "0xA569EC0", VA = "0x18A56B4C0")]
		internal AccessorSparse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xA56E540", Offset = "0xA56CF40", VA = "0x18A56E540")]
		internal AccessorSparse(int sparseCount, BufferView indices, int indicesOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xA56E350", Offset = "0xA56CD50", VA = "0x18A56E350")]
		internal KeyValuePair<IntegerArray, MemoryAccessor> _CreateMemoryAccessors(Accessor baseAccessor)
		{
			return default(KeyValuePair<IntegerArray, MemoryAccessor>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA56DC40", Offset = "0xA56C640", VA = "0x18A56DC40", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xA56DA10", Offset = "0xA56C410", VA = "0x18A56DA10", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xA587AE0", Offset = "0xA5864E0", VA = "0x18A587AE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xA585730", Offset = "0xA584130", VA = "0x18A585730", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xA587D30", Offset = "0xA586730", VA = "0x18A587D30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xA586FE0", Offset = "0xA5859E0", VA = "0x18A586FE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xA586800", Offset = "0xA585200", VA = "0x18A586800", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xA586800", Offset = "0xA585200", VA = "0x18A586800", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1674260", Offset = "0x1672C60", VA = "0x181674260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public DimensionType Dimensions
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xA574410", Offset = "0xA572E10", VA = "0x18A574410")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xD4E360", Offset = "0xD4CD60", VA = "0x180D4E360")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5761B0", Offset = "0xA574BB0", VA = "0x18A5761B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xA576290", Offset = "0xA574C90", VA = "0x18A576290")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xA576030", Offset = "0xA574A30", VA = "0x18A576030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public BufferView SourceBufferView
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xA5761F0", Offset = "0xA574BF0", VA = "0x18A5761F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public int ByteOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xA5760E0", Offset = "0xA574AE0", VA = "0x18A5760E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool IsSparse
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x86DA4B0", Offset = "0x86D8EB0", VA = "0x1886DA4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public AttributeFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xA576120", Offset = "0xA574B20", VA = "0x18A576120")]
			get
			{
				return default(AttributeFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public (IReadOnlyList<double> Min, IReadOnlyList<double> Max) Bounds
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xA575F90", Offset = "0xA574990", VA = "0x18A575F90")]
			get
			{
				return default((IReadOnlyList<double>, IReadOnlyList<double>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xA56F8A0", Offset = "0xA56E2A0", VA = "0x18A56F8A0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA56FE20", Offset = "0xA56E820", VA = "0x18A56FE20", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA571BF0", Offset = "0xA5705F0", VA = "0x18A571BF0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xA56FED0", Offset = "0xA56E8D0", VA = "0x18A56FED0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xA56F4B0", Offset = "0xA56DEB0", VA = "0x18A56F4B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xA56ED20", Offset = "0xA56D720", VA = "0x18A56ED20")]
		public IAccessorArray<Matrix3x2> AsMatrix2x2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xA56EE00", Offset = "0xA56D800", VA = "0x18A56EE00")]
		public IAccessorArray<Matrix4x4> AsMatrix3x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xA56EEE0", Offset = "0xA56D8E0", VA = "0x18A56EEE0")]
		public IAccessorArray<Matrix4x4> AsMatrix4x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xA56EFC0", Offset = "0xA56D9C0", VA = "0x18A56EFC0")]
		public IAccessorArray<Matrix4x4> AsMatrix4x4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xA56F060", Offset = "0xA56DA60", VA = "0x18A56F060")]
		[Obsolete("Use AsMatrix4x4Array instead", true)]
		internal IReadOnlyList<Matrix4x4> AsMatrix4x4ReadOnlyList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xA56F240", Offset = "0xA56DC40", VA = "0x18A56F240")]
		public IAccessorArray<Quaternion> AsQuaternionArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xA56F100", Offset = "0xA56DB00", VA = "0x18A56F100")]
		public IAccessorArray<float[]> AsMultiArray(int dimensions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xA56EAD0", Offset = "0xA56D4D0", VA = "0x18A56EAD0")]
		public IAccessorArray<uint> AsIndicesArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xA56EA90", Offset = "0xA56D490", VA = "0x18A56EA90")]
		public IAccessorArray<uint> AsIndexArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xA56F3B0", Offset = "0xA56DDB0", VA = "0x18A56F3B0")]
		public IAccessorArray<float> AsScalarArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xA56F3F0", Offset = "0xA56DDF0", VA = "0x18A56F3F0")]
		public IAccessorArray<Vector2> AsVector2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xA56F430", Offset = "0xA56DE30", VA = "0x18A56F430")]
		public IAccessorArray<Vector3> AsVector3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA56F470", Offset = "0xA56DE70", VA = "0x18A56F470")]
		public IAccessorArray<Vector4> AsVector4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x336D860", Offset = "0x336C260", VA = "0x18336D860")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xA56E8A0", Offset = "0xA56D2A0", VA = "0x18A56E8A0")]
		public IAccessorArray<Vector4> AsColorArray(float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xA571A00", Offset = "0xA570400", VA = "0x18A571A00")]
		public ArraySegment<byte> TryGetVertexBytes(int vertexIdx)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xA574400", Offset = "0xA572E00", VA = "0x18A574400")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xA575E60", Offset = "0xA574860", VA = "0x18A575E60")]
		internal Accessor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xA574410", Offset = "0xA572E10", VA = "0x18A574410")]
		private DimensionType _GetDimensions()
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xA574920", Offset = "0xA573320", VA = "0x18A574920")]
		internal bool _TryGetMemoryAccessor([Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xA574670", Offset = "0xA573070", VA = "0x18A574670")]
		internal bool _TryGetMemoryAccessor(string name, [Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA571930", Offset = "0xA570330", VA = "0x18A571930")]
		public bool TryGetBufferView([Out] BufferView bv)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5727D0", Offset = "0xA5711D0", VA = "0x18A5727D0")]
		public void UpdateBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA574500", Offset = "0xA572F00", VA = "0x18A574500")]
		private void _ResetBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x336EDE0", Offset = "0x336D7E0", VA = "0x18336EDE0")]
		private void _AppendToBounds<T>(T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA574230", Offset = "0xA572C30", VA = "0x18A574230")]
		private void _AppendToBounds(params float[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5701E0", Offset = "0xA56EBE0", VA = "0x18A5701E0")]
		public void SetDataFrom(Accessor other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xA571760", Offset = "0xA570160", VA = "0x18A571760")]
		public void SetZeros(MemoryAccessInfo accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xA571790", Offset = "0xA570190", VA = "0x18A571790")]
		public void SetZeros(int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5704B0", Offset = "0xA56EEB0", VA = "0x18A5704B0")]
		[Obsolete("Use SetData with AttributeFormat. This will be removed soon.")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5705B0", Offset = "0xA56EFB0", VA = "0x18A5705B0")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xA56FEA0", Offset = "0xA56E8A0", VA = "0x18A56FEA0")]
		public void RemoveSparseData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x336DF90", Offset = "0x336C990", VA = "0x18336DF90")]
		public void CreateSparseData<T>(IReadOnlyDictionary<int, T> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5710B0", Offset = "0xA56FAB0", VA = "0x18A5710B0")]
		public void SetSparseData(MemoryAccessor sparseIndices, MemoryAccessor sparseValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xA570CE0", Offset = "0xA56F6E0", VA = "0x18A570CE0")]
		public void SetSparseData(int sparseCount, BufferView indices, int indicesByteOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesByteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA570850", Offset = "0xA56F250", VA = "0x18A570850")]
		public void SetIndexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xA570B60", Offset = "0xA56F560", VA = "0x18A570B60")]
		public void SetIndexData(BufferView buffer, int bufferByteOffset, int itemCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xA5713E0", Offset = "0xA56FDE0", VA = "0x18A5713E0")]
		public void SetVertexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xA5712E0", Offset = "0xA56FCE0", VA = "0x18A5712E0")]
		[Obsolete("Use SetVertexData with AttributeFormat. This will be removed soon.")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions = DimensionType.VEC3, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5715F0", Offset = "0xA56FFF0", VA = "0x18A5715F0")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xA56FCE0", Offset = "0xA56E6E0", VA = "0x18A56FCE0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xA56F8D0", Offset = "0xA56E2D0", VA = "0x18A56F8D0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xA572E90", Offset = "0xA571890", VA = "0x18A572E90")]
		internal void ValidateIndices(ValidationContext validate, uint vertexCount, PrimitiveType drawingType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5737C0", Offset = "0xA5721C0", VA = "0x18A5737C0")]
		internal static void ValidateVertexAttributes(ValidationContext validate, IReadOnlyDictionary<string, Accessor> attributes, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xA575260", Offset = "0xA573C60", VA = "0x18A575260")]
		private void _ValidatePositions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xA574F00", Offset = "0xA573900", VA = "0x18A574F00")]
		private void _ValidateNormals(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xA575580", Offset = "0xA573F80", VA = "0x18A575580")]
		private void _ValidateTangents(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xA574BE0", Offset = "0xA5735E0", VA = "0x18A574BE0")]
		private void _ValidateJoints(ValidationContext validate, string attributeName, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xA5759F0", Offset = "0xA5743F0", VA = "0x18A5759F0")]
		private static void _ValidateWeights(ValidationContext validate, Accessor weights0, Accessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xA575BA0", Offset = "0xA5745A0", VA = "0x18A575BA0")]
		private void _ValidateWeights(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xA573240", Offset = "0xA571C40", VA = "0x18A573240")]
		internal void ValidateMatrices4x3(ValidationContext validate, bool mustInvert = true, bool mustDecompose = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xA572C20", Offset = "0xA571620", VA = "0x18A572C20")]
		internal void ValidateAnimationInput(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xA572D40", Offset = "0xA571740", VA = "0x18A572D40")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xA587A20", Offset = "0xA586420", VA = "0x18A587A20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xA584710", Offset = "0xA583110", VA = "0x18A584710", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xA587F60", Offset = "0xA586960", VA = "0x18A587F60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xA586EE0", Offset = "0xA5858E0", VA = "0x18A586EE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA586C60", Offset = "0xA585660", VA = "0x18A586C60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA586C60", Offset = "0xA585660", VA = "0x18A586C60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDD3A0", Offset = "0xCDBDA0", VA = "0x180CDD3A0")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA5765E0", Offset = "0xA574FE0", VA = "0x18A5765E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xA5766F0", Offset = "0xA5750F0", VA = "0x18A5766F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xA576840", Offset = "0xA575240", VA = "0x18A576840", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xA576770", Offset = "0xA575170", VA = "0x18A576770", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xA5762D0", Offset = "0xA574CD0", VA = "0x18A5762D0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xA56B4C0", Offset = "0xA569EC0", VA = "0x18A56B4C0")]
		internal AnimationChannelTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA576AF0", Offset = "0xA5754F0", VA = "0x18A576AF0")]
		internal AnimationChannelTarget(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA576B80", Offset = "0xA575580", VA = "0x18A576B80")]
		internal AnimationChannelTarget(string pointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0", Slot = "17")]
		void IChildOf<AnimationChannel>.SetLogicalParent(AnimationChannel parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA5763C0", Offset = "0xA574DC0", VA = "0x18A5763C0")]
		public int GetNodeIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA576470", Offset = "0xA574E70", VA = "0x18A576470")]
		public PropertyPath GetNodePath()
		{
			return default(PropertyPath);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA5764E0", Offset = "0xA574EE0", VA = "0x18A5764E0")]
		public string GetPointerPath()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA576610", Offset = "0xA575010", VA = "0x18A576610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xA5872A0", Offset = "0xA585CA0", VA = "0x18A5872A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0xA585F40", Offset = "0xA584940", VA = "0x18A585F40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0xA587C40", Offset = "0xA586640", VA = "0x18A587C40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0xA586E60", Offset = "0xA585860", VA = "0x18A586E60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0xA586A80", Offset = "0xA585480", VA = "0x18A586A80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xA586A80", Offset = "0xA585480", VA = "0x18A586A80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE3800", Offset = "0xCE2200", VA = "0x180CE3800", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xCE3460", Offset = "0xCE1E60", VA = "0x180CE3460")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E40", Offset = "0xCD5840", VA = "0x180CD6E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public string TargetPointerPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0xA577A10", Offset = "0xA576410", VA = "0x18A577A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public Node TargetNode
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0xA577890", Offset = "0xA576290", VA = "0x18A577890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public PropertyPath TargetNodePath
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xA577810", Offset = "0xA576210", VA = "0x18A577810")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA576E10", Offset = "0xA575810", VA = "0x18A576E10", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xA576F80", Offset = "0xA575980", VA = "0x18A576F80", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA5771D0", Offset = "0xA575BD0", VA = "0x18A5771D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xA577000", Offset = "0xA575A00", VA = "0x18A577000", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA576C90", Offset = "0xA575690", VA = "0x18A576C90", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA5775D0", Offset = "0xA575FD0", VA = "0x18A5775D0")]
		internal AnimationChannel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xA5776C0", Offset = "0xA5760C0", VA = "0x18A5776C0")]
		internal AnimationChannel(string pointerPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xA5775E0", Offset = "0xA575FE0", VA = "0x18A5775E0")]
		internal AnimationChannel(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xA5770C0", Offset = "0xA575AC0", VA = "0x18A5770C0")]
		internal void SetSampler(AnimationSampler sampler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xA5771A0", Offset = "0xA575BA0", VA = "0x18A5771A0", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xA577540", Offset = "0xA575F40", VA = "0x18A577540")]
		private void _SetChannelTarget(AnimationChannelTarget target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x338D7F0", Offset = "0x338C1F0", VA = "0x18338D7F0")]
		public IAnimationSampler<T> GetSamplerOrNull<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA577480", Offset = "0xA575E80", VA = "0x18A577480")]
		internal AnimationSampler _GetSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xA576DE0", Offset = "0xA5757E0", VA = "0x18A576DE0")]
		public IAnimationSampler<Vector3> GetScaleSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA576DB0", Offset = "0xA5757B0", VA = "0x18A576DB0")]
		public IAnimationSampler<Quaternion> GetRotationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA576E40", Offset = "0xA575840", VA = "0x18A576E40")]
		public IAnimationSampler<Vector3> GetTranslationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA576D80", Offset = "0xA575780", VA = "0x18A576D80")]
		public IAnimationSampler<SparseWeight8> GetSparseMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA576D80", Offset = "0xA575780", VA = "0x18A576D80")]
		public IAnimationSampler<float[]> GetMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xA576E70", Offset = "0xA575870", VA = "0x18A576E70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xA59F5C0", Offset = "0xA59DFC0", VA = "0x18A59F5C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0xA59CBC0", Offset = "0xA59B5C0", VA = "0x18A59CBC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0xA59FD90", Offset = "0xA59E790", VA = "0x18A59FD90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xA59F100", Offset = "0xA59DB00", VA = "0x18A59F100", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0xA59EFA0", Offset = "0xA59D9A0", VA = "0x18A59EFA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0xA59EFA0", Offset = "0xA59D9A0", VA = "0x18A59EFA0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x12B5BC0", Offset = "0x12B45C0", VA = "0x1812B5BC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6541830", Offset = "0x6540230", VA = "0x186541830", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x1394DA0", Offset = "0x13937A0", VA = "0x181394DA0")]
			[DebuggerHidden]
			public <_GroupByTangentValueTangent>d__84(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x72B5DF0", Offset = "0x72B47F0", VA = "0x1872B5DF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x72B5630", Offset = "0x72B4030", VA = "0x1872B5630", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x72B5F20", Offset = "0x72B4920", VA = "0x1872B5F20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x6B02AD0", Offset = "0x6B014D0", VA = "0x186B02AD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(T, T, T)> IEnumerable<(T, T, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x72B5A90", Offset = "0x72B4490", VA = "0x1872B5A90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xD05F80", Offset = "0xD04980", VA = "0x180D05F80", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xDECAD0", Offset = "0xDEB4D0", VA = "0x180DECAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public AnimationInterpolationMode InterpolationMode
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0xA57EF30", Offset = "0xA57D930", VA = "0x18A57EF30", Slot = "51")]
			get
			{
				return default(AnimationInterpolationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0xA57EFD0", Offset = "0xA57D9D0", VA = "0x18A57EFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public Accessor Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xA57EED0", Offset = "0xA57D8D0", VA = "0x18A57EED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public Accessor Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xA57EF70", Offset = "0xA57D970", VA = "0x18A57EF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0xA57EDC0", Offset = "0xA57D7C0", VA = "0x18A57EDC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xA577C70", Offset = "0xA576670", VA = "0x18A577C70", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xA578390", Offset = "0xA576D90", VA = "0x18A578390", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA57D5A0", Offset = "0xA57BFA0", VA = "0x18A57D5A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xA578410", Offset = "0xA576E10", VA = "0x18A578410", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA577B20", Offset = "0xA576520", VA = "0x18A577B20", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA57ECC0", Offset = "0xA57D6C0", VA = "0x18A57ECC0")]
		internal AnimationSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xA57ED30", Offset = "0xA57D730", VA = "0x18A57ED30")]
		internal AnimationSampler(AnimationInterpolationMode interpolation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xA579670", Offset = "0xA578070", VA = "0x18A579670", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xA57D920", Offset = "0xA57C320", VA = "0x18A57D920")]
		private Accessor _CreateInputAccessor(IReadOnlyList<float> input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xA57DB70", Offset = "0xA57C570", VA = "0x18A57DB70")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<bool> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xA57DDA0", Offset = "0xA57C7A0", VA = "0x18A57DDA0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xA57E240", Offset = "0xA57CC40", VA = "0x18A57E240")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector2> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xA57E490", Offset = "0xA57CE90", VA = "0x18A57E490")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector3> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xA57DFF0", Offset = "0xA57C9F0", VA = "0x18A57DFF0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector4> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xA57E980", Offset = "0xA57D380", VA = "0x18A57E980")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Quaternion> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xA57EBB0", Offset = "0xA57D5B0", VA = "0x18A57EBB0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<SparseWeight8> output, int itemsStride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x338E600", Offset = "0x338D000", VA = "0x18338E600")]
		private Accessor _CreateOutputAccessor<T>(IReadOnlyList<T> output, int itemsStride) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xA57E6E0", Offset = "0xA57D0E0", VA = "0x18A57E6E0")]
		private Accessor _CreateOutputAccessor(int itemCount, int itemsStride, Func<int, int, float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x338EFF0", Offset = "0x338D9F0", VA = "0x18338EFF0")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, TValue> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x338EBF0", Offset = "0x338D5F0", VA = "0x18338EBF0")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, (TValue TangentIn, TValue Value, TValue TangentOut)> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xA579160", Offset = "0xA577B60", VA = "0x18A579160")]
		internal void SetKeys(IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA579060", Offset = "0xA577A60", VA = "0x18A579060")]
		internal void SetKeys(IReadOnlyDictionary<float, float> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xA579470", Offset = "0xA577E70", VA = "0x18A579470")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector2> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA579570", Offset = "0xA577F70", VA = "0x18A579570")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector3> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xA578F60", Offset = "0xA577960", VA = "0x18A578F60")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector4> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xA579370", Offset = "0xA577D70", VA = "0x18A579370")]
		internal void SetKeys(IReadOnlyDictionary<float, Quaternion> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x338DDB0", Offset = "0x338C7B0", VA = "0x18338DDB0")]
		internal void SetKeys<TWeights>(IReadOnlyDictionary<float, TWeights> keyframes, int itemsStride) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA579260", Offset = "0xA577C60", VA = "0x18A579260")]
		internal void SetKeys(IReadOnlyDictionary<float, SparseWeight8> keyframes, int itemsStride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA578BC0", Offset = "0xA5775C0", VA = "0x18A578BC0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (float TangentIn, float Value, float TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xA578D70", Offset = "0xA577770", VA = "0x18A578D70")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector2 TangentIn, Vector2 Value, Vector2 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA578720", Offset = "0xA577120", VA = "0x18A578720")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xA578540", Offset = "0xA576F40", VA = "0x18A578540")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector4 TangentIn, Vector4 Value, Vector4 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA578A90", Offset = "0xA577490", VA = "0x18A578A90")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x338D9E0", Offset = "0x338C3E0", VA = "0x18338D9E0")]
		internal void SetCubicKeys<TWeights>(IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int expandedCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xA578900", Offset = "0xA577300", VA = "0x18A578900")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int expandedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xA57A830", Offset = "0xA579230", VA = "0x18A57A830", Slot = "20")]
		IEnumerable<(float, bool)> IAnimationSampler<bool>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA57CA90", Offset = "0xA57B490", VA = "0x18A57CA90", Slot = "24")]
		IEnumerable<(float, float)> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA57B5F0", Offset = "0xA579FF0", VA = "0x18A57B5F0", Slot = "28")]
		IEnumerable<(float, Vector2)> IAnimationSampler<Vector2>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA57BCD0", Offset = "0xA57A6D0", VA = "0x18A57BCD0", Slot = "32")]
		IEnumerable<(float, Vector3)> IAnimationSampler<Vector3>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA57C3B0", Offset = "0xA57ADB0", VA = "0x18A57C3B0", Slot = "36")]
		IEnumerable<(float, Vector4)> IAnimationSampler<Vector4>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA57AF30", Offset = "0xA579930", VA = "0x18A57AF30", Slot = "40")]
		IEnumerable<(float, Quaternion)> IAnimationSampler<Quaternion>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA579B60", Offset = "0xA578560", VA = "0x18A579B60", Slot = "44")]
		IEnumerable<(float, SparseWeight8)> IAnimationSampler<SparseWeight8>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA57A3A0", Offset = "0xA578DA0", VA = "0x18A57A3A0", Slot = "48")]
		IEnumerable<(float, ArraySegment<float>)> IAnimationSampler<ArraySegment<float>>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xA57D220", Offset = "0xA57BC20", VA = "0x18A57D220", Slot = "52")]
		IEnumerable<(float, float[])> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA57A7F0", Offset = "0xA5791F0", VA = "0x18A57A7F0", Slot = "21")]
		IEnumerable<(float, (bool, bool, bool))> IAnimationSampler<bool>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xA57C7A0", Offset = "0xA57B1A0", VA = "0x18A57C7A0", Slot = "25")]
		IEnumerable<(float, (float, float, float))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA57B300", Offset = "0xA579D00", VA = "0x18A57B300", Slot = "29")]
		IEnumerable<(float, (Vector2, Vector2, Vector2))> IAnimationSampler<Vector2>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xA57B9E0", Offset = "0xA57A3E0", VA = "0x18A57B9E0", Slot = "33")]
		IEnumerable<(float, (Vector3, Vector3, Vector3))> IAnimationSampler<Vector3>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA57C0C0", Offset = "0xA57AAC0", VA = "0x18A57C0C0", Slot = "37")]
		IEnumerable<(float, (Vector4, Vector4, Vector4))> IAnimationSampler<Vector4>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xA57AC60", Offset = "0xA579660", VA = "0x18A57AC60", Slot = "41")]
		IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> IAnimationSampler<Quaternion>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA57CE80", Offset = "0xA57B880", VA = "0x18A57CE80", Slot = "53")]
		IEnumerable<(float, (float[], float[], float[]))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA57A000", Offset = "0xA578A00", VA = "0x18A57A000", Slot = "49")]
		IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> IAnimationSampler<ArraySegment<float>>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xA5797C0", Offset = "0xA5781C0", VA = "0x18A5797C0", Slot = "45")]
		IEnumerable<(float, (SparseWeight8, SparseWeight8, SparseWeight8))> IAnimationSampler<SparseWeight8>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xA57A720", Offset = "0xA579120", VA = "0x18A57A720", Slot = "22")]
		ICurveSampler<bool> IAnimationSampler<bool>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA57C680", Offset = "0xA57B080", VA = "0x18A57C680", Slot = "26")]
		ICurveSampler<float> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA57B1E0", Offset = "0xA579BE0", VA = "0x18A57B1E0", Slot = "30")]
		ICurveSampler<Vector2> IAnimationSampler<Vector2>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA57B8C0", Offset = "0xA57A2C0", VA = "0x18A57B8C0", Slot = "34")]
		ICurveSampler<Vector3> IAnimationSampler<Vector3>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xA57BFA0", Offset = "0xA57A9A0", VA = "0x18A57BFA0", Slot = "38")]
		ICurveSampler<Vector4> IAnimationSampler<Vector4>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xA57AB40", Offset = "0xA579540", VA = "0x18A57AB40", Slot = "42")]
		ICurveSampler<Quaternion> IAnimationSampler<Quaternion>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xA5796A0", Offset = "0xA5780A0", VA = "0x18A5796A0", Slot = "46")]
		ICurveSampler<SparseWeight8> IAnimationSampler<SparseWeight8>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xA57CD60", Offset = "0xA57B760", VA = "0x18A57CD60", Slot = "54")]
		ICurveSampler<float[]> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xA579EE0", Offset = "0xA5788E0", VA = "0x18A579EE0", Slot = "50")]
		ICurveSampler<ArraySegment<float>> IAnimationSampler<ArraySegment<float>>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x338E9B0", Offset = "0x338D3B0", VA = "0x18338E9B0")]
		[IteratorStateMachine(typeof(<_GroupByTangentValueTangent>d__84<>))]
		private static IEnumerable<(T, T, T)> _GroupByTangentValueTangent<T>(IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xA5781D0", Offset = "0xA576BD0", VA = "0x18A5781D0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xA577CA0", Offset = "0xA5766A0", VA = "0x18A577CA0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xA59F980", Offset = "0xA59E380", VA = "0x18A59F980", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0xA59D1E0", Offset = "0xA59BBE0", VA = "0x18A59D1E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xA59FFC0", Offset = "0xA59E9C0", VA = "0x18A59FFC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0xA59F040", Offset = "0xA59DA40", VA = "0x18A59F040", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0xA59EB40", Offset = "0xA59D540", VA = "0x18A59EB40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xA59EB40", Offset = "0xA59D540", VA = "0x18A59EB40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public IReadOnlyList<AnimationChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0xA58B330", Offset = "0xA589D30", VA = "0x18A58B330")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA58A7A0", Offset = "0xA5891A0", VA = "0x18A58A7A0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xA58A920", Offset = "0xA589320", VA = "0x18A58A920", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xA58AAB0", Offset = "0xA5894B0", VA = "0x18A58AAB0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xA58A9A0", Offset = "0xA5893A0", VA = "0x18A58A9A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xA58A2F0", Offset = "0xA588CF0", VA = "0x18A58A2F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xA58B260", Offset = "0xA589C60", VA = "0x18A58B260")]
		internal Animation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA58A550", Offset = "0xA588F50", VA = "0x18A58A550")]
		public IEnumerable<AnimationChannel> FindChannels(string rootPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA58A3E0", Offset = "0xA588DE0", VA = "0x18A58A3E0")]
		public IEnumerable<AnimationChannel> FindChannels(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA58A780", Offset = "0xA589180", VA = "0x18A58A780")]
		public AnimationChannel FindScaleChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA58A770", Offset = "0xA589170", VA = "0x18A58A770")]
		public AnimationChannel FindRotationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA58A790", Offset = "0xA589190", VA = "0x18A58A790")]
		public AnimationChannel FindTranslationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA58A760", Offset = "0xA589160", VA = "0x18A58A760")]
		public AnimationChannel FindMorphChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA58ADD0", Offset = "0xA5897D0", VA = "0x18A58ADD0")]
		private AnimationChannel _FindChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA58AD40", Offset = "0xA589740", VA = "0x18A58AD40")]
		private AnimationSampler _CreateSampler(AnimationInterpolationMode interpolation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA58B080", Offset = "0xA589A80", VA = "0x18A58B080")]
		private AnimationChannel _UseChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA58AFF0", Offset = "0xA5899F0", VA = "0x18A58AFF0")]
		private AnimationChannel _UseChannel(string pointerPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x3393670", Offset = "0x3392070", VA = "0x183393670")]
		public void CreateMaterialPropertyChannel<T>(Material material, string propertyName, IReadOnlyDictionary<float, T> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x3394340", Offset = "0x3392D40", VA = "0x183394340")]
		public void DangerousCreatePointerChannel<T>(string pointerPath, IReadOnlyDictionary<float, T> keyframes, bool linear = true, bool verifyBackingFieldExists = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xA589C60", Offset = "0xA588660", VA = "0x18A589C60")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA589AF0", Offset = "0xA5884F0", VA = "0x18A589AF0")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA589800", Offset = "0xA588200", VA = "0x18A589800")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, Quaternion> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xA589980", Offset = "0xA588380", VA = "0x18A589980")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA589DE0", Offset = "0xA5887E0", VA = "0x18A589DE0")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xA589F60", Offset = "0xA588960", VA = "0x18A589F60")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x3393A90", Offset = "0x3392490", VA = "0x183393A90")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, TWeights> keyframes, int morphCount, bool linear = true) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x3393810", Offset = "0x3392210", VA = "0x183393810")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int morphCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA589680", Offset = "0xA588080", VA = "0x18A589680")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, SparseWeight8> keyframes, int morphCount, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xA589500", Offset = "0xA587F00", VA = "0x18A589500")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int morphCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xA58A0D0", Offset = "0xA588AD0", VA = "0x18A58A0D0")]
		public void CreateVisibilityChannel(Node node, IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xA58A800", Offset = "0xA589200", VA = "0x18A58A800", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xA58A7D0", Offset = "0xA5891D0", VA = "0x18A58A7D0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0xA59F8C0", Offset = "0xA59E2C0", VA = "0x18A59F8C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0xA59D720", Offset = "0xA59C120", VA = "0x18A59D720", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0xA5A0060", Offset = "0xA59EA60", VA = "0x18A5A0060")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0xA59F0C0", Offset = "0xA59DAC0", VA = "0x18A59F0C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xA59ED20", Offset = "0xA59D720", VA = "0x18A59ED20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xA59ED20", Offset = "0xA59D720", VA = "0x18A59ED20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public static string AssemblyInformationalVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xA58C100", Offset = "0xA58AB00", VA = "0x18A58C100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public string Copyright
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0xA58C2F0", Offset = "0xA58ACF0", VA = "0x18A58C2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public string Generator
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xA58C320", Offset = "0xA58AD20", VA = "0x18A58C320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Version Version
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0xA58C270", Offset = "0xA58AC70", VA = "0x18A58C270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Version MinVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xA58C1F0", Offset = "0xA58ABF0", VA = "0x18A58C1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA58B790", Offset = "0xA58A190", VA = "0x18A58B790", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA58B9C0", Offset = "0xA58A3C0", VA = "0x18A58B9C0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA58BB00", Offset = "0xA58A500", VA = "0x18A58BB00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xA58BA40", Offset = "0xA58A440", VA = "0x18A58BA40", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA58B670", Offset = "0xA58A070", VA = "0x18A58B670", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA56B4C0", Offset = "0xA569EC0", VA = "0x18A56B4C0")]
		internal Asset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xA58B450", Offset = "0xA589E50", VA = "0x18A58B450")]
		internal static Asset CreateDefault(string copyright)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0", Slot = "17")]
		void IChildOf<ModelRoot>.SetLogicalParent(ModelRoot parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA58B7C0", Offset = "0xA58A1C0", VA = "0x18A58B7C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0xA59F800", Offset = "0xA59E200", VA = "0x18A59F800", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xA59E200", Offset = "0xA59CC00", VA = "0x18A59E200", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xA59FF70", Offset = "0xA59E970", VA = "0x18A59FF70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xA59F280", Offset = "0xA59DC80", VA = "0x18A59F280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xA59EAA0", Offset = "0xA59D4A0", VA = "0x18A59EAA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0xA59EAA0", Offset = "0xA59D4A0", VA = "0x18A59EAA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA58E990", Offset = "0xA58D390", VA = "0x18A58E990", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA58EDC0", Offset = "0xA58D7C0", VA = "0x18A58EDC0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA58EEF0", Offset = "0xA58D8F0", VA = "0x18A58EEF0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xA58EE40", Offset = "0xA58D840", VA = "0x18A58EE40", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xA58E8A0", Offset = "0xA58D2A0", VA = "0x18A58E8A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xA58F690", Offset = "0xA58E090", VA = "0x18A58F690")]
		internal Buffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xA58F6A0", Offset = "0xA58E0A0", VA = "0x18A58F6A0")]
		internal Buffer(byte[] content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0xA58F3D0", Offset = "0xA58DDD0", VA = "0x18A58F3D0")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xA58F250", Offset = "0xA58DC50", VA = "0x18A58F250")]
		private static byte[] _LoadBinaryBufferUnchecked(string uri, ReadContext context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xA58F5C0", Offset = "0xA58DFC0", VA = "0x18A58F5C0")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xA58F580", Offset = "0xA58DF80", VA = "0x18A58F580")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xA58F1A0", Offset = "0xA58DBA0", VA = "0x18A58F1A0")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xA58F1D0", Offset = "0xA58DBD0", VA = "0x18A58F1D0")]
		internal void _IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xA58E9C0", Offset = "0xA58D3C0", VA = "0x18A58E9C0")]
		internal void OnValidateBinaryChunk(ValidationContext validate, byte[] binaryChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xA58ED10", Offset = "0xA58D710", VA = "0x18A58ED10", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xA58EBE0", Offset = "0xA58D5E0", VA = "0x18A58EBE0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA59F380", Offset = "0xA59DD80", VA = "0x18A59F380", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0xA59C0D0", Offset = "0xA59AAD0", VA = "0x18A59C0D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA59FE80", Offset = "0xA59E880", VA = "0x18A59FE80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA59F240", Offset = "0xA59DC40", VA = "0x18A59F240", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0xA59EDC0", Offset = "0xA59D7C0", VA = "0x18A59EDC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0xA59EDC0", Offset = "0xA59D7C0", VA = "0x18A59EDC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA58E860", Offset = "0xA58D260", VA = "0x18A58E860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public bool IsIndexBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0xA58E820", Offset = "0xA58D220", VA = "0x18A58E820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public bool IsDataBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA58E7E0", Offset = "0xA58D1E0", VA = "0x18A58E7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xA58E6D0", Offset = "0xA58D0D0", VA = "0x18A58E6D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public ArraySegment<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA58E710", Offset = "0xA58D110", VA = "0x18A58E710")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		internal int LogicalBufferIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0xD05F80", Offset = "0xD04980", VA = "0x180D05F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA58C900", Offset = "0xA58B300", VA = "0x18A58C900", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA58D160", Offset = "0xA58BB60", VA = "0x18A58D160", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA58D360", Offset = "0xA58BD60", VA = "0x18A58D360", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA58D1E0", Offset = "0xA58BBE0", VA = "0x18A58D1E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xA58C4F0", Offset = "0xA58AEF0", VA = "0x18A58C4F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA58E180", Offset = "0xA58CB80", VA = "0x18A58E180")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA58E670", Offset = "0xA58D070", VA = "0x18A58E670")]
		internal BufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA58E2C0", Offset = "0xA58CCC0", VA = "0x18A58E2C0")]
		internal BufferView(Buffer buffer, int byteOffset, int? byteLength, int byteStride, BufferMode? target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xA58C780", Offset = "0xA58B180", VA = "0x18A58C780")]
		public IEnumerable<Image> FindImages()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0xA58C6B0", Offset = "0xA58B0B0", VA = "0x18A58C6B0")]
		public IEnumerable<Accessor> FindAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA58E190", Offset = "0xA58CB90", VA = "0x18A58E190")]
		internal void _IsolateBufferMemory(_StaticBufferBuilder targetBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA58C930", Offset = "0xA58B330", VA = "0x18A58C930")]
		public bool IsInterleaved(IEnumerable<Accessor> accessors)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xA58C350", Offset = "0xA58AD50", VA = "0x18A58C350")]
		internal static bool AreEqual(BufferView bv, ArraySegment<byte> content, int byteStride, BufferMode? target)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA58C850", Offset = "0xA58B250", VA = "0x18A58C850")]
		internal static int GetAccessorByteLength([In] AttributeFormat fmt, int count, BufferView bv)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA58DBA0", Offset = "0xA58C5A0", VA = "0x18A58DBA0")]
		internal static void VerifyAccess(ValidationContext validate, BufferView bv, int accessorByteOffset, AttributeFormat format, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xA58CDA0", Offset = "0xA58B7A0", VA = "0x18A58CDA0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xA58CBD0", Offset = "0xA58B5D0", VA = "0x18A58CBD0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA58D940", Offset = "0xA58C340", VA = "0x18A58D940")]
		internal void ValidateBufferUsageGPU(ValidationContext validate, BufferMode usingMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA58DA40", Offset = "0xA58C440", VA = "0x18A58DA40")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA59F740", Offset = "0xA59E140", VA = "0x18A59F740", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xA59CEC0", Offset = "0xA59B8C0", VA = "0x18A59CEC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xA5A00B0", Offset = "0xA59EAB0", VA = "0x18A5A00B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xA59F180", Offset = "0xA59DB80", VA = "0x18A59F180", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xA59E8C0", Offset = "0xA59D2C0", VA = "0x18A59E8C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xA59E8C0", Offset = "0xA59D2C0", VA = "0x18A59E8C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool IsOrthographic
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public float XMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xA5902A0", Offset = "0xA58ECA0", VA = "0x18A5902A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public float YMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xA5902B0", Offset = "0xA58ECB0", VA = "0x18A5902B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xA5902D0", Offset = "0xA58ECD0", VA = "0x18A5902D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xA5902C0", Offset = "0xA58ECC0", VA = "0x18A5902C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xA590230", Offset = "0xA58EC30", VA = "0x18A590230", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xA58F800", Offset = "0xA58E200", VA = "0x18A58F800", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA58F8E0", Offset = "0xA58E2E0", VA = "0x18A58F8E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA58FB20", Offset = "0xA58E520", VA = "0x18A58FB20", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xA58F960", Offset = "0xA58E360", VA = "0x18A58F960", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xA58F6E0", Offset = "0xA58E0E0", VA = "0x18A58F6E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA56B4C0", Offset = "0xA569EC0", VA = "0x18A56B4C0")]
		internal CameraOrthographic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA5901B0", Offset = "0xA58EBB0", VA = "0x18A5901B0")]
		internal CameraOrthographic(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA590040", Offset = "0xA58EA40", VA = "0x18A590040")]
		public static void VerifyParameters(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA58F830", Offset = "0xA58E230", VA = "0x18A58F830", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xA59F500", Offset = "0xA59DF00", VA = "0x18A59F500", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xA59DC90", Offset = "0xA59C690", VA = "0x18A59DC90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xA59FED0", Offset = "0xA59E8D0", VA = "0x18A59FED0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xA59F140", Offset = "0xA59DB40", VA = "0x18A59F140", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xA59EA00", Offset = "0xA59D400", VA = "0x18A59EA00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0xA59EA00", Offset = "0xA59D400", VA = "0x18A59EA00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public bool IsPerspective
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public float? AspectRatio
		{
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xA590EF0", Offset = "0xA58F8F0", VA = "0x18A590EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public float VerticalFOV
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xA5902C0", Offset = "0xA58ECC0", VA = "0x18A5902C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x9C49A10", Offset = "0x9C48410", VA = "0x189C49A10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xA5910B0", Offset = "0xA58FAB0", VA = "0x18A5910B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0xA590F80", Offset = "0xA58F980", VA = "0x18A590F80", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA590420", Offset = "0xA58EE20", VA = "0x18A590420", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA590500", Offset = "0xA58EF00", VA = "0x18A590500", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA590710", Offset = "0xA58F110", VA = "0x18A590710", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA590580", Offset = "0xA58EF80", VA = "0x18A590580", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA5902E0", Offset = "0xA58ECE0", VA = "0x18A5902E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA56B4C0", Offset = "0xA569EC0", VA = "0x18A56B4C0")]
		internal CameraPerspective()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA590DA0", Offset = "0xA58F7A0", VA = "0x18A590DA0")]
		internal CameraPerspective(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xA590C40", Offset = "0xA58F640", VA = "0x18A590C40")]
		public static void VerifyParameters(float? aspectRatio, float yfov, float znear, float zfar = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA590450", Offset = "0xA58EE50", VA = "0x18A590450", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0xA59FBC0", Offset = "0xA59E5C0", VA = "0x18A59FBC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xA59C450", Offset = "0xA59AE50", VA = "0x18A59C450", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xA59FD40", Offset = "0xA59E740", VA = "0x18A59FD40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xA59F1C0", Offset = "0xA59DBC0", VA = "0x18A59F1C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0xA59E820", Offset = "0xA59D220", VA = "0x18A59E820", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xA59E820", Offset = "0xA59D220", VA = "0x18A59E820", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA591DA0", Offset = "0xA5907A0", VA = "0x18A591DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0xA591CB0", Offset = "0xA5906B0", VA = "0x18A591CB0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5912E0", Offset = "0xA58FCE0", VA = "0x18A5912E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5914B0", Offset = "0xA58FEB0", VA = "0x18A5914B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA591900", Offset = "0xA590300", VA = "0x18A591900", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA591530", Offset = "0xA58FF30", VA = "0x18A591530", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA591110", Offset = "0xA58FB10", VA = "0x18A591110", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA58F690", Offset = "0xA58E090", VA = "0x18A58F690")]
		internal Camera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA591250", Offset = "0xA58FC50", VA = "0x18A591250")]
		internal ICamera GetCamera()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA591640", Offset = "0xA590040", VA = "0x18A591640")]
		public void SetOrthographicMode(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xA591740", Offset = "0xA590140", VA = "0x18A591740")]
		public void SetPerspectiveMode(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xA591310", Offset = "0xA58FD10", VA = "0x18A591310", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0xA59F680", Offset = "0xA59E080", VA = "0x18A59F680", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xA59D480", Offset = "0xA59BE80", VA = "0x18A59D480", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0xA5A0100", Offset = "0xA59EB00", VA = "0x18A5A0100")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xA59F080", Offset = "0xA59DA80", VA = "0x18A59F080", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xA59EE60", Offset = "0xA59D860", VA = "0x18A59EE60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0xA59EE60", Offset = "0xA59D860", VA = "0x18A59EE60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public int LogicalTextureIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0xD29750", Offset = "0xD28150", VA = "0x180D29750")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA59B7E0", Offset = "0xA59A1E0", VA = "0x18A59B7E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0xA59B860", Offset = "0xA59A260", VA = "0x18A59B860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public TextureTransform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA59B820", Offset = "0xA59A220", VA = "0x18A59B820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA59B120", Offset = "0xA599B20", VA = "0x18A59B120", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA59B260", Offset = "0xA599C60", VA = "0x18A59B260", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA59B4D0", Offset = "0xA599ED0", VA = "0x18A59B4D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA59B2E0", Offset = "0xA599CE0", VA = "0x18A59B2E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA59B030", Offset = "0xA599A30", VA = "0x18A59B030", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA59B780", Offset = "0xA59A180", VA = "0x18A59B780")]
		public TextureInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA59B3C0", Offset = "0xA599DC0", VA = "0x18A59B3C0")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA59B150", Offset = "0xA599B50", VA = "0x18A59B150", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA59C070", Offset = "0xA59AA70", VA = "0x18A59C070", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <GetChannels>d__32(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA59B8C0", Offset = "0xA59A2C0", VA = "0x18A59B8C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA59C030", Offset = "0xA59AA30", VA = "0x18A59C030", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA59BF80", Offset = "0xA59A980", VA = "0x18A59BF80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA59BF80", Offset = "0xA59A980", VA = "0x18A59BF80", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xA59FA40", Offset = "0xA59E440", VA = "0x18A59FA40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xA59E4A0", Offset = "0xA59CEA0", VA = "0x18A59E4A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xA59FE30", Offset = "0xA59E830", VA = "0x18A59FE30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0xA59F300", Offset = "0xA59DD00", VA = "0x18A59F300", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0xA59EC80", Offset = "0xA59D680", VA = "0x18A59EC80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0xA59EC80", Offset = "0xA59D680", VA = "0x18A59EC80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6DC0", Offset = "0xCD57C0", VA = "0x180CD6DC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xA5935B0", Offset = "0xA591FB0", VA = "0x18A5935B0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0xA593670", Offset = "0xA592070", VA = "0x18A593670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public float MetallicFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA5937E0", Offset = "0xA5921E0", VA = "0x18A5937E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0xA593840", Offset = "0xA592240", VA = "0x18A593840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA5938B0", Offset = "0xA5922B0", VA = "0x18A5938B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0xA593910", Offset = "0xA592310", VA = "0x18A593910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA592A30", Offset = "0xA591430", VA = "0x18A592A30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA592C90", Offset = "0xA591690", VA = "0x18A592C90", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA592F40", Offset = "0xA591940", VA = "0x18A592F40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA592D10", Offset = "0xA591710", VA = "0x18A592D10", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA592800", Offset = "0xA591200", VA = "0x18A592800", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xCD6C80", Offset = "0xCD5680", VA = "0x180CD6C80", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA592A60", Offset = "0xA591460", VA = "0x18A592A60", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xA5929A0", Offset = "0xA5913A0", VA = "0x18A5929A0")]
		[IteratorStateMachine(typeof(<GetChannels>d__32))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA5939D0", Offset = "0xA5923D0", VA = "0x18A5939D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083A")]
			[Cpp2IlInjected.Address(RVA = "0xA59FC80", Offset = "0xA59E680", VA = "0x18A59FC80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083B")]
			[Cpp2IlInjected.Address(RVA = "0xA59DA40", Offset = "0xA59C440", VA = "0x18A59DA40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600083C")]
			[Cpp2IlInjected.Address(RVA = "0xA59FDE0", Offset = "0xA59E7E0", VA = "0x18A59FDE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xA59F200", Offset = "0xA59DC00", VA = "0x18A59F200", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0xA59E960", Offset = "0xA59D360", VA = "0x18A59E960", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xA59E960", Offset = "0xA59D360", VA = "0x18A59E960", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD81890", Offset = "0xD80290", VA = "0x180D81890")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public float Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0xA592210", Offset = "0xA590C10", VA = "0x18A592210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0xA592270", Offset = "0xA590C70", VA = "0x18A592270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xA591E50", Offset = "0xA590850", VA = "0x18A591E50", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xA591E80", Offset = "0xA590880", VA = "0x18A591E80", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA591FC0", Offset = "0xA5909C0", VA = "0x18A591FC0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA591F00", Offset = "0xA590900", VA = "0x18A591F00", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA591DB0", Offset = "0xA5907B0", VA = "0x18A591DB0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA592170", Offset = "0xA590B70", VA = "0x18A592170")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xA59FB00", Offset = "0xA59E500", VA = "0x18A59FB00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA59DFB0", Offset = "0xA59C9B0", VA = "0x18A59DFB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA59FF20", Offset = "0xA59E920", VA = "0x18A59FF20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0xA59F2C0", Offset = "0xA59DCC0", VA = "0x18A59F2C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xA59EBE0", Offset = "0xA59D5E0", VA = "0x18A59EBE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xA59EBE0", Offset = "0xA59D5E0", VA = "0x18A59EBE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD81890", Offset = "0xD80290", VA = "0x180D81890")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public float Strength
		{
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0xA592730", Offset = "0xA591130", VA = "0x18A592730")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xA592790", Offset = "0xA591190", VA = "0x18A592790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA592380", Offset = "0xA590D80", VA = "0x18A592380", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA5923B0", Offset = "0xA590DB0", VA = "0x18A5923B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA5924F0", Offset = "0xA590EF0", VA = "0x18A5924F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA592430", Offset = "0xA590E30", VA = "0x18A592430", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA5922E0", Offset = "0xA590CE0", VA = "0x18A5922E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA592690", Offset = "0xA591090", VA = "0x18A592690")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA59F440", Offset = "0xA59DE40", VA = "0x18A59F440", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA59C750", Offset = "0xA59B150", VA = "0x18A59C750", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xA5A0010", Offset = "0xA59EA10", VA = "0x18A5A0010")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xA59F340", Offset = "0xA59DD40", VA = "0x18A59F340", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xA59EF00", Offset = "0xA59D900", VA = "0x18A59EF00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xA59EF00", Offset = "0xA59D900", VA = "0x18A59EF00", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x10C8380", Offset = "0x10C6D80", VA = "0x1810C8380", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5A3590", Offset = "0xA5A1F90", VA = "0x18A5A3590", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x14153A0", Offset = "0x1413DA0", VA = "0x1814153A0")]
			[DebuggerHidden]
			public <_GetChannels>d__45(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0xA5A35F0", Offset = "0xA5A1FF0", VA = "0x18A5A35F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xA5A19A0", Offset = "0xA5A03A0", VA = "0x18A5A19A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0xA5A39E0", Offset = "0xA5A23E0", VA = "0x18A5A39E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3A40", Offset = "0xA5A2440", VA = "0x18A5A3A40")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3AA0", Offset = "0xA5A24A0", VA = "0x18A5A3AA0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3B00", Offset = "0xA5A2500", VA = "0x18A5A3B00")]
			private void <>m__Finally4()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3B60", Offset = "0xA5A2560", VA = "0x18A5A3B60")]
			private void <>m__Finally5()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3BC0", Offset = "0xA5A25C0", VA = "0x18A5A3BC0")]
			private void <>m__Finally6()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3C20", Offset = "0xA5A2620", VA = "0x18A5A3C20")]
			private void <>m__Finally7()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3C80", Offset = "0xA5A2680", VA = "0x18A5A3C80")]
			private void <>m__Finally8()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3CE0", Offset = "0xA5A26E0", VA = "0x18A5A3CE0")]
			private void <>m__Finally9()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3980", Offset = "0xA5A2380", VA = "0x18A5A3980")]
			private void <>m__Finally10()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3550", Offset = "0xA5A1F50", VA = "0x18A5A3550", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xA5A34B0", Offset = "0xA5A1EB0", VA = "0x18A5A34B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5A34B0", Offset = "0xA5A1EB0", VA = "0x18A5A34B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA596040", Offset = "0xA594A40", VA = "0x18A596040")]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0xA596280", Offset = "0xA594C80", VA = "0x18A596280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0xA595FE0", Offset = "0xA5949E0", VA = "0x18A595FE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0xA596200", Offset = "0xA594C00", VA = "0x18A596200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0xA5960E0", Offset = "0xA594AE0", VA = "0x18A5960E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0xA5963B0", Offset = "0xA594DB0", VA = "0x18A5963B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public bool Unlit
		{
			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0xA5961C0", Offset = "0xA594BC0", VA = "0x18A5961C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public IEnumerable<MaterialChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xA595A80", Offset = "0xA594480", VA = "0x18A595A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xA596160", Offset = "0xA594B60", VA = "0x18A596160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0xA596430", Offset = "0xA594E30", VA = "0x18A596430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA596080", Offset = "0xA594A80", VA = "0x18A596080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0xA5962D0", Offset = "0xA594CD0", VA = "0x18A5962D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xA594300", Offset = "0xA592D00", VA = "0x18A594300", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA5949A0", Offset = "0xA5933A0", VA = "0x18A5949A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA594D30", Offset = "0xA593730", VA = "0x18A594D30", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA594A20", Offset = "0xA593420", VA = "0x18A594A20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA593C30", Offset = "0xA592630", VA = "0x18A593C30", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA595E90", Offset = "0xA594890", VA = "0x18A595E90")]
		internal Material()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xA593FE0", Offset = "0xA5929E0", VA = "0x18A593FE0")]
		[DebuggerStepThrough]
		public MaterialChannel? FindChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xA5947D0", Offset = "0xA5931D0", VA = "0x18A5947D0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xA593AE0", Offset = "0xA5924E0", VA = "0x18A593AE0")]
		internal void ClearExtensions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xA594730", Offset = "0xA593130", VA = "0x18A594730")]
		public void InitializeUnlit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA594330", Offset = "0xA592D30", VA = "0x18A594330")]
		public void InitializePBRMetallicRoughness(params string[] extensionNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA594660", Offset = "0xA593060", VA = "0x18A594660")]
		public void InitializePBRSpecularGlossiness(bool useFallback = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA595A80", Offset = "0xA594480", VA = "0x18A595A80")]
		[IteratorStateMachine(typeof(<_GetChannels>d__45))]
		private IEnumerable<MaterialChannel> _GetChannels()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA595BE0", Offset = "0xA5945E0", VA = "0x18A595BE0")]
		private MaterialNormalTextureInfo _GetNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA595D00", Offset = "0xA594700", VA = "0x18A595D00")]
		private MaterialOcclusionTextureInfo _GetOcclusionTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xA595B00", Offset = "0xA594500", VA = "0x18A595B00")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0930", Offset = "0xA5BF330", VA = "0x18A5C0930", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xA5BFDF0", Offset = "0xA5BE7F0", VA = "0x18A5BFDF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0F10", Offset = "0xA5BF910", VA = "0x18A5C0F10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0770", Offset = "0xA5BF170", VA = "0x18A5C0770", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xA5C03F0", Offset = "0xA5BEDF0", VA = "0x18A5C03F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0xA5C03F0", Offset = "0xA5BEDF0", VA = "0x18A5C03F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD4E360", Offset = "0xD4CD60", VA = "0x180D4E360", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD4F650", Offset = "0xD4E050", VA = "0x180D4F650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public Mesh LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DF0", Offset = "0xCD57F0", VA = "0x180CD6DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0xA59ACD0", Offset = "0xA5996D0", VA = "0x18A59ACD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0xA59AF40", Offset = "0xA599940", VA = "0x18A59AF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public PrimitiveType DrawPrimitiveType
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xA59ABE0", Offset = "0xA5995E0", VA = "0x18A59ABE0")]
			get
			{
				return default(PrimitiveType);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0xA59AEF0", Offset = "0xA5998F0", VA = "0x18A59AEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0xA59ADE0", Offset = "0xA5997E0", VA = "0x18A59ADE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public IReadOnlyDictionary<string, Accessor> VertexAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0xA59AE20", Offset = "0xA599820", VA = "0x18A59AE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public Accessor IndexAccessor
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0xA59AC20", Offset = "0xA599620", VA = "0x18A59AC20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xA599680", Offset = "0xA598080", VA = "0x18A599680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xA5974E0", Offset = "0xA595EE0", VA = "0x18A5974E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xA599470", Offset = "0xA597E70", VA = "0x18A599470", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xA599F00", Offset = "0xA598900", VA = "0x18A599F00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5994F0", Offset = "0xA597EF0", VA = "0x18A5994F0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5967A0", Offset = "0xA5951A0", VA = "0x18A5967A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA59AA70", Offset = "0xA599470", VA = "0x18A59AA70")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA59AAE0", Offset = "0xA5994E0", VA = "0x18A59AAE0")]
		internal MeshPrimitive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA599ED0", Offset = "0xA5988D0", VA = "0x18A599ED0", Slot = "18")]
		void IChildOfList<Mesh>.SetLogicalParent(Mesh parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA596990", Offset = "0xA595390", VA = "0x18A596990")]
		public IEnumerable<BufferView> GetBufferViews(bool includeIndices, bool includeVertices, bool includeMorphs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA597810", Offset = "0xA596210", VA = "0x18A597810")]
		public IReadOnlyList<KeyValuePair<string, Accessor>> GetVertexAccessorsByBuffer(BufferView vb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0xA597710", Offset = "0xA596110", VA = "0x18A597710")]
		public Accessor GetVertexAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0xA599D70", Offset = "0xA598770", VA = "0x18A599D70")]
		public void SetVertexAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B3C0", Offset = "0x3D09DC0", VA = "0x183D0B3C0")]
		internal IReadOnlyList<T> GetVertices<T>(string attributeKey) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xA596E50", Offset = "0xA595850", VA = "0x18A596E50")]
		public Accessor GetIndexAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xA599680", Offset = "0xA598080", VA = "0x18A599680")]
		public void SetIndexAccessor(Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xA596EF0", Offset = "0xA5958F0", VA = "0x18A596EF0")]
		public IList<uint> GetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0xA597270", Offset = "0xA595C70", VA = "0x18A597270")]
		public IEnumerable<int> GetPointIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xA596F20", Offset = "0xA595920", VA = "0x18A596F20")]
		public IEnumerable<(int, int)> GetLineIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA597510", Offset = "0xA595F10", VA = "0x18A597510")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA597120", Offset = "0xA595B20", VA = "0x18A597120")]
		public IReadOnlyDictionary<string, Accessor> GetMorphTargetAccessors(int targetIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA599780", Offset = "0xA598180", VA = "0x18A599780")]
		public void SetMorphTargetAccessors(int targetIdx, IReadOnlyDictionary<string, Accessor> accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA596510", Offset = "0xA594F10", VA = "0x18A596510")]
		internal static bool CheckAttributesQuantizationRequired(ModelRoot root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA596710", Offset = "0xA595110", VA = "0x18A596710")]
		private bool CheckAttributesQuantizationRequired()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA598E20", Offset = "0xA597820", VA = "0x18A598E20", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA597A90", Offset = "0xA596490", VA = "0x18A597A90", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0870", Offset = "0xA5BF270", VA = "0x18A5C0870", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE410", Offset = "0xA5BCE10", VA = "0x18A5BE410", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0FB0", Offset = "0xA5BF9B0", VA = "0x18A5C0FB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090D")]
			[Cpp2IlInjected.Address(RVA = "0xA5C06F0", Offset = "0xA5BF0F0", VA = "0x18A5C06F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xA5C02B0", Offset = "0xA5BECB0", VA = "0x18A5C02B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xA5C02B0", Offset = "0xA5BECB0", VA = "0x18A5C02B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5A6B50", Offset = "0xA5A5550", VA = "0x18A5A6B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public IReadOnlyList<MeshPrimitive> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60008F8")]
			[Cpp2IlInjected.Address(RVA = "0xA5A5C50", Offset = "0xA5A4650", VA = "0x18A5A5C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public bool AllPrimitivesHaveJoints
		{
			[Cpp2IlInjected.Token(Token = "0x60008F9")]
			[Cpp2IlInjected.Address(RVA = "0xA5A6A30", Offset = "0xA5A5430", VA = "0x18A5A6A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5DC0", Offset = "0xA5A47C0", VA = "0x18A5A5DC0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5A62D0", Offset = "0xA5A4CD0", VA = "0x18A5A62D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xA5A65E0", Offset = "0xA5A4FE0", VA = "0x18A5A65E0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6350", Offset = "0xA5A4D50", VA = "0x18A5A6350", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5B60", Offset = "0xA5A4560", VA = "0x18A5A5B60", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6870", Offset = "0xA5A5270", VA = "0x18A5A6870")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6970", Offset = "0xA5A5370", VA = "0x18A5A6970")]
		internal Mesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5C50", Offset = "0xA5A4650", VA = "0x18A5A5C50")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6460", Offset = "0xA5A4E60", VA = "0x18A5A6460")]
		public void SetMorphWeights(IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6470", Offset = "0xA5A4E70", VA = "0x18A5A6470")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5AE0", Offset = "0xA5A44E0", VA = "0x18A5A5AE0")]
		public MeshPrimitive CreatePrimitive()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6170", Offset = "0xA5A4B70", VA = "0x18A5A6170", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5DF0", Offset = "0xA5A47F0", VA = "0x18A5A5DF0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <Flatten>d__70(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE1D0", Offset = "0xA5BCBD0", VA = "0x18A5BE1D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xA5BDD00", Offset = "0xA5BC700", VA = "0x18A5BDD00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE370", Offset = "0xA5BCD70", VA = "0x18A5BE370")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE3C0", Offset = "0xA5BCDC0", VA = "0x18A5BE3C0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE190", Offset = "0xA5BCB90", VA = "0x18A5BE190", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE0F0", Offset = "0xA5BCAF0", VA = "0x18A5BE0F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE0F0", Offset = "0xA5BCAF0", VA = "0x18A5BE0F0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0DB0", Offset = "0xA5BF7B0", VA = "0x18A5C0DB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0xA5BECD0", Offset = "0xA5BD6D0", VA = "0x18A5BECD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xA5C10A0", Offset = "0xA5BFAA0", VA = "0x18A5C10A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0xA5C06B0", Offset = "0xA5BF0B0", VA = "0x18A5C06B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0210", Offset = "0xA5BEC10", VA = "0x18A5C0210", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0210", Offset = "0xA5BEC10", VA = "0x18A5C0210", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B6F30", Offset = "0xA5B5930", VA = "0x18A5B6F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Node VisualRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7040", Offset = "0xA5B5A40", VA = "0x18A5B7040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<Scene> VisualScenes
		{
			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B70B0", Offset = "0xA5B5AB0", VA = "0x18A5B70B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B4240", Offset = "0xA5B2C40", VA = "0x18A5B4240", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public bool IsSkinJoint
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6020", Offset = "0xA5B4A20", VA = "0x18A5B6020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public bool IsSkinSkeleton
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6130", Offset = "0xA5B4B30", VA = "0x18A5B6130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public Camera Camera
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5F20", Offset = "0xA5B4920", VA = "0x18A5B5F20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B75D0", Offset = "0xA5B5FD0", VA = "0x18A5B75D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public Mesh Mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6B60", Offset = "0xA5B5560", VA = "0x18A5B6B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0xA5B77B0", Offset = "0xA5B61B0", VA = "0x18A5B77B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public Skin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6E20", Offset = "0xA5B5820", VA = "0x18A5B6E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0xA5B79A0", Offset = "0xA5B63A0", VA = "0x18A5B79A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6C70", Offset = "0xA5B5670", VA = "0x18A5B6C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0xA5B74B0", Offset = "0xA5B5EB0", VA = "0x18A5B74B0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7B40", Offset = "0xA5B6540", VA = "0x18A5B7B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0xA5B69F0", Offset = "0xA5B53F0", VA = "0x18A5B69F0")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7770", Offset = "0xA5B6170", VA = "0x18A5B7770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000929")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6910", Offset = "0xA5B5310", VA = "0x18A5B6910")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600092A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B76B0", Offset = "0xA5B60B0", VA = "0x18A5B76B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6480", Offset = "0xA5B4E80", VA = "0x18A5B6480")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B71F0", Offset = "0xA5B5BF0", VA = "0x18A5B71F0")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool IsTransformAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6240", Offset = "0xA5B4C40", VA = "0x18A5B6240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		internal bool IsTransformDecomposed
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6420", Offset = "0xA5B4E20", VA = "0x18A5B6420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public PunctualLight PunctualLight
		{
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6C80", Offset = "0xA5B5680", VA = "0x18A5B6C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0xA5B78A0", Offset = "0xA5B62A0", VA = "0x18A5B78A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1B60", Offset = "0xA5B0560", VA = "0x18A5B1B60", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0xA5B23B0", Offset = "0xA5B0DB0", VA = "0x18A5B23B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0xA5B2C00", Offset = "0xA5B1600", VA = "0x18A5B2C00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xA5B2470", Offset = "0xA5B0E70", VA = "0x18A5B2470", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA5B0FF0", Offset = "0xA5AF9F0", VA = "0x18A5B0FF0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xA5B3CF0", Offset = "0xA5B26F0", VA = "0x18A5B3CF0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5C60", Offset = "0xA5B4660", VA = "0x18A5B5C60")]
		internal Node()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1740", Offset = "0xA5B0140", VA = "0x18A5B1740")]
		public AffineTransform GetLocalTransform(Animation animation, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1B90", Offset = "0xA5B0590", VA = "0x18A5B1B90")]
		public Matrix4x4 GetWorldMatrix(Animation animation, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1880", Offset = "0xA5B0280", VA = "0x18A5B1880")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xA5B28F0", Offset = "0xA5B12F0", VA = "0x18A5B28F0")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xA5B3BD0", Offset = "0xA5B25D0", VA = "0x18A5B3BD0")]
		internal static Node _FindVisualRootNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0xA5B0F90", Offset = "0xA5AF990", VA = "0x18A5B0F90", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1580", Offset = "0xA5AFF80", VA = "0x18A5B1580")]
		[IteratorStateMachine(typeof(<Flatten>d__70))]
		public static IEnumerable<Node> Flatten(IVisualNodeContainer container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1380", Offset = "0xA5AFD80", VA = "0x18A5B1380")]
		public static IEnumerable<Node> FindNodesUsingMesh(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1480", Offset = "0xA5AFE80", VA = "0x18A5B1480")]
		public static IEnumerable<Node> FindNodesUsingSkin(Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA5B3A60", Offset = "0xA5B2460", VA = "0x18A5B3A60")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA5B42D0", Offset = "0xA5B2CD0", VA = "0x18A5B42D0")]
		internal bool _HasVisualChild(int nodeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B4240", Offset = "0xA5B2C40", VA = "0x18A5B4240")]
		internal IEnumerable<Node> _GetVisualChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B4890", Offset = "0xA5B3290", VA = "0x18A5B4890")]
		internal void _SetVisualParent(Node parentNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B4330", Offset = "0xA5B2D30", VA = "0x18A5B4330")]
		internal void _RemoveFromVisualParent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1600", Offset = "0xA5B0000", VA = "0x18A5B1600")]
		public NodeCurveSamplers GetCurveSamplers(Animation animation)
		{
			return default(NodeCurveSamplers);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B4390", Offset = "0xA5B2D90", VA = "0x18A5B4390")]
		private void _SetLocalTransform(AffineTransform value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B2000", Offset = "0xA5B0A00", VA = "0x18A5B2000", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5000", Offset = "0xA5B3A00", VA = "0x18A5B5000")]
		internal static void _ValidateParentHierarchy(IEnumerable<Node> nodes, ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1E20", Offset = "0xA5B0820", VA = "0x18A5B1E20", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0xA5B4C70", Offset = "0xA5B3670", VA = "0x18A5B4C70")]
		private void _ValidateChildrenHierarchy(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xA5B56E0", Offset = "0xA5B40E0", VA = "0x18A5B56E0")]
		private void _ValidateTransforms(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xA5B4D70", Offset = "0xA5B3770", VA = "0x18A5B4D70")]
		private static void _ValidateMeshAndSkin(ValidationContext validate, Mesh mesh, Skin skin, List<double> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0xA5B1700", Offset = "0xA5B0100", VA = "0x18A5B1700")]
		public MeshGpuInstancing GetGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA5B39B0", Offset = "0xA5B23B0", VA = "0x18A5B39B0")]
		public MeshGpuInstancing UseGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA5B2430", Offset = "0xA5B0E30", VA = "0x18A5B2430")]
		public void RemoveGpuInstancing()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B2B90", Offset = "0xA5B1590", VA = "0x18A5B2B90")]
		public bool TryGetVisibility([Out] bool isVisible)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B2AE0", Offset = "0xA5B14E0", VA = "0x18A5B2AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C24C0", Offset = "0xA5C0EC0", VA = "0x18A5C24C0", Slot = "4")]
			public bool Equals(TextureSampler x, TextureSampler y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xA5C2660", Offset = "0xA5C1060", VA = "0x18A5C2660", Slot = "5")]
			public int GetHashCode(TextureSampler obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099C")]
			[Cpp2IlInjected.Address(RVA = "0xA5C09F0", Offset = "0xA5BF3F0", VA = "0x18A5C09F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE9B0", Offset = "0xA5BD3B0", VA = "0x18A5BE9B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0E70", Offset = "0xA5BF870", VA = "0x18A5C0E70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0670", Offset = "0xA5BF070", VA = "0x18A5C0670", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0350", Offset = "0xA5BED50", VA = "0x18A5C0350", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0350", Offset = "0xA5BED50", VA = "0x18A5C0350", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BC6B0", Offset = "0xA5BB0B0", VA = "0x18A5BC6B0")]
			get
			{
				return default(TextureMipMapFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000987")]
			[Cpp2IlInjected.Address(RVA = "0xA5BC670", Offset = "0xA5BB070", VA = "0x18A5BC670")]
			get
			{
				return default(TextureInterpolationFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0xA5BC6F0", Offset = "0xA5BB0F0", VA = "0x18A5BC6F0")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0xA5BC730", Offset = "0xA5BB130", VA = "0x18A5BC730")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public static IEqualityComparer<TextureSampler> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xA5BC620", Offset = "0xA5BB020", VA = "0x18A5BC620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xA5BC770", Offset = "0xA5BB170", VA = "0x18A5BC770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBC00", Offset = "0xA5BA600", VA = "0x18A5BBC00", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBD40", Offset = "0xA5BA740", VA = "0x18A5BBD40", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBF40", Offset = "0xA5BA940", VA = "0x18A5BBF40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBDC0", Offset = "0xA5BA7C0", VA = "0x18A5BBDC0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xA5BB8B0", Offset = "0xA5BA2B0", VA = "0x18A5BB8B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC460", Offset = "0xA5BAE60", VA = "0x18A5BC460")]
		internal TextureSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC4F0", Offset = "0xA5BAEF0", VA = "0x18A5BC4F0")]
		internal TextureSampler(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBC30", Offset = "0xA5BA630", VA = "0x18A5BBC30")]
		internal static bool IsDefault(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xA5BB750", Offset = "0xA5BA150", VA = "0x18A5BB750")]
		public static bool AreEqualByContent(TextureSampler x, TextureSampler y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBC50", Offset = "0xA5BA650", VA = "0x18A5BBC50")]
		internal bool IsEqualTo(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBAE0", Offset = "0xA5BA4E0", VA = "0x18A5BBAE0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0AB0", Offset = "0xA5BF4B0", VA = "0x18A5C0AB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF1A0", Offset = "0xA5BDBA0", VA = "0x18A5BF1A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0EC0", Offset = "0xA5BF8C0", VA = "0x18A5C0EC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0xA5C07F0", Offset = "0xA5BF1F0", VA = "0x18A5C07F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0530", Offset = "0xA5BEF30", VA = "0x18A5C0530", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0530", Offset = "0xA5BEF30", VA = "0x18A5C0530", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0xA5B8BC0", Offset = "0xA5B75C0", VA = "0x18A5B8BC0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5B7DA0", Offset = "0xA5B67A0", VA = "0x18A5B7DA0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8320", Offset = "0xA5B6D20", VA = "0x18A5B8320", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8450", Offset = "0xA5B6E50", VA = "0x18A5B8450", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B83A0", Offset = "0xA5B6DA0", VA = "0x18A5B83A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xA5B7D00", Offset = "0xA5B6700", VA = "0x18A5B7D00", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B40", Offset = "0xA5B7540", VA = "0x18A5B8B40")]
		internal Scene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5B7CA0", Offset = "0xA5B66A0", VA = "0x18A5B7CA0", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8650", Offset = "0xA5B7050", VA = "0x18A5B8650")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8890", Offset = "0xA5B7290", VA = "0x18A5B8890")]
		internal void _RemoveVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8980", Offset = "0xA5B7380", VA = "0x18A5B8980")]
		internal void _UseVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B7DD0", Offset = "0xA5B67D0", VA = "0x18A5B7DD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0B70", Offset = "0xA5BF570", VA = "0x18A5C0B70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE6B0", Offset = "0xA5BD0B0", VA = "0x18A5BE6B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0xA5C1050", Offset = "0xA5BFA50", VA = "0x18A5C1050")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F1")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0830", Offset = "0xA5BF230", VA = "0x18A5C0830", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0170", Offset = "0xA5BEB70", VA = "0x18A5C0170", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0170", Offset = "0xA5BEB70", VA = "0x18A5C0170", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BB540", Offset = "0xA5B9F40", VA = "0x18A5BB540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public int JointsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xA5BB3D0", Offset = "0xA5B9DD0", VA = "0x18A5BB3D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public IReadOnlyList<Node> Joints
		{
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0xA5BB410", Offset = "0xA5B9E10", VA = "0x18A5BB410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public IReadOnlyList<Matrix4x4> InverseBindMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0xA5BB320", Offset = "0xA5B9D20", VA = "0x18A5BB320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public Node Skeleton
		{
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xA5BB4A0", Offset = "0xA5B9EA0", VA = "0x18A5BB4A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0xA5BB670", Offset = "0xA5BA070", VA = "0x18A5BB670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9DE0", Offset = "0xA5B87E0", VA = "0x18A5B9DE0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA710", Offset = "0xA5B9110", VA = "0x18A5BA710", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA8A0", Offset = "0xA5B92A0", VA = "0x18A5BA8A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA790", Offset = "0xA5B9190", VA = "0x18A5BA790", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B97E0", Offset = "0xA5B81E0", VA = "0x18A5B97E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BB2A0", Offset = "0xA5B9CA0", VA = "0x18A5BB2A0")]
		internal Skin()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5BAD80", Offset = "0xA5B9780", VA = "0x18A5BAD80")]
		public Accessor UseInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9AC0", Offset = "0xA5B84C0", VA = "0x18A5B9AC0")]
		public Accessor GetInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9BC0", Offset = "0xA5B85C0", VA = "0x18A5B9BC0")]
		public (Node, Matrix4x4) GetJoint(int idx)
		{
			return default((Node, Matrix4x4));
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9300", Offset = "0xA5B7D00", VA = "0x18A5B9300")]
		public void BindJoints(params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9380", Offset = "0xA5B7D80", VA = "0x18A5B9380")]
		public void BindJoints(Matrix4x4 meshBindTransform, params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8C50", Offset = "0xA5B7650", VA = "0x18A5B8C50")]
		public void BindJoints(IReadOnlyList<(Node Joint, Matrix4x4 InverseBindMatrix)> joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9E10", Offset = "0xA5B8810", VA = "0x18A5B9E10")]
		internal bool IsMatch(Node skeleton, KeyValuePair<Node, Matrix4x4>[] joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9900", Offset = "0xA5B8300", VA = "0x18A5B9900")]
		internal static IEnumerable<Skin> FindSkinsUsingJoint(Node jointNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B99E0", Offset = "0xA5B83E0", VA = "0x18A5B99E0")]
		internal static IEnumerable<Skin> FindSkinsUsingSkeleton(Node skeletonNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BAEA0", Offset = "0xA5B98A0", VA = "0x18A5BAEA0")]
		private Node _FindCommonAncestor(IEnumerable<Node> nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA230", Offset = "0xA5B8C30", VA = "0x18A5BA230", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA000", Offset = "0xA5B8A00", VA = "0x18A5BA000", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0C30", Offset = "0xA5BF630", VA = "0x18A5C0C30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0xA5BFB50", Offset = "0xA5BE550", VA = "0x18A5BFB50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0xA5C1000", Offset = "0xA5BFA00", VA = "0x18A5C1000")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0730", Offset = "0xA5BF130", VA = "0x18A5C0730", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0xA5C05D0", Offset = "0xA5BEFD0", VA = "0x18A5C05D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0xA5C05D0", Offset = "0xA5BEFD0", VA = "0x18A5C05D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BDB40", Offset = "0xA5BC540", VA = "0x18A5BDB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0xA5BDC40", Offset = "0xA5BC640", VA = "0x18A5BDC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public Image PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0xA5BDB30", Offset = "0xA5BC530", VA = "0x18A5BDB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public Image FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0xA5BDA70", Offset = "0xA5BC470", VA = "0x18A5BDA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC930", Offset = "0xA5BB330", VA = "0x18A5BC930", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCAB0", Offset = "0xA5BB4B0", VA = "0x18A5BCAB0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD2A0", Offset = "0xA5BBCA0", VA = "0x18A5BD2A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCB30", Offset = "0xA5BB530", VA = "0x18A5BCB30", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC860", Offset = "0xA5BB260", VA = "0x18A5BC860", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xA58F690", Offset = "0xA58E090", VA = "0x18A58F690")]
		internal Texture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD610", Offset = "0xA5BC010", VA = "0x18A5BD610")]
		private Image _GetPrimaryImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD550", Offset = "0xA5BBF50", VA = "0x18A5BD550")]
		private Image _GetFallbackImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCBC0", Offset = "0xA5BB5C0", VA = "0x18A5BCBC0")]
		public void SetImage(Image primaryImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCDF0", Offset = "0xA5BB7F0", VA = "0x18A5BCDF0")]
		public void SetImages(Image primaryImage, Image fallbackImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC7E0", Offset = "0xA5BB1E0", VA = "0x18A5BC7E0")]
		public void ClearImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD920", Offset = "0xA5BC320", VA = "0x18A5BD920")]
		private TextureDDS _UseDDSTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xA5BDA00", Offset = "0xA5BC400", VA = "0x18A5BDA00")]
		private TextureWEBP _UseWEBPTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD990", Offset = "0xA5BC390", VA = "0x18A5BD990")]
		private TextureKTX2 _UseKTX2Texture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD740", Offset = "0xA5BC140", VA = "0x18A5BD740")]
		internal bool _IsEqualentTo(Image primary, Image fallback, TextureSampler sampler)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC960", Offset = "0xA5BB360", VA = "0x18A5BC960", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0CF0", Offset = "0xA5BF6F0", VA = "0x18A5C0CF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF3F0", Offset = "0xA5BDDF0", VA = "0x18A5BF3F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0F60", Offset = "0xA5BF960", VA = "0x18A5C0F60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0xA5C07B0", Offset = "0xA5BF1B0", VA = "0x18A5C07B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9D")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0490", Offset = "0xA5BEE90", VA = "0x18A5C0490", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9E")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0490", Offset = "0xA5BEE90", VA = "0x18A5C0490", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0E60", Offset = "0xA5AF860", VA = "0x18A5B0E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public bool MeshQuantizationAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0E00", Offset = "0xA5AF800", VA = "0x18A5B0E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public IEnumerable<string> ExtensionsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public IEnumerable<string> ExtensionsRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public IEnumerable<string> IncompatibleExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0CB0", Offset = "0xA5AF6B0", VA = "0x18A5B0CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public IReadOnlyList<Material> LogicalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DC0", Offset = "0xCD57C0", VA = "0x180CD6DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public IReadOnlyList<Texture> LogicalTextures
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0xDB03C0", Offset = "0xDAEDC0", VA = "0x180DB03C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public IReadOnlyList<TextureSampler> LogicalTextureSamplers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B50", Offset = "0xCD8550", VA = "0x180CD9B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public IReadOnlyList<Image> LogicalImages
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0xCDAC20", Offset = "0xCD9620", VA = "0x180CDAC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public IReadOnlyList<Buffer> LogicalBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public IReadOnlyList<BufferView> LogicalBufferViews
		{
			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public IReadOnlyList<Accessor> LogicalAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public IReadOnlyList<Mesh> LogicalMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0xCD7530", Offset = "0xCD5F30", VA = "0x180CD7530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public IReadOnlyList<Skin> LogicalSkins
		{
			[Cpp2IlInjected.Token(Token = "0x6000A47")]
			[Cpp2IlInjected.Address(RVA = "0xCD9A10", Offset = "0xCD8410", VA = "0x180CD9A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public IReadOnlyList<Camera> LogicalCameras
		{
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C10", Offset = "0xCD5610", VA = "0x180CD6C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public IReadOnlyList<Node> LogicalNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xCDA170", Offset = "0xCD8B70", VA = "0x180CDA170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public IReadOnlyList<Scene> LogicalScenes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xD05C10", Offset = "0xD04610", VA = "0x180D05C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public IReadOnlyList<Animation> LogicalAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public Scene DefaultScene
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0C00", Offset = "0xA5AF600", VA = "0x18A5B0C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0EB0", Offset = "0xA5AF8B0", VA = "0x18A5B0EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public IReadOnlyList<PunctualLight> LogicalPunctualLights
		{
			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0D40", Offset = "0xA5AF740", VA = "0x18A5B0D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9630", Offset = "0xA5A8030", VA = "0x18A5A9630", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA5AB170", Offset = "0xA5A9B70", VA = "0x18A5AB170", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0xA5ABCA0", Offset = "0xA5AA6A0", VA = "0x18A5ABCA0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xA5AB6D0", Offset = "0xA5AA0D0", VA = "0x18A5AB6D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xA5A8450", Offset = "0xA5A6E50", VA = "0x18A5A8450", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7680", Offset = "0xA5A6080", VA = "0x18A5A7680")]
		public Accessor CreateAccessor([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7720", Offset = "0xA5A6120", VA = "0x18A5A7720")]
		public Animation CreateAnimation([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7950", Offset = "0xA5A6350", VA = "0x18A5A7950")]
		public Buffer CreateBuffer(int byteCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD8D0", Offset = "0xA5AC2D0", VA = "0x18A5AD8D0")]
		public Buffer UseBuffer(byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0xA5A99F0", Offset = "0xA5A83F0", VA = "0x18A5A99F0")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9E40", Offset = "0xA5A8840", VA = "0x18A5A9E40")]
		public void MergeBuffers(int maxSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9660", Offset = "0xA5A8060", VA = "0x18A5A9660")]
		public void IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xA5A77C0", Offset = "0xA5A61C0", VA = "0x18A5A77C0")]
		public BufferView CreateBufferView(int byteSize, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD1F0", Offset = "0xA5ABBF0", VA = "0x18A5AD1F0")]
		public BufferView UseBufferView(ArraySegment<byte> data, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD3F0", Offset = "0xA5ABDF0", VA = "0x18A5AD3F0")]
		public BufferView UseBufferView(byte[] buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD4F0", Offset = "0xA5ABEF0", VA = "0x18A5AD4F0")]
		public BufferView UseBufferView(Buffer buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7A00", Offset = "0xA5A6400", VA = "0x18A5A7A00")]
		public Camera CreateCamera([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD020", Offset = "0xA5ABA20", VA = "0x18A5AD020")]
		internal void UpdateExtensionsSupport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0xA5A8B80", Offset = "0xA5A7580", VA = "0x18A5A8B80")]
		internal IEnumerable<string> GatherUsedExtensions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0xA5AFE50", Offset = "0xA5AE850", VA = "0x18A5AFE50")]
		private void _SetExtensionUsage(string extension, bool used, bool required)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0xA5AFF70", Offset = "0xA5AE970", VA = "0x18A5AFF70")]
		internal void _ValidateExtensions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7AA0", Offset = "0xA5A64A0", VA = "0x18A5A7AA0")]
		public Image CreateImage([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xA5ADB30", Offset = "0xA5AC530", VA = "0x18A5ADB30")]
		public Image UseImage(MemoryImage imageContent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA400", Offset = "0xA5A8E00", VA = "0x18A5AA400")]
		public void MergeImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7BC0", Offset = "0xA5A65C0", VA = "0x18A5A7BC0")]
		public Material CreateMaterial([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7C60", Offset = "0xA5A6660", VA = "0x18A5A7C60")]
		public Mesh CreateMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF260", Offset = "0xA5ADC60", VA = "0x18A5AF260")]
		internal Node _FindVisualParentNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7B40", Offset = "0xA5A6540", VA = "0x18A5A7B40")]
		public Node CreateLogicalNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF180", Offset = "0xA5ADB80", VA = "0x18A5AF180")]
		internal Node _CreateVisualNode(IList<int> parentChildren)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6C80", Offset = "0xA5A5680", VA = "0x18A5A6C80")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7DA0", Offset = "0xA5A67A0", VA = "0x18A5A7DA0")]
		public static ModelRoot CreateModel()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0xA5B0780", Offset = "0xA5AF180", VA = "0x18A5B0780")]
		internal ModelRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0xA5A8040", Offset = "0xA5A6A40", VA = "0x18A5A8040")]
		public ModelRoot DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0xDF8EF0", Offset = "0xDF78F0", VA = "0x180DF8EF0", Slot = "16")]
		ModelRoot IConvertibleToGltf2.ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0xA5A93A0", Offset = "0xA5A7DA0", VA = "0x18A5A93A0")]
		internal IEnumerable<ExtraProperties> GetLogicalChildrenFlattened()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA610", Offset = "0xA5A9010", VA = "0x18A5AA610", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA5A0", Offset = "0xA5A8FA0", VA = "0x18A5AA5A0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7E70", Offset = "0xA5A6870", VA = "0x18A5A7E70")]
		public PunctualLight CreatePunctualLight(PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7ED0", Offset = "0xA5A68D0", VA = "0x18A5A7ED0")]
		public PunctualLight CreatePunctualLight(string name, PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0xA5ADF50", Offset = "0xA5AC950", VA = "0x18A5ADF50")]
		public Scene UseScene(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0xA5ADE00", Offset = "0xA5AC800", VA = "0x18A5ADE00")]
		public Scene UseScene(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7F40", Offset = "0xA5A6940", VA = "0x18A5A7F40")]
		public Skin CreateSkin([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE100", Offset = "0xA5ACB00", VA = "0x18A5AE100")]
		public TextureSampler UseTextureSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min, TextureInterpolationFilter mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE550", Offset = "0xA5ACF50", VA = "0x18A5AE550")]
		public Texture UseTexture(Image primary, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE580", Offset = "0xA5ACF80", VA = "0x18A5AE580")]
		public Texture UseTexture(Image primary, Image fallback, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE910", Offset = "0xA5AD310", VA = "0x18A5AE910")]
		public static ValidationResult Validate(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9810", Offset = "0xA5A8210", VA = "0x18A5A9810")]
		public static ModelRoot Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA7D0", Offset = "0xA5A91D0", VA = "0x18A5AA7D0")]
		public static ModelRoot ParseGLB(ArraySegment<byte> glb, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0xA5AAF80", Offset = "0xA5A9980", VA = "0x18A5AAF80")]
		public static ModelRoot ReadGLB(Stream stream, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0xA5A94D0", Offset = "0xA5A7ED0", VA = "0x18A5A94D0")]
		public static string[] GetSatellitePaths(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA9B0", Offset = "0xA5A93B0", VA = "0x18A5AA9B0")]
		private static string[] ParseSatellitePaths(ReadOnlyMemory<byte> json)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		internal void OnDeserializationCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xA5AFA60", Offset = "0xA5AE460", VA = "0x18A5AFA60")]
		internal void _ResolveSatelliteDependencies(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0xA5AB5D0", Offset = "0xA5A9FD0", VA = "0x18A5AB5D0")]
		public void Save(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xA5AB1F0", Offset = "0xA5A9BF0", VA = "0x18A5AB1F0")]
		public void SaveGLB(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0xA5AB3E0", Offset = "0xA5A9DE0", VA = "0x18A5AB3E0")]
		public void SaveGLTF(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9390", Offset = "0xA5A7D90", VA = "0x18A5A9390")]
		[Obsolete("Use GetJsonPreview", true)]
		public string GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0xA5A9390", Offset = "0xA5A7D90", VA = "0x18A5A9390")]
		public string GetJsonPreview()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF360", Offset = "0xA5ADD60", VA = "0x18A5AF360")]
		internal string _GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0xA5AEA60", Offset = "0xA5AD460", VA = "0x18A5AEA60")]
		public ArraySegment<byte> WriteGLB([Optional] WriteSettings settings)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0xA5AECA0", Offset = "0xA5AD6A0", VA = "0x18A5AECA0")]
		public void WriteGLB(Stream stream, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B03E0", Offset = "0xA5AEDE0", VA = "0x18A5B03E0")]
		internal void _WriteJSON(Stream sw, JsonWriterOptions options, JsonFilterCallback filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF680", Offset = "0xA5AE080", VA = "0x18A5AF680")]
		internal void _PrepareBuffersForSatelliteWriting(WriteContext context, string baseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF5D0", Offset = "0xA5ADFD0", VA = "0x18A5AF5D0")]
		internal void _PrepareBuffersForInternalWriting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF7D0", Offset = "0xA5AE1D0", VA = "0x18A5AF7D0")]
		internal void _PrepareImagesForWriting(WriteContext context, string baseName, bool isBinary, ResourceWriteMode rmode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0xA5AEDF0", Offset = "0xA5AD7F0", VA = "0x18A5AEDF0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABD")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB600", Offset = "0xA5DA000", VA = "0x18A5DB600", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB220", Offset = "0xA5D9C20", VA = "0x18A5DB220", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB6C0", Offset = "0xA5DA0C0", VA = "0x18A5DB6C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB5C0", Offset = "0xA5D9FC0", VA = "0x18A5DB5C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB520", Offset = "0xA5D9F20", VA = "0x18A5DB520", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB520", Offset = "0xA5D9F20", VA = "0x18A5DB520", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5A5870", Offset = "0xA5A4270", VA = "0x18A5A5870")]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0xA5A48C0", Offset = "0xA5A32C0", VA = "0x18A5A48C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DC0", Offset = "0xCD57C0", VA = "0x180CD6DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C80", Offset = "0xCD5680", VA = "0x180CD6C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0xA5A5AA0", Offset = "0xA5A44A0", VA = "0x18A5A5AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		internal bool _HasContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0xA5A5A00", Offset = "0xA5A4400", VA = "0x18A5A5A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4450", Offset = "0xA5A2E50", VA = "0x18A5A4450", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4790", Offset = "0xA5A3190", VA = "0x18A5A4790", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4CB0", Offset = "0xA5A36B0", VA = "0x18A5A4CB0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4810", Offset = "0xA5A3210", VA = "0x18A5A4810", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4190", Offset = "0xA5A2B90", VA = "0x18A5A4190", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0xA5A50A0", Offset = "0xA5A3AA0", VA = "0x18A5A50A0")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0xA58F690", Offset = "0xA58E090", VA = "0x18A58F690")]
		internal Image()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0xA5A42B0", Offset = "0xA5A2CB0", VA = "0x18A5A42B0")]
		private MemoryImage GetSatelliteContent()
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0xA5A48C0", Offset = "0xA5A32C0", VA = "0x18A5A48C0")]
		private void SetSatelliteContent(MemoryImage content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAE")]
		[Cpp2IlInjected.Address(RVA = "0xA5A49D0", Offset = "0xA5A33D0", VA = "0x18A5A49D0")]
		internal void TransferToInternalBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAF")]
		[Cpp2IlInjected.Address(RVA = "0xA5A51C0", Offset = "0xA5A3BC0", VA = "0x18A5A51C0")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB0")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5170", Offset = "0xA5A3B70", VA = "0x18A5A5170")]
		internal void _DiscardContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0xA5A54B0", Offset = "0xA5A3EB0", VA = "0x18A5A54B0")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0xA5A55B0", Offset = "0xA5A3FB0", VA = "0x18A5A55B0")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5380", Offset = "0xA5A3D80", VA = "0x18A5A5380")]
		private void _WriteAsBufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5060", Offset = "0xA5A3A60", VA = "0x18A5A5060")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4600", Offset = "0xA5A3000", VA = "0x18A5A4600", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4480", Offset = "0xA5A2E80", VA = "0x18A5A4480", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACC")]
			[Cpp2IlInjected.Address(RVA = "0xA5E38F0", Offset = "0xA5E22F0", VA = "0x18A5E38F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3860", Offset = "0xA5E2260", VA = "0x18A5E3860")]
		public _StaticBufferBuilder(int bufferIndex, int initialCapacity = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3660", Offset = "0xA5E2060", VA = "0x18A5E3660")]
		public int Append(byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA5E37C0", Offset = "0xA5E21C0", VA = "0x18A5E37C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4159DF0", Offset = "0x41587F0", VA = "0x184159DF0")]
			public static ExtensionEntry Create<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
			{
				return default(ExtensionEntry);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AD9")]
			[Cpp2IlInjected.Address(RVA = "0x23DE5F0", Offset = "0x23DCFF0", VA = "0x1823DE5F0")]
			public ExtensionEntry(string n, Type p, Type e, Func<JsonSerializable, JsonSerializable> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADA")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4B30", Offset = "0xA5C3530", VA = "0x18A5C4B30")]
			public bool IsMatch(Type parentType, string extensionName)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADB")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4AB0", Offset = "0xA5C34B0", VA = "0x18A5C4AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C5AA0", Offset = "0xA5C44A0", VA = "0x18A5C5AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4F40", Offset = "0xA5C3940", VA = "0x18A5C4F40")]
		static ExtensionsFactory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6780", Offset = "0x3AA5180", VA = "0x183AA6780")]
		[Obsolete("Use RegisterExtension(name, factory) instead.")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6480", Offset = "0x3AA4E80", VA = "0x183AA6480")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName, Func<TParent, JsonSerializable> factory) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4B90", Offset = "0xA5C3590", VA = "0x18A5C4B90")]
		internal static JsonSerializable Create(JsonSerializable parent, string extensionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4D60", Offset = "0xA5C3760", VA = "0x18A5C4D60")]
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
					[Cpp2IlInjected.Address(RVA = "0x4F06690", Offset = "0x4F05090", VA = "0x184F06690", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA5DA700", Offset = "0xA5D9100", VA = "0x18A5DA700", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000B20")]
				[Cpp2IlInjected.Address(RVA = "0x6662850", Offset = "0x6661250", VA = "0x186662850")]
				[DebuggerHidden]
				public <GetFields>d__3(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B21")]
				[Cpp2IlInjected.Address(RVA = "0xA5DA750", Offset = "0xA5D9150", VA = "0x18A5DA750", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B22")]
				[Cpp2IlInjected.Address(RVA = "0xA5DA2D0", Offset = "0xA5D8CD0", VA = "0x18A5DA2D0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B23")]
				[Cpp2IlInjected.Address(RVA = "0xA5DA810", Offset = "0xA5D9210", VA = "0x18A5DA810")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B25")]
				[Cpp2IlInjected.Address(RVA = "0xA5DA6C0", Offset = "0xA5D90C0", VA = "0x18A5DA6C0", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B27")]
				[Cpp2IlInjected.Address(RVA = "0xA5DA620", Offset = "0xA5D9020", VA = "0x18A5DA620", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B28")]
				[Cpp2IlInjected.Address(RVA = "0xA5DA620", Offset = "0xA5D9020", VA = "0x18A5DA620", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
			public _ExtensionsReflection(IReadOnlyList<JsonSerializable> extensions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B18")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2000", Offset = "0xA5E0A00", VA = "0x18A5E2000", Slot = "5")]
			public bool TryGetField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0xA5E1F80", Offset = "0xA5E0980", VA = "0x18A5E1F80", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B35")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <Flatten>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B36")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9FB0", Offset = "0xA5D89B0", VA = "0x18A5D9FB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B37")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9B30", Offset = "0xA5D8530", VA = "0x18A5D9B30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0xA5DA150", Offset = "0xA5D8B50", VA = "0x18A5DA150")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0xA5DA1A0", Offset = "0xA5D8BA0", VA = "0x18A5DA1A0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9F70", Offset = "0xA5D8970", VA = "0x18A5D9F70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3D")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9ED0", Offset = "0xA5D88D0", VA = "0x18A5D9ED0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3E")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9ED0", Offset = "0xA5D88D0", VA = "0x18A5D9ED0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3F")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <GetLogicalChildren>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B40")]
			[Cpp2IlInjected.Address(RVA = "0xA5DAFE0", Offset = "0xA5D99E0", VA = "0x18A5DAFE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0xA5DA860", Offset = "0xA5D9260", VA = "0x18A5DA860", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB180", Offset = "0xA5D9B80", VA = "0x18A5DB180")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB1D0", Offset = "0xA5D9BD0", VA = "0x18A5DB1D0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B45")]
			[Cpp2IlInjected.Address(RVA = "0xA5DAFA0", Offset = "0xA5D99A0", VA = "0x18A5DAFA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0xA5DAF00", Offset = "0xA5D9900", VA = "0x18A5DAF00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B48")]
			[Cpp2IlInjected.Address(RVA = "0xA5DAF00", Offset = "0xA5D9900", VA = "0x18A5DAF00", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B49")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBB10", Offset = "0xA5DA510", VA = "0x18A5DBB10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB710", Offset = "0xA5DA110", VA = "0x18A5DB710", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4C")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBBD0", Offset = "0xA5DA5D0", VA = "0x18A5DBBD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBAD0", Offset = "0xA5DA4D0", VA = "0x18A5DBAD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B50")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBA30", Offset = "0xA5DA430", VA = "0x18A5DBA30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBA30", Offset = "0xA5DA430", VA = "0x18A5DBA30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "14")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0xA5C6FA0", Offset = "0xA5C59A0", VA = "0x18A5C6FA0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0xA5C5E90", Offset = "0xA5C4890", VA = "0x18A5C5E90", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0xA5C64E0", Offset = "0xA5C4EE0", VA = "0x18A5C64E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__9))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6620", Offset = "0xA5C5020", VA = "0x18A5C6620", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0xA5C5E10", Offset = "0xA5C4810", VA = "0x18A5C5E10")]
		[IteratorStateMachine(typeof(<GetLogicalChildren>d__11))]
		protected IEnumerable<ExtraProperties> GetLogicalChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0xA5C5D90", Offset = "0xA5C4790", VA = "0x18A5C5D90")]
		[IteratorStateMachine(typeof(<Flatten>d__12))]
		protected static IEnumerable<ExtraProperties> Flatten(ExtraProperties container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9280", Offset = "0x3AA7C80", VA = "0x183AA9280")]
		protected static void SetProperty<TParent, TProperty, TValue>(TParent parent, TProperty property, TValue value) where TParent : ExtraProperties where TProperty : class where TValue : TProperty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8B90", Offset = "0x3AA7590", VA = "0x183AA8B90")]
		protected static ChildSetter<T> GetChildSetter<T>(T owner) where T : ExtraProperties
		{
			return default(ChildSetter<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8BE0", Offset = "0x3AA75E0", VA = "0x183AA8BE0")]
		public T GetExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9300", Offset = "0x3AA7D00", VA = "0x183AA9300")]
		public T UseExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8EC0", Offset = "0x3AA78C0", VA = "0x183AA8EC0")]
		public void SetExtension<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8C30", Offset = "0x3AA7630", VA = "0x183AA8C30")]
		public void RemoveExtensions<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8D20", Offset = "0x3AA7720", VA = "0x183AA8D20")]
		public void RemoveExtensions<T>() where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C60D0", Offset = "0xA5C4AD0", VA = "0x18A5C60D0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0xA5C5EC0", Offset = "0xA5C48C0", VA = "0x18A5C5EC0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6560", Offset = "0xA5C4F60", VA = "0x18A5C6560", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6C50", Offset = "0xA5C5650", VA = "0x18A5C6C50")]
		private static Dictionary<string, JsonSerializable> _ToDictionary(JsonSerializable context, IEnumerable<JsonSerializable> serializables)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0xA5C5C60", Offset = "0xA5C4660", VA = "0x18A5C5C60", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6970", Offset = "0xA5C5370", VA = "0x18A5C6970")]
		private static void _DeserializeExtensions(JsonSerializable parent, Utf8JsonReader reader, List<JsonSerializable> extensions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6F20", Offset = "0xA5C5920", VA = "0x18A5C6F20")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000B59")]
			[Cpp2IlInjected.Address(RVA = "0xF27430", Offset = "0xF25E30", VA = "0x180F27430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public bool HasDefaultContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0xA5CB1A0", Offset = "0xA5C9BA0", VA = "0x18A5CB1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5CB1B0", Offset = "0xA5C9BB0", VA = "0x18A5CB1B0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xA5CB550", Offset = "0xA5C9F50", VA = "0x18A5CB550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public IReadOnlyList<IMaterialParameter> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public Texture Texture
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0xA5CB290", Offset = "0xA5C9C90", VA = "0x18A5CB290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public TextureSampler TextureSampler
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0xA5CB220", Offset = "0xA5C9C20", VA = "0x18A5CB220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0xA5CB210", Offset = "0xA5C9C10", VA = "0x18A5CB210")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0xA5CB250", Offset = "0xA5C9C50", VA = "0x18A5CB250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0xA5CAF70", Offset = "0xA5C9970", VA = "0x18A5CAF70")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0xA5CB320", Offset = "0xA5C9D20", VA = "0x18A5CB320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0xA5CAD50", Offset = "0xA5C9750", VA = "0x18A5CAD50")]
		internal MaterialChannel(Material m, string key, _MaterialTexture texInfo, params IMaterialParameter[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA5A0", Offset = "0xA5C8FA0", VA = "0x18A5CA5A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA370", Offset = "0xA5C8D70", VA = "0x18A5CA370", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA430", Offset = "0xA5C8E30", VA = "0x18A5CA430", Slot = "4")]
		public bool Equals(MaterialChannel other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB2A0", Offset = "0xA5C9CA0", VA = "0x18A5CB2A0")]
		public static bool operator ==([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB2E0", Offset = "0xA5C9CE0", VA = "0x18A5CB2E0")]
		public static bool operator !=([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA470", Offset = "0xA5C8E70", VA = "0x18A5CA470")]
		public float GetFactor(string key)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA600", Offset = "0xA5C9000", VA = "0x18A5CA600")]
		public void SetFactor(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0xA5CAC50", Offset = "0xA5C9650", VA = "0x18A5CAC50")]
		private Texture _GetTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA740", Offset = "0xA5C9140", VA = "0x18A5CA740")]
		public Texture SetTexture(int texCoord, Image primaryImg, [Optional] Image fallbackImg, TextureWrapMode ws = TextureWrapMode.REPEAT, TextureWrapMode wt = TextureWrapMode.REPEAT, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA8F0", Offset = "0xA5C92F0", VA = "0x18A5CA8F0")]
		public void SetTexture(int texSet, Texture tex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0xA5CAA40", Offset = "0xA5C9440", VA = "0x18A5CAA40")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0xA5CAB10", Offset = "0xA5C9510", VA = "0x18A5CAB10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AE1B00", Offset = "0x3AE0500", VA = "0x183AE1B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public TextureInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000B76")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2440", Offset = "0xA5E0E40", VA = "0x18A5E2440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B77")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2460", Offset = "0xA5E0E60", VA = "0x18A5E2460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0xA5E24F0", Offset = "0xA5E0EF0", VA = "0x18A5E24F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2530", Offset = "0xA5E0F30", VA = "0x18A5E2530")]
		public static implicit operator _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
			return default(_MaterialTexture);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2240", Offset = "0xA5E0C40", VA = "0x18A5E2240")]
		public _MaterialTexture(Func<TextureInfo> getter, Action initialize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2330", Offset = "0xA5E0D30", VA = "0x18A5E2330")]
		public _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2220", Offset = "0xA5E0C20", VA = "0x18A5E2220")]
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
			[Cpp2IlInjected.Address(RVA = "0x51C5D00", Offset = "0x51C4700", VA = "0x1851C5D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x51C5870", Offset = "0x51C4270", VA = "0x1851C5870", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000B87")]
			[Cpp2IlInjected.Address(RVA = "0x51C6100", Offset = "0x51C4B00", VA = "0x1851C6100", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x51C63C0", Offset = "0x51C4DC0", VA = "0x1851C63C0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x51C65E0", Offset = "0x51C4FE0", VA = "0x1851C65E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		object IMaterialParameter.Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0x51C4560", Offset = "0x51C2F60", VA = "0x1851C4560", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8B")]
			[Cpp2IlInjected.Address(RVA = "0x51C4990", Offset = "0x51C3390", VA = "0x1851C4990", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x51C52C0", Offset = "0x51C3CC0", VA = "0x1851C52C0")]
		internal _MaterialParameter(_MaterialParameterKey key, T defval, Func<T> getter, Action<T> setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x51C3510", Offset = "0x51C1F10", VA = "0x1851C3510")]
		internal static Vector4 Combine(IReadOnlyList<IMaterialParameter> parameters)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x51C1280", Offset = "0x51BFC80", VA = "0x1851C1280")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D5F10", Offset = "0xA5D4910", VA = "0x18A5D5F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public bool HasMorphingCurves
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0xE19A30", Offset = "0xE18430", VA = "0x180E19A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public IAnimationSampler<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public IAnimationSampler<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public IAnimationSampler<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D5F70", Offset = "0xA5D4970", VA = "0x18A5D5F70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D5F30", Offset = "0xA5D4930", VA = "0x18A5D5F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public IAnimationSampler<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0xA5D59F0", Offset = "0xA5D43F0", VA = "0x18A5D59F0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5BA0", Offset = "0xA5D45A0", VA = "0x18A5D5BA0")]
		internal NodeCurveSamplers(Node node, Animation animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDDA0", Offset = "0x7DBC7A0", VA = "0x187DBDDA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5270", Offset = "0xA5D3C70", VA = "0x18A5D5270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5FB0", Offset = "0xA5D49B0", VA = "0x18A5D5FB0")]
		public static bool operator ==([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5FE0", Offset = "0xA5D49E0", VA = "0x18A5D5FE0")]
		public static bool operator !=([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5240", Offset = "0xA5D3C40", VA = "0x18A5D5240", Slot = "4")]
		public bool Equals(NodeCurveSamplers other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x37D2C80", Offset = "0x37D1680", VA = "0x1837D2C80")]
		public IAnimationSampler<TWeights> GetMorphingSampler<TWeights>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D52F0", Offset = "0xA5D3CF0", VA = "0x18A5D52F0")]
		public AffineTransform GetLocalTransform(float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x3D41730", Offset = "0x3D40130", VA = "0x183D41730")]
		public IReadOnlyList<float> GetMorphingWeights<TWeight>(float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0xA5D57A0", Offset = "0xA5D41A0", VA = "0x18A5D57A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5E1410", Offset = "0xA5DFE10", VA = "0x18A5E1410")]
		public static Memory<byte> ReadBytesToEnd(this Stream s)
		{
			return default(Memory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1F30", Offset = "0xA5E0930", VA = "0x18A5E1F30")]
		internal static bool _TryReadUInt32(this BinaryReader r, [Out] uint result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1A70", Offset = "0xA5E0470", VA = "0x18A5E1A70")]
		internal static bool _Identify(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0DC0", Offset = "0xA5DF7C0", VA = "0x18A5E0DC0")]
		internal static bool IsBinaryHeader(ReadOnlySpan<byte> span)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0E50", Offset = "0xA5DF850", VA = "0x18A5E0E50")]
		public static bool IsBinaryHeader(byte a, byte b, byte c, byte d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0E80", Offset = "0xA5DF880", VA = "0x18A5E0E80")]
		public static IReadOnlyDictionary<uint, byte[]> ReadBinaryFile(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1C30", Offset = "0xA5E0630", VA = "0x18A5E1C30")]
		private static long _ReadBinaryHeader(BinaryReader binaryReader)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0C40", Offset = "0xA5DF640", VA = "0x18A5E0C40")]
		public static Exception IsBinaryCompatible(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1740", Offset = "0xA5E0140", VA = "0x18A5E1740")]
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
			[Cpp2IlInjected.Address(RVA = "0xF54E40", Offset = "0xF53840", VA = "0x180F54E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(RVA = "0xF549E0", Offset = "0xF533E0", VA = "0x180F549E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6BD0", Offset = "0xA5D55D0", VA = "0x18A5D6BD0")]
		public static ReadContext Create(FileReaderCallback callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6910", Offset = "0xA5D5310", VA = "0x18A5D6910")]
		public static ReadContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6790", Offset = "0xA5D5190", VA = "0x18A5D6790")]
		public static ReadContext CreateFromDictionary(IReadOnlyDictionary<string, ArraySegment<byte>> dictionary, bool checkExtensions = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8F80", Offset = "0xA5D7980", VA = "0x18A5D8F80")]
		private ReadContext(FileReaderCallback reader, [Optional] UriResolver uriResolver, bool checkExtensions = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8090", Offset = "0xA5D6A90", VA = "0x18A5D8090")]
		public ReadContext WithSettingsFrom(ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8FF0", Offset = "0xA5D79F0", VA = "0x18A5D8FF0")]
		internal ReadContext(ReadContext other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7CA0", Offset = "0xA5D66A0", VA = "0x18A5D7CA0")]
		public bool TryGetFullPath(string relativeUri, [Out] string fullPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6D90", Offset = "0xA5D5790", VA = "0x18A5D6D90")]
		public Stream OpenFile(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6EC0", Offset = "0xA5D58C0", VA = "0x18A5D6EC0")]
		public ArraySegment<byte> ReadAllBytesToEnd(string resourceName)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7D00", Offset = "0xA5D6700", VA = "0x18A5D7D00")]
		public ValidationResult Validate(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7500", Offset = "0xA5D5F00", VA = "0x18A5D7500")]
		public ModelRoot ReadSchema2(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7760", Offset = "0xA5D6160", VA = "0x18A5D7760")]
		public ModelRoot ReadSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7AD0", Offset = "0xA5D64D0", VA = "0x18A5D7AD0")]
		public ModelRoot ReadTextSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6F80", Offset = "0xA5D5980", VA = "0x18A5D6F80")]
		public ModelRoot ReadBinarySchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8170", Offset = "0xA5D6B70", VA = "0x18A5D8170")]
		private static ModelRoot _FilterErrors((ModelRoot Model, ValidationResult Validation) mv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8330", Offset = "0xA5D6D30", VA = "0x18A5D8330")]
		private (ModelRoot, ValidationResult) _ReadGLB(Stream stream)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8770", Offset = "0xA5D7170", VA = "0x18A5D8770")]
		private (ModelRoot, ValidationResult) _Read(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D81F0", Offset = "0xA5D6BF0", VA = "0x18A5D81F0")]
		private ReadOnlyMemory<byte> _Preprocess(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default(ReadOnlyMemory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6CE0", Offset = "0xA5D56E0", VA = "0x18A5D6CE0")]
		public static bool IdentifyBinaryContainer(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D72B0", Offset = "0xA5D5CB0", VA = "0x18A5D72B0")]
		public static string ReadJson(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7110", Offset = "0xA5D5B10", VA = "0x18A5D7110")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0xCDD360", Offset = "0xCDBD60", VA = "0x180CDD360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public ImageDecodeCallback ImageDecoder
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE3")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public JsonFilterCallback JsonPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9350", Offset = "0xA5D7D50", VA = "0x18A5D9350")]
		public static implicit operator ReadSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9340", Offset = "0xA5D7D40", VA = "0x18A5D9340")]
		public ReadSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9220", Offset = "0xA5D7C20", VA = "0x18A5D9220")]
		public ReadSettings(ReadSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9140", Offset = "0xA5D7B40", VA = "0x18A5D9140")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6C10", Offset = "0xCD5610", VA = "0x180CD6C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0xCD7510", Offset = "0xCD5F10", VA = "0x180CD7510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		internal bool _UpdateSupportedExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFA")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E20", Offset = "0xCD5820", VA = "0x180CD6E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C70", Offset = "0xCD5670", VA = "0x180CD6C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		internal bool _NoCloneWatchdog
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFC")]
			[Cpp2IlInjected.Address(RVA = "0xCD7500", Offset = "0xCD5F00", VA = "0x180CD7500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFD")]
			[Cpp2IlInjected.Address(RVA = "0xCD6D90", Offset = "0xCD5790", VA = "0x180CD6D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF520", Offset = "0xA5DDF20", VA = "0x18A5DF520")]
		public static WriteContext Create(FileWriterCallback fileCallback, [Optional] Func<string, Stream> streamWriteCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF0A0", Offset = "0xA5DDAA0", VA = "0x18A5DF0A0")]
		public static WriteContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEED0", Offset = "0xA5DD8D0", VA = "0x18A5DEED0")]
		public static WriteContext CreateFromDictionary(IDictionary<string, ArraySegment<byte>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF2E0", Offset = "0xA5DDCE0", VA = "0x18A5DF2E0")]
		public static WriteContext CreateFromStream(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF6C0", Offset = "0xA5DE0C0", VA = "0x18A5DF6C0")]
		public WriteContext WithTextSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF640", Offset = "0xA5DE040", VA = "0x18A5DF640")]
		public WriteContext WithBinarySettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF690", Offset = "0xA5DE090", VA = "0x18A5DF690")]
		public WriteContext WithSettingsFrom(WriteSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF680", Offset = "0xA5DE080", VA = "0x18A5DF680")]
		internal WriteContext WithDeepCloneSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0940", Offset = "0xA5DF340", VA = "0x18A5E0940")]
		private WriteContext(FileWriterCallback byteWriteCallback, Func<string, Stream> streamWriteCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF6E0", Offset = "0xA5DE0E0", VA = "0x18A5DF6E0")]
		public void WriteAllBytesToEnd(string fileName, ArraySegment<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DFCE0", Offset = "0xA5DE6E0", VA = "0x18A5DFCE0")]
		public string WriteImage(string assetName, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0xA5DFF10", Offset = "0xA5DE910", VA = "0x18A5DFF10")]
		public void WriteTextSchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF720", Offset = "0xA5DE120", VA = "0x18A5DF720")]
		public void WriteBinarySchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0xA5E07C0", Offset = "0xA5DF1C0", VA = "0x18A5E07C0")]
		private void _ValidateBeforeWriting(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0xA5E03B0", Offset = "0xA5DEDB0", VA = "0x18A5E03B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			[CompilerGenerated]
			get
			{
				return default(ResourceWriteMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0xD29750", Offset = "0xD28150", VA = "0x180D29750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public ImageWriterCallback ImageWriteCallback
		{
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000C15")]
			[Cpp2IlInjected.Address(RVA = "0xD2F810", Offset = "0xD2E210", VA = "0x180D2F810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C16")]
			[Cpp2IlInjected.Address(RVA = "0xD300E0", Offset = "0xD2EAE0", VA = "0x180D300E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public int BuffersMaxSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000C17")]
			[Cpp2IlInjected.Address(RVA = "0xD25F70", Offset = "0xD24970", VA = "0x180D25F70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C18")]
			[Cpp2IlInjected.Address(RVA = "0x16D02A0", Offset = "0x16CECA0", VA = "0x1816D02A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public bool JsonIndented
		{
			[Cpp2IlInjected.Token(Token = "0x6000C19")]
			[Cpp2IlInjected.Address(RVA = "0xA5E0BB0", Offset = "0xA5DF5B0", VA = "0x18A5E0BB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1A")]
			[Cpp2IlInjected.Address(RVA = "0xA5E0C30", Offset = "0xA5DF630", VA = "0x18A5E0C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public JsonWriterOptions JsonOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1B")]
			[Cpp2IlInjected.Address(RVA = "0xEFDE50", Offset = "0xEFC850", VA = "0x180EFDE50")]
			get
			{
				return default(JsonWriterOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0x4BC1050", Offset = "0x4BBFA50", VA = "0x184BC1050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public ValidationMode Validation
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(RVA = "0xD05F80", Offset = "0xD04980", VA = "0x180D05F80")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(RVA = "0xDECAD0", Offset = "0xDEB4D0", VA = "0x180DECAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public JsonFilterCallback JsonPostprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C20")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0BC0", Offset = "0xA5DF5C0", VA = "0x18A5E0BC0")]
		public static implicit operator WriteSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0AB0", Offset = "0xA5DF4B0", VA = "0x18A5E0AB0")]
		public WriteSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0AD0", Offset = "0xA5DF4D0", VA = "0x18A5E0AD0")]
		public WriteSettings(WriteSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0xA5E09B0", Offset = "0xA5DF3B0", VA = "0x18A5E09B0")]
		public void CopyTo(WriteSettings other)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	internal static class _Schema2Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3000", Offset = "0xA5E1A00", VA = "0x18A5E3000")]
		public static void SetMorphWeights(this IList<double> list, int maxCount, SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2A40", Offset = "0xA5E1440", VA = "0x18A5E2A40")]
		public static void SetMorphWeights(this IList<double> list, IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2550", Offset = "0xA5E0F50", VA = "0x18A5E2550")]
		internal static string AsName(this string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x41573F0", Offset = "0x4155DF0", VA = "0x1841573F0")]
		internal static T AsValue<T>(this T? value, T defval) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x41561B0", Offset = "0x4154BB0", VA = "0x1841561B0")]
		internal static T? AsNullable<T>(this T value, T defval) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x4156260", Offset = "0x4154C60", VA = "0x184156260")]
		internal static T? AsNullable<T>(this T value, T defval, T minval, T maxval) where T : struct, IEquatable<T>, IComparable<T>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2580", Offset = "0xA5E0F80", VA = "0x18A5E2580")]
		internal static Vector2? AsNullable(this Vector2 value, Vector2 defval, Vector2 minval, Vector2 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0xA5E26B0", Offset = "0xA5E10B0", VA = "0x18A5E26B0")]
		internal static Vector3? AsNullable(this Vector3 value, Vector3 defval, Vector3 minval, Vector3 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2840", Offset = "0xA5E1240", VA = "0x18A5E2840")]
		internal static Vector4? AsNullable(this Vector4 value, Vector4 defval, Vector4 minval, Vector4 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2A10", Offset = "0xA5E1410", VA = "0x18A5E2A10")]
		internal static string AsNullable(this string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2550", Offset = "0xA5E0F50", VA = "0x18A5E2550")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C7320", Offset = "0xA5C5D20", VA = "0x18A5C7320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C7330", Offset = "0xA5C5D30", VA = "0x18A5C7330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C71C0", Offset = "0xA5C5BC0", VA = "0x18A5C71C0")]
		public static void Verify(IReflectionObject reflectionObject, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6FE0", Offset = "0xA5C59E0", VA = "0x18A5C6FE0")]
		public static FieldInfo From(IReflectionObject reflectionObject, string path)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x3ABE5E0", Offset = "0x3ABCFE0", VA = "0x183ABE5E0")]
		public static FieldInfo From<TInstance, TValue>(string name, TInstance instance, Func<TInstance, TValue> getter)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0xA5C72B0", Offset = "0xA5C5CB0", VA = "0x18A5C72B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4F06690", Offset = "0x4F05090", VA = "0x184F06690", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5DBF60", Offset = "0xA5DA960", VA = "0x18A5DBF60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C44")]
			[Cpp2IlInjected.Address(RVA = "0x6662850", Offset = "0x6661250", VA = "0x186662850")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C45")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBFB0", Offset = "0xA5DA9B0", VA = "0x18A5DBFB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBC20", Offset = "0xA5DA620", VA = "0x18A5DBC20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0xA5DC070", Offset = "0xA5DAA70", VA = "0x18A5DC070")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBF20", Offset = "0xA5DA920", VA = "0x18A5DBF20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4B")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBE80", Offset = "0xA5DA880", VA = "0x18A5DBE80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBE80", Offset = "0xA5DA880", VA = "0x18A5DBE80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public const string SCHEMANAME = "Object";

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA290", Offset = "0xA5C8C90", VA = "0x18A5CA290", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C68D0", Offset = "0xA5C52D0", VA = "0x18A5C68D0", Slot = "11")]
		protected virtual IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA360", Offset = "0xA5C8D60", VA = "0x18A5CA360", Slot = "12")]
		protected virtual bool TryReflectField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA2C0", Offset = "0xA5C8CC0", VA = "0x18A5CA2C0", Slot = "9")]
		[IteratorStateMachine(typeof(<SharpGLTF-Reflection-IReflectionObject-GetFields>d__4))]
		IEnumerable<FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA340", Offset = "0xA5C8D40", VA = "0x18A5CA340", Slot = "10")]
		bool IReflectionObject.TryGetField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA280", Offset = "0xA5C8C80", VA = "0x18A5CA280", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C3300", Offset = "0xA5C1D00", VA = "0x18A5C3300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2D10", Offset = "0xA5C1710", VA = "0x18A5C2D10")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3460", Offset = "0xA5C1E60", VA = "0x18A5C3460")]
		public static implicit operator AttributeFormat(IndexEncodingType indexer)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3390", Offset = "0xA5C1D90", VA = "0x18A5C3390")]
		public static implicit operator AttributeFormat(EncodingType enc)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3410", Offset = "0xA5C1E10", VA = "0x18A5C3410")]
		public static implicit operator AttributeFormat(DimensionType dim)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0xA5C34B0", Offset = "0xA5C1EB0", VA = "0x18A5C34B0")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0xA5C33D0", Offset = "0xA5C1DD0", VA = "0x18A5C33D0")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc, bool nrm) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3260", Offset = "0xA5C1C60", VA = "0x18A5C3260")]
		public AttributeFormat(IndexEncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3110", Offset = "0xA5C1B10", VA = "0x18A5C3110")]
		public AttributeFormat(EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0xA5C32B0", Offset = "0xA5C1CB0", VA = "0x18A5C32B0")]
		public AttributeFormat(DimensionType dim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3150", Offset = "0xA5C1B50", VA = "0x18A5C3150")]
		public AttributeFormat(DimensionType dim, EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3190", Offset = "0xA5C1B90", VA = "0x18A5C3190")]
		public AttributeFormat(DimensionType dim, EncodingType enc, bool nrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2CA0", Offset = "0xA5C16A0", VA = "0x18A5C2CA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2B00", Offset = "0xA5C1500", VA = "0x18A5C2B00")]
		public static bool AreEqual(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2B20", Offset = "0xA5C1520", VA = "0x18A5C2B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2C10", Offset = "0xA5C1610", VA = "0x18A5C2C10", Slot = "4")]
		public bool Equals(AttributeFormat other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3310", Offset = "0xA5C1D10", VA = "0x18A5C3310")]
		public static bool operator ==(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3500", Offset = "0xA5C1F00", VA = "0x18A5C3500")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C43D0", Offset = "0xA5C2DD0", VA = "0x18A5C43D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0xA5C42A0", Offset = "0xA5C2CA0", VA = "0x18A5C42A0", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4450", Offset = "0xA5C2E50", VA = "0x18A5C4450", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4240", Offset = "0xA5C2C40", VA = "0x18A5C4240")]
		public ColorArray(Memory<byte> source, int byteStride = 0, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0xA5C40E0", Offset = "0xA5C2AE0", VA = "0x18A5C40E0")]
		public ColorArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3D80", Offset = "0xA5C2780", VA = "0x18A5C3D80", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4020", Offset = "0xA5C2A20", VA = "0x18A5C4020", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3AA0", Offset = "0xA5C24A0", VA = "0x18A5C3AA0", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3E40", Offset = "0xA5C2840", VA = "0x18A5C3E40", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3B40", Offset = "0xA5C2540", VA = "0x18A5C3B40", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3C60", Offset = "0xA5C2660", VA = "0x18A5C3C60")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3FA0", Offset = "0xA5C29A0", VA = "0x18A5C3FA0", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3FE0", Offset = "0xA5C29E0", VA = "0x18A5C3FE0", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3EE0", Offset = "0xA5C28E0", VA = "0x18A5C3EE0", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3F20", Offset = "0xA5C2920", VA = "0x18A5C3F20", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3F60", Offset = "0xA5C2960", VA = "0x18A5C3F60", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x5BC39D0", Offset = "0x5BC23D0", VA = "0x185BC39D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x5BC31D0", Offset = "0x5BC1BD0", VA = "0x185BC31D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3710", Offset = "0x5BC2110", VA = "0x185BC3710")]
		public EncodedArrayEnumerator(IReadOnlyList<T> accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x5BC2FA0", Offset = "0x5BC19A0", VA = "0x185BC2FA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x5BC2FB0", Offset = "0x5BC19B0", VA = "0x185BC2FB0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	internal static class EncodedArrayUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0xA5C44F0", Offset = "0xA5C2EF0", VA = "0x18A5C44F0")]
		public static void _CopyTo(this IEnumerable<int> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0xA5C47D0", Offset = "0xA5C31D0", VA = "0x18A5C47D0")]
		public static void _CopyTo(this IEnumerable<bool> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x3938AF0", Offset = "0x39374F0", VA = "0x183938AF0")]
		public static void _CopyTo<T>(this IEnumerable<T> src, IList<T> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x393A6C0", Offset = "0x39390C0", VA = "0x18393A6C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C90C0", Offset = "0xA5C7AC0", VA = "0x18A5C90C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000C92")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C93")]
			[Cpp2IlInjected.Address(RVA = "0xA5C9140", Offset = "0xA5C7B40", VA = "0x18A5C9140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C94")]
			[Cpp2IlInjected.Address(RVA = "0xA5C9230", Offset = "0xA5C7C30", VA = "0x18A5C9230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public float this[int rowIndex, int subIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C95")]
			[Cpp2IlInjected.Address(RVA = "0xA5C9100", Offset = "0xA5C7B00", VA = "0x18A5C9100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C96")]
			[Cpp2IlInjected.Address(RVA = "0xA5C9170", Offset = "0xA5C7B70", VA = "0x18A5C9170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C84E0", Offset = "0xA5C6EE0", VA = "0x18A5C84E0")]
		public FloatingAccessor(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7BB0", Offset = "0xA5C65B0", VA = "0x18A5C7BB0")]
		private float _GetValueU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8390", Offset = "0xA5C6D90", VA = "0x18A5C8390")]
		private void _SetValueU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7760", Offset = "0xA5C6160", VA = "0x18A5C7760")]
		private float _GetValueS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7F90", Offset = "0xA5C6990", VA = "0x18A5C7F90")]
		private void _SetValueS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0xA5C78D0", Offset = "0xA5C62D0", VA = "0x18A5C78D0")]
		private float _GetValueU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0xA5C80E0", Offset = "0xA5C6AE0", VA = "0x18A5C80E0")]
		private void _SetValueU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0xA5C75F0", Offset = "0xA5C5FF0", VA = "0x18A5C75F0")]
		private float _GetValueS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7E40", Offset = "0xA5C6840", VA = "0x18A5C7E40")]
		private void _SetValueS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7A40", Offset = "0xA5C6440", VA = "0x18A5C7A40")]
		private float _GetValueU32(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8230", Offset = "0xA5C6C30", VA = "0x18A5C8230")]
		private void _SetValueU32(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0xA5C75D0", Offset = "0xA5C5FD0", VA = "0x18A5C75D0")]
		private float _GetNormalizedU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7E30", Offset = "0xA5C6830", VA = "0x18A5C7E30")]
		private void _SetNormalizedU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7530", Offset = "0xA5C5F30", VA = "0x18A5C7530")]
		private float _GetNormalizedS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7DA0", Offset = "0xA5C67A0", VA = "0x18A5C7DA0")]
		private void _SetNormalizedS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0xA5C75B0", Offset = "0xA5C5FB0", VA = "0x18A5C75B0")]
		private float _GetNormalizedU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7E20", Offset = "0xA5C6820", VA = "0x18A5C7E20")]
		private void _SetNormalizedU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C74B0", Offset = "0xA5C5EB0", VA = "0x18A5C74B0")]
		private float _GetNormalizedS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7D20", Offset = "0xA5C6720", VA = "0x18A5C7D20")]
		private void _SetNormalizedS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x3AC4A90", Offset = "0x3AC3490", VA = "0x183AC4A90")]
		private T _GetValue<T>(int byteOffset) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5380", Offset = "0x3AC3D80", VA = "0x183AC5380")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D9A90", Offset = "0xA5D8490", VA = "0x18A5D9A90")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA3")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA4")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9A60", Offset = "0xA5D8460", VA = "0x18A5D9A60", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA5")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9B10", Offset = "0xA5D8510", VA = "0x18A5D9B10", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0xA5D99C0", Offset = "0xA5D83C0", VA = "0x18A5D99C0")]
		public ScalarArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9920", Offset = "0xA5D8320", VA = "0x18A5D9920")]
		public ScalarArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0xA5D95F0", Offset = "0xA5D7FF0", VA = "0x18A5D95F0", Slot = "9")]
		public IEnumerator<float> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9870", Offset = "0xA5D8270", VA = "0x18A5D9870", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0xA5D93B0", Offset = "0xA5D7DB0", VA = "0x18A5D93B0", Slot = "20")]
		public bool Contains(float item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0xA5D96A0", Offset = "0xA5D80A0", VA = "0x18A5D96A0", Slot = "13")]
		public int IndexOf(float item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0xA5D93D0", Offset = "0xA5D7DD0", VA = "0x18A5D93D0", Slot = "21")]
		public void CopyTo(float[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D94E0", Offset = "0xA5D7EE0", VA = "0x18A5D94E0")]
		public void Fill(IEnumerable<float> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D97F0", Offset = "0xA5D81F0", VA = "0x18A5D97F0", Slot = "14")]
		void IList<float>.Insert(int index, float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9830", Offset = "0xA5D8230", VA = "0x18A5D9830", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9730", Offset = "0xA5D8130", VA = "0x18A5D9730", Slot = "18")]
		void ICollection<float>.Add(float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9770", Offset = "0xA5D8170", VA = "0x18A5D9770", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D97B0", Offset = "0xA5D81B0", VA = "0x18A5D97B0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5DDE80", Offset = "0xA5DC880", VA = "0x18A5DDE80")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		bool ICollection<Vector2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB5")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public Vector2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB6")]
			[Cpp2IlInjected.Address(RVA = "0xA5DDDF0", Offset = "0xA5DC7F0", VA = "0x18A5DDDF0", Slot = "11")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB7")]
			[Cpp2IlInjected.Address(RVA = "0xA5DDF00", Offset = "0xA5DC900", VA = "0x18A5DDF00", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDD50", Offset = "0xA5DC750", VA = "0x18A5DDD50")]
		public Vector2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDCB0", Offset = "0xA5DC6B0", VA = "0x18A5DDCB0")]
		public Vector2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD980", Offset = "0xA5DC380", VA = "0x18A5DD980", Slot = "9")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDC00", Offset = "0xA5DC600", VA = "0x18A5DDC00", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBA")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD740", Offset = "0xA5DC140", VA = "0x18A5DD740", Slot = "20")]
		public bool Contains(Vector2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDA30", Offset = "0xA5DC430", VA = "0x18A5DDA30", Slot = "13")]
		public int IndexOf(Vector2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBC")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD760", Offset = "0xA5DC160", VA = "0x18A5DD760", Slot = "21")]
		public void CopyTo(Vector2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD870", Offset = "0xA5DC270", VA = "0x18A5DD870")]
		public void Fill(IEnumerable<Vector2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBE")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDB80", Offset = "0xA5DC580", VA = "0x18A5DDB80", Slot = "14")]
		void IList<Vector2>.Insert(int index, Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDBC0", Offset = "0xA5DC5C0", VA = "0x18A5DDBC0", Slot = "15")]
		void IList<Vector2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDAC0", Offset = "0xA5DC4C0", VA = "0x18A5DDAC0", Slot = "18")]
		void ICollection<Vector2>.Add(Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDB00", Offset = "0xA5DC500", VA = "0x18A5DDB00", Slot = "19")]
		void ICollection<Vector2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDB40", Offset = "0xA5DC540", VA = "0x18A5DDB40", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5DE770", Offset = "0xA5DD170", VA = "0x18A5DE770")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		bool ICollection<Vector3>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC7")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public Vector3 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0xA5DE6A0", Offset = "0xA5DD0A0", VA = "0x18A5DE6A0", Slot = "11")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC9")]
			[Cpp2IlInjected.Address(RVA = "0xA5DE7F0", Offset = "0xA5DD1F0", VA = "0x18A5DE7F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE560", Offset = "0xA5DCF60", VA = "0x18A5DE560")]
		public Vector3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE600", Offset = "0xA5DD000", VA = "0x18A5DE600")]
		public Vector3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCA")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE220", Offset = "0xA5DCC20", VA = "0x18A5DE220", Slot = "9")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE4B0", Offset = "0xA5DCEB0", VA = "0x18A5DE4B0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDF60", Offset = "0xA5DC960", VA = "0x18A5DDF60", Slot = "20")]
		public bool Contains(Vector3 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE2D0", Offset = "0xA5DCCD0", VA = "0x18A5DE2D0", Slot = "13")]
		public int IndexOf(Vector3 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE000", Offset = "0xA5DCA00", VA = "0x18A5DE000", Slot = "21")]
		public void CopyTo(Vector3[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE110", Offset = "0xA5DCB10", VA = "0x18A5DE110")]
		public void Fill(IEnumerable<Vector3> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE430", Offset = "0xA5DCE30", VA = "0x18A5DE430", Slot = "14")]
		void IList<Vector3>.Insert(int index, Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE470", Offset = "0xA5DCE70", VA = "0x18A5DE470", Slot = "15")]
		void IList<Vector3>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE370", Offset = "0xA5DCD70", VA = "0x18A5DE370", Slot = "18")]
		void ICollection<Vector3>.Add(Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE3B0", Offset = "0xA5DCDB0", VA = "0x18A5DE3B0", Slot = "19")]
		void ICollection<Vector3>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE3F0", Offset = "0xA5DCDF0", VA = "0x18A5DE3F0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5DEE50", Offset = "0xA5DD850", VA = "0x18A5DEE50")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD9")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDA")]
			[Cpp2IlInjected.Address(RVA = "0xA5D65F0", Offset = "0xA5D4FF0", VA = "0x18A5D65F0", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDB")]
			[Cpp2IlInjected.Address(RVA = "0xA5CBEA0", Offset = "0xA5CA8A0", VA = "0x18A5CBEA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBBB0", Offset = "0xA5CA5B0", VA = "0x18A5CBBB0")]
		public Vector4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBC50", Offset = "0xA5CA650", VA = "0x18A5CBC50")]
		public Vector4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDC")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEB20", Offset = "0xA5DD520", VA = "0x18A5DEB20", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEDA0", Offset = "0xA5DD7A0", VA = "0x18A5DEDA0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDE")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE870", Offset = "0xA5DD270", VA = "0x18A5DE870", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEBD0", Offset = "0xA5DD5D0", VA = "0x18A5DEBD0", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE900", Offset = "0xA5DD300", VA = "0x18A5DE900", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEA10", Offset = "0xA5DD410", VA = "0x18A5DEA10")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DED20", Offset = "0xA5DD720", VA = "0x18A5DED20", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DED60", Offset = "0xA5DD760", VA = "0x18A5DED60", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEC60", Offset = "0xA5DD660", VA = "0x18A5DEC60", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DECA0", Offset = "0xA5DD6A0", VA = "0x18A5DECA0", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0xA5DECE0", Offset = "0xA5DD6E0", VA = "0x18A5DECE0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D6710", Offset = "0xA5D5110", VA = "0x18A5D6710")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		bool ICollection<Quaternion>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEB")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public Quaternion this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEC")]
			[Cpp2IlInjected.Address(RVA = "0xA5D65F0", Offset = "0xA5D4FF0", VA = "0x18A5D65F0", Slot = "11")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CED")]
			[Cpp2IlInjected.Address(RVA = "0xA5CBEA0", Offset = "0xA5CA8A0", VA = "0x18A5CBEA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBBB0", Offset = "0xA5CA5B0", VA = "0x18A5CBBB0")]
		public QuaternionArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBC50", Offset = "0xA5CA650", VA = "0x18A5CBC50")]
		public QuaternionArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D62C0", Offset = "0xA5D4CC0", VA = "0x18A5D62C0", Slot = "9")]
		public IEnumerator<Quaternion> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6540", Offset = "0xA5D4F40", VA = "0x18A5D6540", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6010", Offset = "0xA5D4A10", VA = "0x18A5D6010", Slot = "20")]
		public bool Contains(Quaternion item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6370", Offset = "0xA5D4D70", VA = "0x18A5D6370", Slot = "13")]
		public int IndexOf(Quaternion item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D60A0", Offset = "0xA5D4AA0", VA = "0x18A5D60A0", Slot = "21")]
		public void CopyTo(Quaternion[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D61B0", Offset = "0xA5D4BB0", VA = "0x18A5D61B0")]
		public void Fill(IEnumerable<Quaternion> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0xA5D64C0", Offset = "0xA5D4EC0", VA = "0x18A5D64C0", Slot = "14")]
		void IList<Quaternion>.Insert(int index, Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6500", Offset = "0xA5D4F00", VA = "0x18A5D6500", Slot = "15")]
		void IList<Quaternion>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF6")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6400", Offset = "0xA5D4E00", VA = "0x18A5D6400", Slot = "18")]
		void ICollection<Quaternion>.Add(Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF7")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6440", Offset = "0xA5D4E40", VA = "0x18A5D6440", Slot = "19")]
		void ICollection<Quaternion>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF8")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6480", Offset = "0xA5D4E80", VA = "0x18A5D6480", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5CBE20", Offset = "0xA5CA820", VA = "0x18A5CBE20")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFD")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFE")]
			[Cpp2IlInjected.Address(RVA = "0xA5CBCF0", Offset = "0xA5CA6F0", VA = "0x18A5CBCF0", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFF")]
			[Cpp2IlInjected.Address(RVA = "0xA5CBEA0", Offset = "0xA5CA8A0", VA = "0x18A5CBEA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF9")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBBB0", Offset = "0xA5CA5B0", VA = "0x18A5CBBB0")]
		public Matrix2x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFA")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBC50", Offset = "0xA5CA650", VA = "0x18A5CBC50")]
		public Matrix2x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D00")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB870", Offset = "0xA5CA270", VA = "0x18A5CB870", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D01")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBB00", Offset = "0xA5CA500", VA = "0x18A5CBB00", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D02")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB5B0", Offset = "0xA5C9FB0", VA = "0x18A5CB5B0", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D03")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB920", Offset = "0xA5CA320", VA = "0x18A5CB920", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D04")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB650", Offset = "0xA5CA050", VA = "0x18A5CB650", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D05")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB760", Offset = "0xA5CA160", VA = "0x18A5CB760")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBA80", Offset = "0xA5CA480", VA = "0x18A5CBA80", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D07")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBAC0", Offset = "0xA5CA4C0", VA = "0x18A5CBAC0", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D08")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB9C0", Offset = "0xA5CA3C0", VA = "0x18A5CB9C0", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D09")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBA00", Offset = "0xA5CA400", VA = "0x18A5CBA00", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0A")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBA40", Offset = "0xA5CA440", VA = "0x18A5CBA40", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5CC820", Offset = "0xA5CB220", VA = "0x18A5CC820")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0F")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D10")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC680", Offset = "0xA5CB080", VA = "0x18A5CC680", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D11")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC8A0", Offset = "0xA5CB2A0", VA = "0x18A5CC8A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0B")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC540", Offset = "0xA5CAF40", VA = "0x18A5CC540")]
		public Matrix3x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0C")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC5E0", Offset = "0xA5CAFE0", VA = "0x18A5CC5E0")]
		public Matrix3x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D12")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC200", Offset = "0xA5CAC00", VA = "0x18A5CC200", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D13")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC490", Offset = "0xA5CAE90", VA = "0x18A5CC490", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D14")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBF40", Offset = "0xA5CA940", VA = "0x18A5CBF40", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D15")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC2B0", Offset = "0xA5CACB0", VA = "0x18A5CC2B0", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D16")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBFE0", Offset = "0xA5CA9E0", VA = "0x18A5CBFE0", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D17")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC0F0", Offset = "0xA5CAAF0", VA = "0x18A5CC0F0")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D18")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC410", Offset = "0xA5CAE10", VA = "0x18A5CC410", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D19")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC450", Offset = "0xA5CAE50", VA = "0x18A5CC450", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1A")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC350", Offset = "0xA5CAD50", VA = "0x18A5CC350", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1B")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC390", Offset = "0xA5CAD90", VA = "0x18A5CC390", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1C")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC3D0", Offset = "0xA5CADD0", VA = "0x18A5CC3D0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5CD320", Offset = "0xA5CBD20", VA = "0x18A5CD320")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D21")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D22")]
			[Cpp2IlInjected.Address(RVA = "0xA5CD070", Offset = "0xA5CBA70", VA = "0x18A5CD070", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D23")]
			[Cpp2IlInjected.Address(RVA = "0xA5CD3A0", Offset = "0xA5CBDA0", VA = "0x18A5CD3A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1D")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCF30", Offset = "0xA5CB930", VA = "0x18A5CCF30")]
		public Matrix3x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1E")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCFD0", Offset = "0xA5CB9D0", VA = "0x18A5CCFD0")]
		public Matrix3x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D24")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCBD0", Offset = "0xA5CB5D0", VA = "0x18A5CCBD0", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D25")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCE80", Offset = "0xA5CB880", VA = "0x18A5CCE80", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D26")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC970", Offset = "0xA5CB370", VA = "0x18A5CC970", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D27")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCC80", Offset = "0xA5CB680", VA = "0x18A5CCC80", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC9B0", Offset = "0xA5CB3B0", VA = "0x18A5CC9B0", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCAC0", Offset = "0xA5CB4C0", VA = "0x18A5CCAC0")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCE00", Offset = "0xA5CB800", VA = "0x18A5CCE00", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCE40", Offset = "0xA5CB840", VA = "0x18A5CCE40", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2C")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCD40", Offset = "0xA5CB740", VA = "0x18A5CCD40", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2D")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCD80", Offset = "0xA5CB780", VA = "0x18A5CCD80", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2E")]
		[Cpp2IlInjected.Address(RVA = "0xA5CCDC0", Offset = "0xA5CB7C0", VA = "0x18A5CCDC0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5CDF20", Offset = "0xA5CC920", VA = "0x18A5CDF20")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D33")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D34")]
			[Cpp2IlInjected.Address(RVA = "0xA5CDBC0", Offset = "0xA5CC5C0", VA = "0x18A5CDBC0", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D35")]
			[Cpp2IlInjected.Address(RVA = "0xA5CDFA0", Offset = "0xA5CC9A0", VA = "0x18A5CDFA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2F")]
		[Cpp2IlInjected.Address(RVA = "0xA5CDB20", Offset = "0xA5CC520", VA = "0x18A5CDB20")]
		public Matrix4x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D30")]
		[Cpp2IlInjected.Address(RVA = "0xA5CDA80", Offset = "0xA5CC480", VA = "0x18A5CDA80")]
		public Matrix4x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D36")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD720", Offset = "0xA5CC120", VA = "0x18A5CD720", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D37")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD9D0", Offset = "0xA5CC3D0", VA = "0x18A5CD9D0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D38")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD4C0", Offset = "0xA5CBEC0", VA = "0x18A5CD4C0", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D39")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD7D0", Offset = "0xA5CC1D0", VA = "0x18A5CD7D0", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3A")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD500", Offset = "0xA5CBF00", VA = "0x18A5CD500", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3B")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD610", Offset = "0xA5CC010", VA = "0x18A5CD610")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3C")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD950", Offset = "0xA5CC350", VA = "0x18A5CD950", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3D")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD990", Offset = "0xA5CC390", VA = "0x18A5CD990", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3E")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD890", Offset = "0xA5CC290", VA = "0x18A5CD890", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3F")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD8D0", Offset = "0xA5CC2D0", VA = "0x18A5CD8D0", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D40")]
		[Cpp2IlInjected.Address(RVA = "0xA5CD910", Offset = "0xA5CC310", VA = "0x18A5CD910", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5CEC40", Offset = "0xA5CD640", VA = "0x18A5CEC40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D45")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D46")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE810", Offset = "0xA5CD210", VA = "0x18A5CE810", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D47")]
			[Cpp2IlInjected.Address(RVA = "0xA5CECC0", Offset = "0xA5CD6C0", VA = "0x18A5CECC0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D41")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE770", Offset = "0xA5CD170", VA = "0x18A5CE770")]
		public Matrix4x4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D42")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE6D0", Offset = "0xA5CD0D0", VA = "0x18A5CE6D0")]
		public Matrix4x4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE370", Offset = "0xA5CCD70", VA = "0x18A5CE370", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE620", Offset = "0xA5CD020", VA = "0x18A5CE620", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4A")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE110", Offset = "0xA5CCB10", VA = "0x18A5CE110", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4B")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE420", Offset = "0xA5CCE20", VA = "0x18A5CE420", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4C")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE150", Offset = "0xA5CCB50", VA = "0x18A5CE150", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4D")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE260", Offset = "0xA5CCC60", VA = "0x18A5CE260")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4E")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE5A0", Offset = "0xA5CCFA0", VA = "0x18A5CE5A0", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4F")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE5E0", Offset = "0xA5CCFE0", VA = "0x18A5CE5E0", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D50")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE4E0", Offset = "0xA5CCEE0", VA = "0x18A5CE4E0", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D51")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE520", Offset = "0xA5CCF20", VA = "0x18A5CE520", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D52")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE560", Offset = "0xA5CCF60", VA = "0x18A5CE560", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D5090", Offset = "0xA5D3A90", VA = "0x18A5D5090")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D57")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public float[] this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D58")]
			[Cpp2IlInjected.Address(RVA = "0xA5D5020", Offset = "0xA5D3A20", VA = "0x18A5D5020", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D59")]
			[Cpp2IlInjected.Address(RVA = "0xA5D5110", Offset = "0xA5D3B10", VA = "0x18A5D5110", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D53")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4F80", Offset = "0xA5D3980", VA = "0x18A5D4F80")]
		public MultiArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5A")]
		[Cpp2IlInjected.Address(RVA = "0xA5D48C0", Offset = "0xA5D32C0", VA = "0x18A5D48C0")]
		public void CopyItemTo(int index, float[] dstItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5B")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4C30", Offset = "0xA5D3630", VA = "0x18A5D4C30", Slot = "9")]
		public IEnumerator<float[]> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5C")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4EC0", Offset = "0xA5D38C0", VA = "0x18A5D4EC0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5D")]
		[Cpp2IlInjected.Address(RVA = "0xA5D48A0", Offset = "0xA5D32A0", VA = "0x18A5D48A0", Slot = "20")]
		public bool Contains(float[] item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5E")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4CF0", Offset = "0xA5D36F0", VA = "0x18A5D4CF0", Slot = "13")]
		public int IndexOf(float[] item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5F")]
		[Cpp2IlInjected.Address(RVA = "0xA5D49F0", Offset = "0xA5D33F0", VA = "0x18A5D49F0", Slot = "21")]
		public void CopyTo(float[][] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D60")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4B10", Offset = "0xA5D3510", VA = "0x18A5D4B10")]
		public void Fill(IEnumerable<float[]> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D61")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4E40", Offset = "0xA5D3840", VA = "0x18A5D4E40", Slot = "14")]
		void IList<float>.Insert(int index, float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4E80", Offset = "0xA5D3880", VA = "0x18A5D4E80", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4D80", Offset = "0xA5D3780", VA = "0x18A5D4D80", Slot = "18")]
		void ICollection<float>.Add(float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4DC0", Offset = "0xA5D37C0", VA = "0x18A5D4DC0", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D65")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4E00", Offset = "0xA5D3800", VA = "0x18A5D4E00", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6C")]
			[Cpp2IlInjected.Address(RVA = "0x51B5EA0", Offset = "0x51B48A0", VA = "0x1851B5EA0", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D6D")]
			[Cpp2IlInjected.Address(RVA = "0x51B4AC0", Offset = "0x51B34C0", VA = "0x1851B4AC0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6E")]
			[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x51B5AE0", Offset = "0x51B44E0", VA = "0x1851B5AE0")]
		static ZeroAccessorArray()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6A")]
		[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
		public ZeroAccessorArray(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6F")]
		[Cpp2IlInjected.Address(RVA = "0x51B3EE0", Offset = "0x51B28E0", VA = "0x1851B3EE0", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D70")]
		[Cpp2IlInjected.Address(RVA = "0x51B1CF0", Offset = "0x51B06F0", VA = "0x1851B1CF0", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D71")]
		[Cpp2IlInjected.Address(RVA = "0x51B3010", Offset = "0x51B1A10", VA = "0x1851B3010", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D72")]
		[Cpp2IlInjected.Address(RVA = "0x51B3930", Offset = "0x51B2330", VA = "0x1851B3930", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D73")]
		[Cpp2IlInjected.Address(RVA = "0x51B3930", Offset = "0x51B2330", VA = "0x1851B3930", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D74")]
		[Cpp2IlInjected.Address(RVA = "0x51B4AC0", Offset = "0x51B34C0", VA = "0x1851B4AC0", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D75")]
		[Cpp2IlInjected.Address(RVA = "0x5018D80", Offset = "0x5017780", VA = "0x185018D80", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D76")]
		[Cpp2IlInjected.Address(RVA = "0x5018D80", Offset = "0x5017780", VA = "0x185018D80", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D77")]
		[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D78")]
		[Cpp2IlInjected.Address(RVA = "0x5018D80", Offset = "0x5017780", VA = "0x185018D80", Slot = "22")]
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
				[Cpp2IlInjected.Address(RVA = "0x1348520", Offset = "0x1346F20", VA = "0x181348520", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8C1B8D0", Offset = "0x8C1A2D0", VA = "0x188C1B8D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D88")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D89")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8A")]
			[Cpp2IlInjected.Address(RVA = "0xA5DA1F0", Offset = "0xA5D8BF0", VA = "0x18A5DA1F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8C")]
			[Cpp2IlInjected.Address(RVA = "0xA5DA290", Offset = "0xA5D8C90", VA = "0x18A5DA290", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8E")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8F")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D90")]
			[Cpp2IlInjected.Address(RVA = "0xA5DC0C0", Offset = "0xA5DAAC0", VA = "0x18A5DC0C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D92")]
			[Cpp2IlInjected.Address(RVA = "0xA5DC190", Offset = "0xA5DAB90", VA = "0x18A5DC190", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C3980", Offset = "0xA5C2380", VA = "0x18A5C3980", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D7B")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3A30", Offset = "0xA5C2430", VA = "0x18A5C3A30", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7C")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7D")]
			[Cpp2IlInjected.Address(RVA = "0xA5C3930", Offset = "0xA5C2330", VA = "0x18A5C3930", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D79")]
		[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
		public BooleanArrayOverIntegerArray(IAccessorArray<uint> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3580", Offset = "0xA5C1F80", VA = "0x18A5C3580", Slot = "20")]
		public bool Contains(bool item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C36C0", Offset = "0xA5C20C0", VA = "0x18A5C36C0", Slot = "13")]
		public int IndexOf(bool item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D80")]
		[Cpp2IlInjected.Address(RVA = "0xA5C35A0", Offset = "0xA5C1FA0", VA = "0x18A5C35A0", Slot = "21")]
		public void CopyTo(bool[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D81")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3650", Offset = "0xA5C2050", VA = "0x18A5C3650", Slot = "9")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__12))]
		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D82")]
		[Cpp2IlInjected.Address(RVA = "0xA5C38C0", Offset = "0xA5C22C0", VA = "0x18A5C38C0", Slot = "10")]
		[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__13))]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D83")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3840", Offset = "0xA5C2240", VA = "0x18A5C3840", Slot = "14")]
		void IList<bool>.Insert(int index, bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D84")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3880", Offset = "0xA5C2280", VA = "0x18A5C3880", Slot = "15")]
		void IList<bool>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D85")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3780", Offset = "0xA5C2180", VA = "0x18A5C3780", Slot = "18")]
		void ICollection<bool>.Add(bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D86")]
		[Cpp2IlInjected.Address(RVA = "0xA5C37C0", Offset = "0xA5C21C0", VA = "0x18A5C37C0", Slot = "19")]
		void ICollection<bool>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D87")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3800", Offset = "0xA5C2200", VA = "0x18A5C3800", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5CA200", Offset = "0xA5C8C00", VA = "0x18A5CA200")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5CA1C0", Offset = "0xA5C8BC0", VA = "0x18A5CA1C0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		bool ICollection<uint>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9E")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public uint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B10580", Offset = "0x2B0EF80", VA = "0x182B10580", Slot = "11")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DA0")]
			[Cpp2IlInjected.Address(RVA = "0x87000D0", Offset = "0x86FEAD0", VA = "0x1887000D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D94")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA180", Offset = "0xA5C8B80", VA = "0x18A5CA180")]
		public IntegerArray(Memory<byte> source, IndexEncodingType encoding = IndexEncodingType.UNSIGNED_INT)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D95")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9CB0", Offset = "0xA5C86B0", VA = "0x18A5C9CB0")]
		public IntegerArray(Memory<byte> source, int byteOffset, int itemsCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D96")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9BA0", Offset = "0xA5C85A0", VA = "0x18A5C9BA0")]
		private uint _GetValueU8(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D97")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9C50", Offset = "0xA5C8650", VA = "0x18A5C9C50")]
		private void _SetValueU8(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D98")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9B50", Offset = "0xA5C8550", VA = "0x18A5C9B50")]
		private uint _GetValueU16(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D99")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9BF0", Offset = "0xA5C85F0", VA = "0x18A5C9BF0")]
		private void _SetValueU16(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9A")]
		[Cpp2IlInjected.Address(RVA = "0x3B4BF80", Offset = "0x3B4A980", VA = "0x183B4BF80")]
		private T _GetValue<T>(int index) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9B")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C250", Offset = "0x3B4AC50", VA = "0x183B4C250")]
		private void _SetValue<T>(int index, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA1")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9830", Offset = "0xA5C8230", VA = "0x18A5C9830", Slot = "9")]
		public IEnumerator<uint> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA2")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9AA0", Offset = "0xA5C84A0", VA = "0x18A5C9AA0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA3")]
		[Cpp2IlInjected.Address(RVA = "0xA5C94C0", Offset = "0xA5C7EC0", VA = "0x18A5C94C0", Slot = "20")]
		public bool Contains(uint item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA4")]
		[Cpp2IlInjected.Address(RVA = "0xA5C98E0", Offset = "0xA5C82E0", VA = "0x18A5C98E0", Slot = "13")]
		public int IndexOf(uint item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA5")]
		[Cpp2IlInjected.Address(RVA = "0xA5C94E0", Offset = "0xA5C7EE0", VA = "0x18A5C94E0", Slot = "21")]
		public void CopyTo(uint[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA6")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9600", Offset = "0xA5C8000", VA = "0x18A5C9600")]
		public void Fill(IEnumerable<int> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA7")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9710", Offset = "0xA5C8110", VA = "0x18A5C9710")]
		public void Fill(IEnumerable<uint> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA8")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9A20", Offset = "0xA5C8420", VA = "0x18A5C9A20", Slot = "14")]
		void IList<uint>.Insert(int index, uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA9")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9A60", Offset = "0xA5C8460", VA = "0x18A5C9A60", Slot = "15")]
		void IList<uint>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAA")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9960", Offset = "0xA5C8360", VA = "0x18A5C9960", Slot = "18")]
		void ICollection<uint>.Add(uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAB")]
		[Cpp2IlInjected.Address(RVA = "0xA5C99A0", Offset = "0xA5C83A0", VA = "0x18A5C99A0", Slot = "19")]
		void ICollection<uint>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAC")]
		[Cpp2IlInjected.Address(RVA = "0xA5C99E0", Offset = "0xA5C83E0", VA = "0x18A5C99E0", Slot = "22")]
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
				[Cpp2IlInjected.Address(RVA = "0xD6AE80", Offset = "0xD69880", VA = "0x180D6AE80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5F1040", Offset = "0xA5EFA40", VA = "0x18A5F1040", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF1")]
			[Cpp2IlInjected.Address(RVA = "0x1D12190", Offset = "0x1D10B90", VA = "0x181D12190")]
			[DebuggerHidden]
			public <GetItemsAsRawBytes>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF2")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF3")]
			[Cpp2IlInjected.Address(RVA = "0xA5F0DD0", Offset = "0xA5EF7D0", VA = "0x18A5F0DD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF5")]
			[Cpp2IlInjected.Address(RVA = "0xA5F1000", Offset = "0xA5EFA00", VA = "0x18A5F1000", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF7")]
			[Cpp2IlInjected.Address(RVA = "0xA5F0F60", Offset = "0xA5EF960", VA = "0x18A5F0F60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ArraySegment<byte>> IEnumerable<ArraySegment<byte>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF8")]
			[Cpp2IlInjected.Address(RVA = "0xA5F0F60", Offset = "0xA5EF960", VA = "0x18A5F0F60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xF28B60", Offset = "0xF27560", VA = "0x180F28B60")]
			[CompilerGenerated]
			get
			{
				return default(MemoryAccessInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBA")]
			[Cpp2IlInjected.Address(RVA = "0x503B5B0", Offset = "0x5039FB0", VA = "0x18503B5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public ArraySegment<byte> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000DBB")]
			[Cpp2IlInjected.Address(RVA = "0x1667760", Offset = "0x1666160", VA = "0x181667760")]
			[CompilerGenerated]
			get
			{
				return default(ArraySegment<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBC")]
			[Cpp2IlInjected.Address(RVA = "0xA5D4880", Offset = "0xA5D3280", VA = "0x18A5D4880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB5")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4410", Offset = "0xA5D2E10", VA = "0x18A5D4410")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB6")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4700", Offset = "0xA5D3100", VA = "0x18A5D4700")]
		public MemoryAccessor(byte[] data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB7")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4810", Offset = "0xA5D3210", VA = "0x18A5D4810")]
		public MemoryAccessor(ArraySegment<byte> data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB8")]
		[Cpp2IlInjected.Address(RVA = "0xA5D47B0", Offset = "0xA5D31B0", VA = "0x18A5D47B0")]
		public MemoryAccessor(MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D28E0", Offset = "0xA5D12E0", VA = "0x18A5D28E0")]
		public void Update(ArraySegment<byte> data, MemoryAccessInfo encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBE")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7DF0", Offset = "0x3CF67F0", VA = "0x183CF7DF0")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBF")]
		[Cpp2IlInjected.Address(RVA = "0xA5CF160", Offset = "0xA5CDB60", VA = "0x18A5CF160")]
		public IntegerArray AsIntegerArray()
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D01D0", Offset = "0xA5CEBD0", VA = "0x18A5D01D0")]
		public ScalarArray AsScalarArray()
		{
			return default(ScalarArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0440", Offset = "0xA5CEE40", VA = "0x18A5D0440")]
		public Vector2Array AsVector2Array()
		{
			return default(Vector2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D06B0", Offset = "0xA5CF0B0", VA = "0x18A5D06B0")]
		public Vector3Array AsVector3Array()
		{
			return default(Vector3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0920", Offset = "0xA5CF320", VA = "0x18A5D0920")]
		public Vector4Array AsVector4Array()
		{
			return default(Vector4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC4")]
		[Cpp2IlInjected.Address(RVA = "0xA5CFF60", Offset = "0xA5CE960", VA = "0x18A5CFF60")]
		public QuaternionArray AsQuaternionArray()
		{
			return default(QuaternionArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC5")]
		[Cpp2IlInjected.Address(RVA = "0xA5CF340", Offset = "0xA5CDD40", VA = "0x18A5CF340")]
		public Matrix2x2Array AsMatrix2x2Array()
		{
			return default(Matrix2x2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC6")]
		[Cpp2IlInjected.Address(RVA = "0xA5CF5B0", Offset = "0xA5CDFB0", VA = "0x18A5CF5B0")]
		public Matrix3x3Array AsMatrix3x3Array()
		{
			return default(Matrix3x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC7")]
		[Cpp2IlInjected.Address(RVA = "0xA5CF820", Offset = "0xA5CE220", VA = "0x18A5CF820")]
		public Matrix4x3Array AsMatrix4x3Array()
		{
			return default(Matrix4x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC8")]
		[Cpp2IlInjected.Address(RVA = "0xA5CFA50", Offset = "0xA5CE450", VA = "0x18A5CFA50")]
		public Matrix4x4Array AsMatrix4x4Array()
		{
			return default(Matrix4x4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC9")]
		[Cpp2IlInjected.Address(RVA = "0xA5CEE90", Offset = "0xA5CD890", VA = "0x18A5CEE90")]
		public ColorArray AsColorArray(float defaultW = 1f)
		{
			return default(ColorArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCA")]
		[Cpp2IlInjected.Address(RVA = "0xA5CFCC0", Offset = "0xA5CE6C0", VA = "0x18A5CFCC0")]
		public MultiArray AsMultiArray(int dimensions)
		{
			return default(MultiArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1760", Offset = "0xA5D0160", VA = "0x18A5D1760")]
		[IteratorStateMachine(typeof(<GetItemsAsRawBytes>d__26))]
		public IEnumerable<ArraySegment<byte>> GetItemsAsRawBytes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0B90", Offset = "0xA5CF590", VA = "0x18A5D0B90")]
		public (MemoryAccessor, MemoryAccessor) ConvertToSparse()
		{
			return default((MemoryAccessor, MemoryAccessor));
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1AE0", Offset = "0xA5D04E0", VA = "0x18A5D1AE0")]
		private bool RepresentsZeroValue(ArraySegment<byte> bytes)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCE")]
		[Cpp2IlInjected.Address(RVA = "0x3CFADD0", Offset = "0x3CF97D0", VA = "0x183CFADD0")]
		public static IAccessorArray<T> CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCF")]
		[Cpp2IlInjected.Address(RVA = "0x3CFAF90", Offset = "0x3CF9990", VA = "0x183CFAF90")]
		public static IAccessorArray<T> CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1520", Offset = "0xA5CFF20", VA = "0x18A5D1520")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1640", Offset = "0xA5D0040", VA = "0x18A5D1640")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD2")]
		[Cpp2IlInjected.Address(RVA = "0x3CFC760", Offset = "0x3CFB160", VA = "0x183CFC760")]
		private static IAccessorArray<T> _CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD3")]
		[Cpp2IlInjected.Address(RVA = "0x3CFC4A0", Offset = "0x3CFAEA0", VA = "0x183CFC4A0")]
		private static IAccessorArray<T> _CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD4")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1D30", Offset = "0xA5D0730", VA = "0x18A5D1D30")]
		public static void SanitizeVertexAttributes(MemoryAccessor[] vertexAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD5")]
		[Cpp2IlInjected.Address(RVA = "0xA5D18C0", Offset = "0xA5D02C0", VA = "0x18A5D18C0")]
		public static bool HaveOverlappingBuffers(MemoryAccessor a, MemoryAccessor b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD6")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4290", Offset = "0xA5D2C90", VA = "0x18A5D4290")]
		internal ArraySegment<byte> _GetBytes()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD7")]
		[Cpp2IlInjected.Address(RVA = "0xA5D17E0", Offset = "0xA5D01E0", VA = "0x18A5D17E0")]
		public static bool HaveOverlappingBuffers(IEnumerable<MemoryAccessor> abc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD8")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1F20", Offset = "0xA5D0920", VA = "0x18A5D1F20")]
		public static void SanitizeWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD9")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4480", Offset = "0xA5D2E80", VA = "0x18A5D4480")]
		private static bool _SanitizeWeightSum(Span<byte> dst, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDA")]
		[Cpp2IlInjected.Address(RVA = "0xA5D36F0", Offset = "0xA5D20F0", VA = "0x18A5D36F0")]
		public static void VerifyWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4050", Offset = "0xA5D2A50", VA = "0x18A5D4050")]
		private static bool _CheckWeightSum(ReadOnlySpan<byte> src, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D2940", Offset = "0xA5D1340", VA = "0x18A5D2940")]
		public static void VerifyAccessorBounds(MemoryAccessor memory, IReadOnlyList<double> min, IReadOnlyList<double> max)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D33C0", Offset = "0xA5D1DC0", VA = "0x18A5D33C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E3AE0", Offset = "0xA5E24E0", VA = "0x18A5E3AE0", Slot = "4")]
			public int Compare(string x, string y)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0E")]
			[Cpp2IlInjected.Address(RVA = "0xA5E3B20", Offset = "0xA5E2520", VA = "0x18A5E3B20")]
			private static int _GetSortingScore(string attribute)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0F")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public readonly EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000E01")]
			[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public readonly bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x6000E02")]
			[Cpp2IlInjected.Address(RVA = "0xE728E0", Offset = "0xE712E0", VA = "0x180E728E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public readonly int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E03")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public readonly int PaddedByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E04")]
			[Cpp2IlInjected.Address(RVA = "0xA5ECD40", Offset = "0xA5EB740", VA = "0x18A5ECD40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public readonly int StepByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E05")]
			[Cpp2IlInjected.Address(RVA = "0xA5ECD90", Offset = "0xA5EB790", VA = "0x18A5ECD90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public readonly bool IsValidVertexAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x6000E06")]
			[Cpp2IlInjected.Address(RVA = "0xA5ECC40", Offset = "0xA5EB640", VA = "0x18A5ECC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public readonly bool IsValidIndexer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E07")]
			[Cpp2IlInjected.Address(RVA = "0xA5ECBA0", Offset = "0xA5EB5A0", VA = "0x18A5ECBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		internal static IComparer<string> NameComparer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E0A")]
			[Cpp2IlInjected.Address(RVA = "0xA5ECCF0", Offset = "0xA5EB6F0", VA = "0x18A5ECCF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E0B")]
			[Cpp2IlInjected.Address(RVA = "0xA5ECDF0", Offset = "0xA5EB7F0", VA = "0x18A5ECDF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF9")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC820", Offset = "0xA5EB220", VA = "0x18A5EC820")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFA")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC140", Offset = "0xA5EAB40", VA = "0x18A5EC140")]
		public static MemoryAccessInfo[] Create(params string[] attributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFB")]
		[Cpp2IlInjected.Address(RVA = "0xA5EB980", Offset = "0xA5EA380", VA = "0x18A5EB980")]
		public static MemoryAccessInfo CreateDefaultElement(string attribute)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFC")]
		[Cpp2IlInjected.Address(RVA = "0xA5ECB50", Offset = "0xA5EB550", VA = "0x18A5ECB50")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFD")]
		[Cpp2IlInjected.Address(RVA = "0xA5ECA50", Offset = "0xA5EB450", VA = "0x18A5ECA50")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, DimensionType dimensions, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFE")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC680", Offset = "0xA5EB080", VA = "0x18A5EC680")]
		public readonly MemoryAccessInfo Slice(int itemStart, int itemCount)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFF")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC7A0", Offset = "0xA5EB1A0", VA = "0x18A5EC7A0")]
		public readonly MemoryAccessInfo WithFormat(AttributeFormat newFormat)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E08")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC270", Offset = "0xA5EAC70", VA = "0x18A5EC270")]
		public static int SetInterleavedInfo(MemoryAccessInfo[] attributes, int byteOffset, int itemsCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E09")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC4C0", Offset = "0xA5EAEC0", VA = "0x18A5EC4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5EFE70", Offset = "0xA5EE870", VA = "0x18A5EFE70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public static MemoryImage Empty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E15")]
			[Cpp2IlInjected.Address(RVA = "0x10E6F20", Offset = "0x10E5920", VA = "0x1810E6F20")]
			get
			{
				return default(MemoryImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		private ArraySegment<byte> _Image
		{
			[Cpp2IlInjected.Token(Token = "0x6000E25")]
			[Cpp2IlInjected.Address(RVA = "0xA5F08A0", Offset = "0xA5EF2A0", VA = "0x18A5F08A0")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2C")]
			[Cpp2IlInjected.Address(RVA = "0xA5F0170", Offset = "0xA5EEB70", VA = "0x18A5F0170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public ReadOnlyMemory<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2D")]
			[Cpp2IlInjected.Address(RVA = "0xA5EFDA0", Offset = "0xA5EE7A0", VA = "0x18A5EFDA0")]
			get
			{
				return default(ReadOnlyMemory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public string SourcePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2E")]
			[Cpp2IlInjected.Address(RVA = "0xF27430", Offset = "0xF25E30", VA = "0x180F27430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public bool IsPng
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2F")]
			[Cpp2IlInjected.Address(RVA = "0xA5F04C0", Offset = "0xA5EEEC0", VA = "0x18A5F04C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public bool IsJpg
		{
			[Cpp2IlInjected.Token(Token = "0x6000E30")]
			[Cpp2IlInjected.Address(RVA = "0xA5F02E0", Offset = "0xA5EECE0", VA = "0x18A5F02E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public bool IsDds
		{
			[Cpp2IlInjected.Token(Token = "0x6000E31")]
			[Cpp2IlInjected.Address(RVA = "0xA5F00B0", Offset = "0xA5EEAB0", VA = "0x18A5F00B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public bool IsWebp
		{
			[Cpp2IlInjected.Token(Token = "0x6000E32")]
			[Cpp2IlInjected.Address(RVA = "0xA5F0600", Offset = "0xA5EF000", VA = "0x18A5F0600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public bool IsKtx2
		{
			[Cpp2IlInjected.Token(Token = "0x6000E33")]
			[Cpp2IlInjected.Address(RVA = "0xA5F0400", Offset = "0xA5EEE00", VA = "0x18A5F0400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public bool IsExtendedFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000E34")]
			[Cpp2IlInjected.Address(RVA = "0xA5F0240", Offset = "0xA5EEC40", VA = "0x18A5F0240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000E35")]
			[Cpp2IlInjected.Address(RVA = "0xA5F0580", Offset = "0xA5EEF80", VA = "0x18A5F0580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public string FileExtension
		{
			[Cpp2IlInjected.Token(Token = "0x6000E36")]
			[Cpp2IlInjected.Address(RVA = "0xA5EFED0", Offset = "0xA5EE8D0", VA = "0x18A5EFED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public string MimeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000E37")]
			[Cpp2IlInjected.Address(RVA = "0xA5F06C0", Offset = "0xA5EF0C0", VA = "0x18A5F06C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E13")]
		[Cpp2IlInjected.Address(RVA = "0xA5EDC90", Offset = "0xA5EC690", VA = "0x18A5EDC90")]
		public string ToDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E16")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0990", Offset = "0xA5EF390", VA = "0x18A5F0990")]
		public static implicit operator MemoryImage(ArraySegment<byte> image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E17")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0A20", Offset = "0xA5EF420", VA = "0x18A5F0A20")]
		public static implicit operator MemoryImage(byte[] image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E18")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0A40", Offset = "0xA5EF440", VA = "0x18A5F0A40")]
		public static implicit operator MemoryImage(string filePath)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E19")]
		[Cpp2IlInjected.Address(RVA = "0xA5EEC80", Offset = "0xA5ED680", VA = "0x18A5EEC80")]
		public static bool TryParseMime64(Uri mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1A")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE7B0", Offset = "0xA5ED1B0", VA = "0x18A5EE7B0")]
		public static bool TryParseMime64(string mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1B")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFB90", Offset = "0xA5EE590", VA = "0x18A5EFB90")]
		public MemoryImage(ArraySegment<byte> image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1C")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF9A0", Offset = "0xA5EE3A0", VA = "0x18A5EF9A0")]
		public MemoryImage(byte[] image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1D")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFCF0", Offset = "0xA5EE6F0", VA = "0x18A5EFCF0")]
		public MemoryImage(Func<ArraySegment<byte>> factory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1E")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFA20", Offset = "0xA5EE420", VA = "0x18A5EFA20")]
		public MemoryImage(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1F")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF920", Offset = "0xA5EE320", VA = "0x18A5EF920")]
		internal MemoryImage(byte[] image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E20")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFC60", Offset = "0xA5EE660", VA = "0x18A5EFC60")]
		internal MemoryImage(ArraySegment<byte> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E21")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFC10", Offset = "0xA5EE610", VA = "0x18A5EFC10")]
		internal MemoryImage(MemoryImage image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E22")]
		[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
		internal MemoryImage(Lazy<ArraySegment<byte>> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E23")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF360", Offset = "0xA5EDD60", VA = "0x18A5EF360")]
		private static Lazy<ArraySegment<byte>> _ToLazy(byte[] bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E24")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF270", Offset = "0xA5EDC70", VA = "0x18A5EF270")]
		private static Lazy<ArraySegment<byte>> _ToLazy(ArraySegment<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E26")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED3E0", Offset = "0xA5EBDE0", VA = "0x18A5ED3E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E27")]
		[Cpp2IlInjected.Address(RVA = "0xA5ECE60", Offset = "0xA5EB860", VA = "0x18A5ECE60")]
		public static bool AreEqual(MemoryImage a, MemoryImage b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E28")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED290", Offset = "0xA5EBC90", VA = "0x18A5ED290", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E29")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED360", Offset = "0xA5EBD60", VA = "0x18A5ED360", Slot = "4")]
		public bool Equals(MemoryImage other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0920", Offset = "0xA5EF320", VA = "0x18A5F0920")]
		public static bool operator ==(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0A60", Offset = "0xA5EF460", VA = "0x18A5F0A60")]
		public static bool operator !=(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E38")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE5D0", Offset = "0xA5ECFD0", VA = "0x18A5EE5D0")]
		public static string TrimImageExtension(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E39")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF3E0", Offset = "0xA5EDDE0", VA = "0x18A5EF3E0")]
		internal static void _Verify(MemoryImage image, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3A")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED7D0", Offset = "0xA5EC1D0", VA = "0x18A5ED7D0")]
		public Stream Open()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3B")]
		[Cpp2IlInjected.Address(RVA = "0xA5EDA30", Offset = "0xA5EC430", VA = "0x18A5EDA30")]
		public void SaveToFile(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3C")]
		[Cpp2IlInjected.Address(RVA = "0xA5EECF0", Offset = "0xA5ED6F0", VA = "0x18A5EECF0")]
		internal ArraySegment<byte> _GetBuffer()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3D")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE1F0", Offset = "0xA5ECBF0", VA = "0x18A5EE1F0")]
		internal string ToMime64(bool withPrefix = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3E")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED4C0", Offset = "0xA5EBEC0", VA = "0x18A5ED4C0")]
		public bool IsImageOfType(string format)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3F")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF090", Offset = "0xA5EDA90", VA = "0x18A5EF090")]
		private static bool _IsPngImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E40")]
		[Cpp2IlInjected.Address(RVA = "0xA5EEFB0", Offset = "0xA5ED9B0", VA = "0x18A5EEFB0")]
		private static bool _IsJpgImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E41")]
		[Cpp2IlInjected.Address(RVA = "0xA5EEDA0", Offset = "0xA5ED7A0", VA = "0x18A5EEDA0")]
		private static bool _IsDdsImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E42")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF140", Offset = "0xA5EDB40", VA = "0x18A5EF140")]
		private static bool _IsWebpImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E43")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF030", Offset = "0xA5EDA30", VA = "0x18A5EF030")]
		private static bool _IsKtx2Image(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E44")]
		[Cpp2IlInjected.Address(RVA = "0xA5EEE50", Offset = "0xA5ED850", VA = "0x18A5EEE50")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5EB960", Offset = "0xA5EA360", VA = "0x18A5EB960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E49")]
		[Cpp2IlInjected.Address(RVA = "0xA5EB5E0", Offset = "0xA5E9FE0", VA = "0x18A5EB5E0")]
		public static bool TryGetHeader(IReadOnlyList<byte> data, [Out] Ktx2Header header)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4A")]
		[Cpp2IlInjected.Address(RVA = "0xA5EB770", Offset = "0xA5EA170", VA = "0x18A5EB770")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE1B30", Offset = "0x7AE0530", VA = "0x187AE1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x7AE14B0", Offset = "0x7ADFEB0", VA = "0x187AE14B0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4E")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4F")]
			[Cpp2IlInjected.Address(RVA = "0x7AE19D0", Offset = "0x7AE03D0", VA = "0x187AE19D0", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E50")]
			[Cpp2IlInjected.Address(RVA = "0x7AE1BD0", Offset = "0x7AE05D0", VA = "0x187AE1BD0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0D50", Offset = "0x7ADF750", VA = "0x187AE0D50")]
		public SparseArray(IReadOnlyList<T> denseValues, IReadOnlyList<T> sparseValues, IReadOnlyList<uint> sparseKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E51")]
		[Cpp2IlInjected.Address(RVA = "0x7ADFAC0", Offset = "0x7ADE4C0", VA = "0x187ADFAC0", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E52")]
		[Cpp2IlInjected.Address(RVA = "0x7ADFAC0", Offset = "0x7ADE4C0", VA = "0x187ADFAC0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E53")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF440", Offset = "0x7ADDE40", VA = "0x187ADF440", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E54")]
		[Cpp2IlInjected.Address(RVA = "0x7ADFBA0", Offset = "0x7ADE5A0", VA = "0x187ADFBA0", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E55")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF9E0", Offset = "0x7ADE3E0", VA = "0x187ADF9E0", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E56")]
		[Cpp2IlInjected.Address(RVA = "0x51B4AC0", Offset = "0x51B34C0", VA = "0x1851B4AC0", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E57")]
		[Cpp2IlInjected.Address(RVA = "0x5018D80", Offset = "0x5017780", VA = "0x185018D80", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E58")]
		[Cpp2IlInjected.Address(RVA = "0x5018D80", Offset = "0x5017780", VA = "0x185018D80", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E59")]
		[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5A")]
		[Cpp2IlInjected.Address(RVA = "0x5018D80", Offset = "0x5017780", VA = "0x185018D80", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x509BFD0", Offset = "0x509A9D0", VA = "0x18509BFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5B")]
		[Cpp2IlInjected.Address(RVA = "0xA5EAC50", Offset = "0xA5E9650", VA = "0x18A5EAC50")]
		internal void ValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5C")]
		[Cpp2IlInjected.Address(RVA = "0xA5EABF0", Offset = "0xA5E95F0", VA = "0x18A5EABF0")]
		internal void ValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		protected virtual void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5E")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		protected virtual void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E60")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9BF0", Offset = "0xA5E85F0", VA = "0x18A5E9BF0", Slot = "6")]
		protected virtual string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E61")]
		[Cpp2IlInjected.Address(RVA = "0xA5EAB10", Offset = "0xA5E9510", VA = "0x18A5EAB10")]
		internal void Serialize(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E62")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void SerializeProperties(Utf8JsonWriter writer);

		[Cpp2IlInjected.Token(Token = "0x6000E63")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA8F0", Offset = "0xA5E92F0", VA = "0x18A5EA8F0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E64")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9C20", Offset = "0xA5E8620", VA = "0x18A5E9C20")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, bool? value, [Optional] bool? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E65")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA9C0", Offset = "0xA5E93C0", VA = "0x18A5EA9C0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, int? value, [Optional] int? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E66")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA0D0", Offset = "0xA5E8AD0", VA = "0x18A5EA0D0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, float? value, [Optional] float? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E67")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA3E0", Offset = "0xA5E8DE0", VA = "0x18A5EA3E0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, double? value, [Optional] double? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E68")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9D90", Offset = "0xA5E8790", VA = "0x18A5E9D90")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector2? value, [Optional] Vector2? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E69")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9F10", Offset = "0xA5E8910", VA = "0x18A5E9F10")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector3? value, [Optional] Vector3? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6A")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA220", Offset = "0xA5E8C20", VA = "0x18A5EA220")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector4? value, [Optional] Vector4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6B")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA520", Offset = "0xA5E8F20", VA = "0x18A5EA520")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Quaternion? value, [Optional] Quaternion? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6C")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA6E0", Offset = "0xA5E90E0", VA = "0x18A5EA6E0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Matrix4x4? value, [Optional] Matrix4x4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7680", Offset = "0x3BB6080", VA = "0x183BB7680")]
		protected static void SerializePropertyEnumValue<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6E")]
		[Cpp2IlInjected.Address(RVA = "0x3BB7080", Offset = "0x3BB5A80", VA = "0x183BB7080")]
		protected static void SerializePropertyEnumSymbol<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6F")]
		[Cpp2IlInjected.Address(RVA = "0x3BB78D0", Offset = "0x3BB62D0", VA = "0x183BB78D0")]
		protected static void SerializePropertyObject<T>(Utf8JsonWriter writer, string name, T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E70")]
		[Cpp2IlInjected.Address(RVA = "0x3BB79A0", Offset = "0x3BB63A0", VA = "0x183BB79A0")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyList<T> collection, [Optional] int? minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E71")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8430", Offset = "0x3BB6E30", VA = "0x183BB8430")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyDictionary<string, T> collection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E72")]
		[Cpp2IlInjected.Address(RVA = "0xA5EAD20", Offset = "0xA5E9720", VA = "0x18A5EAD20")]
		private static void _SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E73")]
		[Cpp2IlInjected.Address(RVA = "0xA5EACB0", Offset = "0xA5E96B0", VA = "0x18A5EACB0")]
		private static bool _IsNullOrEmpty(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E74")]
		[Cpp2IlInjected.Address(RVA = "0xA5EAEB0", Offset = "0xA5E98B0", VA = "0x18A5EAEB0")]
		private static void _SerializeValue(Utf8JsonWriter writer, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E75")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9AB0", Offset = "0xA5E84B0", VA = "0x18A5E9AB0")]
		internal void Deserialize(Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E76")]
		[Cpp2IlInjected.Address(RVA = "0xA5E95A0", Offset = "0xA5E7FA0", VA = "0x18A5E95A0")]
		protected static object DeserializeUnknownObject(Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E77")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader);

		[Cpp2IlInjected.Token(Token = "0x6000E78")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5FF0", Offset = "0x3BB49F0", VA = "0x183BB5FF0")]
		protected static T DeserializePropertyValue<T>(Utf8JsonReader reader)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E79")]
		[Cpp2IlInjected.Address(RVA = "0x3BB68F0", Offset = "0x3BB52F0", VA = "0x183BB68F0")]
		protected static void DeserializePropertyValue<TParent, T>(Utf8JsonReader reader, TParent owner, [Out] T property) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5980", Offset = "0x3BB4380", VA = "0x183BB5980")]
		protected static void DeserializePropertyList<TParent, T>(Utf8JsonReader reader, TParent owner, IList<T> list) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7B")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5270", Offset = "0x3BB3C70", VA = "0x183BB5270")]
		protected static void DeserializePropertyList<T>(Utf8JsonReader reader, IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5220", Offset = "0x3BB3C20", VA = "0x183BB5220")]
		protected static void DeserializePropertyDictionary<TParent, T>(Utf8JsonReader reader, TParent owner, IDictionary<string, T> dict) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4F40", Offset = "0x3BB3940", VA = "0x183BB4F40")]
		protected static void DeserializePropertyDictionary<T>(Utf8JsonReader reader, IDictionary<string, T> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7E")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8F90", Offset = "0x3BB7990", VA = "0x183BB8F90")]
		private static bool _TryCastValue<T>(Utf8JsonReader reader, [Out] object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7F")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected JsonSerializable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal static class _JSonSerializationExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000E80")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2200", Offset = "0xA5F0C00", VA = "0x18A5F2200")]
		public static bool AsBoolean([In] this Utf8JsonReader reader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E81")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2820", Offset = "0xA5F1220", VA = "0x18A5F2820")]
		public static string AsString([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E82")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2330", Offset = "0xA5F0D30", VA = "0x18A5F2330")]
		public static object AsEnum([In] this Utf8JsonReader reader, Type enumType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E83")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2B80", Offset = "0xA5F1580", VA = "0x18A5F2B80")]
		public static object GetAnyValue([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E84")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2E90", Offset = "0xA5F1890", VA = "0x18A5F2E90")]
		public static object GetValueAs([In] this Utf8JsonReader reader, Type vtype)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E85")]
		[Cpp2IlInjected.Address(RVA = "0x4154D90", Offset = "0x4153790", VA = "0x184154D90")]
		public static T GetValueAs<T>([In] this Utf8JsonReader reader) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E86")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3F50", Offset = "0xA5F2950", VA = "0x18A5F3F50")]
		public static bool TryWriteProperty(this Utf8JsonWriter writer, string property, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E87")]
		[Cpp2IlInjected.Address(RVA = "0xA5F4780", Offset = "0xA5F3180", VA = "0x18A5F4780")]
		public static bool TryWriteValue(this Utf8JsonWriter writer, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E88")]
		[Cpp2IlInjected.Address(RVA = "0xA5F5120", Offset = "0xA5F3B20", VA = "0x18A5F5120")]
		public static void WriteVector2(this Utf8JsonWriter writer, Vector2 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E89")]
		[Cpp2IlInjected.Address(RVA = "0xA5F5180", Offset = "0xA5F3B80", VA = "0x18A5F5180")]
		public static void WriteVector3(this Utf8JsonWriter writer, Vector3 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F5050", Offset = "0xA5F3A50", VA = "0x18A5F5050")]
		public static void WriteVector4(this Utf8JsonWriter writer, Vector4 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F5050", Offset = "0xA5F3A50", VA = "0x18A5F5050")]
		public static void WriteQuaternion(this Utf8JsonWriter writer, Quaternion q)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F4F10", Offset = "0xA5F3910", VA = "0x18A5F4F10")]
		public static void WriteMatrix4x4(this Utf8JsonWriter writer, Matrix4x4 m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F26D0", Offset = "0xA5F10D0", VA = "0x18A5F26D0")]
		public static Uri AsStringUri([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F50D0", Offset = "0xA5F3AD0", VA = "0x18A5F50D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public IReadOnlyDictionary<string, JsonNode> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000E91")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1A10", Offset = "0xA5F0410", VA = "0x18A5F1A10")]
		public UnknownNode(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E92")]
		[Cpp2IlInjected.Address(RVA = "0xA5F17A0", Offset = "0xA5F01A0", VA = "0x18A5F17A0", Slot = "8")]
		protected override void DeserializeProperty(string property, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E93")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1820", Offset = "0xA5F0220", VA = "0x18A5F1820", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5E7F40", Offset = "0xA5E6940", VA = "0x18A5E7F40")]
		internal static string GetAttributeShortName(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E95")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8970", Offset = "0xA5E7370", VA = "0x18A5E8970")]
		public static string ToReport(this MemoryAccessInfo minfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E96")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8780", Offset = "0xA5E7180", VA = "0x18A5E8780")]
		public static string ToReport(this BufferView bv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E97")]
		[Cpp2IlInjected.Address(RVA = "0xA5E86D0", Offset = "0xA5E70D0", VA = "0x18A5E86D0")]
		public static string ToReportShort(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E98")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8460", Offset = "0xA5E6E60", VA = "0x18A5E8460")]
		public static string ToReportLong(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E99")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8AE0", Offset = "0xA5E74E0", VA = "0x18A5E8AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x51B64A0", Offset = "0x51B4EA0", VA = "0x1851B64A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA2")]
		[Cpp2IlInjected.Address(RVA = "0x51B6410", Offset = "0x51B4E10", VA = "0x1851B6410")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F21E0", Offset = "0xA5F0BE0", VA = "0x18A5F21E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA6")]
			[Cpp2IlInjected.Address(RVA = "0xA5F21C0", Offset = "0xA5F0BC0", VA = "0x18A5F21C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA7")]
			[Cpp2IlInjected.Address(RVA = "0xA5F2140", Offset = "0xA5F0B40", VA = "0x18A5F2140")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F20F0", Offset = "0xA5F0AF0", VA = "0x18A5F20F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA4")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F1B60", Offset = "0xA5F0560", VA = "0x18A5F1B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public BufferView Source
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAB")]
			[Cpp2IlInjected.Address(RVA = "0xA5F1FA0", Offset = "0xA5F09A0", VA = "0x18A5F1FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public (DimensionType Dimensions, EncodingType Encoding, bool Normalized) Format
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAC")]
			[Cpp2IlInjected.Address(RVA = "0xA5F1AB0", Offset = "0xA5F04B0", VA = "0x18A5F1AB0")]
			get
			{
				return default((DimensionType, EncodingType, bool));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		public object[] Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAD")]
			[Cpp2IlInjected.Address(RVA = "0xA5F1BE0", Offset = "0xA5F05E0", VA = "0x18A5F1BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA9")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FA37B0", Offset = "0x1FA21B0", VA = "0x181FA37B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F5460", Offset = "0xA5F3E60", VA = "0x18A5F5460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAE")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F5260", Offset = "0xA5F3C60", VA = "0x18A5F5260")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public (double X, double Y, double Z, double W) Row2
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB3")]
			[Cpp2IlInjected.Address(RVA = "0xA5F52E0", Offset = "0xA5F3CE0", VA = "0x18A5F52E0")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public (double X, double Y, double Z, double W) Row3
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB4")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5360", Offset = "0xA5F3D60", VA = "0x18A5F5360")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public (double X, double Y, double Z, double W) Row4
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB5")]
			[Cpp2IlInjected.Address(RVA = "0xA5F53E0", Offset = "0xA5F3DE0", VA = "0x18A5F53E0")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F51F0", Offset = "0xA5F3BF0", VA = "0x18A5F51F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x505F3D0", Offset = "0x505DDD0", VA = "0x18505F3D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public ICollection<string> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB8")]
			[Cpp2IlInjected.Address(RVA = "0x505FB70", Offset = "0x505E570", VA = "0x18505FB70", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		IEnumerable<T> IReadOnlyDictionary<string, T>.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB9")]
			[Cpp2IlInjected.Address(RVA = "0x505F450", Offset = "0x505DE50", VA = "0x18505F450", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public ICollection<T> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBA")]
			[Cpp2IlInjected.Address(RVA = "0x505FBF0", Offset = "0x505E5F0", VA = "0x18505FBF0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBB")]
			[Cpp2IlInjected.Address(RVA = "0x505FAC0", Offset = "0x505E4C0", VA = "0x18505FAC0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBC")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		public T this[string key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBD")]
			[Cpp2IlInjected.Address(RVA = "0x505FAE0", Offset = "0x505E4E0", VA = "0x18505FAE0", Slot = "12")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EBE")]
			[Cpp2IlInjected.Address(RVA = "0x505FC40", Offset = "0x505E640", VA = "0x18505FC40", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB6")]
		[Cpp2IlInjected.Address(RVA = "0x505F9F0", Offset = "0x505E3F0", VA = "0x18505F9F0")]
		public ChildrenDictionary(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBF")]
		[Cpp2IlInjected.Address(RVA = "0x505ED90", Offset = "0x505D790", VA = "0x18505ED90", Slot = "23")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC0")]
		[Cpp2IlInjected.Address(RVA = "0x505EC50", Offset = "0x505D650", VA = "0x18505EC50", Slot = "17")]
		public void Add(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC1")]
		[Cpp2IlInjected.Address(RVA = "0x505F2A0", Offset = "0x505DCA0", VA = "0x18505F2A0", Slot = "18")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC2")]
		[Cpp2IlInjected.Address(RVA = "0x505EF90", Offset = "0x505D990", VA = "0x18505EF90", Slot = "16")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC3")]
		[Cpp2IlInjected.Address(RVA = "0x505F630", Offset = "0x505E030", VA = "0x18505F630", Slot = "19")]
		public bool TryGetValue(string key, [Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC4")]
		[Cpp2IlInjected.Address(RVA = "0x505F180", Offset = "0x505DB80", VA = "0x18505F180", Slot = "10")]
		public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC5")]
		[Cpp2IlInjected.Address(RVA = "0x505F180", Offset = "0x505DB80", VA = "0x18505F180", Slot = "11")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC6")]
		[Cpp2IlInjected.Address(RVA = "0x505F790", Offset = "0x505E190", VA = "0x18505F790")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC7")]
		[Cpp2IlInjected.Address(RVA = "0x10841B0", Offset = "0x1082BB0", VA = "0x1810841B0")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC8")]
		[Cpp2IlInjected.Address(RVA = "0x505EC30", Offset = "0x505D630", VA = "0x18505EC30", Slot = "22")]
		public void Add(KeyValuePair<string, T> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC9")]
		[Cpp2IlInjected.Address(RVA = "0x505EFC0", Offset = "0x505D9C0", VA = "0x18505EFC0", Slot = "24")]
		public bool Contains(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECA")]
		[Cpp2IlInjected.Address(RVA = "0x505F280", Offset = "0x505DC80", VA = "0x18505F280", Slot = "26")]
		public bool Remove(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECB")]
		[Cpp2IlInjected.Address(RVA = "0x505F000", Offset = "0x505DA00", VA = "0x18505F000", Slot = "25")]
		public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECC")]
		[Cpp2IlInjected.Address(RVA = "0x505F1F0", Offset = "0x505DBF0", VA = "0x18505F1F0", Slot = "27")]
		public IEnumerable<SharpGLTF.Reflection.FieldInfo> GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECD")]
		[Cpp2IlInjected.Address(RVA = "0x505F4A0", Offset = "0x505DEA0", VA = "0x18505F4A0", Slot = "28")]
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
				[Cpp2IlInjected.Address(RVA = "0x4F06690", Offset = "0x4F05090", VA = "0x184F06690", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D96950", Offset = "0x6D95350", VA = "0x186D96950", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEB")]
			[Cpp2IlInjected.Address(RVA = "0x6662850", Offset = "0x6661250", VA = "0x186662850")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEC")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EED")]
			[Cpp2IlInjected.Address(RVA = "0x6D96740", Offset = "0x6D95140", VA = "0x186D96740", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEF")]
			[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF1")]
			[Cpp2IlInjected.Address(RVA = "0x6662360", Offset = "0x6660D60", VA = "0x186662360", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF2")]
			[Cpp2IlInjected.Address(RVA = "0x6D96890", Offset = "0x6D95290", VA = "0x186D96890", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5060BE0", Offset = "0x505F5E0", VA = "0x185060BE0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ED5")]
			[Cpp2IlInjected.Address(RVA = "0x5060C50", Offset = "0x505F650", VA = "0x185060C50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED6")]
			[Cpp2IlInjected.Address(RVA = "0x5060BC0", Offset = "0x505F5C0", VA = "0x185060BC0", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED3")]
		[Cpp2IlInjected.Address(RVA = "0x5060AF0", Offset = "0x505F4F0", VA = "0x185060AF0")]
		public ChildrenList(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED8")]
		[Cpp2IlInjected.Address(RVA = "0x505FFD0", Offset = "0x505E9D0", VA = "0x18505FFD0", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED9")]
		[Cpp2IlInjected.Address(RVA = "0x5060140", Offset = "0x505EB40", VA = "0x185060140", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDA")]
		[Cpp2IlInjected.Address(RVA = "0x505FFF0", Offset = "0x505E9F0", VA = "0x18505FFF0", Slot = "14")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDB")]
		[Cpp2IlInjected.Address(RVA = "0x505FC60", Offset = "0x505E660", VA = "0x18505FC60", Slot = "11")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDC")]
		[Cpp2IlInjected.Address(RVA = "0x505FDD0", Offset = "0x505E7D0", VA = "0x18505FDD0", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDD")]
		[Cpp2IlInjected.Address(RVA = "0x5060160", Offset = "0x505EB60", VA = "0x185060160", Slot = "7")]
		public void Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDE")]
		[Cpp2IlInjected.Address(RVA = "0x5060520", Offset = "0x505EF20", VA = "0x185060520", Slot = "15")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDF")]
		[Cpp2IlInjected.Address(RVA = "0x50602C0", Offset = "0x505ECC0", VA = "0x1850602C0", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE0")]
		[Cpp2IlInjected.Address(RVA = "0x5060010", Offset = "0x505EA10", VA = "0x185060010", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE1")]
		[Cpp2IlInjected.Address(RVA = "0x5060010", Offset = "0x505EA10", VA = "0x185060010", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE2")]
		[Cpp2IlInjected.Address(RVA = "0x5060920", Offset = "0x505F320", VA = "0x185060920")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE3")]
		[Cpp2IlInjected.Address(RVA = "0x10841B0", Offset = "0x1082BB0", VA = "0x1810841B0")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE4")]
		[Cpp2IlInjected.Address(RVA = "0x5060700", Offset = "0x505F100", VA = "0x185060700", Slot = "22")]
		[IteratorStateMachine(typeof(ChildrenList<, >.<SharpGLTF-Reflection-IReflectionObject-GetFields>d__22))]
		IEnumerable<SharpGLTF.Reflection.FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE5")]
		[Cpp2IlInjected.Address(RVA = "0x5060590", Offset = "0x505EF90", VA = "0x185060590", Slot = "21")]
		SharpGLTF.Reflection.FieldInfo IReflectionArray.GetField(int index)
		{
			return default(SharpGLTF.Reflection.FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE6")]
		[Cpp2IlInjected.Address(RVA = "0x5060790", Offset = "0x505F190", VA = "0x185060790", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x505EB70", Offset = "0x505D570", VA = "0x18505EB70")]
		public ChildSetter(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF4")]
		[Cpp2IlInjected.Address(RVA = "0x36E0C00", Offset = "0x36DF600", VA = "0x1836E0C00")]
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
			[Cpp2IlInjected.Address(RVA = "0x78AE400", Offset = "0x78ACE00", VA = "0x1878AE400", Slot = "6")]
			get
			{
				return (TValueOut)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EFF")]
			[Cpp2IlInjected.Address(RVA = "0x78AE790", Offset = "0x78AD190", VA = "0x1878AE790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public IEnumerable<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F00")]
			[Cpp2IlInjected.Address(RVA = "0x78AE7F0", Offset = "0x78AD1F0", VA = "0x1878AE7F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F01")]
			[Cpp2IlInjected.Address(RVA = "0x78AE3A0", Offset = "0x78ACDA0", VA = "0x1878AE3A0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFD")]
		[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
		public ReadOnlyLinqDictionary(IReadOnlyDictionary<TKey, TValueIn> dict, Converter<TValueIn, TValueOut> valConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F02")]
		[Cpp2IlInjected.Address(RVA = "0x78AD6F0", Offset = "0x78AC0F0", VA = "0x1878AD6F0", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F03")]
		[Cpp2IlInjected.Address(RVA = "0x78AE250", Offset = "0x78ACC50", VA = "0x1878AE250", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F04")]
		[Cpp2IlInjected.Address(RVA = "0x78AD980", Offset = "0x78AC380", VA = "0x1878AD980", Slot = "10")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F05")]
		[Cpp2IlInjected.Address(RVA = "0x78ADB40", Offset = "0x78AC540", VA = "0x1878ADB40", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A9DEC0", Offset = "0x6A9C8C0", VA = "0x186A9DEC0", Slot = "4")]
			get
			{
				return (TValueOut)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000F0E")]
			[Cpp2IlInjected.Address(RVA = "0x6A9E480", Offset = "0x6A9CE80", VA = "0x186A9E480", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public ICollection<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000F0F")]
			[Cpp2IlInjected.Address(RVA = "0x6A9E1B0", Offset = "0x6A9CBB0", VA = "0x186A9E1B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public ICollection<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F10")]
			[Cpp2IlInjected.Address(RVA = "0x6A9E210", Offset = "0x6A9CC10", VA = "0x186A9E210", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F11")]
			[Cpp2IlInjected.Address(RVA = "0x6A9DE60", Offset = "0x6A9C860", VA = "0x186A9DE60", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000F12")]
			[Cpp2IlInjected.Address(RVA = "0x65A5F70", Offset = "0x65A4970", VA = "0x1865A5F70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0C")]
		[Cpp2IlInjected.Address(RVA = "0x1F22AA0", Offset = "0x1F214A0", VA = "0x181F22AA0")]
		public LinqDictionary(IDictionary<TKey, TValueIn> dict, Converter<TValueOut, TValueIn> inConverter, Converter<TValueIn, TValueOut> outConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F13")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D3D0", Offset = "0x6A9BDD0", VA = "0x186A9D3D0", Slot = "8")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F14")]
		[Cpp2IlInjected.Address(RVA = "0x6A9DAB0", Offset = "0x6A9C4B0", VA = "0x186A9DAB0", Slot = "11")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F15")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D520", Offset = "0x6A9BF20", VA = "0x186A9D520", Slot = "19")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F16")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D890", Offset = "0x6A9C290", VA = "0x186A9D890", Slot = "20")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F17")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D160", Offset = "0x6A9BB60", VA = "0x186A9D160", Slot = "9")]
		public void Add(TKey key, TValueOut value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F18")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D740", Offset = "0x6A9C140", VA = "0x186A9D740", Slot = "10")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F19")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CF20", Offset = "0x6A9B920", VA = "0x186A9CF20", Slot = "14")]
		public void Add(KeyValuePair<TKey, TValueOut> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1A")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D370", Offset = "0x6A9BD70", VA = "0x186A9D370", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1B")]
		[Cpp2IlInjected.Address(RVA = "0x3BF68C0", Offset = "0x3BF52C0", VA = "0x183BF68C0", Slot = "16")]
		public bool Contains(KeyValuePair<TKey, TValueOut> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6700", Offset = "0x3BF5100", VA = "0x183BF6700", Slot = "17")]
		public void CopyTo(KeyValuePair<TKey, TValueOut>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF68C0", Offset = "0x3BF52C0", VA = "0x183BF68C0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private ReferenceComparer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F25")]
		[Cpp2IlInjected.Address(RVA = "0x1721A50", Offset = "0x1720450", VA = "0x181721A50", Slot = "4")]
		public bool Equals(T x, T y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F26")]
		[Cpp2IlInjected.Address(RVA = "0x794B250", Offset = "0x7949C50", VA = "0x18794B250", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4C")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <SplitByTime>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4D")]
			[Cpp2IlInjected.Address(RVA = "0x6E35FC0", Offset = "0x6E349C0", VA = "0x186E35FC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4E")]
			[Cpp2IlInjected.Address(RVA = "0x6E2E1B0", Offset = "0x6E2CBB0", VA = "0x186E2E1B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4F")]
			[Cpp2IlInjected.Address(RVA = "0x6E36C70", Offset = "0x6E35670", VA = "0x186E36C70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F51")]
			[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F53")]
			[Cpp2IlInjected.Address(RVA = "0x653AFE0", Offset = "0x65399E0", VA = "0x18653AFE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(float, T)[]> IEnumerable<(float, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000F54")]
			[Cpp2IlInjected.Address(RVA = "0x6E35660", Offset = "0x6E34060", VA = "0x186E35660", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5E62B0", Offset = "0xA5E4CB0", VA = "0x18A5E62B0")]
		internal static string CurveError(int maxDegree)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F29")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5E90", Offset = "0xA5E4890", VA = "0x18A5E5E90")]
		public static Vector3 CreateTangent(Vector3 fromValue, Vector3 toValue, float scale = 1f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5F70", Offset = "0xA5E4970", VA = "0x18A5E5F70")]
		public static Quaternion CreateTangent(Quaternion fromValue, Quaternion toValue, float scale = 1f)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E60F0", Offset = "0xA5E4AF0", VA = "0x18A5E60F0")]
		public static float[] CreateTangent(float[] fromValue, float[] toValue, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3ED0", Offset = "0xA5E28D0", VA = "0x18A5E3ED0")]
		public static (float, float, float, float) CreateHermitePointWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3F70", Offset = "0xA5E2970", VA = "0x18A5E3F70")]
		public static (float, float, float, float) CreateHermiteTangentWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2E")]
		[Cpp2IlInjected.Address(RVA = "0x38BDA60", Offset = "0x38BC460", VA = "0x1838BDA60")]
		public static (T, T, float) FindRangeContainingOffset<T>(this IEnumerable<(float Key, T Value)> sequence, float offset)
		{
			return default((T, T, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6340", Offset = "0xA5E4D40", VA = "0x18A5E6340")]
		public static (float, float, float) FindRangeContainingOffset(IEnumerable<float> sequence, float offset)
		{
			return default((float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F30")]
		[Cpp2IlInjected.Address(RVA = "0x338EA40", Offset = "0x338D440", VA = "0x18338EA40")]
		[IteratorStateMachine(typeof(<SplitByTime>d__11<>))]
		internal static IEnumerable<(float, T)[]> SplitByTime<T>(this IEnumerable<(float Time, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F31")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7C50", Offset = "0xA5E6650", VA = "0x18A5E7C50")]
		public static float[] Subtract(IReadOnlyList<float> left, IReadOnlyList<float> right)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F32")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7980", Offset = "0xA5E6380", VA = "0x18A5E7980")]
		public static float[] InterpolateLinear(IReadOnlyList<float> start, IReadOnlyList<float> end, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F33")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6DA0", Offset = "0xA5E57A0", VA = "0x18A5E6DA0")]
		public static float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F34")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6880", Offset = "0xA5E5280", VA = "0x18A5E6880")]
		public static Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F35")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6AA0", Offset = "0xA5E54A0", VA = "0x18A5E6AA0")]
		public static Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F36")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6EC0", Offset = "0xA5E58C0", VA = "0x18A5E6EC0")]
		public static Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F37")]
		[Cpp2IlInjected.Address(RVA = "0xA5E77A0", Offset = "0xA5E61A0", VA = "0x18A5E77A0")]
		public static Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F38")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7200", Offset = "0xA5E5C00", VA = "0x18A5E7200")]
		public static float[] InterpolateCubic(IReadOnlyList<float> start, IReadOnlyList<float> outgoingTangent, IReadOnlyList<float> end, IReadOnlyList<float> incomingTangent, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F39")]
		[Cpp2IlInjected.Address(RVA = "0x38C92C0", Offset = "0x38C7CC0", VA = "0x1838C92C0")]
		private static bool _HasZero<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3A")]
		[Cpp2IlInjected.Address(RVA = "0x38C8E40", Offset = "0x38C7840", VA = "0x1838C8E40")]
		private static bool _HasOne<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5490", Offset = "0xA5E3E90", VA = "0x18A5E5490")]
		public static ICurveSampler<bool> CreateSampler(this IEnumerable<(float, bool)> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4850", Offset = "0xA5E3250", VA = "0x18A5E4850")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, float)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4BF0", Offset = "0xA5E35F0", VA = "0x18A5E4BF0")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, Vector2)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5250", Offset = "0xA5E3C50", VA = "0x18A5E5250")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, Vector3)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E55F0", Offset = "0xA5E3FF0", VA = "0x18A5E55F0")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, Vector4)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F40")]
		[Cpp2IlInjected.Address(RVA = "0xA5E43D0", Offset = "0xA5E2DD0", VA = "0x18A5E43D0")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, Quaternion)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F41")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5830", Offset = "0xA5E4230", VA = "0x18A5E5830")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, float[])> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F42")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4030", Offset = "0xA5E2A30", VA = "0x18A5E4030")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, ArraySegment<float>)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F43")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4610", Offset = "0xA5E3010", VA = "0x18A5E4610")]
		public static ICurveSampler<SparseWeight8> CreateSampler(this IEnumerable<(float, SparseWeight8)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F44")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5A70", Offset = "0xA5E4470", VA = "0x18A5E5A70")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, (float, float, float))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F45")]
		[Cpp2IlInjected.Address(RVA = "0xA5E50F0", Offset = "0xA5E3AF0", VA = "0x18A5E50F0")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, (Vector2, Vector2, Vector2))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F46")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4F90", Offset = "0xA5E3990", VA = "0x18A5E4F90")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, (Vector3, Vector3, Vector3))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F47")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5D30", Offset = "0xA5E4730", VA = "0x18A5E5D30")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, (Vector4, Vector4, Vector4))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F48")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5BD0", Offset = "0xA5E45D0", VA = "0x18A5E5BD0")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F49")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4A90", Offset = "0xA5E3490", VA = "0x18A5E4A90")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, (float[], float[], float[]))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4270", Offset = "0xA5E2C70", VA = "0x18A5E4270")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4E30", Offset = "0xA5E3830", VA = "0x18A5E4E30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5AEB0", Offset = "0xD598B0", VA = "0x180D5AEB0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F55")]
		[Cpp2IlInjected.Address(RVA = "0x538F400", Offset = "0x538DE00", VA = "0x18538F400", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F56")]
		[Cpp2IlInjected.Address(RVA = "0x53948A0", Offset = "0x53932A0", VA = "0x1853948A0")]
		public CubicSampler(IEnumerable<(float, (T, T, T))> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F58")]
		[Cpp2IlInjected.Address(RVA = "0x5391250", Offset = "0x538FC50", VA = "0x185391250", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F59")]
		[Cpp2IlInjected.Address(RVA = "0x53919D0", Offset = "0x53903D0", VA = "0x1853919D0", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5A")]
		[Cpp2IlInjected.Address(RVA = "0x53919D0", Offset = "0x53903D0", VA = "0x1853919D0", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5B")]
		[Cpp2IlInjected.Address(RVA = "0x53933A0", Offset = "0x5391DA0", VA = "0x1853933A0", Slot = "9")]
		IReadOnlyDictionary<float, (T, T, T)> IConvertibleCurve<T>.ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5C")]
		[Cpp2IlInjected.Address(RVA = "0x5393F40", Offset = "0x5392940", VA = "0x185393F40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F66")]
		[Cpp2IlInjected.Address(RVA = "0x6358010", Offset = "0x6356A10", VA = "0x186358010")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F67")]
		[Cpp2IlInjected.Address(RVA = "0x63578C0", Offset = "0x63562C0", VA = "0x1863578C0")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, (T, T, T) Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F68")]
		[Cpp2IlInjected.Address(RVA = "0x63573B0", Offset = "0x6355DB0", VA = "0x1863573B0", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F69")]
		[Cpp2IlInjected.Address(RVA = "0x12B5C10", Offset = "0x12B4610", VA = "0x1812B5C10")]
		private FixedSampler(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6B")]
		[Cpp2IlInjected.Address(RVA = "0x12B5BE0", Offset = "0x12B45E0", VA = "0x1812B5BE0", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6C")]
		[Cpp2IlInjected.Address(RVA = "0x63588E0", Offset = "0x63572E0", VA = "0x1863588E0", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6D")]
		[Cpp2IlInjected.Address(RVA = "0x63588E0", Offset = "0x63572E0", VA = "0x1863588E0", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6E")]
		[Cpp2IlInjected.Address(RVA = "0x6359420", Offset = "0x6357E20", VA = "0x186359420", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6F")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A340", Offset = "0x6A28D40", VA = "0x186A2A340", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F70")]
		[Cpp2IlInjected.Address(RVA = "0x53948A0", Offset = "0x53932A0", VA = "0x1853948A0")]
		public LinearSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F72")]
		[Cpp2IlInjected.Address(RVA = "0x6A2B5B0", Offset = "0x6A29FB0", VA = "0x186A2B5B0", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F73")]
		[Cpp2IlInjected.Address(RVA = "0x6A2F060", Offset = "0x6A2DA60", VA = "0x186A2F060", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F74")]
		[Cpp2IlInjected.Address(RVA = "0x6A2ECD0", Offset = "0x6A2D6D0", VA = "0x186A2ECD0", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F75")]
		[Cpp2IlInjected.Address(RVA = "0x6A2F060", Offset = "0x6A2DA60", VA = "0x186A2F060", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F76")]
		[Cpp2IlInjected.Address(RVA = "0x6A2CE40", Offset = "0x6A2B840", VA = "0x186A2CE40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F80")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A340", Offset = "0x6A28D40", VA = "0x186A2A340", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F81")]
		[Cpp2IlInjected.Address(RVA = "0x53948A0", Offset = "0x53932A0", VA = "0x1853948A0")]
		public StepSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F83")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE030", Offset = "0x7AECA30", VA = "0x187AEE030", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F84")]
		[Cpp2IlInjected.Address(RVA = "0x7AEF0C0", Offset = "0x7AEDAC0", VA = "0x187AEF0C0", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F85")]
		[Cpp2IlInjected.Address(RVA = "0x7AEEFA0", Offset = "0x7AED9A0", VA = "0x187AEEFA0", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F86")]
		[Cpp2IlInjected.Address(RVA = "0x7AEEFA0", Offset = "0x7AED9A0", VA = "0x187AEEFA0", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F87")]
		[Cpp2IlInjected.Address(RVA = "0x6A2CE40", Offset = "0x6A2B840", VA = "0x186A2CE40")]
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
			[Cpp2IlInjected.Address(RVA = "0x13FC9E0", Offset = "0x13FB3E0", VA = "0x1813FC9E0", Slot = "4")]
			public bool Clone(bool value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F96")]
			[Cpp2IlInjected.Address(RVA = "0xA5F20D0", Offset = "0xA5F0AD0", VA = "0x18A5F20D0", Slot = "5")]
			public bool InterpolateLinear(bool left, bool right, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F97")]
			[Cpp2IlInjected.Address(RVA = "0xA5F20B0", Offset = "0xA5F0AB0", VA = "0x18A5F20B0", Slot = "6")]
			public bool InterpolateCubic(bool start, bool outgoingTangent, bool end, bool incomingTangent, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F98")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public _Boolean()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		private sealed class _Scalar : ISamplerTraits<float>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F99")]
			[Cpp2IlInjected.Address(RVA = "0xF09E20", Offset = "0xF08820", VA = "0x180F09E20", Slot = "4")]
			public float Clone(float value)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9A")]
			[Cpp2IlInjected.Address(RVA = "0xA5F57E0", Offset = "0xA5F41E0", VA = "0x18A5F57E0", Slot = "5")]
			public float InterpolateLinear(float left, float right, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9B")]
			[Cpp2IlInjected.Address(RVA = "0xA5F56D0", Offset = "0xA5F40D0", VA = "0x18A5F56D0", Slot = "6")]
			public float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9C")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public _Scalar()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		private sealed class _Vector2 : ISamplerTraits<Vector2>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F9D")]
			[Cpp2IlInjected.Address(RVA = "0xD3BAF0", Offset = "0xD3A4F0", VA = "0x180D3BAF0", Slot = "4")]
			public Vector2 Clone(Vector2 value)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9E")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5BA0", Offset = "0xA5F45A0", VA = "0x18A5F5BA0", Slot = "5")]
			public Vector2 InterpolateLinear(Vector2 left, Vector2 right, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9F")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5B60", Offset = "0xA5F4560", VA = "0x18A5F5B60", Slot = "6")]
			public Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA0")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public _Vector2()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private sealed class _Vector3 : ISamplerTraits<Vector3>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA1")]
			[Cpp2IlInjected.Address(RVA = "0x10524F0", Offset = "0x1050EF0", VA = "0x1810524F0", Slot = "4")]
			public Vector3 Clone(Vector3 value)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA2")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5CC0", Offset = "0xA5F46C0", VA = "0x18A5F5CC0", Slot = "5")]
			public Vector3 InterpolateLinear(Vector3 left, Vector3 right, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA3")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5C00", Offset = "0xA5F4600", VA = "0x18A5F5C00", Slot = "6")]
			public Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA4")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public _Vector3()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B0")]
		private sealed class _Vector4 : ISamplerTraits<Vector4>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA5")]
			[Cpp2IlInjected.Address(RVA = "0x12AA260", Offset = "0x12A8C60", VA = "0x1812AA260", Slot = "4")]
			public Vector4 Clone(Vector4 value)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA6")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5DC0", Offset = "0xA5F47C0", VA = "0x18A5F5DC0", Slot = "5")]
			public Vector4 InterpolateLinear(Vector4 left, Vector4 right, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA7")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5D30", Offset = "0xA5F4730", VA = "0x18A5F5D30", Slot = "6")]
			public Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA8")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public _Vector4()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B1")]
		private sealed class _Quaternion : ISamplerTraits<Quaternion>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA9")]
			[Cpp2IlInjected.Address(RVA = "0x12AA260", Offset = "0x12A8C60", VA = "0x1812AA260", Slot = "4")]
			public Quaternion Clone(Quaternion value)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5680", Offset = "0xA5F4080", VA = "0x18A5F5680", Slot = "5")]
			public Quaternion InterpolateLinear(Quaternion left, Quaternion right, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAB")]
			[Cpp2IlInjected.Address(RVA = "0xA5F54B0", Offset = "0xA5F3EB0", VA = "0x18A5F54B0", Slot = "6")]
			public Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAC")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public _Quaternion()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		private sealed class _Array : ISamplerTraits<float[]>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FAD")]
			[Cpp2IlInjected.Address(RVA = "0xA5F1FE0", Offset = "0xA5F09E0", VA = "0x18A5F1FE0", Slot = "4")]
			public float[] Clone(float[] value)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAE")]
			[Cpp2IlInjected.Address(RVA = "0xA5F2090", Offset = "0xA5F0A90", VA = "0x18A5F2090", Slot = "5")]
			public float[] InterpolateLinear(float[] left, float[] right, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAF")]
			[Cpp2IlInjected.Address(RVA = "0xA5F2060", Offset = "0xA5F0A60", VA = "0x18A5F2060", Slot = "6")]
			public float[] InterpolateCubic(float[] start, float[] outgoingTangent, float[] end, float[] incomingTangent, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB0")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public _Array()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		private sealed class _Segment : ISamplerTraits<ArraySegment<float>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB1")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5800", Offset = "0xA5F4200", VA = "0x18A5F5800", Slot = "4")]
			public ArraySegment<float> Clone(ArraySegment<float> value)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB2")]
			[Cpp2IlInjected.Address(RVA = "0xA5F59C0", Offset = "0xA5F43C0", VA = "0x18A5F59C0", Slot = "5")]
			public ArraySegment<float> InterpolateLinear(ArraySegment<float> left, ArraySegment<float> right, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB3")]
			[Cpp2IlInjected.Address(RVA = "0xA5F58A0", Offset = "0xA5F42A0", VA = "0x18A5F58A0", Slot = "6")]
			public ArraySegment<float> InterpolateCubic(ArraySegment<float> start, ArraySegment<float> outgoingTangent, ArraySegment<float> end, ArraySegment<float> incomingTangent, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB4")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public _Segment()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		private sealed class _Sparse : ISamplerTraits<SparseWeight8>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB5")]
			[Cpp2IlInjected.Address(RVA = "0x572A070", Offset = "0x5728A70", VA = "0x18572A070", Slot = "4")]
			public SparseWeight8 Clone(SparseWeight8 value)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB6")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5B00", Offset = "0xA5F4500", VA = "0x18A5F5B00", Slot = "5")]
			public SparseWeight8 InterpolateLinear(SparseWeight8 left, SparseWeight8 right, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB7")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5A80", Offset = "0xA5F4480", VA = "0x18A5F5A80", Slot = "6")]
			public SparseWeight8 InterpolateCubic(SparseWeight8 start, SparseWeight8 outgoingTangent, SparseWeight8 end, SparseWeight8 incomingTangent, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB8")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x37D2D60", Offset = "0x37D1760", VA = "0x1837D2D60")]
		public static ICurveSampler<T> CreateFrom<TKey>(IEnumerable<(float, TKey)> sequence, Func<(float, TKey)[], ICurveSampler<T>> chunkFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBA")]
		[Cpp2IlInjected.Address(RVA = "0x630CC50", Offset = "0x630B650", VA = "0x18630CC50")]
		private FastCurveSampler(IEnumerable<ICurveSampler<T>> samplers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBB")]
		[Cpp2IlInjected.Address(RVA = "0x630C5E0", Offset = "0x630AFE0", VA = "0x18630C5E0", Slot = "4")]
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

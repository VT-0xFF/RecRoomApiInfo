using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using SharpGLTF.Animations;
using SharpGLTF.Schema2;
using SharpGLTF.Transforms;

[assembly: AssemblyVersion("1.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
namespace SharpGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DebuggerStepThrough]
	internal static class Guard
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly IReadOnlyList<char> _InvalidRelativePathChars;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE490", Offset = "0xA5ED090", VA = "0x18A5EE490")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED460", Offset = "0xA5EC060", VA = "0x18A5ED460")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED6D0", Offset = "0xA5EC2D0", VA = "0x18A5ED6D0")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED920", Offset = "0xA5EC520", VA = "0x18A5ED920")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED3C0", Offset = "0xA5EBFC0", VA = "0x18A5ED3C0")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE110", Offset = "0xA5ECD10", VA = "0x18A5EE110")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA5EDFF0", Offset = "0xA5ECBF0", VA = "0x18A5EDFF0")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE5E0", Offset = "0xA5ED1E0", VA = "0x18A5EE5E0")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE580", Offset = "0xA5ED180", VA = "0x18A5EE580")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA5EDE30", Offset = "0xA5ECA30", VA = "0x18A5EDE30")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB170", Offset = "0x3AE9D70", VA = "0x183AEB170")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9AC0", Offset = "0x3AE86C0", VA = "0x183AE9AC0")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5EDE90", Offset = "0xA5ECA90", VA = "0x18A5EDE90")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3AEAC10", Offset = "0x3AE9810", VA = "0x183AEAC10")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA7B0", Offset = "0x3AE93B0", VA = "0x183AEA7B0")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA370", Offset = "0x3AE8F70", VA = "0x183AEA370")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA070", Offset = "0x3AE8C70", VA = "0x183AEA070")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9370", Offset = "0x3AE7F70", VA = "0x183AE9370")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA5EDA20", Offset = "0xA5EC620", VA = "0x18A5EDA20")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED9C0", Offset = "0xA5EC5C0", VA = "0x18A5ED9C0")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA5EDA80", Offset = "0xA5EC680", VA = "0x18A5EDA80")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE330", Offset = "0xA5ECF30", VA = "0x18A5EE330")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE230", Offset = "0xA5ECE30", VA = "0x18A5EE230")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8060", Offset = "0x3AE6C60", VA = "0x183AE8060")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED130", Offset = "0xA5EBD30", VA = "0x18A5ED130")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6EF0", Offset = "0x3AE5AF0", VA = "0x183AE6EF0")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6EF0", Offset = "0x3AE5AF0", VA = "0x183AE6EF0")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6EF0", Offset = "0x3AE5AF0", VA = "0x183AE6EF0")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6EF0", Offset = "0x3AE5AF0", VA = "0x183AE6EF0")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6EF0", Offset = "0x3AE5AF0", VA = "0x183AE6EF0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6290", Offset = "0x3AE4E90", VA = "0x183AE6290")]
		public static void MustBeBetweenOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	internal static class _Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private readonly struct _ListSelect<TSource, TResult> : IReadOnlyList<TResult>, IEnumerable<TResult>, IEnumerable, IReadOnlyCollection<TResult>
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
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
					[Cpp2IlInjected.Token(Token = "0x600007B")]
					[Cpp2IlInjected.Address(RVA = "0x667B970", Offset = "0x667A570", VA = "0x18667B970", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return (TResult)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600007D")]
					[Cpp2IlInjected.Address(RVA = "0x667BA20", Offset = "0x667A620", VA = "0x18667BA20", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x5117D20", Offset = "0x5116920", VA = "0x185117D20")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x667BBB0", Offset = "0x667A7B0", VA = "0x18667BBB0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x667C840", Offset = "0x667B440", VA = "0x18667C840", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6681B20", Offset = "0x6680720", VA = "0x186681B20")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
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
					[Cpp2IlInjected.Token(Token = "0x6000082")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000084")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x6E3CFC0", Offset = "0x6E3BBC0", VA = "0x186E3CFC0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6E42350", Offset = "0x6E40F50", VA = "0x186E42350", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6E467B0", Offset = "0x6E453B0", VA = "0x186E467B0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x515AA00", Offset = "0x5159600", VA = "0x18515AA00", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x515A9A0", Offset = "0x51595A0", VA = "0x18515A9A0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x515A700", Offset = "0x5159300", VA = "0x18515A700", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x515A820", Offset = "0x5159420", VA = "0x18515A820", Slot = "7")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<System-Collections-IEnumerable-GetEnumerator>d__8))]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private readonly struct _CollectionSelect<TSource, TResult> : IReadOnlyCollection<TResult>, IEnumerable<TResult>, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x200000D")]
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
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0x667B970", Offset = "0x667A570", VA = "0x18667B970", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return (TResult)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0x667BA20", Offset = "0x667A620", VA = "0x18667BA20", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x5117D20", Offset = "0x5116920", VA = "0x185117D20")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x667BBB0", Offset = "0x667A7B0", VA = "0x18667BBB0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x667B100", Offset = "0x6679D00", VA = "0x18667B100", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x667C150", Offset = "0x667AD50", VA = "0x18667C150")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
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
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6E3CFC0", Offset = "0x6E3BBC0", VA = "0x186E3CFC0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6E3BD60", Offset = "0x6E3A960", VA = "0x186E3BD60", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6E3D4D0", Offset = "0x6E3C0D0", VA = "0x186E3D4D0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
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
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x5151B00", Offset = "0x5150700", VA = "0x185151B00", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5151860", Offset = "0x5150460", VA = "0x185151860", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5151A30", Offset = "0x5150630", VA = "0x185151A30", Slot = "6")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<System-Collections-IEnumerable-GetEnumerator>d__6))]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
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
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x13F8890", Offset = "0x13F7490", VA = "0x1813F8890", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xA5F53C0", Offset = "0xA5F3FC0", VA = "0x18A5F53C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x64DD0E0", Offset = "0x64DBCE0", VA = "0x1864DD0E0")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5410", Offset = "0xA5F4010", VA = "0x18A5F5410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5070", Offset = "0xA5F3C70", VA = "0x18A5F5070", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA5F54D0", Offset = "0xA5F40D0", VA = "0x18A5F54D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5380", Offset = "0xA5F3F80", VA = "0x18A5F5380", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA5F52D0", Offset = "0xA5F3ED0", VA = "0x18A5F52D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA5F52D0", Offset = "0xA5F3ED0", VA = "0x18A5F52D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
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
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x19FE720", Offset = "0x19FD320", VA = "0x1819FE720", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0xA5F5EB0", Offset = "0xA5F4AB0", VA = "0x18A5F5EB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5F00", Offset = "0xA5F4B00", VA = "0x18A5F5F00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5520", Offset = "0xA5F4120", VA = "0x18A5F5520", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F60F0", Offset = "0xA5F4CF0", VA = "0x18A5F60F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA5F6140", Offset = "0xA5F4D40", VA = "0x18A5F6140")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA5F6190", Offset = "0xA5F4D90", VA = "0x18A5F6190")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5E70", Offset = "0xA5F4A70", VA = "0x18A5F5E70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5DC0", Offset = "0xA5F49C0", VA = "0x18A5F5DC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA5F5DC0", Offset = "0xA5F49C0", VA = "0x18A5F5DC0", Slot = "5")]
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

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA544900", Offset = "0xA543500", VA = "0x18A544900")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA5462D0", Offset = "0xA544ED0", VA = "0x18A5462D0")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA546400", Offset = "0xA545000", VA = "0x18A546400")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA546310", Offset = "0xA544F10", VA = "0x18A546310")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA546430", Offset = "0xA545030", VA = "0x18A546430")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA546370", Offset = "0xA544F70", VA = "0x18A546370")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5464A0", Offset = "0xA5450A0", VA = "0x18A5464A0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA546370", Offset = "0xA544F70", VA = "0x18A546370")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA546200", Offset = "0xA544E00", VA = "0x18A546200")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7760", Offset = "0xA5F6360", VA = "0x18A5F7760")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7640", Offset = "0xA5F6240", VA = "0x18A5F7640")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA543CA0", Offset = "0xA5428A0", VA = "0x18A543CA0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7FF0", Offset = "0xA5F6BF0", VA = "0x18A5F7FF0")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA5448B0", Offset = "0xA5434B0", VA = "0x18A5448B0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA544850", Offset = "0xA543450", VA = "0x18A544850")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA544B30", Offset = "0xA543730", VA = "0x18A544B30")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8B90", Offset = "0xA5F7790", VA = "0x18A5F8B90")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8D10", Offset = "0xA5F7910", VA = "0x18A5F8D10")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7960", Offset = "0xA5F6560", VA = "0x18A5F7960")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7860", Offset = "0xA5F6460", VA = "0x18A5F7860")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7C30", Offset = "0xA5F6830", VA = "0x18A5F7C30")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F74B0", Offset = "0xA5F60B0", VA = "0x18A5F74B0")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA5F78E0", Offset = "0xA5F64E0", VA = "0x18A5F78E0")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA545400", Offset = "0xA544000", VA = "0x18A545400")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA5F78F0", Offset = "0xA5F64F0", VA = "0x18A5F78F0")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA544620", Offset = "0xA543220", VA = "0x18A544620")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA544560", Offset = "0xA543160", VA = "0x18A544560")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4141D90", Offset = "0x4140990", VA = "0x184141D90")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA543E10", Offset = "0xA542A10", VA = "0x18A543E10")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA543F80", Offset = "0xA542B80", VA = "0x18A543F80")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4143130", Offset = "0x4141D30", VA = "0x184143130")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4144250", Offset = "0x4142E50", VA = "0x184144250")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4144420", Offset = "0x4143020", VA = "0x184144420")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4144500", Offset = "0x4143100", VA = "0x184144500")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4141DB0", Offset = "0x41409B0", VA = "0x184141DB0")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4142F70", Offset = "0x4141B70", VA = "0x184142F70")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4142E60", Offset = "0x4141A60", VA = "0x184142E60")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x41425A0", Offset = "0x41411A0", VA = "0x1841425A0")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4144170", Offset = "0x4142D70", VA = "0x184144170")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4143AE0", Offset = "0x41426E0", VA = "0x184143AE0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4143F20", Offset = "0x4142B20", VA = "0x184143F20")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4143C80", Offset = "0x4142880", VA = "0x184143C80")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4142450", Offset = "0x4141050", VA = "0x184142450")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4142200", Offset = "0x4140E00", VA = "0x184142200")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4141A10", Offset = "0x4140610", VA = "0x184141A10")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4141E40", Offset = "0x4140A40", VA = "0x184141E40")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7A30", Offset = "0xA5F6630", VA = "0x18A5F7A30")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7D90", Offset = "0xA5F6990", VA = "0x18A5F7D90")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x41441D0", Offset = "0x4142DD0", VA = "0x1841441D0")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x41441D0", Offset = "0x4142DD0", VA = "0x1841441D0")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F82A0", Offset = "0xA5F6EA0", VA = "0x18A5F82A0")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6EB0", Offset = "0xA5F5AB0", VA = "0x18A5F6EB0")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6E00", Offset = "0xA5F5A00", VA = "0x18A5F6E00")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8220", Offset = "0xA5F6E20", VA = "0x18A5F8220")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8960", Offset = "0xA5F7560", VA = "0x18A5F8960")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6F30", Offset = "0xA5F5B30", VA = "0x18A5F6F30")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA5F84A0", Offset = "0xA5F70A0", VA = "0x18A5F84A0")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8570", Offset = "0xA5F7170", VA = "0x18A5F8570")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7250", Offset = "0xA5F5E50", VA = "0x18A5F7250")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6FF0", Offset = "0xA5F5BF0", VA = "0x18A5F6FF0")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA5F72F0", Offset = "0xA5F5EF0", VA = "0x18A5F72F0")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7130", Offset = "0xA5F5D30", VA = "0x18A5F7130")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7430", Offset = "0xA5F6030", VA = "0x18A5F7430")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2382940", Offset = "0x2381540", VA = "0x182382940")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA5462F0", Offset = "0xA544EF0", VA = "0x18A5462F0")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4144730", Offset = "0x4143330", VA = "0x184144730")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8160", Offset = "0xA5F6D60", VA = "0x18A5F8160")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F71B0", Offset = "0xA5F5DB0", VA = "0x18A5F71B0")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8AE0", Offset = "0xA5F76E0", VA = "0x18A5F8AE0")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8F10", Offset = "0xA5F7B10", VA = "0x18A5F8F10")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA5F89E0", Offset = "0xA5F75E0", VA = "0x18A5F89E0")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA543EB0", Offset = "0xA542AB0", VA = "0x18A543EB0")]
		public static bool DeepEquals(this JsonNode x, JsonNode y, double precission)
		{
			return default(bool);
		}
	}
}
namespace SharpGLTF.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal sealed class AnimatableProperty<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private List<ICurveSampler<T>> _Curves;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2A30", VA = "0x180EA3E30")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCFD470", Offset = "0xCFC070", VA = "0x180CFD470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x73726C0", Offset = "0x73712C0", VA = "0x1873726C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7371510", Offset = "0x7370110", VA = "0x187371510")]
		internal AnimatableProperty(T defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7368A90", Offset = "0x7367690", VA = "0x187368A90")]
		public T GetValueAt(int trackLogicalIndex, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x736A110", Offset = "0x7368D10", VA = "0x18736A110")]
		public void SetCurve(int trackLogicalIndex, ICurveSampler<T> curveSampler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[DebuggerDisplay("{Name} {Duration}s")]
	public class AnimationTrackInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xD47F10", Offset = "0xD46B10", VA = "0x180D47F10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x10AD2D0", Offset = "0x10ABED0", VA = "0x1810AD2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA220", Offset = "0xA5E8E20", VA = "0x18A5EA220")]
		internal AnimationTrackInfo(string name, object extras, float duration)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ArmatureInstance
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal readonly ArmatureTemplate _Template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IReadOnlyList<NodeTemplate> _NodeTemplates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IReadOnlyList<NodeInstance> _NodeInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IReadOnlyList<MaterialTemplate> _MaterialTemplates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IReadOnlyList<AnimationTrackInfo> _AnimationTracks;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IReadOnlyList<NodeInstance> LogicalNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<NodeInstance> VisualNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5EAA20", Offset = "0xA5E9620", VA = "0x18A5EAA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyList<AnimationTrackInfo> AnimationTracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA7E0", Offset = "0xA5E93E0", VA = "0x18A5EA7E0")]
		internal ArmatureInstance(ArmatureTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA300", Offset = "0xA5E8F00", VA = "0x18A5EA300")]
		public void SetLocalMatrix(string name, Matrix4x4 localMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA4A0", Offset = "0xA5E90A0", VA = "0x18A5EA4A0")]
		public void SetModelMatrix(string name, Matrix4x4 modelMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA7A0", Offset = "0xA5E93A0", VA = "0x18A5EA7A0")]
		public void SetPoseTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA290", Offset = "0xA5E8E90", VA = "0x18A5EA290")]
		public void SetAnimationFrame(int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA2D0", Offset = "0xA5E8ED0", VA = "0x18A5EA2D0")]
		public void SetAnimationFrame(params (int TrackIdx, float Time, float Weight)[] blended)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal class ArmatureTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly NodeTemplate[] _NodeTemplates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MaterialTemplate[] _MaterialTemplates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly AnimationTrackInfo[] _AnimationTracks;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyList<NodeTemplate> Nodes
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyList<MaterialTemplate> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<AnimationTrackInfo> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5EB880", Offset = "0xA5EA480", VA = "0x18A5EB880")]
		internal static ArmatureTemplate Create(Scene srcScene, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC770", Offset = "0xA5EB370", VA = "0x18A5EC770")]
		private ArmatureTemplate(NodeTemplate[] nodes, MaterialTemplate[] materials, AnimationTrackInfo[] animTracks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5EB850", Offset = "0xA5EA450", VA = "0x18A5EB850")]
		internal void ApplyDefaultPoseTo(ArmatureInstance instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5EAB40", Offset = "0xA5E9740", VA = "0x18A5EAB40")]
		internal void ApplyAnimationTo(ArmatureInstance instance, int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5EAF10", Offset = "0xA5E9B10", VA = "0x18A5EAF10")]
		internal void ApplyAnimationTo(ArmatureInstance instance, (int TrackIdx, float Time, float Weight)[] blended)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC540", Offset = "0xA5EB140", VA = "0x18A5EC540")]
		private void _SetVisibility(ArmatureInstance instance, int index, bool isVisible)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DebuggerDisplay("{_ToDebuggerDisplayString(),nq}")]
	public readonly struct DrawableInstance
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly IDrawableTemplate Template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly IGeometryTransform Transform;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int InstanceCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA5ED060", Offset = "0xA5EBC60", VA = "0x18A5ED060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5ECCD0", Offset = "0xA5EB8D0", VA = "0x18A5ECCD0")]
		private string _ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
		internal DrawableInstance(IDrawableTemplate t, IGeometryTransform xform)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface IDrawableTemplate
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		int LogicalMeshIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal abstract class DrawableTemplate : IDrawableTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _NodeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _LogicalNodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _LogicalMeshIndex;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string NodeName
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int LogicalMeshIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x16230F0", Offset = "0x1621CF0", VA = "0x1816230F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED0C0", Offset = "0xA5EBCC0", VA = "0x18A5ED0C0")]
		protected DrawableTemplate(Node node, int nodeIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract IGeometryTransform CreateGeometryTransform();

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void UpdateGeometryTransform(IGeometryTransform geoxform, ArmatureInstance armature);
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class RigidDrawableTemplate : DrawableTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly int _NodeIndex;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3A60", Offset = "0xA5F2660", VA = "0x18A5F3A60")]
		internal RigidDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3890", Offset = "0xA5F2490", VA = "0x18A5F3890", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5F38E0", Offset = "0xA5F24E0", VA = "0x18A5F38E0", Slot = "7")]
		public override void UpdateGeometryTransform(IGeometryTransform rigidTransform, ArmatureInstance armature)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class InstancedDrawableTemplate : RigidDrawableTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly AffineTransform[] _Instances;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IReadOnlyList<AffineTransform> Instances
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE9F0", Offset = "0xA5ED5F0", VA = "0x18A5EE9F0")]
		internal InstancedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE780", Offset = "0xA5ED380", VA = "0x18A5EE780", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE7E0", Offset = "0xA5ED3E0", VA = "0x18A5EE7E0", Slot = "7")]
		public override void UpdateGeometryTransform(IGeometryTransform rigidTransform, ArmatureInstance armature)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal sealed class SkinnedDrawableTemplate : DrawableTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly int _MorphNodeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly int[] _JointsNodeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly Matrix4x4[] _BindMatrices;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA5F4BE0", Offset = "0xA5F37E0", VA = "0x18A5F4BE0")]
		internal SkinnedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F4960", Offset = "0xA5F3560", VA = "0x18A5F4960", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5F49B0", Offset = "0xA5F35B0", VA = "0x18A5F49B0", Slot = "7")]
		public override void UpdateGeometryTransform(IGeometryTransform skinnedTransform, ArmatureInstance armature)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class MaterialInstance
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public MaterialInstance()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class MaterialTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly int _LogicalSourceIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly string _PointerPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly Dictionary<string, AnimatableProperty<float>> _ScalarAnimatables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly Dictionary<string, AnimatableProperty<Vector2>> _Vector2Animatables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly Dictionary<string, AnimatableProperty<Vector3>> _Vector3Animatables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly Dictionary<string, AnimatableProperty<Vector4>> _Vector4Animatables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private bool _IsAnimated;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xF50890", Offset = "0xF4F490", VA = "0x180F50890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xCEE170", Offset = "0xCECD70", VA = "0x180CEE170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF270", Offset = "0xA5EDE70", VA = "0x18A5EF270")]
		internal MaterialTemplate(Material srcMaterial, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3D06C90", Offset = "0x3D05890", VA = "0x183D06C90")]
		private void _AddAnimatableProperty<T>(Dictionary<string, AnimatableProperty<T>> dict, int trackIdx, AnimationChannel channel, string pointerPath, T defaultSingle, bool isolateMemory) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA5EEEF0", Offset = "0xA5EDAF0", VA = "0x18A5EEEF0")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, float> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA5EEB70", Offset = "0xA5ED770", VA = "0x18A5EEB70")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector2> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF090", Offset = "0xA5EDC90", VA = "0x18A5EF090")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector3> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA5EED20", Offset = "0xA5ED920", VA = "0x18A5EED20")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector4> target)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface IMeshDecoder<TMaterial> where TMaterial : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		IReadOnlyList<IMeshPrimitiveDecoder<TMaterial>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface IMeshPrimitiveDecoder
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		int VertexCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		int ColorsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		int TexCoordsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		int JointsWeightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		IEnumerable<(int A, int B)> LineIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		IEnumerable<(int A, int B, int C)> TriangleIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Vector3 GetPosition(int vertexIndex);

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		Vector3 GetNormal(int vertexIndex);

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		Vector4 GetTangent(int vertexIndex);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Vector2 GetTextureCoord(int vertexIndex, int textureSetIndex);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		Vector4 GetColor(int vertexIndex, int colorSetIndex);

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SparseWeight8 GetSkinWeights(int vertexIndex);

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "13")]
		IReadOnlyList<Vector3> GetPositionDeltas(int vertexIndex);

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "14")]
		IReadOnlyList<Vector3> GetNormalDeltas(int vertexIndex);

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IReadOnlyList<Vector3> GetTangentDeltas(int vertexIndex);

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "16")]
		IReadOnlyList<Vector2> GetTextureCoordDeltas(int vertexIndex, int textureSetIndex);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "17")]
		IReadOnlyList<Vector4> GetColorDeltas(int vertexIndex, int colorSetIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IMeshPrimitiveDecoder<TMaterial> : IMeshPrimitiveDecoder where TMaterial : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		TMaterial Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class MeshDecoder
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class <GetWorldVertices>d__15<TMaterial> : IEnumerable<Vector3>, IEnumerable, IEnumerator<Vector3>, IEnumerator, IDisposable where TMaterial : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private Vector3 <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private IMeshDecoder<TMaterial> mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public IMeshDecoder<TMaterial> <>3__mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private IGeometryTransform xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public IGeometryTransform <>3__xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private IEnumerator<IGeometryTransform> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private IGeometryTransform <childXform>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private IEnumerator<IMeshPrimitiveDecoder<TMaterial>> <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private IMeshPrimitiveDecoder<TMaterial> <primitive>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private int <i>5__6;

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			Vector3 IEnumerator<Vector3>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x19FE720", Offset = "0x19FD320", VA = "0x1819FE720", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x6837880", Offset = "0x6836480", VA = "0x186837880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <GetWorldVertices>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x68378D0", Offset = "0x68364D0", VA = "0x1868378D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6837200", Offset = "0x6835E00", VA = "0x186837200", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x6837B00", Offset = "0x6836700", VA = "0x186837B00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x6837B50", Offset = "0x6836750", VA = "0x186837B50")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x64CFC80", Offset = "0x64CE880", VA = "0x1864CFC80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x68377C0", Offset = "0x68363C0", VA = "0x1868377C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFE10", Offset = "0xA5EEA10", VA = "0x18A5EFE10")]
		public static IMeshDecoder<Material> Decode(this Mesh mesh, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFCA0", Offset = "0xA5EE8A0", VA = "0x18A5EFCA0")]
		public static IMeshDecoder<Material>[] Decode(this IReadOnlyList<Mesh> meshes, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0DC0", Offset = "0xA5EF9C0", VA = "0x18A5F0DC0")]
		public static Vector3 GetPosition(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0A60", Offset = "0xA5EF660", VA = "0x18A5F0A60")]
		public static Vector3 GetNormal(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1120", Offset = "0xA5EFD20", VA = "0x18A5F1120")]
		public static Vector4 GetTangent(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1470", Offset = "0xA5F0070", VA = "0x18A5F1470")]
		public static Vector2 GetTextureCoord(this IMeshPrimitiveDecoder primitive, int vertexIdx, int textureSetIndex, IGeometryTransform xform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0700", Offset = "0xA5EF300", VA = "0x18A5F0700")]
		public static Vector4 GetColor(this IMeshPrimitiveDecoder primitive, int vertexIdx, int colorSetIndex, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFEC0", Offset = "0xA5EEAC0", VA = "0x18A5EFEC0")]
		public static (Vector3, Vector3) EvaluateBoundingBox(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F05E0", Offset = "0xA5EF1E0", VA = "0x18A5F05E0")]
		public static (Vector3, float) EvaluateBoundingSphere(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA5F02F0", Offset = "0xA5EEEF0", VA = "0x18A5F02F0")]
		public static (Vector3, float) EvaluateBoundingSphere(this SceneTemplate sceneTemplate, IMeshDecoder<Material>[] decodedMeshes, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3D1AB80", Offset = "0x3D19780", VA = "0x183D1AB80")]
		public static (Vector3, Vector3) EvaluateBoundingBox<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3D1AFC0", Offset = "0x3D19BC0", VA = "0x183D1AFC0")]
		public static (Vector3, float) EvaluateBoundingSphere<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1780", Offset = "0xA5F0380", VA = "0x18A5F1780")]
		private static void _AddPointToSphere(Vector3 c1, float r1, Vector3 c2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1A80", Offset = "0xA5F0680", VA = "0x18A5F1A80")]
		private static void _MergeSphere(Vector3 c1, float r1, Vector3 c2, float r2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B310", Offset = "0x3D19F10", VA = "0x183D1B310")]
		public static IEnumerable<Vector3> GetWorldVertices<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x39976E0", Offset = "0x39962E0", VA = "0x1839976E0")]
		[IteratorStateMachine(typeof(<GetWorldVertices>d__15<>))]
		public static IEnumerable<Vector3> GetWorldVertices<TMaterial>(this IMeshDecoder<TMaterial> mesh, IGeometryTransform xform) where TMaterial : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class _MeshDecoder<TMaterial> : IMeshDecoder<TMaterial> where TMaterial : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly string _Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly object _Extras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly int _LogicalIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly _MeshPrimitiveDecoder<TMaterial>[] _Primitives;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF270", VA = "0x180D00670", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IReadOnlyList<IMeshPrimitiveDecoder<TMaterial>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5162500", Offset = "0x5161100", VA = "0x185162500")]
		public _MeshDecoder(Mesh srcMesh, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5161A30", Offset = "0x5160630", VA = "0x185161A30")]
		public void GenerateNormalsAndTangents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[DebuggerDisplay("{_GetDebugString(),nq}")]
	internal sealed class _MeshPrimitiveDecoder<TMaterial> : _MeshPrimitiveDecoder, IMeshPrimitiveDecoder<TMaterial>, IMeshPrimitiveDecoder where TMaterial : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly TMaterial _Material;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public TMaterial Material
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xDD4470", Offset = "0xDD3070", VA = "0x180DD4470", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x51627A0", Offset = "0x51613A0", VA = "0x1851627A0")]
		internal _MeshPrimitiveDecoder(MeshPrimitive srcPrim)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[DebuggerDisplay("{_GetDebugString(),nq}")]
	internal class _MeshPrimitiveDecoder : IMeshPrimitiveDecoder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly PrimitiveType _PrimitiveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly IReadOnlyList<uint> _PrimitiveIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal readonly _MeshGeometryDecoder _Geometry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal readonly List<_MorphTargetDecoder> _MorphTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly IReadOnlyList<Vector4> _Color0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly IReadOnlyList<Vector4> _Color1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly int _ColorsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly IReadOnlyList<Vector2> _TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly IReadOnlyList<Vector2> _TexCoord1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly IReadOnlyList<Vector2> _TexCoord2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly IReadOnlyList<Vector2> _TexCoord3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly int _TexCoordCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly IReadOnlyList<Vector4> _Joints0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly IReadOnlyList<Vector4> _Joints1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly IReadOnlyList<Vector4> _Weights0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly IReadOnlyList<Vector4> _Weights1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly int _JointsWeightsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly object _Extras;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int VertexCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA5FB4A0", Offset = "0xA5FA0A0", VA = "0x18A5FB4A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int ColorsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD60", Offset = "0xD0B960", VA = "0x180D0CD60", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int TexCoordsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xE06CD0", Offset = "0xE058D0", VA = "0x180E06CD0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int JointsWeightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xCF7DB0", Offset = "0xCF69B0", VA = "0x180CF7DB0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xA5FB220", Offset = "0xA5F9E20", VA = "0x18A5FB220", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsPointIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xA5FAFC0", Offset = "0xA5F9BC0", VA = "0x18A5FAFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IEnumerable<(int A, int B)> LineIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xA5FAFE0", Offset = "0xA5F9BE0", VA = "0x18A5FAFE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public IEnumerable<(int A, int B, int C)> TriangleIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA5FB260", Offset = "0xA5F9E60", VA = "0x18A5FB260", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA3B0", Offset = "0xA5F8FB0", VA = "0x18A5FA3B0", Slot = "22")]
		protected virtual string _GetDebugString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA4B0", Offset = "0xA5F90B0", VA = "0x18A5FA4B0")]
		internal _MeshPrimitiveDecoder(MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9DC0", Offset = "0xA5F89C0", VA = "0x18A5F9DC0", Slot = "11")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9CF0", Offset = "0xA5F88F0", VA = "0x18A5F9CF0", Slot = "17")]
		public IReadOnlyList<Vector3> GetPositionDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9CB0", Offset = "0xA5F88B0", VA = "0x18A5F9CB0", Slot = "12")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9BE0", Offset = "0xA5F87E0", VA = "0x18A5F9BE0", Slot = "18")]
		public IReadOnlyList<Vector3> GetNormalDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA170", Offset = "0xA5F8D70", VA = "0x18A5FA170", Slot = "13")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA0A0", Offset = "0xA5F8CA0", VA = "0x18A5FA0A0", Slot = "19")]
		public IReadOnlyList<Vector3> GetTangentDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA2F0", Offset = "0xA5F8EF0", VA = "0x18A5FA2F0", Slot = "14")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA1B0", Offset = "0xA5F8DB0", VA = "0x18A5FA1B0", Slot = "20")]
		public IReadOnlyList<Vector2> GetTextureCoordDeltas(int vertexIndex, int texCoordSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9B30", Offset = "0xA5F8730", VA = "0x18A5F9B30", Slot = "15")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F99F0", Offset = "0xA5F85F0", VA = "0x18A5F99F0", Slot = "21")]
		public IReadOnlyList<Vector4> GetColorDeltas(int vertexIndex, int colorSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9E00", Offset = "0xA5F8A00", VA = "0x18A5F9E00", Slot = "16")]
		public SparseWeight8 GetSkinWeights(int vertexIndex)
		{
			return default(SparseWeight8);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[DebuggerDisplay("Vertices: {VertexCount}")]
	internal sealed class _MeshGeometryDecoder : VertexNormalsFactory.IMeshPrimitive, VertexTangentsFactory.IMeshPrimitive
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly _MeshPrimitiveDecoder _Owner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		internal readonly IReadOnlyList<Vector3> _Positions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IReadOnlyList<Vector3> _Normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IReadOnlyList<Vector4> _Tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private Vector3[] _GeneratedNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Vector4[] _GeneratedTangents;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int VertexCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xA5F99A0", Offset = "0xA5F85A0", VA = "0x18A5F99A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x2185050", Offset = "0x2183C50", VA = "0x182185050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xE06A00", Offset = "0xE05600", VA = "0x180E06A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9870", Offset = "0xA5F8470", VA = "0x18A5F9870")]
		public _MeshGeometryDecoder(_MeshPrimitiveDecoder owner, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9310", Offset = "0xA5F7F10", VA = "0x18A5F9310")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9230", Offset = "0xA5F7E30", VA = "0x18A5F9230")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA5F93F0", Offset = "0xA5F7FF0", VA = "0x18A5F93F0")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA5F94C0", Offset = "0xA5F80C0", VA = "0x18A5F94C0")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9170", Offset = "0xA5F7D70", VA = "0x18A5F9170")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9590", Offset = "0xA5F8190", VA = "0x18A5F9590", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9590", Offset = "0xA5F8190", VA = "0x18A5F9590", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F95B0", Offset = "0xA5F81B0", VA = "0x18A5F95B0", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F95B0", Offset = "0xA5F81B0", VA = "0x18A5F95B0", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F96D0", Offset = "0xA5F82D0", VA = "0x18A5F96D0", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9700", Offset = "0xA5F8300", VA = "0x18A5F9700", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F95E0", Offset = "0xA5F81E0", VA = "0x18A5F95E0", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9780", Offset = "0xA5F8380", VA = "0x18A5F9780", Slot = "12")]
		private void SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.SetVertexTangent(int idx, Vector4 tangent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[DebuggerDisplay("Vertices: {VertexCount}")]
	internal sealed class _MorphTargetDecoder : VertexNormalsFactory.IMeshPrimitive, VertexTangentsFactory.IMeshPrimitive
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly _MeshGeometryDecoder _Geometry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		internal readonly IReadOnlyList<Vector3> _PositionsDeltas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private IReadOnlyList<Vector3> _NormalsDeltas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private IReadOnlyList<Vector3> _TangentsDeltas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private IReadOnlyList<Vector2> _TexCoordDeltas_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private IReadOnlyList<Vector2> _TexCoordDeltas_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IReadOnlyList<Vector4> _ColorDeltas_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private IReadOnlyList<Vector4> _ColorDeltas_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private Vector3[] _GeneratedNormals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private Vector3[] _GeneratedTangents;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int VertexCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xA5FC890", Offset = "0xA5FB490", VA = "0x18A5FC890", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x2185050", Offset = "0x2183C50", VA = "0x182185050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xE06A00", Offset = "0xE05600", VA = "0x180E06A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC2C0", Offset = "0xA5FAEC0", VA = "0x18A5FC2C0")]
		public _MorphTargetDecoder(_MeshGeometryDecoder geometry, MeshPrimitive srcPrim, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBCC0", Offset = "0xA5FA8C0", VA = "0x18A5FBCC0")]
		public bool HasTexCoord(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBCA0", Offset = "0xA5FA8A0", VA = "0x18A5FBCA0")]
		public bool HasColor(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB980", Offset = "0xA5FA580", VA = "0x18A5FB980")]
		public Vector3 GetPositionBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB9C0", Offset = "0xA5FA5C0", VA = "0x18A5FB9C0")]
		public Vector3 GetPositionDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB850", Offset = "0xA5FA450", VA = "0x18A5FB850")]
		public Vector3 GetNormalBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB890", Offset = "0xA5FA490", VA = "0x18A5FB890")]
		public Vector3 GetNormalDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBAB0", Offset = "0xA5FA6B0", VA = "0x18A5FBAB0")]
		public Vector4 GetTangentBase(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBAF0", Offset = "0xA5FA6F0", VA = "0x18A5FBAF0")]
		public Vector3 GetTangentDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBC80", Offset = "0xA5FA880", VA = "0x18A5FBC80")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBBE0", Offset = "0xA5FA7E0", VA = "0x18A5FBBE0")]
		public Vector2 GetTextureCoordDelta(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB780", Offset = "0xA5FA380", VA = "0x18A5FB780")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB6D0", Offset = "0xA5FA2D0", VA = "0x18A5FB6D0")]
		public Vector4 GetColorDelta(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBCE0", Offset = "0xA5FA8E0", VA = "0x18A5FBCE0", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBF60", Offset = "0xA5FAB60", VA = "0x18A5FBF60", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBD30", Offset = "0xA5FA930", VA = "0x18A5FBD30", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBD30", Offset = "0xA5FA930", VA = "0x18A5FBD30", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBFB0", Offset = "0xA5FABB0", VA = "0x18A5FBFB0", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC080", Offset = "0xA5FAC80", VA = "0x18A5FC080", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBE00", Offset = "0xA5FAA00", VA = "0x18A5FBE00", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC100", Offset = "0xA5FAD00", VA = "0x18A5FC100", Slot = "12")]
		private void SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.SetVertexTangent(int idx, Vector4 tangent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[DebuggerDisplay("Vertex {_VertexIndex} Positions deltas")]
	internal readonly struct _MorphTargetPositionSlice : IReadOnlyList<Vector3>, IEnumerable<Vector3>, IEnumerable, IReadOnlyCollection<Vector3>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly IReadOnlyList<_MorphTargetDecoder> _Geometries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly int _VertexIndex;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Vector3 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCB10", Offset = "0xA5FB710", VA = "0x18A5FCB10", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCAC0", Offset = "0xA5FB6C0", VA = "0x18A5FCAC0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xDA7AE0", Offset = "0xDA66E0", VA = "0x180DA7AE0")]
		public _MorphTargetPositionSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCA40", Offset = "0xA5FB640", VA = "0x18A5FCA40", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCA80", Offset = "0xA5FB680", VA = "0x18A5FCA80", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[DebuggerDisplay("Vertex {_VertexIndex} Normals deltas")]
	internal readonly struct _MorphTargetNormalSlice : IReadOnlyList<Vector3>, IEnumerable<Vector3>, IEnumerable, IReadOnlyCollection<Vector3>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly IReadOnlyList<_MorphTargetDecoder> _Geometries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly int _VertexIndex;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector3 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA5FC9B0", Offset = "0xA5FB5B0", VA = "0x18A5FC9B0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5FC960", Offset = "0xA5FB560", VA = "0x18A5FC960", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xDA7AE0", Offset = "0xDA66E0", VA = "0x180DA7AE0")]
		public _MorphTargetNormalSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC8E0", Offset = "0xA5FB4E0", VA = "0x18A5FC8E0", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC920", Offset = "0xA5FB520", VA = "0x18A5FC920", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[DebuggerDisplay("Vertex {_VertexIndex} Tangents deltas")]
	internal readonly struct _MorphTargetTangentSlice : IReadOnlyList<Vector3>, IEnumerable<Vector3>, IEnumerable, IReadOnlyCollection<Vector3>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly IReadOnlyList<_MorphTargetDecoder> _Geometries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly int _VertexIndex;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCC70", Offset = "0xA5FB870", VA = "0x18A5FCC70", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCC20", Offset = "0xA5FB820", VA = "0x18A5FCC20", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xDA7AE0", Offset = "0xDA66E0", VA = "0x180DA7AE0")]
		public _MorphTargetTangentSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCBA0", Offset = "0xA5FB7A0", VA = "0x18A5FCBA0", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCBE0", Offset = "0xA5FB7E0", VA = "0x18A5FCBE0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DebuggerDisplay("Vertex {_VertexIndex} Tangents deltas")]
	internal readonly struct _MorphTargetTexCoordSlice : IReadOnlyList<Vector2>, IEnumerable<Vector2>, IEnumerable, IReadOnlyCollection<Vector2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly IReadOnlyList<_MorphTargetDecoder> _Geometries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly int _VertexIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private readonly int _TexCoordSet;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCE80", Offset = "0xA5FBA80", VA = "0x18A5FCE80", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCE30", Offset = "0xA5FBA30", VA = "0x18A5FCE30", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4EC17B0", Offset = "0x4EC03B0", VA = "0x184EC17B0")]
		public _MorphTargetTexCoordSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCDB0", Offset = "0xA5FB9B0", VA = "0x18A5FCDB0", Slot = "6")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCDF0", Offset = "0xA5FB9F0", VA = "0x18A5FCDF0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DebuggerDisplay("Vertex {_VertexIndex} Tangents deltas")]
	internal readonly struct _MorphTargetColorSlice : IReadOnlyList<Vector4>, IEnumerable<Vector4>, IEnumerable, IReadOnlyCollection<Vector4>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly IReadOnlyList<_MorphTargetDecoder> _Geometries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly int _VertexIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly int _ColorSet;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA5FB5D0", Offset = "0xA5FA1D0", VA = "0x18A5FB5D0", Slot = "4")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA5FB580", Offset = "0xA5FA180", VA = "0x18A5FB580", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4EC17B0", Offset = "0x4EC03B0", VA = "0x184EC17B0")]
		public _MorphTargetColorSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB500", Offset = "0xA5FA100", VA = "0x18A5FB500", Slot = "6")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB540", Offset = "0xA5FA140", VA = "0x18A5FB540", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[DebuggerDisplay("{Name}")]
	public sealed class NodeInstance
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly NodeTemplate _Template;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly NodeInstance _Parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private Matrix4x4 _LocalMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private Matrix4x4? _WorldMatrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private SparseWeight8 _MorphWeights;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x887B3A0", Offset = "0x8879FA0", VA = "0x18887B3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA07FCA0", Offset = "0xA07E8A0", VA = "0x18A07FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NodeInstance VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public SparseWeight8 MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA5F23B0", Offset = "0xA5F0FB0", VA = "0x18A5F23B0")]
			get
			{
				return default(SparseWeight8);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA5F2490", Offset = "0xA5F1090", VA = "0x18A5F2490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA5F2340", Offset = "0xA5F0F40", VA = "0x18A5F2340")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA5F2440", Offset = "0xA5F1040", VA = "0x18A5F2440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Matrix4x4 ModelMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F2370", Offset = "0xA5F0F70", VA = "0x18A5F2370")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA5F2190", Offset = "0xA5F0D90", VA = "0x18A5F2190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x10C0B80", Offset = "0x10BF780", VA = "0x1810C0B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x10C1A20", Offset = "0x10C0620", VA = "0x1810C1A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private bool TransformChainIsDirty
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA5F23E0", Offset = "0xA5F0FE0", VA = "0x18A5F23E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1560", VA = "0x180CF2960")]
		internal NodeInstance(NodeTemplate template, NodeInstance parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1F20", Offset = "0xA5F0B20", VA = "0x18A5F1F20")]
		private Matrix4x4 _GetModelMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2190", Offset = "0xA5F0D90", VA = "0x18A5F2190")]
		private void _SetModelMatrix(Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1E30", Offset = "0xA5F0A30", VA = "0x18A5F1E30")]
		public void SetAnimationFrame(int trackLogicalIndex, float time)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[DebuggerDisplay("[{LogicalNodeIndex}] {Name}")]
	internal class NodeTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly int _LogicalSourceIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly int _ParentIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly int[] _ChildIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly AffineTransform _LocalTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly _NodeTemplateTransforms _LocalTransformAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly AnimatableProperty<SparseWeight8> _Morphing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly bool? _IsVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly AnimatableProperty<bool> _Visibility;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xCF7720", Offset = "0xCF6320", VA = "0x180CF7720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xCF76E0", Offset = "0xCF62E0", VA = "0x180CF76E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xCF7D90", Offset = "0xCF6990", VA = "0x180CF7D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xCF7750", Offset = "0xCF6350", VA = "0x180CF7750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int ParentIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xDDD830", Offset = "0xDDC430", VA = "0x180DDD830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IReadOnlyList<int> ChildIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3810", Offset = "0xA5F2410", VA = "0x18A5F3810")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3000", Offset = "0xA5F1C00", VA = "0x18A5F3000")]
		internal NodeTemplate(Node srcNode, int parentIdx, int[] childIndices, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2D00", Offset = "0xA5F1900", VA = "0x18A5F2D00")]
		public SparseWeight8 GetMorphWeights(int trackLogicalIndex, float time)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2A30", Offset = "0xA5F1630", VA = "0x18A5F2A30")]
		public SparseWeight8 GetMorphWeights(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2740", Offset = "0xA5F1340", VA = "0x18A5F2740")]
		public AffineTransform GetLocalTransform(int trackLogicalIndex, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F27D0", Offset = "0xA5F13D0", VA = "0x18A5F27D0")]
		public AffineTransform GetLocalTransform(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5F24C0", Offset = "0xA5F10C0", VA = "0x18A5F24C0")]
		public Matrix4x4 GetLocalMatrix(int trackLogicalIndex, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F25E0", Offset = "0xA5F11E0", VA = "0x18A5F25E0")]
		public Matrix4x4 GetLocalMatrix(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2F60", Offset = "0xA5F1B60", VA = "0x18A5F2F60")]
		public bool? GetVisibility(int trackLogicalIndex, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2DE0", Offset = "0xA5F19E0", VA = "0x18A5F2DE0")]
		public bool? GetVisibility(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class _NodeTemplateTransforms
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly AnimatableProperty<Vector3> _Scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly AnimatableProperty<Quaternion> _Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly AnimatableProperty<Vector3> _Translation;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA5FD5F0", Offset = "0xA5FC1F0", VA = "0x18A5FD5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD2B0", Offset = "0xA5FBEB0", VA = "0x18A5FD2B0")]
		public _NodeTemplateTransforms(Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD160", Offset = "0xA5FBD60", VA = "0x18A5FD160")]
		public void SetCurves(NodeCurveSamplers curves, int index, bool isolateMemory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCF60", Offset = "0xA5FBB60", VA = "0x18A5FCF60")]
		public AffineTransform GetTransform(int trackLogicalIndex, float time)
		{
			return default(AffineTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum MeshInstancing
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		Discard,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Enabled,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		SingleMesh
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class RuntimeOptions
	{
		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool IsolateMemory
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xD44270", Offset = "0xD42E70", VA = "0x180D44270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xE0B9D0", Offset = "0xE0A5D0", VA = "0x180E0B9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MeshInstancing GpuMeshInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xDDD830", Offset = "0xDDC430", VA = "0x180DDD830")]
			[CompilerGenerated]
			get
			{
				return default(MeshInstancing);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xDDD820", Offset = "0xDDC420", VA = "0x180DDD820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Converter<ExtraProperties, object> ExtrasConverterCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3B00", Offset = "0xA5F2700", VA = "0x18A5F3B00")]
		internal static object ConvertExtras(ExtraProperties source, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1605850", Offset = "0x1604450", VA = "0x181605850")]
		public RuntimeOptions()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class SceneInstance : IEnumerable<DrawableInstance>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__7 : IEnumerator<DrawableInstance>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private DrawableInstance <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public SceneInstance <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			DrawableInstance IEnumerator<DrawableInstance>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(DrawableInstance);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0xA5F5020", Offset = "0xA5F3C20", VA = "0x18A5F5020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public <GetEnumerator>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA5F4E20", Offset = "0xA5F3A20", VA = "0x18A5F4E20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA5F4FE0", Offset = "0xA5F3BE0", VA = "0x18A5F4FE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ArmatureInstance _Armature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly DrawableTemplate[] _DrawableReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IGeometryTransform[] _DrawableTransforms;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public ArmatureInstance Armature
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3BE0", Offset = "0xA5F27E0", VA = "0x18A5F3BE0")]
		internal SceneInstance(ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3B70", Offset = "0xA5F2770", VA = "0x18A5F3B70", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3B70", Offset = "0xA5F2770", VA = "0x18A5F3B70", Slot = "4")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__7))]
		public IEnumerator<DrawableInstance> GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class SceneTemplate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly string _Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly object _Extras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ArmatureTemplate _Armature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly DrawableTemplate[] _DrawableReferences;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public (Vector3 center, float radius) SphereBounds
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xF61530", Offset = "0xF60130", VA = "0x180F61530")]
			[CompilerGenerated]
			get
			{
				return default((Vector3, float));
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xF615B0", Offset = "0xF601B0", VA = "0x180F615B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public IEnumerable<int> LogicalMeshIds
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA5F4830", Offset = "0xA5F3430", VA = "0x18A5F4830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3F10", Offset = "0xA5F2B10", VA = "0x18A5F3F10")]
		public static SceneTemplate Create(Scene srcScene, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1120590", Offset = "0x111F190", VA = "0x181120590")]
		private SceneTemplate(string name, object extras, ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3E60", Offset = "0xA5F2A60", VA = "0x18A5F3E60")]
		public SceneInstance CreateInstance()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class VertexNormalsFactory
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public interface IMeshPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			int VertexCount
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Vector3 GetVertexPosition(int idx);

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetVertexNormal(int idx, Vector3 normal);

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			IEnumerable<(int, int, int)> GetTriangleIndices();
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x40DA500", Offset = "0x40D9100", VA = "0x1840DA500")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6A90", Offset = "0xA5F5690", VA = "0x18A5F6A90")]
		private static void _AddDirection(Dictionary<Vector3, Vector3> dict, Vector3 pos, Vector3 dir)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class VertexTangentsFactory
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public interface IMeshPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			int VertexCount
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Vector3 GetVertexPosition(int idx);

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Vector3 GetVertexNormal(int idx);

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Vector2 GetVertexTexCoord(int idx);

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void SetVertexTangent(int idx, Vector4 tangent);

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(Slot = "5")]
			IEnumerable<(int, int, int)> GetTriangleIndices();
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x40ED120", Offset = "0x40EBD20", VA = "0x1840ED120")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6C50", Offset = "0xA5F5850", VA = "0x18A5F6C50")]
		private static void _AddTangent(Dictionary<(Vector3, Vector3, Vector2), (Vector3, Vector3)> dict, (Vector3, Vector3, Vector2) key, (Vector3 tu, Vector3 tv) alpha)
		{
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

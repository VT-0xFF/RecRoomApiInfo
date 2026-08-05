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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52FE20", Offset = "0xA52E820", VA = "0x18A52FE20")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA52EDF0", Offset = "0xA52D7F0", VA = "0x18A52EDF0")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA52F060", Offset = "0xA52DA60", VA = "0x18A52F060")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA52F2B0", Offset = "0xA52DCB0", VA = "0x18A52F2B0")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA52ED50", Offset = "0xA52D750", VA = "0x18A52ED50")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA52FAA0", Offset = "0xA52E4A0", VA = "0x18A52FAA0")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA52F980", Offset = "0xA52E380", VA = "0x18A52F980")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA52FF70", Offset = "0xA52E970", VA = "0x18A52FF70")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA52FF10", Offset = "0xA52E910", VA = "0x18A52FF10")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA52F7C0", Offset = "0xA52E1C0", VA = "0x18A52F7C0")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9980", Offset = "0x3AE8380", VA = "0x183AE9980")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE83D0", Offset = "0x3AE6DD0", VA = "0x183AE83D0")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA52F820", Offset = "0xA52E220", VA = "0x18A52F820")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9410", Offset = "0x3AE7E10", VA = "0x183AE9410")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9320", Offset = "0x3AE7D20", VA = "0x183AE9320")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8B80", Offset = "0x3AE7580", VA = "0x183AE8B80")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8980", Offset = "0x3AE7380", VA = "0x183AE8980")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7620", Offset = "0x3AE6020", VA = "0x183AE7620")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA52F3B0", Offset = "0xA52DDB0", VA = "0x18A52F3B0")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA52F350", Offset = "0xA52DD50", VA = "0x18A52F350")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA52F410", Offset = "0xA52DE10", VA = "0x18A52F410")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA52FBC0", Offset = "0xA52E5C0", VA = "0x18A52FBC0")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA52FD20", Offset = "0xA52E720", VA = "0x18A52FD20")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6CD0", Offset = "0x3AE56D0", VA = "0x183AE6CD0")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA52EAC0", Offset = "0xA52D4C0", VA = "0x18A52EAC0")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6310", Offset = "0x3AE4D10", VA = "0x183AE6310")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5F60", Offset = "0x3AE4960", VA = "0x183AE5F60")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5F60", Offset = "0x3AE4960", VA = "0x183AE5F60")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5F60", Offset = "0x3AE4960", VA = "0x183AE5F60")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5F60", Offset = "0x3AE4960", VA = "0x183AE5F60")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE53E0", Offset = "0x3AE3DE0", VA = "0x183AE53E0")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x667FDC0", Offset = "0x667E7C0", VA = "0x18667FDC0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x667ACF0", Offset = "0x66796F0", VA = "0x18667ACF0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x6680220", Offset = "0x667EC20", VA = "0x186680220")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6E44C00", Offset = "0x6E43600", VA = "0x186E44C00", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6E40660", Offset = "0x6E3F060", VA = "0x186E40660", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x6E450D0", Offset = "0x6E43AD0", VA = "0x186E450D0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x5159450", Offset = "0x5157E50", VA = "0x185159450", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x5159220", Offset = "0x5157C20", VA = "0x185159220", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC000", VA = "0x1810DD600")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5158ED0", Offset = "0x51578D0", VA = "0x185158ED0", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5159170", Offset = "0x5157B70", VA = "0x185159170", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x667A1F0", Offset = "0x6678BF0", VA = "0x18667A1F0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x667A2A0", Offset = "0x6678CA0", VA = "0x18667A2A0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x51165A0", Offset = "0x5114FA0", VA = "0x1851165A0")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x667A430", Offset = "0x6678E30", VA = "0x18667A430", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x6678850", Offset = "0x6677250", VA = "0x186678850", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x667AB00", Offset = "0x6679500", VA = "0x18667AB00")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6E3B840", Offset = "0x6E3A240", VA = "0x186E3B840", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6E3AC50", Offset = "0x6E39650", VA = "0x186E3AC50", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6E3BDA0", Offset = "0x6E3A7A0", VA = "0x186E3BDA0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x5150380", Offset = "0x514ED80", VA = "0x185150380", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC000", VA = "0x1810DD600")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x51500E0", Offset = "0x514EAE0", VA = "0x1851500E0", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x51502B0", Offset = "0x514ECB0", VA = "0x1851502B0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x13F8890", Offset = "0x13F7290", VA = "0x1813F8890", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA53E160", Offset = "0xA53CB60", VA = "0x18A53E160", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x64DB960", Offset = "0x64DA360", VA = "0x1864DB960")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA53E1B0", Offset = "0xA53CBB0", VA = "0x18A53E1B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA53DE10", Offset = "0xA53C810", VA = "0x18A53DE10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA53E270", Offset = "0xA53CC70", VA = "0x18A53E270")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA53E120", Offset = "0xA53CB20", VA = "0x18A53E120", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA53E070", Offset = "0xA53CA70", VA = "0x18A53E070", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA53E070", Offset = "0xA53CA70", VA = "0x18A53E070", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x19FCE80", Offset = "0x19FB880", VA = "0x1819FCE80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA53EC50", Offset = "0xA53D650", VA = "0x18A53EC50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA53ECA0", Offset = "0xA53D6A0", VA = "0x18A53ECA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA53E2C0", Offset = "0xA53CCC0", VA = "0x18A53E2C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA53EE90", Offset = "0xA53D890", VA = "0x18A53EE90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA53EEE0", Offset = "0xA53D8E0", VA = "0x18A53EEE0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA53EF30", Offset = "0xA53D930", VA = "0x18A53EF30")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA53EC10", Offset = "0xA53D610", VA = "0x18A53EC10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA53EB60", Offset = "0xA53D560", VA = "0x18A53EB60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA53EB60", Offset = "0xA53D560", VA = "0x18A53EB60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA542DF0", Offset = "0xA5417F0", VA = "0x18A542DF0")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA5447C0", Offset = "0xA5431C0", VA = "0x18A5447C0")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA5448F0", Offset = "0xA5432F0", VA = "0x18A5448F0")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA544800", Offset = "0xA543200", VA = "0x18A544800")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA544920", Offset = "0xA543320", VA = "0x18A544920")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA544860", Offset = "0xA543260", VA = "0x18A544860")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA544990", Offset = "0xA543390", VA = "0x18A544990")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA544860", Offset = "0xA543260", VA = "0x18A544860")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA5446F0", Offset = "0xA5430F0", VA = "0x18A5446F0")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA542F20", Offset = "0xA541920", VA = "0x18A542F20")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA542E00", Offset = "0xA541800", VA = "0x18A542E00")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA542190", Offset = "0xA540B90", VA = "0x18A542190")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA543890", Offset = "0xA542290", VA = "0x18A543890")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA542DA0", Offset = "0xA5417A0", VA = "0x18A542DA0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA542D40", Offset = "0xA541740", VA = "0x18A542D40")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA543020", Offset = "0xA541A20", VA = "0x18A543020")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA544370", Offset = "0xA542D70", VA = "0x18A544370")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA5444F0", Offset = "0xA542EF0", VA = "0x18A5444F0")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA543200", Offset = "0xA541C00", VA = "0x18A543200")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA543110", Offset = "0xA541B10", VA = "0x18A543110")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA5434D0", Offset = "0xA541ED0", VA = "0x18A5434D0")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA542BB0", Offset = "0xA5415B0", VA = "0x18A542BB0")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA533EE0", Offset = "0xA5328E0", VA = "0x18A533EE0")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA5438F0", Offset = "0xA5422F0", VA = "0x18A5438F0")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA543190", Offset = "0xA541B90", VA = "0x18A543190")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA542B10", Offset = "0xA541510", VA = "0x18A542B10")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA542A50", Offset = "0xA541450", VA = "0x18A542A50")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41406A0", Offset = "0x413F0A0", VA = "0x1841406A0")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA542300", Offset = "0xA540D00", VA = "0x18A542300")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA542470", Offset = "0xA540E70", VA = "0x18A542470")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4141A40", Offset = "0x4140440", VA = "0x184141A40")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4142B60", Offset = "0x4141560", VA = "0x184142B60")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4142C90", Offset = "0x4141690", VA = "0x184142C90")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4142BE0", Offset = "0x41415E0", VA = "0x184142BE0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x41406C0", Offset = "0x413F0C0", VA = "0x1841406C0")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4141880", Offset = "0x4140280", VA = "0x184141880")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4141770", Offset = "0x4140170", VA = "0x184141770")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4141540", Offset = "0x413FF40", VA = "0x184141540")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4142A80", Offset = "0x4141480", VA = "0x184142A80")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x41423F0", Offset = "0x4140DF0", VA = "0x1841423F0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4142990", Offset = "0x4141390", VA = "0x184142990")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4142590", Offset = "0x4140F90", VA = "0x184142590")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4140D60", Offset = "0x413F760", VA = "0x184140D60")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4140B10", Offset = "0x413F510", VA = "0x184140B10")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4140320", Offset = "0x413ED20", VA = "0x184140320")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4140750", Offset = "0x413F150", VA = "0x184140750")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA5432D0", Offset = "0xA541CD0", VA = "0x18A5432D0")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA543630", Offset = "0xA542030", VA = "0x18A543630")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4142AE0", Offset = "0x41414E0", VA = "0x184142AE0")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4142AE0", Offset = "0x41414E0", VA = "0x184142AE0")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA543A80", Offset = "0xA542480", VA = "0x18A543A80")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA5421D0", Offset = "0xA540BD0", VA = "0x18A5421D0")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA542250", Offset = "0xA540C50", VA = "0x18A542250")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA543A00", Offset = "0xA542400", VA = "0x18A543A00")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA544140", Offset = "0xA542B40", VA = "0x18A544140")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA5423B0", Offset = "0xA540DB0", VA = "0x18A5423B0")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA544070", Offset = "0xA542A70", VA = "0x18A544070")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA543C80", Offset = "0xA542680", VA = "0x18A543C80")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA5427A0", Offset = "0xA5411A0", VA = "0x18A5427A0")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA542570", Offset = "0xA540F70", VA = "0x18A542570")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA542840", Offset = "0xA541240", VA = "0x18A542840")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA5424F0", Offset = "0xA540EF0", VA = "0x18A5424F0")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA5429D0", Offset = "0xA5413D0", VA = "0x18A5429D0")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x23810A0", Offset = "0x237FAA0", VA = "0x1823810A0")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA5447E0", Offset = "0xA5431E0", VA = "0x18A5447E0")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4142EE0", Offset = "0x41418E0", VA = "0x184142EE0")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA543940", Offset = "0xA542340", VA = "0x18A543940")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA542700", Offset = "0xA541100", VA = "0x18A542700")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA5442C0", Offset = "0xA542CC0", VA = "0x18A5442C0")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA544C30", Offset = "0xA543630", VA = "0x18A544C30")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA5441C0", Offset = "0xA542BC0", VA = "0x18A5441C0")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA5423A0", Offset = "0xA540DA0", VA = "0x18A5423A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF7E00", Offset = "0xCF6800", VA = "0x180CF7E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF7690", Offset = "0xCF6090", VA = "0x180CF7690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string Message
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA535920", Offset = "0xA534320", VA = "0x18A535920", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private string _Generator
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA535970", Offset = "0xA534370", VA = "0x18A535970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA535890", Offset = "0xA534290", VA = "0x18A535890")]
		internal ModelException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA5357E0", Offset = "0xA5341E0", VA = "0x18A5357E0")]
		internal ModelException(JsonSerializable target, Exception ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA535440", Offset = "0xA533E40", VA = "0x18A535440")]
		private static string _CreateBaseMessage(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA5355E0", Offset = "0xA533FE0", VA = "0x18A5355E0")]
		internal static void _Decorate(Exception ex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SchemaException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA52EAB0", Offset = "0xA52D4B0", VA = "0x18A52EAB0")]
		internal SchemaException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5357E0", Offset = "0xA5341E0", VA = "0x18A5357E0")]
		internal SchemaException(JsonSerializable target, JsonException rex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class SemanticException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA52EAB0", Offset = "0xA52D4B0", VA = "0x18A52EAB0")]
		internal SemanticException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class LinkException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA52EAB0", Offset = "0xA52D4B0", VA = "0x18A52EAB0")]
		internal LinkException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DataException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA52EAB0", Offset = "0xA52D4B0", VA = "0x18A52EAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6A90", VA = "0x180EC8090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool TryFix
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA541690", Offset = "0xA540090", VA = "0x18A541690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5415B0", Offset = "0xA53FFB0", VA = "0x18A5415B0")]
		public ValidationContext(ValidationResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA541560", Offset = "0xA53FF60", VA = "0x18A541560")]
		internal ValidationContext(ValidationContext context, JsonSerializable target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA540380", Offset = "0xA53ED80", VA = "0x18A540380")]
		public ValidationContext GetContext(JsonSerializable target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5414C0", Offset = "0xA53FEC0", VA = "0x18A5414C0")]
		[DebuggerStepThrough]
		internal void _SchemaThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA540DF0", Offset = "0xA53F7F0", VA = "0x18A540DF0")]
		public ValidationContext IsTrue(ValueLocation parameterName, bool value, string msg)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA541130", Offset = "0xA53FB30", VA = "0x18A541130")]
		public ValidationContext NotNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA541010", Offset = "0xA53FA10", VA = "0x18A541010")]
		public ValidationContext MustBeNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x40CEAF0", Offset = "0x40CD4F0", VA = "0x1840CEAF0")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x40CEA50", Offset = "0x40CD450", VA = "0x1840CEA50")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x40D0B90", Offset = "0x40CF590", VA = "0x1840D0B90")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x40D0A40", Offset = "0x40CF440", VA = "0x1840D0A40")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x40CD8B0", Offset = "0x40CC2B0", VA = "0x1840CD8B0")]
		public ValidationContext AreSameReference<TRef>(ValueLocation parameterName, TRef value, TRef expected) where TRef : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x40CD7B0", Offset = "0x40CC1B0", VA = "0x1840CD7B0")]
		public ValidationContext AreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : IEquatable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x40CFF70", Offset = "0x40CE970", VA = "0x1840CFF70")]
		public ValidationContext IsLess<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x40CFC00", Offset = "0x40CE600", VA = "0x1840CFC00")]
		public ValidationContext IsLessOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x40CF2B0", Offset = "0x40CDCB0", VA = "0x1840CF2B0")]
		public ValidationContext IsGreater<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x40CE160", Offset = "0x40CCB60", VA = "0x1840CE160")]
		public ValidationContext IsDefaultOrWithin<TValue>(ValueLocation parameterName, TValue? value, TValue minInclusive, TValue maxInclusive) where TValue : struct, IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x40CEDF0", Offset = "0x40CD7F0", VA = "0x1840CEDF0")]
		public ValidationContext IsGreaterOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5407E0", Offset = "0xA53F1E0", VA = "0x18A5407E0")]
		public ValidationContext IsMultipleOf(ValueLocation parameterName, int value, int multiple)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5410A0", Offset = "0xA53FAA0", VA = "0x18A5410A0")]
		public ValidationContext NonNegative(ValueLocation parameterName, int? value)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA540BE0", Offset = "0xA53F5E0", VA = "0x18A540BE0")]
		public ValidationContext IsNullOrValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA540E40", Offset = "0xA53F840", VA = "0x18A540E40")]
		public ValidationContext IsValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA541420", Offset = "0xA53FE20", VA = "0x18A541420")]
		[DebuggerStepThrough]
		internal void _LinkThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x40CDB40", Offset = "0x40CC540", VA = "0x1840CDB40")]
		public ValidationContext EnumsAreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : Enum
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x40D0500", Offset = "0x40CEF00", VA = "0x1840D0500")]
		public ValidationContext IsNullOrIndex<T>(ValueLocation parameterName, int? index, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x40D0090", Offset = "0x40CEA90", VA = "0x1840D0090")]
		public ValidationContext IsNullOrInRange<T>(ValueLocation parameterName, int? offset, int length, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x40CDF60", Offset = "0x40CC960", VA = "0x1840CDF60")]
		public ValidationContext IsAnyOf<T>(ValueLocation parameterName, T value, params T[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5403E0", Offset = "0xA53EDE0", VA = "0x18A5403E0")]
		public ValidationContext IsAnyOf(ValueLocation parameterName, AttributeFormat value, params AttributeFormat[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x40D05B0", Offset = "0x40CEFB0", VA = "0x1840D05B0")]
		public ValidationContext IsSetCollection<T>(ValueLocation parameterName, IEnumerable<T> collection) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA541380", Offset = "0xA53FD80", VA = "0x18A541380")]
		[DebuggerStepThrough]
		private void _DataThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x40CF800", Offset = "0x40CE200", VA = "0x1840CF800")]
		public ValidationContext IsInRange<T>(ValueLocation pname, T value, T minInclusive, T maxInclusive) where T : IComparable<T>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA540AA0", Offset = "0xA53F4A0", VA = "0x18A540AA0")]
		public ValidationContext IsNullOrMatrix(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA540960", Offset = "0xA53F360", VA = "0x18A540960")]
		public ValidationContext IsNullOrMatrix4x3(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA540C50", Offset = "0xA53F650", VA = "0x18A540C50")]
		public ValidationContext IsPosition(ValueLocation pname, [In] Vector3 position)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA5408B0", Offset = "0xA53F2B0", VA = "0x18A5408B0")]
		public ValidationContext IsNormal(ValueLocation pname, [In] Vector3 normal)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA540D50", Offset = "0xA53F750", VA = "0x18A540D50")]
		public ValidationContext IsRotation(ValueLocation pname, [In] Quaternion rotation)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA540730", Offset = "0xA53F130", VA = "0x18A540730")]
		public ValidationContext IsMatrix(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA540680", Offset = "0xA53F080", VA = "0x18A540680")]
		public ValidationContext IsMatrix4x3(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA53FA80", Offset = "0xA53E480", VA = "0x18A53FA80")]
		public ValidationContext ArePositions(ValueLocation pname, IReadOnlyList<Vector3> positions)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA53F710", Offset = "0xA53E110", VA = "0x18A53F710")]
		public ValidationContext AreNormals(ValueLocation pname, IReadOnlyList<Vector3> normals)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA5400A0", Offset = "0xA53EAA0", VA = "0x18A5400A0")]
		public ValidationContext AreTangents(ValueLocation pname, IReadOnlyList<Vector4> tangents)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA53FE50", Offset = "0xA53E850", VA = "0x18A53FE50")]
		public ValidationContext AreRotations(ValueLocation pname, IReadOnlyList<Quaternion> rotations)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA53F200", Offset = "0xA53DC00", VA = "0x18A53F200")]
		public ValidationContext AreJoints(ValueLocation pname, IReadOnlyList<Vector4> joints, int skinsMaxJointCount)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5411C0", Offset = "0xA53FBC0", VA = "0x18A5411C0")]
		public ValidationContext That(Action action)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA541320", Offset = "0xA53FD20", VA = "0x18A541320")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5420F0", Offset = "0xA540AF0", VA = "0x18A5420F0")]
		public static implicit operator ValueLocation(int index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA542090", Offset = "0xA540A90", VA = "0x18A542090")]
		public static implicit operator ValueLocation(int? index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B76D20", Offset = "0x2B75720", VA = "0x182B76D20")]
		public static implicit operator ValueLocation(string name)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA542140", Offset = "0xA540B40", VA = "0x18A542140")]
		public static implicit operator ValueLocation((string name, int index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA542030", Offset = "0xA540A30", VA = "0x18A542030")]
		public static implicit operator ValueLocation((string name, int? index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA542180", Offset = "0xA540B80", VA = "0x18A542180")]
		public static implicit operator string(ValueLocation location)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xDA7AE0", Offset = "0xDA64E0", VA = "0x180DA7AE0")]
		private ValueLocation(string name, int idx1 = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA541FB0", Offset = "0xA5409B0", VA = "0x18A541FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA541F40", Offset = "0xA540940", VA = "0x18A541F40")]
		public string ToString(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA541E10", Offset = "0xA540810", VA = "0x18A541E10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ValidationMode Mode
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0")]
			get
			{
				return default(ValidationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IEnumerable<Exception> Errors
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool HasErrors
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xA541DC0", Offset = "0xA5407C0", VA = "0x18A541DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA541D00", Offset = "0xA540700", VA = "0x18A541D00")]
		public ValidationResult(ModelRoot root, ValidationMode mode, bool instantThrow = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA5416A0", Offset = "0xA5400A0", VA = "0x18A5416A0")]
		public ValidationContext GetContext()
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA541C00", Offset = "0xA540600", VA = "0x18A541C00")]
		public void SetSchemaError(EndOfStreamException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA541B80", Offset = "0xA540580", VA = "0x18A541B80")]
		public void SetSchemaError(ModelRoot model, string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA541A80", Offset = "0xA540480", VA = "0x18A541A80")]
		public void SetSchemaError(ModelRoot model, JsonException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA541960", Offset = "0xA540360", VA = "0x18A541960")]
		public void SetModelError(FormatException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA541860", Offset = "0xA540260", VA = "0x18A541860")]
		public void SetModelError(ModelRoot model, ArgumentException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA541790", Offset = "0xA540190", VA = "0x18A541790")]
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
			[Cpp2IlInjected.Address(RVA = "0xA52E320", Offset = "0xA52CD20", VA = "0x18A52E320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA52E300", Offset = "0xA52CD00", VA = "0x18A52E300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IsSRT
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA52E310", Offset = "0xA52CD10", VA = "0x18A52E310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA52E660", Offset = "0xA52D060", VA = "0x18A52E660")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Quaternion Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA52E5F0", Offset = "0xA52CFF0", VA = "0x18A52E5F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xECAF90", Offset = "0xEC9990", VA = "0x180ECAF90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA52E570", Offset = "0xA52CF70", VA = "0x18A52E570")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IsLosslessDecomposable
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA52E1F0", Offset = "0xA52CBF0", VA = "0x18A52E1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IsIdentity
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA52DF50", Offset = "0xA52C950", VA = "0x18A52DF50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA52A990", Offset = "0xA529390", VA = "0x18A52A990")]
		internal string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA52E780", Offset = "0xA52D180", VA = "0x18A52E780")]
		public static implicit operator AffineTransform((Quaternion r, Vector3 t) xform)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA52E910", Offset = "0xA52D310", VA = "0x18A52E910")]
		public static implicit operator AffineTransform(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA52E8D0", Offset = "0xA52D2D0", VA = "0x18A52E8D0")]
		public static implicit operator AffineTransform(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA529A20", Offset = "0xA528420", VA = "0x18A529A20")]
		public static AffineTransform CreateDecomposed(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA529B90", Offset = "0xA528590", VA = "0x18A529B90")]
		public static AffineTransform CreateFromAny(Matrix4x4? matrix, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA52C900", Offset = "0xA52B300", VA = "0x18A52C900")]
		public AffineTransform WithScale(Vector3 scale)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA52C580", Offset = "0xA52AF80", VA = "0x18A52C580")]
		public AffineTransform WithRotation(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA52CCB0", Offset = "0xA52B6B0", VA = "0x18A52CCB0")]
		public AffineTransform WithTranslation(Vector3 translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA52D760", Offset = "0xA52C160", VA = "0x18A52D760")]
		public AffineTransform(Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA52DAA0", Offset = "0xA52C4A0", VA = "0x18A52DAA0")]
		public AffineTransform(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA52D690", Offset = "0xA52C090", VA = "0x18A52D690")]
		public AffineTransform(Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA52DB80", Offset = "0xA52C580", VA = "0x18A52DB80")]
		public AffineTransform(Vector3 scale, Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA52D8F0", Offset = "0xA52C2F0", VA = "0x18A52D8F0")]
		public AffineTransform(Matrix4x4 matrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA52A1E0", Offset = "0xA528BE0", VA = "0x18A52A1E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA529E80", Offset = "0xA528880", VA = "0x18A529E80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA529F90", Offset = "0xA528990", VA = "0x18A529F90", Slot = "4")]
		public bool Equals(AffineTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA52E6D0", Offset = "0xA52D0D0", VA = "0x18A52E6D0")]
		public static bool operator ==([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA52E970", Offset = "0xA52D370", VA = "0x18A52E970")]
		public static bool operator !=([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA529200", Offset = "0xA527C00", VA = "0x18A529200")]
		public static bool AreGeometricallyEquivalent([In] AffineTransform a, [In] AffineTransform b, float tolerance = 1E-05f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA52A120", Offset = "0xA528B20", VA = "0x18A52A120")]
		public AffineTransform GetDecomposed()
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA52B900", Offset = "0xA52A300", VA = "0x18A52B900")]
		public bool TryDecompose([Out] AffineTransform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA52B6C0", Offset = "0xA52A0C0", VA = "0x18A52B6C0")]
		public bool TryDecompose([Out] Vector3 scale, [Out] Quaternion rotation, [Out] Vector3 translation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA529490", Offset = "0xA527E90", VA = "0x18A529490")]
		public static AffineTransform Blend(ReadOnlySpan<AffineTransform> transforms, ReadOnlySpan<float> weights)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA52EA20", Offset = "0xA52D420", VA = "0x18A52EA20")]
		public static AffineTransform operator *([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA52A210", Offset = "0xA528C10", VA = "0x18A52A210")]
		public static AffineTransform Multiply([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA52BC50", Offset = "0xA52A650", VA = "0x18A52BC50")]
		public static bool TryInvert([In] AffineTransform xform, [Out] AffineTransform inverse)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA52B2A0", Offset = "0xA529CA0", VA = "0x18A52B2A0")]
		private static Vector3 Transform(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA52AEC0", Offset = "0xA5298C0", VA = "0x18A52AEC0")]
		public static Vector3 TransformNormal(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA52D570", Offset = "0xA52BF70", VA = "0x18A52D570")]
		private void _VerifyDefined()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA52D020", Offset = "0xA52BA20", VA = "0x18A52D020")]
		private Matrix4x4 _GetMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA52D4A0", Offset = "0xA52BEA0", VA = "0x18A52D4A0")]
		private Vector3 _GetScale()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA52D3D0", Offset = "0xA52BDD0", VA = "0x18A52D3D0")]
		private Quaternion _GetRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA528D10", Offset = "0xA527710", VA = "0x18A528D10")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5315D0", Offset = "0xA52FFD0", VA = "0x18A5315D0")]
		public static implicit operator IndexWeight((int Index, float Weight) pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA531580", Offset = "0xA52FF80", VA = "0x18A531580")]
		public static implicit operator IndexWeight(KeyValuePair<int, float> pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA5314B0", Offset = "0xA52FEB0", VA = "0x18A5314B0")]
		public IndexWeight((int Index, float Weight) pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA531440", Offset = "0xA52FE40", VA = "0x18A531440")]
		public IndexWeight(KeyValuePair<int, float> pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x68590F0", Offset = "0x6857AF0", VA = "0x1868590F0")]
		public IndexWeight(int i, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA530890", Offset = "0xA52F290", VA = "0x18A530890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA5307D0", Offset = "0xA52F1D0", VA = "0x18A5307D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA530870", Offset = "0xA52F270", VA = "0x18A530870", Slot = "4")]
		public bool Equals(IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA531260", Offset = "0xA52FC60", VA = "0x18A531260")]
		public bool IsGreaterThan([In] IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA5314F0", Offset = "0xA52FEF0", VA = "0x18A5314F0")]
		public static IndexWeight operator +(IndexWeight a, IndexWeight b)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA5314D0", Offset = "0xA52FED0", VA = "0x18A5314D0")]
		public static IndexWeight operator +(IndexWeight a, float w)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA531300", Offset = "0xA52FD00", VA = "0x18A531300")]
		public static bool IsWellFormed(ReadOnlySpan<IndexWeight> iw, [Out] string err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA5308E0", Offset = "0xA52F2E0", VA = "0x18A5308E0")]
		public static int InsertSorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA530DB0", Offset = "0xA52F7B0", VA = "0x18A530DB0")]
		public static int InsertUnsorted(Span<IndexWeight> sparse, [In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA530BB0", Offset = "0xA52F5B0", VA = "0x18A530BB0")]
		public static int InsertUnsorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA530390", Offset = "0xA52ED90", VA = "0x18A530390")]
		public static int CopyTo([In] SparseWeight8 src, Span<int> dstIndices, Span<float> dstWeights, int dstLength)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA5301F0", Offset = "0xA52EBF0", VA = "0x18A5301F0")]
		public static void BubbleSortByWeight(Span<IndexWeight> pairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA530110", Offset = "0xA52EB10", VA = "0x18A530110")]
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
			[Cpp2IlInjected.Address(RVA = "0xA533070", Offset = "0xA531A70", VA = "0x18A533070")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public (double x, double y, double z) Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA533110", Offset = "0xA531B10", VA = "0x18A533110")]
			get
			{
				return default((double, double, double));
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA533AC0", Offset = "0xA5324C0", VA = "0x18A533AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA532FC0", Offset = "0xA5319C0", VA = "0x18A532FC0")]
		public Matrix4x4Double(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA532F00", Offset = "0xA531900", VA = "0x18A532F00")]
		public Matrix4x4Double(Matrix4x4 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA531ED0", Offset = "0xA5308D0", VA = "0x18A531ED0")]
		public static Matrix4x4Double CreateTranslation(double xPosition, double yPosition, double zPosition)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA531E70", Offset = "0xA530870", VA = "0x18A531E70")]
		public static Matrix4x4Double CreateScale(double xScale, double yScale, double zScale)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA531CE0", Offset = "0xA5306E0", VA = "0x18A531CE0")]
		public static Matrix4x4Double CreateFromQuaternion(Quaternion quaternion)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA5332D0", Offset = "0xA531CD0", VA = "0x18A5332D0")]
		public static explicit operator Matrix4x4(Matrix4x4Double mat)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA533480", Offset = "0xA531E80", VA = "0x18A533480")]
		public static implicit operator Matrix4x4Double(Matrix4x4 mat)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA532400", Offset = "0xA530E00", VA = "0x18A532400", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA533180", Offset = "0xA531B80", VA = "0x18A533180")]
		public static bool operator ==(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA533560", Offset = "0xA531F60", VA = "0x18A533560")]
		public static bool operator !=(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA532270", Offset = "0xA530C70", VA = "0x18A532270", Slot = "4")]
		public readonly bool Equals(Matrix4x4Double other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA531F30", Offset = "0xA530930", VA = "0x18A531F30", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA532660", Offset = "0xA531060", VA = "0x18A532660")]
		public static bool Invert(Matrix4x4Double matrix, [Out] Matrix4x4Double result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA532D20", Offset = "0xA531720", VA = "0x18A532D20")]
		public static Matrix4x4Double Multiply(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA5336B0", Offset = "0xA5320B0", VA = "0x18A5336B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA535030", Offset = "0xA533A30", VA = "0x18A535030")]
		private static MatrixCheck _Validate([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(MatrixCheck);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA533EE0", Offset = "0xA5328E0", VA = "0x18A533EE0")]
		public static bool IsValid([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA533E20", Offset = "0xA532820", VA = "0x18A533E20")]
		[DebuggerStepThrough]
		public static void GuardMatrix(string argName, Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA533BC0", Offset = "0xA5325C0", VA = "0x18A533BC0")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA533AE0", Offset = "0xA5324E0", VA = "0x18A533AE0")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ, Vector3 translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA533C80", Offset = "0xA532680", VA = "0x18A533C80")]
		public static Matrix4x4 CreateFrom(Matrix4x4? transform, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA533F00", Offset = "0xA532900", VA = "0x18A533F00")]
		public static Matrix4x4 LocalToWorld([In] Matrix4x4 parentWorld, [In] Matrix4x4 childLocal)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA534CF0", Offset = "0xA5336F0", VA = "0x18A534CF0")]
		public static Matrix4x4 WorldToLocal([In] Matrix4x4 parentWorld, [In] Matrix4x4 childWorld)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA534230", Offset = "0xA532C30", VA = "0x18A534230")]
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
			[Cpp2IlInjected.Address(RVA = "0x5164BF0", Offset = "0x51635F0", VA = "0x185164BF0")]
			get
			{
				return default(SparseWeight8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool AbsoluteMorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD94370", Offset = "0xD92D70", VA = "0x180D94370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA536A60", Offset = "0xA535460", VA = "0x18A536A60")]
		protected MorphTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA536AA0", Offset = "0xA5354A0", VA = "0x18A536AA0")]
		protected MorphTransform(SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA536950", Offset = "0xA535350", VA = "0x18A536950")]
		public void Update([In] SparseWeight8 morphWeights, bool useAbsoluteMorphTargets = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA536010", Offset = "0xA534A10", VA = "0x18A536010")]
		protected Vector2 MorphVectors(Vector2 value, IReadOnlyList<Vector2> morphTargets)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA535A80", Offset = "0xA534480", VA = "0x18A535A80")]
		protected Vector3 MorphVectors(Vector3 value, IReadOnlyList<Vector3> morphTargets)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA5363E0", Offset = "0xA534DE0", VA = "0x18A5363E0")]
		protected Vector4 MorphVectors(Vector4 value, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA535A30", Offset = "0xA534430", VA = "0x18A535A30", Slot = "5")]
		public Vector4 MorphColors(Vector4 color, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA535A70", Offset = "0xA534470", VA = "0x18A535A70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1EC10", Offset = "0xD1D610", VA = "0x180D1EC10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x20B12E0", Offset = "0x20AFCE0", VA = "0x1820B12E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA537C60", Offset = "0xA536660", VA = "0x18A537C60")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA537B70", Offset = "0xA536570", VA = "0x18A537B70")]
		public RigidTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA537AC0", Offset = "0xA5364C0", VA = "0x18A537AC0")]
		public RigidTransform(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA537A10", Offset = "0xA536410", VA = "0x18A537A10")]
		public RigidTransform(Matrix4x4 worldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA537860", Offset = "0xA536260", VA = "0x18A537860")]
		public void Update(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA5374C0", Offset = "0xA535EC0", VA = "0x18A5374C0")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA537330", Offset = "0xA535D30", VA = "0x18A537330")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA537660", Offset = "0xA536060", VA = "0x18A537660")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA537130", Offset = "0xA535B30", VA = "0x18A537130", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA536FA0", Offset = "0xA5359A0", VA = "0x18A536FA0", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA5372E0", Offset = "0xA535CE0", VA = "0x18A5372E0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public IReadOnlyList<Matrix4x4> SkinMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECB50", VA = "0x180CEE150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA536A60", Offset = "0xA535460", VA = "0x18A536A60")]
		public SkinnedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA539960", Offset = "0xA538360", VA = "0x18A539960")]
		public SkinnedTransform(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA5399F0", Offset = "0xA5383F0", VA = "0x18A5399F0")]
		public SkinnedTransform(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA5395B0", Offset = "0xA537FB0", VA = "0x18A5395B0")]
		public void Update(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA5392A0", Offset = "0xA537CA0", VA = "0x18A5392A0")]
		public void Update(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA538860", Offset = "0xA537260", VA = "0x18A538860")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA5383C0", Offset = "0xA536DC0", VA = "0x18A5383C0")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA538DD0", Offset = "0xA5377D0", VA = "0x18A538DD0")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA538090", Offset = "0xA536A90", VA = "0x18A538090")]
		public static Matrix4x4 CalculateInverseBinding(Matrix4x4 meshWorldTransform, Matrix4x4 jointWorldTransform)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA537C90", Offset = "0xA536690", VA = "0x18A537C90")]
		public static Matrix4x4Double CalculateInverseBinding(Matrix4x4Double meshWorldTransform, Matrix4x4Double jointWorldTransform)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA538310", Offset = "0xA536D10", VA = "0x18A538310", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA5382B0", Offset = "0xA536CB0", VA = "0x18A5382B0", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA538370", Offset = "0xA536D70", VA = "0x18A538370", Slot = "10")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <Evaluate>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA53DD00", Offset = "0xA53C700", VA = "0x18A53DD00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA53D960", Offset = "0xA53C360", VA = "0x18A53D960", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA53DDC0", Offset = "0xA53C7C0", VA = "0x18A53DDC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA53DCC0", Offset = "0xA53C6C0", VA = "0x18A53DCC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA53DC20", Offset = "0xA53C620", VA = "0x18A53DC20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IGeometryTransform> IEnumerable<IGeometryTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA53DC20", Offset = "0xA53C620", VA = "0x18A53DC20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA531CC0", Offset = "0xA5306C0", VA = "0x18A531CC0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IReadOnlyList<Matrix4x4> LocalMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xDD4470", Offset = "0xDD2E70", VA = "0x180DD4470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public IReadOnlyList<RigidTransform> WorldTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA531670", Offset = "0xA530070", VA = "0x18A531670", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA531A30", Offset = "0xA530430", VA = "0x18A531A30")]
		public InstancingTransform(AffineTransform[] instances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA531930", Offset = "0xA530330", VA = "0x18A531930")]
		private RigidTransform[] _CreateTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA531670", Offset = "0xA530070", VA = "0x18A531670")]
		public RigidTransform[] UpdateInstances()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA5315F0", Offset = "0xA52FFF0", VA = "0x18A5315F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA536AF0", Offset = "0xA5354F0", VA = "0x18A536AF0")]
		public static Matrix4x4 CreateOrthographicMatrix(float xmag, float ymag, float znear, float zfar)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA536CF0", Offset = "0xA5356F0", VA = "0x18A536CF0")]
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
				[Cpp2IlInjected.Address(RVA = "0xEBBD20", Offset = "0xEBA720", VA = "0x180EBBD20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2081E60", Offset = "0x2080860", VA = "0x182081E60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x15B7650", Offset = "0x15B6050", VA = "0x1815B7650")]
			[DebuggerHidden]
			public <Expand>d__51(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xA551E80", Offset = "0xA550880", VA = "0x18A551E80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA551FB0", Offset = "0xA5509B0", VA = "0x18A551FB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA551EF0", Offset = "0xA5508F0", VA = "0x18A551EF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<float> IEnumerable<float>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA551EF0", Offset = "0xA5508F0", VA = "0x18A551EF0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x13F8890", Offset = "0x13F7290", VA = "0x1813F8890", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA555000", Offset = "0xA553A00", VA = "0x18A555000", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x64DB960", Offset = "0x64DA360", VA = "0x1864DB960")]
			[DebuggerHidden]
			public <GetIndexedWeights>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA554C60", Offset = "0xA553660", VA = "0x18A554C60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xA554FC0", Offset = "0xA5539C0", VA = "0x18A554FC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xA554F00", Offset = "0xA553900", VA = "0x18A554F00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xA554F00", Offset = "0xA553900", VA = "0x18A554F00", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x13F8890", Offset = "0x13F7290", VA = "0x1813F8890", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA555440", Offset = "0xA553E40", VA = "0x18A555440", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x64DB960", Offset = "0x64DA360", VA = "0x1864DB960")]
			[DebuggerHidden]
			public <GetNonZeroWeights>d__53(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA555050", Offset = "0xA553A50", VA = "0x18A555050", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA555400", Offset = "0xA553E00", VA = "0x18A555400", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA555340", Offset = "0xA553D40", VA = "0x18A555340", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xA555340", Offset = "0xA553D40", VA = "0x18A555340", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x13F8890", Offset = "0x13F7290", VA = "0x1813F8890", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA55C580", Offset = "0xA55AF80", VA = "0x18A55C580", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x64DB960", Offset = "0x64DA360", VA = "0x1864DB960")]
			[DebuggerHidden]
			public <_GetPairs>d__64(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA55C1C0", Offset = "0xA55ABC0", VA = "0x18A55C1C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA55C540", Offset = "0xA55AF40", VA = "0x18A55C540", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xA55C480", Offset = "0xA55AE80", VA = "0x18A55C480", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IndexWeight> IEnumerable<IndexWeight>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xA55C480", Offset = "0xA55AE80", VA = "0x18A55C480", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA53D7B0", Offset = "0xA53C1B0", VA = "0x18A53D7B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA53B210", Offset = "0xA539C10", VA = "0x18A53B210")]
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
			[Cpp2IlInjected.Address(RVA = "0xA53D7C0", Offset = "0xA53C1C0", VA = "0x18A53D7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float WeightSum
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA53D8B0", Offset = "0xA53C2B0", VA = "0x18A53D8B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int MaxIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA53D8A0", Offset = "0xA53C2A0", VA = "0x18A53D8A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA53C9C0", Offset = "0xA53B3C0", VA = "0x18A53C9C0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA53A780", Offset = "0xA539180", VA = "0x18A53A780")]
		public static SparseWeight8 Create(params float[] weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA53AC70", Offset = "0xA539670", VA = "0x18A53AC70")]
		public static SparseWeight8 Create(IEnumerable<float> weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA53A740", Offset = "0xA539140", VA = "0x18A53A740")]
		public static SparseWeight8 Create(params (int Index, float Weight)[] indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA53A7C0", Offset = "0xA5391C0", VA = "0x18A53A7C0")]
		public static SparseWeight8 Create(IEnumerable<(int Index, float Weight)> indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA53AB70", Offset = "0xA539570", VA = "0x18A53AB70")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA53A4E0", Offset = "0xA538EE0", VA = "0x18A53A4E0")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA53A450", Offset = "0xA538E50", VA = "0x18A53A450")]
		public static SparseWeight8 CreateUnchecked([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA53D690", Offset = "0xA53C090", VA = "0x18A53D690")]
		private SparseWeight8([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA53D5D0", Offset = "0xA53BFD0", VA = "0x18A53D5D0")]
		private SparseWeight8(ReadOnlySpan<IndexWeight> iw)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA53D710", Offset = "0xA53C110", VA = "0x18A53D710")]
		private SparseWeight8([In] SparseWeight8 sparse, float scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA53B330", Offset = "0xA539D30", VA = "0x18A53B330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA53B090", Offset = "0xA539A90", VA = "0x18A53B090", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA53B150", Offset = "0xA539B50", VA = "0x18A53B150", Slot = "4")]
		public bool Equals(SparseWeight8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA53D8E0", Offset = "0xA53C2E0", VA = "0x18A53D8E0")]
		public static bool operator ==(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA53D920", Offset = "0xA53C320", VA = "0x18A53D920")]
		public static bool operator !=(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA539BE0", Offset = "0xA5385E0", VA = "0x18A539BE0")]
		internal static bool AreEqual([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA53C3B0", Offset = "0xA53ADB0", VA = "0x18A53C3B0")]
		public static SparseWeight8 OrderedByWeight([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA53C1D0", Offset = "0xA53ABD0", VA = "0x18A53C1D0")]
		public static SparseWeight8 OrderedByIndex([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA539A90", Offset = "0xA538490", VA = "0x18A539A90")]
		public static SparseWeight8 Add([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA53C780", Offset = "0xA53B180", VA = "0x18A53C780")]
		public static SparseWeight8 Subtract([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA53C080", Offset = "0xA53AA80", VA = "0x18A53C080")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA53BFE0", Offset = "0xA53A9E0", VA = "0x18A53BFE0")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, float y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA53BEB0", Offset = "0xA53A8B0", VA = "0x18A53BEB0")]
		public static SparseWeight8 InterpolateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA53BD70", Offset = "0xA53A770", VA = "0x18A53BD70")]
		public static SparseWeight8 InterpolateCubic([In] SparseWeight8 x, [In] SparseWeight8 xt, [In] SparseWeight8 y, [In] SparseWeight8 yt, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA53B170", Offset = "0xA539B70", VA = "0x18A53B170")]
		[IteratorStateMachine(typeof(<Expand>d__51))]
		public IEnumerable<float> Expand(int count)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA53B520", Offset = "0xA539F20", VA = "0x18A53B520")]
		[IteratorStateMachine(typeof(<GetIndexedWeights>d__52))]
		public IEnumerable<(int, float)> GetIndexedWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA53B5B0", Offset = "0xA539FB0", VA = "0x18A53B5B0")]
		[IteratorStateMachine(typeof(<GetNonZeroWeights>d__53))]
		public IEnumerable<(int, float)> GetNonZeroWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA539F60", Offset = "0xA538960", VA = "0x18A539F60")]
		public static SparseWeight8 Blend(ReadOnlySpan<SparseWeight8> sparses, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA53B920", Offset = "0xA53A320", VA = "0x18A53B920")]
		public SparseWeight8 GetTrimmed(int maxWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA53B7D0", Offset = "0xA53A1D0", VA = "0x18A53B7D0")]
		public SparseWeight8 GetNormalized()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA53C8D0", Offset = "0xA53B2D0", VA = "0x18A53C8D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA53D260", Offset = "0xA53BC60", VA = "0x18A53D260")]
		private static SparseWeight8 _OperateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, Func<float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA53CDB0", Offset = "0xA53B7B0", VA = "0x18A53CDB0")]
		private static SparseWeight8 _OperateCubic([In] SparseWeight8 x, [In] SparseWeight8 y, [In] SparseWeight8 z, [In] SparseWeight8 w, Func<float, float, float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA53B210", Offset = "0xA539C10", VA = "0x18A53B210")]
		private float GetExpandedAt(int idx)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA53B270", Offset = "0xA539C70", VA = "0x18A53B270")]
		private int GetExpandedCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA53B640", Offset = "0xA53A040", VA = "0x18A53B640")]
		internal SparseWeight8 GetNormalizedWithComplement(int complementIndex)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA53CB30", Offset = "0xA53B530", VA = "0x18A53CB30")]
		internal int _GetMaxIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA53CD20", Offset = "0xA53B720", VA = "0x18A53CD20")]
		[IteratorStateMachine(typeof(<_GetPairs>d__64))]
		internal IEnumerable<IndexWeight> _GetPairs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA53BA60", Offset = "0xA53A460", VA = "0x18A53BA60")]
		internal int InsertTo(Span<IndexWeight> dst)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA53A1D0", Offset = "0xA538BD0", VA = "0x18A53A1D0")]
		internal void CopyTo(Span<IndexWeight> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA539D60", Offset = "0xA538760", VA = "0x18A539D60")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xA55AB90", Offset = "0xA559590", VA = "0x18A55AB90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xA55A860", Offset = "0xA559260", VA = "0x18A55A860", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA55AC50", Offset = "0xA559650", VA = "0x18A55AC50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xA55AB50", Offset = "0xA559550", VA = "0x18A55AB50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA55AAB0", Offset = "0xA5594B0", VA = "0x18A55AAB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xA55AAB0", Offset = "0xA5594B0", VA = "0x18A55AAB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA55D1F0", Offset = "0xA55BBF0", VA = "0x18A55D1F0")]
		internal XmpPackets(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA55CD00", Offset = "0xA55B700", VA = "0x18A55CD00")]
		public int AddPacket(JsonNode packet)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA55CEF0", Offset = "0xA55B8F0", VA = "0x18A55CEF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA55CF20", Offset = "0xA55B920", VA = "0x18A55CF20", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__6))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA55D050", Offset = "0xA55BA50", VA = "0x18A55D050", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA55CFA0", Offset = "0xA55B9A0", VA = "0x18A55CFA0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA55CE50", Offset = "0xA55B850", VA = "0x18A55CE50", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA5557C0", Offset = "0xA5541C0", VA = "0x18A5557C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA555490", Offset = "0xA553E90", VA = "0x18A555490", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA555880", Offset = "0xA554280", VA = "0x18A555880")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xA555780", Offset = "0xA554180", VA = "0x18A555780", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xA5556E0", Offset = "0xA5540E0", VA = "0x18A5556E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xA5556E0", Offset = "0xA5540E0", VA = "0x18A5556E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0400", VA = "0x180CF1A00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public JsonNode JsonPacket
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xA55CC30", Offset = "0xA55B630", VA = "0x18A55CC30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA55CBF0", Offset = "0xA55B5F0", VA = "0x18A55CBF0")]
		internal XmpPacketReference(ExtraProperties owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA55CAC0", Offset = "0xA55B4C0", VA = "0x18A55CAC0")]
		private ModelRoot _FindRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA55CB40", Offset = "0xA55B540", VA = "0x18A55CB40")]
		private XmpPackets _GetPackets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA55C7B0", Offset = "0xA55B1B0", VA = "0x18A55C7B0")]
		public void SetPacket(int logicalIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA55C670", Offset = "0xA55B070", VA = "0x18A55C670", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA55C6A0", Offset = "0xA55B0A0", VA = "0x18A55C6A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__11))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA55C920", Offset = "0xA55B320", VA = "0x18A55C920", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA55C720", Offset = "0xA55B120", VA = "0x18A55C720", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA55C5D0", Offset = "0xA55AFD0", VA = "0x18A55C5D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA559AD0", Offset = "0xA5584D0", VA = "0x18A559AD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA5569C0", Offset = "0xA5553C0", VA = "0x18A5569C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA55A630", Offset = "0xA559030", VA = "0x18A55A630")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA559250", Offset = "0xA557C50", VA = "0x18A559250", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA558950", Offset = "0xA557350", VA = "0x18A558950", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA558950", Offset = "0xA557350", VA = "0x18A558950", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA545780", Offset = "0xA544180", VA = "0x18A545780", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA5457B0", Offset = "0xA5441B0", VA = "0x18A5457B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA545BE0", Offset = "0xA5445E0", VA = "0x18A545BE0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA545830", Offset = "0xA544230", VA = "0x18A545830", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA5456E0", Offset = "0xA5440E0", VA = "0x18A5456E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA545D90", Offset = "0xA544790", VA = "0x18A545D90")]
		public AnimationPointer(AnimationChannelTarget parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA5459A0", Offset = "0xA5443A0", VA = "0x18A5459A0")]
		public static bool TryParseNodeTransform(string pointerPath, [Out] int nodeIndex, [Out] PropertyPath property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA545890", Offset = "0xA544290", VA = "0x18A545890")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5524F0", Offset = "0xA550EF0", VA = "0x18A5524F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xA551FF0", Offset = "0xA5509F0", VA = "0x18A551FF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xA5524B0", Offset = "0xA550EB0", VA = "0x18A5524B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xA552400", Offset = "0xA550E00", VA = "0x18A552400", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xA552400", Offset = "0xA550E00", VA = "0x18A552400", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xA55A0D0", Offset = "0xA558AD0", VA = "0x18A55A0D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xA555C50", Offset = "0xA554650", VA = "0x18A555C50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xA55A540", Offset = "0xA558F40", VA = "0x18A55A540")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xA5594D0", Offset = "0xA557ED0", VA = "0x18A5594D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA558770", Offset = "0xA557170", VA = "0x18A558770", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA558770", Offset = "0xA557170", VA = "0x18A558770", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5466A0", Offset = "0xA5450A0", VA = "0x18A5466A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA5466F0", Offset = "0xA5450F0", VA = "0x18A5466F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float AnisotropyRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA546770", Offset = "0xA545170", VA = "0x18A546770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA5467C0", Offset = "0xA5451C0", VA = "0x18A5467C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA545F80", Offset = "0xA544980", VA = "0x18A545F80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA5460A0", Offset = "0xA544AA0", VA = "0x18A5460A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA546270", Offset = "0xA544C70", VA = "0x18A546270", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA546120", Offset = "0xA544B20", VA = "0x18A546120", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA545DD0", Offset = "0xA5447D0", VA = "0x18A545DD0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA546870", Offset = "0xA545270", VA = "0x18A546870")]
		internal MaterialAnisotropy(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA545FB0", Offset = "0xA5449B0", VA = "0x18A545FB0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA545EF0", Offset = "0xA5448F0", VA = "0x18A545EF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA554360", Offset = "0xA552D60", VA = "0x18A554360", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__28(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xA553B00", Offset = "0xA552500", VA = "0x18A553B00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA554320", Offset = "0xA552D20", VA = "0x18A554320", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xA554270", Offset = "0xA552C70", VA = "0x18A554270", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xA554270", Offset = "0xA552C70", VA = "0x18A554270", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xA559D10", Offset = "0xA558710", VA = "0x18A559D10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xA5558D0", Offset = "0xA5542D0", VA = "0x18A5558D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xA55A6D0", Offset = "0xA5590D0", VA = "0x18A55A6D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA559310", Offset = "0xA557D10", VA = "0x18A559310", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA558810", Offset = "0xA557210", VA = "0x18A558810", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA558810", Offset = "0xA557210", VA = "0x18A558810", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA547490", Offset = "0xA545E90", VA = "0x18A547490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA5474E0", Offset = "0xA545EE0", VA = "0x18A5474E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA547600", Offset = "0xA546000", VA = "0x18A547600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xA547650", Offset = "0xA546050", VA = "0x18A547650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA546B20", Offset = "0xA545520", VA = "0x18A546B20", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA546CA0", Offset = "0xA5456A0", VA = "0x18A546CA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA546EC0", Offset = "0xA5458C0", VA = "0x18A546EC0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA546D20", Offset = "0xA545720", VA = "0x18A546D20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA5468F0", Offset = "0xA5452F0", VA = "0x18A5468F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA5479B0", Offset = "0xA5463B0", VA = "0x18A5479B0")]
		internal MaterialClearCoat(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA546B50", Offset = "0xA545550", VA = "0x18A546B50", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA547920", Offset = "0xA546320", VA = "0x18A547920")]
		private TextureInfo _GetClearCoatTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA547890", Offset = "0xA546290", VA = "0x18A547890")]
		private TextureInfo _GetClearCoatRoughnessTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA547800", Offset = "0xA546200", VA = "0x18A547800")]
		private MaterialNormalTextureInfo _GetClearCoatNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA546A90", Offset = "0xA545490", VA = "0x18A546A90")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5532A0", Offset = "0xA551CA0", VA = "0x18A5532A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA552B10", Offset = "0xA551510", VA = "0x18A552B10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xA553260", Offset = "0xA551C60", VA = "0x18A553260", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA553170", Offset = "0xA551B70", VA = "0x18A553170", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA553170", Offset = "0xA551B70", VA = "0x18A553170", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xA559A10", Offset = "0xA558410", VA = "0x18A559A10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA558450", Offset = "0xA556E50", VA = "0x18A558450", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xA55A450", Offset = "0xA558E50", VA = "0x18A55A450")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA559510", Offset = "0xA557F10", VA = "0x18A559510", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA558B30", Offset = "0xA557530", VA = "0x18A558B30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xA558B30", Offset = "0xA557530", VA = "0x18A558B30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5484B0", Offset = "0xA546EB0", VA = "0x18A5484B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA548500", Offset = "0xA546F00", VA = "0x18A548500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 DiffuseTransmissionColorFactor
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xA5485F0", Offset = "0xA546FF0", VA = "0x18A5485F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xA5486B0", Offset = "0xA5470B0", VA = "0x18A5486B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA547C30", Offset = "0xA546630", VA = "0x18A547C30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA547D50", Offset = "0xA546750", VA = "0x18A547D50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xA547F90", Offset = "0xA546990", VA = "0x18A547F90", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xA547DD0", Offset = "0xA5467D0", VA = "0x18A547DD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA547A30", Offset = "0xA546430", VA = "0x18A547A30", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA5487B0", Offset = "0xA5471B0", VA = "0x18A5487B0")]
		internal MaterialDiffuseTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA547C60", Offset = "0xA546660", VA = "0x18A547C60", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA547BA0", Offset = "0xA5465A0", VA = "0x18A547BA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xA55A250", Offset = "0xA558C50", VA = "0x18A55A250", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xA5561A0", Offset = "0xA554BA0", VA = "0x18A5561A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xA55A4F0", Offset = "0xA558EF0", VA = "0x18A55A4F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA559550", Offset = "0xA557F50", VA = "0x18A559550", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA558DB0", Offset = "0xA5577B0", VA = "0x18A558DB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA558DB0", Offset = "0xA5577B0", VA = "0x18A558DB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3F500", Offset = "0xD3DF00", VA = "0x180D3F500")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA548D60", Offset = "0xA547760", VA = "0x18A548D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA548DB0", Offset = "0xA5477B0", VA = "0x18A548DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA548920", Offset = "0xA547320", VA = "0x18A548920", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA548A20", Offset = "0xA547420", VA = "0x18A548A20", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA548B60", Offset = "0xA547560", VA = "0x18A548B60", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA548AA0", Offset = "0xA5474A0", VA = "0x18A548AA0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA548880", Offset = "0xA547280", VA = "0x18A548880", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA548D00", Offset = "0xA547700", VA = "0x18A548D00")]
		internal MaterialDispersion(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA548950", Offset = "0xA547350", VA = "0x18A548950", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xA559F50", Offset = "0xA558950", VA = "0x18A559F50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xA557100", Offset = "0xA555B00", VA = "0x18A557100", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xA55A400", Offset = "0xA558E00", VA = "0x18A55A400")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xA559590", Offset = "0xA557F90", VA = "0x18A559590", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xA5589F0", Offset = "0xA5573F0", VA = "0x18A5589F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA5589F0", Offset = "0xA5573F0", VA = "0x18A5589F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA549A40", Offset = "0xA548440", VA = "0x18A549A40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xA549A50", Offset = "0xA548450", VA = "0x18A549A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xA549AA0", Offset = "0xA5484A0", VA = "0x18A549AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA5495D0", Offset = "0xA547FD0", VA = "0x18A5495D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA549700", Offset = "0xA548100", VA = "0x18A549700", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA549840", Offset = "0xA548240", VA = "0x18A549840", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA549780", Offset = "0xA548180", VA = "0x18A549780", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA549530", Offset = "0xA547F30", VA = "0x18A549530", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5499E0", Offset = "0xA5483E0", VA = "0x18A5499E0")]
		internal MaterialIOR(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA549600", Offset = "0xA548000", VA = "0x18A549600", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA554C00", Offset = "0xA553600", VA = "0x18A554C00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__35(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA5543C0", Offset = "0xA552DC0", VA = "0x18A5543C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA554BC0", Offset = "0xA5535C0", VA = "0x18A554BC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA554B10", Offset = "0xA553510", VA = "0x18A554B10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA554B10", Offset = "0xA553510", VA = "0x18A554B10", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xA559DD0", Offset = "0xA5587D0", VA = "0x18A559DD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0xA558080", Offset = "0xA556A80", VA = "0x18A558080", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xA55A310", Offset = "0xA558D10", VA = "0x18A55A310")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xA559490", Offset = "0xA557E90", VA = "0x18A559490", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xA558F90", Offset = "0xA557990", VA = "0x18A558F90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xA558F90", Offset = "0xA557990", VA = "0x18A558F90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54AA00", Offset = "0xA549400", VA = "0x18A54AA00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA54AA50", Offset = "0xA549450", VA = "0x18A54AA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float IridescenceIndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xA54AAD0", Offset = "0xA5494D0", VA = "0x18A54AAD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xA54AB30", Offset = "0xA549530", VA = "0x18A54AB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float IridescenceThicknessMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xA54AC20", Offset = "0xA549620", VA = "0x18A54AC20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xA54AC80", Offset = "0xA549680", VA = "0x18A54AC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float IridescenceThicknessMaximum
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xA54A8B0", Offset = "0xA5492B0", VA = "0x18A54A8B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xA54A910", Offset = "0xA549310", VA = "0x18A54A910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA549D40", Offset = "0xA548740", VA = "0x18A549D40", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA549FA0", Offset = "0xA5489A0", VA = "0x18A549FA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA54A250", Offset = "0xA548C50", VA = "0x18A54A250", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA54A020", Offset = "0xA548A20", VA = "0x18A54A020", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA549B10", Offset = "0xA548510", VA = "0x18A549B10", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA54AD00", Offset = "0xA549700", VA = "0x18A54AD00")]
		internal MaterialIridescence(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA549D70", Offset = "0xA548770", VA = "0x18A549D70", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA549CB0", Offset = "0xA5486B0", VA = "0x18A549CB0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xA559710", Offset = "0xA558110", VA = "0x18A559710", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xA555F50", Offset = "0xA554950", VA = "0x18A555F50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xA55A5E0", Offset = "0xA558FE0", VA = "0x18A55A5E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA559390", Offset = "0xA557D90", VA = "0x18A559390", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xA5590D0", Offset = "0xA557AD0", VA = "0x18A5590D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA5590D0", Offset = "0xA557AD0", VA = "0x18A5590D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA549460", Offset = "0xA547E60", VA = "0x18A549460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xA5494B0", Offset = "0xA547EB0", VA = "0x18A5494B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA549020", Offset = "0xA547A20", VA = "0x18A549020", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA549120", Offset = "0xA547B20", VA = "0x18A549120", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA549260", Offset = "0xA547C60", VA = "0x18A549260", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA5491A0", Offset = "0xA547BA0", VA = "0x18A5491A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA548E40", Offset = "0xA547840", VA = "0x18A548E40", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA549400", Offset = "0xA547E00", VA = "0x18A549400")]
		internal MaterialEmissiveStrength(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA549050", Offset = "0xA547A50", VA = "0x18A549050", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA548EE0", Offset = "0xA5478E0", VA = "0x18A548EE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA553AA0", Offset = "0xA5524A0", VA = "0x18A553AA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA553360", Offset = "0xA551D60", VA = "0x18A553360", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA553A60", Offset = "0xA552460", VA = "0x18A553A60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xA5539B0", Offset = "0xA5523B0", VA = "0x18A5539B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA5539B0", Offset = "0xA5523B0", VA = "0x18A5539B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA55A010", Offset = "0xA558A10", VA = "0x18A55A010", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA557350", Offset = "0xA555D50", VA = "0x18A557350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA55A360", Offset = "0xA558D60", VA = "0x18A55A360")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA5592D0", Offset = "0xA557CD0", VA = "0x18A5592D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA558EF0", Offset = "0xA5578F0", VA = "0x18A558EF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA558EF0", Offset = "0xA5578F0", VA = "0x18A558EF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54DC40", Offset = "0xA54C640", VA = "0x18A54DC40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA54DC90", Offset = "0xA54C690", VA = "0x18A54DC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 AttenuationColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA54DD10", Offset = "0xA54C710", VA = "0x18A54DD10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0xA54DDD0", Offset = "0xA54C7D0", VA = "0x18A54DDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float AttenuationDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA54DE80", Offset = "0xA54C880", VA = "0x18A54DE80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xA54DEE0", Offset = "0xA54C8E0", VA = "0x18A54DEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA54D280", Offset = "0xA54BC80", VA = "0x18A54D280", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA54D4A0", Offset = "0xA54BEA0", VA = "0x18A54D4A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA54D700", Offset = "0xA54C100", VA = "0x18A54D700", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA54D520", Offset = "0xA54BF20", VA = "0x18A54D520", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA54D080", Offset = "0xA54BA80", VA = "0x18A54D080", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA54DFA0", Offset = "0xA54C9A0", VA = "0x18A54DFA0")]
		internal MaterialVolume(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA54D2B0", Offset = "0xA54BCB0", VA = "0x18A54D2B0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA54D1F0", Offset = "0xA54BBF0", VA = "0x18A54D1F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xA559E90", Offset = "0xA558890", VA = "0x18A559E90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xA5563F0", Offset = "0xA554DF0", VA = "0x18A5563F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xA55A3B0", Offset = "0xA558DB0", VA = "0x18A55A3B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA559210", Offset = "0xA557C10", VA = "0x18A559210", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xA558BD0", Offset = "0xA5575D0", VA = "0x18A558BD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xA558BD0", Offset = "0xA5575D0", VA = "0x18A558BD0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x5B99680", Offset = "0x5B98080", VA = "0x185B99680", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA55C160", Offset = "0xA55AB60", VA = "0x18A55C160", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x64DB930", Offset = "0x64DA330", VA = "0x1864DB930")]
			[DebuggerHidden]
			public <_GetLocalTransforms>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA55BFC0", Offset = "0xA55A9C0", VA = "0x18A55BFC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA55C120", Offset = "0xA55AB20", VA = "0x18A55C120", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xA55C080", Offset = "0xA55AA80", VA = "0x18A55C080", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<AffineTransform> IEnumerable<AffineTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xA55C080", Offset = "0xA55AA80", VA = "0x18A55C080", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Node VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xA54F0F0", Offset = "0xA54DAF0", VA = "0x18A54F0F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IReadOnlyDictionary<string, Accessor> Accessors
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0xA54EE20", Offset = "0xA54D820", VA = "0x18A54EE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public IEnumerable<AffineTransform> LocalTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xA54EFE0", Offset = "0xA54D9E0", VA = "0x18A54EFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA54E690", Offset = "0xA54D090", VA = "0x18A54E690", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA54E8E0", Offset = "0xA54D2E0", VA = "0x18A54E8E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA54EBA0", Offset = "0xA54D5A0", VA = "0x18A54EBA0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA54E960", Offset = "0xA54D360", VA = "0x18A54E960", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA54E0C0", Offset = "0xA54CAC0", VA = "0x18A54E0C0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA54F060", Offset = "0xA54DA60", VA = "0x18A54F060")]
		internal MeshGpuInstancing(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA54EEF0", Offset = "0xA54D8F0", VA = "0x18A54EEF0")]
		private int _GetCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA54EE20", Offset = "0xA54D820", VA = "0x18A54EE20")]
		private IReadOnlyDictionary<string, Accessor> _GetAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA54EFE0", Offset = "0xA54D9E0", VA = "0x18A54EFE0")]
		[IteratorStateMachine(typeof(<_GetLocalTransforms>d__21))]
		private IEnumerable<AffineTransform> _GetLocalTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA54E070", Offset = "0xA54CA70", VA = "0x18A54E070")]
		public void ClearAccessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA54E160", Offset = "0xA54CB60", VA = "0x18A54E160")]
		public Accessor GetAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA54E9D0", Offset = "0xA54D3D0", VA = "0x18A54E9D0")]
		public void SetAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA54E340", Offset = "0xA54CD40", VA = "0x18A54E340")]
		public AffineTransform GetLocalTransform(int index)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA54E260", Offset = "0xA54CC60", VA = "0x18A54E260")]
		public Matrix4x4 GetLocalMatrix(int index)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA54E6C0", Offset = "0xA54D0C0", VA = "0x18A54E6C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xA5597D0", Offset = "0xA5581D0", VA = "0x18A5597D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xA556C10", Offset = "0xA555610", VA = "0x18A556C10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xA55A810", Offset = "0xA559210", VA = "0x18A55A810")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xA5595D0", Offset = "0xA557FD0", VA = "0x18A5595D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xA559170", Offset = "0xA557B70", VA = "0x18A559170", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xA559170", Offset = "0xA557B70", VA = "0x18A559170", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54F9D0", Offset = "0xA54E3D0", VA = "0x18A54F9D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA54FA80", Offset = "0xA54E480", VA = "0x18A54FA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA54FA20", Offset = "0xA54E420", VA = "0x18A54FA20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA54FBA0", Offset = "0xA54E5A0", VA = "0x18A54FBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA54F1D0", Offset = "0xA54DBD0", VA = "0x18A54F1D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA54F4F0", Offset = "0xA54DEF0", VA = "0x18A54F4F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA54F690", Offset = "0xA54E090", VA = "0x18A54F690", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA54F570", Offset = "0xA54DF70", VA = "0x18A54F570", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA54F100", Offset = "0xA54DB00", VA = "0x18A54F100", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA54F200", Offset = "0xA54DC00", VA = "0x18A54F200", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA54F940", Offset = "0xA54E340", VA = "0x18A54F940")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xA559890", Offset = "0xA558290", VA = "0x18A559890", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA556640", Offset = "0xA555040", VA = "0x18A556640", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xA55A590", Offset = "0xA558F90", VA = "0x18A55A590")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xA559410", Offset = "0xA557E10", VA = "0x18A559410", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xA559030", Offset = "0xA557A30", VA = "0x18A559030", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xA559030", Offset = "0xA557A30", VA = "0x18A559030", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5514F0", Offset = "0xA54FEF0", VA = "0x18A5514F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public PunctualLightType LightType
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xA551400", Offset = "0xA54FE00", VA = "0x18A551400")]
			get
			{
				return default(PunctualLightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public float InnerConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xA551340", Offset = "0xA54FD40", VA = "0x18A551340")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xA551590", Offset = "0xA54FF90", VA = "0x18A551590")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xA551280", Offset = "0xA54FC80", VA = "0x18A551280")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA551650", Offset = "0xA550050", VA = "0x18A551650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xA5513A0", Offset = "0xA54FDA0", VA = "0x18A5513A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xA551770", Offset = "0xA550170", VA = "0x18A551770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float Range
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xA5515F0", Offset = "0xA54FFF0", VA = "0x18A5515F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0xA5517F0", Offset = "0xA5501F0", VA = "0x18A5517F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA54FE80", Offset = "0xA54E880", VA = "0x18A54FE80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA550170", Offset = "0xA54EB70", VA = "0x18A550170", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA550990", Offset = "0xA54F390", VA = "0x18A550990", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5501F0", Offset = "0xA54EBF0", VA = "0x18A5501F0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA54FCC0", Offset = "0xA54E6C0", VA = "0x18A54FCC0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5511A0", Offset = "0xA54FBA0", VA = "0x18A5511A0")]
		internal PunctualLight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA550FB0", Offset = "0xA54F9B0", VA = "0x18A550FB0")]
		internal PunctualLight(PunctualLightType ltype)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA550640", Offset = "0xA54F040", VA = "0x18A550640")]
		public void SetSpotCone(float innerConeAngle, float outerConeAngle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5503F0", Offset = "0xA54EDF0", VA = "0x18A5503F0")]
		public void SetColor(Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA54FF80", Offset = "0xA54E980", VA = "0x18A54FF80", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA54FEB0", Offset = "0xA54E8B0", VA = "0x18A54FEB0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xA55A190", Offset = "0xA558B90", VA = "0x18A55A190", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xA556EB0", Offset = "0xA5558B0", VA = "0x18A556EB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xA55A770", Offset = "0xA559170", VA = "0x18A55A770")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xA559350", Offset = "0xA557D50", VA = "0x18A559350", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xA5588B0", Offset = "0xA5572B0", VA = "0x18A5588B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xA5588B0", Offset = "0xA5572B0", VA = "0x18A5588B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA55D3C0", Offset = "0xA55BDC0", VA = "0x18A55D3C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA55D3F0", Offset = "0xA55BDF0", VA = "0x18A55D3F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA55D520", Offset = "0xA55BF20", VA = "0x18A55D520", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA55D470", Offset = "0xA55BE70", VA = "0x18A55D470", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA55D320", Offset = "0xA55BD20", VA = "0x18A55D320", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA55D6C0", Offset = "0xA55C0C0", VA = "0x18A55D6C0")]
		internal _ModelPunctualLights(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA55D270", Offset = "0xA55BC70", VA = "0x18A55D270")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA559C50", Offset = "0xA558650", VA = "0x18A559C50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA557E30", Offset = "0xA556830", VA = "0x18A557E30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA55A720", Offset = "0xA559120", VA = "0x18A55A720")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA559290", Offset = "0xA557C90", VA = "0x18A559290", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA558E50", Offset = "0xA557850", VA = "0x18A558E50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA558E50", Offset = "0xA557850", VA = "0x18A558E50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA551C30", Offset = "0xA550630", VA = "0x18A551C30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xA551D40", Offset = "0xA550740", VA = "0x18A551D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA551970", Offset = "0xA550370", VA = "0x18A551970", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5519A0", Offset = "0xA5503A0", VA = "0x18A5519A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA551A90", Offset = "0xA550490", VA = "0x18A551A90", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA551A20", Offset = "0xA550420", VA = "0x18A551A20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5518D0", Offset = "0xA5502D0", VA = "0x18A5518D0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA545D90", Offset = "0xA544790", VA = "0x18A545D90")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA559650", Offset = "0xA558050", VA = "0x18A559650", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA557BE0", Offset = "0xA5565E0", VA = "0x18A557BE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xA55A7C0", Offset = "0xA5591C0", VA = "0x18A55A7C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA5593D0", Offset = "0xA557DD0", VA = "0x18A5593D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA558A90", Offset = "0xA557490", VA = "0x18A558A90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA558A90", Offset = "0xA557490", VA = "0x18A558A90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF070", VA = "0x180D00670")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xD45780", Offset = "0xD44180", VA = "0x180D45780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xA55D7F0", Offset = "0xA55C1F0", VA = "0x18A55D7F0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xA55D820", Offset = "0xA55C220", VA = "0x18A55D820", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xA55D930", Offset = "0xA55C330", VA = "0x18A55D930", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xA55D8A0", Offset = "0xA55C2A0", VA = "0x18A55D8A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xA55D750", Offset = "0xA55C150", VA = "0x18A55D750", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAD0", Offset = "0xA55C4D0", VA = "0x18A55DAD0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA559B90", Offset = "0xA558590", VA = "0x18A559B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA557990", Offset = "0xA556390", VA = "0x18A557990", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA55A680", Offset = "0xA559080", VA = "0x18A55A680")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA559610", Offset = "0xA558010", VA = "0x18A559610", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA558D10", Offset = "0xA557710", VA = "0x18A558D10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA558D10", Offset = "0xA557710", VA = "0x18A558D10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA55DF90", Offset = "0xA55C990", VA = "0x18A55DF90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xA55E010", Offset = "0xA55CA10", VA = "0x18A55E010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA55DB80", Offset = "0xA55C580", VA = "0x18A55DB80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xA55DBB0", Offset = "0xA55C5B0", VA = "0x18A55DBB0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA55DD00", Offset = "0xA55C700", VA = "0x18A55DD00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xA55DC30", Offset = "0xA55C630", VA = "0x18A55DC30", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAE0", Offset = "0xA55C4E0", VA = "0x18A55DAE0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xA55DEE0", Offset = "0xA55C8E0", VA = "0x18A55DEE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA553300", Offset = "0xA551D00", VA = "0x18A553300", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xA552550", Offset = "0xA550F50", VA = "0x18A552550", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA553220", Offset = "0xA551C20", VA = "0x18A553220", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA5530C0", Offset = "0xA551AC0", VA = "0x18A5530C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA5530C0", Offset = "0xA551AC0", VA = "0x18A5530C0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xA559950", Offset = "0xA558350", VA = "0x18A559950", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA557670", Offset = "0xA556070", VA = "0x18A557670", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA55A4A0", Offset = "0xA558EA0", VA = "0x18A55A4A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xA559450", Offset = "0xA557E50", VA = "0x18A559450", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xA558C70", Offset = "0xA557670", VA = "0x18A558C70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xA558C70", Offset = "0xA557670", VA = "0x18A558C70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54CCA0", Offset = "0xA54B6A0", VA = "0x18A54CCA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA54CD60", Offset = "0xA54B760", VA = "0x18A54CD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public float SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xA54CE80", Offset = "0xA54B880", VA = "0x18A54CE80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xA54CEE0", Offset = "0xA54B8E0", VA = "0x18A54CEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xA54C310", Offset = "0xA54AD10", VA = "0x18A54C310", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xA54C530", Offset = "0xA54AF30", VA = "0x18A54C530", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA54C780", Offset = "0xA54B180", VA = "0x18A54C780", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA54C5B0", Offset = "0xA54AFB0", VA = "0x18A54C5B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xA54C110", Offset = "0xA54AB10", VA = "0x18A54C110", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xA54CFA0", Offset = "0xA54B9A0", VA = "0x18A54CFA0")]
		internal MaterialSpecular(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA54C340", Offset = "0xA54AD40", VA = "0x18A54C340", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA54C280", Offset = "0xA54AC80", VA = "0x18A54C280")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA576280", Offset = "0xA574C80", VA = "0x18A576280", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xA575A50", Offset = "0xA574450", VA = "0x18A575A50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA576240", Offset = "0xA574C40", VA = "0x18A576240", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xA576190", Offset = "0xA574B90", VA = "0x18A576190", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xA576190", Offset = "0xA574B90", VA = "0x18A576190", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xA579750", Offset = "0xA578150", VA = "0x18A579750", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xA576720", Offset = "0xA575120", VA = "0x18A576720", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xA57A450", Offset = "0xA578E50", VA = "0x18A57A450")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xA5796D0", Offset = "0xA5780D0", VA = "0x18A5796D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xA578ED0", Offset = "0xA5778D0", VA = "0x18A578ED0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xA578ED0", Offset = "0xA5778D0", VA = "0x18A578ED0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54BB50", Offset = "0xA54A550", VA = "0x18A54BB50")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA54BC10", Offset = "0xA54A610", VA = "0x18A54BC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA54BD30", Offset = "0xA54A730", VA = "0x18A54BD30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA54BDF0", Offset = "0xA54A7F0", VA = "0x18A54BDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public float GlossinessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA54BEA0", Offset = "0xA54A8A0", VA = "0x18A54BEA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xA54BF00", Offset = "0xA54A900", VA = "0x18A54BF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xA54B030", Offset = "0xA549A30", VA = "0x18A54B030", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xA54B250", Offset = "0xA549C50", VA = "0x18A54B250", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA54B520", Offset = "0xA549F20", VA = "0x18A54B520", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xA54B2D0", Offset = "0xA549CD0", VA = "0x18A54B2D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xA54ADE0", Offset = "0xA5497E0", VA = "0x18A54ADE0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA54BFE0", Offset = "0xA54A9E0", VA = "0x18A54BFE0")]
		internal MaterialPBRSpecularGlossiness(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA54B060", Offset = "0xA549A60", VA = "0x18A54B060", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA54AFA0", Offset = "0xA5499A0", VA = "0x18A54AFA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5759F0", Offset = "0xA5743F0", VA = "0x18A5759F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xA575350", Offset = "0xA573D50", VA = "0x18A575350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xA5759B0", Offset = "0xA5743B0", VA = "0x18A5759B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xA575900", Offset = "0xA574300", VA = "0x18A575900", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xA575900", Offset = "0xA574300", VA = "0x18A575900", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xA579C90", Offset = "0xA578690", VA = "0x18A579C90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xA577280", Offset = "0xA575C80", VA = "0x18A577280", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xA57A220", Offset = "0xA578C20", VA = "0x18A57A220")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xA5793D0", Offset = "0xA577DD0", VA = "0x18A5793D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xA579010", Offset = "0xA577A10", VA = "0x18A579010", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xA579010", Offset = "0xA577A10", VA = "0x18A579010", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA572610", Offset = "0xA571010", VA = "0x18A572610")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xA5726D0", Offset = "0xA5710D0", VA = "0x18A5726D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xA5727F0", Offset = "0xA5711F0", VA = "0x18A5727F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xA572830", Offset = "0xA571230", VA = "0x18A572830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xA571C90", Offset = "0xA570690", VA = "0x18A571C90", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xA571EB0", Offset = "0xA5708B0", VA = "0x18A571EB0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA5720F0", Offset = "0xA570AF0", VA = "0x18A5720F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA571F30", Offset = "0xA570930", VA = "0x18A571F30", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA571A90", Offset = "0xA570490", VA = "0x18A571A90", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA5728D0", Offset = "0xA5712D0", VA = "0x18A5728D0")]
		internal MaterialSheen(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xA571CC0", Offset = "0xA5706C0", VA = "0x18A571CC0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xA571C00", Offset = "0xA570600", VA = "0x18A571C00")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xA579D50", Offset = "0xA578750", VA = "0x18A579D50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xA5762E0", Offset = "0xA574CE0", VA = "0x18A5762E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xA57A310", Offset = "0xA578D10", VA = "0x18A57A310")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xA579450", Offset = "0xA577E50", VA = "0x18A579450", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xA578CF0", Offset = "0xA5776F0", VA = "0x18A578CF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xA578CF0", Offset = "0xA5776F0", VA = "0x18A578CF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA573680", Offset = "0xA572080", VA = "0x18A573680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xA573720", Offset = "0xA572120", VA = "0x18A573720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5733C0", Offset = "0xA571DC0", VA = "0x18A5733C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA5733F0", Offset = "0xA571DF0", VA = "0x18A5733F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA5734E0", Offset = "0xA571EE0", VA = "0x18A5734E0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA573470", Offset = "0xA571E70", VA = "0x18A573470", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA573320", Offset = "0xA571D20", VA = "0x18A573320", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA545D90", Offset = "0xA544790", VA = "0x18A545D90")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0xA579E10", Offset = "0xA578810", VA = "0x18A579E10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0xA5777F0", Offset = "0xA5761F0", VA = "0x18A5777F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xA57A400", Offset = "0xA578E00", VA = "0x18A57A400")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0xA579410", Offset = "0xA577E10", VA = "0x18A579410", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0xA578BB0", Offset = "0xA5775B0", VA = "0x18A578BB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0xA578BB0", Offset = "0xA5775B0", VA = "0x18A578BB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA574620", Offset = "0xA573020", VA = "0x18A574620")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xA5747B0", Offset = "0xA5731B0", VA = "0x18A5747B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xA574710", Offset = "0xA573110", VA = "0x18A574710")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xA5748C0", Offset = "0xA5732C0", VA = "0x18A5748C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xA5746C0", Offset = "0xA5730C0", VA = "0x18A5746C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xA574860", Offset = "0xA573260", VA = "0x18A574860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public int? TextureCoordinateOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0x8A6E950", Offset = "0x8A6D350", VA = "0x188A6E950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xA574970", Offset = "0xA573370", VA = "0x18A574970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xA574300", Offset = "0xA572D00", VA = "0x18A574300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public Matrix3x2 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xA574370", Offset = "0xA572D70", VA = "0x18A574370")]
			get
			{
				return default(Matrix3x2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5739D0", Offset = "0xA5723D0", VA = "0x18A5739D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA573A00", Offset = "0xA572400", VA = "0x18A573A00", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA573CB0", Offset = "0xA5726B0", VA = "0x18A573CB0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xA573A80", Offset = "0xA572480", VA = "0x18A573A80", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA573860", Offset = "0xA572260", VA = "0x18A573860", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA5741D0", Offset = "0xA572BD0", VA = "0x18A5741D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xA579BD0", Offset = "0xA5785D0", VA = "0x18A579BD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0xA5775A0", Offset = "0xA575FA0", VA = "0x18A5775A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0xA57A4A0", Offset = "0xA578EA0", VA = "0x18A57A4A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xA579710", Offset = "0xA578110", VA = "0x18A579710", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0xA5791F0", Offset = "0xA577BF0", VA = "0x18A5791F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xA5791F0", Offset = "0xA577BF0", VA = "0x18A5791F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA574CE0", Offset = "0xA5736E0", VA = "0x18A574CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0xA574D80", Offset = "0xA573780", VA = "0x18A574D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xA574A20", Offset = "0xA573420", VA = "0x18A574A20", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA574A50", Offset = "0xA573450", VA = "0x18A574A50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA574B40", Offset = "0xA573540", VA = "0x18A574B40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA574AD0", Offset = "0xA5734D0", VA = "0x18A574AD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xA574980", Offset = "0xA573380", VA = "0x18A574980", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA545D90", Offset = "0xA544790", VA = "0x18A545D90")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5752F0", Offset = "0xA573CF0", VA = "0x18A5752F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0xA574EC0", Offset = "0xA5738C0", VA = "0x18A574EC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xA5752B0", Offset = "0xA573CB0", VA = "0x18A5752B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0xA575200", Offset = "0xA573C00", VA = "0x18A575200", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xA575200", Offset = "0xA573C00", VA = "0x18A575200", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xA579ED0", Offset = "0xA5788D0", VA = "0x18A579ED0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0xA576AA0", Offset = "0xA5754A0", VA = "0x18A576AA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0xA57A2C0", Offset = "0xA578CC0", VA = "0x18A57A2C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xA579650", Offset = "0xA578050", VA = "0x18A579650", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xA578D90", Offset = "0xA577790", VA = "0x18A578D90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0xA578D90", Offset = "0xA577790", VA = "0x18A578D90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5730E0", Offset = "0xA571AE0", VA = "0x18A5730E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0xA573130", Offset = "0xA571B30", VA = "0x18A573130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA572B30", Offset = "0xA571530", VA = "0x18A572B30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xA572C50", Offset = "0xA571650", VA = "0x18A572C50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA572DC0", Offset = "0xA5717C0", VA = "0x18A572DC0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA572CD0", Offset = "0xA5716D0", VA = "0x18A572CD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA5729B0", Offset = "0xA5713B0", VA = "0x18A5729B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xA5731E0", Offset = "0xA571BE0", VA = "0x18A5731E0")]
		internal MaterialTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xA572B60", Offset = "0xA571560", VA = "0x18A572B60", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA572AA0", Offset = "0xA5714A0", VA = "0x18A572AA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0xA579990", Offset = "0xA578390", VA = "0x18A579990", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0xA576530", Offset = "0xA574F30", VA = "0x18A576530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xA57A1D0", Offset = "0xA578BD0", VA = "0x18A57A1D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0xA5795D0", Offset = "0xA577FD0", VA = "0x18A5795D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0xA579330", Offset = "0xA577D30", VA = "0x18A579330", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xA579330", Offset = "0xA577D30", VA = "0x18A579330", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public new const string SCHEMANAME = "KHR_materials_unlit";

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA573250", Offset = "0xA571C50", VA = "0x18A573250", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA573280", Offset = "0xA571C80", VA = "0x18A573280", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xA573310", Offset = "0xA571D10", VA = "0x18A573310", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA573300", Offset = "0xA571D00", VA = "0x18A573300", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA573240", Offset = "0xA571C40", VA = "0x18A573240", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAD0", Offset = "0xA55C4D0", VA = "0x18A55DAD0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0xA579F90", Offset = "0xA578990", VA = "0x18A579F90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0xA577B10", Offset = "0xA576510", VA = "0x18A577B10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0xA57A4F0", Offset = "0xA578EF0", VA = "0x18A57A4F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xA579690", Offset = "0xA578090", VA = "0x18A579690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xA578C50", Offset = "0xA577650", VA = "0x18A578C50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0xA578C50", Offset = "0xA577650", VA = "0x18A578C50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ModelRoot LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0180", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0xCFAD50", Offset = "0xCF9750", VA = "0x180CFAD50", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0xCFAF30", Offset = "0xCF9930", VA = "0x180CFAF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA5716D0", Offset = "0xA5700D0", VA = "0x18A5716D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA564D60", Offset = "0xA563760", VA = "0x18A564D60", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xA5718D0", Offset = "0xA5702D0", VA = "0x18A5718D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA5717B0", Offset = "0xA5701B0", VA = "0x18A5717B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xA571630", Offset = "0xA570030", VA = "0x18A571630", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xA5718A0", Offset = "0xA5702A0", VA = "0x18A5718A0", Slot = "18")]
		void IChildOfList<ModelRoot>.SetLogicalParent(ModelRoot parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xA571810", Offset = "0xA570210", VA = "0x18A571810")]
		protected bool SharesLogicalParent(params LogicalChildOfRoot[] items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3C18200", Offset = "0x3C16C00", VA = "0x183C18200")]
		public static void RenameLogicalElements<T>(IEnumerable<T> collection, string namePrefix) where T : LogicalChildOfRoot
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA571700", Offset = "0xA570100", VA = "0x18A571700")]
		private bool RenameIfAvailable(string newName, HashSet<string> usedNames)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA569BE0", Offset = "0xA5685E0", VA = "0x18A569BE0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0xA579810", Offset = "0xA578210", VA = "0x18A579810", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xA578270", Offset = "0xA576C70", VA = "0x18A578270", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0xA57A540", Offset = "0xA578F40", VA = "0x18A57A540")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xA5794D0", Offset = "0xA577ED0", VA = "0x18A5794D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xA579150", Offset = "0xA577B50", VA = "0x18A579150", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xA579150", Offset = "0xA577B50", VA = "0x18A579150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55E820", Offset = "0xA55D220", VA = "0x18A55E820", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA55E9D0", Offset = "0xA55D3D0", VA = "0x18A55E9D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA55EB80", Offset = "0xA55D580", VA = "0x18A55EB80", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA55EA50", Offset = "0xA55D450", VA = "0x18A55EA50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA55E6E0", Offset = "0xA55D0E0", VA = "0x18A55E6E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA55F1D0", Offset = "0xA55DBD0", VA = "0x18A55F1D0")]
		internal AccessorSparseIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xA55F230", Offset = "0xA55DC30", VA = "0x18A55F230")]
		internal AccessorSparseIndices(BufferView bv, int byteOffset, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA55F0C0", Offset = "0xA55DAC0", VA = "0x18A55F0C0")]
		internal IntegerArray _GetIndicesArray(ModelRoot root, int sparseCount)
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xA55E850", Offset = "0xA55D250", VA = "0x18A55E850", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA55EF40", Offset = "0xA55D940", VA = "0x18A55EF40")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xA579A50", Offset = "0xA578450", VA = "0x18A579A50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xA576FE0", Offset = "0xA5759E0", VA = "0x18A576FE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xA57A3B0", Offset = "0xA578DB0", VA = "0x18A57A3B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xA579550", Offset = "0xA577F50", VA = "0x18A579550", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0xA578B10", Offset = "0xA577510", VA = "0x18A578B10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0xA578B10", Offset = "0xA577510", VA = "0x18A578B10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55F470", Offset = "0xA55DE70", VA = "0x18A55F470", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA55F620", Offset = "0xA55E020", VA = "0x18A55F620", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xA55F780", Offset = "0xA55E180", VA = "0x18A55F780", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xA55F6A0", Offset = "0xA55E0A0", VA = "0x18A55F6A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xA55F380", Offset = "0xA55DD80", VA = "0x18A55F380", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xA55FE40", Offset = "0xA55E840", VA = "0x18A55FE40")]
		internal AccessorSparseValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xA55FCF0", Offset = "0xA55E6F0", VA = "0x18A55FCF0")]
		internal AccessorSparseValues(BufferView bv, int byteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xA55FA90", Offset = "0xA55E490", VA = "0x18A55FA90")]
		internal MemoryAccessor _GetMemoryAccessor(ModelRoot root, int sparseCount, Accessor baseAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA55F4A0", Offset = "0xA55DEA0", VA = "0x18A55F4A0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xA55FA30", Offset = "0xA55E430", VA = "0x18A55FA30")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xA579B10", Offset = "0xA578510", VA = "0x18A579B10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0xA578810", Offset = "0xA577210", VA = "0x18A578810", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xA57A5E0", Offset = "0xA578FE0", VA = "0x18A57A5E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0xA579590", Offset = "0xA577F90", VA = "0x18A579590", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xA578F70", Offset = "0xA577970", VA = "0x18A578F70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0xA578F70", Offset = "0xA577970", VA = "0x18A578F70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF070", VA = "0x180D00670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xA55FFF0", Offset = "0xA55E9F0", VA = "0x18A55FFF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xA560430", Offset = "0xA55EE30", VA = "0x18A560430", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xA5605B0", Offset = "0xA55EFB0", VA = "0x18A5605B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xA5604B0", Offset = "0xA55EEB0", VA = "0x18A5604B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA55FEA0", Offset = "0xA55E8A0", VA = "0x18A55FEA0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAD0", Offset = "0xA55C4D0", VA = "0x18A55DAD0")]
		internal AccessorSparse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xA560B50", Offset = "0xA55F550", VA = "0x18A560B50")]
		internal AccessorSparse(int sparseCount, BufferView indices, int indicesOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xA560960", Offset = "0xA55F360", VA = "0x18A560960")]
		internal KeyValuePair<IntegerArray, MemoryAccessor> _CreateMemoryAccessors(Accessor baseAccessor)
		{
			return default(KeyValuePair<IntegerArray, MemoryAccessor>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA560250", Offset = "0xA55EC50", VA = "0x18A560250", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xA560020", Offset = "0xA55EA20", VA = "0x18A560020", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xA57A110", Offset = "0xA578B10", VA = "0x18A57A110", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xA577D60", Offset = "0xA576760", VA = "0x18A577D60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xA57A360", Offset = "0xA578D60", VA = "0x18A57A360")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xA579610", Offset = "0xA578010", VA = "0x18A579610", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xA578E30", Offset = "0xA577830", VA = "0x18A578E30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xA578E30", Offset = "0xA577830", VA = "0x18A578E30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x167E2F0", Offset = "0x167CCF0", VA = "0x18167E2F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public DimensionType Dimensions
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xA566A20", Offset = "0xA565420", VA = "0x18A566A20")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xD66FC0", Offset = "0xD659C0", VA = "0x180D66FC0")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5687C0", Offset = "0xA5671C0", VA = "0x18A5687C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xA5688A0", Offset = "0xA5672A0", VA = "0x18A5688A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xA568640", Offset = "0xA567040", VA = "0x18A568640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public BufferView SourceBufferView
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xA568800", Offset = "0xA567200", VA = "0x18A568800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public int ByteOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xA5686F0", Offset = "0xA5670F0", VA = "0x18A5686F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool IsSparse
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x86D1260", Offset = "0x86CFC60", VA = "0x1886D1260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public AttributeFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xA568730", Offset = "0xA567130", VA = "0x18A568730")]
			get
			{
				return default(AttributeFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public (IReadOnlyList<double> Min, IReadOnlyList<double> Max) Bounds
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xA5685A0", Offset = "0xA566FA0", VA = "0x18A5685A0")]
			get
			{
				return default((IReadOnlyList<double>, IReadOnlyList<double>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xA561EB0", Offset = "0xA5608B0", VA = "0x18A561EB0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA562430", Offset = "0xA560E30", VA = "0x18A562430", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA564200", Offset = "0xA562C00", VA = "0x18A564200", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5624E0", Offset = "0xA560EE0", VA = "0x18A5624E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xA561AC0", Offset = "0xA5604C0", VA = "0x18A561AC0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xA561330", Offset = "0xA55FD30", VA = "0x18A561330")]
		public IAccessorArray<Matrix3x2> AsMatrix2x2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xA561410", Offset = "0xA55FE10", VA = "0x18A561410")]
		public IAccessorArray<Matrix4x4> AsMatrix3x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5614F0", Offset = "0xA55FEF0", VA = "0x18A5614F0")]
		public IAccessorArray<Matrix4x4> AsMatrix4x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5615D0", Offset = "0xA55FFD0", VA = "0x18A5615D0")]
		public IAccessorArray<Matrix4x4> AsMatrix4x4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xA561670", Offset = "0xA560070", VA = "0x18A561670")]
		[Obsolete("Use AsMatrix4x4Array instead", true)]
		internal IReadOnlyList<Matrix4x4> AsMatrix4x4ReadOnlyList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xA561850", Offset = "0xA560250", VA = "0x18A561850")]
		public IAccessorArray<Quaternion> AsQuaternionArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xA561710", Offset = "0xA560110", VA = "0x18A561710")]
		public IAccessorArray<float[]> AsMultiArray(int dimensions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5610E0", Offset = "0xA55FAE0", VA = "0x18A5610E0")]
		public IAccessorArray<uint> AsIndicesArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5610A0", Offset = "0xA55FAA0", VA = "0x18A5610A0")]
		public IAccessorArray<uint> AsIndexArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xA5619C0", Offset = "0xA5603C0", VA = "0x18A5619C0")]
		public IAccessorArray<float> AsScalarArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xA561A00", Offset = "0xA560400", VA = "0x18A561A00")]
		public IAccessorArray<Vector2> AsVector2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xA561A40", Offset = "0xA560440", VA = "0x18A561A40")]
		public IAccessorArray<Vector3> AsVector3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA561A80", Offset = "0xA560480", VA = "0x18A561A80")]
		public IAccessorArray<Vector4> AsVector4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x336A3B0", Offset = "0x3368DB0", VA = "0x18336A3B0")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xA560EB0", Offset = "0xA55F8B0", VA = "0x18A560EB0")]
		public IAccessorArray<Vector4> AsColorArray(float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xA564010", Offset = "0xA562A10", VA = "0x18A564010")]
		public ArraySegment<byte> TryGetVertexBytes(int vertexIdx)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xA566A10", Offset = "0xA565410", VA = "0x18A566A10")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xA568470", Offset = "0xA566E70", VA = "0x18A568470")]
		internal Accessor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xA566A20", Offset = "0xA565420", VA = "0x18A566A20")]
		private DimensionType _GetDimensions()
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xA566F30", Offset = "0xA565930", VA = "0x18A566F30")]
		internal bool _TryGetMemoryAccessor([Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xA566C80", Offset = "0xA565680", VA = "0x18A566C80")]
		internal bool _TryGetMemoryAccessor(string name, [Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA563F40", Offset = "0xA562940", VA = "0x18A563F40")]
		public bool TryGetBufferView([Out] BufferView bv)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xA564DE0", Offset = "0xA5637E0", VA = "0x18A564DE0")]
		public void UpdateBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA566B10", Offset = "0xA565510", VA = "0x18A566B10")]
		private void _ResetBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x336B950", Offset = "0x336A350", VA = "0x18336B950")]
		private void _AppendToBounds<T>(T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA566840", Offset = "0xA565240", VA = "0x18A566840")]
		private void _AppendToBounds(params float[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5627F0", Offset = "0xA5611F0", VA = "0x18A5627F0")]
		public void SetDataFrom(Accessor other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xA563D70", Offset = "0xA562770", VA = "0x18A563D70")]
		public void SetZeros(MemoryAccessInfo accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xA563DA0", Offset = "0xA5627A0", VA = "0x18A563DA0")]
		public void SetZeros(int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xA562AC0", Offset = "0xA5614C0", VA = "0x18A562AC0")]
		[Obsolete("Use SetData with AttributeFormat. This will be removed soon.")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xA562BC0", Offset = "0xA5615C0", VA = "0x18A562BC0")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5624B0", Offset = "0xA560EB0", VA = "0x18A5624B0")]
		public void RemoveSparseData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x336AAE0", Offset = "0x33694E0", VA = "0x18336AAE0")]
		public void CreateSparseData<T>(IReadOnlyDictionary<int, T> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5636C0", Offset = "0xA5620C0", VA = "0x18A5636C0")]
		public void SetSparseData(MemoryAccessor sparseIndices, MemoryAccessor sparseValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xA5632F0", Offset = "0xA561CF0", VA = "0x18A5632F0")]
		public void SetSparseData(int sparseCount, BufferView indices, int indicesByteOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesByteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA562E60", Offset = "0xA561860", VA = "0x18A562E60")]
		public void SetIndexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xA563170", Offset = "0xA561B70", VA = "0x18A563170")]
		public void SetIndexData(BufferView buffer, int bufferByteOffset, int itemCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xA5639F0", Offset = "0xA5623F0", VA = "0x18A5639F0")]
		public void SetVertexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xA5638F0", Offset = "0xA5622F0", VA = "0x18A5638F0")]
		[Obsolete("Use SetVertexData with AttributeFormat. This will be removed soon.")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions = DimensionType.VEC3, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xA563C00", Offset = "0xA562600", VA = "0x18A563C00")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xA5622F0", Offset = "0xA560CF0", VA = "0x18A5622F0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xA561EE0", Offset = "0xA5608E0", VA = "0x18A561EE0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xA5654A0", Offset = "0xA563EA0", VA = "0x18A5654A0")]
		internal void ValidateIndices(ValidationContext validate, uint vertexCount, PrimitiveType drawingType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xA565DD0", Offset = "0xA5647D0", VA = "0x18A565DD0")]
		internal static void ValidateVertexAttributes(ValidationContext validate, IReadOnlyDictionary<string, Accessor> attributes, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xA567870", Offset = "0xA566270", VA = "0x18A567870")]
		private void _ValidatePositions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xA567510", Offset = "0xA565F10", VA = "0x18A567510")]
		private void _ValidateNormals(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xA567B90", Offset = "0xA566590", VA = "0x18A567B90")]
		private void _ValidateTangents(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5671F0", Offset = "0xA565BF0", VA = "0x18A5671F0")]
		private void _ValidateJoints(ValidationContext validate, string attributeName, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xA568000", Offset = "0xA566A00", VA = "0x18A568000")]
		private static void _ValidateWeights(ValidationContext validate, Accessor weights0, Accessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5681B0", Offset = "0xA566BB0", VA = "0x18A5681B0")]
		private void _ValidateWeights(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xA565850", Offset = "0xA564250", VA = "0x18A565850")]
		internal void ValidateMatrices4x3(ValidationContext validate, bool mustInvert = true, bool mustDecompose = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xA565230", Offset = "0xA563C30", VA = "0x18A565230")]
		internal void ValidateAnimationInput(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xA565350", Offset = "0xA563D50", VA = "0x18A565350")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xA57A050", Offset = "0xA578A50", VA = "0x18A57A050", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xA576D40", Offset = "0xA575740", VA = "0x18A576D40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xA57A590", Offset = "0xA578F90", VA = "0x18A57A590")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xA579510", Offset = "0xA577F10", VA = "0x18A579510", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA579290", Offset = "0xA577C90", VA = "0x18A579290", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA579290", Offset = "0xA577C90", VA = "0x18A579290", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0400", VA = "0x180CF1A00")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA568BF0", Offset = "0xA5675F0", VA = "0x18A568BF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xA568D00", Offset = "0xA567700", VA = "0x18A568D00", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xA568E50", Offset = "0xA567850", VA = "0x18A568E50", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xA568D80", Offset = "0xA567780", VA = "0x18A568D80", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xA5688E0", Offset = "0xA5672E0", VA = "0x18A5688E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAD0", Offset = "0xA55C4D0", VA = "0x18A55DAD0")]
		internal AnimationChannelTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA569100", Offset = "0xA567B00", VA = "0x18A569100")]
		internal AnimationChannelTarget(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA569190", Offset = "0xA567B90", VA = "0x18A569190")]
		internal AnimationChannelTarget(string pointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0", Slot = "17")]
		void IChildOf<AnimationChannel>.SetLogicalParent(AnimationChannel parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA5689D0", Offset = "0xA5673D0", VA = "0x18A5689D0")]
		public int GetNodeIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA568A80", Offset = "0xA567480", VA = "0x18A568A80")]
		public PropertyPath GetNodePath()
		{
			return default(PropertyPath);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA568AF0", Offset = "0xA5674F0", VA = "0x18A568AF0")]
		public string GetPointerPath()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA568C20", Offset = "0xA567620", VA = "0x18A568C20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xA5798D0", Offset = "0xA5782D0", VA = "0x18A5798D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0xA578570", Offset = "0xA576F70", VA = "0x18A578570", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0xA57A270", Offset = "0xA578C70", VA = "0x18A57A270")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0xA579490", Offset = "0xA577E90", VA = "0x18A579490", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0xA5790B0", Offset = "0xA577AB0", VA = "0x18A5790B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xA5790B0", Offset = "0xA577AB0", VA = "0x18A5790B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFAD50", Offset = "0xCF9750", VA = "0x180CFAD50", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xCFAF30", Offset = "0xCF9930", VA = "0x180CFAF30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF2F30", VA = "0x180CF4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public string TargetPointerPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0xA56A020", Offset = "0xA568A20", VA = "0x18A56A020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public Node TargetNode
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0xA569EA0", Offset = "0xA5688A0", VA = "0x18A569EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public PropertyPath TargetNodePath
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xA569E20", Offset = "0xA568820", VA = "0x18A569E20")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA569420", Offset = "0xA567E20", VA = "0x18A569420", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xA569590", Offset = "0xA567F90", VA = "0x18A569590", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA5697E0", Offset = "0xA5681E0", VA = "0x18A5697E0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xA569610", Offset = "0xA568010", VA = "0x18A569610", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA5692A0", Offset = "0xA567CA0", VA = "0x18A5692A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA569BE0", Offset = "0xA5685E0", VA = "0x18A569BE0")]
		internal AnimationChannel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xA569CD0", Offset = "0xA5686D0", VA = "0x18A569CD0")]
		internal AnimationChannel(string pointerPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xA569BF0", Offset = "0xA5685F0", VA = "0x18A569BF0")]
		internal AnimationChannel(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xA5696D0", Offset = "0xA5680D0", VA = "0x18A5696D0")]
		internal void SetSampler(AnimationSampler sampler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xA5697B0", Offset = "0xA5681B0", VA = "0x18A5697B0", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xA569B50", Offset = "0xA568550", VA = "0x18A569B50")]
		private void _SetChannelTarget(AnimationChannelTarget target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x338CFA0", Offset = "0x338B9A0", VA = "0x18338CFA0")]
		public IAnimationSampler<T> GetSamplerOrNull<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA569A90", Offset = "0xA568490", VA = "0x18A569A90")]
		internal AnimationSampler _GetSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xA5693F0", Offset = "0xA567DF0", VA = "0x18A5693F0")]
		public IAnimationSampler<Vector3> GetScaleSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA5693C0", Offset = "0xA567DC0", VA = "0x18A5693C0")]
		public IAnimationSampler<Quaternion> GetRotationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA569450", Offset = "0xA567E50", VA = "0x18A569450")]
		public IAnimationSampler<Vector3> GetTranslationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA569390", Offset = "0xA567D90", VA = "0x18A569390")]
		public IAnimationSampler<SparseWeight8> GetSparseMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA569390", Offset = "0xA567D90", VA = "0x18A569390")]
		public IAnimationSampler<float[]> GetMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xA569480", Offset = "0xA567E80", VA = "0x18A569480", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xA591C00", Offset = "0xA590600", VA = "0x18A591C00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0xA58F200", Offset = "0xA58DC00", VA = "0x18A58F200", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5923D0", Offset = "0xA590DD0", VA = "0x18A5923D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xA591740", Offset = "0xA590140", VA = "0x18A591740", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0xA5915E0", Offset = "0xA58FFE0", VA = "0x18A5915E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0xA5915E0", Offset = "0xA58FFE0", VA = "0x18A5915E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7490", VA = "0x1812B8A90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x64E1080", Offset = "0x64DFA80", VA = "0x1864E1080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B87B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <_GroupByTangentValueTangent>d__84(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x7197BF0", Offset = "0x71965F0", VA = "0x187197BF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x7197430", Offset = "0x7195E30", VA = "0x187197430", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x7197D20", Offset = "0x7196720", VA = "0x187197D20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x69CB230", Offset = "0x69C9C30", VA = "0x1869CB230", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(T, T, T)> IEnumerable<(T, T, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x7197890", Offset = "0x7196290", VA = "0x187197890", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1D990", VA = "0x180D1EF90", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xDE9880", Offset = "0xDE8280", VA = "0x180DE9880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public AnimationInterpolationMode InterpolationMode
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0xA571540", Offset = "0xA56FF40", VA = "0x18A571540", Slot = "51")]
			get
			{
				return default(AnimationInterpolationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0xA5715E0", Offset = "0xA56FFE0", VA = "0x18A5715E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public Accessor Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xA5714E0", Offset = "0xA56FEE0", VA = "0x18A5714E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public Accessor Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xA571580", Offset = "0xA56FF80", VA = "0x18A571580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0xA5713D0", Offset = "0xA56FDD0", VA = "0x18A5713D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xA56A280", Offset = "0xA568C80", VA = "0x18A56A280", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xA56A9A0", Offset = "0xA5693A0", VA = "0x18A56A9A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA56FBB0", Offset = "0xA56E5B0", VA = "0x18A56FBB0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xA56AA20", Offset = "0xA569420", VA = "0x18A56AA20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA56A130", Offset = "0xA568B30", VA = "0x18A56A130", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA5712D0", Offset = "0xA56FCD0", VA = "0x18A5712D0")]
		internal AnimationSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xA571340", Offset = "0xA56FD40", VA = "0x18A571340")]
		internal AnimationSampler(AnimationInterpolationMode interpolation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xA56BC80", Offset = "0xA56A680", VA = "0x18A56BC80", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xA56FF30", Offset = "0xA56E930", VA = "0x18A56FF30")]
		private Accessor _CreateInputAccessor(IReadOnlyList<float> input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xA570180", Offset = "0xA56EB80", VA = "0x18A570180")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<bool> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xA5703B0", Offset = "0xA56EDB0", VA = "0x18A5703B0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xA570850", Offset = "0xA56F250", VA = "0x18A570850")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector2> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xA570AA0", Offset = "0xA56F4A0", VA = "0x18A570AA0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector3> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xA570600", Offset = "0xA56F000", VA = "0x18A570600")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector4> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xA570F90", Offset = "0xA56F990", VA = "0x18A570F90")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Quaternion> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xA5711C0", Offset = "0xA56FBC0", VA = "0x18A5711C0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<SparseWeight8> output, int itemsStride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x338DDB0", Offset = "0x338C7B0", VA = "0x18338DDB0")]
		private Accessor _CreateOutputAccessor<T>(IReadOnlyList<T> output, int itemsStride) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xA570CF0", Offset = "0xA56F6F0", VA = "0x18A570CF0")]
		private Accessor _CreateOutputAccessor(int itemCount, int itemsStride, Func<int, int, float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x338E7A0", Offset = "0x338D1A0", VA = "0x18338E7A0")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, TValue> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x338E3A0", Offset = "0x338CDA0", VA = "0x18338E3A0")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, (TValue TangentIn, TValue Value, TValue TangentOut)> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xA56B770", Offset = "0xA56A170", VA = "0x18A56B770")]
		internal void SetKeys(IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA56B670", Offset = "0xA56A070", VA = "0x18A56B670")]
		internal void SetKeys(IReadOnlyDictionary<float, float> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xA56BA80", Offset = "0xA56A480", VA = "0x18A56BA80")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector2> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA56BB80", Offset = "0xA56A580", VA = "0x18A56BB80")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector3> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xA56B570", Offset = "0xA569F70", VA = "0x18A56B570")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector4> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xA56B980", Offset = "0xA56A380", VA = "0x18A56B980")]
		internal void SetKeys(IReadOnlyDictionary<float, Quaternion> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x338D560", Offset = "0x338BF60", VA = "0x18338D560")]
		internal void SetKeys<TWeights>(IReadOnlyDictionary<float, TWeights> keyframes, int itemsStride) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA56B870", Offset = "0xA56A270", VA = "0x18A56B870")]
		internal void SetKeys(IReadOnlyDictionary<float, SparseWeight8> keyframes, int itemsStride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA56B1D0", Offset = "0xA569BD0", VA = "0x18A56B1D0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (float TangentIn, float Value, float TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xA56B380", Offset = "0xA569D80", VA = "0x18A56B380")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector2 TangentIn, Vector2 Value, Vector2 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA56AD30", Offset = "0xA569730", VA = "0x18A56AD30")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xA56AB50", Offset = "0xA569550", VA = "0x18A56AB50")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector4 TangentIn, Vector4 Value, Vector4 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA56B0A0", Offset = "0xA569AA0", VA = "0x18A56B0A0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x338D190", Offset = "0x338BB90", VA = "0x18338D190")]
		internal void SetCubicKeys<TWeights>(IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int expandedCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xA56AF10", Offset = "0xA569910", VA = "0x18A56AF10")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int expandedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xA56CE40", Offset = "0xA56B840", VA = "0x18A56CE40", Slot = "20")]
		IEnumerable<(float, bool)> IAnimationSampler<bool>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA56F0A0", Offset = "0xA56DAA0", VA = "0x18A56F0A0", Slot = "24")]
		IEnumerable<(float, float)> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA56DC00", Offset = "0xA56C600", VA = "0x18A56DC00", Slot = "28")]
		IEnumerable<(float, Vector2)> IAnimationSampler<Vector2>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA56E2E0", Offset = "0xA56CCE0", VA = "0x18A56E2E0", Slot = "32")]
		IEnumerable<(float, Vector3)> IAnimationSampler<Vector3>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA56E9C0", Offset = "0xA56D3C0", VA = "0x18A56E9C0", Slot = "36")]
		IEnumerable<(float, Vector4)> IAnimationSampler<Vector4>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA56D540", Offset = "0xA56BF40", VA = "0x18A56D540", Slot = "40")]
		IEnumerable<(float, Quaternion)> IAnimationSampler<Quaternion>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA56C170", Offset = "0xA56AB70", VA = "0x18A56C170", Slot = "44")]
		IEnumerable<(float, SparseWeight8)> IAnimationSampler<SparseWeight8>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA56C9B0", Offset = "0xA56B3B0", VA = "0x18A56C9B0", Slot = "48")]
		IEnumerable<(float, ArraySegment<float>)> IAnimationSampler<ArraySegment<float>>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xA56F830", Offset = "0xA56E230", VA = "0x18A56F830", Slot = "52")]
		IEnumerable<(float, float[])> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA56CE00", Offset = "0xA56B800", VA = "0x18A56CE00", Slot = "21")]
		IEnumerable<(float, (bool, bool, bool))> IAnimationSampler<bool>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xA56EDB0", Offset = "0xA56D7B0", VA = "0x18A56EDB0", Slot = "25")]
		IEnumerable<(float, (float, float, float))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA56D910", Offset = "0xA56C310", VA = "0x18A56D910", Slot = "29")]
		IEnumerable<(float, (Vector2, Vector2, Vector2))> IAnimationSampler<Vector2>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xA56DFF0", Offset = "0xA56C9F0", VA = "0x18A56DFF0", Slot = "33")]
		IEnumerable<(float, (Vector3, Vector3, Vector3))> IAnimationSampler<Vector3>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA56E6D0", Offset = "0xA56D0D0", VA = "0x18A56E6D0", Slot = "37")]
		IEnumerable<(float, (Vector4, Vector4, Vector4))> IAnimationSampler<Vector4>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xA56D270", Offset = "0xA56BC70", VA = "0x18A56D270", Slot = "41")]
		IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> IAnimationSampler<Quaternion>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA56F490", Offset = "0xA56DE90", VA = "0x18A56F490", Slot = "53")]
		IEnumerable<(float, (float[], float[], float[]))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA56C610", Offset = "0xA56B010", VA = "0x18A56C610", Slot = "49")]
		IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> IAnimationSampler<ArraySegment<float>>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xA56BDD0", Offset = "0xA56A7D0", VA = "0x18A56BDD0", Slot = "45")]
		IEnumerable<(float, (SparseWeight8, SparseWeight8, SparseWeight8))> IAnimationSampler<SparseWeight8>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xA56CD30", Offset = "0xA56B730", VA = "0x18A56CD30", Slot = "22")]
		ICurveSampler<bool> IAnimationSampler<bool>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA56EC90", Offset = "0xA56D690", VA = "0x18A56EC90", Slot = "26")]
		ICurveSampler<float> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA56D7F0", Offset = "0xA56C1F0", VA = "0x18A56D7F0", Slot = "30")]
		ICurveSampler<Vector2> IAnimationSampler<Vector2>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA56DED0", Offset = "0xA56C8D0", VA = "0x18A56DED0", Slot = "34")]
		ICurveSampler<Vector3> IAnimationSampler<Vector3>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xA56E5B0", Offset = "0xA56CFB0", VA = "0x18A56E5B0", Slot = "38")]
		ICurveSampler<Vector4> IAnimationSampler<Vector4>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xA56D150", Offset = "0xA56BB50", VA = "0x18A56D150", Slot = "42")]
		ICurveSampler<Quaternion> IAnimationSampler<Quaternion>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xA56BCB0", Offset = "0xA56A6B0", VA = "0x18A56BCB0", Slot = "46")]
		ICurveSampler<SparseWeight8> IAnimationSampler<SparseWeight8>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xA56F370", Offset = "0xA56DD70", VA = "0x18A56F370", Slot = "54")]
		ICurveSampler<float[]> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xA56C4F0", Offset = "0xA56AEF0", VA = "0x18A56C4F0", Slot = "50")]
		ICurveSampler<ArraySegment<float>> IAnimationSampler<ArraySegment<float>>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x338E160", Offset = "0x338CB60", VA = "0x18338E160")]
		[IteratorStateMachine(typeof(<_GroupByTangentValueTangent>d__84<>))]
		private static IEnumerable<(T, T, T)> _GroupByTangentValueTangent<T>(IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xA56A7E0", Offset = "0xA5691E0", VA = "0x18A56A7E0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xA56A2B0", Offset = "0xA568CB0", VA = "0x18A56A2B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xA591FC0", Offset = "0xA5909C0", VA = "0x18A591FC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0xA58F820", Offset = "0xA58E220", VA = "0x18A58F820", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xA592600", Offset = "0xA591000", VA = "0x18A592600")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0xA591680", Offset = "0xA590080", VA = "0x18A591680", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0xA591180", Offset = "0xA58FB80", VA = "0x18A591180", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xA591180", Offset = "0xA58FB80", VA = "0x18A591180", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2DA0", VA = "0x180CF43A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public IReadOnlyList<AnimationChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0xA57D960", Offset = "0xA57C360", VA = "0x18A57D960")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA57CDD0", Offset = "0xA57B7D0", VA = "0x18A57CDD0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xA57CF50", Offset = "0xA57B950", VA = "0x18A57CF50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xA57D0E0", Offset = "0xA57BAE0", VA = "0x18A57D0E0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xA57CFD0", Offset = "0xA57B9D0", VA = "0x18A57CFD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xA57C920", Offset = "0xA57B320", VA = "0x18A57C920", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xA57D890", Offset = "0xA57C290", VA = "0x18A57D890")]
		internal Animation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA57CB80", Offset = "0xA57B580", VA = "0x18A57CB80")]
		public IEnumerable<AnimationChannel> FindChannels(string rootPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA57CA10", Offset = "0xA57B410", VA = "0x18A57CA10")]
		public IEnumerable<AnimationChannel> FindChannels(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA57CDB0", Offset = "0xA57B7B0", VA = "0x18A57CDB0")]
		public AnimationChannel FindScaleChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA57CDA0", Offset = "0xA57B7A0", VA = "0x18A57CDA0")]
		public AnimationChannel FindRotationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA57CDC0", Offset = "0xA57B7C0", VA = "0x18A57CDC0")]
		public AnimationChannel FindTranslationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA57CD90", Offset = "0xA57B790", VA = "0x18A57CD90")]
		public AnimationChannel FindMorphChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA57D400", Offset = "0xA57BE00", VA = "0x18A57D400")]
		private AnimationChannel _FindChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA57D370", Offset = "0xA57BD70", VA = "0x18A57D370")]
		private AnimationSampler _CreateSampler(AnimationInterpolationMode interpolation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA57D6B0", Offset = "0xA57C0B0", VA = "0x18A57D6B0")]
		private AnimationChannel _UseChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA57D620", Offset = "0xA57C020", VA = "0x18A57D620")]
		private AnimationChannel _UseChannel(string pointerPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x338EAE0", Offset = "0x338D4E0", VA = "0x18338EAE0")]
		public void CreateMaterialPropertyChannel<T>(Material material, string propertyName, IReadOnlyDictionary<float, T> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x338F7B0", Offset = "0x338E1B0", VA = "0x18338F7B0")]
		public void DangerousCreatePointerChannel<T>(string pointerPath, IReadOnlyDictionary<float, T> keyframes, bool linear = true, bool verifyBackingFieldExists = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xA57C290", Offset = "0xA57AC90", VA = "0x18A57C290")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA57C120", Offset = "0xA57AB20", VA = "0x18A57C120")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA57BE30", Offset = "0xA57A830", VA = "0x18A57BE30")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, Quaternion> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xA57BFB0", Offset = "0xA57A9B0", VA = "0x18A57BFB0")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA57C410", Offset = "0xA57AE10", VA = "0x18A57C410")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xA57C590", Offset = "0xA57AF90", VA = "0x18A57C590")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x338EF00", Offset = "0x338D900", VA = "0x18338EF00")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, TWeights> keyframes, int morphCount, bool linear = true) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x338EC80", Offset = "0x338D680", VA = "0x18338EC80")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int morphCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA57BCB0", Offset = "0xA57A6B0", VA = "0x18A57BCB0")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, SparseWeight8> keyframes, int morphCount, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xA57BB30", Offset = "0xA57A530", VA = "0x18A57BB30")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int morphCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xA57C700", Offset = "0xA57B100", VA = "0x18A57C700")]
		public void CreateVisibilityChannel(Node node, IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xA57CE30", Offset = "0xA57B830", VA = "0x18A57CE30", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xA57CE00", Offset = "0xA57B800", VA = "0x18A57CE00", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0xA591F00", Offset = "0xA590900", VA = "0x18A591F00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0xA58FD60", Offset = "0xA58E760", VA = "0x18A58FD60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0xA5926A0", Offset = "0xA5910A0", VA = "0x18A5926A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0xA591700", Offset = "0xA590100", VA = "0x18A591700", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xA591360", Offset = "0xA58FD60", VA = "0x18A591360", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xA591360", Offset = "0xA58FD60", VA = "0x18A591360", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2DA0", VA = "0x180CF43A0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2D70", VA = "0x180CF4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public static string AssemblyInformationalVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xA57E730", Offset = "0xA57D130", VA = "0x18A57E730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public string Copyright
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0xA57E920", Offset = "0xA57D320", VA = "0x18A57E920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public string Generator
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xA57E950", Offset = "0xA57D350", VA = "0x18A57E950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Version Version
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0xA57E8A0", Offset = "0xA57D2A0", VA = "0x18A57E8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Version MinVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xA57E820", Offset = "0xA57D220", VA = "0x18A57E820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA57DDC0", Offset = "0xA57C7C0", VA = "0x18A57DDC0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA57DFF0", Offset = "0xA57C9F0", VA = "0x18A57DFF0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA57E130", Offset = "0xA57CB30", VA = "0x18A57E130", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xA57E070", Offset = "0xA57CA70", VA = "0x18A57E070", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA57DCA0", Offset = "0xA57C6A0", VA = "0x18A57DCA0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAD0", Offset = "0xA55C4D0", VA = "0x18A55DAD0")]
		internal Asset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xA57DA80", Offset = "0xA57C480", VA = "0x18A57DA80")]
		internal static Asset CreateDefault(string copyright)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2D70", VA = "0x180CF4370", Slot = "17")]
		void IChildOf<ModelRoot>.SetLogicalParent(ModelRoot parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA57DDF0", Offset = "0xA57C7F0", VA = "0x18A57DDF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0xA591E40", Offset = "0xA590840", VA = "0x18A591E40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xA590840", Offset = "0xA58F240", VA = "0x18A590840", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xA5925B0", Offset = "0xA590FB0", VA = "0x18A5925B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xA5918C0", Offset = "0xA5902C0", VA = "0x18A5918C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xA5910E0", Offset = "0xA58FAE0", VA = "0x18A5910E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0xA5910E0", Offset = "0xA58FAE0", VA = "0x18A5910E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2CE0", VA = "0x180CF42E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA580FC0", Offset = "0xA57F9C0", VA = "0x18A580FC0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA5813F0", Offset = "0xA57FDF0", VA = "0x18A5813F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA581520", Offset = "0xA57FF20", VA = "0x18A581520", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xA581470", Offset = "0xA57FE70", VA = "0x18A581470", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xA580ED0", Offset = "0xA57F8D0", VA = "0x18A580ED0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xA581CC0", Offset = "0xA5806C0", VA = "0x18A581CC0")]
		internal Buffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xA581CD0", Offset = "0xA5806D0", VA = "0x18A581CD0")]
		internal Buffer(byte[] content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0xA581A00", Offset = "0xA580400", VA = "0x18A581A00")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xA581880", Offset = "0xA580280", VA = "0x18A581880")]
		private static byte[] _LoadBinaryBufferUnchecked(string uri, ReadContext context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xA581BF0", Offset = "0xA5805F0", VA = "0x18A581BF0")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xA581BB0", Offset = "0xA5805B0", VA = "0x18A581BB0")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xA5817D0", Offset = "0xA5801D0", VA = "0x18A5817D0")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xA581800", Offset = "0xA580200", VA = "0x18A581800")]
		internal void _IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xA580FF0", Offset = "0xA57F9F0", VA = "0x18A580FF0")]
		internal void OnValidateBinaryChunk(ValidationContext validate, byte[] binaryChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xA581340", Offset = "0xA57FD40", VA = "0x18A581340", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xA581210", Offset = "0xA57FC10", VA = "0x18A581210", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA5919C0", Offset = "0xA5903C0", VA = "0x18A5919C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0xA58E710", Offset = "0xA58D110", VA = "0x18A58E710", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA5924C0", Offset = "0xA590EC0", VA = "0x18A5924C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA591880", Offset = "0xA590280", VA = "0x18A591880", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0xA591400", Offset = "0xA58FE00", VA = "0x18A591400", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0xA591400", Offset = "0xA58FE00", VA = "0x18A591400", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA580E90", Offset = "0xA57F890", VA = "0x18A580E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public bool IsIndexBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0xA580E50", Offset = "0xA57F850", VA = "0x18A580E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public bool IsDataBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA580E10", Offset = "0xA57F810", VA = "0x18A580E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xA580D00", Offset = "0xA57F700", VA = "0x18A580D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public ArraySegment<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA580D40", Offset = "0xA57F740", VA = "0x18A580D40")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		internal int LogicalBufferIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1D990", VA = "0x180D1EF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA57EF30", Offset = "0xA57D930", VA = "0x18A57EF30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA57F790", Offset = "0xA57E190", VA = "0x18A57F790", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA57F990", Offset = "0xA57E390", VA = "0x18A57F990", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA57F810", Offset = "0xA57E210", VA = "0x18A57F810", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xA57EB20", Offset = "0xA57D520", VA = "0x18A57EB20", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA5807B0", Offset = "0xA57F1B0", VA = "0x18A5807B0")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA580CA0", Offset = "0xA57F6A0", VA = "0x18A580CA0")]
		internal BufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA5808F0", Offset = "0xA57F2F0", VA = "0x18A5808F0")]
		internal BufferView(Buffer buffer, int byteOffset, int? byteLength, int byteStride, BufferMode? target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xA57EDB0", Offset = "0xA57D7B0", VA = "0x18A57EDB0")]
		public IEnumerable<Image> FindImages()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0xA57ECE0", Offset = "0xA57D6E0", VA = "0x18A57ECE0")]
		public IEnumerable<Accessor> FindAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA5807C0", Offset = "0xA57F1C0", VA = "0x18A5807C0")]
		internal void _IsolateBufferMemory(_StaticBufferBuilder targetBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA57EF60", Offset = "0xA57D960", VA = "0x18A57EF60")]
		public bool IsInterleaved(IEnumerable<Accessor> accessors)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xA57E980", Offset = "0xA57D380", VA = "0x18A57E980")]
		internal static bool AreEqual(BufferView bv, ArraySegment<byte> content, int byteStride, BufferMode? target)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA57EE80", Offset = "0xA57D880", VA = "0x18A57EE80")]
		internal static int GetAccessorByteLength([In] AttributeFormat fmt, int count, BufferView bv)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA5801D0", Offset = "0xA57EBD0", VA = "0x18A5801D0")]
		internal static void VerifyAccess(ValidationContext validate, BufferView bv, int accessorByteOffset, AttributeFormat format, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xA57F3D0", Offset = "0xA57DDD0", VA = "0x18A57F3D0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xA57F200", Offset = "0xA57DC00", VA = "0x18A57F200", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA57FF70", Offset = "0xA57E970", VA = "0x18A57FF70")]
		internal void ValidateBufferUsageGPU(ValidationContext validate, BufferMode usingMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA580070", Offset = "0xA57EA70", VA = "0x18A580070")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA591D80", Offset = "0xA590780", VA = "0x18A591D80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xA58F500", Offset = "0xA58DF00", VA = "0x18A58F500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xA5926F0", Offset = "0xA5910F0", VA = "0x18A5926F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xA5917C0", Offset = "0xA5901C0", VA = "0x18A5917C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xA590F00", Offset = "0xA58F900", VA = "0x18A590F00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xA590F00", Offset = "0xA58F900", VA = "0x18A590F00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool IsOrthographic
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public float XMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xA5828D0", Offset = "0xA5812D0", VA = "0x18A5828D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public float YMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xA5828E0", Offset = "0xA5812E0", VA = "0x18A5828E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xA582900", Offset = "0xA581300", VA = "0x18A582900")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xA5828F0", Offset = "0xA5812F0", VA = "0x18A5828F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xA582860", Offset = "0xA581260", VA = "0x18A582860", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xA581E30", Offset = "0xA580830", VA = "0x18A581E30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA581F10", Offset = "0xA580910", VA = "0x18A581F10", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA582150", Offset = "0xA580B50", VA = "0x18A582150", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xA581F90", Offset = "0xA580990", VA = "0x18A581F90", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xA581D10", Offset = "0xA580710", VA = "0x18A581D10", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAD0", Offset = "0xA55C4D0", VA = "0x18A55DAD0")]
		internal CameraOrthographic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA5827E0", Offset = "0xA5811E0", VA = "0x18A5827E0")]
		internal CameraOrthographic(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA582670", Offset = "0xA581070", VA = "0x18A582670")]
		public static void VerifyParameters(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA581E60", Offset = "0xA580860", VA = "0x18A581E60", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xA591B40", Offset = "0xA590540", VA = "0x18A591B40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xA5902D0", Offset = "0xA58ECD0", VA = "0x18A5902D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xA592510", Offset = "0xA590F10", VA = "0x18A592510")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xA591780", Offset = "0xA590180", VA = "0x18A591780", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xA591040", Offset = "0xA58FA40", VA = "0x18A591040", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0xA591040", Offset = "0xA58FA40", VA = "0x18A591040", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public bool IsPerspective
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public float? AspectRatio
		{
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xA583520", Offset = "0xA581F20", VA = "0x18A583520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public float VerticalFOV
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xA5828F0", Offset = "0xA5812F0", VA = "0x18A5828F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x9C380A0", Offset = "0x9C36AA0", VA = "0x189C380A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xA5836E0", Offset = "0xA5820E0", VA = "0x18A5836E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0xA5835B0", Offset = "0xA581FB0", VA = "0x18A5835B0", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA582A50", Offset = "0xA581450", VA = "0x18A582A50", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA582B30", Offset = "0xA581530", VA = "0x18A582B30", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA582D40", Offset = "0xA581740", VA = "0x18A582D40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA582BB0", Offset = "0xA5815B0", VA = "0x18A582BB0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA582910", Offset = "0xA581310", VA = "0x18A582910", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAD0", Offset = "0xA55C4D0", VA = "0x18A55DAD0")]
		internal CameraPerspective()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5833D0", Offset = "0xA581DD0", VA = "0x18A5833D0")]
		internal CameraPerspective(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xA583270", Offset = "0xA581C70", VA = "0x18A583270")]
		public static void VerifyParameters(float? aspectRatio, float yfov, float znear, float zfar = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA582A80", Offset = "0xA581480", VA = "0x18A582A80", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0xA592200", Offset = "0xA590C00", VA = "0x18A592200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xA58EA90", Offset = "0xA58D490", VA = "0x18A58EA90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xA592380", Offset = "0xA590D80", VA = "0x18A592380")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xA591800", Offset = "0xA590200", VA = "0x18A591800", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0xA590E60", Offset = "0xA58F860", VA = "0x18A590E60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xA590E60", Offset = "0xA58F860", VA = "0x18A590E60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5843D0", Offset = "0xA582DD0", VA = "0x18A5843D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0xA5842E0", Offset = "0xA582CE0", VA = "0x18A5842E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA583910", Offset = "0xA582310", VA = "0x18A583910", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA583AE0", Offset = "0xA5824E0", VA = "0x18A583AE0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA583F30", Offset = "0xA582930", VA = "0x18A583F30", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA583B60", Offset = "0xA582560", VA = "0x18A583B60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA583740", Offset = "0xA582140", VA = "0x18A583740", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA581CC0", Offset = "0xA5806C0", VA = "0x18A581CC0")]
		internal Camera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA583880", Offset = "0xA582280", VA = "0x18A583880")]
		internal ICamera GetCamera()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA583C70", Offset = "0xA582670", VA = "0x18A583C70")]
		public void SetOrthographicMode(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xA583D70", Offset = "0xA582770", VA = "0x18A583D70")]
		public void SetPerspectiveMode(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xA583940", Offset = "0xA582340", VA = "0x18A583940", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0xA591CC0", Offset = "0xA5906C0", VA = "0x18A591CC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xA58FAC0", Offset = "0xA58E4C0", VA = "0x18A58FAC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0xA592740", Offset = "0xA591140", VA = "0x18A592740")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xA5916C0", Offset = "0xA5900C0", VA = "0x18A5916C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xA5914A0", Offset = "0xA58FEA0", VA = "0x18A5914A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0xA5914A0", Offset = "0xA58FEA0", VA = "0x18A5914A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public int LogicalTextureIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF070", VA = "0x180D00670")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0xD45780", Offset = "0xD44180", VA = "0x180D45780")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA58DE10", Offset = "0xA58C810", VA = "0x18A58DE10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0xA58DE90", Offset = "0xA58C890", VA = "0x18A58DE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public TextureTransform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA58DE50", Offset = "0xA58C850", VA = "0x18A58DE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA58D750", Offset = "0xA58C150", VA = "0x18A58D750", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA58D890", Offset = "0xA58C290", VA = "0x18A58D890", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA58DB00", Offset = "0xA58C500", VA = "0x18A58DB00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA58D910", Offset = "0xA58C310", VA = "0x18A58D910", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA58D660", Offset = "0xA58C060", VA = "0x18A58D660", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA58DDB0", Offset = "0xA58C7B0", VA = "0x18A58DDB0")]
		public TextureInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA58D9F0", Offset = "0xA58C3F0", VA = "0x18A58D9F0")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA58D780", Offset = "0xA58C180", VA = "0x18A58D780", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA58E6B0", Offset = "0xA58D0B0", VA = "0x18A58E6B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <GetChannels>d__32(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA58DEF0", Offset = "0xA58C8F0", VA = "0x18A58DEF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA58E670", Offset = "0xA58D070", VA = "0x18A58E670", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA58E5C0", Offset = "0xA58CFC0", VA = "0x18A58E5C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA58E5C0", Offset = "0xA58CFC0", VA = "0x18A58E5C0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xA592080", Offset = "0xA590A80", VA = "0x18A592080", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xA590AE0", Offset = "0xA58F4E0", VA = "0x18A590AE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xA592470", Offset = "0xA590E70", VA = "0x18A592470")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0xA591940", Offset = "0xA590340", VA = "0x18A591940", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0xA5912C0", Offset = "0xA58FCC0", VA = "0x18A5912C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0xA5912C0", Offset = "0xA58FCC0", VA = "0x18A5912C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEE740", Offset = "0xCED140", VA = "0x180CEE740", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xA585BE0", Offset = "0xA5845E0", VA = "0x18A585BE0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0xA585CA0", Offset = "0xA5846A0", VA = "0x18A585CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public float MetallicFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA585E10", Offset = "0xA584810", VA = "0x18A585E10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0xA585E70", Offset = "0xA584870", VA = "0x18A585E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA585EE0", Offset = "0xA5848E0", VA = "0x18A585EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0xA585F40", Offset = "0xA584940", VA = "0x18A585F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA585060", Offset = "0xA583A60", VA = "0x18A585060", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5852C0", Offset = "0xA583CC0", VA = "0x18A5852C0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA585570", Offset = "0xA583F70", VA = "0x18A585570", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA585340", Offset = "0xA583D40", VA = "0x18A585340", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA584E30", Offset = "0xA583830", VA = "0x18A584E30", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xCEE750", Offset = "0xCED150", VA = "0x180CEE750", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA585090", Offset = "0xA583A90", VA = "0x18A585090", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xA584FD0", Offset = "0xA5839D0", VA = "0x18A584FD0")]
		[IteratorStateMachine(typeof(<GetChannels>d__32))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA586000", Offset = "0xA584A00", VA = "0x18A586000")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083A")]
			[Cpp2IlInjected.Address(RVA = "0xA5922C0", Offset = "0xA590CC0", VA = "0x18A5922C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083B")]
			[Cpp2IlInjected.Address(RVA = "0xA590080", Offset = "0xA58EA80", VA = "0x18A590080", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600083C")]
			[Cpp2IlInjected.Address(RVA = "0xA592420", Offset = "0xA590E20", VA = "0x18A592420")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xA591840", Offset = "0xA590240", VA = "0x18A591840", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0xA590FA0", Offset = "0xA58F9A0", VA = "0x18A590FA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xA590FA0", Offset = "0xA58F9A0", VA = "0x18A590FA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD9A780", Offset = "0xD99180", VA = "0x180D9A780")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public float Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0xA584840", Offset = "0xA583240", VA = "0x18A584840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0xA5848A0", Offset = "0xA5832A0", VA = "0x18A5848A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xA584480", Offset = "0xA582E80", VA = "0x18A584480", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xA5844B0", Offset = "0xA582EB0", VA = "0x18A5844B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA5845F0", Offset = "0xA582FF0", VA = "0x18A5845F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA584530", Offset = "0xA582F30", VA = "0x18A584530", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA5843E0", Offset = "0xA582DE0", VA = "0x18A5843E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA5847A0", Offset = "0xA5831A0", VA = "0x18A5847A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xA592140", Offset = "0xA590B40", VA = "0x18A592140", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA5905F0", Offset = "0xA58EFF0", VA = "0x18A5905F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA592560", Offset = "0xA590F60", VA = "0x18A592560")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0xA591900", Offset = "0xA590300", VA = "0x18A591900", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xA591220", Offset = "0xA58FC20", VA = "0x18A591220", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xA591220", Offset = "0xA58FC20", VA = "0x18A591220", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD9A780", Offset = "0xD99180", VA = "0x180D9A780")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public float Strength
		{
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0xA584D60", Offset = "0xA583760", VA = "0x18A584D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xA584DC0", Offset = "0xA5837C0", VA = "0x18A584DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA5849B0", Offset = "0xA5833B0", VA = "0x18A5849B0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA5849E0", Offset = "0xA5833E0", VA = "0x18A5849E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA584B20", Offset = "0xA583520", VA = "0x18A584B20", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA584A60", Offset = "0xA583460", VA = "0x18A584A60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA584910", Offset = "0xA583310", VA = "0x18A584910", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA584CC0", Offset = "0xA5836C0", VA = "0x18A584CC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA591A80", Offset = "0xA590480", VA = "0x18A591A80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA58ED90", Offset = "0xA58D790", VA = "0x18A58ED90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xA592650", Offset = "0xA591050", VA = "0x18A592650")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xA591980", Offset = "0xA590380", VA = "0x18A591980", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xA591540", Offset = "0xA58FF40", VA = "0x18A591540", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xA591540", Offset = "0xA58FF40", VA = "0x18A591540", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x10EC0A0", Offset = "0x10EAAA0", VA = "0x1810EC0A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA595BE0", Offset = "0xA5945E0", VA = "0x18A595BE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x140FA20", Offset = "0x140E420", VA = "0x18140FA20")]
			[DebuggerHidden]
			public <_GetChannels>d__45(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0xA595C40", Offset = "0xA594640", VA = "0x18A595C40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xA593FE0", Offset = "0xA5929E0", VA = "0x18A593FE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0xA596030", Offset = "0xA594A30", VA = "0x18A596030")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0xA596090", Offset = "0xA594A90", VA = "0x18A596090")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0xA5960F0", Offset = "0xA594AF0", VA = "0x18A5960F0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xA596150", Offset = "0xA594B50", VA = "0x18A596150")]
			private void <>m__Finally4()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0xA5961B0", Offset = "0xA594BB0", VA = "0x18A5961B0")]
			private void <>m__Finally5()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0xA596210", Offset = "0xA594C10", VA = "0x18A596210")]
			private void <>m__Finally6()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0xA596270", Offset = "0xA594C70", VA = "0x18A596270")]
			private void <>m__Finally7()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0xA5962D0", Offset = "0xA594CD0", VA = "0x18A5962D0")]
			private void <>m__Finally8()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0xA596330", Offset = "0xA594D30", VA = "0x18A596330")]
			private void <>m__Finally9()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xA595FD0", Offset = "0xA5949D0", VA = "0x18A595FD0")]
			private void <>m__Finally10()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0xA595BA0", Offset = "0xA5945A0", VA = "0x18A595BA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xA595B00", Offset = "0xA594500", VA = "0x18A595B00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA595B00", Offset = "0xA594500", VA = "0x18A595B00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA588670", Offset = "0xA587070", VA = "0x18A588670")]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0xA5888B0", Offset = "0xA5872B0", VA = "0x18A5888B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0xA588610", Offset = "0xA587010", VA = "0x18A588610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0xA588830", Offset = "0xA587230", VA = "0x18A588830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0xA588710", Offset = "0xA587110", VA = "0x18A588710")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0xA5889E0", Offset = "0xA5873E0", VA = "0x18A5889E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public bool Unlit
		{
			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0xA5887F0", Offset = "0xA5871F0", VA = "0x18A5887F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public IEnumerable<MaterialChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xA5880B0", Offset = "0xA586AB0", VA = "0x18A5880B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xA588790", Offset = "0xA587190", VA = "0x18A588790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0xA588A60", Offset = "0xA587460", VA = "0x18A588A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA5886B0", Offset = "0xA5870B0", VA = "0x18A5886B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0xA588900", Offset = "0xA587300", VA = "0x18A588900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xA586930", Offset = "0xA585330", VA = "0x18A586930", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA586FD0", Offset = "0xA5859D0", VA = "0x18A586FD0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA587360", Offset = "0xA585D60", VA = "0x18A587360", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA587050", Offset = "0xA585A50", VA = "0x18A587050", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA586260", Offset = "0xA584C60", VA = "0x18A586260", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA5884C0", Offset = "0xA586EC0", VA = "0x18A5884C0")]
		internal Material()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xA586610", Offset = "0xA585010", VA = "0x18A586610")]
		[DebuggerStepThrough]
		public MaterialChannel? FindChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xA586E00", Offset = "0xA585800", VA = "0x18A586E00", Slot = "5")]
		protected override void OnValidateContent(ValidationContext result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xA586110", Offset = "0xA584B10", VA = "0x18A586110")]
		internal void ClearExtensions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xA586D60", Offset = "0xA585760", VA = "0x18A586D60")]
		public void InitializeUnlit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA586960", Offset = "0xA585360", VA = "0x18A586960")]
		public void InitializePBRMetallicRoughness(params string[] extensionNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA586C90", Offset = "0xA585690", VA = "0x18A586C90")]
		public void InitializePBRSpecularGlossiness(bool useFallback = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA5880B0", Offset = "0xA586AB0", VA = "0x18A5880B0")]
		[IteratorStateMachine(typeof(<_GetChannels>d__45))]
		private IEnumerable<MaterialChannel> _GetChannels()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA588210", Offset = "0xA586C10", VA = "0x18A588210")]
		private MaterialNormalTextureInfo _GetNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA588330", Offset = "0xA586D30", VA = "0x18A588330")]
		private MaterialOcclusionTextureInfo _GetOcclusionTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xA588130", Offset = "0xA586B30", VA = "0x18A588130")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2F80", Offset = "0xA5B1980", VA = "0x18A5B2F80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2440", Offset = "0xA5B0E40", VA = "0x18A5B2440", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0xA5B3560", Offset = "0xA5B1F60", VA = "0x18A5B3560")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2DC0", Offset = "0xA5B17C0", VA = "0x18A5B2DC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2A40", Offset = "0xA5B1440", VA = "0x18A5B2A40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2A40", Offset = "0xA5B1440", VA = "0x18A5B2A40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD66FC0", Offset = "0xD659C0", VA = "0x180D66FC0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD68130", Offset = "0xD66B30", VA = "0x180D68130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public Mesh LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECB20", VA = "0x180CEE120", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xCEE170", Offset = "0xCECB70", VA = "0x180CEE170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0xA58D300", Offset = "0xA58BD00", VA = "0x18A58D300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0xA58D570", Offset = "0xA58BF70", VA = "0x18A58D570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public PrimitiveType DrawPrimitiveType
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xA58D210", Offset = "0xA58BC10", VA = "0x18A58D210")]
			get
			{
				return default(PrimitiveType);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0xA58D520", Offset = "0xA58BF20", VA = "0x18A58D520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0xA58D410", Offset = "0xA58BE10", VA = "0x18A58D410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public IReadOnlyDictionary<string, Accessor> VertexAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0xA58D450", Offset = "0xA58BE50", VA = "0x18A58D450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public Accessor IndexAccessor
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0xA58D250", Offset = "0xA58BC50", VA = "0x18A58D250")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xA58BCB0", Offset = "0xA58A6B0", VA = "0x18A58BCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xA589B10", Offset = "0xA588510", VA = "0x18A589B10", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xA58BAA0", Offset = "0xA58A4A0", VA = "0x18A58BAA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xA58C530", Offset = "0xA58AF30", VA = "0x18A58C530", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA58BB20", Offset = "0xA58A520", VA = "0x18A58BB20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA588DD0", Offset = "0xA5877D0", VA = "0x18A588DD0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA58D0A0", Offset = "0xA58BAA0", VA = "0x18A58D0A0")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA58D110", Offset = "0xA58BB10", VA = "0x18A58D110")]
		internal MeshPrimitive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA58C500", Offset = "0xA58AF00", VA = "0x18A58C500", Slot = "18")]
		void IChildOfList<Mesh>.SetLogicalParent(Mesh parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA588FC0", Offset = "0xA5879C0", VA = "0x18A588FC0")]
		public IEnumerable<BufferView> GetBufferViews(bool includeIndices, bool includeVertices, bool includeMorphs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA589E40", Offset = "0xA588840", VA = "0x18A589E40")]
		public IReadOnlyList<KeyValuePair<string, Accessor>> GetVertexAccessorsByBuffer(BufferView vb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0xA589D40", Offset = "0xA588740", VA = "0x18A589D40")]
		public Accessor GetVertexAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0xA58C3A0", Offset = "0xA58ADA0", VA = "0x18A58C3A0")]
		public void SetVertexAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A1A0", Offset = "0x3D18BA0", VA = "0x183D1A1A0")]
		internal IReadOnlyList<T> GetVertices<T>(string attributeKey) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xA589480", Offset = "0xA587E80", VA = "0x18A589480")]
		public Accessor GetIndexAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xA58BCB0", Offset = "0xA58A6B0", VA = "0x18A58BCB0")]
		public void SetIndexAccessor(Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xA589520", Offset = "0xA587F20", VA = "0x18A589520")]
		public IList<uint> GetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5898A0", Offset = "0xA5882A0", VA = "0x18A5898A0")]
		public IEnumerable<int> GetPointIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xA589550", Offset = "0xA587F50", VA = "0x18A589550")]
		public IEnumerable<(int, int)> GetLineIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA589B40", Offset = "0xA588540", VA = "0x18A589B40")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA589750", Offset = "0xA588150", VA = "0x18A589750")]
		public IReadOnlyDictionary<string, Accessor> GetMorphTargetAccessors(int targetIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA58BDB0", Offset = "0xA58A7B0", VA = "0x18A58BDB0")]
		public void SetMorphTargetAccessors(int targetIdx, IReadOnlyDictionary<string, Accessor> accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA588B40", Offset = "0xA587540", VA = "0x18A588B40")]
		internal static bool CheckAttributesQuantizationRequired(ModelRoot root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA588D40", Offset = "0xA587740", VA = "0x18A588D40")]
		private bool CheckAttributesQuantizationRequired()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA58B450", Offset = "0xA589E50", VA = "0x18A58B450", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA58A0C0", Offset = "0xA588AC0", VA = "0x18A58A0C0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2EC0", Offset = "0xA5B18C0", VA = "0x18A5B2EC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0A60", Offset = "0xA5AF460", VA = "0x18A5B0A60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B3600", Offset = "0xA5B2000", VA = "0x18A5B3600")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2D40", Offset = "0xA5B1740", VA = "0x18A5B2D40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2900", Offset = "0xA5B1300", VA = "0x18A5B2900", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2900", Offset = "0xA5B1300", VA = "0x18A5B2900", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5991A0", Offset = "0xA597BA0", VA = "0x18A5991A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public IReadOnlyList<MeshPrimitive> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60008F8")]
			[Cpp2IlInjected.Address(RVA = "0xA5982A0", Offset = "0xA596CA0", VA = "0x18A5982A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public bool AllPrimitivesHaveJoints
		{
			[Cpp2IlInjected.Token(Token = "0x60008F9")]
			[Cpp2IlInjected.Address(RVA = "0xA599080", Offset = "0xA597A80", VA = "0x18A599080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xA598410", Offset = "0xA596E10", VA = "0x18A598410", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xA598920", Offset = "0xA597320", VA = "0x18A598920", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xA598C30", Offset = "0xA597630", VA = "0x18A598C30", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5989A0", Offset = "0xA5973A0", VA = "0x18A5989A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xA5981B0", Offset = "0xA596BB0", VA = "0x18A5981B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xA598EC0", Offset = "0xA5978C0", VA = "0x18A598EC0")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA598FC0", Offset = "0xA5979C0", VA = "0x18A598FC0")]
		internal Mesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5982A0", Offset = "0xA596CA0", VA = "0x18A5982A0")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0xA598AB0", Offset = "0xA5974B0", VA = "0x18A598AB0")]
		public void SetMorphWeights(IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xA598AC0", Offset = "0xA5974C0", VA = "0x18A598AC0")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0xA598130", Offset = "0xA596B30", VA = "0x18A598130")]
		public MeshPrimitive CreatePrimitive()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5987C0", Offset = "0xA5971C0", VA = "0x18A5987C0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xA598440", Offset = "0xA596E40", VA = "0x18A598440", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <Flatten>d__70(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0820", Offset = "0xA5AF220", VA = "0x18A5B0820", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0350", Offset = "0xA5AED50", VA = "0x18A5B0350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B09C0", Offset = "0xA5AF3C0", VA = "0x18A5B09C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0A10", Offset = "0xA5AF410", VA = "0x18A5B0A10")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0xA5B07E0", Offset = "0xA5AF1E0", VA = "0x18A5B07E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0740", Offset = "0xA5AF140", VA = "0x18A5B0740", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0740", Offset = "0xA5AF140", VA = "0x18A5B0740", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0xA5B3400", Offset = "0xA5B1E00", VA = "0x18A5B3400", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0xA5B1320", Offset = "0xA5AFD20", VA = "0x18A5B1320", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xA5B36F0", Offset = "0xA5B20F0", VA = "0x18A5B36F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2D00", Offset = "0xA5B1700", VA = "0x18A5B2D00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2860", Offset = "0xA5B1260", VA = "0x18A5B2860", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2860", Offset = "0xA5B1260", VA = "0x18A5B2860", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5A9580", Offset = "0xA5A7F80", VA = "0x18A5A9580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Node VisualRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9690", Offset = "0xA5A8090", VA = "0x18A5A9690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<Scene> VisualScenes
		{
			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9700", Offset = "0xA5A8100", VA = "0x18A5A9700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0xA5A6890", Offset = "0xA5A5290", VA = "0x18A5A6890", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public bool IsSkinJoint
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0xA5A8670", Offset = "0xA5A7070", VA = "0x18A5A8670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public bool IsSkinSkeleton
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0xA5A8780", Offset = "0xA5A7180", VA = "0x18A5A8780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public Camera Camera
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xA5A8570", Offset = "0xA5A6F70", VA = "0x18A5A8570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9C20", Offset = "0xA5A8620", VA = "0x18A5A9C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public Mesh Mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0xA5A91B0", Offset = "0xA5A7BB0", VA = "0x18A5A91B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9E00", Offset = "0xA5A8800", VA = "0x18A5A9E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public Skin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9470", Offset = "0xA5A7E70", VA = "0x18A5A9470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9FF0", Offset = "0xA5A89F0", VA = "0x18A5A9FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0xA5A92C0", Offset = "0xA5A7CC0", VA = "0x18A5A92C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9B00", Offset = "0xA5A8500", VA = "0x18A5A9B00")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0xA5AA190", Offset = "0xA5A8B90", VA = "0x18A5AA190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9040", Offset = "0xA5A7A40", VA = "0x18A5A9040")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9DC0", Offset = "0xA5A87C0", VA = "0x18A5A9DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000929")]
			[Cpp2IlInjected.Address(RVA = "0xA5A8F60", Offset = "0xA5A7960", VA = "0x18A5A8F60")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600092A")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9D00", Offset = "0xA5A8700", VA = "0x18A5A9D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(RVA = "0xA5A8AD0", Offset = "0xA5A74D0", VA = "0x18A5A8AD0")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9840", Offset = "0xA5A8240", VA = "0x18A5A9840")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool IsTransformAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0xA5A8890", Offset = "0xA5A7290", VA = "0x18A5A8890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		internal bool IsTransformDecomposed
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0xA5A8A70", Offset = "0xA5A7470", VA = "0x18A5A8A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public PunctualLight PunctualLight
		{
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0xA5A92D0", Offset = "0xA5A7CD0", VA = "0x18A5A92D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0xA5A9EF0", Offset = "0xA5A88F0", VA = "0x18A5A9EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0xA5A41B0", Offset = "0xA5A2BB0", VA = "0x18A5A41B0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4A00", Offset = "0xA5A3400", VA = "0x18A5A4A00", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5250", Offset = "0xA5A3C50", VA = "0x18A5A5250", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4AC0", Offset = "0xA5A34C0", VA = "0x18A5A4AC0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3640", Offset = "0xA5A2040", VA = "0x18A5A3640", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6340", Offset = "0xA5A4D40", VA = "0x18A5A6340")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xA5A82B0", Offset = "0xA5A6CB0", VA = "0x18A5A82B0")]
		internal Node()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3D90", Offset = "0xA5A2790", VA = "0x18A5A3D90")]
		public AffineTransform GetLocalTransform(Animation animation, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0xA5A41E0", Offset = "0xA5A2BE0", VA = "0x18A5A41E0")]
		public Matrix4x4 GetWorldMatrix(Animation animation, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3ED0", Offset = "0xA5A28D0", VA = "0x18A5A3ED0")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4F40", Offset = "0xA5A3940", VA = "0x18A5A4F40")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6220", Offset = "0xA5A4C20", VA = "0x18A5A6220")]
		internal static Node _FindVisualRootNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0xA5A35E0", Offset = "0xA5A1FE0", VA = "0x18A5A35E0", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3BD0", Offset = "0xA5A25D0", VA = "0x18A5A3BD0")]
		[IteratorStateMachine(typeof(<Flatten>d__70))]
		public static IEnumerable<Node> Flatten(IVisualNodeContainer container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA5A39D0", Offset = "0xA5A23D0", VA = "0x18A5A39D0")]
		public static IEnumerable<Node> FindNodesUsingMesh(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3AD0", Offset = "0xA5A24D0", VA = "0x18A5A3AD0")]
		public static IEnumerable<Node> FindNodesUsingSkin(Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA5A60B0", Offset = "0xA5A4AB0", VA = "0x18A5A60B0")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6920", Offset = "0xA5A5320", VA = "0x18A5A6920")]
		internal bool _HasVisualChild(int nodeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6890", Offset = "0xA5A5290", VA = "0x18A5A6890")]
		internal IEnumerable<Node> _GetVisualChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6EE0", Offset = "0xA5A58E0", VA = "0x18A5A6EE0")]
		internal void _SetVisualParent(Node parentNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6980", Offset = "0xA5A5380", VA = "0x18A5A6980")]
		internal void _RemoveFromVisualParent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3C50", Offset = "0xA5A2650", VA = "0x18A5A3C50")]
		public NodeCurveSamplers GetCurveSamplers(Animation animation)
		{
			return default(NodeCurveSamplers);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA5A69E0", Offset = "0xA5A53E0", VA = "0x18A5A69E0")]
		private void _SetLocalTransform(AffineTransform value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4650", Offset = "0xA5A3050", VA = "0x18A5A4650", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7650", Offset = "0xA5A6050", VA = "0x18A5A7650")]
		internal static void _ValidateParentHierarchy(IEnumerable<Node> nodes, ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4470", Offset = "0xA5A2E70", VA = "0x18A5A4470", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0xA5A72C0", Offset = "0xA5A5CC0", VA = "0x18A5A72C0")]
		private void _ValidateChildrenHierarchy(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xA5A7D30", Offset = "0xA5A6730", VA = "0x18A5A7D30")]
		private void _ValidateTransforms(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xA5A73C0", Offset = "0xA5A5DC0", VA = "0x18A5A73C0")]
		private static void _ValidateMeshAndSkin(ValidationContext validate, Mesh mesh, Skin skin, List<double> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3D50", Offset = "0xA5A2750", VA = "0x18A5A3D50")]
		public MeshGpuInstancing GetGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA5A6000", Offset = "0xA5A4A00", VA = "0x18A5A6000")]
		public MeshGpuInstancing UseGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA5A4A80", Offset = "0xA5A3480", VA = "0x18A5A4A80")]
		public void RemoveGpuInstancing()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA5A51E0", Offset = "0xA5A3BE0", VA = "0x18A5A51E0")]
		public bool TryGetVisibility([Out] bool isVisible)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0xA5A5130", Offset = "0xA5A3B30", VA = "0x18A5A5130")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B4B10", Offset = "0xA5B3510", VA = "0x18A5B4B10", Slot = "4")]
			public bool Equals(TextureSampler x, TextureSampler y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xA5B4CB0", Offset = "0xA5B36B0", VA = "0x18A5B4CB0", Slot = "5")]
			public int GetHashCode(TextureSampler obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B3040", Offset = "0xA5B1A40", VA = "0x18A5B3040", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B1000", Offset = "0xA5AFA00", VA = "0x18A5B1000", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B34C0", Offset = "0xA5B1EC0", VA = "0x18A5B34C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2CC0", Offset = "0xA5B16C0", VA = "0x18A5B2CC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B29A0", Offset = "0xA5B13A0", VA = "0x18A5B29A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0xA5B29A0", Offset = "0xA5B13A0", VA = "0x18A5B29A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5AED00", Offset = "0xA5AD700", VA = "0x18A5AED00")]
			get
			{
				return default(TextureMipMapFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000987")]
			[Cpp2IlInjected.Address(RVA = "0xA5AECC0", Offset = "0xA5AD6C0", VA = "0x18A5AECC0")]
			get
			{
				return default(TextureInterpolationFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0xA5AED40", Offset = "0xA5AD740", VA = "0x18A5AED40")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0xA5AED80", Offset = "0xA5AD780", VA = "0x18A5AED80")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public static IEqualityComparer<TextureSampler> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xA5AEC70", Offset = "0xA5AD670", VA = "0x18A5AEC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xA5AEDC0", Offset = "0xA5AD7C0", VA = "0x18A5AEDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE250", Offset = "0xA5ACC50", VA = "0x18A5AE250", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE390", Offset = "0xA5ACD90", VA = "0x18A5AE390", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE590", Offset = "0xA5ACF90", VA = "0x18A5AE590", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE410", Offset = "0xA5ACE10", VA = "0x18A5AE410", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xA5ADF00", Offset = "0xA5AC900", VA = "0x18A5ADF00", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xA5AEAB0", Offset = "0xA5AD4B0", VA = "0x18A5AEAB0")]
		internal TextureSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA5AEB40", Offset = "0xA5AD540", VA = "0x18A5AEB40")]
		internal TextureSampler(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE280", Offset = "0xA5ACC80", VA = "0x18A5AE280")]
		internal static bool IsDefault(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xA5ADDA0", Offset = "0xA5AC7A0", VA = "0x18A5ADDA0")]
		public static bool AreEqualByContent(TextureSampler x, TextureSampler y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE2A0", Offset = "0xA5ACCA0", VA = "0x18A5AE2A0")]
		internal bool IsEqualTo(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0xA5AE130", Offset = "0xA5ACB30", VA = "0x18A5AE130")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0xA5B3100", Offset = "0xA5B1B00", VA = "0x18A5B3100", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0xA5B17F0", Offset = "0xA5B01F0", VA = "0x18A5B17F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0xA5B3510", Offset = "0xA5B1F10", VA = "0x18A5B3510")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2E40", Offset = "0xA5B1840", VA = "0x18A5B2E40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2B80", Offset = "0xA5B1580", VA = "0x18A5B2B80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2B80", Offset = "0xA5B1580", VA = "0x18A5B2B80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0xA5AB210", Offset = "0xA5A9C10", VA = "0x18A5AB210", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA3F0", Offset = "0xA5A8DF0", VA = "0x18A5AA3F0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA970", Offset = "0xA5A9370", VA = "0x18A5AA970", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xA5AAAA0", Offset = "0xA5A94A0", VA = "0x18A5AAAA0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA9F0", Offset = "0xA5A93F0", VA = "0x18A5AA9F0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA350", Offset = "0xA5A8D50", VA = "0x18A5AA350", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xA5AB190", Offset = "0xA5A9B90", VA = "0x18A5AB190")]
		internal Scene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA2F0", Offset = "0xA5A8CF0", VA = "0x18A5AA2F0", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5AACA0", Offset = "0xA5A96A0", VA = "0x18A5AACA0")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xA5AAEE0", Offset = "0xA5A98E0", VA = "0x18A5AAEE0")]
		internal void _RemoveVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5AAFD0", Offset = "0xA5A99D0", VA = "0x18A5AAFD0")]
		internal void _UseVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5AA420", Offset = "0xA5A8E20", VA = "0x18A5AA420", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xA5B31C0", Offset = "0xA5B1BC0", VA = "0x18A5B31C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0D00", Offset = "0xA5AF700", VA = "0x18A5B0D00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0xA5B36A0", Offset = "0xA5B20A0", VA = "0x18A5B36A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F1")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2E80", Offset = "0xA5B1880", VA = "0x18A5B2E80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0xA5B27C0", Offset = "0xA5B11C0", VA = "0x18A5B27C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0xA5B27C0", Offset = "0xA5B11C0", VA = "0x18A5B27C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5ADB90", Offset = "0xA5AC590", VA = "0x18A5ADB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public int JointsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xA5ADA20", Offset = "0xA5AC420", VA = "0x18A5ADA20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public IReadOnlyList<Node> Joints
		{
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0xA5ADA60", Offset = "0xA5AC460", VA = "0x18A5ADA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public IReadOnlyList<Matrix4x4> InverseBindMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0xA5AD970", Offset = "0xA5AC370", VA = "0x18A5AD970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public Node Skeleton
		{
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xA5ADAF0", Offset = "0xA5AC4F0", VA = "0x18A5ADAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0xA5ADCC0", Offset = "0xA5AC6C0", VA = "0x18A5ADCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC430", Offset = "0xA5AAE30", VA = "0x18A5AC430", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0xA5ACD60", Offset = "0xA5AB760", VA = "0x18A5ACD60", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5ACEF0", Offset = "0xA5AB8F0", VA = "0x18A5ACEF0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5ACDE0", Offset = "0xA5AB7E0", VA = "0x18A5ACDE0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5ABE30", Offset = "0xA5AA830", VA = "0x18A5ABE30", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD8F0", Offset = "0xA5AC2F0", VA = "0x18A5AD8F0")]
		internal Skin()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD3D0", Offset = "0xA5ABDD0", VA = "0x18A5AD3D0")]
		public Accessor UseInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC110", Offset = "0xA5AAB10", VA = "0x18A5AC110")]
		public Accessor GetInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC210", Offset = "0xA5AAC10", VA = "0x18A5AC210")]
		public (Node, Matrix4x4) GetJoint(int idx)
		{
			return default((Node, Matrix4x4));
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5AB950", Offset = "0xA5AA350", VA = "0x18A5AB950")]
		public void BindJoints(params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5AB9D0", Offset = "0xA5AA3D0", VA = "0x18A5AB9D0")]
		public void BindJoints(Matrix4x4 meshBindTransform, params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5AB2A0", Offset = "0xA5A9CA0", VA = "0x18A5AB2A0")]
		public void BindJoints(IReadOnlyList<(Node Joint, Matrix4x4 InverseBindMatrix)> joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC460", Offset = "0xA5AAE60", VA = "0x18A5AC460")]
		internal bool IsMatch(Node skeleton, KeyValuePair<Node, Matrix4x4>[] joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5ABF50", Offset = "0xA5AA950", VA = "0x18A5ABF50")]
		internal static IEnumerable<Skin> FindSkinsUsingJoint(Node jointNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC030", Offset = "0xA5AAA30", VA = "0x18A5AC030")]
		internal static IEnumerable<Skin> FindSkinsUsingSkeleton(Node skeletonNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5AD4F0", Offset = "0xA5ABEF0", VA = "0x18A5AD4F0")]
		private Node _FindCommonAncestor(IEnumerable<Node> nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC880", Offset = "0xA5AB280", VA = "0x18A5AC880", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5AC650", Offset = "0xA5AB050", VA = "0x18A5AC650", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B3280", Offset = "0xA5B1C80", VA = "0x18A5B3280", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0xA5B21A0", Offset = "0xA5B0BA0", VA = "0x18A5B21A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0xA5B3650", Offset = "0xA5B2050", VA = "0x18A5B3650")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2D80", Offset = "0xA5B1780", VA = "0x18A5B2D80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2C20", Offset = "0xA5B1620", VA = "0x18A5B2C20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2C20", Offset = "0xA5B1620", VA = "0x18A5B2C20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B0190", Offset = "0xA5AEB90", VA = "0x18A5B0190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0290", Offset = "0xA5AEC90", VA = "0x18A5B0290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public Image PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0180", Offset = "0xA5AEB80", VA = "0x18A5B0180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public Image FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0xA5B00C0", Offset = "0xA5AEAC0", VA = "0x18A5B00C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xA5AEF80", Offset = "0xA5AD980", VA = "0x18A5AEF80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF100", Offset = "0xA5ADB00", VA = "0x18A5AF100", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF8F0", Offset = "0xA5AE2F0", VA = "0x18A5AF8F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF180", Offset = "0xA5ADB80", VA = "0x18A5AF180", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5AEEB0", Offset = "0xA5AD8B0", VA = "0x18A5AEEB0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xA581CC0", Offset = "0xA5806C0", VA = "0x18A581CC0")]
		internal Texture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5AFC60", Offset = "0xA5AE660", VA = "0x18A5AFC60")]
		private Image _GetPrimaryImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0xA5AFBA0", Offset = "0xA5AE5A0", VA = "0x18A5AFBA0")]
		private Image _GetFallbackImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF210", Offset = "0xA5ADC10", VA = "0x18A5AF210")]
		public void SetImage(Image primaryImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0xA5AF440", Offset = "0xA5ADE40", VA = "0x18A5AF440")]
		public void SetImages(Image primaryImage, Image fallbackImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xA5AEE30", Offset = "0xA5AD830", VA = "0x18A5AEE30")]
		public void ClearImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0xA5AFF70", Offset = "0xA5AE970", VA = "0x18A5AFF70")]
		private TextureDDS _UseDDSTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xA5B0050", Offset = "0xA5AEA50", VA = "0x18A5B0050")]
		private TextureWEBP _UseWEBPTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xA5AFFE0", Offset = "0xA5AE9E0", VA = "0x18A5AFFE0")]
		private TextureKTX2 _UseKTX2Texture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xA5AFD90", Offset = "0xA5AE790", VA = "0x18A5AFD90")]
		internal bool _IsEqualentTo(Image primary, Image fallback, TextureSampler sampler)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xA5AEFB0", Offset = "0xA5AD9B0", VA = "0x18A5AEFB0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0xA5B3340", Offset = "0xA5B1D40", VA = "0x18A5B3340", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0xA5B1A40", Offset = "0xA5B0440", VA = "0x18A5B1A40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0xA5B35B0", Offset = "0xA5B1FB0", VA = "0x18A5B35B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2E00", Offset = "0xA5B1800", VA = "0x18A5B2E00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2AE0", Offset = "0xA5B14E0", VA = "0x18A5B2AE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9E")]
			[Cpp2IlInjected.Address(RVA = "0xA5B2AE0", Offset = "0xA5B14E0", VA = "0x18A5B2AE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xA5A34B0", Offset = "0xA5A1EB0", VA = "0x18A5A34B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public bool MeshQuantizationAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3450", Offset = "0xA5A1E50", VA = "0x18A5A3450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public IEnumerable<string> ExtensionsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public IEnumerable<string> ExtensionsRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public IEnumerable<string> IncompatibleExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3300", Offset = "0xA5A1D00", VA = "0x18A5A3300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public IReadOnlyList<Material> LogicalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0xCEE740", Offset = "0xCED140", VA = "0x180CEE740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public IReadOnlyList<Texture> LogicalTextures
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0xDD4470", Offset = "0xDD2E70", VA = "0x180DD4470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public IReadOnlyList<TextureSampler> LogicalTextureSamplers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0xCF7D90", Offset = "0xCF6790", VA = "0x180CF7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public IReadOnlyList<Image> LogicalImages
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0xCEE130", Offset = "0xCECB30", VA = "0x180CEE130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public IReadOnlyList<Buffer> LogicalBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECB20", VA = "0x180CEE120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public IReadOnlyList<BufferView> LogicalBufferViews
		{
			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2CE0", VA = "0x180CF42E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public IReadOnlyList<Accessor> LogicalAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public IReadOnlyList<Mesh> LogicalMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED120", VA = "0x180CEE720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public IReadOnlyList<Skin> LogicalSkins
		{
			[Cpp2IlInjected.Token(Token = "0x6000A47")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E00", Offset = "0xCF6800", VA = "0x180CF7E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public IReadOnlyList<Camera> LogicalCameras
		{
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECB50", VA = "0x180CEE150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public IReadOnlyList<Node> LogicalNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xCF7720", Offset = "0xCF6120", VA = "0x180CF7720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public IReadOnlyList<Scene> LogicalScenes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xD1EC20", Offset = "0xD1D620", VA = "0x180D1EC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public IReadOnlyList<Animation> LogicalAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2DA0", VA = "0x180CF43A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public Scene DefaultScene
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3250", Offset = "0xA5A1C50", VA = "0x18A5A3250")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3500", Offset = "0xA5A1F00", VA = "0x18A5A3500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public IReadOnlyList<PunctualLight> LogicalPunctualLights
		{
			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3390", Offset = "0xA5A1D90", VA = "0x18A5A3390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA59BC80", Offset = "0xA59A680", VA = "0x18A59BC80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA59D7C0", Offset = "0xA59C1C0", VA = "0x18A59D7C0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0xA59E2F0", Offset = "0xA59CCF0", VA = "0x18A59E2F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xA59DD20", Offset = "0xA59C720", VA = "0x18A59DD20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xA59AAA0", Offset = "0xA5994A0", VA = "0x18A59AAA0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xA599CD0", Offset = "0xA5986D0", VA = "0x18A599CD0")]
		public Accessor CreateAccessor([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0xA599D70", Offset = "0xA598770", VA = "0x18A599D70")]
		public Animation CreateAnimation([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xA599FA0", Offset = "0xA5989A0", VA = "0x18A599FA0")]
		public Buffer CreateBuffer(int byteCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0xA59FF20", Offset = "0xA59E920", VA = "0x18A59FF20")]
		public Buffer UseBuffer(byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0xA59C040", Offset = "0xA59AA40", VA = "0x18A59C040")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0xA59C490", Offset = "0xA59AE90", VA = "0x18A59C490")]
		public void MergeBuffers(int maxSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0xA59BCB0", Offset = "0xA59A6B0", VA = "0x18A59BCB0")]
		public void IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xA599E10", Offset = "0xA598810", VA = "0x18A599E10")]
		public BufferView CreateBufferView(int byteSize, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0xA59F840", Offset = "0xA59E240", VA = "0x18A59F840")]
		public BufferView UseBufferView(ArraySegment<byte> data, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0xA59FA40", Offset = "0xA59E440", VA = "0x18A59FA40")]
		public BufferView UseBufferView(byte[] buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0xA59FB40", Offset = "0xA59E540", VA = "0x18A59FB40")]
		public BufferView UseBufferView(Buffer buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xA59A050", Offset = "0xA598A50", VA = "0x18A59A050")]
		public Camera CreateCamera([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0xA59F670", Offset = "0xA59E070", VA = "0x18A59F670")]
		internal void UpdateExtensionsSupport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0xA59B1D0", Offset = "0xA599BD0", VA = "0x18A59B1D0")]
		internal IEnumerable<string> GatherUsedExtensions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0xA5A24A0", Offset = "0xA5A0EA0", VA = "0x18A5A24A0")]
		private void _SetExtensionUsage(string extension, bool used, bool required)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0xA5A25C0", Offset = "0xA5A0FC0", VA = "0x18A5A25C0")]
		internal void _ValidateExtensions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0xA59A0F0", Offset = "0xA598AF0", VA = "0x18A59A0F0")]
		public Image CreateImage([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xA5A0180", Offset = "0xA59EB80", VA = "0x18A5A0180")]
		public Image UseImage(MemoryImage imageContent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0xA59CA50", Offset = "0xA59B450", VA = "0x18A59CA50")]
		public void MergeImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0xA59A210", Offset = "0xA598C10", VA = "0x18A59A210")]
		public Material CreateMaterial([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0xA59A2B0", Offset = "0xA598CB0", VA = "0x18A59A2B0")]
		public Mesh CreateMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0xA5A18B0", Offset = "0xA5A02B0", VA = "0x18A5A18B0")]
		internal Node _FindVisualParentNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0xA59A190", Offset = "0xA598B90", VA = "0x18A59A190")]
		public Node CreateLogicalNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0xA5A17D0", Offset = "0xA5A01D0", VA = "0x18A5A17D0")]
		internal Node _CreateVisualNode(IList<int> parentChildren)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0xA5992D0", Offset = "0xA597CD0", VA = "0x18A5992D0")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0xA59A3F0", Offset = "0xA598DF0", VA = "0x18A59A3F0")]
		public static ModelRoot CreateModel()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0xA5A2DD0", Offset = "0xA5A17D0", VA = "0x18A5A2DD0")]
		internal ModelRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0xA59A690", Offset = "0xA599090", VA = "0x18A59A690")]
		public ModelRoot DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF80B0", VA = "0x180DF96B0", Slot = "16")]
		ModelRoot IConvertibleToGltf2.ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0xA59B9F0", Offset = "0xA59A3F0", VA = "0x18A59B9F0")]
		internal IEnumerable<ExtraProperties> GetLogicalChildrenFlattened()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0xA59CC60", Offset = "0xA59B660", VA = "0x18A59CC60", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0xA59CBF0", Offset = "0xA59B5F0", VA = "0x18A59CBF0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0xA59A4C0", Offset = "0xA598EC0", VA = "0x18A59A4C0")]
		public PunctualLight CreatePunctualLight(PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0xA59A520", Offset = "0xA598F20", VA = "0x18A59A520")]
		public PunctualLight CreatePunctualLight(string name, PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0xA5A05A0", Offset = "0xA59EFA0", VA = "0x18A5A05A0")]
		public Scene UseScene(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0xA5A0450", Offset = "0xA59EE50", VA = "0x18A5A0450")]
		public Scene UseScene(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0xA59A590", Offset = "0xA598F90", VA = "0x18A59A590")]
		public Skin CreateSkin([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0xA5A0750", Offset = "0xA59F150", VA = "0x18A5A0750")]
		public TextureSampler UseTextureSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min, TextureInterpolationFilter mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0xA5A0BA0", Offset = "0xA59F5A0", VA = "0x18A5A0BA0")]
		public Texture UseTexture(Image primary, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0xA5A0BD0", Offset = "0xA59F5D0", VA = "0x18A5A0BD0")]
		public Texture UseTexture(Image primary, Image fallback, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0xA5A0F60", Offset = "0xA59F960", VA = "0x18A5A0F60")]
		public static ValidationResult Validate(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0xA59BE60", Offset = "0xA59A860", VA = "0x18A59BE60")]
		public static ModelRoot Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0xA59CE20", Offset = "0xA59B820", VA = "0x18A59CE20")]
		public static ModelRoot ParseGLB(ArraySegment<byte> glb, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0xA59D5D0", Offset = "0xA59BFD0", VA = "0x18A59D5D0")]
		public static ModelRoot ReadGLB(Stream stream, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0xA59BB20", Offset = "0xA59A520", VA = "0x18A59BB20")]
		public static string[] GetSatellitePaths(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0xA59D000", Offset = "0xA59BA00", VA = "0x18A59D000")]
		private static string[] ParseSatellitePaths(ReadOnlyMemory<byte> json)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		internal void OnDeserializationCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xA5A20B0", Offset = "0xA5A0AB0", VA = "0x18A5A20B0")]
		internal void _ResolveSatelliteDependencies(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0xA59DC20", Offset = "0xA59C620", VA = "0x18A59DC20")]
		public void Save(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xA59D840", Offset = "0xA59C240", VA = "0x18A59D840")]
		public void SaveGLB(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0xA59DA30", Offset = "0xA59C430", VA = "0x18A59DA30")]
		public void SaveGLTF(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0xA59B9E0", Offset = "0xA59A3E0", VA = "0x18A59B9E0")]
		[Obsolete("Use GetJsonPreview", true)]
		public string GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0xA59B9E0", Offset = "0xA59A3E0", VA = "0x18A59B9E0")]
		public string GetJsonPreview()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0xA5A19B0", Offset = "0xA5A03B0", VA = "0x18A5A19B0")]
		internal string _GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0xA5A10B0", Offset = "0xA59FAB0", VA = "0x18A5A10B0")]
		public ArraySegment<byte> WriteGLB([Optional] WriteSettings settings)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0xA5A12F0", Offset = "0xA59FCF0", VA = "0x18A5A12F0")]
		public void WriteGLB(Stream stream, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0xA5A2A30", Offset = "0xA5A1430", VA = "0x18A5A2A30")]
		internal void _WriteJSON(Stream sw, JsonWriterOptions options, JsonFilterCallback filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0xA5A1CD0", Offset = "0xA5A06D0", VA = "0x18A5A1CD0")]
		internal void _PrepareBuffersForSatelliteWriting(WriteContext context, string baseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0xA5A1C20", Offset = "0xA5A0620", VA = "0x18A5A1C20")]
		internal void _PrepareBuffersForInternalWriting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0xA5A1E20", Offset = "0xA5A0820", VA = "0x18A5A1E20")]
		internal void _PrepareImagesForWriting(WriteContext context, string baseName, bool isBinary, ResourceWriteMode rmode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0xA5A1440", Offset = "0xA59FE40", VA = "0x18A5A1440")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABD")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0xA5CDC40", Offset = "0xA5CC640", VA = "0x18A5CDC40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0xA5CD860", Offset = "0xA5CC260", VA = "0x18A5CD860", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0xA5CDD00", Offset = "0xA5CC700", VA = "0x18A5CDD00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0xA5CDC00", Offset = "0xA5CC600", VA = "0x18A5CDC00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0xA5CDB60", Offset = "0xA5CC560", VA = "0x18A5CDB60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(RVA = "0xA5CDB60", Offset = "0xA5CC560", VA = "0x18A5CDB60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA597EC0", Offset = "0xA5968C0", VA = "0x18A597EC0")]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0xA596F10", Offset = "0xA595910", VA = "0x18A596F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA8")]
			[Cpp2IlInjected.Address(RVA = "0xCEE740", Offset = "0xCED140", VA = "0x180CEE740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0xCEE750", Offset = "0xCED150", VA = "0x180CEE750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0xA5980F0", Offset = "0xA596AF0", VA = "0x18A5980F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		internal bool _HasContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0xA598050", Offset = "0xA596A50", VA = "0x18A598050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0xA596AA0", Offset = "0xA5954A0", VA = "0x18A596AA0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0xA596DE0", Offset = "0xA5957E0", VA = "0x18A596DE0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0xA597300", Offset = "0xA595D00", VA = "0x18A597300", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xA596E60", Offset = "0xA595860", VA = "0x18A596E60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0xA5967E0", Offset = "0xA5951E0", VA = "0x18A5967E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0xA5976F0", Offset = "0xA5960F0", VA = "0x18A5976F0")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0xA581CC0", Offset = "0xA5806C0", VA = "0x18A581CC0")]
		internal Image()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0xA596900", Offset = "0xA595300", VA = "0x18A596900")]
		private MemoryImage GetSatelliteContent()
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0xA596F10", Offset = "0xA595910", VA = "0x18A596F10")]
		private void SetSatelliteContent(MemoryImage content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAE")]
		[Cpp2IlInjected.Address(RVA = "0xA597020", Offset = "0xA595A20", VA = "0x18A597020")]
		internal void TransferToInternalBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAF")]
		[Cpp2IlInjected.Address(RVA = "0xA597810", Offset = "0xA596210", VA = "0x18A597810")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB0")]
		[Cpp2IlInjected.Address(RVA = "0xA5977C0", Offset = "0xA5961C0", VA = "0x18A5977C0")]
		internal void _DiscardContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0xA597B00", Offset = "0xA596500", VA = "0x18A597B00")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0xA597C00", Offset = "0xA596600", VA = "0x18A597C00")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0xA5979D0", Offset = "0xA5963D0", VA = "0x18A5979D0")]
		private void _WriteAsBufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0xA5976B0", Offset = "0xA5960B0", VA = "0x18A5976B0")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0xA596C50", Offset = "0xA595650", VA = "0x18A596C50", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xA596AD0", Offset = "0xA5954D0", VA = "0x18A596AD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECB10", VA = "0x180CEE110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACC")]
			[Cpp2IlInjected.Address(RVA = "0xA5D5F30", Offset = "0xA5D4930", VA = "0x18A5D5F30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5EA0", Offset = "0xA5D48A0", VA = "0x18A5D5EA0")]
		public _StaticBufferBuilder(int bufferIndex, int initialCapacity = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5CA0", Offset = "0xA5D46A0", VA = "0x18A5D5CA0")]
		public int Append(byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5E00", Offset = "0xA5D4800", VA = "0x18A5D5E00")]
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
			[Cpp2IlInjected.Address(RVA = "0x4145A40", Offset = "0x4144440", VA = "0x184145A40")]
			public static ExtensionEntry Create<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
			{
				return default(ExtensionEntry);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AD9")]
			[Cpp2IlInjected.Address(RVA = "0x23DA440", Offset = "0x23D8E40", VA = "0x1823DA440")]
			public ExtensionEntry(string n, Type p, Type e, Func<JsonSerializable, JsonSerializable> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADA")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7180", Offset = "0xA5B5B80", VA = "0x18A5B7180")]
			public bool IsMatch(Type parentType, string extensionName)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADB")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7100", Offset = "0xA5B5B00", VA = "0x18A5B7100")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B80F0", Offset = "0xA5B6AF0", VA = "0x18A5B80F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA5B7590", Offset = "0xA5B5F90", VA = "0x18A5B7590")]
		static ExtensionsFactory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0690", Offset = "0x3AAF090", VA = "0x183AB0690")]
		[Obsolete("Use RegisterExtension(name, factory) instead.")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0390", Offset = "0x3AAED90", VA = "0x183AB0390")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName, Func<TParent, JsonSerializable> factory) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA5B71E0", Offset = "0xA5B5BE0", VA = "0x18A5B71E0")]
		internal static JsonSerializable Create(JsonSerializable parent, string extensionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B73B0", Offset = "0xA5B5DB0", VA = "0x18A5B73B0")]
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
					[Cpp2IlInjected.Address(RVA = "0x5112B50", Offset = "0x5111550", VA = "0x185112B50", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA5CCD40", Offset = "0xA5CB740", VA = "0x18A5CCD40", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000B20")]
				[Cpp2IlInjected.Address(RVA = "0x5145310", Offset = "0x5143D10", VA = "0x185145310")]
				[DebuggerHidden]
				public <GetFields>d__3(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B21")]
				[Cpp2IlInjected.Address(RVA = "0xA5CCD90", Offset = "0xA5CB790", VA = "0x18A5CCD90", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B22")]
				[Cpp2IlInjected.Address(RVA = "0xA5CC910", Offset = "0xA5CB310", VA = "0x18A5CC910", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B23")]
				[Cpp2IlInjected.Address(RVA = "0xA5CCE50", Offset = "0xA5CB850", VA = "0x18A5CCE50")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B25")]
				[Cpp2IlInjected.Address(RVA = "0xA5CCD00", Offset = "0xA5CB700", VA = "0x18A5CCD00", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B27")]
				[Cpp2IlInjected.Address(RVA = "0xA5CCC60", Offset = "0xA5CB660", VA = "0x18A5CCC60", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B28")]
				[Cpp2IlInjected.Address(RVA = "0xA5CCC60", Offset = "0xA5CB660", VA = "0x18A5CCC60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6AB0", VA = "0x180EC80B0")]
			public _ExtensionsReflection(IReadOnlyList<JsonSerializable> extensions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B18")]
			[Cpp2IlInjected.Address(RVA = "0xA5D4640", Offset = "0xA5D3040", VA = "0x18A5D4640", Slot = "5")]
			public bool TryGetField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0xA5D45C0", Offset = "0xA5D2FC0", VA = "0x18A5D45C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B35")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <Flatten>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B36")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC5F0", Offset = "0xA5CAFF0", VA = "0x18A5CC5F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B37")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC170", Offset = "0xA5CAB70", VA = "0x18A5CC170", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC790", Offset = "0xA5CB190", VA = "0x18A5CC790")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC7E0", Offset = "0xA5CB1E0", VA = "0x18A5CC7E0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC5B0", Offset = "0xA5CAFB0", VA = "0x18A5CC5B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3D")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC510", Offset = "0xA5CAF10", VA = "0x18A5CC510", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3E")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC510", Offset = "0xA5CAF10", VA = "0x18A5CC510", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3F")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <GetLogicalChildren>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B40")]
			[Cpp2IlInjected.Address(RVA = "0xA5CD620", Offset = "0xA5CC020", VA = "0x18A5CD620", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0xA5CCEA0", Offset = "0xA5CB8A0", VA = "0x18A5CCEA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0xA5CD7C0", Offset = "0xA5CC1C0", VA = "0x18A5CD7C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0xA5CD810", Offset = "0xA5CC210", VA = "0x18A5CD810")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B45")]
			[Cpp2IlInjected.Address(RVA = "0xA5CD5E0", Offset = "0xA5CBFE0", VA = "0x18A5CD5E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0xA5CD540", Offset = "0xA5CBF40", VA = "0x18A5CD540", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B48")]
			[Cpp2IlInjected.Address(RVA = "0xA5CD540", Offset = "0xA5CBF40", VA = "0x18A5CD540", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B49")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE150", Offset = "0xA5CCB50", VA = "0x18A5CE150", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0xA5CDD50", Offset = "0xA5CC750", VA = "0x18A5CDD50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4C")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE210", Offset = "0xA5CCC10", VA = "0x18A5CE210")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE110", Offset = "0xA5CCB10", VA = "0x18A5CE110", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B50")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE070", Offset = "0xA5CCA70", VA = "0x18A5CE070", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE070", Offset = "0xA5CCA70", VA = "0x18A5CE070", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "14")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0xA5B95E0", Offset = "0xA5B7FE0", VA = "0x18A5B95E0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0xA5B84E0", Offset = "0xA5B6EE0", VA = "0x18A5B84E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8B30", Offset = "0xA5B7530", VA = "0x18A5B8B30", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__9))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8C70", Offset = "0xA5B7670", VA = "0x18A5B8C70", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8460", Offset = "0xA5B6E60", VA = "0x18A5B8460")]
		[IteratorStateMachine(typeof(<GetLogicalChildren>d__11))]
		protected IEnumerable<ExtraProperties> GetLogicalChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0xA5B83E0", Offset = "0xA5B6DE0", VA = "0x18A5B83E0")]
		[IteratorStateMachine(typeof(<Flatten>d__12))]
		protected static IEnumerable<ExtraProperties> Flatten(ExtraProperties container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x3AB31C0", Offset = "0x3AB1BC0", VA = "0x183AB31C0")]
		protected static void SetProperty<TParent, TProperty, TValue>(TParent parent, TProperty property, TValue value) where TParent : ExtraProperties where TProperty : class where TValue : TProperty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2AD0", Offset = "0x3AB14D0", VA = "0x183AB2AD0")]
		protected static ChildSetter<T> GetChildSetter<T>(T owner) where T : ExtraProperties
		{
			return default(ChildSetter<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2B20", Offset = "0x3AB1520", VA = "0x183AB2B20")]
		public T GetExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3240", Offset = "0x3AB1C40", VA = "0x183AB3240")]
		public T UseExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2E00", Offset = "0x3AB1800", VA = "0x183AB2E00")]
		public void SetExtension<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2B70", Offset = "0x3AB1570", VA = "0x183AB2B70")]
		public void RemoveExtensions<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2C60", Offset = "0x3AB1660", VA = "0x183AB2C60")]
		public void RemoveExtensions<T>() where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8720", Offset = "0xA5B7120", VA = "0x18A5B8720", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8510", Offset = "0xA5B6F10", VA = "0x18A5B8510", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8BB0", Offset = "0xA5B75B0", VA = "0x18A5B8BB0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0xA5B92A0", Offset = "0xA5B7CA0", VA = "0x18A5B92A0")]
		private static Dictionary<string, JsonSerializable> _ToDictionary(JsonSerializable context, IEnumerable<JsonSerializable> serializables)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0xA5B82B0", Offset = "0xA5B6CB0", VA = "0x18A5B82B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8FC0", Offset = "0xA5B79C0", VA = "0x18A5B8FC0")]
		private static void _DeserializeExtensions(JsonSerializable parent, Utf8JsonReader reader, List<JsonSerializable> extensions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9560", Offset = "0xA5B7F60", VA = "0x18A5B9560")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6A90", VA = "0x180EC8090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000B59")]
			[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25AD0", VA = "0x180F270D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public bool HasDefaultContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0xA5BD7E0", Offset = "0xA5BC1E0", VA = "0x18A5BD7E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BD7F0", Offset = "0xA5BC1F0", VA = "0x18A5BD7F0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xA5BDB90", Offset = "0xA5BC590", VA = "0x18A5BDB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public IReadOnlyList<IMaterialParameter> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public Texture Texture
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0xA5BD8D0", Offset = "0xA5BC2D0", VA = "0x18A5BD8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public TextureSampler TextureSampler
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0xA5BD860", Offset = "0xA5BC260", VA = "0x18A5BD860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0xA5BD850", Offset = "0xA5BC250", VA = "0x18A5BD850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0xA5BD890", Offset = "0xA5BC290", VA = "0x18A5BD890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0xA5BD5B0", Offset = "0xA5BBFB0", VA = "0x18A5BD5B0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0xA5BD960", Offset = "0xA5BC360", VA = "0x18A5BD960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD390", Offset = "0xA5BBD90", VA = "0x18A5BD390")]
		internal MaterialChannel(Material m, string key, _MaterialTexture texInfo, params IMaterialParameter[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCBE0", Offset = "0xA5BB5E0", VA = "0x18A5BCBE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC9B0", Offset = "0xA5BB3B0", VA = "0x18A5BC9B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCA70", Offset = "0xA5BB470", VA = "0x18A5BCA70", Slot = "4")]
		public bool Equals(MaterialChannel other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD8E0", Offset = "0xA5BC2E0", VA = "0x18A5BD8E0")]
		public static bool operator ==([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD920", Offset = "0xA5BC320", VA = "0x18A5BD920")]
		public static bool operator !=([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCAB0", Offset = "0xA5BB4B0", VA = "0x18A5BCAB0")]
		public float GetFactor(string key)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCC40", Offset = "0xA5BB640", VA = "0x18A5BCC40")]
		public void SetFactor(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD290", Offset = "0xA5BBC90", VA = "0x18A5BD290")]
		private Texture _GetTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCD80", Offset = "0xA5BB780", VA = "0x18A5BCD80")]
		public Texture SetTexture(int texCoord, Image primaryImg, [Optional] Image fallbackImg, TextureWrapMode ws = TextureWrapMode.REPEAT, TextureWrapMode wt = TextureWrapMode.REPEAT, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0xA5BCF30", Offset = "0xA5BB930", VA = "0x18A5BCF30")]
		public void SetTexture(int texSet, Texture tex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD080", Offset = "0xA5BBA80", VA = "0x18A5BD080")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD150", Offset = "0xA5BBB50", VA = "0x18A5BD150")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B90C70", Offset = "0x3B8F670", VA = "0x183B90C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public TextureInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000B76")]
			[Cpp2IlInjected.Address(RVA = "0xA5D4A80", Offset = "0xA5D3480", VA = "0x18A5D4A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B77")]
			[Cpp2IlInjected.Address(RVA = "0xA5D4AA0", Offset = "0xA5D34A0", VA = "0x18A5D4AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0xA5D4B30", Offset = "0xA5D3530", VA = "0x18A5D4B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4B70", Offset = "0xA5D3570", VA = "0x18A5D4B70")]
		public static implicit operator _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
			return default(_MaterialTexture);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4880", Offset = "0xA5D3280", VA = "0x18A5D4880")]
		public _MaterialTexture(Func<TextureInfo> getter, Action initialize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4970", Offset = "0xA5D3370", VA = "0x18A5D4970")]
		public _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4860", Offset = "0xA5D3260", VA = "0x18A5D4860")]
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
			[Cpp2IlInjected.Address(RVA = "0x515F8D0", Offset = "0x515E2D0", VA = "0x18515F8D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x515F440", Offset = "0x515DE40", VA = "0x18515F440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000B87")]
			[Cpp2IlInjected.Address(RVA = "0x515FCD0", Offset = "0x515E6D0", VA = "0x18515FCD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x515FF80", Offset = "0x515E980", VA = "0x18515FF80")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x51601A0", Offset = "0x515EBA0", VA = "0x1851601A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		object IMaterialParameter.Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0x515E110", Offset = "0x515CB10", VA = "0x18515E110", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8B")]
			[Cpp2IlInjected.Address(RVA = "0x515E550", Offset = "0x515CF50", VA = "0x18515E550", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x515EE90", Offset = "0x515D890", VA = "0x18515EE90")]
		internal _MaterialParameter(_MaterialParameterKey key, T defval, Func<T> getter, Action<T> setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x515D0A0", Offset = "0x515BAA0", VA = "0x18515D0A0")]
		internal static Vector4 Combine(IReadOnlyList<IMaterialParameter> parameters)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x515ADA0", Offset = "0x51597A0", VA = "0x18515ADA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C8550", Offset = "0xA5C6F50", VA = "0x18A5C8550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public bool HasMorphingCurves
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0xE06A00", Offset = "0xE05400", VA = "0x180E06A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public IAnimationSampler<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public IAnimationSampler<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public IAnimationSampler<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C85B0", Offset = "0xA5C6FB0", VA = "0x18A5C85B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C8570", Offset = "0xA5C6F70", VA = "0x18A5C8570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public IAnimationSampler<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8030", Offset = "0xA5C6A30", VA = "0x18A5C8030")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0xA5C81E0", Offset = "0xA5C6BE0", VA = "0x18A5C81E0")]
		internal NodeCurveSamplers(Node node, Animation animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x7CF2D40", Offset = "0x7CF1740", VA = "0x187CF2D40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0xA5C78B0", Offset = "0xA5C62B0", VA = "0x18A5C78B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0xA5C85F0", Offset = "0xA5C6FF0", VA = "0x18A5C85F0")]
		public static bool operator ==([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8620", Offset = "0xA5C7020", VA = "0x18A5C8620")]
		public static bool operator !=([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7880", Offset = "0xA5C6280", VA = "0x18A5C7880", Slot = "4")]
		public bool Equals(NodeCurveSamplers other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x37CF2F0", Offset = "0x37CDCF0", VA = "0x1837CF2F0")]
		public IAnimationSampler<TWeights> GetMorphingSampler<TWeights>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7930", Offset = "0xA5C6330", VA = "0x18A5C7930")]
		public AffineTransform GetLocalTransform(float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x3D7F100", Offset = "0x3D7DB00", VA = "0x183D7F100")]
		public IReadOnlyList<float> GetMorphingWeights<TWeight>(float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7DE0", Offset = "0xA5C67E0", VA = "0x18A5C7DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5D3A50", Offset = "0xA5D2450", VA = "0x18A5D3A50")]
		public static Memory<byte> ReadBytesToEnd(this Stream s)
		{
			return default(Memory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4570", Offset = "0xA5D2F70", VA = "0x18A5D4570")]
		internal static bool _TryReadUInt32(this BinaryReader r, [Out] uint result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0xA5D40B0", Offset = "0xA5D2AB0", VA = "0x18A5D40B0")]
		internal static bool _Identify(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3400", Offset = "0xA5D1E00", VA = "0x18A5D3400")]
		internal static bool IsBinaryHeader(ReadOnlySpan<byte> span)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3490", Offset = "0xA5D1E90", VA = "0x18A5D3490")]
		public static bool IsBinaryHeader(byte a, byte b, byte c, byte d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D34C0", Offset = "0xA5D1EC0", VA = "0x18A5D34C0")]
		public static IReadOnlyDictionary<uint, byte[]> ReadBinaryFile(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4270", Offset = "0xA5D2C70", VA = "0x18A5D4270")]
		private static long _ReadBinaryHeader(BinaryReader binaryReader)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3280", Offset = "0xA5D1C80", VA = "0x18A5D3280")]
		public static Exception IsBinaryCompatible(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3D80", Offset = "0xA5D2780", VA = "0x18A5D3D80")]
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
			[Cpp2IlInjected.Address(RVA = "0xF50890", Offset = "0xF4F290", VA = "0x180F50890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(RVA = "0xF50430", Offset = "0xF4EE30", VA = "0x180F50430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9210", Offset = "0xA5C7C10", VA = "0x18A5C9210")]
		public static ReadContext Create(FileReaderCallback callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8F50", Offset = "0xA5C7950", VA = "0x18A5C8F50")]
		public static ReadContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8DD0", Offset = "0xA5C77D0", VA = "0x18A5C8DD0")]
		public static ReadContext CreateFromDictionary(IReadOnlyDictionary<string, ArraySegment<byte>> dictionary, bool checkExtensions = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB5C0", Offset = "0xA5C9FC0", VA = "0x18A5CB5C0")]
		private ReadContext(FileReaderCallback reader, [Optional] UriResolver uriResolver, bool checkExtensions = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA6D0", Offset = "0xA5C90D0", VA = "0x18A5CA6D0")]
		public ReadContext WithSettingsFrom(ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB630", Offset = "0xA5CA030", VA = "0x18A5CB630")]
		internal ReadContext(ReadContext other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA2E0", Offset = "0xA5C8CE0", VA = "0x18A5CA2E0")]
		public bool TryGetFullPath(string relativeUri, [Out] string fullPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0xA5C93D0", Offset = "0xA5C7DD0", VA = "0x18A5C93D0")]
		public Stream OpenFile(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9500", Offset = "0xA5C7F00", VA = "0x18A5C9500")]
		public ArraySegment<byte> ReadAllBytesToEnd(string resourceName)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA340", Offset = "0xA5C8D40", VA = "0x18A5CA340")]
		public ValidationResult Validate(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9B40", Offset = "0xA5C8540", VA = "0x18A5C9B40")]
		public ModelRoot ReadSchema2(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9DA0", Offset = "0xA5C87A0", VA = "0x18A5C9DA0")]
		public ModelRoot ReadSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA110", Offset = "0xA5C8B10", VA = "0x18A5CA110")]
		public ModelRoot ReadTextSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0xA5C95C0", Offset = "0xA5C7FC0", VA = "0x18A5C95C0")]
		public ModelRoot ReadBinarySchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA7B0", Offset = "0xA5C91B0", VA = "0x18A5CA7B0")]
		private static ModelRoot _FilterErrors((ModelRoot Model, ValidationResult Validation) mv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA970", Offset = "0xA5C9370", VA = "0x18A5CA970")]
		private (ModelRoot, ValidationResult) _ReadGLB(Stream stream)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0xA5CADB0", Offset = "0xA5C97B0", VA = "0x18A5CADB0")]
		private (ModelRoot, ValidationResult) _Read(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0xA5CA830", Offset = "0xA5C9230", VA = "0x18A5CA830")]
		private ReadOnlyMemory<byte> _Preprocess(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default(ReadOnlyMemory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9320", Offset = "0xA5C7D20", VA = "0x18A5C9320")]
		public static bool IdentifyBinaryContainer(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0xA5C98F0", Offset = "0xA5C82F0", VA = "0x18A5C98F0")]
		public static string ReadJson(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0xA5C9750", Offset = "0xA5C8150", VA = "0x18A5C9750")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECB10", VA = "0x180CEE110")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A40", Offset = "0xCF0440", VA = "0x180CF1A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public ImageDecodeCallback ImageDecoder
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE3")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0410", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public JsonFilterCallback JsonPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB990", Offset = "0xA5CA390", VA = "0x18A5CB990")]
		public static implicit operator ReadSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB980", Offset = "0xA5CA380", VA = "0x18A5CB980")]
		public ReadSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB860", Offset = "0xA5CA260", VA = "0x18A5CB860")]
		public ReadSettings(ReadSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB780", Offset = "0xA5CA180", VA = "0x18A5CB780")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECB50", VA = "0x180CEE150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0xCEE160", Offset = "0xCECB60", VA = "0x180CEE160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		internal bool _UpdateSupportedExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4380", Offset = "0xCF2D80", VA = "0x180CF4380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFB")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF2D60", VA = "0x180CF4360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		internal bool _NoCloneWatchdog
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4320", Offset = "0xCF2D20", VA = "0x180CF4320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFD")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C50", Offset = "0xCF3650", VA = "0x180CF4C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1B60", Offset = "0xA5D0560", VA = "0x18A5D1B60")]
		public static WriteContext Create(FileWriterCallback fileCallback, [Optional] Func<string, Stream> streamWriteCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D16E0", Offset = "0xA5D00E0", VA = "0x18A5D16E0")]
		public static WriteContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1510", Offset = "0xA5CFF10", VA = "0x18A5D1510")]
		public static WriteContext CreateFromDictionary(IDictionary<string, ArraySegment<byte>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1920", Offset = "0xA5D0320", VA = "0x18A5D1920")]
		public static WriteContext CreateFromStream(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1D00", Offset = "0xA5D0700", VA = "0x18A5D1D00")]
		public WriteContext WithTextSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1C80", Offset = "0xA5D0680", VA = "0x18A5D1C80")]
		public WriteContext WithBinarySettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1CD0", Offset = "0xA5D06D0", VA = "0x18A5D1CD0")]
		public WriteContext WithSettingsFrom(WriteSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1CC0", Offset = "0xA5D06C0", VA = "0x18A5D1CC0")]
		internal WriteContext WithDeepCloneSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0xA5D2F80", Offset = "0xA5D1980", VA = "0x18A5D2F80")]
		private WriteContext(FileWriterCallback byteWriteCallback, Func<string, Stream> streamWriteCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1D20", Offset = "0xA5D0720", VA = "0x18A5D1D20")]
		public void WriteAllBytesToEnd(string fileName, ArraySegment<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D2320", Offset = "0xA5D0D20", VA = "0x18A5D2320")]
		public string WriteImage(string assetName, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0xA5D2550", Offset = "0xA5D0F50", VA = "0x18A5D2550")]
		public void WriteTextSchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1D60", Offset = "0xA5D0760", VA = "0x18A5D1D60")]
		public void WriteBinarySchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0xA5D2E00", Offset = "0xA5D1800", VA = "0x18A5D2E00")]
		private void _ValidateBeforeWriting(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0xA5D29F0", Offset = "0xA5D13F0", VA = "0x18A5D29F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF070", VA = "0x180D00670")]
			[CompilerGenerated]
			get
			{
				return default(ResourceWriteMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0xD45780", Offset = "0xD44180", VA = "0x180D45780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public ImageWriterCallback ImageWriteCallback
		{
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0180", VA = "0x180CF1780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000C15")]
			[Cpp2IlInjected.Address(RVA = "0xD4DD70", Offset = "0xD4C770", VA = "0x180D4DD70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C16")]
			[Cpp2IlInjected.Address(RVA = "0xD4F0D0", Offset = "0xD4DAD0", VA = "0x180D4F0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public int BuffersMaxSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000C17")]
			[Cpp2IlInjected.Address(RVA = "0xD3EFF0", Offset = "0xD3D9F0", VA = "0x180D3EFF0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C18")]
			[Cpp2IlInjected.Address(RVA = "0x16D7CE0", Offset = "0x16D66E0", VA = "0x1816D7CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public bool JsonIndented
		{
			[Cpp2IlInjected.Token(Token = "0x6000C19")]
			[Cpp2IlInjected.Address(RVA = "0xA5D31F0", Offset = "0xA5D1BF0", VA = "0x18A5D31F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1A")]
			[Cpp2IlInjected.Address(RVA = "0xA5D3270", Offset = "0xA5D1C70", VA = "0x18A5D3270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public JsonWriterOptions JsonOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1B")]
			[Cpp2IlInjected.Address(RVA = "0xF00A10", Offset = "0xEFF410", VA = "0x180F00A10")]
			get
			{
				return default(JsonWriterOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0x4B45060", Offset = "0x4B43A60", VA = "0x184B45060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public ValidationMode Validation
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1D990", VA = "0x180D1EF90")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(RVA = "0xDE9880", Offset = "0xDE8280", VA = "0x180DE9880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public JsonFilterCallback JsonPostprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1F")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2DA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C20")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2D70", VA = "0x180CF4370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3200", Offset = "0xA5D1C00", VA = "0x18A5D3200")]
		public static implicit operator WriteSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0xA5D30F0", Offset = "0xA5D1AF0", VA = "0x18A5D30F0")]
		public WriteSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3110", Offset = "0xA5D1B10", VA = "0x18A5D3110")]
		public WriteSettings(WriteSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0xA5D2FF0", Offset = "0xA5D19F0", VA = "0x18A5D2FF0")]
		public void CopyTo(WriteSettings other)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	internal static class _Schema2Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5640", Offset = "0xA5D4040", VA = "0x18A5D5640")]
		public static void SetMorphWeights(this IList<double> list, int maxCount, SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5080", Offset = "0xA5D3A80", VA = "0x18A5D5080")]
		public static void SetMorphWeights(this IList<double> list, IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4B90", Offset = "0xA5D3590", VA = "0x18A5D4B90")]
		internal static string AsName(this string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x41533E0", Offset = "0x4151DE0", VA = "0x1841533E0")]
		internal static T AsValue<T>(this T? value, T defval) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x41521A0", Offset = "0x4150BA0", VA = "0x1841521A0")]
		internal static T? AsNullable<T>(this T value, T defval) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x4152250", Offset = "0x4150C50", VA = "0x184152250")]
		internal static T? AsNullable<T>(this T value, T defval, T minval, T maxval) where T : struct, IEquatable<T>, IComparable<T>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4BC0", Offset = "0xA5D35C0", VA = "0x18A5D4BC0")]
		internal static Vector2? AsNullable(this Vector2 value, Vector2 defval, Vector2 minval, Vector2 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4CF0", Offset = "0xA5D36F0", VA = "0x18A5D4CF0")]
		internal static Vector3? AsNullable(this Vector3 value, Vector3 defval, Vector3 minval, Vector3 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4E80", Offset = "0xA5D3880", VA = "0x18A5D4E80")]
		internal static Vector4? AsNullable(this Vector4 value, Vector4 defval, Vector4 minval, Vector4 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5050", Offset = "0xA5D3A50", VA = "0x18A5D5050")]
		internal static string AsNullable(this string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4B90", Offset = "0xA5D3590", VA = "0x18A5D4B90")]
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
			[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6A90", VA = "0x180EC8090")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B9960", Offset = "0xA5B8360", VA = "0x18A5B9960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B9970", Offset = "0xA5B8370", VA = "0x18A5B9970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9800", Offset = "0xA5B8200", VA = "0x18A5B9800")]
		public static void Verify(IReflectionObject reflectionObject, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9620", Offset = "0xA5B8020", VA = "0x18A5B9620")]
		public static FieldInfo From(IReflectionObject reflectionObject, string path)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBED0", Offset = "0x3ACA8D0", VA = "0x183ACBED0")]
		public static FieldInfo From<TInstance, TValue>(string name, TInstance instance, Func<TInstance, TValue> getter)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0xA5B98F0", Offset = "0xA5B82F0", VA = "0x18A5B98F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5112B50", Offset = "0x5111550", VA = "0x185112B50", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5CE5A0", Offset = "0xA5CCFA0", VA = "0x18A5CE5A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C44")]
			[Cpp2IlInjected.Address(RVA = "0x5145310", Offset = "0x5143D10", VA = "0x185145310")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C45")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE5F0", Offset = "0xA5CCFF0", VA = "0x18A5CE5F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE260", Offset = "0xA5CCC60", VA = "0x18A5CE260", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE6B0", Offset = "0xA5CD0B0", VA = "0x18A5CE6B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE560", Offset = "0xA5CCF60", VA = "0x18A5CE560", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4B")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE4C0", Offset = "0xA5CCEC0", VA = "0x18A5CE4C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE4C0", Offset = "0xA5CCEC0", VA = "0x18A5CE4C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public const string SCHEMANAME = "Object";

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC8D0", Offset = "0xA5BB2D0", VA = "0x18A5BC8D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8F20", Offset = "0xA5B7920", VA = "0x18A5B8F20", Slot = "11")]
		protected virtual IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC9A0", Offset = "0xA5BB3A0", VA = "0x18A5BC9A0", Slot = "12")]
		protected virtual bool TryReflectField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC900", Offset = "0xA5BB300", VA = "0x18A5BC900", Slot = "9")]
		[IteratorStateMachine(typeof(<SharpGLTF-Reflection-IReflectionObject-GetFields>d__4))]
		IEnumerable<FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC980", Offset = "0xA5BB380", VA = "0x18A5BC980", Slot = "10")]
		bool IReflectionObject.TryGetField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC8C0", Offset = "0xA5BB2C0", VA = "0x18A5BC8C0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B5950", Offset = "0xA5B4350", VA = "0x18A5B5950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5360", Offset = "0xA5B3D60", VA = "0x18A5B5360")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5AB0", Offset = "0xA5B44B0", VA = "0x18A5B5AB0")]
		public static implicit operator AttributeFormat(IndexEncodingType indexer)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B59E0", Offset = "0xA5B43E0", VA = "0x18A5B59E0")]
		public static implicit operator AttributeFormat(EncodingType enc)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A60", Offset = "0xA5B4460", VA = "0x18A5B5A60")]
		public static implicit operator AttributeFormat(DimensionType dim)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5B00", Offset = "0xA5B4500", VA = "0x18A5B5B00")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A20", Offset = "0xA5B4420", VA = "0x18A5B5A20")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc, bool nrm) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0xA5B58B0", Offset = "0xA5B42B0", VA = "0x18A5B58B0")]
		public AttributeFormat(IndexEncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5760", Offset = "0xA5B4160", VA = "0x18A5B5760")]
		public AttributeFormat(EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5900", Offset = "0xA5B4300", VA = "0x18A5B5900")]
		public AttributeFormat(DimensionType dim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0xA5B57A0", Offset = "0xA5B41A0", VA = "0x18A5B57A0")]
		public AttributeFormat(DimensionType dim, EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0xA5B57E0", Offset = "0xA5B41E0", VA = "0x18A5B57E0")]
		public AttributeFormat(DimensionType dim, EncodingType enc, bool nrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0xA5B52F0", Offset = "0xA5B3CF0", VA = "0x18A5B52F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5150", Offset = "0xA5B3B50", VA = "0x18A5B5150")]
		public static bool AreEqual(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5170", Offset = "0xA5B3B70", VA = "0x18A5B5170", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5260", Offset = "0xA5B3C60", VA = "0x18A5B5260", Slot = "4")]
		public bool Equals(AttributeFormat other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5960", Offset = "0xA5B4360", VA = "0x18A5B5960")]
		public static bool operator ==(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5B50", Offset = "0xA5B4550", VA = "0x18A5B5B50")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B6A20", Offset = "0xA5B5420", VA = "0x18A5B6A20")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0xA5B68F0", Offset = "0xA5B52F0", VA = "0x18A5B68F0", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6AA0", Offset = "0xA5B54A0", VA = "0x18A5B6AA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6890", Offset = "0xA5B5290", VA = "0x18A5B6890")]
		public ColorArray(Memory<byte> source, int byteStride = 0, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6730", Offset = "0xA5B5130", VA = "0x18A5B6730")]
		public ColorArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0xA5B63D0", Offset = "0xA5B4DD0", VA = "0x18A5B63D0", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6670", Offset = "0xA5B5070", VA = "0x18A5B6670", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0xA5B60F0", Offset = "0xA5B4AF0", VA = "0x18A5B60F0", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6490", Offset = "0xA5B4E90", VA = "0x18A5B6490", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6190", Offset = "0xA5B4B90", VA = "0x18A5B6190", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xA5B62B0", Offset = "0xA5B4CB0", VA = "0x18A5B62B0")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B65F0", Offset = "0xA5B4FF0", VA = "0x18A5B65F0", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6630", Offset = "0xA5B5030", VA = "0x18A5B6630", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6530", Offset = "0xA5B4F30", VA = "0x18A5B6530", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6570", Offset = "0xA5B4F70", VA = "0x18A5B6570", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0xA5B65B0", Offset = "0xA5B4FB0", VA = "0x18A5B65B0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B61330", Offset = "0x5B5FD30", VA = "0x185B61330", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x5B60B30", Offset = "0x5B5F530", VA = "0x185B60B30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x5B61070", Offset = "0x5B5FA70", VA = "0x185B61070")]
		public EncodedArrayEnumerator(IReadOnlyList<T> accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x5B60900", Offset = "0x5B5F300", VA = "0x185B60900", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x5B60910", Offset = "0x5B5F310", VA = "0x185B60910", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	internal static class EncodedArrayUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6B40", Offset = "0xA5B5540", VA = "0x18A5B6B40")]
		public static void _CopyTo(this IEnumerable<int> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0xA5B6E20", Offset = "0xA5B5820", VA = "0x18A5B6E20")]
		public static void _CopyTo(this IEnumerable<bool> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x3934FF0", Offset = "0x39339F0", VA = "0x183934FF0")]
		public static void _CopyTo<T>(this IEnumerable<T> src, IList<T> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x3937C40", Offset = "0x3936640", VA = "0x183937C40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BB700", Offset = "0xA5BA100", VA = "0x18A5BB700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000C92")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C93")]
			[Cpp2IlInjected.Address(RVA = "0xA5BB780", Offset = "0xA5BA180", VA = "0x18A5BB780")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C94")]
			[Cpp2IlInjected.Address(RVA = "0xA5BB870", Offset = "0xA5BA270", VA = "0x18A5BB870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public float this[int rowIndex, int subIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C95")]
			[Cpp2IlInjected.Address(RVA = "0xA5BB740", Offset = "0xA5BA140", VA = "0x18A5BB740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C96")]
			[Cpp2IlInjected.Address(RVA = "0xA5BB7B0", Offset = "0xA5BA1B0", VA = "0x18A5BB7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0xA5BAB20", Offset = "0xA5B9520", VA = "0x18A5BAB20")]
		public FloatingAccessor(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA1F0", Offset = "0xA5B8BF0", VA = "0x18A5BA1F0")]
		private float _GetValueU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA9D0", Offset = "0xA5B93D0", VA = "0x18A5BA9D0")]
		private void _SetValueU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9DA0", Offset = "0xA5B87A0", VA = "0x18A5B9DA0")]
		private float _GetValueS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA5D0", Offset = "0xA5B8FD0", VA = "0x18A5BA5D0")]
		private void _SetValueS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9F10", Offset = "0xA5B8910", VA = "0x18A5B9F10")]
		private float _GetValueU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA720", Offset = "0xA5B9120", VA = "0x18A5BA720")]
		private void _SetValueU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9C30", Offset = "0xA5B8630", VA = "0x18A5B9C30")]
		private float _GetValueS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA480", Offset = "0xA5B8E80", VA = "0x18A5BA480")]
		private void _SetValueS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA080", Offset = "0xA5B8A80", VA = "0x18A5BA080")]
		private float _GetValueU32(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA870", Offset = "0xA5B9270", VA = "0x18A5BA870")]
		private void _SetValueU32(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9C10", Offset = "0xA5B8610", VA = "0x18A5B9C10")]
		private float _GetNormalizedU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA470", Offset = "0xA5B8E70", VA = "0x18A5BA470")]
		private void _SetNormalizedU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9B70", Offset = "0xA5B8570", VA = "0x18A5B9B70")]
		private float _GetNormalizedS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA3E0", Offset = "0xA5B8DE0", VA = "0x18A5BA3E0")]
		private void _SetNormalizedS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9BF0", Offset = "0xA5B85F0", VA = "0x18A5B9BF0")]
		private float _GetNormalizedU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA460", Offset = "0xA5B8E60", VA = "0x18A5BA460")]
		private void _SetNormalizedU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9AF0", Offset = "0xA5B84F0", VA = "0x18A5B9AF0")]
		private float _GetNormalizedS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA360", Offset = "0xA5B8D60", VA = "0x18A5BA360")]
		private void _SetNormalizedS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2380", Offset = "0x3AD0D80", VA = "0x183AD2380")]
		private T _GetValue<T>(int byteOffset) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x3AD2C70", Offset = "0x3AD1670", VA = "0x183AD2C70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5CC0D0", Offset = "0xA5CAAD0", VA = "0x18A5CC0D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA3")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA4")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC0A0", Offset = "0xA5CAAA0", VA = "0x18A5CC0A0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA5")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC150", Offset = "0xA5CAB50", VA = "0x18A5CC150", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0xA5CC000", Offset = "0xA5CAA00", VA = "0x18A5CC000")]
		public ScalarArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA0")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBF60", Offset = "0xA5CA960", VA = "0x18A5CBF60")]
		public ScalarArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBC30", Offset = "0xA5CA630", VA = "0x18A5CBC30", Slot = "9")]
		public IEnumerator<float> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBEB0", Offset = "0xA5CA8B0", VA = "0x18A5CBEB0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0xA5CB9F0", Offset = "0xA5CA3F0", VA = "0x18A5CB9F0", Slot = "20")]
		public bool Contains(float item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBCE0", Offset = "0xA5CA6E0", VA = "0x18A5CBCE0", Slot = "13")]
		public int IndexOf(float item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBA10", Offset = "0xA5CA410", VA = "0x18A5CBA10", Slot = "21")]
		public void CopyTo(float[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBB20", Offset = "0xA5CA520", VA = "0x18A5CBB20")]
		public void Fill(IEnumerable<float> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBE30", Offset = "0xA5CA830", VA = "0x18A5CBE30", Slot = "14")]
		void IList<float>.Insert(int index, float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAD")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBE70", Offset = "0xA5CA870", VA = "0x18A5CBE70", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBD70", Offset = "0xA5CA770", VA = "0x18A5CBD70", Slot = "18")]
		void ICollection<float>.Add(float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAF")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBDB0", Offset = "0xA5CA7B0", VA = "0x18A5CBDB0", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0xA5CBDF0", Offset = "0xA5CA7F0", VA = "0x18A5CBDF0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D04C0", Offset = "0xA5CEEC0", VA = "0x18A5D04C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		bool ICollection<Vector2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB5")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public Vector2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB6")]
			[Cpp2IlInjected.Address(RVA = "0xA5D0430", Offset = "0xA5CEE30", VA = "0x18A5D0430", Slot = "11")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB7")]
			[Cpp2IlInjected.Address(RVA = "0xA5D0540", Offset = "0xA5CEF40", VA = "0x18A5D0540", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0390", Offset = "0xA5CED90", VA = "0x18A5D0390")]
		public Vector2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D02F0", Offset = "0xA5CECF0", VA = "0x18A5D02F0")]
		public Vector2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0xA5CFFC0", Offset = "0xA5CE9C0", VA = "0x18A5CFFC0", Slot = "9")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB9")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0240", Offset = "0xA5CEC40", VA = "0x18A5D0240", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBA")]
		[Cpp2IlInjected.Address(RVA = "0xA5CFD80", Offset = "0xA5CE780", VA = "0x18A5CFD80", Slot = "20")]
		public bool Contains(Vector2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0070", Offset = "0xA5CEA70", VA = "0x18A5D0070", Slot = "13")]
		public int IndexOf(Vector2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBC")]
		[Cpp2IlInjected.Address(RVA = "0xA5CFDA0", Offset = "0xA5CE7A0", VA = "0x18A5CFDA0", Slot = "21")]
		public void CopyTo(Vector2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBD")]
		[Cpp2IlInjected.Address(RVA = "0xA5CFEB0", Offset = "0xA5CE8B0", VA = "0x18A5CFEB0")]
		public void Fill(IEnumerable<Vector2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D01C0", Offset = "0xA5CEBC0", VA = "0x18A5D01C0", Slot = "14")]
		void IList<Vector2>.Insert(int index, Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0200", Offset = "0xA5CEC00", VA = "0x18A5D0200", Slot = "15")]
		void IList<Vector2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0100", Offset = "0xA5CEB00", VA = "0x18A5D0100", Slot = "18")]
		void ICollection<Vector2>.Add(Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0140", Offset = "0xA5CEB40", VA = "0x18A5D0140", Slot = "19")]
		void ICollection<Vector2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0180", Offset = "0xA5CEB80", VA = "0x18A5D0180", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D0DB0", Offset = "0xA5CF7B0", VA = "0x18A5D0DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		bool ICollection<Vector3>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC7")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public Vector3 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0xA5D0CE0", Offset = "0xA5CF6E0", VA = "0x18A5D0CE0", Slot = "11")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC9")]
			[Cpp2IlInjected.Address(RVA = "0xA5D0E30", Offset = "0xA5CF830", VA = "0x18A5D0E30", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0BA0", Offset = "0xA5CF5A0", VA = "0x18A5D0BA0")]
		public Vector3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC4")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0C40", Offset = "0xA5CF640", VA = "0x18A5D0C40")]
		public Vector3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCA")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0860", Offset = "0xA5CF260", VA = "0x18A5D0860", Slot = "9")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0AF0", Offset = "0xA5CF4F0", VA = "0x18A5D0AF0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D05A0", Offset = "0xA5CEFA0", VA = "0x18A5D05A0", Slot = "20")]
		public bool Contains(Vector3 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0910", Offset = "0xA5CF310", VA = "0x18A5D0910", Slot = "13")]
		public int IndexOf(Vector3 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0640", Offset = "0xA5CF040", VA = "0x18A5D0640", Slot = "21")]
		public void CopyTo(Vector3[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0750", Offset = "0xA5CF150", VA = "0x18A5D0750")]
		public void Fill(IEnumerable<Vector3> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0A70", Offset = "0xA5CF470", VA = "0x18A5D0A70", Slot = "14")]
		void IList<Vector3>.Insert(int index, Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0AB0", Offset = "0xA5CF4B0", VA = "0x18A5D0AB0", Slot = "15")]
		void IList<Vector3>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D09B0", Offset = "0xA5CF3B0", VA = "0x18A5D09B0", Slot = "18")]
		void ICollection<Vector3>.Add(Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D09F0", Offset = "0xA5CF3F0", VA = "0x18A5D09F0", Slot = "19")]
		void ICollection<Vector3>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0A30", Offset = "0xA5CF430", VA = "0x18A5D0A30", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D1490", Offset = "0xA5CFE90", VA = "0x18A5D1490")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD9")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDA")]
			[Cpp2IlInjected.Address(RVA = "0xA5C8C30", Offset = "0xA5C7630", VA = "0x18A5C8C30", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDB")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE4E0", Offset = "0xA5BCEE0", VA = "0x18A5BE4E0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE1F0", Offset = "0xA5BCBF0", VA = "0x18A5BE1F0")]
		public Vector4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE290", Offset = "0xA5BCC90", VA = "0x18A5BE290")]
		public Vector4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1160", Offset = "0xA5CFB60", VA = "0x18A5D1160", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D13E0", Offset = "0xA5CFDE0", VA = "0x18A5D13E0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0EB0", Offset = "0xA5CF8B0", VA = "0x18A5D0EB0", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1210", Offset = "0xA5CFC10", VA = "0x18A5D1210", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D0F40", Offset = "0xA5CF940", VA = "0x18A5D0F40", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1050", Offset = "0xA5CFA50", VA = "0x18A5D1050")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1360", Offset = "0xA5CFD60", VA = "0x18A5D1360", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D13A0", Offset = "0xA5CFDA0", VA = "0x18A5D13A0", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE4")]
		[Cpp2IlInjected.Address(RVA = "0xA5D12A0", Offset = "0xA5CFCA0", VA = "0x18A5D12A0", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE5")]
		[Cpp2IlInjected.Address(RVA = "0xA5D12E0", Offset = "0xA5CFCE0", VA = "0x18A5D12E0", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1320", Offset = "0xA5CFD20", VA = "0x18A5D1320", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C8D50", Offset = "0xA5C7750", VA = "0x18A5C8D50")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		bool ICollection<Quaternion>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEB")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public Quaternion this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEC")]
			[Cpp2IlInjected.Address(RVA = "0xA5C8C30", Offset = "0xA5C7630", VA = "0x18A5C8C30", Slot = "11")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CED")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE4E0", Offset = "0xA5BCEE0", VA = "0x18A5BE4E0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE1F0", Offset = "0xA5BCBF0", VA = "0x18A5BE1F0")]
		public QuaternionArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE290", Offset = "0xA5BCC90", VA = "0x18A5BE290")]
		public QuaternionArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8900", Offset = "0xA5C7300", VA = "0x18A5C8900", Slot = "9")]
		public IEnumerator<Quaternion> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8B80", Offset = "0xA5C7580", VA = "0x18A5C8B80", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8650", Offset = "0xA5C7050", VA = "0x18A5C8650", Slot = "20")]
		public bool Contains(Quaternion item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0xA5C89B0", Offset = "0xA5C73B0", VA = "0x18A5C89B0", Slot = "13")]
		public int IndexOf(Quaternion item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0xA5C86E0", Offset = "0xA5C70E0", VA = "0x18A5C86E0", Slot = "21")]
		public void CopyTo(Quaternion[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xA5C87F0", Offset = "0xA5C71F0", VA = "0x18A5C87F0")]
		public void Fill(IEnumerable<Quaternion> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8B00", Offset = "0xA5C7500", VA = "0x18A5C8B00", Slot = "14")]
		void IList<Quaternion>.Insert(int index, Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8B40", Offset = "0xA5C7540", VA = "0x18A5C8B40", Slot = "15")]
		void IList<Quaternion>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF6")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8A40", Offset = "0xA5C7440", VA = "0x18A5C8A40", Slot = "18")]
		void ICollection<Quaternion>.Add(Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF7")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8A80", Offset = "0xA5C7480", VA = "0x18A5C8A80", Slot = "19")]
		void ICollection<Quaternion>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF8")]
		[Cpp2IlInjected.Address(RVA = "0xA5C8AC0", Offset = "0xA5C74C0", VA = "0x18A5C8AC0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BE460", Offset = "0xA5BCE60", VA = "0x18A5BE460")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFD")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFE")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE330", Offset = "0xA5BCD30", VA = "0x18A5BE330", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFF")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE4E0", Offset = "0xA5BCEE0", VA = "0x18A5BE4E0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF9")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE1F0", Offset = "0xA5BCBF0", VA = "0x18A5BE1F0")]
		public Matrix2x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFA")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE290", Offset = "0xA5BCC90", VA = "0x18A5BE290")]
		public Matrix2x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D00")]
		[Cpp2IlInjected.Address(RVA = "0xA5BDEB0", Offset = "0xA5BC8B0", VA = "0x18A5BDEB0", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D01")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE140", Offset = "0xA5BCB40", VA = "0x18A5BE140", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D02")]
		[Cpp2IlInjected.Address(RVA = "0xA5BDBF0", Offset = "0xA5BC5F0", VA = "0x18A5BDBF0", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D03")]
		[Cpp2IlInjected.Address(RVA = "0xA5BDF60", Offset = "0xA5BC960", VA = "0x18A5BDF60", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D04")]
		[Cpp2IlInjected.Address(RVA = "0xA5BDC90", Offset = "0xA5BC690", VA = "0x18A5BDC90", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D05")]
		[Cpp2IlInjected.Address(RVA = "0xA5BDDA0", Offset = "0xA5BC7A0", VA = "0x18A5BDDA0")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE0C0", Offset = "0xA5BCAC0", VA = "0x18A5BE0C0", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D07")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE100", Offset = "0xA5BCB00", VA = "0x18A5BE100", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D08")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE000", Offset = "0xA5BCA00", VA = "0x18A5BE000", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D09")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE040", Offset = "0xA5BCA40", VA = "0x18A5BE040", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0A")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE080", Offset = "0xA5BCA80", VA = "0x18A5BE080", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BEE60", Offset = "0xA5BD860", VA = "0x18A5BEE60")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0F")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D10")]
			[Cpp2IlInjected.Address(RVA = "0xA5BECC0", Offset = "0xA5BD6C0", VA = "0x18A5BECC0", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D11")]
			[Cpp2IlInjected.Address(RVA = "0xA5BEEE0", Offset = "0xA5BD8E0", VA = "0x18A5BEEE0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0B")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEB80", Offset = "0xA5BD580", VA = "0x18A5BEB80")]
		public Matrix3x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0C")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEC20", Offset = "0xA5BD620", VA = "0x18A5BEC20")]
		public Matrix3x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D12")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE840", Offset = "0xA5BD240", VA = "0x18A5BE840", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D13")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEAD0", Offset = "0xA5BD4D0", VA = "0x18A5BEAD0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D14")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE580", Offset = "0xA5BCF80", VA = "0x18A5BE580", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D15")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE8F0", Offset = "0xA5BD2F0", VA = "0x18A5BE8F0", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D16")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE620", Offset = "0xA5BD020", VA = "0x18A5BE620", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D17")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE730", Offset = "0xA5BD130", VA = "0x18A5BE730")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D18")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEA50", Offset = "0xA5BD450", VA = "0x18A5BEA50", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D19")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEA90", Offset = "0xA5BD490", VA = "0x18A5BEA90", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1A")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE990", Offset = "0xA5BD390", VA = "0x18A5BE990", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1B")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE9D0", Offset = "0xA5BD3D0", VA = "0x18A5BE9D0", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1C")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEA10", Offset = "0xA5BD410", VA = "0x18A5BEA10", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BF960", Offset = "0xA5BE360", VA = "0x18A5BF960")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D21")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D22")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF6B0", Offset = "0xA5BE0B0", VA = "0x18A5BF6B0", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D23")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF9E0", Offset = "0xA5BE3E0", VA = "0x18A5BF9E0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1D")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF570", Offset = "0xA5BDF70", VA = "0x18A5BF570")]
		public Matrix3x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1E")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF610", Offset = "0xA5BE010", VA = "0x18A5BF610")]
		public Matrix3x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D24")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF210", Offset = "0xA5BDC10", VA = "0x18A5BF210", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D25")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF4C0", Offset = "0xA5BDEC0", VA = "0x18A5BF4C0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D26")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEFB0", Offset = "0xA5BD9B0", VA = "0x18A5BEFB0", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D27")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF2C0", Offset = "0xA5BDCC0", VA = "0x18A5BF2C0", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEFF0", Offset = "0xA5BD9F0", VA = "0x18A5BEFF0", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF100", Offset = "0xA5BDB00", VA = "0x18A5BF100")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF440", Offset = "0xA5BDE40", VA = "0x18A5BF440", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF480", Offset = "0xA5BDE80", VA = "0x18A5BF480", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2C")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF380", Offset = "0xA5BDD80", VA = "0x18A5BF380", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2D")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF3C0", Offset = "0xA5BDDC0", VA = "0x18A5BF3C0", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2E")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF400", Offset = "0xA5BDE00", VA = "0x18A5BF400", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C0560", Offset = "0xA5BEF60", VA = "0x18A5C0560")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D33")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D34")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0200", Offset = "0xA5BEC00", VA = "0x18A5C0200", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D35")]
			[Cpp2IlInjected.Address(RVA = "0xA5C05E0", Offset = "0xA5BEFE0", VA = "0x18A5C05E0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0160", Offset = "0xA5BEB60", VA = "0x18A5C0160")]
		public Matrix4x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D30")]
		[Cpp2IlInjected.Address(RVA = "0xA5C00C0", Offset = "0xA5BEAC0", VA = "0x18A5C00C0")]
		public Matrix4x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D36")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFD60", Offset = "0xA5BE760", VA = "0x18A5BFD60", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D37")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0010", Offset = "0xA5BEA10", VA = "0x18A5C0010", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D38")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFB00", Offset = "0xA5BE500", VA = "0x18A5BFB00", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D39")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFE10", Offset = "0xA5BE810", VA = "0x18A5BFE10", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3A")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFB40", Offset = "0xA5BE540", VA = "0x18A5BFB40", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3B")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFC50", Offset = "0xA5BE650", VA = "0x18A5BFC50")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3C")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFF90", Offset = "0xA5BE990", VA = "0x18A5BFF90", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3D")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFFD0", Offset = "0xA5BE9D0", VA = "0x18A5BFFD0", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3E")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFED0", Offset = "0xA5BE8D0", VA = "0x18A5BFED0", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3F")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFF10", Offset = "0xA5BE910", VA = "0x18A5BFF10", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D40")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFF50", Offset = "0xA5BE950", VA = "0x18A5BFF50", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C1280", Offset = "0xA5BFC80", VA = "0x18A5C1280")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D45")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D46")]
			[Cpp2IlInjected.Address(RVA = "0xA5C0E50", Offset = "0xA5BF850", VA = "0x18A5C0E50", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D47")]
			[Cpp2IlInjected.Address(RVA = "0xA5C1300", Offset = "0xA5BFD00", VA = "0x18A5C1300", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D41")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0DB0", Offset = "0xA5BF7B0", VA = "0x18A5C0DB0")]
		public Matrix4x4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D42")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0D10", Offset = "0xA5BF710", VA = "0x18A5C0D10")]
		public Matrix4x4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0xA5C09B0", Offset = "0xA5BF3B0", VA = "0x18A5C09B0", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0C60", Offset = "0xA5BF660", VA = "0x18A5C0C60", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4A")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0750", Offset = "0xA5BF150", VA = "0x18A5C0750", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4B")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0A60", Offset = "0xA5BF460", VA = "0x18A5C0A60", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0790", Offset = "0xA5BF190", VA = "0x18A5C0790", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C08A0", Offset = "0xA5BF2A0", VA = "0x18A5C08A0")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0BE0", Offset = "0xA5BF5E0", VA = "0x18A5C0BE0", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0C20", Offset = "0xA5BF620", VA = "0x18A5C0C20", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D50")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0B20", Offset = "0xA5BF520", VA = "0x18A5C0B20", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D51")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0B60", Offset = "0xA5BF560", VA = "0x18A5C0B60", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D52")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0BA0", Offset = "0xA5BF5A0", VA = "0x18A5C0BA0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C76D0", Offset = "0xA5C60D0", VA = "0x18A5C76D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF070", VA = "0x180D00670", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF4FFA0", VA = "0x180F515A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D57")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public float[] this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D58")]
			[Cpp2IlInjected.Address(RVA = "0xA5C7660", Offset = "0xA5C6060", VA = "0x18A5C7660", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D59")]
			[Cpp2IlInjected.Address(RVA = "0xA5C7750", Offset = "0xA5C6150", VA = "0x18A5C7750", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D53")]
		[Cpp2IlInjected.Address(RVA = "0xA5C75C0", Offset = "0xA5C5FC0", VA = "0x18A5C75C0")]
		public MultiArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5A")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6F00", Offset = "0xA5C5900", VA = "0x18A5C6F00")]
		public void CopyItemTo(int index, float[] dstItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5B")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7270", Offset = "0xA5C5C70", VA = "0x18A5C7270", Slot = "9")]
		public IEnumerator<float[]> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7500", Offset = "0xA5C5F00", VA = "0x18A5C7500", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5D")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6EE0", Offset = "0xA5C58E0", VA = "0x18A5C6EE0", Slot = "20")]
		public bool Contains(float[] item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7330", Offset = "0xA5C5D30", VA = "0x18A5C7330", Slot = "13")]
		public int IndexOf(float[] item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5F")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7030", Offset = "0xA5C5A30", VA = "0x18A5C7030", Slot = "21")]
		public void CopyTo(float[][] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D60")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7150", Offset = "0xA5C5B50", VA = "0x18A5C7150")]
		public void Fill(IEnumerable<float[]> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D61")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7480", Offset = "0xA5C5E80", VA = "0x18A5C7480", Slot = "14")]
		void IList<float>.Insert(int index, float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0xA5C74C0", Offset = "0xA5C5EC0", VA = "0x18A5C74C0", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0xA5C73C0", Offset = "0xA5C5DC0", VA = "0x18A5C73C0", Slot = "18")]
		void ICollection<float>.Add(float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7400", Offset = "0xA5C5E00", VA = "0x18A5C7400", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D65")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7440", Offset = "0xA5C5E40", VA = "0x18A5C7440", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6C")]
			[Cpp2IlInjected.Address(RVA = "0x514F900", Offset = "0x514E300", VA = "0x18514F900", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D6D")]
			[Cpp2IlInjected.Address(RVA = "0x514E530", Offset = "0x514CF30", VA = "0x18514E530", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6E")]
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF4FFA0", VA = "0x180F515A0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x514F550", Offset = "0x514DF50", VA = "0x18514F550")]
		static ZeroAccessorArray()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6A")]
		[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
		public ZeroAccessorArray(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6F")]
		[Cpp2IlInjected.Address(RVA = "0x514D940", Offset = "0x514C340", VA = "0x18514D940", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D70")]
		[Cpp2IlInjected.Address(RVA = "0x514B750", Offset = "0x514A150", VA = "0x18514B750", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D71")]
		[Cpp2IlInjected.Address(RVA = "0x514CA70", Offset = "0x514B470", VA = "0x18514CA70", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D72")]
		[Cpp2IlInjected.Address(RVA = "0x514D390", Offset = "0x514BD90", VA = "0x18514D390", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D73")]
		[Cpp2IlInjected.Address(RVA = "0x514D390", Offset = "0x514BD90", VA = "0x18514D390", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D74")]
		[Cpp2IlInjected.Address(RVA = "0x514E530", Offset = "0x514CF30", VA = "0x18514E530", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D75")]
		[Cpp2IlInjected.Address(RVA = "0x50B70B0", Offset = "0x50B5AB0", VA = "0x1850B70B0", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D76")]
		[Cpp2IlInjected.Address(RVA = "0x50B70B0", Offset = "0x50B5AB0", VA = "0x1850B70B0", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D77")]
		[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D78")]
		[Cpp2IlInjected.Address(RVA = "0x50B70B0", Offset = "0x50B5AB0", VA = "0x1850B70B0", Slot = "22")]
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
				[Cpp2IlInjected.Address(RVA = "0x1329660", Offset = "0x1328060", VA = "0x181329660", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8C12D30", Offset = "0x8C11730", VA = "0x188C12D30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D88")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D89")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8A")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC830", Offset = "0xA5CB230", VA = "0x18A5CC830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8C")]
			[Cpp2IlInjected.Address(RVA = "0xA5CC8D0", Offset = "0xA5CB2D0", VA = "0x18A5CC8D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8E")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8F")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D90")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE700", Offset = "0xA5CD100", VA = "0x18A5CE700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D92")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE7D0", Offset = "0xA5CD1D0", VA = "0x18A5CE7D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B5FD0", Offset = "0xA5B49D0", VA = "0x18A5B5FD0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D7B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B6080", Offset = "0xA5B4A80", VA = "0x18A5B6080", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7C")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5F80", Offset = "0xA5B4980", VA = "0x18A5B5F80", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D79")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6AB0", VA = "0x180EC80B0")]
		public BooleanArrayOverIntegerArray(IAccessorArray<uint> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5BD0", Offset = "0xA5B45D0", VA = "0x18A5B5BD0", Slot = "20")]
		public bool Contains(bool item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5D10", Offset = "0xA5B4710", VA = "0x18A5B5D10", Slot = "13")]
		public int IndexOf(bool item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D80")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5BF0", Offset = "0xA5B45F0", VA = "0x18A5B5BF0", Slot = "21")]
		public void CopyTo(bool[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D81")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5CA0", Offset = "0xA5B46A0", VA = "0x18A5B5CA0", Slot = "9")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__12))]
		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D82")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5F10", Offset = "0xA5B4910", VA = "0x18A5B5F10", Slot = "10")]
		[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__13))]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D83")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E90", Offset = "0xA5B4890", VA = "0x18A5B5E90", Slot = "14")]
		void IList<bool>.Insert(int index, bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D84")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5ED0", Offset = "0xA5B48D0", VA = "0x18A5B5ED0", Slot = "15")]
		void IList<bool>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D85")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5DD0", Offset = "0xA5B47D0", VA = "0x18A5B5DD0", Slot = "18")]
		void ICollection<bool>.Add(bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D86")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E10", Offset = "0xA5B4810", VA = "0x18A5B5E10", Slot = "19")]
		void ICollection<bool>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D87")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E50", Offset = "0xA5B4850", VA = "0x18A5B5E50", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BC840", Offset = "0xA5BB240", VA = "0x18A5BC840")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5BC800", Offset = "0xA5BB200", VA = "0x18A5BC800", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		bool ICollection<uint>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9E")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public uint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B12840", Offset = "0x2B11240", VA = "0x182B12840", Slot = "11")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DA0")]
			[Cpp2IlInjected.Address(RVA = "0x86F6E70", Offset = "0x86F5870", VA = "0x1886F6E70", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D94")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC7C0", Offset = "0xA5BB1C0", VA = "0x18A5BC7C0")]
		public IntegerArray(Memory<byte> source, IndexEncodingType encoding = IndexEncodingType.UNSIGNED_INT)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D95")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC2F0", Offset = "0xA5BACF0", VA = "0x18A5BC2F0")]
		public IntegerArray(Memory<byte> source, int byteOffset, int itemsCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D96")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC1E0", Offset = "0xA5BABE0", VA = "0x18A5BC1E0")]
		private uint _GetValueU8(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D97")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC290", Offset = "0xA5BAC90", VA = "0x18A5BC290")]
		private void _SetValueU8(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D98")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC190", Offset = "0xA5BAB90", VA = "0x18A5BC190")]
		private uint _GetValueU16(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D99")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC230", Offset = "0xA5BAC30", VA = "0x18A5BC230")]
		private void _SetValueU16(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9A")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD630", Offset = "0x3BAC030", VA = "0x183BAD630")]
		private T _GetValue<T>(int index) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9B")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD900", Offset = "0x3BAC300", VA = "0x183BAD900")]
		private void _SetValue<T>(int index, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA1")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBE70", Offset = "0xA5BA870", VA = "0x18A5BBE70", Slot = "9")]
		public IEnumerator<uint> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA2")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC0E0", Offset = "0xA5BAAE0", VA = "0x18A5BC0E0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA3")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBB00", Offset = "0xA5BA500", VA = "0x18A5BBB00", Slot = "20")]
		public bool Contains(uint item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA4")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBF20", Offset = "0xA5BA920", VA = "0x18A5BBF20", Slot = "13")]
		public int IndexOf(uint item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA5")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBB20", Offset = "0xA5BA520", VA = "0x18A5BBB20", Slot = "21")]
		public void CopyTo(uint[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA6")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBC40", Offset = "0xA5BA640", VA = "0x18A5BBC40")]
		public void Fill(IEnumerable<int> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA7")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBD50", Offset = "0xA5BA750", VA = "0x18A5BBD50")]
		public void Fill(IEnumerable<uint> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC060", Offset = "0xA5BAA60", VA = "0x18A5BC060", Slot = "14")]
		void IList<uint>.Insert(int index, uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA9")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC0A0", Offset = "0xA5BAAA0", VA = "0x18A5BC0A0", Slot = "15")]
		void IList<uint>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAA")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBFA0", Offset = "0xA5BA9A0", VA = "0x18A5BBFA0", Slot = "18")]
		void ICollection<uint>.Add(uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAB")]
		[Cpp2IlInjected.Address(RVA = "0xA5BBFE0", Offset = "0xA5BA9E0", VA = "0x18A5BBFE0", Slot = "19")]
		void ICollection<uint>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAC")]
		[Cpp2IlInjected.Address(RVA = "0xA5BC020", Offset = "0xA5BAA20", VA = "0x18A5BC020", Slot = "22")]
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
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87230", VA = "0x180D88830", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5E3680", Offset = "0xA5E2080", VA = "0x18A5E3680", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF1")]
			[Cpp2IlInjected.Address(RVA = "0x1D01620", Offset = "0x1D00020", VA = "0x181D01620")]
			[DebuggerHidden]
			public <GetItemsAsRawBytes>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF2")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF3")]
			[Cpp2IlInjected.Address(RVA = "0xA5E3410", Offset = "0xA5E1E10", VA = "0x18A5E3410", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF5")]
			[Cpp2IlInjected.Address(RVA = "0xA5E3640", Offset = "0xA5E2040", VA = "0x18A5E3640", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF7")]
			[Cpp2IlInjected.Address(RVA = "0xA5E35A0", Offset = "0xA5E1FA0", VA = "0x18A5E35A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ArraySegment<byte>> IEnumerable<ArraySegment<byte>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF8")]
			[Cpp2IlInjected.Address(RVA = "0xA5E35A0", Offset = "0xA5E1FA0", VA = "0x18A5E35A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xF37BB0", Offset = "0xF365B0", VA = "0x180F37BB0")]
			[CompilerGenerated]
			get
			{
				return default(MemoryAccessInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBA")]
			[Cpp2IlInjected.Address(RVA = "0x50E5390", Offset = "0x50E3D90", VA = "0x1850E5390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public ArraySegment<byte> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000DBB")]
			[Cpp2IlInjected.Address(RVA = "0x166BAB0", Offset = "0x166A4B0", VA = "0x18166BAB0")]
			[CompilerGenerated]
			get
			{
				return default(ArraySegment<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBC")]
			[Cpp2IlInjected.Address(RVA = "0xA5C6EC0", Offset = "0xA5C58C0", VA = "0x18A5C6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB5")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6A50", Offset = "0xA5C5450", VA = "0x18A5C6A50")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB6")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6D40", Offset = "0xA5C5740", VA = "0x18A5C6D40")]
		public MemoryAccessor(byte[] data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB7")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6E50", Offset = "0xA5C5850", VA = "0x18A5C6E50")]
		public MemoryAccessor(ArraySegment<byte> data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB8")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6DF0", Offset = "0xA5C57F0", VA = "0x18A5C6DF0")]
		public MemoryAccessor(MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBD")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4F20", Offset = "0xA5C3920", VA = "0x18A5C4F20")]
		public void Update(ArraySegment<byte> data, MemoryAccessInfo encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBE")]
		[Cpp2IlInjected.Address(RVA = "0x3D069D0", Offset = "0x3D053D0", VA = "0x183D069D0")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBF")]
		[Cpp2IlInjected.Address(RVA = "0xA5C17A0", Offset = "0xA5C01A0", VA = "0x18A5C17A0")]
		public IntegerArray AsIntegerArray()
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC0")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2810", Offset = "0xA5C1210", VA = "0x18A5C2810")]
		public ScalarArray AsScalarArray()
		{
			return default(ScalarArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC1")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2A80", Offset = "0xA5C1480", VA = "0x18A5C2A80")]
		public Vector2Array AsVector2Array()
		{
			return default(Vector2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC2")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2CF0", Offset = "0xA5C16F0", VA = "0x18A5C2CF0")]
		public Vector3Array AsVector3Array()
		{
			return default(Vector3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC3")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2F60", Offset = "0xA5C1960", VA = "0x18A5C2F60")]
		public Vector4Array AsVector4Array()
		{
			return default(Vector4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC4")]
		[Cpp2IlInjected.Address(RVA = "0xA5C25A0", Offset = "0xA5C0FA0", VA = "0x18A5C25A0")]
		public QuaternionArray AsQuaternionArray()
		{
			return default(QuaternionArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC5")]
		[Cpp2IlInjected.Address(RVA = "0xA5C1980", Offset = "0xA5C0380", VA = "0x18A5C1980")]
		public Matrix2x2Array AsMatrix2x2Array()
		{
			return default(Matrix2x2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC6")]
		[Cpp2IlInjected.Address(RVA = "0xA5C1BF0", Offset = "0xA5C05F0", VA = "0x18A5C1BF0")]
		public Matrix3x3Array AsMatrix3x3Array()
		{
			return default(Matrix3x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC7")]
		[Cpp2IlInjected.Address(RVA = "0xA5C1E60", Offset = "0xA5C0860", VA = "0x18A5C1E60")]
		public Matrix4x3Array AsMatrix4x3Array()
		{
			return default(Matrix4x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC8")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2090", Offset = "0xA5C0A90", VA = "0x18A5C2090")]
		public Matrix4x4Array AsMatrix4x4Array()
		{
			return default(Matrix4x4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC9")]
		[Cpp2IlInjected.Address(RVA = "0xA5C14D0", Offset = "0xA5BFED0", VA = "0x18A5C14D0")]
		public ColorArray AsColorArray(float defaultW = 1f)
		{
			return default(ColorArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCA")]
		[Cpp2IlInjected.Address(RVA = "0xA5C2300", Offset = "0xA5C0D00", VA = "0x18A5C2300")]
		public MultiArray AsMultiArray(int dimensions)
		{
			return default(MultiArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCB")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3DA0", Offset = "0xA5C27A0", VA = "0x18A5C3DA0")]
		[IteratorStateMachine(typeof(<GetItemsAsRawBytes>d__26))]
		public IEnumerable<ArraySegment<byte>> GetItemsAsRawBytes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCC")]
		[Cpp2IlInjected.Address(RVA = "0xA5C31D0", Offset = "0xA5C1BD0", VA = "0x18A5C31D0")]
		public (MemoryAccessor, MemoryAccessor) ConvertToSparse()
		{
			return default((MemoryAccessor, MemoryAccessor));
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCD")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4120", Offset = "0xA5C2B20", VA = "0x18A5C4120")]
		private bool RepresentsZeroValue(ArraySegment<byte> bytes)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCE")]
		[Cpp2IlInjected.Address(RVA = "0x3D09990", Offset = "0x3D08390", VA = "0x183D09990")]
		public static IAccessorArray<T> CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCF")]
		[Cpp2IlInjected.Address(RVA = "0x3D09B50", Offset = "0x3D08550", VA = "0x183D09B50")]
		public static IAccessorArray<T> CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD0")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3B60", Offset = "0xA5C2560", VA = "0x18A5C3B60")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD1")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3C80", Offset = "0xA5C2680", VA = "0x18A5C3C80")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD2")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B330", Offset = "0x3D09D30", VA = "0x183D0B330")]
		private static IAccessorArray<T> _CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD3")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B070", Offset = "0x3D09A70", VA = "0x183D0B070")]
		private static IAccessorArray<T> _CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD4")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4370", Offset = "0xA5C2D70", VA = "0x18A5C4370")]
		public static void SanitizeVertexAttributes(MemoryAccessor[] vertexAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD5")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3F00", Offset = "0xA5C2900", VA = "0x18A5C3F00")]
		public static bool HaveOverlappingBuffers(MemoryAccessor a, MemoryAccessor b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD6")]
		[Cpp2IlInjected.Address(RVA = "0xA5C68D0", Offset = "0xA5C52D0", VA = "0x18A5C68D0")]
		internal ArraySegment<byte> _GetBytes()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD7")]
		[Cpp2IlInjected.Address(RVA = "0xA5C3E20", Offset = "0xA5C2820", VA = "0x18A5C3E20")]
		public static bool HaveOverlappingBuffers(IEnumerable<MemoryAccessor> abc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD8")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4560", Offset = "0xA5C2F60", VA = "0x18A5C4560")]
		public static void SanitizeWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD9")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6AC0", Offset = "0xA5C54C0", VA = "0x18A5C6AC0")]
		private static bool _SanitizeWeightSum(Span<byte> dst, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDA")]
		[Cpp2IlInjected.Address(RVA = "0xA5C5D30", Offset = "0xA5C4730", VA = "0x18A5C5D30")]
		public static void VerifyWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDB")]
		[Cpp2IlInjected.Address(RVA = "0xA5C6690", Offset = "0xA5C5090", VA = "0x18A5C6690")]
		private static bool _CheckWeightSum(ReadOnlySpan<byte> src, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDC")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4F80", Offset = "0xA5C3980", VA = "0x18A5C4F80")]
		public static void VerifyAccessorBounds(MemoryAccessor memory, IReadOnlyList<double> min, IReadOnlyList<double> max)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDD")]
		[Cpp2IlInjected.Address(RVA = "0xA5C5A00", Offset = "0xA5C4400", VA = "0x18A5C5A00")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D6120", Offset = "0xA5D4B20", VA = "0x18A5D6120", Slot = "4")]
			public int Compare(string x, string y)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0E")]
			[Cpp2IlInjected.Address(RVA = "0xA5D6160", Offset = "0xA5D4B60", VA = "0x18A5D6160")]
			private static int _GetSortingScore(string attribute)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF60D0", VA = "0x180CF76D0")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public readonly EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000E01")]
			[Cpp2IlInjected.Address(RVA = "0xDDD830", Offset = "0xDDC230", VA = "0x180DDD830")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public readonly bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x6000E02")]
			[Cpp2IlInjected.Address(RVA = "0xE97170", Offset = "0xE95B70", VA = "0x180E97170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public readonly int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E03")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF070", VA = "0x180D00670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public readonly int PaddedByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E04")]
			[Cpp2IlInjected.Address(RVA = "0xA5DF380", Offset = "0xA5DDD80", VA = "0x18A5DF380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public readonly int StepByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E05")]
			[Cpp2IlInjected.Address(RVA = "0xA5DF3D0", Offset = "0xA5DDDD0", VA = "0x18A5DF3D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public readonly bool IsValidVertexAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x6000E06")]
			[Cpp2IlInjected.Address(RVA = "0xA5DF280", Offset = "0xA5DDC80", VA = "0x18A5DF280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public readonly bool IsValidIndexer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E07")]
			[Cpp2IlInjected.Address(RVA = "0xA5DF1E0", Offset = "0xA5DDBE0", VA = "0x18A5DF1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		internal static IComparer<string> NameComparer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E0A")]
			[Cpp2IlInjected.Address(RVA = "0xA5DF330", Offset = "0xA5DDD30", VA = "0x18A5DF330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E0B")]
			[Cpp2IlInjected.Address(RVA = "0xA5DF430", Offset = "0xA5DDE30", VA = "0x18A5DF430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEE60", Offset = "0xA5DD860", VA = "0x18A5DEE60")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFA")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE780", Offset = "0xA5DD180", VA = "0x18A5DE780")]
		public static MemoryAccessInfo[] Create(params string[] attributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDFC0", Offset = "0xA5DC9C0", VA = "0x18A5DDFC0")]
		public static MemoryAccessInfo CreateDefaultElement(string attribute)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFC")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF190", Offset = "0xA5DDB90", VA = "0x18A5DF190")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF090", Offset = "0xA5DDA90", VA = "0x18A5DF090")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, DimensionType dimensions, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFE")]
		[Cpp2IlInjected.Address(RVA = "0xA5DECC0", Offset = "0xA5DD6C0", VA = "0x18A5DECC0")]
		public readonly MemoryAccessInfo Slice(int itemStart, int itemCount)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEDE0", Offset = "0xA5DD7E0", VA = "0x18A5DEDE0")]
		public readonly MemoryAccessInfo WithFormat(AttributeFormat newFormat)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E08")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE8B0", Offset = "0xA5DD2B0", VA = "0x18A5DE8B0")]
		public static int SetInterleavedInfo(MemoryAccessInfo[] attributes, int byteOffset, int itemsCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E09")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEB00", Offset = "0xA5DD500", VA = "0x18A5DEB00")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E24B0", Offset = "0xA5E0EB0", VA = "0x18A5E24B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public static MemoryImage Empty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E15")]
			[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FCEF0", VA = "0x1810FE4F0")]
			get
			{
				return default(MemoryImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		private ArraySegment<byte> _Image
		{
			[Cpp2IlInjected.Token(Token = "0x6000E25")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2EE0", Offset = "0xA5E18E0", VA = "0x18A5E2EE0")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2C")]
			[Cpp2IlInjected.Address(RVA = "0xA5E27B0", Offset = "0xA5E11B0", VA = "0x18A5E27B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public ReadOnlyMemory<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2D")]
			[Cpp2IlInjected.Address(RVA = "0xA5E23E0", Offset = "0xA5E0DE0", VA = "0x18A5E23E0")]
			get
			{
				return default(ReadOnlyMemory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public string SourcePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2E")]
			[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25AD0", VA = "0x180F270D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public bool IsPng
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2F")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2B00", Offset = "0xA5E1500", VA = "0x18A5E2B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public bool IsJpg
		{
			[Cpp2IlInjected.Token(Token = "0x6000E30")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2920", Offset = "0xA5E1320", VA = "0x18A5E2920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public bool IsDds
		{
			[Cpp2IlInjected.Token(Token = "0x6000E31")]
			[Cpp2IlInjected.Address(RVA = "0xA5E26F0", Offset = "0xA5E10F0", VA = "0x18A5E26F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public bool IsWebp
		{
			[Cpp2IlInjected.Token(Token = "0x6000E32")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2C40", Offset = "0xA5E1640", VA = "0x18A5E2C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public bool IsKtx2
		{
			[Cpp2IlInjected.Token(Token = "0x6000E33")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2A40", Offset = "0xA5E1440", VA = "0x18A5E2A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public bool IsExtendedFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000E34")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2880", Offset = "0xA5E1280", VA = "0x18A5E2880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000E35")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2BC0", Offset = "0xA5E15C0", VA = "0x18A5E2BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public string FileExtension
		{
			[Cpp2IlInjected.Token(Token = "0x6000E36")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2510", Offset = "0xA5E0F10", VA = "0x18A5E2510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public string MimeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000E37")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2D00", Offset = "0xA5E1700", VA = "0x18A5E2D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E13")]
		[Cpp2IlInjected.Address(RVA = "0xA5E02D0", Offset = "0xA5DECD0", VA = "0x18A5E02D0")]
		public string ToDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E16")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2FD0", Offset = "0xA5E19D0", VA = "0x18A5E2FD0")]
		public static implicit operator MemoryImage(ArraySegment<byte> image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E17")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3060", Offset = "0xA5E1A60", VA = "0x18A5E3060")]
		public static implicit operator MemoryImage(byte[] image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E18")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3080", Offset = "0xA5E1A80", VA = "0x18A5E3080")]
		public static implicit operator MemoryImage(string filePath)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E19")]
		[Cpp2IlInjected.Address(RVA = "0xA5E12C0", Offset = "0xA5DFCC0", VA = "0x18A5E12C0")]
		public static bool TryParseMime64(Uri mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0DF0", Offset = "0xA5DF7F0", VA = "0x18A5E0DF0")]
		public static bool TryParseMime64(string mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E21D0", Offset = "0xA5E0BD0", VA = "0x18A5E21D0")]
		public MemoryImage(ArraySegment<byte> image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1FE0", Offset = "0xA5E09E0", VA = "0x18A5E1FE0")]
		public MemoryImage(byte[] image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2330", Offset = "0xA5E0D30", VA = "0x18A5E2330")]
		public MemoryImage(Func<ArraySegment<byte>> factory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2060", Offset = "0xA5E0A60", VA = "0x18A5E2060")]
		public MemoryImage(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1F60", Offset = "0xA5E0960", VA = "0x18A5E1F60")]
		internal MemoryImage(byte[] image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E20")]
		[Cpp2IlInjected.Address(RVA = "0xA5E22A0", Offset = "0xA5E0CA0", VA = "0x18A5E22A0")]
		internal MemoryImage(ArraySegment<byte> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E21")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2250", Offset = "0xA5E0C50", VA = "0x18A5E2250")]
		internal MemoryImage(MemoryImage image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E22")]
		[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC000", VA = "0x1810DD600")]
		internal MemoryImage(Lazy<ArraySegment<byte>> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E23")]
		[Cpp2IlInjected.Address(RVA = "0xA5E19A0", Offset = "0xA5E03A0", VA = "0x18A5E19A0")]
		private static Lazy<ArraySegment<byte>> _ToLazy(byte[] bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E24")]
		[Cpp2IlInjected.Address(RVA = "0xA5E18B0", Offset = "0xA5E02B0", VA = "0x18A5E18B0")]
		private static Lazy<ArraySegment<byte>> _ToLazy(ArraySegment<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E26")]
		[Cpp2IlInjected.Address(RVA = "0xA5DFA20", Offset = "0xA5DE420", VA = "0x18A5DFA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E27")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF4A0", Offset = "0xA5DDEA0", VA = "0x18A5DF4A0")]
		public static bool AreEqual(MemoryImage a, MemoryImage b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E28")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF8D0", Offset = "0xA5DE2D0", VA = "0x18A5DF8D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E29")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF9A0", Offset = "0xA5DE3A0", VA = "0x18A5DF9A0", Slot = "4")]
		public bool Equals(MemoryImage other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2F60", Offset = "0xA5E1960", VA = "0x18A5E2F60")]
		public static bool operator ==(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E30A0", Offset = "0xA5E1AA0", VA = "0x18A5E30A0")]
		public static bool operator !=(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E38")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0C10", Offset = "0xA5DF610", VA = "0x18A5E0C10")]
		public static string TrimImageExtension(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E39")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1A20", Offset = "0xA5E0420", VA = "0x18A5E1A20")]
		internal static void _Verify(MemoryImage image, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DFE10", Offset = "0xA5DE810", VA = "0x18A5DFE10")]
		public Stream Open()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0070", Offset = "0xA5DEA70", VA = "0x18A5E0070")]
		public void SaveToFile(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1330", Offset = "0xA5DFD30", VA = "0x18A5E1330")]
		internal ArraySegment<byte> _GetBuffer()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0830", Offset = "0xA5DF230", VA = "0x18A5E0830")]
		internal string ToMime64(bool withPrefix = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DFB00", Offset = "0xA5DE500", VA = "0x18A5DFB00")]
		public bool IsImageOfType(string format)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E16D0", Offset = "0xA5E00D0", VA = "0x18A5E16D0")]
		private static bool _IsPngImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E40")]
		[Cpp2IlInjected.Address(RVA = "0xA5E15F0", Offset = "0xA5DFFF0", VA = "0x18A5E15F0")]
		private static bool _IsJpgImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E41")]
		[Cpp2IlInjected.Address(RVA = "0xA5E13E0", Offset = "0xA5DFDE0", VA = "0x18A5E13E0")]
		private static bool _IsDdsImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E42")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1780", Offset = "0xA5E0180", VA = "0x18A5E1780")]
		private static bool _IsWebpImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E43")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1670", Offset = "0xA5E0070", VA = "0x18A5E1670")]
		private static bool _IsKtx2Image(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E44")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1490", Offset = "0xA5DFE90", VA = "0x18A5E1490")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5DDFA0", Offset = "0xA5DC9A0", VA = "0x18A5DDFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E49")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDC20", Offset = "0xA5DC620", VA = "0x18A5DDC20")]
		public static bool TryGetHeader(IReadOnlyList<byte> data, [Out] Ktx2Header header)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDDB0", Offset = "0xA5DC7B0", VA = "0x18A5DDDB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A3D750", Offset = "0x7A3C150", VA = "0x187A3D750")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A3D0D0", Offset = "0x7A3BAD0", VA = "0x187A3D0D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4E")]
			[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4F")]
			[Cpp2IlInjected.Address(RVA = "0x7A3D5F0", Offset = "0x7A3BFF0", VA = "0x187A3D5F0", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E50")]
			[Cpp2IlInjected.Address(RVA = "0x7A3D7F0", Offset = "0x7A3C1F0", VA = "0x187A3D7F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4B")]
		[Cpp2IlInjected.Address(RVA = "0x7A3C970", Offset = "0x7A3B370", VA = "0x187A3C970")]
		public SparseArray(IReadOnlyList<T> denseValues, IReadOnlyList<T> sparseValues, IReadOnlyList<uint> sparseKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E51")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B6E0", Offset = "0x7A3A0E0", VA = "0x187A3B6E0", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E52")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B6E0", Offset = "0x7A3A0E0", VA = "0x187A3B6E0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E53")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B060", Offset = "0x7A39A60", VA = "0x187A3B060", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E54")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B7C0", Offset = "0x7A3A1C0", VA = "0x187A3B7C0", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E55")]
		[Cpp2IlInjected.Address(RVA = "0x7A3B600", Offset = "0x7A3A000", VA = "0x187A3B600", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E56")]
		[Cpp2IlInjected.Address(RVA = "0x514E530", Offset = "0x514CF30", VA = "0x18514E530", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E57")]
		[Cpp2IlInjected.Address(RVA = "0x50B70B0", Offset = "0x50B5AB0", VA = "0x1850B70B0", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E58")]
		[Cpp2IlInjected.Address(RVA = "0x50B70B0", Offset = "0x50B5AB0", VA = "0x1850B70B0", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E59")]
		[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5A")]
		[Cpp2IlInjected.Address(RVA = "0x50B70B0", Offset = "0x50B5AB0", VA = "0x1850B70B0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x7679FE0", Offset = "0x76789E0", VA = "0x187679FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD290", Offset = "0xA5DBC90", VA = "0x18A5DD290")]
		internal void ValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD230", Offset = "0xA5DBC30", VA = "0x18A5DD230")]
		internal void ValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "4")]
		protected virtual void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
		protected virtual void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E60")]
		[Cpp2IlInjected.Address(RVA = "0xA5DC230", Offset = "0xA5DAC30", VA = "0x18A5DC230", Slot = "6")]
		protected virtual string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E61")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD150", Offset = "0xA5DBB50", VA = "0x18A5DD150")]
		internal void Serialize(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E62")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void SerializeProperties(Utf8JsonWriter writer);

		[Cpp2IlInjected.Token(Token = "0x6000E63")]
		[Cpp2IlInjected.Address(RVA = "0xA5DCF30", Offset = "0xA5DB930", VA = "0x18A5DCF30")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E64")]
		[Cpp2IlInjected.Address(RVA = "0xA5DC260", Offset = "0xA5DAC60", VA = "0x18A5DC260")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, bool? value, [Optional] bool? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E65")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD000", Offset = "0xA5DBA00", VA = "0x18A5DD000")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, int? value, [Optional] int? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E66")]
		[Cpp2IlInjected.Address(RVA = "0xA5DC710", Offset = "0xA5DB110", VA = "0x18A5DC710")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, float? value, [Optional] float? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E67")]
		[Cpp2IlInjected.Address(RVA = "0xA5DCA20", Offset = "0xA5DB420", VA = "0x18A5DCA20")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, double? value, [Optional] double? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E68")]
		[Cpp2IlInjected.Address(RVA = "0xA5DC3D0", Offset = "0xA5DADD0", VA = "0x18A5DC3D0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector2? value, [Optional] Vector2? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E69")]
		[Cpp2IlInjected.Address(RVA = "0xA5DC550", Offset = "0xA5DAF50", VA = "0x18A5DC550")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector3? value, [Optional] Vector3? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DC860", Offset = "0xA5DB260", VA = "0x18A5DC860")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector4? value, [Optional] Vector4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DCB60", Offset = "0xA5DB560", VA = "0x18A5DCB60")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Quaternion? value, [Optional] Quaternion? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DCD20", Offset = "0xA5DB720", VA = "0x18A5DCD20")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Matrix4x4? value, [Optional] Matrix4x4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6D")]
		[Cpp2IlInjected.Address(RVA = "0x3BD99A0", Offset = "0x3BD83A0", VA = "0x183BD99A0")]
		protected static void SerializePropertyEnumValue<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD9390", Offset = "0x3BD7D90", VA = "0x183BD9390")]
		protected static void SerializePropertyEnumSymbol<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6F")]
		[Cpp2IlInjected.Address(RVA = "0x3BD9BF0", Offset = "0x3BD85F0", VA = "0x183BD9BF0")]
		protected static void SerializePropertyObject<T>(Utf8JsonWriter writer, string name, T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E70")]
		[Cpp2IlInjected.Address(RVA = "0x3BD9CC0", Offset = "0x3BD86C0", VA = "0x183BD9CC0")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyList<T> collection, [Optional] int? minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E71")]
		[Cpp2IlInjected.Address(RVA = "0x3BDA750", Offset = "0x3BD9150", VA = "0x183BDA750")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyDictionary<string, T> collection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E72")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD360", Offset = "0xA5DBD60", VA = "0x18A5DD360")]
		private static void _SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E73")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD2F0", Offset = "0xA5DBCF0", VA = "0x18A5DD2F0")]
		private static bool _IsNullOrEmpty(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E74")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD4F0", Offset = "0xA5DBEF0", VA = "0x18A5DD4F0")]
		private static void _SerializeValue(Utf8JsonWriter writer, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E75")]
		[Cpp2IlInjected.Address(RVA = "0xA5DC0F0", Offset = "0xA5DAAF0", VA = "0x18A5DC0F0")]
		internal void Deserialize(Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E76")]
		[Cpp2IlInjected.Address(RVA = "0xA5DBBE0", Offset = "0xA5DA5E0", VA = "0x18A5DBBE0")]
		protected static object DeserializeUnknownObject(Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E77")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader);

		[Cpp2IlInjected.Token(Token = "0x6000E78")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8210", Offset = "0x3BD6C10", VA = "0x183BD8210")]
		protected static T DeserializePropertyValue<T>(Utf8JsonReader reader)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E79")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8990", Offset = "0x3BD7390", VA = "0x183BD8990")]
		protected static void DeserializePropertyValue<TParent, T>(Utf8JsonReader reader, TParent owner, [Out] T property) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7A")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7B90", Offset = "0x3BD6590", VA = "0x183BD7B90")]
		protected static void DeserializePropertyList<TParent, T>(Utf8JsonReader reader, TParent owner, IList<T> list) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7480", Offset = "0x3BD5E80", VA = "0x183BD7480")]
		protected static void DeserializePropertyList<T>(Utf8JsonReader reader, IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7430", Offset = "0x3BD5E30", VA = "0x183BD7430")]
		protected static void DeserializePropertyDictionary<TParent, T>(Utf8JsonReader reader, TParent owner, IDictionary<string, T> dict) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7D")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7140", Offset = "0x3BD5B40", VA = "0x183BD7140")]
		protected static void DeserializePropertyDictionary<T>(Utf8JsonReader reader, IDictionary<string, T> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7E")]
		[Cpp2IlInjected.Address(RVA = "0x3BDB2B0", Offset = "0x3BD9CB0", VA = "0x183BDB2B0")]
		private static bool _TryCastValue<T>(Utf8JsonReader reader, [Out] object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected JsonSerializable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal static class _JSonSerializationExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000E80")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4840", Offset = "0xA5E3240", VA = "0x18A5E4840")]
		public static bool AsBoolean([In] this Utf8JsonReader reader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E81")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4E60", Offset = "0xA5E3860", VA = "0x18A5E4E60")]
		public static string AsString([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E82")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4970", Offset = "0xA5E3370", VA = "0x18A5E4970")]
		public static object AsEnum([In] this Utf8JsonReader reader, Type enumType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E83")]
		[Cpp2IlInjected.Address(RVA = "0xA5E51C0", Offset = "0xA5E3BC0", VA = "0x18A5E51C0")]
		public static object GetAnyValue([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E84")]
		[Cpp2IlInjected.Address(RVA = "0xA5E54D0", Offset = "0xA5E3ED0", VA = "0x18A5E54D0")]
		public static object GetValueAs([In] this Utf8JsonReader reader, Type vtype)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E85")]
		[Cpp2IlInjected.Address(RVA = "0x4143190", Offset = "0x4141B90", VA = "0x184143190")]
		public static T GetValueAs<T>([In] this Utf8JsonReader reader) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E86")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6570", Offset = "0xA5E4F70", VA = "0x18A5E6570")]
		public static bool TryWriteProperty(this Utf8JsonWriter writer, string property, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E87")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6E10", Offset = "0xA5E5810", VA = "0x18A5E6E10")]
		public static bool TryWriteValue(this Utf8JsonWriter writer, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E88")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7820", Offset = "0xA5E6220", VA = "0x18A5E7820")]
		public static void WriteVector2(this Utf8JsonWriter writer, Vector2 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E89")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7880", Offset = "0xA5E6280", VA = "0x18A5E7880")]
		public static void WriteVector3(this Utf8JsonWriter writer, Vector3 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7750", Offset = "0xA5E6150", VA = "0x18A5E7750")]
		public static void WriteVector4(this Utf8JsonWriter writer, Vector4 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7750", Offset = "0xA5E6150", VA = "0x18A5E7750")]
		public static void WriteQuaternion(this Utf8JsonWriter writer, Quaternion q)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7610", Offset = "0xA5E6010", VA = "0x18A5E7610")]
		public static void WriteMatrix4x4(this Utf8JsonWriter writer, Matrix4x4 m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4D10", Offset = "0xA5E3710", VA = "0x18A5E4D10")]
		public static Uri AsStringUri([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E77D0", Offset = "0xA5E61D0", VA = "0x18A5E77D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public IReadOnlyDictionary<string, JsonNode> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000E91")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4050", Offset = "0xA5E2A50", VA = "0x18A5E4050")]
		public UnknownNode(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E92")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3DE0", Offset = "0xA5E27E0", VA = "0x18A5E3DE0", Slot = "8")]
		protected override void DeserializeProperty(string property, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E93")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3E60", Offset = "0xA5E2860", VA = "0x18A5E3E60", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DA580", Offset = "0xA5D8F80", VA = "0x18A5DA580")]
		internal static string GetAttributeShortName(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E95")]
		[Cpp2IlInjected.Address(RVA = "0xA5DAFB0", Offset = "0xA5D99B0", VA = "0x18A5DAFB0")]
		public static string ToReport(this MemoryAccessInfo minfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E96")]
		[Cpp2IlInjected.Address(RVA = "0xA5DADC0", Offset = "0xA5D97C0", VA = "0x18A5DADC0")]
		public static string ToReport(this BufferView bv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E97")]
		[Cpp2IlInjected.Address(RVA = "0xA5DAD10", Offset = "0xA5D9710", VA = "0x18A5DAD10")]
		public static string ToReportShort(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E98")]
		[Cpp2IlInjected.Address(RVA = "0xA5DAAA0", Offset = "0xA5D94A0", VA = "0x18A5DAAA0")]
		public static string ToReportLong(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E99")]
		[Cpp2IlInjected.Address(RVA = "0xA5DB120", Offset = "0xA5D9B20", VA = "0x18A5DB120")]
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
			[Cpp2IlInjected.Address(RVA = "0x514FF00", Offset = "0x514E900", VA = "0x18514FF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA2")]
		[Cpp2IlInjected.Address(RVA = "0x514FE70", Offset = "0x514E870", VA = "0x18514FE70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E4820", Offset = "0xA5E3220", VA = "0x18A5E4820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA6")]
			[Cpp2IlInjected.Address(RVA = "0xA5E4800", Offset = "0xA5E3200", VA = "0x18A5E4800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA7")]
			[Cpp2IlInjected.Address(RVA = "0xA5E4780", Offset = "0xA5E3180", VA = "0x18A5E4780")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E4730", Offset = "0xA5E3130", VA = "0x18A5E4730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA4")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E41A0", Offset = "0xA5E2BA0", VA = "0x18A5E41A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public BufferView Source
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAB")]
			[Cpp2IlInjected.Address(RVA = "0xA5E45E0", Offset = "0xA5E2FE0", VA = "0x18A5E45E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public (DimensionType Dimensions, EncodingType Encoding, bool Normalized) Format
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAC")]
			[Cpp2IlInjected.Address(RVA = "0xA5E40F0", Offset = "0xA5E2AF0", VA = "0x18A5E40F0")]
			get
			{
				return default((DimensionType, EncodingType, bool));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		public object[] Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAD")]
			[Cpp2IlInjected.Address(RVA = "0xA5E4220", Offset = "0xA5E2C20", VA = "0x18A5E4220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA9")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FA7990", Offset = "0x1FA6390", VA = "0x181FA7990")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E7B60", Offset = "0xA5E6560", VA = "0x18A5E7B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAE")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E7960", Offset = "0xA5E6360", VA = "0x18A5E7960")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public (double X, double Y, double Z, double W) Row2
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB3")]
			[Cpp2IlInjected.Address(RVA = "0xA5E79E0", Offset = "0xA5E63E0", VA = "0x18A5E79E0")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public (double X, double Y, double Z, double W) Row3
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB4")]
			[Cpp2IlInjected.Address(RVA = "0xA5E7A60", Offset = "0xA5E6460", VA = "0x18A5E7A60")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public (double X, double Y, double Z, double W) Row4
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB5")]
			[Cpp2IlInjected.Address(RVA = "0xA5E7AE0", Offset = "0xA5E64E0", VA = "0x18A5E7AE0")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB1")]
		[Cpp2IlInjected.Address(RVA = "0xA5E78F0", Offset = "0xA5E62F0", VA = "0x18A5E78F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x517F170", Offset = "0x517DB70", VA = "0x18517F170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public ICollection<string> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB8")]
			[Cpp2IlInjected.Address(RVA = "0x517F910", Offset = "0x517E310", VA = "0x18517F910", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		IEnumerable<T> IReadOnlyDictionary<string, T>.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB9")]
			[Cpp2IlInjected.Address(RVA = "0x517F1F0", Offset = "0x517DBF0", VA = "0x18517F1F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public ICollection<T> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBA")]
			[Cpp2IlInjected.Address(RVA = "0x517F990", Offset = "0x517E390", VA = "0x18517F990", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBB")]
			[Cpp2IlInjected.Address(RVA = "0x517F860", Offset = "0x517E260", VA = "0x18517F860", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBC")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		public T this[string key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBD")]
			[Cpp2IlInjected.Address(RVA = "0x517F880", Offset = "0x517E280", VA = "0x18517F880", Slot = "12")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EBE")]
			[Cpp2IlInjected.Address(RVA = "0x517F9E0", Offset = "0x517E3E0", VA = "0x18517F9E0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB6")]
		[Cpp2IlInjected.Address(RVA = "0x517F790", Offset = "0x517E190", VA = "0x18517F790")]
		public ChildrenDictionary(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBF")]
		[Cpp2IlInjected.Address(RVA = "0x517EB30", Offset = "0x517D530", VA = "0x18517EB30", Slot = "23")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC0")]
		[Cpp2IlInjected.Address(RVA = "0x517E9F0", Offset = "0x517D3F0", VA = "0x18517E9F0", Slot = "17")]
		public void Add(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC1")]
		[Cpp2IlInjected.Address(RVA = "0x517F040", Offset = "0x517DA40", VA = "0x18517F040", Slot = "18")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC2")]
		[Cpp2IlInjected.Address(RVA = "0x517ED30", Offset = "0x517D730", VA = "0x18517ED30", Slot = "16")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC3")]
		[Cpp2IlInjected.Address(RVA = "0x517F3D0", Offset = "0x517DDD0", VA = "0x18517F3D0", Slot = "19")]
		public bool TryGetValue(string key, [Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC4")]
		[Cpp2IlInjected.Address(RVA = "0x517EF20", Offset = "0x517D920", VA = "0x18517EF20", Slot = "10")]
		public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC5")]
		[Cpp2IlInjected.Address(RVA = "0x517EF20", Offset = "0x517D920", VA = "0x18517EF20", Slot = "11")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC6")]
		[Cpp2IlInjected.Address(RVA = "0x517F530", Offset = "0x517DF30", VA = "0x18517F530")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC7")]
		[Cpp2IlInjected.Address(RVA = "0x1075230", Offset = "0x1073C30", VA = "0x181075230")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC8")]
		[Cpp2IlInjected.Address(RVA = "0x517E9D0", Offset = "0x517D3D0", VA = "0x18517E9D0", Slot = "22")]
		public void Add(KeyValuePair<string, T> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC9")]
		[Cpp2IlInjected.Address(RVA = "0x517ED60", Offset = "0x517D760", VA = "0x18517ED60", Slot = "24")]
		public bool Contains(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECA")]
		[Cpp2IlInjected.Address(RVA = "0x517F020", Offset = "0x517DA20", VA = "0x18517F020", Slot = "26")]
		public bool Remove(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECB")]
		[Cpp2IlInjected.Address(RVA = "0x517EDA0", Offset = "0x517D7A0", VA = "0x18517EDA0", Slot = "25")]
		public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECC")]
		[Cpp2IlInjected.Address(RVA = "0x517EF90", Offset = "0x517D990", VA = "0x18517EF90", Slot = "27")]
		public IEnumerable<SharpGLTF.Reflection.FieldInfo> GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECD")]
		[Cpp2IlInjected.Address(RVA = "0x517F240", Offset = "0x517DC40", VA = "0x18517F240", Slot = "28")]
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
				[Cpp2IlInjected.Address(RVA = "0x5112B50", Offset = "0x5111550", VA = "0x185112B50", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C60330", Offset = "0x6C5ED30", VA = "0x186C60330", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEB")]
			[Cpp2IlInjected.Address(RVA = "0x5145310", Offset = "0x5143D10", VA = "0x185145310")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEC")]
			[Cpp2IlInjected.Address(RVA = "0x6673AC0", Offset = "0x66724C0", VA = "0x186673AC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EED")]
			[Cpp2IlInjected.Address(RVA = "0x6C60120", Offset = "0x6C5EB20", VA = "0x186C60120", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEF")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF1")]
			[Cpp2IlInjected.Address(RVA = "0x65CD9A0", Offset = "0x65CC3A0", VA = "0x1865CD9A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF2")]
			[Cpp2IlInjected.Address(RVA = "0x6C60270", Offset = "0x6C5EC70", VA = "0x186C60270", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x51809D0", Offset = "0x517F3D0", VA = "0x1851809D0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ED5")]
			[Cpp2IlInjected.Address(RVA = "0x5180A40", Offset = "0x517F440", VA = "0x185180A40", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED6")]
			[Cpp2IlInjected.Address(RVA = "0x51809B0", Offset = "0x517F3B0", VA = "0x1851809B0", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38940", VA = "0x180D39F40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED3")]
		[Cpp2IlInjected.Address(RVA = "0x51808E0", Offset = "0x517F2E0", VA = "0x1851808E0")]
		public ChildrenList(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED8")]
		[Cpp2IlInjected.Address(RVA = "0x517FD70", Offset = "0x517E770", VA = "0x18517FD70", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED9")]
		[Cpp2IlInjected.Address(RVA = "0x517FEE0", Offset = "0x517E8E0", VA = "0x18517FEE0", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDA")]
		[Cpp2IlInjected.Address(RVA = "0x517FD90", Offset = "0x517E790", VA = "0x18517FD90", Slot = "14")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDB")]
		[Cpp2IlInjected.Address(RVA = "0x517FA00", Offset = "0x517E400", VA = "0x18517FA00", Slot = "11")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDC")]
		[Cpp2IlInjected.Address(RVA = "0x517FB70", Offset = "0x517E570", VA = "0x18517FB70", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDD")]
		[Cpp2IlInjected.Address(RVA = "0x517FF00", Offset = "0x517E900", VA = "0x18517FF00", Slot = "7")]
		public void Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDE")]
		[Cpp2IlInjected.Address(RVA = "0x51802C0", Offset = "0x517ECC0", VA = "0x1851802C0", Slot = "15")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDF")]
		[Cpp2IlInjected.Address(RVA = "0x5180060", Offset = "0x517EA60", VA = "0x185180060", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE0")]
		[Cpp2IlInjected.Address(RVA = "0x517FDB0", Offset = "0x517E7B0", VA = "0x18517FDB0", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE1")]
		[Cpp2IlInjected.Address(RVA = "0x517FDB0", Offset = "0x517E7B0", VA = "0x18517FDB0", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE2")]
		[Cpp2IlInjected.Address(RVA = "0x51806C0", Offset = "0x517F0C0", VA = "0x1851806C0")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE3")]
		[Cpp2IlInjected.Address(RVA = "0x1075230", Offset = "0x1073C30", VA = "0x181075230")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE4")]
		[Cpp2IlInjected.Address(RVA = "0x51804A0", Offset = "0x517EEA0", VA = "0x1851804A0", Slot = "22")]
		[IteratorStateMachine(typeof(ChildrenList<, >.<SharpGLTF-Reflection-IReflectionObject-GetFields>d__22))]
		IEnumerable<SharpGLTF.Reflection.FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE5")]
		[Cpp2IlInjected.Address(RVA = "0x5180330", Offset = "0x517ED30", VA = "0x185180330", Slot = "21")]
		SharpGLTF.Reflection.FieldInfo IReflectionArray.GetField(int index)
		{
			return default(SharpGLTF.Reflection.FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE6")]
		[Cpp2IlInjected.Address(RVA = "0x5180530", Offset = "0x517EF30", VA = "0x185180530", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x517E910", Offset = "0x517D310", VA = "0x18517E910")]
		public ChildSetter(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF4")]
		[Cpp2IlInjected.Address(RVA = "0x36DF540", Offset = "0x36DDF40", VA = "0x1836DF540")]
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
			[Cpp2IlInjected.Address(RVA = "0x77E2590", Offset = "0x77E0F90", VA = "0x1877E2590", Slot = "6")]
			get
			{
				return (TValueOut)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EFF")]
			[Cpp2IlInjected.Address(RVA = "0x77E2920", Offset = "0x77E1320", VA = "0x1877E2920", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public IEnumerable<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F00")]
			[Cpp2IlInjected.Address(RVA = "0x77E2980", Offset = "0x77E1380", VA = "0x1877E2980", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F01")]
			[Cpp2IlInjected.Address(RVA = "0x77E2530", Offset = "0x77E0F30", VA = "0x1877E2530", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFD")]
		[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC000", VA = "0x1810DD600")]
		public ReadOnlyLinqDictionary(IReadOnlyDictionary<TKey, TValueIn> dict, Converter<TValueIn, TValueOut> valConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F02")]
		[Cpp2IlInjected.Address(RVA = "0x77E1890", Offset = "0x77E0290", VA = "0x1877E1890", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F03")]
		[Cpp2IlInjected.Address(RVA = "0x77E23E0", Offset = "0x77E0DE0", VA = "0x1877E23E0", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F04")]
		[Cpp2IlInjected.Address(RVA = "0x77E1B20", Offset = "0x77E0520", VA = "0x1877E1B20", Slot = "10")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F05")]
		[Cpp2IlInjected.Address(RVA = "0x77E1CE0", Offset = "0x77E06E0", VA = "0x1877E1CE0", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0x6925520", Offset = "0x6923F20", VA = "0x186925520", Slot = "4")]
			get
			{
				return (TValueOut)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000F0E")]
			[Cpp2IlInjected.Address(RVA = "0x6925AE0", Offset = "0x69244E0", VA = "0x186925AE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public ICollection<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000F0F")]
			[Cpp2IlInjected.Address(RVA = "0x6925810", Offset = "0x6924210", VA = "0x186925810", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public ICollection<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F10")]
			[Cpp2IlInjected.Address(RVA = "0x6925870", Offset = "0x6924270", VA = "0x186925870", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F11")]
			[Cpp2IlInjected.Address(RVA = "0x6925460", Offset = "0x6923E60", VA = "0x186925460", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000F12")]
			[Cpp2IlInjected.Address(RVA = "0x6288E30", Offset = "0x6287830", VA = "0x186288E30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0C")]
		[Cpp2IlInjected.Address(RVA = "0x1F34EF0", Offset = "0x1F338F0", VA = "0x181F34EF0")]
		public LinqDictionary(IDictionary<TKey, TValueIn> dict, Converter<TValueOut, TValueIn> inConverter, Converter<TValueIn, TValueOut> outConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F13")]
		[Cpp2IlInjected.Address(RVA = "0x6924A00", Offset = "0x6923400", VA = "0x186924A00", Slot = "8")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F14")]
		[Cpp2IlInjected.Address(RVA = "0x69250C0", Offset = "0x6923AC0", VA = "0x1869250C0", Slot = "11")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F15")]
		[Cpp2IlInjected.Address(RVA = "0x6924B40", Offset = "0x6923540", VA = "0x186924B40", Slot = "19")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F16")]
		[Cpp2IlInjected.Address(RVA = "0x6924EA0", Offset = "0x69238A0", VA = "0x186924EA0", Slot = "20")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F17")]
		[Cpp2IlInjected.Address(RVA = "0x69247A0", Offset = "0x69231A0", VA = "0x1869247A0", Slot = "9")]
		public void Add(TKey key, TValueOut value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F18")]
		[Cpp2IlInjected.Address(RVA = "0x6924D60", Offset = "0x6923760", VA = "0x186924D60", Slot = "10")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F19")]
		[Cpp2IlInjected.Address(RVA = "0x6924570", Offset = "0x6922F70", VA = "0x186924570", Slot = "14")]
		public void Add(KeyValuePair<TKey, TValueOut> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1A")]
		[Cpp2IlInjected.Address(RVA = "0x69249A0", Offset = "0x69233A0", VA = "0x1869249A0", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1B")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CEF0", Offset = "0x3C0B8F0", VA = "0x183C0CEF0", Slot = "16")]
		public bool Contains(KeyValuePair<TKey, TValueOut> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1C")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CD30", Offset = "0x3C0B730", VA = "0x183C0CD30", Slot = "17")]
		public void CopyTo(KeyValuePair<TKey, TValueOut>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CEF0", Offset = "0x3C0B8F0", VA = "0x183C0CEF0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private ReferenceComparer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F25")]
		[Cpp2IlInjected.Address(RVA = "0x1719110", Offset = "0x1717B10", VA = "0x181719110", Slot = "4")]
		public bool Equals(T x, T y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F26")]
		[Cpp2IlInjected.Address(RVA = "0x7883EC0", Offset = "0x78828C0", VA = "0x187883EC0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4C")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <SplitByTime>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4D")]
			[Cpp2IlInjected.Address(RVA = "0x6CF66F0", Offset = "0x6CF50F0", VA = "0x186CF66F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4E")]
			[Cpp2IlInjected.Address(RVA = "0x6CEE9B0", Offset = "0x6CED3B0", VA = "0x186CEE9B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4F")]
			[Cpp2IlInjected.Address(RVA = "0x6CF7390", Offset = "0x6CF5D90", VA = "0x186CF7390")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F51")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F53")]
			[Cpp2IlInjected.Address(RVA = "0x64DA8B0", Offset = "0x64D92B0", VA = "0x1864DA8B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(float, T)[]> IEnumerable<(float, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000F54")]
			[Cpp2IlInjected.Address(RVA = "0x6CF5D90", Offset = "0x6CF4790", VA = "0x186CF5D90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5D88F0", Offset = "0xA5D72F0", VA = "0x18A5D88F0")]
		internal static string CurveError(int maxDegree)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F29")]
		[Cpp2IlInjected.Address(RVA = "0xA5D84D0", Offset = "0xA5D6ED0", VA = "0x18A5D84D0")]
		public static Vector3 CreateTangent(Vector3 fromValue, Vector3 toValue, float scale = 1f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2A")]
		[Cpp2IlInjected.Address(RVA = "0xA5D85B0", Offset = "0xA5D6FB0", VA = "0x18A5D85B0")]
		public static Quaternion CreateTangent(Quaternion fromValue, Quaternion toValue, float scale = 1f)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2B")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8730", Offset = "0xA5D7130", VA = "0x18A5D8730")]
		public static float[] CreateTangent(float[] fromValue, float[] toValue, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2C")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6510", Offset = "0xA5D4F10", VA = "0x18A5D6510")]
		public static (float, float, float, float) CreateHermitePointWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2D")]
		[Cpp2IlInjected.Address(RVA = "0xA5D65B0", Offset = "0xA5D4FB0", VA = "0x18A5D65B0")]
		public static (float, float, float, float) CreateHermiteTangentWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2E")]
		[Cpp2IlInjected.Address(RVA = "0x38BD640", Offset = "0x38BC040", VA = "0x1838BD640")]
		public static (T, T, float) FindRangeContainingOffset<T>(this IEnumerable<(float Key, T Value)> sequence, float offset)
		{
			return default((T, T, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2F")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8980", Offset = "0xA5D7380", VA = "0x18A5D8980")]
		public static (float, float, float) FindRangeContainingOffset(IEnumerable<float> sequence, float offset)
		{
			return default((float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F30")]
		[Cpp2IlInjected.Address(RVA = "0x338E1F0", Offset = "0x338CBF0", VA = "0x18338E1F0")]
		[IteratorStateMachine(typeof(<SplitByTime>d__11<>))]
		internal static IEnumerable<(float, T)[]> SplitByTime<T>(this IEnumerable<(float Time, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F31")]
		[Cpp2IlInjected.Address(RVA = "0xA5DA290", Offset = "0xA5D8C90", VA = "0x18A5DA290")]
		public static float[] Subtract(IReadOnlyList<float> left, IReadOnlyList<float> right)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F32")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9FC0", Offset = "0xA5D89C0", VA = "0x18A5D9FC0")]
		public static float[] InterpolateLinear(IReadOnlyList<float> start, IReadOnlyList<float> end, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F33")]
		[Cpp2IlInjected.Address(RVA = "0xA5D93E0", Offset = "0xA5D7DE0", VA = "0x18A5D93E0")]
		public static float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F34")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8EC0", Offset = "0xA5D78C0", VA = "0x18A5D8EC0")]
		public static Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F35")]
		[Cpp2IlInjected.Address(RVA = "0xA5D90E0", Offset = "0xA5D7AE0", VA = "0x18A5D90E0")]
		public static Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F36")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9500", Offset = "0xA5D7F00", VA = "0x18A5D9500")]
		public static Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F37")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9DE0", Offset = "0xA5D87E0", VA = "0x18A5D9DE0")]
		public static Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F38")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9840", Offset = "0xA5D8240", VA = "0x18A5D9840")]
		public static float[] InterpolateCubic(IReadOnlyList<float> start, IReadOnlyList<float> outgoingTangent, IReadOnlyList<float> end, IReadOnlyList<float> incomingTangent, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F39")]
		[Cpp2IlInjected.Address(RVA = "0x38C8E60", Offset = "0x38C7860", VA = "0x1838C8E60")]
		private static bool _HasZero<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3A")]
		[Cpp2IlInjected.Address(RVA = "0x38C89E0", Offset = "0x38C73E0", VA = "0x1838C89E0")]
		private static bool _HasOne<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3B")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7AD0", Offset = "0xA5D64D0", VA = "0x18A5D7AD0")]
		public static ICurveSampler<bool> CreateSampler(this IEnumerable<(float, bool)> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3C")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6E90", Offset = "0xA5D5890", VA = "0x18A5D6E90")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, float)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3D")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7230", Offset = "0xA5D5C30", VA = "0x18A5D7230")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, Vector2)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3E")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7890", Offset = "0xA5D6290", VA = "0x18A5D7890")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, Vector3)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3F")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7C30", Offset = "0xA5D6630", VA = "0x18A5D7C30")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, Vector4)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F40")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6A10", Offset = "0xA5D5410", VA = "0x18A5D6A10")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, Quaternion)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F41")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7E70", Offset = "0xA5D6870", VA = "0x18A5D7E70")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, float[])> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F42")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6670", Offset = "0xA5D5070", VA = "0x18A5D6670")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, ArraySegment<float>)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F43")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6C50", Offset = "0xA5D5650", VA = "0x18A5D6C50")]
		public static ICurveSampler<SparseWeight8> CreateSampler(this IEnumerable<(float, SparseWeight8)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F44")]
		[Cpp2IlInjected.Address(RVA = "0xA5D80B0", Offset = "0xA5D6AB0", VA = "0x18A5D80B0")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, (float, float, float))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F45")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7730", Offset = "0xA5D6130", VA = "0x18A5D7730")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, (Vector2, Vector2, Vector2))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F46")]
		[Cpp2IlInjected.Address(RVA = "0xA5D75D0", Offset = "0xA5D5FD0", VA = "0x18A5D75D0")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, (Vector3, Vector3, Vector3))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F47")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8370", Offset = "0xA5D6D70", VA = "0x18A5D8370")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, (Vector4, Vector4, Vector4))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F48")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8210", Offset = "0xA5D6C10", VA = "0x18A5D8210")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F49")]
		[Cpp2IlInjected.Address(RVA = "0xA5D70D0", Offset = "0xA5D5AD0", VA = "0x18A5D70D0")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, (float[], float[], float[]))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4A")]
		[Cpp2IlInjected.Address(RVA = "0xA5D68B0", Offset = "0xA5D52B0", VA = "0x18A5D68B0")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4B")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7470", Offset = "0xA5D5E70", VA = "0x18A5D7470")]
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
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD722A0", VA = "0x180D738A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F55")]
		[Cpp2IlInjected.Address(RVA = "0x5397CF0", Offset = "0x53966F0", VA = "0x185397CF0", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F56")]
		[Cpp2IlInjected.Address(RVA = "0x539D180", Offset = "0x539BB80", VA = "0x18539D180")]
		public CubicSampler(IEnumerable<(float, (T, T, T))> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F58")]
		[Cpp2IlInjected.Address(RVA = "0x5399B30", Offset = "0x5398530", VA = "0x185399B30", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F59")]
		[Cpp2IlInjected.Address(RVA = "0x539A2B0", Offset = "0x5398CB0", VA = "0x18539A2B0", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5A")]
		[Cpp2IlInjected.Address(RVA = "0x539A2B0", Offset = "0x5398CB0", VA = "0x18539A2B0", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5B")]
		[Cpp2IlInjected.Address(RVA = "0x539BC80", Offset = "0x539A680", VA = "0x18539BC80", Slot = "9")]
		IReadOnlyDictionary<float, (T, T, T)> IConvertibleCurve<T>.ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5C")]
		[Cpp2IlInjected.Address(RVA = "0x539C820", Offset = "0x539B220", VA = "0x18539C820")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F66")]
		[Cpp2IlInjected.Address(RVA = "0x62E23C0", Offset = "0x62E0DC0", VA = "0x1862E23C0")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F67")]
		[Cpp2IlInjected.Address(RVA = "0x62E1C70", Offset = "0x62E0670", VA = "0x1862E1C70")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, (T, T, T) Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F68")]
		[Cpp2IlInjected.Address(RVA = "0x62E1760", Offset = "0x62E0160", VA = "0x1862E1760", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F69")]
		[Cpp2IlInjected.Address(RVA = "0x12B8AE0", Offset = "0x12B74E0", VA = "0x1812B8AE0")]
		private FixedSampler(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6B")]
		[Cpp2IlInjected.Address(RVA = "0x12B8AB0", Offset = "0x12B74B0", VA = "0x1812B8AB0", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6C")]
		[Cpp2IlInjected.Address(RVA = "0x62E2C90", Offset = "0x62E1690", VA = "0x1862E2C90", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6D")]
		[Cpp2IlInjected.Address(RVA = "0x62E2C90", Offset = "0x62E1690", VA = "0x1862E2C90", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6E")]
		[Cpp2IlInjected.Address(RVA = "0x62E37D0", Offset = "0x62E21D0", VA = "0x1862E37D0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD59EA0", VA = "0x180D5B4A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6F")]
		[Cpp2IlInjected.Address(RVA = "0x68D1380", Offset = "0x68CFD80", VA = "0x1868D1380", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F70")]
		[Cpp2IlInjected.Address(RVA = "0x539D180", Offset = "0x539BB80", VA = "0x18539D180")]
		public LinearSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F72")]
		[Cpp2IlInjected.Address(RVA = "0x68D25F0", Offset = "0x68D0FF0", VA = "0x1868D25F0", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F73")]
		[Cpp2IlInjected.Address(RVA = "0x68D6090", Offset = "0x68D4A90", VA = "0x1868D6090", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F74")]
		[Cpp2IlInjected.Address(RVA = "0x68D5D00", Offset = "0x68D4700", VA = "0x1868D5D00", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F75")]
		[Cpp2IlInjected.Address(RVA = "0x68D6090", Offset = "0x68D4A90", VA = "0x1868D6090", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F76")]
		[Cpp2IlInjected.Address(RVA = "0x68D3E70", Offset = "0x68D2870", VA = "0x1868D3E70")]
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
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F80")]
		[Cpp2IlInjected.Address(RVA = "0x68D1380", Offset = "0x68CFD80", VA = "0x1868D1380", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F81")]
		[Cpp2IlInjected.Address(RVA = "0x539D180", Offset = "0x539BB80", VA = "0x18539D180")]
		public StepSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F83")]
		[Cpp2IlInjected.Address(RVA = "0x7A49C50", Offset = "0x7A48650", VA = "0x187A49C50", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F84")]
		[Cpp2IlInjected.Address(RVA = "0x7A4ACE0", Offset = "0x7A496E0", VA = "0x187A4ACE0", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F85")]
		[Cpp2IlInjected.Address(RVA = "0x7A4ABC0", Offset = "0x7A495C0", VA = "0x187A4ABC0", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F86")]
		[Cpp2IlInjected.Address(RVA = "0x7A4ABC0", Offset = "0x7A495C0", VA = "0x187A4ABC0", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F87")]
		[Cpp2IlInjected.Address(RVA = "0x68D3E70", Offset = "0x68D2870", VA = "0x1868D3E70")]
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
			[Cpp2IlInjected.Address(RVA = "0x140FA50", Offset = "0x140E450", VA = "0x18140FA50", Slot = "4")]
			public bool Clone(bool value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F96")]
			[Cpp2IlInjected.Address(RVA = "0xA5E4710", Offset = "0xA5E3110", VA = "0x18A5E4710", Slot = "5")]
			public bool InterpolateLinear(bool left, bool right, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F97")]
			[Cpp2IlInjected.Address(RVA = "0xA5E46F0", Offset = "0xA5E30F0", VA = "0x18A5E46F0", Slot = "6")]
			public bool InterpolateCubic(bool start, bool outgoingTangent, bool end, bool incomingTangent, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F98")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public _Boolean()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		private sealed class _Scalar : ISamplerTraits<float>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F99")]
			[Cpp2IlInjected.Address(RVA = "0xF12790", Offset = "0xF11190", VA = "0x180F12790", Slot = "4")]
			public float Clone(float value)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9A")]
			[Cpp2IlInjected.Address(RVA = "0xA5E7EE0", Offset = "0xA5E68E0", VA = "0x18A5E7EE0", Slot = "5")]
			public float InterpolateLinear(float left, float right, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9B")]
			[Cpp2IlInjected.Address(RVA = "0xA5E7DD0", Offset = "0xA5E67D0", VA = "0x18A5E7DD0", Slot = "6")]
			public float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public _Scalar()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		private sealed class _Vector2 : ISamplerTraits<Vector2>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F9D")]
			[Cpp2IlInjected.Address(RVA = "0xD548C0", Offset = "0xD532C0", VA = "0x180D548C0", Slot = "4")]
			public Vector2 Clone(Vector2 value)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9E")]
			[Cpp2IlInjected.Address(RVA = "0xA5E82A0", Offset = "0xA5E6CA0", VA = "0x18A5E82A0", Slot = "5")]
			public Vector2 InterpolateLinear(Vector2 left, Vector2 right, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9F")]
			[Cpp2IlInjected.Address(RVA = "0xA5E8260", Offset = "0xA5E6C60", VA = "0x18A5E8260", Slot = "6")]
			public Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA0")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public _Vector2()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private sealed class _Vector3 : ISamplerTraits<Vector3>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA1")]
			[Cpp2IlInjected.Address(RVA = "0x10477D0", Offset = "0x10461D0", VA = "0x1810477D0", Slot = "4")]
			public Vector3 Clone(Vector3 value)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA2")]
			[Cpp2IlInjected.Address(RVA = "0xA5E83C0", Offset = "0xA5E6DC0", VA = "0x18A5E83C0", Slot = "5")]
			public Vector3 InterpolateLinear(Vector3 left, Vector3 right, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA3")]
			[Cpp2IlInjected.Address(RVA = "0xA5E8300", Offset = "0xA5E6D00", VA = "0x18A5E8300", Slot = "6")]
			public Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA4")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public _Vector3()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B0")]
		private sealed class _Vector4 : ISamplerTraits<Vector4>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA5")]
			[Cpp2IlInjected.Address(RVA = "0x12ABB40", Offset = "0x12AA540", VA = "0x1812ABB40", Slot = "4")]
			public Vector4 Clone(Vector4 value)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA6")]
			[Cpp2IlInjected.Address(RVA = "0xA5E84C0", Offset = "0xA5E6EC0", VA = "0x18A5E84C0", Slot = "5")]
			public Vector4 InterpolateLinear(Vector4 left, Vector4 right, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA7")]
			[Cpp2IlInjected.Address(RVA = "0xA5E8430", Offset = "0xA5E6E30", VA = "0x18A5E8430", Slot = "6")]
			public Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA8")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public _Vector4()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B1")]
		private sealed class _Quaternion : ISamplerTraits<Quaternion>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA9")]
			[Cpp2IlInjected.Address(RVA = "0x12ABB40", Offset = "0x12AA540", VA = "0x1812ABB40", Slot = "4")]
			public Quaternion Clone(Quaternion value)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAA")]
			[Cpp2IlInjected.Address(RVA = "0xA5E7D80", Offset = "0xA5E6780", VA = "0x18A5E7D80", Slot = "5")]
			public Quaternion InterpolateLinear(Quaternion left, Quaternion right, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAB")]
			[Cpp2IlInjected.Address(RVA = "0xA5E7BB0", Offset = "0xA5E65B0", VA = "0x18A5E7BB0", Slot = "6")]
			public Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAC")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public _Quaternion()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		private sealed class _Array : ISamplerTraits<float[]>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FAD")]
			[Cpp2IlInjected.Address(RVA = "0xA5E4620", Offset = "0xA5E3020", VA = "0x18A5E4620", Slot = "4")]
			public float[] Clone(float[] value)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAE")]
			[Cpp2IlInjected.Address(RVA = "0xA5E46D0", Offset = "0xA5E30D0", VA = "0x18A5E46D0", Slot = "5")]
			public float[] InterpolateLinear(float[] left, float[] right, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAF")]
			[Cpp2IlInjected.Address(RVA = "0xA5E46A0", Offset = "0xA5E30A0", VA = "0x18A5E46A0", Slot = "6")]
			public float[] InterpolateCubic(float[] start, float[] outgoingTangent, float[] end, float[] incomingTangent, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB0")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public _Array()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		private sealed class _Segment : ISamplerTraits<ArraySegment<float>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB1")]
			[Cpp2IlInjected.Address(RVA = "0xA5E7F00", Offset = "0xA5E6900", VA = "0x18A5E7F00", Slot = "4")]
			public ArraySegment<float> Clone(ArraySegment<float> value)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB2")]
			[Cpp2IlInjected.Address(RVA = "0xA5E80C0", Offset = "0xA5E6AC0", VA = "0x18A5E80C0", Slot = "5")]
			public ArraySegment<float> InterpolateLinear(ArraySegment<float> left, ArraySegment<float> right, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB3")]
			[Cpp2IlInjected.Address(RVA = "0xA5E7FA0", Offset = "0xA5E69A0", VA = "0x18A5E7FA0", Slot = "6")]
			public ArraySegment<float> InterpolateCubic(ArraySegment<float> start, ArraySegment<float> outgoingTangent, ArraySegment<float> end, ArraySegment<float> incomingTangent, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB4")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public _Segment()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		private sealed class _Sparse : ISamplerTraits<SparseWeight8>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB5")]
			[Cpp2IlInjected.Address(RVA = "0x5700F70", Offset = "0x56FF970", VA = "0x185700F70", Slot = "4")]
			public SparseWeight8 Clone(SparseWeight8 value)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB6")]
			[Cpp2IlInjected.Address(RVA = "0xA5E8200", Offset = "0xA5E6C00", VA = "0x18A5E8200", Slot = "5")]
			public SparseWeight8 InterpolateLinear(SparseWeight8 left, SparseWeight8 right, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB7")]
			[Cpp2IlInjected.Address(RVA = "0xA5E8180", Offset = "0xA5E6B80", VA = "0x18A5E8180", Slot = "6")]
			public SparseWeight8 InterpolateCubic(SparseWeight8 start, SparseWeight8 outgoingTangent, SparseWeight8 end, SparseWeight8 incomingTangent, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB8")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x37CF5B0", Offset = "0x37CDFB0", VA = "0x1837CF5B0")]
		public static ICurveSampler<T> CreateFrom<TKey>(IEnumerable<(float, TKey)> sequence, Func<(float, TKey)[], ICurveSampler<T>> chunkFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBA")]
		[Cpp2IlInjected.Address(RVA = "0x6297400", Offset = "0x6295E00", VA = "0x186297400")]
		private FastCurveSampler(IEnumerable<ICurveSampler<T>> samplers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBB")]
		[Cpp2IlInjected.Address(RVA = "0x6296D90", Offset = "0x6295790", VA = "0x186296D90", Slot = "4")]
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

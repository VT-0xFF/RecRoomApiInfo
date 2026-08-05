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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5D53B0", Offset = "0xA5D41B0", VA = "0x18A5D53B0")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4380", Offset = "0xA5D3180", VA = "0x18A5D4380")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA5D45F0", Offset = "0xA5D33F0", VA = "0x18A5D45F0")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4840", Offset = "0xA5D3640", VA = "0x18A5D4840")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5D42E0", Offset = "0xA5D30E0", VA = "0x18A5D42E0")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5030", Offset = "0xA5D3E30", VA = "0x18A5D5030")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4F10", Offset = "0xA5D3D10", VA = "0x18A5D4F10")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5500", Offset = "0xA5D4300", VA = "0x18A5D5500")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA5D54A0", Offset = "0xA5D42A0", VA = "0x18A5D54A0")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4D50", Offset = "0xA5D3B50", VA = "0x18A5D4D50")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0F90", Offset = "0x3ACFD90", VA = "0x183AD0F90")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF8E0", Offset = "0x3ACE6E0", VA = "0x183ACF8E0")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4DB0", Offset = "0xA5D3BB0", VA = "0x18A5D4DB0")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0A30", Offset = "0x3ACF830", VA = "0x183AD0A30")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AD05D0", Offset = "0x3ACF3D0", VA = "0x183AD05D0")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0190", Offset = "0x3ACEF90", VA = "0x183AD0190")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3ACFE90", Offset = "0x3ACEC90", VA = "0x183ACFE90")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF190", Offset = "0x3ACDF90", VA = "0x183ACF190")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4940", Offset = "0xA5D3740", VA = "0x18A5D4940")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA5D48E0", Offset = "0xA5D36E0", VA = "0x18A5D48E0")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA5D49A0", Offset = "0xA5D37A0", VA = "0x18A5D49A0")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5250", Offset = "0xA5D4050", VA = "0x18A5D5250")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5150", Offset = "0xA5D3F50", VA = "0x18A5D5150")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDE80", Offset = "0x3ACCC80", VA = "0x183ACDE80")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA5D4050", Offset = "0xA5D2E50", VA = "0x18A5D4050")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3ACCD10", Offset = "0x3ACBB10", VA = "0x183ACCD10")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3ACCD10", Offset = "0x3ACBB10", VA = "0x183ACCD10")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3ACCD10", Offset = "0x3ACBB10", VA = "0x183ACCD10")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3ACCD10", Offset = "0x3ACBB10", VA = "0x183ACCD10")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3ACCD10", Offset = "0x3ACBB10", VA = "0x183ACCD10")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC0B0", Offset = "0x3ACAEB0", VA = "0x183ACC0B0")]
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
					[Cpp2IlInjected.Address(RVA = "0x5AF8540", Offset = "0x5AF7340", VA = "0x185AF8540", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x5AF79F0", Offset = "0x5AF67F0", VA = "0x185AF79F0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x5106460", Offset = "0x5105260", VA = "0x185106460")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x6661E40", Offset = "0x6660C40", VA = "0x186661E40", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x6662AD0", Offset = "0x66618D0", VA = "0x186662AD0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6667BB0", Offset = "0x66669B0", VA = "0x186667BB0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x6E525E0", Offset = "0x6E513E0", VA = "0x186E525E0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6E57970", Offset = "0x6E56770", VA = "0x186E57970", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6E5BDD0", Offset = "0x6E5ABD0", VA = "0x186E5BDD0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x513F790", Offset = "0x513E590", VA = "0x18513F790", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x513F730", Offset = "0x513E530", VA = "0x18513F730", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x513F490", Offset = "0x513E290", VA = "0x18513F490", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x513F5B0", Offset = "0x513E3B0", VA = "0x18513F5B0", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x5AF8540", Offset = "0x5AF7340", VA = "0x185AF8540", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x5AF79F0", Offset = "0x5AF67F0", VA = "0x185AF79F0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x5106460", Offset = "0x5105260", VA = "0x185106460")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x6661E40", Offset = "0x6660C40", VA = "0x186661E40", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x66614F0", Offset = "0x66602F0", VA = "0x1866614F0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x66623E0", Offset = "0x66611E0", VA = "0x1866623E0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6E525E0", Offset = "0x6E513E0", VA = "0x186E525E0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6E51380", Offset = "0x6E50180", VA = "0x186E51380", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6E52AF0", Offset = "0x6E518F0", VA = "0x186E52AF0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x5136890", Offset = "0x5135690", VA = "0x185136890", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x51365F0", Offset = "0x51353F0", VA = "0x1851365F0", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x51367C0", Offset = "0x51355C0", VA = "0x1851367C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x13EF890", Offset = "0x13EE690", VA = "0x1813EF890", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5DC2E0", Offset = "0xA5DB0E0", VA = "0x18A5DC2E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x64BEF30", Offset = "0x64BDD30", VA = "0x1864BEF30")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA5DC330", Offset = "0xA5DB130", VA = "0x18A5DC330", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBF90", Offset = "0xA5DAD90", VA = "0x18A5DBF90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA5DC3F0", Offset = "0xA5DB1F0", VA = "0x18A5DC3F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA5DC2A0", Offset = "0xA5DB0A0", VA = "0x18A5DC2A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA5DC1F0", Offset = "0xA5DAFF0", VA = "0x18A5DC1F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA5DC1F0", Offset = "0xA5DAFF0", VA = "0x18A5DC1F0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A050E0", Offset = "0x1A03EE0", VA = "0x181A050E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5DCDD0", Offset = "0xA5DBBD0", VA = "0x18A5DCDD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA5DCE20", Offset = "0xA5DBC20", VA = "0x18A5DCE20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA5DC440", Offset = "0xA5DB240", VA = "0x18A5DC440", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA5DD010", Offset = "0xA5DBE10", VA = "0x18A5DD010")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA5DD060", Offset = "0xA5DBE60", VA = "0x18A5DD060")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA5DD0B0", Offset = "0xA5DBEB0", VA = "0x18A5DD0B0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA5DCD90", Offset = "0xA5DBB90", VA = "0x18A5DCD90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA5DCCE0", Offset = "0xA5DBAE0", VA = "0x18A5DCCE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA5DCCE0", Offset = "0xA5DBAE0", VA = "0x18A5DCCE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52B820", Offset = "0xA52A620", VA = "0x18A52B820")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA52D1F0", Offset = "0xA52BFF0", VA = "0x18A52D1F0")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA52D320", Offset = "0xA52C120", VA = "0x18A52D320")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA52D230", Offset = "0xA52C030", VA = "0x18A52D230")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA52D350", Offset = "0xA52C150", VA = "0x18A52D350")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA52D290", Offset = "0xA52C090", VA = "0x18A52D290")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA52D3C0", Offset = "0xA52C1C0", VA = "0x18A52D3C0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA52D290", Offset = "0xA52C090", VA = "0x18A52D290")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA52D120", Offset = "0xA52BF20", VA = "0x18A52D120")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE680", Offset = "0xA5DD480", VA = "0x18A5DE680")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE560", Offset = "0xA5DD360", VA = "0x18A5DE560")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA52ABC0", Offset = "0xA5299C0", VA = "0x18A52ABC0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF10", Offset = "0xA5DDD10", VA = "0x18A5DEF10")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA52B7D0", Offset = "0xA52A5D0", VA = "0x18A52B7D0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA52B770", Offset = "0xA52A570", VA = "0x18A52B770")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA52BA50", Offset = "0xA52A850", VA = "0x18A52BA50")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DFAB0", Offset = "0xA5DE8B0", VA = "0x18A5DFAB0")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DFC30", Offset = "0xA5DEA30", VA = "0x18A5DFC30")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE880", Offset = "0xA5DD680", VA = "0x18A5DE880")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE780", Offset = "0xA5DD580", VA = "0x18A5DE780")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEB50", Offset = "0xA5DD950", VA = "0x18A5DEB50")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE3D0", Offset = "0xA5DD1D0", VA = "0x18A5DE3D0")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE800", Offset = "0xA5DD600", VA = "0x18A5DE800")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA52C320", Offset = "0xA52B120", VA = "0x18A52C320")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE810", Offset = "0xA5DD610", VA = "0x18A5DE810")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA52B540", Offset = "0xA52A340", VA = "0x18A52B540")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA52B480", Offset = "0xA52A280", VA = "0x18A52B480")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4128BF0", Offset = "0x41279F0", VA = "0x184128BF0")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA52AD30", Offset = "0xA529B30", VA = "0x18A52AD30")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA52AEA0", Offset = "0xA529CA0", VA = "0x18A52AEA0")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4129D10", Offset = "0x4128B10", VA = "0x184129D10")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x412AAA0", Offset = "0x41298A0", VA = "0x18412AAA0")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x412AC70", Offset = "0x4129A70", VA = "0x18412AC70")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x412AD50", Offset = "0x4129B50", VA = "0x18412AD50")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4128C10", Offset = "0x4127A10", VA = "0x184128C10")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4129B50", Offset = "0x4128950", VA = "0x184129B50")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4129A40", Offset = "0x4128840", VA = "0x184129A40")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x41291F0", Offset = "0x4127FF0", VA = "0x1841291F0")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x412A9C0", Offset = "0x41297C0", VA = "0x18412A9C0")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x412A490", Offset = "0x4129290", VA = "0x18412A490")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x412A330", Offset = "0x4129130", VA = "0x18412A330")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x412A630", Offset = "0x4129430", VA = "0x18412A630")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x41290A0", Offset = "0x4127EA0", VA = "0x1841290A0")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4128E50", Offset = "0x4127C50", VA = "0x184128E50")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4128870", Offset = "0x4127670", VA = "0x184128870")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4128CA0", Offset = "0x4127AA0", VA = "0x184128CA0")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE950", Offset = "0xA5DD750", VA = "0x18A5DE950")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA5DECB0", Offset = "0xA5DDAB0", VA = "0x18A5DECB0")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x412AA20", Offset = "0x4129820", VA = "0x18412AA20")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x412AA20", Offset = "0x4129820", VA = "0x18412AA20")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF1C0", Offset = "0xA5DDFC0", VA = "0x18A5DF1C0")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDDD0", Offset = "0xA5DCBD0", VA = "0x18A5DDDD0")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDD20", Offset = "0xA5DCB20", VA = "0x18A5DDD20")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF140", Offset = "0xA5DDF40", VA = "0x18A5DF140")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF880", Offset = "0xA5DE680", VA = "0x18A5DF880")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDE50", Offset = "0xA5DCC50", VA = "0x18A5DDE50")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF3C0", Offset = "0xA5DE1C0", VA = "0x18A5DF3C0")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF490", Offset = "0xA5DE290", VA = "0x18A5DF490")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE170", Offset = "0xA5DCF70", VA = "0x18A5DE170")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDF10", Offset = "0xA5DCD10", VA = "0x18A5DDF10")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE210", Offset = "0xA5DD010", VA = "0x18A5DE210")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE050", Offset = "0xA5DCE50", VA = "0x18A5DE050")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE350", Offset = "0xA5DD150", VA = "0x18A5DE350")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2379940", Offset = "0x2378740", VA = "0x182379940")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA52D210", Offset = "0xA52C010", VA = "0x18A52D210")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x412AF80", Offset = "0x4129D80", VA = "0x18412AF80")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF080", Offset = "0xA5DDE80", VA = "0x18A5DF080")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE0D0", Offset = "0xA5DCED0", VA = "0x18A5DE0D0")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DFA00", Offset = "0xA5DE800", VA = "0x18A5DFA00")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA5DFE30", Offset = "0xA5DEC30", VA = "0x18A5DFE30")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA5DF900", Offset = "0xA5DE700", VA = "0x18A5DF900")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA52ADD0", Offset = "0xA529BD0", VA = "0x18A52ADD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF90", Offset = "0xCEED90", VA = "0x180CEFF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x73783A0", Offset = "0x73771A0", VA = "0x1873783A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x73778A0", Offset = "0x73766A0", VA = "0x1873778A0")]
		internal AnimatableProperty(T defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7371C90", Offset = "0x7370A90", VA = "0x187371C90")]
		public T GetValueAt(int trackLogicalIndex, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7373230", Offset = "0x7372030", VA = "0x187373230")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xD4D5A0", Offset = "0xD4C3A0", VA = "0x180D4D5A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x10A2ED0", Offset = "0x10A1CD0", VA = "0x1810A2ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1140", Offset = "0xA5CFF40", VA = "0x18A5D1140")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<NodeInstance> VisualNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5D1940", Offset = "0xA5D0740", VA = "0x18A5D1940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyList<AnimationTrackInfo> AnimationTracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1700", Offset = "0xA5D0500", VA = "0x18A5D1700")]
		internal ArmatureInstance(ArmatureTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1220", Offset = "0xA5D0020", VA = "0x18A5D1220")]
		public void SetLocalMatrix(string name, Matrix4x4 localMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5D13C0", Offset = "0xA5D01C0", VA = "0x18A5D13C0")]
		public void SetModelMatrix(string name, Matrix4x4 modelMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5D16C0", Offset = "0xA5D04C0", VA = "0x18A5D16C0")]
		public void SetPoseTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5D11B0", Offset = "0xA5CFFB0", VA = "0x18A5D11B0")]
		public void SetAnimationFrame(int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5D11F0", Offset = "0xA5CFFF0", VA = "0x18A5D11F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyList<MaterialTemplate> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<AnimationTrackInfo> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D27A0", Offset = "0xA5D15A0", VA = "0x18A5D27A0")]
		internal static ArmatureTemplate Create(Scene srcScene, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3690", Offset = "0xA5D2490", VA = "0x18A5D3690")]
		private ArmatureTemplate(NodeTemplate[] nodes, MaterialTemplate[] materials, AnimationTrackInfo[] animTracks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5D2770", Offset = "0xA5D1570", VA = "0x18A5D2770")]
		internal void ApplyDefaultPoseTo(ArmatureInstance instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1A60", Offset = "0xA5D0860", VA = "0x18A5D1A60")]
		internal void ApplyAnimationTo(ArmatureInstance instance, int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5D1E30", Offset = "0xA5D0C30", VA = "0x18A5D1E30")]
		internal void ApplyAnimationTo(ArmatureInstance instance, (int TrackIdx, float Time, float Weight)[] blended)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3460", Offset = "0xA5D2260", VA = "0x18A5D3460")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5D3F80", Offset = "0xA5D2D80", VA = "0x18A5D3F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3BF0", Offset = "0xA5D29F0", VA = "0x18A5D3BF0")]
		private string _ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int LogicalMeshIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x162E100", Offset = "0x162CF00", VA = "0x18162E100", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D3FE0", Offset = "0xA5D2DE0", VA = "0x18A5D3FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DA980", Offset = "0xA5D9780", VA = "0x18A5DA980")]
		internal RigidDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DA7B0", Offset = "0xA5D95B0", VA = "0x18A5DA7B0", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5DA800", Offset = "0xA5D9600", VA = "0x18A5DA800", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5910", Offset = "0xA5D4710", VA = "0x18A5D5910")]
		internal InstancedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D56A0", Offset = "0xA5D44A0", VA = "0x18A5D56A0", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5700", Offset = "0xA5D4500", VA = "0x18A5D5700", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5DBB00", Offset = "0xA5DA900", VA = "0x18A5DBB00")]
		internal SkinnedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5DB880", Offset = "0xA5DA680", VA = "0x18A5DB880", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DB8D0", Offset = "0xA5DA6D0", VA = "0x18A5DB8D0", Slot = "7")]
		public override void UpdateGeometryTransform(IGeometryTransform skinnedTransform, ArmatureInstance armature)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class MaterialInstance
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xF423C0", Offset = "0xF411C0", VA = "0x180F423C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xCE8290", Offset = "0xCE7090", VA = "0x180CE8290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B20", Offset = "0xCE6920", VA = "0x180CE7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7900", Offset = "0xCE6700", VA = "0x180CE7900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6190", Offset = "0xA5D4F90", VA = "0x18A5D6190")]
		internal MaterialTemplate(Material srcMaterial, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3CE14B0", Offset = "0x3CE02B0", VA = "0x183CE14B0")]
		private void _AddAnimatableProperty<T>(Dictionary<string, AnimatableProperty<T>> dict, int trackIdx, AnimationChannel channel, string pointerPath, T defaultSingle, bool isolateMemory) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5E10", Offset = "0xA5D4C10", VA = "0x18A5D5E10")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, float> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5A90", Offset = "0xA5D4890", VA = "0x18A5D5A90")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector2> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5FB0", Offset = "0xA5D4DB0", VA = "0x18A5D5FB0")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector3> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA5D5C40", Offset = "0xA5D4A40", VA = "0x18A5D5C40")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A050E0", Offset = "0x1A03EE0", VA = "0x181A050E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6937140", Offset = "0x6935F40", VA = "0x186937140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public <GetWorldVertices>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x6937190", Offset = "0x6935F90", VA = "0x186937190", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6936AC0", Offset = "0x69358C0", VA = "0x186936AC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x69373C0", Offset = "0x69361C0", VA = "0x1869373C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x6937410", Offset = "0x6936210", VA = "0x186937410")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x64B1CA0", Offset = "0x64B0AA0", VA = "0x1864B1CA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x6937080", Offset = "0x6935E80", VA = "0x186937080", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6D30", Offset = "0xA5D5B30", VA = "0x18A5D6D30")]
		public static IMeshDecoder<Material> Decode(this Mesh mesh, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6BC0", Offset = "0xA5D59C0", VA = "0x18A5D6BC0")]
		public static IMeshDecoder<Material>[] Decode(this IReadOnlyList<Mesh> meshes, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7CE0", Offset = "0xA5D6AE0", VA = "0x18A5D7CE0")]
		public static Vector3 GetPosition(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7980", Offset = "0xA5D6780", VA = "0x18A5D7980")]
		public static Vector3 GetNormal(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8040", Offset = "0xA5D6E40", VA = "0x18A5D8040")]
		public static Vector4 GetTangent(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8390", Offset = "0xA5D7190", VA = "0x18A5D8390")]
		public static Vector2 GetTextureCoord(this IMeshPrimitiveDecoder primitive, int vertexIdx, int textureSetIndex, IGeometryTransform xform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7620", Offset = "0xA5D6420", VA = "0x18A5D7620")]
		public static Vector4 GetColor(this IMeshPrimitiveDecoder primitive, int vertexIdx, int colorSetIndex, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA5D6DE0", Offset = "0xA5D5BE0", VA = "0x18A5D6DE0")]
		public static (Vector3, Vector3) EvaluateBoundingBox(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7500", Offset = "0xA5D6300", VA = "0x18A5D7500")]
		public static (Vector3, float) EvaluateBoundingSphere(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA5D7210", Offset = "0xA5D6010", VA = "0x18A5D7210")]
		public static (Vector3, float) EvaluateBoundingSphere(this SceneTemplate sceneTemplate, IMeshDecoder<Material>[] decodedMeshes, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3CF67A0", Offset = "0x3CF55A0", VA = "0x183CF67A0")]
		public static (Vector3, Vector3) EvaluateBoundingBox<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6BE0", Offset = "0x3CF59E0", VA = "0x183CF6BE0")]
		public static (Vector3, float) EvaluateBoundingSphere<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA5D86A0", Offset = "0xA5D74A0", VA = "0x18A5D86A0")]
		private static void _AddPointToSphere(Vector3 c1, float r1, Vector3 c2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA5D89A0", Offset = "0xA5D77A0", VA = "0x18A5D89A0")]
		private static void _MergeSphere(Vector3 c1, float r1, Vector3 c2, float r2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6F30", Offset = "0x3CF5D30", VA = "0x183CF6F30")]
		public static IEnumerable<Vector3> GetWorldVertices<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3991E50", Offset = "0x3990C50", VA = "0x183991E50")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xCF75E0", Offset = "0xCF63E0", VA = "0x180CF75E0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IReadOnlyList<IMeshPrimitiveDecoder<TMaterial>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5147290", Offset = "0x5146090", VA = "0x185147290")]
		public _MeshDecoder(Mesh srcMesh, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x51467C0", Offset = "0x51455C0", VA = "0x1851467C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xDC75F0", Offset = "0xDC63F0", VA = "0x180DC75F0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5147530", Offset = "0x5146330", VA = "0x185147530")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E23C0", Offset = "0xA5E11C0", VA = "0x18A5E23C0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int ColorsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xD03CD0", Offset = "0xD02AD0", VA = "0x180D03CD0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int TexCoordsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xE00A00", Offset = "0xDFF800", VA = "0x180E00A00", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int JointsWeightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xCF48A0", Offset = "0xCF36A0", VA = "0x180CF48A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2140", Offset = "0xA5E0F40", VA = "0x18A5E2140", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsPointIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xA5E1EE0", Offset = "0xA5E0CE0", VA = "0x18A5E1EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IEnumerable<(int A, int B)> LineIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xA5E1F00", Offset = "0xA5E0D00", VA = "0x18A5E1F00", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public IEnumerable<(int A, int B, int C)> TriangleIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA5E2180", Offset = "0xA5E0F80", VA = "0x18A5E2180", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E12D0", Offset = "0xA5E00D0", VA = "0x18A5E12D0", Slot = "22")]
		protected virtual string _GetDebugString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E13D0", Offset = "0xA5E01D0", VA = "0x18A5E13D0")]
		internal _MeshPrimitiveDecoder(MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0CE0", Offset = "0xA5DFAE0", VA = "0x18A5E0CE0", Slot = "11")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0C10", Offset = "0xA5DFA10", VA = "0x18A5E0C10", Slot = "17")]
		public IReadOnlyList<Vector3> GetPositionDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0BD0", Offset = "0xA5DF9D0", VA = "0x18A5E0BD0", Slot = "12")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0B00", Offset = "0xA5DF900", VA = "0x18A5E0B00", Slot = "18")]
		public IReadOnlyList<Vector3> GetNormalDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1090", Offset = "0xA5DFE90", VA = "0x18A5E1090", Slot = "13")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0FC0", Offset = "0xA5DFDC0", VA = "0x18A5E0FC0", Slot = "19")]
		public IReadOnlyList<Vector3> GetTangentDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E1210", Offset = "0xA5E0010", VA = "0x18A5E1210", Slot = "14")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E10D0", Offset = "0xA5DFED0", VA = "0x18A5E10D0", Slot = "20")]
		public IReadOnlyList<Vector2> GetTextureCoordDeltas(int vertexIndex, int texCoordSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0A50", Offset = "0xA5DF850", VA = "0x18A5E0A50", Slot = "15")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0910", Offset = "0xA5DF710", VA = "0x18A5E0910", Slot = "21")]
		public IReadOnlyList<Vector4> GetColorDeltas(int vertexIndex, int colorSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0D20", Offset = "0xA5DFB20", VA = "0x18A5E0D20", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E08C0", Offset = "0xA5DF6C0", VA = "0x18A5E08C0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x217A150", Offset = "0x2178F50", VA = "0x18217A150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xE00520", Offset = "0xDFF320", VA = "0x180E00520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0790", Offset = "0xA5DF590", VA = "0x18A5E0790")]
		public _MeshGeometryDecoder(_MeshPrimitiveDecoder owner, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0230", Offset = "0xA5DF030", VA = "0x18A5E0230")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0150", Offset = "0xA5DEF50", VA = "0x18A5E0150")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0310", Offset = "0xA5DF110", VA = "0x18A5E0310")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA5E03E0", Offset = "0xA5DF1E0", VA = "0x18A5E03E0")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0090", Offset = "0xA5DEE90", VA = "0x18A5E0090")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA5E04B0", Offset = "0xA5DF2B0", VA = "0x18A5E04B0", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E04B0", Offset = "0xA5DF2B0", VA = "0x18A5E04B0", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E04D0", Offset = "0xA5DF2D0", VA = "0x18A5E04D0", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E04D0", Offset = "0xA5DF2D0", VA = "0x18A5E04D0", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E05F0", Offset = "0xA5DF3F0", VA = "0x18A5E05F0", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0620", Offset = "0xA5DF420", VA = "0x18A5E0620", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E0500", Offset = "0xA5DF300", VA = "0x18A5E0500", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA5E06A0", Offset = "0xA5DF4A0", VA = "0x18A5E06A0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E37B0", Offset = "0xA5E25B0", VA = "0x18A5E37B0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x217A150", Offset = "0x2178F50", VA = "0x18217A150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xE00520", Offset = "0xDFF320", VA = "0x180E00520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA5E31E0", Offset = "0xA5E1FE0", VA = "0x18A5E31E0")]
		public _MorphTargetDecoder(_MeshGeometryDecoder geometry, MeshPrimitive srcPrim, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2BE0", Offset = "0xA5E19E0", VA = "0x18A5E2BE0")]
		public bool HasTexCoord(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2BC0", Offset = "0xA5E19C0", VA = "0x18A5E2BC0")]
		public bool HasColor(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA5E28A0", Offset = "0xA5E16A0", VA = "0x18A5E28A0")]
		public Vector3 GetPositionBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA5E28E0", Offset = "0xA5E16E0", VA = "0x18A5E28E0")]
		public Vector3 GetPositionDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2770", Offset = "0xA5E1570", VA = "0x18A5E2770")]
		public Vector3 GetNormalBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E27B0", Offset = "0xA5E15B0", VA = "0x18A5E27B0")]
		public Vector3 GetNormalDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E29D0", Offset = "0xA5E17D0", VA = "0x18A5E29D0")]
		public Vector4 GetTangentBase(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2A10", Offset = "0xA5E1810", VA = "0x18A5E2A10")]
		public Vector3 GetTangentDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2BA0", Offset = "0xA5E19A0", VA = "0x18A5E2BA0")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2B00", Offset = "0xA5E1900", VA = "0x18A5E2B00")]
		public Vector2 GetTextureCoordDelta(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E26A0", Offset = "0xA5E14A0", VA = "0x18A5E26A0")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA5E25F0", Offset = "0xA5E13F0", VA = "0x18A5E25F0")]
		public Vector4 GetColorDelta(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2C00", Offset = "0xA5E1A00", VA = "0x18A5E2C00", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2E80", Offset = "0xA5E1C80", VA = "0x18A5E2E80", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2C50", Offset = "0xA5E1A50", VA = "0x18A5E2C50", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2C50", Offset = "0xA5E1A50", VA = "0x18A5E2C50", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2ED0", Offset = "0xA5E1CD0", VA = "0x18A5E2ED0", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2FA0", Offset = "0xA5E1DA0", VA = "0x18A5E2FA0", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2D20", Offset = "0xA5E1B20", VA = "0x18A5E2D20", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3020", Offset = "0xA5E1E20", VA = "0x18A5E3020", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E3A30", Offset = "0xA5E2830", VA = "0x18A5E3A30", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA5E39E0", Offset = "0xA5E27E0", VA = "0x18A5E39E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xD9EB20", Offset = "0xD9D920", VA = "0x180D9EB20")]
		public _MorphTargetPositionSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3960", Offset = "0xA5E2760", VA = "0x18A5E3960", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E39A0", Offset = "0xA5E27A0", VA = "0x18A5E39A0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E38D0", Offset = "0xA5E26D0", VA = "0x18A5E38D0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5E3880", Offset = "0xA5E2680", VA = "0x18A5E3880", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xD9EB20", Offset = "0xD9D920", VA = "0x180D9EB20")]
		public _MorphTargetNormalSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3800", Offset = "0xA5E2600", VA = "0x18A5E3800", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3840", Offset = "0xA5E2640", VA = "0x18A5E3840", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E3B90", Offset = "0xA5E2990", VA = "0x18A5E3B90", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA5E3B40", Offset = "0xA5E2940", VA = "0x18A5E3B40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xD9EB20", Offset = "0xD9D920", VA = "0x180D9EB20")]
		public _MorphTargetTangentSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3AC0", Offset = "0xA5E28C0", VA = "0x18A5E3AC0", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3B00", Offset = "0xA5E2900", VA = "0x18A5E3B00", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E3DA0", Offset = "0xA5E2BA0", VA = "0x18A5E3DA0", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA5E3D50", Offset = "0xA5E2B50", VA = "0x18A5E3D50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC780", Offset = "0x4EAB580", VA = "0x184EAC780")]
		public _MorphTargetTexCoordSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3CD0", Offset = "0xA5E2AD0", VA = "0x18A5E3CD0", Slot = "6")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3D10", Offset = "0xA5E2B10", VA = "0x18A5E3D10", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E24F0", Offset = "0xA5E12F0", VA = "0x18A5E24F0", Slot = "4")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA5E24A0", Offset = "0xA5E12A0", VA = "0x18A5E24A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC780", Offset = "0x4EAB580", VA = "0x184EAC780")]
		public _MorphTargetColorSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2420", Offset = "0xA5E1220", VA = "0x18A5E2420", Slot = "6")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5E2460", Offset = "0xA5E1260", VA = "0x18A5E2460", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x88621D0", Offset = "0x8860FD0", VA = "0x1888621D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA064FA0", Offset = "0xA063DA0", VA = "0x18A064FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NodeInstance VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public SparseWeight8 MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA5D92D0", Offset = "0xA5D80D0", VA = "0x18A5D92D0")]
			get
			{
				return default(SparseWeight8);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA5D93B0", Offset = "0xA5D81B0", VA = "0x18A5D93B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9260", Offset = "0xA5D8060", VA = "0x18A5D9260")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9360", Offset = "0xA5D8160", VA = "0x18A5D9360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Matrix4x4 ModelMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9290", Offset = "0xA5D8090", VA = "0x18A5D9290")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA5D90B0", Offset = "0xA5D7EB0", VA = "0x18A5D90B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x10B8200", Offset = "0x10B7000", VA = "0x1810B8200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x10B8710", Offset = "0x10B7510", VA = "0x1810B8710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private bool TransformChainIsDirty
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA5D9300", Offset = "0xA5D8100", VA = "0x18A5D9300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xCE9C40", Offset = "0xCE8A40", VA = "0x180CE9C40")]
		internal NodeInstance(NodeTemplate template, NodeInstance parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8E40", Offset = "0xA5D7C40", VA = "0x18A5D8E40")]
		private Matrix4x4 _GetModelMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D90B0", Offset = "0xA5D7EB0", VA = "0x18A5D90B0")]
		private void _SetModelMatrix(Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D8D50", Offset = "0xA5D7B50", VA = "0x18A5D8D50")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4890", Offset = "0xCF3690", VA = "0x180CF4890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4810", Offset = "0xCF3610", VA = "0x180CF4810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4840", Offset = "0xCF3640", VA = "0x180CF4840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4830", Offset = "0xCF3630", VA = "0x180CF4830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int ParentIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xDDD300", Offset = "0xDDC100", VA = "0x180DDD300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IReadOnlyList<int> ChildIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA5DA730", Offset = "0xA5D9530", VA = "0x18A5DA730")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9F20", Offset = "0xA5D8D20", VA = "0x18A5D9F20")]
		internal NodeTemplate(Node srcNode, int parentIdx, int[] childIndices, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9C20", Offset = "0xA5D8A20", VA = "0x18A5D9C20")]
		public SparseWeight8 GetMorphWeights(int trackLogicalIndex, float time)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9950", Offset = "0xA5D8750", VA = "0x18A5D9950")]
		public SparseWeight8 GetMorphWeights(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9660", Offset = "0xA5D8460", VA = "0x18A5D9660")]
		public AffineTransform GetLocalTransform(int trackLogicalIndex, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5D96F0", Offset = "0xA5D84F0", VA = "0x18A5D96F0")]
		public AffineTransform GetLocalTransform(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5D93E0", Offset = "0xA5D81E0", VA = "0x18A5D93E0")]
		public Matrix4x4 GetLocalMatrix(int trackLogicalIndex, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9500", Offset = "0xA5D8300", VA = "0x18A5D9500")]
		public Matrix4x4 GetLocalMatrix(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9E80", Offset = "0xA5D8C80", VA = "0x18A5D9E80")]
		public bool? GetVisibility(int trackLogicalIndex, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5D9D00", Offset = "0xA5D8B00", VA = "0x18A5D9D00")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E4510", Offset = "0xA5E3310", VA = "0x18A5E4510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5E41D0", Offset = "0xA5E2FD0", VA = "0x18A5E41D0")]
		public _NodeTemplateTransforms(Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4080", Offset = "0xA5E2E80", VA = "0x18A5E4080")]
		public void SetCurves(NodeCurveSamplers curves, int index, bool isolateMemory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5E3E80", Offset = "0xA5E2C80", VA = "0x18A5E3E80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3CC00", Offset = "0xD3BA00", VA = "0x180D3CC00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xE0DF60", Offset = "0xE0CD60", VA = "0x180E0DF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MeshInstancing GpuMeshInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xDDD300", Offset = "0xDDC100", VA = "0x180DDD300")]
			[CompilerGenerated]
			get
			{
				return default(MeshInstancing);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xDDD310", Offset = "0xDDC110", VA = "0x180DDD310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Converter<ExtraProperties, object> ExtrasConverterCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DAA20", Offset = "0xA5D9820", VA = "0x18A5DAA20")]
		internal static object ConvertExtras(ExtraProperties source, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x15FFDE0", Offset = "0x15FEBE0", VA = "0x1815FFDE0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5DBF40", Offset = "0xA5DAD40", VA = "0x18A5DBF40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public <GetEnumerator>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBD40", Offset = "0xA5DAB40", VA = "0x18A5DBD40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA5DBF00", Offset = "0xA5DAD00", VA = "0x18A5DBF00", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA5DAB00", Offset = "0xA5D9900", VA = "0x18A5DAB00")]
		internal SceneInstance(ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DAA90", Offset = "0xA5D9890", VA = "0x18A5DAA90", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA5DAA90", Offset = "0xA5D9890", VA = "0x18A5DAA90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public (Vector3 center, float radius) SphereBounds
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xF71A30", Offset = "0xF70830", VA = "0x180F71A30")]
			[CompilerGenerated]
			get
			{
				return default((Vector3, float));
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xF72010", Offset = "0xF70E10", VA = "0x180F72010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public IEnumerable<int> LogicalMeshIds
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA5DB750", Offset = "0xA5DA550", VA = "0x18A5DB750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DAE30", Offset = "0xA5D9C30", VA = "0x18A5DAE30")]
		public static SceneTemplate Create(Scene srcScene, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1117370", Offset = "0x1116170", VA = "0x181117370")]
		private SceneTemplate(string name, object extras, ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DAD80", Offset = "0xA5D9B80", VA = "0x18A5DAD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x40D0180", Offset = "0x40CEF80", VA = "0x1840D0180")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5DD9B0", Offset = "0xA5DC7B0", VA = "0x18A5DD9B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40E2DA0", Offset = "0x40E1BA0", VA = "0x1840E2DA0")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDB70", Offset = "0xA5DC970", VA = "0x18A5DDB70")]
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

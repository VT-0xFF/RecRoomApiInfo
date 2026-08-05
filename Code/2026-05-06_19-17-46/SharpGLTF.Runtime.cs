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
		[Cpp2IlInjected.Address(RVA = "0xA5FA280", Offset = "0xA5F8C80", VA = "0x18A5FA280")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9250", Offset = "0xA5F7C50", VA = "0x18A5F9250")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA5F94C0", Offset = "0xA5F7EC0", VA = "0x18A5F94C0")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9710", Offset = "0xA5F8110", VA = "0x18A5F9710")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5F91B0", Offset = "0xA5F7BB0", VA = "0x18A5F91B0")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9F00", Offset = "0xA5F8900", VA = "0x18A5F9F00")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9DE0", Offset = "0xA5F87E0", VA = "0x18A5F9DE0")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA3D0", Offset = "0xA5F8DD0", VA = "0x18A5FA3D0")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA370", Offset = "0xA5F8D70", VA = "0x18A5FA370")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9C20", Offset = "0xA5F8620", VA = "0x18A5F9C20")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8240", Offset = "0x3AD6C40", VA = "0x183AD8240")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6B80", Offset = "0x3AD5580", VA = "0x183AD6B80")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9C80", Offset = "0xA5F8680", VA = "0x18A5F9C80")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7CE0", Offset = "0x3AD66E0", VA = "0x183AD7CE0")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7880", Offset = "0x3AD6280", VA = "0x183AD7880")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7430", Offset = "0x3AD5E30", VA = "0x183AD7430")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7130", Offset = "0x3AD5B30", VA = "0x183AD7130")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3AD39B0", Offset = "0x3AD23B0", VA = "0x183AD39B0")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9810", Offset = "0xA5F8210", VA = "0x18A5F9810")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA5F97B0", Offset = "0xA5F81B0", VA = "0x18A5F97B0")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9870", Offset = "0xA5F8270", VA = "0x18A5F9870")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA120", Offset = "0xA5F8B20", VA = "0x18A5FA120")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA020", Offset = "0xA5F8A20", VA = "0x18A5FA020")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5B60", Offset = "0x3AD4560", VA = "0x183AD5B60")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8F20", Offset = "0xA5F7920", VA = "0x18A5F8F20")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AD49F0", Offset = "0x3AD33F0", VA = "0x183AD49F0")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AD49F0", Offset = "0x3AD33F0", VA = "0x183AD49F0")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AD49F0", Offset = "0x3AD33F0", VA = "0x183AD49F0")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AD49F0", Offset = "0x3AD33F0", VA = "0x183AD49F0")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AD49F0", Offset = "0x3AD33F0", VA = "0x183AD49F0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AD3D90", Offset = "0x3AD2790", VA = "0x183AD3D90")]
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
					[Cpp2IlInjected.Address(RVA = "0x66B81E0", Offset = "0x66B6BE0", VA = "0x1866B81E0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x66BB590", Offset = "0x66B9F90", VA = "0x1866BB590", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x4F166D0", Offset = "0x4F150D0", VA = "0x184F166D0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x670ACC0", Offset = "0x67096C0", VA = "0x18670ACC0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x670B950", Offset = "0x670A350", VA = "0x18670B950", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x67107C0", Offset = "0x670F1C0", VA = "0x1867107C0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
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
					[Cpp2IlInjected.Token(Token = "0x6000084")]
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x6F7BD30", Offset = "0x6F7A730", VA = "0x186F7BD30", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6F810C0", Offset = "0x6F7FAC0", VA = "0x186F810C0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6F85520", Offset = "0x6F83F20", VA = "0x186F85520")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
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
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x51BF7C0", Offset = "0x51BE1C0", VA = "0x1851BF7C0", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x51BF760", Offset = "0x51BE160", VA = "0x1851BF760", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x51BF4C0", Offset = "0x51BDEC0", VA = "0x1851BF4C0", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x51BF5E0", Offset = "0x51BDFE0", VA = "0x1851BF5E0", Slot = "7")]
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
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0x66BB590", Offset = "0x66B9F90", VA = "0x1866BB590", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x4F166D0", Offset = "0x4F150D0", VA = "0x184F166D0")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x670ACC0", Offset = "0x67096C0", VA = "0x18670ACC0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x670A350", Offset = "0x6708D50", VA = "0x18670A350", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x670B260", Offset = "0x6709C60", VA = "0x18670B260")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
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
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6F7BD30", Offset = "0x6F7A730", VA = "0x186F7BD30", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6F7AAD0", Offset = "0x6F794D0", VA = "0x186F7AAD0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6F7C240", Offset = "0x6F7AC40", VA = "0x186F7C240")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000095")]
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
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x51B6920", Offset = "0x51B5320", VA = "0x1851B6920", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x51B6680", Offset = "0x51B5080", VA = "0x1851B6680", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x51B6850", Offset = "0x51B5250", VA = "0x1851B6850", Slot = "6")]
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
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xA6011A0", Offset = "0xA5FFBA0", VA = "0x18A6011A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x653C0B0", Offset = "0x653AAB0", VA = "0x18653C0B0")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA6011F0", Offset = "0xA5FFBF0", VA = "0x18A6011F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA600E50", Offset = "0xA5FF850", VA = "0x18A600E50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA6012B0", Offset = "0xA5FFCB0", VA = "0x18A6012B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA601160", Offset = "0xA5FFB60", VA = "0x18A601160", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA6010B0", Offset = "0xA5FFAB0", VA = "0x18A6010B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA6010B0", Offset = "0xA5FFAB0", VA = "0x18A6010B0", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0xA601C90", Offset = "0xA600690", VA = "0x18A601C90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA601CE0", Offset = "0xA6006E0", VA = "0x18A601CE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA601300", Offset = "0xA5FFD00", VA = "0x18A601300", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA601ED0", Offset = "0xA6008D0", VA = "0x18A601ED0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA601F20", Offset = "0xA600920", VA = "0x18A601F20")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA601F70", Offset = "0xA600970", VA = "0x18A601F70")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA601C50", Offset = "0xA600650", VA = "0x18A601C50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA601BA0", Offset = "0xA6005A0", VA = "0x18A601BA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA601BA0", Offset = "0xA6005A0", VA = "0x18A601BA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA550800", Offset = "0xA54F200", VA = "0x18A550800")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA5521F0", Offset = "0xA550BF0", VA = "0x18A5521F0")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA552320", Offset = "0xA550D20", VA = "0x18A552320")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA552230", Offset = "0xA550C30", VA = "0x18A552230")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA552350", Offset = "0xA550D50", VA = "0x18A552350")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA552290", Offset = "0xA550C90", VA = "0x18A552290")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5523C0", Offset = "0xA550DC0", VA = "0x18A5523C0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA552290", Offset = "0xA550C90", VA = "0x18A552290")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA552120", Offset = "0xA550B20", VA = "0x18A552120")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA603540", Offset = "0xA601F40", VA = "0x18A603540")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA603420", Offset = "0xA601E20", VA = "0x18A603420")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA54FBA0", Offset = "0xA54E5A0", VA = "0x18A54FBA0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA603DD0", Offset = "0xA6027D0", VA = "0x18A603DD0")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA5507B0", Offset = "0xA54F1B0", VA = "0x18A5507B0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA550750", Offset = "0xA54F150", VA = "0x18A550750")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA550A30", Offset = "0xA54F430", VA = "0x18A550A30")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA604990", Offset = "0xA603390", VA = "0x18A604990")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA604B10", Offset = "0xA603510", VA = "0x18A604B10")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA603740", Offset = "0xA602140", VA = "0x18A603740")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA603640", Offset = "0xA602040", VA = "0x18A603640")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA603A10", Offset = "0xA602410", VA = "0x18A603A10")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA603290", Offset = "0xA601C90", VA = "0x18A603290")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA6036C0", Offset = "0xA6020C0", VA = "0x18A6036C0")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA551300", Offset = "0xA54FD00", VA = "0x18A551300")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA6036D0", Offset = "0xA6020D0", VA = "0x18A6036D0")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA550520", Offset = "0xA54EF20", VA = "0x18A550520")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA550460", Offset = "0xA54EE60", VA = "0x18A550460")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4152280", Offset = "0x4150C80", VA = "0x184152280")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA54FD10", Offset = "0xA54E710", VA = "0x18A54FD10")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA54FE80", Offset = "0xA54E880", VA = "0x18A54FE80")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4153630", Offset = "0x4152030", VA = "0x184153630")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4154760", Offset = "0x4153160", VA = "0x184154760")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4154930", Offset = "0x4153330", VA = "0x184154930")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4154A10", Offset = "0x4153410", VA = "0x184154A10")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x41522A0", Offset = "0x4150CA0", VA = "0x1841522A0")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4153460", Offset = "0x4151E60", VA = "0x184153460")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4153350", Offset = "0x4151D50", VA = "0x184153350")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4152A90", Offset = "0x4151490", VA = "0x184152A90")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4154680", Offset = "0x4153080", VA = "0x184154680")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4153FE0", Offset = "0x41529E0", VA = "0x184153FE0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4154430", Offset = "0x4152E30", VA = "0x184154430")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4154180", Offset = "0x4152B80", VA = "0x184154180")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4152940", Offset = "0x4151340", VA = "0x184152940")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x41526F0", Offset = "0x41510F0", VA = "0x1841526F0")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4151F00", Offset = "0x4150900", VA = "0x184151F00")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4152330", Offset = "0x4150D30", VA = "0x184152330")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA603810", Offset = "0xA602210", VA = "0x18A603810")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA603B70", Offset = "0xA602570", VA = "0x18A603B70")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x41546E0", Offset = "0x41530E0", VA = "0x1841546E0")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x41546E0", Offset = "0x41530E0", VA = "0x1841546E0")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA604080", Offset = "0xA602A80", VA = "0x18A604080")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA602C90", Offset = "0xA601690", VA = "0x18A602C90")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA602BE0", Offset = "0xA6015E0", VA = "0x18A602BE0")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA604000", Offset = "0xA602A00", VA = "0x18A604000")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA604760", Offset = "0xA603160", VA = "0x18A604760")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA602D10", Offset = "0xA601710", VA = "0x18A602D10")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA604280", Offset = "0xA602C80", VA = "0x18A604280")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA604350", Offset = "0xA602D50", VA = "0x18A604350")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA603030", Offset = "0xA601A30", VA = "0x18A603030")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA602DD0", Offset = "0xA6017D0", VA = "0x18A602DD0")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA6030D0", Offset = "0xA601AD0", VA = "0x18A6030D0")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA602F10", Offset = "0xA601910", VA = "0x18A602F10")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA603210", Offset = "0xA601C10", VA = "0x18A603210")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x23855B0", Offset = "0x2383FB0", VA = "0x1823855B0")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA552210", Offset = "0xA550C10", VA = "0x18A552210")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4154C40", Offset = "0x4153640", VA = "0x184154C40")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA603F40", Offset = "0xA602940", VA = "0x18A603F40")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA602F90", Offset = "0xA601990", VA = "0x18A602F90")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA6048E0", Offset = "0xA6032E0", VA = "0x18A6048E0")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA604D10", Offset = "0xA603710", VA = "0x18A604D10")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA6047E0", Offset = "0xA6031E0", VA = "0x18A6047E0")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA54FDB0", Offset = "0xA54E7B0", VA = "0x18A54FDB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCD8BE0", Offset = "0xCD75E0", VA = "0x180CD8BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x74B8F50", Offset = "0x74B7950", VA = "0x1874B8F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74B7DA0", Offset = "0x74B67A0", VA = "0x1874B7DA0")]
		internal AnimatableProperty(T defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x74AF3C0", Offset = "0x74ADDC0", VA = "0x1874AF3C0")]
		public T GetValueAt(int trackLogicalIndex, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x74B0A70", Offset = "0x74AF470", VA = "0x1874B0A70")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xD2E370", Offset = "0xD2CD70", VA = "0x180D2E370")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x1099750", Offset = "0x1098150", VA = "0x181099750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6010", Offset = "0xA5F4A10", VA = "0x18A5F6010")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<NodeInstance> VisualNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA5F6810", Offset = "0xA5F5210", VA = "0x18A5F6810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyList<AnimationTrackInfo> AnimationTracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5F65D0", Offset = "0xA5F4FD0", VA = "0x18A5F65D0")]
		internal ArmatureInstance(ArmatureTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F60F0", Offset = "0xA5F4AF0", VA = "0x18A5F60F0")]
		public void SetLocalMatrix(string name, Matrix4x4 localMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6290", Offset = "0xA5F4C90", VA = "0x18A5F6290")]
		public void SetModelMatrix(string name, Matrix4x4 modelMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6590", Offset = "0xA5F4F90", VA = "0x18A5F6590")]
		public void SetPoseTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6080", Offset = "0xA5F4A80", VA = "0x18A5F6080")]
		public void SetAnimationFrame(int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5F60C0", Offset = "0xA5F4AC0", VA = "0x18A5F60C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyList<MaterialTemplate> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<AnimationTrackInfo> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7670", Offset = "0xA5F6070", VA = "0x18A5F7670")]
		internal static ArmatureTemplate Create(Scene srcScene, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8560", Offset = "0xA5F6F60", VA = "0x18A5F8560")]
		private ArmatureTemplate(NodeTemplate[] nodes, MaterialTemplate[] materials, AnimationTrackInfo[] animTracks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7640", Offset = "0xA5F6040", VA = "0x18A5F7640")]
		internal void ApplyDefaultPoseTo(ArmatureInstance instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6930", Offset = "0xA5F5330", VA = "0x18A5F6930")]
		internal void ApplyAnimationTo(ArmatureInstance instance, int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6D00", Offset = "0xA5F5700", VA = "0x18A5F6D00")]
		internal void ApplyAnimationTo(ArmatureInstance instance, (int TrackIdx, float Time, float Weight)[] blended)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8330", Offset = "0xA5F6D30", VA = "0x18A5F8330")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F8E50", Offset = "0xA5F7850", VA = "0x18A5F8E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8AC0", Offset = "0xA5F74C0", VA = "0x18A5F8AC0")]
		private string _ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x10E4340", Offset = "0x10E2D40", VA = "0x1810E4340")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int LogicalMeshIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1620320", Offset = "0x161ED20", VA = "0x181620320", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8EB0", Offset = "0xA5F78B0", VA = "0x18A5F8EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5FF840", Offset = "0xA5FE240", VA = "0x18A5FF840")]
		internal RigidDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF660", Offset = "0xA5FE060", VA = "0x18A5FF660", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF6B0", Offset = "0xA5FE0B0", VA = "0x18A5FF6B0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA7E0", Offset = "0xA5F91E0", VA = "0x18A5FA7E0")]
		internal InstancedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA570", Offset = "0xA5F8F70", VA = "0x18A5FA570", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA5D0", Offset = "0xA5F8FD0", VA = "0x18A5FA5D0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6009C0", Offset = "0xA5FF3C0", VA = "0x18A6009C0")]
		internal SkinnedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA600740", Offset = "0xA5FF140", VA = "0x18A600740", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA600790", Offset = "0xA5FF190", VA = "0x18A600790", Slot = "7")]
		public override void UpdateGeometryTransform(IGeometryTransform skinnedTransform, ArmatureInstance armature)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class MaterialInstance
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF54E40", Offset = "0xF53840", VA = "0x180F54E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E10", Offset = "0xCD5810", VA = "0x180CD6E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DF0", Offset = "0xCD57F0", VA = "0x180CD6DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB060", Offset = "0xA5F9A60", VA = "0x18A5FB060")]
		internal MaterialTemplate(Material srcMaterial, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3CF69C0", Offset = "0x3CF53C0", VA = "0x183CF69C0")]
		private void _AddAnimatableProperty<T>(Dictionary<string, AnimatableProperty<T>> dict, int trackIdx, AnimationChannel channel, string pointerPath, T defaultSingle, bool isolateMemory) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FACE0", Offset = "0xA5F96E0", VA = "0x18A5FACE0")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, float> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA960", Offset = "0xA5F9360", VA = "0x18A5FA960")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector2> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA5FAE80", Offset = "0xA5F9880", VA = "0x18A5FAE80")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector3> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA5FAB10", Offset = "0xA5F9510", VA = "0x18A5FAB10")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A06E20", Offset = "0x1A05820", VA = "0x181A06E20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6A34BA0", Offset = "0x6A335A0", VA = "0x186A34BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public <GetWorldVertices>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x6A34BF0", Offset = "0x6A335F0", VA = "0x186A34BF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6A34520", Offset = "0x6A32F20", VA = "0x186A34520", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x6A34E20", Offset = "0x6A33820", VA = "0x186A34E20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x6A34E70", Offset = "0x6A33870", VA = "0x186A34E70")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x652EDA0", Offset = "0x652D7A0", VA = "0x18652EDA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x6A34AE0", Offset = "0x6A334E0", VA = "0x186A34AE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBBE0", Offset = "0xA5FA5E0", VA = "0x18A5FBBE0")]
		public static IMeshDecoder<Material> Decode(this Mesh mesh, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBA70", Offset = "0xA5FA470", VA = "0x18A5FBA70")]
		public static IMeshDecoder<Material>[] Decode(this IReadOnlyList<Mesh> meshes, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB90", Offset = "0xA5FB590", VA = "0x18A5FCB90")]
		public static Vector3 GetPosition(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC830", Offset = "0xA5FB230", VA = "0x18A5FC830")]
		public static Vector3 GetNormal(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCEF0", Offset = "0xA5FB8F0", VA = "0x18A5FCEF0")]
		public static Vector4 GetTangent(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD240", Offset = "0xA5FBC40", VA = "0x18A5FD240")]
		public static Vector2 GetTextureCoord(this IMeshPrimitiveDecoder primitive, int vertexIdx, int textureSetIndex, IGeometryTransform xform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC4D0", Offset = "0xA5FAED0", VA = "0x18A5FC4D0")]
		public static Vector4 GetColor(this IMeshPrimitiveDecoder primitive, int vertexIdx, int colorSetIndex, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBC90", Offset = "0xA5FA690", VA = "0x18A5FBC90")]
		public static (Vector3, Vector3) EvaluateBoundingBox(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC3B0", Offset = "0xA5FADB0", VA = "0x18A5FC3B0")]
		public static (Vector3, float) EvaluateBoundingSphere(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC0C0", Offset = "0xA5FAAC0", VA = "0x18A5FC0C0")]
		public static (Vector3, float) EvaluateBoundingSphere(this SceneTemplate sceneTemplate, IMeshDecoder<Material>[] decodedMeshes, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A6B0", Offset = "0x3D090B0", VA = "0x183D0A6B0")]
		public static (Vector3, Vector3) EvaluateBoundingBox<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3D0AAF0", Offset = "0x3D094F0", VA = "0x183D0AAF0")]
		public static (Vector3, float) EvaluateBoundingSphere<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD550", Offset = "0xA5FBF50", VA = "0x18A5FD550")]
		private static void _AddPointToSphere(Vector3 c1, float r1, Vector3 c2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD850", Offset = "0xA5FC250", VA = "0x18A5FD850")]
		private static void _MergeSphere(Vector3 c1, float r1, Vector3 c2, float r2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3D0AE40", Offset = "0x3D09840", VA = "0x183D0AE40")]
		public static IEnumerable<Vector3> GetWorldVertices<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x39970A0", Offset = "0x3995AA0", VA = "0x1839970A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IReadOnlyList<IMeshPrimitiveDecoder<TMaterial>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x51C71C0", Offset = "0x51C5BC0", VA = "0x1851C71C0")]
		public _MeshDecoder(Mesh srcMesh, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x51C66F0", Offset = "0x51C50F0", VA = "0x1851C66F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xDB03C0", Offset = "0xDAEDC0", VA = "0x180DB03C0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x51C7460", Offset = "0x51C5E60", VA = "0x1851C7460")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6072A0", Offset = "0xA605CA0", VA = "0x18A6072A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int ColorsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xCF3DF0", Offset = "0xCF27F0", VA = "0x180CF3DF0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int TexCoordsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xE19770", Offset = "0xE18170", VA = "0x180E19770", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int JointsWeightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xCD9A60", Offset = "0xCD8460", VA = "0x180CD9A60", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xA607020", Offset = "0xA605A20", VA = "0x18A607020", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsPointIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xA606DC0", Offset = "0xA6057C0", VA = "0x18A606DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IEnumerable<(int A, int B)> LineIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xA606DE0", Offset = "0xA6057E0", VA = "0x18A606DE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public IEnumerable<(int A, int B, int C)> TriangleIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA607060", Offset = "0xA605A60", VA = "0x18A607060", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA6061B0", Offset = "0xA604BB0", VA = "0x18A6061B0", Slot = "22")]
		protected virtual string _GetDebugString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA6062B0", Offset = "0xA604CB0", VA = "0x18A6062B0")]
		internal _MeshPrimitiveDecoder(MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA605BC0", Offset = "0xA6045C0", VA = "0x18A605BC0", Slot = "11")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA605AF0", Offset = "0xA6044F0", VA = "0x18A605AF0", Slot = "17")]
		public IReadOnlyList<Vector3> GetPositionDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA605AB0", Offset = "0xA6044B0", VA = "0x18A605AB0", Slot = "12")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA6059E0", Offset = "0xA6043E0", VA = "0x18A6059E0", Slot = "18")]
		public IReadOnlyList<Vector3> GetNormalDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA605F70", Offset = "0xA604970", VA = "0x18A605F70", Slot = "13")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA605EA0", Offset = "0xA6048A0", VA = "0x18A605EA0", Slot = "19")]
		public IReadOnlyList<Vector3> GetTangentDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA6060F0", Offset = "0xA604AF0", VA = "0x18A6060F0", Slot = "14")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA605FB0", Offset = "0xA6049B0", VA = "0x18A605FB0", Slot = "20")]
		public IReadOnlyList<Vector2> GetTextureCoordDeltas(int vertexIndex, int texCoordSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA605930", Offset = "0xA604330", VA = "0x18A605930", Slot = "15")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA6057F0", Offset = "0xA6041F0", VA = "0x18A6057F0", Slot = "21")]
		public IReadOnlyList<Vector4> GetColorDeltas(int vertexIndex, int colorSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA605C00", Offset = "0xA604600", VA = "0x18A605C00", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6057A0", Offset = "0xA6041A0", VA = "0x18A6057A0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x217D0A0", Offset = "0x217BAA0", VA = "0x18217D0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xE19A30", Offset = "0xE18430", VA = "0x180E19A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA605670", Offset = "0xA604070", VA = "0x18A605670")]
		public _MeshGeometryDecoder(_MeshPrimitiveDecoder owner, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA605110", Offset = "0xA603B10", VA = "0x18A605110")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA605030", Offset = "0xA603A30", VA = "0x18A605030")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA6051F0", Offset = "0xA603BF0", VA = "0x18A6051F0")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA6052C0", Offset = "0xA603CC0", VA = "0x18A6052C0")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA604F70", Offset = "0xA603970", VA = "0x18A604F70")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA605390", Offset = "0xA603D90", VA = "0x18A605390", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA605390", Offset = "0xA603D90", VA = "0x18A605390", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA6053B0", Offset = "0xA603DB0", VA = "0x18A6053B0", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA6053B0", Offset = "0xA603DB0", VA = "0x18A6053B0", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA6054D0", Offset = "0xA603ED0", VA = "0x18A6054D0", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA605500", Offset = "0xA603F00", VA = "0x18A605500", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA6053E0", Offset = "0xA603DE0", VA = "0x18A6053E0", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA605580", Offset = "0xA603F80", VA = "0x18A605580", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA608690", Offset = "0xA607090", VA = "0x18A608690", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x217D0A0", Offset = "0x217BAA0", VA = "0x18217D0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xE19A30", Offset = "0xE18430", VA = "0x180E19A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA6080C0", Offset = "0xA606AC0", VA = "0x18A6080C0")]
		public _MorphTargetDecoder(_MeshGeometryDecoder geometry, MeshPrimitive srcPrim, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA607AC0", Offset = "0xA6064C0", VA = "0x18A607AC0")]
		public bool HasTexCoord(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA607AA0", Offset = "0xA6064A0", VA = "0x18A607AA0")]
		public bool HasColor(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA607780", Offset = "0xA606180", VA = "0x18A607780")]
		public Vector3 GetPositionBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA6077C0", Offset = "0xA6061C0", VA = "0x18A6077C0")]
		public Vector3 GetPositionDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA607650", Offset = "0xA606050", VA = "0x18A607650")]
		public Vector3 GetNormalBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA607690", Offset = "0xA606090", VA = "0x18A607690")]
		public Vector3 GetNormalDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA6078B0", Offset = "0xA6062B0", VA = "0x18A6078B0")]
		public Vector4 GetTangentBase(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA6078F0", Offset = "0xA6062F0", VA = "0x18A6078F0")]
		public Vector3 GetTangentDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA607A80", Offset = "0xA606480", VA = "0x18A607A80")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA6079E0", Offset = "0xA6063E0", VA = "0x18A6079E0")]
		public Vector2 GetTextureCoordDelta(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA607580", Offset = "0xA605F80", VA = "0x18A607580")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA6074D0", Offset = "0xA605ED0", VA = "0x18A6074D0")]
		public Vector4 GetColorDelta(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA607AE0", Offset = "0xA6064E0", VA = "0x18A607AE0", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA607D60", Offset = "0xA606760", VA = "0x18A607D60", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA607B30", Offset = "0xA606530", VA = "0x18A607B30", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA607B30", Offset = "0xA606530", VA = "0x18A607B30", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA607DB0", Offset = "0xA6067B0", VA = "0x18A607DB0", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA607E80", Offset = "0xA606880", VA = "0x18A607E80", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA607C00", Offset = "0xA606600", VA = "0x18A607C00", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA607F00", Offset = "0xA606900", VA = "0x18A607F00", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA608910", Offset = "0xA607310", VA = "0x18A608910", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA6088C0", Offset = "0xA6072C0", VA = "0x18A6088C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8D750", VA = "0x180D8ED50")]
		public _MorphTargetPositionSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA608840", Offset = "0xA607240", VA = "0x18A608840", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA608880", Offset = "0xA607280", VA = "0x18A608880", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6087B0", Offset = "0xA6071B0", VA = "0x18A6087B0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA608760", Offset = "0xA607160", VA = "0x18A608760", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8D750", VA = "0x180D8ED50")]
		public _MorphTargetNormalSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6086E0", Offset = "0xA6070E0", VA = "0x18A6086E0", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA608720", Offset = "0xA607120", VA = "0x18A608720", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA608A70", Offset = "0xA607470", VA = "0x18A608A70", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA608A20", Offset = "0xA607420", VA = "0x18A608A20", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8D750", VA = "0x180D8ED50")]
		public _MorphTargetTangentSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA6089A0", Offset = "0xA6073A0", VA = "0x18A6089A0", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6089E0", Offset = "0xA6073E0", VA = "0x18A6089E0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA608C80", Offset = "0xA607680", VA = "0x18A608C80", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA608C30", Offset = "0xA607630", VA = "0x18A608C30", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD440", Offset = "0x4EDBE40", VA = "0x184EDD440")]
		public _MorphTargetTexCoordSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA608BB0", Offset = "0xA6075B0", VA = "0x18A608BB0", Slot = "6")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA608BF0", Offset = "0xA6075F0", VA = "0x18A608BF0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6073D0", Offset = "0xA605DD0", VA = "0x18A6073D0", Slot = "4")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA607380", Offset = "0xA605D80", VA = "0x18A607380", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD440", Offset = "0x4EDBE40", VA = "0x184EDD440")]
		public _MorphTargetColorSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA607300", Offset = "0xA605D00", VA = "0x18A607300", Slot = "6")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA607340", Offset = "0xA605D40", VA = "0x18A607340", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x8882FD0", Offset = "0x88819D0", VA = "0x188882FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA08F560", Offset = "0xA08DF60", VA = "0x18A08F560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NodeInstance VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public SparseWeight8 MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE180", Offset = "0xA5FCB80", VA = "0x18A5FE180")]
			get
			{
				return default(SparseWeight8);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE260", Offset = "0xA5FCC60", VA = "0x18A5FE260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE110", Offset = "0xA5FCB10", VA = "0x18A5FE110")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE210", Offset = "0xA5FCC10", VA = "0x18A5FE210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Matrix4x4 ModelMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE140", Offset = "0xA5FCB40", VA = "0x18A5FE140")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA5FDF60", Offset = "0xA5FC960", VA = "0x18A5FDF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x10C60A0", Offset = "0x10C4AA0", VA = "0x1810C60A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x10C7440", Offset = "0x10C5E40", VA = "0x1810C7440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private bool TransformChainIsDirty
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE1B0", Offset = "0xA5FCBB0", VA = "0x18A5FE1B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xCDD200", Offset = "0xCDBC00", VA = "0x180CDD200")]
		internal NodeInstance(NodeTemplate template, NodeInstance parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDCF0", Offset = "0xA5FC6F0", VA = "0x18A5FDCF0")]
		private Matrix4x4 _GetModelMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDF60", Offset = "0xA5FC960", VA = "0x18A5FDF60")]
		private void _SetModelMatrix(Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDC00", Offset = "0xA5FC600", VA = "0x18A5FDC00")]
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
			[Cpp2IlInjected.Address(RVA = "0xCDA170", Offset = "0xCD8B70", VA = "0x180CDA170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xCD9A30", Offset = "0xCD8430", VA = "0x180CD9A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B50", Offset = "0xCD8550", VA = "0x180CD9B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B40", Offset = "0xCD8540", VA = "0x180CD9B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int ParentIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IReadOnlyList<int> ChildIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA5FF5E0", Offset = "0xA5FDFE0", VA = "0x18A5FF5E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5FEDD0", Offset = "0xA5FD7D0", VA = "0x18A5FEDD0")]
		internal NodeTemplate(Node srcNode, int parentIdx, int[] childIndices, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA5FEAD0", Offset = "0xA5FD4D0", VA = "0x18A5FEAD0")]
		public SparseWeight8 GetMorphWeights(int trackLogicalIndex, float time)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE800", Offset = "0xA5FD200", VA = "0x18A5FE800")]
		public SparseWeight8 GetMorphWeights(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE510", Offset = "0xA5FCF10", VA = "0x18A5FE510")]
		public AffineTransform GetLocalTransform(int trackLogicalIndex, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE5A0", Offset = "0xA5FCFA0", VA = "0x18A5FE5A0")]
		public AffineTransform GetLocalTransform(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE290", Offset = "0xA5FCC90", VA = "0x18A5FE290")]
		public Matrix4x4 GetLocalMatrix(int trackLogicalIndex, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE3B0", Offset = "0xA5FCDB0", VA = "0x18A5FE3B0")]
		public Matrix4x4 GetLocalMatrix(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5FED30", Offset = "0xA5FD730", VA = "0x18A5FED30")]
		public bool? GetVisibility(int trackLogicalIndex, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5FEBB0", Offset = "0xA5FD5B0", VA = "0x18A5FEBB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6093F0", Offset = "0xA607DF0", VA = "0x18A6093F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA6090B0", Offset = "0xA607AB0", VA = "0x18A6090B0")]
		public _NodeTemplateTransforms(Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA608F60", Offset = "0xA607960", VA = "0x18A608F60")]
		public void SetCurves(NodeCurveSamplers curves, int index, bool isolateMemory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA608D60", Offset = "0xA607760", VA = "0x18A608D60")]
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
			[Cpp2IlInjected.Address(RVA = "0xD2C460", Offset = "0xD2AE60", VA = "0x180D2C460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xDE7AB0", Offset = "0xDE64B0", VA = "0x180DE7AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MeshInstancing GpuMeshInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410")]
			[CompilerGenerated]
			get
			{
				return default(MeshInstancing);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xDF2300", Offset = "0xDF0D00", VA = "0x180DF2300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Converter<ExtraProperties, object> ExtrasConverterCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF8E0", Offset = "0xA5FE2E0", VA = "0x18A5FF8E0")]
		internal static object ConvertExtras(ExtraProperties source, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x15FCDF0", Offset = "0x15FB7F0", VA = "0x1815FCDF0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD6AE80", Offset = "0xD69880", VA = "0x180D6AE80", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA600E00", Offset = "0xA5FF800", VA = "0x18A600E00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public <GetEnumerator>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x6703E10", Offset = "0x6702810", VA = "0x186703E10", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA600C00", Offset = "0xA5FF600", VA = "0x18A600C00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA600DC0", Offset = "0xA5FF7C0", VA = "0x18A600DC0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF9C0", Offset = "0xA5FE3C0", VA = "0x18A5FF9C0")]
		internal SceneInstance(ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF950", Offset = "0xA5FE350", VA = "0x18A5FF950", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF950", Offset = "0xA5FE350", VA = "0x18A5FF950", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public (Vector3 center, float radius) SphereBounds
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xF43900", Offset = "0xF42300", VA = "0x180F43900")]
			[CompilerGenerated]
			get
			{
				return default((Vector3, float));
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xF43730", Offset = "0xF42130", VA = "0x180F43730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public IEnumerable<int> LogicalMeshIds
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA600610", Offset = "0xA5FF010", VA = "0x18A600610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFCF0", Offset = "0xA5FE6F0", VA = "0x18A5FFCF0")]
		public static SceneTemplate Create(Scene srcScene, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC420", Offset = "0x10FAE20", VA = "0x1810FC420")]
		private SceneTemplate(string name, object extras, ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFC40", Offset = "0xA5FE640", VA = "0x18A5FFC40")]
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
		[Cpp2IlInjected.Address(RVA = "0x40D2930", Offset = "0x40D1330", VA = "0x1840D2930")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA602870", Offset = "0xA601270", VA = "0x18A602870")]
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
		[Cpp2IlInjected.Address(RVA = "0x40E5260", Offset = "0x40E3C60", VA = "0x1840E5260")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA602A30", Offset = "0xA601430", VA = "0x18A602A30")]
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

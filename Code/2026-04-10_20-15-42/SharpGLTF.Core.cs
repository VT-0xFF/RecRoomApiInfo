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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6D2DC0", Offset = "0xA6D1DC0", VA = "0x18A6D2DC0")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1D90", Offset = "0xA6D0D90", VA = "0x18A6D1D90")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2000", Offset = "0xA6D1000", VA = "0x18A6D2000")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2250", Offset = "0xA6D1250", VA = "0x18A6D2250")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1CF0", Offset = "0xA6D0CF0", VA = "0x18A6D1CF0")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2A40", Offset = "0xA6D1A40", VA = "0x18A6D2A40")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2920", Offset = "0xA6D1920", VA = "0x18A6D2920")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2F10", Offset = "0xA6D1F10", VA = "0x18A6D2F10")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2EB0", Offset = "0xA6D1EB0", VA = "0x18A6D2EB0")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2760", Offset = "0xA6D1760", VA = "0x18A6D2760")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B028B0", Offset = "0x3B018B0", VA = "0x183B028B0")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3B01300", Offset = "0x3B00300", VA = "0x183B01300")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA6D27C0", Offset = "0xA6D17C0", VA = "0x18A6D27C0")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3B02340", Offset = "0x3B01340", VA = "0x183B02340")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B02250", Offset = "0x3B01250", VA = "0x183B02250")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B01AB0", Offset = "0x3B00AB0", VA = "0x183B01AB0")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B018B0", Offset = "0x3B008B0", VA = "0x183B018B0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B00550", Offset = "0x3AFF550", VA = "0x183B00550")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2350", Offset = "0xA6D1350", VA = "0x18A6D2350")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA6D22F0", Offset = "0xA6D12F0", VA = "0x18A6D22F0")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA6D23B0", Offset = "0xA6D13B0", VA = "0x18A6D23B0")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2B60", Offset = "0xA6D1B60", VA = "0x18A6D2B60")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2CC0", Offset = "0xA6D1CC0", VA = "0x18A6D2CC0")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFC00", Offset = "0x3AFEC00", VA = "0x183AFFC00")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1A60", Offset = "0xA6D0A60", VA = "0x18A6D1A60")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF240", Offset = "0x3AFE240", VA = "0x183AFF240")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEE90", Offset = "0x3AFDE90", VA = "0x183AFEE90")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEE90", Offset = "0x3AFDE90", VA = "0x183AFEE90")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEE90", Offset = "0x3AFDE90", VA = "0x183AFEE90")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AFEE90", Offset = "0x3AFDE90", VA = "0x183AFEE90")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE310", Offset = "0x3AFD310", VA = "0x183AFE310")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x675E200", Offset = "0x675D200", VA = "0x18675E200", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x6759060", Offset = "0x6758060", VA = "0x186759060", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x675E660", Offset = "0x675D660", VA = "0x18675E660")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6F54900", Offset = "0x6F53900", VA = "0x186F54900", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6F50310", Offset = "0x6F4F310", VA = "0x186F50310", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x6F54DD0", Offset = "0x6F53DD0", VA = "0x186F54DD0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x51AEFF0", Offset = "0x51ADFF0", VA = "0x1851AEFF0", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x51AEDB0", Offset = "0x51ADDB0", VA = "0x1851AEDB0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x51AEA40", Offset = "0x51ADA40", VA = "0x1851AEA40", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x51AED00", Offset = "0x51ADD00", VA = "0x1851AED00", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x6758540", Offset = "0x6757540", VA = "0x186758540", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x67585F0", Offset = "0x67575F0", VA = "0x1867585F0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x5169B30", Offset = "0x5168B30", VA = "0x185169B30")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x6758780", Offset = "0x6757780", VA = "0x186758780", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x6756B10", Offset = "0x6755B10", VA = "0x186756B10", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6758E70", Offset = "0x6757E70", VA = "0x186758E70")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6F4B4B0", Offset = "0x6F4A4B0", VA = "0x186F4B4B0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6F4A8A0", Offset = "0x6F498A0", VA = "0x186F4A8A0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6F4BA30", Offset = "0x6F4AA30", VA = "0x186F4BA30")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x51A5B50", Offset = "0x51A4B50", VA = "0x1851A5B50", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x51A5890", Offset = "0x51A4890", VA = "0x1851A5890", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x51A5A70", Offset = "0x51A4A70", VA = "0x1851A5A70", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x1414B90", Offset = "0x1413B90", VA = "0x181414B90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6E1110", Offset = "0xA6E0110", VA = "0x18A6E1110", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x65AFE60", Offset = "0x65AEE60", VA = "0x1865AFE60")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1160", Offset = "0xA6E0160", VA = "0x18A6E1160", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0DC0", Offset = "0xA6DFDC0", VA = "0x18A6E0DC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1220", Offset = "0xA6E0220", VA = "0x18A6E1220")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA6E10D0", Offset = "0xA6E00D0", VA = "0x18A6E10D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1020", Offset = "0xA6E0020", VA = "0x18A6E1020", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1020", Offset = "0xA6E0020", VA = "0x18A6E1020", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A191E0", Offset = "0x1A181E0", VA = "0x181A191E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6E1C00", Offset = "0xA6E0C00", VA = "0x18A6E1C00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1C50", Offset = "0xA6E0C50", VA = "0x18A6E1C50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1270", Offset = "0xA6E0270", VA = "0x18A6E1270", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1E40", Offset = "0xA6E0E40", VA = "0x18A6E1E40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1E90", Offset = "0xA6E0E90", VA = "0x18A6E1E90")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1EE0", Offset = "0xA6E0EE0", VA = "0x18A6E1EE0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1BC0", Offset = "0xA6E0BC0", VA = "0x18A6E1BC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1B10", Offset = "0xA6E0B10", VA = "0x18A6E1B10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1B10", Offset = "0xA6E0B10", VA = "0x18A6E1B10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6E5DA0", Offset = "0xA6E4DA0", VA = "0x18A6E5DA0")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7770", Offset = "0xA6E6770", VA = "0x18A6E7770")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E78A0", Offset = "0xA6E68A0", VA = "0x18A6E78A0")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E77B0", Offset = "0xA6E67B0", VA = "0x18A6E77B0")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E78D0", Offset = "0xA6E68D0", VA = "0x18A6E78D0")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7810", Offset = "0xA6E6810", VA = "0x18A6E7810")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7940", Offset = "0xA6E6940", VA = "0x18A6E7940")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7810", Offset = "0xA6E6810", VA = "0x18A6E7810")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA6E76A0", Offset = "0xA6E66A0", VA = "0x18A6E76A0")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5ED0", Offset = "0xA6E4ED0", VA = "0x18A6E5ED0")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5DB0", Offset = "0xA6E4DB0", VA = "0x18A6E5DB0")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5140", Offset = "0xA6E4140", VA = "0x18A6E5140")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6840", Offset = "0xA6E5840", VA = "0x18A6E6840")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5D50", Offset = "0xA6E4D50", VA = "0x18A6E5D50")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5CF0", Offset = "0xA6E4CF0", VA = "0x18A6E5CF0")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5FD0", Offset = "0xA6E4FD0", VA = "0x18A6E5FD0")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7320", Offset = "0xA6E6320", VA = "0x18A6E7320")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E74A0", Offset = "0xA6E64A0", VA = "0x18A6E74A0")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E61B0", Offset = "0xA6E51B0", VA = "0x18A6E61B0")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E60C0", Offset = "0xA6E50C0", VA = "0x18A6E60C0")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6480", Offset = "0xA6E5480", VA = "0x18A6E6480")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5B60", Offset = "0xA6E4B60", VA = "0x18A6E5B60")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6E80", Offset = "0xA6D5E80", VA = "0x18A6D6E80")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA6E68A0", Offset = "0xA6E58A0", VA = "0x18A6E68A0")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6140", Offset = "0xA6E5140", VA = "0x18A6E6140")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5AC0", Offset = "0xA6E4AC0", VA = "0x18A6E5AC0")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5A00", Offset = "0xA6E4A00", VA = "0x18A6E5A00")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x415CE30", Offset = "0x415BE30", VA = "0x18415CE30")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA6E52B0", Offset = "0xA6E42B0", VA = "0x18A6E52B0")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5420", Offset = "0xA6E4420", VA = "0x18A6E5420")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x415E1D0", Offset = "0x415D1D0", VA = "0x18415E1D0")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x415F2F0", Offset = "0x415E2F0", VA = "0x18415F2F0")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x415F420", Offset = "0x415E420", VA = "0x18415F420")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x415F370", Offset = "0x415E370", VA = "0x18415F370")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x415CE50", Offset = "0x415BE50", VA = "0x18415CE50")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x415E010", Offset = "0x415D010", VA = "0x18415E010")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x415DF00", Offset = "0x415CF00", VA = "0x18415DF00")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x415DCD0", Offset = "0x415CCD0", VA = "0x18415DCD0")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x415F210", Offset = "0x415E210", VA = "0x18415F210")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x415EB80", Offset = "0x415DB80", VA = "0x18415EB80")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x415F120", Offset = "0x415E120", VA = "0x18415F120")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x415ED20", Offset = "0x415DD20", VA = "0x18415ED20")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x415D4F0", Offset = "0x415C4F0", VA = "0x18415D4F0")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x415D2A0", Offset = "0x415C2A0", VA = "0x18415D2A0")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x415CAB0", Offset = "0x415BAB0", VA = "0x18415CAB0")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x415CEE0", Offset = "0x415BEE0", VA = "0x18415CEE0")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6280", Offset = "0xA6E5280", VA = "0x18A6E6280")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E65E0", Offset = "0xA6E55E0", VA = "0x18A6E65E0")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x415F270", Offset = "0x415E270", VA = "0x18415F270")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x415F270", Offset = "0x415E270", VA = "0x18415F270")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6A30", Offset = "0xA6E5A30", VA = "0x18A6E6A30")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5180", Offset = "0xA6E4180", VA = "0x18A6E5180")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5200", Offset = "0xA6E4200", VA = "0x18A6E5200")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA6E69B0", Offset = "0xA6E59B0", VA = "0x18A6E69B0")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA6E70F0", Offset = "0xA6E60F0", VA = "0x18A6E70F0")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5360", Offset = "0xA6E4360", VA = "0x18A6E5360")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7020", Offset = "0xA6E6020", VA = "0x18A6E7020")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6C30", Offset = "0xA6E5C30", VA = "0x18A6E6C30")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5750", Offset = "0xA6E4750", VA = "0x18A6E5750")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5520", Offset = "0xA6E4520", VA = "0x18A6E5520")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA6E57F0", Offset = "0xA6E47F0", VA = "0x18A6E57F0")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA6E54A0", Offset = "0xA6E44A0", VA = "0x18A6E54A0")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5980", Offset = "0xA6E4980", VA = "0x18A6E5980")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x239D950", Offset = "0x239C950", VA = "0x18239D950")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7790", Offset = "0xA6E6790", VA = "0x18A6E7790")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x415F670", Offset = "0x415E670", VA = "0x18415F670")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E68F0", Offset = "0xA6E58F0", VA = "0x18A6E68F0")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E56B0", Offset = "0xA6E46B0", VA = "0x18A6E56B0")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7270", Offset = "0xA6E6270", VA = "0x18A6E7270")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7BE0", Offset = "0xA6E6BE0", VA = "0x18A6E7BE0")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7170", Offset = "0xA6E6170", VA = "0x18A6E7170")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5350", Offset = "0xA6E4350", VA = "0x18A6E5350")]
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
			[Cpp2IlInjected.Address(RVA = "0xD12F00", Offset = "0xD11F00", VA = "0x180D12F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD12790", Offset = "0xD11790", VA = "0x180D12790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string Message
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA6D88C0", Offset = "0xA6D78C0", VA = "0x18A6D88C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private string _Generator
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8910", Offset = "0xA6D7910", VA = "0x18A6D8910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8830", Offset = "0xA6D7830", VA = "0x18A6D8830")]
		internal ModelException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8780", Offset = "0xA6D7780", VA = "0x18A6D8780")]
		internal ModelException(JsonSerializable target, Exception ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D83E0", Offset = "0xA6D73E0", VA = "0x18A6D83E0")]
		private static string _CreateBaseMessage(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8580", Offset = "0xA6D7580", VA = "0x18A6D8580")]
		internal static void _Decorate(Exception ex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SchemaException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1A50", Offset = "0xA6D0A50", VA = "0x18A6D1A50")]
		internal SchemaException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8780", Offset = "0xA6D7780", VA = "0x18A6D8780")]
		internal SchemaException(JsonSerializable target, JsonException rex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class SemanticException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1A50", Offset = "0xA6D0A50", VA = "0x18A6D1A50")]
		internal SemanticException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class LinkException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1A50", Offset = "0xA6D0A50", VA = "0x18A6D1A50")]
		internal LinkException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DataException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1A50", Offset = "0xA6D0A50", VA = "0x18A6D1A50")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool TryFix
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA6E4640", Offset = "0xA6E3640", VA = "0x18A6E4640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4560", Offset = "0xA6E3560", VA = "0x18A6E4560")]
		public ValidationContext(ValidationResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4510", Offset = "0xA6E3510", VA = "0x18A6E4510")]
		internal ValidationContext(ValidationContext context, JsonSerializable target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3330", Offset = "0xA6E2330", VA = "0x18A6E3330")]
		public ValidationContext GetContext(JsonSerializable target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4470", Offset = "0xA6E3470", VA = "0x18A6E4470")]
		[DebuggerStepThrough]
		internal void _SchemaThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3DA0", Offset = "0xA6E2DA0", VA = "0x18A6E3DA0")]
		public ValidationContext IsTrue(ValueLocation parameterName, bool value, string msg)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E40E0", Offset = "0xA6E30E0", VA = "0x18A6E40E0")]
		public ValidationContext NotNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3FC0", Offset = "0xA6E2FC0", VA = "0x18A6E3FC0")]
		public ValidationContext MustBeNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x40EB160", Offset = "0x40EA160", VA = "0x1840EB160")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x40EB0C0", Offset = "0x40EA0C0", VA = "0x1840EB0C0")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x40ED200", Offset = "0x40EC200", VA = "0x1840ED200")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x40ED0B0", Offset = "0x40EC0B0", VA = "0x1840ED0B0")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x40E0F90", Offset = "0x40DFF90", VA = "0x1840E0F90")]
		public ValidationContext AreSameReference<TRef>(ValueLocation parameterName, TRef value, TRef expected) where TRef : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x40E0E90", Offset = "0x40DFE90", VA = "0x1840E0E90")]
		public ValidationContext AreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : IEquatable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x40EC5E0", Offset = "0x40EB5E0", VA = "0x1840EC5E0")]
		public ValidationContext IsLess<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x40EC270", Offset = "0x40EB270", VA = "0x1840EC270")]
		public ValidationContext IsLessOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x40EB920", Offset = "0x40EA920", VA = "0x1840EB920")]
		public ValidationContext IsGreater<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x40E1840", Offset = "0x40E0840", VA = "0x1840E1840")]
		public ValidationContext IsDefaultOrWithin<TValue>(ValueLocation parameterName, TValue? value, TValue minInclusive, TValue maxInclusive) where TValue : struct, IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x40EB460", Offset = "0x40EA460", VA = "0x1840EB460")]
		public ValidationContext IsGreaterOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3790", Offset = "0xA6E2790", VA = "0x18A6E3790")]
		public ValidationContext IsMultipleOf(ValueLocation parameterName, int value, int multiple)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4050", Offset = "0xA6E3050", VA = "0x18A6E4050")]
		public ValidationContext NonNegative(ValueLocation parameterName, int? value)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3B90", Offset = "0xA6E2B90", VA = "0x18A6E3B90")]
		public ValidationContext IsNullOrValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3DF0", Offset = "0xA6E2DF0", VA = "0x18A6E3DF0")]
		public ValidationContext IsValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E43D0", Offset = "0xA6E33D0", VA = "0x18A6E43D0")]
		[DebuggerStepThrough]
		internal void _LinkThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x40E1220", Offset = "0x40E0220", VA = "0x1840E1220")]
		public ValidationContext EnumsAreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : Enum
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x40ECB70", Offset = "0x40EBB70", VA = "0x1840ECB70")]
		public ValidationContext IsNullOrIndex<T>(ValueLocation parameterName, int? index, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x40EC700", Offset = "0x40EB700", VA = "0x1840EC700")]
		public ValidationContext IsNullOrInRange<T>(ValueLocation parameterName, int? offset, int length, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x40E1640", Offset = "0x40E0640", VA = "0x1840E1640")]
		public ValidationContext IsAnyOf<T>(ValueLocation parameterName, T value, params T[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3390", Offset = "0xA6E2390", VA = "0x18A6E3390")]
		public ValidationContext IsAnyOf(ValueLocation parameterName, AttributeFormat value, params AttributeFormat[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x40ECC20", Offset = "0x40EBC20", VA = "0x1840ECC20")]
		public ValidationContext IsSetCollection<T>(ValueLocation parameterName, IEnumerable<T> collection) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4330", Offset = "0xA6E3330", VA = "0x18A6E4330")]
		[DebuggerStepThrough]
		private void _DataThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x40EBE70", Offset = "0x40EAE70", VA = "0x1840EBE70")]
		public ValidationContext IsInRange<T>(ValueLocation pname, T value, T minInclusive, T maxInclusive) where T : IComparable<T>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3A50", Offset = "0xA6E2A50", VA = "0x18A6E3A50")]
		public ValidationContext IsNullOrMatrix(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3910", Offset = "0xA6E2910", VA = "0x18A6E3910")]
		public ValidationContext IsNullOrMatrix4x3(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3C00", Offset = "0xA6E2C00", VA = "0x18A6E3C00")]
		public ValidationContext IsPosition(ValueLocation pname, [In] Vector3 position)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3860", Offset = "0xA6E2860", VA = "0x18A6E3860")]
		public ValidationContext IsNormal(ValueLocation pname, [In] Vector3 normal)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3D00", Offset = "0xA6E2D00", VA = "0x18A6E3D00")]
		public ValidationContext IsRotation(ValueLocation pname, [In] Quaternion rotation)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA6E36E0", Offset = "0xA6E26E0", VA = "0x18A6E36E0")]
		public ValidationContext IsMatrix(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3630", Offset = "0xA6E2630", VA = "0x18A6E3630")]
		public ValidationContext IsMatrix4x3(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2A30", Offset = "0xA6E1A30", VA = "0x18A6E2A30")]
		public ValidationContext ArePositions(ValueLocation pname, IReadOnlyList<Vector3> positions)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E26C0", Offset = "0xA6E16C0", VA = "0x18A6E26C0")]
		public ValidationContext AreNormals(ValueLocation pname, IReadOnlyList<Vector3> normals)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3050", Offset = "0xA6E2050", VA = "0x18A6E3050")]
		public ValidationContext AreTangents(ValueLocation pname, IReadOnlyList<Vector4> tangents)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2E00", Offset = "0xA6E1E00", VA = "0x18A6E2E00")]
		public ValidationContext AreRotations(ValueLocation pname, IReadOnlyList<Quaternion> rotations)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA6E21B0", Offset = "0xA6E11B0", VA = "0x18A6E21B0")]
		public ValidationContext AreJoints(ValueLocation pname, IReadOnlyList<Vector4> joints, int skinsMaxJointCount)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4170", Offset = "0xA6E3170", VA = "0x18A6E4170")]
		public ValidationContext That(Action action)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA6E42D0", Offset = "0xA6E32D0", VA = "0x18A6E42D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6E50A0", Offset = "0xA6E40A0", VA = "0x18A6E50A0")]
		public static implicit operator ValueLocation(int index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5040", Offset = "0xA6E4040", VA = "0x18A6E5040")]
		public static implicit operator ValueLocation(int? index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E150", Offset = "0x2B8D150", VA = "0x182B8E150")]
		public static implicit operator ValueLocation(string name)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E50F0", Offset = "0xA6E40F0", VA = "0x18A6E50F0")]
		public static implicit operator ValueLocation((string name, int index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4FE0", Offset = "0xA6E3FE0", VA = "0x18A6E4FE0")]
		public static implicit operator ValueLocation((string name, int? index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5130", Offset = "0xA6E4130", VA = "0x18A6E5130")]
		public static implicit operator string(ValueLocation location)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xDC3070", Offset = "0xDC2070", VA = "0x180DC3070")]
		private ValueLocation(string name, int idx1 = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4F60", Offset = "0xA6E3F60", VA = "0x18A6E4F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4EF0", Offset = "0xA6E3EF0", VA = "0x18A6E4EF0")]
		public string ToString(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4DC0", Offset = "0xA6E3DC0", VA = "0x18A6E4DC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ValidationMode Mode
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0")]
			get
			{
				return default(ValidationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IEnumerable<Exception> Errors
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool HasErrors
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xA6E4D70", Offset = "0xA6E3D70", VA = "0x18A6E4D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4CB0", Offset = "0xA6E3CB0", VA = "0x18A6E4CB0")]
		public ValidationResult(ModelRoot root, ValidationMode mode, bool instantThrow = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4650", Offset = "0xA6E3650", VA = "0x18A6E4650")]
		public ValidationContext GetContext()
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4BB0", Offset = "0xA6E3BB0", VA = "0x18A6E4BB0")]
		public void SetSchemaError(EndOfStreamException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4B30", Offset = "0xA6E3B30", VA = "0x18A6E4B30")]
		public void SetSchemaError(ModelRoot model, string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4A30", Offset = "0xA6E3A30", VA = "0x18A6E4A30")]
		public void SetSchemaError(ModelRoot model, JsonException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4910", Offset = "0xA6E3910", VA = "0x18A6E4910")]
		public void SetModelError(FormatException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4810", Offset = "0xA6E3810", VA = "0x18A6E4810")]
		public void SetModelError(ModelRoot model, ArgumentException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4740", Offset = "0xA6E3740", VA = "0x18A6E4740")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D12C0", Offset = "0xA6D02C0", VA = "0x18A6D12C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D12A0", Offset = "0xA6D02A0", VA = "0x18A6D12A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IsSRT
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D12B0", Offset = "0xA6D02B0", VA = "0x18A6D12B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1600", Offset = "0xA6D0600", VA = "0x18A6D1600")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Quaternion Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1590", Offset = "0xA6D0590", VA = "0x18A6D1590")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xEE6810", Offset = "0xEE5810", VA = "0x180EE6810")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1510", Offset = "0xA6D0510", VA = "0x18A6D1510")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IsLosslessDecomposable
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1190", Offset = "0xA6D0190", VA = "0x18A6D1190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IsIdentity
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA6D0EF0", Offset = "0xA6CFEF0", VA = "0x18A6D0EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD930", Offset = "0xA6CC930", VA = "0x18A6CD930")]
		internal string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1720", Offset = "0xA6D0720", VA = "0x18A6D1720")]
		public static implicit operator AffineTransform((Quaternion r, Vector3 t) xform)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D18B0", Offset = "0xA6D08B0", VA = "0x18A6D18B0")]
		public static implicit operator AffineTransform(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1870", Offset = "0xA6D0870", VA = "0x18A6D1870")]
		public static implicit operator AffineTransform(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC9C0", Offset = "0xA6CB9C0", VA = "0x18A6CC9C0")]
		public static AffineTransform CreateDecomposed(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA6CCB30", Offset = "0xA6CBB30", VA = "0x18A6CCB30")]
		public static AffineTransform CreateFromAny(Matrix4x4? matrix, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA6CF8A0", Offset = "0xA6CE8A0", VA = "0x18A6CF8A0")]
		public AffineTransform WithScale(Vector3 scale)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA6CF520", Offset = "0xA6CE520", VA = "0x18A6CF520")]
		public AffineTransform WithRotation(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA6CFC50", Offset = "0xA6CEC50", VA = "0x18A6CFC50")]
		public AffineTransform WithTranslation(Vector3 translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0700", Offset = "0xA6CF700", VA = "0x18A6D0700")]
		public AffineTransform(Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0A40", Offset = "0xA6CFA40", VA = "0x18A6D0A40")]
		public AffineTransform(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0630", Offset = "0xA6CF630", VA = "0x18A6D0630")]
		public AffineTransform(Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0B20", Offset = "0xA6CFB20", VA = "0x18A6D0B20")]
		public AffineTransform(Vector3 scale, Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0890", Offset = "0xA6CF890", VA = "0x18A6D0890")]
		public AffineTransform(Matrix4x4 matrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD180", Offset = "0xA6CC180", VA = "0x18A6CD180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA6CCE20", Offset = "0xA6CBE20", VA = "0x18A6CCE20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA6CCF30", Offset = "0xA6CBF30", VA = "0x18A6CCF30", Slot = "4")]
		public bool Equals(AffineTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1670", Offset = "0xA6D0670", VA = "0x18A6D1670")]
		public static bool operator ==([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1910", Offset = "0xA6D0910", VA = "0x18A6D1910")]
		public static bool operator !=([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC1A0", Offset = "0xA6CB1A0", VA = "0x18A6CC1A0")]
		public static bool AreGeometricallyEquivalent([In] AffineTransform a, [In] AffineTransform b, float tolerance = 1E-05f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD0C0", Offset = "0xA6CC0C0", VA = "0x18A6CD0C0")]
		public AffineTransform GetDecomposed()
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA6CE8A0", Offset = "0xA6CD8A0", VA = "0x18A6CE8A0")]
		public bool TryDecompose([Out] AffineTransform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA6CE660", Offset = "0xA6CD660", VA = "0x18A6CE660")]
		public bool TryDecompose([Out] Vector3 scale, [Out] Quaternion rotation, [Out] Vector3 translation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC430", Offset = "0xA6CB430", VA = "0x18A6CC430")]
		public static AffineTransform Blend(ReadOnlySpan<AffineTransform> transforms, ReadOnlySpan<float> weights)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA6D19C0", Offset = "0xA6D09C0", VA = "0x18A6D19C0")]
		public static AffineTransform operator *([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD1B0", Offset = "0xA6CC1B0", VA = "0x18A6CD1B0")]
		public static AffineTransform Multiply([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA6CEBF0", Offset = "0xA6CDBF0", VA = "0x18A6CEBF0")]
		public static bool TryInvert([In] AffineTransform xform, [Out] AffineTransform inverse)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA6CE240", Offset = "0xA6CD240", VA = "0x18A6CE240")]
		private static Vector3 Transform(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA6CDE60", Offset = "0xA6CCE60", VA = "0x18A6CDE60")]
		public static Vector3 TransformNormal(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0510", Offset = "0xA6CF510", VA = "0x18A6D0510")]
		private void _VerifyDefined()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA6CFFC0", Offset = "0xA6CEFC0", VA = "0x18A6CFFC0")]
		private Matrix4x4 _GetMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0440", Offset = "0xA6CF440", VA = "0x18A6D0440")]
		private Vector3 _GetScale()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0370", Offset = "0xA6CF370", VA = "0x18A6D0370")]
		private Quaternion _GetRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA6CBCB0", Offset = "0xA6CACB0", VA = "0x18A6CBCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6D4570", Offset = "0xA6D3570", VA = "0x18A6D4570")]
		public static implicit operator IndexWeight((int Index, float Weight) pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4520", Offset = "0xA6D3520", VA = "0x18A6D4520")]
		public static implicit operator IndexWeight(KeyValuePair<int, float> pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4450", Offset = "0xA6D3450", VA = "0x18A6D4450")]
		public IndexWeight((int Index, float Weight) pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA6D43E0", Offset = "0xA6D33E0", VA = "0x18A6D43E0")]
		public IndexWeight(KeyValuePair<int, float> pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6940870", Offset = "0x693F870", VA = "0x186940870")]
		public IndexWeight(int i, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3830", Offset = "0xA6D2830", VA = "0x18A6D3830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3770", Offset = "0xA6D2770", VA = "0x18A6D3770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3810", Offset = "0xA6D2810", VA = "0x18A6D3810", Slot = "4")]
		public bool Equals(IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4200", Offset = "0xA6D3200", VA = "0x18A6D4200")]
		public bool IsGreaterThan([In] IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4490", Offset = "0xA6D3490", VA = "0x18A6D4490")]
		public static IndexWeight operator +(IndexWeight a, IndexWeight b)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4470", Offset = "0xA6D3470", VA = "0x18A6D4470")]
		public static IndexWeight operator +(IndexWeight a, float w)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D42A0", Offset = "0xA6D32A0", VA = "0x18A6D42A0")]
		public static bool IsWellFormed(ReadOnlySpan<IndexWeight> iw, [Out] string err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3880", Offset = "0xA6D2880", VA = "0x18A6D3880")]
		public static int InsertSorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3D50", Offset = "0xA6D2D50", VA = "0x18A6D3D50")]
		public static int InsertUnsorted(Span<IndexWeight> sparse, [In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3B50", Offset = "0xA6D2B50", VA = "0x18A6D3B50")]
		public static int InsertUnsorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3330", Offset = "0xA6D2330", VA = "0x18A6D3330")]
		public static int CopyTo([In] SparseWeight8 src, Span<int> dstIndices, Span<float> dstWeights, int dstLength)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3190", Offset = "0xA6D2190", VA = "0x18A6D3190")]
		public static void BubbleSortByWeight(Span<IndexWeight> pairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA6D30B0", Offset = "0xA6D20B0", VA = "0x18A6D30B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D6010", Offset = "0xA6D5010", VA = "0x18A6D6010")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public (double x, double y, double z) Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA6D60B0", Offset = "0xA6D50B0", VA = "0x18A6D60B0")]
			get
			{
				return default((double, double, double));
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA6D6A60", Offset = "0xA6D5A60", VA = "0x18A6D6A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA6D5F60", Offset = "0xA6D4F60", VA = "0x18A6D5F60")]
		public Matrix4x4Double(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA6D5EA0", Offset = "0xA6D4EA0", VA = "0x18A6D5EA0")]
		public Matrix4x4Double(Matrix4x4 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4E70", Offset = "0xA6D3E70", VA = "0x18A6D4E70")]
		public static Matrix4x4Double CreateTranslation(double xPosition, double yPosition, double zPosition)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4E10", Offset = "0xA6D3E10", VA = "0x18A6D4E10")]
		public static Matrix4x4Double CreateScale(double xScale, double yScale, double zScale)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4C80", Offset = "0xA6D3C80", VA = "0x18A6D4C80")]
		public static Matrix4x4Double CreateFromQuaternion(Quaternion quaternion)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6270", Offset = "0xA6D5270", VA = "0x18A6D6270")]
		public static explicit operator Matrix4x4(Matrix4x4Double mat)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6420", Offset = "0xA6D5420", VA = "0x18A6D6420")]
		public static implicit operator Matrix4x4Double(Matrix4x4 mat)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D53A0", Offset = "0xA6D43A0", VA = "0x18A6D53A0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6120", Offset = "0xA6D5120", VA = "0x18A6D6120")]
		public static bool operator ==(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6500", Offset = "0xA6D5500", VA = "0x18A6D6500")]
		public static bool operator !=(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA6D5210", Offset = "0xA6D4210", VA = "0x18A6D5210", Slot = "4")]
		public readonly bool Equals(Matrix4x4Double other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4ED0", Offset = "0xA6D3ED0", VA = "0x18A6D4ED0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA6D5600", Offset = "0xA6D4600", VA = "0x18A6D5600")]
		public static bool Invert(Matrix4x4Double matrix, [Out] Matrix4x4Double result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA6D5CC0", Offset = "0xA6D4CC0", VA = "0x18A6D5CC0")]
		public static Matrix4x4Double Multiply(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6650", Offset = "0xA6D5650", VA = "0x18A6D6650")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6D7FD0", Offset = "0xA6D6FD0", VA = "0x18A6D7FD0")]
		private static MatrixCheck _Validate([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(MatrixCheck);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6E80", Offset = "0xA6D5E80", VA = "0x18A6D6E80")]
		public static bool IsValid([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6DC0", Offset = "0xA6D5DC0", VA = "0x18A6D6DC0")]
		[DebuggerStepThrough]
		public static void GuardMatrix(string argName, Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6B60", Offset = "0xA6D5B60", VA = "0x18A6D6B60")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6A80", Offset = "0xA6D5A80", VA = "0x18A6D6A80")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ, Vector3 translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6C20", Offset = "0xA6D5C20", VA = "0x18A6D6C20")]
		public static Matrix4x4 CreateFrom(Matrix4x4? transform, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D6EA0", Offset = "0xA6D5EA0", VA = "0x18A6D6EA0")]
		public static Matrix4x4 LocalToWorld([In] Matrix4x4 parentWorld, [In] Matrix4x4 childLocal)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA6D7C90", Offset = "0xA6D6C90", VA = "0x18A6D7C90")]
		public static Matrix4x4 WorldToLocal([In] Matrix4x4 parentWorld, [In] Matrix4x4 childWorld)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA6D71D0", Offset = "0xA6D61D0", VA = "0x18A6D71D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x51BA9E0", Offset = "0x51B99E0", VA = "0x1851BA9E0")]
			get
			{
				return default(SparseWeight8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool AbsoluteMorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xDAF8B0", Offset = "0xDAE8B0", VA = "0x180DAF8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9A10", Offset = "0xA6D8A10", VA = "0x18A6D9A10")]
		protected MorphTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9A50", Offset = "0xA6D8A50", VA = "0x18A6D9A50")]
		protected MorphTransform(SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9900", Offset = "0xA6D8900", VA = "0x18A6D9900")]
		public void Update([In] SparseWeight8 morphWeights, bool useAbsoluteMorphTargets = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8FC0", Offset = "0xA6D7FC0", VA = "0x18A6D8FC0")]
		protected Vector2 MorphVectors(Vector2 value, IReadOnlyList<Vector2> morphTargets)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8A30", Offset = "0xA6D7A30", VA = "0x18A6D8A30")]
		protected Vector3 MorphVectors(Vector3 value, IReadOnlyList<Vector3> morphTargets)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9390", Offset = "0xA6D8390", VA = "0x18A6D9390")]
		protected Vector4 MorphVectors(Vector4 value, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA6D89E0", Offset = "0xA6D79E0", VA = "0x18A6D89E0", Slot = "5")]
		public Vector4 MorphColors(Vector4 color, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8A20", Offset = "0xA6D7A20", VA = "0x18A6D8A20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD39E60", Offset = "0xD38E60", VA = "0x180D39E60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x20CD710", Offset = "0x20CC710", VA = "0x1820CD710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA6DAC10", Offset = "0xA6D9C10", VA = "0x18A6DAC10")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA6DAB20", Offset = "0xA6D9B20", VA = "0x18A6DAB20")]
		public RigidTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA6DAA70", Offset = "0xA6D9A70", VA = "0x18A6DAA70")]
		public RigidTransform(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA6DA9C0", Offset = "0xA6D99C0", VA = "0x18A6DA9C0")]
		public RigidTransform(Matrix4x4 worldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA6DA810", Offset = "0xA6D9810", VA = "0x18A6DA810")]
		public void Update(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA6DA470", Offset = "0xA6D9470", VA = "0x18A6DA470")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA6DA2E0", Offset = "0xA6D92E0", VA = "0x18A6DA2E0")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA6DA610", Offset = "0xA6D9610", VA = "0x18A6DA610")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA6DA0E0", Offset = "0xA6D90E0", VA = "0x18A6DA0E0", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9F50", Offset = "0xA6D8F50", VA = "0x18A6D9F50", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA6DA290", Offset = "0xA6D9290", VA = "0x18A6DA290", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public IReadOnlyList<Matrix4x4> SkinMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD09150", Offset = "0xD08150", VA = "0x180D09150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9A10", Offset = "0xA6D8A10", VA = "0x18A6D9A10")]
		public SkinnedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC910", Offset = "0xA6DB910", VA = "0x18A6DC910")]
		public SkinnedTransform(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC9A0", Offset = "0xA6DB9A0", VA = "0x18A6DC9A0")]
		public SkinnedTransform(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC560", Offset = "0xA6DB560", VA = "0x18A6DC560")]
		public void Update(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC250", Offset = "0xA6DB250", VA = "0x18A6DC250")]
		public void Update(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB810", Offset = "0xA6DA810", VA = "0x18A6DB810")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB370", Offset = "0xA6DA370", VA = "0x18A6DB370")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA6DBD80", Offset = "0xA6DAD80", VA = "0x18A6DBD80")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB040", Offset = "0xA6DA040", VA = "0x18A6DB040")]
		public static Matrix4x4 CalculateInverseBinding(Matrix4x4 meshWorldTransform, Matrix4x4 jointWorldTransform)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA6DAC40", Offset = "0xA6D9C40", VA = "0x18A6DAC40")]
		public static Matrix4x4Double CalculateInverseBinding(Matrix4x4Double meshWorldTransform, Matrix4x4Double jointWorldTransform)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB2C0", Offset = "0xA6DA2C0", VA = "0x18A6DB2C0", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB260", Offset = "0xA6DA260", VA = "0x18A6DB260", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB320", Offset = "0xA6DA320", VA = "0x18A6DB320", Slot = "10")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <Evaluate>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0CB0", Offset = "0xA6DFCB0", VA = "0x18A6E0CB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0910", Offset = "0xA6DF910", VA = "0x18A6E0910", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0D70", Offset = "0xA6DFD70", VA = "0x18A6E0D70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0C70", Offset = "0xA6DFC70", VA = "0x18A6E0C70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0BD0", Offset = "0xA6DFBD0", VA = "0x18A6E0BD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IGeometryTransform> IEnumerable<IGeometryTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0BD0", Offset = "0xA6DFBD0", VA = "0x18A6E0BD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D4C60", Offset = "0xA6D3C60", VA = "0x18A6D4C60", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IReadOnlyList<Matrix4x4> LocalMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xDEFAF0", Offset = "0xDEEAF0", VA = "0x180DEFAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public IReadOnlyList<RigidTransform> WorldTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA6D4610", Offset = "0xA6D3610", VA = "0x18A6D4610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA6D49D0", Offset = "0xA6D39D0", VA = "0x18A6D49D0")]
		public InstancingTransform(AffineTransform[] instances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA6D48D0", Offset = "0xA6D38D0", VA = "0x18A6D48D0")]
		private RigidTransform[] _CreateTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4610", Offset = "0xA6D3610", VA = "0x18A6D4610")]
		public RigidTransform[] UpdateInstances()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4590", Offset = "0xA6D3590", VA = "0x18A6D4590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6D9AA0", Offset = "0xA6D8AA0", VA = "0x18A6D9AA0")]
		public static Matrix4x4 CreateOrthographicMatrix(float xmag, float ymag, float znear, float zfar)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9CA0", Offset = "0xA6D8CA0", VA = "0x18A6D9CA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xED7570", Offset = "0xED6570", VA = "0x180ED7570", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x209E220", Offset = "0x209D220", VA = "0x18209E220", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x15D3630", Offset = "0x15D2630", VA = "0x1815D3630")]
			[DebuggerHidden]
			public <Expand>d__51(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4E30", Offset = "0xA6F3E30", VA = "0x18A6F4E30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4F60", Offset = "0xA6F3F60", VA = "0x18A6F4F60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4EA0", Offset = "0xA6F3EA0", VA = "0x18A6F4EA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<float> IEnumerable<float>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4EA0", Offset = "0xA6F3EA0", VA = "0x18A6F4EA0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1414B90", Offset = "0x1413B90", VA = "0x181414B90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6F7FB0", Offset = "0xA6F6FB0", VA = "0x18A6F7FB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x65AFE60", Offset = "0x65AEE60", VA = "0x1865AFE60")]
			[DebuggerHidden]
			public <GetIndexedWeights>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7C10", Offset = "0xA6F6C10", VA = "0x18A6F7C10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7F70", Offset = "0xA6F6F70", VA = "0x18A6F7F70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7EB0", Offset = "0xA6F6EB0", VA = "0x18A6F7EB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7EB0", Offset = "0xA6F6EB0", VA = "0x18A6F7EB0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1414B90", Offset = "0x1413B90", VA = "0x181414B90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6F83F0", Offset = "0xA6F73F0", VA = "0x18A6F83F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x65AFE60", Offset = "0x65AEE60", VA = "0x1865AFE60")]
			[DebuggerHidden]
			public <GetNonZeroWeights>d__53(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8000", Offset = "0xA6F7000", VA = "0x18A6F8000", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA6F83B0", Offset = "0xA6F73B0", VA = "0x18A6F83B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA6F82F0", Offset = "0xA6F72F0", VA = "0x18A6F82F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xA6F82F0", Offset = "0xA6F72F0", VA = "0x18A6F82F0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1414B90", Offset = "0x1413B90", VA = "0x181414B90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6FF530", Offset = "0xA6FE530", VA = "0x18A6FF530", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x65AFE60", Offset = "0x65AEE60", VA = "0x1865AFE60")]
			[DebuggerHidden]
			public <_GetPairs>d__64(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA6FF170", Offset = "0xA6FE170", VA = "0x18A6FF170", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA6FF4F0", Offset = "0xA6FE4F0", VA = "0x18A6FF4F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xA6FF430", Offset = "0xA6FE430", VA = "0x18A6FF430", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IndexWeight> IEnumerable<IndexWeight>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xA6FF430", Offset = "0xA6FE430", VA = "0x18A6FF430", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6E0760", Offset = "0xA6DF760", VA = "0x18A6E0760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA6DE1C0", Offset = "0xA6DD1C0", VA = "0x18A6DE1C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6E0770", Offset = "0xA6DF770", VA = "0x18A6E0770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float WeightSum
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0860", Offset = "0xA6DF860", VA = "0x18A6E0860")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int MaxIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0850", Offset = "0xA6DF850", VA = "0x18A6E0850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF970", Offset = "0xA6DE970", VA = "0x18A6DF970")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD730", Offset = "0xA6DC730", VA = "0x18A6DD730")]
		public static SparseWeight8 Create(params float[] weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA6DDC20", Offset = "0xA6DCC20", VA = "0x18A6DDC20")]
		public static SparseWeight8 Create(IEnumerable<float> weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD6F0", Offset = "0xA6DC6F0", VA = "0x18A6DD6F0")]
		public static SparseWeight8 Create(params (int Index, float Weight)[] indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD770", Offset = "0xA6DC770", VA = "0x18A6DD770")]
		public static SparseWeight8 Create(IEnumerable<(int Index, float Weight)> indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA6DDB20", Offset = "0xA6DCB20", VA = "0x18A6DDB20")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD490", Offset = "0xA6DC490", VA = "0x18A6DD490")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD400", Offset = "0xA6DC400", VA = "0x18A6DD400")]
		public static SparseWeight8 CreateUnchecked([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0640", Offset = "0xA6DF640", VA = "0x18A6E0640")]
		private SparseWeight8([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0580", Offset = "0xA6DF580", VA = "0x18A6E0580")]
		private SparseWeight8(ReadOnlySpan<IndexWeight> iw)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA6E06C0", Offset = "0xA6DF6C0", VA = "0x18A6E06C0")]
		private SparseWeight8([In] SparseWeight8 sparse, float scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE2E0", Offset = "0xA6DD2E0", VA = "0x18A6DE2E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE040", Offset = "0xA6DD040", VA = "0x18A6DE040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE100", Offset = "0xA6DD100", VA = "0x18A6DE100", Slot = "4")]
		public bool Equals(SparseWeight8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0890", Offset = "0xA6DF890", VA = "0x18A6E0890")]
		public static bool operator ==(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E08D0", Offset = "0xA6DF8D0", VA = "0x18A6E08D0")]
		public static bool operator !=(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA6DCB90", Offset = "0xA6DBB90", VA = "0x18A6DCB90")]
		internal static bool AreEqual([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF360", Offset = "0xA6DE360", VA = "0x18A6DF360")]
		public static SparseWeight8 OrderedByWeight([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF180", Offset = "0xA6DE180", VA = "0x18A6DF180")]
		public static SparseWeight8 OrderedByIndex([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6DCA40", Offset = "0xA6DBA40", VA = "0x18A6DCA40")]
		public static SparseWeight8 Add([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF730", Offset = "0xA6DE730", VA = "0x18A6DF730")]
		public static SparseWeight8 Subtract([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF030", Offset = "0xA6DE030", VA = "0x18A6DF030")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6DEF90", Offset = "0xA6DDF90", VA = "0x18A6DEF90")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, float y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6DEE60", Offset = "0xA6DDE60", VA = "0x18A6DEE60")]
		public static SparseWeight8 InterpolateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6DED20", Offset = "0xA6DDD20", VA = "0x18A6DED20")]
		public static SparseWeight8 InterpolateCubic([In] SparseWeight8 x, [In] SparseWeight8 xt, [In] SparseWeight8 y, [In] SparseWeight8 yt, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE120", Offset = "0xA6DD120", VA = "0x18A6DE120")]
		[IteratorStateMachine(typeof(<Expand>d__51))]
		public IEnumerable<float> Expand(int count)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE4D0", Offset = "0xA6DD4D0", VA = "0x18A6DE4D0")]
		[IteratorStateMachine(typeof(<GetIndexedWeights>d__52))]
		public IEnumerable<(int, float)> GetIndexedWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE560", Offset = "0xA6DD560", VA = "0x18A6DE560")]
		[IteratorStateMachine(typeof(<GetNonZeroWeights>d__53))]
		public IEnumerable<(int, float)> GetNonZeroWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6DCF10", Offset = "0xA6DBF10", VA = "0x18A6DCF10")]
		public static SparseWeight8 Blend(ReadOnlySpan<SparseWeight8> sparses, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE8D0", Offset = "0xA6DD8D0", VA = "0x18A6DE8D0")]
		public SparseWeight8 GetTrimmed(int maxWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE780", Offset = "0xA6DD780", VA = "0x18A6DE780")]
		public SparseWeight8 GetNormalized()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF880", Offset = "0xA6DE880", VA = "0x18A6DF880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0210", Offset = "0xA6DF210", VA = "0x18A6E0210")]
		private static SparseWeight8 _OperateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, Func<float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6DFD60", Offset = "0xA6DED60", VA = "0x18A6DFD60")]
		private static SparseWeight8 _OperateCubic([In] SparseWeight8 x, [In] SparseWeight8 y, [In] SparseWeight8 z, [In] SparseWeight8 w, Func<float, float, float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE1C0", Offset = "0xA6DD1C0", VA = "0x18A6DE1C0")]
		private float GetExpandedAt(int idx)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE220", Offset = "0xA6DD220", VA = "0x18A6DE220")]
		private int GetExpandedCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE5F0", Offset = "0xA6DD5F0", VA = "0x18A6DE5F0")]
		internal SparseWeight8 GetNormalizedWithComplement(int complementIndex)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6DFAE0", Offset = "0xA6DEAE0", VA = "0x18A6DFAE0")]
		internal int _GetMaxIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6DFCD0", Offset = "0xA6DECD0", VA = "0x18A6DFCD0")]
		[IteratorStateMachine(typeof(<_GetPairs>d__64))]
		internal IEnumerable<IndexWeight> _GetPairs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA6DEA10", Offset = "0xA6DDA10", VA = "0x18A6DEA10")]
		internal int InsertTo(Span<IndexWeight> dst)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD180", Offset = "0xA6DC180", VA = "0x18A6DD180")]
		internal void CopyTo(Span<IndexWeight> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA6DCD10", Offset = "0xA6DBD10", VA = "0x18A6DCD10")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xA6FDB40", Offset = "0xA6FCB40", VA = "0x18A6FDB40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD810", Offset = "0xA6FC810", VA = "0x18A6FD810", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA6FDC00", Offset = "0xA6FCC00", VA = "0x18A6FDC00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xA6FDB00", Offset = "0xA6FCB00", VA = "0x18A6FDB00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA6FDA60", Offset = "0xA6FCA60", VA = "0x18A6FDA60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xA6FDA60", Offset = "0xA6FCA60", VA = "0x18A6FDA60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA7001A0", Offset = "0xA6FF1A0", VA = "0x18A7001A0")]
		internal XmpPackets(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFCB0", Offset = "0xA6FECB0", VA = "0x18A6FFCB0")]
		public int AddPacket(JsonNode packet)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFEA0", Offset = "0xA6FEEA0", VA = "0x18A6FFEA0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFED0", Offset = "0xA6FEED0", VA = "0x18A6FFED0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__6))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA700000", Offset = "0xA6FF000", VA = "0x18A700000", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFF50", Offset = "0xA6FEF50", VA = "0x18A6FFF50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFE00", Offset = "0xA6FEE00", VA = "0x18A6FFE00", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8770", Offset = "0xA6F7770", VA = "0x18A6F8770", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8440", Offset = "0xA6F7440", VA = "0x18A6F8440", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8830", Offset = "0xA6F7830", VA = "0x18A6F8830")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8730", Offset = "0xA6F7730", VA = "0x18A6F8730", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8690", Offset = "0xA6F7690", VA = "0x18A6F8690", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8690", Offset = "0xA6F7690", VA = "0x18A6F8690", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CA80", Offset = "0xD0BA80", VA = "0x180D0CA80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public JsonNode JsonPacket
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xA6FFBE0", Offset = "0xA6FEBE0", VA = "0x18A6FFBE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFBA0", Offset = "0xA6FEBA0", VA = "0x18A6FFBA0")]
		internal XmpPacketReference(ExtraProperties owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFA70", Offset = "0xA6FEA70", VA = "0x18A6FFA70")]
		private ModelRoot _FindRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFAF0", Offset = "0xA6FEAF0", VA = "0x18A6FFAF0")]
		private XmpPackets _GetPackets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF760", Offset = "0xA6FE760", VA = "0x18A6FF760")]
		public void SetPacket(int logicalIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF620", Offset = "0xA6FE620", VA = "0x18A6FF620", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF650", Offset = "0xA6FE650", VA = "0x18A6FF650", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__11))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF8D0", Offset = "0xA6FE8D0", VA = "0x18A6FF8D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF6D0", Offset = "0xA6FE6D0", VA = "0x18A6FF6D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF580", Offset = "0xA6FE580", VA = "0x18A6FF580", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA6FCA80", Offset = "0xA6FBA80", VA = "0x18A6FCA80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA6F9970", Offset = "0xA6F8970", VA = "0x18A6F9970", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD5E0", Offset = "0xA6FC5E0", VA = "0x18A6FD5E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC200", Offset = "0xA6FB200", VA = "0x18A6FC200", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB900", Offset = "0xA6FA900", VA = "0x18A6FB900", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB900", Offset = "0xA6FA900", VA = "0x18A6FB900", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8730", Offset = "0xA6E7730", VA = "0x18A6E8730", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8760", Offset = "0xA6E7760", VA = "0x18A6E8760", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8B90", Offset = "0xA6E7B90", VA = "0x18A6E8B90", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E87E0", Offset = "0xA6E77E0", VA = "0x18A6E87E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8690", Offset = "0xA6E7690", VA = "0x18A6E8690", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8D40", Offset = "0xA6E7D40", VA = "0x18A6E8D40")]
		public AnimationPointer(AnimationChannelTarget parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8950", Offset = "0xA6E7950", VA = "0x18A6E8950")]
		public static bool TryParseNodeTransform(string pointerPath, [Out] int nodeIndex, [Out] PropertyPath property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8840", Offset = "0xA6E7840", VA = "0x18A6E8840")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6F54A0", Offset = "0xA6F44A0", VA = "0x18A6F54A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4FA0", Offset = "0xA6F3FA0", VA = "0x18A6F4FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5460", Offset = "0xA6F4460", VA = "0x18A6F5460", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xA6F53B0", Offset = "0xA6F43B0", VA = "0x18A6F53B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xA6F53B0", Offset = "0xA6F43B0", VA = "0x18A6F53B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD080", Offset = "0xA6FC080", VA = "0x18A6FD080", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8C00", Offset = "0xA6F7C00", VA = "0x18A6F8C00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD4F0", Offset = "0xA6FC4F0", VA = "0x18A6FD4F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC480", Offset = "0xA6FB480", VA = "0x18A6FC480", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB720", Offset = "0xA6FA720", VA = "0x18A6FB720", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB720", Offset = "0xA6FA720", VA = "0x18A6FB720", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6E9650", Offset = "0xA6E8650", VA = "0x18A6E9650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA6E96A0", Offset = "0xA6E86A0", VA = "0x18A6E96A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float AnisotropyRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA6E9720", Offset = "0xA6E8720", VA = "0x18A6E9720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA6E9770", Offset = "0xA6E8770", VA = "0x18A6E9770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8F30", Offset = "0xA6E7F30", VA = "0x18A6E8F30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9050", Offset = "0xA6E8050", VA = "0x18A6E9050", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9220", Offset = "0xA6E8220", VA = "0x18A6E9220", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA6E90D0", Offset = "0xA6E80D0", VA = "0x18A6E90D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8D80", Offset = "0xA6E7D80", VA = "0x18A6E8D80", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9820", Offset = "0xA6E8820", VA = "0x18A6E9820")]
		internal MaterialAnisotropy(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8F60", Offset = "0xA6E7F60", VA = "0x18A6E8F60", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8EA0", Offset = "0xA6E7EA0", VA = "0x18A6E8EA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6F7310", Offset = "0xA6F6310", VA = "0x18A6F7310", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__28(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6AB0", Offset = "0xA6F5AB0", VA = "0x18A6F6AB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA6F72D0", Offset = "0xA6F62D0", VA = "0x18A6F72D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7220", Offset = "0xA6F6220", VA = "0x18A6F7220", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7220", Offset = "0xA6F6220", VA = "0x18A6F7220", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xA6FCCC0", Offset = "0xA6FBCC0", VA = "0x18A6FCCC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8880", Offset = "0xA6F7880", VA = "0x18A6F8880", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD680", Offset = "0xA6FC680", VA = "0x18A6FD680")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC2C0", Offset = "0xA6FB2C0", VA = "0x18A6FC2C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB7C0", Offset = "0xA6FA7C0", VA = "0x18A6FB7C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB7C0", Offset = "0xA6FA7C0", VA = "0x18A6FB7C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6EA440", Offset = "0xA6E9440", VA = "0x18A6EA440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA6EA490", Offset = "0xA6E9490", VA = "0x18A6EA490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA6EA5B0", Offset = "0xA6E95B0", VA = "0x18A6EA5B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xA6EA600", Offset = "0xA6E9600", VA = "0x18A6EA600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9AD0", Offset = "0xA6E8AD0", VA = "0x18A6E9AD0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9C50", Offset = "0xA6E8C50", VA = "0x18A6E9C50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9E70", Offset = "0xA6E8E70", VA = "0x18A6E9E70", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9CD0", Offset = "0xA6E8CD0", VA = "0x18A6E9CD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E98A0", Offset = "0xA6E88A0", VA = "0x18A6E98A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA6EA960", Offset = "0xA6E9960", VA = "0x18A6EA960")]
		internal MaterialClearCoat(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9B00", Offset = "0xA6E8B00", VA = "0x18A6E9B00", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA6EA8D0", Offset = "0xA6E98D0", VA = "0x18A6EA8D0")]
		private TextureInfo _GetClearCoatTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA6EA840", Offset = "0xA6E9840", VA = "0x18A6EA840")]
		private TextureInfo _GetClearCoatRoughnessTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA6EA7B0", Offset = "0xA6E97B0", VA = "0x18A6EA7B0")]
		private MaterialNormalTextureInfo _GetClearCoatNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9A40", Offset = "0xA6E8A40", VA = "0x18A6E9A40")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6F6250", Offset = "0xA6F5250", VA = "0x18A6F6250", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5AC0", Offset = "0xA6F4AC0", VA = "0x18A6F5AC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6210", Offset = "0xA6F5210", VA = "0x18A6F6210", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6120", Offset = "0xA6F5120", VA = "0x18A6F6120", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6120", Offset = "0xA6F5120", VA = "0x18A6F6120", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC9C0", Offset = "0xA6FB9C0", VA = "0x18A6FC9C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB400", Offset = "0xA6FA400", VA = "0x18A6FB400", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD400", Offset = "0xA6FC400", VA = "0x18A6FD400")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC4C0", Offset = "0xA6FB4C0", VA = "0x18A6FC4C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBAE0", Offset = "0xA6FAAE0", VA = "0x18A6FBAE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBAE0", Offset = "0xA6FAAE0", VA = "0x18A6FBAE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6EB460", Offset = "0xA6EA460", VA = "0x18A6EB460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA6EB4B0", Offset = "0xA6EA4B0", VA = "0x18A6EB4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 DiffuseTransmissionColorFactor
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xA6EB5A0", Offset = "0xA6EA5A0", VA = "0x18A6EB5A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xA6EB660", Offset = "0xA6EA660", VA = "0x18A6EB660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA6EABE0", Offset = "0xA6E9BE0", VA = "0x18A6EABE0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA6EAD00", Offset = "0xA6E9D00", VA = "0x18A6EAD00", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xA6EAF40", Offset = "0xA6E9F40", VA = "0x18A6EAF40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xA6EAD80", Offset = "0xA6E9D80", VA = "0x18A6EAD80", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA6EA9E0", Offset = "0xA6E99E0", VA = "0x18A6EA9E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB760", Offset = "0xA6EA760", VA = "0x18A6EB760")]
		internal MaterialDiffuseTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6EAC10", Offset = "0xA6E9C10", VA = "0x18A6EAC10", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6EAB50", Offset = "0xA6E9B50", VA = "0x18A6EAB50")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD200", Offset = "0xA6FC200", VA = "0x18A6FD200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xA6F9150", Offset = "0xA6F8150", VA = "0x18A6F9150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD4A0", Offset = "0xA6FC4A0", VA = "0x18A6FD4A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC500", Offset = "0xA6FB500", VA = "0x18A6FC500", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBD60", Offset = "0xA6FAD60", VA = "0x18A6FBD60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBD60", Offset = "0xA6FAD60", VA = "0x18A6FBD60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5A860", Offset = "0xD59860", VA = "0x180D5A860")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA6EBD10", Offset = "0xA6EAD10", VA = "0x18A6EBD10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA6EBD60", Offset = "0xA6EAD60", VA = "0x18A6EBD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB8D0", Offset = "0xA6EA8D0", VA = "0x18A6EB8D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB9D0", Offset = "0xA6EA9D0", VA = "0x18A6EB9D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6EBB10", Offset = "0xA6EAB10", VA = "0x18A6EBB10", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA6EBA50", Offset = "0xA6EAA50", VA = "0x18A6EBA50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB830", Offset = "0xA6EA830", VA = "0x18A6EB830", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6EBCB0", Offset = "0xA6EACB0", VA = "0x18A6EBCB0")]
		internal MaterialDispersion(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB900", Offset = "0xA6EA900", VA = "0x18A6EB900", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xA6FCF00", Offset = "0xA6FBF00", VA = "0x18A6FCF00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xA6FA0B0", Offset = "0xA6F90B0", VA = "0x18A6FA0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD3B0", Offset = "0xA6FC3B0", VA = "0x18A6FD3B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC540", Offset = "0xA6FB540", VA = "0x18A6FC540", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB9A0", Offset = "0xA6FA9A0", VA = "0x18A6FB9A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB9A0", Offset = "0xA6FA9A0", VA = "0x18A6FB9A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6EC9F0", Offset = "0xA6EB9F0", VA = "0x18A6EC9F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xA6ECA00", Offset = "0xA6EBA00", VA = "0x18A6ECA00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xA6ECA50", Offset = "0xA6EBA50", VA = "0x18A6ECA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC580", Offset = "0xA6EB580", VA = "0x18A6EC580", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC6B0", Offset = "0xA6EB6B0", VA = "0x18A6EC6B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC7F0", Offset = "0xA6EB7F0", VA = "0x18A6EC7F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC730", Offset = "0xA6EB730", VA = "0x18A6EC730", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC4E0", Offset = "0xA6EB4E0", VA = "0x18A6EC4E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC990", Offset = "0xA6EB990", VA = "0x18A6EC990")]
		internal MaterialIOR(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC5B0", Offset = "0xA6EB5B0", VA = "0x18A6EC5B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6F7BB0", Offset = "0xA6F6BB0", VA = "0x18A6F7BB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__35(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7370", Offset = "0xA6F6370", VA = "0x18A6F7370", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7B70", Offset = "0xA6F6B70", VA = "0x18A6F7B70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7AC0", Offset = "0xA6F6AC0", VA = "0x18A6F7AC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7AC0", Offset = "0xA6F6AC0", VA = "0x18A6F7AC0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xA6FCD80", Offset = "0xA6FBD80", VA = "0x18A6FCD80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB030", Offset = "0xA6FA030", VA = "0x18A6FB030", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD2C0", Offset = "0xA6FC2C0", VA = "0x18A6FD2C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC440", Offset = "0xA6FB440", VA = "0x18A6FC440", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBF40", Offset = "0xA6FAF40", VA = "0x18A6FBF40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBF40", Offset = "0xA6FAF40", VA = "0x18A6FBF40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6ED9B0", Offset = "0xA6EC9B0", VA = "0x18A6ED9B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA6EDA00", Offset = "0xA6ECA00", VA = "0x18A6EDA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float IridescenceIndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xA6EDA80", Offset = "0xA6ECA80", VA = "0x18A6EDA80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xA6EDAE0", Offset = "0xA6ECAE0", VA = "0x18A6EDAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float IridescenceThicknessMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xA6EDBD0", Offset = "0xA6ECBD0", VA = "0x18A6EDBD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xA6EDC30", Offset = "0xA6ECC30", VA = "0x18A6EDC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float IridescenceThicknessMaximum
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED860", Offset = "0xA6EC860", VA = "0x18A6ED860")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED8C0", Offset = "0xA6EC8C0", VA = "0x18A6ED8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECCF0", Offset = "0xA6EBCF0", VA = "0x18A6ECCF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECF50", Offset = "0xA6EBF50", VA = "0x18A6ECF50", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED200", Offset = "0xA6EC200", VA = "0x18A6ED200", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECFD0", Offset = "0xA6EBFD0", VA = "0x18A6ECFD0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECAC0", Offset = "0xA6EBAC0", VA = "0x18A6ECAC0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6EDCB0", Offset = "0xA6ECCB0", VA = "0x18A6EDCB0")]
		internal MaterialIridescence(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECD20", Offset = "0xA6EBD20", VA = "0x18A6ECD20", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECC60", Offset = "0xA6EBC60", VA = "0x18A6ECC60")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC6C0", Offset = "0xA6FB6C0", VA = "0x18A6FC6C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xA6F8F00", Offset = "0xA6F7F00", VA = "0x18A6F8F00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD590", Offset = "0xA6FC590", VA = "0x18A6FD590")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC340", Offset = "0xA6FB340", VA = "0x18A6FC340", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC080", Offset = "0xA6FB080", VA = "0x18A6FC080", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC080", Offset = "0xA6FB080", VA = "0x18A6FC080", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6EC410", Offset = "0xA6EB410", VA = "0x18A6EC410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xA6EC460", Offset = "0xA6EB460", VA = "0x18A6EC460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA6EBFD0", Offset = "0xA6EAFD0", VA = "0x18A6EBFD0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC0D0", Offset = "0xA6EB0D0", VA = "0x18A6EC0D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC210", Offset = "0xA6EB210", VA = "0x18A6EC210", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC150", Offset = "0xA6EB150", VA = "0x18A6EC150", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA6EBDF0", Offset = "0xA6EADF0", VA = "0x18A6EBDF0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC3B0", Offset = "0xA6EB3B0", VA = "0x18A6EC3B0")]
		internal MaterialEmissiveStrength(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC000", Offset = "0xA6EB000", VA = "0x18A6EC000", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA6EBE90", Offset = "0xA6EAE90", VA = "0x18A6EBE90")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6F6A50", Offset = "0xA6F5A50", VA = "0x18A6F6A50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6310", Offset = "0xA6F5310", VA = "0x18A6F6310", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6A10", Offset = "0xA6F5A10", VA = "0x18A6F6A10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6960", Offset = "0xA6F5960", VA = "0x18A6F6960", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6960", Offset = "0xA6F5960", VA = "0x18A6F6960", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA6FCFC0", Offset = "0xA6FBFC0", VA = "0x18A6FCFC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA6FA300", Offset = "0xA6F9300", VA = "0x18A6FA300", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD310", Offset = "0xA6FC310", VA = "0x18A6FD310")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC280", Offset = "0xA6FB280", VA = "0x18A6FC280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBEA0", Offset = "0xA6FAEA0", VA = "0x18A6FBEA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBEA0", Offset = "0xA6FAEA0", VA = "0x18A6FBEA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6F0BF0", Offset = "0xA6EFBF0", VA = "0x18A6F0BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0C40", Offset = "0xA6EFC40", VA = "0x18A6F0C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 AttenuationColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0CC0", Offset = "0xA6EFCC0", VA = "0x18A6F0CC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0D80", Offset = "0xA6EFD80", VA = "0x18A6F0D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float AttenuationDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0E30", Offset = "0xA6EFE30", VA = "0x18A6F0E30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0E90", Offset = "0xA6EFE90", VA = "0x18A6F0E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA6F0230", Offset = "0xA6EF230", VA = "0x18A6F0230", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA6F0450", Offset = "0xA6EF450", VA = "0x18A6F0450", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA6F06B0", Offset = "0xA6EF6B0", VA = "0x18A6F06B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA6F04D0", Offset = "0xA6EF4D0", VA = "0x18A6F04D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA6F0030", Offset = "0xA6EF030", VA = "0x18A6F0030", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA6F0F50", Offset = "0xA6EFF50", VA = "0x18A6F0F50")]
		internal MaterialVolume(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA6F0260", Offset = "0xA6EF260", VA = "0x18A6F0260", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA6F01A0", Offset = "0xA6EF1A0", VA = "0x18A6F01A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xA6FCE40", Offset = "0xA6FBE40", VA = "0x18A6FCE40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xA6F93A0", Offset = "0xA6F83A0", VA = "0x18A6F93A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD360", Offset = "0xA6FC360", VA = "0x18A6FD360")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC1C0", Offset = "0xA6FB1C0", VA = "0x18A6FC1C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBB80", Offset = "0xA6FAB80", VA = "0x18A6FBB80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBB80", Offset = "0xA6FAB80", VA = "0x18A6FBB80", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x5C2FA80", Offset = "0x5C2EA80", VA = "0x185C2FA80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6FF110", Offset = "0xA6FE110", VA = "0x18A6FF110", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x65AFE30", Offset = "0x65AEE30", VA = "0x1865AFE30")]
			[DebuggerHidden]
			public <_GetLocalTransforms>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA6FEF70", Offset = "0xA6FDF70", VA = "0x18A6FEF70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA6FF0D0", Offset = "0xA6FE0D0", VA = "0x18A6FF0D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xA6FF030", Offset = "0xA6FE030", VA = "0x18A6FF030", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<AffineTransform> IEnumerable<AffineTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xA6FF030", Offset = "0xA6FE030", VA = "0x18A6FF030", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Node VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xA6F20A0", Offset = "0xA6F10A0", VA = "0x18A6F20A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IReadOnlyDictionary<string, Accessor> Accessors
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1DD0", Offset = "0xA6F0DD0", VA = "0x18A6F1DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public IEnumerable<AffineTransform> LocalTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1F90", Offset = "0xA6F0F90", VA = "0x18A6F1F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1640", Offset = "0xA6F0640", VA = "0x18A6F1640", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1890", Offset = "0xA6F0890", VA = "0x18A6F1890", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1B50", Offset = "0xA6F0B50", VA = "0x18A6F1B50", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1910", Offset = "0xA6F0910", VA = "0x18A6F1910", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1070", Offset = "0xA6F0070", VA = "0x18A6F1070", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA6F2010", Offset = "0xA6F1010", VA = "0x18A6F2010")]
		internal MeshGpuInstancing(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1EA0", Offset = "0xA6F0EA0", VA = "0x18A6F1EA0")]
		private int _GetCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1DD0", Offset = "0xA6F0DD0", VA = "0x18A6F1DD0")]
		private IReadOnlyDictionary<string, Accessor> _GetAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1F90", Offset = "0xA6F0F90", VA = "0x18A6F1F90")]
		[IteratorStateMachine(typeof(<_GetLocalTransforms>d__21))]
		private IEnumerable<AffineTransform> _GetLocalTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1020", Offset = "0xA6F0020", VA = "0x18A6F1020")]
		public void ClearAccessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1110", Offset = "0xA6F0110", VA = "0x18A6F1110")]
		public Accessor GetAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1980", Offset = "0xA6F0980", VA = "0x18A6F1980")]
		public void SetAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA6F12F0", Offset = "0xA6F02F0", VA = "0x18A6F12F0")]
		public AffineTransform GetLocalTransform(int index)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1210", Offset = "0xA6F0210", VA = "0x18A6F1210")]
		public Matrix4x4 GetLocalMatrix(int index)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA6F1670", Offset = "0xA6F0670", VA = "0x18A6F1670")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC780", Offset = "0xA6FB780", VA = "0x18A6FC780", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xA6F9BC0", Offset = "0xA6F8BC0", VA = "0x18A6F9BC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD7C0", Offset = "0xA6FC7C0", VA = "0x18A6FD7C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC580", Offset = "0xA6FB580", VA = "0x18A6FC580", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC120", Offset = "0xA6FB120", VA = "0x18A6FC120", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC120", Offset = "0xA6FB120", VA = "0x18A6FC120", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6F2980", Offset = "0xA6F1980", VA = "0x18A6F2980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA6F2A30", Offset = "0xA6F1A30", VA = "0x18A6F2A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA6F29D0", Offset = "0xA6F19D0", VA = "0x18A6F29D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA6F2B50", Offset = "0xA6F1B50", VA = "0x18A6F2B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6F2180", Offset = "0xA6F1180", VA = "0x18A6F2180", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6F24A0", Offset = "0xA6F14A0", VA = "0x18A6F24A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6F2640", Offset = "0xA6F1640", VA = "0x18A6F2640", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6F2520", Offset = "0xA6F1520", VA = "0x18A6F2520", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA6F20B0", Offset = "0xA6F10B0", VA = "0x18A6F20B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA6F21B0", Offset = "0xA6F11B0", VA = "0x18A6F21B0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA6F28F0", Offset = "0xA6F18F0", VA = "0x18A6F28F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC840", Offset = "0xA6FB840", VA = "0x18A6FC840", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA6F95F0", Offset = "0xA6F85F0", VA = "0x18A6F95F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD540", Offset = "0xA6FC540", VA = "0x18A6FD540")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC3C0", Offset = "0xA6FB3C0", VA = "0x18A6FC3C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBFE0", Offset = "0xA6FAFE0", VA = "0x18A6FBFE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBFE0", Offset = "0xA6FAFE0", VA = "0x18A6FBFE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6F44A0", Offset = "0xA6F34A0", VA = "0x18A6F44A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public PunctualLightType LightType
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xA6F43B0", Offset = "0xA6F33B0", VA = "0x18A6F43B0")]
			get
			{
				return default(PunctualLightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public float InnerConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xA6F42F0", Offset = "0xA6F32F0", VA = "0x18A6F42F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4540", Offset = "0xA6F3540", VA = "0x18A6F4540")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4230", Offset = "0xA6F3230", VA = "0x18A6F4230")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4600", Offset = "0xA6F3600", VA = "0x18A6F4600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4350", Offset = "0xA6F3350", VA = "0x18A6F4350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4720", Offset = "0xA6F3720", VA = "0x18A6F4720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float Range
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xA6F45A0", Offset = "0xA6F35A0", VA = "0x18A6F45A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0xA6F47A0", Offset = "0xA6F37A0", VA = "0x18A6F47A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6F2E30", Offset = "0xA6F1E30", VA = "0x18A6F2E30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA6F3120", Offset = "0xA6F2120", VA = "0x18A6F3120", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6F3940", Offset = "0xA6F2940", VA = "0x18A6F3940", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6F31A0", Offset = "0xA6F21A0", VA = "0x18A6F31A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA6F2C70", Offset = "0xA6F1C70", VA = "0x18A6F2C70", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6F4150", Offset = "0xA6F3150", VA = "0x18A6F4150")]
		internal PunctualLight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6F3F60", Offset = "0xA6F2F60", VA = "0x18A6F3F60")]
		internal PunctualLight(PunctualLightType ltype)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6F35F0", Offset = "0xA6F25F0", VA = "0x18A6F35F0")]
		public void SetSpotCone(float innerConeAngle, float outerConeAngle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6F33A0", Offset = "0xA6F23A0", VA = "0x18A6F33A0")]
		public void SetColor(Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6F2F30", Offset = "0xA6F1F30", VA = "0x18A6F2F30", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6F2E60", Offset = "0xA6F1E60", VA = "0x18A6F2E60", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD140", Offset = "0xA6FC140", VA = "0x18A6FD140", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xA6F9E60", Offset = "0xA6F8E60", VA = "0x18A6F9E60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD720", Offset = "0xA6FC720", VA = "0x18A6FD720")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC300", Offset = "0xA6FB300", VA = "0x18A6FC300", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB860", Offset = "0xA6FA860", VA = "0x18A6FB860", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xA6FB860", Offset = "0xA6FA860", VA = "0x18A6FB860", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA700370", Offset = "0xA6FF370", VA = "0x18A700370", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7003A0", Offset = "0xA6FF3A0", VA = "0x18A7003A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA7004D0", Offset = "0xA6FF4D0", VA = "0x18A7004D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA700420", Offset = "0xA6FF420", VA = "0x18A700420", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA7002D0", Offset = "0xA6FF2D0", VA = "0x18A7002D0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA700670", Offset = "0xA6FF670", VA = "0x18A700670")]
		internal _ModelPunctualLights(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA700220", Offset = "0xA6FF220", VA = "0x18A700220")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA6FCC00", Offset = "0xA6FBC00", VA = "0x18A6FCC00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA6FADE0", Offset = "0xA6F9DE0", VA = "0x18A6FADE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD6D0", Offset = "0xA6FC6D0", VA = "0x18A6FD6D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC240", Offset = "0xA6FB240", VA = "0x18A6FC240", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBE00", Offset = "0xA6FAE00", VA = "0x18A6FBE00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBE00", Offset = "0xA6FAE00", VA = "0x18A6FBE00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6F4BE0", Offset = "0xA6F3BE0", VA = "0x18A6F4BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xA6F4CF0", Offset = "0xA6F3CF0", VA = "0x18A6F4CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA6F4920", Offset = "0xA6F3920", VA = "0x18A6F4920", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6F4950", Offset = "0xA6F3950", VA = "0x18A6F4950", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6F4A40", Offset = "0xA6F3A40", VA = "0x18A6F4A40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6F49D0", Offset = "0xA6F39D0", VA = "0x18A6F49D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6F4880", Offset = "0xA6F3880", VA = "0x18A6F4880", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8D40", Offset = "0xA6E7D40", VA = "0x18A6E8D40")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC600", Offset = "0xA6FB600", VA = "0x18A6FC600", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA6FAB90", Offset = "0xA6F9B90", VA = "0x18A6FAB90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD770", Offset = "0xA6FC770", VA = "0x18A6FD770")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC380", Offset = "0xA6FB380", VA = "0x18A6FC380", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBA40", Offset = "0xA6FAA40", VA = "0x18A6FBA40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBA40", Offset = "0xA6FAA40", VA = "0x18A6FBA40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xD60B30", Offset = "0xD5FB30", VA = "0x180D60B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xA7007A0", Offset = "0xA6FF7A0", VA = "0x18A7007A0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xA7007D0", Offset = "0xA6FF7D0", VA = "0x18A7007D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xA7008E0", Offset = "0xA6FF8E0", VA = "0x18A7008E0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xA700850", Offset = "0xA6FF850", VA = "0x18A700850", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xA700700", Offset = "0xA6FF700", VA = "0x18A700700", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xA700A80", Offset = "0xA6FFA80", VA = "0x18A700A80")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA6FCB40", Offset = "0xA6FBB40", VA = "0x18A6FCB40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA6FA940", Offset = "0xA6F9940", VA = "0x18A6FA940", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD630", Offset = "0xA6FC630", VA = "0x18A6FD630")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC5C0", Offset = "0xA6FB5C0", VA = "0x18A6FC5C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBCC0", Offset = "0xA6FACC0", VA = "0x18A6FBCC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBCC0", Offset = "0xA6FACC0", VA = "0x18A6FBCC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA700F40", Offset = "0xA6FFF40", VA = "0x18A700F40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xA700FC0", Offset = "0xA6FFFC0", VA = "0x18A700FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA700B30", Offset = "0xA6FFB30", VA = "0x18A700B30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xA700B60", Offset = "0xA6FFB60", VA = "0x18A700B60", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA700CB0", Offset = "0xA6FFCB0", VA = "0x18A700CB0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xA700BE0", Offset = "0xA6FFBE0", VA = "0x18A700BE0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xA700A90", Offset = "0xA6FFA90", VA = "0x18A700A90", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xA700E90", Offset = "0xA6FFE90", VA = "0x18A700E90")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6F62B0", Offset = "0xA6F52B0", VA = "0x18A6F62B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5500", Offset = "0xA6F4500", VA = "0x18A6F5500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA6F61D0", Offset = "0xA6F51D0", VA = "0x18A6F61D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6070", Offset = "0xA6F5070", VA = "0x18A6F6070", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6070", Offset = "0xA6F5070", VA = "0x18A6F6070", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC900", Offset = "0xA6FB900", VA = "0x18A6FC900", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA6FA620", Offset = "0xA6F9620", VA = "0x18A6FA620", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA6FD450", Offset = "0xA6FC450", VA = "0x18A6FD450")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xA6FC400", Offset = "0xA6FB400", VA = "0x18A6FC400", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBC20", Offset = "0xA6FAC20", VA = "0x18A6FBC20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xA6FBC20", Offset = "0xA6FAC20", VA = "0x18A6FBC20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6EFC50", Offset = "0xA6EEC50", VA = "0x18A6EFC50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA6EFD10", Offset = "0xA6EED10", VA = "0x18A6EFD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public float SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xA6EFE30", Offset = "0xA6EEE30", VA = "0x18A6EFE30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xA6EFE90", Offset = "0xA6EEE90", VA = "0x18A6EFE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF2C0", Offset = "0xA6EE2C0", VA = "0x18A6EF2C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF4E0", Offset = "0xA6EE4E0", VA = "0x18A6EF4E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF730", Offset = "0xA6EE730", VA = "0x18A6EF730", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF560", Offset = "0xA6EE560", VA = "0x18A6EF560", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF0C0", Offset = "0xA6EE0C0", VA = "0x18A6EF0C0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xA6EFF50", Offset = "0xA6EEF50", VA = "0x18A6EFF50")]
		internal MaterialSpecular(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF2F0", Offset = "0xA6EE2F0", VA = "0x18A6EF2F0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA6EF230", Offset = "0xA6EE230", VA = "0x18A6EF230")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA719240", Offset = "0xA718240", VA = "0x18A719240", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xA718A10", Offset = "0xA717A10", VA = "0x18A718A10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA719200", Offset = "0xA718200", VA = "0x18A719200", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xA719150", Offset = "0xA718150", VA = "0x18A719150", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xA719150", Offset = "0xA718150", VA = "0x18A719150", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xA71C710", Offset = "0xA71B710", VA = "0x18A71C710", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xA7196E0", Offset = "0xA7186E0", VA = "0x18A7196E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xA71D410", Offset = "0xA71C410", VA = "0x18A71D410")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xA71C690", Offset = "0xA71B690", VA = "0x18A71C690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xA71BE90", Offset = "0xA71AE90", VA = "0x18A71BE90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xA71BE90", Offset = "0xA71AE90", VA = "0x18A71BE90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6EEB00", Offset = "0xA6EDB00", VA = "0x18A6EEB00")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEBC0", Offset = "0xA6EDBC0", VA = "0x18A6EEBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA6EECE0", Offset = "0xA6EDCE0", VA = "0x18A6EECE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEDA0", Offset = "0xA6EDDA0", VA = "0x18A6EEDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public float GlossinessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEE50", Offset = "0xA6EDE50", VA = "0x18A6EEE50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEEB0", Offset = "0xA6EDEB0", VA = "0x18A6EEEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xA6EDFE0", Offset = "0xA6ECFE0", VA = "0x18A6EDFE0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE200", Offset = "0xA6ED200", VA = "0x18A6EE200", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE4D0", Offset = "0xA6ED4D0", VA = "0x18A6EE4D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE280", Offset = "0xA6ED280", VA = "0x18A6EE280", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xA6EDD90", Offset = "0xA6ECD90", VA = "0x18A6EDD90", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA6EEF90", Offset = "0xA6EDF90", VA = "0x18A6EEF90")]
		internal MaterialPBRSpecularGlossiness(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA6EE010", Offset = "0xA6ED010", VA = "0x18A6EE010", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA6EDF50", Offset = "0xA6ECF50", VA = "0x18A6EDF50")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7189B0", Offset = "0xA7179B0", VA = "0x18A7189B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xA718310", Offset = "0xA717310", VA = "0x18A718310", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xA718970", Offset = "0xA717970", VA = "0x18A718970", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xA7188C0", Offset = "0xA7178C0", VA = "0x18A7188C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xA7188C0", Offset = "0xA7178C0", VA = "0x18A7188C0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xA71CC50", Offset = "0xA71BC50", VA = "0x18A71CC50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xA71A240", Offset = "0xA719240", VA = "0x18A71A240", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xA71D1E0", Offset = "0xA71C1E0", VA = "0x18A71D1E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xA71C390", Offset = "0xA71B390", VA = "0x18A71C390", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xA71BFD0", Offset = "0xA71AFD0", VA = "0x18A71BFD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xA71BFD0", Offset = "0xA71AFD0", VA = "0x18A71BFD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7155D0", Offset = "0xA7145D0", VA = "0x18A7155D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xA715690", Offset = "0xA714690", VA = "0x18A715690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xA7157B0", Offset = "0xA7147B0", VA = "0x18A7157B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xA7157F0", Offset = "0xA7147F0", VA = "0x18A7157F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xA714C50", Offset = "0xA713C50", VA = "0x18A714C50", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xA714E70", Offset = "0xA713E70", VA = "0x18A714E70", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA7150B0", Offset = "0xA7140B0", VA = "0x18A7150B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA714EF0", Offset = "0xA713EF0", VA = "0x18A714EF0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA714A50", Offset = "0xA713A50", VA = "0x18A714A50", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA715890", Offset = "0xA714890", VA = "0x18A715890")]
		internal MaterialSheen(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xA714C80", Offset = "0xA713C80", VA = "0x18A714C80", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xA714BC0", Offset = "0xA713BC0", VA = "0x18A714BC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xA71CD10", Offset = "0xA71BD10", VA = "0x18A71CD10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xA7192A0", Offset = "0xA7182A0", VA = "0x18A7192A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xA71D2D0", Offset = "0xA71C2D0", VA = "0x18A71D2D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xA71C410", Offset = "0xA71B410", VA = "0x18A71C410", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xA71BCB0", Offset = "0xA71ACB0", VA = "0x18A71BCB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xA71BCB0", Offset = "0xA71ACB0", VA = "0x18A71BCB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA716640", Offset = "0xA715640", VA = "0x18A716640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xA7166E0", Offset = "0xA7156E0", VA = "0x18A7166E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA716380", Offset = "0xA715380", VA = "0x18A716380", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA7163B0", Offset = "0xA7153B0", VA = "0x18A7163B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA7164A0", Offset = "0xA7154A0", VA = "0x18A7164A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA716430", Offset = "0xA715430", VA = "0x18A716430", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA7162E0", Offset = "0xA7152E0", VA = "0x18A7162E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8D40", Offset = "0xA6E7D40", VA = "0x18A6E8D40")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0xA71CDD0", Offset = "0xA71BDD0", VA = "0x18A71CDD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0xA71A7B0", Offset = "0xA7197B0", VA = "0x18A71A7B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xA71D3C0", Offset = "0xA71C3C0", VA = "0x18A71D3C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0xA71C3D0", Offset = "0xA71B3D0", VA = "0x18A71C3D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0xA71BB70", Offset = "0xA71AB70", VA = "0x18A71BB70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0xA71BB70", Offset = "0xA71AB70", VA = "0x18A71BB70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7175E0", Offset = "0xA7165E0", VA = "0x18A7175E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xA717770", Offset = "0xA716770", VA = "0x18A717770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xA7176D0", Offset = "0xA7166D0", VA = "0x18A7176D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xA717880", Offset = "0xA716880", VA = "0x18A717880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xA717680", Offset = "0xA716680", VA = "0x18A717680")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xA717820", Offset = "0xA716820", VA = "0x18A717820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public int? TextureCoordinateOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0x8C0E730", Offset = "0x8C0D730", VA = "0x188C0E730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xA717930", Offset = "0xA716930", VA = "0x18A717930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xA7172C0", Offset = "0xA7162C0", VA = "0x18A7172C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public Matrix3x2 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xA717330", Offset = "0xA716330", VA = "0x18A717330")]
			get
			{
				return default(Matrix3x2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA716990", Offset = "0xA715990", VA = "0x18A716990", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA7169C0", Offset = "0xA7159C0", VA = "0x18A7169C0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA716C70", Offset = "0xA715C70", VA = "0x18A716C70", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xA716A40", Offset = "0xA715A40", VA = "0x18A716A40", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA716820", Offset = "0xA715820", VA = "0x18A716820", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA717190", Offset = "0xA716190", VA = "0x18A717190")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xA71CB90", Offset = "0xA71BB90", VA = "0x18A71CB90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0xA71A560", Offset = "0xA719560", VA = "0x18A71A560", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0xA71D460", Offset = "0xA71C460", VA = "0x18A71D460")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xA71C6D0", Offset = "0xA71B6D0", VA = "0x18A71C6D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0xA71C1B0", Offset = "0xA71B1B0", VA = "0x18A71C1B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xA71C1B0", Offset = "0xA71B1B0", VA = "0x18A71C1B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA717CA0", Offset = "0xA716CA0", VA = "0x18A717CA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0xA717D40", Offset = "0xA716D40", VA = "0x18A717D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xA7179E0", Offset = "0xA7169E0", VA = "0x18A7179E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA717A10", Offset = "0xA716A10", VA = "0x18A717A10", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA717B00", Offset = "0xA716B00", VA = "0x18A717B00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA717A90", Offset = "0xA716A90", VA = "0x18A717A90", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xA717940", Offset = "0xA716940", VA = "0x18A717940", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8D40", Offset = "0xA6E7D40", VA = "0x18A6E8D40")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7182B0", Offset = "0xA7172B0", VA = "0x18A7182B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0xA717E80", Offset = "0xA716E80", VA = "0x18A717E80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xA718270", Offset = "0xA717270", VA = "0x18A718270", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0xA7181C0", Offset = "0xA7171C0", VA = "0x18A7181C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xA7181C0", Offset = "0xA7171C0", VA = "0x18A7181C0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xA71CE90", Offset = "0xA71BE90", VA = "0x18A71CE90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0xA719A60", Offset = "0xA718A60", VA = "0x18A719A60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0xA71D280", Offset = "0xA71C280", VA = "0x18A71D280")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xA71C610", Offset = "0xA71B610", VA = "0x18A71C610", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xA71BD50", Offset = "0xA71AD50", VA = "0x18A71BD50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0xA71BD50", Offset = "0xA71AD50", VA = "0x18A71BD50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7160A0", Offset = "0xA7150A0", VA = "0x18A7160A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0xA7160F0", Offset = "0xA7150F0", VA = "0x18A7160F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA715AF0", Offset = "0xA714AF0", VA = "0x18A715AF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xA715C10", Offset = "0xA714C10", VA = "0x18A715C10", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA715D80", Offset = "0xA714D80", VA = "0x18A715D80", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA715C90", Offset = "0xA714C90", VA = "0x18A715C90", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA715970", Offset = "0xA714970", VA = "0x18A715970", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xA7161A0", Offset = "0xA7151A0", VA = "0x18A7161A0")]
		internal MaterialTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xA715B20", Offset = "0xA714B20", VA = "0x18A715B20", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA715A60", Offset = "0xA714A60", VA = "0x18A715A60")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0xA71C950", Offset = "0xA71B950", VA = "0x18A71C950", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0xA7194F0", Offset = "0xA7184F0", VA = "0x18A7194F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xA71D190", Offset = "0xA71C190", VA = "0x18A71D190")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0xA71C590", Offset = "0xA71B590", VA = "0x18A71C590", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0xA71C2F0", Offset = "0xA71B2F0", VA = "0x18A71C2F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xA71C2F0", Offset = "0xA71B2F0", VA = "0x18A71C2F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public new const string SCHEMANAME = "KHR_materials_unlit";

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA716210", Offset = "0xA715210", VA = "0x18A716210", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA716240", Offset = "0xA715240", VA = "0x18A716240", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xA7162D0", Offset = "0xA7152D0", VA = "0x18A7162D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA7162C0", Offset = "0xA7152C0", VA = "0x18A7162C0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA716200", Offset = "0xA715200", VA = "0x18A716200", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA700A80", Offset = "0xA6FFA80", VA = "0x18A700A80")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0xA71CF50", Offset = "0xA71BF50", VA = "0x18A71CF50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0xA71AAD0", Offset = "0xA719AD0", VA = "0x18A71AAD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0xA71D4B0", Offset = "0xA71C4B0", VA = "0x18A71D4B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xA71C650", Offset = "0xA71B650", VA = "0x18A71C650", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xA71BC10", Offset = "0xA71AC10", VA = "0x18A71BC10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0xA71BC10", Offset = "0xA71AC10", VA = "0x18A71BC10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ModelRoot LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0xD15E70", Offset = "0xD14E70", VA = "0x180D15E70", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0xD16060", Offset = "0xD15060", VA = "0x180D16060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA714690", Offset = "0xA713690", VA = "0x18A714690", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA707D10", Offset = "0xA706D10", VA = "0x18A707D10", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xA714890", Offset = "0xA713890", VA = "0x18A714890", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA714770", Offset = "0xA713770", VA = "0x18A714770", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xA7145F0", Offset = "0xA7135F0", VA = "0x18A7145F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xA714860", Offset = "0xA713860", VA = "0x18A714860", Slot = "18")]
		void IChildOfList<ModelRoot>.SetLogicalParent(ModelRoot parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xA7147D0", Offset = "0xA7137D0", VA = "0x18A7147D0")]
		protected bool SharesLogicalParent(params LogicalChildOfRoot[] items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3C31020", Offset = "0x3C30020", VA = "0x183C31020")]
		public static void RenameLogicalElements<T>(IEnumerable<T> collection, string namePrefix) where T : LogicalChildOfRoot
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA7146C0", Offset = "0xA7136C0", VA = "0x18A7146C0")]
		private bool RenameIfAvailable(string newName, HashSet<string> usedNames)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA70CBA0", Offset = "0xA70BBA0", VA = "0x18A70CBA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0xA71C7D0", Offset = "0xA71B7D0", VA = "0x18A71C7D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xA71B230", Offset = "0xA71A230", VA = "0x18A71B230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0xA71D500", Offset = "0xA71C500", VA = "0x18A71D500")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xA71C490", Offset = "0xA71B490", VA = "0x18A71C490", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xA71C110", Offset = "0xA71B110", VA = "0x18A71C110", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xA71C110", Offset = "0xA71B110", VA = "0x18A71C110", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7017D0", Offset = "0xA7007D0", VA = "0x18A7017D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA701980", Offset = "0xA700980", VA = "0x18A701980", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA701B30", Offset = "0xA700B30", VA = "0x18A701B30", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA701A00", Offset = "0xA700A00", VA = "0x18A701A00", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA701690", Offset = "0xA700690", VA = "0x18A701690", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA702180", Offset = "0xA701180", VA = "0x18A702180")]
		internal AccessorSparseIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xA7021E0", Offset = "0xA7011E0", VA = "0x18A7021E0")]
		internal AccessorSparseIndices(BufferView bv, int byteOffset, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA702070", Offset = "0xA701070", VA = "0x18A702070")]
		internal IntegerArray _GetIndicesArray(ModelRoot root, int sparseCount)
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xA701800", Offset = "0xA700800", VA = "0x18A701800", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA701EF0", Offset = "0xA700EF0", VA = "0x18A701EF0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xA71CA10", Offset = "0xA71BA10", VA = "0x18A71CA10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xA719FA0", Offset = "0xA718FA0", VA = "0x18A719FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xA71D370", Offset = "0xA71C370", VA = "0x18A71D370")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xA71C510", Offset = "0xA71B510", VA = "0x18A71C510", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0xA71BAD0", Offset = "0xA71AAD0", VA = "0x18A71BAD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0xA71BAD0", Offset = "0xA71AAD0", VA = "0x18A71BAD0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA702420", Offset = "0xA701420", VA = "0x18A702420", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA7025D0", Offset = "0xA7015D0", VA = "0x18A7025D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xA702730", Offset = "0xA701730", VA = "0x18A702730", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xA702650", Offset = "0xA701650", VA = "0x18A702650", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xA702330", Offset = "0xA701330", VA = "0x18A702330", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xA702DF0", Offset = "0xA701DF0", VA = "0x18A702DF0")]
		internal AccessorSparseValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xA702CA0", Offset = "0xA701CA0", VA = "0x18A702CA0")]
		internal AccessorSparseValues(BufferView bv, int byteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xA702A40", Offset = "0xA701A40", VA = "0x18A702A40")]
		internal MemoryAccessor _GetMemoryAccessor(ModelRoot root, int sparseCount, Accessor baseAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA702450", Offset = "0xA701450", VA = "0x18A702450", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xA7029E0", Offset = "0xA7019E0", VA = "0x18A7029E0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xA71CAD0", Offset = "0xA71BAD0", VA = "0x18A71CAD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0xA71B7D0", Offset = "0xA71A7D0", VA = "0x18A71B7D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xA71D5A0", Offset = "0xA71C5A0", VA = "0x18A71D5A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0xA71C550", Offset = "0xA71B550", VA = "0x18A71C550", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xA71BF30", Offset = "0xA71AF30", VA = "0x18A71BF30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0xA71BF30", Offset = "0xA71AF30", VA = "0x18A71BF30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xA702FA0", Offset = "0xA701FA0", VA = "0x18A702FA0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xA7033E0", Offset = "0xA7023E0", VA = "0x18A7033E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xA703560", Offset = "0xA702560", VA = "0x18A703560", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xA703460", Offset = "0xA702460", VA = "0x18A703460", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA702E50", Offset = "0xA701E50", VA = "0x18A702E50", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xA700A80", Offset = "0xA6FFA80", VA = "0x18A700A80")]
		internal AccessorSparse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xA703B00", Offset = "0xA702B00", VA = "0x18A703B00")]
		internal AccessorSparse(int sparseCount, BufferView indices, int indicesOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xA703910", Offset = "0xA702910", VA = "0x18A703910")]
		internal KeyValuePair<IntegerArray, MemoryAccessor> _CreateMemoryAccessors(Accessor baseAccessor)
		{
			return default(KeyValuePair<IntegerArray, MemoryAccessor>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA703200", Offset = "0xA702200", VA = "0x18A703200", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xA702FD0", Offset = "0xA701FD0", VA = "0x18A702FD0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xA71D0D0", Offset = "0xA71C0D0", VA = "0x18A71D0D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xA71AD20", Offset = "0xA719D20", VA = "0x18A71AD20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xA71D320", Offset = "0xA71C320", VA = "0x18A71D320")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xA71C5D0", Offset = "0xA71B5D0", VA = "0x18A71C5D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xA71BDF0", Offset = "0xA71ADF0", VA = "0x18A71BDF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xA71BDF0", Offset = "0xA71ADF0", VA = "0x18A71BDF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1699E60", Offset = "0x1698E60", VA = "0x181699E60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public DimensionType Dimensions
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xA7099D0", Offset = "0xA7089D0", VA = "0x18A7099D0")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xD82430", Offset = "0xD81430", VA = "0x180D82430")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0xA70B780", Offset = "0xA70A780", VA = "0x18A70B780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xA70B860", Offset = "0xA70A860", VA = "0x18A70B860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xA70B600", Offset = "0xA70A600", VA = "0x18A70B600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public BufferView SourceBufferView
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xA70B7C0", Offset = "0xA70A7C0", VA = "0x18A70B7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public int ByteOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xA70B6B0", Offset = "0xA70A6B0", VA = "0x18A70B6B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool IsSparse
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x8870CE0", Offset = "0x886FCE0", VA = "0x188870CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public AttributeFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xA70B6F0", Offset = "0xA70A6F0", VA = "0x18A70B6F0")]
			get
			{
				return default(AttributeFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public (IReadOnlyList<double> Min, IReadOnlyList<double> Max) Bounds
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xA70B560", Offset = "0xA70A560", VA = "0x18A70B560")]
			get
			{
				return default((IReadOnlyList<double>, IReadOnlyList<double>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xA704E60", Offset = "0xA703E60", VA = "0x18A704E60", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA7053E0", Offset = "0xA7043E0", VA = "0x18A7053E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA7071B0", Offset = "0xA7061B0", VA = "0x18A7071B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xA705490", Offset = "0xA704490", VA = "0x18A705490", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xA704A70", Offset = "0xA703A70", VA = "0x18A704A70", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xA7042E0", Offset = "0xA7032E0", VA = "0x18A7042E0")]
		public IAccessorArray<Matrix3x2> AsMatrix2x2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xA7043C0", Offset = "0xA7033C0", VA = "0x18A7043C0")]
		public IAccessorArray<Matrix4x4> AsMatrix3x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xA7044A0", Offset = "0xA7034A0", VA = "0x18A7044A0")]
		public IAccessorArray<Matrix4x4> AsMatrix4x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xA704580", Offset = "0xA703580", VA = "0x18A704580")]
		public IAccessorArray<Matrix4x4> AsMatrix4x4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xA704620", Offset = "0xA703620", VA = "0x18A704620")]
		[Obsolete("Use AsMatrix4x4Array instead", true)]
		internal IReadOnlyList<Matrix4x4> AsMatrix4x4ReadOnlyList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xA704800", Offset = "0xA703800", VA = "0x18A704800")]
		public IAccessorArray<Quaternion> AsQuaternionArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xA7046C0", Offset = "0xA7036C0", VA = "0x18A7046C0")]
		public IAccessorArray<float[]> AsMultiArray(int dimensions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xA704090", Offset = "0xA703090", VA = "0x18A704090")]
		public IAccessorArray<uint> AsIndicesArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xA704050", Offset = "0xA703050", VA = "0x18A704050")]
		public IAccessorArray<uint> AsIndexArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xA704970", Offset = "0xA703970", VA = "0x18A704970")]
		public IAccessorArray<float> AsScalarArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xA7049B0", Offset = "0xA7039B0", VA = "0x18A7049B0")]
		public IAccessorArray<Vector2> AsVector2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xA7049F0", Offset = "0xA7039F0", VA = "0x18A7049F0")]
		public IAccessorArray<Vector3> AsVector3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA704A30", Offset = "0xA703A30", VA = "0x18A704A30")]
		public IAccessorArray<Vector4> AsVector4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x3380EC0", Offset = "0x337FEC0", VA = "0x183380EC0")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xA703E60", Offset = "0xA702E60", VA = "0x18A703E60")]
		public IAccessorArray<Vector4> AsColorArray(float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xA706FC0", Offset = "0xA705FC0", VA = "0x18A706FC0")]
		public ArraySegment<byte> TryGetVertexBytes(int vertexIdx)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xA7099C0", Offset = "0xA7089C0", VA = "0x18A7099C0")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xA70B430", Offset = "0xA70A430", VA = "0x18A70B430")]
		internal Accessor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xA7099D0", Offset = "0xA7089D0", VA = "0x18A7099D0")]
		private DimensionType _GetDimensions()
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xA709EF0", Offset = "0xA708EF0", VA = "0x18A709EF0")]
		internal bool _TryGetMemoryAccessor([Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xA709C40", Offset = "0xA708C40", VA = "0x18A709C40")]
		internal bool _TryGetMemoryAccessor(string name, [Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA706EF0", Offset = "0xA705EF0", VA = "0x18A706EF0")]
		public bool TryGetBufferView([Out] BufferView bv)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xA707D90", Offset = "0xA706D90", VA = "0x18A707D90")]
		public void UpdateBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA709AC0", Offset = "0xA708AC0", VA = "0x18A709AC0")]
		private void _ResetBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x3382460", Offset = "0x3381460", VA = "0x183382460")]
		private void _AppendToBounds<T>(T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA7097F0", Offset = "0xA7087F0", VA = "0x18A7097F0")]
		private void _AppendToBounds(params float[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA7057A0", Offset = "0xA7047A0", VA = "0x18A7057A0")]
		public void SetDataFrom(Accessor other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xA706D20", Offset = "0xA705D20", VA = "0x18A706D20")]
		public void SetZeros(MemoryAccessInfo accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xA706D50", Offset = "0xA705D50", VA = "0x18A706D50")]
		public void SetZeros(int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xA705A70", Offset = "0xA704A70", VA = "0x18A705A70")]
		[Obsolete("Use SetData with AttributeFormat. This will be removed soon.")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xA705B70", Offset = "0xA704B70", VA = "0x18A705B70")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xA705460", Offset = "0xA704460", VA = "0x18A705460")]
		public void RemoveSparseData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x33815F0", Offset = "0x33805F0", VA = "0x1833815F0")]
		public void CreateSparseData<T>(IReadOnlyDictionary<int, T> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA706670", Offset = "0xA705670", VA = "0x18A706670")]
		public void SetSparseData(MemoryAccessor sparseIndices, MemoryAccessor sparseValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7062A0", Offset = "0xA7052A0", VA = "0x18A7062A0")]
		public void SetSparseData(int sparseCount, BufferView indices, int indicesByteOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesByteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA705E10", Offset = "0xA704E10", VA = "0x18A705E10")]
		public void SetIndexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xA706120", Offset = "0xA705120", VA = "0x18A706120")]
		public void SetIndexData(BufferView buffer, int bufferByteOffset, int itemCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xA7069A0", Offset = "0xA7059A0", VA = "0x18A7069A0")]
		public void SetVertexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xA7068A0", Offset = "0xA7058A0", VA = "0x18A7068A0")]
		[Obsolete("Use SetVertexData with AttributeFormat. This will be removed soon.")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions = DimensionType.VEC3, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xA706BB0", Offset = "0xA705BB0", VA = "0x18A706BB0")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7052A0", Offset = "0xA7042A0", VA = "0x18A7052A0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xA704E90", Offset = "0xA703E90", VA = "0x18A704E90", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xA708450", Offset = "0xA707450", VA = "0x18A708450")]
		internal void ValidateIndices(ValidationContext validate, uint vertexCount, PrimitiveType drawingType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xA708D80", Offset = "0xA707D80", VA = "0x18A708D80")]
		internal static void ValidateVertexAttributes(ValidationContext validate, IReadOnlyDictionary<string, Accessor> attributes, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xA70A830", Offset = "0xA709830", VA = "0x18A70A830")]
		private void _ValidatePositions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xA70A4D0", Offset = "0xA7094D0", VA = "0x18A70A4D0")]
		private void _ValidateNormals(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xA70AB50", Offset = "0xA709B50", VA = "0x18A70AB50")]
		private void _ValidateTangents(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xA70A1B0", Offset = "0xA7091B0", VA = "0x18A70A1B0")]
		private void _ValidateJoints(ValidationContext validate, string attributeName, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xA70AFC0", Offset = "0xA709FC0", VA = "0x18A70AFC0")]
		private static void _ValidateWeights(ValidationContext validate, Accessor weights0, Accessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xA70B170", Offset = "0xA70A170", VA = "0x18A70B170")]
		private void _ValidateWeights(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xA708800", Offset = "0xA707800", VA = "0x18A708800")]
		internal void ValidateMatrices4x3(ValidationContext validate, bool mustInvert = true, bool mustDecompose = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xA7081E0", Offset = "0xA7071E0", VA = "0x18A7081E0")]
		internal void ValidateAnimationInput(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xA708300", Offset = "0xA707300", VA = "0x18A708300")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xA71D010", Offset = "0xA71C010", VA = "0x18A71D010", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xA719D00", Offset = "0xA718D00", VA = "0x18A719D00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xA71D550", Offset = "0xA71C550", VA = "0x18A71D550")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xA71C4D0", Offset = "0xA71B4D0", VA = "0x18A71C4D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA71C250", Offset = "0xA71B250", VA = "0x18A71C250", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA71C250", Offset = "0xA71B250", VA = "0x18A71C250", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CA80", Offset = "0xD0BA80", VA = "0x180D0CA80")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA70BBB0", Offset = "0xA70ABB0", VA = "0x18A70BBB0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xA70BCC0", Offset = "0xA70ACC0", VA = "0x18A70BCC0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xA70BE10", Offset = "0xA70AE10", VA = "0x18A70BE10", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xA70BD40", Offset = "0xA70AD40", VA = "0x18A70BD40", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xA70B8A0", Offset = "0xA70A8A0", VA = "0x18A70B8A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xA700A80", Offset = "0xA6FFA80", VA = "0x18A700A80")]
		internal AnimationChannelTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA70C0C0", Offset = "0xA70B0C0", VA = "0x18A70C0C0")]
		internal AnimationChannelTarget(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA70C150", Offset = "0xA70B150", VA = "0x18A70C150")]
		internal AnimationChannelTarget(string pointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0", Slot = "17")]
		void IChildOf<AnimationChannel>.SetLogicalParent(AnimationChannel parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA70B990", Offset = "0xA70A990", VA = "0x18A70B990")]
		public int GetNodeIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA70BA40", Offset = "0xA70AA40", VA = "0x18A70BA40")]
		public PropertyPath GetNodePath()
		{
			return default(PropertyPath);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA70BAB0", Offset = "0xA70AAB0", VA = "0x18A70BAB0")]
		public string GetPointerPath()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA70BBE0", Offset = "0xA70ABE0", VA = "0x18A70BBE0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xA71C890", Offset = "0xA71B890", VA = "0x18A71C890", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0xA71B530", Offset = "0xA71A530", VA = "0x18A71B530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0xA71D230", Offset = "0xA71C230", VA = "0x18A71D230")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0xA71C450", Offset = "0xA71B450", VA = "0x18A71C450", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0xA71C070", Offset = "0xA71B070", VA = "0x18A71C070", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xA71C070", Offset = "0xA71B070", VA = "0x18A71C070", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD15E70", Offset = "0xD14E70", VA = "0x180D15E70", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xD16060", Offset = "0xD15060", VA = "0x180D16060")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xD0F5E0", Offset = "0xD0E5E0", VA = "0x180D0F5E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public string TargetPointerPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0xA70CFE0", Offset = "0xA70BFE0", VA = "0x18A70CFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public Node TargetNode
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0xA70CE60", Offset = "0xA70BE60", VA = "0x18A70CE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public PropertyPath TargetNodePath
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xA70CDE0", Offset = "0xA70BDE0", VA = "0x18A70CDE0")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA70C3E0", Offset = "0xA70B3E0", VA = "0x18A70C3E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xA70C550", Offset = "0xA70B550", VA = "0x18A70C550", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA70C7A0", Offset = "0xA70B7A0", VA = "0x18A70C7A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xA70C5D0", Offset = "0xA70B5D0", VA = "0x18A70C5D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA70C260", Offset = "0xA70B260", VA = "0x18A70C260", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA70CBA0", Offset = "0xA70BBA0", VA = "0x18A70CBA0")]
		internal AnimationChannel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xA70CC90", Offset = "0xA70BC90", VA = "0x18A70CC90")]
		internal AnimationChannel(string pointerPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xA70CBB0", Offset = "0xA70BBB0", VA = "0x18A70CBB0")]
		internal AnimationChannel(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xA70C690", Offset = "0xA70B690", VA = "0x18A70C690")]
		internal void SetSampler(AnimationSampler sampler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xA70C770", Offset = "0xA70B770", VA = "0x18A70C770", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xA70CB10", Offset = "0xA70BB10", VA = "0x18A70CB10")]
		private void _SetChannelTarget(AnimationChannelTarget target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x33A3B80", Offset = "0x33A2B80", VA = "0x1833A3B80")]
		public IAnimationSampler<T> GetSamplerOrNull<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA70CA50", Offset = "0xA70BA50", VA = "0x18A70CA50")]
		internal AnimationSampler _GetSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xA70C3B0", Offset = "0xA70B3B0", VA = "0x18A70C3B0")]
		public IAnimationSampler<Vector3> GetScaleSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA70C380", Offset = "0xA70B380", VA = "0x18A70C380")]
		public IAnimationSampler<Quaternion> GetRotationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA70C410", Offset = "0xA70B410", VA = "0x18A70C410")]
		public IAnimationSampler<Vector3> GetTranslationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA70C350", Offset = "0xA70B350", VA = "0x18A70C350")]
		public IAnimationSampler<SparseWeight8> GetSparseMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA70C350", Offset = "0xA70B350", VA = "0x18A70C350")]
		public IAnimationSampler<float[]> GetMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xA70C440", Offset = "0xA70B440", VA = "0x18A70C440", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xA734BC0", Offset = "0xA733BC0", VA = "0x18A734BC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0xA7321C0", Offset = "0xA7311C0", VA = "0x18A7321C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0xA735390", Offset = "0xA734390", VA = "0x18A735390")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xA734700", Offset = "0xA733700", VA = "0x18A734700", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0xA7345A0", Offset = "0xA7335A0", VA = "0x18A7345A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0xA7345A0", Offset = "0xA7335A0", VA = "0x18A7345A0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x12D4C00", Offset = "0x12D3C00", VA = "0x1812D4C00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x65B57B0", Offset = "0x65B47B0", VA = "0x1865B57B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x13D5FF0", Offset = "0x13D4FF0", VA = "0x1813D5FF0")]
			[DebuggerHidden]
			public <_GroupByTangentValueTangent>d__84(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x72BFA60", Offset = "0x72BEA60", VA = "0x1872BFA60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x72BF270", Offset = "0x72BE270", VA = "0x1872BF270", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x72BFB90", Offset = "0x72BEB90", VA = "0x1872BFB90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x6ABD820", Offset = "0x6ABC820", VA = "0x186ABD820", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(T, T, T)> IEnumerable<(T, T, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x72BF6E0", Offset = "0x72BE6E0", VA = "0x1872BF6E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xD3A1E0", Offset = "0xD391E0", VA = "0x180D3A1E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xE04F50", Offset = "0xE03F50", VA = "0x180E04F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public AnimationInterpolationMode InterpolationMode
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0xA714500", Offset = "0xA713500", VA = "0x18A714500", Slot = "51")]
			get
			{
				return default(AnimationInterpolationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0xA7145A0", Offset = "0xA7135A0", VA = "0x18A7145A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public Accessor Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xA7144A0", Offset = "0xA7134A0", VA = "0x18A7144A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public Accessor Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xA714540", Offset = "0xA713540", VA = "0x18A714540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0xA714390", Offset = "0xA713390", VA = "0x18A714390")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xA70D240", Offset = "0xA70C240", VA = "0x18A70D240", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xA70D960", Offset = "0xA70C960", VA = "0x18A70D960", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA712B70", Offset = "0xA711B70", VA = "0x18A712B70", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xA70D9E0", Offset = "0xA70C9E0", VA = "0x18A70D9E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA70D0F0", Offset = "0xA70C0F0", VA = "0x18A70D0F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA714290", Offset = "0xA713290", VA = "0x18A714290")]
		internal AnimationSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xA714300", Offset = "0xA713300", VA = "0x18A714300")]
		internal AnimationSampler(AnimationInterpolationMode interpolation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xA70EC40", Offset = "0xA70DC40", VA = "0x18A70EC40", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xA712EF0", Offset = "0xA711EF0", VA = "0x18A712EF0")]
		private Accessor _CreateInputAccessor(IReadOnlyList<float> input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xA713140", Offset = "0xA712140", VA = "0x18A713140")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<bool> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xA713370", Offset = "0xA712370", VA = "0x18A713370")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xA713810", Offset = "0xA712810", VA = "0x18A713810")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector2> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xA713A60", Offset = "0xA712A60", VA = "0x18A713A60")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector3> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xA7135C0", Offset = "0xA7125C0", VA = "0x18A7135C0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector4> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xA713F50", Offset = "0xA712F50", VA = "0x18A713F50")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Quaternion> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xA714180", Offset = "0xA713180", VA = "0x18A714180")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<SparseWeight8> output, int itemsStride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x33A4990", Offset = "0x33A3990", VA = "0x1833A4990")]
		private Accessor _CreateOutputAccessor<T>(IReadOnlyList<T> output, int itemsStride) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xA713CB0", Offset = "0xA712CB0", VA = "0x18A713CB0")]
		private Accessor _CreateOutputAccessor(int itemCount, int itemsStride, Func<int, int, float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x33A5380", Offset = "0x33A4380", VA = "0x1833A5380")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, TValue> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x33A4F80", Offset = "0x33A3F80", VA = "0x1833A4F80")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, (TValue TangentIn, TValue Value, TValue TangentOut)> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xA70E730", Offset = "0xA70D730", VA = "0x18A70E730")]
		internal void SetKeys(IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA70E630", Offset = "0xA70D630", VA = "0x18A70E630")]
		internal void SetKeys(IReadOnlyDictionary<float, float> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xA70EA40", Offset = "0xA70DA40", VA = "0x18A70EA40")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector2> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA70EB40", Offset = "0xA70DB40", VA = "0x18A70EB40")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector3> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xA70E530", Offset = "0xA70D530", VA = "0x18A70E530")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector4> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xA70E940", Offset = "0xA70D940", VA = "0x18A70E940")]
		internal void SetKeys(IReadOnlyDictionary<float, Quaternion> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x33A4140", Offset = "0x33A3140", VA = "0x1833A4140")]
		internal void SetKeys<TWeights>(IReadOnlyDictionary<float, TWeights> keyframes, int itemsStride) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA70E830", Offset = "0xA70D830", VA = "0x18A70E830")]
		internal void SetKeys(IReadOnlyDictionary<float, SparseWeight8> keyframes, int itemsStride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA70E190", Offset = "0xA70D190", VA = "0x18A70E190")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (float TangentIn, float Value, float TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xA70E340", Offset = "0xA70D340", VA = "0x18A70E340")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector2 TangentIn, Vector2 Value, Vector2 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA70DCF0", Offset = "0xA70CCF0", VA = "0x18A70DCF0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xA70DB10", Offset = "0xA70CB10", VA = "0x18A70DB10")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector4 TangentIn, Vector4 Value, Vector4 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA70E060", Offset = "0xA70D060", VA = "0x18A70E060")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x33A3D70", Offset = "0x33A2D70", VA = "0x1833A3D70")]
		internal void SetCubicKeys<TWeights>(IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int expandedCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xA70DED0", Offset = "0xA70CED0", VA = "0x18A70DED0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int expandedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xA70FE00", Offset = "0xA70EE00", VA = "0x18A70FE00", Slot = "20")]
		IEnumerable<(float, bool)> IAnimationSampler<bool>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA712060", Offset = "0xA711060", VA = "0x18A712060", Slot = "24")]
		IEnumerable<(float, float)> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA710BC0", Offset = "0xA70FBC0", VA = "0x18A710BC0", Slot = "28")]
		IEnumerable<(float, Vector2)> IAnimationSampler<Vector2>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA7112A0", Offset = "0xA7102A0", VA = "0x18A7112A0", Slot = "32")]
		IEnumerable<(float, Vector3)> IAnimationSampler<Vector3>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA711980", Offset = "0xA710980", VA = "0x18A711980", Slot = "36")]
		IEnumerable<(float, Vector4)> IAnimationSampler<Vector4>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA710500", Offset = "0xA70F500", VA = "0x18A710500", Slot = "40")]
		IEnumerable<(float, Quaternion)> IAnimationSampler<Quaternion>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA70F130", Offset = "0xA70E130", VA = "0x18A70F130", Slot = "44")]
		IEnumerable<(float, SparseWeight8)> IAnimationSampler<SparseWeight8>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA70F970", Offset = "0xA70E970", VA = "0x18A70F970", Slot = "48")]
		IEnumerable<(float, ArraySegment<float>)> IAnimationSampler<ArraySegment<float>>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xA7127F0", Offset = "0xA7117F0", VA = "0x18A7127F0", Slot = "52")]
		IEnumerable<(float, float[])> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA70FDC0", Offset = "0xA70EDC0", VA = "0x18A70FDC0", Slot = "21")]
		IEnumerable<(float, (bool, bool, bool))> IAnimationSampler<bool>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xA711D70", Offset = "0xA710D70", VA = "0x18A711D70", Slot = "25")]
		IEnumerable<(float, (float, float, float))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA7108D0", Offset = "0xA70F8D0", VA = "0x18A7108D0", Slot = "29")]
		IEnumerable<(float, (Vector2, Vector2, Vector2))> IAnimationSampler<Vector2>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xA710FB0", Offset = "0xA70FFB0", VA = "0x18A710FB0", Slot = "33")]
		IEnumerable<(float, (Vector3, Vector3, Vector3))> IAnimationSampler<Vector3>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA711690", Offset = "0xA710690", VA = "0x18A711690", Slot = "37")]
		IEnumerable<(float, (Vector4, Vector4, Vector4))> IAnimationSampler<Vector4>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xA710230", Offset = "0xA70F230", VA = "0x18A710230", Slot = "41")]
		IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> IAnimationSampler<Quaternion>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA712450", Offset = "0xA711450", VA = "0x18A712450", Slot = "53")]
		IEnumerable<(float, (float[], float[], float[]))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA70F5D0", Offset = "0xA70E5D0", VA = "0x18A70F5D0", Slot = "49")]
		IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> IAnimationSampler<ArraySegment<float>>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xA70ED90", Offset = "0xA70DD90", VA = "0x18A70ED90", Slot = "45")]
		IEnumerable<(float, (SparseWeight8, SparseWeight8, SparseWeight8))> IAnimationSampler<SparseWeight8>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xA70FCF0", Offset = "0xA70ECF0", VA = "0x18A70FCF0", Slot = "22")]
		ICurveSampler<bool> IAnimationSampler<bool>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA711C50", Offset = "0xA710C50", VA = "0x18A711C50", Slot = "26")]
		ICurveSampler<float> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA7107B0", Offset = "0xA70F7B0", VA = "0x18A7107B0", Slot = "30")]
		ICurveSampler<Vector2> IAnimationSampler<Vector2>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA710E90", Offset = "0xA70FE90", VA = "0x18A710E90", Slot = "34")]
		ICurveSampler<Vector3> IAnimationSampler<Vector3>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xA711570", Offset = "0xA710570", VA = "0x18A711570", Slot = "38")]
		ICurveSampler<Vector4> IAnimationSampler<Vector4>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xA710110", Offset = "0xA70F110", VA = "0x18A710110", Slot = "42")]
		ICurveSampler<Quaternion> IAnimationSampler<Quaternion>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xA70EC70", Offset = "0xA70DC70", VA = "0x18A70EC70", Slot = "46")]
		ICurveSampler<SparseWeight8> IAnimationSampler<SparseWeight8>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xA712330", Offset = "0xA711330", VA = "0x18A712330", Slot = "54")]
		ICurveSampler<float[]> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xA70F4B0", Offset = "0xA70E4B0", VA = "0x18A70F4B0", Slot = "50")]
		ICurveSampler<ArraySegment<float>> IAnimationSampler<ArraySegment<float>>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x33A4D40", Offset = "0x33A3D40", VA = "0x1833A4D40")]
		[IteratorStateMachine(typeof(<_GroupByTangentValueTangent>d__84<>))]
		private static IEnumerable<(T, T, T)> _GroupByTangentValueTangent<T>(IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xA70D7A0", Offset = "0xA70C7A0", VA = "0x18A70D7A0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xA70D270", Offset = "0xA70C270", VA = "0x18A70D270", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xA734F80", Offset = "0xA733F80", VA = "0x18A734F80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0xA7327E0", Offset = "0xA7317E0", VA = "0x18A7327E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xA7355C0", Offset = "0xA7345C0", VA = "0x18A7355C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0xA734640", Offset = "0xA733640", VA = "0x18A734640", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0xA734140", Offset = "0xA733140", VA = "0x18A734140", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xA734140", Offset = "0xA733140", VA = "0x18A734140", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public IReadOnlyList<AnimationChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0xA720920", Offset = "0xA71F920", VA = "0x18A720920")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA71FD90", Offset = "0xA71ED90", VA = "0x18A71FD90", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xA71FF10", Offset = "0xA71EF10", VA = "0x18A71FF10", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xA7200A0", Offset = "0xA71F0A0", VA = "0x18A7200A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xA71FF90", Offset = "0xA71EF90", VA = "0x18A71FF90", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xA71F8E0", Offset = "0xA71E8E0", VA = "0x18A71F8E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xA720850", Offset = "0xA71F850", VA = "0x18A720850")]
		internal Animation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA71FB40", Offset = "0xA71EB40", VA = "0x18A71FB40")]
		public IEnumerable<AnimationChannel> FindChannels(string rootPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA71F9D0", Offset = "0xA71E9D0", VA = "0x18A71F9D0")]
		public IEnumerable<AnimationChannel> FindChannels(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA71FD70", Offset = "0xA71ED70", VA = "0x18A71FD70")]
		public AnimationChannel FindScaleChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA71FD60", Offset = "0xA71ED60", VA = "0x18A71FD60")]
		public AnimationChannel FindRotationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA71FD80", Offset = "0xA71ED80", VA = "0x18A71FD80")]
		public AnimationChannel FindTranslationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA71FD50", Offset = "0xA71ED50", VA = "0x18A71FD50")]
		public AnimationChannel FindMorphChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA7203C0", Offset = "0xA71F3C0", VA = "0x18A7203C0")]
		private AnimationChannel _FindChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA720330", Offset = "0xA71F330", VA = "0x18A720330")]
		private AnimationSampler _CreateSampler(AnimationInterpolationMode interpolation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA720670", Offset = "0xA71F670", VA = "0x18A720670")]
		private AnimationChannel _UseChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA7205E0", Offset = "0xA71F5E0", VA = "0x18A7205E0")]
		private AnimationChannel _UseChannel(string pointerPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x33A56C0", Offset = "0x33A46C0", VA = "0x1833A56C0")]
		public void CreateMaterialPropertyChannel<T>(Material material, string propertyName, IReadOnlyDictionary<float, T> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x33A6390", Offset = "0x33A5390", VA = "0x1833A6390")]
		public void DangerousCreatePointerChannel<T>(string pointerPath, IReadOnlyDictionary<float, T> keyframes, bool linear = true, bool verifyBackingFieldExists = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xA71F250", Offset = "0xA71E250", VA = "0x18A71F250")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA71F0E0", Offset = "0xA71E0E0", VA = "0x18A71F0E0")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA71EDF0", Offset = "0xA71DDF0", VA = "0x18A71EDF0")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, Quaternion> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xA71EF70", Offset = "0xA71DF70", VA = "0x18A71EF70")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA71F3D0", Offset = "0xA71E3D0", VA = "0x18A71F3D0")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xA71F550", Offset = "0xA71E550", VA = "0x18A71F550")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x33A5AE0", Offset = "0x33A4AE0", VA = "0x1833A5AE0")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, TWeights> keyframes, int morphCount, bool linear = true) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x33A5860", Offset = "0x33A4860", VA = "0x1833A5860")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int morphCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA71EC70", Offset = "0xA71DC70", VA = "0x18A71EC70")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, SparseWeight8> keyframes, int morphCount, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xA71EAF0", Offset = "0xA71DAF0", VA = "0x18A71EAF0")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int morphCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xA71F6C0", Offset = "0xA71E6C0", VA = "0x18A71F6C0")]
		public void CreateVisibilityChannel(Node node, IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xA71FDF0", Offset = "0xA71EDF0", VA = "0x18A71FDF0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xA71FDC0", Offset = "0xA71EDC0", VA = "0x18A71FDC0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0xA734EC0", Offset = "0xA733EC0", VA = "0x18A734EC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0xA732D20", Offset = "0xA731D20", VA = "0x18A732D20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0xA735660", Offset = "0xA734660", VA = "0x18A735660")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0xA7346C0", Offset = "0xA7336C0", VA = "0x18A7346C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xA734320", Offset = "0xA733320", VA = "0x18A734320", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xA734320", Offset = "0xA733320", VA = "0x18A734320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xD0F420", Offset = "0xD0E420", VA = "0x180D0F420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public static string AssemblyInformationalVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xA7216F0", Offset = "0xA7206F0", VA = "0x18A7216F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public string Copyright
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0xA7218E0", Offset = "0xA7208E0", VA = "0x18A7218E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public string Generator
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xA721910", Offset = "0xA720910", VA = "0x18A721910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Version Version
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0xA721860", Offset = "0xA720860", VA = "0x18A721860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Version MinVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xA7217E0", Offset = "0xA7207E0", VA = "0x18A7217E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA720D80", Offset = "0xA71FD80", VA = "0x18A720D80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA720FB0", Offset = "0xA71FFB0", VA = "0x18A720FB0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA7210F0", Offset = "0xA7200F0", VA = "0x18A7210F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xA721030", Offset = "0xA720030", VA = "0x18A721030", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA720C60", Offset = "0xA71FC60", VA = "0x18A720C60", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA700A80", Offset = "0xA6FFA80", VA = "0x18A700A80")]
		internal Asset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xA720A40", Offset = "0xA71FA40", VA = "0x18A720A40")]
		internal static Asset CreateDefault(string copyright)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xD0F420", Offset = "0xD0E420", VA = "0x180D0F420", Slot = "17")]
		void IChildOf<ModelRoot>.SetLogicalParent(ModelRoot parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA720DB0", Offset = "0xA71FDB0", VA = "0x18A720DB0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0xA734E00", Offset = "0xA733E00", VA = "0x18A734E00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xA733800", Offset = "0xA732800", VA = "0x18A733800", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xA735570", Offset = "0xA734570", VA = "0x18A735570")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xA734880", Offset = "0xA733880", VA = "0x18A734880", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xA7340A0", Offset = "0xA7330A0", VA = "0x18A7340A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0xA7340A0", Offset = "0xA7330A0", VA = "0x18A7340A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA723F80", Offset = "0xA722F80", VA = "0x18A723F80", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA7243B0", Offset = "0xA7233B0", VA = "0x18A7243B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA7244E0", Offset = "0xA7234E0", VA = "0x18A7244E0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xA724430", Offset = "0xA723430", VA = "0x18A724430", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xA723E90", Offset = "0xA722E90", VA = "0x18A723E90", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xA724C80", Offset = "0xA723C80", VA = "0x18A724C80")]
		internal Buffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xA724C90", Offset = "0xA723C90", VA = "0x18A724C90")]
		internal Buffer(byte[] content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0xA7249C0", Offset = "0xA7239C0", VA = "0x18A7249C0")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xA724840", Offset = "0xA723840", VA = "0x18A724840")]
		private static byte[] _LoadBinaryBufferUnchecked(string uri, ReadContext context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xA724BB0", Offset = "0xA723BB0", VA = "0x18A724BB0")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xA724B70", Offset = "0xA723B70", VA = "0x18A724B70")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xA724790", Offset = "0xA723790", VA = "0x18A724790")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xA7247C0", Offset = "0xA7237C0", VA = "0x18A7247C0")]
		internal void _IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xA723FB0", Offset = "0xA722FB0", VA = "0x18A723FB0")]
		internal void OnValidateBinaryChunk(ValidationContext validate, byte[] binaryChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xA724300", Offset = "0xA723300", VA = "0x18A724300", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xA7241D0", Offset = "0xA7231D0", VA = "0x18A7241D0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA734980", Offset = "0xA733980", VA = "0x18A734980", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0xA7316D0", Offset = "0xA7306D0", VA = "0x18A7316D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA735480", Offset = "0xA734480", VA = "0x18A735480")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA734840", Offset = "0xA733840", VA = "0x18A734840", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0xA7343C0", Offset = "0xA7333C0", VA = "0x18A7343C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0xA7343C0", Offset = "0xA7333C0", VA = "0x18A7343C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA723E50", Offset = "0xA722E50", VA = "0x18A723E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public bool IsIndexBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0xA723E10", Offset = "0xA722E10", VA = "0x18A723E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public bool IsDataBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA723DD0", Offset = "0xA722DD0", VA = "0x18A723DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xA723CC0", Offset = "0xA722CC0", VA = "0x18A723CC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public ArraySegment<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA723D00", Offset = "0xA722D00", VA = "0x18A723D00")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		internal int LogicalBufferIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0xD3A1E0", Offset = "0xD391E0", VA = "0x180D3A1E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA721EF0", Offset = "0xA720EF0", VA = "0x18A721EF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA722750", Offset = "0xA721750", VA = "0x18A722750", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA722950", Offset = "0xA721950", VA = "0x18A722950", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA7227D0", Offset = "0xA7217D0", VA = "0x18A7227D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xA721AE0", Offset = "0xA720AE0", VA = "0x18A721AE0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA723770", Offset = "0xA722770", VA = "0x18A723770")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA723C60", Offset = "0xA722C60", VA = "0x18A723C60")]
		internal BufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA7238B0", Offset = "0xA7228B0", VA = "0x18A7238B0")]
		internal BufferView(Buffer buffer, int byteOffset, int? byteLength, int byteStride, BufferMode? target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xA721D70", Offset = "0xA720D70", VA = "0x18A721D70")]
		public IEnumerable<Image> FindImages()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0xA721CA0", Offset = "0xA720CA0", VA = "0x18A721CA0")]
		public IEnumerable<Accessor> FindAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA723780", Offset = "0xA722780", VA = "0x18A723780")]
		internal void _IsolateBufferMemory(_StaticBufferBuilder targetBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA721F20", Offset = "0xA720F20", VA = "0x18A721F20")]
		public bool IsInterleaved(IEnumerable<Accessor> accessors)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xA721940", Offset = "0xA720940", VA = "0x18A721940")]
		internal static bool AreEqual(BufferView bv, ArraySegment<byte> content, int byteStride, BufferMode? target)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA721E40", Offset = "0xA720E40", VA = "0x18A721E40")]
		internal static int GetAccessorByteLength([In] AttributeFormat fmt, int count, BufferView bv)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA723190", Offset = "0xA722190", VA = "0x18A723190")]
		internal static void VerifyAccess(ValidationContext validate, BufferView bv, int accessorByteOffset, AttributeFormat format, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xA722390", Offset = "0xA721390", VA = "0x18A722390", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xA7221C0", Offset = "0xA7211C0", VA = "0x18A7221C0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA722F30", Offset = "0xA721F30", VA = "0x18A722F30")]
		internal void ValidateBufferUsageGPU(ValidationContext validate, BufferMode usingMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA723030", Offset = "0xA722030", VA = "0x18A723030")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA734D40", Offset = "0xA733D40", VA = "0x18A734D40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xA7324C0", Offset = "0xA7314C0", VA = "0x18A7324C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xA7356B0", Offset = "0xA7346B0", VA = "0x18A7356B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xA734780", Offset = "0xA733780", VA = "0x18A734780", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xA733EC0", Offset = "0xA732EC0", VA = "0x18A733EC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xA733EC0", Offset = "0xA732EC0", VA = "0x18A733EC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool IsOrthographic
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public float XMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xA725890", Offset = "0xA724890", VA = "0x18A725890")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public float YMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xA7258A0", Offset = "0xA7248A0", VA = "0x18A7258A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xA7258C0", Offset = "0xA7248C0", VA = "0x18A7258C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xA7258B0", Offset = "0xA7248B0", VA = "0x18A7258B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xA725820", Offset = "0xA724820", VA = "0x18A725820", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xA724DF0", Offset = "0xA723DF0", VA = "0x18A724DF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA724ED0", Offset = "0xA723ED0", VA = "0x18A724ED0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA725110", Offset = "0xA724110", VA = "0x18A725110", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xA724F50", Offset = "0xA723F50", VA = "0x18A724F50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xA724CD0", Offset = "0xA723CD0", VA = "0x18A724CD0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA700A80", Offset = "0xA6FFA80", VA = "0x18A700A80")]
		internal CameraOrthographic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA7257A0", Offset = "0xA7247A0", VA = "0x18A7257A0")]
		internal CameraOrthographic(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA725630", Offset = "0xA724630", VA = "0x18A725630")]
		public static void VerifyParameters(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA724E20", Offset = "0xA723E20", VA = "0x18A724E20", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xA734B00", Offset = "0xA733B00", VA = "0x18A734B00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xA733290", Offset = "0xA732290", VA = "0x18A733290", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xA7354D0", Offset = "0xA7344D0", VA = "0x18A7354D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xA734740", Offset = "0xA733740", VA = "0x18A734740", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xA734000", Offset = "0xA733000", VA = "0x18A734000", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0xA734000", Offset = "0xA733000", VA = "0x18A734000", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public bool IsPerspective
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public float? AspectRatio
		{
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xA7264E0", Offset = "0xA7254E0", VA = "0x18A7264E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public float VerticalFOV
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xA7258B0", Offset = "0xA7248B0", VA = "0x18A7258B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x9DDAD70", Offset = "0x9DD9D70", VA = "0x189DDAD70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xA7266A0", Offset = "0xA7256A0", VA = "0x18A7266A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0xA726570", Offset = "0xA725570", VA = "0x18A726570", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA725A10", Offset = "0xA724A10", VA = "0x18A725A10", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA725AF0", Offset = "0xA724AF0", VA = "0x18A725AF0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA725D00", Offset = "0xA724D00", VA = "0x18A725D00", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA725B70", Offset = "0xA724B70", VA = "0x18A725B70", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA7258D0", Offset = "0xA7248D0", VA = "0x18A7258D0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA700A80", Offset = "0xA6FFA80", VA = "0x18A700A80")]
		internal CameraPerspective()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA726390", Offset = "0xA725390", VA = "0x18A726390")]
		internal CameraPerspective(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xA726230", Offset = "0xA725230", VA = "0x18A726230")]
		public static void VerifyParameters(float? aspectRatio, float yfov, float znear, float zfar = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA725A40", Offset = "0xA724A40", VA = "0x18A725A40", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0xA7351C0", Offset = "0xA7341C0", VA = "0x18A7351C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xA731A50", Offset = "0xA730A50", VA = "0x18A731A50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xA735340", Offset = "0xA734340", VA = "0x18A735340")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xA7347C0", Offset = "0xA7337C0", VA = "0x18A7347C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0xA733E20", Offset = "0xA732E20", VA = "0x18A733E20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xA733E20", Offset = "0xA732E20", VA = "0x18A733E20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA727390", Offset = "0xA726390", VA = "0x18A727390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0xA7272A0", Offset = "0xA7262A0", VA = "0x18A7272A0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA7268D0", Offset = "0xA7258D0", VA = "0x18A7268D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA726AA0", Offset = "0xA725AA0", VA = "0x18A726AA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA726EF0", Offset = "0xA725EF0", VA = "0x18A726EF0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA726B20", Offset = "0xA725B20", VA = "0x18A726B20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA726700", Offset = "0xA725700", VA = "0x18A726700", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA724C80", Offset = "0xA723C80", VA = "0x18A724C80")]
		internal Camera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA726840", Offset = "0xA725840", VA = "0x18A726840")]
		internal ICamera GetCamera()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA726C30", Offset = "0xA725C30", VA = "0x18A726C30")]
		public void SetOrthographicMode(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xA726D30", Offset = "0xA725D30", VA = "0x18A726D30")]
		public void SetPerspectiveMode(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xA726900", Offset = "0xA725900", VA = "0x18A726900", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0xA734C80", Offset = "0xA733C80", VA = "0x18A734C80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xA732A80", Offset = "0xA731A80", VA = "0x18A732A80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0xA735700", Offset = "0xA734700", VA = "0x18A735700")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xA734680", Offset = "0xA733680", VA = "0x18A734680", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xA734460", Offset = "0xA733460", VA = "0x18A734460", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0xA734460", Offset = "0xA733460", VA = "0x18A734460", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public int LogicalTextureIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0xD60B30", Offset = "0xD5FB30", VA = "0x180D60B30")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA730DD0", Offset = "0xA72FDD0", VA = "0x18A730DD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0xA730E50", Offset = "0xA72FE50", VA = "0x18A730E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public TextureTransform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA730E10", Offset = "0xA72FE10", VA = "0x18A730E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA730710", Offset = "0xA72F710", VA = "0x18A730710", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA730850", Offset = "0xA72F850", VA = "0x18A730850", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA730AC0", Offset = "0xA72FAC0", VA = "0x18A730AC0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA7308D0", Offset = "0xA72F8D0", VA = "0x18A7308D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA730620", Offset = "0xA72F620", VA = "0x18A730620", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA730D70", Offset = "0xA72FD70", VA = "0x18A730D70")]
		public TextureInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA7309B0", Offset = "0xA72F9B0", VA = "0x18A7309B0")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA730740", Offset = "0xA72F740", VA = "0x18A730740", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA731670", Offset = "0xA730670", VA = "0x18A731670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <GetChannels>d__32(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA730EB0", Offset = "0xA72FEB0", VA = "0x18A730EB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA731630", Offset = "0xA730630", VA = "0x18A731630", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA731580", Offset = "0xA730580", VA = "0x18A731580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA731580", Offset = "0xA730580", VA = "0x18A731580", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xA735040", Offset = "0xA734040", VA = "0x18A735040", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xA733AA0", Offset = "0xA732AA0", VA = "0x18A733AA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xA735430", Offset = "0xA734430", VA = "0x18A735430")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0xA734900", Offset = "0xA733900", VA = "0x18A734900", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0xA734280", Offset = "0xA733280", VA = "0x18A734280", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0xA734280", Offset = "0xA733280", VA = "0x18A734280", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09750", Offset = "0xD08750", VA = "0x180D09750", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xA728BA0", Offset = "0xA727BA0", VA = "0x18A728BA0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0xA728C60", Offset = "0xA727C60", VA = "0x18A728C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public float MetallicFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA728DD0", Offset = "0xA727DD0", VA = "0x18A728DD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0xA728E30", Offset = "0xA727E30", VA = "0x18A728E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA728EA0", Offset = "0xA727EA0", VA = "0x18A728EA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0xA728F00", Offset = "0xA727F00", VA = "0x18A728F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA728020", Offset = "0xA727020", VA = "0x18A728020", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA728280", Offset = "0xA727280", VA = "0x18A728280", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA728530", Offset = "0xA727530", VA = "0x18A728530", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA728300", Offset = "0xA727300", VA = "0x18A728300", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA727DF0", Offset = "0xA726DF0", VA = "0x18A727DF0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xD09760", Offset = "0xD08760", VA = "0x180D09760", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA728050", Offset = "0xA727050", VA = "0x18A728050", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xA727F90", Offset = "0xA726F90", VA = "0x18A727F90")]
		[IteratorStateMachine(typeof(<GetChannels>d__32))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA728FC0", Offset = "0xA727FC0", VA = "0x18A728FC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083A")]
			[Cpp2IlInjected.Address(RVA = "0xA735280", Offset = "0xA734280", VA = "0x18A735280", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083B")]
			[Cpp2IlInjected.Address(RVA = "0xA733040", Offset = "0xA732040", VA = "0x18A733040", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600083C")]
			[Cpp2IlInjected.Address(RVA = "0xA7353E0", Offset = "0xA7343E0", VA = "0x18A7353E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xA734800", Offset = "0xA733800", VA = "0x18A734800", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0xA733F60", Offset = "0xA732F60", VA = "0x18A733F60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xA733F60", Offset = "0xA732F60", VA = "0x18A733F60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xDB5CF0", Offset = "0xDB4CF0", VA = "0x180DB5CF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public float Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0xA727800", Offset = "0xA726800", VA = "0x18A727800")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0xA727860", Offset = "0xA726860", VA = "0x18A727860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xA727440", Offset = "0xA726440", VA = "0x18A727440", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xA727470", Offset = "0xA726470", VA = "0x18A727470", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA7275B0", Offset = "0xA7265B0", VA = "0x18A7275B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA7274F0", Offset = "0xA7264F0", VA = "0x18A7274F0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA7273A0", Offset = "0xA7263A0", VA = "0x18A7273A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA727760", Offset = "0xA726760", VA = "0x18A727760")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xA735100", Offset = "0xA734100", VA = "0x18A735100", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA7335B0", Offset = "0xA7325B0", VA = "0x18A7335B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA735520", Offset = "0xA734520", VA = "0x18A735520")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0xA7348C0", Offset = "0xA7338C0", VA = "0x18A7348C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xA7341E0", Offset = "0xA7331E0", VA = "0x18A7341E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xA7341E0", Offset = "0xA7331E0", VA = "0x18A7341E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xDB5CF0", Offset = "0xDB4CF0", VA = "0x180DB5CF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public float Strength
		{
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0xA727D20", Offset = "0xA726D20", VA = "0x18A727D20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xA727D80", Offset = "0xA726D80", VA = "0x18A727D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA727970", Offset = "0xA726970", VA = "0x18A727970", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA7279A0", Offset = "0xA7269A0", VA = "0x18A7279A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA727AE0", Offset = "0xA726AE0", VA = "0x18A727AE0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA727A20", Offset = "0xA726A20", VA = "0x18A727A20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA7278D0", Offset = "0xA7268D0", VA = "0x18A7278D0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA727C80", Offset = "0xA726C80", VA = "0x18A727C80")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA734A40", Offset = "0xA733A40", VA = "0x18A734A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA731D50", Offset = "0xA730D50", VA = "0x18A731D50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xA735610", Offset = "0xA734610", VA = "0x18A735610")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xA734940", Offset = "0xA733940", VA = "0x18A734940", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xA734500", Offset = "0xA733500", VA = "0x18A734500", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xA734500", Offset = "0xA733500", VA = "0x18A734500", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1107DA0", Offset = "0x1106DA0", VA = "0x181107DA0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA738BA0", Offset = "0xA737BA0", VA = "0x18A738BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x142BD40", Offset = "0x142AD40", VA = "0x18142BD40")]
			[DebuggerHidden]
			public <_GetChannels>d__45(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0xA738C00", Offset = "0xA737C00", VA = "0x18A738C00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xA736FA0", Offset = "0xA735FA0", VA = "0x18A736FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0xA738FF0", Offset = "0xA737FF0", VA = "0x18A738FF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0xA739050", Offset = "0xA738050", VA = "0x18A739050")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0xA7390B0", Offset = "0xA7380B0", VA = "0x18A7390B0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xA739110", Offset = "0xA738110", VA = "0x18A739110")]
			private void <>m__Finally4()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0xA739170", Offset = "0xA738170", VA = "0x18A739170")]
			private void <>m__Finally5()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0xA7391D0", Offset = "0xA7381D0", VA = "0x18A7391D0")]
			private void <>m__Finally6()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0xA739230", Offset = "0xA738230", VA = "0x18A739230")]
			private void <>m__Finally7()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0xA739290", Offset = "0xA738290", VA = "0x18A739290")]
			private void <>m__Finally8()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0xA7392F0", Offset = "0xA7382F0", VA = "0x18A7392F0")]
			private void <>m__Finally9()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xA738F90", Offset = "0xA737F90", VA = "0x18A738F90")]
			private void <>m__Finally10()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0xA738B60", Offset = "0xA737B60", VA = "0x18A738B60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xA738AC0", Offset = "0xA737AC0", VA = "0x18A738AC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA738AC0", Offset = "0xA737AC0", VA = "0x18A738AC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA72B630", Offset = "0xA72A630", VA = "0x18A72B630")]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0xA72B870", Offset = "0xA72A870", VA = "0x18A72B870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0xA72B5D0", Offset = "0xA72A5D0", VA = "0x18A72B5D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0xA72B7F0", Offset = "0xA72A7F0", VA = "0x18A72B7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0xA72B6D0", Offset = "0xA72A6D0", VA = "0x18A72B6D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0xA72B9A0", Offset = "0xA72A9A0", VA = "0x18A72B9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public bool Unlit
		{
			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0xA72B7B0", Offset = "0xA72A7B0", VA = "0x18A72B7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public IEnumerable<MaterialChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xA72B070", Offset = "0xA72A070", VA = "0x18A72B070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xA72B750", Offset = "0xA72A750", VA = "0x18A72B750")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0xA72BA20", Offset = "0xA72AA20", VA = "0x18A72BA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA72B670", Offset = "0xA72A670", VA = "0x18A72B670")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0xA72B8C0", Offset = "0xA72A8C0", VA = "0x18A72B8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xA7298F0", Offset = "0xA7288F0", VA = "0x18A7298F0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA729F90", Offset = "0xA728F90", VA = "0x18A729F90", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA72A320", Offset = "0xA729320", VA = "0x18A72A320", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA72A010", Offset = "0xA729010", VA = "0x18A72A010", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA729220", Offset = "0xA728220", VA = "0x18A729220", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA72B480", Offset = "0xA72A480", VA = "0x18A72B480")]
		internal Material()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xA7295D0", Offset = "0xA7285D0", VA = "0x18A7295D0")]
		[DebuggerStepThrough]
		public MaterialChannel? FindChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xA729DC0", Offset = "0xA728DC0", VA = "0x18A729DC0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xA7290D0", Offset = "0xA7280D0", VA = "0x18A7290D0")]
		internal void ClearExtensions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xA729D20", Offset = "0xA728D20", VA = "0x18A729D20")]
		public void InitializeUnlit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA729920", Offset = "0xA728920", VA = "0x18A729920")]
		public void InitializePBRMetallicRoughness(params string[] extensionNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA729C50", Offset = "0xA728C50", VA = "0x18A729C50")]
		public void InitializePBRSpecularGlossiness(bool useFallback = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA72B070", Offset = "0xA72A070", VA = "0x18A72B070")]
		[IteratorStateMachine(typeof(<_GetChannels>d__45))]
		private IEnumerable<MaterialChannel> _GetChannels()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA72B1D0", Offset = "0xA72A1D0", VA = "0x18A72B1D0")]
		private MaterialNormalTextureInfo _GetNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA72B2F0", Offset = "0xA72A2F0", VA = "0x18A72B2F0")]
		private MaterialOcclusionTextureInfo _GetOcclusionTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xA72B0F0", Offset = "0xA72A0F0", VA = "0x18A72B0F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0xA755EF0", Offset = "0xA754EF0", VA = "0x18A755EF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xA7553B0", Offset = "0xA7543B0", VA = "0x18A7553B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0xA7564D0", Offset = "0xA7554D0", VA = "0x18A7564D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0xA755D30", Offset = "0xA754D30", VA = "0x18A755D30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xA7559B0", Offset = "0xA7549B0", VA = "0x18A7559B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0xA7559B0", Offset = "0xA7549B0", VA = "0x18A7559B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD82430", Offset = "0xD81430", VA = "0x180D82430", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD835A0", Offset = "0xD825A0", VA = "0x180D835A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public Mesh LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xD09170", Offset = "0xD08170", VA = "0x180D09170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0xA7302C0", Offset = "0xA72F2C0", VA = "0x18A7302C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0xA730530", Offset = "0xA72F530", VA = "0x18A730530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public PrimitiveType DrawPrimitiveType
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xA7301D0", Offset = "0xA72F1D0", VA = "0x18A7301D0")]
			get
			{
				return default(PrimitiveType);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0xA7304E0", Offset = "0xA72F4E0", VA = "0x18A7304E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0xA7303D0", Offset = "0xA72F3D0", VA = "0x18A7303D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public IReadOnlyDictionary<string, Accessor> VertexAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0xA730410", Offset = "0xA72F410", VA = "0x18A730410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public Accessor IndexAccessor
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0xA730210", Offset = "0xA72F210", VA = "0x18A730210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xA72EC70", Offset = "0xA72DC70", VA = "0x18A72EC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xA72CAD0", Offset = "0xA72BAD0", VA = "0x18A72CAD0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xA72EA60", Offset = "0xA72DA60", VA = "0x18A72EA60", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xA72F4F0", Offset = "0xA72E4F0", VA = "0x18A72F4F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA72EAE0", Offset = "0xA72DAE0", VA = "0x18A72EAE0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA72BD90", Offset = "0xA72AD90", VA = "0x18A72BD90", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA730060", Offset = "0xA72F060", VA = "0x18A730060")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA7300D0", Offset = "0xA72F0D0", VA = "0x18A7300D0")]
		internal MeshPrimitive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA72F4C0", Offset = "0xA72E4C0", VA = "0x18A72F4C0", Slot = "18")]
		void IChildOfList<Mesh>.SetLogicalParent(Mesh parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA72BF80", Offset = "0xA72AF80", VA = "0x18A72BF80")]
		public IEnumerable<BufferView> GetBufferViews(bool includeIndices, bool includeVertices, bool includeMorphs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA72CE00", Offset = "0xA72BE00", VA = "0x18A72CE00")]
		public IReadOnlyList<KeyValuePair<string, Accessor>> GetVertexAccessorsByBuffer(BufferView vb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0xA72CD00", Offset = "0xA72BD00", VA = "0x18A72CD00")]
		public Accessor GetVertexAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0xA72F360", Offset = "0xA72E360", VA = "0x18A72F360")]
		public void SetVertexAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D308A0", Offset = "0x3D2F8A0", VA = "0x183D308A0")]
		internal IReadOnlyList<T> GetVertices<T>(string attributeKey) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xA72C440", Offset = "0xA72B440", VA = "0x18A72C440")]
		public Accessor GetIndexAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xA72EC70", Offset = "0xA72DC70", VA = "0x18A72EC70")]
		public void SetIndexAccessor(Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xA72C4E0", Offset = "0xA72B4E0", VA = "0x18A72C4E0")]
		public IList<uint> GetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0xA72C860", Offset = "0xA72B860", VA = "0x18A72C860")]
		public IEnumerable<int> GetPointIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xA72C510", Offset = "0xA72B510", VA = "0x18A72C510")]
		public IEnumerable<(int, int)> GetLineIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA72CB00", Offset = "0xA72BB00", VA = "0x18A72CB00")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA72C710", Offset = "0xA72B710", VA = "0x18A72C710")]
		public IReadOnlyDictionary<string, Accessor> GetMorphTargetAccessors(int targetIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA72ED70", Offset = "0xA72DD70", VA = "0x18A72ED70")]
		public void SetMorphTargetAccessors(int targetIdx, IReadOnlyDictionary<string, Accessor> accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA72BB00", Offset = "0xA72AB00", VA = "0x18A72BB00")]
		internal static bool CheckAttributesQuantizationRequired(ModelRoot root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA72BD00", Offset = "0xA72AD00", VA = "0x18A72BD00")]
		private bool CheckAttributesQuantizationRequired()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA72E410", Offset = "0xA72D410", VA = "0x18A72E410", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA72D080", Offset = "0xA72C080", VA = "0x18A72D080", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0xA755E30", Offset = "0xA754E30", VA = "0x18A755E30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0xA7539D0", Offset = "0xA7529D0", VA = "0x18A7539D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0xA756570", Offset = "0xA755570", VA = "0x18A756570")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090D")]
			[Cpp2IlInjected.Address(RVA = "0xA755CB0", Offset = "0xA754CB0", VA = "0x18A755CB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xA755870", Offset = "0xA754870", VA = "0x18A755870", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xA755870", Offset = "0xA754870", VA = "0x18A755870", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA73C160", Offset = "0xA73B160", VA = "0x18A73C160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public IReadOnlyList<MeshPrimitive> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60008F8")]
			[Cpp2IlInjected.Address(RVA = "0xA73B260", Offset = "0xA73A260", VA = "0x18A73B260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public bool AllPrimitivesHaveJoints
		{
			[Cpp2IlInjected.Token(Token = "0x60008F9")]
			[Cpp2IlInjected.Address(RVA = "0xA73C040", Offset = "0xA73B040", VA = "0x18A73C040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xA73B3D0", Offset = "0xA73A3D0", VA = "0x18A73B3D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xA73B8E0", Offset = "0xA73A8E0", VA = "0x18A73B8E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xA73BBF0", Offset = "0xA73ABF0", VA = "0x18A73BBF0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xA73B960", Offset = "0xA73A960", VA = "0x18A73B960", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xA73B170", Offset = "0xA73A170", VA = "0x18A73B170", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xA73BE80", Offset = "0xA73AE80", VA = "0x18A73BE80")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA73BF80", Offset = "0xA73AF80", VA = "0x18A73BF80")]
		internal Mesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xA73B260", Offset = "0xA73A260", VA = "0x18A73B260")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0xA73BA70", Offset = "0xA73AA70", VA = "0x18A73BA70")]
		public void SetMorphWeights(IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xA73BA80", Offset = "0xA73AA80", VA = "0x18A73BA80")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0xA73B0F0", Offset = "0xA73A0F0", VA = "0x18A73B0F0")]
		public MeshPrimitive CreatePrimitive()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0xA73B780", Offset = "0xA73A780", VA = "0x18A73B780", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xA73B400", Offset = "0xA73A400", VA = "0x18A73B400", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <Flatten>d__70(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0xA753790", Offset = "0xA752790", VA = "0x18A753790", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xA7532C0", Offset = "0xA7522C0", VA = "0x18A7532C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xA753930", Offset = "0xA752930", VA = "0x18A753930")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xA753980", Offset = "0xA752980", VA = "0x18A753980")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0xA753750", Offset = "0xA752750", VA = "0x18A753750", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0xA7536B0", Offset = "0xA7526B0", VA = "0x18A7536B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0xA7536B0", Offset = "0xA7526B0", VA = "0x18A7536B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0xA756370", Offset = "0xA755370", VA = "0x18A756370", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0xA754290", Offset = "0xA753290", VA = "0x18A754290", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xA756660", Offset = "0xA755660", VA = "0x18A756660")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0xA755C70", Offset = "0xA754C70", VA = "0x18A755C70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0xA7557D0", Offset = "0xA7547D0", VA = "0x18A7557D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xA7557D0", Offset = "0xA7547D0", VA = "0x18A7557D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA74C4F0", Offset = "0xA74B4F0", VA = "0x18A74C4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Node VisualRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0xA74C600", Offset = "0xA74B600", VA = "0x18A74C600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<Scene> VisualScenes
		{
			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0xA74C670", Offset = "0xA74B670", VA = "0x18A74C670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0xA749800", Offset = "0xA748800", VA = "0x18A749800", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public bool IsSkinJoint
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0xA74B5E0", Offset = "0xA74A5E0", VA = "0x18A74B5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public bool IsSkinSkeleton
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0xA74B6F0", Offset = "0xA74A6F0", VA = "0x18A74B6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public Camera Camera
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xA74B4E0", Offset = "0xA74A4E0", VA = "0x18A74B4E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0xA74CB90", Offset = "0xA74BB90", VA = "0x18A74CB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public Mesh Mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0xA74C120", Offset = "0xA74B120", VA = "0x18A74C120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0xA74CD70", Offset = "0xA74BD70", VA = "0x18A74CD70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public Skin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0xA74C3E0", Offset = "0xA74B3E0", VA = "0x18A74C3E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0xA74CF60", Offset = "0xA74BF60", VA = "0x18A74CF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0xA74C230", Offset = "0xA74B230", VA = "0x18A74C230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0xA74CA70", Offset = "0xA74BA70", VA = "0x18A74CA70")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0xA74D100", Offset = "0xA74C100", VA = "0x18A74D100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0xA74BFB0", Offset = "0xA74AFB0", VA = "0x18A74BFB0")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0xA74CD30", Offset = "0xA74BD30", VA = "0x18A74CD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000929")]
			[Cpp2IlInjected.Address(RVA = "0xA74BED0", Offset = "0xA74AED0", VA = "0x18A74BED0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600092A")]
			[Cpp2IlInjected.Address(RVA = "0xA74CC70", Offset = "0xA74BC70", VA = "0x18A74CC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(RVA = "0xA74BA40", Offset = "0xA74AA40", VA = "0x18A74BA40")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0xA74C7B0", Offset = "0xA74B7B0", VA = "0x18A74C7B0")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool IsTransformAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0xA74B800", Offset = "0xA74A800", VA = "0x18A74B800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		internal bool IsTransformDecomposed
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0xA74B9E0", Offset = "0xA74A9E0", VA = "0x18A74B9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public PunctualLight PunctualLight
		{
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0xA74C240", Offset = "0xA74B240", VA = "0x18A74C240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0xA74CE60", Offset = "0xA74BE60", VA = "0x18A74CE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0xA747120", Offset = "0xA746120", VA = "0x18A747120", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0xA747970", Offset = "0xA746970", VA = "0x18A747970", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0xA7481C0", Offset = "0xA7471C0", VA = "0x18A7481C0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xA747A30", Offset = "0xA746A30", VA = "0x18A747A30", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA7465B0", Offset = "0xA7455B0", VA = "0x18A7465B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xA7492B0", Offset = "0xA7482B0", VA = "0x18A7492B0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xA74B220", Offset = "0xA74A220", VA = "0x18A74B220")]
		internal Node()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xA746D00", Offset = "0xA745D00", VA = "0x18A746D00")]
		public AffineTransform GetLocalTransform(Animation animation, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0xA747150", Offset = "0xA746150", VA = "0x18A747150")]
		public Matrix4x4 GetWorldMatrix(Animation animation, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xA746E40", Offset = "0xA745E40", VA = "0x18A746E40")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xA747EB0", Offset = "0xA746EB0", VA = "0x18A747EB0")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xA749190", Offset = "0xA748190", VA = "0x18A749190")]
		internal static Node _FindVisualRootNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0xA746550", Offset = "0xA745550", VA = "0x18A746550", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0xA746B40", Offset = "0xA745B40", VA = "0x18A746B40")]
		[IteratorStateMachine(typeof(<Flatten>d__70))]
		public static IEnumerable<Node> Flatten(IVisualNodeContainer container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA746940", Offset = "0xA745940", VA = "0x18A746940")]
		public static IEnumerable<Node> FindNodesUsingMesh(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA746A40", Offset = "0xA745A40", VA = "0x18A746A40")]
		public static IEnumerable<Node> FindNodesUsingSkin(Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA749020", Offset = "0xA748020", VA = "0x18A749020")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA749890", Offset = "0xA748890", VA = "0x18A749890")]
		internal bool _HasVisualChild(int nodeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA749800", Offset = "0xA748800", VA = "0x18A749800")]
		internal IEnumerable<Node> _GetVisualChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xA749E50", Offset = "0xA748E50", VA = "0x18A749E50")]
		internal void _SetVisualParent(Node parentNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA7498F0", Offset = "0xA7488F0", VA = "0x18A7498F0")]
		internal void _RemoveFromVisualParent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA746BC0", Offset = "0xA745BC0", VA = "0x18A746BC0")]
		public NodeCurveSamplers GetCurveSamplers(Animation animation)
		{
			return default(NodeCurveSamplers);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA749950", Offset = "0xA748950", VA = "0x18A749950")]
		private void _SetLocalTransform(AffineTransform value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA7475C0", Offset = "0xA7465C0", VA = "0x18A7475C0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA74A5C0", Offset = "0xA7495C0", VA = "0x18A74A5C0")]
		internal static void _ValidateParentHierarchy(IEnumerable<Node> nodes, ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA7473E0", Offset = "0xA7463E0", VA = "0x18A7473E0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0xA74A230", Offset = "0xA749230", VA = "0x18A74A230")]
		private void _ValidateChildrenHierarchy(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xA74ACA0", Offset = "0xA749CA0", VA = "0x18A74ACA0")]
		private void _ValidateTransforms(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xA74A330", Offset = "0xA749330", VA = "0x18A74A330")]
		private static void _ValidateMeshAndSkin(ValidationContext validate, Mesh mesh, Skin skin, List<double> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0xA746CC0", Offset = "0xA745CC0", VA = "0x18A746CC0")]
		public MeshGpuInstancing GetGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA748F70", Offset = "0xA747F70", VA = "0x18A748F70")]
		public MeshGpuInstancing UseGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA7479F0", Offset = "0xA7469F0", VA = "0x18A7479F0")]
		public void RemoveGpuInstancing()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA748150", Offset = "0xA747150", VA = "0x18A748150")]
		public bool TryGetVisibility([Out] bool isVisible)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0xA7480A0", Offset = "0xA7470A0", VA = "0x18A7480A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA757A80", Offset = "0xA756A80", VA = "0x18A757A80", Slot = "4")]
			public bool Equals(TextureSampler x, TextureSampler y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xA757C20", Offset = "0xA756C20", VA = "0x18A757C20", Slot = "5")]
			public int GetHashCode(TextureSampler obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099C")]
			[Cpp2IlInjected.Address(RVA = "0xA755FB0", Offset = "0xA754FB0", VA = "0x18A755FB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xA753F70", Offset = "0xA752F70", VA = "0x18A753F70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xA756430", Offset = "0xA755430", VA = "0x18A756430")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0xA755C30", Offset = "0xA754C30", VA = "0x18A755C30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xA755910", Offset = "0xA754910", VA = "0x18A755910", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0xA755910", Offset = "0xA754910", VA = "0x18A755910", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA751C70", Offset = "0xA750C70", VA = "0x18A751C70")]
			get
			{
				return default(TextureMipMapFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000987")]
			[Cpp2IlInjected.Address(RVA = "0xA751C30", Offset = "0xA750C30", VA = "0x18A751C30")]
			get
			{
				return default(TextureInterpolationFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0xA751CB0", Offset = "0xA750CB0", VA = "0x18A751CB0")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0xA751CF0", Offset = "0xA750CF0", VA = "0x18A751CF0")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public static IEqualityComparer<TextureSampler> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xA751BE0", Offset = "0xA750BE0", VA = "0x18A751BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xA751D30", Offset = "0xA750D30", VA = "0x18A751D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0xA7511C0", Offset = "0xA7501C0", VA = "0x18A7511C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xA751300", Offset = "0xA750300", VA = "0x18A751300", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xA751500", Offset = "0xA750500", VA = "0x18A751500", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xA751380", Offset = "0xA750380", VA = "0x18A751380", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xA750E70", Offset = "0xA74FE70", VA = "0x18A750E70", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xA751A20", Offset = "0xA750A20", VA = "0x18A751A20")]
		internal TextureSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA751AB0", Offset = "0xA750AB0", VA = "0x18A751AB0")]
		internal TextureSampler(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xA7511F0", Offset = "0xA7501F0", VA = "0x18A7511F0")]
		internal static bool IsDefault(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xA750D10", Offset = "0xA74FD10", VA = "0x18A750D10")]
		public static bool AreEqualByContent(TextureSampler x, TextureSampler y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0xA751210", Offset = "0xA750210", VA = "0x18A751210")]
		internal bool IsEqualTo(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0xA7510A0", Offset = "0xA7500A0", VA = "0x18A7510A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0xA756070", Offset = "0xA755070", VA = "0x18A756070", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0xA754760", Offset = "0xA753760", VA = "0x18A754760", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0xA756480", Offset = "0xA755480", VA = "0x18A756480")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0xA755DB0", Offset = "0xA754DB0", VA = "0x18A755DB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0xA755AF0", Offset = "0xA754AF0", VA = "0x18A755AF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0xA755AF0", Offset = "0xA754AF0", VA = "0x18A755AF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0xA74E180", Offset = "0xA74D180", VA = "0x18A74E180", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xA74D360", Offset = "0xA74C360", VA = "0x18A74D360", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xA74D8E0", Offset = "0xA74C8E0", VA = "0x18A74D8E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xA74DA10", Offset = "0xA74CA10", VA = "0x18A74DA10", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0xA74D960", Offset = "0xA74C960", VA = "0x18A74D960", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xA74D2C0", Offset = "0xA74C2C0", VA = "0x18A74D2C0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xA74E100", Offset = "0xA74D100", VA = "0x18A74E100")]
		internal Scene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0xA74D260", Offset = "0xA74C260", VA = "0x18A74D260", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0xA74DC10", Offset = "0xA74CC10", VA = "0x18A74DC10")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xA74DE50", Offset = "0xA74CE50", VA = "0x18A74DE50")]
		internal void _RemoveVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xA74DF40", Offset = "0xA74CF40", VA = "0x18A74DF40")]
		internal void _UseVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xA74D390", Offset = "0xA74C390", VA = "0x18A74D390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xA756130", Offset = "0xA755130", VA = "0x18A756130", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0xA753C70", Offset = "0xA752C70", VA = "0x18A753C70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0xA756610", Offset = "0xA755610", VA = "0x18A756610")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F1")]
			[Cpp2IlInjected.Address(RVA = "0xA755DF0", Offset = "0xA754DF0", VA = "0x18A755DF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0xA755730", Offset = "0xA754730", VA = "0x18A755730", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0xA755730", Offset = "0xA754730", VA = "0x18A755730", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA750B00", Offset = "0xA74FB00", VA = "0x18A750B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public int JointsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xA750990", Offset = "0xA74F990", VA = "0x18A750990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public IReadOnlyList<Node> Joints
		{
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0xA7509D0", Offset = "0xA74F9D0", VA = "0x18A7509D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public IReadOnlyList<Matrix4x4> InverseBindMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0xA7508E0", Offset = "0xA74F8E0", VA = "0x18A7508E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public Node Skeleton
		{
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xA750A60", Offset = "0xA74FA60", VA = "0x18A750A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0xA750C30", Offset = "0xA74FC30", VA = "0x18A750C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xA74F3A0", Offset = "0xA74E3A0", VA = "0x18A74F3A0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0xA74FCD0", Offset = "0xA74ECD0", VA = "0x18A74FCD0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xA74FE60", Offset = "0xA74EE60", VA = "0x18A74FE60", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0xA74FD50", Offset = "0xA74ED50", VA = "0x18A74FD50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0xA74EDA0", Offset = "0xA74DDA0", VA = "0x18A74EDA0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0xA750860", Offset = "0xA74F860", VA = "0x18A750860")]
		internal Skin()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0xA750340", Offset = "0xA74F340", VA = "0x18A750340")]
		public Accessor UseInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xA74F080", Offset = "0xA74E080", VA = "0x18A74F080")]
		public Accessor GetInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xA74F180", Offset = "0xA74E180", VA = "0x18A74F180")]
		public (Node, Matrix4x4) GetJoint(int idx)
		{
			return default((Node, Matrix4x4));
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0xA74E8C0", Offset = "0xA74D8C0", VA = "0x18A74E8C0")]
		public void BindJoints(params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0xA74E940", Offset = "0xA74D940", VA = "0x18A74E940")]
		public void BindJoints(Matrix4x4 meshBindTransform, params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA74E210", Offset = "0xA74D210", VA = "0x18A74E210")]
		public void BindJoints(IReadOnlyList<(Node Joint, Matrix4x4 InverseBindMatrix)> joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA74F3D0", Offset = "0xA74E3D0", VA = "0x18A74F3D0")]
		internal bool IsMatch(Node skeleton, KeyValuePair<Node, Matrix4x4>[] joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xA74EEC0", Offset = "0xA74DEC0", VA = "0x18A74EEC0")]
		internal static IEnumerable<Skin> FindSkinsUsingJoint(Node jointNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0xA74EFA0", Offset = "0xA74DFA0", VA = "0x18A74EFA0")]
		internal static IEnumerable<Skin> FindSkinsUsingSkeleton(Node skeletonNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0xA750460", Offset = "0xA74F460", VA = "0x18A750460")]
		private Node _FindCommonAncestor(IEnumerable<Node> nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0xA74F7F0", Offset = "0xA74E7F0", VA = "0x18A74F7F0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0xA74F5C0", Offset = "0xA74E5C0", VA = "0x18A74F5C0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0xA7561F0", Offset = "0xA7551F0", VA = "0x18A7561F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0xA755110", Offset = "0xA754110", VA = "0x18A755110", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0xA7565C0", Offset = "0xA7555C0", VA = "0x18A7565C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xA755CF0", Offset = "0xA754CF0", VA = "0x18A755CF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0xA755B90", Offset = "0xA754B90", VA = "0x18A755B90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0xA755B90", Offset = "0xA754B90", VA = "0x18A755B90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA753100", Offset = "0xA752100", VA = "0x18A753100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0xA753200", Offset = "0xA752200", VA = "0x18A753200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public Image PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0xA7530F0", Offset = "0xA7520F0", VA = "0x18A7530F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public Image FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0xA753030", Offset = "0xA752030", VA = "0x18A753030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xA751EF0", Offset = "0xA750EF0", VA = "0x18A751EF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xA752070", Offset = "0xA751070", VA = "0x18A752070", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0xA752860", Offset = "0xA751860", VA = "0x18A752860", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0xA7520F0", Offset = "0xA7510F0", VA = "0x18A7520F0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0xA751E20", Offset = "0xA750E20", VA = "0x18A751E20", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xA724C80", Offset = "0xA723C80", VA = "0x18A724C80")]
		internal Texture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xA752BD0", Offset = "0xA751BD0", VA = "0x18A752BD0")]
		private Image _GetPrimaryImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0xA752B10", Offset = "0xA751B10", VA = "0x18A752B10")]
		private Image _GetFallbackImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0xA752180", Offset = "0xA751180", VA = "0x18A752180")]
		public void SetImage(Image primaryImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0xA7523B0", Offset = "0xA7513B0", VA = "0x18A7523B0")]
		public void SetImages(Image primaryImage, Image fallbackImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xA751DA0", Offset = "0xA750DA0", VA = "0x18A751DA0")]
		public void ClearImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0xA752EE0", Offset = "0xA751EE0", VA = "0x18A752EE0")]
		private TextureDDS _UseDDSTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xA752FC0", Offset = "0xA751FC0", VA = "0x18A752FC0")]
		private TextureWEBP _UseWEBPTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xA752F50", Offset = "0xA751F50", VA = "0x18A752F50")]
		private TextureKTX2 _UseKTX2Texture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xA752D00", Offset = "0xA751D00", VA = "0x18A752D00")]
		internal bool _IsEqualentTo(Image primary, Image fallback, TextureSampler sampler)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xA751F20", Offset = "0xA750F20", VA = "0x18A751F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0xA7562B0", Offset = "0xA7552B0", VA = "0x18A7562B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0xA7549B0", Offset = "0xA7539B0", VA = "0x18A7549B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0xA756520", Offset = "0xA755520", VA = "0x18A756520")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0xA755D70", Offset = "0xA754D70", VA = "0x18A755D70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9D")]
			[Cpp2IlInjected.Address(RVA = "0xA755A50", Offset = "0xA754A50", VA = "0x18A755A50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9E")]
			[Cpp2IlInjected.Address(RVA = "0xA755A50", Offset = "0xA754A50", VA = "0x18A755A50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xA746420", Offset = "0xA745420", VA = "0x18A746420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public bool MeshQuantizationAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xA7463C0", Offset = "0xA7453C0", VA = "0x18A7463C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public IEnumerable<string> ExtensionsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public IEnumerable<string> ExtensionsRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public IEnumerable<string> IncompatibleExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0xA746270", Offset = "0xA745270", VA = "0x18A746270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public IReadOnlyList<Material> LogicalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0xD09750", Offset = "0xD08750", VA = "0x180D09750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public IReadOnlyList<Texture> LogicalTextures
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0xDEFAF0", Offset = "0xDEEAF0", VA = "0x180DEFAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public IReadOnlyList<TextureSampler> LogicalTextureSamplers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0xD12E90", Offset = "0xD11E90", VA = "0x180D12E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public IReadOnlyList<Image> LogicalImages
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0xD09130", Offset = "0xD08130", VA = "0x180D09130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public IReadOnlyList<Buffer> LogicalBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public IReadOnlyList<BufferView> LogicalBufferViews
		{
			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public IReadOnlyList<Accessor> LogicalAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public IReadOnlyList<Mesh> LogicalMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0xD09730", Offset = "0xD08730", VA = "0x180D09730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public IReadOnlyList<Skin> LogicalSkins
		{
			[Cpp2IlInjected.Token(Token = "0x6000A47")]
			[Cpp2IlInjected.Address(RVA = "0xD12F00", Offset = "0xD11F00", VA = "0x180D12F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public IReadOnlyList<Camera> LogicalCameras
		{
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xD09150", Offset = "0xD08150", VA = "0x180D09150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public IReadOnlyList<Node> LogicalNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xD12820", Offset = "0xD11820", VA = "0x180D12820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public IReadOnlyList<Scene> LogicalScenes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xD39E70", Offset = "0xD38E70", VA = "0x180D39E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public IReadOnlyList<Animation> LogicalAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public Scene DefaultScene
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0xA7461C0", Offset = "0xA7451C0", VA = "0x18A7461C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0xA746470", Offset = "0xA745470", VA = "0x18A746470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public IReadOnlyList<PunctualLight> LogicalPunctualLights
		{
			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0xA746300", Offset = "0xA745300", VA = "0x18A746300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA73EC40", Offset = "0xA73DC40", VA = "0x18A73EC40", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA740730", Offset = "0xA73F730", VA = "0x18A740730", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0xA741260", Offset = "0xA740260", VA = "0x18A741260", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xA740C90", Offset = "0xA73FC90", VA = "0x18A740C90", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xA73DA60", Offset = "0xA73CA60", VA = "0x18A73DA60", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xA73CC90", Offset = "0xA73BC90", VA = "0x18A73CC90")]
		public Accessor CreateAccessor([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0xA73CD30", Offset = "0xA73BD30", VA = "0x18A73CD30")]
		public Animation CreateAnimation([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xA73CF60", Offset = "0xA73BF60", VA = "0x18A73CF60")]
		public Buffer CreateBuffer(int byteCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0xA742E90", Offset = "0xA741E90", VA = "0x18A742E90")]
		public Buffer UseBuffer(byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0xA73F000", Offset = "0xA73E000", VA = "0x18A73F000")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0xA73F450", Offset = "0xA73E450", VA = "0x18A73F450")]
		public void MergeBuffers(int maxSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0xA73EC70", Offset = "0xA73DC70", VA = "0x18A73EC70")]
		public void IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xA73CDD0", Offset = "0xA73BDD0", VA = "0x18A73CDD0")]
		public BufferView CreateBufferView(int byteSize, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0xA7427B0", Offset = "0xA7417B0", VA = "0x18A7427B0")]
		public BufferView UseBufferView(ArraySegment<byte> data, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0xA7429B0", Offset = "0xA7419B0", VA = "0x18A7429B0")]
		public BufferView UseBufferView(byte[] buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0xA742AB0", Offset = "0xA741AB0", VA = "0x18A742AB0")]
		public BufferView UseBufferView(Buffer buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xA73D010", Offset = "0xA73C010", VA = "0x18A73D010")]
		public Camera CreateCamera([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0xA7425E0", Offset = "0xA7415E0", VA = "0x18A7425E0")]
		internal void UpdateExtensionsSupport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0xA73E190", Offset = "0xA73D190", VA = "0x18A73E190")]
		internal IEnumerable<string> GatherUsedExtensions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0xA745410", Offset = "0xA744410", VA = "0x18A745410")]
		private void _SetExtensionUsage(string extension, bool used, bool required)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0xA745530", Offset = "0xA744530", VA = "0x18A745530")]
		internal void _ValidateExtensions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0xA73D0B0", Offset = "0xA73C0B0", VA = "0x18A73D0B0")]
		public Image CreateImage([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xA7430F0", Offset = "0xA7420F0", VA = "0x18A7430F0")]
		public Image UseImage(MemoryImage imageContent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0xA73F9C0", Offset = "0xA73E9C0", VA = "0x18A73F9C0")]
		public void MergeImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0xA73D1D0", Offset = "0xA73C1D0", VA = "0x18A73D1D0")]
		public Material CreateMaterial([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0xA73D270", Offset = "0xA73C270", VA = "0x18A73D270")]
		public Mesh CreateMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0xA744820", Offset = "0xA743820", VA = "0x18A744820")]
		internal Node _FindVisualParentNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0xA73D150", Offset = "0xA73C150", VA = "0x18A73D150")]
		public Node CreateLogicalNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0xA744740", Offset = "0xA743740", VA = "0x18A744740")]
		internal Node _CreateVisualNode(IList<int> parentChildren)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0xA73C290", Offset = "0xA73B290", VA = "0x18A73C290")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0xA73D3B0", Offset = "0xA73C3B0", VA = "0x18A73D3B0")]
		public static ModelRoot CreateModel()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0xA745D40", Offset = "0xA744D40", VA = "0x18A745D40")]
		internal ModelRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0xA73D650", Offset = "0xA73C650", VA = "0x18A73D650")]
		public ModelRoot DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0xE14D80", Offset = "0xE13D80", VA = "0x180E14D80", Slot = "16")]
		ModelRoot IConvertibleToGltf2.ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0xA73E9B0", Offset = "0xA73D9B0", VA = "0x18A73E9B0")]
		internal IEnumerable<ExtraProperties> GetLogicalChildrenFlattened()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0xA73FBD0", Offset = "0xA73EBD0", VA = "0x18A73FBD0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0xA73FB60", Offset = "0xA73EB60", VA = "0x18A73FB60", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0xA73D480", Offset = "0xA73C480", VA = "0x18A73D480")]
		public PunctualLight CreatePunctualLight(PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0xA73D4E0", Offset = "0xA73C4E0", VA = "0x18A73D4E0")]
		public PunctualLight CreatePunctualLight(string name, PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0xA743510", Offset = "0xA742510", VA = "0x18A743510")]
		public Scene UseScene(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0xA7433C0", Offset = "0xA7423C0", VA = "0x18A7433C0")]
		public Scene UseScene(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0xA73D550", Offset = "0xA73C550", VA = "0x18A73D550")]
		public Skin CreateSkin([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0xA7436C0", Offset = "0xA7426C0", VA = "0x18A7436C0")]
		public TextureSampler UseTextureSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min, TextureInterpolationFilter mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0xA743B10", Offset = "0xA742B10", VA = "0x18A743B10")]
		public Texture UseTexture(Image primary, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0xA743B40", Offset = "0xA742B40", VA = "0x18A743B40")]
		public Texture UseTexture(Image primary, Image fallback, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0xA743ED0", Offset = "0xA742ED0", VA = "0x18A743ED0")]
		public static ValidationResult Validate(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0xA73EE20", Offset = "0xA73DE20", VA = "0x18A73EE20")]
		public static ModelRoot Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0xA73FD90", Offset = "0xA73ED90", VA = "0x18A73FD90")]
		public static ModelRoot ParseGLB(ArraySegment<byte> glb, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0xA740540", Offset = "0xA73F540", VA = "0x18A740540")]
		public static ModelRoot ReadGLB(Stream stream, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0xA73EAE0", Offset = "0xA73DAE0", VA = "0x18A73EAE0")]
		public static string[] GetSatellitePaths(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0xA73FF70", Offset = "0xA73EF70", VA = "0x18A73FF70")]
		private static string[] ParseSatellitePaths(ReadOnlyMemory<byte> json)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		internal void OnDeserializationCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xA745020", Offset = "0xA744020", VA = "0x18A745020")]
		internal void _ResolveSatelliteDependencies(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0xA740B90", Offset = "0xA73FB90", VA = "0x18A740B90")]
		public void Save(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xA7407B0", Offset = "0xA73F7B0", VA = "0x18A7407B0")]
		public void SaveGLB(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0xA7409A0", Offset = "0xA73F9A0", VA = "0x18A7409A0")]
		public void SaveGLTF(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0xA73E9A0", Offset = "0xA73D9A0", VA = "0x18A73E9A0")]
		[Obsolete("Use GetJsonPreview", true)]
		public string GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0xA73E9A0", Offset = "0xA73D9A0", VA = "0x18A73E9A0")]
		public string GetJsonPreview()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0xA744920", Offset = "0xA743920", VA = "0x18A744920")]
		internal string _GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0xA744020", Offset = "0xA743020", VA = "0x18A744020")]
		public ArraySegment<byte> WriteGLB([Optional] WriteSettings settings)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0xA744260", Offset = "0xA743260", VA = "0x18A744260")]
		public void WriteGLB(Stream stream, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0xA7459A0", Offset = "0xA7449A0", VA = "0x18A7459A0")]
		internal void _WriteJSON(Stream sw, JsonWriterOptions options, JsonFilterCallback filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0xA744C40", Offset = "0xA743C40", VA = "0x18A744C40")]
		internal void _PrepareBuffersForSatelliteWriting(WriteContext context, string baseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0xA744B90", Offset = "0xA743B90", VA = "0x18A744B90")]
		internal void _PrepareBuffersForInternalWriting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0xA744D90", Offset = "0xA743D90", VA = "0x18A744D90")]
		internal void _PrepareImagesForWriting(WriteContext context, string baseName, bool isBinary, ResourceWriteMode rmode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0xA7443B0", Offset = "0xA7433B0", VA = "0x18A7443B0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABD")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0xA770BC0", Offset = "0xA76FBC0", VA = "0x18A770BC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0xA7707E0", Offset = "0xA76F7E0", VA = "0x18A7707E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0xA770C80", Offset = "0xA76FC80", VA = "0x18A770C80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0xA770B80", Offset = "0xA76FB80", VA = "0x18A770B80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0xA770AE0", Offset = "0xA76FAE0", VA = "0x18A770AE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(RVA = "0xA770AE0", Offset = "0xA76FAE0", VA = "0x18A770AE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA73AE80", Offset = "0xA739E80", VA = "0x18A73AE80")]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0xA739ED0", Offset = "0xA738ED0", VA = "0x18A739ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA8")]
			[Cpp2IlInjected.Address(RVA = "0xD09750", Offset = "0xD08750", VA = "0x180D09750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0xD09760", Offset = "0xD08760", VA = "0x180D09760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0xA73B0B0", Offset = "0xA73A0B0", VA = "0x18A73B0B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		internal bool _HasContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0xA73B010", Offset = "0xA73A010", VA = "0x18A73B010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0xA739A60", Offset = "0xA738A60", VA = "0x18A739A60", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0xA739DA0", Offset = "0xA738DA0", VA = "0x18A739DA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0xA73A2C0", Offset = "0xA7392C0", VA = "0x18A73A2C0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xA739E20", Offset = "0xA738E20", VA = "0x18A739E20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0xA7397A0", Offset = "0xA7387A0", VA = "0x18A7397A0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0xA73A6B0", Offset = "0xA7396B0", VA = "0x18A73A6B0")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0xA724C80", Offset = "0xA723C80", VA = "0x18A724C80")]
		internal Image()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0xA7398C0", Offset = "0xA7388C0", VA = "0x18A7398C0")]
		private MemoryImage GetSatelliteContent()
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0xA739ED0", Offset = "0xA738ED0", VA = "0x18A739ED0")]
		private void SetSatelliteContent(MemoryImage content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAE")]
		[Cpp2IlInjected.Address(RVA = "0xA739FE0", Offset = "0xA738FE0", VA = "0x18A739FE0")]
		internal void TransferToInternalBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAF")]
		[Cpp2IlInjected.Address(RVA = "0xA73A7D0", Offset = "0xA7397D0", VA = "0x18A73A7D0")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB0")]
		[Cpp2IlInjected.Address(RVA = "0xA73A780", Offset = "0xA739780", VA = "0x18A73A780")]
		internal void _DiscardContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0xA73AAC0", Offset = "0xA739AC0", VA = "0x18A73AAC0")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0xA73ABC0", Offset = "0xA739BC0", VA = "0x18A73ABC0")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0xA73A990", Offset = "0xA739990", VA = "0x18A73A990")]
		private void _WriteAsBufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0xA73A670", Offset = "0xA739670", VA = "0x18A73A670")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0xA739C10", Offset = "0xA738C10", VA = "0x18A739C10", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xA739A90", Offset = "0xA738A90", VA = "0x18A739A90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACC")]
			[Cpp2IlInjected.Address(RVA = "0xA778EB0", Offset = "0xA777EB0", VA = "0x18A778EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA778E20", Offset = "0xA777E20", VA = "0x18A778E20")]
		public _StaticBufferBuilder(int bufferIndex, int initialCapacity = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA778C20", Offset = "0xA777C20", VA = "0x18A778C20")]
		public int Append(byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA778D80", Offset = "0xA777D80", VA = "0x18A778D80")]
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
			[Cpp2IlInjected.Address(RVA = "0x41621D0", Offset = "0x41611D0", VA = "0x1841621D0")]
			public static ExtensionEntry Create<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
			{
				return default(ExtensionEntry);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AD9")]
			[Cpp2IlInjected.Address(RVA = "0x23F6BA0", Offset = "0x23F5BA0", VA = "0x1823F6BA0")]
			public ExtensionEntry(string n, Type p, Type e, Func<JsonSerializable, JsonSerializable> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADA")]
			[Cpp2IlInjected.Address(RVA = "0xA75A0F0", Offset = "0xA7590F0", VA = "0x18A75A0F0")]
			public bool IsMatch(Type parentType, string extensionName)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADB")]
			[Cpp2IlInjected.Address(RVA = "0xA75A070", Offset = "0xA759070", VA = "0x18A75A070")]
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
			[Cpp2IlInjected.Address(RVA = "0xA75B060", Offset = "0xA75A060", VA = "0x18A75B060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA75A500", Offset = "0xA759500", VA = "0x18A75A500")]
		static ExtensionsFactory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9500", Offset = "0x3AC8500", VA = "0x183AC9500")]
		[Obsolete("Use RegisterExtension(name, factory) instead.")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x3AC9200", Offset = "0x3AC8200", VA = "0x183AC9200")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName, Func<TParent, JsonSerializable> factory) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA75A150", Offset = "0xA759150", VA = "0x18A75A150")]
		internal static JsonSerializable Create(JsonSerializable parent, string extensionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0xA75A320", Offset = "0xA759320", VA = "0x18A75A320")]
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
					[Cpp2IlInjected.Address(RVA = "0x5165E40", Offset = "0x5164E40", VA = "0x185165E40", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA76FCC0", Offset = "0xA76ECC0", VA = "0x18A76FCC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000B20")]
				[Cpp2IlInjected.Address(RVA = "0x519A500", Offset = "0x5199500", VA = "0x18519A500")]
				[DebuggerHidden]
				public <GetFields>d__3(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B21")]
				[Cpp2IlInjected.Address(RVA = "0xA76FD10", Offset = "0xA76ED10", VA = "0x18A76FD10", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B22")]
				[Cpp2IlInjected.Address(RVA = "0xA76F890", Offset = "0xA76E890", VA = "0x18A76F890", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B23")]
				[Cpp2IlInjected.Address(RVA = "0xA76FDD0", Offset = "0xA76EDD0", VA = "0x18A76FDD0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B25")]
				[Cpp2IlInjected.Address(RVA = "0xA76FC80", Offset = "0xA76EC80", VA = "0x18A76FC80", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B27")]
				[Cpp2IlInjected.Address(RVA = "0xA76FBE0", Offset = "0xA76EBE0", VA = "0x18A76FBE0", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B28")]
				[Cpp2IlInjected.Address(RVA = "0xA76FBE0", Offset = "0xA76EBE0", VA = "0x18A76FBE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
			public _ExtensionsReflection(IReadOnlyList<JsonSerializable> extensions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B18")]
			[Cpp2IlInjected.Address(RVA = "0xA7775C0", Offset = "0xA7765C0", VA = "0x18A7775C0", Slot = "5")]
			public bool TryGetField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0xA777540", Offset = "0xA776540", VA = "0x18A777540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B35")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <Flatten>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B36")]
			[Cpp2IlInjected.Address(RVA = "0xA76F570", Offset = "0xA76E570", VA = "0x18A76F570", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B37")]
			[Cpp2IlInjected.Address(RVA = "0xA76F0F0", Offset = "0xA76E0F0", VA = "0x18A76F0F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0xA76F710", Offset = "0xA76E710", VA = "0x18A76F710")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0xA76F760", Offset = "0xA76E760", VA = "0x18A76F760")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0xA76F530", Offset = "0xA76E530", VA = "0x18A76F530", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3D")]
			[Cpp2IlInjected.Address(RVA = "0xA76F490", Offset = "0xA76E490", VA = "0x18A76F490", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3E")]
			[Cpp2IlInjected.Address(RVA = "0xA76F490", Offset = "0xA76E490", VA = "0x18A76F490", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3F")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <GetLogicalChildren>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B40")]
			[Cpp2IlInjected.Address(RVA = "0xA7705A0", Offset = "0xA76F5A0", VA = "0x18A7705A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0xA76FE20", Offset = "0xA76EE20", VA = "0x18A76FE20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0xA770740", Offset = "0xA76F740", VA = "0x18A770740")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0xA770790", Offset = "0xA76F790", VA = "0x18A770790")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B45")]
			[Cpp2IlInjected.Address(RVA = "0xA770560", Offset = "0xA76F560", VA = "0x18A770560", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0xA7704C0", Offset = "0xA76F4C0", VA = "0x18A7704C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B48")]
			[Cpp2IlInjected.Address(RVA = "0xA7704C0", Offset = "0xA76F4C0", VA = "0x18A7704C0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B49")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0xA7710D0", Offset = "0xA7700D0", VA = "0x18A7710D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0xA770CD0", Offset = "0xA76FCD0", VA = "0x18A770CD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4C")]
			[Cpp2IlInjected.Address(RVA = "0xA771190", Offset = "0xA770190", VA = "0x18A771190")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0xA771090", Offset = "0xA770090", VA = "0x18A771090", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B50")]
			[Cpp2IlInjected.Address(RVA = "0xA770FF0", Offset = "0xA76FFF0", VA = "0x18A770FF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0xA770FF0", Offset = "0xA76FFF0", VA = "0x18A770FF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "14")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0xA75C560", Offset = "0xA75B560", VA = "0x18A75C560", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0xA75B450", Offset = "0xA75A450", VA = "0x18A75B450", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0xA75BAA0", Offset = "0xA75AAA0", VA = "0x18A75BAA0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__9))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0xA75BBE0", Offset = "0xA75ABE0", VA = "0x18A75BBE0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0xA75B3D0", Offset = "0xA75A3D0", VA = "0x18A75B3D0")]
		[IteratorStateMachine(typeof(<GetLogicalChildren>d__11))]
		protected IEnumerable<ExtraProperties> GetLogicalChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0xA75B350", Offset = "0xA75A350", VA = "0x18A75B350")]
		[IteratorStateMachine(typeof(<Flatten>d__12))]
		protected static IEnumerable<ExtraProperties> Flatten(ExtraProperties container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBFE0", Offset = "0x3ACAFE0", VA = "0x183ACBFE0")]
		protected static void SetProperty<TParent, TProperty, TValue>(TParent parent, TProperty property, TValue value) where TParent : ExtraProperties where TProperty : class where TValue : TProperty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB940", Offset = "0x3ACA940", VA = "0x183ACB940")]
		protected static ChildSetter<T> GetChildSetter<T>(T owner) where T : ExtraProperties
		{
			return default(ChildSetter<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB990", Offset = "0x3ACA990", VA = "0x183ACB990")]
		public T GetExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC060", Offset = "0x3ACB060", VA = "0x183ACC060")]
		public T UseExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBC70", Offset = "0x3ACAC70", VA = "0x183ACBC70")]
		public void SetExtension<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB9E0", Offset = "0x3ACA9E0", VA = "0x183ACB9E0")]
		public void RemoveExtensions<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBAD0", Offset = "0x3ACAAD0", VA = "0x183ACBAD0")]
		public void RemoveExtensions<T>() where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0xA75B690", Offset = "0xA75A690", VA = "0x18A75B690", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0xA75B480", Offset = "0xA75A480", VA = "0x18A75B480", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0xA75BB20", Offset = "0xA75AB20", VA = "0x18A75BB20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0xA75C210", Offset = "0xA75B210", VA = "0x18A75C210")]
		private static Dictionary<string, JsonSerializable> _ToDictionary(JsonSerializable context, IEnumerable<JsonSerializable> serializables)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0xA75B220", Offset = "0xA75A220", VA = "0x18A75B220", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0xA75BF30", Offset = "0xA75AF30", VA = "0x18A75BF30")]
		private static void _DeserializeExtensions(JsonSerializable parent, Utf8JsonReader reader, List<JsonSerializable> extensions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0xA75C4E0", Offset = "0xA75B4E0", VA = "0x18A75C4E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000B59")]
			[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public bool HasDefaultContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0xA760760", Offset = "0xA75F760", VA = "0x18A760760")]
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
			[Cpp2IlInjected.Address(RVA = "0xA760770", Offset = "0xA75F770", VA = "0x18A760770")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xA760B10", Offset = "0xA75FB10", VA = "0x18A760B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public IReadOnlyList<IMaterialParameter> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public Texture Texture
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0xA760850", Offset = "0xA75F850", VA = "0x18A760850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public TextureSampler TextureSampler
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0xA7607E0", Offset = "0xA75F7E0", VA = "0x18A7607E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0xA7607D0", Offset = "0xA75F7D0", VA = "0x18A7607D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0xA760810", Offset = "0xA75F810", VA = "0x18A760810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0xA760530", Offset = "0xA75F530", VA = "0x18A760530")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0xA7608E0", Offset = "0xA75F8E0", VA = "0x18A7608E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0xA760310", Offset = "0xA75F310", VA = "0x18A760310")]
		internal MaterialChannel(Material m, string key, _MaterialTexture texInfo, params IMaterialParameter[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0xA75FB60", Offset = "0xA75EB60", VA = "0x18A75FB60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0xA75F930", Offset = "0xA75E930", VA = "0x18A75F930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0xA75F9F0", Offset = "0xA75E9F0", VA = "0x18A75F9F0", Slot = "4")]
		public bool Equals(MaterialChannel other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0xA760860", Offset = "0xA75F860", VA = "0x18A760860")]
		public static bool operator ==([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0xA7608A0", Offset = "0xA75F8A0", VA = "0x18A7608A0")]
		public static bool operator !=([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0xA75FA30", Offset = "0xA75EA30", VA = "0x18A75FA30")]
		public float GetFactor(string key)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0xA75FBC0", Offset = "0xA75EBC0", VA = "0x18A75FBC0")]
		public void SetFactor(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0xA760210", Offset = "0xA75F210", VA = "0x18A760210")]
		private Texture _GetTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0xA75FD00", Offset = "0xA75ED00", VA = "0x18A75FD00")]
		public Texture SetTexture(int texCoord, Image primaryImg, [Optional] Image fallbackImg, TextureWrapMode ws = TextureWrapMode.REPEAT, TextureWrapMode wt = TextureWrapMode.REPEAT, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0xA75FEB0", Offset = "0xA75EEB0", VA = "0x18A75FEB0")]
		public void SetTexture(int texSet, Texture tex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0xA760000", Offset = "0xA75F000", VA = "0x18A760000")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0xA7600D0", Offset = "0xA75F0D0", VA = "0x18A7600D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BA9A40", Offset = "0x3BA8A40", VA = "0x183BA9A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public TextureInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000B76")]
			[Cpp2IlInjected.Address(RVA = "0xA777A00", Offset = "0xA776A00", VA = "0x18A777A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B77")]
			[Cpp2IlInjected.Address(RVA = "0xA777A20", Offset = "0xA776A20", VA = "0x18A777A20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0xA777AB0", Offset = "0xA776AB0", VA = "0x18A777AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0xA777AF0", Offset = "0xA776AF0", VA = "0x18A777AF0")]
		public static implicit operator _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
			return default(_MaterialTexture);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0xA777800", Offset = "0xA776800", VA = "0x18A777800")]
		public _MaterialTexture(Func<TextureInfo> getter, Action initialize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0xA7778F0", Offset = "0xA7768F0", VA = "0x18A7778F0")]
		public _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xA7777E0", Offset = "0xA7767E0", VA = "0x18A7777E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x51B55B0", Offset = "0x51B45B0", VA = "0x1851B55B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x51B5100", Offset = "0x51B4100", VA = "0x1851B5100", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000B87")]
			[Cpp2IlInjected.Address(RVA = "0x51B59C0", Offset = "0x51B49C0", VA = "0x1851B59C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x51B5C80", Offset = "0x51B4C80", VA = "0x1851B5C80")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x51B5EB0", Offset = "0x51B4EB0", VA = "0x1851B5EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		object IMaterialParameter.Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0x51B3D00", Offset = "0x51B2D00", VA = "0x1851B3D00", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8B")]
			[Cpp2IlInjected.Address(RVA = "0x51B4160", Offset = "0x51B3160", VA = "0x1851B4160", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x51B4B20", Offset = "0x51B3B20", VA = "0x1851B4B20")]
		internal _MaterialParameter(_MaterialParameterKey key, T defval, Func<T> getter, Action<T> setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x51B2C80", Offset = "0x51B1C80", VA = "0x1851B2C80")]
		internal static Vector4 Combine(IReadOnlyList<IMaterialParameter> parameters)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x51B0980", Offset = "0x51AF980", VA = "0x1851B0980")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76B4D0", Offset = "0xA76A4D0", VA = "0x18A76B4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public bool HasMorphingCurves
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0xE220E0", Offset = "0xE210E0", VA = "0x180E220E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public IAnimationSampler<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public IAnimationSampler<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public IAnimationSampler<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76B530", Offset = "0xA76A530", VA = "0x18A76B530")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76B4F0", Offset = "0xA76A4F0", VA = "0x18A76B4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public IAnimationSampler<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0xA76AFB0", Offset = "0xA769FB0", VA = "0x18A76AFB0")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0xA76B160", Offset = "0xA76A160", VA = "0x18A76B160")]
		internal NodeCurveSamplers(Node node, Animation animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B220", Offset = "0x7E5A220", VA = "0x187E5B220", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0xA76A830", Offset = "0xA769830", VA = "0x18A76A830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0xA76B570", Offset = "0xA76A570", VA = "0x18A76B570")]
		public static bool operator ==([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0xA76B5A0", Offset = "0xA76A5A0", VA = "0x18A76B5A0")]
		public static bool operator !=([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0xA76A800", Offset = "0xA769800", VA = "0x18A76A800", Slot = "4")]
		public bool Equals(NodeCurveSamplers other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x37ED600", Offset = "0x37EC600", VA = "0x1837ED600")]
		public IAnimationSampler<TWeights> GetMorphingSampler<TWeights>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0xA76A8B0", Offset = "0xA7698B0", VA = "0x18A76A8B0")]
		public AffineTransform GetLocalTransform(float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x3D96780", Offset = "0x3D95780", VA = "0x183D96780")]
		public IReadOnlyList<float> GetMorphingWeights<TWeight>(float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0xA76AD60", Offset = "0xA769D60", VA = "0x18A76AD60")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7769D0", Offset = "0xA7759D0", VA = "0x18A7769D0")]
		public static Memory<byte> ReadBytesToEnd(this Stream s)
		{
			return default(Memory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0xA7774F0", Offset = "0xA7764F0", VA = "0x18A7774F0")]
		internal static bool _TryReadUInt32(this BinaryReader r, [Out] uint result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0xA777030", Offset = "0xA776030", VA = "0x18A777030")]
		internal static bool _Identify(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0xA776380", Offset = "0xA775380", VA = "0x18A776380")]
		internal static bool IsBinaryHeader(ReadOnlySpan<byte> span)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0xA776410", Offset = "0xA775410", VA = "0x18A776410")]
		public static bool IsBinaryHeader(byte a, byte b, byte c, byte d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0xA776440", Offset = "0xA775440", VA = "0x18A776440")]
		public static IReadOnlyDictionary<uint, byte[]> ReadBinaryFile(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0xA7771F0", Offset = "0xA7761F0", VA = "0x18A7771F0")]
		private static long _ReadBinaryHeader(BinaryReader binaryReader)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0xA776200", Offset = "0xA775200", VA = "0x18A776200")]
		public static Exception IsBinaryCompatible(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0xA776D00", Offset = "0xA775D00", VA = "0x18A776D00")]
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
			[Cpp2IlInjected.Address(RVA = "0xF6C200", Offset = "0xF6B200", VA = "0x180F6C200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(RVA = "0xF6BDA0", Offset = "0xF6ADA0", VA = "0x180F6BDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0xA76C190", Offset = "0xA76B190", VA = "0x18A76C190")]
		public static ReadContext Create(FileReaderCallback callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0xA76BED0", Offset = "0xA76AED0", VA = "0x18A76BED0")]
		public static ReadContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0xA76BD50", Offset = "0xA76AD50", VA = "0x18A76BD50")]
		public static ReadContext CreateFromDictionary(IReadOnlyDictionary<string, ArraySegment<byte>> dictionary, bool checkExtensions = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0xA76E540", Offset = "0xA76D540", VA = "0x18A76E540")]
		private ReadContext(FileReaderCallback reader, [Optional] UriResolver uriResolver, bool checkExtensions = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0xA76D650", Offset = "0xA76C650", VA = "0x18A76D650")]
		public ReadContext WithSettingsFrom(ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0xA76E5B0", Offset = "0xA76D5B0", VA = "0x18A76E5B0")]
		internal ReadContext(ReadContext other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0xA76D260", Offset = "0xA76C260", VA = "0x18A76D260")]
		public bool TryGetFullPath(string relativeUri, [Out] string fullPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0xA76C350", Offset = "0xA76B350", VA = "0x18A76C350")]
		public Stream OpenFile(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0xA76C480", Offset = "0xA76B480", VA = "0x18A76C480")]
		public ArraySegment<byte> ReadAllBytesToEnd(string resourceName)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0xA76D2C0", Offset = "0xA76C2C0", VA = "0x18A76D2C0")]
		public ValidationResult Validate(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0xA76CAC0", Offset = "0xA76BAC0", VA = "0x18A76CAC0")]
		public ModelRoot ReadSchema2(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0xA76CD20", Offset = "0xA76BD20", VA = "0x18A76CD20")]
		public ModelRoot ReadSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0xA76D090", Offset = "0xA76C090", VA = "0x18A76D090")]
		public ModelRoot ReadTextSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0xA76C540", Offset = "0xA76B540", VA = "0x18A76C540")]
		public ModelRoot ReadBinarySchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0xA76D730", Offset = "0xA76C730", VA = "0x18A76D730")]
		private static ModelRoot _FilterErrors((ModelRoot Model, ValidationResult Validation) mv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0xA76D8F0", Offset = "0xA76C8F0", VA = "0x18A76D8F0")]
		private (ModelRoot, ValidationResult) _ReadGLB(Stream stream)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0xA76DD30", Offset = "0xA76CD30", VA = "0x18A76DD30")]
		private (ModelRoot, ValidationResult) _Read(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0xA76D7B0", Offset = "0xA76C7B0", VA = "0x18A76D7B0")]
		private ReadOnlyMemory<byte> _Preprocess(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default(ReadOnlyMemory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0xA76C2A0", Offset = "0xA76B2A0", VA = "0x18A76C2A0")]
		public static bool IdentifyBinaryContainer(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0xA76C870", Offset = "0xA76B870", VA = "0x18A76C870")]
		public static string ReadJson(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0xA76C6D0", Offset = "0xA76B6D0", VA = "0x18A76C6D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0xD0CAC0", Offset = "0xD0BAC0", VA = "0x180D0CAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public ImageDecodeCallback ImageDecoder
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE3")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public JsonFilterCallback JsonPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0xA76E910", Offset = "0xA76D910", VA = "0x18A76E910")]
		public static implicit operator ReadSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0xA76E900", Offset = "0xA76D900", VA = "0x18A76E900")]
		public ReadSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0xA76E7E0", Offset = "0xA76D7E0", VA = "0x18A76E7E0")]
		public ReadSettings(ReadSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0xA76E700", Offset = "0xA76D700", VA = "0x18A76E700")]
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
			[Cpp2IlInjected.Address(RVA = "0xD09150", Offset = "0xD08150", VA = "0x180D09150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0xD09160", Offset = "0xD08160", VA = "0x180D09160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		internal bool _UpdateSupportedExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFA")]
			[Cpp2IlInjected.Address(RVA = "0xD0F430", Offset = "0xD0E430", VA = "0x180D0F430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFB")]
			[Cpp2IlInjected.Address(RVA = "0xD0F410", Offset = "0xD0E410", VA = "0x180D0F410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		internal bool _NoCloneWatchdog
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFC")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3D0", Offset = "0xD0E3D0", VA = "0x180D0F3D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFD")]
			[Cpp2IlInjected.Address(RVA = "0xD0FD00", Offset = "0xD0ED00", VA = "0x180D0FD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0xA774AE0", Offset = "0xA773AE0", VA = "0x18A774AE0")]
		public static WriteContext Create(FileWriterCallback fileCallback, [Optional] Func<string, Stream> streamWriteCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0xA774660", Offset = "0xA773660", VA = "0x18A774660")]
		public static WriteContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0xA774490", Offset = "0xA773490", VA = "0x18A774490")]
		public static WriteContext CreateFromDictionary(IDictionary<string, ArraySegment<byte>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0xA7748A0", Offset = "0xA7738A0", VA = "0x18A7748A0")]
		public static WriteContext CreateFromStream(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0xA774C80", Offset = "0xA773C80", VA = "0x18A774C80")]
		public WriteContext WithTextSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0xA774C00", Offset = "0xA773C00", VA = "0x18A774C00")]
		public WriteContext WithBinarySettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0xA774C50", Offset = "0xA773C50", VA = "0x18A774C50")]
		public WriteContext WithSettingsFrom(WriteSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0xA774C40", Offset = "0xA773C40", VA = "0x18A774C40")]
		internal WriteContext WithDeepCloneSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0xA775F00", Offset = "0xA774F00", VA = "0x18A775F00")]
		private WriteContext(FileWriterCallback byteWriteCallback, Func<string, Stream> streamWriteCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0xA774CA0", Offset = "0xA773CA0", VA = "0x18A774CA0")]
		public void WriteAllBytesToEnd(string fileName, ArraySegment<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0xA7752A0", Offset = "0xA7742A0", VA = "0x18A7752A0")]
		public string WriteImage(string assetName, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0xA7754D0", Offset = "0xA7744D0", VA = "0x18A7754D0")]
		public void WriteTextSchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0xA774CE0", Offset = "0xA773CE0", VA = "0x18A774CE0")]
		public void WriteBinarySchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0xA775D80", Offset = "0xA774D80", VA = "0x18A775D80")]
		private void _ValidateBeforeWriting(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0xA775970", Offset = "0xA774970", VA = "0x18A775970")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
			[CompilerGenerated]
			get
			{
				return default(ResourceWriteMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0xD60B30", Offset = "0xD5FB30", VA = "0x180D60B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public ImageWriterCallback ImageWriteCallback
		{
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000C15")]
			[Cpp2IlInjected.Address(RVA = "0xD69190", Offset = "0xD68190", VA = "0x180D69190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C16")]
			[Cpp2IlInjected.Address(RVA = "0xD6A4F0", Offset = "0xD694F0", VA = "0x180D6A4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public int BuffersMaxSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000C17")]
			[Cpp2IlInjected.Address(RVA = "0xD5A350", Offset = "0xD59350", VA = "0x180D5A350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C18")]
			[Cpp2IlInjected.Address(RVA = "0x16F3910", Offset = "0x16F2910", VA = "0x1816F3910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public bool JsonIndented
		{
			[Cpp2IlInjected.Token(Token = "0x6000C19")]
			[Cpp2IlInjected.Address(RVA = "0xA776170", Offset = "0xA775170", VA = "0x18A776170")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1A")]
			[Cpp2IlInjected.Address(RVA = "0xA7761F0", Offset = "0xA7751F0", VA = "0x18A7761F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public JsonWriterOptions JsonOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1B")]
			[Cpp2IlInjected.Address(RVA = "0xF1C290", Offset = "0xF1B290", VA = "0x180F1C290")]
			get
			{
				return default(JsonWriterOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0x4B81DB0", Offset = "0x4B80DB0", VA = "0x184B81DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public ValidationMode Validation
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(RVA = "0xD3A1E0", Offset = "0xD391E0", VA = "0x180D3A1E0")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(RVA = "0xE04F50", Offset = "0xE03F50", VA = "0x180E04F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public JsonFilterCallback JsonPostprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1F")]
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C20")]
			[Cpp2IlInjected.Address(RVA = "0xD0F420", Offset = "0xD0E420", VA = "0x180D0F420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0xA776180", Offset = "0xA775180", VA = "0x18A776180")]
		public static implicit operator WriteSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0xA776070", Offset = "0xA775070", VA = "0x18A776070")]
		public WriteSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0xA776090", Offset = "0xA775090", VA = "0x18A776090")]
		public WriteSettings(WriteSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0xA775F70", Offset = "0xA774F70", VA = "0x18A775F70")]
		public void CopyTo(WriteSettings other)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	internal static class _Schema2Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0xA7785C0", Offset = "0xA7775C0", VA = "0x18A7785C0")]
		public static void SetMorphWeights(this IList<double> list, int maxCount, SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0xA778000", Offset = "0xA777000", VA = "0x18A778000")]
		public static void SetMorphWeights(this IList<double> list, IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0xA777B10", Offset = "0xA776B10", VA = "0x18A777B10")]
		internal static string AsName(this string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x416FAD0", Offset = "0x416EAD0", VA = "0x18416FAD0")]
		internal static T AsValue<T>(this T? value, T defval) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x416E890", Offset = "0x416D890", VA = "0x18416E890")]
		internal static T? AsNullable<T>(this T value, T defval) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x416E940", Offset = "0x416D940", VA = "0x18416E940")]
		internal static T? AsNullable<T>(this T value, T defval, T minval, T maxval) where T : struct, IEquatable<T>, IComparable<T>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0xA777B40", Offset = "0xA776B40", VA = "0x18A777B40")]
		internal static Vector2? AsNullable(this Vector2 value, Vector2 defval, Vector2 minval, Vector2 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0xA777C70", Offset = "0xA776C70", VA = "0x18A777C70")]
		internal static Vector3? AsNullable(this Vector3 value, Vector3 defval, Vector3 minval, Vector3 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0xA777E00", Offset = "0xA776E00", VA = "0x18A777E00")]
		internal static Vector4? AsNullable(this Vector4 value, Vector4 defval, Vector4 minval, Vector4 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0xA777FD0", Offset = "0xA776FD0", VA = "0x18A777FD0")]
		internal static string AsNullable(this string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0xA777B10", Offset = "0xA776B10", VA = "0x18A777B10")]
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
			[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA75C8E0", Offset = "0xA75B8E0", VA = "0x18A75C8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA75C8F0", Offset = "0xA75B8F0", VA = "0x18A75C8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2D")]
		[Cpp2IlInjected.Address(RVA = "0xA75C780", Offset = "0xA75B780", VA = "0x18A75C780")]
		public static void Verify(IReflectionObject reflectionObject, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2E")]
		[Cpp2IlInjected.Address(RVA = "0xA75C5A0", Offset = "0xA75B5A0", VA = "0x18A75C5A0")]
		public static FieldInfo From(IReflectionObject reflectionObject, string path)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4DF0", Offset = "0x3AE3DF0", VA = "0x183AE4DF0")]
		public static FieldInfo From<TInstance, TValue>(string name, TInstance instance, Func<TInstance, TValue> getter)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0xA75C870", Offset = "0xA75B870", VA = "0x18A75C870")]
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
				[Cpp2IlInjected.Address(RVA = "0x5165E40", Offset = "0x5164E40", VA = "0x185165E40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA771520", Offset = "0xA770520", VA = "0x18A771520", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C44")]
			[Cpp2IlInjected.Address(RVA = "0x519A500", Offset = "0x5199500", VA = "0x18519A500")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C45")]
			[Cpp2IlInjected.Address(RVA = "0xA771570", Offset = "0xA770570", VA = "0x18A771570", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0xA7711E0", Offset = "0xA7701E0", VA = "0x18A7711E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0xA771630", Offset = "0xA770630", VA = "0x18A771630")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0xA7714E0", Offset = "0xA7704E0", VA = "0x18A7714E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4B")]
			[Cpp2IlInjected.Address(RVA = "0xA771440", Offset = "0xA770440", VA = "0x18A771440", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0xA771440", Offset = "0xA770440", VA = "0x18A771440", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public const string SCHEMANAME = "Object";

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0xA75F850", Offset = "0xA75E850", VA = "0x18A75F850", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0xA75BE90", Offset = "0xA75AE90", VA = "0x18A75BE90", Slot = "11")]
		protected virtual IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0xA75F920", Offset = "0xA75E920", VA = "0x18A75F920", Slot = "12")]
		protected virtual bool TryReflectField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0xA75F880", Offset = "0xA75E880", VA = "0x18A75F880", Slot = "9")]
		[IteratorStateMachine(typeof(<SharpGLTF-Reflection-IReflectionObject-GetFields>d__4))]
		IEnumerable<FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0xA75F900", Offset = "0xA75E900", VA = "0x18A75F900", Slot = "10")]
		bool IReflectionObject.TryGetField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0xA75F840", Offset = "0xA75E840", VA = "0x18A75F840", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7588C0", Offset = "0xA7578C0", VA = "0x18A7588C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0xA7582D0", Offset = "0xA7572D0", VA = "0x18A7582D0")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0xA758A20", Offset = "0xA757A20", VA = "0x18A758A20")]
		public static implicit operator AttributeFormat(IndexEncodingType indexer)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0xA758950", Offset = "0xA757950", VA = "0x18A758950")]
		public static implicit operator AttributeFormat(EncodingType enc)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0xA7589D0", Offset = "0xA7579D0", VA = "0x18A7589D0")]
		public static implicit operator AttributeFormat(DimensionType dim)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0xA758A70", Offset = "0xA757A70", VA = "0x18A758A70")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0xA758990", Offset = "0xA757990", VA = "0x18A758990")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc, bool nrm) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0xA758820", Offset = "0xA757820", VA = "0x18A758820")]
		public AttributeFormat(IndexEncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0xA7586D0", Offset = "0xA7576D0", VA = "0x18A7586D0")]
		public AttributeFormat(EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0xA758870", Offset = "0xA757870", VA = "0x18A758870")]
		public AttributeFormat(DimensionType dim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0xA758710", Offset = "0xA757710", VA = "0x18A758710")]
		public AttributeFormat(DimensionType dim, EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0xA758750", Offset = "0xA757750", VA = "0x18A758750")]
		public AttributeFormat(DimensionType dim, EncodingType enc, bool nrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0xA758260", Offset = "0xA757260", VA = "0x18A758260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0xA7580C0", Offset = "0xA7570C0", VA = "0x18A7580C0")]
		public static bool AreEqual(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0xA7580E0", Offset = "0xA7570E0", VA = "0x18A7580E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0xA7581D0", Offset = "0xA7571D0", VA = "0x18A7581D0", Slot = "4")]
		public bool Equals(AttributeFormat other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0xA7588D0", Offset = "0xA7578D0", VA = "0x18A7588D0")]
		public static bool operator ==(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0xA758AC0", Offset = "0xA757AC0", VA = "0x18A758AC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA759990", Offset = "0xA758990", VA = "0x18A759990")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0xA759860", Offset = "0xA758860", VA = "0x18A759860", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0xA759A10", Offset = "0xA758A10", VA = "0x18A759A10", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0xA759800", Offset = "0xA758800", VA = "0x18A759800")]
		public ColorArray(Memory<byte> source, int byteStride = 0, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0xA7596A0", Offset = "0xA7586A0", VA = "0x18A7596A0")]
		public ColorArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0xA759340", Offset = "0xA758340", VA = "0x18A759340", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0xA7595E0", Offset = "0xA7585E0", VA = "0x18A7595E0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0xA759060", Offset = "0xA758060", VA = "0x18A759060", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0xA759400", Offset = "0xA758400", VA = "0x18A759400", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0xA759100", Offset = "0xA758100", VA = "0x18A759100", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xA759220", Offset = "0xA758220", VA = "0x18A759220")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0xA759560", Offset = "0xA758560", VA = "0x18A759560", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0xA7595A0", Offset = "0xA7585A0", VA = "0x18A7595A0", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0xA7594A0", Offset = "0xA7584A0", VA = "0x18A7594A0", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0xA7594E0", Offset = "0xA7584E0", VA = "0x18A7594E0", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0xA759520", Offset = "0xA758520", VA = "0x18A759520", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x5BF65B0", Offset = "0x5BF55B0", VA = "0x185BF65B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x5BF5D60", Offset = "0x5BF4D60", VA = "0x185BF5D60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x5BF62D0", Offset = "0x5BF52D0", VA = "0x185BF62D0")]
		public EncodedArrayEnumerator(IReadOnlyList<T> accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5B10", Offset = "0x5BF4B10", VA = "0x185BF5B10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5B20", Offset = "0x5BF4B20", VA = "0x185BF5B20", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	internal static class EncodedArrayUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0xA759AB0", Offset = "0xA758AB0", VA = "0x18A759AB0")]
		public static void _CopyTo(this IEnumerable<int> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0xA759D90", Offset = "0xA758D90", VA = "0x18A759D90")]
		public static void _CopyTo(this IEnumerable<bool> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x3954A50", Offset = "0x3953A50", VA = "0x183954A50")]
		public static void _CopyTo<T>(this IEnumerable<T> src, IList<T> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x39565B0", Offset = "0x39555B0", VA = "0x1839565B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA75E680", Offset = "0xA75D680", VA = "0x18A75E680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000C92")]
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C93")]
			[Cpp2IlInjected.Address(RVA = "0xA75E700", Offset = "0xA75D700", VA = "0x18A75E700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C94")]
			[Cpp2IlInjected.Address(RVA = "0xA75E7F0", Offset = "0xA75D7F0", VA = "0x18A75E7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public float this[int rowIndex, int subIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C95")]
			[Cpp2IlInjected.Address(RVA = "0xA75E6C0", Offset = "0xA75D6C0", VA = "0x18A75E6C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C96")]
			[Cpp2IlInjected.Address(RVA = "0xA75E730", Offset = "0xA75D730", VA = "0x18A75E730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0xA75DAA0", Offset = "0xA75CAA0", VA = "0x18A75DAA0")]
		public FloatingAccessor(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0xA75D170", Offset = "0xA75C170", VA = "0x18A75D170")]
		private float _GetValueU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0xA75D950", Offset = "0xA75C950", VA = "0x18A75D950")]
		private void _SetValueU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0xA75CD20", Offset = "0xA75BD20", VA = "0x18A75CD20")]
		private float _GetValueS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0xA75D550", Offset = "0xA75C550", VA = "0x18A75D550")]
		private void _SetValueS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0xA75CE90", Offset = "0xA75BE90", VA = "0x18A75CE90")]
		private float _GetValueU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0xA75D6A0", Offset = "0xA75C6A0", VA = "0x18A75D6A0")]
		private void _SetValueU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0xA75CBB0", Offset = "0xA75BBB0", VA = "0x18A75CBB0")]
		private float _GetValueS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0xA75D400", Offset = "0xA75C400", VA = "0x18A75D400")]
		private void _SetValueS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0xA75D000", Offset = "0xA75C000", VA = "0x18A75D000")]
		private float _GetValueU32(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0xA75D7F0", Offset = "0xA75C7F0", VA = "0x18A75D7F0")]
		private void _SetValueU32(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0xA75CB90", Offset = "0xA75BB90", VA = "0x18A75CB90")]
		private float _GetNormalizedU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0xA75D3F0", Offset = "0xA75C3F0", VA = "0x18A75D3F0")]
		private void _SetNormalizedU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0xA75CAF0", Offset = "0xA75BAF0", VA = "0x18A75CAF0")]
		private float _GetNormalizedS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0xA75D360", Offset = "0xA75C360", VA = "0x18A75D360")]
		private void _SetNormalizedS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0xA75CB70", Offset = "0xA75BB70", VA = "0x18A75CB70")]
		private float _GetNormalizedU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0xA75D3E0", Offset = "0xA75C3E0", VA = "0x18A75D3E0")]
		private void _SetNormalizedU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0xA75CA70", Offset = "0xA75BA70", VA = "0x18A75CA70")]
		private float _GetNormalizedS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0xA75D2E0", Offset = "0xA75C2E0", VA = "0x18A75D2E0")]
		private void _SetNormalizedS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB2A0", Offset = "0x3AEA2A0", VA = "0x183AEB2A0")]
		private T _GetValue<T>(int byteOffset) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBB90", Offset = "0x3AEAB90", VA = "0x183AEBB90")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76F050", Offset = "0xA76E050", VA = "0x18A76F050")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA3")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA4")]
			[Cpp2IlInjected.Address(RVA = "0xA76F020", Offset = "0xA76E020", VA = "0x18A76F020", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA5")]
			[Cpp2IlInjected.Address(RVA = "0xA76F0D0", Offset = "0xA76E0D0", VA = "0x18A76F0D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0xA76EF80", Offset = "0xA76DF80", VA = "0x18A76EF80")]
		public ScalarArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA0")]
		[Cpp2IlInjected.Address(RVA = "0xA76EEE0", Offset = "0xA76DEE0", VA = "0x18A76EEE0")]
		public ScalarArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0xA76EBB0", Offset = "0xA76DBB0", VA = "0x18A76EBB0", Slot = "9")]
		public IEnumerator<float> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0xA76EE30", Offset = "0xA76DE30", VA = "0x18A76EE30", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0xA76E970", Offset = "0xA76D970", VA = "0x18A76E970", Slot = "20")]
		public bool Contains(float item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0xA76EC60", Offset = "0xA76DC60", VA = "0x18A76EC60", Slot = "13")]
		public int IndexOf(float item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0xA76E990", Offset = "0xA76D990", VA = "0x18A76E990", Slot = "21")]
		public void CopyTo(float[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0xA76EAA0", Offset = "0xA76DAA0", VA = "0x18A76EAA0")]
		public void Fill(IEnumerable<float> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0xA76EDB0", Offset = "0xA76DDB0", VA = "0x18A76EDB0", Slot = "14")]
		void IList<float>.Insert(int index, float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAD")]
		[Cpp2IlInjected.Address(RVA = "0xA76EDF0", Offset = "0xA76DDF0", VA = "0x18A76EDF0", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0xA76ECF0", Offset = "0xA76DCF0", VA = "0x18A76ECF0", Slot = "18")]
		void ICollection<float>.Add(float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAF")]
		[Cpp2IlInjected.Address(RVA = "0xA76ED30", Offset = "0xA76DD30", VA = "0x18A76ED30", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0xA76ED70", Offset = "0xA76DD70", VA = "0x18A76ED70", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA773440", Offset = "0xA772440", VA = "0x18A773440")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		bool ICollection<Vector2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB5")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public Vector2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB6")]
			[Cpp2IlInjected.Address(RVA = "0xA7733B0", Offset = "0xA7723B0", VA = "0x18A7733B0", Slot = "11")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB7")]
			[Cpp2IlInjected.Address(RVA = "0xA7734C0", Offset = "0xA7724C0", VA = "0x18A7734C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0xA773310", Offset = "0xA772310", VA = "0x18A773310")]
		public Vector2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0xA773270", Offset = "0xA772270", VA = "0x18A773270")]
		public Vector2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0xA772F40", Offset = "0xA771F40", VA = "0x18A772F40", Slot = "9")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB9")]
		[Cpp2IlInjected.Address(RVA = "0xA7731C0", Offset = "0xA7721C0", VA = "0x18A7731C0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBA")]
		[Cpp2IlInjected.Address(RVA = "0xA772D00", Offset = "0xA771D00", VA = "0x18A772D00", Slot = "20")]
		public bool Contains(Vector2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBB")]
		[Cpp2IlInjected.Address(RVA = "0xA772FF0", Offset = "0xA771FF0", VA = "0x18A772FF0", Slot = "13")]
		public int IndexOf(Vector2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBC")]
		[Cpp2IlInjected.Address(RVA = "0xA772D20", Offset = "0xA771D20", VA = "0x18A772D20", Slot = "21")]
		public void CopyTo(Vector2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBD")]
		[Cpp2IlInjected.Address(RVA = "0xA772E30", Offset = "0xA771E30", VA = "0x18A772E30")]
		public void Fill(IEnumerable<Vector2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBE")]
		[Cpp2IlInjected.Address(RVA = "0xA773140", Offset = "0xA772140", VA = "0x18A773140", Slot = "14")]
		void IList<Vector2>.Insert(int index, Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBF")]
		[Cpp2IlInjected.Address(RVA = "0xA773180", Offset = "0xA772180", VA = "0x18A773180", Slot = "15")]
		void IList<Vector2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC0")]
		[Cpp2IlInjected.Address(RVA = "0xA773080", Offset = "0xA772080", VA = "0x18A773080", Slot = "18")]
		void ICollection<Vector2>.Add(Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC1")]
		[Cpp2IlInjected.Address(RVA = "0xA7730C0", Offset = "0xA7720C0", VA = "0x18A7730C0", Slot = "19")]
		void ICollection<Vector2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC2")]
		[Cpp2IlInjected.Address(RVA = "0xA773100", Offset = "0xA772100", VA = "0x18A773100", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA773D30", Offset = "0xA772D30", VA = "0x18A773D30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		bool ICollection<Vector3>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC7")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public Vector3 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0xA773C60", Offset = "0xA772C60", VA = "0x18A773C60", Slot = "11")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC9")]
			[Cpp2IlInjected.Address(RVA = "0xA773DB0", Offset = "0xA772DB0", VA = "0x18A773DB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC3")]
		[Cpp2IlInjected.Address(RVA = "0xA773B20", Offset = "0xA772B20", VA = "0x18A773B20")]
		public Vector3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC4")]
		[Cpp2IlInjected.Address(RVA = "0xA773BC0", Offset = "0xA772BC0", VA = "0x18A773BC0")]
		public Vector3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCA")]
		[Cpp2IlInjected.Address(RVA = "0xA7737E0", Offset = "0xA7727E0", VA = "0x18A7737E0", Slot = "9")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0xA773A70", Offset = "0xA772A70", VA = "0x18A773A70", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0xA773520", Offset = "0xA772520", VA = "0x18A773520", Slot = "20")]
		public bool Contains(Vector3 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0xA773890", Offset = "0xA772890", VA = "0x18A773890", Slot = "13")]
		public int IndexOf(Vector3 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xA7735C0", Offset = "0xA7725C0", VA = "0x18A7735C0", Slot = "21")]
		public void CopyTo(Vector3[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCF")]
		[Cpp2IlInjected.Address(RVA = "0xA7736D0", Offset = "0xA7726D0", VA = "0x18A7736D0")]
		public void Fill(IEnumerable<Vector3> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD0")]
		[Cpp2IlInjected.Address(RVA = "0xA7739F0", Offset = "0xA7729F0", VA = "0x18A7739F0", Slot = "14")]
		void IList<Vector3>.Insert(int index, Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0xA773A30", Offset = "0xA772A30", VA = "0x18A773A30", Slot = "15")]
		void IList<Vector3>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0xA773930", Offset = "0xA772930", VA = "0x18A773930", Slot = "18")]
		void ICollection<Vector3>.Add(Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0xA773970", Offset = "0xA772970", VA = "0x18A773970", Slot = "19")]
		void ICollection<Vector3>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0xA7739B0", Offset = "0xA7729B0", VA = "0x18A7739B0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA774410", Offset = "0xA773410", VA = "0x18A774410")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD9")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDA")]
			[Cpp2IlInjected.Address(RVA = "0xA76BBB0", Offset = "0xA76ABB0", VA = "0x18A76BBB0", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDB")]
			[Cpp2IlInjected.Address(RVA = "0xA761460", Offset = "0xA760460", VA = "0x18A761460", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0xA761170", Offset = "0xA760170", VA = "0x18A761170")]
		public Vector4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0xA761210", Offset = "0xA760210", VA = "0x18A761210")]
		public Vector4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDC")]
		[Cpp2IlInjected.Address(RVA = "0xA7740E0", Offset = "0xA7730E0", VA = "0x18A7740E0", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDD")]
		[Cpp2IlInjected.Address(RVA = "0xA774360", Offset = "0xA773360", VA = "0x18A774360", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDE")]
		[Cpp2IlInjected.Address(RVA = "0xA773E30", Offset = "0xA772E30", VA = "0x18A773E30", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDF")]
		[Cpp2IlInjected.Address(RVA = "0xA774190", Offset = "0xA773190", VA = "0x18A774190", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE0")]
		[Cpp2IlInjected.Address(RVA = "0xA773EC0", Offset = "0xA772EC0", VA = "0x18A773EC0", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE1")]
		[Cpp2IlInjected.Address(RVA = "0xA773FD0", Offset = "0xA772FD0", VA = "0x18A773FD0")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE2")]
		[Cpp2IlInjected.Address(RVA = "0xA7742E0", Offset = "0xA7732E0", VA = "0x18A7742E0", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE3")]
		[Cpp2IlInjected.Address(RVA = "0xA774320", Offset = "0xA773320", VA = "0x18A774320", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE4")]
		[Cpp2IlInjected.Address(RVA = "0xA774220", Offset = "0xA773220", VA = "0x18A774220", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE5")]
		[Cpp2IlInjected.Address(RVA = "0xA774260", Offset = "0xA773260", VA = "0x18A774260", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0xA7742A0", Offset = "0xA7732A0", VA = "0x18A7742A0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76BCD0", Offset = "0xA76ACD0", VA = "0x18A76BCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		bool ICollection<Quaternion>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEB")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public Quaternion this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEC")]
			[Cpp2IlInjected.Address(RVA = "0xA76BBB0", Offset = "0xA76ABB0", VA = "0x18A76BBB0", Slot = "11")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CED")]
			[Cpp2IlInjected.Address(RVA = "0xA761460", Offset = "0xA760460", VA = "0x18A761460", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0xA761170", Offset = "0xA760170", VA = "0x18A761170")]
		public QuaternionArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0xA761210", Offset = "0xA760210", VA = "0x18A761210")]
		public QuaternionArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0xA76B880", Offset = "0xA76A880", VA = "0x18A76B880", Slot = "9")]
		public IEnumerator<Quaternion> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0xA76BB00", Offset = "0xA76AB00", VA = "0x18A76BB00", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0xA76B5D0", Offset = "0xA76A5D0", VA = "0x18A76B5D0", Slot = "20")]
		public bool Contains(Quaternion item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0xA76B930", Offset = "0xA76A930", VA = "0x18A76B930", Slot = "13")]
		public int IndexOf(Quaternion item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0xA76B660", Offset = "0xA76A660", VA = "0x18A76B660", Slot = "21")]
		public void CopyTo(Quaternion[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xA76B770", Offset = "0xA76A770", VA = "0x18A76B770")]
		public void Fill(IEnumerable<Quaternion> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0xA76BA80", Offset = "0xA76AA80", VA = "0x18A76BA80", Slot = "14")]
		void IList<Quaternion>.Insert(int index, Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0xA76BAC0", Offset = "0xA76AAC0", VA = "0x18A76BAC0", Slot = "15")]
		void IList<Quaternion>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF6")]
		[Cpp2IlInjected.Address(RVA = "0xA76B9C0", Offset = "0xA76A9C0", VA = "0x18A76B9C0", Slot = "18")]
		void ICollection<Quaternion>.Add(Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF7")]
		[Cpp2IlInjected.Address(RVA = "0xA76BA00", Offset = "0xA76AA00", VA = "0x18A76BA00", Slot = "19")]
		void ICollection<Quaternion>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF8")]
		[Cpp2IlInjected.Address(RVA = "0xA76BA40", Offset = "0xA76AA40", VA = "0x18A76BA40", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7613E0", Offset = "0xA7603E0", VA = "0x18A7613E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFD")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFE")]
			[Cpp2IlInjected.Address(RVA = "0xA7612B0", Offset = "0xA7602B0", VA = "0x18A7612B0", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFF")]
			[Cpp2IlInjected.Address(RVA = "0xA761460", Offset = "0xA760460", VA = "0x18A761460", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF9")]
		[Cpp2IlInjected.Address(RVA = "0xA761170", Offset = "0xA760170", VA = "0x18A761170")]
		public Matrix2x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFA")]
		[Cpp2IlInjected.Address(RVA = "0xA761210", Offset = "0xA760210", VA = "0x18A761210")]
		public Matrix2x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D00")]
		[Cpp2IlInjected.Address(RVA = "0xA760E30", Offset = "0xA75FE30", VA = "0x18A760E30", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D01")]
		[Cpp2IlInjected.Address(RVA = "0xA7610C0", Offset = "0xA7600C0", VA = "0x18A7610C0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D02")]
		[Cpp2IlInjected.Address(RVA = "0xA760B70", Offset = "0xA75FB70", VA = "0x18A760B70", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D03")]
		[Cpp2IlInjected.Address(RVA = "0xA760EE0", Offset = "0xA75FEE0", VA = "0x18A760EE0", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D04")]
		[Cpp2IlInjected.Address(RVA = "0xA760C10", Offset = "0xA75FC10", VA = "0x18A760C10", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D05")]
		[Cpp2IlInjected.Address(RVA = "0xA760D20", Offset = "0xA75FD20", VA = "0x18A760D20")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		[Cpp2IlInjected.Address(RVA = "0xA761040", Offset = "0xA760040", VA = "0x18A761040", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D07")]
		[Cpp2IlInjected.Address(RVA = "0xA761080", Offset = "0xA760080", VA = "0x18A761080", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D08")]
		[Cpp2IlInjected.Address(RVA = "0xA760F80", Offset = "0xA75FF80", VA = "0x18A760F80", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D09")]
		[Cpp2IlInjected.Address(RVA = "0xA760FC0", Offset = "0xA75FFC0", VA = "0x18A760FC0", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0A")]
		[Cpp2IlInjected.Address(RVA = "0xA761000", Offset = "0xA760000", VA = "0x18A761000", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA761DE0", Offset = "0xA760DE0", VA = "0x18A761DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0F")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D10")]
			[Cpp2IlInjected.Address(RVA = "0xA761C40", Offset = "0xA760C40", VA = "0x18A761C40", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D11")]
			[Cpp2IlInjected.Address(RVA = "0xA761E60", Offset = "0xA760E60", VA = "0x18A761E60", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0B")]
		[Cpp2IlInjected.Address(RVA = "0xA761B00", Offset = "0xA760B00", VA = "0x18A761B00")]
		public Matrix3x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0C")]
		[Cpp2IlInjected.Address(RVA = "0xA761BA0", Offset = "0xA760BA0", VA = "0x18A761BA0")]
		public Matrix3x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D12")]
		[Cpp2IlInjected.Address(RVA = "0xA7617C0", Offset = "0xA7607C0", VA = "0x18A7617C0", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D13")]
		[Cpp2IlInjected.Address(RVA = "0xA761A50", Offset = "0xA760A50", VA = "0x18A761A50", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D14")]
		[Cpp2IlInjected.Address(RVA = "0xA761500", Offset = "0xA760500", VA = "0x18A761500", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D15")]
		[Cpp2IlInjected.Address(RVA = "0xA761870", Offset = "0xA760870", VA = "0x18A761870", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D16")]
		[Cpp2IlInjected.Address(RVA = "0xA7615A0", Offset = "0xA7605A0", VA = "0x18A7615A0", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D17")]
		[Cpp2IlInjected.Address(RVA = "0xA7616B0", Offset = "0xA7606B0", VA = "0x18A7616B0")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D18")]
		[Cpp2IlInjected.Address(RVA = "0xA7619D0", Offset = "0xA7609D0", VA = "0x18A7619D0", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D19")]
		[Cpp2IlInjected.Address(RVA = "0xA761A10", Offset = "0xA760A10", VA = "0x18A761A10", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1A")]
		[Cpp2IlInjected.Address(RVA = "0xA761910", Offset = "0xA760910", VA = "0x18A761910", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1B")]
		[Cpp2IlInjected.Address(RVA = "0xA761950", Offset = "0xA760950", VA = "0x18A761950", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1C")]
		[Cpp2IlInjected.Address(RVA = "0xA761990", Offset = "0xA760990", VA = "0x18A761990", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7628E0", Offset = "0xA7618E0", VA = "0x18A7628E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D21")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D22")]
			[Cpp2IlInjected.Address(RVA = "0xA762630", Offset = "0xA761630", VA = "0x18A762630", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D23")]
			[Cpp2IlInjected.Address(RVA = "0xA762960", Offset = "0xA761960", VA = "0x18A762960", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1D")]
		[Cpp2IlInjected.Address(RVA = "0xA7624F0", Offset = "0xA7614F0", VA = "0x18A7624F0")]
		public Matrix3x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1E")]
		[Cpp2IlInjected.Address(RVA = "0xA762590", Offset = "0xA761590", VA = "0x18A762590")]
		public Matrix3x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D24")]
		[Cpp2IlInjected.Address(RVA = "0xA762190", Offset = "0xA761190", VA = "0x18A762190", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D25")]
		[Cpp2IlInjected.Address(RVA = "0xA762440", Offset = "0xA761440", VA = "0x18A762440", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D26")]
		[Cpp2IlInjected.Address(RVA = "0xA761F30", Offset = "0xA760F30", VA = "0x18A761F30", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D27")]
		[Cpp2IlInjected.Address(RVA = "0xA762240", Offset = "0xA761240", VA = "0x18A762240", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0xA761F70", Offset = "0xA760F70", VA = "0x18A761F70", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0xA762080", Offset = "0xA761080", VA = "0x18A762080")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0xA7623C0", Offset = "0xA7613C0", VA = "0x18A7623C0", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2B")]
		[Cpp2IlInjected.Address(RVA = "0xA762400", Offset = "0xA761400", VA = "0x18A762400", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2C")]
		[Cpp2IlInjected.Address(RVA = "0xA762300", Offset = "0xA761300", VA = "0x18A762300", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2D")]
		[Cpp2IlInjected.Address(RVA = "0xA762340", Offset = "0xA761340", VA = "0x18A762340", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2E")]
		[Cpp2IlInjected.Address(RVA = "0xA762380", Offset = "0xA761380", VA = "0x18A762380", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7634E0", Offset = "0xA7624E0", VA = "0x18A7634E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D33")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D34")]
			[Cpp2IlInjected.Address(RVA = "0xA763180", Offset = "0xA762180", VA = "0x18A763180", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D35")]
			[Cpp2IlInjected.Address(RVA = "0xA763560", Offset = "0xA762560", VA = "0x18A763560", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2F")]
		[Cpp2IlInjected.Address(RVA = "0xA7630E0", Offset = "0xA7620E0", VA = "0x18A7630E0")]
		public Matrix4x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D30")]
		[Cpp2IlInjected.Address(RVA = "0xA763040", Offset = "0xA762040", VA = "0x18A763040")]
		public Matrix4x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D36")]
		[Cpp2IlInjected.Address(RVA = "0xA762CE0", Offset = "0xA761CE0", VA = "0x18A762CE0", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D37")]
		[Cpp2IlInjected.Address(RVA = "0xA762F90", Offset = "0xA761F90", VA = "0x18A762F90", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D38")]
		[Cpp2IlInjected.Address(RVA = "0xA762A80", Offset = "0xA761A80", VA = "0x18A762A80", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D39")]
		[Cpp2IlInjected.Address(RVA = "0xA762D90", Offset = "0xA761D90", VA = "0x18A762D90", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3A")]
		[Cpp2IlInjected.Address(RVA = "0xA762AC0", Offset = "0xA761AC0", VA = "0x18A762AC0", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3B")]
		[Cpp2IlInjected.Address(RVA = "0xA762BD0", Offset = "0xA761BD0", VA = "0x18A762BD0")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3C")]
		[Cpp2IlInjected.Address(RVA = "0xA762F10", Offset = "0xA761F10", VA = "0x18A762F10", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3D")]
		[Cpp2IlInjected.Address(RVA = "0xA762F50", Offset = "0xA761F50", VA = "0x18A762F50", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3E")]
		[Cpp2IlInjected.Address(RVA = "0xA762E50", Offset = "0xA761E50", VA = "0x18A762E50", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3F")]
		[Cpp2IlInjected.Address(RVA = "0xA762E90", Offset = "0xA761E90", VA = "0x18A762E90", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D40")]
		[Cpp2IlInjected.Address(RVA = "0xA762ED0", Offset = "0xA761ED0", VA = "0x18A762ED0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA764200", Offset = "0xA763200", VA = "0x18A764200")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D45")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D46")]
			[Cpp2IlInjected.Address(RVA = "0xA763DD0", Offset = "0xA762DD0", VA = "0x18A763DD0", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D47")]
			[Cpp2IlInjected.Address(RVA = "0xA764280", Offset = "0xA763280", VA = "0x18A764280", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D41")]
		[Cpp2IlInjected.Address(RVA = "0xA763D30", Offset = "0xA762D30", VA = "0x18A763D30")]
		public Matrix4x4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D42")]
		[Cpp2IlInjected.Address(RVA = "0xA763C90", Offset = "0xA762C90", VA = "0x18A763C90")]
		public Matrix4x4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0xA763930", Offset = "0xA762930", VA = "0x18A763930", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0xA763BE0", Offset = "0xA762BE0", VA = "0x18A763BE0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4A")]
		[Cpp2IlInjected.Address(RVA = "0xA7636D0", Offset = "0xA7626D0", VA = "0x18A7636D0", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4B")]
		[Cpp2IlInjected.Address(RVA = "0xA7639E0", Offset = "0xA7629E0", VA = "0x18A7639E0", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4C")]
		[Cpp2IlInjected.Address(RVA = "0xA763710", Offset = "0xA762710", VA = "0x18A763710", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4D")]
		[Cpp2IlInjected.Address(RVA = "0xA763820", Offset = "0xA762820", VA = "0x18A763820")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4E")]
		[Cpp2IlInjected.Address(RVA = "0xA763B60", Offset = "0xA762B60", VA = "0x18A763B60", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4F")]
		[Cpp2IlInjected.Address(RVA = "0xA763BA0", Offset = "0xA762BA0", VA = "0x18A763BA0", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D50")]
		[Cpp2IlInjected.Address(RVA = "0xA763AA0", Offset = "0xA762AA0", VA = "0x18A763AA0", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D51")]
		[Cpp2IlInjected.Address(RVA = "0xA763AE0", Offset = "0xA762AE0", VA = "0x18A763AE0", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D52")]
		[Cpp2IlInjected.Address(RVA = "0xA763B20", Offset = "0xA762B20", VA = "0x18A763B20", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA76A650", Offset = "0xA769650", VA = "0x18A76A650")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xF6CF10", Offset = "0xF6BF10", VA = "0x180F6CF10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D57")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public float[] this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D58")]
			[Cpp2IlInjected.Address(RVA = "0xA76A5E0", Offset = "0xA7695E0", VA = "0x18A76A5E0", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D59")]
			[Cpp2IlInjected.Address(RVA = "0xA76A6D0", Offset = "0xA7696D0", VA = "0x18A76A6D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D53")]
		[Cpp2IlInjected.Address(RVA = "0xA76A540", Offset = "0xA769540", VA = "0x18A76A540")]
		public MultiArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5A")]
		[Cpp2IlInjected.Address(RVA = "0xA769E80", Offset = "0xA768E80", VA = "0x18A769E80")]
		public void CopyItemTo(int index, float[] dstItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5B")]
		[Cpp2IlInjected.Address(RVA = "0xA76A1F0", Offset = "0xA7691F0", VA = "0x18A76A1F0", Slot = "9")]
		public IEnumerator<float[]> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5C")]
		[Cpp2IlInjected.Address(RVA = "0xA76A480", Offset = "0xA769480", VA = "0x18A76A480", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5D")]
		[Cpp2IlInjected.Address(RVA = "0xA769E60", Offset = "0xA768E60", VA = "0x18A769E60", Slot = "20")]
		public bool Contains(float[] item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5E")]
		[Cpp2IlInjected.Address(RVA = "0xA76A2B0", Offset = "0xA7692B0", VA = "0x18A76A2B0", Slot = "13")]
		public int IndexOf(float[] item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5F")]
		[Cpp2IlInjected.Address(RVA = "0xA769FB0", Offset = "0xA768FB0", VA = "0x18A769FB0", Slot = "21")]
		public void CopyTo(float[][] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D60")]
		[Cpp2IlInjected.Address(RVA = "0xA76A0D0", Offset = "0xA7690D0", VA = "0x18A76A0D0")]
		public void Fill(IEnumerable<float[]> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D61")]
		[Cpp2IlInjected.Address(RVA = "0xA76A400", Offset = "0xA769400", VA = "0x18A76A400", Slot = "14")]
		void IList<float>.Insert(int index, float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0xA76A440", Offset = "0xA769440", VA = "0x18A76A440", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0xA76A340", Offset = "0xA769340", VA = "0x18A76A340", Slot = "18")]
		void ICollection<float>.Add(float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0xA76A380", Offset = "0xA769380", VA = "0x18A76A380", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D65")]
		[Cpp2IlInjected.Address(RVA = "0xA76A3C0", Offset = "0xA7693C0", VA = "0x18A76A3C0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6C")]
			[Cpp2IlInjected.Address(RVA = "0x51A5090", Offset = "0x51A4090", VA = "0x1851A5090", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D6D")]
			[Cpp2IlInjected.Address(RVA = "0x51A3C20", Offset = "0x51A2C20", VA = "0x1851A3C20", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6E")]
			[Cpp2IlInjected.Address(RVA = "0xF6CF10", Offset = "0xF6BF10", VA = "0x180F6CF10", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x51A4CC0", Offset = "0x51A3CC0", VA = "0x1851A4CC0")]
		static ZeroAccessorArray()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6A")]
		[Cpp2IlInjected.Address(RVA = "0x15D7850", Offset = "0x15D6850", VA = "0x1815D7850")]
		public ZeroAccessorArray(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6F")]
		[Cpp2IlInjected.Address(RVA = "0x51A2FC0", Offset = "0x51A1FC0", VA = "0x1851A2FC0", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D70")]
		[Cpp2IlInjected.Address(RVA = "0x51A0C60", Offset = "0x519FC60", VA = "0x1851A0C60", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D71")]
		[Cpp2IlInjected.Address(RVA = "0x51A2050", Offset = "0x51A1050", VA = "0x1851A2050", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D72")]
		[Cpp2IlInjected.Address(RVA = "0x51A29E0", Offset = "0x51A19E0", VA = "0x1851A29E0", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D73")]
		[Cpp2IlInjected.Address(RVA = "0x51A29E0", Offset = "0x51A19E0", VA = "0x1851A29E0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D74")]
		[Cpp2IlInjected.Address(RVA = "0x51A3C20", Offset = "0x51A2C20", VA = "0x1851A3C20", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D75")]
		[Cpp2IlInjected.Address(RVA = "0x5107710", Offset = "0x5106710", VA = "0x185107710", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D76")]
		[Cpp2IlInjected.Address(RVA = "0x5107710", Offset = "0x5106710", VA = "0x185107710", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D77")]
		[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D78")]
		[Cpp2IlInjected.Address(RVA = "0x5107710", Offset = "0x5106710", VA = "0x185107710", Slot = "22")]
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
				[Cpp2IlInjected.Address(RVA = "0x1345890", Offset = "0x1344890", VA = "0x181345890", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8DB2C90", Offset = "0x8DB1C90", VA = "0x188DB2C90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D88")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D89")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8A")]
			[Cpp2IlInjected.Address(RVA = "0xA76F7B0", Offset = "0xA76E7B0", VA = "0x18A76F7B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8C")]
			[Cpp2IlInjected.Address(RVA = "0xA76F850", Offset = "0xA76E850", VA = "0x18A76F850", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8E")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8F")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D90")]
			[Cpp2IlInjected.Address(RVA = "0xA771680", Offset = "0xA770680", VA = "0x18A771680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D92")]
			[Cpp2IlInjected.Address(RVA = "0xA771750", Offset = "0xA770750", VA = "0x18A771750", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xA758F40", Offset = "0xA757F40", VA = "0x18A758F40", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D7B")]
			[Cpp2IlInjected.Address(RVA = "0xA758FF0", Offset = "0xA757FF0", VA = "0x18A758FF0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7C")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7D")]
			[Cpp2IlInjected.Address(RVA = "0xA758EF0", Offset = "0xA757EF0", VA = "0x18A758EF0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D79")]
		[Cpp2IlInjected.Address(RVA = "0xEE3920", Offset = "0xEE2920", VA = "0x180EE3920")]
		public BooleanArrayOverIntegerArray(IAccessorArray<uint> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7E")]
		[Cpp2IlInjected.Address(RVA = "0xA758B40", Offset = "0xA757B40", VA = "0x18A758B40", Slot = "20")]
		public bool Contains(bool item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7F")]
		[Cpp2IlInjected.Address(RVA = "0xA758C80", Offset = "0xA757C80", VA = "0x18A758C80", Slot = "13")]
		public int IndexOf(bool item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D80")]
		[Cpp2IlInjected.Address(RVA = "0xA758B60", Offset = "0xA757B60", VA = "0x18A758B60", Slot = "21")]
		public void CopyTo(bool[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D81")]
		[Cpp2IlInjected.Address(RVA = "0xA758C10", Offset = "0xA757C10", VA = "0x18A758C10", Slot = "9")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__12))]
		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D82")]
		[Cpp2IlInjected.Address(RVA = "0xA758E80", Offset = "0xA757E80", VA = "0x18A758E80", Slot = "10")]
		[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__13))]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D83")]
		[Cpp2IlInjected.Address(RVA = "0xA758E00", Offset = "0xA757E00", VA = "0x18A758E00", Slot = "14")]
		void IList<bool>.Insert(int index, bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D84")]
		[Cpp2IlInjected.Address(RVA = "0xA758E40", Offset = "0xA757E40", VA = "0x18A758E40", Slot = "15")]
		void IList<bool>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D85")]
		[Cpp2IlInjected.Address(RVA = "0xA758D40", Offset = "0xA757D40", VA = "0x18A758D40", Slot = "18")]
		void ICollection<bool>.Add(bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D86")]
		[Cpp2IlInjected.Address(RVA = "0xA758D80", Offset = "0xA757D80", VA = "0x18A758D80", Slot = "19")]
		void ICollection<bool>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D87")]
		[Cpp2IlInjected.Address(RVA = "0xA758DC0", Offset = "0xA757DC0", VA = "0x18A758DC0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA75F7C0", Offset = "0xA75E7C0", VA = "0x18A75F7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA75F780", Offset = "0xA75E780", VA = "0x18A75F780", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		bool ICollection<uint>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9E")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public uint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B29BB0", Offset = "0x2B28BB0", VA = "0x182B29BB0", Slot = "11")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DA0")]
			[Cpp2IlInjected.Address(RVA = "0x88968F0", Offset = "0x88958F0", VA = "0x1888968F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D94")]
		[Cpp2IlInjected.Address(RVA = "0xA75F740", Offset = "0xA75E740", VA = "0x18A75F740")]
		public IntegerArray(Memory<byte> source, IndexEncodingType encoding = IndexEncodingType.UNSIGNED_INT)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D95")]
		[Cpp2IlInjected.Address(RVA = "0xA75F270", Offset = "0xA75E270", VA = "0x18A75F270")]
		public IntegerArray(Memory<byte> source, int byteOffset, int itemsCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D96")]
		[Cpp2IlInjected.Address(RVA = "0xA75F160", Offset = "0xA75E160", VA = "0x18A75F160")]
		private uint _GetValueU8(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D97")]
		[Cpp2IlInjected.Address(RVA = "0xA75F210", Offset = "0xA75E210", VA = "0x18A75F210")]
		private void _SetValueU8(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D98")]
		[Cpp2IlInjected.Address(RVA = "0xA75F110", Offset = "0xA75E110", VA = "0x18A75F110")]
		private uint _GetValueU16(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D99")]
		[Cpp2IlInjected.Address(RVA = "0xA75F1B0", Offset = "0xA75E1B0", VA = "0x18A75F1B0")]
		private void _SetValueU16(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC63D0", Offset = "0x3BC53D0", VA = "0x183BC63D0")]
		private T _GetValue<T>(int index) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9B")]
		[Cpp2IlInjected.Address(RVA = "0x3BC66A0", Offset = "0x3BC56A0", VA = "0x183BC66A0")]
		private void _SetValue<T>(int index, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA1")]
		[Cpp2IlInjected.Address(RVA = "0xA75EDF0", Offset = "0xA75DDF0", VA = "0x18A75EDF0", Slot = "9")]
		public IEnumerator<uint> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA2")]
		[Cpp2IlInjected.Address(RVA = "0xA75F060", Offset = "0xA75E060", VA = "0x18A75F060", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA3")]
		[Cpp2IlInjected.Address(RVA = "0xA75EA80", Offset = "0xA75DA80", VA = "0x18A75EA80", Slot = "20")]
		public bool Contains(uint item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA4")]
		[Cpp2IlInjected.Address(RVA = "0xA75EEA0", Offset = "0xA75DEA0", VA = "0x18A75EEA0", Slot = "13")]
		public int IndexOf(uint item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA5")]
		[Cpp2IlInjected.Address(RVA = "0xA75EAA0", Offset = "0xA75DAA0", VA = "0x18A75EAA0", Slot = "21")]
		public void CopyTo(uint[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA6")]
		[Cpp2IlInjected.Address(RVA = "0xA75EBC0", Offset = "0xA75DBC0", VA = "0x18A75EBC0")]
		public void Fill(IEnumerable<int> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA7")]
		[Cpp2IlInjected.Address(RVA = "0xA75ECD0", Offset = "0xA75DCD0", VA = "0x18A75ECD0")]
		public void Fill(IEnumerable<uint> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA8")]
		[Cpp2IlInjected.Address(RVA = "0xA75EFE0", Offset = "0xA75DFE0", VA = "0x18A75EFE0", Slot = "14")]
		void IList<uint>.Insert(int index, uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA9")]
		[Cpp2IlInjected.Address(RVA = "0xA75F020", Offset = "0xA75E020", VA = "0x18A75F020", Slot = "15")]
		void IList<uint>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAA")]
		[Cpp2IlInjected.Address(RVA = "0xA75EF20", Offset = "0xA75DF20", VA = "0x18A75EF20", Slot = "18")]
		void ICollection<uint>.Add(uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAB")]
		[Cpp2IlInjected.Address(RVA = "0xA75EF60", Offset = "0xA75DF60", VA = "0x18A75EF60", Slot = "19")]
		void ICollection<uint>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAC")]
		[Cpp2IlInjected.Address(RVA = "0xA75EFA0", Offset = "0xA75DFA0", VA = "0x18A75EFA0", Slot = "22")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA3D20", Offset = "0xDA2D20", VA = "0x180DA3D20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA786610", Offset = "0xA785610", VA = "0x18A786610", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF1")]
			[Cpp2IlInjected.Address(RVA = "0x1D1DB60", Offset = "0x1D1CB60", VA = "0x181D1DB60")]
			[DebuggerHidden]
			public <GetItemsAsRawBytes>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF2")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF3")]
			[Cpp2IlInjected.Address(RVA = "0xA7863A0", Offset = "0xA7853A0", VA = "0x18A7863A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF5")]
			[Cpp2IlInjected.Address(RVA = "0xA7865D0", Offset = "0xA7855D0", VA = "0x18A7865D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF7")]
			[Cpp2IlInjected.Address(RVA = "0xA786530", Offset = "0xA785530", VA = "0x18A786530", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ArraySegment<byte>> IEnumerable<ArraySegment<byte>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF8")]
			[Cpp2IlInjected.Address(RVA = "0xA786530", Offset = "0xA785530", VA = "0x18A786530", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xF534D0", Offset = "0xF524D0", VA = "0x180F534D0")]
			[CompilerGenerated]
			get
			{
				return default(MemoryAccessInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBA")]
			[Cpp2IlInjected.Address(RVA = "0x5137250", Offset = "0x5136250", VA = "0x185137250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public ArraySegment<byte> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000DBB")]
			[Cpp2IlInjected.Address(RVA = "0x1687600", Offset = "0x1686600", VA = "0x181687600")]
			[CompilerGenerated]
			get
			{
				return default(ArraySegment<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBC")]
			[Cpp2IlInjected.Address(RVA = "0xA769E40", Offset = "0xA768E40", VA = "0x18A769E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB5")]
		[Cpp2IlInjected.Address(RVA = "0xA7699D0", Offset = "0xA7689D0", VA = "0x18A7699D0")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB6")]
		[Cpp2IlInjected.Address(RVA = "0xA769CC0", Offset = "0xA768CC0", VA = "0x18A769CC0")]
		public MemoryAccessor(byte[] data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB7")]
		[Cpp2IlInjected.Address(RVA = "0xA769DD0", Offset = "0xA768DD0", VA = "0x18A769DD0")]
		public MemoryAccessor(ArraySegment<byte> data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB8")]
		[Cpp2IlInjected.Address(RVA = "0xA769D70", Offset = "0xA768D70", VA = "0x18A769D70")]
		public MemoryAccessor(MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBD")]
		[Cpp2IlInjected.Address(RVA = "0xA767EA0", Offset = "0xA766EA0", VA = "0x18A767EA0")]
		public void Update(ArraySegment<byte> data, MemoryAccessInfo encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBE")]
		[Cpp2IlInjected.Address(RVA = "0x3D1CD30", Offset = "0x3D1BD30", VA = "0x183D1CD30")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBF")]
		[Cpp2IlInjected.Address(RVA = "0xA764720", Offset = "0xA763720", VA = "0x18A764720")]
		public IntegerArray AsIntegerArray()
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC0")]
		[Cpp2IlInjected.Address(RVA = "0xA765790", Offset = "0xA764790", VA = "0x18A765790")]
		public ScalarArray AsScalarArray()
		{
			return default(ScalarArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC1")]
		[Cpp2IlInjected.Address(RVA = "0xA765A00", Offset = "0xA764A00", VA = "0x18A765A00")]
		public Vector2Array AsVector2Array()
		{
			return default(Vector2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC2")]
		[Cpp2IlInjected.Address(RVA = "0xA765C70", Offset = "0xA764C70", VA = "0x18A765C70")]
		public Vector3Array AsVector3Array()
		{
			return default(Vector3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC3")]
		[Cpp2IlInjected.Address(RVA = "0xA765EE0", Offset = "0xA764EE0", VA = "0x18A765EE0")]
		public Vector4Array AsVector4Array()
		{
			return default(Vector4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC4")]
		[Cpp2IlInjected.Address(RVA = "0xA765520", Offset = "0xA764520", VA = "0x18A765520")]
		public QuaternionArray AsQuaternionArray()
		{
			return default(QuaternionArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC5")]
		[Cpp2IlInjected.Address(RVA = "0xA764900", Offset = "0xA763900", VA = "0x18A764900")]
		public Matrix2x2Array AsMatrix2x2Array()
		{
			return default(Matrix2x2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC6")]
		[Cpp2IlInjected.Address(RVA = "0xA764B70", Offset = "0xA763B70", VA = "0x18A764B70")]
		public Matrix3x3Array AsMatrix3x3Array()
		{
			return default(Matrix3x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC7")]
		[Cpp2IlInjected.Address(RVA = "0xA764DE0", Offset = "0xA763DE0", VA = "0x18A764DE0")]
		public Matrix4x3Array AsMatrix4x3Array()
		{
			return default(Matrix4x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC8")]
		[Cpp2IlInjected.Address(RVA = "0xA765010", Offset = "0xA764010", VA = "0x18A765010")]
		public Matrix4x4Array AsMatrix4x4Array()
		{
			return default(Matrix4x4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC9")]
		[Cpp2IlInjected.Address(RVA = "0xA764450", Offset = "0xA763450", VA = "0x18A764450")]
		public ColorArray AsColorArray(float defaultW = 1f)
		{
			return default(ColorArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCA")]
		[Cpp2IlInjected.Address(RVA = "0xA765280", Offset = "0xA764280", VA = "0x18A765280")]
		public MultiArray AsMultiArray(int dimensions)
		{
			return default(MultiArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCB")]
		[Cpp2IlInjected.Address(RVA = "0xA766D20", Offset = "0xA765D20", VA = "0x18A766D20")]
		[IteratorStateMachine(typeof(<GetItemsAsRawBytes>d__26))]
		public IEnumerable<ArraySegment<byte>> GetItemsAsRawBytes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCC")]
		[Cpp2IlInjected.Address(RVA = "0xA766150", Offset = "0xA765150", VA = "0x18A766150")]
		public (MemoryAccessor, MemoryAccessor) ConvertToSparse()
		{
			return default((MemoryAccessor, MemoryAccessor));
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCD")]
		[Cpp2IlInjected.Address(RVA = "0xA7670A0", Offset = "0xA7660A0", VA = "0x18A7670A0")]
		private bool RepresentsZeroValue(ArraySegment<byte> bytes)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCE")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FCF0", Offset = "0x3D1ECF0", VA = "0x183D1FCF0")]
		public static IAccessorArray<T> CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCF")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FEB0", Offset = "0x3D1EEB0", VA = "0x183D1FEB0")]
		public static IAccessorArray<T> CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD0")]
		[Cpp2IlInjected.Address(RVA = "0xA766AE0", Offset = "0xA765AE0", VA = "0x18A766AE0")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD1")]
		[Cpp2IlInjected.Address(RVA = "0xA766C00", Offset = "0xA765C00", VA = "0x18A766C00")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD2")]
		[Cpp2IlInjected.Address(RVA = "0x3D21690", Offset = "0x3D20690", VA = "0x183D21690")]
		private static IAccessorArray<T> _CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD3")]
		[Cpp2IlInjected.Address(RVA = "0x3D213D0", Offset = "0x3D203D0", VA = "0x183D213D0")]
		private static IAccessorArray<T> _CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD4")]
		[Cpp2IlInjected.Address(RVA = "0xA7672F0", Offset = "0xA7662F0", VA = "0x18A7672F0")]
		public static void SanitizeVertexAttributes(MemoryAccessor[] vertexAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD5")]
		[Cpp2IlInjected.Address(RVA = "0xA766E80", Offset = "0xA765E80", VA = "0x18A766E80")]
		public static bool HaveOverlappingBuffers(MemoryAccessor a, MemoryAccessor b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD6")]
		[Cpp2IlInjected.Address(RVA = "0xA769850", Offset = "0xA768850", VA = "0x18A769850")]
		internal ArraySegment<byte> _GetBytes()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD7")]
		[Cpp2IlInjected.Address(RVA = "0xA766DA0", Offset = "0xA765DA0", VA = "0x18A766DA0")]
		public static bool HaveOverlappingBuffers(IEnumerable<MemoryAccessor> abc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD8")]
		[Cpp2IlInjected.Address(RVA = "0xA7674E0", Offset = "0xA7664E0", VA = "0x18A7674E0")]
		public static void SanitizeWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD9")]
		[Cpp2IlInjected.Address(RVA = "0xA769A40", Offset = "0xA768A40", VA = "0x18A769A40")]
		private static bool _SanitizeWeightSum(Span<byte> dst, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDA")]
		[Cpp2IlInjected.Address(RVA = "0xA768CB0", Offset = "0xA767CB0", VA = "0x18A768CB0")]
		public static void VerifyWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDB")]
		[Cpp2IlInjected.Address(RVA = "0xA769610", Offset = "0xA768610", VA = "0x18A769610")]
		private static bool _CheckWeightSum(ReadOnlySpan<byte> src, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDC")]
		[Cpp2IlInjected.Address(RVA = "0xA767F00", Offset = "0xA766F00", VA = "0x18A767F00")]
		public static void VerifyAccessorBounds(MemoryAccessor memory, IReadOnlyList<double> min, IReadOnlyList<double> max)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDD")]
		[Cpp2IlInjected.Address(RVA = "0xA768980", Offset = "0xA767980", VA = "0x18A768980")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7790A0", Offset = "0xA7780A0", VA = "0x18A7790A0", Slot = "4")]
			public int Compare(string x, string y)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0E")]
			[Cpp2IlInjected.Address(RVA = "0xA7790E0", Offset = "0xA7780E0", VA = "0x18A7790E0")]
			private static int _GetSortingScore(string attribute)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public readonly EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000E01")]
			[Cpp2IlInjected.Address(RVA = "0xDF8EE0", Offset = "0xDF7EE0", VA = "0x180DF8EE0")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public readonly bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x6000E02")]
			[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB1930", VA = "0x180EB2930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public readonly int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E03")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public readonly int PaddedByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E04")]
			[Cpp2IlInjected.Address(RVA = "0xA782310", Offset = "0xA781310", VA = "0x18A782310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public readonly int StepByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E05")]
			[Cpp2IlInjected.Address(RVA = "0xA782360", Offset = "0xA781360", VA = "0x18A782360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public readonly bool IsValidVertexAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x6000E06")]
			[Cpp2IlInjected.Address(RVA = "0xA782210", Offset = "0xA781210", VA = "0x18A782210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public readonly bool IsValidIndexer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E07")]
			[Cpp2IlInjected.Address(RVA = "0xA782170", Offset = "0xA781170", VA = "0x18A782170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		internal static IComparer<string> NameComparer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E0A")]
			[Cpp2IlInjected.Address(RVA = "0xA7822C0", Offset = "0xA7812C0", VA = "0x18A7822C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E0B")]
			[Cpp2IlInjected.Address(RVA = "0xA7823C0", Offset = "0xA7813C0", VA = "0x18A7823C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF9")]
		[Cpp2IlInjected.Address(RVA = "0xA781DF0", Offset = "0xA780DF0", VA = "0x18A781DF0")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFA")]
		[Cpp2IlInjected.Address(RVA = "0xA781710", Offset = "0xA780710", VA = "0x18A781710")]
		public static MemoryAccessInfo[] Create(params string[] attributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFB")]
		[Cpp2IlInjected.Address(RVA = "0xA780F50", Offset = "0xA77FF50", VA = "0x18A780F50")]
		public static MemoryAccessInfo CreateDefaultElement(string attribute)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFC")]
		[Cpp2IlInjected.Address(RVA = "0xA782120", Offset = "0xA781120", VA = "0x18A782120")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFD")]
		[Cpp2IlInjected.Address(RVA = "0xA782020", Offset = "0xA781020", VA = "0x18A782020")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, DimensionType dimensions, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFE")]
		[Cpp2IlInjected.Address(RVA = "0xA781C50", Offset = "0xA780C50", VA = "0x18A781C50")]
		public readonly MemoryAccessInfo Slice(int itemStart, int itemCount)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFF")]
		[Cpp2IlInjected.Address(RVA = "0xA781D70", Offset = "0xA780D70", VA = "0x18A781D70")]
		public readonly MemoryAccessInfo WithFormat(AttributeFormat newFormat)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E08")]
		[Cpp2IlInjected.Address(RVA = "0xA781840", Offset = "0xA780840", VA = "0x18A781840")]
		public static int SetInterleavedInfo(MemoryAccessInfo[] attributes, int byteOffset, int itemsCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E09")]
		[Cpp2IlInjected.Address(RVA = "0xA781A90", Offset = "0xA780A90", VA = "0x18A781A90")]
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
			[Cpp2IlInjected.Address(RVA = "0xA785440", Offset = "0xA784440", VA = "0x18A785440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public static MemoryImage Empty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E15")]
			[Cpp2IlInjected.Address(RVA = "0x111A210", Offset = "0x1119210", VA = "0x18111A210")]
			get
			{
				return default(MemoryImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		private ArraySegment<byte> _Image
		{
			[Cpp2IlInjected.Token(Token = "0x6000E25")]
			[Cpp2IlInjected.Address(RVA = "0xA785E70", Offset = "0xA784E70", VA = "0x18A785E70")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2C")]
			[Cpp2IlInjected.Address(RVA = "0xA785740", Offset = "0xA784740", VA = "0x18A785740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public ReadOnlyMemory<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2D")]
			[Cpp2IlInjected.Address(RVA = "0xA785370", Offset = "0xA784370", VA = "0x18A785370")]
			get
			{
				return default(ReadOnlyMemory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public string SourcePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2E")]
			[Cpp2IlInjected.Address(RVA = "0xF429D0", Offset = "0xF419D0", VA = "0x180F429D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public bool IsPng
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2F")]
			[Cpp2IlInjected.Address(RVA = "0xA785A90", Offset = "0xA784A90", VA = "0x18A785A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public bool IsJpg
		{
			[Cpp2IlInjected.Token(Token = "0x6000E30")]
			[Cpp2IlInjected.Address(RVA = "0xA7858B0", Offset = "0xA7848B0", VA = "0x18A7858B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public bool IsDds
		{
			[Cpp2IlInjected.Token(Token = "0x6000E31")]
			[Cpp2IlInjected.Address(RVA = "0xA785680", Offset = "0xA784680", VA = "0x18A785680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public bool IsWebp
		{
			[Cpp2IlInjected.Token(Token = "0x6000E32")]
			[Cpp2IlInjected.Address(RVA = "0xA785BD0", Offset = "0xA784BD0", VA = "0x18A785BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public bool IsKtx2
		{
			[Cpp2IlInjected.Token(Token = "0x6000E33")]
			[Cpp2IlInjected.Address(RVA = "0xA7859D0", Offset = "0xA7849D0", VA = "0x18A7859D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public bool IsExtendedFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000E34")]
			[Cpp2IlInjected.Address(RVA = "0xA785810", Offset = "0xA784810", VA = "0x18A785810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000E35")]
			[Cpp2IlInjected.Address(RVA = "0xA785B50", Offset = "0xA784B50", VA = "0x18A785B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public string FileExtension
		{
			[Cpp2IlInjected.Token(Token = "0x6000E36")]
			[Cpp2IlInjected.Address(RVA = "0xA7854A0", Offset = "0xA7844A0", VA = "0x18A7854A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public string MimeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000E37")]
			[Cpp2IlInjected.Address(RVA = "0xA785C90", Offset = "0xA784C90", VA = "0x18A785C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E13")]
		[Cpp2IlInjected.Address(RVA = "0xA783260", Offset = "0xA782260", VA = "0x18A783260")]
		public string ToDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E16")]
		[Cpp2IlInjected.Address(RVA = "0xA785F60", Offset = "0xA784F60", VA = "0x18A785F60")]
		public static implicit operator MemoryImage(ArraySegment<byte> image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E17")]
		[Cpp2IlInjected.Address(RVA = "0xA785FF0", Offset = "0xA784FF0", VA = "0x18A785FF0")]
		public static implicit operator MemoryImage(byte[] image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E18")]
		[Cpp2IlInjected.Address(RVA = "0xA786010", Offset = "0xA785010", VA = "0x18A786010")]
		public static implicit operator MemoryImage(string filePath)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E19")]
		[Cpp2IlInjected.Address(RVA = "0xA784250", Offset = "0xA783250", VA = "0x18A784250")]
		public static bool TryParseMime64(Uri mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1A")]
		[Cpp2IlInjected.Address(RVA = "0xA783D80", Offset = "0xA782D80", VA = "0x18A783D80")]
		public static bool TryParseMime64(string mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1B")]
		[Cpp2IlInjected.Address(RVA = "0xA785160", Offset = "0xA784160", VA = "0x18A785160")]
		public MemoryImage(ArraySegment<byte> image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1C")]
		[Cpp2IlInjected.Address(RVA = "0xA784F70", Offset = "0xA783F70", VA = "0x18A784F70")]
		public MemoryImage(byte[] image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1D")]
		[Cpp2IlInjected.Address(RVA = "0xA7852C0", Offset = "0xA7842C0", VA = "0x18A7852C0")]
		public MemoryImage(Func<ArraySegment<byte>> factory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1E")]
		[Cpp2IlInjected.Address(RVA = "0xA784FF0", Offset = "0xA783FF0", VA = "0x18A784FF0")]
		public MemoryImage(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1F")]
		[Cpp2IlInjected.Address(RVA = "0xA784EF0", Offset = "0xA783EF0", VA = "0x18A784EF0")]
		internal MemoryImage(byte[] image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E20")]
		[Cpp2IlInjected.Address(RVA = "0xA785230", Offset = "0xA784230", VA = "0x18A785230")]
		internal MemoryImage(ArraySegment<byte> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E21")]
		[Cpp2IlInjected.Address(RVA = "0xA7851E0", Offset = "0xA7841E0", VA = "0x18A7851E0")]
		internal MemoryImage(MemoryImage image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E22")]
		[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
		internal MemoryImage(Lazy<ArraySegment<byte>> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E23")]
		[Cpp2IlInjected.Address(RVA = "0xA784930", Offset = "0xA783930", VA = "0x18A784930")]
		private static Lazy<ArraySegment<byte>> _ToLazy(byte[] bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E24")]
		[Cpp2IlInjected.Address(RVA = "0xA784840", Offset = "0xA783840", VA = "0x18A784840")]
		private static Lazy<ArraySegment<byte>> _ToLazy(ArraySegment<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E26")]
		[Cpp2IlInjected.Address(RVA = "0xA7829B0", Offset = "0xA7819B0", VA = "0x18A7829B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E27")]
		[Cpp2IlInjected.Address(RVA = "0xA782430", Offset = "0xA781430", VA = "0x18A782430")]
		public static bool AreEqual(MemoryImage a, MemoryImage b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E28")]
		[Cpp2IlInjected.Address(RVA = "0xA782860", Offset = "0xA781860", VA = "0x18A782860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E29")]
		[Cpp2IlInjected.Address(RVA = "0xA782930", Offset = "0xA781930", VA = "0x18A782930", Slot = "4")]
		public bool Equals(MemoryImage other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2A")]
		[Cpp2IlInjected.Address(RVA = "0xA785EF0", Offset = "0xA784EF0", VA = "0x18A785EF0")]
		public static bool operator ==(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2B")]
		[Cpp2IlInjected.Address(RVA = "0xA786030", Offset = "0xA785030", VA = "0x18A786030")]
		public static bool operator !=(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E38")]
		[Cpp2IlInjected.Address(RVA = "0xA783BA0", Offset = "0xA782BA0", VA = "0x18A783BA0")]
		public static string TrimImageExtension(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E39")]
		[Cpp2IlInjected.Address(RVA = "0xA7849B0", Offset = "0xA7839B0", VA = "0x18A7849B0")]
		internal static void _Verify(MemoryImage image, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3A")]
		[Cpp2IlInjected.Address(RVA = "0xA782DA0", Offset = "0xA781DA0", VA = "0x18A782DA0")]
		public Stream Open()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3B")]
		[Cpp2IlInjected.Address(RVA = "0xA783000", Offset = "0xA782000", VA = "0x18A783000")]
		public void SaveToFile(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3C")]
		[Cpp2IlInjected.Address(RVA = "0xA7842C0", Offset = "0xA7832C0", VA = "0x18A7842C0")]
		internal ArraySegment<byte> _GetBuffer()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3D")]
		[Cpp2IlInjected.Address(RVA = "0xA7837C0", Offset = "0xA7827C0", VA = "0x18A7837C0")]
		internal string ToMime64(bool withPrefix = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3E")]
		[Cpp2IlInjected.Address(RVA = "0xA782A90", Offset = "0xA781A90", VA = "0x18A782A90")]
		public bool IsImageOfType(string format)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3F")]
		[Cpp2IlInjected.Address(RVA = "0xA784660", Offset = "0xA783660", VA = "0x18A784660")]
		private static bool _IsPngImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E40")]
		[Cpp2IlInjected.Address(RVA = "0xA784580", Offset = "0xA783580", VA = "0x18A784580")]
		private static bool _IsJpgImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E41")]
		[Cpp2IlInjected.Address(RVA = "0xA784370", Offset = "0xA783370", VA = "0x18A784370")]
		private static bool _IsDdsImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E42")]
		[Cpp2IlInjected.Address(RVA = "0xA784710", Offset = "0xA783710", VA = "0x18A784710")]
		private static bool _IsWebpImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E43")]
		[Cpp2IlInjected.Address(RVA = "0xA784600", Offset = "0xA783600", VA = "0x18A784600")]
		private static bool _IsKtx2Image(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E44")]
		[Cpp2IlInjected.Address(RVA = "0xA784420", Offset = "0xA783420", VA = "0x18A784420")]
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
			[Cpp2IlInjected.Address(RVA = "0xA780F30", Offset = "0xA77FF30", VA = "0x18A780F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E49")]
		[Cpp2IlInjected.Address(RVA = "0xA780BB0", Offset = "0xA77FBB0", VA = "0x18A780BB0")]
		public static bool TryGetHeader(IReadOnlyList<byte> data, [Out] Ktx2Header header)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4A")]
		[Cpp2IlInjected.Address(RVA = "0xA780D40", Offset = "0xA77FD40", VA = "0x18A780D40")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B96C60", Offset = "0x7B95C60", VA = "0x187B96C60")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B965A0", Offset = "0x7B955A0", VA = "0x187B965A0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4E")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4F")]
			[Cpp2IlInjected.Address(RVA = "0x7B96AE0", Offset = "0x7B95AE0", VA = "0x187B96AE0", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E50")]
			[Cpp2IlInjected.Address(RVA = "0x7B96D00", Offset = "0x7B95D00", VA = "0x187B96D00", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4B")]
		[Cpp2IlInjected.Address(RVA = "0x7B95E40", Offset = "0x7B94E40", VA = "0x187B95E40")]
		public SparseArray(IReadOnlyList<T> denseValues, IReadOnlyList<T> sparseValues, IReadOnlyList<uint> sparseKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E51")]
		[Cpp2IlInjected.Address(RVA = "0x7B94BA0", Offset = "0x7B93BA0", VA = "0x187B94BA0", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E52")]
		[Cpp2IlInjected.Address(RVA = "0x7B94BA0", Offset = "0x7B93BA0", VA = "0x187B94BA0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E53")]
		[Cpp2IlInjected.Address(RVA = "0x7B944B0", Offset = "0x7B934B0", VA = "0x187B944B0", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E54")]
		[Cpp2IlInjected.Address(RVA = "0x7B94C90", Offset = "0x7B93C90", VA = "0x187B94C90", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E55")]
		[Cpp2IlInjected.Address(RVA = "0x7B94AB0", Offset = "0x7B93AB0", VA = "0x187B94AB0", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E56")]
		[Cpp2IlInjected.Address(RVA = "0x51A3C20", Offset = "0x51A2C20", VA = "0x1851A3C20", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E57")]
		[Cpp2IlInjected.Address(RVA = "0x5107710", Offset = "0x5106710", VA = "0x185107710", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E58")]
		[Cpp2IlInjected.Address(RVA = "0x5107710", Offset = "0x5106710", VA = "0x185107710", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E59")]
		[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5A")]
		[Cpp2IlInjected.Address(RVA = "0x5107710", Offset = "0x5106710", VA = "0x185107710", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x77C0CD0", Offset = "0x77BFCD0", VA = "0x1877C0CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5B")]
		[Cpp2IlInjected.Address(RVA = "0xA780220", Offset = "0xA77F220", VA = "0x18A780220")]
		internal void ValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5C")]
		[Cpp2IlInjected.Address(RVA = "0xA7801C0", Offset = "0xA77F1C0", VA = "0x18A7801C0")]
		internal void ValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "4")]
		protected virtual void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5E")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
		protected virtual void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E60")]
		[Cpp2IlInjected.Address(RVA = "0xA77F1C0", Offset = "0xA77E1C0", VA = "0x18A77F1C0", Slot = "6")]
		protected virtual string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E61")]
		[Cpp2IlInjected.Address(RVA = "0xA7800E0", Offset = "0xA77F0E0", VA = "0x18A7800E0")]
		internal void Serialize(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E62")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void SerializeProperties(Utf8JsonWriter writer);

		[Cpp2IlInjected.Token(Token = "0x6000E63")]
		[Cpp2IlInjected.Address(RVA = "0xA77FEC0", Offset = "0xA77EEC0", VA = "0x18A77FEC0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E64")]
		[Cpp2IlInjected.Address(RVA = "0xA77F1F0", Offset = "0xA77E1F0", VA = "0x18A77F1F0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, bool? value, [Optional] bool? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E65")]
		[Cpp2IlInjected.Address(RVA = "0xA77FF90", Offset = "0xA77EF90", VA = "0x18A77FF90")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, int? value, [Optional] int? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E66")]
		[Cpp2IlInjected.Address(RVA = "0xA77F6A0", Offset = "0xA77E6A0", VA = "0x18A77F6A0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, float? value, [Optional] float? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E67")]
		[Cpp2IlInjected.Address(RVA = "0xA77F9B0", Offset = "0xA77E9B0", VA = "0x18A77F9B0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, double? value, [Optional] double? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E68")]
		[Cpp2IlInjected.Address(RVA = "0xA77F360", Offset = "0xA77E360", VA = "0x18A77F360")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector2? value, [Optional] Vector2? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E69")]
		[Cpp2IlInjected.Address(RVA = "0xA77F4E0", Offset = "0xA77E4E0", VA = "0x18A77F4E0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector3? value, [Optional] Vector3? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6A")]
		[Cpp2IlInjected.Address(RVA = "0xA77F7F0", Offset = "0xA77E7F0", VA = "0x18A77F7F0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector4? value, [Optional] Vector4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6B")]
		[Cpp2IlInjected.Address(RVA = "0xA77FAF0", Offset = "0xA77EAF0", VA = "0x18A77FAF0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Quaternion? value, [Optional] Quaternion? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6C")]
		[Cpp2IlInjected.Address(RVA = "0xA77FCB0", Offset = "0xA77ECB0", VA = "0x18A77FCB0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Matrix4x4? value, [Optional] Matrix4x4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3980", Offset = "0x3BF2980", VA = "0x183BF3980")]
		protected static void SerializePropertyEnumValue<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3370", Offset = "0x3BF2370", VA = "0x183BF3370")]
		protected static void SerializePropertyEnumSymbol<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3BD0", Offset = "0x3BF2BD0", VA = "0x183BF3BD0")]
		protected static void SerializePropertyObject<T>(Utf8JsonWriter writer, string name, T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E70")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1D20", Offset = "0x3BF0D20", VA = "0x183BF1D20")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyList<T> collection, [Optional] int? minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E71")]
		[Cpp2IlInjected.Address(RVA = "0x3BF23E0", Offset = "0x3BF13E0", VA = "0x183BF23E0")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyDictionary<string, T> collection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E72")]
		[Cpp2IlInjected.Address(RVA = "0xA7802F0", Offset = "0xA77F2F0", VA = "0x18A7802F0")]
		private static void _SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E73")]
		[Cpp2IlInjected.Address(RVA = "0xA780280", Offset = "0xA77F280", VA = "0x18A780280")]
		private static bool _IsNullOrEmpty(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E74")]
		[Cpp2IlInjected.Address(RVA = "0xA780480", Offset = "0xA77F480", VA = "0x18A780480")]
		private static void _SerializeValue(Utf8JsonWriter writer, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E75")]
		[Cpp2IlInjected.Address(RVA = "0xA77F080", Offset = "0xA77E080", VA = "0x18A77F080")]
		internal void Deserialize(Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E76")]
		[Cpp2IlInjected.Address(RVA = "0xA77EB60", Offset = "0xA77DB60", VA = "0x18A77EB60")]
		protected static object DeserializeUnknownObject(Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E77")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader);

		[Cpp2IlInjected.Token(Token = "0x6000E78")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1020", Offset = "0x3BF0020", VA = "0x183BF1020")]
		protected static T DeserializePropertyValue<T>(Utf8JsonReader reader)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E79")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1940", Offset = "0x3BF0940", VA = "0x183BF1940")]
		protected static void DeserializePropertyValue<TParent, T>(Utf8JsonReader reader, TParent owner, [Out] T property) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF09A0", Offset = "0x3BEF9A0", VA = "0x183BF09A0")]
		protected static void DeserializePropertyList<TParent, T>(Utf8JsonReader reader, TParent owner, IList<T> list) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7B")]
		[Cpp2IlInjected.Address(RVA = "0x3BF0290", Offset = "0x3BEF290", VA = "0x183BF0290")]
		protected static void DeserializePropertyList<T>(Utf8JsonReader reader, IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF0240", Offset = "0x3BEF240", VA = "0x183BF0240")]
		protected static void DeserializePropertyDictionary<TParent, T>(Utf8JsonReader reader, TParent owner, IDictionary<string, T> dict) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7D")]
		[Cpp2IlInjected.Address(RVA = "0x3BEFF50", Offset = "0x3BEEF50", VA = "0x183BEFF50")]
		protected static void DeserializePropertyDictionary<T>(Utf8JsonReader reader, IDictionary<string, T> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7E")]
		[Cpp2IlInjected.Address(RVA = "0x3BF4070", Offset = "0x3BF3070", VA = "0x183BF4070")]
		private static bool _TryCastValue<T>(Utf8JsonReader reader, [Out] object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7F")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		protected JsonSerializable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal static class _JSonSerializationExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000E80")]
		[Cpp2IlInjected.Address(RVA = "0xA7877D0", Offset = "0xA7867D0", VA = "0x18A7877D0")]
		public static bool AsBoolean([In] this Utf8JsonReader reader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E81")]
		[Cpp2IlInjected.Address(RVA = "0xA787DF0", Offset = "0xA786DF0", VA = "0x18A787DF0")]
		public static string AsString([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E82")]
		[Cpp2IlInjected.Address(RVA = "0xA787900", Offset = "0xA786900", VA = "0x18A787900")]
		public static object AsEnum([In] this Utf8JsonReader reader, Type enumType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E83")]
		[Cpp2IlInjected.Address(RVA = "0xA788150", Offset = "0xA787150", VA = "0x18A788150")]
		public static object GetAnyValue([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E84")]
		[Cpp2IlInjected.Address(RVA = "0xA788460", Offset = "0xA787460", VA = "0x18A788460")]
		public static object GetValueAs([In] this Utf8JsonReader reader, Type vtype)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E85")]
		[Cpp2IlInjected.Address(RVA = "0x415F920", Offset = "0x415E920", VA = "0x18415F920")]
		public static T GetValueAs<T>([In] this Utf8JsonReader reader) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E86")]
		[Cpp2IlInjected.Address(RVA = "0xA789500", Offset = "0xA788500", VA = "0x18A789500")]
		public static bool TryWriteProperty(this Utf8JsonWriter writer, string property, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E87")]
		[Cpp2IlInjected.Address(RVA = "0xA789DA0", Offset = "0xA788DA0", VA = "0x18A789DA0")]
		public static bool TryWriteValue(this Utf8JsonWriter writer, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E88")]
		[Cpp2IlInjected.Address(RVA = "0xA78A7B0", Offset = "0xA7897B0", VA = "0x18A78A7B0")]
		public static void WriteVector2(this Utf8JsonWriter writer, Vector2 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E89")]
		[Cpp2IlInjected.Address(RVA = "0xA78A810", Offset = "0xA789810", VA = "0x18A78A810")]
		public static void WriteVector3(this Utf8JsonWriter writer, Vector3 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8A")]
		[Cpp2IlInjected.Address(RVA = "0xA78A6E0", Offset = "0xA7896E0", VA = "0x18A78A6E0")]
		public static void WriteVector4(this Utf8JsonWriter writer, Vector4 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8B")]
		[Cpp2IlInjected.Address(RVA = "0xA78A6E0", Offset = "0xA7896E0", VA = "0x18A78A6E0")]
		public static void WriteQuaternion(this Utf8JsonWriter writer, Quaternion q)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8C")]
		[Cpp2IlInjected.Address(RVA = "0xA78A5A0", Offset = "0xA7895A0", VA = "0x18A78A5A0")]
		public static void WriteMatrix4x4(this Utf8JsonWriter writer, Matrix4x4 m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8D")]
		[Cpp2IlInjected.Address(RVA = "0xA787CA0", Offset = "0xA786CA0", VA = "0x18A787CA0")]
		public static Uri AsStringUri([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8E")]
		[Cpp2IlInjected.Address(RVA = "0xA78A760", Offset = "0xA789760", VA = "0x18A78A760")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public IReadOnlyDictionary<string, JsonNode> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000E91")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8F")]
		[Cpp2IlInjected.Address(RVA = "0xA786FE0", Offset = "0xA785FE0", VA = "0x18A786FE0")]
		public UnknownNode(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E92")]
		[Cpp2IlInjected.Address(RVA = "0xA786D70", Offset = "0xA785D70", VA = "0x18A786D70", Slot = "8")]
		protected override void DeserializeProperty(string property, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E93")]
		[Cpp2IlInjected.Address(RVA = "0xA786DF0", Offset = "0xA785DF0", VA = "0x18A786DF0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA77D500", Offset = "0xA77C500", VA = "0x18A77D500")]
		internal static string GetAttributeShortName(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E95")]
		[Cpp2IlInjected.Address(RVA = "0xA77DF30", Offset = "0xA77CF30", VA = "0x18A77DF30")]
		public static string ToReport(this MemoryAccessInfo minfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E96")]
		[Cpp2IlInjected.Address(RVA = "0xA77DD40", Offset = "0xA77CD40", VA = "0x18A77DD40")]
		public static string ToReport(this BufferView bv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E97")]
		[Cpp2IlInjected.Address(RVA = "0xA77DC90", Offset = "0xA77CC90", VA = "0x18A77DC90")]
		public static string ToReportShort(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E98")]
		[Cpp2IlInjected.Address(RVA = "0xA77DA20", Offset = "0xA77CA20", VA = "0x18A77DA20")]
		public static string ToReportLong(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E99")]
		[Cpp2IlInjected.Address(RVA = "0xA77E0A0", Offset = "0xA77D0A0", VA = "0x18A77E0A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x51A56B0", Offset = "0x51A46B0", VA = "0x1851A56B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA2")]
		[Cpp2IlInjected.Address(RVA = "0x51A5620", Offset = "0x51A4620", VA = "0x1851A5620")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7877B0", Offset = "0xA7867B0", VA = "0x18A7877B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA6")]
			[Cpp2IlInjected.Address(RVA = "0xA787790", Offset = "0xA786790", VA = "0x18A787790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA7")]
			[Cpp2IlInjected.Address(RVA = "0xA787710", Offset = "0xA786710", VA = "0x18A787710")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7876C0", Offset = "0xA7866C0", VA = "0x18A7876C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA4")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA787130", Offset = "0xA786130", VA = "0x18A787130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public BufferView Source
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAB")]
			[Cpp2IlInjected.Address(RVA = "0xA787570", Offset = "0xA786570", VA = "0x18A787570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public (DimensionType Dimensions, EncodingType Encoding, bool Normalized) Format
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAC")]
			[Cpp2IlInjected.Address(RVA = "0xA787080", Offset = "0xA786080", VA = "0x18A787080")]
			get
			{
				return default((DimensionType, EncodingType, bool));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		public object[] Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAD")]
			[Cpp2IlInjected.Address(RVA = "0xA7871B0", Offset = "0xA7861B0", VA = "0x18A7871B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA9")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FC3A80", Offset = "0x1FC2A80", VA = "0x181FC3A80")]
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
			[Cpp2IlInjected.Address(RVA = "0xA78AAF0", Offset = "0xA789AF0", VA = "0x18A78AAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAE")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA78A8F0", Offset = "0xA7898F0", VA = "0x18A78A8F0")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public (double X, double Y, double Z, double W) Row2
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB3")]
			[Cpp2IlInjected.Address(RVA = "0xA78A970", Offset = "0xA789970", VA = "0x18A78A970")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public (double X, double Y, double Z, double W) Row3
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB4")]
			[Cpp2IlInjected.Address(RVA = "0xA78A9F0", Offset = "0xA7899F0", VA = "0x18A78A9F0")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public (double X, double Y, double Z, double W) Row4
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB5")]
			[Cpp2IlInjected.Address(RVA = "0xA78AA70", Offset = "0xA789A70", VA = "0x18A78AA70")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB1")]
		[Cpp2IlInjected.Address(RVA = "0xA78A880", Offset = "0xA789880", VA = "0x18A78A880")]
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
			[Cpp2IlInjected.Address(RVA = "0x51D5810", Offset = "0x51D4810", VA = "0x1851D5810", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public ICollection<string> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB8")]
			[Cpp2IlInjected.Address(RVA = "0x51D6000", Offset = "0x51D5000", VA = "0x1851D6000", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		IEnumerable<T> IReadOnlyDictionary<string, T>.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB9")]
			[Cpp2IlInjected.Address(RVA = "0x51D58A0", Offset = "0x51D48A0", VA = "0x1851D58A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public ICollection<T> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBA")]
			[Cpp2IlInjected.Address(RVA = "0x51D6080", Offset = "0x51D5080", VA = "0x1851D6080", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBB")]
			[Cpp2IlInjected.Address(RVA = "0x51D5F40", Offset = "0x51D4F40", VA = "0x1851D5F40", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBC")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		public T this[string key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBD")]
			[Cpp2IlInjected.Address(RVA = "0x51D5F70", Offset = "0x51D4F70", VA = "0x1851D5F70", Slot = "12")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EBE")]
			[Cpp2IlInjected.Address(RVA = "0x51D60D0", Offset = "0x51D50D0", VA = "0x1851D60D0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB6")]
		[Cpp2IlInjected.Address(RVA = "0x51D5E70", Offset = "0x51D4E70", VA = "0x1851D5E70")]
		public ChildrenDictionary(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBF")]
		[Cpp2IlInjected.Address(RVA = "0x51D5190", Offset = "0x51D4190", VA = "0x1851D5190", Slot = "23")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC0")]
		[Cpp2IlInjected.Address(RVA = "0x51D5040", Offset = "0x51D4040", VA = "0x1851D5040", Slot = "17")]
		public void Add(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC1")]
		[Cpp2IlInjected.Address(RVA = "0x51D56E0", Offset = "0x51D46E0", VA = "0x1851D56E0", Slot = "18")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC2")]
		[Cpp2IlInjected.Address(RVA = "0x51D53A0", Offset = "0x51D43A0", VA = "0x1851D53A0", Slot = "16")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC3")]
		[Cpp2IlInjected.Address(RVA = "0x51D5AA0", Offset = "0x51D4AA0", VA = "0x1851D5AA0", Slot = "19")]
		public bool TryGetValue(string key, [Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC4")]
		[Cpp2IlInjected.Address(RVA = "0x51D55A0", Offset = "0x51D45A0", VA = "0x1851D55A0", Slot = "10")]
		public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC5")]
		[Cpp2IlInjected.Address(RVA = "0x51D55A0", Offset = "0x51D45A0", VA = "0x1851D55A0", Slot = "11")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC6")]
		[Cpp2IlInjected.Address(RVA = "0x51D5C10", Offset = "0x51D4C10", VA = "0x1851D5C10")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC7")]
		[Cpp2IlInjected.Address(RVA = "0x1090EC0", Offset = "0x108FEC0", VA = "0x181090EC0")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC8")]
		[Cpp2IlInjected.Address(RVA = "0x51D5020", Offset = "0x51D4020", VA = "0x1851D5020", Slot = "22")]
		public void Add(KeyValuePair<string, T> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC9")]
		[Cpp2IlInjected.Address(RVA = "0x51D53D0", Offset = "0x51D43D0", VA = "0x1851D53D0", Slot = "24")]
		public bool Contains(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECA")]
		[Cpp2IlInjected.Address(RVA = "0x51D56C0", Offset = "0x51D46C0", VA = "0x1851D56C0", Slot = "26")]
		public bool Remove(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECB")]
		[Cpp2IlInjected.Address(RVA = "0x51D5410", Offset = "0x51D4410", VA = "0x1851D5410", Slot = "25")]
		public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECC")]
		[Cpp2IlInjected.Address(RVA = "0x51D5620", Offset = "0x51D4620", VA = "0x1851D5620", Slot = "27")]
		public IEnumerable<SharpGLTF.Reflection.FieldInfo> GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECD")]
		[Cpp2IlInjected.Address(RVA = "0x51D5900", Offset = "0x51D4900", VA = "0x1851D5900", Slot = "28")]
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
				[Cpp2IlInjected.Address(RVA = "0x5165E40", Offset = "0x5164E40", VA = "0x185165E40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D63B20", Offset = "0x6D62B20", VA = "0x186D63B20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEB")]
			[Cpp2IlInjected.Address(RVA = "0x519A500", Offset = "0x5199500", VA = "0x18519A500")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEC")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EED")]
			[Cpp2IlInjected.Address(RVA = "0x6D63910", Offset = "0x6D62910", VA = "0x186D63910", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEF")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF1")]
			[Cpp2IlInjected.Address(RVA = "0x66A70F0", Offset = "0x66A60F0", VA = "0x1866A70F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF2")]
			[Cpp2IlInjected.Address(RVA = "0x6D63A60", Offset = "0x6D62A60", VA = "0x186D63A60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x51D7170", Offset = "0x51D6170", VA = "0x1851D7170", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ED5")]
			[Cpp2IlInjected.Address(RVA = "0x51D71F0", Offset = "0x51D61F0", VA = "0x1851D71F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED6")]
			[Cpp2IlInjected.Address(RVA = "0x51D7150", Offset = "0x51D6150", VA = "0x1851D7150", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED3")]
		[Cpp2IlInjected.Address(RVA = "0x51D7080", Offset = "0x51D6080", VA = "0x1851D7080")]
		public ChildrenList(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED8")]
		[Cpp2IlInjected.Address(RVA = "0x51D6480", Offset = "0x51D5480", VA = "0x1851D6480", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED9")]
		[Cpp2IlInjected.Address(RVA = "0x51D6600", Offset = "0x51D5600", VA = "0x1851D6600", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDA")]
		[Cpp2IlInjected.Address(RVA = "0x51D64A0", Offset = "0x51D54A0", VA = "0x1851D64A0", Slot = "14")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDB")]
		[Cpp2IlInjected.Address(RVA = "0x51D60F0", Offset = "0x51D50F0", VA = "0x1851D60F0", Slot = "11")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDC")]
		[Cpp2IlInjected.Address(RVA = "0x51D6270", Offset = "0x51D5270", VA = "0x1851D6270", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDD")]
		[Cpp2IlInjected.Address(RVA = "0x51D6630", Offset = "0x51D5630", VA = "0x1851D6630", Slot = "7")]
		public void Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDE")]
		[Cpp2IlInjected.Address(RVA = "0x51D6A20", Offset = "0x51D5A20", VA = "0x1851D6A20", Slot = "15")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDF")]
		[Cpp2IlInjected.Address(RVA = "0x51D67A0", Offset = "0x51D57A0", VA = "0x1851D67A0", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE0")]
		[Cpp2IlInjected.Address(RVA = "0x51D64C0", Offset = "0x51D54C0", VA = "0x1851D64C0", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE1")]
		[Cpp2IlInjected.Address(RVA = "0x51D64C0", Offset = "0x51D54C0", VA = "0x1851D64C0", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE2")]
		[Cpp2IlInjected.Address(RVA = "0x51D6E50", Offset = "0x51D5E50", VA = "0x1851D6E50")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE3")]
		[Cpp2IlInjected.Address(RVA = "0x1090EC0", Offset = "0x108FEC0", VA = "0x181090EC0")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE4")]
		[Cpp2IlInjected.Address(RVA = "0x51D6C20", Offset = "0x51D5C20", VA = "0x1851D6C20", Slot = "22")]
		[IteratorStateMachine(typeof(ChildrenList<, >.<SharpGLTF-Reflection-IReflectionObject-GetFields>d__22))]
		IEnumerable<SharpGLTF.Reflection.FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE5")]
		[Cpp2IlInjected.Address(RVA = "0x51D6AA0", Offset = "0x51D5AA0", VA = "0x1851D6AA0", Slot = "21")]
		SharpGLTF.Reflection.FieldInfo IReflectionArray.GetField(int index)
		{
			return default(SharpGLTF.Reflection.FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE6")]
		[Cpp2IlInjected.Address(RVA = "0x51D6CB0", Offset = "0x51D5CB0", VA = "0x1851D6CB0", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x51D4F60", Offset = "0x51D3F60", VA = "0x1851D4F60")]
		public ChildSetter(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF4")]
		[Cpp2IlInjected.Address(RVA = "0x36FB120", Offset = "0x36FA120", VA = "0x1836FB120")]
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
			[Cpp2IlInjected.Address(RVA = "0x792EF80", Offset = "0x792DF80", VA = "0x18792EF80", Slot = "6")]
			get
			{
				return (TValueOut)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EFF")]
			[Cpp2IlInjected.Address(RVA = "0x792F320", Offset = "0x792E320", VA = "0x18792F320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public IEnumerable<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F00")]
			[Cpp2IlInjected.Address(RVA = "0x792F380", Offset = "0x792E380", VA = "0x18792F380", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F01")]
			[Cpp2IlInjected.Address(RVA = "0x792EF20", Offset = "0x792DF20", VA = "0x18792EF20", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFD")]
		[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
		public ReadOnlyLinqDictionary(IReadOnlyDictionary<TKey, TValueIn> dict, Converter<TValueIn, TValueOut> valConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F02")]
		[Cpp2IlInjected.Address(RVA = "0x792E200", Offset = "0x792D200", VA = "0x18792E200", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F03")]
		[Cpp2IlInjected.Address(RVA = "0x792EDD0", Offset = "0x792DDD0", VA = "0x18792EDD0", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F04")]
		[Cpp2IlInjected.Address(RVA = "0x792E4B0", Offset = "0x792D4B0", VA = "0x18792E4B0", Slot = "10")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F05")]
		[Cpp2IlInjected.Address(RVA = "0x792E680", Offset = "0x792D680", VA = "0x18792E680", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A13250", Offset = "0x6A12250", VA = "0x186A13250", Slot = "4")]
			get
			{
				return (TValueOut)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000F0E")]
			[Cpp2IlInjected.Address(RVA = "0x6A13850", Offset = "0x6A12850", VA = "0x186A13850", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public ICollection<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000F0F")]
			[Cpp2IlInjected.Address(RVA = "0x6A13560", Offset = "0x6A12560", VA = "0x186A13560", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public ICollection<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F10")]
			[Cpp2IlInjected.Address(RVA = "0x6A135C0", Offset = "0x6A125C0", VA = "0x186A135C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F11")]
			[Cpp2IlInjected.Address(RVA = "0x6A13190", Offset = "0x6A12190", VA = "0x186A13190", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000F12")]
			[Cpp2IlInjected.Address(RVA = "0x634C740", Offset = "0x634B740", VA = "0x18634C740", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0C")]
		[Cpp2IlInjected.Address(RVA = "0x1F50EC0", Offset = "0x1F4FEC0", VA = "0x181F50EC0")]
		public LinqDictionary(IDictionary<TKey, TValueIn> dict, Converter<TValueOut, TValueIn> inConverter, Converter<TValueIn, TValueOut> outConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F13")]
		[Cpp2IlInjected.Address(RVA = "0x6A126B0", Offset = "0x6A116B0", VA = "0x186A126B0", Slot = "8")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F14")]
		[Cpp2IlInjected.Address(RVA = "0x6A12DD0", Offset = "0x6A11DD0", VA = "0x186A12DD0", Slot = "11")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F15")]
		[Cpp2IlInjected.Address(RVA = "0x6A12800", Offset = "0x6A11800", VA = "0x186A12800", Slot = "19")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F16")]
		[Cpp2IlInjected.Address(RVA = "0x6A12B90", Offset = "0x6A11B90", VA = "0x186A12B90", Slot = "20")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F17")]
		[Cpp2IlInjected.Address(RVA = "0x6A12430", Offset = "0x6A11430", VA = "0x186A12430", Slot = "9")]
		public void Add(TKey key, TValueOut value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F18")]
		[Cpp2IlInjected.Address(RVA = "0x6A12A40", Offset = "0x6A11A40", VA = "0x186A12A40", Slot = "10")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F19")]
		[Cpp2IlInjected.Address(RVA = "0x6A121E0", Offset = "0x6A111E0", VA = "0x186A121E0", Slot = "14")]
		public void Add(KeyValuePair<TKey, TValueOut> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1A")]
		[Cpp2IlInjected.Address(RVA = "0x6A12650", Offset = "0x6A11650", VA = "0x186A12650", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1B")]
		[Cpp2IlInjected.Address(RVA = "0x3C25D10", Offset = "0x3C24D10", VA = "0x183C25D10", Slot = "16")]
		public bool Contains(KeyValuePair<TKey, TValueOut> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1C")]
		[Cpp2IlInjected.Address(RVA = "0x3C25B50", Offset = "0x3C24B50", VA = "0x183C25B50", Slot = "17")]
		public void CopyTo(KeyValuePair<TKey, TValueOut>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1D")]
		[Cpp2IlInjected.Address(RVA = "0x3C25D10", Offset = "0x3C24D10", VA = "0x183C25D10", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private ReferenceComparer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F25")]
		[Cpp2IlInjected.Address(RVA = "0x1734D60", Offset = "0x1733D60", VA = "0x181734D60", Slot = "4")]
		public bool Equals(T x, T y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F26")]
		[Cpp2IlInjected.Address(RVA = "0x79D43B0", Offset = "0x79D33B0", VA = "0x1879D43B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4C")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <SplitByTime>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4D")]
			[Cpp2IlInjected.Address(RVA = "0x6DFE080", Offset = "0x6DFD080", VA = "0x186DFE080", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4E")]
			[Cpp2IlInjected.Address(RVA = "0x6DF6070", Offset = "0x6DF5070", VA = "0x186DF6070", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4F")]
			[Cpp2IlInjected.Address(RVA = "0x6DFED70", Offset = "0x6DFDD70", VA = "0x186DFED70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F51")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F53")]
			[Cpp2IlInjected.Address(RVA = "0x65AED30", Offset = "0x65ADD30", VA = "0x1865AED30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(float, T)[]> IEnumerable<(float, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000F54")]
			[Cpp2IlInjected.Address(RVA = "0x6DFD720", Offset = "0x6DFC720", VA = "0x186DFD720", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA77B870", Offset = "0xA77A870", VA = "0x18A77B870")]
		internal static string CurveError(int maxDegree)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F29")]
		[Cpp2IlInjected.Address(RVA = "0xA77B450", Offset = "0xA77A450", VA = "0x18A77B450")]
		public static Vector3 CreateTangent(Vector3 fromValue, Vector3 toValue, float scale = 1f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2A")]
		[Cpp2IlInjected.Address(RVA = "0xA77B530", Offset = "0xA77A530", VA = "0x18A77B530")]
		public static Quaternion CreateTangent(Quaternion fromValue, Quaternion toValue, float scale = 1f)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2B")]
		[Cpp2IlInjected.Address(RVA = "0xA77B6B0", Offset = "0xA77A6B0", VA = "0x18A77B6B0")]
		public static float[] CreateTangent(float[] fromValue, float[] toValue, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2C")]
		[Cpp2IlInjected.Address(RVA = "0xA779490", Offset = "0xA778490", VA = "0x18A779490")]
		public static (float, float, float, float) CreateHermitePointWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2D")]
		[Cpp2IlInjected.Address(RVA = "0xA779530", Offset = "0xA778530", VA = "0x18A779530")]
		public static (float, float, float, float) CreateHermiteTangentWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2E")]
		[Cpp2IlInjected.Address(RVA = "0x38DBCF0", Offset = "0x38DACF0", VA = "0x1838DBCF0")]
		public static (T, T, float) FindRangeContainingOffset<T>(this IEnumerable<(float Key, T Value)> sequence, float offset)
		{
			return default((T, T, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2F")]
		[Cpp2IlInjected.Address(RVA = "0xA77B900", Offset = "0xA77A900", VA = "0x18A77B900")]
		public static (float, float, float) FindRangeContainingOffset(IEnumerable<float> sequence, float offset)
		{
			return default((float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F30")]
		[Cpp2IlInjected.Address(RVA = "0x33A4DD0", Offset = "0x33A3DD0", VA = "0x1833A4DD0")]
		[IteratorStateMachine(typeof(<SplitByTime>d__11<>))]
		internal static IEnumerable<(float, T)[]> SplitByTime<T>(this IEnumerable<(float Time, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F31")]
		[Cpp2IlInjected.Address(RVA = "0xA77D210", Offset = "0xA77C210", VA = "0x18A77D210")]
		public static float[] Subtract(IReadOnlyList<float> left, IReadOnlyList<float> right)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F32")]
		[Cpp2IlInjected.Address(RVA = "0xA77CF40", Offset = "0xA77BF40", VA = "0x18A77CF40")]
		public static float[] InterpolateLinear(IReadOnlyList<float> start, IReadOnlyList<float> end, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F33")]
		[Cpp2IlInjected.Address(RVA = "0xA77C360", Offset = "0xA77B360", VA = "0x18A77C360")]
		public static float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F34")]
		[Cpp2IlInjected.Address(RVA = "0xA77BE40", Offset = "0xA77AE40", VA = "0x18A77BE40")]
		public static Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F35")]
		[Cpp2IlInjected.Address(RVA = "0xA77C060", Offset = "0xA77B060", VA = "0x18A77C060")]
		public static Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F36")]
		[Cpp2IlInjected.Address(RVA = "0xA77C480", Offset = "0xA77B480", VA = "0x18A77C480")]
		public static Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F37")]
		[Cpp2IlInjected.Address(RVA = "0xA77CD60", Offset = "0xA77BD60", VA = "0x18A77CD60")]
		public static Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F38")]
		[Cpp2IlInjected.Address(RVA = "0xA77C7C0", Offset = "0xA77B7C0", VA = "0x18A77C7C0")]
		public static float[] InterpolateCubic(IReadOnlyList<float> start, IReadOnlyList<float> outgoingTangent, IReadOnlyList<float> end, IReadOnlyList<float> incomingTangent, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F39")]
		[Cpp2IlInjected.Address(RVA = "0x38E7510", Offset = "0x38E6510", VA = "0x1838E7510")]
		private static bool _HasZero<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3A")]
		[Cpp2IlInjected.Address(RVA = "0x38E7090", Offset = "0x38E6090", VA = "0x1838E7090")]
		private static bool _HasOne<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3B")]
		[Cpp2IlInjected.Address(RVA = "0xA77AA50", Offset = "0xA779A50", VA = "0x18A77AA50")]
		public static ICurveSampler<bool> CreateSampler(this IEnumerable<(float, bool)> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3C")]
		[Cpp2IlInjected.Address(RVA = "0xA779E10", Offset = "0xA778E10", VA = "0x18A779E10")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, float)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3D")]
		[Cpp2IlInjected.Address(RVA = "0xA77A1B0", Offset = "0xA7791B0", VA = "0x18A77A1B0")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, Vector2)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3E")]
		[Cpp2IlInjected.Address(RVA = "0xA77A810", Offset = "0xA779810", VA = "0x18A77A810")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, Vector3)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3F")]
		[Cpp2IlInjected.Address(RVA = "0xA77ABB0", Offset = "0xA779BB0", VA = "0x18A77ABB0")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, Vector4)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F40")]
		[Cpp2IlInjected.Address(RVA = "0xA779990", Offset = "0xA778990", VA = "0x18A779990")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, Quaternion)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F41")]
		[Cpp2IlInjected.Address(RVA = "0xA77ADF0", Offset = "0xA779DF0", VA = "0x18A77ADF0")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, float[])> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F42")]
		[Cpp2IlInjected.Address(RVA = "0xA7795F0", Offset = "0xA7785F0", VA = "0x18A7795F0")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, ArraySegment<float>)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F43")]
		[Cpp2IlInjected.Address(RVA = "0xA779BD0", Offset = "0xA778BD0", VA = "0x18A779BD0")]
		public static ICurveSampler<SparseWeight8> CreateSampler(this IEnumerable<(float, SparseWeight8)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F44")]
		[Cpp2IlInjected.Address(RVA = "0xA77B030", Offset = "0xA77A030", VA = "0x18A77B030")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, (float, float, float))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F45")]
		[Cpp2IlInjected.Address(RVA = "0xA77A6B0", Offset = "0xA7796B0", VA = "0x18A77A6B0")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, (Vector2, Vector2, Vector2))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F46")]
		[Cpp2IlInjected.Address(RVA = "0xA77A550", Offset = "0xA779550", VA = "0x18A77A550")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, (Vector3, Vector3, Vector3))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F47")]
		[Cpp2IlInjected.Address(RVA = "0xA77B2F0", Offset = "0xA77A2F0", VA = "0x18A77B2F0")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, (Vector4, Vector4, Vector4))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F48")]
		[Cpp2IlInjected.Address(RVA = "0xA77B190", Offset = "0xA77A190", VA = "0x18A77B190")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F49")]
		[Cpp2IlInjected.Address(RVA = "0xA77A050", Offset = "0xA779050", VA = "0x18A77A050")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, (float[], float[], float[]))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4A")]
		[Cpp2IlInjected.Address(RVA = "0xA779830", Offset = "0xA778830", VA = "0x18A779830")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4B")]
		[Cpp2IlInjected.Address(RVA = "0xA77A3F0", Offset = "0xA7793F0", VA = "0x18A77A3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8DD50", VA = "0x180D8ED50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F55")]
		[Cpp2IlInjected.Address(RVA = "0x53FC060", Offset = "0x53FB060", VA = "0x1853FC060", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F56")]
		[Cpp2IlInjected.Address(RVA = "0x54017E0", Offset = "0x54007E0", VA = "0x1854017E0")]
		public CubicSampler(IEnumerable<(float, (T, T, T))> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F58")]
		[Cpp2IlInjected.Address(RVA = "0x53FDF90", Offset = "0x53FCF90", VA = "0x1853FDF90", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F59")]
		[Cpp2IlInjected.Address(RVA = "0x53FE740", Offset = "0x53FD740", VA = "0x1853FE740", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5A")]
		[Cpp2IlInjected.Address(RVA = "0x53FE740", Offset = "0x53FD740", VA = "0x1853FE740", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5B")]
		[Cpp2IlInjected.Address(RVA = "0x5400200", Offset = "0x53FF200", VA = "0x185400200", Slot = "9")]
		IReadOnlyDictionary<float, (T, T, T)> IConvertibleCurve<T>.ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5C")]
		[Cpp2IlInjected.Address(RVA = "0x5400E10", Offset = "0x53FFE10", VA = "0x185400E10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F66")]
		[Cpp2IlInjected.Address(RVA = "0x63A7D80", Offset = "0x63A6D80", VA = "0x1863A7D80")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F67")]
		[Cpp2IlInjected.Address(RVA = "0x63A75F0", Offset = "0x63A65F0", VA = "0x1863A75F0")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, (T, T, T) Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F68")]
		[Cpp2IlInjected.Address(RVA = "0x63A70B0", Offset = "0x63A60B0", VA = "0x1863A70B0", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F69")]
		[Cpp2IlInjected.Address(RVA = "0x12D4C50", Offset = "0x12D3C50", VA = "0x1812D4C50")]
		private FixedSampler(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6B")]
		[Cpp2IlInjected.Address(RVA = "0x12D4C20", Offset = "0x12D3C20", VA = "0x1812D4C20", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6C")]
		[Cpp2IlInjected.Address(RVA = "0x63A86D0", Offset = "0x63A76D0", VA = "0x1863A86D0", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6D")]
		[Cpp2IlInjected.Address(RVA = "0x63A86D0", Offset = "0x63A76D0", VA = "0x1863A86D0", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6E")]
		[Cpp2IlInjected.Address(RVA = "0x63A9280", Offset = "0x63A8280", VA = "0x1863A9280", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xD768E0", Offset = "0xD758E0", VA = "0x180D768E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6F")]
		[Cpp2IlInjected.Address(RVA = "0x69BC3D0", Offset = "0x69BB3D0", VA = "0x1869BC3D0", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F70")]
		[Cpp2IlInjected.Address(RVA = "0x54017E0", Offset = "0x54007E0", VA = "0x1854017E0")]
		public LinearSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F72")]
		[Cpp2IlInjected.Address(RVA = "0x69BD6E0", Offset = "0x69BC6E0", VA = "0x1869BD6E0", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F73")]
		[Cpp2IlInjected.Address(RVA = "0x69C13C0", Offset = "0x69C03C0", VA = "0x1869C13C0", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F74")]
		[Cpp2IlInjected.Address(RVA = "0x69C1010", Offset = "0x69C0010", VA = "0x1869C1010", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F75")]
		[Cpp2IlInjected.Address(RVA = "0x69C13C0", Offset = "0x69C03C0", VA = "0x1869C13C0", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F76")]
		[Cpp2IlInjected.Address(RVA = "0x69BF060", Offset = "0x69BE060", VA = "0x1869BF060")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F80")]
		[Cpp2IlInjected.Address(RVA = "0x69BC3D0", Offset = "0x69BB3D0", VA = "0x1869BC3D0", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F81")]
		[Cpp2IlInjected.Address(RVA = "0x54017E0", Offset = "0x54007E0", VA = "0x1854017E0")]
		public StepSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F83")]
		[Cpp2IlInjected.Address(RVA = "0x7BA35A0", Offset = "0x7BA25A0", VA = "0x187BA35A0", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F84")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4690", Offset = "0x7BA3690", VA = "0x187BA4690", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F85")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4570", Offset = "0x7BA3570", VA = "0x187BA4570", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F86")]
		[Cpp2IlInjected.Address(RVA = "0x7BA4570", Offset = "0x7BA3570", VA = "0x187BA4570", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F87")]
		[Cpp2IlInjected.Address(RVA = "0x69BF060", Offset = "0x69BE060", VA = "0x1869BF060")]
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
			[Cpp2IlInjected.Address(RVA = "0x142BD70", Offset = "0x142AD70", VA = "0x18142BD70", Slot = "4")]
			public bool Clone(bool value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F96")]
			[Cpp2IlInjected.Address(RVA = "0xA7876A0", Offset = "0xA7866A0", VA = "0x18A7876A0", Slot = "5")]
			public bool InterpolateLinear(bool left, bool right, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F97")]
			[Cpp2IlInjected.Address(RVA = "0xA787680", Offset = "0xA786680", VA = "0x18A787680", Slot = "6")]
			public bool InterpolateCubic(bool start, bool outgoingTangent, bool end, bool incomingTangent, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F98")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public _Boolean()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		private sealed class _Scalar : ISamplerTraits<float>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F99")]
			[Cpp2IlInjected.Address(RVA = "0xF2E040", Offset = "0xF2D040", VA = "0x180F2E040", Slot = "4")]
			public float Clone(float value)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9A")]
			[Cpp2IlInjected.Address(RVA = "0xA78AE70", Offset = "0xA789E70", VA = "0x18A78AE70", Slot = "5")]
			public float InterpolateLinear(float left, float right, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9B")]
			[Cpp2IlInjected.Address(RVA = "0xA78AD60", Offset = "0xA789D60", VA = "0x18A78AD60", Slot = "6")]
			public float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9C")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public _Scalar()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		private sealed class _Vector2 : ISamplerTraits<Vector2>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F9D")]
			[Cpp2IlInjected.Address(RVA = "0xD6FCE0", Offset = "0xD6ECE0", VA = "0x180D6FCE0", Slot = "4")]
			public Vector2 Clone(Vector2 value)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9E")]
			[Cpp2IlInjected.Address(RVA = "0xA78B230", Offset = "0xA78A230", VA = "0x18A78B230", Slot = "5")]
			public Vector2 InterpolateLinear(Vector2 left, Vector2 right, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9F")]
			[Cpp2IlInjected.Address(RVA = "0xA78B1F0", Offset = "0xA78A1F0", VA = "0x18A78B1F0", Slot = "6")]
			public Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA0")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public _Vector2()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private sealed class _Vector3 : ISamplerTraits<Vector3>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA1")]
			[Cpp2IlInjected.Address(RVA = "0x10633D0", Offset = "0x10623D0", VA = "0x1810633D0", Slot = "4")]
			public Vector3 Clone(Vector3 value)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA2")]
			[Cpp2IlInjected.Address(RVA = "0xA78B350", Offset = "0xA78A350", VA = "0x18A78B350", Slot = "5")]
			public Vector3 InterpolateLinear(Vector3 left, Vector3 right, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA3")]
			[Cpp2IlInjected.Address(RVA = "0xA78B290", Offset = "0xA78A290", VA = "0x18A78B290", Slot = "6")]
			public Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA4")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public _Vector3()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B0")]
		private sealed class _Vector4 : ISamplerTraits<Vector4>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA5")]
			[Cpp2IlInjected.Address(RVA = "0x12C7CA0", Offset = "0x12C6CA0", VA = "0x1812C7CA0", Slot = "4")]
			public Vector4 Clone(Vector4 value)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA6")]
			[Cpp2IlInjected.Address(RVA = "0xA78B450", Offset = "0xA78A450", VA = "0x18A78B450", Slot = "5")]
			public Vector4 InterpolateLinear(Vector4 left, Vector4 right, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA7")]
			[Cpp2IlInjected.Address(RVA = "0xA78B3C0", Offset = "0xA78A3C0", VA = "0x18A78B3C0", Slot = "6")]
			public Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA8")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public _Vector4()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B1")]
		private sealed class _Quaternion : ISamplerTraits<Quaternion>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA9")]
			[Cpp2IlInjected.Address(RVA = "0x12C7CA0", Offset = "0x12C6CA0", VA = "0x1812C7CA0", Slot = "4")]
			public Quaternion Clone(Quaternion value)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAA")]
			[Cpp2IlInjected.Address(RVA = "0xA78AD10", Offset = "0xA789D10", VA = "0x18A78AD10", Slot = "5")]
			public Quaternion InterpolateLinear(Quaternion left, Quaternion right, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAB")]
			[Cpp2IlInjected.Address(RVA = "0xA78AB40", Offset = "0xA789B40", VA = "0x18A78AB40", Slot = "6")]
			public Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAC")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public _Quaternion()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		private sealed class _Array : ISamplerTraits<float[]>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FAD")]
			[Cpp2IlInjected.Address(RVA = "0xA7875B0", Offset = "0xA7865B0", VA = "0x18A7875B0", Slot = "4")]
			public float[] Clone(float[] value)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAE")]
			[Cpp2IlInjected.Address(RVA = "0xA787660", Offset = "0xA786660", VA = "0x18A787660", Slot = "5")]
			public float[] InterpolateLinear(float[] left, float[] right, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAF")]
			[Cpp2IlInjected.Address(RVA = "0xA787630", Offset = "0xA786630", VA = "0x18A787630", Slot = "6")]
			public float[] InterpolateCubic(float[] start, float[] outgoingTangent, float[] end, float[] incomingTangent, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB0")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public _Array()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		private sealed class _Segment : ISamplerTraits<ArraySegment<float>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB1")]
			[Cpp2IlInjected.Address(RVA = "0xA78AE90", Offset = "0xA789E90", VA = "0x18A78AE90", Slot = "4")]
			public ArraySegment<float> Clone(ArraySegment<float> value)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB2")]
			[Cpp2IlInjected.Address(RVA = "0xA78B050", Offset = "0xA78A050", VA = "0x18A78B050", Slot = "5")]
			public ArraySegment<float> InterpolateLinear(ArraySegment<float> left, ArraySegment<float> right, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB3")]
			[Cpp2IlInjected.Address(RVA = "0xA78AF30", Offset = "0xA789F30", VA = "0x18A78AF30", Slot = "6")]
			public ArraySegment<float> InterpolateCubic(ArraySegment<float> start, ArraySegment<float> outgoingTangent, ArraySegment<float> end, ArraySegment<float> incomingTangent, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB4")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public _Segment()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		private sealed class _Sparse : ISamplerTraits<SparseWeight8>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB5")]
			[Cpp2IlInjected.Address(RVA = "0x577B340", Offset = "0x577A340", VA = "0x18577B340", Slot = "4")]
			public SparseWeight8 Clone(SparseWeight8 value)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB6")]
			[Cpp2IlInjected.Address(RVA = "0xA78B190", Offset = "0xA78A190", VA = "0x18A78B190", Slot = "5")]
			public SparseWeight8 InterpolateLinear(SparseWeight8 left, SparseWeight8 right, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB7")]
			[Cpp2IlInjected.Address(RVA = "0xA78B110", Offset = "0xA78A110", VA = "0x18A78B110", Slot = "6")]
			public SparseWeight8 InterpolateCubic(SparseWeight8 start, SparseWeight8 outgoingTangent, SparseWeight8 end, SparseWeight8 incomingTangent, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB8")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0x37ED8C0", Offset = "0x37EC8C0", VA = "0x1837ED8C0")]
		public static ICurveSampler<T> CreateFrom<TKey>(IEnumerable<(float, TKey)> sequence, Func<(float, TKey)[], ICurveSampler<T>> chunkFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBA")]
		[Cpp2IlInjected.Address(RVA = "0x635B370", Offset = "0x635A370", VA = "0x18635B370")]
		private FastCurveSampler(IEnumerable<ICurveSampler<T>> samplers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBB")]
		[Cpp2IlInjected.Address(RVA = "0x635AD00", Offset = "0x6359D00", VA = "0x18635AD00", Slot = "4")]
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

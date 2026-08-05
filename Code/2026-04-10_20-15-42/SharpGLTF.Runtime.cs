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
		[Cpp2IlInjected.Address(RVA = "0xA78F910", Offset = "0xA78E910", VA = "0x18A78F910")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA78E8E0", Offset = "0xA78D8E0", VA = "0x18A78E8E0")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA78EB50", Offset = "0xA78DB50", VA = "0x18A78EB50")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA78EDA0", Offset = "0xA78DDA0", VA = "0x18A78EDA0")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA78E840", Offset = "0xA78D840", VA = "0x18A78E840")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA78F590", Offset = "0xA78E590", VA = "0x18A78F590")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA78F470", Offset = "0xA78E470", VA = "0x18A78F470")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA78FA60", Offset = "0xA78EA60", VA = "0x18A78FA60")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA78FA00", Offset = "0xA78EA00", VA = "0x18A78FA00")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA78F2B0", Offset = "0xA78E2B0", VA = "0x18A78F2B0")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B029B0", Offset = "0x3B019B0", VA = "0x183B029B0")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3B01300", Offset = "0x3B00300", VA = "0x183B01300")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA78F310", Offset = "0xA78E310", VA = "0x18A78F310")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3B02450", Offset = "0x3B01450", VA = "0x183B02450")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3B01FF0", Offset = "0x3B00FF0", VA = "0x183B01FF0")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B01BB0", Offset = "0x3B00BB0", VA = "0x183B01BB0")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B018B0", Offset = "0x3B008B0", VA = "0x183B018B0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B00BB0", Offset = "0x3AFFBB0", VA = "0x183B00BB0")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA78EEA0", Offset = "0xA78DEA0", VA = "0x18A78EEA0")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA78EE40", Offset = "0xA78DE40", VA = "0x18A78EE40")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA78EF00", Offset = "0xA78DF00", VA = "0x18A78EF00")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA78F7B0", Offset = "0xA78E7B0", VA = "0x18A78F7B0")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA78F6B0", Offset = "0xA78E6B0", VA = "0x18A78F6B0")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF8A0", Offset = "0x3AFE8A0", VA = "0x183AFF8A0")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA78E5B0", Offset = "0xA78D5B0", VA = "0x18A78E5B0")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE730", Offset = "0x3AFD730", VA = "0x183AFE730")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE730", Offset = "0x3AFD730", VA = "0x183AFE730")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE730", Offset = "0x3AFD730", VA = "0x183AFE730")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE730", Offset = "0x3AFD730", VA = "0x183AFE730")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE730", Offset = "0x3AFD730", VA = "0x183AFE730")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AFDAD0", Offset = "0x3AFCAD0", VA = "0x183AFDAD0")]
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
					[Cpp2IlInjected.Address(RVA = "0x6758540", Offset = "0x6757540", VA = "0x186758540", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x67585F0", Offset = "0x67575F0", VA = "0x1867585F0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x5169B30", Offset = "0x5168B30", VA = "0x185169B30")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x6758780", Offset = "0x6757780", VA = "0x186758780", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x6759440", Offset = "0x6758440", VA = "0x186759440", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x675E7E0", Offset = "0x675D7E0", VA = "0x18675E7E0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
					[Cpp2IlInjected.Token(Token = "0x6000084")]
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0x6F4B4B0", Offset = "0x6F4A4B0", VA = "0x186F4B4B0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6F50890", Offset = "0x6F4F890", VA = "0x186F50890", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6F54D30", Offset = "0x6F53D30", VA = "0x186F54D30")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000083")]
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
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x51AEE10", Offset = "0x51ADE10", VA = "0x1851AEE10", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x51AEDB0", Offset = "0x51ADDB0", VA = "0x1851AEDB0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x51AEAF0", Offset = "0x51ADAF0", VA = "0x1851AEAF0", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x51AEC20", Offset = "0x51ADC20", VA = "0x1851AEC20", Slot = "7")]
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
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0x67585F0", Offset = "0x67575F0", VA = "0x1867585F0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x5169B30", Offset = "0x5168B30", VA = "0x185169B30")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x6758780", Offset = "0x6757780", VA = "0x186758780", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x6757CA0", Offset = "0x6756CA0", VA = "0x186757CA0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x6758D40", Offset = "0x6757D40", VA = "0x186758D40")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6F4B4B0", Offset = "0x6F4A4B0", VA = "0x186F4B4B0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6F4A210", Offset = "0x6F49210", VA = "0x186F4A210", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6F4B9E0", Offset = "0x6F4A9E0", VA = "0x186F4B9E0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000095")]
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
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x51A5B50", Offset = "0x51A4B50", VA = "0x1851A5B50", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x51A5890", Offset = "0x51A4890", VA = "0x1851A5890", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x51A5A70", Offset = "0x51A4A70", VA = "0x1851A5A70", Slot = "6")]
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
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xA796850", Offset = "0xA795850", VA = "0x18A796850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x65AFE60", Offset = "0x65AEE60", VA = "0x1865AFE60")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA7968A0", Offset = "0xA7958A0", VA = "0x18A7968A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA796500", Offset = "0xA795500", VA = "0x18A796500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA796960", Offset = "0xA795960", VA = "0x18A796960")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA796810", Offset = "0xA795810", VA = "0x18A796810", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA796760", Offset = "0xA795760", VA = "0x18A796760", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA796760", Offset = "0xA795760", VA = "0x18A796760", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0xA797340", Offset = "0xA796340", VA = "0x18A797340", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA797390", Offset = "0xA796390", VA = "0x18A797390", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA7969B0", Offset = "0xA7959B0", VA = "0x18A7969B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA797580", Offset = "0xA796580", VA = "0x18A797580")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA7975D0", Offset = "0xA7965D0", VA = "0x18A7975D0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA797620", Offset = "0xA796620", VA = "0x18A797620")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA797300", Offset = "0xA796300", VA = "0x18A797300", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA797250", Offset = "0xA796250", VA = "0x18A797250", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA797250", Offset = "0xA796250", VA = "0x18A797250", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6E5DA0", Offset = "0xA6E4DA0", VA = "0x18A6E5DA0")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7770", Offset = "0xA6E6770", VA = "0x18A6E7770")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E78A0", Offset = "0xA6E68A0", VA = "0x18A6E78A0")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E77B0", Offset = "0xA6E67B0", VA = "0x18A6E77B0")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E78D0", Offset = "0xA6E68D0", VA = "0x18A6E78D0")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7810", Offset = "0xA6E6810", VA = "0x18A6E7810")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7940", Offset = "0xA6E6940", VA = "0x18A6E7940")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7810", Offset = "0xA6E6810", VA = "0x18A6E7810")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA6E76A0", Offset = "0xA6E66A0", VA = "0x18A6E76A0")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA798BF0", Offset = "0xA797BF0", VA = "0x18A798BF0")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA798AD0", Offset = "0xA797AD0", VA = "0x18A798AD0")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5140", Offset = "0xA6E4140", VA = "0x18A6E5140")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA799480", Offset = "0xA798480", VA = "0x18A799480")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5D50", Offset = "0xA6E4D50", VA = "0x18A6E5D50")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5CF0", Offset = "0xA6E4CF0", VA = "0x18A6E5CF0")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5FD0", Offset = "0xA6E4FD0", VA = "0x18A6E5FD0")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA79A020", Offset = "0xA799020", VA = "0x18A79A020")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA79A1A0", Offset = "0xA7991A0", VA = "0x18A79A1A0")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA798DF0", Offset = "0xA797DF0", VA = "0x18A798DF0")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA798CF0", Offset = "0xA797CF0", VA = "0x18A798CF0")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA7990C0", Offset = "0xA7980C0", VA = "0x18A7990C0")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA798940", Offset = "0xA797940", VA = "0x18A798940")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA798D70", Offset = "0xA797D70", VA = "0x18A798D70")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA6E68A0", Offset = "0xA6E58A0", VA = "0x18A6E68A0")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA798D80", Offset = "0xA797D80", VA = "0x18A798D80")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5AC0", Offset = "0xA6E4AC0", VA = "0x18A6E5AC0")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5A00", Offset = "0xA6E4A00", VA = "0x18A6E5A00")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x415CE30", Offset = "0x415BE30", VA = "0x18415CE30")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA6E52B0", Offset = "0xA6E42B0", VA = "0x18A6E52B0")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5420", Offset = "0xA6E4420", VA = "0x18A6E5420")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x415E1D0", Offset = "0x415D1D0", VA = "0x18415E1D0")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x415F2F0", Offset = "0x415E2F0", VA = "0x18415F2F0")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x415F4C0", Offset = "0x415E4C0", VA = "0x18415F4C0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x415F5A0", Offset = "0x415E5A0", VA = "0x18415F5A0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x415CE50", Offset = "0x415BE50", VA = "0x18415CE50")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x415E010", Offset = "0x415D010", VA = "0x18415E010")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x415DF00", Offset = "0x415CF00", VA = "0x18415DF00")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x415D640", Offset = "0x415C640", VA = "0x18415D640")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x415F210", Offset = "0x415E210", VA = "0x18415F210")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x415EB80", Offset = "0x415DB80", VA = "0x18415EB80")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x415EFC0", Offset = "0x415DFC0", VA = "0x18415EFC0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x415ED20", Offset = "0x415DD20", VA = "0x18415ED20")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x415D4F0", Offset = "0x415C4F0", VA = "0x18415D4F0")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x415D2A0", Offset = "0x415C2A0", VA = "0x18415D2A0")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x415CAB0", Offset = "0x415BAB0", VA = "0x18415CAB0")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x415CEE0", Offset = "0x415BEE0", VA = "0x18415CEE0")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA798EC0", Offset = "0xA797EC0", VA = "0x18A798EC0")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA799220", Offset = "0xA798220", VA = "0x18A799220")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x415F270", Offset = "0x415E270", VA = "0x18415F270")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x415F270", Offset = "0x415E270", VA = "0x18415F270")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA799730", Offset = "0xA798730", VA = "0x18A799730")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA798340", Offset = "0xA797340", VA = "0x18A798340")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA798290", Offset = "0xA797290", VA = "0x18A798290")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA7996B0", Offset = "0xA7986B0", VA = "0x18A7996B0")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA799DF0", Offset = "0xA798DF0", VA = "0x18A799DF0")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA7983C0", Offset = "0xA7973C0", VA = "0x18A7983C0")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA799930", Offset = "0xA798930", VA = "0x18A799930")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA799A00", Offset = "0xA798A00", VA = "0x18A799A00")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA7986E0", Offset = "0xA7976E0", VA = "0x18A7986E0")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA798480", Offset = "0xA797480", VA = "0x18A798480")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA798780", Offset = "0xA797780", VA = "0x18A798780")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA7985C0", Offset = "0xA7975C0", VA = "0x18A7985C0")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA7988C0", Offset = "0xA7978C0", VA = "0x18A7988C0")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x239D950", Offset = "0x239C950", VA = "0x18239D950")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7790", Offset = "0xA6E6790", VA = "0x18A6E7790")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x415F7D0", Offset = "0x415E7D0", VA = "0x18415F7D0")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA7995F0", Offset = "0xA7985F0", VA = "0x18A7995F0")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA798640", Offset = "0xA797640", VA = "0x18A798640")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA799F70", Offset = "0xA798F70", VA = "0x18A799F70")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA79A3A0", Offset = "0xA7993A0", VA = "0x18A79A3A0")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA799E70", Offset = "0xA798E70", VA = "0x18A799E70")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5350", Offset = "0xA6E4350", VA = "0x18A6E5350")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBF620", Offset = "0xEBE620", VA = "0x180EBF620")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD18620", Offset = "0xD17620", VA = "0x180D18620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x74A4390", Offset = "0x74A3390", VA = "0x1874A4390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74A3140", Offset = "0x74A2140", VA = "0x1874A3140")]
		internal AnimatableProperty(T defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x749A250", Offset = "0x7499250", VA = "0x18749A250")]
		public T GetValueAt(int trackLogicalIndex, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x749B9D0", Offset = "0x749A9D0", VA = "0x18749B9D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xD632D0", Offset = "0xD622D0", VA = "0x180D632D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x10C8F50", Offset = "0x10C7F50", VA = "0x1810C8F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA78B6A0", Offset = "0xA78A6A0", VA = "0x18A78B6A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<NodeInstance> VisualNodes
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA78BEA0", Offset = "0xA78AEA0", VA = "0x18A78BEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyList<AnimationTrackInfo> AnimationTracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA78BC60", Offset = "0xA78AC60", VA = "0x18A78BC60")]
		internal ArmatureInstance(ArmatureTemplate template)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA78B780", Offset = "0xA78A780", VA = "0x18A78B780")]
		public void SetLocalMatrix(string name, Matrix4x4 localMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA78B920", Offset = "0xA78A920", VA = "0x18A78B920")]
		public void SetModelMatrix(string name, Matrix4x4 modelMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA78BC20", Offset = "0xA78AC20", VA = "0x18A78BC20")]
		public void SetPoseTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA78B710", Offset = "0xA78A710", VA = "0x18A78B710")]
		public void SetAnimationFrame(int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA78B750", Offset = "0xA78A750", VA = "0x18A78B750")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IReadOnlyList<MaterialTemplate> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<AnimationTrackInfo> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA78CD00", Offset = "0xA78BD00", VA = "0x18A78CD00")]
		internal static ArmatureTemplate Create(Scene srcScene, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA78DBF0", Offset = "0xA78CBF0", VA = "0x18A78DBF0")]
		private ArmatureTemplate(NodeTemplate[] nodes, MaterialTemplate[] materials, AnimationTrackInfo[] animTracks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA78CCD0", Offset = "0xA78BCD0", VA = "0x18A78CCD0")]
		internal void ApplyDefaultPoseTo(ArmatureInstance instance)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA78BFC0", Offset = "0xA78AFC0", VA = "0x18A78BFC0")]
		internal void ApplyAnimationTo(ArmatureInstance instance, int trackLogicalIndex, float time, bool looped = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA78C390", Offset = "0xA78B390", VA = "0x18A78C390")]
		internal void ApplyAnimationTo(ArmatureInstance instance, (int TrackIdx, float Time, float Weight)[] blended)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA78D9C0", Offset = "0xA78C9C0", VA = "0x18A78D9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA78E4E0", Offset = "0xA78D4E0", VA = "0x18A78E4E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA78E150", Offset = "0xA78D150", VA = "0x18A78E150")]
		private string _ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xD127D0", Offset = "0xD117D0", VA = "0x180D127D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int LogicalMeshIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x163D350", Offset = "0x163C350", VA = "0x18163D350", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA78E540", Offset = "0xA78D540", VA = "0x18A78E540")]
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
		[Cpp2IlInjected.Address(RVA = "0xA794EF0", Offset = "0xA793EF0", VA = "0x18A794EF0")]
		internal RigidDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA794D10", Offset = "0xA793D10", VA = "0x18A794D10", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA794D60", Offset = "0xA793D60", VA = "0x18A794D60", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA78FE70", Offset = "0xA78EE70", VA = "0x18A78FE70")]
		internal InstancedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA78FC00", Offset = "0xA78EC00", VA = "0x18A78FC00", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA78FC60", Offset = "0xA78EC60", VA = "0x18A78FC60", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA796070", Offset = "0xA795070", VA = "0x18A796070")]
		internal SkinnedDrawableTemplate(Node node, Func<Node, int> indexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA795DF0", Offset = "0xA794DF0", VA = "0x18A795DF0", Slot = "6")]
		public override IGeometryTransform CreateGeometryTransform()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA795E40", Offset = "0xA794E40", VA = "0x18A795E40", Slot = "7")]
		public override void UpdateGeometryTransform(IGeometryTransform skinnedTransform, ArmatureInstance armature)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class MaterialInstance
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xF6C200", Offset = "0xF6B200", VA = "0x180F6C200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD0F390", Offset = "0xD0E390", VA = "0x180D0F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xD0F5C0", Offset = "0xD0E5C0", VA = "0x180D0F5C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xD09170", Offset = "0xD08170", VA = "0x180D09170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA7906F0", Offset = "0xA78F6F0", VA = "0x18A7906F0")]
		internal MaterialTemplate(Material srcMaterial, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B900", Offset = "0x3D1A900", VA = "0x183D1B900")]
		private void _AddAnimatableProperty<T>(Dictionary<string, AnimatableProperty<T>> dict, int trackIdx, AnimationChannel channel, string pointerPath, T defaultSingle, bool isolateMemory) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA790370", Offset = "0xA78F370", VA = "0x18A790370")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, float> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA78FFF0", Offset = "0xA78EFF0", VA = "0x18A78FFF0")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector2> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA790510", Offset = "0xA78F510", VA = "0x18A790510")]
		public void UpdateRuntimeMaterial(int trackLogicalIndex, float time, Action<string, Vector3> target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA7901A0", Offset = "0xA78F1A0", VA = "0x18A7901A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A191E0", Offset = "0x1A181E0", VA = "0x181A191E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x691D1D0", Offset = "0x691C1D0", VA = "0x18691D1D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public <GetWorldVertices>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x691D220", Offset = "0x691C220", VA = "0x18691D220", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x691CB30", Offset = "0x691BB30", VA = "0x18691CB30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x691D450", Offset = "0x691C450", VA = "0x18691D450")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x691D4A0", Offset = "0x691C4A0", VA = "0x18691D4A0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x65A2330", Offset = "0x65A1330", VA = "0x1865A2330", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Vector3> IEnumerable<Vector3>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x691D100", Offset = "0x691C100", VA = "0x18691D100", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA791290", Offset = "0xA790290", VA = "0x18A791290")]
		public static IMeshDecoder<Material> Decode(this Mesh mesh, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA791120", Offset = "0xA790120", VA = "0x18A791120")]
		public static IMeshDecoder<Material>[] Decode(this IReadOnlyList<Mesh> meshes, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA792240", Offset = "0xA791240", VA = "0x18A792240")]
		public static Vector3 GetPosition(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA791EE0", Offset = "0xA790EE0", VA = "0x18A791EE0")]
		public static Vector3 GetNormal(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA7925A0", Offset = "0xA7915A0", VA = "0x18A7925A0")]
		public static Vector4 GetTangent(this IMeshPrimitiveDecoder primitive, int vertexIdx, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA7928F0", Offset = "0xA7918F0", VA = "0x18A7928F0")]
		public static Vector2 GetTextureCoord(this IMeshPrimitiveDecoder primitive, int vertexIdx, int textureSetIndex, IGeometryTransform xform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA791B80", Offset = "0xA790B80", VA = "0x18A791B80")]
		public static Vector4 GetColor(this IMeshPrimitiveDecoder primitive, int vertexIdx, int colorSetIndex, IGeometryTransform xform)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA791340", Offset = "0xA790340", VA = "0x18A791340")]
		public static (Vector3, Vector3) EvaluateBoundingBox(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA791A60", Offset = "0xA790A60", VA = "0x18A791A60")]
		public static (Vector3, float) EvaluateBoundingSphere(this Scene scene, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA791770", Offset = "0xA790770", VA = "0x18A791770")]
		public static (Vector3, float) EvaluateBoundingSphere(this SceneTemplate sceneTemplate, IMeshDecoder<Material>[] decodedMeshes, float samplingTimeStep = 1f)
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FB90", Offset = "0x3D2EB90", VA = "0x183D2FB90")]
		public static (Vector3, Vector3) EvaluateBoundingBox<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FFD0", Offset = "0x3D2EFD0", VA = "0x183D2FFD0")]
		public static (Vector3, float) EvaluateBoundingSphere<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return default((Vector3, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA792C00", Offset = "0xA791C00", VA = "0x18A792C00")]
		private static void _AddPointToSphere(Vector3 c1, float r1, Vector3 c2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA792F00", Offset = "0xA791F00", VA = "0x18A792F00")]
		private static void _MergeSphere(Vector3 c1, float r1, Vector3 c2, float r2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3D30320", Offset = "0x3D2F320", VA = "0x183D30320")]
		public static IEnumerable<Vector3> GetWorldVertices<TMaterial>(this SceneInstance instance, IReadOnlyList<IMeshDecoder<TMaterial>> meshes) where TMaterial : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x39AE400", Offset = "0x39AD400", VA = "0x1839AE400")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IReadOnlyList<IMeshPrimitiveDecoder<TMaterial>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x51B6B20", Offset = "0x51B5B20", VA = "0x1851B6B20")]
		public _MeshDecoder(Mesh srcMesh, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x51B5FC0", Offset = "0x51B4FC0", VA = "0x1851B5FC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xDEFAF0", Offset = "0xDEEAF0", VA = "0x180DEFAF0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x51B6DE0", Offset = "0x51B5DE0", VA = "0x1851B6DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79C930", Offset = "0xA79B930", VA = "0x18A79C930", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int ColorsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xD27F80", Offset = "0xD26F80", VA = "0x180D27F80", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int TexCoordsCount
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xE223B0", Offset = "0xE213B0", VA = "0x180E223B0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int JointsWeightsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xD12EB0", Offset = "0xD11EB0", VA = "0x180D12EB0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xA79C6B0", Offset = "0xA79B6B0", VA = "0x18A79C6B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsPointIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xA79C450", Offset = "0xA79B450", VA = "0x18A79C450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IEnumerable<(int A, int B)> LineIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xA79C470", Offset = "0xA79B470", VA = "0x18A79C470", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public IEnumerable<(int A, int B, int C)> TriangleIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA79C6F0", Offset = "0xA79B6F0", VA = "0x18A79C6F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA79B840", Offset = "0xA79A840", VA = "0x18A79B840", Slot = "22")]
		protected virtual string _GetDebugString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA79B940", Offset = "0xA79A940", VA = "0x18A79B940")]
		internal _MeshPrimitiveDecoder(MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA79B250", Offset = "0xA79A250", VA = "0x18A79B250", Slot = "11")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA79B180", Offset = "0xA79A180", VA = "0x18A79B180", Slot = "17")]
		public IReadOnlyList<Vector3> GetPositionDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA79B140", Offset = "0xA79A140", VA = "0x18A79B140", Slot = "12")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA79B070", Offset = "0xA79A070", VA = "0x18A79B070", Slot = "18")]
		public IReadOnlyList<Vector3> GetNormalDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA79B600", Offset = "0xA79A600", VA = "0x18A79B600", Slot = "13")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA79B530", Offset = "0xA79A530", VA = "0x18A79B530", Slot = "19")]
		public IReadOnlyList<Vector3> GetTangentDeltas(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA79B780", Offset = "0xA79A780", VA = "0x18A79B780", Slot = "14")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA79B640", Offset = "0xA79A640", VA = "0x18A79B640", Slot = "20")]
		public IReadOnlyList<Vector2> GetTextureCoordDeltas(int vertexIndex, int texCoordSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA79AFC0", Offset = "0xA799FC0", VA = "0x18A79AFC0", Slot = "15")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA79AE80", Offset = "0xA799E80", VA = "0x18A79AE80", Slot = "21")]
		public IReadOnlyList<Vector4> GetColorDeltas(int vertexIndex, int colorSet)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA79B290", Offset = "0xA79A290", VA = "0x18A79B290", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79AE30", Offset = "0xA799E30", VA = "0x18A79AE30", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x219FCB0", Offset = "0x219ECB0", VA = "0x18219FCB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xE220E0", Offset = "0xE210E0", VA = "0x180E220E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA79AD00", Offset = "0xA799D00", VA = "0x18A79AD00")]
		public _MeshGeometryDecoder(_MeshPrimitiveDecoder owner, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA79A7A0", Offset = "0xA7997A0", VA = "0x18A79A7A0")]
		public Vector3 GetPosition(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA79A6C0", Offset = "0xA7996C0", VA = "0x18A79A6C0")]
		public Vector3 GetNormal(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA79A880", Offset = "0xA799880", VA = "0x18A79A880")]
		public Vector4 GetTangent(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA79A950", Offset = "0xA799950", VA = "0x18A79A950")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA79A600", Offset = "0xA799600", VA = "0x18A79A600")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA79AA20", Offset = "0xA799A20", VA = "0x18A79AA20", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA79AA20", Offset = "0xA799A20", VA = "0x18A79AA20", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA79AA40", Offset = "0xA799A40", VA = "0x18A79AA40", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA79AA40", Offset = "0xA799A40", VA = "0x18A79AA40", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA79AB60", Offset = "0xA799B60", VA = "0x18A79AB60", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA79AB90", Offset = "0xA799B90", VA = "0x18A79AB90", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA79AA70", Offset = "0xA799A70", VA = "0x18A79AA70", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA79AC10", Offset = "0xA799C10", VA = "0x18A79AC10", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79DD20", Offset = "0xA79CD20", VA = "0x18A79DD20", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool HasNormals
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x219FCB0", Offset = "0x219ECB0", VA = "0x18219FCB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool HasTangents
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xE220E0", Offset = "0xE210E0", VA = "0x180E220E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA79D750", Offset = "0xA79C750", VA = "0x18A79D750")]
		public _MorphTargetDecoder(_MeshGeometryDecoder geometry, MeshPrimitive srcPrim, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA79D150", Offset = "0xA79C150", VA = "0x18A79D150")]
		public bool HasTexCoord(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA79D130", Offset = "0xA79C130", VA = "0x18A79D130")]
		public bool HasColor(int set)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA79CE10", Offset = "0xA79BE10", VA = "0x18A79CE10")]
		public Vector3 GetPositionBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA79CE50", Offset = "0xA79BE50", VA = "0x18A79CE50")]
		public Vector3 GetPositionDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA79CCE0", Offset = "0xA79BCE0", VA = "0x18A79CCE0")]
		public Vector3 GetNormalBase(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA79CD20", Offset = "0xA79BD20", VA = "0x18A79CD20")]
		public Vector3 GetNormalDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA79CF40", Offset = "0xA79BF40", VA = "0x18A79CF40")]
		public Vector4 GetTangentBase(int vertexIndex)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA79CF80", Offset = "0xA79BF80", VA = "0x18A79CF80")]
		public Vector3 GetTangentDelta(int vertexIndex)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA79D110", Offset = "0xA79C110", VA = "0x18A79D110")]
		public Vector2 GetTextureCoord(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA79D070", Offset = "0xA79C070", VA = "0x18A79D070")]
		public Vector2 GetTextureCoordDelta(int vertexIndex, int set)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA79CC10", Offset = "0xA79BC10", VA = "0x18A79CC10")]
		public Vector4 GetColor(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA79CB60", Offset = "0xA79BB60", VA = "0x18A79CB60")]
		public Vector4 GetColorDelta(int vertexIndex, int set)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA79D170", Offset = "0xA79C170", VA = "0x18A79D170", Slot = "7")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA79D3F0", Offset = "0xA79C3F0", VA = "0x18A79D3F0", Slot = "13")]
		private IEnumerable<(int, int, int)> SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA79D1C0", Offset = "0xA79C1C0", VA = "0x18A79D1C0", Slot = "5")]
		private Vector3 SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA79D1C0", Offset = "0xA79C1C0", VA = "0x18A79D1C0", Slot = "9")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA79D440", Offset = "0xA79C440", VA = "0x18A79D440", Slot = "10")]
		private Vector3 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA79D510", Offset = "0xA79C510", VA = "0x18A79D510", Slot = "11")]
		private Vector2 SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive.GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA79D290", Offset = "0xA79C290", VA = "0x18A79D290", Slot = "6")]
		private void SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive.SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA79D590", Offset = "0xA79C590", VA = "0x18A79D590", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79DFA0", Offset = "0xA79CFA0", VA = "0x18A79DFA0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA79DF50", Offset = "0xA79CF50", VA = "0x18A79DF50", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xDC3070", Offset = "0xDC2070", VA = "0x180DC3070")]
		public _MorphTargetPositionSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA79DED0", Offset = "0xA79CED0", VA = "0x18A79DED0", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA79DF10", Offset = "0xA79CF10", VA = "0x18A79DF10", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79DE40", Offset = "0xA79CE40", VA = "0x18A79DE40", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA79DDF0", Offset = "0xA79CDF0", VA = "0x18A79DDF0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xDC3070", Offset = "0xDC2070", VA = "0x180DC3070")]
		public _MorphTargetNormalSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA79DD70", Offset = "0xA79CD70", VA = "0x18A79DD70", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA79DDB0", Offset = "0xA79CDB0", VA = "0x18A79DDB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79E100", Offset = "0xA79D100", VA = "0x18A79E100", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA79E0B0", Offset = "0xA79D0B0", VA = "0x18A79E0B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xDC3070", Offset = "0xDC2070", VA = "0x180DC3070")]
		public _MorphTargetTangentSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA79E030", Offset = "0xA79D030", VA = "0x18A79E030", Slot = "6")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA79E070", Offset = "0xA79D070", VA = "0x18A79E070", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79E310", Offset = "0xA79D310", VA = "0x18A79E310", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA79E2C0", Offset = "0xA79D2C0", VA = "0x18A79E2C0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4F071F0", Offset = "0x4F061F0", VA = "0x184F071F0")]
		public _MorphTargetTexCoordSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA79E240", Offset = "0xA79D240", VA = "0x18A79E240", Slot = "6")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA79E280", Offset = "0xA79D280", VA = "0x18A79E280", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79CA60", Offset = "0xA79BA60", VA = "0x18A79CA60", Slot = "4")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA79CA10", Offset = "0xA79BA10", VA = "0x18A79CA10", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4F071F0", Offset = "0x4F061F0", VA = "0x184F071F0")]
		public _MorphTargetColorSlice(IReadOnlyList<_MorphTargetDecoder> ggg, int idx, int set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA79C990", Offset = "0xA79B990", VA = "0x18A79C990", Slot = "6")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA79C9D0", Offset = "0xA79B9D0", VA = "0x18A79C9D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A19600", Offset = "0x8A18600", VA = "0x188A19600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA220E80", Offset = "0xA21FE80", VA = "0x18A220E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NodeInstance VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public SparseWeight8 MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA793830", Offset = "0xA792830", VA = "0x18A793830")]
			get
			{
				return default(SparseWeight8);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0xA793910", Offset = "0xA792910", VA = "0x18A793910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA7937C0", Offset = "0xA7927C0", VA = "0x18A7937C0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA7938C0", Offset = "0xA7928C0", VA = "0x18A7938C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Matrix4x4 ModelMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0xA7937F0", Offset = "0xA7927F0", VA = "0x18A7937F0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA793610", Offset = "0xA792610", VA = "0x18A793610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x10DC800", Offset = "0x10DB800", VA = "0x1810DC800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x10DD6A0", Offset = "0x10DC6A0", VA = "0x1810DD6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		private bool TransformChainIsDirty
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA793860", Offset = "0xA792860", VA = "0x18A793860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD0D9F0", Offset = "0xD0C9F0", VA = "0x180D0D9F0")]
		internal NodeInstance(NodeTemplate template, NodeInstance parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA7933A0", Offset = "0xA7923A0", VA = "0x18A7933A0")]
		private Matrix4x4 _GetModelMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA793610", Offset = "0xA792610", VA = "0x18A793610")]
		private void _SetModelMatrix(Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA7932B0", Offset = "0xA7922B0", VA = "0x18A7932B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD12820", Offset = "0xD11820", VA = "0x180D12820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xD127E0", Offset = "0xD117E0", VA = "0x180D127E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xD12E90", Offset = "0xD11E90", VA = "0x180D12E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xD12850", Offset = "0xD11850", VA = "0x180D12850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int LogicalNodeIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int ParentIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xDF8EE0", Offset = "0xDF7EE0", VA = "0x180DF8EE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IReadOnlyList<int> ChildIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA794C90", Offset = "0xA793C90", VA = "0x18A794C90")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA794480", Offset = "0xA793480", VA = "0x18A794480")]
		internal NodeTemplate(Node srcNode, int parentIdx, int[] childIndices, RuntimeOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA794180", Offset = "0xA793180", VA = "0x18A794180")]
		public SparseWeight8 GetMorphWeights(int trackLogicalIndex, float time)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA793EB0", Offset = "0xA792EB0", VA = "0x18A793EB0")]
		public SparseWeight8 GetMorphWeights(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA793BC0", Offset = "0xA792BC0", VA = "0x18A793BC0")]
		public AffineTransform GetLocalTransform(int trackLogicalIndex, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA793C50", Offset = "0xA792C50", VA = "0x18A793C50")]
		public AffineTransform GetLocalTransform(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA793940", Offset = "0xA792940", VA = "0x18A793940")]
		public Matrix4x4 GetLocalMatrix(int trackLogicalIndex, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA793A60", Offset = "0xA792A60", VA = "0x18A793A60")]
		public Matrix4x4 GetLocalMatrix(ReadOnlySpan<int> track, ReadOnlySpan<float> time, ReadOnlySpan<float> weight)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA7943E0", Offset = "0xA7933E0", VA = "0x18A7943E0")]
		public bool? GetVisibility(int trackLogicalIndex, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA794260", Offset = "0xA793260", VA = "0x18A794260")]
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
			[Cpp2IlInjected.Address(RVA = "0xA79EA80", Offset = "0xA79DA80", VA = "0x18A79EA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA79E740", Offset = "0xA79D740", VA = "0x18A79E740")]
		public _NodeTemplateTransforms(Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA79E5F0", Offset = "0xA79D5F0", VA = "0x18A79E5F0")]
		public void SetCurves(NodeCurveSamplers curves, int index, bool isolateMemory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA79E3F0", Offset = "0xA79D3F0", VA = "0x18A79E3F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD5F620", Offset = "0xD5E620", VA = "0x180D5F620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xE270B0", Offset = "0xE260B0", VA = "0x180E270B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MeshInstancing GpuMeshInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xDF8EE0", Offset = "0xDF7EE0", VA = "0x180DF8EE0")]
			[CompilerGenerated]
			get
			{
				return default(MeshInstancing);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xDF8ED0", Offset = "0xDF7ED0", VA = "0x180DF8ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Converter<ExtraProperties, object> ExtrasConverterCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA794F90", Offset = "0xA793F90", VA = "0x18A794F90")]
		internal static object ConvertExtras(ExtraProperties source, RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x161FA30", Offset = "0x161EA30", VA = "0x18161FA30")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA3D20", Offset = "0xDA2D20", VA = "0x180DA3D20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA7964B0", Offset = "0xA7954B0", VA = "0x18A7964B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public <GetEnumerator>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x6751B90", Offset = "0x6750B90", VA = "0x186751B90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA7962B0", Offset = "0xA7952B0", VA = "0x18A7962B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA796470", Offset = "0xA795470", VA = "0x18A796470", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA795070", Offset = "0xA794070", VA = "0x18A795070")]
		internal SceneInstance(ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA795000", Offset = "0xA794000", VA = "0x18A795000", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA795000", Offset = "0xA794000", VA = "0x18A795000", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public object Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public (Vector3 center, float radius) SphereBounds
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0xF7CED0", Offset = "0xF7BED0", VA = "0x180F7CED0")]
			[CompilerGenerated]
			get
			{
				return default((Vector3, float));
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xF7CF50", Offset = "0xF7BF50", VA = "0x180F7CF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public IEnumerable<int> LogicalMeshIds
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA795CC0", Offset = "0xA794CC0", VA = "0x18A795CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA7953A0", Offset = "0xA7943A0", VA = "0x18A7953A0")]
		public static SceneTemplate Create(Scene srcScene, [Optional] RuntimeOptions options)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x113C300", Offset = "0x113B300", VA = "0x18113C300")]
		private SceneTemplate(string name, object extras, ArmatureTemplate armature, DrawableTemplate[] drawables)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA7952F0", Offset = "0xA7942F0", VA = "0x18A7952F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40F5480", Offset = "0x40F4480", VA = "0x1840F5480")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA797F20", Offset = "0xA796F20", VA = "0x18A797F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x41080A0", Offset = "0x41070A0", VA = "0x1841080A0")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA7980E0", Offset = "0xA7970E0", VA = "0x18A7980E0")]
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

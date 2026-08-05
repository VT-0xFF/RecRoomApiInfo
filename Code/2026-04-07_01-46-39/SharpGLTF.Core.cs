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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xA68F550", Offset = "0xA68E550", VA = "0x18A68F550")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA68E520", Offset = "0xA68D520", VA = "0x18A68E520")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA68E790", Offset = "0xA68D790", VA = "0x18A68E790")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA68E9E0", Offset = "0xA68D9E0", VA = "0x18A68E9E0")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA68E480", Offset = "0xA68D480", VA = "0x18A68E480")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA68F1D0", Offset = "0xA68E1D0", VA = "0x18A68F1D0")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA68F0B0", Offset = "0xA68E0B0", VA = "0x18A68F0B0")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA68F6A0", Offset = "0xA68E6A0", VA = "0x18A68F6A0")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA68F640", Offset = "0xA68E640", VA = "0x18A68F640")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA68EEF0", Offset = "0xA68DEF0", VA = "0x18A68EEF0")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFDF0", Offset = "0x3AEEDF0", VA = "0x183AEFDF0")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE840", Offset = "0x3AED840", VA = "0x183AEE840")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA68EF50", Offset = "0xA68DF50", VA = "0x18A68EF50")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF880", Offset = "0x3AEE880", VA = "0x183AEF880")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF790", Offset = "0x3AEE790", VA = "0x183AEF790")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3AEEFF0", Offset = "0x3AEDFF0", VA = "0x183AEEFF0")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3AEEDF0", Offset = "0x3AEDDF0", VA = "0x183AEEDF0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDA90", Offset = "0x3AECA90", VA = "0x183AEDA90")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA68EAE0", Offset = "0xA68DAE0", VA = "0x18A68EAE0")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA68EA80", Offset = "0xA68DA80", VA = "0x18A68EA80")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA68EB40", Offset = "0xA68DB40", VA = "0x18A68EB40")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA68F2F0", Offset = "0xA68E2F0", VA = "0x18A68F2F0")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA68F450", Offset = "0xA68E450", VA = "0x18A68F450")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3AF22C0", Offset = "0x3AF12C0", VA = "0x183AF22C0")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA68E1F0", Offset = "0xA68D1F0", VA = "0x18A68E1F0")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1AA0", Offset = "0x3AF0AA0", VA = "0x183AF1AA0")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AF16F0", Offset = "0x3AF06F0", VA = "0x183AF16F0")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AF16F0", Offset = "0x3AF06F0", VA = "0x183AF16F0")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AF16F0", Offset = "0x3AF06F0", VA = "0x183AF16F0")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AF16F0", Offset = "0x3AF06F0", VA = "0x183AF16F0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0B70", Offset = "0x3AEFB70", VA = "0x183AF0B70")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x6721090", Offset = "0x6720090", VA = "0x186721090", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x671BEF0", Offset = "0x671AEF0", VA = "0x18671BEF0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x67214F0", Offset = "0x67204F0", VA = "0x1867214F0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x6F507C0", Offset = "0x6F4F7C0", VA = "0x186F507C0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x6F4C1D0", Offset = "0x6F4B1D0", VA = "0x186F4C1D0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x6F50C90", Offset = "0x6F4FC90", VA = "0x186F50C90")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x5165CC0", Offset = "0x5164CC0", VA = "0x185165CC0", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0x5165A80", Offset = "0x5164A80", VA = "0x185165A80", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5165710", Offset = "0x5164710", VA = "0x185165710", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x51659D0", Offset = "0x51649D0", VA = "0x1851659D0", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x671B3D0", Offset = "0x671A3D0", VA = "0x18671B3D0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x671B480", Offset = "0x671A480", VA = "0x18671B480", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x5088B20", Offset = "0x5087B20", VA = "0x185088B20")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x671B610", Offset = "0x671A610", VA = "0x18671B610", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x67199A0", Offset = "0x67189A0", VA = "0x1867199A0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x671BD00", Offset = "0x671AD00", VA = "0x18671BD00")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0x6F47370", Offset = "0x6F46370", VA = "0x186F47370", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6F46760", Offset = "0x6F45760", VA = "0x186F46760", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x6F478F0", Offset = "0x6F468F0", VA = "0x186F478F0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x515C820", Offset = "0x515B820", VA = "0x18515C820", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x515C560", Offset = "0x515B560", VA = "0x18515C560", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x515C740", Offset = "0x515B740", VA = "0x18515C740", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x13FFA60", Offset = "0x13FEA60", VA = "0x1813FFA60", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA69D8A0", Offset = "0xA69C8A0", VA = "0x18A69D8A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x65480C0", Offset = "0x65470C0", VA = "0x1865480C0")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA69D8F0", Offset = "0xA69C8F0", VA = "0x18A69D8F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA69D550", Offset = "0xA69C550", VA = "0x18A69D550", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA69D9B0", Offset = "0xA69C9B0", VA = "0x18A69D9B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA69D860", Offset = "0xA69C860", VA = "0x18A69D860", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA69D7B0", Offset = "0xA69C7B0", VA = "0x18A69D7B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA69D7B0", Offset = "0xA69C7B0", VA = "0x18A69D7B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A04590", Offset = "0x1A03590", VA = "0x181A04590", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA69E390", Offset = "0xA69D390", VA = "0x18A69E390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA69E3E0", Offset = "0xA69D3E0", VA = "0x18A69E3E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA69DA00", Offset = "0xA69CA00", VA = "0x18A69DA00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA69E5D0", Offset = "0xA69D5D0", VA = "0x18A69E5D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA69E620", Offset = "0xA69D620", VA = "0x18A69E620")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA69E670", Offset = "0xA69D670", VA = "0x18A69E670")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA69E350", Offset = "0xA69D350", VA = "0x18A69E350", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA69E2A0", Offset = "0xA69D2A0", VA = "0x18A69E2A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA69E2A0", Offset = "0xA69D2A0", VA = "0x18A69E2A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6A2530", Offset = "0xA6A1530", VA = "0x18A6A2530")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3F00", Offset = "0xA6A2F00", VA = "0x18A6A3F00")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4030", Offset = "0xA6A3030", VA = "0x18A6A4030")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3F40", Offset = "0xA6A2F40", VA = "0x18A6A3F40")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4060", Offset = "0xA6A3060", VA = "0x18A6A4060")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3FA0", Offset = "0xA6A2FA0", VA = "0x18A6A3FA0")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA6A40D0", Offset = "0xA6A30D0", VA = "0x18A6A40D0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3FA0", Offset = "0xA6A2FA0", VA = "0x18A6A3FA0")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3E30", Offset = "0xA6A2E30", VA = "0x18A6A3E30")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2660", Offset = "0xA6A1660", VA = "0x18A6A2660")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2540", Offset = "0xA6A1540", VA = "0x18A6A2540")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA6A18D0", Offset = "0xA6A08D0", VA = "0x18A6A18D0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2FD0", Offset = "0xA6A1FD0", VA = "0x18A6A2FD0")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA6A24E0", Offset = "0xA6A14E0", VA = "0x18A6A24E0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2480", Offset = "0xA6A1480", VA = "0x18A6A2480")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2760", Offset = "0xA6A1760", VA = "0x18A6A2760")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3AB0", Offset = "0xA6A2AB0", VA = "0x18A6A3AB0")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3C30", Offset = "0xA6A2C30", VA = "0x18A6A3C30")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2940", Offset = "0xA6A1940", VA = "0x18A6A2940")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2850", Offset = "0xA6A1850", VA = "0x18A6A2850")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2C10", Offset = "0xA6A1C10", VA = "0x18A6A2C10")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA6A22F0", Offset = "0xA6A12F0", VA = "0x18A6A22F0")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA693610", Offset = "0xA692610", VA = "0x18A693610")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3030", Offset = "0xA6A2030", VA = "0x18A6A3030")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA6A28D0", Offset = "0xA6A18D0", VA = "0x18A6A28D0")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2250", Offset = "0xA6A1250", VA = "0x18A6A2250")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2190", Offset = "0xA6A1190", VA = "0x18A6A2190")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x413AA60", Offset = "0x4139A60", VA = "0x18413AA60")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1A40", Offset = "0xA6A0A40", VA = "0x18A6A1A40")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1BB0", Offset = "0xA6A0BB0", VA = "0x18A6A1BB0")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x413BE00", Offset = "0x413AE00", VA = "0x18413BE00")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x413CF20", Offset = "0x413BF20", VA = "0x18413CF20")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x413D050", Offset = "0x413C050", VA = "0x18413D050")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x413CFA0", Offset = "0x413BFA0", VA = "0x18413CFA0")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x413AA80", Offset = "0x4139A80", VA = "0x18413AA80")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x413BC40", Offset = "0x413AC40", VA = "0x18413BC40")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x413BB30", Offset = "0x413AB30", VA = "0x18413BB30")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x413B900", Offset = "0x413A900", VA = "0x18413B900")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x413CE40", Offset = "0x413BE40", VA = "0x18413CE40")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x413C7B0", Offset = "0x413B7B0", VA = "0x18413C7B0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x413CD50", Offset = "0x413BD50", VA = "0x18413CD50")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x413C950", Offset = "0x413B950", VA = "0x18413C950")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x413B120", Offset = "0x413A120", VA = "0x18413B120")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x413AED0", Offset = "0x4139ED0", VA = "0x18413AED0")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x413A6E0", Offset = "0x41396E0", VA = "0x18413A6E0")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x413AB10", Offset = "0x4139B10", VA = "0x18413AB10")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2A10", Offset = "0xA6A1A10", VA = "0x18A6A2A10")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2D70", Offset = "0xA6A1D70", VA = "0x18A6A2D70")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x413CEA0", Offset = "0x413BEA0", VA = "0x18413CEA0")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x413CEA0", Offset = "0x413BEA0", VA = "0x18413CEA0")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A31C0", Offset = "0xA6A21C0", VA = "0x18A6A31C0")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1910", Offset = "0xA6A0910", VA = "0x18A6A1910")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1990", Offset = "0xA6A0990", VA = "0x18A6A1990")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3140", Offset = "0xA6A2140", VA = "0x18A6A3140")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3880", Offset = "0xA6A2880", VA = "0x18A6A3880")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1AF0", Offset = "0xA6A0AF0", VA = "0x18A6A1AF0")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA6A37B0", Offset = "0xA6A27B0", VA = "0x18A6A37B0")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA6A33C0", Offset = "0xA6A23C0", VA = "0x18A6A33C0")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1EE0", Offset = "0xA6A0EE0", VA = "0x18A6A1EE0")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1CB0", Offset = "0xA6A0CB0", VA = "0x18A6A1CB0")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1F80", Offset = "0xA6A0F80", VA = "0x18A6A1F80")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1C30", Offset = "0xA6A0C30", VA = "0x18A6A1C30")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA6A2110", Offset = "0xA6A1110", VA = "0x18A6A2110")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2388B00", Offset = "0x2387B00", VA = "0x182388B00")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3F20", Offset = "0xA6A2F20", VA = "0x18A6A3F20")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x413D2A0", Offset = "0x413C2A0", VA = "0x18413D2A0")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3080", Offset = "0xA6A2080", VA = "0x18A6A3080")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1E40", Offset = "0xA6A0E40", VA = "0x18A6A1E40")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3A00", Offset = "0xA6A2A00", VA = "0x18A6A3A00")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4370", Offset = "0xA6A3370", VA = "0x18A6A4370")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA6A3900", Offset = "0xA6A2900", VA = "0x18A6A3900")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1AE0", Offset = "0xA6A0AE0", VA = "0x18A6A1AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01390", Offset = "0xD00390", VA = "0x180D01390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00400", VA = "0x180D01400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string Message
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA695050", Offset = "0xA694050", VA = "0x18A695050", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private string _Generator
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA6950A0", Offset = "0xA6940A0", VA = "0x18A6950A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA694FC0", Offset = "0xA693FC0", VA = "0x18A694FC0")]
		internal ModelException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA694F10", Offset = "0xA693F10", VA = "0x18A694F10")]
		internal ModelException(JsonSerializable target, Exception ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA694B70", Offset = "0xA693B70", VA = "0x18A694B70")]
		private static string _CreateBaseMessage(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA694D10", Offset = "0xA693D10", VA = "0x18A694D10")]
		internal static void _Decorate(Exception ex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SchemaException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA68E1E0", Offset = "0xA68D1E0", VA = "0x18A68E1E0")]
		internal SchemaException(JsonSerializable target, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA694F10", Offset = "0xA693F10", VA = "0x18A694F10")]
		internal SchemaException(JsonSerializable target, JsonException rex)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class SemanticException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA68E1E0", Offset = "0xA68D1E0", VA = "0x18A68E1E0")]
		internal SemanticException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class LinkException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA68E1E0", Offset = "0xA68D1E0", VA = "0x18A68E1E0")]
		internal LinkException(JsonSerializable target, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class DataException : ModelException
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA68E1E0", Offset = "0xA68D1E0", VA = "0x18A68E1E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool TryFix
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA6A0DD0", Offset = "0xA69FDD0", VA = "0x18A6A0DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0CF0", Offset = "0xA69FCF0", VA = "0x18A6A0CF0")]
		public ValidationContext(ValidationResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0CA0", Offset = "0xA69FCA0", VA = "0x18A6A0CA0")]
		internal ValidationContext(ValidationContext context, JsonSerializable target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA69FAC0", Offset = "0xA69EAC0", VA = "0x18A69FAC0")]
		public ValidationContext GetContext(JsonSerializable target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0C00", Offset = "0xA69FC00", VA = "0x18A6A0C00")]
		[DebuggerStepThrough]
		internal void _SchemaThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0530", Offset = "0xA69F530", VA = "0x18A6A0530")]
		public ValidationContext IsTrue(ValueLocation parameterName, bool value, string msg)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0870", Offset = "0xA69F870", VA = "0x18A6A0870")]
		public ValidationContext NotNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0750", Offset = "0xA69F750", VA = "0x18A6A0750")]
		public ValidationContext MustBeNull(ValueLocation parameterName, object target)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x409D030", Offset = "0x409C030", VA = "0x18409D030")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x409CF90", Offset = "0x409BF90", VA = "0x18409CF90")]
		public ValidationContext IsDefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x409F130", Offset = "0x409E130", VA = "0x18409F130")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T value) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x409EFE0", Offset = "0x409DFE0", VA = "0x18409EFE0")]
		public ValidationContext IsUndefined<T>(ValueLocation parameterName, T? value) where T : struct
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x409BDF0", Offset = "0x409ADF0", VA = "0x18409BDF0")]
		public ValidationContext AreSameReference<TRef>(ValueLocation parameterName, TRef value, TRef expected) where TRef : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x409BCF0", Offset = "0x409ACF0", VA = "0x18409BCF0")]
		public ValidationContext AreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : IEquatable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x409E4B0", Offset = "0x409D4B0", VA = "0x18409E4B0")]
		public ValidationContext IsLess<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x409E140", Offset = "0x409D140", VA = "0x18409E140")]
		public ValidationContext IsLessOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue max) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x409D7F0", Offset = "0x409C7F0", VA = "0x18409D7F0")]
		public ValidationContext IsGreater<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x409C6A0", Offset = "0x409B6A0", VA = "0x18409C6A0")]
		public ValidationContext IsDefaultOrWithin<TValue>(ValueLocation parameterName, TValue? value, TValue minInclusive, TValue maxInclusive) where TValue : struct, IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x409D330", Offset = "0x409C330", VA = "0x18409D330")]
		public ValidationContext IsGreaterOrEqual<TValue>(ValueLocation parameterName, TValue value, TValue min) where TValue : IComparable<TValue>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA69FF20", Offset = "0xA69EF20", VA = "0x18A69FF20")]
		public ValidationContext IsMultipleOf(ValueLocation parameterName, int value, int multiple)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6A07E0", Offset = "0xA69F7E0", VA = "0x18A6A07E0")]
		public ValidationContext NonNegative(ValueLocation parameterName, int? value)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0320", Offset = "0xA69F320", VA = "0x18A6A0320")]
		public ValidationContext IsNullOrValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0580", Offset = "0xA69F580", VA = "0x18A6A0580")]
		public ValidationContext IsValidURI(ValueLocation parameterName, string gltfURI, params string[] validHeaders)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0B60", Offset = "0xA69FB60", VA = "0x18A6A0B60")]
		[DebuggerStepThrough]
		internal void _LinkThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x409C080", Offset = "0x409B080", VA = "0x18409C080")]
		public ValidationContext EnumsAreEqual<TValue>(ValueLocation parameterName, TValue value, TValue expected) where TValue : Enum
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x409EA40", Offset = "0x409DA40", VA = "0x18409EA40")]
		public ValidationContext IsNullOrIndex<T>(ValueLocation parameterName, int? index, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x409E5D0", Offset = "0x409D5D0", VA = "0x18409E5D0")]
		public ValidationContext IsNullOrInRange<T>(ValueLocation parameterName, int? offset, int length, IReadOnlyList<T> array)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x409C4A0", Offset = "0x409B4A0", VA = "0x18409C4A0")]
		public ValidationContext IsAnyOf<T>(ValueLocation parameterName, T value, params T[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA69FB20", Offset = "0xA69EB20", VA = "0x18A69FB20")]
		public ValidationContext IsAnyOf(ValueLocation parameterName, AttributeFormat value, params AttributeFormat[] values)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x409EAF0", Offset = "0x409DAF0", VA = "0x18409EAF0")]
		public ValidationContext IsSetCollection<T>(ValueLocation parameterName, IEnumerable<T> collection) where T : class
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0AC0", Offset = "0xA69FAC0", VA = "0x18A6A0AC0")]
		[DebuggerStepThrough]
		private void _DataThrow(ValueLocation pname, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x409DD40", Offset = "0x409CD40", VA = "0x18409DD40")]
		public ValidationContext IsInRange<T>(ValueLocation pname, T value, T minInclusive, T maxInclusive) where T : IComparable<T>
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6A01E0", Offset = "0xA69F1E0", VA = "0x18A6A01E0")]
		public ValidationContext IsNullOrMatrix(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6A00A0", Offset = "0xA69F0A0", VA = "0x18A6A00A0")]
		public ValidationContext IsNullOrMatrix4x3(ValueLocation pname, Matrix4x4? matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0390", Offset = "0xA69F390", VA = "0x18A6A0390")]
		public ValidationContext IsPosition(ValueLocation pname, [In] Vector3 position)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA69FFF0", Offset = "0xA69EFF0", VA = "0x18A69FFF0")]
		public ValidationContext IsNormal(ValueLocation pname, [In] Vector3 normal)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0490", Offset = "0xA69F490", VA = "0x18A6A0490")]
		public ValidationContext IsRotation(ValueLocation pname, [In] Quaternion rotation)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA69FE70", Offset = "0xA69EE70", VA = "0x18A69FE70")]
		public ValidationContext IsMatrix(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA69FDC0", Offset = "0xA69EDC0", VA = "0x18A69FDC0")]
		public ValidationContext IsMatrix4x3(ValueLocation pname, [In] Matrix4x4 matrix, bool mustInvert = true, bool mustDecompose = true)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA69F1C0", Offset = "0xA69E1C0", VA = "0x18A69F1C0")]
		public ValidationContext ArePositions(ValueLocation pname, IReadOnlyList<Vector3> positions)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA69EE50", Offset = "0xA69DE50", VA = "0x18A69EE50")]
		public ValidationContext AreNormals(ValueLocation pname, IReadOnlyList<Vector3> normals)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA69F7E0", Offset = "0xA69E7E0", VA = "0x18A69F7E0")]
		public ValidationContext AreTangents(ValueLocation pname, IReadOnlyList<Vector4> tangents)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA69F590", Offset = "0xA69E590", VA = "0x18A69F590")]
		public ValidationContext AreRotations(ValueLocation pname, IReadOnlyList<Quaternion> rotations)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA69E940", Offset = "0xA69D940", VA = "0x18A69E940")]
		public ValidationContext AreJoints(ValueLocation pname, IReadOnlyList<Vector4> joints, int skinsMaxJointCount)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0900", Offset = "0xA69F900", VA = "0x18A6A0900")]
		public ValidationContext That(Action action)
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0A60", Offset = "0xA69FA60", VA = "0x18A6A0A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6A1830", Offset = "0xA6A0830", VA = "0x18A6A1830")]
		public static implicit operator ValueLocation(int index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6A17D0", Offset = "0xA6A07D0", VA = "0x18A6A17D0")]
		public static implicit operator ValueLocation(int? index)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B790A0", Offset = "0x2B780A0", VA = "0x182B790A0")]
		public static implicit operator ValueLocation(string name)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1880", Offset = "0xA6A0880", VA = "0x18A6A1880")]
		public static implicit operator ValueLocation((string name, int index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1770", Offset = "0xA6A0770", VA = "0x18A6A1770")]
		public static implicit operator ValueLocation((string name, int? index) tuple)
		{
			return default(ValueLocation);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6A18C0", Offset = "0xA6A08C0", VA = "0x18A6A18C0")]
		public static implicit operator string(ValueLocation location)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xDAE230", Offset = "0xDAD230", VA = "0x180DAE230")]
		private ValueLocation(string name, int idx1 = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6A16F0", Offset = "0xA6A06F0", VA = "0x18A6A16F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1680", Offset = "0xA6A0680", VA = "0x18A6A1680")]
		public string ToString(JsonSerializable target, string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1550", Offset = "0xA6A0550", VA = "0x18A6A1550")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ValidationMode Mode
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			get
			{
				return default(ValidationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IEnumerable<Exception> Errors
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool HasErrors
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xA6A1500", Offset = "0xA6A0500", VA = "0x18A6A1500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1440", Offset = "0xA6A0440", VA = "0x18A6A1440")]
		public ValidationResult(ModelRoot root, ValidationMode mode, bool instantThrow = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0DE0", Offset = "0xA69FDE0", VA = "0x18A6A0DE0")]
		public ValidationContext GetContext()
		{
			return default(ValidationContext);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA6A1340", Offset = "0xA6A0340", VA = "0x18A6A1340")]
		public void SetSchemaError(EndOfStreamException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA6A12C0", Offset = "0xA6A02C0", VA = "0x18A6A12C0")]
		public void SetSchemaError(ModelRoot model, string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA6A11C0", Offset = "0xA6A01C0", VA = "0x18A6A11C0")]
		public void SetSchemaError(ModelRoot model, JsonException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA6A10A0", Offset = "0xA6A00A0", VA = "0x18A6A10A0")]
		public void SetModelError(FormatException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0FA0", Offset = "0xA69FFA0", VA = "0x18A6A0FA0")]
		public void SetModelError(ModelRoot model, ArgumentException ex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0ED0", Offset = "0xA69FED0", VA = "0x18A6A0ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA68DA50", Offset = "0xA68CA50", VA = "0x18A68DA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool IsMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA68DA30", Offset = "0xA68CA30", VA = "0x18A68DA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool IsSRT
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA68DA40", Offset = "0xA68CA40", VA = "0x18A68DA40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA68DD90", Offset = "0xA68CD90", VA = "0x18A68DD90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Quaternion Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA68DD20", Offset = "0xA68CD20", VA = "0x18A68DD20")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xED16B0", Offset = "0xED06B0", VA = "0x180ED16B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA68DCA0", Offset = "0xA68CCA0", VA = "0x18A68DCA0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IsLosslessDecomposable
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA68D920", Offset = "0xA68C920", VA = "0x18A68D920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IsIdentity
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA68D680", Offset = "0xA68C680", VA = "0x18A68D680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA68A0C0", Offset = "0xA6890C0", VA = "0x18A68A0C0")]
		internal string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA68DEB0", Offset = "0xA68CEB0", VA = "0x18A68DEB0")]
		public static implicit operator AffineTransform((Quaternion r, Vector3 t) xform)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA68E040", Offset = "0xA68D040", VA = "0x18A68E040")]
		public static implicit operator AffineTransform(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA68E000", Offset = "0xA68D000", VA = "0x18A68E000")]
		public static implicit operator AffineTransform(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA689150", Offset = "0xA688150", VA = "0x18A689150")]
		public static AffineTransform CreateDecomposed(Matrix4x4 matrix)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA6892C0", Offset = "0xA6882C0", VA = "0x18A6892C0")]
		public static AffineTransform CreateFromAny(Matrix4x4? matrix, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA68C030", Offset = "0xA68B030", VA = "0x18A68C030")]
		public AffineTransform WithScale(Vector3 scale)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA68BCB0", Offset = "0xA68ACB0", VA = "0x18A68BCB0")]
		public AffineTransform WithRotation(Quaternion rotation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA68C3E0", Offset = "0xA68B3E0", VA = "0x18A68C3E0")]
		public AffineTransform WithTranslation(Vector3 translation)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA68CE90", Offset = "0xA68BE90", VA = "0x18A68CE90")]
		public AffineTransform(Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA68D1D0", Offset = "0xA68C1D0", VA = "0x18A68D1D0")]
		public AffineTransform(Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA68CDC0", Offset = "0xA68BDC0", VA = "0x18A68CDC0")]
		public AffineTransform(Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA68D2B0", Offset = "0xA68C2B0", VA = "0x18A68D2B0")]
		public AffineTransform(Vector3 scale, Quaternion rotation, Vector3 translation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA68D020", Offset = "0xA68C020", VA = "0x18A68D020")]
		public AffineTransform(Matrix4x4 matrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA689910", Offset = "0xA688910", VA = "0x18A689910", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA6895B0", Offset = "0xA6885B0", VA = "0x18A6895B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA6896C0", Offset = "0xA6886C0", VA = "0x18A6896C0", Slot = "4")]
		public bool Equals(AffineTransform other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA68DE00", Offset = "0xA68CE00", VA = "0x18A68DE00")]
		public static bool operator ==([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA68E0A0", Offset = "0xA68D0A0", VA = "0x18A68E0A0")]
		public static bool operator !=([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA688930", Offset = "0xA687930", VA = "0x18A688930")]
		public static bool AreGeometricallyEquivalent([In] AffineTransform a, [In] AffineTransform b, float tolerance = 1E-05f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA689850", Offset = "0xA688850", VA = "0x18A689850")]
		public AffineTransform GetDecomposed()
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA68B030", Offset = "0xA68A030", VA = "0x18A68B030")]
		public bool TryDecompose([Out] AffineTransform transform)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA68ADF0", Offset = "0xA689DF0", VA = "0x18A68ADF0")]
		public bool TryDecompose([Out] Vector3 scale, [Out] Quaternion rotation, [Out] Vector3 translation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA688BC0", Offset = "0xA687BC0", VA = "0x18A688BC0")]
		public static AffineTransform Blend(ReadOnlySpan<AffineTransform> transforms, ReadOnlySpan<float> weights)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA68E150", Offset = "0xA68D150", VA = "0x18A68E150")]
		public static AffineTransform operator *([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA689940", Offset = "0xA688940", VA = "0x18A689940")]
		public static AffineTransform Multiply([In] AffineTransform a, [In] AffineTransform b)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA68B380", Offset = "0xA68A380", VA = "0x18A68B380")]
		public static bool TryInvert([In] AffineTransform xform, [Out] AffineTransform inverse)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA68A9D0", Offset = "0xA6899D0", VA = "0x18A68A9D0")]
		private static Vector3 Transform(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA68A5F0", Offset = "0xA6895F0", VA = "0x18A68A5F0")]
		public static Vector3 TransformNormal(Vector3 vector, [In] AffineTransform xform)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA68CCA0", Offset = "0xA68BCA0", VA = "0x18A68CCA0")]
		private void _VerifyDefined()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA68C750", Offset = "0xA68B750", VA = "0x18A68C750")]
		private Matrix4x4 _GetMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA68CBD0", Offset = "0xA68BBD0", VA = "0x18A68CBD0")]
		private Vector3 _GetScale()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA68CB00", Offset = "0xA68BB00", VA = "0x18A68CB00")]
		private Quaternion _GetRotation()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA688440", Offset = "0xA687440", VA = "0x18A688440")]
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
		[Cpp2IlInjected.Address(RVA = "0xA690D00", Offset = "0xA68FD00", VA = "0x18A690D00")]
		public static implicit operator IndexWeight((int Index, float Weight) pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA690CB0", Offset = "0xA68FCB0", VA = "0x18A690CB0")]
		public static implicit operator IndexWeight(KeyValuePair<int, float> pair)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA690BE0", Offset = "0xA68FBE0", VA = "0x18A690BE0")]
		public IndexWeight((int Index, float Weight) pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA690B70", Offset = "0xA68FB70", VA = "0x18A690B70")]
		public IndexWeight(KeyValuePair<int, float> pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x691BC50", Offset = "0x691AC50", VA = "0x18691BC50")]
		public IndexWeight(int i, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA68FFC0", Offset = "0xA68EFC0", VA = "0x18A68FFC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA68FF00", Offset = "0xA68EF00", VA = "0x18A68FF00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA68FFA0", Offset = "0xA68EFA0", VA = "0x18A68FFA0", Slot = "4")]
		public bool Equals(IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA690990", Offset = "0xA68F990", VA = "0x18A690990")]
		public bool IsGreaterThan([In] IndexWeight other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA690C20", Offset = "0xA68FC20", VA = "0x18A690C20")]
		public static IndexWeight operator +(IndexWeight a, IndexWeight b)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA690C00", Offset = "0xA68FC00", VA = "0x18A690C00")]
		public static IndexWeight operator +(IndexWeight a, float w)
		{
			return default(IndexWeight);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA690A30", Offset = "0xA68FA30", VA = "0x18A690A30")]
		public static bool IsWellFormed(ReadOnlySpan<IndexWeight> iw, [Out] string err)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA690010", Offset = "0xA68F010", VA = "0x18A690010")]
		public static int InsertSorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA6904E0", Offset = "0xA68F4E0", VA = "0x18A6904E0")]
		public static int InsertUnsorted(Span<IndexWeight> sparse, [In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA6902E0", Offset = "0xA68F2E0", VA = "0x18A6902E0")]
		public static int InsertUnsorted(Span<IndexWeight> buffer, int length, IndexWeight item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA68FAC0", Offset = "0xA68EAC0", VA = "0x18A68FAC0")]
		public static int CopyTo([In] SparseWeight8 src, Span<int> dstIndices, Span<float> dstWeights, int dstLength)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA68F920", Offset = "0xA68E920", VA = "0x18A68F920")]
		public static void BubbleSortByWeight(Span<IndexWeight> pairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA68F840", Offset = "0xA68E840", VA = "0x18A68F840")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6927A0", Offset = "0xA6917A0", VA = "0x18A6927A0")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public (double x, double y, double z) Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA692840", Offset = "0xA691840", VA = "0x18A692840")]
			get
			{
				return default((double, double, double));
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA6931F0", Offset = "0xA6921F0", VA = "0x18A6931F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA6926F0", Offset = "0xA6916F0", VA = "0x18A6926F0")]
		public Matrix4x4Double(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double m41, double m42, double m43, double m44)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA692630", Offset = "0xA691630", VA = "0x18A692630")]
		public Matrix4x4Double(Matrix4x4 other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA691600", Offset = "0xA690600", VA = "0x18A691600")]
		public static Matrix4x4Double CreateTranslation(double xPosition, double yPosition, double zPosition)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA6915A0", Offset = "0xA6905A0", VA = "0x18A6915A0")]
		public static Matrix4x4Double CreateScale(double xScale, double yScale, double zScale)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA691410", Offset = "0xA690410", VA = "0x18A691410")]
		public static Matrix4x4Double CreateFromQuaternion(Quaternion quaternion)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA692A00", Offset = "0xA691A00", VA = "0x18A692A00")]
		public static explicit operator Matrix4x4(Matrix4x4Double mat)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA692BB0", Offset = "0xA691BB0", VA = "0x18A692BB0")]
		public static implicit operator Matrix4x4Double(Matrix4x4 mat)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA691B30", Offset = "0xA690B30", VA = "0x18A691B30", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA6928B0", Offset = "0xA6918B0", VA = "0x18A6928B0")]
		public static bool operator ==(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA692C90", Offset = "0xA691C90", VA = "0x18A692C90")]
		public static bool operator !=(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA6919A0", Offset = "0xA6909A0", VA = "0x18A6919A0", Slot = "4")]
		public readonly bool Equals(Matrix4x4Double other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA691660", Offset = "0xA690660", VA = "0x18A691660", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA691D90", Offset = "0xA690D90", VA = "0x18A691D90")]
		public static bool Invert(Matrix4x4Double matrix, [Out] Matrix4x4Double result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA692450", Offset = "0xA691450", VA = "0x18A692450")]
		public static Matrix4x4Double Multiply(Matrix4x4Double value1, Matrix4x4Double value2)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA692DE0", Offset = "0xA691DE0", VA = "0x18A692DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA694760", Offset = "0xA693760", VA = "0x18A694760")]
		private static MatrixCheck _Validate([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(MatrixCheck);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA693610", Offset = "0xA692610", VA = "0x18A693610")]
		public static bool IsValid([In] Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA693550", Offset = "0xA692550", VA = "0x18A693550")]
		[DebuggerStepThrough]
		public static void GuardMatrix(string argName, Matrix4x4 matrix, MatrixCheck check, float tolerance = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA6932F0", Offset = "0xA6922F0", VA = "0x18A6932F0")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA693210", Offset = "0xA692210", VA = "0x18A693210")]
		public static Matrix4x4 CreateFromRows(Vector3 rowX, Vector3 rowY, Vector3 rowZ, Vector3 translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA6933B0", Offset = "0xA6923B0", VA = "0x18A6933B0")]
		public static Matrix4x4 CreateFrom(Matrix4x4? transform, Vector3? scale, Quaternion? rotation, Vector3? translation)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA693630", Offset = "0xA692630", VA = "0x18A693630")]
		public static Matrix4x4 LocalToWorld([In] Matrix4x4 parentWorld, [In] Matrix4x4 childLocal)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA694420", Offset = "0xA693420", VA = "0x18A694420")]
		public static Matrix4x4 WorldToLocal([In] Matrix4x4 parentWorld, [In] Matrix4x4 childWorld)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA693960", Offset = "0xA692960", VA = "0x18A693960")]
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
			[Cpp2IlInjected.Address(RVA = "0x5173930", Offset = "0x5172930", VA = "0x185173930")]
			get
			{
				return default(SparseWeight8);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool AbsoluteMorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD9B510", Offset = "0xD9A510", VA = "0x180D9B510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA6961A0", Offset = "0xA6951A0", VA = "0x18A6961A0")]
		protected MorphTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA6961E0", Offset = "0xA6951E0", VA = "0x18A6961E0")]
		protected MorphTransform(SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA696090", Offset = "0xA695090", VA = "0x18A696090")]
		public void Update([In] SparseWeight8 morphWeights, bool useAbsoluteMorphTargets = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA695750", Offset = "0xA694750", VA = "0x18A695750")]
		protected Vector2 MorphVectors(Vector2 value, IReadOnlyList<Vector2> morphTargets)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA6951C0", Offset = "0xA6941C0", VA = "0x18A6951C0")]
		protected Vector3 MorphVectors(Vector3 value, IReadOnlyList<Vector3> morphTargets)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA695B20", Offset = "0xA694B20", VA = "0x18A695B20")]
		protected Vector4 MorphVectors(Vector4 value, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA695170", Offset = "0xA694170", VA = "0x18A695170", Slot = "5")]
		public Vector4 MorphColors(Vector4 color, IReadOnlyList<Vector4> morphTargets)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA6951B0", Offset = "0xA6941B0", VA = "0x18A6951B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD24A20", Offset = "0xD23A20", VA = "0x180D24A20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x20B7260", Offset = "0x20B6260", VA = "0x1820B7260", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA6973A0", Offset = "0xA6963A0", VA = "0x18A6973A0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA6972B0", Offset = "0xA6962B0", VA = "0x18A6972B0")]
		public RigidTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA697200", Offset = "0xA696200", VA = "0x18A697200")]
		public RigidTransform(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA697150", Offset = "0xA696150", VA = "0x18A697150")]
		public RigidTransform(Matrix4x4 worldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA696FA0", Offset = "0xA695FA0", VA = "0x18A696FA0")]
		public void Update(Matrix4x4 worldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA696C00", Offset = "0xA695C00", VA = "0x18A696C00")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA696A70", Offset = "0xA695A70", VA = "0x18A696A70")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA696DA0", Offset = "0xA695DA0", VA = "0x18A696DA0")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA696870", Offset = "0xA695870", VA = "0x18A696870", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA6966E0", Offset = "0xA6956E0", VA = "0x18A6966E0", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA696A20", Offset = "0xA695A20", VA = "0x18A696A20", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FlipFaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public IReadOnlyList<Matrix4x4> SkinMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA6961A0", Offset = "0xA6951A0", VA = "0x18A6961A0")]
		public SkinnedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA6990A0", Offset = "0xA6980A0", VA = "0x18A6990A0")]
		public SkinnedTransform(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA699130", Offset = "0xA698130", VA = "0x18A699130")]
		public SkinnedTransform(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix, SparseWeight8 morphWeights, bool useAbsoluteMorphTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA698CF0", Offset = "0xA697CF0", VA = "0x18A698CF0")]
		public void Update(Matrix4x4[] invBindMatrix, Matrix4x4[] currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA6989E0", Offset = "0xA6979E0", VA = "0x18A6989E0")]
		public void Update(int count, Func<int, Matrix4x4> invBindMatrix, Func<int, Matrix4x4> currWorldMatrix)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA697FA0", Offset = "0xA696FA0", VA = "0x18A697FA0")]
		public Vector3 TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA697B00", Offset = "0xA696B00", VA = "0x18A697B00")]
		public Vector3 TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA698510", Offset = "0xA697510", VA = "0x18A698510")]
		public Vector4 TransformTangent(Vector4 tangent, IReadOnlyList<Vector3> tangentDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA6977D0", Offset = "0xA6967D0", VA = "0x18A6977D0")]
		public static Matrix4x4 CalculateInverseBinding(Matrix4x4 meshWorldTransform, Matrix4x4 jointWorldTransform)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA6973D0", Offset = "0xA6963D0", VA = "0x18A6973D0")]
		public static Matrix4x4Double CalculateInverseBinding(Matrix4x4Double meshWorldTransform, Matrix4x4Double jointWorldTransform)
		{
			return default(Matrix4x4Double);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA697A50", Offset = "0xA696A50", VA = "0x18A697A50", Slot = "8")]
		Vector3 IGeometryTransform.TransformPosition(Vector3 localPosition, IReadOnlyList<Vector3> positionDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA6979F0", Offset = "0xA6969F0", VA = "0x18A6979F0", Slot = "9")]
		Vector3 IGeometryTransform.TransformNormal(Vector3 localNormal, IReadOnlyList<Vector3> normalDeltas, [In] SparseWeight8 skinWeights)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA697AB0", Offset = "0xA696AB0", VA = "0x18A697AB0", Slot = "10")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <Evaluate>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA69D440", Offset = "0xA69C440", VA = "0x18A69D440", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA69D0A0", Offset = "0xA69C0A0", VA = "0x18A69D0A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA69D500", Offset = "0xA69C500", VA = "0x18A69D500")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA69D400", Offset = "0xA69C400", VA = "0x18A69D400", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA69D360", Offset = "0xA69C360", VA = "0x18A69D360", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IGeometryTransform> IEnumerable<IGeometryTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA69D360", Offset = "0xA69C360", VA = "0x18A69D360", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6913F0", Offset = "0xA6903F0", VA = "0x18A6913F0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IReadOnlyList<Matrix4x4> LocalMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xDD3B70", Offset = "0xDD2B70", VA = "0x180DD3B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public IReadOnlyList<RigidTransform> WorldTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA690DA0", Offset = "0xA68FDA0", VA = "0x18A690DA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA691160", Offset = "0xA690160", VA = "0x18A691160")]
		public InstancingTransform(AffineTransform[] instances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA691060", Offset = "0xA690060", VA = "0x18A691060")]
		private RigidTransform[] _CreateTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA690DA0", Offset = "0xA68FDA0", VA = "0x18A690DA0")]
		public RigidTransform[] UpdateInstances()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA690D20", Offset = "0xA68FD20", VA = "0x18A690D20")]
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
		[Cpp2IlInjected.Address(RVA = "0xA696230", Offset = "0xA695230", VA = "0x18A696230")]
		public static Matrix4x4 CreateOrthographicMatrix(float xmag, float ymag, float znear, float zfar)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA696430", Offset = "0xA695430", VA = "0x18A696430")]
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
				[Cpp2IlInjected.Address(RVA = "0xED46A0", Offset = "0xED36A0", VA = "0x180ED46A0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2087290", Offset = "0x2086290", VA = "0x182087290", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x15B89F0", Offset = "0x15B79F0", VA = "0x1815B89F0")]
			[DebuggerHidden]
			public <Expand>d__51(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xA6B15C0", Offset = "0xA6B05C0", VA = "0x18A6B15C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA6B16F0", Offset = "0xA6B06F0", VA = "0x18A6B16F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA6B1630", Offset = "0xA6B0630", VA = "0x18A6B1630", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<float> IEnumerable<float>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA6B1630", Offset = "0xA6B0630", VA = "0x18A6B1630", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x13FFA60", Offset = "0x13FEA60", VA = "0x1813FFA60", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6B4740", Offset = "0xA6B3740", VA = "0x18A6B4740", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x65480C0", Offset = "0x65470C0", VA = "0x1865480C0")]
			[DebuggerHidden]
			public <GetIndexedWeights>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA6B43A0", Offset = "0xA6B33A0", VA = "0x18A6B43A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4700", Offset = "0xA6B3700", VA = "0x18A6B4700", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4640", Offset = "0xA6B3640", VA = "0x18A6B4640", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4640", Offset = "0xA6B3640", VA = "0x18A6B4640", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x13FFA60", Offset = "0x13FEA60", VA = "0x1813FFA60", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6B4B80", Offset = "0xA6B3B80", VA = "0x18A6B4B80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x65480C0", Offset = "0x65470C0", VA = "0x1865480C0")]
			[DebuggerHidden]
			public <GetNonZeroWeights>d__53(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4790", Offset = "0xA6B3790", VA = "0x18A6B4790", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4B40", Offset = "0xA6B3B40", VA = "0x18A6B4B40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4A80", Offset = "0xA6B3A80", VA = "0x18A6B4A80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, float)> IEnumerable<(int, float)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4A80", Offset = "0xA6B3A80", VA = "0x18A6B4A80", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x13FFA60", Offset = "0x13FEA60", VA = "0x1813FFA60", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6BBCC0", Offset = "0xA6BACC0", VA = "0x18A6BBCC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x65480C0", Offset = "0x65470C0", VA = "0x1865480C0")]
			[DebuggerHidden]
			public <_GetPairs>d__64(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA6BB900", Offset = "0xA6BA900", VA = "0x18A6BB900", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA6BBC80", Offset = "0xA6BAC80", VA = "0x18A6BBC80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xA6BBBC0", Offset = "0xA6BABC0", VA = "0x18A6BBBC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<IndexWeight> IEnumerable<IndexWeight>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xA6BBBC0", Offset = "0xA6BABC0", VA = "0x18A6BBBC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA69CEF0", Offset = "0xA69BEF0", VA = "0x18A69CEF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA69A950", Offset = "0xA699950", VA = "0x18A69A950")]
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
			[Cpp2IlInjected.Address(RVA = "0xA69CF00", Offset = "0xA69BF00", VA = "0x18A69CF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float WeightSum
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xA69CFF0", Offset = "0xA69BFF0", VA = "0x18A69CFF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int MaxIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xA69CFE0", Offset = "0xA69BFE0", VA = "0x18A69CFE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA69C100", Offset = "0xA69B100", VA = "0x18A69C100")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA699EC0", Offset = "0xA698EC0", VA = "0x18A699EC0")]
		public static SparseWeight8 Create(params float[] weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA69A3B0", Offset = "0xA6993B0", VA = "0x18A69A3B0")]
		public static SparseWeight8 Create(IEnumerable<float> weights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA699E80", Offset = "0xA698E80", VA = "0x18A699E80")]
		public static SparseWeight8 Create(params (int Index, float Weight)[] indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA699F00", Offset = "0xA698F00", VA = "0x18A699F00")]
		public static SparseWeight8 Create(IEnumerable<(int Index, float Weight)> indexedWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA69A2B0", Offset = "0xA6992B0", VA = "0x18A69A2B0")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 wgt0123)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA699C20", Offset = "0xA698C20", VA = "0x18A699C20")]
		public static SparseWeight8 Create([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA699B90", Offset = "0xA698B90", VA = "0x18A699B90")]
		public static SparseWeight8 CreateUnchecked([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA69CDD0", Offset = "0xA69BDD0", VA = "0x18A69CDD0")]
		private SparseWeight8([In] Vector4 idx0123, [In] Vector4 idx4567, [In] Vector4 wgt0123, [In] Vector4 wgt4567)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA69CD10", Offset = "0xA69BD10", VA = "0x18A69CD10")]
		private SparseWeight8(ReadOnlySpan<IndexWeight> iw)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA69CE50", Offset = "0xA69BE50", VA = "0x18A69CE50")]
		private SparseWeight8([In] SparseWeight8 sparse, float scale)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA69AA70", Offset = "0xA699A70", VA = "0x18A69AA70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA69A7D0", Offset = "0xA6997D0", VA = "0x18A69A7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA69A890", Offset = "0xA699890", VA = "0x18A69A890", Slot = "4")]
		public bool Equals(SparseWeight8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA69D020", Offset = "0xA69C020", VA = "0x18A69D020")]
		public static bool operator ==(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA69D060", Offset = "0xA69C060", VA = "0x18A69D060")]
		public static bool operator !=(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA699320", Offset = "0xA698320", VA = "0x18A699320")]
		internal static bool AreEqual([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA69BAF0", Offset = "0xA69AAF0", VA = "0x18A69BAF0")]
		public static SparseWeight8 OrderedByWeight([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA69B910", Offset = "0xA69A910", VA = "0x18A69B910")]
		public static SparseWeight8 OrderedByIndex([In] SparseWeight8 sparse)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6991D0", Offset = "0xA6981D0", VA = "0x18A6991D0")]
		public static SparseWeight8 Add([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA69BEC0", Offset = "0xA69AEC0", VA = "0x18A69BEC0")]
		public static SparseWeight8 Subtract([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA69B7C0", Offset = "0xA69A7C0", VA = "0x18A69B7C0")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, [In] SparseWeight8 y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA69B720", Offset = "0xA69A720", VA = "0x18A69B720")]
		public static SparseWeight8 Multiply([In] SparseWeight8 x, float y)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA69B5F0", Offset = "0xA69A5F0", VA = "0x18A69B5F0")]
		public static SparseWeight8 InterpolateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA69B4B0", Offset = "0xA69A4B0", VA = "0x18A69B4B0")]
		public static SparseWeight8 InterpolateCubic([In] SparseWeight8 x, [In] SparseWeight8 xt, [In] SparseWeight8 y, [In] SparseWeight8 yt, float amount)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA69A8B0", Offset = "0xA6998B0", VA = "0x18A69A8B0")]
		[IteratorStateMachine(typeof(<Expand>d__51))]
		public IEnumerable<float> Expand(int count)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA69AC60", Offset = "0xA699C60", VA = "0x18A69AC60")]
		[IteratorStateMachine(typeof(<GetIndexedWeights>d__52))]
		public IEnumerable<(int, float)> GetIndexedWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA69ACF0", Offset = "0xA699CF0", VA = "0x18A69ACF0")]
		[IteratorStateMachine(typeof(<GetNonZeroWeights>d__53))]
		public IEnumerable<(int, float)> GetNonZeroWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6996A0", Offset = "0xA6986A0", VA = "0x18A6996A0")]
		public static SparseWeight8 Blend(ReadOnlySpan<SparseWeight8> sparses, ReadOnlySpan<float> weight)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA69B060", Offset = "0xA69A060", VA = "0x18A69B060")]
		public SparseWeight8 GetTrimmed(int maxWeights)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA69AF10", Offset = "0xA699F10", VA = "0x18A69AF10")]
		public SparseWeight8 GetNormalized()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA69C010", Offset = "0xA69B010", VA = "0x18A69C010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA69C9A0", Offset = "0xA69B9A0", VA = "0x18A69C9A0")]
		private static SparseWeight8 _OperateLinear([In] SparseWeight8 x, [In] SparseWeight8 y, Func<float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA69C4F0", Offset = "0xA69B4F0", VA = "0x18A69C4F0")]
		private static SparseWeight8 _OperateCubic([In] SparseWeight8 x, [In] SparseWeight8 y, [In] SparseWeight8 z, [In] SparseWeight8 w, Func<float, float, float, float, float> operationFunc)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA69A950", Offset = "0xA699950", VA = "0x18A69A950")]
		private float GetExpandedAt(int idx)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA69A9B0", Offset = "0xA6999B0", VA = "0x18A69A9B0")]
		private int GetExpandedCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA69AD80", Offset = "0xA699D80", VA = "0x18A69AD80")]
		internal SparseWeight8 GetNormalizedWithComplement(int complementIndex)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA69C270", Offset = "0xA69B270", VA = "0x18A69C270")]
		internal int _GetMaxIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA69C460", Offset = "0xA69B460", VA = "0x18A69C460")]
		[IteratorStateMachine(typeof(<_GetPairs>d__64))]
		internal IEnumerable<IndexWeight> _GetPairs()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA69B1A0", Offset = "0xA69A1A0", VA = "0x18A69B1A0")]
		internal int InsertTo(Span<IndexWeight> dst)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA699910", Offset = "0xA698910", VA = "0x18A699910")]
		internal void CopyTo(Span<IndexWeight> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA6994A0", Offset = "0xA6984A0", VA = "0x18A6994A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xA6BA2D0", Offset = "0xA6B92D0", VA = "0x18A6BA2D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9FA0", Offset = "0xA6B8FA0", VA = "0x18A6B9FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA6BA390", Offset = "0xA6B9390", VA = "0x18A6BA390")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xA6BA290", Offset = "0xA6B9290", VA = "0x18A6BA290", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xA6BA1F0", Offset = "0xA6B91F0", VA = "0x18A6BA1F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xA6BA1F0", Offset = "0xA6B91F0", VA = "0x18A6BA1F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC930", Offset = "0xA6BB930", VA = "0x18A6BC930")]
		internal XmpPackets(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC440", Offset = "0xA6BB440", VA = "0x18A6BC440")]
		public int AddPacket(JsonNode packet)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC630", Offset = "0xA6BB630", VA = "0x18A6BC630", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC660", Offset = "0xA6BB660", VA = "0x18A6BC660", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__6))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC790", Offset = "0xA6BB790", VA = "0x18A6BC790", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC6E0", Offset = "0xA6BB6E0", VA = "0x18A6BC6E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC590", Offset = "0xA6BB590", VA = "0x18A6BC590", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4F00", Offset = "0xA6B3F00", VA = "0x18A6B4F00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4BD0", Offset = "0xA6B3BD0", VA = "0x18A6B4BD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4FC0", Offset = "0xA6B3FC0", VA = "0x18A6B4FC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4EC0", Offset = "0xA6B3EC0", VA = "0x18A6B4EC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4E20", Offset = "0xA6B3E20", VA = "0x18A6B4E20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4E20", Offset = "0xA6B3E20", VA = "0x18A6B4E20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFBA70", Offset = "0xCFAA70", VA = "0x180CFBA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public JsonNode JsonPacket
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xA6BC370", Offset = "0xA6BB370", VA = "0x18A6BC370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC330", Offset = "0xA6BB330", VA = "0x18A6BC330")]
		internal XmpPacketReference(ExtraProperties owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC200", Offset = "0xA6BB200", VA = "0x18A6BC200")]
		private ModelRoot _FindRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC280", Offset = "0xA6BB280", VA = "0x18A6BC280")]
		private XmpPackets _GetPackets()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA6BBEF0", Offset = "0xA6BAEF0", VA = "0x18A6BBEF0")]
		public void SetPacket(int logicalIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA6BBDB0", Offset = "0xA6BADB0", VA = "0x18A6BBDB0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA6BBDE0", Offset = "0xA6BADE0", VA = "0x18A6BBDE0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__11))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC060", Offset = "0xA6BB060", VA = "0x18A6BC060", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA6BBE60", Offset = "0xA6BAE60", VA = "0x18A6BBE60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA6BBD10", Offset = "0xA6BAD10", VA = "0x18A6BBD10", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9210", Offset = "0xA6B8210", VA = "0x18A6B9210", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA6B6100", Offset = "0xA6B5100", VA = "0x18A6B6100", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9D70", Offset = "0xA6B8D70", VA = "0x18A6B9D70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8990", Offset = "0xA6B7990", VA = "0x18A6B8990", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8090", Offset = "0xA6B7090", VA = "0x18A6B8090", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8090", Offset = "0xA6B7090", VA = "0x18A6B8090", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4EC0", Offset = "0xA6A3EC0", VA = "0x18A6A4EC0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4EF0", Offset = "0xA6A3EF0", VA = "0x18A6A4EF0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A5320", Offset = "0xA6A4320", VA = "0x18A6A5320", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4F70", Offset = "0xA6A3F70", VA = "0x18A6A4F70", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4E20", Offset = "0xA6A3E20", VA = "0x18A6A4E20", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A54D0", Offset = "0xA6A44D0", VA = "0x18A6A54D0")]
		public AnimationPointer(AnimationChannelTarget parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA6A50E0", Offset = "0xA6A40E0", VA = "0x18A6A50E0")]
		public static bool TryParseNodeTransform(string pointerPath, [Out] int nodeIndex, [Out] PropertyPath property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA6A4FD0", Offset = "0xA6A3FD0", VA = "0x18A6A4FD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6B1C30", Offset = "0xA6B0C30", VA = "0x18A6B1C30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xA6B1730", Offset = "0xA6B0730", VA = "0x18A6B1730", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xA6B1BF0", Offset = "0xA6B0BF0", VA = "0x18A6B1BF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xA6B1B40", Offset = "0xA6B0B40", VA = "0x18A6B1B40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xA6B1B40", Offset = "0xA6B0B40", VA = "0x18A6B1B40", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9810", Offset = "0xA6B8810", VA = "0x18A6B9810", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xA6B5390", Offset = "0xA6B4390", VA = "0x18A6B5390", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9C80", Offset = "0xA6B8C80", VA = "0x18A6B9C80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8C10", Offset = "0xA6B7C10", VA = "0x18A6B8C10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA6B7EB0", Offset = "0xA6B6EB0", VA = "0x18A6B7EB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA6B7EB0", Offset = "0xA6B6EB0", VA = "0x18A6B7EB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6A5DE0", Offset = "0xA6A4DE0", VA = "0x18A6A5DE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA6A5E30", Offset = "0xA6A4E30", VA = "0x18A6A5E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float AnisotropyRotation
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA6A5EB0", Offset = "0xA6A4EB0", VA = "0x18A6A5EB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA6A5F00", Offset = "0xA6A4F00", VA = "0x18A6A5F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA6A56C0", Offset = "0xA6A46C0", VA = "0x18A6A56C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0xA6A57E0", Offset = "0xA6A47E0", VA = "0x18A6A57E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA6A59B0", Offset = "0xA6A49B0", VA = "0x18A6A59B0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA6A5860", Offset = "0xA6A4860", VA = "0x18A6A5860", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA6A5510", Offset = "0xA6A4510", VA = "0x18A6A5510", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA6A5FB0", Offset = "0xA6A4FB0", VA = "0x18A6A5FB0")]
		internal MaterialAnisotropy(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA6A56F0", Offset = "0xA6A46F0", VA = "0x18A6A56F0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A5630", Offset = "0xA6A4630", VA = "0x18A6A5630")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6B3AA0", Offset = "0xA6B2AA0", VA = "0x18A6B3AA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__28(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xA6B3240", Offset = "0xA6B2240", VA = "0x18A6B3240", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA6B3A60", Offset = "0xA6B2A60", VA = "0x18A6B3A60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xA6B39B0", Offset = "0xA6B29B0", VA = "0x18A6B39B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xA6B39B0", Offset = "0xA6B29B0", VA = "0x18A6B39B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9450", Offset = "0xA6B8450", VA = "0x18A6B9450", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xA6B5010", Offset = "0xA6B4010", VA = "0x18A6B5010", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9E10", Offset = "0xA6B8E10", VA = "0x18A6B9E10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8A50", Offset = "0xA6B7A50", VA = "0x18A6B8A50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA6B7F50", Offset = "0xA6B6F50", VA = "0x18A6B7F50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA6B7F50", Offset = "0xA6B6F50", VA = "0x18A6B7F50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6A6BD0", Offset = "0xA6A5BD0", VA = "0x18A6A6BD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6C20", Offset = "0xA6A5C20", VA = "0x18A6A6C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6D40", Offset = "0xA6A5D40", VA = "0x18A6A6D40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6D90", Offset = "0xA6A5D90", VA = "0x18A6A6D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6260", Offset = "0xA6A5260", VA = "0x18A6A6260", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA6A63E0", Offset = "0xA6A53E0", VA = "0x18A6A63E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6600", Offset = "0xA6A5600", VA = "0x18A6A6600", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6460", Offset = "0xA6A5460", VA = "0x18A6A6460", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6030", Offset = "0xA6A5030", VA = "0x18A6A6030", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A70F0", Offset = "0xA6A60F0", VA = "0x18A6A70F0")]
		internal MaterialClearCoat(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6290", Offset = "0xA6A5290", VA = "0x18A6A6290", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA6A7060", Offset = "0xA6A6060", VA = "0x18A6A7060")]
		private TextureInfo _GetClearCoatTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6FD0", Offset = "0xA6A5FD0", VA = "0x18A6A6FD0")]
		private TextureInfo _GetClearCoatRoughnessTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA6A6F40", Offset = "0xA6A5F40", VA = "0x18A6A6F40")]
		private MaterialNormalTextureInfo _GetClearCoatNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA6A61D0", Offset = "0xA6A51D0", VA = "0x18A6A61D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6B29E0", Offset = "0xA6B19E0", VA = "0x18A6B29E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA6B2250", Offset = "0xA6B1250", VA = "0x18A6B2250", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xA6B29A0", Offset = "0xA6B19A0", VA = "0x18A6B29A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA6B28B0", Offset = "0xA6B18B0", VA = "0x18A6B28B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA6B28B0", Offset = "0xA6B18B0", VA = "0x18A6B28B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9150", Offset = "0xA6B8150", VA = "0x18A6B9150", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA6B7B90", Offset = "0xA6B6B90", VA = "0x18A6B7B90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9B90", Offset = "0xA6B8B90", VA = "0x18A6B9B90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8C50", Offset = "0xA6B7C50", VA = "0x18A6B8C50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8270", Offset = "0xA6B7270", VA = "0x18A6B8270", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8270", Offset = "0xA6B7270", VA = "0x18A6B8270", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6A7BF0", Offset = "0xA6A6BF0", VA = "0x18A6A7BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA6A7C40", Offset = "0xA6A6C40", VA = "0x18A6A7C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 DiffuseTransmissionColorFactor
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xA6A7D30", Offset = "0xA6A6D30", VA = "0x18A6A7D30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0xA6A7DF0", Offset = "0xA6A6DF0", VA = "0x18A6A7DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA6A7370", Offset = "0xA6A6370", VA = "0x18A6A7370", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A7490", Offset = "0xA6A6490", VA = "0x18A6A7490", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A76D0", Offset = "0xA6A66D0", VA = "0x18A6A76D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A7510", Offset = "0xA6A6510", VA = "0x18A6A7510", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA6A7170", Offset = "0xA6A6170", VA = "0x18A6A7170", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6A7EF0", Offset = "0xA6A6EF0", VA = "0x18A6A7EF0")]
		internal MaterialDiffuseTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6A73A0", Offset = "0xA6A63A0", VA = "0x18A6A73A0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6A72E0", Offset = "0xA6A62E0", VA = "0x18A6A72E0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9990", Offset = "0xA6B8990", VA = "0x18A6B9990", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xA6B58E0", Offset = "0xA6B48E0", VA = "0x18A6B58E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9C30", Offset = "0xA6B8C30", VA = "0x18A6B9C30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8C90", Offset = "0xA6B7C90", VA = "0x18A6B8C90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA6B84F0", Offset = "0xA6B74F0", VA = "0x18A6B84F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA6B84F0", Offset = "0xA6B74F0", VA = "0x18A6B84F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD453C0", Offset = "0xD443C0", VA = "0x180D453C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA6A84A0", Offset = "0xA6A74A0", VA = "0x18A6A84A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA6A84F0", Offset = "0xA6A74F0", VA = "0x18A6A84F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8060", Offset = "0xA6A7060", VA = "0x18A6A8060", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8160", Offset = "0xA6A7160", VA = "0x18A6A8160", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6A82A0", Offset = "0xA6A72A0", VA = "0x18A6A82A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA6A81E0", Offset = "0xA6A71E0", VA = "0x18A6A81E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6A7FC0", Offset = "0xA6A6FC0", VA = "0x18A6A7FC0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8440", Offset = "0xA6A7440", VA = "0x18A6A8440")]
		internal MaterialDispersion(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8090", Offset = "0xA6A7090", VA = "0x18A6A8090", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9690", Offset = "0xA6B8690", VA = "0x18A6B9690", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xA6B6840", Offset = "0xA6B5840", VA = "0x18A6B6840", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9B40", Offset = "0xA6B8B40", VA = "0x18A6B9B40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8CD0", Offset = "0xA6B7CD0", VA = "0x18A6B8CD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8130", Offset = "0xA6B7130", VA = "0x18A6B8130", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8130", Offset = "0xA6B7130", VA = "0x18A6B8130", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6A9180", Offset = "0xA6A8180", VA = "0x18A6A9180")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xA6A9190", Offset = "0xA6A8190", VA = "0x18A6A9190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xA6A91E0", Offset = "0xA6A81E0", VA = "0x18A6A91E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8D10", Offset = "0xA6A7D10", VA = "0x18A6A8D10", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8E40", Offset = "0xA6A7E40", VA = "0x18A6A8E40", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8F80", Offset = "0xA6A7F80", VA = "0x18A6A8F80", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8EC0", Offset = "0xA6A7EC0", VA = "0x18A6A8EC0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8C70", Offset = "0xA6A7C70", VA = "0x18A6A8C70", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6A9120", Offset = "0xA6A8120", VA = "0x18A6A9120")]
		internal MaterialIOR(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8D40", Offset = "0xA6A7D40", VA = "0x18A6A8D40", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6B4340", Offset = "0xA6B3340", VA = "0x18A6B4340", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__35(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA6B3B00", Offset = "0xA6B2B00", VA = "0x18A6B3B00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4300", Offset = "0xA6B3300", VA = "0x18A6B4300", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4250", Offset = "0xA6B3250", VA = "0x18A6B4250", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA6B4250", Offset = "0xA6B3250", VA = "0x18A6B4250", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9510", Offset = "0xA6B8510", VA = "0x18A6B9510", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0xA6B77C0", Offset = "0xA6B67C0", VA = "0x18A6B77C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9A50", Offset = "0xA6B8A50", VA = "0x18A6B9A50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8BD0", Offset = "0xA6B7BD0", VA = "0x18A6B8BD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xA6B86D0", Offset = "0xA6B76D0", VA = "0x18A6B86D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xA6B86D0", Offset = "0xA6B76D0", VA = "0x18A6B86D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6AA140", Offset = "0xA6A9140", VA = "0x18A6AA140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA6AA190", Offset = "0xA6A9190", VA = "0x18A6AA190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public float IridescenceIndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xA6AA210", Offset = "0xA6A9210", VA = "0x18A6AA210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xA6AA270", Offset = "0xA6A9270", VA = "0x18A6AA270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public float IridescenceThicknessMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xA6AA360", Offset = "0xA6A9360", VA = "0x18A6AA360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xA6AA3C0", Offset = "0xA6A93C0", VA = "0x18A6AA3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float IridescenceThicknessMaximum
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xA6A9FF0", Offset = "0xA6A8FF0", VA = "0x18A6A9FF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xA6AA050", Offset = "0xA6A9050", VA = "0x18A6AA050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6A9480", Offset = "0xA6A8480", VA = "0x18A6A9480", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6A96E0", Offset = "0xA6A86E0", VA = "0x18A6A96E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6A9990", Offset = "0xA6A8990", VA = "0x18A6A9990", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6A9760", Offset = "0xA6A8760", VA = "0x18A6A9760", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6A9250", Offset = "0xA6A8250", VA = "0x18A6A9250", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6AA440", Offset = "0xA6A9440", VA = "0x18A6AA440")]
		internal MaterialIridescence(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6A94B0", Offset = "0xA6A84B0", VA = "0x18A6A94B0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA6A93F0", Offset = "0xA6A83F0", VA = "0x18A6A93F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8E50", Offset = "0xA6B7E50", VA = "0x18A6B8E50", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xA6B5690", Offset = "0xA6B4690", VA = "0x18A6B5690", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9D20", Offset = "0xA6B8D20", VA = "0x18A6B9D20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8AD0", Offset = "0xA6B7AD0", VA = "0x18A6B8AD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8810", Offset = "0xA6B7810", VA = "0x18A6B8810", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8810", Offset = "0xA6B7810", VA = "0x18A6B8810", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6A8BA0", Offset = "0xA6A7BA0", VA = "0x18A6A8BA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xA6A8BF0", Offset = "0xA6A7BF0", VA = "0x18A6A8BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8760", Offset = "0xA6A7760", VA = "0x18A6A8760", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8860", Offset = "0xA6A7860", VA = "0x18A6A8860", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA6A89A0", Offset = "0xA6A79A0", VA = "0x18A6A89A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA6A88E0", Offset = "0xA6A78E0", VA = "0x18A6A88E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8580", Offset = "0xA6A7580", VA = "0x18A6A8580", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8B40", Offset = "0xA6A7B40", VA = "0x18A6A8B40")]
		internal MaterialEmissiveStrength(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8790", Offset = "0xA6A7790", VA = "0x18A6A8790", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA6A8620", Offset = "0xA6A7620", VA = "0x18A6A8620")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6B31E0", Offset = "0xA6B21E0", VA = "0x18A6B31E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA6B2AA0", Offset = "0xA6B1AA0", VA = "0x18A6B2AA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA6B31A0", Offset = "0xA6B21A0", VA = "0x18A6B31A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xA6B30F0", Offset = "0xA6B20F0", VA = "0x18A6B30F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA6B30F0", Offset = "0xA6B20F0", VA = "0x18A6B30F0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9750", Offset = "0xA6B8750", VA = "0x18A6B9750", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA6B6A90", Offset = "0xA6B5A90", VA = "0x18A6B6A90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9AA0", Offset = "0xA6B8AA0", VA = "0x18A6B9AA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8A10", Offset = "0xA6B7A10", VA = "0x18A6B8A10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8630", Offset = "0xA6B7630", VA = "0x18A6B8630", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8630", Offset = "0xA6B7630", VA = "0x18A6B8630", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6AD380", Offset = "0xA6AC380", VA = "0x18A6AD380")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA6AD3D0", Offset = "0xA6AC3D0", VA = "0x18A6AD3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 AttenuationColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA6AD450", Offset = "0xA6AC450", VA = "0x18A6AD450")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0xA6AD510", Offset = "0xA6AC510", VA = "0x18A6AD510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float AttenuationDistance
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA6AD5C0", Offset = "0xA6AC5C0", VA = "0x18A6AD5C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xA6AD620", Offset = "0xA6AC620", VA = "0x18A6AD620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA6AC9C0", Offset = "0xA6AB9C0", VA = "0x18A6AC9C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA6ACBE0", Offset = "0xA6ABBE0", VA = "0x18A6ACBE0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA6ACE40", Offset = "0xA6ABE40", VA = "0x18A6ACE40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ACC60", Offset = "0xA6ABC60", VA = "0x18A6ACC60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA6AC7C0", Offset = "0xA6AB7C0", VA = "0x18A6AC7C0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA6AD6E0", Offset = "0xA6AC6E0", VA = "0x18A6AD6E0")]
		internal MaterialVolume(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA6AC9F0", Offset = "0xA6AB9F0", VA = "0x18A6AC9F0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA6AC930", Offset = "0xA6AB930", VA = "0x18A6AC930")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xA6B95D0", Offset = "0xA6B85D0", VA = "0x18A6B95D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xA6B5B30", Offset = "0xA6B4B30", VA = "0x18A6B5B30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9AF0", Offset = "0xA6B8AF0", VA = "0x18A6B9AF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8950", Offset = "0xA6B7950", VA = "0x18A6B8950", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8310", Offset = "0xA6B7310", VA = "0x18A6B8310", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8310", Offset = "0xA6B7310", VA = "0x18A6B8310", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x5BA6F10", Offset = "0x5BA5F10", VA = "0x185BA6F10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6BB8A0", Offset = "0xA6BA8A0", VA = "0x18A6BB8A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x6548090", Offset = "0x6547090", VA = "0x186548090")]
			[DebuggerHidden]
			public <_GetLocalTransforms>d__21(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA6BB700", Offset = "0xA6BA700", VA = "0x18A6BB700", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA6BB860", Offset = "0xA6BA860", VA = "0x18A6BB860", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xA6BB7C0", Offset = "0xA6BA7C0", VA = "0x18A6BB7C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<AffineTransform> IEnumerable<AffineTransform>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0xA6BB7C0", Offset = "0xA6BA7C0", VA = "0x18A6BB7C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Node VisualParent
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xA6AE830", Offset = "0xA6AD830", VA = "0x18A6AE830")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IReadOnlyDictionary<string, Accessor> Accessors
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0xA6AE560", Offset = "0xA6AD560", VA = "0x18A6AE560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public IEnumerable<AffineTransform> LocalTransforms
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xA6AE720", Offset = "0xA6AD720", VA = "0x18A6AE720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA6ADDD0", Offset = "0xA6ACDD0", VA = "0x18A6ADDD0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE020", Offset = "0xA6AD020", VA = "0x18A6AE020", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE2E0", Offset = "0xA6AD2E0", VA = "0x18A6AE2E0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE0A0", Offset = "0xA6AD0A0", VA = "0x18A6AE0A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA6AD800", Offset = "0xA6AC800", VA = "0x18A6AD800", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE7A0", Offset = "0xA6AD7A0", VA = "0x18A6AE7A0")]
		internal MeshGpuInstancing(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE630", Offset = "0xA6AD630", VA = "0x18A6AE630")]
		private int _GetCount()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE560", Offset = "0xA6AD560", VA = "0x18A6AE560")]
		private IReadOnlyDictionary<string, Accessor> _GetAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE720", Offset = "0xA6AD720", VA = "0x18A6AE720")]
		[IteratorStateMachine(typeof(<_GetLocalTransforms>d__21))]
		private IEnumerable<AffineTransform> _GetLocalTransforms()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA6AD7B0", Offset = "0xA6AC7B0", VA = "0x18A6AD7B0")]
		public void ClearAccessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA6AD8A0", Offset = "0xA6AC8A0", VA = "0x18A6AD8A0")]
		public Accessor GetAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE110", Offset = "0xA6AD110", VA = "0x18A6AE110")]
		public void SetAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA6ADA80", Offset = "0xA6ACA80", VA = "0x18A6ADA80")]
		public AffineTransform GetLocalTransform(int index)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA6AD9A0", Offset = "0xA6AC9A0", VA = "0x18A6AD9A0")]
		public Matrix4x4 GetLocalMatrix(int index)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA6ADE00", Offset = "0xA6ACE00", VA = "0x18A6ADE00")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8F10", Offset = "0xA6B7F10", VA = "0x18A6B8F10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xA6B6350", Offset = "0xA6B5350", VA = "0x18A6B6350", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9F50", Offset = "0xA6B8F50", VA = "0x18A6B9F50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8D10", Offset = "0xA6B7D10", VA = "0x18A6B8D10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xA6B88B0", Offset = "0xA6B78B0", VA = "0x18A6B88B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xA6B88B0", Offset = "0xA6B78B0", VA = "0x18A6B88B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6AF110", Offset = "0xA6AE110", VA = "0x18A6AF110")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA6AF1C0", Offset = "0xA6AE1C0", VA = "0x18A6AF1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA6AF160", Offset = "0xA6AE160", VA = "0x18A6AF160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA6AF2E0", Offset = "0xA6AE2E0", VA = "0x18A6AF2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE910", Offset = "0xA6AD910", VA = "0x18A6AE910", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6AEC30", Offset = "0xA6ADC30", VA = "0x18A6AEC30", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6AEDD0", Offset = "0xA6ADDD0", VA = "0x18A6AEDD0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6AECB0", Offset = "0xA6ADCB0", VA = "0x18A6AECB0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE840", Offset = "0xA6AD840", VA = "0x18A6AE840", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA6AE940", Offset = "0xA6AD940", VA = "0x18A6AE940", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA6AF080", Offset = "0xA6AE080", VA = "0x18A6AF080")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8FD0", Offset = "0xA6B7FD0", VA = "0x18A6B8FD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA6B5D80", Offset = "0xA6B4D80", VA = "0x18A6B5D80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9CD0", Offset = "0xA6B8CD0", VA = "0x18A6B9CD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8B50", Offset = "0xA6B7B50", VA = "0x18A6B8B50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8770", Offset = "0xA6B7770", VA = "0x18A6B8770", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8770", Offset = "0xA6B7770", VA = "0x18A6B8770", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6B0C30", Offset = "0xA6AFC30", VA = "0x18A6B0C30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public PunctualLightType LightType
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0B40", Offset = "0xA6AFB40", VA = "0x18A6B0B40")]
			get
			{
				return default(PunctualLightType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public float InnerConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0A80", Offset = "0xA6AFA80", VA = "0x18A6B0A80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public float OuterConeAngle
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0CD0", Offset = "0xA6AFCD0", VA = "0x18A6B0CD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xA6B09C0", Offset = "0xA6AF9C0", VA = "0x18A6B09C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0D90", Offset = "0xA6AFD90", VA = "0x18A6B0D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0AE0", Offset = "0xA6AFAE0", VA = "0x18A6B0AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0EB0", Offset = "0xA6AFEB0", VA = "0x18A6B0EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public float Range
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0D30", Offset = "0xA6AFD30", VA = "0x18A6B0D30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0xA6B0F30", Offset = "0xA6AFF30", VA = "0x18A6B0F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6AF5C0", Offset = "0xA6AE5C0", VA = "0x18A6AF5C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA6AF8B0", Offset = "0xA6AE8B0", VA = "0x18A6AF8B0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6B00D0", Offset = "0xA6AF0D0", VA = "0x18A6B00D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6AF930", Offset = "0xA6AE930", VA = "0x18A6AF930", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA6AF400", Offset = "0xA6AE400", VA = "0x18A6AF400", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6B08E0", Offset = "0xA6AF8E0", VA = "0x18A6B08E0")]
		internal PunctualLight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6B06F0", Offset = "0xA6AF6F0", VA = "0x18A6B06F0")]
		internal PunctualLight(PunctualLightType ltype)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6AFD80", Offset = "0xA6AED80", VA = "0x18A6AFD80")]
		public void SetSpotCone(float innerConeAngle, float outerConeAngle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6AFB30", Offset = "0xA6AEB30", VA = "0x18A6AFB30")]
		public void SetColor(Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6AF6C0", Offset = "0xA6AE6C0", VA = "0x18A6AF6C0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6AF5F0", Offset = "0xA6AE5F0", VA = "0x18A6AF5F0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xA6B98D0", Offset = "0xA6B88D0", VA = "0x18A6B98D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xA6B65F0", Offset = "0xA6B55F0", VA = "0x18A6B65F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9EB0", Offset = "0xA6B8EB0", VA = "0x18A6B9EB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8A90", Offset = "0xA6B7A90", VA = "0x18A6B8A90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xA6B7FF0", Offset = "0xA6B6FF0", VA = "0x18A6B7FF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xA6B7FF0", Offset = "0xA6B6FF0", VA = "0x18A6B7FF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCB00", Offset = "0xA6BBB00", VA = "0x18A6BCB00", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCB30", Offset = "0xA6BBB30", VA = "0x18A6BCB30", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCC60", Offset = "0xA6BBC60", VA = "0x18A6BCC60", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCBB0", Offset = "0xA6BBBB0", VA = "0x18A6BCBB0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCA60", Offset = "0xA6BBA60", VA = "0x18A6BCA60", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCE00", Offset = "0xA6BBE00", VA = "0x18A6BCE00")]
		internal _ModelPunctualLights(ModelRoot root)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC9B0", Offset = "0xA6BB9B0", VA = "0x18A6BC9B0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9390", Offset = "0xA6B8390", VA = "0x18A6B9390", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA6B7570", Offset = "0xA6B6570", VA = "0x18A6B7570", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9E60", Offset = "0xA6B8E60", VA = "0x18A6B9E60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA6B89D0", Offset = "0xA6B79D0", VA = "0x18A6B89D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8590", Offset = "0xA6B7590", VA = "0x18A6B8590", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8590", Offset = "0xA6B7590", VA = "0x18A6B8590", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6B1370", Offset = "0xA6B0370", VA = "0x18A6B1370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xA6B1480", Offset = "0xA6B0480", VA = "0x18A6B1480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA6B10B0", Offset = "0xA6B00B0", VA = "0x18A6B10B0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA6B10E0", Offset = "0xA6B00E0", VA = "0x18A6B10E0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6B11D0", Offset = "0xA6B01D0", VA = "0x18A6B11D0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6B1160", Offset = "0xA6B0160", VA = "0x18A6B1160", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6B1010", Offset = "0xA6B0010", VA = "0x18A6B1010", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6A54D0", Offset = "0xA6A44D0", VA = "0x18A6A54D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8D90", Offset = "0xA6B7D90", VA = "0x18A6B8D90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA6B7320", Offset = "0xA6B6320", VA = "0x18A6B7320", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9F00", Offset = "0xA6B8F00", VA = "0x18A6B9F00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8B10", Offset = "0xA6B7B10", VA = "0x18A6B8B10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA6B81D0", Offset = "0xA6B71D0", VA = "0x18A6B81D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA6B81D0", Offset = "0xA6B71D0", VA = "0x18A6B81D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xD4BEA0", Offset = "0xD4AEA0", VA = "0x180D4BEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCF30", Offset = "0xA6BBF30", VA = "0x18A6BCF30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCF60", Offset = "0xA6BBF60", VA = "0x18A6BCF60", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD070", Offset = "0xA6BC070", VA = "0x18A6BD070", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCFE0", Offset = "0xA6BBFE0", VA = "0x18A6BCFE0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xA6BCE90", Offset = "0xA6BBE90", VA = "0x18A6BCE90", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD210", Offset = "0xA6BC210", VA = "0x18A6BD210")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA6B92D0", Offset = "0xA6B82D0", VA = "0x18A6B92D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA6B70D0", Offset = "0xA6B60D0", VA = "0x18A6B70D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9DC0", Offset = "0xA6B8DC0", VA = "0x18A6B9DC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8D50", Offset = "0xA6B7D50", VA = "0x18A6B8D50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8450", Offset = "0xA6B7450", VA = "0x18A6B8450", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8450", Offset = "0xA6B7450", VA = "0x18A6B8450", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6BD6D0", Offset = "0xA6BC6D0", VA = "0x18A6BD6D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xA6BD750", Offset = "0xA6BC750", VA = "0x18A6BD750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD2C0", Offset = "0xA6BC2C0", VA = "0x18A6BD2C0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD2F0", Offset = "0xA6BC2F0", VA = "0x18A6BD2F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD440", Offset = "0xA6BC440", VA = "0x18A6BD440", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD370", Offset = "0xA6BC370", VA = "0x18A6BD370", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD220", Offset = "0xA6BC220", VA = "0x18A6BD220", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD620", Offset = "0xA6BC620", VA = "0x18A6BD620")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6B2A40", Offset = "0xA6B1A40", VA = "0x18A6B2A40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xA6B1C90", Offset = "0xA6B0C90", VA = "0x18A6B1C90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xA6B2960", Offset = "0xA6B1960", VA = "0x18A6B2960", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA6B2800", Offset = "0xA6B1800", VA = "0x18A6B2800", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA6B2800", Offset = "0xA6B1800", VA = "0x18A6B2800", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9090", Offset = "0xA6B8090", VA = "0x18A6B9090", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA6B6DB0", Offset = "0xA6B5DB0", VA = "0x18A6B6DB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA6B9BE0", Offset = "0xA6B8BE0", VA = "0x18A6B9BE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xA6B8B90", Offset = "0xA6B7B90", VA = "0x18A6B8B90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xA6B83B0", Offset = "0xA6B73B0", VA = "0x18A6B83B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xA6B83B0", Offset = "0xA6B73B0", VA = "0x18A6B83B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6AC3E0", Offset = "0xA6AB3E0", VA = "0x18A6AC3E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA6AC4A0", Offset = "0xA6AB4A0", VA = "0x18A6AC4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public float SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xA6AC5C0", Offset = "0xA6AB5C0", VA = "0x18A6AC5C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xA6AC620", Offset = "0xA6AB620", VA = "0x18A6AC620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xA6ABA50", Offset = "0xA6AAA50", VA = "0x18A6ABA50", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0xA6ABC70", Offset = "0xA6AAC70", VA = "0x18A6ABC70", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xA6ABEC0", Offset = "0xA6AAEC0", VA = "0x18A6ABEC0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA6ABCF0", Offset = "0xA6AACF0", VA = "0x18A6ABCF0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xA6AB850", Offset = "0xA6AA850", VA = "0x18A6AB850", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xA6AC6E0", Offset = "0xA6AB6E0", VA = "0x18A6AC6E0")]
		internal MaterialSpecular(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA6ABA80", Offset = "0xA6AAA80", VA = "0x18A6ABA80", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xA6AB9C0", Offset = "0xA6AA9C0", VA = "0x18A6AB9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6D59D0", Offset = "0xA6D49D0", VA = "0x18A6D59D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0xA6D51A0", Offset = "0xA6D41A0", VA = "0x18A6D51A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0xA6D5990", Offset = "0xA6D4990", VA = "0x18A6D5990", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D58E0", Offset = "0xA6D48E0", VA = "0x18A6D58E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D58E0", Offset = "0xA6D48E0", VA = "0x18A6D58E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8EA0", Offset = "0xA6D7EA0", VA = "0x18A6D8EA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D5E70", Offset = "0xA6D4E70", VA = "0x18A6D5E70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9BA0", Offset = "0xA6D8BA0", VA = "0x18A6D9BA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8E20", Offset = "0xA6D7E20", VA = "0x18A6D8E20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8620", Offset = "0xA6D7620", VA = "0x18A6D8620", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8620", Offset = "0xA6D7620", VA = "0x18A6D8620", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6AB290", Offset = "0xA6AA290", VA = "0x18A6AB290")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA6AB350", Offset = "0xA6AA350", VA = "0x18A6AB350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 SpecularFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA6AB470", Offset = "0xA6AA470", VA = "0x18A6AB470")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA6AB530", Offset = "0xA6AA530", VA = "0x18A6AB530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public float GlossinessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA6AB5E0", Offset = "0xA6AA5E0", VA = "0x18A6AB5E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xA6AB640", Offset = "0xA6AA640", VA = "0x18A6AB640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xA6AA770", Offset = "0xA6A9770", VA = "0x18A6AA770", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xA6AA990", Offset = "0xA6A9990", VA = "0x18A6AA990", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA6AAC60", Offset = "0xA6A9C60", VA = "0x18A6AAC60", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xA6AAA10", Offset = "0xA6A9A10", VA = "0x18A6AAA10", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xA6AA520", Offset = "0xA6A9520", VA = "0x18A6AA520", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA6AB720", Offset = "0xA6AA720", VA = "0x18A6AB720")]
		internal MaterialPBRSpecularGlossiness(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA6AA7A0", Offset = "0xA6A97A0", VA = "0x18A6AA7A0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA6AA6E0", Offset = "0xA6A96E0", VA = "0x18A6AA6E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6D5140", Offset = "0xA6D4140", VA = "0x18A6D5140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xA6D4AA0", Offset = "0xA6D3AA0", VA = "0x18A6D4AA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xA6D5100", Offset = "0xA6D4100", VA = "0x18A6D5100", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0xA6D5050", Offset = "0xA6D4050", VA = "0x18A6D5050", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0xA6D5050", Offset = "0xA6D4050", VA = "0x18A6D5050", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0xA6D93E0", Offset = "0xA6D83E0", VA = "0x18A6D93E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xA6D69D0", Offset = "0xA6D59D0", VA = "0x18A6D69D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9970", Offset = "0xA6D8970", VA = "0x18A6D9970")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8B20", Offset = "0xA6D7B20", VA = "0x18A6D8B20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8760", Offset = "0xA6D7760", VA = "0x18A6D8760", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8760", Offset = "0xA6D7760", VA = "0x18A6D8760", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1D60", Offset = "0xA6D0D60", VA = "0x18A6D1D60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1E20", Offset = "0xA6D0E20", VA = "0x18A6D1E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F40", Offset = "0xA6D0F40", VA = "0x18A6D1F40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F80", Offset = "0xA6D0F80", VA = "0x18A6D1F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0xA6D13E0", Offset = "0xA6D03E0", VA = "0x18A6D13E0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1600", Offset = "0xA6D0600", VA = "0x18A6D1600", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1840", Offset = "0xA6D0840", VA = "0x18A6D1840", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1680", Offset = "0xA6D0680", VA = "0x18A6D1680", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA6D11E0", Offset = "0xA6D01E0", VA = "0x18A6D11E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2020", Offset = "0xA6D1020", VA = "0x18A6D2020")]
		internal MaterialSheen(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1410", Offset = "0xA6D0410", VA = "0x18A6D1410", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1350", Offset = "0xA6D0350", VA = "0x18A6D1350")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0xA6D94A0", Offset = "0xA6D84A0", VA = "0x18A6D94A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0xA6D5A30", Offset = "0xA6D4A30", VA = "0x18A6D5A30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9A60", Offset = "0xA6D8A60", VA = "0x18A6D9A60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8BA0", Offset = "0xA6D7BA0", VA = "0x18A6D8BA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8440", Offset = "0xA6D7440", VA = "0x18A6D8440", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8440", Offset = "0xA6D7440", VA = "0x18A6D8440", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D2DD0", Offset = "0xA6D1DD0", VA = "0x18A6D2DD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xA6D2E70", Offset = "0xA6D1E70", VA = "0x18A6D2E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2B10", Offset = "0xA6D1B10", VA = "0x18A6D2B10", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2B40", Offset = "0xA6D1B40", VA = "0x18A6D2B40", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2C30", Offset = "0xA6D1C30", VA = "0x18A6D2C30", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2BC0", Offset = "0xA6D1BC0", VA = "0x18A6D2BC0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2A70", Offset = "0xA6D1A70", VA = "0x18A6D2A70", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6A54D0", Offset = "0xA6A44D0", VA = "0x18A6A54D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9560", Offset = "0xA6D8560", VA = "0x18A6D9560", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D6F40", Offset = "0xA6D5F40", VA = "0x18A6D6F40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9B50", Offset = "0xA6D8B50", VA = "0x18A6D9B50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8B60", Offset = "0xA6D7B60", VA = "0x18A6D8B60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F6")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8300", Offset = "0xA6D7300", VA = "0x18A6D8300", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004F7")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8300", Offset = "0xA6D7300", VA = "0x18A6D8300", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D3D70", Offset = "0xA6D2D70", VA = "0x18A6D3D70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xA6D3F00", Offset = "0xA6D2F00", VA = "0x18A6D3F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xA6D3E60", Offset = "0xA6D2E60", VA = "0x18A6D3E60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0xA6D4010", Offset = "0xA6D3010", VA = "0x18A6D4010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D3E10", Offset = "0xA6D2E10", VA = "0x18A6D3E10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0xA6D3FB0", Offset = "0xA6D2FB0", VA = "0x18A6D3FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public int? TextureCoordinateOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0x8BCB590", Offset = "0x8BCA590", VA = "0x188BCB590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0xA6D40C0", Offset = "0xA6D30C0", VA = "0x18A6D40C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xA6D3A50", Offset = "0xA6D2A50", VA = "0x18A6D3A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public Matrix3x2 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0xA6D3AC0", Offset = "0xA6D2AC0", VA = "0x18A6D3AC0")]
			get
			{
				return default(Matrix3x2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3120", Offset = "0xA6D2120", VA = "0x18A6D3120", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3150", Offset = "0xA6D2150", VA = "0x18A6D3150", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3400", Offset = "0xA6D2400", VA = "0x18A6D3400", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D31D0", Offset = "0xA6D21D0", VA = "0x18A6D31D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2FB0", Offset = "0xA6D1FB0", VA = "0x18A6D2FB0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D3920", Offset = "0xA6D2920", VA = "0x18A6D3920")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9320", Offset = "0xA6D8320", VA = "0x18A6D9320", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000506")]
			[Cpp2IlInjected.Address(RVA = "0xA6D6CF0", Offset = "0xA6D5CF0", VA = "0x18A6D6CF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9BF0", Offset = "0xA6D8BF0", VA = "0x18A6D9BF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8E60", Offset = "0xA6D7E60", VA = "0x18A6D8E60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8940", Offset = "0xA6D7940", VA = "0x18A6D8940", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8940", Offset = "0xA6D7940", VA = "0x18A6D8940", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D4430", Offset = "0xA6D3430", VA = "0x18A6D4430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004FF")]
			[Cpp2IlInjected.Address(RVA = "0xA6D44D0", Offset = "0xA6D34D0", VA = "0x18A6D44D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4170", Offset = "0xA6D3170", VA = "0x18A6D4170", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D41A0", Offset = "0xA6D31A0", VA = "0x18A6D41A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4290", Offset = "0xA6D3290", VA = "0x18A6D4290", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D4220", Offset = "0xA6D3220", VA = "0x18A6D4220", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6D40D0", Offset = "0xA6D30D0", VA = "0x18A6D40D0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6A54D0", Offset = "0xA6A44D0", VA = "0x18A6A54D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6D4A40", Offset = "0xA6D3A40", VA = "0x18A6D4A40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0xA6D4610", Offset = "0xA6D3610", VA = "0x18A6D4610", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xA6D4A00", Offset = "0xA6D3A00", VA = "0x18A6D4A00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0xA6D4950", Offset = "0xA6D3950", VA = "0x18A6D4950", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0xA6D4950", Offset = "0xA6D3950", VA = "0x18A6D4950", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9620", Offset = "0xA6D8620", VA = "0x18A6D9620", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D61F0", Offset = "0xA6D51F0", VA = "0x18A6D61F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9A10", Offset = "0xA6D8A10", VA = "0x18A6D9A10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8DA0", Offset = "0xA6D7DA0", VA = "0x18A6D8DA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D84E0", Offset = "0xA6D74E0", VA = "0x18A6D84E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0xA6D84E0", Offset = "0xA6D74E0", VA = "0x18A6D84E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D2830", Offset = "0xA6D1830", VA = "0x18A6D2830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0xA6D2880", Offset = "0xA6D1880", VA = "0x18A6D2880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2280", Offset = "0xA6D1280", VA = "0x18A6D2280", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D23A0", Offset = "0xA6D13A0", VA = "0x18A6D23A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2510", Offset = "0xA6D1510", VA = "0x18A6D2510", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2420", Offset = "0xA6D1420", VA = "0x18A6D2420", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2100", Offset = "0xA6D1100", VA = "0x18A6D2100", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2930", Offset = "0xA6D1930", VA = "0x18A6D2930")]
		internal MaterialTransmission(Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xA6D22B0", Offset = "0xA6D12B0", VA = "0x18A6D22B0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA6D21F0", Offset = "0xA6D11F0", VA = "0x18A6D21F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0xA6D90E0", Offset = "0xA6D80E0", VA = "0x18A6D90E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D5C80", Offset = "0xA6D4C80", VA = "0x18A6D5C80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9920", Offset = "0xA6D8920", VA = "0x18A6D9920")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8D20", Offset = "0xA6D7D20", VA = "0x18A6D8D20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8A80", Offset = "0xA6D7A80", VA = "0x18A6D8A80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8A80", Offset = "0xA6D7A80", VA = "0x18A6D8A80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public new const string SCHEMANAME = "KHR_materials_unlit";

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA6D29A0", Offset = "0xA6D19A0", VA = "0x18A6D29A0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA6D29D0", Offset = "0xA6D19D0", VA = "0x18A6D29D0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2A60", Offset = "0xA6D1A60", VA = "0x18A6D2A60", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2A50", Offset = "0xA6D1A50", VA = "0x18A6D2A50", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA6D2990", Offset = "0xA6D1990", VA = "0x18A6D2990", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD210", Offset = "0xA6BC210", VA = "0x18A6BD210")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0xA6D96E0", Offset = "0xA6D86E0", VA = "0x18A6D96E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0xA6D7260", Offset = "0xA6D6260", VA = "0x18A6D7260", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9C40", Offset = "0xA6D8C40", VA = "0x18A6D9C40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8DE0", Offset = "0xA6D7DE0", VA = "0x18A6D8DE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D83A0", Offset = "0xA6D73A0", VA = "0x18A6D83A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D83A0", Offset = "0xA6D73A0", VA = "0x18A6D83A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public ModelRoot LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4860", Offset = "0xCF3860", VA = "0x180CF4860", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4870", Offset = "0xCF3870", VA = "0x180CF4870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0E20", Offset = "0xA6CFE20", VA = "0x18A6D0E20", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA6C44A0", Offset = "0xA6C34A0", VA = "0x18A6C44A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1020", Offset = "0xA6D0020", VA = "0x18A6D1020", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0F00", Offset = "0xA6CFF00", VA = "0x18A6D0F00", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0D80", Offset = "0xA6CFD80", VA = "0x18A6D0D80", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0FF0", Offset = "0xA6CFFF0", VA = "0x18A6D0FF0", Slot = "18")]
		void IChildOfList<ModelRoot>.SetLogicalParent(ModelRoot parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0F60", Offset = "0xA6CFF60", VA = "0x18A6D0F60")]
		protected bool SharesLogicalParent(params LogicalChildOfRoot[] items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3C130D0", Offset = "0x3C120D0", VA = "0x183C130D0")]
		public static void RenameLogicalElements<T>(IEnumerable<T> collection, string namePrefix) where T : LogicalChildOfRoot
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0E50", Offset = "0xA6CFE50", VA = "0x18A6D0E50")]
		private bool RenameIfAvailable(string newName, HashSet<string> usedNames)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9330", Offset = "0xA6C8330", VA = "0x18A6C9330")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8F60", Offset = "0xA6D7F60", VA = "0x18A6D8F60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xA6D79C0", Offset = "0xA6D69C0", VA = "0x18A6D79C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9C90", Offset = "0xA6D8C90", VA = "0x18A6D9C90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8C20", Offset = "0xA6D7C20", VA = "0x18A6D8C20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xA6D88A0", Offset = "0xA6D78A0", VA = "0x18A6D88A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xA6D88A0", Offset = "0xA6D78A0", VA = "0x18A6D88A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6BDF60", Offset = "0xA6BCF60", VA = "0x18A6BDF60", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xA6BE110", Offset = "0xA6BD110", VA = "0x18A6BE110", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xA6BE2C0", Offset = "0xA6BD2C0", VA = "0x18A6BE2C0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA6BE190", Offset = "0xA6BD190", VA = "0x18A6BE190", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA6BDE20", Offset = "0xA6BCE20", VA = "0x18A6BDE20", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA6BE910", Offset = "0xA6BD910", VA = "0x18A6BE910")]
		internal AccessorSparseIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xA6BE970", Offset = "0xA6BD970", VA = "0x18A6BE970")]
		internal AccessorSparseIndices(BufferView bv, int byteOffset, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA6BE800", Offset = "0xA6BD800", VA = "0x18A6BE800")]
		internal IntegerArray _GetIndicesArray(ModelRoot root, int sparseCount)
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xA6BDF90", Offset = "0xA6BCF90", VA = "0x18A6BDF90", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA6BE680", Offset = "0xA6BD680", VA = "0x18A6BE680")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xA6D91A0", Offset = "0xA6D81A0", VA = "0x18A6D91A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xA6D6730", Offset = "0xA6D5730", VA = "0x18A6D6730", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9B00", Offset = "0xA6D8B00", VA = "0x18A6D9B00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8CA0", Offset = "0xA6D7CA0", VA = "0x18A6D8CA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8260", Offset = "0xA6D7260", VA = "0x18A6D8260", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8260", Offset = "0xA6D7260", VA = "0x18A6D8260", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6BEBB0", Offset = "0xA6BDBB0", VA = "0x18A6BEBB0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA6BED60", Offset = "0xA6BDD60", VA = "0x18A6BED60", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xA6BEEC0", Offset = "0xA6BDEC0", VA = "0x18A6BEEC0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xA6BEDE0", Offset = "0xA6BDDE0", VA = "0x18A6BEDE0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xA6BEAC0", Offset = "0xA6BDAC0", VA = "0x18A6BEAC0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xA6BF580", Offset = "0xA6BE580", VA = "0x18A6BF580")]
		internal AccessorSparseValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xA6BF430", Offset = "0xA6BE430", VA = "0x18A6BF430")]
		internal AccessorSparseValues(BufferView bv, int byteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xA6BF1D0", Offset = "0xA6BE1D0", VA = "0x18A6BF1D0")]
		internal MemoryAccessor _GetMemoryAccessor(ModelRoot root, int sparseCount, Accessor baseAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA6BEBE0", Offset = "0xA6BDBE0", VA = "0x18A6BEBE0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xA6BF170", Offset = "0xA6BE170", VA = "0x18A6BF170")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9260", Offset = "0xA6D8260", VA = "0x18A6D9260", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0xA6D7F60", Offset = "0xA6D6F60", VA = "0x18A6D7F60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9D30", Offset = "0xA6D8D30", VA = "0x18A6D9D30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8CE0", Offset = "0xA6D7CE0", VA = "0x18A6D8CE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xA6D86C0", Offset = "0xA6D76C0", VA = "0x18A6D86C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0xA6D86C0", Offset = "0xA6D76C0", VA = "0x18A6D86C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xA6BF730", Offset = "0xA6BE730", VA = "0x18A6BF730", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xA6BFB70", Offset = "0xA6BEB70", VA = "0x18A6BFB70", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xA6BFCF0", Offset = "0xA6BECF0", VA = "0x18A6BFCF0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xA6BFBF0", Offset = "0xA6BEBF0", VA = "0x18A6BFBF0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA6BF5E0", Offset = "0xA6BE5E0", VA = "0x18A6BF5E0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD210", Offset = "0xA6BC210", VA = "0x18A6BD210")]
		internal AccessorSparse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0290", Offset = "0xA6BF290", VA = "0x18A6C0290")]
		internal AccessorSparse(int sparseCount, BufferView indices, int indicesOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xA6C00A0", Offset = "0xA6BF0A0", VA = "0x18A6C00A0")]
		internal KeyValuePair<IntegerArray, MemoryAccessor> _CreateMemoryAccessors(Accessor baseAccessor)
		{
			return default(KeyValuePair<IntegerArray, MemoryAccessor>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA6BF990", Offset = "0xA6BE990", VA = "0x18A6BF990", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xA6BF760", Offset = "0xA6BE760", VA = "0x18A6BF760", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9860", Offset = "0xA6D8860", VA = "0x18A6D9860", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xA6D74B0", Offset = "0xA6D64B0", VA = "0x18A6D74B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9AB0", Offset = "0xA6D8AB0", VA = "0x18A6D9AB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8D60", Offset = "0xA6D7D60", VA = "0x18A6D8D60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8580", Offset = "0xA6D7580", VA = "0x18A6D8580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8580", Offset = "0xA6D7580", VA = "0x18A6D8580", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x167EE10", Offset = "0x167DE10", VA = "0x18167EE10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public DimensionType Dimensions
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xA6C6160", Offset = "0xA6C5160", VA = "0x18A6C6160")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0xD6D840", Offset = "0xD6C840", VA = "0x180D6D840")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0xA6C7F10", Offset = "0xA6C6F10", VA = "0x18A6C7F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xA6C7FF0", Offset = "0xA6C6FF0", VA = "0x18A6C7FF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0xA6C7D90", Offset = "0xA6C6D90", VA = "0x18A6C7D90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public BufferView SourceBufferView
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xA6C7F50", Offset = "0xA6C6F50", VA = "0x18A6C7F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public int ByteOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xA6C7E40", Offset = "0xA6C6E40", VA = "0x18A6C7E40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool IsSparse
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x882E040", Offset = "0x882D040", VA = "0x18882E040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public AttributeFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xA6C7E80", Offset = "0xA6C6E80", VA = "0x18A6C7E80")]
			get
			{
				return default(AttributeFormat);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public (IReadOnlyList<double> Min, IReadOnlyList<double> Max) Bounds
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xA6C7CF0", Offset = "0xA6C6CF0", VA = "0x18A6C7CF0")]
			get
			{
				return default((IReadOnlyList<double>, IReadOnlyList<double>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xA6C15F0", Offset = "0xA6C05F0", VA = "0x18A6C15F0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1B70", Offset = "0xA6C0B70", VA = "0x18A6C1B70", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6C3940", Offset = "0xA6C2940", VA = "0x18A6C3940", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1C20", Offset = "0xA6C0C20", VA = "0x18A6C1C20", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1200", Offset = "0xA6C0200", VA = "0x18A6C1200", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0A70", Offset = "0xA6BFA70", VA = "0x18A6C0A70")]
		public IAccessorArray<Matrix3x2> AsMatrix2x2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0B50", Offset = "0xA6BFB50", VA = "0x18A6C0B50")]
		public IAccessorArray<Matrix4x4> AsMatrix3x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0C30", Offset = "0xA6BFC30", VA = "0x18A6C0C30")]
		public IAccessorArray<Matrix4x4> AsMatrix4x3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0D10", Offset = "0xA6BFD10", VA = "0x18A6C0D10")]
		public IAccessorArray<Matrix4x4> AsMatrix4x4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0DB0", Offset = "0xA6BFDB0", VA = "0x18A6C0DB0")]
		[Obsolete("Use AsMatrix4x4Array instead", true)]
		internal IReadOnlyList<Matrix4x4> AsMatrix4x4ReadOnlyList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0F90", Offset = "0xA6BFF90", VA = "0x18A6C0F90")]
		public IAccessorArray<Quaternion> AsQuaternionArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0E50", Offset = "0xA6BFE50", VA = "0x18A6C0E50")]
		public IAccessorArray<float[]> AsMultiArray(int dimensions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xA6C0820", Offset = "0xA6BF820", VA = "0x18A6C0820")]
		public IAccessorArray<uint> AsIndicesArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xA6C07E0", Offset = "0xA6BF7E0", VA = "0x18A6C07E0")]
		public IAccessorArray<uint> AsIndexArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1100", Offset = "0xA6C0100", VA = "0x18A6C1100")]
		public IAccessorArray<float> AsScalarArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1140", Offset = "0xA6C0140", VA = "0x18A6C1140")]
		public IAccessorArray<Vector2> AsVector2Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1180", Offset = "0xA6C0180", VA = "0x18A6C1180")]
		public IAccessorArray<Vector3> AsVector3Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA6C11C0", Offset = "0xA6C01C0", VA = "0x18A6C11C0")]
		public IAccessorArray<Vector4> AsVector4Array()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x336FA40", Offset = "0x336EA40", VA = "0x18336FA40")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6C05F0", Offset = "0xA6BF5F0", VA = "0x18A6C05F0")]
		public IAccessorArray<Vector4> AsColorArray(float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xA6C3750", Offset = "0xA6C2750", VA = "0x18A6C3750")]
		public ArraySegment<byte> TryGetVertexBytes(int vertexIdx)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6150", Offset = "0xA6C5150", VA = "0x18A6C6150")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6C7BC0", Offset = "0xA6C6BC0", VA = "0x18A6C7BC0")]
		internal Accessor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6160", Offset = "0xA6C5160", VA = "0x18A6C6160")]
		private DimensionType _GetDimensions()
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6680", Offset = "0xA6C5680", VA = "0x18A6C6680")]
		internal bool _TryGetMemoryAccessor([Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6C63D0", Offset = "0xA6C53D0", VA = "0x18A6C63D0")]
		internal bool _TryGetMemoryAccessor(string name, [Out] MemoryAccessor mem)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6C3680", Offset = "0xA6C2680", VA = "0x18A6C3680")]
		public bool TryGetBufferView([Out] BufferView bv)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xA6C4520", Offset = "0xA6C3520", VA = "0x18A6C4520")]
		public void UpdateBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6250", Offset = "0xA6C5250", VA = "0x18A6C6250")]
		private void _ResetBounds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x3370FE0", Offset = "0x336FFE0", VA = "0x183370FE0")]
		private void _AppendToBounds<T>(T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA6C5F80", Offset = "0xA6C4F80", VA = "0x18A6C5F80")]
		private void _AppendToBounds(params float[] values)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1F30", Offset = "0xA6C0F30", VA = "0x18A6C1F30")]
		public void SetDataFrom(Accessor other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6C34B0", Offset = "0xA6C24B0", VA = "0x18A6C34B0")]
		public void SetZeros(MemoryAccessInfo accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6C34E0", Offset = "0xA6C24E0", VA = "0x18A6C34E0")]
		public void SetZeros(int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6C2200", Offset = "0xA6C1200", VA = "0x18A6C2200")]
		[Obsolete("Use SetData with AttributeFormat. This will be removed soon.")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6C2300", Offset = "0xA6C1300", VA = "0x18A6C2300")]
		public void SetData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1BF0", Offset = "0xA6C0BF0", VA = "0x18A6C1BF0")]
		public void RemoveSparseData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3370170", Offset = "0x336F170", VA = "0x183370170")]
		public void CreateSparseData<T>(IReadOnlyDictionary<int, T> data) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA6C2E00", Offset = "0xA6C1E00", VA = "0x18A6C2E00")]
		public void SetSparseData(MemoryAccessor sparseIndices, MemoryAccessor sparseValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xA6C2A30", Offset = "0xA6C1A30", VA = "0x18A6C2A30")]
		public void SetSparseData(int sparseCount, BufferView indices, int indicesByteOffset, IndexEncodingType indicesEncoding, BufferView values, int valuesByteOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6C25A0", Offset = "0xA6C15A0", VA = "0x18A6C25A0")]
		public void SetIndexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xA6C28B0", Offset = "0xA6C18B0", VA = "0x18A6C28B0")]
		public void SetIndexData(BufferView buffer, int bufferByteOffset, int itemCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6C3130", Offset = "0xA6C2130", VA = "0x18A6C3130")]
		public void SetVertexData(MemoryAccessor src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xA6C3030", Offset = "0xA6C2030", VA = "0x18A6C3030")]
		[Obsolete("Use SetVertexData with AttributeFormat. This will be removed soon.")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, DimensionType dimensions = DimensionType.VEC3, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6C3340", Offset = "0xA6C2340", VA = "0x18A6C3340")]
		public void SetVertexData(BufferView buffer, int bufferByteOffset, int itemCount, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1A30", Offset = "0xA6C0A30", VA = "0x18A6C1A30", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6C1620", Offset = "0xA6C0620", VA = "0x18A6C1620", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6C4BE0", Offset = "0xA6C3BE0", VA = "0x18A6C4BE0")]
		internal void ValidateIndices(ValidationContext validate, uint vertexCount, PrimitiveType drawingType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6C5510", Offset = "0xA6C4510", VA = "0x18A6C5510")]
		internal static void ValidateVertexAttributes(ValidationContext validate, IReadOnlyDictionary<string, Accessor> attributes, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6FC0", Offset = "0xA6C5FC0", VA = "0x18A6C6FC0")]
		private void _ValidatePositions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6C60", Offset = "0xA6C5C60", VA = "0x18A6C6C60")]
		private void _ValidateNormals(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6C72E0", Offset = "0xA6C62E0", VA = "0x18A6C72E0")]
		private void _ValidateTangents(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6C6940", Offset = "0xA6C5940", VA = "0x18A6C6940")]
		private void _ValidateJoints(ValidationContext validate, string attributeName, int skinsMaxJointCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6C7750", Offset = "0xA6C6750", VA = "0x18A6C7750")]
		private static void _ValidateWeights(ValidationContext validate, Accessor weights0, Accessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xA6C7900", Offset = "0xA6C6900", VA = "0x18A6C7900")]
		private void _ValidateWeights(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xA6C4F90", Offset = "0xA6C3F90", VA = "0x18A6C4F90")]
		internal void ValidateMatrices4x3(ValidationContext validate, bool mustInvert = true, bool mustDecompose = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xA6C4970", Offset = "0xA6C3970", VA = "0x18A6C4970")]
		internal void ValidateAnimationInput(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0xA6C4A90", Offset = "0xA6C3A90", VA = "0x18A6C4A90")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xA6D97A0", Offset = "0xA6D87A0", VA = "0x18A6D97A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xA6D6490", Offset = "0xA6D5490", VA = "0x18A6D6490", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9CE0", Offset = "0xA6D8CE0", VA = "0x18A6D9CE0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8C60", Offset = "0xA6D7C60", VA = "0x18A6D8C60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA6D89E0", Offset = "0xA6D79E0", VA = "0x18A6D89E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA6D89E0", Offset = "0xA6D79E0", VA = "0x18A6D89E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFBA70", Offset = "0xCFAA70", VA = "0x180CFBA70")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8340", Offset = "0xA6C7340", VA = "0x18A6C8340", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8450", Offset = "0xA6C7450", VA = "0x18A6C8450", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xA6C85A0", Offset = "0xA6C75A0", VA = "0x18A6C85A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xA6C84D0", Offset = "0xA6C74D0", VA = "0x18A6C84D0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8030", Offset = "0xA6C7030", VA = "0x18A6C8030", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD210", Offset = "0xA6BC210", VA = "0x18A6BD210")]
		internal AnimationChannelTarget()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8850", Offset = "0xA6C7850", VA = "0x18A6C8850")]
		internal AnimationChannelTarget(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA6C88E0", Offset = "0xA6C78E0", VA = "0x18A6C88E0")]
		internal AnimationChannelTarget(string pointer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500", Slot = "17")]
		void IChildOf<AnimationChannel>.SetLogicalParent(AnimationChannel parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8120", Offset = "0xA6C7120", VA = "0x18A6C8120")]
		public int GetNodeIndex()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA6C81D0", Offset = "0xA6C71D0", VA = "0x18A6C81D0")]
		public PropertyPath GetNodePath()
		{
			return default(PropertyPath);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8240", Offset = "0xA6C7240", VA = "0x18A6C8240")]
		public string GetPointerPath()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8370", Offset = "0xA6C7370", VA = "0x18A6C8370", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9020", Offset = "0xA6D8020", VA = "0x18A6D9020", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D7CC0", Offset = "0xA6D6CC0", VA = "0x18A6D7CC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D99C0", Offset = "0xA6D89C0", VA = "0x18A6D99C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8BE0", Offset = "0xA6D7BE0", VA = "0x18A6D8BE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8800", Offset = "0xA6D7800", VA = "0x18A6D8800", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8800", Offset = "0xA6D7800", VA = "0x18A6D8800", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4860", Offset = "0xCF3860", VA = "0x180CF4860", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0xCF4870", Offset = "0xCF3870", VA = "0x180CF4870")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xCFC360", Offset = "0xCFB360", VA = "0x180CFC360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public string TargetPointerPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0xA6C9770", Offset = "0xA6C8770", VA = "0x18A6C9770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public Node TargetNode
		{
			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0xA6C95F0", Offset = "0xA6C85F0", VA = "0x18A6C95F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public PropertyPath TargetNodePath
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xA6C9570", Offset = "0xA6C8570", VA = "0x18A6C9570")]
			get
			{
				return default(PropertyPath);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8B70", Offset = "0xA6C7B70", VA = "0x18A6C8B70", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8CE0", Offset = "0xA6C7CE0", VA = "0x18A6C8CE0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8F30", Offset = "0xA6C7F30", VA = "0x18A6C8F30", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8D60", Offset = "0xA6C7D60", VA = "0x18A6C8D60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA6C89F0", Offset = "0xA6C79F0", VA = "0x18A6C89F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9330", Offset = "0xA6C8330", VA = "0x18A6C9330")]
		internal AnimationChannel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9420", Offset = "0xA6C8420", VA = "0x18A6C9420")]
		internal AnimationChannel(string pointerPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9340", Offset = "0xA6C8340", VA = "0x18A6C9340")]
		internal AnimationChannel(Node targetNode, PropertyPath targetPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8E20", Offset = "0xA6C7E20", VA = "0x18A6C8E20")]
		internal void SetSampler(AnimationSampler sampler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8F00", Offset = "0xA6C7F00", VA = "0x18A6C8F00", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xA6C92A0", Offset = "0xA6C82A0", VA = "0x18A6C92A0")]
		private void _SetChannelTarget(AnimationChannelTarget target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x3391CD0", Offset = "0x3390CD0", VA = "0x183391CD0")]
		public IAnimationSampler<T> GetSamplerOrNull<T>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xA6C91E0", Offset = "0xA6C81E0", VA = "0x18A6C91E0")]
		internal AnimationSampler _GetSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8B40", Offset = "0xA6C7B40", VA = "0x18A6C8B40")]
		public IAnimationSampler<Vector3> GetScaleSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8B10", Offset = "0xA6C7B10", VA = "0x18A6C8B10")]
		public IAnimationSampler<Quaternion> GetRotationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8BA0", Offset = "0xA6C7BA0", VA = "0x18A6C8BA0")]
		public IAnimationSampler<Vector3> GetTranslationSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8AE0", Offset = "0xA6C7AE0", VA = "0x18A6C8AE0")]
		public IAnimationSampler<SparseWeight8> GetSparseMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8AE0", Offset = "0xA6C7AE0", VA = "0x18A6C8AE0")]
		public IAnimationSampler<float[]> GetMorphSampler()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xA6C8BD0", Offset = "0xA6C7BD0", VA = "0x18A6C8BD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1350", Offset = "0xA6F0350", VA = "0x18A6F1350", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0xA6EE950", Offset = "0xA6ED950", VA = "0x18A6EE950", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1B20", Offset = "0xA6F0B20", VA = "0x18A6F1B20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0E90", Offset = "0xA6EFE90", VA = "0x18A6F0E90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0D30", Offset = "0xA6EFD30", VA = "0x18A6F0D30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0D30", Offset = "0xA6EFD30", VA = "0x18A6F0D30", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x12BFC10", Offset = "0x12BEC10", VA = "0x1812BFC10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x654DA10", Offset = "0x654CA10", VA = "0x18654DA10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x13C33D0", Offset = "0x13C23D0", VA = "0x1813C33D0")]
			[DebuggerHidden]
			public <_GroupByTangentValueTangent>d__84(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x72EB740", Offset = "0x72EA740", VA = "0x1872EB740", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x72EAF50", Offset = "0x72E9F50", VA = "0x1872EAF50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x72EB870", Offset = "0x72EA870", VA = "0x1872EB870")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x6AB9A70", Offset = "0x6AB8A70", VA = "0x186AB9A70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(T, T, T)> IEnumerable<(T, T, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x72EB3C0", Offset = "0x72EA3C0", VA = "0x1872EB3C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public int LogicalIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xD24DA0", Offset = "0xD23DA0", VA = "0x180D24DA0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0xDEFC00", Offset = "0xDEEC00", VA = "0x180DEFC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public AnimationInterpolationMode InterpolationMode
		{
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D0C90", Offset = "0xA6CFC90", VA = "0x18A6D0C90", Slot = "51")]
			get
			{
				return default(AnimationInterpolationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0xA6D0D30", Offset = "0xA6CFD30", VA = "0x18A6D0D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public Accessor Input
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xA6D0C30", Offset = "0xA6CFC30", VA = "0x18A6D0C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public Accessor Output
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xA6D0CD0", Offset = "0xA6CFCD0", VA = "0x18A6D0CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0xA6D0B20", Offset = "0xA6CFB20", VA = "0x18A6D0B20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xA6C99D0", Offset = "0xA6C89D0", VA = "0x18A6C99D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA0F0", Offset = "0xA6C90F0", VA = "0x18A6CA0F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0xA6CF300", Offset = "0xA6CE300", VA = "0x18A6CF300", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA170", Offset = "0xA6C9170", VA = "0x18A6CA170", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9880", Offset = "0xA6C8880", VA = "0x18A6C9880", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0A20", Offset = "0xA6CFA20", VA = "0x18A6D0A20")]
		internal AnimationSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0A90", Offset = "0xA6CFA90", VA = "0x18A6D0A90")]
		internal AnimationSampler(AnimationInterpolationMode interpolation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xA6CB3D0", Offset = "0xA6CA3D0", VA = "0x18A6CB3D0", Slot = "18")]
		void IChildOfList<Animation>.SetLogicalParent(Animation parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xA6CF680", Offset = "0xA6CE680", VA = "0x18A6CF680")]
		private Accessor _CreateInputAccessor(IReadOnlyList<float> input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xA6CF8D0", Offset = "0xA6CE8D0", VA = "0x18A6CF8D0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<bool> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xA6CFB00", Offset = "0xA6CEB00", VA = "0x18A6CFB00")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xA6CFFA0", Offset = "0xA6CEFA0", VA = "0x18A6CFFA0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector2> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xA6D01F0", Offset = "0xA6CF1F0", VA = "0x18A6D01F0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector3> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xA6CFD50", Offset = "0xA6CED50", VA = "0x18A6CFD50")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Vector4> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D06E0", Offset = "0xA6CF6E0", VA = "0x18A6D06E0")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<Quaternion> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0910", Offset = "0xA6CF910", VA = "0x18A6D0910")]
		private Accessor _CreateOutputAccessor(IReadOnlyList<SparseWeight8> output, int itemsStride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x3392AE0", Offset = "0x3391AE0", VA = "0x183392AE0")]
		private Accessor _CreateOutputAccessor<T>(IReadOnlyList<T> output, int itemsStride) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0440", Offset = "0xA6CF440", VA = "0x18A6D0440")]
		private Accessor _CreateOutputAccessor(int itemCount, int itemsStride, Func<int, int, float> output)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x33934D0", Offset = "0x33924D0", VA = "0x1833934D0")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, TValue> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x33930D0", Offset = "0x33920D0", VA = "0x1833930D0")]
		private static (float[], TValue[]) _Split<TValue>(IReadOnlyDictionary<float, (TValue TangentIn, TValue Value, TValue TangentOut)> keyframes)
		{
			return default((float[], TValue[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0xA6CAEC0", Offset = "0xA6C9EC0", VA = "0x18A6CAEC0")]
		internal void SetKeys(IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA6CADC0", Offset = "0xA6C9DC0", VA = "0x18A6CADC0")]
		internal void SetKeys(IReadOnlyDictionary<float, float> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xA6CB1D0", Offset = "0xA6CA1D0", VA = "0x18A6CB1D0")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector2> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA6CB2D0", Offset = "0xA6CA2D0", VA = "0x18A6CB2D0")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector3> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xA6CACC0", Offset = "0xA6C9CC0", VA = "0x18A6CACC0")]
		internal void SetKeys(IReadOnlyDictionary<float, Vector4> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xA6CB0D0", Offset = "0xA6CA0D0", VA = "0x18A6CB0D0")]
		internal void SetKeys(IReadOnlyDictionary<float, Quaternion> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x3392290", Offset = "0x3391290", VA = "0x183392290")]
		internal void SetKeys<TWeights>(IReadOnlyDictionary<float, TWeights> keyframes, int itemsStride) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA6CAFC0", Offset = "0xA6C9FC0", VA = "0x18A6CAFC0")]
		internal void SetKeys(IReadOnlyDictionary<float, SparseWeight8> keyframes, int itemsStride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA920", Offset = "0xA6C9920", VA = "0x18A6CA920")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (float TangentIn, float Value, float TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xA6CAAD0", Offset = "0xA6C9AD0", VA = "0x18A6CAAD0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector2 TangentIn, Vector2 Value, Vector2 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA480", Offset = "0xA6C9480", VA = "0x18A6CA480")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA2A0", Offset = "0xA6C92A0", VA = "0x18A6CA2A0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Vector4 TangentIn, Vector4 Value, Vector4 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA7F0", Offset = "0xA6C97F0", VA = "0x18A6CA7F0")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x3391EC0", Offset = "0x3390EC0", VA = "0x183391EC0")]
		internal void SetCubicKeys<TWeights>(IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int expandedCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA660", Offset = "0xA6C9660", VA = "0x18A6CA660")]
		internal void SetCubicKeys(IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int expandedCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC590", Offset = "0xA6CB590", VA = "0x18A6CC590", Slot = "20")]
		IEnumerable<(float, bool)> IAnimationSampler<bool>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xA6CE7F0", Offset = "0xA6CD7F0", VA = "0x18A6CE7F0", Slot = "24")]
		IEnumerable<(float, float)> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD350", Offset = "0xA6CC350", VA = "0x18A6CD350", Slot = "28")]
		IEnumerable<(float, Vector2)> IAnimationSampler<Vector2>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xA6CDA30", Offset = "0xA6CCA30", VA = "0x18A6CDA30", Slot = "32")]
		IEnumerable<(float, Vector3)> IAnimationSampler<Vector3>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA6CE110", Offset = "0xA6CD110", VA = "0x18A6CE110", Slot = "36")]
		IEnumerable<(float, Vector4)> IAnimationSampler<Vector4>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xA6CCC90", Offset = "0xA6CBC90", VA = "0x18A6CCC90", Slot = "40")]
		IEnumerable<(float, Quaternion)> IAnimationSampler<Quaternion>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA6CB8C0", Offset = "0xA6CA8C0", VA = "0x18A6CB8C0", Slot = "44")]
		IEnumerable<(float, SparseWeight8)> IAnimationSampler<SparseWeight8>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC100", Offset = "0xA6CB100", VA = "0x18A6CC100", Slot = "48")]
		IEnumerable<(float, ArraySegment<float>)> IAnimationSampler<ArraySegment<float>>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0xA6CEF80", Offset = "0xA6CDF80", VA = "0x18A6CEF80", Slot = "52")]
		IEnumerable<(float, float[])> IAnimationSampler<float>.GetLinearKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC550", Offset = "0xA6CB550", VA = "0x18A6CC550", Slot = "21")]
		IEnumerable<(float, (bool, bool, bool))> IAnimationSampler<bool>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xA6CE500", Offset = "0xA6CD500", VA = "0x18A6CE500", Slot = "25")]
		IEnumerable<(float, (float, float, float))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD060", Offset = "0xA6CC060", VA = "0x18A6CD060", Slot = "29")]
		IEnumerable<(float, (Vector2, Vector2, Vector2))> IAnimationSampler<Vector2>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD740", Offset = "0xA6CC740", VA = "0x18A6CD740", Slot = "33")]
		IEnumerable<(float, (Vector3, Vector3, Vector3))> IAnimationSampler<Vector3>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA6CDE20", Offset = "0xA6CCE20", VA = "0x18A6CDE20", Slot = "37")]
		IEnumerable<(float, (Vector4, Vector4, Vector4))> IAnimationSampler<Vector4>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC9C0", Offset = "0xA6CB9C0", VA = "0x18A6CC9C0", Slot = "41")]
		IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> IAnimationSampler<Quaternion>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA6CEBE0", Offset = "0xA6CDBE0", VA = "0x18A6CEBE0", Slot = "53")]
		IEnumerable<(float, (float[], float[], float[]))> IAnimationSampler<float>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0xA6CBD60", Offset = "0xA6CAD60", VA = "0x18A6CBD60", Slot = "49")]
		IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> IAnimationSampler<ArraySegment<float>>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0xA6CB520", Offset = "0xA6CA520", VA = "0x18A6CB520", Slot = "45")]
		IEnumerable<(float, (SparseWeight8, SparseWeight8, SparseWeight8))> IAnimationSampler<SparseWeight8>.GetCubicKeys()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC480", Offset = "0xA6CB480", VA = "0x18A6CC480", Slot = "22")]
		ICurveSampler<bool> IAnimationSampler<bool>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA6CE3E0", Offset = "0xA6CD3E0", VA = "0x18A6CE3E0", Slot = "26")]
		ICurveSampler<float> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA6CCF40", Offset = "0xA6CBF40", VA = "0x18A6CCF40", Slot = "30")]
		ICurveSampler<Vector2> IAnimationSampler<Vector2>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA6CD620", Offset = "0xA6CC620", VA = "0x18A6CD620", Slot = "34")]
		ICurveSampler<Vector3> IAnimationSampler<Vector3>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xA6CDD00", Offset = "0xA6CCD00", VA = "0x18A6CDD00", Slot = "38")]
		ICurveSampler<Vector4> IAnimationSampler<Vector4>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC8A0", Offset = "0xA6CB8A0", VA = "0x18A6CC8A0", Slot = "42")]
		ICurveSampler<Quaternion> IAnimationSampler<Quaternion>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xA6CB400", Offset = "0xA6CA400", VA = "0x18A6CB400", Slot = "46")]
		ICurveSampler<SparseWeight8> IAnimationSampler<SparseWeight8>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0xA6CEAC0", Offset = "0xA6CDAC0", VA = "0x18A6CEAC0", Slot = "54")]
		ICurveSampler<float[]> IAnimationSampler<float>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0xA6CBC40", Offset = "0xA6CAC40", VA = "0x18A6CBC40", Slot = "50")]
		ICurveSampler<ArraySegment<float>> IAnimationSampler<ArraySegment<float>>.CreateCurveSampler(bool isolateMemory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x3392E90", Offset = "0x3391E90", VA = "0x183392E90")]
		[IteratorStateMachine(typeof(<_GroupByTangentValueTangent>d__84<>))]
		private static IEnumerable<(T, T, T)> _GroupByTangentValueTangent<T>(IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9F30", Offset = "0xA6C8F30", VA = "0x18A6C9F30", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xA6C9A00", Offset = "0xA6C8A00", VA = "0x18A6C9A00", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1710", Offset = "0xA6F0710", VA = "0x18A6F1710", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEF70", Offset = "0xA6EDF70", VA = "0x18A6EEF70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1D50", Offset = "0xA6F0D50", VA = "0x18A6F1D50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0DD0", Offset = "0xA6EFDD0", VA = "0x18A6F0DD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0xA6F08D0", Offset = "0xA6EF8D0", VA = "0x18A6F08D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xA6F08D0", Offset = "0xA6EF8D0", VA = "0x18A6F08D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public IReadOnlyList<AnimationChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public float Duration
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0xA6DD0B0", Offset = "0xA6DC0B0", VA = "0x18A6DD0B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC520", Offset = "0xA6DB520", VA = "0x18A6DC520", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC6A0", Offset = "0xA6DB6A0", VA = "0x18A6DC6A0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC830", Offset = "0xA6DB830", VA = "0x18A6DC830", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC720", Offset = "0xA6DB720", VA = "0x18A6DC720", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC070", Offset = "0xA6DB070", VA = "0x18A6DC070", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xA6DCFE0", Offset = "0xA6DBFE0", VA = "0x18A6DCFE0")]
		internal Animation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC2D0", Offset = "0xA6DB2D0", VA = "0x18A6DC2D0")]
		public IEnumerable<AnimationChannel> FindChannels(string rootPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC160", Offset = "0xA6DB160", VA = "0x18A6DC160")]
		public IEnumerable<AnimationChannel> FindChannels(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC500", Offset = "0xA6DB500", VA = "0x18A6DC500")]
		public AnimationChannel FindScaleChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC4F0", Offset = "0xA6DB4F0", VA = "0x18A6DC4F0")]
		public AnimationChannel FindRotationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC510", Offset = "0xA6DB510", VA = "0x18A6DC510")]
		public AnimationChannel FindTranslationChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC4E0", Offset = "0xA6DB4E0", VA = "0x18A6DC4E0")]
		public AnimationChannel FindMorphChannel(Node node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6DCB50", Offset = "0xA6DBB50", VA = "0x18A6DCB50")]
		private AnimationChannel _FindChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6DCAC0", Offset = "0xA6DBAC0", VA = "0x18A6DCAC0")]
		private AnimationSampler _CreateSampler(AnimationInterpolationMode interpolation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6DCE00", Offset = "0xA6DBE00", VA = "0x18A6DCE00")]
		private AnimationChannel _UseChannel(Node node, PropertyPath path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6DCD70", Offset = "0xA6DBD70", VA = "0x18A6DCD70")]
		private AnimationChannel _UseChannel(string pointerPath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x3397B60", Offset = "0x3396B60", VA = "0x183397B60")]
		public void CreateMaterialPropertyChannel<T>(Material material, string propertyName, IReadOnlyDictionary<float, T> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x3398830", Offset = "0x3397830", VA = "0x183398830")]
		public void DangerousCreatePointerChannel<T>(string pointerPath, IReadOnlyDictionary<float, T> keyframes, bool linear = true, bool verifyBackingFieldExists = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB9E0", Offset = "0xA6DA9E0", VA = "0x18A6DB9E0")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB870", Offset = "0xA6DA870", VA = "0x18A6DB870")]
		public void CreateScaleChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB580", Offset = "0xA6DA580", VA = "0x18A6DB580")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, Quaternion> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB700", Offset = "0xA6DA700", VA = "0x18A6DB700")]
		public void CreateRotationChannel(Node node, IReadOnlyDictionary<float, (Quaternion TangentIn, Quaternion Value, Quaternion TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA6DBB60", Offset = "0xA6DAB60", VA = "0x18A6DBB60")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, Vector3> keyframes, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xA6DBCE0", Offset = "0xA6DACE0", VA = "0x18A6DBCE0")]
		public void CreateTranslationChannel(Node node, IReadOnlyDictionary<float, (Vector3 TangentIn, Vector3 Value, Vector3 TangentOut)> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x3397F80", Offset = "0x3396F80", VA = "0x183397F80")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, TWeights> keyframes, int morphCount, bool linear = true) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x3397D00", Offset = "0x3396D00", VA = "0x183397D00")]
		public void CreateMorphChannel<TWeights>(Node node, IReadOnlyDictionary<float, (TWeights TangentIn, TWeights Value, TWeights TangentOut)> keyframes, int morphCount) where TWeights : IReadOnlyList<float>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB400", Offset = "0xA6DA400", VA = "0x18A6DB400")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, SparseWeight8> keyframes, int morphCount, bool linear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0xA6DB280", Offset = "0xA6DA280", VA = "0x18A6DB280")]
		public void CreateMorphChannel(Node node, IReadOnlyDictionary<float, (SparseWeight8 TangentIn, SparseWeight8 Value, SparseWeight8 TangentOut)> keyframes, int morphCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xA6DBE50", Offset = "0xA6DAE50", VA = "0x18A6DBE50")]
		public void CreateVisibilityChannel(Node node, IReadOnlyDictionary<float, bool> keyframes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC580", Offset = "0xA6DB580", VA = "0x18A6DC580", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6DC550", Offset = "0xA6DB550", VA = "0x18A6DC550", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1650", Offset = "0xA6F0650", VA = "0x18A6F1650", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0xA6EF4B0", Offset = "0xA6EE4B0", VA = "0x18A6EF4B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1DF0", Offset = "0xA6F0DF0", VA = "0x18A6F1DF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0E50", Offset = "0xA6EFE50", VA = "0x18A6F0E50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0AB0", Offset = "0xA6EFAB0", VA = "0x18A6F0AB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0AB0", Offset = "0xA6EFAB0", VA = "0x18A6F0AB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF3370", VA = "0x180CF4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public static string AssemblyInformationalVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xA6DDE80", Offset = "0xA6DCE80", VA = "0x18A6DDE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public string Copyright
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0xA6DE070", Offset = "0xA6DD070", VA = "0x18A6DE070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		public string Generator
		{
			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0xA6DE0A0", Offset = "0xA6DD0A0", VA = "0x18A6DE0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		public Version Version
		{
			[Cpp2IlInjected.Token(Token = "0x600071C")]
			[Cpp2IlInjected.Address(RVA = "0xA6DDFF0", Offset = "0xA6DCFF0", VA = "0x18A6DDFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public Version MinVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0xA6DDF70", Offset = "0xA6DCF70", VA = "0x18A6DDF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD510", Offset = "0xA6DC510", VA = "0x18A6DD510", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD740", Offset = "0xA6DC740", VA = "0x18A6DD740", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD880", Offset = "0xA6DC880", VA = "0x18A6DD880", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD7C0", Offset = "0xA6DC7C0", VA = "0x18A6DD7C0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD3F0", Offset = "0xA6DC3F0", VA = "0x18A6DD3F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD210", Offset = "0xA6BC210", VA = "0x18A6BD210")]
		internal Asset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD1D0", Offset = "0xA6DC1D0", VA = "0x18A6DD1D0")]
		internal static Asset CreateDefault(string copyright)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF3370", VA = "0x180CF4370", Slot = "17")]
		void IChildOf<ModelRoot>.SetLogicalParent(ModelRoot parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA6DD540", Offset = "0xA6DC540", VA = "0x18A6DD540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1590", Offset = "0xA6F0590", VA = "0x18A6F1590", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xA6EFF90", Offset = "0xA6EEF90", VA = "0x18A6EFF90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1D00", Offset = "0xA6F0D00", VA = "0x18A6F1D00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1010", Offset = "0xA6F0010", VA = "0x18A6F1010", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0830", Offset = "0xA6EF830", VA = "0x18A6F0830", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0830", Offset = "0xA6EF830", VA = "0x18A6F0830", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0710", Offset = "0xA6DF710", VA = "0x18A6E0710", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0B40", Offset = "0xA6DFB40", VA = "0x18A6E0B40", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0C70", Offset = "0xA6DFC70", VA = "0x18A6E0C70", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0BC0", Offset = "0xA6DFBC0", VA = "0x18A6E0BC0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0620", Offset = "0xA6DF620", VA = "0x18A6E0620", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1410", Offset = "0xA6E0410", VA = "0x18A6E1410")]
		internal Buffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1420", Offset = "0xA6E0420", VA = "0x18A6E1420")]
		internal Buffer(byte[] content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1150", Offset = "0xA6E0150", VA = "0x18A6E1150")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0FD0", Offset = "0xA6DFFD0", VA = "0x18A6E0FD0")]
		private static byte[] _LoadBinaryBufferUnchecked(string uri, ReadContext context)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1340", Offset = "0xA6E0340", VA = "0x18A6E1340")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1300", Offset = "0xA6E0300", VA = "0x18A6E1300")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0F20", Offset = "0xA6DFF20", VA = "0x18A6E0F20")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0F50", Offset = "0xA6DFF50", VA = "0x18A6E0F50")]
		internal void _IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0740", Offset = "0xA6DF740", VA = "0x18A6E0740")]
		internal void OnValidateBinaryChunk(ValidationContext validate, byte[] binaryChunk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0A90", Offset = "0xA6DFA90", VA = "0x18A6E0A90", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0960", Offset = "0xA6DF960", VA = "0x18A6E0960", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1110", Offset = "0xA6F0110", VA = "0x18A6F1110", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0xA6EDE60", Offset = "0xA6ECE60", VA = "0x18A6EDE60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1C10", Offset = "0xA6F0C10", VA = "0x18A6F1C10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0FD0", Offset = "0xA6EFFD0", VA = "0x18A6F0FD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0B50", Offset = "0xA6EFB50", VA = "0x18A6F0B50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0B50", Offset = "0xA6EFB50", VA = "0x18A6F0B50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6E05E0", Offset = "0xA6DF5E0", VA = "0x18A6E05E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public bool IsIndexBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0xA6E05A0", Offset = "0xA6DF5A0", VA = "0x18A6E05A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		public bool IsDataBuffer
		{
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0560", Offset = "0xA6DF560", VA = "0x18A6E0560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0450", Offset = "0xA6DF450", VA = "0x18A6E0450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public ArraySegment<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA6E0490", Offset = "0xA6DF490", VA = "0x18A6E0490")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		internal int LogicalBufferIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0xD24DA0", Offset = "0xD23DA0", VA = "0x180D24DA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE680", Offset = "0xA6DD680", VA = "0x18A6DE680", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA6DEEE0", Offset = "0xA6DDEE0", VA = "0x18A6DEEE0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF0E0", Offset = "0xA6DE0E0", VA = "0x18A6DF0E0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA6DEF60", Offset = "0xA6DDF60", VA = "0x18A6DEF60", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE270", Offset = "0xA6DD270", VA = "0x18A6DE270", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA6DFF00", Offset = "0xA6DEF00", VA = "0x18A6DFF00")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA6E03F0", Offset = "0xA6DF3F0", VA = "0x18A6E03F0")]
		internal BufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0040", Offset = "0xA6DF040", VA = "0x18A6E0040")]
		internal BufferView(Buffer buffer, int byteOffset, int? byteLength, int byteStride, BufferMode? target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE500", Offset = "0xA6DD500", VA = "0x18A6DE500")]
		public IEnumerable<Image> FindImages()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE430", Offset = "0xA6DD430", VA = "0x18A6DE430")]
		public IEnumerable<Accessor> FindAccessors()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA6DFF10", Offset = "0xA6DEF10", VA = "0x18A6DFF10")]
		internal void _IsolateBufferMemory(_StaticBufferBuilder targetBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE6B0", Offset = "0xA6DD6B0", VA = "0x18A6DE6B0")]
		public bool IsInterleaved(IEnumerable<Accessor> accessors)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE0D0", Offset = "0xA6DD0D0", VA = "0x18A6DE0D0")]
		internal static bool AreEqual(BufferView bv, ArraySegment<byte> content, int byteStride, BufferMode? target)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE5D0", Offset = "0xA6DD5D0", VA = "0x18A6DE5D0")]
		internal static int GetAccessorByteLength([In] AttributeFormat fmt, int count, BufferView bv)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF920", Offset = "0xA6DE920", VA = "0x18A6DF920")]
		internal static void VerifyAccess(ValidationContext validate, BufferView bv, int accessorByteOffset, AttributeFormat format, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xA6DEB20", Offset = "0xA6DDB20", VA = "0x18A6DEB20", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xA6DE950", Offset = "0xA6DD950", VA = "0x18A6DE950", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF6C0", Offset = "0xA6DE6C0", VA = "0x18A6DF6C0")]
		internal void ValidateBufferUsageGPU(ValidationContext validate, BufferMode usingMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA6DF7C0", Offset = "0xA6DE7C0", VA = "0x18A6DF7C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA6F14D0", Offset = "0xA6F04D0", VA = "0x18A6F14D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0xA6EEC50", Offset = "0xA6EDC50", VA = "0x18A6EEC50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1E40", Offset = "0xA6F0E40", VA = "0x18A6F1E40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0F10", Offset = "0xA6EFF10", VA = "0x18A6F0F10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0650", Offset = "0xA6EF650", VA = "0x18A6F0650", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0650", Offset = "0xA6EF650", VA = "0x18A6F0650", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool IsOrthographic
		{
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public float XMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0xA6E2020", Offset = "0xA6E1020", VA = "0x18A6E2020")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public float YMag
		{
			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xA6E2030", Offset = "0xA6E1030", VA = "0x18A6E2030")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0xA6E2050", Offset = "0xA6E1050", VA = "0x18A6E2050")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0xA6E2040", Offset = "0xA6E1040", VA = "0x18A6E2040")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1FB0", Offset = "0xA6E0FB0", VA = "0x18A6E1FB0", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1580", Offset = "0xA6E0580", VA = "0x18A6E1580", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1660", Offset = "0xA6E0660", VA = "0x18A6E1660", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E18A0", Offset = "0xA6E08A0", VA = "0x18A6E18A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xA6E16E0", Offset = "0xA6E06E0", VA = "0x18A6E16E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1460", Offset = "0xA6E0460", VA = "0x18A6E1460", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD210", Offset = "0xA6BC210", VA = "0x18A6BD210")]
		internal CameraOrthographic()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1F30", Offset = "0xA6E0F30", VA = "0x18A6E1F30")]
		internal CameraOrthographic(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1DC0", Offset = "0xA6E0DC0", VA = "0x18A6E1DC0")]
		public static void VerifyParameters(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E15B0", Offset = "0xA6E05B0", VA = "0x18A6E15B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1290", Offset = "0xA6F0290", VA = "0x18A6F1290", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xA6EFA20", Offset = "0xA6EEA20", VA = "0x18A6EFA20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1C60", Offset = "0xA6F0C60", VA = "0x18A6F1C60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0ED0", Offset = "0xA6EFED0", VA = "0x18A6F0ED0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0790", Offset = "0xA6EF790", VA = "0x18A6F0790", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0790", Offset = "0xA6EF790", VA = "0x18A6F0790", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public bool IsPerspective
		{
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public float? AspectRatio
		{
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xA6E2C70", Offset = "0xA6E1C70", VA = "0x18A6E2C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public float VerticalFOV
		{
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xA6E2040", Offset = "0xA6E1040", VA = "0x18A6E2040")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x9D9A770", Offset = "0x9D99770", VA = "0x189D9A770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xA6E2E30", Offset = "0xA6E1E30", VA = "0x18A6E2E30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0xA6E2D00", Offset = "0xA6E1D00", VA = "0x18A6E2D00", Slot = "18")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E21A0", Offset = "0xA6E11A0", VA = "0x18A6E21A0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2280", Offset = "0xA6E1280", VA = "0x18A6E2280", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2490", Offset = "0xA6E1490", VA = "0x18A6E2490", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2300", Offset = "0xA6E1300", VA = "0x18A6E2300", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2060", Offset = "0xA6E1060", VA = "0x18A6E2060", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD210", Offset = "0xA6BC210", VA = "0x18A6BD210")]
		internal CameraPerspective()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2B20", Offset = "0xA6E1B20", VA = "0x18A6E2B20")]
		internal CameraPerspective(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6E29C0", Offset = "0xA6E19C0", VA = "0x18A6E29C0")]
		public static void VerifyParameters(float? aspectRatio, float yfov, float znear, float zfar = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E21D0", Offset = "0xA6E11D0", VA = "0x18A6E21D0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1950", Offset = "0xA6F0950", VA = "0x18A6F1950", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xA6EE1E0", Offset = "0xA6ED1E0", VA = "0x18A6EE1E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1AD0", Offset = "0xA6F0AD0", VA = "0x18A6F1AD0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0F50", Offset = "0xA6EFF50", VA = "0x18A6F0F50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0xA6F05B0", Offset = "0xA6EF5B0", VA = "0x18A6F05B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xA6F05B0", Offset = "0xA6EF5B0", VA = "0x18A6F05B0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6E3B20", Offset = "0xA6E2B20", VA = "0x18A6E3B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0xA6E3A30", Offset = "0xA6E2A30", VA = "0x18A6E3A30")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3060", Offset = "0xA6E2060", VA = "0x18A6E3060", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3230", Offset = "0xA6E2230", VA = "0x18A6E3230", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3680", Offset = "0xA6E2680", VA = "0x18A6E3680", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6E32B0", Offset = "0xA6E22B0", VA = "0x18A6E32B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2E90", Offset = "0xA6E1E90", VA = "0x18A6E2E90", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1410", Offset = "0xA6E0410", VA = "0x18A6E1410")]
		internal Camera()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2FD0", Offset = "0xA6E1FD0", VA = "0x18A6E2FD0")]
		internal ICamera GetCamera()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E33C0", Offset = "0xA6E23C0", VA = "0x18A6E33C0")]
		public void SetOrthographicMode(float xmag, float ymag, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E34C0", Offset = "0xA6E24C0", VA = "0x18A6E34C0")]
		public void SetPerspectiveMode(float? aspectRatio, float yfov, float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3090", Offset = "0xA6E2090", VA = "0x18A6E3090", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1410", Offset = "0xA6F0410", VA = "0x18A6F1410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xA6EF210", Offset = "0xA6EE210", VA = "0x18A6EF210", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1E90", Offset = "0xA6F0E90", VA = "0x18A6F1E90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0E10", Offset = "0xA6EFE10", VA = "0x18A6F0E10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0BF0", Offset = "0xA6EFBF0", VA = "0x18A6F0BF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0BF0", Offset = "0xA6EFBF0", VA = "0x18A6F0BF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public int LogicalTextureIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0xD4BEA0", Offset = "0xD4AEA0", VA = "0x180D4BEA0")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED560", Offset = "0xA6EC560", VA = "0x18A6ED560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED5E0", Offset = "0xA6EC5E0", VA = "0x18A6ED5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public TextureTransform Transform
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED5A0", Offset = "0xA6EC5A0", VA = "0x18A6ED5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECEA0", Offset = "0xA6EBEA0", VA = "0x18A6ECEA0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECFE0", Offset = "0xA6EBFE0", VA = "0x18A6ECFE0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED250", Offset = "0xA6EC250", VA = "0x18A6ED250", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED060", Offset = "0xA6EC060", VA = "0x18A6ED060", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECDB0", Offset = "0xA6EBDB0", VA = "0x18A6ECDB0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED500", Offset = "0xA6EC500", VA = "0x18A6ED500")]
		public TextureInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED140", Offset = "0xA6EC140", VA = "0x18A6ED140")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6ECED0", Offset = "0xA6EBED0", VA = "0x18A6ECED0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6EDE00", Offset = "0xA6ECE00", VA = "0x18A6EDE00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <GetChannels>d__32(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED640", Offset = "0xA6EC640", VA = "0x18A6ED640", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA6EDDC0", Offset = "0xA6ECDC0", VA = "0x18A6EDDC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA6EDD10", Offset = "0xA6ECD10", VA = "0x18A6EDD10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA6EDD10", Offset = "0xA6ECD10", VA = "0x18A6EDD10", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xA6F17D0", Offset = "0xA6F07D0", VA = "0x18A6F17D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0230", Offset = "0xA6EF230", VA = "0x18A6F0230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1BC0", Offset = "0xA6F0BC0", VA = "0x18A6F1BC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1090", Offset = "0xA6F0090", VA = "0x18A6F1090", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0A10", Offset = "0xA6EFA10", VA = "0x18A6F0A10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0A10", Offset = "0xA6EFA10", VA = "0x18A6F0A10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF7BE0", Offset = "0xCF6BE0", VA = "0x180CF7BE0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xA6E5330", Offset = "0xA6E4330", VA = "0x18A6E5330")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0xA6E53F0", Offset = "0xA6E43F0", VA = "0x18A6E53F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public float MetallicFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA6E5560", Offset = "0xA6E4560", VA = "0x18A6E5560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0xA6E55C0", Offset = "0xA6E45C0", VA = "0x18A6E55C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public float RoughnessFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA6E5630", Offset = "0xA6E4630", VA = "0x18A6E5630")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0xA6E5690", Offset = "0xA6E4690", VA = "0x18A6E5690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E47B0", Offset = "0xA6E37B0", VA = "0x18A6E47B0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4A10", Offset = "0xA6E3A10", VA = "0x18A6E4A10", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4CC0", Offset = "0xA6E3CC0", VA = "0x18A6E4CC0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4A90", Offset = "0xA6E3A90", VA = "0x18A6E4A90", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4580", Offset = "0xA6E3580", VA = "0x18A6E4580", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xCF7B80", Offset = "0xCF6B80", VA = "0x180CF7B80", Slot = "17")]
		void IChildOf<Material>.SetLogicalParent(Material parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA6E47E0", Offset = "0xA6E37E0", VA = "0x18A6E47E0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4720", Offset = "0xA6E3720", VA = "0x18A6E4720")]
		[IteratorStateMachine(typeof(<GetChannels>d__32))]
		public IEnumerable<MaterialChannel> GetChannels(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5750", Offset = "0xA6E4750", VA = "0x18A6E5750")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000839")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083A")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1A10", Offset = "0xA6F0A10", VA = "0x18A6F1A10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083B")]
			[Cpp2IlInjected.Address(RVA = "0xA6EF7D0", Offset = "0xA6EE7D0", VA = "0x18A6EF7D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600083C")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1B70", Offset = "0xA6F0B70", VA = "0x18A6F1B70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0F90", Offset = "0xA6EFF90", VA = "0x18A6F0F90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0xA6F06F0", Offset = "0xA6EF6F0", VA = "0x18A6F06F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xA6F06F0", Offset = "0xA6EF6F0", VA = "0x18A6F06F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xDA1580", Offset = "0xDA0580", VA = "0x180DA1580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public float Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0xA6E3F90", Offset = "0xA6E2F90", VA = "0x18A6E3F90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0xA6E3FF0", Offset = "0xA6E2FF0", VA = "0x18A6E3FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3BD0", Offset = "0xA6E2BD0", VA = "0x18A6E3BD0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3C00", Offset = "0xA6E2C00", VA = "0x18A6E3C00", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3D40", Offset = "0xA6E2D40", VA = "0x18A6E3D40", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3C80", Offset = "0xA6E2C80", VA = "0x18A6E3C80", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3B30", Offset = "0xA6E2B30", VA = "0x18A6E3B30", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA6E3EF0", Offset = "0xA6E2EF0", VA = "0x18A6E3EF0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1890", Offset = "0xA6F0890", VA = "0x18A6F1890", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA6EFD40", Offset = "0xA6EED40", VA = "0x18A6EFD40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1CB0", Offset = "0xA6F0CB0", VA = "0x18A6F1CB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000854")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1050", Offset = "0xA6F0050", VA = "0x18A6F1050", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0970", Offset = "0xA6EF970", VA = "0x18A6F0970", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0970", Offset = "0xA6EF970", VA = "0x18A6F0970", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xDA1580", Offset = "0xDA0580", VA = "0x180DA1580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public float Strength
		{
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0xA6E44B0", Offset = "0xA6E34B0", VA = "0x18A6E44B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xA6E4510", Offset = "0xA6E3510", VA = "0x18A6E4510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4100", Offset = "0xA6E3100", VA = "0x18A6E4100", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4130", Offset = "0xA6E3130", VA = "0x18A6E4130", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4270", Offset = "0xA6E3270", VA = "0x18A6E4270", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA6E41B0", Offset = "0xA6E31B0", VA = "0x18A6E41B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4060", Offset = "0xA6E3060", VA = "0x18A6E4060", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA6E4410", Offset = "0xA6E3410", VA = "0x18A6E4410")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA6F11D0", Offset = "0xA6F01D0", VA = "0x18A6F11D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA6EE4E0", Offset = "0xA6ED4E0", VA = "0x18A6EE4E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xA6F1DA0", Offset = "0xA6F0DA0", VA = "0x18A6F1DA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xA6F10D0", Offset = "0xA6F00D0", VA = "0x18A6F10D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0C90", Offset = "0xA6EFC90", VA = "0x18A6F0C90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xA6F0C90", Offset = "0xA6EFC90", VA = "0x18A6F0C90", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x10F9AE0", Offset = "0x10F8AE0", VA = "0x1810F9AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6F5330", Offset = "0xA6F4330", VA = "0x18A6F5330", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x1416C10", Offset = "0x1415C10", VA = "0x181416C10")]
			[DebuggerHidden]
			public <_GetChannels>d__45(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5390", Offset = "0xA6F4390", VA = "0x18A6F5390", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0xA6F3730", Offset = "0xA6F2730", VA = "0x18A6F3730", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5780", Offset = "0xA6F4780", VA = "0x18A6F5780")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0xA6F57E0", Offset = "0xA6F47E0", VA = "0x18A6F57E0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5840", Offset = "0xA6F4840", VA = "0x18A6F5840")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0xA6F58A0", Offset = "0xA6F48A0", VA = "0x18A6F58A0")]
			private void <>m__Finally4()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5900", Offset = "0xA6F4900", VA = "0x18A6F5900")]
			private void <>m__Finally5()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5960", Offset = "0xA6F4960", VA = "0x18A6F5960")]
			private void <>m__Finally6()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0xA6F59C0", Offset = "0xA6F49C0", VA = "0x18A6F59C0")]
			private void <>m__Finally7()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5A20", Offset = "0xA6F4A20", VA = "0x18A6F5A20")]
			private void <>m__Finally8()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5A80", Offset = "0xA6F4A80", VA = "0x18A6F5A80")]
			private void <>m__Finally9()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5720", Offset = "0xA6F4720", VA = "0x18A6F5720")]
			private void <>m__Finally10()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0xA6F52F0", Offset = "0xA6F42F0", VA = "0x18A6F52F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5250", Offset = "0xA6F4250", VA = "0x18A6F5250", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<MaterialChannel> IEnumerable<MaterialChannel>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA6F5250", Offset = "0xA6F4250", VA = "0x18A6F5250", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6E7DC0", Offset = "0xA6E6DC0", VA = "0x18A6E7DC0")]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0xA6E8000", Offset = "0xA6E7000", VA = "0x18A6E8000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7D60", Offset = "0xA6E6D60", VA = "0x18A6E7D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7F80", Offset = "0xA6E6F80", VA = "0x18A6E7F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7E60", Offset = "0xA6E6E60", VA = "0x18A6E7E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0xA6E8130", Offset = "0xA6E7130", VA = "0x18A6E8130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		public bool Unlit
		{
			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7F40", Offset = "0xA6E6F40", VA = "0x18A6E7F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public IEnumerable<MaterialChannel> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7800", Offset = "0xA6E6800", VA = "0x18A6E7800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7EE0", Offset = "0xA6E6EE0", VA = "0x18A6E7EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0xA6E81B0", Offset = "0xA6E71B0", VA = "0x18A6E81B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7E00", Offset = "0xA6E6E00", VA = "0x18A6E7E00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0xA6E8050", Offset = "0xA6E7050", VA = "0x18A6E8050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6080", Offset = "0xA6E5080", VA = "0x18A6E6080", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6720", Offset = "0xA6E5720", VA = "0x18A6E6720", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6AB0", Offset = "0xA6E5AB0", VA = "0x18A6E6AB0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E67A0", Offset = "0xA6E57A0", VA = "0x18A6E67A0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E59B0", Offset = "0xA6E49B0", VA = "0x18A6E59B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7C10", Offset = "0xA6E6C10", VA = "0x18A6E7C10")]
		internal Material()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5D60", Offset = "0xA6E4D60", VA = "0x18A6E5D60")]
		[DebuggerStepThrough]
		public MaterialChannel? FindChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xA6E6550", Offset = "0xA6E5550", VA = "0x18A6E6550", Slot = "5")]
		protected override void OnValidateContent(ValidationContext result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xA6E5860", Offset = "0xA6E4860", VA = "0x18A6E5860")]
		internal void ClearExtensions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E64B0", Offset = "0xA6E54B0", VA = "0x18A6E64B0")]
		public void InitializeUnlit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E60B0", Offset = "0xA6E50B0", VA = "0x18A6E60B0")]
		public void InitializePBRMetallicRoughness(params string[] extensionNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E63E0", Offset = "0xA6E53E0", VA = "0x18A6E63E0")]
		public void InitializePBRSpecularGlossiness(bool useFallback = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7800", Offset = "0xA6E6800", VA = "0x18A6E7800")]
		[IteratorStateMachine(typeof(<_GetChannels>d__45))]
		private IEnumerable<MaterialChannel> _GetChannels()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7960", Offset = "0xA6E6960", VA = "0x18A6E7960")]
		private MaterialNormalTextureInfo _GetNormalTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7A80", Offset = "0xA6E6A80", VA = "0x18A6E7A80")]
		private MaterialOcclusionTextureInfo _GetOcclusionTexture(bool create)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xA6E7880", Offset = "0xA6E6880", VA = "0x18A6E7880")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0xA712680", Offset = "0xA711680", VA = "0x18A712680", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0xA711B40", Offset = "0xA710B40", VA = "0x18A711B40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0xA712C60", Offset = "0xA711C60", VA = "0x18A712C60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EB")]
			[Cpp2IlInjected.Address(RVA = "0xA7124C0", Offset = "0xA7114C0", VA = "0x18A7124C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xA712140", Offset = "0xA711140", VA = "0x18A712140", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0xA712140", Offset = "0xA711140", VA = "0x18A712140", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD6D840", Offset = "0xD6C840", VA = "0x180D6D840", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD6F040", Offset = "0xD6E040", VA = "0x180D6F040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public Mesh LogicalParent
		{
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BC0", Offset = "0xCF6BC0", VA = "0x180CF7BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0xA6ECA50", Offset = "0xA6EBA50", VA = "0x18A6ECA50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0xA6ECCC0", Offset = "0xA6EBCC0", VA = "0x18A6ECCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		public PrimitiveType DrawPrimitiveType
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xA6EC960", Offset = "0xA6EB960", VA = "0x18A6EC960")]
			get
			{
				return default(PrimitiveType);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0xA6ECC70", Offset = "0xA6EBC70", VA = "0x18A6ECC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		public int MorphTargetsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0xA6ECB60", Offset = "0xA6EBB60", VA = "0x18A6ECB60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public IReadOnlyDictionary<string, Accessor> VertexAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0xA6ECBA0", Offset = "0xA6EBBA0", VA = "0x18A6ECBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public Accessor IndexAccessor
		{
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0xA6EC9A0", Offset = "0xA6EB9A0", VA = "0x18A6EC9A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xA6EB400", Offset = "0xA6EA400", VA = "0x18A6EB400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9260", Offset = "0xA6E8260", VA = "0x18A6E9260", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB1F0", Offset = "0xA6EA1F0", VA = "0x18A6EB1F0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6EBC80", Offset = "0xA6EAC80", VA = "0x18A6EBC80", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB270", Offset = "0xA6EA270", VA = "0x18A6EB270", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8520", Offset = "0xA6E7520", VA = "0x18A6E8520", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC7F0", Offset = "0xA6EB7F0", VA = "0x18A6EC7F0")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6EC860", Offset = "0xA6EB860", VA = "0x18A6EC860")]
		internal MeshPrimitive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6EBC50", Offset = "0xA6EAC50", VA = "0x18A6EBC50", Slot = "18")]
		void IChildOfList<Mesh>.SetLogicalParent(Mesh parent, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8710", Offset = "0xA6E7710", VA = "0x18A6E8710")]
		public IEnumerable<BufferView> GetBufferViews(bool includeIndices, bool includeVertices, bool includeMorphs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9590", Offset = "0xA6E8590", VA = "0x18A6E9590")]
		public IReadOnlyList<KeyValuePair<string, Accessor>> GetVertexAccessorsByBuffer(BufferView vb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9490", Offset = "0xA6E8490", VA = "0x18A6E9490")]
		public Accessor GetVertexAccessor(string attributeKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0xA6EBAF0", Offset = "0xA6EAAF0", VA = "0x18A6EBAF0")]
		public void SetVertexAccessor(string attributeKey, Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D16340", Offset = "0x3D15340", VA = "0x183D16340")]
		internal IReadOnlyList<T> GetVertices<T>(string attributeKey) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8BD0", Offset = "0xA6E7BD0", VA = "0x18A6E8BD0")]
		public Accessor GetIndexAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB400", Offset = "0xA6EA400", VA = "0x18A6EB400")]
		public void SetIndexAccessor(Accessor accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8C70", Offset = "0xA6E7C70", VA = "0x18A6E8C70")]
		public IList<uint> GetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8FF0", Offset = "0xA6E7FF0", VA = "0x18A6E8FF0")]
		public IEnumerable<int> GetPointIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8CA0", Offset = "0xA6E7CA0", VA = "0x18A6E8CA0")]
		public IEnumerable<(int, int)> GetLineIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9290", Offset = "0xA6E8290", VA = "0x18A6E9290")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8EA0", Offset = "0xA6E7EA0", VA = "0x18A6E8EA0")]
		public IReadOnlyDictionary<string, Accessor> GetMorphTargetAccessors(int targetIdx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6EB500", Offset = "0xA6EA500", VA = "0x18A6EB500")]
		public void SetMorphTargetAccessors(int targetIdx, IReadOnlyDictionary<string, Accessor> accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8290", Offset = "0xA6E7290", VA = "0x18A6E8290")]
		internal static bool CheckAttributesQuantizationRequired(ModelRoot root)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0xA6E8490", Offset = "0xA6E7490", VA = "0x18A6E8490")]
		private bool CheckAttributesQuantizationRequired()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6EABA0", Offset = "0xA6E9BA0", VA = "0x18A6EABA0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E9810", Offset = "0xA6E8810", VA = "0x18A6E9810", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0xA7125C0", Offset = "0xA7115C0", VA = "0x18A7125C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0xA710160", Offset = "0xA70F160", VA = "0x18A710160", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0xA712D00", Offset = "0xA711D00", VA = "0x18A712D00")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090D")]
			[Cpp2IlInjected.Address(RVA = "0xA712440", Offset = "0xA711440", VA = "0x18A712440", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xA712000", Offset = "0xA711000", VA = "0x18A712000", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0xA712000", Offset = "0xA711000", VA = "0x18A712000", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6F88F0", Offset = "0xA6F78F0", VA = "0x18A6F88F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public IReadOnlyList<MeshPrimitive> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60008F8")]
			[Cpp2IlInjected.Address(RVA = "0xA6F79F0", Offset = "0xA6F69F0", VA = "0x18A6F79F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public bool AllPrimitivesHaveJoints
		{
			[Cpp2IlInjected.Token(Token = "0x60008F9")]
			[Cpp2IlInjected.Address(RVA = "0xA6F87D0", Offset = "0xA6F77D0", VA = "0x18A6F87D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6F7B60", Offset = "0xA6F6B60", VA = "0x18A6F7B60", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xA6F8070", Offset = "0xA6F7070", VA = "0x18A6F8070", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xA6F8380", Offset = "0xA6F7380", VA = "0x18A6F8380", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xA6F80F0", Offset = "0xA6F70F0", VA = "0x18A6F80F0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6F7900", Offset = "0xA6F6900", VA = "0x18A6F7900", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6F8610", Offset = "0xA6F7610", VA = "0x18A6F8610")]
		private string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xA6F8710", Offset = "0xA6F7710", VA = "0x18A6F8710")]
		internal Mesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6F79F0", Offset = "0xA6F69F0", VA = "0x18A6F79F0")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6F8200", Offset = "0xA6F7200", VA = "0x18A6F8200")]
		public void SetMorphWeights(IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6F8210", Offset = "0xA6F7210", VA = "0x18A6F8210")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6F7880", Offset = "0xA6F6880", VA = "0x18A6F7880")]
		public MeshPrimitive CreatePrimitive()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6F7F10", Offset = "0xA6F6F10", VA = "0x18A6F7F10", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0xA6F7B90", Offset = "0xA6F6B90", VA = "0x18A6F7B90", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600096C")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <Flatten>d__70(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096D")]
			[Cpp2IlInjected.Address(RVA = "0xA70FF20", Offset = "0xA70EF20", VA = "0x18A70FF20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600096E")]
			[Cpp2IlInjected.Address(RVA = "0xA70FA50", Offset = "0xA70EA50", VA = "0x18A70FA50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xA7100C0", Offset = "0xA70F0C0", VA = "0x18A7100C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xA710110", Offset = "0xA70F110", VA = "0x18A710110")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000972")]
			[Cpp2IlInjected.Address(RVA = "0xA70FEE0", Offset = "0xA70EEE0", VA = "0x18A70FEE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000974")]
			[Cpp2IlInjected.Address(RVA = "0xA70FE40", Offset = "0xA70EE40", VA = "0x18A70FE40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0xA70FE40", Offset = "0xA70EE40", VA = "0x18A70FE40", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0xA712B00", Offset = "0xA711B00", VA = "0x18A712B00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0xA710A20", Offset = "0xA70FA20", VA = "0x18A710A20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000979")]
			[Cpp2IlInjected.Address(RVA = "0xA712DF0", Offset = "0xA711DF0", VA = "0x18A712DF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097B")]
			[Cpp2IlInjected.Address(RVA = "0xA712400", Offset = "0xA711400", VA = "0x18A712400", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0xA711F60", Offset = "0xA710F60", VA = "0x18A711F60", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xA711F60", Offset = "0xA710F60", VA = "0x18A711F60", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA708C80", Offset = "0xA707C80", VA = "0x18A708C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Node VisualRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0xA708D90", Offset = "0xA707D90", VA = "0x18A708D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<Scene> VisualScenes
		{
			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0xA708E00", Offset = "0xA707E00", VA = "0x18A708E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0xA705F90", Offset = "0xA704F90", VA = "0x18A705F90", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public bool IsSkinJoint
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0xA707D70", Offset = "0xA706D70", VA = "0x18A707D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public bool IsSkinSkeleton
		{
			[Cpp2IlInjected.Token(Token = "0x600091D")]
			[Cpp2IlInjected.Address(RVA = "0xA707E80", Offset = "0xA706E80", VA = "0x18A707E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public Camera Camera
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xA707C70", Offset = "0xA706C70", VA = "0x18A707C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0xA709320", Offset = "0xA708320", VA = "0x18A709320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		public Mesh Mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0xA7088B0", Offset = "0xA7078B0", VA = "0x18A7088B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0xA709500", Offset = "0xA708500", VA = "0x18A709500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public Skin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0xA708B70", Offset = "0xA707B70", VA = "0x18A708B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0xA7096F0", Offset = "0xA7086F0", VA = "0x18A7096F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public IReadOnlyList<float> MorphWeights
		{
			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0xA7089C0", Offset = "0xA7079C0", VA = "0x18A7089C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0xA709200", Offset = "0xA708200", VA = "0x18A709200")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0xA709890", Offset = "0xA708890", VA = "0x18A709890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0xA708740", Offset = "0xA707740", VA = "0x18A708740")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0xA7094C0", Offset = "0xA7084C0", VA = "0x18A7094C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x6000929")]
			[Cpp2IlInjected.Address(RVA = "0xA708660", Offset = "0xA707660", VA = "0x18A708660")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600092A")]
			[Cpp2IlInjected.Address(RVA = "0xA709400", Offset = "0xA708400", VA = "0x18A709400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(RVA = "0xA7081D0", Offset = "0xA7071D0", VA = "0x18A7081D0")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0xA708F40", Offset = "0xA707F40", VA = "0x18A708F40")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool IsTransformAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0xA707F90", Offset = "0xA706F90", VA = "0x18A707F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		internal bool IsTransformDecomposed
		{
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0xA708170", Offset = "0xA707170", VA = "0x18A708170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public PunctualLight PunctualLight
		{
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0xA7089D0", Offset = "0xA7079D0", VA = "0x18A7089D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0xA7095F0", Offset = "0xA7085F0", VA = "0x18A7095F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0xA7038B0", Offset = "0xA7028B0", VA = "0x18A7038B0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0xA704100", Offset = "0xA703100", VA = "0x18A704100", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0xA704950", Offset = "0xA703950", VA = "0x18A704950", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xA7041C0", Offset = "0xA7031C0", VA = "0x18A7041C0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xA702D40", Offset = "0xA701D40", VA = "0x18A702D40", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xA705A40", Offset = "0xA704A40", VA = "0x18A705A40")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xA7079B0", Offset = "0xA7069B0", VA = "0x18A7079B0")]
		internal Node()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0xA703490", Offset = "0xA702490", VA = "0x18A703490")]
		public AffineTransform GetLocalTransform(Animation animation, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0xA7038E0", Offset = "0xA7028E0", VA = "0x18A7038E0")]
		public Matrix4x4 GetWorldMatrix(Animation animation, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xA7035D0", Offset = "0xA7025D0", VA = "0x18A7035D0")]
		public IReadOnlyList<float> GetMorphWeights()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0xA704640", Offset = "0xA703640", VA = "0x18A704640")]
		public void SetMorphWeights(SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xA705920", Offset = "0xA704920", VA = "0x18A705920")]
		internal static Node _FindVisualRootNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0xA702CE0", Offset = "0xA701CE0", VA = "0x18A702CE0", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0xA7032D0", Offset = "0xA7022D0", VA = "0x18A7032D0")]
		[IteratorStateMachine(typeof(<Flatten>d__70))]
		public static IEnumerable<Node> Flatten(IVisualNodeContainer container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA7030D0", Offset = "0xA7020D0", VA = "0x18A7030D0")]
		public static IEnumerable<Node> FindNodesUsingMesh(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA7031D0", Offset = "0xA7021D0", VA = "0x18A7031D0")]
		public static IEnumerable<Node> FindNodesUsingSkin(Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA7057B0", Offset = "0xA7047B0", VA = "0x18A7057B0")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA706020", Offset = "0xA705020", VA = "0x18A706020")]
		internal bool _HasVisualChild(int nodeIndex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA705F90", Offset = "0xA704F90", VA = "0x18A705F90")]
		internal IEnumerable<Node> _GetVisualChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xA7065E0", Offset = "0xA7055E0", VA = "0x18A7065E0")]
		internal void _SetVisualParent(Node parentNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA706080", Offset = "0xA705080", VA = "0x18A706080")]
		internal void _RemoveFromVisualParent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA703350", Offset = "0xA702350", VA = "0x18A703350")]
		public NodeCurveSamplers GetCurveSamplers(Animation animation)
		{
			return default(NodeCurveSamplers);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA7060E0", Offset = "0xA7050E0", VA = "0x18A7060E0")]
		private void _SetLocalTransform(AffineTransform value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA703D50", Offset = "0xA702D50", VA = "0x18A703D50", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA706D50", Offset = "0xA705D50", VA = "0x18A706D50")]
		internal static void _ValidateParentHierarchy(IEnumerable<Node> nodes, ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA703B70", Offset = "0xA702B70", VA = "0x18A703B70", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0xA7069C0", Offset = "0xA7059C0", VA = "0x18A7069C0")]
		private void _ValidateChildrenHierarchy(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xA707430", Offset = "0xA706430", VA = "0x18A707430")]
		private void _ValidateTransforms(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xA706AC0", Offset = "0xA705AC0", VA = "0x18A706AC0")]
		private static void _ValidateMeshAndSkin(ValidationContext validate, Mesh mesh, Skin skin, List<double> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0xA703450", Offset = "0xA702450", VA = "0x18A703450")]
		public MeshGpuInstancing GetGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA705700", Offset = "0xA704700", VA = "0x18A705700")]
		public MeshGpuInstancing UseGpuInstancing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA704180", Offset = "0xA703180", VA = "0x18A704180")]
		public void RemoveGpuInstancing()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA7048E0", Offset = "0xA7038E0", VA = "0x18A7048E0")]
		public bool TryGetVisibility([Out] bool isVisible)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0xA704830", Offset = "0xA703830", VA = "0x18A704830")]
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
			[Cpp2IlInjected.Address(RVA = "0xA714210", Offset = "0xA713210", VA = "0x18A714210", Slot = "4")]
			public bool Equals(TextureSampler x, TextureSampler y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0xA7143B0", Offset = "0xA7133B0", VA = "0x18A7143B0", Slot = "5")]
			public int GetHashCode(TextureSampler obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099C")]
			[Cpp2IlInjected.Address(RVA = "0xA712740", Offset = "0xA711740", VA = "0x18A712740", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099D")]
			[Cpp2IlInjected.Address(RVA = "0xA710700", Offset = "0xA70F700", VA = "0x18A710700", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0xA712BC0", Offset = "0xA711BC0", VA = "0x18A712BC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A0")]
			[Cpp2IlInjected.Address(RVA = "0xA7123C0", Offset = "0xA7113C0", VA = "0x18A7123C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0xA7120A0", Offset = "0xA7110A0", VA = "0x18A7120A0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0xA7120A0", Offset = "0xA7110A0", VA = "0x18A7120A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA70E400", Offset = "0xA70D400", VA = "0x18A70E400")]
			get
			{
				return default(TextureMipMapFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000987")]
			[Cpp2IlInjected.Address(RVA = "0xA70E3C0", Offset = "0xA70D3C0", VA = "0x18A70E3C0")]
			get
			{
				return default(TextureInterpolationFilter);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0xA70E440", Offset = "0xA70D440", VA = "0x18A70E440")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0xA70E480", Offset = "0xA70D480", VA = "0x18A70E480")]
			get
			{
				return default(TextureWrapMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public static IEqualityComparer<TextureSampler> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xA70E370", Offset = "0xA70D370", VA = "0x18A70E370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xA70E4C0", Offset = "0xA70D4C0", VA = "0x18A70E4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0xA70D950", Offset = "0xA70C950", VA = "0x18A70D950", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0xA70DA90", Offset = "0xA70CA90", VA = "0x18A70DA90", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0xA70DC90", Offset = "0xA70CC90", VA = "0x18A70DC90", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0xA70DB10", Offset = "0xA70CB10", VA = "0x18A70DB10", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(RVA = "0xA70D600", Offset = "0xA70C600", VA = "0x18A70D600", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0xA70E1B0", Offset = "0xA70D1B0", VA = "0x18A70E1B0")]
		internal TextureSampler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0xA70E240", Offset = "0xA70D240", VA = "0x18A70E240")]
		internal TextureSampler(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xA70D980", Offset = "0xA70C980", VA = "0x18A70D980")]
		internal static bool IsDefault(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xA70D4A0", Offset = "0xA70C4A0", VA = "0x18A70D4A0")]
		public static bool AreEqualByContent(TextureSampler x, TextureSampler y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0xA70D9A0", Offset = "0xA70C9A0", VA = "0x18A70D9A0")]
		internal bool IsEqualTo(TextureMipMapFilter min, TextureInterpolationFilter mag, TextureWrapMode ws, TextureWrapMode wt)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0xA70D830", Offset = "0xA70C830", VA = "0x18A70D830")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0xA712800", Offset = "0xA711800", VA = "0x18A712800", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0xA710EF0", Offset = "0xA70FEF0", VA = "0x18A710EF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009BD")]
			[Cpp2IlInjected.Address(RVA = "0xA712C10", Offset = "0xA711C10", VA = "0x18A712C10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0xA712540", Offset = "0xA711540", VA = "0x18A712540", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0xA712280", Offset = "0xA711280", VA = "0x18A712280", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0xA712280", Offset = "0xA711280", VA = "0x18A712280", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public IEnumerable<Node> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0xA70A910", Offset = "0xA709910", VA = "0x18A70A910", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xA709AF0", Offset = "0xA708AF0", VA = "0x18A709AF0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xA70A070", Offset = "0xA709070", VA = "0x18A70A070", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xA70A1A0", Offset = "0xA7091A0", VA = "0x18A70A1A0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0xA70A0F0", Offset = "0xA7090F0", VA = "0x18A70A0F0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0xA709A50", Offset = "0xA708A50", VA = "0x18A709A50", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0xA70A890", Offset = "0xA709890", VA = "0x18A70A890")]
		internal Scene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0xA7099F0", Offset = "0xA7089F0", VA = "0x18A7099F0", Slot = "20")]
		public Node CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0xA70A3A0", Offset = "0xA7093A0", VA = "0x18A70A3A0")]
		internal bool _ContainsVisualNode(Node node, bool recursive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0xA70A5E0", Offset = "0xA7095E0", VA = "0x18A70A5E0")]
		internal void _RemoveVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xA70A6D0", Offset = "0xA7096D0", VA = "0x18A70A6D0")]
		internal void _UseVisualNode(Node node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0xA709B20", Offset = "0xA708B20", VA = "0x18A709B20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0xA7128C0", Offset = "0xA7118C0", VA = "0x18A7128C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0xA710400", Offset = "0xA70F400", VA = "0x18A710400", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0xA712DA0", Offset = "0xA711DA0", VA = "0x18A712DA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F1")]
			[Cpp2IlInjected.Address(RVA = "0xA712580", Offset = "0xA711580", VA = "0x18A712580", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0xA711EC0", Offset = "0xA710EC0", VA = "0x18A711EC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0xA711EC0", Offset = "0xA710EC0", VA = "0x18A711EC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA70D290", Offset = "0xA70C290", VA = "0x18A70D290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		public int JointsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60009CA")]
			[Cpp2IlInjected.Address(RVA = "0xA70D120", Offset = "0xA70C120", VA = "0x18A70D120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		public IReadOnlyList<Node> Joints
		{
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0xA70D160", Offset = "0xA70C160", VA = "0x18A70D160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		public IReadOnlyList<Matrix4x4> InverseBindMatrices
		{
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0xA70D070", Offset = "0xA70C070", VA = "0x18A70D070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		public Node Skeleton
		{
			[Cpp2IlInjected.Token(Token = "0x60009CD")]
			[Cpp2IlInjected.Address(RVA = "0xA70D1F0", Offset = "0xA70C1F0", VA = "0x18A70D1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0xA70D3C0", Offset = "0xA70C3C0", VA = "0x18A70D3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xA70BB30", Offset = "0xA70AB30", VA = "0x18A70BB30", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0xA70C460", Offset = "0xA70B460", VA = "0x18A70C460", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0xA70C5F0", Offset = "0xA70B5F0", VA = "0x18A70C5F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0xA70C4E0", Offset = "0xA70B4E0", VA = "0x18A70C4E0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0xA70B530", Offset = "0xA70A530", VA = "0x18A70B530", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0xA70CFF0", Offset = "0xA70BFF0", VA = "0x18A70CFF0")]
		internal Skin()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0xA70CAD0", Offset = "0xA70BAD0", VA = "0x18A70CAD0")]
		public Accessor UseInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0xA70B810", Offset = "0xA70A810", VA = "0x18A70B810")]
		public Accessor GetInverseBindMatricesAccessor()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0xA70B910", Offset = "0xA70A910", VA = "0x18A70B910")]
		public (Node, Matrix4x4) GetJoint(int idx)
		{
			return default((Node, Matrix4x4));
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0xA70B050", Offset = "0xA70A050", VA = "0x18A70B050")]
		public void BindJoints(params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0xA70B0D0", Offset = "0xA70A0D0", VA = "0x18A70B0D0")]
		public void BindJoints(Matrix4x4 meshBindTransform, params Node[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0xA70A9A0", Offset = "0xA7099A0", VA = "0x18A70A9A0")]
		public void BindJoints(IReadOnlyList<(Node Joint, Matrix4x4 InverseBindMatrix)> joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0xA70BB60", Offset = "0xA70AB60", VA = "0x18A70BB60")]
		internal bool IsMatch(Node skeleton, KeyValuePair<Node, Matrix4x4>[] joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0xA70B650", Offset = "0xA70A650", VA = "0x18A70B650")]
		internal static IEnumerable<Skin> FindSkinsUsingJoint(Node jointNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0xA70B730", Offset = "0xA70A730", VA = "0x18A70B730")]
		internal static IEnumerable<Skin> FindSkinsUsingSkeleton(Node skeletonNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0xA70CBF0", Offset = "0xA70BBF0", VA = "0x18A70CBF0")]
		private Node _FindCommonAncestor(IEnumerable<Node> nodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0xA70BF80", Offset = "0xA70AF80", VA = "0x18A70BF80", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0xA70BD50", Offset = "0xA70AD50", VA = "0x18A70BD50", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0xA712980", Offset = "0xA711980", VA = "0x18A712980", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0xA7118A0", Offset = "0xA7108A0", VA = "0x18A7118A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0xA712D50", Offset = "0xA711D50", VA = "0x18A712D50")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xA712480", Offset = "0xA711480", VA = "0x18A712480", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0xA712320", Offset = "0xA711320", VA = "0x18A712320", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0xA712320", Offset = "0xA711320", VA = "0x18A712320", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA70F890", Offset = "0xA70E890", VA = "0x18A70F890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0xA70F990", Offset = "0xA70E990", VA = "0x18A70F990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		public Image PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0xA70F880", Offset = "0xA70E880", VA = "0x18A70F880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		public Image FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0xA70F7C0", Offset = "0xA70E7C0", VA = "0x18A70F7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0xA70E680", Offset = "0xA70D680", VA = "0x18A70E680", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0xA70E800", Offset = "0xA70D800", VA = "0x18A70E800", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0xA70EFF0", Offset = "0xA70DFF0", VA = "0x18A70EFF0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0xA70E880", Offset = "0xA70D880", VA = "0x18A70E880", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F9")]
		[Cpp2IlInjected.Address(RVA = "0xA70E5B0", Offset = "0xA70D5B0", VA = "0x18A70E5B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1410", Offset = "0xA6E0410", VA = "0x18A6E1410")]
		internal Texture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xA70F360", Offset = "0xA70E360", VA = "0x18A70F360")]
		private Image _GetPrimaryImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0xA70F2A0", Offset = "0xA70E2A0", VA = "0x18A70F2A0")]
		private Image _GetFallbackImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0xA70E910", Offset = "0xA70D910", VA = "0x18A70E910")]
		public void SetImage(Image primaryImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0xA70EB40", Offset = "0xA70DB40", VA = "0x18A70EB40")]
		public void SetImages(Image primaryImage, Image fallbackImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xA70E530", Offset = "0xA70D530", VA = "0x18A70E530")]
		public void ClearImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0xA70F670", Offset = "0xA70E670", VA = "0x18A70F670")]
		private TextureDDS _UseDDSTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0xA70F750", Offset = "0xA70E750", VA = "0x18A70F750")]
		private TextureWEBP _UseWEBPTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0xA70F6E0", Offset = "0xA70E6E0", VA = "0x18A70F6E0")]
		private TextureKTX2 _UseKTX2Texture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0xA70F490", Offset = "0xA70E490", VA = "0x18A70F490")]
		internal bool _IsEqualentTo(Image primary, Image fallback, TextureSampler sampler)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0xA70E6B0", Offset = "0xA70D6B0", VA = "0x18A70E6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0xA712A40", Offset = "0xA711A40", VA = "0x18A712A40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0xA711140", Offset = "0xA710140", VA = "0x18A711140", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0xA712CB0", Offset = "0xA711CB0", VA = "0x18A712CB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0xA712500", Offset = "0xA711500", VA = "0x18A712500", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9D")]
			[Cpp2IlInjected.Address(RVA = "0xA7121E0", Offset = "0xA7111E0", VA = "0x18A7121E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9E")]
			[Cpp2IlInjected.Address(RVA = "0xA7121E0", Offset = "0xA7111E0", VA = "0x18A7121E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xA702BB0", Offset = "0xA701BB0", VA = "0x18A702BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		public bool MeshQuantizationAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xA702B50", Offset = "0xA701B50", VA = "0x18A702B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		public IEnumerable<string> ExtensionsUsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		public IEnumerable<string> ExtensionsRequired
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public IEnumerable<string> IncompatibleExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0xA702A00", Offset = "0xA701A00", VA = "0x18A702A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public IReadOnlyList<Material> LogicalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BE0", Offset = "0xCF6BE0", VA = "0x180CF7BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public IReadOnlyList<Texture> LogicalTextures
		{
			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0xDD3B70", Offset = "0xDD2B70", VA = "0x180DD3B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public IReadOnlyList<TextureSampler> LogicalTextureSamplers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0xD01440", Offset = "0xD00440", VA = "0x180D01440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public IReadOnlyList<Image> LogicalImages
		{
			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B90", Offset = "0xCF6B90", VA = "0x180CF7B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public IReadOnlyList<Buffer> LogicalBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public IReadOnlyList<BufferView> LogicalBufferViews
		{
			[Cpp2IlInjected.Token(Token = "0x6000A44")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public IReadOnlyList<Accessor> LogicalAccessors
		{
			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public IReadOnlyList<Mesh> LogicalMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A46")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B60", Offset = "0xCF6B60", VA = "0x180CF7B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public IReadOnlyList<Skin> LogicalSkins
		{
			[Cpp2IlInjected.Token(Token = "0x6000A47")]
			[Cpp2IlInjected.Address(RVA = "0xD01390", Offset = "0xD00390", VA = "0x180D01390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public IReadOnlyList<Camera> LogicalCameras
		{
			[Cpp2IlInjected.Token(Token = "0x6000A48")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public IReadOnlyList<Node> LogicalNodes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xD01A50", Offset = "0xD00A50", VA = "0x180D01A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public IReadOnlyList<Scene> LogicalScenes
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xD24A30", Offset = "0xD23A30", VA = "0x180D24A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public IReadOnlyList<Animation> LogicalAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public Scene DefaultScene
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0xA702950", Offset = "0xA701950", VA = "0x18A702950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0xA702C00", Offset = "0xA701C00", VA = "0x18A702C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public IReadOnlyList<PunctualLight> LogicalPunctualLights
		{
			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0xA702A90", Offset = "0xA701A90", VA = "0x18A702A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB3D0", Offset = "0xA6FA3D0", VA = "0x18A6FB3D0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA6FCEC0", Offset = "0xA6FBEC0", VA = "0x18A6FCEC0", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0xA6FD9F0", Offset = "0xA6FC9F0", VA = "0x18A6FD9F0", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xA6FD420", Offset = "0xA6FC420", VA = "0x18A6FD420", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0xA6FA1F0", Offset = "0xA6F91F0", VA = "0x18A6FA1F0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9420", Offset = "0xA6F8420", VA = "0x18A6F9420")]
		public Accessor CreateAccessor([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0xA6F94C0", Offset = "0xA6F84C0", VA = "0x18A6F94C0")]
		public Animation CreateAnimation([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xA6F96F0", Offset = "0xA6F86F0", VA = "0x18A6F96F0")]
		public Buffer CreateBuffer(int byteCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF620", Offset = "0xA6FE620", VA = "0x18A6FF620")]
		public Buffer UseBuffer(byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB790", Offset = "0xA6FA790", VA = "0x18A6FB790")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0xA6FBBE0", Offset = "0xA6FABE0", VA = "0x18A6FBBE0")]
		public void MergeBuffers(int maxSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB400", Offset = "0xA6FA400", VA = "0x18A6FB400")]
		public void IsolateMemory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9560", Offset = "0xA6F8560", VA = "0x18A6F9560")]
		public BufferView CreateBufferView(int byteSize, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0xA6FEF40", Offset = "0xA6FDF40", VA = "0x18A6FEF40")]
		public BufferView UseBufferView(ArraySegment<byte> data, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF140", Offset = "0xA6FE140", VA = "0x18A6FF140")]
		public BufferView UseBufferView(byte[] buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF240", Offset = "0xA6FE240", VA = "0x18A6FF240")]
		public BufferView UseBufferView(Buffer buffer, int byteOffset = 0, [Optional] int? byteLength, int byteStride = 0, [Optional] BufferMode? target)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xA6F97A0", Offset = "0xA6F87A0", VA = "0x18A6F97A0")]
		public Camera CreateCamera([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0xA6FED70", Offset = "0xA6FDD70", VA = "0x18A6FED70")]
		internal void UpdateExtensionsSupport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0xA6FA920", Offset = "0xA6F9920", VA = "0x18A6FA920")]
		internal IEnumerable<string> GatherUsedExtensions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0xA701BA0", Offset = "0xA700BA0", VA = "0x18A701BA0")]
		private void _SetExtensionUsage(string extension, bool used, bool required)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0xA701CC0", Offset = "0xA700CC0", VA = "0x18A701CC0")]
		internal void _ValidateExtensions(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9840", Offset = "0xA6F8840", VA = "0x18A6F9840")]
		public Image CreateImage([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xA6FF880", Offset = "0xA6FE880", VA = "0x18A6FF880")]
		public Image UseImage(MemoryImage imageContent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0xA6FC150", Offset = "0xA6FB150", VA = "0x18A6FC150")]
		public void MergeImages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9960", Offset = "0xA6F8960", VA = "0x18A6F9960")]
		public Material CreateMaterial([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9A00", Offset = "0xA6F8A00", VA = "0x18A6F9A00")]
		public Mesh CreateMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0xA700FB0", Offset = "0xA6FFFB0", VA = "0x18A700FB0")]
		internal Node _FindVisualParentNode(Node childNode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0xA6F98E0", Offset = "0xA6F88E0", VA = "0x18A6F98E0")]
		public Node CreateLogicalNode()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0xA700ED0", Offset = "0xA6FFED0", VA = "0x18A700ED0")]
		internal Node _CreateVisualNode(IList<int> parentChildren)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0xA6F8A20", Offset = "0xA6F7A20", VA = "0x18A6F8A20")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9B40", Offset = "0xA6F8B40", VA = "0x18A6F9B40")]
		public static ModelRoot CreateModel()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0xA7024D0", Offset = "0xA7014D0", VA = "0x18A7024D0")]
		internal ModelRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9DE0", Offset = "0xA6F8DE0", VA = "0x18A6F9DE0")]
		public ModelRoot DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3E")]
		[Cpp2IlInjected.Address(RVA = "0xDFC0C0", Offset = "0xDFB0C0", VA = "0x180DFC0C0", Slot = "16")]
		ModelRoot IConvertibleToGltf2.ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB140", Offset = "0xA6FA140", VA = "0x18A6FB140")]
		internal IEnumerable<ExtraProperties> GetLogicalChildrenFlattened()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0xA6FC360", Offset = "0xA6FB360", VA = "0x18A6FC360", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0xA6FC2F0", Offset = "0xA6FB2F0", VA = "0x18A6FC2F0", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9C10", Offset = "0xA6F8C10", VA = "0x18A6F9C10")]
		public PunctualLight CreatePunctualLight(PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9C70", Offset = "0xA6F8C70", VA = "0x18A6F9C70")]
		public PunctualLight CreatePunctualLight(string name, PunctualLightType lightType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFCA0", Offset = "0xA6FECA0", VA = "0x18A6FFCA0")]
		public Scene UseScene(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFB50", Offset = "0xA6FEB50", VA = "0x18A6FFB50")]
		public Scene UseScene(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0xA6F9CE0", Offset = "0xA6F8CE0", VA = "0x18A6F9CE0")]
		public Skin CreateSkin([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0xA6FFE50", Offset = "0xA6FEE50", VA = "0x18A6FFE50")]
		public TextureSampler UseTextureSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min, TextureInterpolationFilter mag)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0xA7002A0", Offset = "0xA6FF2A0", VA = "0x18A7002A0")]
		public Texture UseTexture(Image primary, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0xA7002D0", Offset = "0xA6FF2D0", VA = "0x18A7002D0")]
		public Texture UseTexture(Image primary, Image fallback, [Optional] TextureSampler sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0xA700660", Offset = "0xA6FF660", VA = "0x18A700660")]
		public static ValidationResult Validate(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB5B0", Offset = "0xA6FA5B0", VA = "0x18A6FB5B0")]
		public static ModelRoot Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0xA6FC520", Offset = "0xA6FB520", VA = "0x18A6FC520")]
		public static ModelRoot ParseGLB(ArraySegment<byte> glb, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0xA6FCCD0", Offset = "0xA6FBCD0", VA = "0x18A6FCCD0")]
		public static ModelRoot ReadGLB(Stream stream, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB270", Offset = "0xA6FA270", VA = "0x18A6FB270")]
		public static string[] GetSatellitePaths(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0xA6FC700", Offset = "0xA6FB700", VA = "0x18A6FC700")]
		private static string[] ParseSatellitePaths(ReadOnlyMemory<byte> json)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		internal void OnDeserializationCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0xA7017B0", Offset = "0xA7007B0", VA = "0x18A7017B0")]
		internal void _ResolveSatelliteDependencies(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0xA6FD320", Offset = "0xA6FC320", VA = "0x18A6FD320")]
		public void Save(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xA6FCF40", Offset = "0xA6FBF40", VA = "0x18A6FCF40")]
		public void SaveGLB(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0xA6FD130", Offset = "0xA6FC130", VA = "0x18A6FD130")]
		public void SaveGLTF(string filePath, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB130", Offset = "0xA6FA130", VA = "0x18A6FB130")]
		[Obsolete("Use GetJsonPreview", true)]
		public string GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A66")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB130", Offset = "0xA6FA130", VA = "0x18A6FB130")]
		public string GetJsonPreview()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0xA7010B0", Offset = "0xA7000B0", VA = "0x18A7010B0")]
		internal string _GetJSON(bool indented)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0xA7007B0", Offset = "0xA6FF7B0", VA = "0x18A7007B0")]
		public ArraySegment<byte> WriteGLB([Optional] WriteSettings settings)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0xA7009F0", Offset = "0xA6FF9F0", VA = "0x18A7009F0")]
		public void WriteGLB(Stream stream, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0xA702130", Offset = "0xA701130", VA = "0x18A702130")]
		internal void _WriteJSON(Stream sw, JsonWriterOptions options, JsonFilterCallback filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0xA7013D0", Offset = "0xA7003D0", VA = "0x18A7013D0")]
		internal void _PrepareBuffersForSatelliteWriting(WriteContext context, string baseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0xA701320", Offset = "0xA700320", VA = "0x18A701320")]
		internal void _PrepareBuffersForInternalWriting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0xA701520", Offset = "0xA700520", VA = "0x18A701520")]
		internal void _PrepareImagesForWriting(WriteContext context, string baseName, bool isBinary, ResourceWriteMode rmode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0xA700B40", Offset = "0xA6FFB40", VA = "0x18A700B40")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABD")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0xA72D350", Offset = "0xA72C350", VA = "0x18A72D350", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0xA72CF70", Offset = "0xA72BF70", VA = "0x18A72CF70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0xA72D410", Offset = "0xA72C410", VA = "0x18A72D410")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0xA72D310", Offset = "0xA72C310", VA = "0x18A72D310", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0xA72D270", Offset = "0xA72C270", VA = "0x18A72D270", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(RVA = "0xA72D270", Offset = "0xA72C270", VA = "0x18A72D270", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6F7610", Offset = "0xA6F6610", VA = "0x18A6F7610")]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6660", Offset = "0xA6F5660", VA = "0x18A6F6660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AA8")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BE0", Offset = "0xCF6BE0", VA = "0x180CF7BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AA9")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B80", Offset = "0xCF6B80", VA = "0x180CF7B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		internal int _SourceBufferViewIndex
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAA")]
			[Cpp2IlInjected.Address(RVA = "0xA6F7840", Offset = "0xA6F6840", VA = "0x18A6F7840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		internal bool _HasContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000AAB")]
			[Cpp2IlInjected.Address(RVA = "0xA6F77A0", Offset = "0xA6F67A0", VA = "0x18A6F77A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0xA6F61F0", Offset = "0xA6F51F0", VA = "0x18A6F61F0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6530", Offset = "0xA6F5530", VA = "0x18A6F6530", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__2))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6A50", Offset = "0xA6F5A50", VA = "0x18A6F6A50", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xA6F65B0", Offset = "0xA6F55B0", VA = "0x18A6F65B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0xA6F5F30", Offset = "0xA6F4F30", VA = "0x18A6F5F30", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6E40", Offset = "0xA6F5E40", VA = "0x18A6F6E40")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0xA6E1410", Offset = "0xA6E0410", VA = "0x18A6E1410")]
		internal Image()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6050", Offset = "0xA6F5050", VA = "0x18A6F6050")]
		private MemoryImage GetSatelliteContent()
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6660", Offset = "0xA6F5660", VA = "0x18A6F6660")]
		private void SetSatelliteContent(MemoryImage content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAE")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6770", Offset = "0xA6F5770", VA = "0x18A6F6770")]
		internal void TransferToInternalBuffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAF")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6F60", Offset = "0xA6F5F60", VA = "0x18A6F6F60")]
		internal void _ResolveUri(ReadContext context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB0")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6F10", Offset = "0xA6F5F10", VA = "0x18A6F6F10")]
		internal void _DiscardContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0xA6F7250", Offset = "0xA6F6250", VA = "0x18A6F7250")]
		internal void _WriteToInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0xA6F7350", Offset = "0xA6F6350", VA = "0x18A6F7350")]
		internal void _WriteToSatellite(WriteContext writer, string satelliteUri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0xA6F7120", Offset = "0xA6F6120", VA = "0x18A6F7120")]
		private void _WriteAsBufferView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6E00", Offset = "0xA6F5E00", VA = "0x18A6F6E00")]
		internal void _ClearAfterWrite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0xA6F63A0", Offset = "0xA6F53A0", VA = "0x18A6F63A0", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xA6F6220", Offset = "0xA6F5220", VA = "0x18A6F6220", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACC")]
			[Cpp2IlInjected.Address(RVA = "0xA735640", Offset = "0xA734640", VA = "0x18A735640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA7355B0", Offset = "0xA7345B0", VA = "0x18A7355B0")]
		public _StaticBufferBuilder(int bufferIndex, int initialCapacity = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA7353B0", Offset = "0xA7343B0", VA = "0x18A7353B0")]
		public int Append(byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA735510", Offset = "0xA734510", VA = "0x18A735510")]
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
			[Cpp2IlInjected.Address(RVA = "0x4143AF0", Offset = "0x4142AF0", VA = "0x184143AF0")]
			public static ExtensionEntry Create<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
			{
				return default(ExtensionEntry);
			}

			[Cpp2IlInjected.Token(Token = "0x6000AD9")]
			[Cpp2IlInjected.Address(RVA = "0x23E1B20", Offset = "0x23E0B20", VA = "0x1823E1B20")]
			public ExtensionEntry(string n, Type p, Type e, Func<JsonSerializable, JsonSerializable> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADA")]
			[Cpp2IlInjected.Address(RVA = "0xA716880", Offset = "0xA715880", VA = "0x18A716880")]
			public bool IsMatch(Type parentType, string extensionName)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000ADB")]
			[Cpp2IlInjected.Address(RVA = "0xA716800", Offset = "0xA715800", VA = "0x18A716800")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7177F0", Offset = "0xA7167F0", VA = "0x18A7177F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA716C90", Offset = "0xA715C90", VA = "0x18A716C90")]
		static ExtensionsFactory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3AB9C40", Offset = "0x3AB8C40", VA = "0x183AB9C40")]
		[Obsolete("Use RegisterExtension(name, factory) instead.")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x3AB9940", Offset = "0x3AB8940", VA = "0x183AB9940")]
		public static void RegisterExtension<TParent, TExtension>(string persistentName, Func<TParent, JsonSerializable> factory) where TParent : JsonSerializable where TExtension : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA7168E0", Offset = "0xA7158E0", VA = "0x18A7168E0")]
		internal static JsonSerializable Create(JsonSerializable parent, string extensionName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0xA716AB0", Offset = "0xA715AB0", VA = "0x18A716AB0")]
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
					[Cpp2IlInjected.Address(RVA = "0x5088B00", Offset = "0x5087B00", VA = "0x185088B00", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xA72C450", Offset = "0xA72B450", VA = "0x18A72C450", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000B20")]
				[Cpp2IlInjected.Address(RVA = "0x667DA70", Offset = "0x667CA70", VA = "0x18667DA70")]
				[DebuggerHidden]
				public <GetFields>d__3(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B21")]
				[Cpp2IlInjected.Address(RVA = "0xA72C4A0", Offset = "0xA72B4A0", VA = "0x18A72C4A0", Slot = "7")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B22")]
				[Cpp2IlInjected.Address(RVA = "0xA72C020", Offset = "0xA72B020", VA = "0x18A72C020", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000B23")]
				[Cpp2IlInjected.Address(RVA = "0xA72C560", Offset = "0xA72B560", VA = "0x18A72C560")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B25")]
				[Cpp2IlInjected.Address(RVA = "0xA72C410", Offset = "0xA72B410", VA = "0x18A72C410", Slot = "10")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000B27")]
				[Cpp2IlInjected.Address(RVA = "0xA72C370", Offset = "0xA72B370", VA = "0x18A72C370", Slot = "4")]
				[DebuggerHidden]
				IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000B28")]
				[Cpp2IlInjected.Address(RVA = "0xA72C370", Offset = "0xA72B370", VA = "0x18A72C370", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
			public _ExtensionsReflection(IReadOnlyList<JsonSerializable> extensions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B18")]
			[Cpp2IlInjected.Address(RVA = "0xA733D50", Offset = "0xA732D50", VA = "0x18A733D50", Slot = "5")]
			public bool TryGetField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B19")]
			[Cpp2IlInjected.Address(RVA = "0xA733CD0", Offset = "0xA732CD0", VA = "0x18A733CD0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B35")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <Flatten>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B36")]
			[Cpp2IlInjected.Address(RVA = "0xA72BD00", Offset = "0xA72AD00", VA = "0x18A72BD00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B37")]
			[Cpp2IlInjected.Address(RVA = "0xA72B880", Offset = "0xA72A880", VA = "0x18A72B880", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0xA72BEA0", Offset = "0xA72AEA0", VA = "0x18A72BEA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0xA72BEF0", Offset = "0xA72AEF0", VA = "0x18A72BEF0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0xA72BCC0", Offset = "0xA72ACC0", VA = "0x18A72BCC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3D")]
			[Cpp2IlInjected.Address(RVA = "0xA72BC20", Offset = "0xA72AC20", VA = "0x18A72BC20", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3E")]
			[Cpp2IlInjected.Address(RVA = "0xA72BC20", Offset = "0xA72AC20", VA = "0x18A72BC20", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B3F")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <GetLogicalChildren>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B40")]
			[Cpp2IlInjected.Address(RVA = "0xA72CD30", Offset = "0xA72BD30", VA = "0x18A72CD30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B41")]
			[Cpp2IlInjected.Address(RVA = "0xA72C5B0", Offset = "0xA72B5B0", VA = "0x18A72C5B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0xA72CED0", Offset = "0xA72BED0", VA = "0x18A72CED0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0xA72CF20", Offset = "0xA72BF20", VA = "0x18A72CF20")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B45")]
			[Cpp2IlInjected.Address(RVA = "0xA72CCF0", Offset = "0xA72BCF0", VA = "0x18A72CCF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B47")]
			[Cpp2IlInjected.Address(RVA = "0xA72CC50", Offset = "0xA72BC50", VA = "0x18A72CC50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ExtraProperties> IEnumerable<ExtraProperties>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B48")]
			[Cpp2IlInjected.Address(RVA = "0xA72CC50", Offset = "0xA72BC50", VA = "0x18A72CC50", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B49")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <ReflectFieldsNames>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4A")]
			[Cpp2IlInjected.Address(RVA = "0xA72D860", Offset = "0xA72C860", VA = "0x18A72D860", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4B")]
			[Cpp2IlInjected.Address(RVA = "0xA72D460", Offset = "0xA72C460", VA = "0x18A72D460", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4C")]
			[Cpp2IlInjected.Address(RVA = "0xA72D920", Offset = "0xA72C920", VA = "0x18A72D920")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0xA72D820", Offset = "0xA72C820", VA = "0x18A72D820", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B50")]
			[Cpp2IlInjected.Address(RVA = "0xA72D780", Offset = "0xA72C780", VA = "0x18A72D780", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0xA72D780", Offset = "0xA72C780", VA = "0x18A72D780", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "14")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B02")]
			[Cpp2IlInjected.Address(RVA = "0xA718CF0", Offset = "0xA717CF0", VA = "0x18A718CF0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0xA717BE0", Offset = "0xA716BE0", VA = "0x18A717BE0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0xA718230", Offset = "0xA717230", VA = "0x18A718230", Slot = "11")]
		[IteratorStateMachine(typeof(<ReflectFieldsNames>d__9))]
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0xA718370", Offset = "0xA717370", VA = "0x18A718370", Slot = "12")]
		protected override bool TryReflectField(string name, [Out] SharpGLTF.Reflection.FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0xA717B60", Offset = "0xA716B60", VA = "0x18A717B60")]
		[IteratorStateMachine(typeof(<GetLogicalChildren>d__11))]
		protected IEnumerable<ExtraProperties> GetLogicalChildren()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B07")]
		[Cpp2IlInjected.Address(RVA = "0xA717AE0", Offset = "0xA716AE0", VA = "0x18A717AE0")]
		[IteratorStateMachine(typeof(<Flatten>d__12))]
		protected static IEnumerable<ExtraProperties> Flatten(ExtraProperties container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x3ABC720", Offset = "0x3ABB720", VA = "0x183ABC720")]
		protected static void SetProperty<TParent, TProperty, TValue>(TParent parent, TProperty property, TValue value) where TParent : ExtraProperties where TProperty : class where TValue : TProperty
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x3ABC080", Offset = "0x3ABB080", VA = "0x183ABC080")]
		protected static ChildSetter<T> GetChildSetter<T>(T owner) where T : ExtraProperties
		{
			return default(ChildSetter<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x3ABC0D0", Offset = "0x3ABB0D0", VA = "0x183ABC0D0")]
		public T GetExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x3ABC7A0", Offset = "0x3ABB7A0", VA = "0x183ABC7A0")]
		public T UseExtension<T>() where T : JsonSerializable
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x3ABC3B0", Offset = "0x3ABB3B0", VA = "0x183ABC3B0")]
		public void SetExtension<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x3ABC120", Offset = "0x3ABB120", VA = "0x183ABC120")]
		public void RemoveExtensions<T>(T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x3ABC210", Offset = "0x3ABB210", VA = "0x183ABC210")]
		public void RemoveExtensions<T>() where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0xA717E20", Offset = "0xA716E20", VA = "0x18A717E20", Slot = "4")]
		protected override void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0xA717C10", Offset = "0xA716C10", VA = "0x18A717C10", Slot = "5")]
		protected override void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0xA7182B0", Offset = "0xA7172B0", VA = "0x18A7182B0", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0xA7189A0", Offset = "0xA7179A0", VA = "0x18A7189A0")]
		private static Dictionary<string, JsonSerializable> _ToDictionary(JsonSerializable context, IEnumerable<JsonSerializable> serializables)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0xA7179B0", Offset = "0xA7169B0", VA = "0x18A7179B0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0xA7186C0", Offset = "0xA7176C0", VA = "0x18A7186C0")]
		private static void _DeserializeExtensions(JsonSerializable parent, Utf8JsonReader reader, List<JsonSerializable> extensions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0xA718C70", Offset = "0xA717C70", VA = "0x18A718C70")]
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
			[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public string Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000B59")]
			[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public bool HasDefaultContent
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5A")]
			[Cpp2IlInjected.Address(RVA = "0xA71CEF0", Offset = "0xA71BEF0", VA = "0x18A71CEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA71CF00", Offset = "0xA71BF00", VA = "0x18A71CF00")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xA71D2A0", Offset = "0xA71C2A0", VA = "0x18A71D2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public IReadOnlyList<IMaterialParameter> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public Texture Texture
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0xA71CFE0", Offset = "0xA71BFE0", VA = "0x18A71CFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public TextureSampler TextureSampler
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0xA71CF70", Offset = "0xA71BF70", VA = "0x18A71CF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0xA71CF60", Offset = "0xA71BF60", VA = "0x18A71CF60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0xA71CFA0", Offset = "0xA71BFA0", VA = "0x18A71CFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public Vector4 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0xA71CCC0", Offset = "0xA71BCC0", VA = "0x18A71CCC0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0xA71D070", Offset = "0xA71C070", VA = "0x18A71D070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0xA71CAA0", Offset = "0xA71BAA0", VA = "0x18A71CAA0")]
		internal MaterialChannel(Material m, string key, _MaterialTexture texInfo, params IMaterialParameter[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0xA71C2F0", Offset = "0xA71B2F0", VA = "0x18A71C2F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0xA71C0C0", Offset = "0xA71B0C0", VA = "0x18A71C0C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0xA71C180", Offset = "0xA71B180", VA = "0x18A71C180", Slot = "4")]
		public bool Equals(MaterialChannel other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0xA71CFF0", Offset = "0xA71BFF0", VA = "0x18A71CFF0")]
		public static bool operator ==([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0xA71D030", Offset = "0xA71C030", VA = "0x18A71D030")]
		public static bool operator !=([In] MaterialChannel a, [In] MaterialChannel b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0xA71C1C0", Offset = "0xA71B1C0", VA = "0x18A71C1C0")]
		public float GetFactor(string key)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0xA71C350", Offset = "0xA71B350", VA = "0x18A71C350")]
		public void SetFactor(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0xA71C9A0", Offset = "0xA71B9A0", VA = "0x18A71C9A0")]
		private Texture _GetTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0xA71C490", Offset = "0xA71B490", VA = "0x18A71C490")]
		public Texture SetTexture(int texCoord, Image primaryImg, [Optional] Image fallbackImg, TextureWrapMode ws = TextureWrapMode.REPEAT, TextureWrapMode wt = TextureWrapMode.REPEAT, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0xA71C640", Offset = "0xA71B640", VA = "0x18A71C640")]
		public void SetTexture(int texSet, Texture tex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0xA71C790", Offset = "0xA71B790", VA = "0x18A71C790")]
		public void SetTransform(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? texCoordOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0xA71C860", Offset = "0xA71B860", VA = "0x18A71C860")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D6CC50", Offset = "0x3D6BC50", VA = "0x183D6CC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public TextureInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000B76")]
			[Cpp2IlInjected.Address(RVA = "0xA734190", Offset = "0xA733190", VA = "0x18A734190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public int TextureCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000B77")]
			[Cpp2IlInjected.Address(RVA = "0xA7341B0", Offset = "0xA7331B0", VA = "0x18A7341B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public TextureTransform TextureTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0xA734240", Offset = "0xA733240", VA = "0x18A734240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0xA734280", Offset = "0xA733280", VA = "0x18A734280")]
		public static implicit operator _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
			return default(_MaterialTexture);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0xA733F90", Offset = "0xA732F90", VA = "0x18A733F90")]
		public _MaterialTexture(Func<TextureInfo> getter, Action initialize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0xA734080", Offset = "0xA733080", VA = "0x18A734080")]
		public _MaterialTexture(Func<bool, TextureInfo> getOrUse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xA733F70", Offset = "0xA732F70", VA = "0x18A733F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x516C280", Offset = "0x516B280", VA = "0x18516C280", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x516BDD0", Offset = "0x516ADD0", VA = "0x18516BDD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000B87")]
			[Cpp2IlInjected.Address(RVA = "0x516C690", Offset = "0x516B690", VA = "0x18516C690", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x516C950", Offset = "0x516B950", VA = "0x18516C950")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x516CB80", Offset = "0x516BB80", VA = "0x18516CB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		object IMaterialParameter.Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0x516A9D0", Offset = "0x51699D0", VA = "0x18516A9D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8B")]
			[Cpp2IlInjected.Address(RVA = "0x516AE30", Offset = "0x5169E30", VA = "0x18516AE30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B84")]
		[Cpp2IlInjected.Address(RVA = "0x516B7F0", Offset = "0x516A7F0", VA = "0x18516B7F0")]
		internal _MaterialParameter(_MaterialParameterKey key, T defval, Func<T> getter, Action<T> setter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x5169950", Offset = "0x5168950", VA = "0x185169950")]
		internal static Vector4 Combine(IReadOnlyList<IMaterialParameter> parameters)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x5167650", Offset = "0x5166650", VA = "0x185167650")]
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
			[Cpp2IlInjected.Address(RVA = "0xA727C60", Offset = "0xA726C60", VA = "0x18A727C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		public bool HasMorphingCurves
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0xE06980", Offset = "0xE05980", VA = "0x180E06980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public IAnimationSampler<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public IAnimationSampler<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public IAnimationSampler<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
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
			[Cpp2IlInjected.Address(RVA = "0xA727CC0", Offset = "0xA726CC0", VA = "0x18A727CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA727C80", Offset = "0xA726C80", VA = "0x18A727C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public IAnimationSampler<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0xA727740", Offset = "0xA726740", VA = "0x18A727740")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0xA7278F0", Offset = "0xA7268F0", VA = "0x18A7278F0")]
		internal NodeCurveSamplers(Node node, Animation animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9C40", Offset = "0x7EC8C40", VA = "0x187EC9C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0xA726FC0", Offset = "0xA725FC0", VA = "0x18A726FC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0xA727D00", Offset = "0xA726D00", VA = "0x18A727D00")]
		public static bool operator ==([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0xA727D30", Offset = "0xA726D30", VA = "0x18A727D30")]
		public static bool operator !=([In] NodeCurveSamplers a, [In] NodeCurveSamplers b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0xA726F90", Offset = "0xA725F90", VA = "0x18A726F90", Slot = "4")]
		public bool Equals(NodeCurveSamplers other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x386C050", Offset = "0x386B050", VA = "0x18386C050")]
		public IAnimationSampler<TWeights> GetMorphingSampler<TWeights>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0xA727040", Offset = "0xA726040", VA = "0x18A727040")]
		public AffineTransform GetLocalTransform(float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x3D58040", Offset = "0x3D57040", VA = "0x183D58040")]
		public IReadOnlyList<float> GetMorphingWeights<TWeight>(float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0xA7274F0", Offset = "0xA7264F0", VA = "0x18A7274F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA733160", Offset = "0xA732160", VA = "0x18A733160")]
		public static Memory<byte> ReadBytesToEnd(this Stream s)
		{
			return default(Memory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0xA733C80", Offset = "0xA732C80", VA = "0x18A733C80")]
		internal static bool _TryReadUInt32(this BinaryReader r, [Out] uint result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0xA7337C0", Offset = "0xA7327C0", VA = "0x18A7337C0")]
		internal static bool _Identify(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0xA732B10", Offset = "0xA731B10", VA = "0x18A732B10")]
		internal static bool IsBinaryHeader(ReadOnlySpan<byte> span)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0xA732BA0", Offset = "0xA731BA0", VA = "0x18A732BA0")]
		public static bool IsBinaryHeader(byte a, byte b, byte c, byte d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0xA732BD0", Offset = "0xA731BD0", VA = "0x18A732BD0")]
		public static IReadOnlyDictionary<uint, byte[]> ReadBinaryFile(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0xA733980", Offset = "0xA732980", VA = "0x18A733980")]
		private static long _ReadBinaryHeader(BinaryReader binaryReader)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0xA732990", Offset = "0xA731990", VA = "0x18A732990")]
		public static Exception IsBinaryCompatible(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0xA733490", Offset = "0xA732490", VA = "0x18A733490")]
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
			[Cpp2IlInjected.Address(RVA = "0xF57640", Offset = "0xF56640", VA = "0x180F57640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(RVA = "0xF57520", Offset = "0xF56520", VA = "0x180F57520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0xA728920", Offset = "0xA727920", VA = "0x18A728920")]
		public static ReadContext Create(FileReaderCallback callback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0xA728660", Offset = "0xA727660", VA = "0x18A728660")]
		public static ReadContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0xA7284E0", Offset = "0xA7274E0", VA = "0x18A7284E0")]
		public static ReadContext CreateFromDictionary(IReadOnlyDictionary<string, ArraySegment<byte>> dictionary, bool checkExtensions = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0xA72ACD0", Offset = "0xA729CD0", VA = "0x18A72ACD0")]
		private ReadContext(FileReaderCallback reader, [Optional] UriResolver uriResolver, bool checkExtensions = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0xA729DE0", Offset = "0xA728DE0", VA = "0x18A729DE0")]
		public ReadContext WithSettingsFrom(ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0xA72AD40", Offset = "0xA729D40", VA = "0x18A72AD40")]
		internal ReadContext(ReadContext other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0xA7299F0", Offset = "0xA7289F0", VA = "0x18A7299F0")]
		public bool TryGetFullPath(string relativeUri, [Out] string fullPath)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0xA728AE0", Offset = "0xA727AE0", VA = "0x18A728AE0")]
		public Stream OpenFile(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0xA728C10", Offset = "0xA727C10", VA = "0x18A728C10")]
		public ArraySegment<byte> ReadAllBytesToEnd(string resourceName)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0xA729A50", Offset = "0xA728A50", VA = "0x18A729A50")]
		public ValidationResult Validate(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0xA729250", Offset = "0xA728250", VA = "0x18A729250")]
		public ModelRoot ReadSchema2(string resourceName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0xA7294B0", Offset = "0xA7284B0", VA = "0x18A7294B0")]
		public ModelRoot ReadSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0xA729820", Offset = "0xA728820", VA = "0x18A729820")]
		public ModelRoot ReadTextSchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0xA728CD0", Offset = "0xA727CD0", VA = "0x18A728CD0")]
		public ModelRoot ReadBinarySchema2(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0xA729EC0", Offset = "0xA728EC0", VA = "0x18A729EC0")]
		private static ModelRoot _FilterErrors((ModelRoot Model, ValidationResult Validation) mv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0xA72A080", Offset = "0xA729080", VA = "0x18A72A080")]
		private (ModelRoot, ValidationResult) _ReadGLB(Stream stream)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0xA72A4C0", Offset = "0xA7294C0", VA = "0x18A72A4C0")]
		private (ModelRoot, ValidationResult) _Read(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default((ModelRoot, ValidationResult));
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0xA729F40", Offset = "0xA728F40", VA = "0x18A729F40")]
		private ReadOnlyMemory<byte> _Preprocess(ReadOnlyMemory<byte> jsonUtf8Bytes)
		{
			return default(ReadOnlyMemory<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0xA728A30", Offset = "0xA727A30", VA = "0x18A728A30")]
		public static bool IdentifyBinaryContainer(Stream stream)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0xA729000", Offset = "0xA728000", VA = "0x18A729000")]
		public static string ReadJson(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0xA728E60", Offset = "0xA727E60", VA = "0x18A728E60")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4110", Offset = "0xCF3110", VA = "0x180CF4110")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE1")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA30", Offset = "0xCFAA30", VA = "0x180CFBA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public ImageDecodeCallback ImageDecoder
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE3")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public JsonFilterCallback JsonPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0xA72B0A0", Offset = "0xA72A0A0", VA = "0x18A72B0A0")]
		public static implicit operator ReadSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0xA72B090", Offset = "0xA72A090", VA = "0x18A72B090")]
		public ReadSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0xA72AF70", Offset = "0xA729F70", VA = "0x18A72AF70")]
		public ReadSettings(ReadSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0xA72AE90", Offset = "0xA729E90", VA = "0x18A72AE90")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E60", Offset = "0xCF6E60", VA = "0x180CF7E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		internal bool _UpdateSupportedExtensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFA")]
			[Cpp2IlInjected.Address(RVA = "0xCFC310", Offset = "0xCFB310", VA = "0x180CFC310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFB")]
			[Cpp2IlInjected.Address(RVA = "0xCFC300", Offset = "0xCFB300", VA = "0x180CFC300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		internal bool _NoCloneWatchdog
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFC")]
			[Cpp2IlInjected.Address(RVA = "0xCFC370", Offset = "0xCFB370", VA = "0x180CFC370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BFD")]
			[Cpp2IlInjected.Address(RVA = "0xCFC250", Offset = "0xCFB250", VA = "0x180CFC250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0xA731270", Offset = "0xA730270", VA = "0x18A731270")]
		public static WriteContext Create(FileWriterCallback fileCallback, [Optional] Func<string, Stream> streamWriteCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0xA730DF0", Offset = "0xA72FDF0", VA = "0x18A730DF0")]
		public static WriteContext CreateFromDirectory(DirectoryInfo dinfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0xA730C20", Offset = "0xA72FC20", VA = "0x18A730C20")]
		public static WriteContext CreateFromDictionary(IDictionary<string, ArraySegment<byte>> dict)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0xA731030", Offset = "0xA730030", VA = "0x18A731030")]
		public static WriteContext CreateFromStream(Stream stream)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0xA731410", Offset = "0xA730410", VA = "0x18A731410")]
		public WriteContext WithTextSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0xA731390", Offset = "0xA730390", VA = "0x18A731390")]
		public WriteContext WithBinarySettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0xA7313E0", Offset = "0xA7303E0", VA = "0x18A7313E0")]
		public WriteContext WithSettingsFrom(WriteSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0xA7313D0", Offset = "0xA7303D0", VA = "0x18A7313D0")]
		internal WriteContext WithDeepCloneSettings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0xA732690", Offset = "0xA731690", VA = "0x18A732690")]
		private WriteContext(FileWriterCallback byteWriteCallback, Func<string, Stream> streamWriteCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0xA731430", Offset = "0xA730430", VA = "0x18A731430")]
		public void WriteAllBytesToEnd(string fileName, ArraySegment<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0xA731A30", Offset = "0xA730A30", VA = "0x18A731A30")]
		public string WriteImage(string assetName, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0xA731C60", Offset = "0xA730C60", VA = "0x18A731C60")]
		public void WriteTextSchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0xA731470", Offset = "0xA730470", VA = "0x18A731470")]
		public void WriteBinarySchema2(string name, ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0xA732510", Offset = "0xA731510", VA = "0x18A732510")]
		private void _ValidateBeforeWriting(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0xA732100", Offset = "0xA731100", VA = "0x18A732100")]
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
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
			[CompilerGenerated]
			get
			{
				return default(ResourceWriteMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0xD4BEA0", Offset = "0xD4AEA0", VA = "0x180D4BEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public ImageWriterCallback ImageWriteCallback
		{
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x6000C15")]
			[Cpp2IlInjected.Address(RVA = "0xD4F720", Offset = "0xD4E720", VA = "0x180D4F720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C16")]
			[Cpp2IlInjected.Address(RVA = "0xD4F620", Offset = "0xD4E620", VA = "0x180D4F620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public int BuffersMaxSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000C17")]
			[Cpp2IlInjected.Address(RVA = "0xD45120", Offset = "0xD44120", VA = "0x180D45120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C18")]
			[Cpp2IlInjected.Address(RVA = "0x16DE810", Offset = "0x16DD810", VA = "0x1816DE810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public bool JsonIndented
		{
			[Cpp2IlInjected.Token(Token = "0x6000C19")]
			[Cpp2IlInjected.Address(RVA = "0xA732900", Offset = "0xA731900", VA = "0x18A732900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1A")]
			[Cpp2IlInjected.Address(RVA = "0xA732980", Offset = "0xA731980", VA = "0x18A732980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public JsonWriterOptions JsonOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1B")]
			[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00")]
			get
			{
				return default(JsonWriterOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1C")]
			[Cpp2IlInjected.Address(RVA = "0x4B74CE0", Offset = "0x4B73CE0", VA = "0x184B74CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public ValidationMode Validation
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1D")]
			[Cpp2IlInjected.Address(RVA = "0xD24DA0", Offset = "0xD23DA0", VA = "0x180D24DA0")]
			[CompilerGenerated]
			get
			{
				return default(ValidationMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C1E")]
			[Cpp2IlInjected.Address(RVA = "0xDEFC00", Offset = "0xDEEC00", VA = "0x180DEFC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public JsonFilterCallback JsonPostprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x6000C1F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C20")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF3370", VA = "0x180CF4370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0xA732910", Offset = "0xA731910", VA = "0x18A732910")]
		public static implicit operator WriteSettings(ValidationMode vmode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0xA732800", Offset = "0xA731800", VA = "0x18A732800")]
		public WriteSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0xA732820", Offset = "0xA731820", VA = "0x18A732820")]
		public WriteSettings(WriteSettings other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0xA732700", Offset = "0xA731700", VA = "0x18A732700")]
		public void CopyTo(WriteSettings other)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	internal static class _Schema2Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0xA734D50", Offset = "0xA733D50", VA = "0x18A734D50")]
		public static void SetMorphWeights(this IList<double> list, int maxCount, SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0xA734790", Offset = "0xA733790", VA = "0x18A734790")]
		public static void SetMorphWeights(this IList<double> list, IReadOnlyList<float> weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0xA7342A0", Offset = "0xA7332A0", VA = "0x18A7342A0")]
		internal static string AsName(this string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x413FBC0", Offset = "0x413EBC0", VA = "0x18413FBC0")]
		internal static T AsValue<T>(this T? value, T defval) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x413E980", Offset = "0x413D980", VA = "0x18413E980")]
		internal static T? AsNullable<T>(this T value, T defval) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x413EA30", Offset = "0x413DA30", VA = "0x18413EA30")]
		internal static T? AsNullable<T>(this T value, T defval, T minval, T maxval) where T : struct, IEquatable<T>, IComparable<T>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0xA7342D0", Offset = "0xA7332D0", VA = "0x18A7342D0")]
		internal static Vector2? AsNullable(this Vector2 value, Vector2 defval, Vector2 minval, Vector2 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0xA734400", Offset = "0xA733400", VA = "0x18A734400")]
		internal static Vector3? AsNullable(this Vector3 value, Vector3 defval, Vector3 minval, Vector3 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0xA734590", Offset = "0xA733590", VA = "0x18A734590")]
		internal static Vector4? AsNullable(this Vector4 value, Vector4 defval, Vector4 minval, Vector4 maxval)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0xA734760", Offset = "0xA733760", VA = "0x18A734760")]
		internal static string AsNullable(this string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0xA7342A0", Offset = "0xA7332A0", VA = "0x18A7342A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
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
			[Cpp2IlInjected.Address(RVA = "0xA719070", Offset = "0xA718070", VA = "0x18A719070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
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
			[Cpp2IlInjected.Address(RVA = "0xA719080", Offset = "0xA718080", VA = "0x18A719080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2D")]
		[Cpp2IlInjected.Address(RVA = "0xA718F10", Offset = "0xA717F10", VA = "0x18A718F10")]
		public static void Verify(IReflectionObject reflectionObject, string path)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2E")]
		[Cpp2IlInjected.Address(RVA = "0xA718D30", Offset = "0xA717D30", VA = "0x18A718D30")]
		public static FieldInfo From(IReflectionObject reflectionObject, string path)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8920", Offset = "0x3AD7920", VA = "0x183AD8920")]
		public static FieldInfo From<TInstance, TValue>(string name, TInstance instance, Func<TInstance, TValue> getter)
		{
			return default(FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0xA719000", Offset = "0xA718000", VA = "0x18A719000")]
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
				[Cpp2IlInjected.Address(RVA = "0x5088B00", Offset = "0x5087B00", VA = "0x185088B00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA72DCB0", Offset = "0xA72CCB0", VA = "0x18A72DCB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C44")]
			[Cpp2IlInjected.Address(RVA = "0x667DA70", Offset = "0x667CA70", VA = "0x18667DA70")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C45")]
			[Cpp2IlInjected.Address(RVA = "0xA72DD00", Offset = "0xA72CD00", VA = "0x18A72DD00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0xA72D970", Offset = "0xA72C970", VA = "0x18A72D970", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0xA72DDC0", Offset = "0xA72CDC0", VA = "0x18A72DDC0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0xA72DC70", Offset = "0xA72CC70", VA = "0x18A72DC70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4B")]
			[Cpp2IlInjected.Address(RVA = "0xA72DBD0", Offset = "0xA72CBD0", VA = "0x18A72DBD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<FieldInfo> IEnumerable<FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0xA72DBD0", Offset = "0xA72CBD0", VA = "0x18A72DBD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public const string SCHEMANAME = "Object";

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0xA71BFE0", Offset = "0xA71AFE0", VA = "0x18A71BFE0", Slot = "6")]
		protected override string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0xA718620", Offset = "0xA717620", VA = "0x18A718620", Slot = "11")]
		protected virtual IEnumerable<string> ReflectFieldsNames()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0xA71C0B0", Offset = "0xA71B0B0", VA = "0x18A71C0B0", Slot = "12")]
		protected virtual bool TryReflectField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0xA71C010", Offset = "0xA71B010", VA = "0x18A71C010", Slot = "9")]
		[IteratorStateMachine(typeof(<SharpGLTF-Reflection-IReflectionObject-GetFields>d__4))]
		IEnumerable<FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0xA71C090", Offset = "0xA71B090", VA = "0x18A71C090", Slot = "10")]
		bool IReflectionObject.TryGetField(string name, [Out] FieldInfo value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
		protected override void SerializeProperties(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0xA71BFD0", Offset = "0xA71AFD0", VA = "0x18A71BFD0", Slot = "8")]
		protected override void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
			[Cpp2IlInjected.Address(RVA = "0xA715050", Offset = "0xA714050", VA = "0x18A715050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0xA714A60", Offset = "0xA713A60", VA = "0x18A714A60")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0xA7151B0", Offset = "0xA7141B0", VA = "0x18A7151B0")]
		public static implicit operator AttributeFormat(IndexEncodingType indexer)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0xA7150E0", Offset = "0xA7140E0", VA = "0x18A7150E0")]
		public static implicit operator AttributeFormat(EncodingType enc)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0xA715160", Offset = "0xA714160", VA = "0x18A715160")]
		public static implicit operator AttributeFormat(DimensionType dim)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0xA715200", Offset = "0xA714200", VA = "0x18A715200")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0xA715120", Offset = "0xA714120", VA = "0x18A715120")]
		public static implicit operator AttributeFormat((DimensionType dim, EncodingType enc, bool nrm) fmt)
		{
			return default(AttributeFormat);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0xA714FB0", Offset = "0xA713FB0", VA = "0x18A714FB0")]
		public AttributeFormat(IndexEncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0xA714E60", Offset = "0xA713E60", VA = "0x18A714E60")]
		public AttributeFormat(EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0xA715000", Offset = "0xA714000", VA = "0x18A715000")]
		public AttributeFormat(DimensionType dim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0xA714EA0", Offset = "0xA713EA0", VA = "0x18A714EA0")]
		public AttributeFormat(DimensionType dim, EncodingType enc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0xA714EE0", Offset = "0xA713EE0", VA = "0x18A714EE0")]
		public AttributeFormat(DimensionType dim, EncodingType enc, bool nrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0xA7149F0", Offset = "0xA7139F0", VA = "0x18A7149F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0xA714850", Offset = "0xA713850", VA = "0x18A714850")]
		public static bool AreEqual(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0xA714870", Offset = "0xA713870", VA = "0x18A714870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0xA714960", Offset = "0xA713960", VA = "0x18A714960", Slot = "4")]
		public bool Equals(AttributeFormat other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0xA715060", Offset = "0xA714060", VA = "0x18A715060")]
		public static bool operator ==(AttributeFormat a, AttributeFormat b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0xA715250", Offset = "0xA714250", VA = "0x18A715250")]
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
			[Cpp2IlInjected.Address(RVA = "0xA716120", Offset = "0xA715120", VA = "0x18A716120")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000C64")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0xA715FF0", Offset = "0xA714FF0", VA = "0x18A715FF0", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C66")]
			[Cpp2IlInjected.Address(RVA = "0xA7161A0", Offset = "0xA7151A0", VA = "0x18A7161A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0xA715F90", Offset = "0xA714F90", VA = "0x18A715F90")]
		public ColorArray(Memory<byte> source, int byteStride = 0, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0xA715E30", Offset = "0xA714E30", VA = "0x18A715E30")]
		public ColorArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions = 4, EncodingType encoding = EncodingType.FLOAT, bool normalized = false, float defaultW = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0xA715AD0", Offset = "0xA714AD0", VA = "0x18A715AD0", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0xA715D70", Offset = "0xA714D70", VA = "0x18A715D70", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0xA7157F0", Offset = "0xA7147F0", VA = "0x18A7157F0", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0xA715B90", Offset = "0xA714B90", VA = "0x18A715B90", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0xA715890", Offset = "0xA714890", VA = "0x18A715890", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xA7159B0", Offset = "0xA7149B0", VA = "0x18A7159B0")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0xA715CF0", Offset = "0xA714CF0", VA = "0x18A715CF0", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0xA715D30", Offset = "0xA714D30", VA = "0x18A715D30", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0xA715C30", Offset = "0xA714C30", VA = "0x18A715C30", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0xA715C70", Offset = "0xA714C70", VA = "0x18A715C70", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0xA715CB0", Offset = "0xA714CB0", VA = "0x18A715CB0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B6DA40", Offset = "0x5B6CA40", VA = "0x185B6DA40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x5B6D1F0", Offset = "0x5B6C1F0", VA = "0x185B6D1F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x5B6D760", Offset = "0x5B6C760", VA = "0x185B6D760")]
		public EncodedArrayEnumerator(IReadOnlyList<T> accessor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x5B6CFA0", Offset = "0x5B6BFA0", VA = "0x185B6CFA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x5B6CFB0", Offset = "0x5B6BFB0", VA = "0x185B6CFB0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	internal static class EncodedArrayUtils
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0xA716240", Offset = "0xA715240", VA = "0x18A716240")]
		public static void _CopyTo(this IEnumerable<int> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0xA716520", Offset = "0xA715520", VA = "0x18A716520")]
		public static void _CopyTo(this IEnumerable<bool> src, IList<uint> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x394F360", Offset = "0x394E360", VA = "0x18394F360")]
		public static void _CopyTo<T>(this IEnumerable<T> src, IList<T> dst, int dstOffset = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x3950F30", Offset = "0x394FF30", VA = "0x183950F30")]
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
			[Cpp2IlInjected.Address(RVA = "0xA71AE10", Offset = "0xA719E10", VA = "0x18A71AE10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000C92")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C93")]
			[Cpp2IlInjected.Address(RVA = "0xA71AE90", Offset = "0xA719E90", VA = "0x18A71AE90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C94")]
			[Cpp2IlInjected.Address(RVA = "0xA71AF80", Offset = "0xA719F80", VA = "0x18A71AF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public float this[int rowIndex, int subIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x6000C95")]
			[Cpp2IlInjected.Address(RVA = "0xA71AE50", Offset = "0xA719E50", VA = "0x18A71AE50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C96")]
			[Cpp2IlInjected.Address(RVA = "0xA71AEC0", Offset = "0xA719EC0", VA = "0x18A71AEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0xA71A230", Offset = "0xA719230", VA = "0x18A71A230")]
		public FloatingAccessor(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0xA719900", Offset = "0xA718900", VA = "0x18A719900")]
		private float _GetValueU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0xA71A0E0", Offset = "0xA7190E0", VA = "0x18A71A0E0")]
		private void _SetValueU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0xA7194B0", Offset = "0xA7184B0", VA = "0x18A7194B0")]
		private float _GetValueS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0xA719CE0", Offset = "0xA718CE0", VA = "0x18A719CE0")]
		private void _SetValueS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0xA719620", Offset = "0xA718620", VA = "0x18A719620")]
		private float _GetValueU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0xA719E30", Offset = "0xA718E30", VA = "0x18A719E30")]
		private void _SetValueU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0xA719340", Offset = "0xA718340", VA = "0x18A719340")]
		private float _GetValueS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0xA719B90", Offset = "0xA718B90", VA = "0x18A719B90")]
		private void _SetValueS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0xA719790", Offset = "0xA718790", VA = "0x18A719790")]
		private float _GetValueU32(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0xA719F80", Offset = "0xA718F80", VA = "0x18A719F80")]
		private void _SetValueU32(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0xA719320", Offset = "0xA718320", VA = "0x18A719320")]
		private float _GetNormalizedU8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0xA719B80", Offset = "0xA718B80", VA = "0x18A719B80")]
		private void _SetNormalizedU8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0xA719280", Offset = "0xA718280", VA = "0x18A719280")]
		private float _GetNormalizedS8(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0xA719AF0", Offset = "0xA718AF0", VA = "0x18A719AF0")]
		private void _SetNormalizedS8(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0xA719300", Offset = "0xA718300", VA = "0x18A719300")]
		private float _GetNormalizedU16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0xA719B70", Offset = "0xA718B70", VA = "0x18A719B70")]
		private void _SetNormalizedU16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0xA719200", Offset = "0xA718200", VA = "0x18A719200")]
		private float _GetNormalizedS16(int byteOffset)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0xA719A70", Offset = "0xA718A70", VA = "0x18A719A70")]
		private void _SetNormalizedS16(int byteOffset, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x3ADEDD0", Offset = "0x3ADDDD0", VA = "0x183ADEDD0")]
		private T _GetValue<T>(int byteOffset) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF6C0", Offset = "0x3ADE6C0", VA = "0x183ADF6C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA72B7E0", Offset = "0xA72A7E0", VA = "0x18A72B7E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA3")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public float this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA4")]
			[Cpp2IlInjected.Address(RVA = "0xA72B7B0", Offset = "0xA72A7B0", VA = "0x18A72B7B0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA5")]
			[Cpp2IlInjected.Address(RVA = "0xA72B860", Offset = "0xA72A860", VA = "0x18A72B860", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0xA72B710", Offset = "0xA72A710", VA = "0x18A72B710")]
		public ScalarArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA0")]
		[Cpp2IlInjected.Address(RVA = "0xA72B670", Offset = "0xA72A670", VA = "0x18A72B670")]
		public ScalarArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0xA72B340", Offset = "0xA72A340", VA = "0x18A72B340", Slot = "9")]
		public IEnumerator<float> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0xA72B5C0", Offset = "0xA72A5C0", VA = "0x18A72B5C0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0xA72B100", Offset = "0xA72A100", VA = "0x18A72B100", Slot = "20")]
		public bool Contains(float item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0xA72B3F0", Offset = "0xA72A3F0", VA = "0x18A72B3F0", Slot = "13")]
		public int IndexOf(float item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0xA72B120", Offset = "0xA72A120", VA = "0x18A72B120", Slot = "21")]
		public void CopyTo(float[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0xA72B230", Offset = "0xA72A230", VA = "0x18A72B230")]
		public void Fill(IEnumerable<float> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0xA72B540", Offset = "0xA72A540", VA = "0x18A72B540", Slot = "14")]
		void IList<float>.Insert(int index, float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAD")]
		[Cpp2IlInjected.Address(RVA = "0xA72B580", Offset = "0xA72A580", VA = "0x18A72B580", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0xA72B480", Offset = "0xA72A480", VA = "0x18A72B480", Slot = "18")]
		void ICollection<float>.Add(float item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAF")]
		[Cpp2IlInjected.Address(RVA = "0xA72B4C0", Offset = "0xA72A4C0", VA = "0x18A72B4C0", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0xA72B500", Offset = "0xA72A500", VA = "0x18A72B500", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA72FBD0", Offset = "0xA72EBD0", VA = "0x18A72FBD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		bool ICollection<Vector2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB5")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public Vector2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB6")]
			[Cpp2IlInjected.Address(RVA = "0xA72FB40", Offset = "0xA72EB40", VA = "0x18A72FB40", Slot = "11")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CB7")]
			[Cpp2IlInjected.Address(RVA = "0xA72FC50", Offset = "0xA72EC50", VA = "0x18A72FC50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0xA72FAA0", Offset = "0xA72EAA0", VA = "0x18A72FAA0")]
		public Vector2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0xA72FA00", Offset = "0xA72EA00", VA = "0x18A72FA00")]
		public Vector2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0xA72F6D0", Offset = "0xA72E6D0", VA = "0x18A72F6D0", Slot = "9")]
		public IEnumerator<Vector2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB9")]
		[Cpp2IlInjected.Address(RVA = "0xA72F950", Offset = "0xA72E950", VA = "0x18A72F950", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBA")]
		[Cpp2IlInjected.Address(RVA = "0xA72F490", Offset = "0xA72E490", VA = "0x18A72F490", Slot = "20")]
		public bool Contains(Vector2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBB")]
		[Cpp2IlInjected.Address(RVA = "0xA72F780", Offset = "0xA72E780", VA = "0x18A72F780", Slot = "13")]
		public int IndexOf(Vector2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBC")]
		[Cpp2IlInjected.Address(RVA = "0xA72F4B0", Offset = "0xA72E4B0", VA = "0x18A72F4B0", Slot = "21")]
		public void CopyTo(Vector2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBD")]
		[Cpp2IlInjected.Address(RVA = "0xA72F5C0", Offset = "0xA72E5C0", VA = "0x18A72F5C0")]
		public void Fill(IEnumerable<Vector2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBE")]
		[Cpp2IlInjected.Address(RVA = "0xA72F8D0", Offset = "0xA72E8D0", VA = "0x18A72F8D0", Slot = "14")]
		void IList<Vector2>.Insert(int index, Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CBF")]
		[Cpp2IlInjected.Address(RVA = "0xA72F910", Offset = "0xA72E910", VA = "0x18A72F910", Slot = "15")]
		void IList<Vector2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC0")]
		[Cpp2IlInjected.Address(RVA = "0xA72F810", Offset = "0xA72E810", VA = "0x18A72F810", Slot = "18")]
		void ICollection<Vector2>.Add(Vector2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC1")]
		[Cpp2IlInjected.Address(RVA = "0xA72F850", Offset = "0xA72E850", VA = "0x18A72F850", Slot = "19")]
		void ICollection<Vector2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC2")]
		[Cpp2IlInjected.Address(RVA = "0xA72F890", Offset = "0xA72E890", VA = "0x18A72F890", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7304C0", Offset = "0xA72F4C0", VA = "0x18A7304C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		bool ICollection<Vector3>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC7")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public Vector3 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0xA7303F0", Offset = "0xA72F3F0", VA = "0x18A7303F0", Slot = "11")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CC9")]
			[Cpp2IlInjected.Address(RVA = "0xA730540", Offset = "0xA72F540", VA = "0x18A730540", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC3")]
		[Cpp2IlInjected.Address(RVA = "0xA7302B0", Offset = "0xA72F2B0", VA = "0x18A7302B0")]
		public Vector3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC4")]
		[Cpp2IlInjected.Address(RVA = "0xA730350", Offset = "0xA72F350", VA = "0x18A730350")]
		public Vector3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCA")]
		[Cpp2IlInjected.Address(RVA = "0xA72FF70", Offset = "0xA72EF70", VA = "0x18A72FF70", Slot = "9")]
		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0xA730200", Offset = "0xA72F200", VA = "0x18A730200", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0xA72FCB0", Offset = "0xA72ECB0", VA = "0x18A72FCB0", Slot = "20")]
		public bool Contains(Vector3 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0xA730020", Offset = "0xA72F020", VA = "0x18A730020", Slot = "13")]
		public int IndexOf(Vector3 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xA72FD50", Offset = "0xA72ED50", VA = "0x18A72FD50", Slot = "21")]
		public void CopyTo(Vector3[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCF")]
		[Cpp2IlInjected.Address(RVA = "0xA72FE60", Offset = "0xA72EE60", VA = "0x18A72FE60")]
		public void Fill(IEnumerable<Vector3> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD0")]
		[Cpp2IlInjected.Address(RVA = "0xA730180", Offset = "0xA72F180", VA = "0x18A730180", Slot = "14")]
		void IList<Vector3>.Insert(int index, Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD1")]
		[Cpp2IlInjected.Address(RVA = "0xA7301C0", Offset = "0xA72F1C0", VA = "0x18A7301C0", Slot = "15")]
		void IList<Vector3>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0xA7300C0", Offset = "0xA72F0C0", VA = "0x18A7300C0", Slot = "18")]
		void ICollection<Vector3>.Add(Vector3 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0xA730100", Offset = "0xA72F100", VA = "0x18A730100", Slot = "19")]
		void ICollection<Vector3>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0xA730140", Offset = "0xA72F140", VA = "0x18A730140", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA730BA0", Offset = "0xA72FBA0", VA = "0x18A730BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		bool ICollection<Vector4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CD9")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public Vector4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CDA")]
			[Cpp2IlInjected.Address(RVA = "0xA728340", Offset = "0xA727340", VA = "0x18A728340", Slot = "11")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CDB")]
			[Cpp2IlInjected.Address(RVA = "0xA71DBF0", Offset = "0xA71CBF0", VA = "0x18A71DBF0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0xA71D900", Offset = "0xA71C900", VA = "0x18A71D900")]
		public Vector4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0xA71D9A0", Offset = "0xA71C9A0", VA = "0x18A71D9A0")]
		public Vector4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDC")]
		[Cpp2IlInjected.Address(RVA = "0xA730870", Offset = "0xA72F870", VA = "0x18A730870", Slot = "9")]
		public IEnumerator<Vector4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDD")]
		[Cpp2IlInjected.Address(RVA = "0xA730AF0", Offset = "0xA72FAF0", VA = "0x18A730AF0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDE")]
		[Cpp2IlInjected.Address(RVA = "0xA7305C0", Offset = "0xA72F5C0", VA = "0x18A7305C0", Slot = "20")]
		public bool Contains(Vector4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CDF")]
		[Cpp2IlInjected.Address(RVA = "0xA730920", Offset = "0xA72F920", VA = "0x18A730920", Slot = "13")]
		public int IndexOf(Vector4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE0")]
		[Cpp2IlInjected.Address(RVA = "0xA730650", Offset = "0xA72F650", VA = "0x18A730650", Slot = "21")]
		public void CopyTo(Vector4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE1")]
		[Cpp2IlInjected.Address(RVA = "0xA730760", Offset = "0xA72F760", VA = "0x18A730760")]
		public void Fill(IEnumerable<Vector4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE2")]
		[Cpp2IlInjected.Address(RVA = "0xA730A70", Offset = "0xA72FA70", VA = "0x18A730A70", Slot = "14")]
		void IList<Vector4>.Insert(int index, Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE3")]
		[Cpp2IlInjected.Address(RVA = "0xA730AB0", Offset = "0xA72FAB0", VA = "0x18A730AB0", Slot = "15")]
		void IList<Vector4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE4")]
		[Cpp2IlInjected.Address(RVA = "0xA7309B0", Offset = "0xA72F9B0", VA = "0x18A7309B0", Slot = "18")]
		void ICollection<Vector4>.Add(Vector4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE5")]
		[Cpp2IlInjected.Address(RVA = "0xA7309F0", Offset = "0xA72F9F0", VA = "0x18A7309F0", Slot = "19")]
		void ICollection<Vector4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0xA730A30", Offset = "0xA72FA30", VA = "0x18A730A30", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA728460", Offset = "0xA727460", VA = "0x18A728460")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		bool ICollection<Quaternion>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEB")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public Quaternion this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CEC")]
			[Cpp2IlInjected.Address(RVA = "0xA728340", Offset = "0xA727340", VA = "0x18A728340", Slot = "11")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CED")]
			[Cpp2IlInjected.Address(RVA = "0xA71DBF0", Offset = "0xA71CBF0", VA = "0x18A71DBF0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0xA71D900", Offset = "0xA71C900", VA = "0x18A71D900")]
		public QuaternionArray(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0xA71D9A0", Offset = "0xA71C9A0", VA = "0x18A71D9A0")]
		public QuaternionArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0xA728010", Offset = "0xA727010", VA = "0x18A728010", Slot = "9")]
		public IEnumerator<Quaternion> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0xA728290", Offset = "0xA727290", VA = "0x18A728290", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0xA727D60", Offset = "0xA726D60", VA = "0x18A727D60", Slot = "20")]
		public bool Contains(Quaternion item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0xA7280C0", Offset = "0xA7270C0", VA = "0x18A7280C0", Slot = "13")]
		public int IndexOf(Quaternion item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0xA727DF0", Offset = "0xA726DF0", VA = "0x18A727DF0", Slot = "21")]
		public void CopyTo(Quaternion[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xA727F00", Offset = "0xA726F00", VA = "0x18A727F00")]
		public void Fill(IEnumerable<Quaternion> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0xA728210", Offset = "0xA727210", VA = "0x18A728210", Slot = "14")]
		void IList<Quaternion>.Insert(int index, Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0xA728250", Offset = "0xA727250", VA = "0x18A728250", Slot = "15")]
		void IList<Quaternion>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF6")]
		[Cpp2IlInjected.Address(RVA = "0xA728150", Offset = "0xA727150", VA = "0x18A728150", Slot = "18")]
		void ICollection<Quaternion>.Add(Quaternion item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF7")]
		[Cpp2IlInjected.Address(RVA = "0xA728190", Offset = "0xA727190", VA = "0x18A728190", Slot = "19")]
		void ICollection<Quaternion>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF8")]
		[Cpp2IlInjected.Address(RVA = "0xA7281D0", Offset = "0xA7271D0", VA = "0x18A7281D0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA71DB70", Offset = "0xA71CB70", VA = "0x18A71DB70")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFD")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000CFE")]
			[Cpp2IlInjected.Address(RVA = "0xA71DA40", Offset = "0xA71CA40", VA = "0x18A71DA40", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000CFF")]
			[Cpp2IlInjected.Address(RVA = "0xA71DBF0", Offset = "0xA71CBF0", VA = "0x18A71DBF0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CF9")]
		[Cpp2IlInjected.Address(RVA = "0xA71D900", Offset = "0xA71C900", VA = "0x18A71D900")]
		public Matrix2x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CFA")]
		[Cpp2IlInjected.Address(RVA = "0xA71D9A0", Offset = "0xA71C9A0", VA = "0x18A71D9A0")]
		public Matrix2x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D00")]
		[Cpp2IlInjected.Address(RVA = "0xA71D5C0", Offset = "0xA71C5C0", VA = "0x18A71D5C0", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D01")]
		[Cpp2IlInjected.Address(RVA = "0xA71D850", Offset = "0xA71C850", VA = "0x18A71D850", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D02")]
		[Cpp2IlInjected.Address(RVA = "0xA71D300", Offset = "0xA71C300", VA = "0x18A71D300", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D03")]
		[Cpp2IlInjected.Address(RVA = "0xA71D670", Offset = "0xA71C670", VA = "0x18A71D670", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D04")]
		[Cpp2IlInjected.Address(RVA = "0xA71D3A0", Offset = "0xA71C3A0", VA = "0x18A71D3A0", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D05")]
		[Cpp2IlInjected.Address(RVA = "0xA71D4B0", Offset = "0xA71C4B0", VA = "0x18A71D4B0")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		[Cpp2IlInjected.Address(RVA = "0xA71D7D0", Offset = "0xA71C7D0", VA = "0x18A71D7D0", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D07")]
		[Cpp2IlInjected.Address(RVA = "0xA71D810", Offset = "0xA71C810", VA = "0x18A71D810", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D08")]
		[Cpp2IlInjected.Address(RVA = "0xA71D710", Offset = "0xA71C710", VA = "0x18A71D710", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D09")]
		[Cpp2IlInjected.Address(RVA = "0xA71D750", Offset = "0xA71C750", VA = "0x18A71D750", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0A")]
		[Cpp2IlInjected.Address(RVA = "0xA71D790", Offset = "0xA71C790", VA = "0x18A71D790", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA71E570", Offset = "0xA71D570", VA = "0x18A71E570")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		bool ICollection<Matrix3x2>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D0F")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public Matrix3x2 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D10")]
			[Cpp2IlInjected.Address(RVA = "0xA71E3D0", Offset = "0xA71D3D0", VA = "0x18A71E3D0", Slot = "11")]
			get
			{
				return default(Matrix3x2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D11")]
			[Cpp2IlInjected.Address(RVA = "0xA71E5F0", Offset = "0xA71D5F0", VA = "0x18A71E5F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0B")]
		[Cpp2IlInjected.Address(RVA = "0xA71E290", Offset = "0xA71D290", VA = "0x18A71E290")]
		public Matrix3x2Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D0C")]
		[Cpp2IlInjected.Address(RVA = "0xA71E330", Offset = "0xA71D330", VA = "0x18A71E330")]
		public Matrix3x2Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D12")]
		[Cpp2IlInjected.Address(RVA = "0xA71DF50", Offset = "0xA71CF50", VA = "0x18A71DF50", Slot = "9")]
		public IEnumerator<Matrix3x2> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D13")]
		[Cpp2IlInjected.Address(RVA = "0xA71E1E0", Offset = "0xA71D1E0", VA = "0x18A71E1E0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D14")]
		[Cpp2IlInjected.Address(RVA = "0xA71DC90", Offset = "0xA71CC90", VA = "0x18A71DC90", Slot = "20")]
		public bool Contains(Matrix3x2 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D15")]
		[Cpp2IlInjected.Address(RVA = "0xA71E000", Offset = "0xA71D000", VA = "0x18A71E000", Slot = "13")]
		public int IndexOf(Matrix3x2 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D16")]
		[Cpp2IlInjected.Address(RVA = "0xA71DD30", Offset = "0xA71CD30", VA = "0x18A71DD30", Slot = "21")]
		public void CopyTo(Matrix3x2[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D17")]
		[Cpp2IlInjected.Address(RVA = "0xA71DE40", Offset = "0xA71CE40", VA = "0x18A71DE40")]
		public void Fill(IEnumerable<Matrix3x2> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D18")]
		[Cpp2IlInjected.Address(RVA = "0xA71E160", Offset = "0xA71D160", VA = "0x18A71E160", Slot = "14")]
		void IList<Matrix3x2>.Insert(int index, Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D19")]
		[Cpp2IlInjected.Address(RVA = "0xA71E1A0", Offset = "0xA71D1A0", VA = "0x18A71E1A0", Slot = "15")]
		void IList<Matrix3x2>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1A")]
		[Cpp2IlInjected.Address(RVA = "0xA71E0A0", Offset = "0xA71D0A0", VA = "0x18A71E0A0", Slot = "18")]
		void ICollection<Matrix3x2>.Add(Matrix3x2 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1B")]
		[Cpp2IlInjected.Address(RVA = "0xA71E0E0", Offset = "0xA71D0E0", VA = "0x18A71E0E0", Slot = "19")]
		void ICollection<Matrix3x2>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1C")]
		[Cpp2IlInjected.Address(RVA = "0xA71E120", Offset = "0xA71D120", VA = "0x18A71E120", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA71F070", Offset = "0xA71E070", VA = "0x18A71F070")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D21")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D22")]
			[Cpp2IlInjected.Address(RVA = "0xA71EDC0", Offset = "0xA71DDC0", VA = "0x18A71EDC0", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D23")]
			[Cpp2IlInjected.Address(RVA = "0xA71F0F0", Offset = "0xA71E0F0", VA = "0x18A71F0F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1D")]
		[Cpp2IlInjected.Address(RVA = "0xA71EC80", Offset = "0xA71DC80", VA = "0x18A71EC80")]
		public Matrix3x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D1E")]
		[Cpp2IlInjected.Address(RVA = "0xA71ED20", Offset = "0xA71DD20", VA = "0x18A71ED20")]
		public Matrix3x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D24")]
		[Cpp2IlInjected.Address(RVA = "0xA71E920", Offset = "0xA71D920", VA = "0x18A71E920", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D25")]
		[Cpp2IlInjected.Address(RVA = "0xA71EBD0", Offset = "0xA71DBD0", VA = "0x18A71EBD0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D26")]
		[Cpp2IlInjected.Address(RVA = "0xA71E6C0", Offset = "0xA71D6C0", VA = "0x18A71E6C0", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D27")]
		[Cpp2IlInjected.Address(RVA = "0xA71E9D0", Offset = "0xA71D9D0", VA = "0x18A71E9D0", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0xA71E700", Offset = "0xA71D700", VA = "0x18A71E700", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0xA71E810", Offset = "0xA71D810", VA = "0x18A71E810")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0xA71EB50", Offset = "0xA71DB50", VA = "0x18A71EB50", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2B")]
		[Cpp2IlInjected.Address(RVA = "0xA71EB90", Offset = "0xA71DB90", VA = "0x18A71EB90", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2C")]
		[Cpp2IlInjected.Address(RVA = "0xA71EA90", Offset = "0xA71DA90", VA = "0x18A71EA90", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2D")]
		[Cpp2IlInjected.Address(RVA = "0xA71EAD0", Offset = "0xA71DAD0", VA = "0x18A71EAD0", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2E")]
		[Cpp2IlInjected.Address(RVA = "0xA71EB10", Offset = "0xA71DB10", VA = "0x18A71EB10", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA71FC70", Offset = "0xA71EC70", VA = "0x18A71FC70")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D33")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D34")]
			[Cpp2IlInjected.Address(RVA = "0xA71F910", Offset = "0xA71E910", VA = "0x18A71F910", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D35")]
			[Cpp2IlInjected.Address(RVA = "0xA71FCF0", Offset = "0xA71ECF0", VA = "0x18A71FCF0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D2F")]
		[Cpp2IlInjected.Address(RVA = "0xA71F870", Offset = "0xA71E870", VA = "0x18A71F870")]
		public Matrix4x3Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D30")]
		[Cpp2IlInjected.Address(RVA = "0xA71F7D0", Offset = "0xA71E7D0", VA = "0x18A71F7D0")]
		public Matrix4x3Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D36")]
		[Cpp2IlInjected.Address(RVA = "0xA71F470", Offset = "0xA71E470", VA = "0x18A71F470", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D37")]
		[Cpp2IlInjected.Address(RVA = "0xA71F720", Offset = "0xA71E720", VA = "0x18A71F720", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D38")]
		[Cpp2IlInjected.Address(RVA = "0xA71F210", Offset = "0xA71E210", VA = "0x18A71F210", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D39")]
		[Cpp2IlInjected.Address(RVA = "0xA71F520", Offset = "0xA71E520", VA = "0x18A71F520", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3A")]
		[Cpp2IlInjected.Address(RVA = "0xA71F250", Offset = "0xA71E250", VA = "0x18A71F250", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3B")]
		[Cpp2IlInjected.Address(RVA = "0xA71F360", Offset = "0xA71E360", VA = "0x18A71F360")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3C")]
		[Cpp2IlInjected.Address(RVA = "0xA71F6A0", Offset = "0xA71E6A0", VA = "0x18A71F6A0", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3D")]
		[Cpp2IlInjected.Address(RVA = "0xA71F6E0", Offset = "0xA71E6E0", VA = "0x18A71F6E0", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3E")]
		[Cpp2IlInjected.Address(RVA = "0xA71F5E0", Offset = "0xA71E5E0", VA = "0x18A71F5E0", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D3F")]
		[Cpp2IlInjected.Address(RVA = "0xA71F620", Offset = "0xA71E620", VA = "0x18A71F620", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D40")]
		[Cpp2IlInjected.Address(RVA = "0xA71F660", Offset = "0xA71E660", VA = "0x18A71F660", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA720990", Offset = "0xA71F990", VA = "0x18A720990")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		bool ICollection<Matrix4x4>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D45")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public Matrix4x4 this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D46")]
			[Cpp2IlInjected.Address(RVA = "0xA720560", Offset = "0xA71F560", VA = "0x18A720560", Slot = "11")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D47")]
			[Cpp2IlInjected.Address(RVA = "0xA720A10", Offset = "0xA71FA10", VA = "0x18A720A10", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D41")]
		[Cpp2IlInjected.Address(RVA = "0xA7204C0", Offset = "0xA71F4C0", VA = "0x18A7204C0")]
		public Matrix4x4Array(Memory<byte> source, int byteStride = 0, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D42")]
		[Cpp2IlInjected.Address(RVA = "0xA720420", Offset = "0xA71F420", VA = "0x18A720420")]
		public Matrix4x4Array(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0xA7200C0", Offset = "0xA71F0C0", VA = "0x18A7200C0", Slot = "9")]
		public IEnumerator<Matrix4x4> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0xA720370", Offset = "0xA71F370", VA = "0x18A720370", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4A")]
		[Cpp2IlInjected.Address(RVA = "0xA71FE60", Offset = "0xA71EE60", VA = "0x18A71FE60", Slot = "20")]
		public bool Contains(Matrix4x4 item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4B")]
		[Cpp2IlInjected.Address(RVA = "0xA720170", Offset = "0xA71F170", VA = "0x18A720170", Slot = "13")]
		public int IndexOf(Matrix4x4 item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4C")]
		[Cpp2IlInjected.Address(RVA = "0xA71FEA0", Offset = "0xA71EEA0", VA = "0x18A71FEA0", Slot = "21")]
		public void CopyTo(Matrix4x4[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4D")]
		[Cpp2IlInjected.Address(RVA = "0xA71FFB0", Offset = "0xA71EFB0", VA = "0x18A71FFB0")]
		public void Fill(IEnumerable<Matrix4x4> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4E")]
		[Cpp2IlInjected.Address(RVA = "0xA7202F0", Offset = "0xA71F2F0", VA = "0x18A7202F0", Slot = "14")]
		void IList<Matrix4x4>.Insert(int index, Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D4F")]
		[Cpp2IlInjected.Address(RVA = "0xA720330", Offset = "0xA71F330", VA = "0x18A720330", Slot = "15")]
		void IList<Matrix4x4>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D50")]
		[Cpp2IlInjected.Address(RVA = "0xA720230", Offset = "0xA71F230", VA = "0x18A720230", Slot = "18")]
		void ICollection<Matrix4x4>.Add(Matrix4x4 item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D51")]
		[Cpp2IlInjected.Address(RVA = "0xA720270", Offset = "0xA71F270", VA = "0x18A720270", Slot = "19")]
		void ICollection<Matrix4x4>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D52")]
		[Cpp2IlInjected.Address(RVA = "0xA7202B0", Offset = "0xA71F2B0", VA = "0x18A7202B0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA726DE0", Offset = "0xA725DE0", VA = "0x18A726DE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0", Slot = "16")]
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
			[Cpp2IlInjected.Address(RVA = "0xF58350", Offset = "0xF57350", VA = "0x180F58350")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		bool ICollection<float>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D57")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public float[] this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D58")]
			[Cpp2IlInjected.Address(RVA = "0xA726D70", Offset = "0xA725D70", VA = "0x18A726D70", Slot = "11")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D59")]
			[Cpp2IlInjected.Address(RVA = "0xA726E60", Offset = "0xA725E60", VA = "0x18A726E60", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D53")]
		[Cpp2IlInjected.Address(RVA = "0xA726CD0", Offset = "0xA725CD0", VA = "0x18A726CD0")]
		public MultiArray(Memory<byte> source, int byteOffset, int itemsCount, int byteStride, int dimensions, EncodingType encoding, bool normalized)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5A")]
		[Cpp2IlInjected.Address(RVA = "0xA726610", Offset = "0xA725610", VA = "0x18A726610")]
		public void CopyItemTo(int index, float[] dstItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5B")]
		[Cpp2IlInjected.Address(RVA = "0xA726980", Offset = "0xA725980", VA = "0x18A726980", Slot = "9")]
		public IEnumerator<float[]> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5C")]
		[Cpp2IlInjected.Address(RVA = "0xA726C10", Offset = "0xA725C10", VA = "0x18A726C10", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5D")]
		[Cpp2IlInjected.Address(RVA = "0xA7265F0", Offset = "0xA7255F0", VA = "0x18A7265F0", Slot = "20")]
		public bool Contains(float[] item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5E")]
		[Cpp2IlInjected.Address(RVA = "0xA726A40", Offset = "0xA725A40", VA = "0x18A726A40", Slot = "13")]
		public int IndexOf(float[] item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D5F")]
		[Cpp2IlInjected.Address(RVA = "0xA726740", Offset = "0xA725740", VA = "0x18A726740", Slot = "21")]
		public void CopyTo(float[][] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D60")]
		[Cpp2IlInjected.Address(RVA = "0xA726860", Offset = "0xA725860", VA = "0x18A726860")]
		public void Fill(IEnumerable<float[]> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D61")]
		[Cpp2IlInjected.Address(RVA = "0xA726B90", Offset = "0xA725B90", VA = "0x18A726B90", Slot = "14")]
		void IList<float>.Insert(int index, float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0xA726BD0", Offset = "0xA725BD0", VA = "0x18A726BD0", Slot = "15")]
		void IList<float>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0xA726AD0", Offset = "0xA725AD0", VA = "0x18A726AD0", Slot = "18")]
		void ICollection<float>.Add(float[] item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0xA726B10", Offset = "0xA725B10", VA = "0x18A726B10", Slot = "19")]
		void ICollection<float>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D65")]
		[Cpp2IlInjected.Address(RVA = "0xA726B50", Offset = "0xA725B50", VA = "0x18A726B50", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6C")]
			[Cpp2IlInjected.Address(RVA = "0x515BD60", Offset = "0x515AD60", VA = "0x18515BD60", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D6D")]
			[Cpp2IlInjected.Address(RVA = "0x515A8F0", Offset = "0x51598F0", VA = "0x18515A8F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D6E")]
			[Cpp2IlInjected.Address(RVA = "0xF58350", Offset = "0xF57350", VA = "0x180F58350", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x515B990", Offset = "0x515A990", VA = "0x18515B990")]
		static ZeroAccessorArray()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6A")]
		[Cpp2IlInjected.Address(RVA = "0x15C1E10", Offset = "0x15C0E10", VA = "0x1815C1E10")]
		public ZeroAccessorArray(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6F")]
		[Cpp2IlInjected.Address(RVA = "0x5159C90", Offset = "0x5158C90", VA = "0x185159C90", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D70")]
		[Cpp2IlInjected.Address(RVA = "0x5157930", Offset = "0x5156930", VA = "0x185157930", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D71")]
		[Cpp2IlInjected.Address(RVA = "0x5158D20", Offset = "0x5157D20", VA = "0x185158D20", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D72")]
		[Cpp2IlInjected.Address(RVA = "0x51596B0", Offset = "0x51586B0", VA = "0x1851596B0", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D73")]
		[Cpp2IlInjected.Address(RVA = "0x51596B0", Offset = "0x51586B0", VA = "0x1851596B0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D74")]
		[Cpp2IlInjected.Address(RVA = "0x515A8F0", Offset = "0x51598F0", VA = "0x18515A8F0", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D75")]
		[Cpp2IlInjected.Address(RVA = "0x50242F0", Offset = "0x50232F0", VA = "0x1850242F0", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D76")]
		[Cpp2IlInjected.Address(RVA = "0x50242F0", Offset = "0x50232F0", VA = "0x1850242F0", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D77")]
		[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D78")]
		[Cpp2IlInjected.Address(RVA = "0x50242F0", Offset = "0x50232F0", VA = "0x1850242F0", Slot = "22")]
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
				[Cpp2IlInjected.Address(RVA = "0x132CAF0", Offset = "0x132BAF0", VA = "0x18132CAF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8D6FAF0", Offset = "0x8D6EAF0", VA = "0x188D6FAF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D88")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public <GetEnumerator>d__12(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D89")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8A")]
			[Cpp2IlInjected.Address(RVA = "0xA72BF40", Offset = "0xA72AF40", VA = "0x18A72BF40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8C")]
			[Cpp2IlInjected.Address(RVA = "0xA72BFE0", Offset = "0xA72AFE0", VA = "0x18A72BFE0", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8E")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D8F")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000D90")]
			[Cpp2IlInjected.Address(RVA = "0xA72DE10", Offset = "0xA72CE10", VA = "0x18A72DE10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000D92")]
			[Cpp2IlInjected.Address(RVA = "0xA72DEE0", Offset = "0xA72CEE0", VA = "0x18A72DEE0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7156D0", Offset = "0xA7146D0", VA = "0x18A7156D0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000D7B")]
			[Cpp2IlInjected.Address(RVA = "0xA715780", Offset = "0xA714780", VA = "0x18A715780", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7C")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000D7D")]
			[Cpp2IlInjected.Address(RVA = "0xA715680", Offset = "0xA714680", VA = "0x18A715680", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D79")]
		[Cpp2IlInjected.Address(RVA = "0xECDF80", Offset = "0xECCF80", VA = "0x180ECDF80")]
		public BooleanArrayOverIntegerArray(IAccessorArray<uint> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7E")]
		[Cpp2IlInjected.Address(RVA = "0xA7152D0", Offset = "0xA7142D0", VA = "0x18A7152D0", Slot = "20")]
		public bool Contains(bool item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D7F")]
		[Cpp2IlInjected.Address(RVA = "0xA715410", Offset = "0xA714410", VA = "0x18A715410", Slot = "13")]
		public int IndexOf(bool item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D80")]
		[Cpp2IlInjected.Address(RVA = "0xA7152F0", Offset = "0xA7142F0", VA = "0x18A7152F0", Slot = "21")]
		public void CopyTo(bool[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D81")]
		[Cpp2IlInjected.Address(RVA = "0xA7153A0", Offset = "0xA7143A0", VA = "0x18A7153A0", Slot = "9")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__12))]
		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D82")]
		[Cpp2IlInjected.Address(RVA = "0xA715610", Offset = "0xA714610", VA = "0x18A715610", Slot = "10")]
		[IteratorStateMachine(typeof(<System-Collections-IEnumerable-GetEnumerator>d__13))]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D83")]
		[Cpp2IlInjected.Address(RVA = "0xA715590", Offset = "0xA714590", VA = "0x18A715590", Slot = "14")]
		void IList<bool>.Insert(int index, bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D84")]
		[Cpp2IlInjected.Address(RVA = "0xA7155D0", Offset = "0xA7145D0", VA = "0x18A7155D0", Slot = "15")]
		void IList<bool>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D85")]
		[Cpp2IlInjected.Address(RVA = "0xA7154D0", Offset = "0xA7144D0", VA = "0x18A7154D0", Slot = "18")]
		void ICollection<bool>.Add(bool item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D86")]
		[Cpp2IlInjected.Address(RVA = "0xA715510", Offset = "0xA714510", VA = "0x18A715510", Slot = "19")]
		void ICollection<bool>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D87")]
		[Cpp2IlInjected.Address(RVA = "0xA715550", Offset = "0xA714550", VA = "0x18A715550", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0xA71BF50", Offset = "0xA71AF50", VA = "0x18A71BF50")]
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
			[Cpp2IlInjected.Address(RVA = "0xA71BF10", Offset = "0xA71AF10", VA = "0x18A71BF10", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		bool ICollection<uint>.IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9E")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public uint this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B0E6C0", Offset = "0x2B0D6C0", VA = "0x182B0E6C0", Slot = "11")]
			get
			{
				return default(uint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DA0")]
			[Cpp2IlInjected.Address(RVA = "0x8853C50", Offset = "0x8852C50", VA = "0x188853C50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D94")]
		[Cpp2IlInjected.Address(RVA = "0xA71BED0", Offset = "0xA71AED0", VA = "0x18A71BED0")]
		public IntegerArray(Memory<byte> source, IndexEncodingType encoding = IndexEncodingType.UNSIGNED_INT)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D95")]
		[Cpp2IlInjected.Address(RVA = "0xA71BA00", Offset = "0xA71AA00", VA = "0x18A71BA00")]
		public IntegerArray(Memory<byte> source, int byteOffset, int itemsCount, IndexEncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D96")]
		[Cpp2IlInjected.Address(RVA = "0xA71B8F0", Offset = "0xA71A8F0", VA = "0x18A71B8F0")]
		private uint _GetValueU8(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D97")]
		[Cpp2IlInjected.Address(RVA = "0xA71B9A0", Offset = "0xA71A9A0", VA = "0x18A71B9A0")]
		private void _SetValueU8(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D98")]
		[Cpp2IlInjected.Address(RVA = "0xA71B8A0", Offset = "0xA71A8A0", VA = "0x18A71B8A0")]
		private uint _GetValueU16(int index)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000D99")]
		[Cpp2IlInjected.Address(RVA = "0xA71B940", Offset = "0xA71A940", VA = "0x18A71B940")]
		private void _SetValueU16(int index, uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9A")]
		[Cpp2IlInjected.Address(RVA = "0x3B97C10", Offset = "0x3B96C10", VA = "0x183B97C10")]
		private T _GetValue<T>(int index) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9B")]
		[Cpp2IlInjected.Address(RVA = "0x3B97EE0", Offset = "0x3B96EE0", VA = "0x183B97EE0")]
		private void _SetValue<T>(int index, T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA1")]
		[Cpp2IlInjected.Address(RVA = "0xA71B580", Offset = "0xA71A580", VA = "0x18A71B580", Slot = "9")]
		public IEnumerator<uint> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA2")]
		[Cpp2IlInjected.Address(RVA = "0xA71B7F0", Offset = "0xA71A7F0", VA = "0x18A71B7F0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA3")]
		[Cpp2IlInjected.Address(RVA = "0xA71B210", Offset = "0xA71A210", VA = "0x18A71B210", Slot = "20")]
		public bool Contains(uint item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA4")]
		[Cpp2IlInjected.Address(RVA = "0xA71B630", Offset = "0xA71A630", VA = "0x18A71B630", Slot = "13")]
		public int IndexOf(uint item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA5")]
		[Cpp2IlInjected.Address(RVA = "0xA71B230", Offset = "0xA71A230", VA = "0x18A71B230", Slot = "21")]
		public void CopyTo(uint[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA6")]
		[Cpp2IlInjected.Address(RVA = "0xA71B350", Offset = "0xA71A350", VA = "0x18A71B350")]
		public void Fill(IEnumerable<int> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA7")]
		[Cpp2IlInjected.Address(RVA = "0xA71B460", Offset = "0xA71A460", VA = "0x18A71B460")]
		public void Fill(IEnumerable<uint> values, int dstStart = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA8")]
		[Cpp2IlInjected.Address(RVA = "0xA71B770", Offset = "0xA71A770", VA = "0x18A71B770", Slot = "14")]
		void IList<uint>.Insert(int index, uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA9")]
		[Cpp2IlInjected.Address(RVA = "0xA71B7B0", Offset = "0xA71A7B0", VA = "0x18A71B7B0", Slot = "15")]
		void IList<uint>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAA")]
		[Cpp2IlInjected.Address(RVA = "0xA71B6B0", Offset = "0xA71A6B0", VA = "0x18A71B6B0", Slot = "18")]
		void ICollection<uint>.Add(uint item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAB")]
		[Cpp2IlInjected.Address(RVA = "0xA71B6F0", Offset = "0xA71A6F0", VA = "0x18A71B6F0", Slot = "19")]
		void ICollection<uint>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DAC")]
		[Cpp2IlInjected.Address(RVA = "0xA71B730", Offset = "0xA71A730", VA = "0x18A71B730", Slot = "22")]
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
				[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA742DA0", Offset = "0xA741DA0", VA = "0x18A742DA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF1")]
			[Cpp2IlInjected.Address(RVA = "0x1D167A0", Offset = "0x1D157A0", VA = "0x181D167A0")]
			[DebuggerHidden]
			public <GetItemsAsRawBytes>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF2")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF3")]
			[Cpp2IlInjected.Address(RVA = "0xA742B30", Offset = "0xA741B30", VA = "0x18A742B30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF5")]
			[Cpp2IlInjected.Address(RVA = "0xA742D60", Offset = "0xA741D60", VA = "0x18A742D60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF7")]
			[Cpp2IlInjected.Address(RVA = "0xA742CC0", Offset = "0xA741CC0", VA = "0x18A742CC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ArraySegment<byte>> IEnumerable<ArraySegment<byte>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000DF8")]
			[Cpp2IlInjected.Address(RVA = "0xA742CC0", Offset = "0xA741CC0", VA = "0x18A742CC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xF2C0A0", Offset = "0xF2B0A0", VA = "0x180F2C0A0")]
			[CompilerGenerated]
			get
			{
				return default(MemoryAccessInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBA")]
			[Cpp2IlInjected.Address(RVA = "0x5091350", Offset = "0x5090350", VA = "0x185091350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		public ArraySegment<byte> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000DBB")]
			[Cpp2IlInjected.Address(RVA = "0x1687D40", Offset = "0x1686D40", VA = "0x181687D40")]
			[CompilerGenerated]
			get
			{
				return default(ArraySegment<byte>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000DBC")]
			[Cpp2IlInjected.Address(RVA = "0xA7265D0", Offset = "0xA7255D0", VA = "0x18A7265D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB5")]
		[Cpp2IlInjected.Address(RVA = "0xA726160", Offset = "0xA725160", VA = "0x18A726160")]
		internal string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB6")]
		[Cpp2IlInjected.Address(RVA = "0xA726450", Offset = "0xA725450", VA = "0x18A726450")]
		public MemoryAccessor(byte[] data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB7")]
		[Cpp2IlInjected.Address(RVA = "0xA726560", Offset = "0xA725560", VA = "0x18A726560")]
		public MemoryAccessor(ArraySegment<byte> data, MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DB8")]
		[Cpp2IlInjected.Address(RVA = "0xA726500", Offset = "0xA725500", VA = "0x18A726500")]
		public MemoryAccessor(MemoryAccessInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBD")]
		[Cpp2IlInjected.Address(RVA = "0xA724630", Offset = "0xA723630", VA = "0x18A724630")]
		public void Update(ArraySegment<byte> data, MemoryAccessInfo encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBE")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3770", Offset = "0x3CC2770", VA = "0x183CC3770")]
		public IAccessorArray<T> AsArrayOf<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DBF")]
		[Cpp2IlInjected.Address(RVA = "0xA720EB0", Offset = "0xA71FEB0", VA = "0x18A720EB0")]
		public IntegerArray AsIntegerArray()
		{
			return default(IntegerArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC0")]
		[Cpp2IlInjected.Address(RVA = "0xA721F20", Offset = "0xA720F20", VA = "0x18A721F20")]
		public ScalarArray AsScalarArray()
		{
			return default(ScalarArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC1")]
		[Cpp2IlInjected.Address(RVA = "0xA722190", Offset = "0xA721190", VA = "0x18A722190")]
		public Vector2Array AsVector2Array()
		{
			return default(Vector2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC2")]
		[Cpp2IlInjected.Address(RVA = "0xA722400", Offset = "0xA721400", VA = "0x18A722400")]
		public Vector3Array AsVector3Array()
		{
			return default(Vector3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC3")]
		[Cpp2IlInjected.Address(RVA = "0xA722670", Offset = "0xA721670", VA = "0x18A722670")]
		public Vector4Array AsVector4Array()
		{
			return default(Vector4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC4")]
		[Cpp2IlInjected.Address(RVA = "0xA721CB0", Offset = "0xA720CB0", VA = "0x18A721CB0")]
		public QuaternionArray AsQuaternionArray()
		{
			return default(QuaternionArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC5")]
		[Cpp2IlInjected.Address(RVA = "0xA721090", Offset = "0xA720090", VA = "0x18A721090")]
		public Matrix2x2Array AsMatrix2x2Array()
		{
			return default(Matrix2x2Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC6")]
		[Cpp2IlInjected.Address(RVA = "0xA721300", Offset = "0xA720300", VA = "0x18A721300")]
		public Matrix3x3Array AsMatrix3x3Array()
		{
			return default(Matrix3x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC7")]
		[Cpp2IlInjected.Address(RVA = "0xA721570", Offset = "0xA720570", VA = "0x18A721570")]
		public Matrix4x3Array AsMatrix4x3Array()
		{
			return default(Matrix4x3Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC8")]
		[Cpp2IlInjected.Address(RVA = "0xA7217A0", Offset = "0xA7207A0", VA = "0x18A7217A0")]
		public Matrix4x4Array AsMatrix4x4Array()
		{
			return default(Matrix4x4Array);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DC9")]
		[Cpp2IlInjected.Address(RVA = "0xA720BE0", Offset = "0xA71FBE0", VA = "0x18A720BE0")]
		public ColorArray AsColorArray(float defaultW = 1f)
		{
			return default(ColorArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCA")]
		[Cpp2IlInjected.Address(RVA = "0xA721A10", Offset = "0xA720A10", VA = "0x18A721A10")]
		public MultiArray AsMultiArray(int dimensions)
		{
			return default(MultiArray);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCB")]
		[Cpp2IlInjected.Address(RVA = "0xA7234B0", Offset = "0xA7224B0", VA = "0x18A7234B0")]
		[IteratorStateMachine(typeof(<GetItemsAsRawBytes>d__26))]
		public IEnumerable<ArraySegment<byte>> GetItemsAsRawBytes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCC")]
		[Cpp2IlInjected.Address(RVA = "0xA7228E0", Offset = "0xA7218E0", VA = "0x18A7228E0")]
		public (MemoryAccessor, MemoryAccessor) ConvertToSparse()
		{
			return default((MemoryAccessor, MemoryAccessor));
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCD")]
		[Cpp2IlInjected.Address(RVA = "0xA723830", Offset = "0xA722830", VA = "0x18A723830")]
		private bool RepresentsZeroValue(ArraySegment<byte> bytes)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCE")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6730", Offset = "0x3CC5730", VA = "0x183CC6730")]
		public static IAccessorArray<T> CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DCF")]
		[Cpp2IlInjected.Address(RVA = "0x3CC68F0", Offset = "0x3CC58F0", VA = "0x183CC68F0")]
		public static IAccessorArray<T> CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD0")]
		[Cpp2IlInjected.Address(RVA = "0xA723270", Offset = "0xA722270", VA = "0x18A723270")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD1")]
		[Cpp2IlInjected.Address(RVA = "0xA723390", Offset = "0xA722390", VA = "0x18A723390")]
		public static IAccessorArray<Vector4> CreateColorSparseArray(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, float defaultW = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD2")]
		[Cpp2IlInjected.Address(RVA = "0x3CC80D0", Offset = "0x3CC70D0", VA = "0x183CC80D0")]
		private static IAccessorArray<T> _CreateSparseArray<T>(int denseCount, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7E10", Offset = "0x3CC6E10", VA = "0x183CC7E10")]
		private static IAccessorArray<T> _CreateSparseArray<T>(MemoryAccessor denseValues, IntegerArray sparseKeys, MemoryAccessor sparseValues, Func<MemoryAccessor, IAccessorArray<T>> toAccessor) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD4")]
		[Cpp2IlInjected.Address(RVA = "0xA723A80", Offset = "0xA722A80", VA = "0x18A723A80")]
		public static void SanitizeVertexAttributes(MemoryAccessor[] vertexAccessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD5")]
		[Cpp2IlInjected.Address(RVA = "0xA723610", Offset = "0xA722610", VA = "0x18A723610")]
		public static bool HaveOverlappingBuffers(MemoryAccessor a, MemoryAccessor b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD6")]
		[Cpp2IlInjected.Address(RVA = "0xA725FE0", Offset = "0xA724FE0", VA = "0x18A725FE0")]
		internal ArraySegment<byte> _GetBytes()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD7")]
		[Cpp2IlInjected.Address(RVA = "0xA723530", Offset = "0xA722530", VA = "0x18A723530")]
		public static bool HaveOverlappingBuffers(IEnumerable<MemoryAccessor> abc)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD8")]
		[Cpp2IlInjected.Address(RVA = "0xA723C70", Offset = "0xA722C70", VA = "0x18A723C70")]
		public static void SanitizeWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DD9")]
		[Cpp2IlInjected.Address(RVA = "0xA7261D0", Offset = "0xA7251D0", VA = "0x18A7261D0")]
		private static bool _SanitizeWeightSum(Span<byte> dst, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDA")]
		[Cpp2IlInjected.Address(RVA = "0xA725440", Offset = "0xA724440", VA = "0x18A725440")]
		public static void VerifyWeightsSum(MemoryAccessor weights0, MemoryAccessor weights1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDB")]
		[Cpp2IlInjected.Address(RVA = "0xA725DA0", Offset = "0xA724DA0", VA = "0x18A725DA0")]
		private static bool _CheckWeightSum(ReadOnlySpan<byte> src, EncodingType encoding)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDC")]
		[Cpp2IlInjected.Address(RVA = "0xA724690", Offset = "0xA723690", VA = "0x18A724690")]
		public static void VerifyAccessorBounds(MemoryAccessor memory, IReadOnlyList<double> min, IReadOnlyList<double> max)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DDD")]
		[Cpp2IlInjected.Address(RVA = "0xA725110", Offset = "0xA724110", VA = "0x18A725110")]
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
			[Cpp2IlInjected.Address(RVA = "0xA735830", Offset = "0xA734830", VA = "0x18A735830", Slot = "4")]
			public int Compare(string x, string y)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0E")]
			[Cpp2IlInjected.Address(RVA = "0xA735870", Offset = "0xA734870", VA = "0x18A735870")]
			private static int _GetSortingScore(string attribute)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000E0F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			get
			{
				return default(DimensionType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		public readonly EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000E01")]
			[Cpp2IlInjected.Address(RVA = "0xE01B10", Offset = "0xE00B10", VA = "0x180E01B10")]
			get
			{
				return default(EncodingType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		public readonly bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x6000E02")]
			[Cpp2IlInjected.Address(RVA = "0xE9D7B0", Offset = "0xE9C7B0", VA = "0x180E9D7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		public readonly int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E03")]
			[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		public readonly int PaddedByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E04")]
			[Cpp2IlInjected.Address(RVA = "0xA73EAA0", Offset = "0xA73DAA0", VA = "0x18A73EAA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		public readonly int StepByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000E05")]
			[Cpp2IlInjected.Address(RVA = "0xA73EAF0", Offset = "0xA73DAF0", VA = "0x18A73EAF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		public readonly bool IsValidVertexAttribute
		{
			[Cpp2IlInjected.Token(Token = "0x6000E06")]
			[Cpp2IlInjected.Address(RVA = "0xA73E9A0", Offset = "0xA73D9A0", VA = "0x18A73E9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		public readonly bool IsValidIndexer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E07")]
			[Cpp2IlInjected.Address(RVA = "0xA73E900", Offset = "0xA73D900", VA = "0x18A73E900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		internal static IComparer<string> NameComparer
		{
			[Cpp2IlInjected.Token(Token = "0x6000E0A")]
			[Cpp2IlInjected.Address(RVA = "0xA73EA50", Offset = "0xA73DA50", VA = "0x18A73EA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E0B")]
			[Cpp2IlInjected.Address(RVA = "0xA73EB50", Offset = "0xA73DB50", VA = "0x18A73EB50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000DF9")]
		[Cpp2IlInjected.Address(RVA = "0xA73E580", Offset = "0xA73D580", VA = "0x18A73E580")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFA")]
		[Cpp2IlInjected.Address(RVA = "0xA73DEA0", Offset = "0xA73CEA0", VA = "0x18A73DEA0")]
		public static MemoryAccessInfo[] Create(params string[] attributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFB")]
		[Cpp2IlInjected.Address(RVA = "0xA73D6E0", Offset = "0xA73C6E0", VA = "0x18A73D6E0")]
		public static MemoryAccessInfo CreateDefaultElement(string attribute)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFC")]
		[Cpp2IlInjected.Address(RVA = "0xA73E8B0", Offset = "0xA73D8B0", VA = "0x18A73E8B0")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, AttributeFormat format)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFD")]
		[Cpp2IlInjected.Address(RVA = "0xA73E7B0", Offset = "0xA73D7B0", VA = "0x18A73E7B0")]
		public MemoryAccessInfo(string name, int byteOffset, int itemsCount, int byteStride, DimensionType dimensions, EncodingType encoding = EncodingType.FLOAT, bool normalized = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFE")]
		[Cpp2IlInjected.Address(RVA = "0xA73E3E0", Offset = "0xA73D3E0", VA = "0x18A73E3E0")]
		public readonly MemoryAccessInfo Slice(int itemStart, int itemCount)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DFF")]
		[Cpp2IlInjected.Address(RVA = "0xA73E500", Offset = "0xA73D500", VA = "0x18A73E500")]
		public readonly MemoryAccessInfo WithFormat(AttributeFormat newFormat)
		{
			return default(MemoryAccessInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E08")]
		[Cpp2IlInjected.Address(RVA = "0xA73DFD0", Offset = "0xA73CFD0", VA = "0x18A73DFD0")]
		public static int SetInterleavedInfo(MemoryAccessInfo[] attributes, int byteOffset, int itemsCount)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E09")]
		[Cpp2IlInjected.Address(RVA = "0xA73E220", Offset = "0xA73D220", VA = "0x18A73E220")]
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
			[Cpp2IlInjected.Address(RVA = "0xA741BD0", Offset = "0xA740BD0", VA = "0x18A741BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		public static MemoryImage Empty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E15")]
			[Cpp2IlInjected.Address(RVA = "0x1106C20", Offset = "0x1105C20", VA = "0x181106C20")]
			get
			{
				return default(MemoryImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		private ArraySegment<byte> _Image
		{
			[Cpp2IlInjected.Token(Token = "0x6000E25")]
			[Cpp2IlInjected.Address(RVA = "0xA742600", Offset = "0xA741600", VA = "0x18A742600")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2C")]
			[Cpp2IlInjected.Address(RVA = "0xA741ED0", Offset = "0xA740ED0", VA = "0x18A741ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		public ReadOnlyMemory<byte> Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2D")]
			[Cpp2IlInjected.Address(RVA = "0xA741B00", Offset = "0xA740B00", VA = "0x18A741B00")]
			get
			{
				return default(ReadOnlyMemory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public string SourcePath
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2E")]
			[Cpp2IlInjected.Address(RVA = "0xF2D660", Offset = "0xF2C660", VA = "0x180F2D660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public bool IsPng
		{
			[Cpp2IlInjected.Token(Token = "0x6000E2F")]
			[Cpp2IlInjected.Address(RVA = "0xA742220", Offset = "0xA741220", VA = "0x18A742220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		public bool IsJpg
		{
			[Cpp2IlInjected.Token(Token = "0x6000E30")]
			[Cpp2IlInjected.Address(RVA = "0xA742040", Offset = "0xA741040", VA = "0x18A742040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		public bool IsDds
		{
			[Cpp2IlInjected.Token(Token = "0x6000E31")]
			[Cpp2IlInjected.Address(RVA = "0xA741E10", Offset = "0xA740E10", VA = "0x18A741E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		public bool IsWebp
		{
			[Cpp2IlInjected.Token(Token = "0x6000E32")]
			[Cpp2IlInjected.Address(RVA = "0xA742360", Offset = "0xA741360", VA = "0x18A742360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public bool IsKtx2
		{
			[Cpp2IlInjected.Token(Token = "0x6000E33")]
			[Cpp2IlInjected.Address(RVA = "0xA742160", Offset = "0xA741160", VA = "0x18A742160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public bool IsExtendedFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000E34")]
			[Cpp2IlInjected.Address(RVA = "0xA741FA0", Offset = "0xA740FA0", VA = "0x18A741FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000E35")]
			[Cpp2IlInjected.Address(RVA = "0xA7422E0", Offset = "0xA7412E0", VA = "0x18A7422E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public string FileExtension
		{
			[Cpp2IlInjected.Token(Token = "0x6000E36")]
			[Cpp2IlInjected.Address(RVA = "0xA741C30", Offset = "0xA740C30", VA = "0x18A741C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		public string MimeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000E37")]
			[Cpp2IlInjected.Address(RVA = "0xA742420", Offset = "0xA741420", VA = "0x18A742420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E13")]
		[Cpp2IlInjected.Address(RVA = "0xA73F9F0", Offset = "0xA73E9F0", VA = "0x18A73F9F0")]
		public string ToDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E16")]
		[Cpp2IlInjected.Address(RVA = "0xA7426F0", Offset = "0xA7416F0", VA = "0x18A7426F0")]
		public static implicit operator MemoryImage(ArraySegment<byte> image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E17")]
		[Cpp2IlInjected.Address(RVA = "0xA742780", Offset = "0xA741780", VA = "0x18A742780")]
		public static implicit operator MemoryImage(byte[] image)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E18")]
		[Cpp2IlInjected.Address(RVA = "0xA7427A0", Offset = "0xA7417A0", VA = "0x18A7427A0")]
		public static implicit operator MemoryImage(string filePath)
		{
			return default(MemoryImage);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E19")]
		[Cpp2IlInjected.Address(RVA = "0xA7409E0", Offset = "0xA73F9E0", VA = "0x18A7409E0")]
		public static bool TryParseMime64(Uri mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1A")]
		[Cpp2IlInjected.Address(RVA = "0xA740510", Offset = "0xA73F510", VA = "0x18A740510")]
		public static bool TryParseMime64(string mime64content, [Out] MemoryImage image)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1B")]
		[Cpp2IlInjected.Address(RVA = "0xA7418F0", Offset = "0xA7408F0", VA = "0x18A7418F0")]
		public MemoryImage(ArraySegment<byte> image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1C")]
		[Cpp2IlInjected.Address(RVA = "0xA741700", Offset = "0xA740700", VA = "0x18A741700")]
		public MemoryImage(byte[] image)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1D")]
		[Cpp2IlInjected.Address(RVA = "0xA741A50", Offset = "0xA740A50", VA = "0x18A741A50")]
		public MemoryImage(Func<ArraySegment<byte>> factory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1E")]
		[Cpp2IlInjected.Address(RVA = "0xA741780", Offset = "0xA740780", VA = "0x18A741780")]
		public MemoryImage(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E1F")]
		[Cpp2IlInjected.Address(RVA = "0xA741680", Offset = "0xA740680", VA = "0x18A741680")]
		internal MemoryImage(byte[] image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E20")]
		[Cpp2IlInjected.Address(RVA = "0xA7419C0", Offset = "0xA7409C0", VA = "0x18A7419C0")]
		internal MemoryImage(ArraySegment<byte> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E21")]
		[Cpp2IlInjected.Address(RVA = "0xA741970", Offset = "0xA740970", VA = "0x18A741970")]
		internal MemoryImage(MemoryImage image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E22")]
		[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
		internal MemoryImage(Lazy<ArraySegment<byte>> image, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E23")]
		[Cpp2IlInjected.Address(RVA = "0xA7410C0", Offset = "0xA7400C0", VA = "0x18A7410C0")]
		private static Lazy<ArraySegment<byte>> _ToLazy(byte[] bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E24")]
		[Cpp2IlInjected.Address(RVA = "0xA740FD0", Offset = "0xA73FFD0", VA = "0x18A740FD0")]
		private static Lazy<ArraySegment<byte>> _ToLazy(ArraySegment<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E26")]
		[Cpp2IlInjected.Address(RVA = "0xA73F140", Offset = "0xA73E140", VA = "0x18A73F140", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E27")]
		[Cpp2IlInjected.Address(RVA = "0xA73EBC0", Offset = "0xA73DBC0", VA = "0x18A73EBC0")]
		public static bool AreEqual(MemoryImage a, MemoryImage b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E28")]
		[Cpp2IlInjected.Address(RVA = "0xA73EFF0", Offset = "0xA73DFF0", VA = "0x18A73EFF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E29")]
		[Cpp2IlInjected.Address(RVA = "0xA73F0C0", Offset = "0xA73E0C0", VA = "0x18A73F0C0", Slot = "4")]
		public bool Equals(MemoryImage other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2A")]
		[Cpp2IlInjected.Address(RVA = "0xA742680", Offset = "0xA741680", VA = "0x18A742680")]
		public static bool operator ==(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E2B")]
		[Cpp2IlInjected.Address(RVA = "0xA7427C0", Offset = "0xA7417C0", VA = "0x18A7427C0")]
		public static bool operator !=(MemoryImage left, MemoryImage right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E38")]
		[Cpp2IlInjected.Address(RVA = "0xA740330", Offset = "0xA73F330", VA = "0x18A740330")]
		public static string TrimImageExtension(string path)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E39")]
		[Cpp2IlInjected.Address(RVA = "0xA741140", Offset = "0xA740140", VA = "0x18A741140")]
		internal static void _Verify(MemoryImage image, string paramName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3A")]
		[Cpp2IlInjected.Address(RVA = "0xA73F530", Offset = "0xA73E530", VA = "0x18A73F530")]
		public Stream Open()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3B")]
		[Cpp2IlInjected.Address(RVA = "0xA73F790", Offset = "0xA73E790", VA = "0x18A73F790")]
		public void SaveToFile(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3C")]
		[Cpp2IlInjected.Address(RVA = "0xA740A50", Offset = "0xA73FA50", VA = "0x18A740A50")]
		internal ArraySegment<byte> _GetBuffer()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3D")]
		[Cpp2IlInjected.Address(RVA = "0xA73FF50", Offset = "0xA73EF50", VA = "0x18A73FF50")]
		internal string ToMime64(bool withPrefix = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3E")]
		[Cpp2IlInjected.Address(RVA = "0xA73F220", Offset = "0xA73E220", VA = "0x18A73F220")]
		public bool IsImageOfType(string format)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E3F")]
		[Cpp2IlInjected.Address(RVA = "0xA740DF0", Offset = "0xA73FDF0", VA = "0x18A740DF0")]
		private static bool _IsPngImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E40")]
		[Cpp2IlInjected.Address(RVA = "0xA740D10", Offset = "0xA73FD10", VA = "0x18A740D10")]
		private static bool _IsJpgImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E41")]
		[Cpp2IlInjected.Address(RVA = "0xA740B00", Offset = "0xA73FB00", VA = "0x18A740B00")]
		private static bool _IsDdsImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E42")]
		[Cpp2IlInjected.Address(RVA = "0xA740EA0", Offset = "0xA73FEA0", VA = "0x18A740EA0")]
		private static bool _IsWebpImage(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E43")]
		[Cpp2IlInjected.Address(RVA = "0xA740D90", Offset = "0xA73FD90", VA = "0x18A740D90")]
		private static bool _IsKtx2Image(IReadOnlyList<byte> data)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E44")]
		[Cpp2IlInjected.Address(RVA = "0xA740BB0", Offset = "0xA73FBB0", VA = "0x18A740BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA73D6C0", Offset = "0xA73C6C0", VA = "0x18A73D6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E49")]
		[Cpp2IlInjected.Address(RVA = "0xA73D340", Offset = "0xA73C340", VA = "0x18A73D340")]
		public static bool TryGetHeader(IReadOnlyList<byte> data, [Out] Ktx2Header header)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4A")]
		[Cpp2IlInjected.Address(RVA = "0xA73D4D0", Offset = "0xA73C4D0", VA = "0x18A73D4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C08A40", Offset = "0x7C07A40", VA = "0x187C08A40")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C08380", Offset = "0x7C07380", VA = "0x187C08380", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4E")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000E4F")]
			[Cpp2IlInjected.Address(RVA = "0x7C088C0", Offset = "0x7C078C0", VA = "0x187C088C0", Slot = "11")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000E50")]
			[Cpp2IlInjected.Address(RVA = "0x7C08AE0", Offset = "0x7C07AE0", VA = "0x187C08AE0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E4B")]
		[Cpp2IlInjected.Address(RVA = "0x7C07C20", Offset = "0x7C06C20", VA = "0x187C07C20")]
		public SparseArray(IReadOnlyList<T> denseValues, IReadOnlyList<T> sparseValues, IReadOnlyList<uint> sparseKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E51")]
		[Cpp2IlInjected.Address(RVA = "0x7C06980", Offset = "0x7C05980", VA = "0x187C06980", Slot = "9")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E52")]
		[Cpp2IlInjected.Address(RVA = "0x7C06980", Offset = "0x7C05980", VA = "0x187C06980", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E53")]
		[Cpp2IlInjected.Address(RVA = "0x7C06290", Offset = "0x7C05290", VA = "0x187C06290", Slot = "20")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E54")]
		[Cpp2IlInjected.Address(RVA = "0x7C06A70", Offset = "0x7C05A70", VA = "0x187C06A70", Slot = "13")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E55")]
		[Cpp2IlInjected.Address(RVA = "0x7C06890", Offset = "0x7C05890", VA = "0x187C06890", Slot = "21")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E56")]
		[Cpp2IlInjected.Address(RVA = "0x515A8F0", Offset = "0x51598F0", VA = "0x18515A8F0", Slot = "14")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E57")]
		[Cpp2IlInjected.Address(RVA = "0x50242F0", Offset = "0x50232F0", VA = "0x1850242F0", Slot = "15")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E58")]
		[Cpp2IlInjected.Address(RVA = "0x50242F0", Offset = "0x50232F0", VA = "0x1850242F0", Slot = "18")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E59")]
		[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "19")]
		void ICollection<T>.Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5A")]
		[Cpp2IlInjected.Address(RVA = "0x50242F0", Offset = "0x50232F0", VA = "0x1850242F0", Slot = "22")]
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
			[Cpp2IlInjected.Address(RVA = "0x73EC140", Offset = "0x73EB140", VA = "0x1873EC140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5B")]
		[Cpp2IlInjected.Address(RVA = "0xA73C9B0", Offset = "0xA73B9B0", VA = "0x18A73C9B0")]
		internal void ValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5C")]
		[Cpp2IlInjected.Address(RVA = "0xA73C950", Offset = "0xA73B950", VA = "0x18A73C950")]
		internal void ValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "4")]
		protected virtual void OnValidateReferences(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
		protected virtual void OnValidateContent(ValidationContext validate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E60")]
		[Cpp2IlInjected.Address(RVA = "0xA73B950", Offset = "0xA73A950", VA = "0x18A73B950", Slot = "6")]
		protected virtual string GetSchemaName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E61")]
		[Cpp2IlInjected.Address(RVA = "0xA73C870", Offset = "0xA73B870", VA = "0x18A73C870")]
		internal void Serialize(Utf8JsonWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E62")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void SerializeProperties(Utf8JsonWriter writer);

		[Cpp2IlInjected.Token(Token = "0x6000E63")]
		[Cpp2IlInjected.Address(RVA = "0xA73C650", Offset = "0xA73B650", VA = "0x18A73C650")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E64")]
		[Cpp2IlInjected.Address(RVA = "0xA73B980", Offset = "0xA73A980", VA = "0x18A73B980")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, bool? value, [Optional] bool? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E65")]
		[Cpp2IlInjected.Address(RVA = "0xA73C720", Offset = "0xA73B720", VA = "0x18A73C720")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, int? value, [Optional] int? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E66")]
		[Cpp2IlInjected.Address(RVA = "0xA73BE30", Offset = "0xA73AE30", VA = "0x18A73BE30")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, float? value, [Optional] float? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E67")]
		[Cpp2IlInjected.Address(RVA = "0xA73C140", Offset = "0xA73B140", VA = "0x18A73C140")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, double? value, [Optional] double? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E68")]
		[Cpp2IlInjected.Address(RVA = "0xA73BAF0", Offset = "0xA73AAF0", VA = "0x18A73BAF0")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector2? value, [Optional] Vector2? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E69")]
		[Cpp2IlInjected.Address(RVA = "0xA73BC70", Offset = "0xA73AC70", VA = "0x18A73BC70")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector3? value, [Optional] Vector3? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6A")]
		[Cpp2IlInjected.Address(RVA = "0xA73BF80", Offset = "0xA73AF80", VA = "0x18A73BF80")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Vector4? value, [Optional] Vector4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6B")]
		[Cpp2IlInjected.Address(RVA = "0xA73C280", Offset = "0xA73B280", VA = "0x18A73C280")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Quaternion? value, [Optional] Quaternion? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6C")]
		[Cpp2IlInjected.Address(RVA = "0xA73C440", Offset = "0xA73B440", VA = "0x18A73C440")]
		protected static void SerializeProperty(Utf8JsonWriter writer, string name, Matrix4x4? value, [Optional] Matrix4x4? defval)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6D")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF370", Offset = "0x3BCE370", VA = "0x183BCF370")]
		protected static void SerializePropertyEnumValue<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6E")]
		[Cpp2IlInjected.Address(RVA = "0x3BCED60", Offset = "0x3BCDD60", VA = "0x183BCED60")]
		protected static void SerializePropertyEnumSymbol<T>(Utf8JsonWriter writer, string name, T? value, [Optional] T? defval) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E6F")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF5C0", Offset = "0x3BCE5C0", VA = "0x183BCF5C0")]
		protected static void SerializePropertyObject<T>(Utf8JsonWriter writer, string name, T value) where T : JsonSerializable
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E70")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF690", Offset = "0x3BCE690", VA = "0x183BCF690")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyList<T> collection, [Optional] int? minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E71")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0120", Offset = "0x3BCF120", VA = "0x183BD0120")]
		protected static void SerializeProperty<T>(Utf8JsonWriter writer, string name, IReadOnlyDictionary<string, T> collection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E72")]
		[Cpp2IlInjected.Address(RVA = "0xA73CA80", Offset = "0xA73BA80", VA = "0x18A73CA80")]
		private static void _SerializeProperty(Utf8JsonWriter writer, string name, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E73")]
		[Cpp2IlInjected.Address(RVA = "0xA73CA10", Offset = "0xA73BA10", VA = "0x18A73CA10")]
		private static bool _IsNullOrEmpty(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E74")]
		[Cpp2IlInjected.Address(RVA = "0xA73CC10", Offset = "0xA73BC10", VA = "0x18A73CC10")]
		private static void _SerializeValue(Utf8JsonWriter writer, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E75")]
		[Cpp2IlInjected.Address(RVA = "0xA73B810", Offset = "0xA73A810", VA = "0x18A73B810")]
		internal void Deserialize(Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E76")]
		[Cpp2IlInjected.Address(RVA = "0xA73B2F0", Offset = "0xA73A2F0", VA = "0x18A73B2F0")]
		protected static object DeserializeUnknownObject(Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E77")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void DeserializeProperty(string jsonPropertyName, Utf8JsonReader reader);

		[Cpp2IlInjected.Token(Token = "0x6000E78")]
		[Cpp2IlInjected.Address(RVA = "0x3BCDCB0", Offset = "0x3BCCCB0", VA = "0x183BCDCB0")]
		protected static T DeserializePropertyValue<T>(Utf8JsonReader reader)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E79")]
		[Cpp2IlInjected.Address(RVA = "0x3BCE5D0", Offset = "0x3BCD5D0", VA = "0x183BCE5D0")]
		protected static void DeserializePropertyValue<TParent, T>(Utf8JsonReader reader, TParent owner, [Out] T property) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7A")]
		[Cpp2IlInjected.Address(RVA = "0x3BCD630", Offset = "0x3BCC630", VA = "0x183BCD630")]
		protected static void DeserializePropertyList<TParent, T>(Utf8JsonReader reader, TParent owner, IList<T> list) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7B")]
		[Cpp2IlInjected.Address(RVA = "0x3BCCF20", Offset = "0x3BCBF20", VA = "0x183BCCF20")]
		protected static void DeserializePropertyList<T>(Utf8JsonReader reader, IList<T> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7C")]
		[Cpp2IlInjected.Address(RVA = "0x3BCCED0", Offset = "0x3BCBED0", VA = "0x183BCCED0")]
		protected static void DeserializePropertyDictionary<TParent, T>(Utf8JsonReader reader, TParent owner, IDictionary<string, T> dict) where TParent : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7D")]
		[Cpp2IlInjected.Address(RVA = "0x3BCCBE0", Offset = "0x3BCBBE0", VA = "0x183BCCBE0")]
		protected static void DeserializePropertyDictionary<T>(Utf8JsonReader reader, IDictionary<string, T> dict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7E")]
		[Cpp2IlInjected.Address(RVA = "0x3BD0C80", Offset = "0x3BCFC80", VA = "0x183BD0C80")]
		private static bool _TryCastValue<T>(Utf8JsonReader reader, [Out] object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E7F")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected JsonSerializable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	internal static class _JSonSerializationExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000E80")]
		[Cpp2IlInjected.Address(RVA = "0xA743F60", Offset = "0xA742F60", VA = "0x18A743F60")]
		public static bool AsBoolean([In] this Utf8JsonReader reader)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E81")]
		[Cpp2IlInjected.Address(RVA = "0xA744580", Offset = "0xA743580", VA = "0x18A744580")]
		public static string AsString([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E82")]
		[Cpp2IlInjected.Address(RVA = "0xA744090", Offset = "0xA743090", VA = "0x18A744090")]
		public static object AsEnum([In] this Utf8JsonReader reader, Type enumType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E83")]
		[Cpp2IlInjected.Address(RVA = "0xA7448E0", Offset = "0xA7438E0", VA = "0x18A7448E0")]
		public static object GetAnyValue([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E84")]
		[Cpp2IlInjected.Address(RVA = "0xA744BF0", Offset = "0xA743BF0", VA = "0x18A744BF0")]
		public static object GetValueAs([In] this Utf8JsonReader reader, Type vtype)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E85")]
		[Cpp2IlInjected.Address(RVA = "0x413D550", Offset = "0x413C550", VA = "0x18413D550")]
		public static T GetValueAs<T>([In] this Utf8JsonReader reader) where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E86")]
		[Cpp2IlInjected.Address(RVA = "0xA745C90", Offset = "0xA744C90", VA = "0x18A745C90")]
		public static bool TryWriteProperty(this Utf8JsonWriter writer, string property, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E87")]
		[Cpp2IlInjected.Address(RVA = "0xA746530", Offset = "0xA745530", VA = "0x18A746530")]
		public static bool TryWriteValue(this Utf8JsonWriter writer, object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E88")]
		[Cpp2IlInjected.Address(RVA = "0xA746F40", Offset = "0xA745F40", VA = "0x18A746F40")]
		public static void WriteVector2(this Utf8JsonWriter writer, Vector2 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E89")]
		[Cpp2IlInjected.Address(RVA = "0xA746FA0", Offset = "0xA745FA0", VA = "0x18A746FA0")]
		public static void WriteVector3(this Utf8JsonWriter writer, Vector3 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8A")]
		[Cpp2IlInjected.Address(RVA = "0xA746E70", Offset = "0xA745E70", VA = "0x18A746E70")]
		public static void WriteVector4(this Utf8JsonWriter writer, Vector4 v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8B")]
		[Cpp2IlInjected.Address(RVA = "0xA746E70", Offset = "0xA745E70", VA = "0x18A746E70")]
		public static void WriteQuaternion(this Utf8JsonWriter writer, Quaternion q)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8C")]
		[Cpp2IlInjected.Address(RVA = "0xA746D30", Offset = "0xA745D30", VA = "0x18A746D30")]
		public static void WriteMatrix4x4(this Utf8JsonWriter writer, Matrix4x4 m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8D")]
		[Cpp2IlInjected.Address(RVA = "0xA744430", Offset = "0xA743430", VA = "0x18A744430")]
		public static Uri AsStringUri([In] this Utf8JsonReader reader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8E")]
		[Cpp2IlInjected.Address(RVA = "0xA746EF0", Offset = "0xA745EF0", VA = "0x18A746EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		public IReadOnlyDictionary<string, JsonNode> Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000E91")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E8F")]
		[Cpp2IlInjected.Address(RVA = "0xA743770", Offset = "0xA742770", VA = "0x18A743770")]
		public UnknownNode(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E92")]
		[Cpp2IlInjected.Address(RVA = "0xA743500", Offset = "0xA742500", VA = "0x18A743500", Slot = "8")]
		protected override void DeserializeProperty(string property, Utf8JsonReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000E93")]
		[Cpp2IlInjected.Address(RVA = "0xA743580", Offset = "0xA742580", VA = "0x18A743580", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xA739C90", Offset = "0xA738C90", VA = "0x18A739C90")]
		internal static string GetAttributeShortName(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E95")]
		[Cpp2IlInjected.Address(RVA = "0xA73A6C0", Offset = "0xA7396C0", VA = "0x18A73A6C0")]
		public static string ToReport(this MemoryAccessInfo minfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E96")]
		[Cpp2IlInjected.Address(RVA = "0xA73A4D0", Offset = "0xA7394D0", VA = "0x18A73A4D0")]
		public static string ToReport(this BufferView bv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E97")]
		[Cpp2IlInjected.Address(RVA = "0xA73A420", Offset = "0xA739420", VA = "0x18A73A420")]
		public static string ToReportShort(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E98")]
		[Cpp2IlInjected.Address(RVA = "0xA73A1B0", Offset = "0xA7391B0", VA = "0x18A73A1B0")]
		public static string ToReportLong(this Accessor accessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000E99")]
		[Cpp2IlInjected.Address(RVA = "0xA73A830", Offset = "0xA739830", VA = "0x18A73A830")]
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
			[Cpp2IlInjected.Address(RVA = "0x515C380", Offset = "0x515B380", VA = "0x18515C380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA2")]
		[Cpp2IlInjected.Address(RVA = "0x515C2F0", Offset = "0x515B2F0", VA = "0x18515C2F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA743F40", Offset = "0xA742F40", VA = "0x18A743F40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		public int ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA6")]
			[Cpp2IlInjected.Address(RVA = "0xA743F20", Offset = "0xA742F20", VA = "0x18A743F20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		public int ByteLength
		{
			[Cpp2IlInjected.Token(Token = "0x6000EA7")]
			[Cpp2IlInjected.Address(RVA = "0xA743EA0", Offset = "0xA742EA0", VA = "0x18A743EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA743E50", Offset = "0xA742E50", VA = "0x18A743E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA4")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7438C0", Offset = "0xA7428C0", VA = "0x18A7438C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		public BufferView Source
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAB")]
			[Cpp2IlInjected.Address(RVA = "0xA743D00", Offset = "0xA742D00", VA = "0x18A743D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		public (DimensionType Dimensions, EncodingType Encoding, bool Normalized) Format
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAC")]
			[Cpp2IlInjected.Address(RVA = "0xA743810", Offset = "0xA742810", VA = "0x18A743810")]
			get
			{
				return default((DimensionType, EncodingType, bool));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		public object[] Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000EAD")]
			[Cpp2IlInjected.Address(RVA = "0xA743940", Offset = "0xA742940", VA = "0x18A743940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EA9")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FB8890", Offset = "0x1FB7890", VA = "0x181FB8890")]
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
			[Cpp2IlInjected.Address(RVA = "0xA747280", Offset = "0xA746280", VA = "0x18A747280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EAE")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA747080", Offset = "0xA746080", VA = "0x18A747080")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		public (double X, double Y, double Z, double W) Row2
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB3")]
			[Cpp2IlInjected.Address(RVA = "0xA747100", Offset = "0xA746100", VA = "0x18A747100")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		public (double X, double Y, double Z, double W) Row3
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB4")]
			[Cpp2IlInjected.Address(RVA = "0xA747180", Offset = "0xA746180", VA = "0x18A747180")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public (double X, double Y, double Z, double W) Row4
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB5")]
			[Cpp2IlInjected.Address(RVA = "0xA747200", Offset = "0xA746200", VA = "0x18A747200")]
			get
			{
				return default((double, double, double, double));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB1")]
		[Cpp2IlInjected.Address(RVA = "0xA747010", Offset = "0xA746010", VA = "0x18A747010")]
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
			[Cpp2IlInjected.Address(RVA = "0x5101180", Offset = "0x5100180", VA = "0x185101180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		public ICollection<string> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB8")]
			[Cpp2IlInjected.Address(RVA = "0x5101970", Offset = "0x5100970", VA = "0x185101970", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		IEnumerable<T> IReadOnlyDictionary<string, T>.Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EB9")]
			[Cpp2IlInjected.Address(RVA = "0x5101210", Offset = "0x5100210", VA = "0x185101210", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		public ICollection<T> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBA")]
			[Cpp2IlInjected.Address(RVA = "0x51019F0", Offset = "0x51009F0", VA = "0x1851019F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBB")]
			[Cpp2IlInjected.Address(RVA = "0x51018B0", Offset = "0x51008B0", VA = "0x1851018B0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBC")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		public T this[string key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000EBD")]
			[Cpp2IlInjected.Address(RVA = "0x51018E0", Offset = "0x51008E0", VA = "0x1851018E0", Slot = "12")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000EBE")]
			[Cpp2IlInjected.Address(RVA = "0x5101A40", Offset = "0x5100A40", VA = "0x185101A40", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EB6")]
		[Cpp2IlInjected.Address(RVA = "0x51017E0", Offset = "0x51007E0", VA = "0x1851017E0")]
		public ChildrenDictionary(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EBF")]
		[Cpp2IlInjected.Address(RVA = "0x5100B00", Offset = "0x50FFB00", VA = "0x185100B00", Slot = "23")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC0")]
		[Cpp2IlInjected.Address(RVA = "0x51009B0", Offset = "0x50FF9B0", VA = "0x1851009B0", Slot = "17")]
		public void Add(string key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC1")]
		[Cpp2IlInjected.Address(RVA = "0x5101050", Offset = "0x5100050", VA = "0x185101050", Slot = "18")]
		public bool Remove(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC2")]
		[Cpp2IlInjected.Address(RVA = "0x5100D10", Offset = "0x50FFD10", VA = "0x185100D10", Slot = "16")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC3")]
		[Cpp2IlInjected.Address(RVA = "0x5101410", Offset = "0x5100410", VA = "0x185101410", Slot = "19")]
		public bool TryGetValue(string key, [Out] T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC4")]
		[Cpp2IlInjected.Address(RVA = "0x5100F10", Offset = "0x50FFF10", VA = "0x185100F10", Slot = "10")]
		public IEnumerator<KeyValuePair<string, T>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC5")]
		[Cpp2IlInjected.Address(RVA = "0x5100F10", Offset = "0x50FFF10", VA = "0x185100F10", Slot = "11")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC6")]
		[Cpp2IlInjected.Address(RVA = "0x5101580", Offset = "0x5100580", VA = "0x185101580")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC7")]
		[Cpp2IlInjected.Address(RVA = "0x107CA40", Offset = "0x107BA40", VA = "0x18107CA40")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC8")]
		[Cpp2IlInjected.Address(RVA = "0x5100990", Offset = "0x50FF990", VA = "0x185100990", Slot = "22")]
		public void Add(KeyValuePair<string, T> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EC9")]
		[Cpp2IlInjected.Address(RVA = "0x5100D40", Offset = "0x50FFD40", VA = "0x185100D40", Slot = "24")]
		public bool Contains(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECA")]
		[Cpp2IlInjected.Address(RVA = "0x5101030", Offset = "0x5100030", VA = "0x185101030", Slot = "26")]
		public bool Remove(KeyValuePair<string, T> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECB")]
		[Cpp2IlInjected.Address(RVA = "0x5100D80", Offset = "0x50FFD80", VA = "0x185100D80", Slot = "25")]
		public void CopyTo(KeyValuePair<string, T>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECC")]
		[Cpp2IlInjected.Address(RVA = "0x5100F90", Offset = "0x50FFF90", VA = "0x185100F90", Slot = "27")]
		public IEnumerable<SharpGLTF.Reflection.FieldInfo> GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ECD")]
		[Cpp2IlInjected.Address(RVA = "0x5101270", Offset = "0x5100270", VA = "0x185101270", Slot = "28")]
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
				[Cpp2IlInjected.Address(RVA = "0x5088B00", Offset = "0x5087B00", VA = "0x185088B00", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D5FCE0", Offset = "0x6D5ECE0", VA = "0x186D5FCE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEB")]
			[Cpp2IlInjected.Address(RVA = "0x667DA70", Offset = "0x667CA70", VA = "0x18667DA70")]
			[DebuggerHidden]
			public <SharpGLTF-Reflection-IReflectionObject-GetFields>d__22(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEC")]
			[Cpp2IlInjected.Address(RVA = "0x67148C0", Offset = "0x67138C0", VA = "0x1867148C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EED")]
			[Cpp2IlInjected.Address(RVA = "0x6D5FAD0", Offset = "0x6D5EAD0", VA = "0x186D5FAD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000EEF")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF1")]
			[Cpp2IlInjected.Address(RVA = "0x667D560", Offset = "0x667C560", VA = "0x18667D560", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SharpGLTF.Reflection.FieldInfo> IEnumerable<SharpGLTF.Reflection.FieldInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000EF2")]
			[Cpp2IlInjected.Address(RVA = "0x6D5FC20", Offset = "0x6D5EC20", VA = "0x186D5FC20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5102A80", Offset = "0x5101A80", VA = "0x185102A80", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ED5")]
			[Cpp2IlInjected.Address(RVA = "0x5102B00", Offset = "0x5101B00", VA = "0x185102B00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000ED6")]
			[Cpp2IlInjected.Address(RVA = "0x5102A60", Offset = "0x5101A60", VA = "0x185102A60", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED3")]
		[Cpp2IlInjected.Address(RVA = "0x5102990", Offset = "0x5101990", VA = "0x185102990")]
		public ChildrenList(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED8")]
		[Cpp2IlInjected.Address(RVA = "0x5101DF0", Offset = "0x5100DF0", VA = "0x185101DF0", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ED9")]
		[Cpp2IlInjected.Address(RVA = "0x5101F70", Offset = "0x5100F70", VA = "0x185101F70", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDA")]
		[Cpp2IlInjected.Address(RVA = "0x5101E10", Offset = "0x5100E10", VA = "0x185101E10", Slot = "14")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDB")]
		[Cpp2IlInjected.Address(RVA = "0x5101A60", Offset = "0x5100A60", VA = "0x185101A60", Slot = "11")]
		public void Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDC")]
		[Cpp2IlInjected.Address(RVA = "0x5101BE0", Offset = "0x5100BE0", VA = "0x185101BE0", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDD")]
		[Cpp2IlInjected.Address(RVA = "0x5101FA0", Offset = "0x5100FA0", VA = "0x185101FA0", Slot = "7")]
		public void Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDE")]
		[Cpp2IlInjected.Address(RVA = "0x5102390", Offset = "0x5101390", VA = "0x185102390", Slot = "15")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EDF")]
		[Cpp2IlInjected.Address(RVA = "0x5102110", Offset = "0x5101110", VA = "0x185102110", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE0")]
		[Cpp2IlInjected.Address(RVA = "0x5101E30", Offset = "0x5100E30", VA = "0x185101E30", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE1")]
		[Cpp2IlInjected.Address(RVA = "0x5101E30", Offset = "0x5100E30", VA = "0x185101E30", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE2")]
		[Cpp2IlInjected.Address(RVA = "0x51027C0", Offset = "0x51017C0", VA = "0x1851027C0")]
		private static void _VerifyIsOrphan(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE3")]
		[Cpp2IlInjected.Address(RVA = "0x107CA40", Offset = "0x107BA40", VA = "0x18107CA40")]
		[Conditional("DEBUG")]
		private void _AssertItem(T item, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE4")]
		[Cpp2IlInjected.Address(RVA = "0x5102590", Offset = "0x5101590", VA = "0x185102590", Slot = "22")]
		[IteratorStateMachine(typeof(ChildrenList<, >.<SharpGLTF-Reflection-IReflectionObject-GetFields>d__22))]
		IEnumerable<SharpGLTF.Reflection.FieldInfo> IReflectionObject.GetFields()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE5")]
		[Cpp2IlInjected.Address(RVA = "0x5102410", Offset = "0x5101410", VA = "0x185102410", Slot = "21")]
		SharpGLTF.Reflection.FieldInfo IReflectionArray.GetField(int index)
		{
			return default(SharpGLTF.Reflection.FieldInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000EE6")]
		[Cpp2IlInjected.Address(RVA = "0x5102620", Offset = "0x5101620", VA = "0x185102620", Slot = "23")]
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
		[Cpp2IlInjected.Address(RVA = "0x51008D0", Offset = "0x50FF8D0", VA = "0x1851008D0")]
		public ChildSetter(TParent parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000EF4")]
		[Cpp2IlInjected.Address(RVA = "0x36E7660", Offset = "0x36E6660", VA = "0x1836E7660")]
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
			[Cpp2IlInjected.Address(RVA = "0x799E840", Offset = "0x799D840", VA = "0x18799E840", Slot = "6")]
			get
			{
				return (TValueOut)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000EFF")]
			[Cpp2IlInjected.Address(RVA = "0x799EBE0", Offset = "0x799DBE0", VA = "0x18799EBE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		public IEnumerable<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F00")]
			[Cpp2IlInjected.Address(RVA = "0x799EC40", Offset = "0x799DC40", VA = "0x18799EC40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F01")]
			[Cpp2IlInjected.Address(RVA = "0x799E7E0", Offset = "0x799D7E0", VA = "0x18799E7E0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000EFD")]
		[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
		public ReadOnlyLinqDictionary(IReadOnlyDictionary<TKey, TValueIn> dict, Converter<TValueIn, TValueOut> valConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F02")]
		[Cpp2IlInjected.Address(RVA = "0x799DAC0", Offset = "0x799CAC0", VA = "0x18799DAC0", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F03")]
		[Cpp2IlInjected.Address(RVA = "0x799E690", Offset = "0x799D690", VA = "0x18799E690", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F04")]
		[Cpp2IlInjected.Address(RVA = "0x799DD70", Offset = "0x799CD70", VA = "0x18799DD70", Slot = "10")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F05")]
		[Cpp2IlInjected.Address(RVA = "0x799DF40", Offset = "0x799CF40", VA = "0x18799DF40", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A06DE0", Offset = "0x6A05DE0", VA = "0x186A06DE0", Slot = "4")]
			get
			{
				return (TValueOut)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000F0E")]
			[Cpp2IlInjected.Address(RVA = "0x6A073E0", Offset = "0x6A063E0", VA = "0x186A073E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public ICollection<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000F0F")]
			[Cpp2IlInjected.Address(RVA = "0x6A070F0", Offset = "0x6A060F0", VA = "0x186A070F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public ICollection<TValueOut> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000F10")]
			[Cpp2IlInjected.Address(RVA = "0x6A07150", Offset = "0x6A06150", VA = "0x186A07150", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000F11")]
			[Cpp2IlInjected.Address(RVA = "0x6A06D40", Offset = "0x6A05D40", VA = "0x186A06D40", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x6000F12")]
			[Cpp2IlInjected.Address(RVA = "0x6A06DA0", Offset = "0x6A05DA0", VA = "0x186A06DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0C")]
		[Cpp2IlInjected.Address(RVA = "0x1F2E2E0", Offset = "0x1F2D2E0", VA = "0x181F2E2E0")]
		public LinqDictionary(IDictionary<TKey, TValueIn> dict, Converter<TValueOut, TValueIn> inConverter, Converter<TValueIn, TValueOut> outConverter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F13")]
		[Cpp2IlInjected.Address(RVA = "0x6A06260", Offset = "0x6A05260", VA = "0x186A06260", Slot = "8")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F14")]
		[Cpp2IlInjected.Address(RVA = "0x6A06980", Offset = "0x6A05980", VA = "0x186A06980", Slot = "11")]
		public bool TryGetValue(TKey key, [Out] TValueOut value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F15")]
		[Cpp2IlInjected.Address(RVA = "0x6A063B0", Offset = "0x6A053B0", VA = "0x186A063B0", Slot = "19")]
		public IEnumerator<KeyValuePair<TKey, TValueOut>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F16")]
		[Cpp2IlInjected.Address(RVA = "0x6A06740", Offset = "0x6A05740", VA = "0x186A06740", Slot = "20")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F17")]
		[Cpp2IlInjected.Address(RVA = "0x6A05FE0", Offset = "0x6A04FE0", VA = "0x186A05FE0", Slot = "9")]
		public void Add(TKey key, TValueOut value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F18")]
		[Cpp2IlInjected.Address(RVA = "0x6A065F0", Offset = "0x6A055F0", VA = "0x186A065F0", Slot = "10")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F19")]
		[Cpp2IlInjected.Address(RVA = "0x6A05D90", Offset = "0x6A04D90", VA = "0x186A05D90", Slot = "14")]
		public void Add(KeyValuePair<TKey, TValueOut> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1A")]
		[Cpp2IlInjected.Address(RVA = "0x6A06200", Offset = "0x6A05200", VA = "0x186A06200", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1B")]
		[Cpp2IlInjected.Address(RVA = "0x3C07E40", Offset = "0x3C06E40", VA = "0x183C07E40", Slot = "16")]
		public bool Contains(KeyValuePair<TKey, TValueOut> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1C")]
		[Cpp2IlInjected.Address(RVA = "0x3C07C80", Offset = "0x3C06C80", VA = "0x183C07C80", Slot = "17")]
		public void CopyTo(KeyValuePair<TKey, TValueOut>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F1D")]
		[Cpp2IlInjected.Address(RVA = "0x3C07E40", Offset = "0x3C06E40", VA = "0x183C07E40", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private ReferenceComparer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F25")]
		[Cpp2IlInjected.Address(RVA = "0x171C8B0", Offset = "0x171B8B0", VA = "0x18171C8B0", Slot = "4")]
		public bool Equals(T x, T y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F26")]
		[Cpp2IlInjected.Address(RVA = "0x7A34380", Offset = "0x7A33380", VA = "0x187A34380", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4C")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public <SplitByTime>d__11(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4D")]
			[Cpp2IlInjected.Address(RVA = "0x6DF9490", Offset = "0x6DF8490", VA = "0x186DF9490", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4E")]
			[Cpp2IlInjected.Address(RVA = "0x6DF1480", Offset = "0x6DF0480", VA = "0x186DF1480", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F4F")]
			[Cpp2IlInjected.Address(RVA = "0x6DFA180", Offset = "0x6DF9180", VA = "0x186DFA180")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F51")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000F53")]
			[Cpp2IlInjected.Address(RVA = "0x4F220F0", Offset = "0x4F210F0", VA = "0x184F220F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(float, T)[]> IEnumerable<(float, T)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000F54")]
			[Cpp2IlInjected.Address(RVA = "0x6DF8B30", Offset = "0x6DF7B30", VA = "0x186DF8B30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA738000", Offset = "0xA737000", VA = "0x18A738000")]
		internal static string CurveError(int maxDegree)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F29")]
		[Cpp2IlInjected.Address(RVA = "0xA737BE0", Offset = "0xA736BE0", VA = "0x18A737BE0")]
		public static Vector3 CreateTangent(Vector3 fromValue, Vector3 toValue, float scale = 1f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2A")]
		[Cpp2IlInjected.Address(RVA = "0xA737CC0", Offset = "0xA736CC0", VA = "0x18A737CC0")]
		public static Quaternion CreateTangent(Quaternion fromValue, Quaternion toValue, float scale = 1f)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2B")]
		[Cpp2IlInjected.Address(RVA = "0xA737E40", Offset = "0xA736E40", VA = "0x18A737E40")]
		public static float[] CreateTangent(float[] fromValue, float[] toValue, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2C")]
		[Cpp2IlInjected.Address(RVA = "0xA735C20", Offset = "0xA734C20", VA = "0x18A735C20")]
		public static (float, float, float, float) CreateHermitePointWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2D")]
		[Cpp2IlInjected.Address(RVA = "0xA735CC0", Offset = "0xA734CC0", VA = "0x18A735CC0")]
		public static (float, float, float, float) CreateHermiteTangentWeights(float amount)
		{
			return default((float, float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2E")]
		[Cpp2IlInjected.Address(RVA = "0x38DFE90", Offset = "0x38DEE90", VA = "0x1838DFE90")]
		public static (T, T, float) FindRangeContainingOffset<T>(this IEnumerable<(float Key, T Value)> sequence, float offset)
		{
			return default((T, T, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F2F")]
		[Cpp2IlInjected.Address(RVA = "0xA738090", Offset = "0xA737090", VA = "0x18A738090")]
		public static (float, float, float) FindRangeContainingOffset(IEnumerable<float> sequence, float offset)
		{
			return default((float, float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000F30")]
		[Cpp2IlInjected.Address(RVA = "0x3392F20", Offset = "0x3391F20", VA = "0x183392F20")]
		[IteratorStateMachine(typeof(<SplitByTime>d__11<>))]
		internal static IEnumerable<(float, T)[]> SplitByTime<T>(this IEnumerable<(float Time, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F31")]
		[Cpp2IlInjected.Address(RVA = "0xA7399A0", Offset = "0xA7389A0", VA = "0x18A7399A0")]
		public static float[] Subtract(IReadOnlyList<float> left, IReadOnlyList<float> right)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F32")]
		[Cpp2IlInjected.Address(RVA = "0xA7396D0", Offset = "0xA7386D0", VA = "0x18A7396D0")]
		public static float[] InterpolateLinear(IReadOnlyList<float> start, IReadOnlyList<float> end, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F33")]
		[Cpp2IlInjected.Address(RVA = "0xA738AF0", Offset = "0xA737AF0", VA = "0x18A738AF0")]
		public static float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F34")]
		[Cpp2IlInjected.Address(RVA = "0xA7385D0", Offset = "0xA7375D0", VA = "0x18A7385D0")]
		public static Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F35")]
		[Cpp2IlInjected.Address(RVA = "0xA7387F0", Offset = "0xA7377F0", VA = "0x18A7387F0")]
		public static Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F36")]
		[Cpp2IlInjected.Address(RVA = "0xA738C10", Offset = "0xA737C10", VA = "0x18A738C10")]
		public static Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F37")]
		[Cpp2IlInjected.Address(RVA = "0xA7394F0", Offset = "0xA7384F0", VA = "0x18A7394F0")]
		public static Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F38")]
		[Cpp2IlInjected.Address(RVA = "0xA738F50", Offset = "0xA737F50", VA = "0x18A738F50")]
		public static float[] InterpolateCubic(IReadOnlyList<float> start, IReadOnlyList<float> outgoingTangent, IReadOnlyList<float> end, IReadOnlyList<float> incomingTangent, float amount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F39")]
		[Cpp2IlInjected.Address(RVA = "0x38EB6B0", Offset = "0x38EA6B0", VA = "0x1838EB6B0")]
		private static bool _HasZero<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3A")]
		[Cpp2IlInjected.Address(RVA = "0x38EB230", Offset = "0x38EA230", VA = "0x1838EB230")]
		private static bool _HasOne<T>(this IEnumerable<T> collection)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3B")]
		[Cpp2IlInjected.Address(RVA = "0xA7371E0", Offset = "0xA7361E0", VA = "0x18A7371E0")]
		public static ICurveSampler<bool> CreateSampler(this IEnumerable<(float, bool)> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3C")]
		[Cpp2IlInjected.Address(RVA = "0xA7365A0", Offset = "0xA7355A0", VA = "0x18A7365A0")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, float)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3D")]
		[Cpp2IlInjected.Address(RVA = "0xA736940", Offset = "0xA735940", VA = "0x18A736940")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, Vector2)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3E")]
		[Cpp2IlInjected.Address(RVA = "0xA736FA0", Offset = "0xA735FA0", VA = "0x18A736FA0")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, Vector3)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F3F")]
		[Cpp2IlInjected.Address(RVA = "0xA737340", Offset = "0xA736340", VA = "0x18A737340")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, Vector4)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F40")]
		[Cpp2IlInjected.Address(RVA = "0xA736120", Offset = "0xA735120", VA = "0x18A736120")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, Quaternion)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F41")]
		[Cpp2IlInjected.Address(RVA = "0xA737580", Offset = "0xA736580", VA = "0x18A737580")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, float[])> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F42")]
		[Cpp2IlInjected.Address(RVA = "0xA735D80", Offset = "0xA734D80", VA = "0x18A735D80")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, ArraySegment<float>)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F43")]
		[Cpp2IlInjected.Address(RVA = "0xA736360", Offset = "0xA735360", VA = "0x18A736360")]
		public static ICurveSampler<SparseWeight8> CreateSampler(this IEnumerable<(float, SparseWeight8)> collection, bool isLinear = true, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F44")]
		[Cpp2IlInjected.Address(RVA = "0xA7377C0", Offset = "0xA7367C0", VA = "0x18A7377C0")]
		public static ICurveSampler<float> CreateSampler(this IEnumerable<(float, (float, float, float))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F45")]
		[Cpp2IlInjected.Address(RVA = "0xA736E40", Offset = "0xA735E40", VA = "0x18A736E40")]
		public static ICurveSampler<Vector2> CreateSampler(this IEnumerable<(float, (Vector2, Vector2, Vector2))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F46")]
		[Cpp2IlInjected.Address(RVA = "0xA736CE0", Offset = "0xA735CE0", VA = "0x18A736CE0")]
		public static ICurveSampler<Vector3> CreateSampler(this IEnumerable<(float, (Vector3, Vector3, Vector3))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F47")]
		[Cpp2IlInjected.Address(RVA = "0xA737A80", Offset = "0xA736A80", VA = "0x18A737A80")]
		public static ICurveSampler<Vector4> CreateSampler(this IEnumerable<(float, (Vector4, Vector4, Vector4))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F48")]
		[Cpp2IlInjected.Address(RVA = "0xA737920", Offset = "0xA736920", VA = "0x18A737920")]
		public static ICurveSampler<Quaternion> CreateSampler(this IEnumerable<(float, (Quaternion, Quaternion, Quaternion))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F49")]
		[Cpp2IlInjected.Address(RVA = "0xA7367E0", Offset = "0xA7357E0", VA = "0x18A7367E0")]
		public static ICurveSampler<float[]> CreateSampler(this IEnumerable<(float, (float[], float[], float[]))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4A")]
		[Cpp2IlInjected.Address(RVA = "0xA735FC0", Offset = "0xA734FC0", VA = "0x18A735FC0")]
		public static ICurveSampler<ArraySegment<float>> CreateSampler(this IEnumerable<(float, (ArraySegment<float>, ArraySegment<float>, ArraySegment<float>))> collection, bool optimize = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F4B")]
		[Cpp2IlInjected.Address(RVA = "0xA736B80", Offset = "0xA735B80", VA = "0x18A736B80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD7A0A0", Offset = "0xD790A0", VA = "0x180D7A0A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F55")]
		[Cpp2IlInjected.Address(RVA = "0x5383720", Offset = "0x5382720", VA = "0x185383720", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F56")]
		[Cpp2IlInjected.Address(RVA = "0x5388EA0", Offset = "0x5387EA0", VA = "0x185388EA0")]
		public CubicSampler(IEnumerable<(float, (T, T, T))> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F58")]
		[Cpp2IlInjected.Address(RVA = "0x5385650", Offset = "0x5384650", VA = "0x185385650", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F59")]
		[Cpp2IlInjected.Address(RVA = "0x5385E00", Offset = "0x5384E00", VA = "0x185385E00", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5A")]
		[Cpp2IlInjected.Address(RVA = "0x5385E00", Offset = "0x5384E00", VA = "0x185385E00", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5B")]
		[Cpp2IlInjected.Address(RVA = "0x53878C0", Offset = "0x53868C0", VA = "0x1853878C0", Slot = "9")]
		IReadOnlyDictionary<float, (T, T, T)> IConvertibleCurve<T>.ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F5C")]
		[Cpp2IlInjected.Address(RVA = "0x53884D0", Offset = "0x53874D0", VA = "0x1853884D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F66")]
		[Cpp2IlInjected.Address(RVA = "0x633B670", Offset = "0x633A670", VA = "0x18633B670")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, T Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F67")]
		[Cpp2IlInjected.Address(RVA = "0x633AEE0", Offset = "0x6339EE0", VA = "0x18633AEE0")]
		public static ICurveSampler<T> Create(IEnumerable<(float Key, (T, T, T) Value)> sequence)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F68")]
		[Cpp2IlInjected.Address(RVA = "0x633A9A0", Offset = "0x63399A0", VA = "0x18633A9A0", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F69")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC60", Offset = "0x12BEC60", VA = "0x1812BFC60")]
		private FixedSampler(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6B")]
		[Cpp2IlInjected.Address(RVA = "0x12BFC30", Offset = "0x12BEC30", VA = "0x1812BFC30", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6C")]
		[Cpp2IlInjected.Address(RVA = "0x633BFC0", Offset = "0x633AFC0", VA = "0x18633BFC0", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6D")]
		[Cpp2IlInjected.Address(RVA = "0x633BFC0", Offset = "0x633AFC0", VA = "0x18633BFC0", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6E")]
		[Cpp2IlInjected.Address(RVA = "0x633CB70", Offset = "0x633BB70", VA = "0x18633CB70", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F6F")]
		[Cpp2IlInjected.Address(RVA = "0x69AF350", Offset = "0x69AE350", VA = "0x1869AF350", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F70")]
		[Cpp2IlInjected.Address(RVA = "0x5388EA0", Offset = "0x5387EA0", VA = "0x185388EA0")]
		public LinearSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F72")]
		[Cpp2IlInjected.Address(RVA = "0x69AF790", Offset = "0x69AE790", VA = "0x1869AF790", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F73")]
		[Cpp2IlInjected.Address(RVA = "0x69B04C0", Offset = "0x69AF4C0", VA = "0x1869B04C0", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F74")]
		[Cpp2IlInjected.Address(RVA = "0x69B0110", Offset = "0x69AF110", VA = "0x1869B0110", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F75")]
		[Cpp2IlInjected.Address(RVA = "0x69B04C0", Offset = "0x69AF4C0", VA = "0x1869B04C0", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F76")]
		[Cpp2IlInjected.Address(RVA = "0x69AFBD0", Offset = "0x69AEBD0", VA = "0x1869AFBD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F80")]
		[Cpp2IlInjected.Address(RVA = "0x69AF350", Offset = "0x69AE350", VA = "0x1869AF350", Slot = "6")]
		public IConvertibleCurve<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F81")]
		[Cpp2IlInjected.Address(RVA = "0x5388EA0", Offset = "0x5387EA0", VA = "0x185388EA0")]
		public StepSampler(IEnumerable<(float, T)> sequence, ISamplerTraits<T> traits)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000F83")]
		[Cpp2IlInjected.Address(RVA = "0x7C15380", Offset = "0x7C14380", VA = "0x187C15380", Slot = "4")]
		public T GetPoint(float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F84")]
		[Cpp2IlInjected.Address(RVA = "0x7C16470", Offset = "0x7C15470", VA = "0x187C16470", Slot = "7")]
		public IReadOnlyDictionary<float, T> ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F85")]
		[Cpp2IlInjected.Address(RVA = "0x7C16350", Offset = "0x7C15350", VA = "0x187C16350", Slot = "8")]
		public IReadOnlyDictionary<float, T> ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F86")]
		[Cpp2IlInjected.Address(RVA = "0x7C16350", Offset = "0x7C15350", VA = "0x187C16350", Slot = "9")]
		public IReadOnlyDictionary<float, (T, T, T)> ToSplineCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000F87")]
		[Cpp2IlInjected.Address(RVA = "0x69AFBD0", Offset = "0x69AEBD0", VA = "0x1869AFBD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1416C40", Offset = "0x1415C40", VA = "0x181416C40", Slot = "4")]
			public bool Clone(bool value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F96")]
			[Cpp2IlInjected.Address(RVA = "0xA743E30", Offset = "0xA742E30", VA = "0x18A743E30", Slot = "5")]
			public bool InterpolateLinear(bool left, bool right, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F97")]
			[Cpp2IlInjected.Address(RVA = "0xA743E10", Offset = "0xA742E10", VA = "0x18A743E10", Slot = "6")]
			public bool InterpolateCubic(bool start, bool outgoingTangent, bool end, bool incomingTangent, float amount)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F98")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public _Boolean()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		private sealed class _Scalar : ISamplerTraits<float>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F99")]
			[Cpp2IlInjected.Address(RVA = "0xF1AB10", Offset = "0xF19B10", VA = "0x180F1AB10", Slot = "4")]
			public float Clone(float value)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9A")]
			[Cpp2IlInjected.Address(RVA = "0xA747600", Offset = "0xA746600", VA = "0x18A747600", Slot = "5")]
			public float InterpolateLinear(float left, float right, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9B")]
			[Cpp2IlInjected.Address(RVA = "0xA7474F0", Offset = "0xA7464F0", VA = "0x18A7474F0", Slot = "6")]
			public float InterpolateCubic(float start, float outgoingTangent, float end, float incomingTangent, float amount)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9C")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public _Scalar()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AE")]
		private sealed class _Vector2 : ISamplerTraits<Vector2>
		{
			[Cpp2IlInjected.Token(Token = "0x6000F9D")]
			[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "4")]
			public Vector2 Clone(Vector2 value)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9E")]
			[Cpp2IlInjected.Address(RVA = "0xA7479C0", Offset = "0xA7469C0", VA = "0x18A7479C0", Slot = "5")]
			public Vector2 InterpolateLinear(Vector2 left, Vector2 right, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000F9F")]
			[Cpp2IlInjected.Address(RVA = "0xA747980", Offset = "0xA746980", VA = "0x18A747980", Slot = "6")]
			public Vector2 InterpolateCubic(Vector2 start, Vector2 outgoingTangent, Vector2 end, Vector2 incomingTangent, float amount)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA0")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public _Vector2()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private sealed class _Vector3 : ISamplerTraits<Vector3>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA1")]
			[Cpp2IlInjected.Address(RVA = "0x1049510", Offset = "0x1048510", VA = "0x181049510", Slot = "4")]
			public Vector3 Clone(Vector3 value)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA2")]
			[Cpp2IlInjected.Address(RVA = "0xA747AE0", Offset = "0xA746AE0", VA = "0x18A747AE0", Slot = "5")]
			public Vector3 InterpolateLinear(Vector3 left, Vector3 right, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA3")]
			[Cpp2IlInjected.Address(RVA = "0xA747A20", Offset = "0xA746A20", VA = "0x18A747A20", Slot = "6")]
			public Vector3 InterpolateCubic(Vector3 start, Vector3 outgoingTangent, Vector3 end, Vector3 incomingTangent, float amount)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA4")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public _Vector3()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B0")]
		private sealed class _Vector4 : ISamplerTraits<Vector4>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA5")]
			[Cpp2IlInjected.Address(RVA = "0x12B0130", Offset = "0x12AF130", VA = "0x1812B0130", Slot = "4")]
			public Vector4 Clone(Vector4 value)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA6")]
			[Cpp2IlInjected.Address(RVA = "0xA747BE0", Offset = "0xA746BE0", VA = "0x18A747BE0", Slot = "5")]
			public Vector4 InterpolateLinear(Vector4 left, Vector4 right, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA7")]
			[Cpp2IlInjected.Address(RVA = "0xA747B50", Offset = "0xA746B50", VA = "0x18A747B50", Slot = "6")]
			public Vector4 InterpolateCubic(Vector4 start, Vector4 outgoingTangent, Vector4 end, Vector4 incomingTangent, float amount)
			{
				return default(Vector4);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FA8")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public _Vector4()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B1")]
		private sealed class _Quaternion : ISamplerTraits<Quaternion>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FA9")]
			[Cpp2IlInjected.Address(RVA = "0x12B0130", Offset = "0x12AF130", VA = "0x1812B0130", Slot = "4")]
			public Quaternion Clone(Quaternion value)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAA")]
			[Cpp2IlInjected.Address(RVA = "0xA7474A0", Offset = "0xA7464A0", VA = "0x18A7474A0", Slot = "5")]
			public Quaternion InterpolateLinear(Quaternion left, Quaternion right, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAB")]
			[Cpp2IlInjected.Address(RVA = "0xA7472D0", Offset = "0xA7462D0", VA = "0x18A7472D0", Slot = "6")]
			public Quaternion InterpolateCubic(Quaternion start, Quaternion outgoingTangent, Quaternion end, Quaternion incomingTangent, float amount)
			{
				return default(Quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAC")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public _Quaternion()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		private sealed class _Array : ISamplerTraits<float[]>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FAD")]
			[Cpp2IlInjected.Address(RVA = "0xA743D40", Offset = "0xA742D40", VA = "0x18A743D40", Slot = "4")]
			public float[] Clone(float[] value)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAE")]
			[Cpp2IlInjected.Address(RVA = "0xA743DF0", Offset = "0xA742DF0", VA = "0x18A743DF0", Slot = "5")]
			public float[] InterpolateLinear(float[] left, float[] right, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FAF")]
			[Cpp2IlInjected.Address(RVA = "0xA743DC0", Offset = "0xA742DC0", VA = "0x18A743DC0", Slot = "6")]
			public float[] InterpolateCubic(float[] start, float[] outgoingTangent, float[] end, float[] incomingTangent, float amount)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB0")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public _Array()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B3")]
		private sealed class _Segment : ISamplerTraits<ArraySegment<float>>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB1")]
			[Cpp2IlInjected.Address(RVA = "0xA747620", Offset = "0xA746620", VA = "0x18A747620", Slot = "4")]
			public ArraySegment<float> Clone(ArraySegment<float> value)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB2")]
			[Cpp2IlInjected.Address(RVA = "0xA7477E0", Offset = "0xA7467E0", VA = "0x18A7477E0", Slot = "5")]
			public ArraySegment<float> InterpolateLinear(ArraySegment<float> left, ArraySegment<float> right, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB3")]
			[Cpp2IlInjected.Address(RVA = "0xA7476C0", Offset = "0xA7466C0", VA = "0x18A7476C0", Slot = "6")]
			public ArraySegment<float> InterpolateCubic(ArraySegment<float> start, ArraySegment<float> outgoingTangent, ArraySegment<float> end, ArraySegment<float> incomingTangent, float amount)
			{
				return default(ArraySegment<float>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB4")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public _Segment()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		private sealed class _Sparse : ISamplerTraits<SparseWeight8>
		{
			[Cpp2IlInjected.Token(Token = "0x6000FB5")]
			[Cpp2IlInjected.Address(RVA = "0x5718960", Offset = "0x5717960", VA = "0x185718960", Slot = "4")]
			public SparseWeight8 Clone(SparseWeight8 value)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB6")]
			[Cpp2IlInjected.Address(RVA = "0xA747920", Offset = "0xA746920", VA = "0x18A747920", Slot = "5")]
			public SparseWeight8 InterpolateLinear(SparseWeight8 left, SparseWeight8 right, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB7")]
			[Cpp2IlInjected.Address(RVA = "0xA7478A0", Offset = "0xA7468A0", VA = "0x18A7478A0", Slot = "6")]
			public SparseWeight8 InterpolateCubic(SparseWeight8 start, SparseWeight8 outgoingTangent, SparseWeight8 end, SparseWeight8 incomingTangent, float amount)
			{
				return default(SparseWeight8);
			}

			[Cpp2IlInjected.Token(Token = "0x6000FB8")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x386C4F0", Offset = "0x386B4F0", VA = "0x18386C4F0")]
		public static ICurveSampler<T> CreateFrom<TKey>(IEnumerable<(float, TKey)> sequence, Func<(float, TKey)[], ICurveSampler<T>> chunkFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBA")]
		[Cpp2IlInjected.Address(RVA = "0x62EED70", Offset = "0x62EDD70", VA = "0x1862EED70")]
		private FastCurveSampler(IEnumerable<ICurveSampler<T>> samplers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000FBB")]
		[Cpp2IlInjected.Address(RVA = "0x62EE700", Offset = "0x62ED700", VA = "0x1862EE700", Slot = "4")]
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

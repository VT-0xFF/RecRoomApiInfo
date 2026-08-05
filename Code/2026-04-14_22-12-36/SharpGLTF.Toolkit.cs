using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Nodes;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using SharpGLTF.Animations;
using SharpGLTF.Collections;
using SharpGLTF.Diagnostics;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Memory;
using SharpGLTF.Runtime;
using SharpGLTF.Scenes;
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
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace SharpGLTF
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class BaseBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected BaseBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		protected BaseBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1560", VA = "0x180CF2960")]
		protected BaseBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDE70", Offset = "0xA5FCA70", VA = "0x18A5FDE70")]
		protected BaseBuilder(BaseBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDC80", Offset = "0xA5FC880", VA = "0x18A5FDC80")]
		protected static int GetContentHashCode(BaseBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDB70", Offset = "0xA5FC770", VA = "0x18A5FDB70")]
		protected static bool AreEqualByContent(BaseBuilder x, BaseBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDD90", Offset = "0xA5FC990", VA = "0x18A5FDD90")]
		internal void SetNameAndExtrasFrom(BaseBuilder source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDD10", Offset = "0xA5FC910", VA = "0x18A5FDD10")]
		internal void SetNameAndExtrasFrom(LogicalChildOfRoot source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDE10", Offset = "0xA5FCA10", VA = "0x18A5FDE10")]
		internal void TryCopyNameAndExtrasTo(LogicalChildOfRoot target)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DebuggerStepThrough]
	internal static class Guard
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IReadOnlyList<char> _InvalidRelativePathChars;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFB10", Offset = "0xA5FE710", VA = "0x18A5FFB10")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA5FEAE0", Offset = "0xA5FD6E0", VA = "0x18A5FEAE0")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA5FED50", Offset = "0xA5FD950", VA = "0x18A5FED50")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA5FEFA0", Offset = "0xA5FDBA0", VA = "0x18A5FEFA0")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA5FEA40", Offset = "0xA5FD640", VA = "0x18A5FEA40")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF790", Offset = "0xA5FE390", VA = "0x18A5FF790")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF670", Offset = "0xA5FE270", VA = "0x18A5FF670")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFC60", Offset = "0xA5FE860", VA = "0x18A5FFC60")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFC00", Offset = "0xA5FE800", VA = "0x18A5FFC00")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF4B0", Offset = "0xA5FE0B0", VA = "0x18A5FF4B0")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB070", Offset = "0x3AE9C70", VA = "0x183AEB070")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9750", Offset = "0x3AE8350", VA = "0x183AE9750")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF510", Offset = "0xA5FE110", VA = "0x18A5FF510")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEAC10", Offset = "0x3AE9810", VA = "0x183AEAC10")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA7B0", Offset = "0x3AE93B0", VA = "0x183AEA7B0")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA370", Offset = "0x3AE8F70", VA = "0x183AEA370")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA070", Offset = "0x3AE8C70", VA = "0x183AEA070")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9370", Offset = "0x3AE7F70", VA = "0x183AE9370")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF0A0", Offset = "0xA5FDCA0", VA = "0x18A5FF0A0")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF040", Offset = "0xA5FDC40", VA = "0x18A5FF040")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF100", Offset = "0xA5FDD00", VA = "0x18A5FF100")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF9B0", Offset = "0xA5FE5B0", VA = "0x18A5FF9B0")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF8B0", Offset = "0xA5FE4B0", VA = "0x18A5FF8B0")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3AE8A80", Offset = "0x3AE7680", VA = "0x183AE8A80")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE7B0", Offset = "0xA5FD3B0", VA = "0x18A5FE7B0")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7D30", Offset = "0x3AE6930", VA = "0x183AE7D30")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AE72A0", Offset = "0x3AE5EA0", VA = "0x183AE72A0")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AE72A0", Offset = "0x3AE5EA0", VA = "0x183AE72A0")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3AE72A0", Offset = "0x3AE5EA0", VA = "0x183AE72A0")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3AE72A0", Offset = "0x3AE5EA0", VA = "0x183AE72A0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3AE66B0", Offset = "0x3AE52B0", VA = "0x183AE66B0")]
		public static void MustBeBetweenOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class _Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private readonly struct _ListSelect<TSource, TResult> : IReadOnlyList<TResult>, IEnumerable<TResult>, IEnumerable, IReadOnlyCollection<TResult>
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__7 : IEnumerator<TResult>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000D")]
				private TResult <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public _ListSelect<TSource, TResult> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				private IEnumerator<TSource> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				TResult IEnumerator<TResult>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return (TResult)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x6681620", Offset = "0x6680220", VA = "0x186681620", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x667F8A0", Offset = "0x667E4A0", VA = "0x18667F8A0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x6681C50", Offset = "0x6680850", VA = "0x186681C50")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class <System-Collections-IEnumerable-GetEnumerator>d__8 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000010")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000011")]
				private object <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public _ListSelect<TSource, TResult> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				private IEnumerator<TSource> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				object IEnumerator<object>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6E461C0", Offset = "0x6E44DC0", VA = "0x186E461C0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x6E426B0", Offset = "0x6E412B0", VA = "0x186E426B0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x6E466C0", Offset = "0x6E452C0", VA = "0x186E466C0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			private readonly IReadOnlyList<TSource> _List;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<TSource, TResult> _Selector;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public TResult this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x515AE00", Offset = "0x5159A00", VA = "0x18515AE00", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x515A9A0", Offset = "0x51595A0", VA = "0x18515A9A0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x515A650", Offset = "0x5159250", VA = "0x18515A650", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x515A8F0", Offset = "0x51594F0", VA = "0x18515A8F0", Slot = "7")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<System-Collections-IEnumerable-GetEnumerator>d__8))]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private readonly struct _CollectionSelect<TSource, TResult> : IReadOnlyCollection<TResult>, IEnumerable<TResult>, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x200000F")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__5 : IEnumerator<TResult>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				private TResult <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public _CollectionSelect<TSource, TResult> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				private IEnumerator<TSource> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				TResult IEnumerator<TResult>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return (TResult)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x667BEA0", Offset = "0x667AAA0", VA = "0x18667BEA0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x667A580", Offset = "0x6679180", VA = "0x18667A580", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x667C230", Offset = "0x667AE30", VA = "0x18667C230")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			[CompilerGenerated]
			private sealed class <System-Collections-IEnumerable-GetEnumerator>d__6 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				private object <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public _CollectionSelect<TSource, TResult> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private IEnumerator<TSource> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				object IEnumerator<object>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x6E3D060", Offset = "0x6E3BC60", VA = "0x186E3D060", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6E3CD00", Offset = "0x6E3B900", VA = "0x186E3CD00", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x6E3D480", Offset = "0x6E3C080", VA = "0x186E3D480")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			private readonly IReadOnlyCollection<TSource> _List;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly Func<TSource, TResult> _Selector;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x5151B00", Offset = "0x5150700", VA = "0x185151B00", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x51517B0", Offset = "0x51503B0", VA = "0x1851517B0", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5151980", Offset = "0x5150580", VA = "0x185151980", Slot = "6")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<System-Collections-IEnumerable-GetEnumerator>d__6))]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class <GetLinesIndices>d__66 : IEnumerable<(int, int)>, IEnumerable, IEnumerator<(int, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private (int A, int B) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private PrimitiveType ptype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PrimitiveType <>3__ptype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private IEnumerable<uint> sourceIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public IEnumerable<uint> <>3__sourceIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private IEnumerator<uint> <ptr>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			(int, int) IEnumerator<(int, int)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0x13F8890", Offset = "0x13F7490", VA = "0x1813F8890", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0xA61C280", Offset = "0xA61AE80", VA = "0x18A61C280", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x64DD0E0", Offset = "0x64DBCE0", VA = "0x1864DD0E0")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA61C2D0", Offset = "0xA61AED0", VA = "0x18A61C2D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA61BF30", Offset = "0xA61AB30", VA = "0x18A61BF30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA61C390", Offset = "0xA61AF90", VA = "0x18A61C390")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA61C240", Offset = "0xA61AE40", VA = "0x18A61C240", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA61C190", Offset = "0xA61AD90", VA = "0x18A61C190", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA61C190", Offset = "0xA61AD90", VA = "0x18A61C190", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class <GetTrianglesIndices>d__67 : IEnumerable<(int, int, int)>, IEnumerable, IEnumerator<(int, int, int)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private (int A, int B, int C) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private PrimitiveType ptype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public PrimitiveType <>3__ptype;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private IEnumerable<uint> sourceIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IEnumerable<uint> <>3__sourceIndices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private IEnumerator<uint> <ptr>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private uint <a>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private uint <c>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private bool <reversed>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			(int, int, int) IEnumerator<(int, int, int)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x19FE720", Offset = "0x19FD320", VA = "0x1819FE720", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((int, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0xA61CD70", Offset = "0xA61B970", VA = "0x18A61CD70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA61CDC0", Offset = "0xA61B9C0", VA = "0x18A61CDC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA61C3E0", Offset = "0xA61AFE0", VA = "0x18A61C3E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA61CFB0", Offset = "0xA61BBB0", VA = "0x18A61CFB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA61D000", Offset = "0xA61BC00", VA = "0x18A61D000")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA61D050", Offset = "0xA61BC50", VA = "0x18A61D050")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA61CD30", Offset = "0xA61B930", VA = "0x18A61CD30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA61CC80", Offset = "0xA61B880", VA = "0x18A61CC80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA61CC80", Offset = "0xA61B880", VA = "0x18A61CC80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float _UnitLengthThresholdVec3 = 0.00674f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float _UnitLengthThresholdVec4 = 0.00769f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float _UnitSumThresholdStep = 0.0039216f;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA544900", Offset = "0xA543500", VA = "0x18A544900")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA5462D0", Offset = "0xA544ED0", VA = "0x18A5462D0")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA546400", Offset = "0xA545000", VA = "0x18A546400")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA546310", Offset = "0xA544F10", VA = "0x18A546310")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA546430", Offset = "0xA545030", VA = "0x18A546430")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA546370", Offset = "0xA544F70", VA = "0x18A546370")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA5464A0", Offset = "0xA5450A0", VA = "0x18A5464A0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA546370", Offset = "0xA544F70", VA = "0x18A546370")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA546200", Offset = "0xA544E00", VA = "0x18A546200")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA61EEF0", Offset = "0xA61DAF0", VA = "0x18A61EEF0")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA61EDD0", Offset = "0xA61D9D0", VA = "0x18A61EDD0")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA543CA0", Offset = "0xA5428A0", VA = "0x18A543CA0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA61F770", Offset = "0xA61E370", VA = "0x18A61F770")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA5448B0", Offset = "0xA5434B0", VA = "0x18A5448B0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA544850", Offset = "0xA543450", VA = "0x18A544850")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA544B30", Offset = "0xA543730", VA = "0x18A544B30")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA620310", Offset = "0xA61EF10", VA = "0x18A620310")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA620490", Offset = "0xA61F090", VA = "0x18A620490")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA61F0E0", Offset = "0xA61DCE0", VA = "0x18A61F0E0")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA61EFF0", Offset = "0xA61DBF0", VA = "0x18A61EFF0")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA61F3B0", Offset = "0xA61DFB0", VA = "0x18A61F3B0")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA61EC40", Offset = "0xA61D840", VA = "0x18A61EC40")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F78E0", Offset = "0xA5F64E0", VA = "0x18A5F78E0")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA545400", Offset = "0xA544000", VA = "0x18A545400")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA61F070", Offset = "0xA61DC70", VA = "0x18A61F070")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA544620", Offset = "0xA543220", VA = "0x18A544620")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA544560", Offset = "0xA543160", VA = "0x18A544560")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4141D90", Offset = "0x4140990", VA = "0x184141D90")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA543E10", Offset = "0xA542A10", VA = "0x18A543E10")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA543F80", Offset = "0xA542B80", VA = "0x18A543F80")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4143750", Offset = "0x4142350", VA = "0x184143750")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4144250", Offset = "0x4142E50", VA = "0x184144250")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4144420", Offset = "0x4143020", VA = "0x184144420")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4144500", Offset = "0x4143100", VA = "0x184144500")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4141DB0", Offset = "0x41409B0", VA = "0x184141DB0")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4142F70", Offset = "0x4141B70", VA = "0x184142F70")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4142E60", Offset = "0x4141A60", VA = "0x184142E60")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x41425A0", Offset = "0x41411A0", VA = "0x1841425A0")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4144170", Offset = "0x4142D70", VA = "0x184144170")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4143AE0", Offset = "0x41426E0", VA = "0x184143AE0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4144080", Offset = "0x4142C80", VA = "0x184144080")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4143C80", Offset = "0x4142880", VA = "0x184143C80")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4142450", Offset = "0x4141050", VA = "0x184142450")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4141FF0", Offset = "0x4140BF0", VA = "0x184141FF0")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4141A10", Offset = "0x4140610", VA = "0x184141A10")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4141E40", Offset = "0x4140A40", VA = "0x184141E40")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA61F1B0", Offset = "0xA61DDB0", VA = "0x18A61F1B0")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA61F510", Offset = "0xA61E110", VA = "0x18A61F510")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x41441D0", Offset = "0x4142DD0", VA = "0x1841441D0")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x41441D0", Offset = "0x4142DD0", VA = "0x1841441D0")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA61FA20", Offset = "0xA61E620", VA = "0x18A61FA20")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA61E5A0", Offset = "0xA61D1A0", VA = "0x18A61E5A0")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA61E4F0", Offset = "0xA61D0F0", VA = "0x18A61E4F0")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA61F9A0", Offset = "0xA61E5A0", VA = "0x18A61F9A0")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA6200E0", Offset = "0xA61ECE0", VA = "0x18A6200E0")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA61E620", Offset = "0xA61D220", VA = "0x18A61E620")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA620010", Offset = "0xA61EC10", VA = "0x18A620010")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA61FC20", Offset = "0xA61E820", VA = "0x18A61FC20")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA61E990", Offset = "0xA61D590", VA = "0x18A61E990")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA61E6E0", Offset = "0xA61D2E0", VA = "0x18A61E6E0")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA61EAB0", Offset = "0xA61D6B0", VA = "0x18A61EAB0")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA61E870", Offset = "0xA61D470", VA = "0x18A61E870")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA61EA30", Offset = "0xA61D630", VA = "0x18A61EA30")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2382940", Offset = "0x2381540", VA = "0x182382940")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA5462F0", Offset = "0xA544EF0", VA = "0x18A5462F0")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4144730", Offset = "0x4143330", VA = "0x184144730")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA61F8E0", Offset = "0xA61E4E0", VA = "0x18A61F8E0")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA61E8F0", Offset = "0xA61D4F0", VA = "0x18A61E8F0")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA620260", Offset = "0xA61EE60", VA = "0x18A620260")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA620690", Offset = "0xA61F290", VA = "0x18A620690")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA620160", Offset = "0xA61ED60", VA = "0x18A620160")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA543EB0", Offset = "0xA542AB0", VA = "0x18A543EB0")]
		public static bool DeepEquals(this JsonNode x, JsonNode y, double precission)
		{
			return default(bool);
		}
	}
}
namespace SharpGLTF.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal static class VertexNormalsFactory
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public interface IMeshPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x17000012")]
			int VertexCount
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Vector3 GetVertexPosition(int idx);

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetVertexNormal(int idx, Vector3 normal);

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(Slot = "3")]
			IEnumerable<(int, int, int)> GetTriangleIndices();
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x40D9120", Offset = "0x40D7D20", VA = "0x1840D9120")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA61E180", Offset = "0xA61CD80", VA = "0x18A61E180")]
		private static void _AddDirection(Dictionary<Vector3, Vector3> dict, Vector3 pos, Vector3 dir)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal static class VertexTangentsFactory
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public interface IMeshPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			int VertexCount
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Vector3 GetVertexPosition(int idx);

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Vector3 GetVertexNormal(int idx);

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Vector2 GetVertexTexCoord(int idx);

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void SetVertexTangent(int idx, Vector4 tangent);

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(Slot = "5")]
			IEnumerable<(int, int, int)> GetTriangleIndices();
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x40EABB0", Offset = "0x40E97B0", VA = "0x1840EABB0")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA61E340", Offset = "0xA61CF40", VA = "0x18A61E340")]
		private static void _AddTangent(Dictionary<(Vector3, Vector3, Vector2), (Vector3, Vector3)> dict, (Vector3, Vector3, Vector2) key, (Vector3 tu, Vector3 tv) alpha)
		{
		}
	}
}
namespace SharpGLTF.Schema2
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class Toolkit
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class <EvaluateLines>d__77 : IEnumerable<(IVertexBuilder, IVertexBuilder, Material)>, IEnumerable, IEnumerator<(IVertexBuilder, IVertexBuilder, Material)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private (IVertexBuilder A, IVertexBuilder B, Material Material) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private MeshPrimitive prim;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public MeshPrimitive <>3__prim;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private IGeometryTransform xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public IGeometryTransform <>3__xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private IEnumerable<(int A, int B)> <lines>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private VertexBufferColumns <vertices>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private Func<IVertexBuilder> <vtype>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private IEnumerator<IGeometryTransform> <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private VertexBufferColumns <xvertices>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private IEnumerator<(int A, int B)> <>7__wrap6;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			(IVertexBuilder, IVertexBuilder, Material) IEnumerator<(IVertexBuilder, IVertexBuilder, Material)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((IVertexBuilder, IVertexBuilder, Material));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xA61A310", Offset = "0xA618F10", VA = "0x18A61A310", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <EvaluateLines>d__77(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA61A360", Offset = "0xA618F60", VA = "0x18A61A360", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA619C60", Offset = "0xA618860", VA = "0x18A619C60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA61A530", Offset = "0xA619130", VA = "0x18A61A530")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA61A580", Offset = "0xA619180", VA = "0x18A61A580")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA61A2D0", Offset = "0xA618ED0", VA = "0x18A61A2D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA61A220", Offset = "0xA618E20", VA = "0x18A61A220", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA61A220", Offset = "0xA618E20", VA = "0x18A61A220", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class <EvaluatePoints>d__75 : IEnumerable<(IVertexBuilder, Material)>, IEnumerable, IEnumerator<(IVertexBuilder, Material)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private (IVertexBuilder A, Material Material) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private MeshPrimitive prim;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public MeshPrimitive <>3__prim;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private IGeometryTransform xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public IGeometryTransform <>3__xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private IEnumerable<int> <points>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private VertexBufferColumns <vertices>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private Func<IVertexBuilder> <vtype>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private IEnumerator<IGeometryTransform> <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private VertexBufferColumns <xvertices>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private IEnumerator<int> <>7__wrap6;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			(IVertexBuilder, Material) IEnumerator<(IVertexBuilder, Material)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A0")]
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((IVertexBuilder, Material));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001A2")]
				[Cpp2IlInjected.Address(RVA = "0xA61ABC0", Offset = "0xA6197C0", VA = "0x18A61ABC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1D02EC0", Offset = "0x1D01AC0", VA = "0x181D02EC0")]
			[DebuggerHidden]
			public <EvaluatePoints>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA61AC10", Offset = "0xA619810", VA = "0x18A61AC10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA61A5E0", Offset = "0xA6191E0", VA = "0x18A61A5E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA61AE10", Offset = "0xA619A10", VA = "0x18A61AE10")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA61AE60", Offset = "0xA619A60", VA = "0x18A61AE60")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA61AB80", Offset = "0xA619780", VA = "0x18A61AB80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA61AAD0", Offset = "0xA6196D0", VA = "0x18A61AAD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA61AAD0", Offset = "0xA6196D0", VA = "0x18A61AAD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class <EvaluateTriangles>d__79 : IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)>, IEnumerable, IEnumerator<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private (IVertexBuilder A, IVertexBuilder B, IVertexBuilder C, Material Material) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private MeshPrimitive prim;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public MeshPrimitive <>3__prim;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private IGeometryTransform xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public IGeometryTransform <>3__xform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private VertexBufferColumns <vertices>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private IEnumerable<(int A, int B, int C)> <triangles>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private IEnumerator<IGeometryTransform> <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private VertexBufferColumns <xvertices>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private Func<IVertexBuilder> <vtype>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private IEnumerator<(int A, int B, int C)> <>7__wrap6;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material) IEnumerator<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x51142D0", Offset = "0x5112ED0", VA = "0x1851142D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((IVertexBuilder, IVertexBuilder, IVertexBuilder, Material));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xA61B5E0", Offset = "0xA61A1E0", VA = "0x18A61B5E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x5146A90", Offset = "0x5145690", VA = "0x185146A90")]
			[DebuggerHidden]
			public <EvaluateTriangles>d__79(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA61B630", Offset = "0xA61A230", VA = "0x18A61B630", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xA61AEB0", Offset = "0xA619AB0", VA = "0x18A61AEB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xA61B810", Offset = "0xA61A410", VA = "0x18A61B810")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA61B860", Offset = "0xA61A460", VA = "0x18A61B860")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xA61B5A0", Offset = "0xA61A1A0", VA = "0x18A61B5A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA61B4F0", Offset = "0xA61A0F0", VA = "0x18A61B4F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA61B4F0", Offset = "0xA61A0F0", VA = "0x18A61B4F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA610790", Offset = "0xA60F390", VA = "0x18A610790")]
		public static Accessor CreateMorphTargetAccessor(this ModelRoot root, MemoryAccessor memAccessor, int sparsityPercent = 60)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6109F0", Offset = "0xA60F5F0", VA = "0x18A6109F0")]
		public static Accessor CreateVertexAccessor(this ModelRoot root, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F7FE40", Offset = "0x3F7EA40", VA = "0x183F7FE40")]
		public static BufferView CreateBufferView<T>(this ModelRoot root, IReadOnlyList<T> data) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA6129D0", Offset = "0xA6115D0", VA = "0x18A6129D0")]
		public static Animation UseAnimation(this ModelRoot root, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA616B30", Offset = "0xA615730", VA = "0x18A616B30")]
		public static Node WithScaleAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA618280", Offset = "0xA616E80", VA = "0x18A618280")]
		public static Node WithTranslationAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA615910", Offset = "0xA614510", VA = "0x18A615910")]
		public static Node WithMorphingAnimation(this Node node, string animationName, ICurveSampler<SparseWeight8> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F86610", Offset = "0x3F85210", VA = "0x183F86610")]
		public static Node WithMorphingAnimation<T>(this Node node, string animationName, ICurveSampler<T> sampler) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA6167F0", Offset = "0xA6153F0", VA = "0x18A6167F0")]
		public static Node WithRotationAnimation(this Node node, string animationName, ICurveSampler<Quaternion> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA618DC0", Offset = "0xA6179C0", VA = "0x18A618DC0")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, ICurveSampler<bool> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA616D40", Offset = "0xA615940", VA = "0x18A616D40")]
		public static Node WithScaleAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA616360", Offset = "0xA614F60", VA = "0x18A616360")]
		public static Node WithRotationAnimation(this Node node, string animationName, params (float Key, Quaternion Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA617F20", Offset = "0xA616B20", VA = "0x18A617F20")]
		public static Node WithTranslationAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA616A00", Offset = "0xA615600", VA = "0x18A616A00")]
		public static Node WithScaleAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA6166C0", Offset = "0xA6152C0", VA = "0x18A6166C0")]
		public static Node WithRotationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA617DF0", Offset = "0xA6169F0", VA = "0x18A617DF0")]
		public static Node WithTranslationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA618F60", Offset = "0xA617B60", VA = "0x18A618F60")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, IReadOnlyDictionary<float, bool> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA617D20", Offset = "0xA616920", VA = "0x18A617D20")]
		public static PunctualLight WithSpotCone(this PunctualLight light, float innerConeAngle, float outerConeAngle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA613630", Offset = "0xA612230", VA = "0x18A613630")]
		public static PunctualLight WithColor(this PunctualLight light, Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA613740", Offset = "0xA612340", VA = "0x18A613740")]
		public static Material WithDefault(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA613850", Offset = "0xA612450", VA = "0x18A613850")]
		public static Material WithDefault(this Material material, Vector4 diffuseColor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA613A30", Offset = "0xA612630", VA = "0x18A613A30")]
		public static Material WithDoubleSide(this Material material, bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA613020", Offset = "0xA611C20", VA = "0x18A613020")]
		[Obsolete("don't use vector4 based parameter. Use WithChannelColor and WithChannelFactor instead.")]
		public static Material WithChannelParameter(this Material material, string channelName, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA612D30", Offset = "0xA611930", VA = "0x18A612D30")]
		public static Material WithChannelColor(this Material material, string channelName, Vector4 color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA612EA0", Offset = "0xA611AA0", VA = "0x18A612EA0")]
		public static Material WithChannelFactor(this Material material, string channelName, string paramName, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA613340", Offset = "0xA611F40", VA = "0x18A613340")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, string imageFilePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA613190", Offset = "0xA611D90", VA = "0x18A613190")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, Image image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA615D80", Offset = "0xA614980", VA = "0x18A615D80")]
		public static Material WithPBRMetallicRoughness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA615E50", Offset = "0xA614A50", VA = "0x18A615E50")]
		public static Material WithPBRMetallicRoughness(this Material material, Vector4 baseColor, string baseColorImageFilePath, [Optional] string metallicImageFilePath, float metallicFactor = 1f, float roughnessFactor = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA616150", Offset = "0xA614D50", VA = "0x18A616150")]
		[Obsolete("SpecularGlossiness Extension has been declared deprecated by the Khronos Group. Use newer extensions instead.")]
		public static Material WithPBRSpecularGlossiness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA618490", Offset = "0xA617090", VA = "0x18A618490")]
		public static Material WithUnlit(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA612C10", Offset = "0xA611810", VA = "0x18A612C10")]
		public static Image UseImageWithFile(this ModelRoot root, string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA612B40", Offset = "0xA611740", VA = "0x18A612B40")]
		public static Image UseImageWithContent(this ModelRoot root, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA610280", Offset = "0xA60EE80", VA = "0x18A610280")]
		public static Material CreateMaterial(this ModelRoot root, MaterialBuilder mb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA612060", Offset = "0xA610C60", VA = "0x18A612060")]
		public static MaterialBuilder ToMaterialBuilder(this Material srcMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA612670", Offset = "0xA611270", VA = "0x18A612670")]
		public static AlphaMode ToSchema2(this SharpGLTF.Materials.AlphaMode alpha)
		{
			return default(AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA612720", Offset = "0xA611320", VA = "0x18A612720")]
		public static SharpGLTF.Materials.AlphaMode ToToolkit(this AlphaMode alpha)
		{
			return default(SharpGLTF.Materials.AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA60EEC0", Offset = "0xA60DAC0", VA = "0x18A60EEC0")]
		public static void CopyTo(this Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6194B0", Offset = "0xA6180B0", VA = "0x18A6194B0")]
		private static void _CopyMetallicRoughnessTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA6191D0", Offset = "0xA617DD0", VA = "0x18A6191D0")]
		private static void _CopyDefaultTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA60E450", Offset = "0xA60D050", VA = "0x18A60E450")]
		public static void CopyChannelsTo(this Material srcMaterial, MaterialBuilder dstMaterial, params string[] channelKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA60E740", Offset = "0xA60D340", VA = "0x18A60E740")]
		public static void CopyTo(this MaterialChannel srcChannel, ChannelBuilder dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA60F830", Offset = "0xA60E430", VA = "0x18A60F830")]
		public static void CopyTo(this MaterialBuilder srcMaterial, Material dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA60E2F0", Offset = "0xA60CEF0", VA = "0x18A60E2F0")]
		[Obsolete]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params string[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA60E030", Offset = "0xA60CC30", VA = "0x18A60E030")]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params KnownChannel[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA60F240", Offset = "0xA60DE40", VA = "0x18A60F240")]
		public static void CopyTo(this ChannelBuilder srcChannel, MaterialChannel dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA619090", Offset = "0xA617C90", VA = "0x18A619090")]
		private static Image _ConvertToImage(MaterialChannel dstChannel, ImageBuilder srcImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA611750", Offset = "0xA610350", VA = "0x18A611750")]
		public static Vector4 GetDiffuseColor(this Material material, Vector4 defaultColor)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA611BB0", Offset = "0xA6107B0", VA = "0x18A611BB0")]
		public static Texture GetDiffuseTexture(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA611A70", Offset = "0xA610670", VA = "0x18A611A70")]
		public static TextureTransform GetDiffuseTextureTransform(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA6118A0", Offset = "0xA6104A0", VA = "0x18A6118A0")]
		public static Matrix3x2? GetDiffuseTextureMatrix(this Material material, Animation track, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA6103B0", Offset = "0xA60EFB0", VA = "0x18A6103B0")]
		public static Mesh CreateMesh(this ModelRoot root, IMeshBuilder<MaterialBuilder> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F81C10", Offset = "0x3F80810", VA = "0x183F81C10")]
		public static Mesh CreateMesh<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialEvaluator, IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA6105F0", Offset = "0xA60F1F0", VA = "0x18A6105F0")]
		public static IReadOnlyList<Mesh> CreateMeshes(this ModelRoot root, params IMeshBuilder<MaterialBuilder>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3F838F0", Offset = "0x3F824F0", VA = "0x183F838F0")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F82C70", Offset = "0x3F81870", VA = "0x183F82C70")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, SceneBuilderSchema2Settings settings, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA613EC0", Offset = "0xA612AC0", VA = "0x18A613EC0")]
		public static MeshPrimitive WithIndicesAutomatic(this MeshPrimitive primitive, PrimitiveType primitiveType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA613AF0", Offset = "0xA6126F0", VA = "0x18A613AF0")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, IReadOnlyList<int> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3F86FB0", Offset = "0x3F85BB0", VA = "0x183F86FB0")]
		public static MeshPrimitive WithVertexAccessor<T>(this MeshPrimitive primitive, string attribute, IReadOnlyList<T> values, bool useExplicitByteStride = false) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA618C60", Offset = "0xA617860", VA = "0x18A618C60")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPosition> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA618B00", Offset = "0xA617700", VA = "0x18A618B00")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPositionNormal> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F875C0", Offset = "0x3F861C0", VA = "0x183F875C0")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F875C0", Offset = "0x3F861C0", VA = "0x183F875C0")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM, TvS>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat, TvS Skin)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F87780", Offset = "0x3F86380", VA = "0x183F87780")]
		public static MeshPrimitive WithVertexAccessors<TVertex>(this MeshPrimitive primitive, IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA618750", Offset = "0xA617350", VA = "0x18A618750")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA618540", Offset = "0xA617140", VA = "0x18A618540")]
		public static MeshPrimitive WithVertexAccessor(this MeshPrimitive primitive, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA613DA0", Offset = "0xA6129A0", VA = "0x18A613DA0")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA615630", Offset = "0xA614230", VA = "0x18A615630")]
		public static MeshPrimitive WithMorphTargetAccessors(this MeshPrimitive primitive, int targetIndex, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3F85D70", Offset = "0x3F84970", VA = "0x183F85D70")]
		public static MeshGpuInstancing WithInstanceAccessor<T>(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<T> values) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA613FA0", Offset = "0xA612BA0", VA = "0x18A613FA0")]
		public static MeshGpuInstancing WithInstanceAccessors(this MeshGpuInstancing instancing, IReadOnlyList<AffineTransform> transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA614A00", Offset = "0xA613600", VA = "0x18A614A00")]
		public static MeshGpuInstancing WithInstanceCustomAccessors(this MeshGpuInstancing instancing, IReadOnlyList<JsonNode> extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA614790", Offset = "0xA613390", VA = "0x18A614790")]
		public static MeshGpuInstancing WithInstanceCustomAccessor(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<JsonNode> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3F87C30", Offset = "0x3F86830", VA = "0x183F87C30")]
		private static List<T> _SelectAttribute<T>(IReadOnlyList<JsonNode> values, string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA6154B0", Offset = "0xA6140B0", VA = "0x18A6154B0")]
		public static MeshPrimitive WithMaterial(this MeshPrimitive primitive, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA610DA0", Offset = "0xA60F9A0", VA = "0x18A610DA0")]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA610D10", Offset = "0xA60F910", VA = "0x18A610D10")]
		[IteratorStateMachine(typeof(<EvaluatePoints>d__75))]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA610B20", Offset = "0xA60F720", VA = "0x18A610B20")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA610C80", Offset = "0xA60F880", VA = "0x18A610C80")]
		[IteratorStateMachine(typeof(<EvaluateLines>d__77))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA611170", Offset = "0xA60FD70", VA = "0x18A611170")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA611270", Offset = "0xA60FE70", VA = "0x18A611270")]
		[IteratorStateMachine(typeof(<EvaluateTriangles>d__79))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3F83DF0", Offset = "0x3F829F0", VA = "0x183F83DF0")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> EvaluateTriangles<TvG, TvM, TvS>(this Mesh mesh, [Optional] IGeometryTransform xform) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA611CF0", Offset = "0xA6108F0", VA = "0x18A611CF0")]
		public static VertexBufferColumns GetVertexColumns(this MeshPrimitive primitive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA619660", Offset = "0xA618260", VA = "0x18A619660")]
		private static void _Initialize(IReadOnlyDictionary<string, Accessor> vertexAccessors, VertexBufferColumns dstColumns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3F7EAA0", Offset = "0x3F7D6A0", VA = "0x183F7EAA0")]
		public static void AddMesh<TMaterial, TvG, TvM, TvS>(this MeshBuilder<TMaterial, TvG, TvM, TvS> meshBuilder, Mesh srcMesh, Converter<Material, TMaterial> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3F84EE0", Offset = "0x3F83AE0", VA = "0x183F84EE0")]
		public static MeshBuilder<TMaterial, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TMaterial, TvG, TvM>(this Scene srcScene, Converter<Material, TMaterial> materialFunc, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3F85530", Offset = "0x3F84130", VA = "0x183F85530")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TvG, TvM>(this Scene srcScene, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA6120F0", Offset = "0xA610CF0", VA = "0x18A6120F0")]
		public static IMeshBuilder<MaterialBuilder> ToMeshBuilder(this Mesh srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3F84C10", Offset = "0x3F83810", VA = "0x183F84C10")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS>(this IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3F84510", Offset = "0x3F83110", VA = "0x183F84510")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS, TMaterial>(this IEnumerable<(VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, TMaterial Material)> triangles, Converter<TMaterial, MaterialBuilder> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA60CEF0", Offset = "0xA60BAF0", VA = "0x18A60CEF0")]
		private static void AddPrimitiveGeometry(this IPrimitiveBuilder dstPrim, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA611F60", Offset = "0xA610B60", VA = "0x18A611F60")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA611E30", Offset = "0xA610A30", VA = "0x18A611E30")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA615240", Offset = "0xA613E40", VA = "0x18A615240")]
		public static Node WithLocalTransform(this Node node, AffineTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA615320", Offset = "0xA613F20", VA = "0x18A615320")]
		public static Node WithLocalTranslation(this Node node, Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA614F30", Offset = "0xA613B30", VA = "0x18A614F30")]
		public static Node WithLocalRotation(this Node node, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA6150B0", Offset = "0xA613CB0", VA = "0x18A6150B0")]
		public static Node WithLocalScale(this Node node, Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA615570", Offset = "0xA614170", VA = "0x18A615570")]
		public static Node WithMesh(this Node node, Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA617590", Offset = "0xA616190", VA = "0x18A617590")]
		public static Node WithSkin(this Node node, Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA6173A0", Offset = "0xA615FA0", VA = "0x18A6173A0")]
		public static Node WithSkinBinding(this Node node, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA6170A0", Offset = "0xA615CA0", VA = "0x18A6170A0")]
		public static Node WithSkinBinding(this Node node, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA617650", Offset = "0xA616250", VA = "0x18A617650")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA6179A0", Offset = "0xA6165A0", VA = "0x18A6179A0")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA616200", Offset = "0xA614E00", VA = "0x18A616200")]
		public static Node WithPerspectiveCamera(this Node node, float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA615C20", Offset = "0xA614820", VA = "0x18A615C20")]
		public static Node WithOrthographicCamera(this Node node, float xmag, float ymag, float znear, float zfar)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA611590", Offset = "0xA610190", VA = "0x18A611590")]
		public static Node FindNode(this Scene scene, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA611300", Offset = "0xA60FF00", VA = "0x18A611300")]
		public static Node FindNode(this Node node, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA610F00", Offset = "0xA60FB00", VA = "0x18A610F00")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3F83E40", Offset = "0x3F82A40", VA = "0x183F83E40")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, VertexEmpty>> EvaluateTriangles<TvG, TvM>(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA6081C0", Offset = "0xA606DC0", VA = "0x18A6081C0")]
		public static SceneBuilder ToSceneBuilder(this Scene srcScene)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct EvaluatedTriangle<TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class <_EvaluateTriangles>d__2 : IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>>, IEnumerable, IEnumerator<EvaluatedTriangle<TvG, TvM, TvS>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private EvaluatedTriangle<TvG, TvM, TvS> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private IEnumerable<(int A, int B, int C)> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public IEnumerable<(int A, int B, int C)> <>3__indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private VertexBufferColumns vertices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public VertexBufferColumns <>3__vertices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private Material material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public Material <>3__material;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private IEnumerator<(int A, int B, int C)> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			EvaluatedTriangle<TvG, TvM, TvS> IEnumerator<EvaluatedTriangle<TvG, TvM, TvS>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x6673C60", Offset = "0x6672860", VA = "0x186673C60", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(EvaluatedTriangle<TvG, TvM, TvS>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0x7197E60", Offset = "0x7196A60", VA = "0x187197E60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x6BCA030", Offset = "0x6BC8C30", VA = "0x186BCA030")]
			[DebuggerHidden]
			public <_EvaluateTriangles>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x71980A0", Offset = "0x7196CA0", VA = "0x1871980A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x71968B0", Offset = "0x71954B0", VA = "0x1871968B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x71982E0", Offset = "0x7196EE0", VA = "0x1871982E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7197840", Offset = "0x7196440", VA = "0x187197840", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<EvaluatedTriangle<TvG, TvM, TvS>> IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x7197C60", Offset = "0x7196860", VA = "0x187197C60", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly VertexBuilder<TvG, TvM, TvS> A;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly VertexBuilder<TvG, TvM, TvS> B;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public readonly VertexBuilder<TvG, TvM, TvS> C;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly Material Material;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6277050", Offset = "0x6275C50", VA = "0x186277050")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> GetTrianglesFromMesh(Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6279C40", Offset = "0x6278840", VA = "0x186279C40")]
		private static List<(Material, VertexBufferColumns, IEnumerable<(int, int, int)>)> _GatherMeshGeometry(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6278090", Offset = "0x6276C90", VA = "0x186278090")]
		[IteratorStateMachine(typeof(EvaluatedTriangle<, , >.<_EvaluateTriangles>d__2))]
		private static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> _EvaluateTriangles(Material material, VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x627C980", Offset = "0x627B580", VA = "0x18627C980")]
		public static implicit operator EvaluatedTriangle<TvG, TvM, TvS>((VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, Material Material) tri)
		{
			return default(EvaluatedTriangle<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x627C4A0", Offset = "0x627B0A0", VA = "0x18627C4A0")]
		public EvaluatedTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, Material m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x62779E0", Offset = "0x62765E0", VA = "0x1862779E0")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> TransformTextureCoordsByMaterial(IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles, [Optional] Animation track, float time = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x627B700", Offset = "0x627A300", VA = "0x18627B700")]
		private EvaluatedTriangle<TvG, TvM, TvS> _TransformTextureBy([In] Matrix3x2 xform)
		{
			return default(EvaluatedTriangle<TvG, TvM, TvS>);
		}
	}
}
namespace SharpGLTF.Scenes
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public abstract class CameraBuilder : BaseBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[DebuggerDisplay("CameraBuilder.Orthographic ({XMag},{YMag})  {ZNear} < {ZFar}")]
		public sealed class Orthographic : CameraBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public float XMag
			{
				[Cpp2IlInjected.Token(Token = "0x60001DD")]
				[Cpp2IlInjected.Address(RVA = "0x10B78F0", Offset = "0x10B64F0", VA = "0x1810B78F0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x134E100", Offset = "0x134CD00", VA = "0x18134E100")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float YMag
			{
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xE69F90", Offset = "0xE68B90", VA = "0x180E69F90")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0xF00A20", Offset = "0xEFF620", VA = "0x180F00A20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA604E40", Offset = "0xA603A40", VA = "0x18A604E40")]
			public Orthographic(float xmag, float ymag, float znear, float zfar)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA604EA0", Offset = "0xA603AA0", VA = "0x18A604EA0")]
			internal Orthographic(CameraOrthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA604CE0", Offset = "0xA6038E0", VA = "0x18A604CE0", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA604F30", Offset = "0xA603B30", VA = "0x18A604F30")]
			private Orthographic(Orthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA604DE0", Offset = "0xA6039E0", VA = "0x18A604DE0", Slot = "9")]
			protected override Matrix4x4 GetMatrix()
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[DebuggerDisplay("CameraBuilder.Perspective {AspectRatio} {VerticalFOV}   {ZNear} < {ZFar}")]
		public sealed class Perspective : CameraBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public float? AspectRatio
			{
				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xCF4C40", Offset = "0xCF3840", VA = "0x180CF4C40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public float VerticalFOV
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0xE69F80", Offset = "0xE68B80", VA = "0x180E69F80")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x108F600", Offset = "0x108E200", VA = "0x18108F600")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA6051C0", Offset = "0xA603DC0", VA = "0x18A6051C0")]
			public Perspective(float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA605220", Offset = "0xA603E20", VA = "0x18A605220")]
			internal Perspective(CameraPerspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA605010", Offset = "0xA603C10", VA = "0x18A605010", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA6052B0", Offset = "0xA603EB0", VA = "0x18A6052B0")]
			private Perspective(Perspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xA605110", Offset = "0xA603D10", VA = "0x18A605110", Slot = "9")]
			protected override Matrix4x4 GetMatrix()
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA553000", Offset = "0xA551C00", VA = "0x18A553000")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xD47F10", Offset = "0xD46B10", VA = "0x180D47F10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x10AD2D0", Offset = "0x10ABED0", VA = "0x1810AD2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD45940", Offset = "0xD44540", VA = "0x180D45940")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xD45790", Offset = "0xD44390", VA = "0x180D45790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE070", Offset = "0xA5FCC70", VA = "0x18A5FE070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE0A0", Offset = "0xA5FCCA0", VA = "0x18A5FE0A0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CameraBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE030", Offset = "0xA5FCC30", VA = "0x18A5FE030")]
		protected CameraBuilder(float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDF60", Offset = "0xA5FCB60", VA = "0x18A5FDF60")]
		protected CameraBuilder(CameraBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract Matrix4x4 GetMatrix();
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal interface IRenderableContent
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IMeshBuilder<MaterialBuilder> GetGeometryAsset();
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[DebuggerDisplay("EmptyContent")]
	internal class EmptyContent : ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public EmptyContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE760", Offset = "0xA5FD360", VA = "0x18A5FE760", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private EmptyContent(EmptyContent other)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[DebuggerDisplay("MeshContent => {_Mesh}")]
	internal class MeshContent : IRenderableContent, ICloneable, IEquatable<IRenderableContent>, Schema2SceneBuilder.IOperator<Node>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IMeshBuilder<MaterialBuilder> _Mesh;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IMeshBuilder<MaterialBuilder> Mesh
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public MeshContent(IMeshBuilder<MaterialBuilder> mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA600550", Offset = "0xA5FF150", VA = "0x18A600550", Slot = "5")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DDD0", Offset = "0x8E6C9D0", VA = "0x188E6DDD0")]
		private MeshContent(MeshContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B76850", Offset = "0x2B75450", VA = "0x182B76850", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6006A0", Offset = "0xA5FF2A0", VA = "0x18A6006A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6005C0", Offset = "0xA5FF1C0", VA = "0x18A6005C0", Slot = "6")]
		public bool Equals(IRenderableContent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "4")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6007B0", Offset = "0xA5FF3B0", VA = "0x18A6007B0", Slot = "7")]
		void Schema2SceneBuilder.IOperator<Node>.ApplyTo(Node dstNode, Schema2SceneBuilder context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[DebuggerDisplay("CameraContent => {_Camera}")]
	internal class CameraContent : ICloneable, Schema2SceneBuilder.IOperator<Node>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CameraBuilder _Camera;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public CameraBuilder Camera
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public CameraContent(CameraBuilder camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE0F0", Offset = "0xA5FCCF0", VA = "0x18A5FE0F0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE4D0", Offset = "0xA5FD0D0", VA = "0x18A5FE4D0")]
		private CameraContent(CameraContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE180", Offset = "0xA5FCD80", VA = "0x18A5FE180", Slot = "5")]
		void Schema2SceneBuilder.IOperator<Node>.ApplyTo(Node dstNode, Schema2SceneBuilder context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[DebuggerDisplay("LightContent => {_Light}")]
	internal class LightContent : ICloneable, Schema2SceneBuilder.IOperator<Node>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private LightBuilder _Light;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public LightBuilder Light
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public LightContent(LightBuilder light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA600170", Offset = "0xA5FED70", VA = "0x18A600170", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE4D0", Offset = "0xA5FD0D0", VA = "0x18A5FE4D0")]
		private LightContent(LightContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA600200", Offset = "0xA5FEE00", VA = "0x18A600200", Slot = "5")]
		void Schema2SceneBuilder.IOperator<Node>.ApplyTo(Node dstNode, Schema2SceneBuilder context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[DebuggerDisplay("{Content}")]
	public sealed class InstanceBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SceneBuilder _Parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ContentTransformer _ContentTransformer;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xA600020", Offset = "0xA5FEC20", VA = "0x18A600020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA5FFF80", Offset = "0xA5FEB80", VA = "0x18A5FFF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public ContentTransformer Content
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA5FFFA0", Offset = "0xA5FEBA0", VA = "0x18A5FFFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		internal InstanceBuilder(SceneBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFEA0", Offset = "0xA5FEAA0", VA = "0x18A5FFEA0")]
		public InstanceBuilder WithName(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFE70", Offset = "0xA5FEA70", VA = "0x18A5FFE70")]
		public InstanceBuilder WithExtras(JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFE00", Offset = "0xA5FEA00", VA = "0x18A5FFE00")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFED0", Offset = "0xA5FEAD0", VA = "0x18A5FFED0")]
		internal InstanceBuilder _CopyTo(SceneBuilder other, ContentTransformer.DeepCloneContext args)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class LightBuilder : BaseBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[DebuggerDisplay("LightBuilder.Directional")]
		public sealed class Directional : LightBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE640", Offset = "0xA5FD240", VA = "0x18A5FE640")]
			public Directional()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE750", Offset = "0xA5FD350", VA = "0x18A5FE750")]
			internal Directional(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE540", Offset = "0xA5FD140", VA = "0x18A5FE540", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xA5FE680", Offset = "0xA5FD280", VA = "0x18A5FE680")]
			private Directional(Directional other)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[DebuggerDisplay("LightBuilder.Point")]
		public sealed class Point : LightBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public float Range
			{
				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0xE69F80", Offset = "0xE68B80", VA = "0x180E69F80")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x108F600", Offset = "0x108E200", VA = "0x18108F600")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA6055B0", Offset = "0xA6041B0", VA = "0x18A6055B0")]
			public Point()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xA605570", Offset = "0xA604170", VA = "0x18A605570")]
			internal Point(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xA605390", Offset = "0xA603F90", VA = "0x18A605390", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA605490", Offset = "0xA604090", VA = "0x18A605490")]
			private Point(Point other)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[DebuggerDisplay("LightBuilder.Spot")]
		public sealed class Spot : LightBuilder
		{
			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public float Range
			{
				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0xE69F80", Offset = "0xE68B80", VA = "0x180E69F80")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x108F600", Offset = "0x108E200", VA = "0x18108F600")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public float InnerConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0xDD4E60", Offset = "0xDD3A60", VA = "0x180DD4E60")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0xDD4E70", Offset = "0xDD3A70", VA = "0x180DD4E70")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public float OuterConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0xD83160", Offset = "0xD81D60", VA = "0x180D83160")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x11285F0", Offset = "0x11271F0", VA = "0x1811285F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA60CE40", Offset = "0xA60BA40", VA = "0x18A60CE40")]
			public Spot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA60CE90", Offset = "0xA60BA90", VA = "0x18A60CE90")]
			internal Spot(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA60CC40", Offset = "0xA60B840", VA = "0x18A60CC40", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xA60CD50", Offset = "0xA60B950", VA = "0x18A60CD50")]
			private Spot(Spot other)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0xA553000", Offset = "0xA551C00", VA = "0x18A553000")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xFC7000", Offset = "0xFC5C00", VA = "0x180FC7000")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xFC6FB0", Offset = "0xFC5BB0", VA = "0x180FC6FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xE69F90", Offset = "0xE68B90", VA = "0x180E69F90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xF00A20", Offset = "0xEFF620", VA = "0x180F00A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE640", Offset = "0xA5FD240", VA = "0x18A5FE640")]
		protected LightBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA600040", Offset = "0xA5FEC40", VA = "0x18A600040")]
		protected LightBuilder(PunctualLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract LightBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE680", Offset = "0xA5FD280", VA = "0x18A5FE680")]
		protected LightBuilder(LightBuilder other)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public class NodeBuilder : BaseBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class <Flatten>d__52 : IEnumerable<NodeBuilder>, IEnumerable, IEnumerator<NodeBuilder>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			private NodeBuilder <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NodeBuilder container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public NodeBuilder <>3__container;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private IEnumerator<NodeBuilder> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private IEnumerator<NodeBuilder> <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			NodeBuilder IEnumerator<NodeBuilder>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <Flatten>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xA61BCF0", Offset = "0xA61A8F0", VA = "0x18A61BCF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xA61B8C0", Offset = "0xA61A4C0", VA = "0x18A61B8C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xA61BE90", Offset = "0xA61AA90", VA = "0x18A61BE90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xA61BEE0", Offset = "0xA61AAE0", VA = "0x18A61BEE0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0xA61BCB0", Offset = "0xA61A8B0", VA = "0x18A61BCB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA61BC10", Offset = "0xA61A810", VA = "0x18A61BC10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NodeBuilder> IEnumerable<NodeBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA61BC10", Offset = "0xA61A810", VA = "0x18A61BC10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private NodeBuilder _Parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly List<NodeBuilder> _Children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private Matrix4x4? _Matrix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private AnimatableProperty<Vector3> _Scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private AnimatableProperty<Quaternion> _Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private AnimatableProperty<Vector3> _Translation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private AnimatableProperty<bool> _Visibility;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public NodeBuilder Parent
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public NodeBuilder Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA6041D0", Offset = "0xA602DD0", VA = "0x18A6041D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IReadOnlyList<NodeBuilder> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IEnumerable<string> AnimationTracksNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA603640", Offset = "0xA602240", VA = "0x18A603640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool HasAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA6037D0", Offset = "0xA6023D0", VA = "0x18A6037D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool HasTransformAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA603830", Offset = "0xA602430", VA = "0x18A603830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public AnimatableProperty<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xCF7720", Offset = "0xCF6320", VA = "0x180CF7720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AnimatableProperty<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xCF7D90", Offset = "0xCF6990", VA = "0x180CF7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AnimatableProperty<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xCF7770", Offset = "0xCF6370", VA = "0x180CF7770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA603EA0", Offset = "0xA602AA0", VA = "0x18A603EA0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xA6046B0", Offset = "0xA6032B0", VA = "0x18A6046B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA603F80", Offset = "0xA602B80", VA = "0x18A603F80")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA604770", Offset = "0xA603370", VA = "0x18A604770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA6044B0", Offset = "0xA6030B0", VA = "0x18A6044B0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA604C00", Offset = "0xA603800", VA = "0x18A604C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xA603940", Offset = "0xA602540", VA = "0x18A603940")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA6041F0", Offset = "0xA602DF0", VA = "0x18A6041F0")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public AnimatableProperty<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xD1EC20", Offset = "0xD1D820", VA = "0x180D1EC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool? IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xA6038D0", Offset = "0xA6024D0", VA = "0x18A6038D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xA6045C0", Offset = "0xA6031C0", VA = "0x18A6045C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA602E70", Offset = "0xA601A70", VA = "0x18A602E70")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA603500", Offset = "0xA602100", VA = "0x18A603500")]
		public NodeBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA603460", Offset = "0xA602060", VA = "0x18A603460")]
		public NodeBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA603580", Offset = "0xA602180", VA = "0x18A603580")]
		public NodeBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA600E70", Offset = "0xA5FFA70", VA = "0x18A600E70")]
		public Dictionary<NodeBuilder, NodeBuilder> DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA600B10", Offset = "0xA5FF710", VA = "0x18A600B10")]
		private NodeBuilder DeepClone(IDictionary<NodeBuilder, NodeBuilder> nodeMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA600A80", Offset = "0xA5FF680", VA = "0x18A600A80")]
		public NodeBuilder CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA600830", Offset = "0xA5FF430", VA = "0x18A600830")]
		public void AddNode(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA6016A0", Offset = "0xA6002A0", VA = "0x18A6016A0")]
		public static bool IsValidArmature(IEnumerable<NodeBuilder> joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA600EE0", Offset = "0xA5FFAE0", VA = "0x18A600EE0")]
		[IteratorStateMachine(typeof(<Flatten>d__52))]
		public static IEnumerable<NodeBuilder> Flatten(NodeBuilder container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA6032B0", Offset = "0xA601EB0", VA = "0x18A6032B0")]
		private void _UseDecomposedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA6021E0", Offset = "0xA600DE0", VA = "0x18A6021E0")]
		public AnimatableProperty<Vector3> UseScale()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA6022A0", Offset = "0xA600EA0", VA = "0x18A6022A0")]
		public CurveBuilder<Vector3> UseScale(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA602110", Offset = "0xA600D10", VA = "0x18A602110")]
		public AnimatableProperty<Quaternion> UseRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA6020B0", Offset = "0xA600CB0", VA = "0x18A6020B0")]
		public CurveBuilder<Quaternion> UseRotation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA602300", Offset = "0xA600F00", VA = "0x18A602300")]
		public AnimatableProperty<Vector3> UseTranslation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA6023D0", Offset = "0xA600FD0", VA = "0x18A6023D0")]
		public CurveBuilder<Vector3> UseTranslation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA601FD0", Offset = "0xA600BD0", VA = "0x18A601FD0")]
		public void SetScaleTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA602040", Offset = "0xA600C40", VA = "0x18A602040")]
		public void SetTranslationTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA601F60", Offset = "0xA600B60", VA = "0x18A601F60")]
		public void SetRotationTrack(string track, ICurveSampler<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA601270", Offset = "0xA5FFE70", VA = "0x18A601270")]
		public AffineTransform GetLocalTransform(string animationTrack, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA6014C0", Offset = "0xA6000C0", VA = "0x18A6014C0")]
		public Matrix4x4 GetWorldMatrix(string animationTrack, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA600F60", Offset = "0xA5FFB60", VA = "0x18A600F60")]
		public Matrix4x4 GetInverseBindMatrix([Optional] Matrix4x4? meshWorldMatrix)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA601B80", Offset = "0xA600780", VA = "0x18A601B80")]
		public void SetLocalTransform(AffineTransform newLocalTransform, bool keepChildrenInPlace)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA602430", Offset = "0xA601030", VA = "0x18A602430")]
		public AnimatableProperty<bool> UseVisibility()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA602E10", Offset = "0xA601A10", VA = "0x18A602E10")]
		public NodeBuilder WithLocalTranslation(Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA602810", Offset = "0xA601410", VA = "0x18A602810")]
		public NodeBuilder WithLocalScale(Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA6027B0", Offset = "0xA6013B0", VA = "0x18A6027B0")]
		public NodeBuilder WithLocalRotation(Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA602B40", Offset = "0xA601740", VA = "0x18A602B40")]
		public NodeBuilder WithLocalTranslation(string animTrack, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA6024E0", Offset = "0xA6010E0", VA = "0x18A6024E0")]
		public NodeBuilder WithLocalRotation(string animTrack, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA602870", Offset = "0xA601470", VA = "0x18A602870")]
		public NodeBuilder WithLocalScale(string animTrack, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[DebuggerDisplay("Scene {Name}")]
	public class SceneBuilder : BaseBuilder, IConvertibleToGltf2
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class <CreateFrom>d__31 : IEnumerable<SceneBuilder>, IEnumerable, IEnumerator<SceneBuilder>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private SceneBuilder <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private IEnumerable<Scene> srcScenes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public IEnumerable<Scene> <>3__srcScenes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private Dictionary<Node, IMeshBuilder<MaterialBuilder>> <dstMeshIntances>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private IEnumerator<Scene> <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			SceneBuilder IEnumerator<SceneBuilder>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <CreateFrom>d__31(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA6328F0", Offset = "0xA6314F0", VA = "0x18A6328F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA632440", Offset = "0xA631040", VA = "0x18A632440", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xA6329D0", Offset = "0xA6315D0", VA = "0x18A6329D0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA6328B0", Offset = "0xA6314B0", VA = "0x18A6328B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA632810", Offset = "0xA631410", VA = "0x18A632810", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SceneBuilder> IEnumerable<SceneBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA632810", Offset = "0xA631410", VA = "0x18A632810", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal readonly List<InstanceBuilder> _Instances;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public IReadOnlyList<InstanceBuilder> Instances
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA60CAA0", Offset = "0xA60B6A0", VA = "0x18A60CAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal IEnumerable<string> AnimationTrackNames
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA60C970", Offset = "0xA60B570", VA = "0x18A60C970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA60C8D0", Offset = "0xA60B4D0", VA = "0x18A60C8D0")]
		public SceneBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA608230", Offset = "0xA606E30", VA = "0x18A608230")]
		public SceneBuilder DeepClone(bool cloneArmatures = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA608B50", Offset = "0xA607750", VA = "0x18A608B50")]
		[Obsolete("Use LoadDefaultScene(...); or LoadAllScenes(...) instead.", true)]
		public static SceneBuilder Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA608B50", Offset = "0xA607750", VA = "0x18A608B50")]
		public static SceneBuilder LoadDefaultScene(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA608A80", Offset = "0xA607680", VA = "0x18A608A80")]
		public static SceneBuilder[] LoadAllScenes(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA606520", Offset = "0xA605120", VA = "0x18A606520")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA606A00", Offset = "0xA605600", VA = "0x18A606A00")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA606740", Offset = "0xA605340", VA = "0x18A606740")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node, AffineTransform instanceTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA606D80", Offset = "0xA605980", VA = "0x18A606D80")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, Matrix4x4 meshWorldMatrix, params NodeBuilder[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA6070F0", Offset = "0xA605CF0", VA = "0x18A6070F0")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, params (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA6055F0", Offset = "0xA6041F0", VA = "0x18A6055F0")]
		public InstanceBuilder AddCamera(CameraBuilder camera, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA605A60", Offset = "0xA604660", VA = "0x18A605A60")]
		public InstanceBuilder AddCamera(CameraBuilder camera, Vector3 cameraPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA605840", Offset = "0xA604440", VA = "0x18A605840")]
		public InstanceBuilder AddCamera(CameraBuilder camera, AffineTransform cameraTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA605ED0", Offset = "0xA604AD0", VA = "0x18A605ED0")]
		public InstanceBuilder AddLight(LightBuilder light, AffineTransform lightTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA6060F0", Offset = "0xA604CF0", VA = "0x18A6060F0")]
		public InstanceBuilder AddLight(LightBuilder light, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA606340", Offset = "0xA604F40", VA = "0x18A606340")]
		public InstanceBuilder AddNode(NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA608860", Offset = "0xA607460", VA = "0x18A608860")]
		public IReadOnlyList<NodeBuilder> FindArmatures()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA6074A0", Offset = "0xA6060A0", VA = "0x18A6074A0")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA606BE0", Offset = "0xA6057E0", VA = "0x18A606BE0")]
		public IReadOnlyList<InstanceBuilder> AddScene(SceneBuilder scene, Matrix4x4 sceneTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA609130", Offset = "0xA607D30", VA = "0x18A609130", Slot = "8")]
		public ModelRoot ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA608BF0", Offset = "0xA6077F0", VA = "0x18A608BF0")]
		public ModelRoot ToGltf2(SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA608CC0", Offset = "0xA6078C0", VA = "0x18A608CC0")]
		public static ModelRoot ToGltf2(IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA6080F0", Offset = "0xA606CF0", VA = "0x18A6080F0")]
		public static SceneBuilder[] CreateFrom(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA6081C0", Offset = "0xA606DC0", VA = "0x18A6081C0")]
		public static SceneBuilder CreateFrom(Scene srcScene)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA608070", Offset = "0xA606C70", VA = "0x18A608070")]
		[IteratorStateMachine(typeof(<CreateFrom>d__31))]
		public static IEnumerable<SceneBuilder> CreateFrom(IEnumerable<Scene> srcScenes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA60AF60", Offset = "0xA609B60", VA = "0x18A60AF60")]
		private static SceneBuilder _CreateFrom(Scene srcScene, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshInstances)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA60B6B0", Offset = "0xA60A2B0", VA = "0x18A60B6B0")]
		private static Dictionary<Node, IMeshBuilder<MaterialBuilder>> _GatherMeshInstances(IEnumerable<Node> srcNodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA609CA0", Offset = "0xA6088A0", VA = "0x18A609CA0")]
		private static void _AddMeshInstances(SceneBuilder dstScene, IEnumerable<Node> srcNodes, IReadOnlyDictionary<Node, NodeBuilder> nodesDict, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshesDict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA609250", Offset = "0xA607E50", VA = "0x18A609250")]
		private static void _AddCameraInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA6098B0", Offset = "0xA6084B0", VA = "0x18A6098B0")]
		private static void _AddLightInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA609620", Offset = "0xA608220", VA = "0x18A609620")]
		private static void _AddEmptyInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA60A7C0", Offset = "0xA6093C0", VA = "0x18A60A7C0")]
		private static void _CopyToNodeBuilder(NodeBuilder dstNode, Node srcNode, IDictionary<Node, NodeBuilder> nodeMapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA60AC00", Offset = "0xA609800", VA = "0x18A60AC00")]
		private static void _CopyTransformAnimation(NodeBuilder dstNode, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA60A310", Offset = "0xA608F10", VA = "0x18A60A310")]
		private static void _CopyMorphingAnimation(InstanceBuilder dstInst, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3F0ED40", Offset = "0x3F0D940", VA = "0x183F0ED40")]
		internal static void _VerifyCurveConversion<T>(IAnimationSampler<T> a, IConvertibleCurve<T> b, Func<T, T, bool> equalityComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA60BBE0", Offset = "0xA60A7E0", VA = "0x18A60BBE0")]
		internal void _VerifyConversion(Scene gltfScene)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct SceneBuilderSchema2Settings
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static SceneBuilderSchema2Settings Default
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xA62ACC0", Offset = "0xA6298C0", VA = "0x18A62ACC0")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static SceneBuilderSchema2Settings WithGpuInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA62ACE0", Offset = "0xA6298E0", VA = "0x18A62ACE0")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool UseStridedBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x10AC780", Offset = "0x10AB380", VA = "0x1810AC780")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x2720D50", Offset = "0x271F950", VA = "0x182720D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool CompactVertexWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x1128660", Offset = "0x1127260", VA = "0x181128660")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x1128690", Offset = "0x1127290", VA = "0x181128690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int GpuMeshInstancingMinCount
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x30BE910", Offset = "0x30BD510", VA = "0x1830BE910")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x30BE920", Offset = "0x30BD520", VA = "0x1830BE920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xEC80A0", Offset = "0xEC6CA0", VA = "0x180EC80A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xEC80C0", Offset = "0xEC6CC0", VA = "0x180EC80C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class Schema2SceneBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public interface IOperator<T>
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ApplyTo(T target, Schema2SceneBuilder context);
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly Dictionary<MaterialBuilder, Material> _Materials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly Dictionary<IMeshBuilder<MaterialBuilder>, Mesh> _Meshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly Dictionary<NodeBuilder, Node> _Nodes;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int GpuMeshInstancingMinCount
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0600", VA = "0x180CF1A00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A20", Offset = "0xCF0620", VA = "0x180CF1A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA62D750", Offset = "0xA62C350", VA = "0x18A62D750")]
		public Mesh GetMesh(IMeshBuilder<MaterialBuilder> key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA62D7E0", Offset = "0xA62C3E0", VA = "0x18A62D7E0")]
		public Node GetNode(NodeBuilder key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA62D870", Offset = "0xA62C470", VA = "0x18A62D870")]
		public static bool HasContent(Node node, bool checkTransform = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA62B1D0", Offset = "0xA629DD0", VA = "0x18A62B1D0")]
		public void AddGeometryResources(ModelRoot root, IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA62AD00", Offset = "0xA629900", VA = "0x18A62AD00")]
		private void AddArmatureResources(IEnumerable<SceneBuilder> srcScenes, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA62CAF0", Offset = "0xA62B6F0", VA = "0x18A62CAF0")]
		private void CreateArmature(NodeBuilder srcNode, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA62DA60", Offset = "0xA62C660", VA = "0x18A62DA60")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<SparseWeight8> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA62DDC0", Offset = "0xA62C9C0", VA = "0x18A62DDC0")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<ArraySegment<float>> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA62C950", Offset = "0xA62B550", VA = "0x18A62C950")]
		public void AddScene(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA62C310", Offset = "0xA62AF10", VA = "0x18A62C310")]
		private void AddMeshes(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA62BD10", Offset = "0xA62A910", VA = "0x18A62BD10")]
		private void AddLightsAndCameras(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA62E230", Offset = "0xA62CE30", VA = "0x18A62E230")]
		public Schema2SceneBuilder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public readonly struct TransformChainBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private readonly NodeBuilder _ParentTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly AffineTransform? _ChildTransform;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public NodeBuilder Parent
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6C90", VA = "0x180EC8090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public AffineTransform? Child
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x6853E20", Offset = "0x6852A20", VA = "0x186853E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6311D0", Offset = "0xA62FDD0", VA = "0x18A6311D0")]
		public static implicit operator TransformChainBuilder(NodeBuilder node)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA631220", Offset = "0xA62FE20", VA = "0x18A631220")]
		public static implicit operator TransformChainBuilder(AffineTransform transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA631280", Offset = "0xA62FE80", VA = "0x18A631280")]
		public static implicit operator TransformChainBuilder(Matrix4x4 transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA631010", Offset = "0xA62FC10", VA = "0x18A631010")]
		public TransformChainBuilder(AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA630FE0", Offset = "0xA62FBE0", VA = "0x18A630FE0")]
		public TransformChainBuilder(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6310F0", Offset = "0xA62FCF0", VA = "0x18A6310F0")]
		public TransformChainBuilder(NodeBuilder parent, AffineTransform child)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class ContentTransformer
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public readonly struct DeepCloneContext
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private readonly IReadOnlyDictionary<NodeBuilder, NodeBuilder> _NodeMap;

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
			internal DeepCloneContext(IReadOnlyDictionary<NodeBuilder, NodeBuilder> nmap)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA623570", Offset = "0xA622170", VA = "0x18A623570")]
			public NodeBuilder GetNode(NodeBuilder node)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object _Content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private AnimatableProperty<ArraySegment<float>> _Morphings;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xA6234F0", Offset = "0xA6220F0", VA = "0x18A6234F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public abstract string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public abstract JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		internal object Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public AnimatableProperty<ArraySegment<float>> Morphings
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool HasRenderableContent
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xA6234A0", Offset = "0xA6220A0", VA = "0x18A6234A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA623390", Offset = "0xA621F90", VA = "0x18A623390")]
		protected ContentTransformer(object content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ContentTransformer DeepClone(DeepCloneContext args);

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA623250", Offset = "0xA621E50", VA = "0x18A623250")]
		protected ContentTransformer(ContentTransformer other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA622E30", Offset = "0xA621A30", VA = "0x18A622E30")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA622DB0", Offset = "0xA6219B0", VA = "0x18A622DB0")]
		public CameraBuilder GetCameraAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA622E90", Offset = "0xA621A90", VA = "0x18A622E90")]
		public LightBuilder GetLightAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract NodeBuilder GetArmatureRoot();

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA623120", Offset = "0xA621D20", VA = "0x18A623120")]
		public AnimatableProperty<ArraySegment<float>> UseMorphing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA622F10", Offset = "0xA621B10", VA = "0x18A622F10")]
		public CurveBuilder<ArraySegment<float>> UseMorphing(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract Matrix4x4 GetPoseWorldMatrix();

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA622BE0", Offset = "0xA6217E0", VA = "0x18A622BE0")]
		internal IEnumerable<string> GetAnimationTracksNames()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[DebuggerDisplay("FixedTransformer Node[{_DebugName,nq}] = {Content}")]
	public class FixedTransformer : ContentTransformer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _NodeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private JsonNode _NodeExtras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private NodeBuilder _ParentNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private AffineTransform _ChildTransform;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public NodeBuilder ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AffineTransform ChildTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x940B1A0", Offset = "0x9409DA0", VA = "0x18940B1A0")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x940B210", Offset = "0x9409E10", VA = "0x18940B210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA623B80", Offset = "0xA622780", VA = "0x18A623B80")]
		internal FixedTransformer(object content, AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA6239E0", Offset = "0xA6225E0", VA = "0x18A6239E0")]
		internal FixedTransformer(object content, NodeBuilder parentNode, AffineTransform childTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA623A40", Offset = "0xA622640", VA = "0x18A623A40")]
		protected FixedTransformer(FixedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA623670", Offset = "0xA622270", VA = "0x18A623670", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA6237E0", Offset = "0xA6223E0", VA = "0x18A6237E0", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA623800", Offset = "0xA622400", VA = "0x18A623800", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[DebuggerDisplay("RigidTransformer Node[{_DebugName,nq}] = {Content}")]
	public class RigidTransformer : ContentTransformer, Schema2SceneBuilder.IOperator<Scene>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private NodeBuilder _Node;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x72C9400", Offset = "0x72C8000", VA = "0x1872C9400", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x97C9010", Offset = "0x97C7C10", VA = "0x1897C9010", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x18B03D0", Offset = "0x18AEFD0", VA = "0x1818B03D0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x97C9380", Offset = "0x97C7F80", VA = "0x1897C9380", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public NodeBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA62ABA0", Offset = "0xA6297A0", VA = "0x18A62ABA0")]
		internal RigidTransformer(object content, NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA62ABE0", Offset = "0xA6297E0", VA = "0x18A62ABE0")]
		protected RigidTransformer(RigidTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA62A8E0", Offset = "0xA6294E0", VA = "0x18A62A8E0", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA62AA00", Offset = "0xA629600", VA = "0x18A62AA00", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA62AA20", Offset = "0xA629620", VA = "0x18A62AA20", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA62AA70", Offset = "0xA629670", VA = "0x18A62AA70", Slot = "11")]
		void Schema2SceneBuilder.IOperator<Scene>.ApplyTo(Scene dstScene, Schema2SceneBuilder context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[DebuggerDisplay("SkinnedTransformer Node[{_DebugName,nq}] = {Content}")]
	public class SkinnedTransformer : ContentTransformer, Schema2SceneBuilder.IOperator<Scene>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _NodeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private JsonNode _NodeExtras;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private AffineTransform? _MeshPoseWorldTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly List<(NodeBuilder Joint, Matrix4x4? InverseBindMatrix)> _Joints;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA62FAA0", Offset = "0xA62E6A0", VA = "0x18A62FAA0")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA62FB80", Offset = "0xA62E780", VA = "0x18A62FB80")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA62F630", Offset = "0xA62E230", VA = "0x18A62F630")]
		protected SkinnedTransformer(SkinnedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA62E340", Offset = "0xA62CF40", VA = "0x18A62E340", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA62EBA0", Offset = "0xA62D7A0", VA = "0x18A62EBA0")]
		private void SetJoints(AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA62EE70", Offset = "0xA62DA70", VA = "0x18A62EE70")]
		private void SetJoints((NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA62E500", Offset = "0xA62D100", VA = "0x18A62E500")]
		public (NodeBuilder, Matrix4x4)[] GetJointBindings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA62E3B0", Offset = "0xA62CFB0", VA = "0x18A62E3B0", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA62EA00", Offset = "0xA62D600", VA = "0x18A62EA00")]
		public IGeometryTransform GetWorldTransformer(string animationTrack, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA62E8A0", Offset = "0xA62D4A0", VA = "0x18A62E8A0", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA62F270", Offset = "0xA62DE70", VA = "0x18A62F270", Slot = "11")]
		void Schema2SceneBuilder.IOperator<Scene>.ApplyTo(Scene dstScene, Schema2SceneBuilder context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[DebuggerDisplay("_MeshInstancing Node[{_DebugName,nq}] = GpuMeshInstances[{_Children.Count}]")]
	internal readonly struct _MeshInstancing : Schema2SceneBuilder.IOperator<Scene>
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class <CreateFrom>d__2 : IEnumerable<Schema2SceneBuilder.IOperator<Scene>>, IEnumerable, IEnumerator<Schema2SceneBuilder.IOperator<Scene>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private Schema2SceneBuilder.IOperator<Scene> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private IEnumerable<FixedTransformer> instances;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			public IEnumerable<FixedTransformer> <>3__instances;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private int gpuMinCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			public int <>3__gpuMinCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private List<FixedTransformer> <renderables>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private IEnumerator<IGrouping<IRenderableContent, FixedTransformer>> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private IEnumerator<IGrouping<NodeBuilder, FixedTransformer>> <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private IGrouping<NodeBuilder, FixedTransformer> <sameParent>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			Schema2SceneBuilder.IOperator<Scene> IEnumerator<Schema2SceneBuilder.IOperator<Scene>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <CreateFrom>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA6320C0", Offset = "0xA630CC0", VA = "0x18A6320C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA631360", Offset = "0xA62FF60", VA = "0x18A631360", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA632350", Offset = "0xA630F50", VA = "0x18A632350")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA6323A0", Offset = "0xA630FA0", VA = "0x18A6323A0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xA6323F0", Offset = "0xA630FF0", VA = "0x18A6323F0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA632080", Offset = "0xA630C80", VA = "0x18A632080", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA631FD0", Offset = "0xA630BD0", VA = "0x18A631FD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Schema2SceneBuilder.IOperator<Scene>> IEnumerable<Schema2SceneBuilder.IOperator<Scene>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA631FD0", Offset = "0xA630BD0", VA = "0x18A631FD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly NodeBuilder _ParentNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly IReadOnlyList<FixedTransformer> _Children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly int _GpuMinCount;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA63EAC0", Offset = "0xA63D6C0", VA = "0x18A63EAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA63E1D0", Offset = "0xA63CDD0", VA = "0x18A63E1D0")]
		[IteratorStateMachine(typeof(<CreateFrom>d__2))]
		public static IEnumerable<Schema2SceneBuilder.IOperator<Scene>> CreateFrom(IEnumerable<FixedTransformer> instances, int gpuMinCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA63E9B0", Offset = "0xA63D5B0", VA = "0x18A63E9B0")]
		private _MeshInstancing(NodeBuilder parentNode, IEnumerable<FixedTransformer> children, int gpuMinCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA63DF40", Offset = "0xA63CB40", VA = "0x18A63DF40", Slot = "4")]
		public void ApplyTo(Scene dstScene, Schema2SceneBuilder context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xA63E250", Offset = "0xA63CE50", VA = "0x18A63E250")]
		private void _AddInstances(IVisualNodeContainer dst, Schema2SceneBuilder context)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[DebuggerDisplay("_FixedIntance Node[{_DebugName,nq}] = {Content}")]
	internal readonly struct _FixedIntance : Schema2SceneBuilder.IOperator<Scene>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly FixedTransformer _srcChild;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA63DEE0", Offset = "0xA63CAE0", VA = "0x18A63DEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		public _FixedIntance(FixedTransformer fixedXformer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA63DD30", Offset = "0xA63C930", VA = "0x18A63DD30", Slot = "4")]
		void Schema2SceneBuilder.IOperator<Scene>.ApplyTo(Scene dstScene, Schema2SceneBuilder context)
		{
		}
	}
}
namespace SharpGLTF.Materials
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public class ChannelBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		private sealed class _ContentComparer : IEqualityComparer<ChannelBuilder>
		{
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			public static readonly _ContentComparer Default;

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0xA63DB60", Offset = "0xA63C760", VA = "0x18A63DB60", Slot = "4")]
			public bool Equals(ChannelBuilder x, ChannelBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xA632F60", Offset = "0xA631B60", VA = "0x18A632F60", Slot = "5")]
			public int GetHashCode(ChannelBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public _ContentComparer()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MaterialBuilder _Parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly KnownChannel _Key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MaterialValue.Collection _Parameters;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public TextureBuilder Texture
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public KnownChannel Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0")]
			get
			{
				return default(KnownChannel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[Obsolete("Use .Parameters[KnownProperty] or .Parameters.CombinedVector")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Vector4 Parameter
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA621090", Offset = "0xA61FC90", VA = "0x18A621090")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA6210D0", Offset = "0xA61FCD0", VA = "0x18A6210D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public MaterialValue.Collection Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static IEqualityComparer<ChannelBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xA621040", Offset = "0xA61FC40", VA = "0x18A621040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA620D70", Offset = "0xA61F970", VA = "0x18A620D70")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA620E50", Offset = "0xA61FA50", VA = "0x18A620E50")]
		internal ChannelBuilder(MaterialBuilder parent, KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA620A90", Offset = "0xA61F690", VA = "0x18A620A90")]
		public static bool AreEqualByContent(ChannelBuilder x, ChannelBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA620C00", Offset = "0xA61F800", VA = "0x18A620C00")]
		public static int GetContentHashCode(ChannelBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA620C80", Offset = "0xA61F880", VA = "0x18A620C80")]
		public TextureBuilder GetValidTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA620CA0", Offset = "0xA61F8A0", VA = "0x18A620CA0")]
		public TextureBuilder UseTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xD1C450", Offset = "0xD1B050", VA = "0x180D1C450")]
		public void RemoveTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA620B80", Offset = "0xA61F780", VA = "0x18A620B80")]
		internal void CopyTo(ChannelBuilder other)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[DebuggerDisplay("{_DebuggerDisplay(),nq}")]
	public sealed class ImageBuilder : BaseBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public MemoryImage Content
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xED3CD0", Offset = "0xED28D0", VA = "0x180ED3CD0")]
			[CompilerGenerated]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x7907320", Offset = "0x7905F20", VA = "0x187907320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA624080", Offset = "0xA622C80", VA = "0x18A624080")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA6241C0", Offset = "0xA622DC0", VA = "0x18A6241C0")]
		public static implicit operator ImageBuilder(ArraySegment<byte> image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA624370", Offset = "0xA622F70", VA = "0x18A624370")]
		public static implicit operator ImageBuilder(byte[] image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA6242A0", Offset = "0xA622EA0", VA = "0x18A6242A0")]
		public static implicit operator ImageBuilder(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA624440", Offset = "0xA623040", VA = "0x18A624440")]
		public static implicit operator ImageBuilder(MemoryImage content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA623D80", Offset = "0xA622980", VA = "0x18A623D80")]
		public static ImageBuilder From(MemoryImage content, [Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA623E40", Offset = "0xA622A40", VA = "0x18A623E40")]
		public static ImageBuilder From(MemoryImage content, string name, JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA624140", Offset = "0xA622D40", VA = "0x18A624140")]
		private ImageBuilder(MemoryImage content, string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA623D00", Offset = "0xA622900", VA = "0x18A623D00")]
		internal ImageBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA624180", Offset = "0xA622D80", VA = "0x18A624180")]
		private ImageBuilder(ImageBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA623BC0", Offset = "0xA6227C0", VA = "0x18A623BC0")]
		public static bool AreEqualByContent(ImageBuilder x, ImageBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xA623F10", Offset = "0xA622B10", VA = "0x18A623F10")]
		public static int GetContentHashCode(ImageBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA623FA0", Offset = "0xA622BA0", VA = "0x18A623FA0")]
		public static bool IsEmpty(ImageBuilder ib)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA624010", Offset = "0xA622C10", VA = "0x18A624010")]
		public static bool IsValid(ImageBuilder ib)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[DebuggerDisplay("{_DebuggerDisplay(),nq}")]
	public class MaterialBuilder : BaseBuilder, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		private sealed class _ContentComparer : IEqualityComparer<MaterialBuilder>
		{
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			public static readonly _ContentComparer Default;

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xA63DAE0", Offset = "0xA63C6E0", VA = "0x18A63DAE0", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA63DB80", Offset = "0xA63C780", VA = "0x18A63DB80", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public _ContentComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		private sealed class _ReferenceComparer : IEqualityComparer<MaterialBuilder>
		{
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			public static readonly _ReferenceComparer Default;

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x171A9B0", Offset = "0x17195B0", VA = "0x18171A9B0", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x7885640", Offset = "0x7884240", VA = "0x187885640", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public _ReferenceComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public const string SHADERUNLIT = "Unlit";

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public const string SHADERPBRMETALLICROUGHNESS = "PBRMetallicRoughness";

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public const string SHADERPBRSPECULARGLOSSINESS = "PBRSpecularGlossiness";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly List<ChannelBuilder> _Channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private MaterialBuilder _CompatibilityFallbackMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _ShaderStyle;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly KnownChannel[] _UnlitChannels;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		internal static readonly KnownChannel[] _MetRouChannels;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[Obsolete("Deprecated by Khronos")]
		private static readonly KnownChannel[] _SpeGloChannels;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public AlphaMode AlphaMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1DB90", VA = "0x180D1EF90")]
			[CompilerGenerated]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xDE9880", Offset = "0xDE8480", VA = "0x180DE9880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xD1EF80", Offset = "0xD1DB80", VA = "0x180D1EF80")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xD1ECB0", Offset = "0xD1D8B0", VA = "0x180D1ECB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xF50890", Offset = "0xF4F490", VA = "0x180F50890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xF50430", Offset = "0xF4F030", VA = "0x180F50430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string ShaderStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xA628610", Offset = "0xA627210", VA = "0x18A628610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xD40A60", Offset = "0xD3F660", VA = "0x180D40A60")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x14F3DB0", Offset = "0x14F29B0", VA = "0x1814F3DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x121C680", Offset = "0x121B280", VA = "0x18121C680")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x2AA94D0", Offset = "0x2AA80D0", VA = "0x182AA94D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public IReadOnlyCollection<ChannelBuilder> Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MaterialBuilder CompatibilityFallback
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA628570", Offset = "0xA627170", VA = "0x18A628570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public static IEqualityComparer<MaterialBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA6284D0", Offset = "0xA6270D0", VA = "0x18A6284D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public static IEqualityComparer<MaterialBuilder> ReferenceComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA628520", Offset = "0xA627120", VA = "0x18A628520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA627AC0", Offset = "0xA6266C0", VA = "0x18A627AC0")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA624950", Offset = "0xA623550", VA = "0x18A624950")]
		public static MaterialBuilder CreateDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA628410", Offset = "0xA627010", VA = "0x18A628410")]
		public MaterialBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA624FC0", Offset = "0xA623BC0", VA = "0x18A624FC0", Slot = "8")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA6248F0", Offset = "0xA6234F0", VA = "0x18A6248F0")]
		public MaterialBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA6280C0", Offset = "0xA626CC0", VA = "0x18A6280C0")]
		public MaterialBuilder(MaterialBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xCF25B0", Offset = "0xCF11B0", VA = "0x180CF25B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF5630", Offset = "0xCF4230", VA = "0x180CF5630", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6244F0", Offset = "0xA6230F0", VA = "0x18A6244F0")]
		public static bool AreEqualByContent(MaterialBuilder x, MaterialBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA624C50", Offset = "0xA623850", VA = "0x18A624C50")]
		public static int GetContentHashCode(MaterialBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA627D80", Offset = "0xA626980", VA = "0x18A627D80")]
		private void _SetShader(string shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA624B20", Offset = "0xA623720", VA = "0x18A624B20")]
		[Obsolete("Use GetChannel with KnownChannel whenever possible")]
		public ChannelBuilder GetChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6251A0", Offset = "0xA623DA0", VA = "0x18A6251A0")]
		[Obsolete("Use UseChannel with KnownChannel whenever possible")]
		public ChannelBuilder UseChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA624A50", Offset = "0xA623650", VA = "0x18A624A50")]
		public ChannelBuilder GetChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xA625020", Offset = "0xA623C20", VA = "0x18A625020")]
		public ChannelBuilder UseChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA624EC0", Offset = "0xA623AC0", VA = "0x18A624EC0")]
		public void RemoveChannel(KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA6252D0", Offset = "0xA623ED0", VA = "0x18A6252D0")]
		internal void ValidateForSchema2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA627290", Offset = "0xA625E90", VA = "0x18A627290")]
		public MaterialBuilder WithShader(string shader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA627870", Offset = "0xA626470", VA = "0x18A627870")]
		public MaterialBuilder WithUnlitShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA626E10", Offset = "0xA625A10", VA = "0x18A626E10")]
		public MaterialBuilder WithMetallicRoughnessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA627440", Offset = "0xA626040", VA = "0x18A627440")]
		[Obsolete("SpecularGlossiness has been deprecated by Khronos")]
		public MaterialBuilder WithSpecularGlossinessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA625930", Offset = "0xA624530", VA = "0x18A625930")]
		public MaterialBuilder WithAlpha(AlphaMode alphaMode = AlphaMode.OPAQUE, float alphaCutoff = 0.5f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x903A970", Offset = "0x9039570", VA = "0x18903A970")]
		public MaterialBuilder WithDoubleSide(bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA625E90", Offset = "0xA624A90", VA = "0x18A625E90")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA625DB0", Offset = "0xA6249B0", VA = "0x18A625DB0")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(string channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA625C70", Offset = "0xA624870", VA = "0x18A625C70")]
		[Obsolete("Use WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)")]
		public MaterialBuilder WithChannelImage(string channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA625E00", Offset = "0xA624A00", VA = "0x18A625E00")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, object parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA625CC0", Offset = "0xA6248C0", VA = "0x18A625CC0")]
		public MaterialBuilder WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA626730", Offset = "0xA625330", VA = "0x18A626730")]
		public MaterialBuilder WithFallback(MaterialBuilder fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA626A80", Offset = "0xA625680", VA = "0x18A626A80")]
		public MaterialBuilder WithMetallicRoughnessFallback(ImageBuilder baseColor, Vector4? rgba, ImageBuilder metallicRoughness, float? metallic, float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA627110", Offset = "0xA625D10", VA = "0x18A627110")]
		public MaterialBuilder WithNormal(ImageBuilder imageFile, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6271D0", Offset = "0xA625DD0", VA = "0x18A6271D0")]
		public MaterialBuilder WithOcclusion(ImageBuilder imageFile, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6265C0", Offset = "0xA6251C0", VA = "0x18A6265C0")]
		public MaterialBuilder WithEmissive(Vector3 rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA626400", Offset = "0xA625000", VA = "0x18A626400")]
		public MaterialBuilder WithEmissive(ImageBuilder imageFile, [Optional] Vector3? rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA625A90", Offset = "0xA624690", VA = "0x18A625A90")]
		public MaterialBuilder WithBaseColor(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA625B50", Offset = "0xA624750", VA = "0x18A625B50")]
		public MaterialBuilder WithBaseColor(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA626FB0", Offset = "0xA625BB0", VA = "0x18A626FB0")]
		public MaterialBuilder WithMetallicRoughness([Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA626E50", Offset = "0xA625A50", VA = "0x18A626E50")]
		public MaterialBuilder WithMetallicRoughness(ImageBuilder imageFile, [Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA625EE0", Offset = "0xA624AE0", VA = "0x18A625EE0")]
		public MaterialBuilder WithClearCoatNormal(ImageBuilder imageFile)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA625FD0", Offset = "0xA624BD0", VA = "0x18A625FD0")]
		public MaterialBuilder WithClearCoat(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xA625F10", Offset = "0xA624B10", VA = "0x18A625F10")]
		public MaterialBuilder WithClearCoatRoughness(ImageBuilder imageFile, float roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6277B0", Offset = "0xA6263B0", VA = "0x18A6277B0")]
		public MaterialBuilder WithTransmission(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA626160", Offset = "0xA624D60", VA = "0x18A626160")]
		public MaterialBuilder WithDiffuseTransmissionFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA626090", Offset = "0xA624C90", VA = "0x18A626090")]
		public MaterialBuilder WithDiffuseTransmissionColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA6272B0", Offset = "0xA625EB0", VA = "0x18A6272B0")]
		public MaterialBuilder WithSpecularColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA627380", Offset = "0xA625F80", VA = "0x18A627380")]
		public MaterialBuilder WithSpecularFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA627A00", Offset = "0xA626600", VA = "0x18A627A00")]
		public MaterialBuilder WithVolumeThickness(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6278B0", Offset = "0xA6264B0", VA = "0x18A6278B0")]
		public MaterialBuilder WithVolumeAttenuation(Vector3 color, float distance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA626930", Offset = "0xA625530", VA = "0x18A626930")]
		public MaterialBuilder WithIridescence(ImageBuilder imageFile, float factor = 0f, float ior = 1.3f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA6267E0", Offset = "0xA6253E0", VA = "0x18A6267E0")]
		public MaterialBuilder WithIridescenceThickness(ImageBuilder imageFile, float min = 100f, float max = 400f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA625940", Offset = "0xA624540", VA = "0x18A625940")]
		public MaterialBuilder WithAnisotropy(ImageBuilder imageFile, float strength = 0f, float rotation = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA626220", Offset = "0xA624E20", VA = "0x18A626220")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA6262E0", Offset = "0xA624EE0", VA = "0x18A6262E0")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA627620", Offset = "0xA626220", VA = "0x18A627620")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness([Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA627480", Offset = "0xA626080", VA = "0x18A627480")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness(ImageBuilder imageFile, [Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA627C20", Offset = "0xA626820", VA = "0x18A627C20")]
		private IReadOnlyList<KnownChannel> _GetValidChannels()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public enum AlphaMode
	{
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		OPAQUE,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		MASK,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		BLEND
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum KnownChannel
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Occlusion,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Emissive,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		BaseColor,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		MetallicRoughness,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use BaseColor instead.")]
		Diffuse,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use SpecularColor instead.")]
		SpecularGlossiness,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		ClearCoat,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		ClearCoatNormal,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		ClearCoatRoughness,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		Transmission,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		SheenColor,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		SheenRoughness,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		SpecularColor,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		SpecularFactor,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		VolumeThickness,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		VolumeAttenuation,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		Iridescence,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		IridescenceThickness,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		Anisotropy,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		DiffuseTransmissionColor,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		DiffuseTransmissionFactor
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public enum KnownProperty
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		RGB,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		RGBA,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Minimum,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Maximum,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		NormalScale,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		OcclusionStrength,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		EmissiveStrength,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		IndexOfRefraction,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		MetallicFactor,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		RoughnessFactor,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		SpecularFactor,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		GlossinessFactor,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		ClearCoatFactor,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		ThicknessFactor,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		TransmissionFactor,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		IridescenceFactor,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		AttenuationDistance,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		DiffuseTransmissionFactor,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		AnisotropyStrength,
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		AnisotropyRotation
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[DebuggerDisplay("{ToString(),nq}")]
	public readonly struct MaterialValue : IEquatable<MaterialValue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[DebuggerDisplay("{ToString(),nq}")]
		internal sealed class _Property : IEquatable<_Property>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private readonly MaterialValue _Default;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			private MaterialValue _Value;

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public KnownProperty Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000406")]
				[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110")]
				[CompilerGenerated]
				get
				{
					return default(KnownProperty);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x600040D")]
				[Cpp2IlInjected.Address(RVA = "0xA63F120", Offset = "0xA63DD20", VA = "0x18A63F120")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public MaterialValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0xFFB070", Offset = "0xFF9C70", VA = "0x180FFB070")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0xA63F1C0", Offset = "0xA63DDC0", VA = "0x18A63F1C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xA63EEB0", Offset = "0xA63DAB0", VA = "0x18A63EEB0")]
			internal _Property(KnownProperty key, float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA63EF70", Offset = "0xA63DB70", VA = "0x18A63EF70")]
			internal _Property(KnownProperty key, Vector2 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA63EDE0", Offset = "0xA63D9E0", VA = "0x18A63EDE0")]
			internal _Property(KnownProperty key, Vector3 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA63F040", Offset = "0xA63DC40", VA = "0x18A63F040")]
			internal _Property(KnownProperty key, Vector4 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA63ECB0", Offset = "0xA63D8B0", VA = "0x18A63ECB0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xA63EC40", Offset = "0xA63D840", VA = "0x18A63EC40", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA63EB10", Offset = "0xA63D710", VA = "0x18A63EB10", Slot = "4")]
			public bool Equals(_Property other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA63F180", Offset = "0xA63DD80", VA = "0x18A63F180")]
			public static bool operator ==(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xA63F1A0", Offset = "0xA63DDA0", VA = "0x18A63F1A0")]
			public static bool operator !=(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xA63EB10", Offset = "0xA63D710", VA = "0x18A63EB10")]
			public static bool AreEqual(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA63ECF0", Offset = "0xA63D8F0", VA = "0x18A63ECF0")]
			public void SetDefault()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xA63ED00", Offset = "0xA63D900", VA = "0x18A63ED00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
		public sealed class Collection : IReadOnlyDictionary<KnownProperty, MaterialValue>, IEnumerable<KeyValuePair<KnownProperty, MaterialValue>>, IEnumerable, IReadOnlyCollection<KeyValuePair<KnownProperty, MaterialValue>>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			private readonly _Property[] _Properties;

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public MaterialValue this[KnownProperty key]
			{
				[Cpp2IlInjected.Token(Token = "0x6000416")]
				[Cpp2IlInjected.Address(RVA = "0xA622010", Offset = "0xA620C10", VA = "0x18A622010", Slot = "6")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0xA622A00", Offset = "0xA621600", VA = "0x18A622A00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public MaterialValue this[string keyName]
			{
				[Cpp2IlInjected.Token(Token = "0x6000418")]
				[Cpp2IlInjected.Address(RVA = "0xA621E90", Offset = "0xA620A90", VA = "0x18A621E90")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000419")]
				[Cpp2IlInjected.Address(RVA = "0xA622920", Offset = "0xA621520", VA = "0x18A622920")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public IEnumerable<KnownProperty> Keys
			{
				[Cpp2IlInjected.Token(Token = "0x600041A")]
				[Cpp2IlInjected.Address(RVA = "0xA622100", Offset = "0xA620D00", VA = "0x18A622100", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public IEnumerable<MaterialValue> Values
			{
				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0xA622220", Offset = "0xA620E20", VA = "0x18A622220", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x2838540", Offset = "0x2837140", VA = "0x182838540", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public Vector4 CombinedVector
			{
				[Cpp2IlInjected.Token(Token = "0x600041D")]
				[Cpp2IlInjected.Address(RVA = "0xA621CE0", Offset = "0xA6208E0", VA = "0x18A621CE0")]
				get
				{
					return default(Vector4);
				}
				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0xA622340", Offset = "0xA620F40", VA = "0x18A622340")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xA621BA0", Offset = "0xA6207A0", VA = "0x18A621BA0")]
			private string _GetDebuggerDisplay()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
			internal Collection(_Property[] properties)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xA621870", Offset = "0xA620470", VA = "0x18A621870", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xA621100", Offset = "0xA61FD00", VA = "0x18A621100")]
			public static bool AreEqual(Collection x, Collection y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA6213B0", Offset = "0xA61FFB0", VA = "0x18A6213B0", Slot = "4")]
			public bool ContainsKey(KnownProperty key)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xA621A70", Offset = "0xA620670", VA = "0x18A621A70", Slot = "5")]
			public bool TryGetValue(KnownProperty key, [Out] MaterialValue value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA621730", Offset = "0xA620330", VA = "0x18A621730", Slot = "10")]
			public IEnumerator<KeyValuePair<KnownProperty, MaterialValue>> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA621930", Offset = "0xA620530", VA = "0x18A621930", Slot = "11")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xA6218E0", Offset = "0xA6204E0", VA = "0x18A6218E0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA621480", Offset = "0xA620080", VA = "0x18A621480")]
			public void CopyTo(Collection other)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class <_CreateDefaultProperties>d__1 : IEnumerable<_Property>, IEnumerable, IEnumerator<_Property>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private _Property <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private KnownChannel key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public KnownChannel <>3__key;

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			_Property IEnumerator<_Property>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <_CreateDefaultProperties>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA634580", Offset = "0xA633180", VA = "0x18A634580", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xA635050", Offset = "0xA633C50", VA = "0x18A635050", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA634FB0", Offset = "0xA633BB0", VA = "0x18A634FB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<_Property> IEnumerable<_Property>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xA634FB0", Offset = "0xA633BB0", VA = "0x18A634FB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private readonly int _Length;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private readonly float _X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private readonly float _Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private readonly float _Z;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private readonly float _W;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xA6290B0", Offset = "0xA627CB0", VA = "0x18A6290B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA628680", Offset = "0xA627280", VA = "0x18A628680")]
		internal static Collection CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA628FB0", Offset = "0xA627BB0", VA = "0x18A628FB0")]
		[IteratorStateMachine(typeof(<_CreateDefaultProperties>d__1))]
		private static IEnumerable<_Property> _CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA6294B0", Offset = "0xA6280B0", VA = "0x18A6294B0")]
		public static implicit operator MaterialValue(float value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA629420", Offset = "0xA628020", VA = "0x18A629420")]
		public static implicit operator MaterialValue(Vector2 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA629450", Offset = "0xA628050", VA = "0x18A629450")]
		public static implicit operator MaterialValue(Vector3 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA629480", Offset = "0xA628080", VA = "0x18A629480")]
		public static implicit operator MaterialValue(Vector4 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA628790", Offset = "0xA627390", VA = "0x18A628790")]
		public static MaterialValue CreateFrom(object value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA629090", Offset = "0xA627C90", VA = "0x18A629090")]
		private MaterialValue(float x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xA629070", Offset = "0xA627C70", VA = "0x18A629070")]
		private MaterialValue(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xA629020", Offset = "0xA627C20", VA = "0x18A629020")]
		private MaterialValue(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA629040", Offset = "0xA627C40", VA = "0x18A629040")]
		private MaterialValue(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA628B70", Offset = "0xA627770", VA = "0x18A628B70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA628A70", Offset = "0xA627670", VA = "0x18A628A70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA628620", Offset = "0xA627220", VA = "0x18A628620", Slot = "4")]
		public bool Equals(MaterialValue other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA628620", Offset = "0xA627220", VA = "0x18A628620")]
		public static bool operator ==([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6294D0", Offset = "0xA6280D0", VA = "0x18A6294D0")]
		public static bool operator !=([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA628620", Offset = "0xA627220", VA = "0x18A628620")]
		public static bool AreEqual([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA629240", Offset = "0xA627E40", VA = "0x18A629240")]
		public static explicit operator float(MaterialValue value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6293A0", Offset = "0xA627FA0", VA = "0x18A6293A0")]
		public static explicit operator Vector2(MaterialValue value)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA629320", Offset = "0xA627F20", VA = "0x18A629320")]
		public static explicit operator Vector3(MaterialValue value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6292A0", Offset = "0xA627EA0", VA = "0x18A6292A0")]
		public static explicit operator Vector4(MaterialValue value)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA628C60", Offset = "0xA627860", VA = "0x18A628C60")]
		public object ToTypeless()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA628C20", Offset = "0xA627820", VA = "0x18A628C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA628F40", Offset = "0xA627B40", VA = "0x18A628F40")]
		internal int _CopyTo(Span<float> dst)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[DebuggerDisplay("{_DebuggerDisplay(),nq}")]
	public class TextureBuilder : BaseBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		private sealed class _ContentComparer : IEqualityComparer<TextureBuilder>
		{
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public static readonly _ContentComparer Default;

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xA63DB40", Offset = "0xA63C740", VA = "0x18A63DB40", Slot = "4")]
			public bool Equals(TextureBuilder x, TextureBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA63DBD0", Offset = "0xA63C7D0", VA = "0x18A63DBD0", Slot = "5")]
			public int GetHashCode(TextureBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public _ContentComparer()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ChannelBuilder _Parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ImageBuilder _PrimaryImageContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ImageBuilder _FallbackImageContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TextureTransformBuilder _Transform;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public int CoordinateSet
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD60", Offset = "0xD0B960", VA = "0x180D0CD60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xD6E2C0", Offset = "0xD6CEC0", VA = "0x180D6E2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public TextureMipMapFilter MinFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD70", Offset = "0xD0B970", VA = "0x180D0CD70")]
			[CompilerGenerated]
			get
			{
				return default(TextureMipMapFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xD6E2B0", Offset = "0xD6CEB0", VA = "0x180D6E2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xD66FC0", Offset = "0xD65BC0", VA = "0x180D66FC0")]
			[CompilerGenerated]
			get
			{
				return default(TextureInterpolationFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xD68130", Offset = "0xD66D30", VA = "0x180D68130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x167FB90", Offset = "0x167E790", VA = "0x18167FB90")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x1C745F0", Offset = "0x1C731F0", VA = "0x181C745F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xEEF700", Offset = "0xEEE300", VA = "0x180EEF700")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x1AAA870", Offset = "0x1AA9470", VA = "0x181AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public ImageBuilder PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA630C30", Offset = "0xA62F830", VA = "0x18A630C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ImageBuilder FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA630B10", Offset = "0xA62F710", VA = "0x18A630B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public TextureTransformBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public static IEqualityComparer<TextureBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA630AC0", Offset = "0xA62F6C0", VA = "0x18A630AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA630720", Offset = "0xA62F320", VA = "0x18A630720")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA6309E0", Offset = "0xA62F5E0", VA = "0x18A6309E0")]
		internal TextureBuilder(ChannelBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA62FC30", Offset = "0xA62E830", VA = "0x18A62FC30")]
		public static bool AreEqualByContent(TextureBuilder x, TextureBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xA630100", Offset = "0xA62ED00", VA = "0x18A630100")]
		public static int GetContentHashCode(TextureBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xA62FEB0", Offset = "0xA62EAB0", VA = "0x18A62FEB0")]
		internal void CopyTo(TextureBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xA6302B0", Offset = "0xA62EEB0", VA = "0x18A6302B0")]
		public TextureBuilder WithCoordinateSet(int cset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA6303E0", Offset = "0xA62EFE0", VA = "0x18A6303E0")]
		public TextureBuilder WithPrimaryImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA6302C0", Offset = "0xA62EEC0", VA = "0x18A6302C0")]
		public TextureBuilder WithFallbackImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA6304D0", Offset = "0xA62F0D0", VA = "0x18A6304D0")]
		public TextureBuilder WithSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xA6304F0", Offset = "0xA62F0F0", VA = "0x18A6304F0")]
		public TextureBuilder WithTransform(float offsetX, float offsetY, float scaleX = 1f, float scaleY = 1f, float rotation = 0f, [Optional] int? coordSetOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xA630630", Offset = "0xA62F230", VA = "0x18A630630")]
		public TextureBuilder WithTransform(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? coordSetOverride)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[DebuggerDisplay("Transform \ud835\udc12:{Scale} \ud835\udc11:{Rotation} \ud835\udebb:{Offset}")]
	public class TextureTransformBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Vector2 Offset
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x32B04C0", Offset = "0x32AF0C0", VA = "0x1832B04C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xE84FE0", Offset = "0xE83BE0", VA = "0x180E84FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x1E84E40", Offset = "0x1E83A40", VA = "0x181E84E40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xDDD760", Offset = "0xDDC360", VA = "0x180DDD760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xD47F10", Offset = "0xD46B10", VA = "0x180D47F10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x10AD2D0", Offset = "0x10ABED0", VA = "0x1810AD2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int? CoordinateSetOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x13F8A00", Offset = "0x13F7600", VA = "0x1813F8A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x10ACC30", Offset = "0x10AB830", VA = "0x1810ACC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xA630F10", Offset = "0xA62FB10", VA = "0x18A630F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xA630E80", Offset = "0xA62FA80", VA = "0x18A630E80")]
		internal TextureTransformBuilder(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? coordSetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xA630D90", Offset = "0xA62F990", VA = "0x18A630D90")]
		internal TextureTransformBuilder(TextureTransformBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA630C40", Offset = "0xA62F840", VA = "0x18A630C40")]
		public static bool AreEqualByContent(TextureTransformBuilder a, TextureTransformBuilder b)
		{
			return default(bool);
		}
	}
}
namespace SharpGLTF.IO
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	internal class WavefrontWriter
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[DebuggerDisplay("{DiffuseColor} {DiffuseTexture.ToDebuggerDisplay()}")]
		public struct Material : IEquatable<Material>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public Vector3 DiffuseColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public Vector3 SpecularColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public float Opacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public MemoryImage DiffuseTexture;

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xA629730", Offset = "0xA628330", VA = "0x18A629730", Slot = "2")]
			public override readonly int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA629680", Offset = "0xA628280", VA = "0x18A629680", Slot = "0")]
			public override readonly bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA629530", Offset = "0xA628130", VA = "0x18A629530", Slot = "4")]
			public readonly bool Equals(Material other)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static readonly Encoding FILEENCODING;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly MeshBuilder<Material, VertexPositionNormal, VertexTexture1, VertexEmpty> _Mesh;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xA638C00", Offset = "0xA637800", VA = "0x18A638C00")]
		public void AddTriangle(Material material, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> a, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> b, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA6393C0", Offset = "0xA637FC0", VA = "0x18A6393C0")]
		public void WriteFiles(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA638D40", Offset = "0xA637940", VA = "0x18A638D40")]
		public IReadOnlyDictionary<string, ArraySegment<byte>> GetFiles(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xA639690", Offset = "0xA638290", VA = "0x18A639690")]
		private Dictionary<string, Action<Stream>> _GetFileGenerators(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xA639A70", Offset = "0xA638670", VA = "0x18A639A70")]
		private static Dictionary<Material, string> _GetMaterialsFileGenerator(IDictionary<string, Action<Stream>> fileGenerators, string baseName, IEnumerable<Material> materials)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xA63BAA0", Offset = "0xA63A6A0", VA = "0x18A63BAA0")]
		private static void _WriteMaterialsFile(Stream fs, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xA63BBF0", Offset = "0xA63A7F0", VA = "0x18A63BBF0")]
		private static void _WriteMaterialsFile(StreamWriter sw, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xA63A470", Offset = "0xA639070", VA = "0x18A63A470")]
		private void _WriteGeometryFile(Stream s, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xA63A5A0", Offset = "0xA6391A0", VA = "0x18A63A5A0")]
		private void _WriteGeometryFile(StreamWriter sw, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA6385B0", Offset = "0xA6371B0", VA = "0x18A6385B0")]
		public void AddModel(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA6388C0", Offset = "0xA6374C0", VA = "0x18A6388C0")]
		public void AddModel(ModelRoot model, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA639180", Offset = "0xA637D80", VA = "0x18A639180")]
		private static Material GetMaterialFromTriangle(SharpGLTF.Schema2.Material srcMaterial)
		{
			return default(Material);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xA63C6D0", Offset = "0xA63B2D0", VA = "0x18A63C6D0")]
		public WavefrontWriter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class ZipReader : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private ZipArchive _Archive;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public IEnumerable<string> ModelFiles
		{
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0xA63D530", Offset = "0xA63C130", VA = "0x18A63D530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xA63C780", Offset = "0xA63B380", VA = "0x18A63C780")]
		public static ModelRoot LoadModelFromZip(string zipPath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xA63D4C0", Offset = "0xA63C0C0", VA = "0x18A63D4C0")]
		public ZipReader(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xA63D3F0", Offset = "0xA63BFF0", VA = "0x18A63D3F0")]
		public ZipReader(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xA63C750", Offset = "0xA63B350", VA = "0x18A63C750", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA63CE40", Offset = "0xA63BA40", VA = "0x18A63CE40")]
		private IEnumerable<ZipArchiveEntry> _GetEntries()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xA63CB10", Offset = "0xA63B710", VA = "0x18A63CB10")]
		public ModelRoot LoadModel([Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xA63CA50", Offset = "0xA63B650", VA = "0x18A63CA50")]
		public ModelRoot LoadModel(string gltfFile, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA63D050", Offset = "0xA63BC50", VA = "0x18A63D050")]
		private ArraySegment<byte> _ReadAsset(string rawUri)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xA63CD00", Offset = "0xA63B900", VA = "0x18A63CD00")]
		private ZipArchiveEntry _FindEntry(string filePath)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class ZipWriter : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private ZipArchive _Archive;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0xA63DA70", Offset = "0xA63C670", VA = "0x18A63DA70")]
		public ZipWriter(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA63D9A0", Offset = "0xA63C5A0", VA = "0x18A63D9A0")]
		public ZipWriter(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA63C750", Offset = "0xA63B350", VA = "0x18A63C750", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA63D650", Offset = "0xA63C250", VA = "0x18A63D650")]
		public void AddModel(string filePath, ModelRoot model, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA63D850", Offset = "0xA63C450", VA = "0x18A63D850")]
		private void _WriteAsset(string filePath, ArraySegment<byte> bytes)
		{
		}
	}
}
namespace SharpGLTF.Geometry
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class MeshBuilder<TMaterial, TvG, TvM, TvS> : BaseBuilder, IMeshBuilder<TMaterial>, ICloneable where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Dictionary<(TMaterial Material, int PrimType), PrimitiveBuilder<TMaterial, TvG, TvM, TvS>> _Primitives;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VertexPreprocessor<TvG, TvM, TvS> _VertexPreprocessor;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x6F8A560", Offset = "0x6F89160", VA = "0x186F8A560", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public VertexPreprocessor<TvG, TvM, TvS> VertexPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IEnumerable<TMaterial> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x6F8A750", Offset = "0x6F89350", VA = "0x186F8A750", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyCollection<PrimitiveBuilder<TMaterial, TvG, TvM, TvS>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x6F83BB0", Offset = "0x6F827B0", VA = "0x186F83BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		IReadOnlyCollection<IPrimitiveReader<TMaterial>> IMeshBuilder<TMaterial>.Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x6F83BB0", Offset = "0x6F827B0", VA = "0x186F83BB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6F89F50", Offset = "0x6F88B50", VA = "0x186F89F50")]
		public MeshBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6F89A40", Offset = "0x6F88640", VA = "0x186F89A40")]
		public MeshBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6F83D30", Offset = "0x6F82930", VA = "0x186F83D30", Slot = "19")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6F82AB0", Offset = "0x6F816B0", VA = "0x186F82AB0", Slot = "17")]
		IMeshBuilder<TMaterial> IMeshBuilder<TMaterial>.Clone(Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6F82AB0", Offset = "0x6F816B0", VA = "0x186F82AB0")]
		public MeshBuilder<TMaterial, TvG, TvM, TvS> Clone([Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F89F70", Offset = "0x6F88B70", VA = "0x186F89F70")]
		private MeshBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> other, [Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F850E0", Offset = "0x6F83CE0", VA = "0x186F850E0")]
		public MorphTargetBuilder<TMaterial, TvG, TvS, TvM> UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F82F00", Offset = "0x6F81B00", VA = "0x186F82F00", Slot = "16")]
		IMorphTargetBuilder IMeshBuilder<TMaterial>.UseMorphTarget(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F86F00", Offset = "0x6F85B00", VA = "0x186F86F00")]
		private PrimitiveBuilder<TMaterial, TvG, TvM, TvS> _UsePrimitive((TMaterial Material, int PrimType) key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F85720", Offset = "0x6F84320", VA = "0x186F85720")]
		public PrimitiveBuilder<TMaterial, TvG, TvM, TvS> UsePrimitive(TMaterial material, int primitiveVertexCount = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F83630", Offset = "0x6F82230", VA = "0x186F83630", Slot = "15")]
		IPrimitiveBuilder IMeshBuilder<TMaterial>.UsePrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7FC30", Offset = "0x6F7E830", VA = "0x186F7FC30")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, Matrix4x4 vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F81010", Offset = "0x6F7FC10", VA = "0x186F81010")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, [Optional] Func<TMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x39D8490", Offset = "0x39D7090", VA = "0x1839D8490")]
		public void AddMesh<TSourceMaterial>(IMeshBuilder<TSourceMaterial> mesh, Func<TSourceMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F83F60", Offset = "0x6F82B60", VA = "0x186F83F60")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F867A0", Offset = "0x6F853A0", VA = "0x186F867A0", Slot = "18")]
		public void Validate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MeshBuilder<TvG, TvM, TvS> : MeshBuilder<MaterialBuilder, TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F9F0", Offset = "0x6F7E5F0", VA = "0x186F7F9F0")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class MeshBuilder<TvG, TvM> : MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6283390", Offset = "0x6281F90", VA = "0x186283390")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class MeshBuilder<TvG> : MeshBuilder<MaterialBuilder, TvG, VertexEmpty, VertexEmpty> where TvG : struct, IVertexGeometry
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x6283390", Offset = "0x6281F90", VA = "0x186283390")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public interface IMeshBuilder<TMaterial>
	{
		[Cpp2IlInjected.Token(Token = "0x17000097")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		IEnumerable<TMaterial> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		IReadOnlyCollection<IPrimitiveReader<TMaterial>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		IPrimitiveBuilder UsePrimitive(TMaterial material, int primitiveVertexCount = 3);

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IMorphTargetBuilder UseMorphTarget(int index);

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IMeshBuilder<TMaterial> Clone([Optional] Func<TMaterial, TMaterial> materialCloneCallback);

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void Validate();
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal static class MeshBuilderToolkit
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xA629800", Offset = "0xA628400", VA = "0x18A629800")]
		public static VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>[] GetMorphTargetVertices(this IPrimitiveMorphTargetReader morphTarget, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D19280", Offset = "0x3D17E80", VA = "0x183D19280")]
		public static EncodingType GetOptimalIndexEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D19E70", Offset = "0x3D18A70", VA = "0x183D19E70")]
		public static EncodingType GetOptimalJointEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D18BE0", Offset = "0x3D177E0", VA = "0x183D18BE0")]
		public static IMeshBuilder<TMaterial> CreateMeshBuilderFromVertexAttributes<TMaterial>(params string[] vertexAttributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D17F90", Offset = "0x3D16B90", VA = "0x183D17F90")]
		public static IReadOnlyDictionary<Vector3, Vector3> CalculateSmoothNormals<TMaterial>(this IMeshBuilder<TMaterial> srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A460", Offset = "0x3D19060", VA = "0x183D1A460")]
		public static bool IsEmpty<TMaterial>(this IPrimitiveReader<TMaterial> primitive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A7F0", Offset = "0x3D193F0", VA = "0x183D1A7F0")]
		public static bool IsEmpty<TMaterial>(this IMeshBuilder<TMaterial> mesh)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA629990", Offset = "0xA628590", VA = "0x18A629990")]
		public static bool GetQuadrangleDiagonal(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public interface IPrimitiveMorphTargetReader
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyCollection<int> GetTargetIndices();

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IVertexBuilder GetVertex(int vertexIndex);

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty> GetVertexDelta(int vertexIndex);
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	internal class PrimitiveMorphTargetBuilder<TvG, TvM> : IPrimitiveMorphTargetReader where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private readonly Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> _BaseVertexFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private readonly Dictionary<int, VertexBuilder<TvG, TvM, VertexEmpty>> _MorphVertices;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x754F1E0", Offset = "0x754DDE0", VA = "0x18754F1E0")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x754F270", Offset = "0x754DE70", VA = "0x18754F270")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc, PrimitiveMorphTargetBuilder<TvG, TvM> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x754B930", Offset = "0x754A530", VA = "0x18754B930", Slot = "4")]
		public IReadOnlyCollection<int> GetTargetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x754BE50", Offset = "0x754AA50", VA = "0x18754BE50", Slot = "6")]
		public VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty> GetVertexDelta(int vertexIndex)
		{
			return default(VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x754D500", Offset = "0x754C100", VA = "0x18754D500")]
		public void SetVertexDelta(int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x754E0C0", Offset = "0x754CCC0", VA = "0x18754E0C0", Slot = "5")]
		IVertexBuilder IPrimitiveMorphTargetReader.GetVertex(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x754C2E0", Offset = "0x754AEE0", VA = "0x18754C2E0")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex(int vertexIndex)
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x754DB30", Offset = "0x754C730", VA = "0x18754DB30")]
		public void SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x754F060", Offset = "0x754DC60", VA = "0x18754F060")]
		private void _SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x754EFE0", Offset = "0x754DBE0", VA = "0x18754EFE0")]
		private void _RemoveVertex(int vertexIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x754EA40", Offset = "0x754D640", VA = "0x18754EA40")]
		internal void TransformVertices(Func<VertexBuilder<TvG, TvM, VertexEmpty>, VertexBuilder<TvG, TvM, VertexEmpty>> vertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x754C410", Offset = "0x754B010", VA = "0x18754C410")]
		internal void SetMorphTargets(IPrimitiveMorphTargetReader other, IReadOnlyDictionary<int, int> vertexMap, Func<IVertexGeometry, VertexBuilder<TvG, TvM, VertexEmpty>> vertexFunc)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public interface IMorphTargetBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		IReadOnlyCollection<Vector3> Positions
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		IReadOnlyCollection<IVertexGeometry> Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IReadOnlyList<IVertexGeometry> GetVertices(Vector3 position);

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex);

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex, IVertexMaterial morphMaterial);

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta);

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta);

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SetVertexDelta(Vector3 meshPosition, VertexGeometryDelta geometryDelta);

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void SetVertexDelta(Vector3 meshPosition, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta);
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class MorphTargetBuilder<TMaterial, TvG, TvS, TvM> : IMorphTargetBuilder where TvG : struct, IVertexGeometry where TvS : struct, IVertexSkinning where TvM : struct, IVertexMaterial
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private readonly MeshBuilder<TMaterial, TvG, TvM, TvS> _Mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly int _MorphTargetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private readonly Dictionary<TvG, List<(PrimitiveBuilder<TMaterial, TvG, TvM, TvS>, int)>> _Vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private readonly Dictionary<Vector3, List<TvG>> _Positions;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public IReadOnlyCollection<TvG> Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x7055180", Offset = "0x7053D80", VA = "0x187055180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public IReadOnlyCollection<Vector3> Positions
		{
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x7055150", Offset = "0x7053D50", VA = "0x187055150", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		IReadOnlyCollection<IVertexGeometry> IMorphTargetBuilder.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x7051E30", Offset = "0x7050A30", VA = "0x187051E30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x7054B00", Offset = "0x7053700", VA = "0x187054B00")]
		internal MorphTargetBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x7045AB0", Offset = "0x70446B0", VA = "0x187045AB0")]
		public IReadOnlyList<TvG> GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x70478B0", Offset = "0x70464B0", VA = "0x1870478B0")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7046C60", Offset = "0x7045860", VA = "0x187046C60")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x704D180", Offset = "0x704BD80", VA = "0x18704D180")]
		public void SetVertex(TvG meshVertex, VertexBuilder<TvG, TvM, VertexEmpty> morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x704A930", Offset = "0x7049530", VA = "0x18704A930")]
		public void SetVertex(TvG meshVertex, TvG morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x704DCC0", Offset = "0x704C8C0", VA = "0x18704DCC0", Slot = "6")]
		IReadOnlyList<IVertexGeometry> IMorphTargetBuilder.GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x7050C60", Offset = "0x704F860", VA = "0x187050C60", Slot = "7")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x7050260", Offset = "0x704EE60", VA = "0x187050260", Slot = "8")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex, IVertexMaterial morphMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x704FF50", Offset = "0x704EB50", VA = "0x18704FF50", Slot = "9")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x704ECF0", Offset = "0x704D8F0", VA = "0x18704ECF0", Slot = "10")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x7047B40", Offset = "0x7046740", VA = "0x187047B40", Slot = "11")]
		public void SetVertexDelta(Vector3 meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7048CD0", Offset = "0x70478D0", VA = "0x187048CD0", Slot = "12")]
		public void SetVertexDelta(Vector3 meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal class PackedBuffer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private readonly List<MemoryAccessor> _Accessors;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected int? ByteStride
		{
			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xA62A7E0", Offset = "0xA6293E0", VA = "0x18A62A7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA629E70", Offset = "0xA628A70", VA = "0x18A629E70")]
		public void AddAccessors(params MemoryAccessor[] accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA62A040", Offset = "0xA628C40", VA = "0x18A62A040")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA62A760", Offset = "0xA629360", VA = "0x18A62A760")]
		public PackedBuffer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	internal class PackedEncoding
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public EncodingType? ColorEncoding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public EncodingType? JointsEncoding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public EncodingType? WeightsEncoding;

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x3D97240", Offset = "0x3D95E40", VA = "0x183D97240")]
		public void AdjustJointEncoding<TVertex>(IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public PackedEncoding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal class PackedMeshBuilder<TMaterial> : BaseBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class <CreatePackedMeshes>d__0 : IEnumerable<PackedMeshBuilder<TMaterial>>, IEnumerable, IEnumerator<PackedMeshBuilder<TMaterial>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private PackedMeshBuilder<TMaterial> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private IEnumerable<IMeshBuilder<TMaterial>> meshBuilders;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public IEnumerable<IMeshBuilder<TMaterial>> <>3__meshBuilders;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			private SceneBuilderSchema2Settings settings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public SceneBuilderSchema2Settings <>3__settings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private PackedEncoding <vertexEncodings>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private EncodingType <indexEncoding>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private IEnumerator<IMeshBuilder<TMaterial>> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			PackedMeshBuilder<TMaterial> IEnumerator<PackedMeshBuilder<TMaterial>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600052D")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public <CreatePackedMeshes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x64E6850", Offset = "0x64E5450", VA = "0x1864E6850", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x64E5DB0", Offset = "0x64E49B0", VA = "0x1864E5DB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x64E69A0", Offset = "0x64E55A0", VA = "0x1864E69A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x64E6520", Offset = "0x64E5120", VA = "0x1864E6520", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<PackedMeshBuilder<TMaterial>> IEnumerable<PackedMeshBuilder<TMaterial>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x64E66D0", Offset = "0x64E52D0", VA = "0x1864E66D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private readonly List<PackedPrimitiveBuilder<TMaterial>> _Primitives;

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x73D49E0", Offset = "0x73D35E0", VA = "0x1873D49E0")]
		[IteratorStateMachine(typeof(PackedMeshBuilder<>.<CreatePackedMeshes>d__0))]
		internal static IEnumerable<PackedMeshBuilder<TMaterial>> CreatePackedMeshes(IEnumerable<IMeshBuilder<TMaterial>> meshBuilders, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x73D5F10", Offset = "0x73D4B10", VA = "0x1873D5F10")]
		private static PackedMeshBuilder<TMaterial> Create(IMeshBuilder<TMaterial> srcMesh, PackedEncoding vertexEncodings, EncodingType indexEncoding, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x73D71D0", Offset = "0x73D5DD0", VA = "0x1873D71D0")]
		private PackedMeshBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x73D45E0", Offset = "0x73D31E0", VA = "0x1873D45E0")]
		public PackedPrimitiveBuilder<TMaterial> AddPrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x73D4AB0", Offset = "0x73D36B0", VA = "0x1873D4AB0")]
		public Mesh CreateSchema2Mesh(ModelRoot root, Converter<TMaterial, Material> materialEvaluator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x73D6F40", Offset = "0x73D5B40", VA = "0x1873D6F40")]
		public static void MergeBuffers(IEnumerable<PackedMeshBuilder<TMaterial>> meshes)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	internal sealed class PackedPrimitiveBuilder<TMaterial>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private readonly TMaterial _Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private readonly int _VerticesPerPrimitive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private Type _StridedVertexType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private MemoryAccessor[] _VertexAccessors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private MemoryAccessor _IndexAccessors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private readonly List<MemoryAccessor[]> _MorphTargets;

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x73DF250", Offset = "0x73DDE50", VA = "0x1873DF250")]
		public PackedPrimitiveBuilder(TMaterial material, int primitiveVertexCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x73DD0B0", Offset = "0x73DBCB0", VA = "0x1873DD0B0")]
		public void SetStridedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x73DC5F0", Offset = "0x73DB1F0", VA = "0x1873DC5F0")]
		public void SetStreamedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x73D97D0", Offset = "0x73D83D0", VA = "0x1873D97D0")]
		public void SetIndices(IPrimitiveReader<TMaterial> srcPrim, EncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x73DAD60", Offset = "0x73D9960", VA = "0x1873DAD60")]
		public void SetMorphTargets(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncodings, ISet<string> morphTargetAttributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x73D7700", Offset = "0x73D6300", VA = "0x1873D7700")]
		private void AddMorphTarget(params MemoryAccessor[] morphTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x73D80F0", Offset = "0x73D6CF0", VA = "0x1873D80F0")]
		internal void CopyToMesh(Mesh dstMesh, Converter<TMaterial, Material> materialEvaluator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x73D7AC0", Offset = "0x73D66C0", VA = "0x1873D7AC0")]
		private void CopyMorphTargets(MeshPrimitive dstPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x73D8DD0", Offset = "0x73D79D0", VA = "0x1873D8DD0")]
		public static void MergeBuffers(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x73DE0F0", Offset = "0x73DCCF0", VA = "0x1873DE0F0")]
		private static void _MergeSequentialVertices(IEnumerable<MemoryAccessor[]> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x73DECA0", Offset = "0x73DD8A0", VA = "0x1873DECA0")]
		private static void _MergeStridedVertices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x73DD670", Offset = "0x73DC270", VA = "0x1873DD670")]
		private static void _MergeIndices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	internal static class _PackedPrimitiveHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x41450C0", Offset = "0x4143CC0", VA = "0x1841450C0")]
		public static void _GatherMorphTargetAttributes<TMaterial>(this IPrimitiveReader<TMaterial> srcPrim, HashSet<string> attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x4145900", Offset = "0x4144500", VA = "0x184145900")]
		public static (MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor) _GetMorphTargetAccessors<TMaterial>(this IPrimitiveReader<TMaterial> srcPrim, int morphTargetIdx, PackedEncoding vertexEncodings, ISet<string> requiredAttributes)
		{
			return default((MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor, MemoryAccessor));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public abstract class PrimitiveBuilder<TMaterial, TvG, TvM, TvS> : IPrimitiveBuilder, IPrimitiveReader<TMaterial> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		private sealed class VertexListWrapper : ValueListSet<VertexBuilder<TvG, TvM, TvS>>, IReadOnlyList<IVertexBuilder>, IEnumerable<IVertexBuilder>, IEnumerable, IReadOnlyCollection<IVertexBuilder>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A5")]
			[CompilerGenerated]
			private sealed class <System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2 : IEnumerator<IVertexBuilder>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000247")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000248")]
				private IVertexBuilder <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000249")]
				public VertexListWrapper <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400024A")]
				private IEnumerator<VertexBuilder<TvG, TvM, TvS>> <>7__wrap1;

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				IVertexBuilder IEnumerator<IVertexBuilder>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000583")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x6000585")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600057F")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000580")]
				[Cpp2IlInjected.Address(RVA = "0x6D01020", Offset = "0x6CFFC20", VA = "0x186D01020", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000581")]
				[Cpp2IlInjected.Address(RVA = "0x6CFDB70", Offset = "0x6CFC770", VA = "0x186CFDB70", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0x6D01BD0", Offset = "0x6D007D0", VA = "0x186D01BD0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000584")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			IVertexBuilder IReadOnlyList<IVertexBuilder>.this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600057C")]
				[Cpp2IlInjected.Address(RVA = "0x857B1B0", Offset = "0x8579DB0", VA = "0x18857B1B0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x857ABE0", Offset = "0x85797E0", VA = "0x18857ABE0", Slot = "10")]
			[IteratorStateMachine(typeof(PrimitiveBuilder<, , , >.VertexListWrapper.<System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2))]
			IEnumerator<IVertexBuilder> IEnumerable<IVertexBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x857CB40", Offset = "0x857B740", VA = "0x18857CB40")]
			public VertexListWrapper()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private readonly MeshBuilder<TMaterial, TvG, TvM, TvS> _Mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private readonly TMaterial _Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private readonly VertexListWrapper _Vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private readonly List<PrimitiveMorphTargetBuilder<TvG, TvM>> _MorphTargets;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public MeshBuilder<TMaterial, TvG, TvM, TvS> Mesh
		{
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public TMaterial Material
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "12")]
			get
			{
				return (TMaterial)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public abstract int VerticesPerPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Type VertexType
		{
			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x7449B20", Offset = "0x7448720", VA = "0x187449B20", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Func<IVertexBuilder> VertexFactory
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x7447F00", Offset = "0x7446B00", VA = "0x187447F00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public IReadOnlyList<VertexBuilder<TvG, TvM, TvS>> Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		IReadOnlyList<IVertexBuilder> IPrimitiveReader<TMaterial>.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		IReadOnlyList<IPrimitiveMorphTargetReader> IPrimitiveReader<TMaterial>.MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public virtual IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x7447220", Offset = "0x7445E20", VA = "0x187447220", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public virtual IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x7446FE0", Offset = "0x7445BE0", VA = "0x187446FE0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public virtual IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x74479A0", Offset = "0x74465A0", VA = "0x1874479A0", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public virtual IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x74475B0", Offset = "0x74461B0", VA = "0x1874475B0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		internal IReadOnlyList<PrimitiveMorphTargetBuilder<TvG, TvM>> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7443980", Offset = "0x7442580", VA = "0x187443980")]
		internal PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x74463E0", Offset = "0x7444FE0", VA = "0x1874463E0")]
		protected PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		internal abstract PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material);

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x743FA80", Offset = "0x743E680", VA = "0x18743FA80")]
		internal PrimitiveMorphTargetBuilder<TvG, TvM> _UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x743EB70", Offset = "0x743D770", VA = "0x18743EB70")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x74334E0", Offset = "0x74320E0", VA = "0x1874334E0")]
		private static VertexBuilder<TvG, TvM, TvS> ConvertVertex(IVertexBuilder vertex)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x7439AA0", Offset = "0x74386A0", VA = "0x187439AA0")]
		protected int UseVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7434100", Offset = "0x7432D00", VA = "0x187434100", Slot = "6")]
		void IPrimitiveBuilder.SetVertexDelta(int morphTargetIndex, int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7433220", Offset = "0x7431E20", VA = "0x187433220")]
		public bool ContainsVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7426340", Offset = "0x7424F40", VA = "0x187426340", Slot = "7")]
		public int AddPoint(IVertexBuilder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x74221E0", Offset = "0x7420DE0", VA = "0x1874221E0", Slot = "8")]
		public (int, int) AddLine(IVertexBuilder a, IVertexBuilder b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7430C30", Offset = "0x742F830", VA = "0x187430C30", Slot = "9")]
		public (int, int, int) AddTriangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x742C350", Offset = "0x742AF50", VA = "0x18742C350", Slot = "10")]
		public (int, int, int, int) AddQuadrangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c, IVertexBuilder d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x74292A0", Offset = "0x7427EA0", VA = "0x1874292A0")]
		internal void AddPrimitive(PrimitiveBuilder<TMaterial, TvG, TvM, TvS> primitive, Converter<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x3A02060", Offset = "0x3A00C60", VA = "0x183A02060")]
		internal void AddPrimitive<TAnyMaterial>(IPrimitiveReader<TAnyMaterial> primitive, Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x7434D80", Offset = "0x7433980", VA = "0x187434D80")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract IReadOnlyList<int> GetIndices();

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x74249B0", Offset = "0x74235B0", VA = "0x1874249B0", Slot = "28")]
		public virtual int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x7421F40", Offset = "0x7420B40", VA = "0x187421F40", Slot = "29")]
		public virtual (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x742ED10", Offset = "0x742D910", VA = "0x18742ED10", Slot = "30")]
		public virtual (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x7429A80", Offset = "0x7428680", VA = "0x187429A80", Slot = "31")]
		public virtual (int, int, int, int) AddQuadrangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, VertexBuilder<TvG, TvM, TvS> d)
		{
			return default((int, int, int, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[DebuggerDisplay("Points[{Points.Count}] {_Material}")]
	internal sealed class PointsPrimitiveBuilder<TMaterial, TvG, TvM, TvS> : PrimitiveBuilder<TMaterial, TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		private readonly struct PointListWrapper<T> : IReadOnlyList<int>, IEnumerable<int>, IEnumerable, IReadOnlyCollection<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			private readonly IReadOnlyList<T> _Vertices;

			[Cpp2IlInjected.Token(Token = "0x170000B6")]
			public int this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x6000599")]
				[Cpp2IlInjected.Address(RVA = "0xD54570", Offset = "0xD53170", VA = "0x180D54570", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x74079C0", Offset = "0x74065C0", VA = "0x1874079C0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
			public PointListWrapper(IReadOnlyList<T> vertices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x73FE540", Offset = "0x73FD140", VA = "0x1873FE540", Slot = "6")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x7407020", Offset = "0x7405C20", VA = "0x187407020", Slot = "7")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public override int VerticesPerPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public override IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x740EA30", Offset = "0x740D630", VA = "0x18740EA30", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x740E8D0", Offset = "0x740D4D0", VA = "0x18740E8D0")]
		internal PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x740DCF0", Offset = "0x740C8F0", VA = "0x18740DCF0", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x740E750", Offset = "0x740D350", VA = "0x18740E750")]
		private PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PointsPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x740C210", Offset = "0x740AE10", VA = "0x18740C210", Slot = "28")]
		public override int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x740E140", Offset = "0x740CD40", VA = "0x18740E140", Slot = "27")]
		public override IReadOnlyList<int> GetIndices()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[DebuggerDisplay("Lines[{Lines.Count}] {_Material}")]
	internal sealed class LinesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> : PrimitiveBuilder<TMaterial, TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private readonly List<(int A, int B)> _Indices;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public override int VerticesPerPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public override IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x68E45E0", Offset = "0x68E31E0", VA = "0x1868E45E0")]
		internal LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x68DD8D0", Offset = "0x68DC4D0", VA = "0x1868DD8D0", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x68E5BC0", Offset = "0x68E47C0", VA = "0x1868E5BC0")]
		private LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, LinesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x68DB3B0", Offset = "0x68D9FB0", VA = "0x1868DB3B0", Slot = "29")]
		public override (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x68E0DB0", Offset = "0x68DF9B0", VA = "0x1868E0DB0", Slot = "27")]
		public override IReadOnlyList<int> GetIndices()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[DebuggerDisplay("Triangles[{Triangles.Count}] {_Material}")]
	internal sealed class TrianglesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> : PrimitiveBuilder<TMaterial, TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		private readonly struct TriangleList : IReadOnlyList<(int, int, int)>, IEnumerable<(int, int, int)>, IEnumerable, IReadOnlyCollection<(int, int, int)>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B0")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__7 : IEnumerator<(int, int, int)>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400025A")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400025B")]
				private (int A, int B, int C) <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400025C")]
				public TriangleList <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400025D")]
				private int <c>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400025E")]
				private int <i>5__3;

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				(int, int, int) IEnumerator<(int, int, int)>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60005B9")]
					[Cpp2IlInjected.Address(RVA = "0x19FE720", Offset = "0x19FD320", VA = "0x1819FE720", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default((int, int, int));
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60005BB")]
					[Cpp2IlInjected.Address(RVA = "0x6681050", Offset = "0x667FC50", VA = "0x186681050", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005B6")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B7")]
				[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B8")]
				[Cpp2IlInjected.Address(RVA = "0x667EF10", Offset = "0x667DB10", VA = "0x18667EF10", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class <System-Collections-IEnumerable-GetEnumerator>d__8 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400025F")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000260")]
				private object <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000261")]
				public TriangleList <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000262")]
				private int <c>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000263")]
				private int <i>5__3;

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				object IEnumerator<object>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60005BF")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60005C1")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x6E3D7F0", Offset = "0x6E3C3F0", VA = "0x186E3D7F0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			private readonly IReadOnlyList<(int A, int B, int C)> _Tris;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			private readonly IReadOnlyList<(int A, int B, int C, int D)> _Quads;

			[Cpp2IlInjected.Token(Token = "0x170000BD")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x60005B2")]
				[Cpp2IlInjected.Address(RVA = "0x7C03170", Offset = "0x7C01D70", VA = "0x187C03170", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BE")]
			public (int A, int B, int C) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x7C04E30", Offset = "0x7C03A30", VA = "0x187C04E30", Slot = "4")]
				get
				{
					return default((int, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			public TriangleList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C02F40", Offset = "0x7C01B40", VA = "0x187C02F40", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.TriangleList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x7A575A0", Offset = "0x7A561A0", VA = "0x187A575A0", Slot = "7")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.TriangleList.<System-Collections-IEnumerable-GetEnumerator>d__8))]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		private readonly struct SurfaceList : IReadOnlyList<(int, int, int, int?)>, IEnumerable<(int, int, int, int?)>, IEnumerable, IReadOnlyCollection<(int, int, int, int?)>
		{
			[Cpp2IlInjected.Token(Token = "0x20000B3")]
			[CompilerGenerated]
			private sealed class <GetEnumerator>d__7 : IEnumerator<(int, int, int, int?)>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000266")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000267")]
				private (int A, int B, int C, int? D) <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000268")]
				public SurfaceList <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000269")]
				private int <c>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026A")]
				private int <i>5__3;

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				private (int, int, int, int?) System.Collections.Generic.IEnumerator<System.ValueTuple<System.Int32,System.Int32,System.Int32,System.Int32?>>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60005CA")]
					[Cpp2IlInjected.Address(RVA = "0x23B2780", Offset = "0x23B1380", VA = "0x1823B2780", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default((int, int, int, int?));
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60005CC")]
					[Cpp2IlInjected.Address(RVA = "0x6681190", Offset = "0x667FD90", VA = "0x186681190", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005C7")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C8")]
				[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C9")]
				[Cpp2IlInjected.Address(RVA = "0x667D8D0", Offset = "0x667C4D0", VA = "0x18667D8D0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005CB")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B4")]
			[CompilerGenerated]
			private sealed class <System-Collections-IEnumerable-GetEnumerator>d__8 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026B")]
				private int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026C")]
				private object <>2__current;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				public SurfaceList <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026E")]
				private int <c>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400026F")]
				private int <i>5__3;

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				object IEnumerator<object>.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60005D0")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				object IEnumerator.Current
				{
					[Cpp2IlInjected.Token(Token = "0x60005D2")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005CD")]
				[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CE")]
				[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CF")]
				[Cpp2IlInjected.Address(RVA = "0x6E41930", Offset = "0x6E40530", VA = "0x186E41930", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005D1")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			private readonly IReadOnlyList<(int A, int B, int C)> _Tris;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			private readonly IReadOnlyList<(int A, int B, int C, int D)> _Quads;

			[Cpp2IlInjected.Token(Token = "0x170000C3")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x60005C3")]
				[Cpp2IlInjected.Address(RVA = "0x7A57A50", Offset = "0x7A56650", VA = "0x187A57A50", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public (int A, int B, int C, int? D) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005C4")]
				[Cpp2IlInjected.Address(RVA = "0x7A5BE30", Offset = "0x7A5AA30", VA = "0x187A5BE30", Slot = "4")]
				get
				{
					return default((int, int, int, int?));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			public SurfaceList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x7A574F0", Offset = "0x7A560F0", VA = "0x187A574F0", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.SurfaceList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int, int?)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x7A575A0", Offset = "0x7A561A0", VA = "0x187A575A0", Slot = "7")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.SurfaceList.<System-Collections-IEnumerable-GetEnumerator>d__8))]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private readonly List<(int A, int B, int C)> _TriIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private readonly List<(int A, int B, int C, int D)> _QuadIndices;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public override int VerticesPerPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public override IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x7C21960", Offset = "0x7C20560", VA = "0x187C21960", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public override IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C21900", Offset = "0x7C20500", VA = "0x187C21900", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C20E80", Offset = "0x7C1FA80", VA = "0x187C20E80")]
		internal TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C1EB90", Offset = "0x7C1D790", VA = "0x187C1EB90", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C21340", Offset = "0x7C1FF40", VA = "0x187C21340")]
		private TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TrianglesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DBF0", Offset = "0x7C1C7F0", VA = "0x187C1DBF0", Slot = "30")]
		public override (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D2B0", Offset = "0x7C1BEB0", VA = "0x187C1D2B0", Slot = "31")]
		public override (int, int, int, int) AddQuadrangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, VertexBuilder<TvG, TvM, TvS> d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C201F0", Offset = "0x7C1EDF0", VA = "0x187C201F0")]
		private (int, int, int) _AddTriangle([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b, [In] VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F720", Offset = "0x7C1E320", VA = "0x187C1F720", Slot = "27")]
		public override IReadOnlyList<int> GetIndices()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	internal sealed class MeshPrimitiveNormalsAndTangents<TMaterial> : SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive, SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private readonly IPrimitiveReader<TMaterial> _Source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private Vector3[] _Normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private Vector4[] _Tangents;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public int VertexCount
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x703BBB0", Offset = "0x703A7B0", VA = "0x18703BBB0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x703AA30", Offset = "0x7039630", VA = "0x18703AA30")]
		public static IReadOnlyDictionary<IPrimitiveReader<TMaterial>, MeshPrimitiveNormalsAndTangents<TMaterial>> GenerateNormalsTangents(IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		private MeshPrimitiveNormalsAndTangents(IPrimitiveReader<TMaterial> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x703B360", Offset = "0x7039F60", VA = "0x18703B360", Slot = "13")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x703B570", Offset = "0x703A170", VA = "0x18703B570", Slot = "9")]
		public Vector3 GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x703B3B0", Offset = "0x7039FB0", VA = "0x18703B3B0", Slot = "10")]
		public Vector3 GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x703B6E0", Offset = "0x703A2E0", VA = "0x18703B6E0")]
		public Vector4 GetVertexTangent(int idx)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x703B890", Offset = "0x703A490", VA = "0x18703B890", Slot = "11")]
		public Vector2 GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x703BA10", Offset = "0x703A610", VA = "0x18703BA10", Slot = "6")]
		public void SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x703BAE0", Offset = "0x703A6E0", VA = "0x18703BAE0", Slot = "12")]
		public void SetVertexTangent(int idx, Vector4 tangent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public interface IPrimitiveReader<TMaterial>
	{
		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		Type VertexType
		{
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		TMaterial Material
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		int VerticesPerPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		IReadOnlyList<IVertexBuilder> Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		IReadOnlyList<IPrimitiveMorphTargetReader> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		IReadOnlyList<int> GetIndices();
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public interface IPrimitiveBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		Type VertexType
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		Func<IVertexBuilder> VertexFactory
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetVertexDelta(int morphTargetIndex, int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta);

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int AddPoint(IVertexBuilder a);

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		(int, int) AddLine(IVertexBuilder a, IVertexBuilder b);

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		(int, int, int) AddTriangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c);

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		(int, int, int, int) AddQuadrangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c, IVertexBuilder d);
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public readonly struct PointPrimitive<TVertex, Tmaterial>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public readonly TVertex A;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public readonly Tmaterial Material;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public readonly struct LinePrimitive<TVertex, Tmaterial>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public readonly TVertex A;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public readonly TVertex B;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public readonly Tmaterial Material;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public readonly struct TrianglePrimitive<TVertex, Tmaterial>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public readonly TVertex A;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public readonly TVertex B;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public readonly TVertex C;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public readonly Tmaterial Material;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class VertexBufferColumns
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		private readonly struct _NormalTangentAgent : SharpGLTF.Runtime.VertexNormalsFactory.IMeshPrimitive, SharpGLTF.Runtime.VertexTangentsFactory.IMeshPrimitive
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			private readonly VertexBufferColumns _Vertices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			private readonly IEnumerable<(int A, int B, int C)> _Indices;

			[Cpp2IlInjected.Token(Token = "0x170000E3")]
			public int VertexCount
			{
				[Cpp2IlInjected.Token(Token = "0x6000626")]
				[Cpp2IlInjected.Address(RVA = "0xA65FCE0", Offset = "0xA65E8E0", VA = "0x18A65FCE0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			public _NormalTangentAgent(VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25CD0", VA = "0x180F270D0", Slot = "13")]
			public IEnumerable<(int, int, int)> GetTriangleIndices()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xA65F8F0", Offset = "0xA65E4F0", VA = "0x18A65F8F0", Slot = "9")]
			public Vector3 GetVertexPosition(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA65F800", Offset = "0xA65E400", VA = "0x18A65F800", Slot = "10")]
			public Vector3 GetVertexNormal(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA65F9E0", Offset = "0xA65E5E0", VA = "0x18A65F9E0", Slot = "11")]
			public Vector2 GetVertexTexCoord(int idx)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xA65FA40", Offset = "0xA65E640", VA = "0x18A65FA40", Slot = "6")]
			public void SetVertexNormal(int idx, Vector3 normal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xA65FB90", Offset = "0xA65E790", VA = "0x18A65FB90", Slot = "12")]
			public void SetVertexTangent(int idx, Vector4 tangent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private const string ERR_COLUMNLEN = "Column length mismatch.";

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private List<VertexBufferColumns> _MorphTargets;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public IList<Vector3> Positions
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public IList<Vector3> Normals
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0610", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public IList<Vector4> Tangents
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public IList<Vector4> Colors0
		{
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0380", VA = "0x180CF1780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public IList<Vector4> Colors1
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public IList<Vector2> TexCoords0
		{
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF3130", VA = "0x180CF4530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public IList<Vector2> TexCoords1
		{
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2F70", VA = "0x180CF4370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public IList<Vector2> TexCoords2
		{
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public IList<Vector2> TexCoords3
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xCEE170", Offset = "0xCECD70", VA = "0x180CEE170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public IList<Vector4> Joints0
		{
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECD50", VA = "0x180CEE150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0xCEE160", Offset = "0xCECD60", VA = "0x180CEE160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public IList<Vector4> Joints1
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xCEE130", Offset = "0xCECD30", VA = "0x180CEE130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xCEE140", Offset = "0xCECD40", VA = "0x180CEE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public IList<Vector4> Weights0
		{
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0xCEE740", Offset = "0xCED340", VA = "0x180CEE740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xCEE750", Offset = "0xCED350", VA = "0x180CEE750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public IList<Vector4> Weights1
		{
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED320", VA = "0x180CEE720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xCEE730", Offset = "0xCED330", VA = "0x180CEE730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public IReadOnlyList<VertexBufferColumns> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0xA638510", Offset = "0xA637110", VA = "0x18A638510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public VertexBufferColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xA638360", Offset = "0xA636F60", VA = "0x18A638360")]
		public VertexBufferColumns(VertexBufferColumns other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x40D7C20", Offset = "0x40D6820", VA = "0x1840D7C20")]
		private static T[] _IsolateColumn<T>(IList<T> column)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA635810", Offset = "0xA634410", VA = "0x18A635810")]
		public void IsolateColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA635AE0", Offset = "0xA6346E0", VA = "0x18A635AE0")]
		public VertexBufferColumns WithTransform(IGeometryTransform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xA635BE0", Offset = "0xA6347E0", VA = "0x18A635BE0")]
		private void _ApplyTransform(IGeometryTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xA637F80", Offset = "0xA636B80", VA = "0x18A637F80")]
		private void _FillMorphData(Vector2[] array, Converter<VertexBufferColumns, Vector2> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xA6381A0", Offset = "0xA636DA0", VA = "0x18A6381A0")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector3> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA638060", Offset = "0xA636C60", VA = "0x18A638060")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA638280", Offset = "0xA636E80", VA = "0x18A638280")]
		private void _FillMorphData(Vector4[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA635090", Offset = "0xA633C90", VA = "0x18A635090")]
		public VertexBufferColumns AddMorphTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA635520", Offset = "0xA634120", VA = "0x18A635520")]
		public (Type, Func<IVertexBuilder>) GetCompatibleVertexType()
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x40D5670", Offset = "0x40D4270", VA = "0x1840D5670")]
		private TvG GetVertexGeometry<TvG>(int index) where TvG : struct, IVertexGeometry
		{
			return (TvG)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x40D62A0", Offset = "0x40D4EA0", VA = "0x1840D62A0")]
		private TvM GetVertexMaterial<TvM>(int index) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x40D7000", Offset = "0x40D5C00", VA = "0x1840D7000")]
		private TvS GetVertexSkinning<TvS>(int index) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xA635650", Offset = "0xA634250", VA = "0x18A635650")]
		public IVertexBuilder GetVertex(Func<IVertexBuilder> factory, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x40D7830", Offset = "0x40D6430", VA = "0x1840D7830")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex<TvG, TvM>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x40D7A40", Offset = "0x40D6640", VA = "0x1840D7A40")]
		public VertexBuilder<TvG, TvM, TvS> GetVertex<TvG, TvM, TvS>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xA6351C0", Offset = "0xA633DC0", VA = "0x18A6351C0")]
		public static void CalculateSmoothNormals(IReadOnlyList<(VertexBufferColumns Vertices, IEnumerable<(int A, int B, int C)> Indices)> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xA635370", Offset = "0xA633F70", VA = "0x18A635370")]
		public static void CalculateTangents(IReadOnlyList<(VertexBufferColumns Vertices, IEnumerable<(int A, int B, int C)> Indices)> primitives)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public interface IVertexBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IVertexGeometry GetGeometry();

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IVertexMaterial GetMaterial();

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IVertexSkinning GetSkinning();

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetGeometry(IVertexGeometry geometry);

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetMaterial(IVertexMaterial material);

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SetSkinning(IVertexSkinning skinning);

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IMeshBuilder<TMaterial> CreateCompatibleMesh<TMaterial>([Optional] string name);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexBuilder<TvG, TvM, TvS> : IVertexBuilder, IEquatable<VertexBuilder<TvG, TvM, TvS>> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public TvG Geometry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public TvM Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public TvS Skinning;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x84539E0", Offset = "0x84525E0", VA = "0x1884539E0")]
			readonly get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x84553B0", Offset = "0x8453FB0", VA = "0x1884553B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x84505C0", Offset = "0x844F1C0", VA = "0x1884505C0")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x844FCC0", Offset = "0x844E8C0", VA = "0x18844FCC0")]
		private static string _GetDebuggerDisplayTextFrom(object o)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x844E660", Offset = "0x844D260", VA = "0x18844E660")]
		private readonly string _GetDebugWarnings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x8453360", Offset = "0x8451F60", VA = "0x188453360")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8453200", Offset = "0x8451E00", VA = "0x188453200")]
		public VertexBuilder([In] TvG g, [In] TvM m, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8452DA0", Offset = "0x84519A0", VA = "0x188452DA0")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x8453860", Offset = "0x8452460", VA = "0x188453860")]
		public VertexBuilder([In] TvG g, [In] TvM m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8453580", Offset = "0x8452180", VA = "0x188453580")]
		public VertexBuilder([In] TvG g, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x84520C0", Offset = "0x8450CC0", VA = "0x1884520C0")]
		public VertexBuilder([In] TvG g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x8452F20", Offset = "0x8451B20", VA = "0x188452F20")]
		public VertexBuilder([In] TvG g, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x8452860", Offset = "0x8451460", VA = "0x188452860")]
		public VertexBuilder(TvG g, SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x8454800", Offset = "0x8453400", VA = "0x188454800")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x8454060", Offset = "0x8452C60", VA = "0x188454060")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x8454C10", Offset = "0x8453810", VA = "0x188454C10")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x8454720", Offset = "0x8453320", VA = "0x188454720")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] TvG g)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x843FFF0", Offset = "0x843EBF0", VA = "0x18843FFF0")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8440190", Offset = "0x843ED90", VA = "0x188440190")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x843FE10", Offset = "0x843EA10", VA = "0x18843FE10")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x843DD10", Offset = "0x843C910", VA = "0x18843DD10")]
		public static VertexBuilder<TvG, TvM, TvS> CreateFrom(IVertexBuilder src)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x84418E0", Offset = "0x84404E0", VA = "0x1884418E0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x84416B0", Offset = "0x84402B0", VA = "0x1884416B0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x8441890", Offset = "0x8440490", VA = "0x188441890", Slot = "11")]
		public readonly bool Equals(VertexBuilder<TvG, TvM, TvS> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x8453AC0", Offset = "0x84526C0", VA = "0x188453AC0")]
		public static bool operator ==([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x8455360", Offset = "0x8453F60", VA = "0x188455360")]
		public static bool operator !=([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x843CA30", Offset = "0x843B630", VA = "0x18843CA30")]
		public static bool AreEqual([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8444880", Offset = "0x8443480", VA = "0x188444880")]
		public readonly void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3350", Offset = "0x3BF1F50", VA = "0x183BF3350")]
		public static MeshBuilder<TMaterial, TvG, TvM, TvS> CreateCompatibleMesh<TMaterial>([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x843D250", Offset = "0x843BE50", VA = "0x18843D250")]
		public static MeshBuilder<TvG, TvM, TvS> CreateCompatibleMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x4185DB0", Offset = "0x41849B0", VA = "0x184185DB0", Slot = "10")]
		IMeshBuilder<TMaterial> IVertexBuilder.CreateCompatibleMesh<TMaterial>(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x84419D0", Offset = "0x84405D0", VA = "0x1884419D0", Slot = "4")]
		readonly IVertexGeometry IVertexBuilder.GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x8441AB0", Offset = "0x84406B0", VA = "0x188441AB0", Slot = "5")]
		readonly IVertexMaterial IVertexBuilder.GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8441C30", Offset = "0x8440830", VA = "0x188441C30", Slot = "6")]
		readonly IVertexSkinning IVertexBuilder.GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x84422F0", Offset = "0x8440EF0", VA = "0x1884422F0", Slot = "7")]
		void IVertexBuilder.SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x8443050", Offset = "0x8441C50", VA = "0x188443050", Slot = "8")]
		void IVertexBuilder.SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8443F00", Offset = "0x8442B00", VA = "0x188443F00", Slot = "9")]
		void IVertexBuilder.SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x8444410", Offset = "0x8443010", VA = "0x188444410")]
		public readonly VertexBuilder<TvG, TvM, TvS> TransformedBy([In] Matrix4x4 transform)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x8445E40", Offset = "0x8444A40", VA = "0x188445E40")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8446870", Offset = "0x8445470", VA = "0x188446870")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8445460", Offset = "0x8444060", VA = "0x188445460")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8448380", Offset = "0x8446F80", VA = "0x188448380")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial(params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8449BE0", Offset = "0x84487E0", VA = "0x188449BE0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8448EB0", Offset = "0x8447AB0", VA = "0x188448EB0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, Vector4 color1, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x844ABC0", Offset = "0x84497C0", VA = "0x18844ABC0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning([In] SparseWeight8 sparse)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x844B7B0", Offset = "0x844A3B0", VA = "0x18844B7B0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning(params (int Index, float Weight)[] bindings)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x844A9C0", Offset = "0x84495C0", VA = "0x18844A9C0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning(IEnumerable<(int Index, float Weight)> bindings)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	internal struct VertexBuilder : IVertexBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public IVertexGeometry Geometry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public IVertexMaterial Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public IVertexSkinning Skinning;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA6444F0", Offset = "0xA6430F0", VA = "0x18A6444F0")]
		public VertexBuilder(IVertexGeometry g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x1F36790", Offset = "0x1F35390", VA = "0x181F36790")]
		public VertexBuilder(IVertexGeometry g, IVertexMaterial m, IVertexSkinning s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x149F030", Offset = "0x149DC30", VA = "0x18149F030", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6C90", VA = "0x180EC8090", Slot = "4")]
		public readonly IVertexGeometry GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25CD0", VA = "0x180F270D0", Slot = "5")]
		public readonly IVertexMaterial GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "6")]
		public readonly IVertexSkinning GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0", Slot = "7")]
		public void SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xF270E0", Offset = "0xF25CE0", VA = "0x180F270E0", Slot = "8")]
		public void SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0", Slot = "9")]
		public void SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA644440", Offset = "0xA643040", VA = "0x18A644440")]
		public readonly IVertexBuilder ConvertToType(Func<IVertexBuilder> factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E5E0", Offset = "0x3C0D1E0", VA = "0x183C0E5E0", Slot = "10")]
		IMeshBuilder<TMaterial> IVertexBuilder.CreateCompatibleMesh<TMaterial>(string name)
		{
			return null;
		}
	}
}
namespace SharpGLTF.Geometry.VertexTypes
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("The usage of this attribute has been removed because it's not AOT friendly. Implement IVertexReflection.GetEncodingAttributes() instead.", true)]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class VertexAttributeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0xCF76D0", Offset = "0xCF62D0", VA = "0x180CF76D0")]
			[CompilerGenerated]
			get
			{
				return default(EncodingType);
			}
			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0xCF8B80", Offset = "0xCF7780", VA = "0x180CF8B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0xE97170", Offset = "0xE95D70", VA = "0x180E97170")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0xEBB6F0", Offset = "0xEBA2F0", VA = "0x180EBB6F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA6443A0", Offset = "0xA642FA0", VA = "0x18A6443A0")]
		public VertexAttributeAttribute(string attributeName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA6443E0", Offset = "0xA642FE0", VA = "0x18A6443E0")]
		public VertexAttributeAttribute(string attributeName, EncodingType encoding, bool normalized)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public interface IVertexCustom : IVertexMaterial, IVertexReflection
	{
		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		IEnumerable<string> CustomAttributes
		{
			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Validate();

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TryGetCustomAttribute(string attributeName, [Out] object value);

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetCustomAttribute(string attributeName, object value);
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[DebuggerDisplay("Empty")]
	public readonly struct VertexEmpty : IVertexMaterial, IVertexReflection, IVertexSkinning, IEquatable<VertexEmpty>
	{
		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public VertexEmpty <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public VertexEmpty <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000F0")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006AD")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F1")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006AF")]
				[Cpp2IlInjected.Address(RVA = "0xA63FC30", Offset = "0xA63E830", VA = "0x18A63FC30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0xFFC910", Offset = "0xFFB510", VA = "0x180FFC910", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xA63FBF0", Offset = "0xA63E7F0", VA = "0x18A63FBF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xA63FB50", Offset = "0xA63E750", VA = "0x18A63FB50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0xA63FB50", Offset = "0xA63E750", VA = "0x18A63FB50", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public int MaxBindings
		{
			[Cpp2IlInjected.Token(Token = "0x6000698")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		Vector4 IVertexSkinning.JointsLow
		{
			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0xA64A600", Offset = "0xA649200", VA = "0x18A64A600", Slot = "18")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		Vector4 IVertexSkinning.JointsHigh
		{
			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0xA64A600", Offset = "0xA649200", VA = "0x18A64A600", Slot = "19")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		Vector4 IVertexSkinning.WeightsLow
		{
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0xA64A600", Offset = "0xA649200", VA = "0x18A64A600", Slot = "20")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		Vector4 IVertexSkinning.WeightsHigh
		{
			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0xA64A600", Offset = "0xA649200", VA = "0x18A64A600", Slot = "21")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA64A530", Offset = "0xA649130", VA = "0x18A64A530", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA64A1C0", Offset = "0xA648DC0", VA = "0x18A64A1C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "22")]
		public bool Equals(VertexEmpty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
		public static bool operator ==([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		public static bool operator !=([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xA64A350", Offset = "0xA648F50", VA = "0x18A64A350", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA64A3A0", Offset = "0xA648FA0", VA = "0x18A64A3A0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xA64A3F0", Offset = "0xA648FF0", VA = "0x18A64A3F0", Slot = "10")]
		VertexMaterialDelta IVertexMaterial.Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA64A2B0", Offset = "0xA648EB0", VA = "0x18A64A2B0", Slot = "6")]
		Vector4 IVertexMaterial.GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xA64A300", Offset = "0xA648F00", VA = "0x18A64A300", Slot = "7")]
		Vector2 IVertexMaterial.GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xA64A210", Offset = "0xA648E10", VA = "0x18A64A210", Slot = "17")]
		public SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xA64A270", Offset = "0xA648E70", VA = "0x18A64A270")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xA64A230", Offset = "0xA648E30", VA = "0x18A64A230", Slot = "16")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xA64A5A0", Offset = "0xA6491A0", VA = "0x18A64A5A0", Slot = "14")]
		(int, float) IVertexSkinning.GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xA64A5F0", Offset = "0xA6491F0", VA = "0x18A64A5F0", Slot = "15")]
		void IVertexSkinning.SetBindings([In] SparseWeight8 bindings)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public interface IVertexGeometry : IVertexReflection
	{
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 GetPosition();

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool TryGetNormal([Out] Vector3 normal);

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool TryGetTangent([Out] Vector4 tangent);

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetPosition([In] Vector3 position);

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetNormal([In] Vector3 normal);

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SetTangent([In] Vector4 tangent);

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ApplyTransform([In] Matrix4x4 xform);

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		VertexGeometryDelta Subtract(IVertexGeometry baseValue);

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Add([In] VertexGeometryDelta delta);
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexPosition : IVertexGeometry, IVertexReflection, IEquatable<VertexPosition>
	{
		[Cpp2IlInjected.Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public VertexPosition <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public VertexPosition <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000F2")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006D5")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006D7")]
				[Cpp2IlInjected.Address(RVA = "0xA640F90", Offset = "0xA63FB90", VA = "0x18A640F90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0xA640230", Offset = "0xA63EE30", VA = "0x18A640230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0xA640DB0", Offset = "0xA63F9B0", VA = "0x18A640DB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xA640AF0", Offset = "0xA63F6F0", VA = "0x18A640AF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xA640AF0", Offset = "0xA63F6F0", VA = "0x18A640AF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public Vector3 Position;

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xA650720", Offset = "0xA64F320", VA = "0x18A650720")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD58E0", Offset = "0x2DD44E0", VA = "0x182DD58E0")]
		public VertexPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6507A0", Offset = "0xA64F3A0", VA = "0x18A6507A0")]
		public VertexPosition(float px, float py, float pz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xA6507E0", Offset = "0xA64F3E0", VA = "0x18A6507E0")]
		public VertexPosition(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3900", Offset = "0x2DD2500", VA = "0x182DD3900")]
		public static implicit operator VertexPosition([In] Vector3 position)
		{
			return default(VertexPosition);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xA650570", Offset = "0xA64F170", VA = "0x18A650570", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xA64A920", Offset = "0xA649520", VA = "0x18A64A920", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6504A0", Offset = "0xA64F0A0", VA = "0x18A6504A0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xA650450", Offset = "0xA64F050", VA = "0x18A650450", Slot = "14")]
		public readonly bool Equals(VertexPosition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xA650450", Offset = "0xA64F050", VA = "0x18A650450")]
		public static bool operator ==([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA650920", Offset = "0xA64F520", VA = "0x18A650920")]
		public static bool operator !=([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xA650450", Offset = "0xA64F050", VA = "0x18A650450")]
		public static bool AreEqual([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DD58E0", Offset = "0x2DD44E0", VA = "0x182DD58E0", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		readonly void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xA6505E0", Offset = "0xA64F1E0", VA = "0x18A6505E0", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xA650270", Offset = "0xA64EE70", VA = "0x18A650270")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3900", Offset = "0x2DD2500", VA = "0x182DD3900", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xA650710", Offset = "0xA64F310", VA = "0x18A650710", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x1737470", Offset = "0x1736070", VA = "0x181737470", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xA6502E0", Offset = "0xA64EEE0", VA = "0x18A6502E0")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xA650560", Offset = "0xA64F160", VA = "0x18A650560", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xA650270", Offset = "0xA64EE70", VA = "0x18A650270", Slot = "12")]
		void IVertexGeometry.Add([In] VertexGeometryDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexPositionNormal : IVertexGeometry, IVertexReflection, IEquatable<VertexPositionNormal>
	{
		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			public VertexPositionNormal <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public VertexPositionNormal <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006F4")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60006F6")]
				[Cpp2IlInjected.Address(RVA = "0xA642490", Offset = "0xA641090", VA = "0x18A642490", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xA641300", Offset = "0xA63FF00", VA = "0x18A641300", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0xA642360", Offset = "0xA640F60", VA = "0x18A642360", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0xA641F80", Offset = "0xA640B80", VA = "0x18A641F80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xA641F80", Offset = "0xA640B80", VA = "0x18A641F80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public Vector3 Normal;

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xA64FF90", Offset = "0xA64EB90", VA = "0x18A64FF90")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xA6501F0", Offset = "0xA64EDF0", VA = "0x18A6501F0")]
		public VertexPositionNormal([In] Vector3 p, [In] Vector3 n)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA650160", Offset = "0xA64ED60", VA = "0x18A650160")]
		public VertexPositionNormal(float px, float py, float pz, float nx, float ny, float nz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA650010", Offset = "0xA64EC10", VA = "0x18A650010")]
		public VertexPositionNormal(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA650220", Offset = "0xA64EE20", VA = "0x18A650220")]
		public static implicit operator VertexPositionNormal([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexPositionNormal);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA64FE50", Offset = "0xA64EA50", VA = "0x18A64FE50", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA64A920", Offset = "0xA649520", VA = "0x18A64A920", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA64FD00", Offset = "0xA64E900", VA = "0x18A64FD00", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA64FE10", Offset = "0xA64EA10", VA = "0x18A64FE10", Slot = "14")]
		public readonly bool Equals(VertexPositionNormal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA650210", Offset = "0xA64EE10", VA = "0x18A650210")]
		public static bool operator ==([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA650250", Offset = "0xA64EE50", VA = "0x18A650250")]
		public static bool operator !=([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA64FC80", Offset = "0xA64E880", VA = "0x18A64FC80")]
		public static bool AreEqual([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2DD58E0", Offset = "0x2DD44E0", VA = "0x182DD58E0", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xA64A970", Offset = "0xA649570", VA = "0x18A64A970", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA64FED0", Offset = "0xA64EAD0", VA = "0x18A64FED0", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA64F960", Offset = "0xA64E560", VA = "0x18A64F960")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3900", Offset = "0x2DD2500", VA = "0x182DD3900", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA64AB10", Offset = "0xA649710", VA = "0x18A64AB10", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x1737470", Offset = "0x1736070", VA = "0x181737470", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xA64FA30", Offset = "0xA64E630", VA = "0x18A64FA30")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xA64FE40", Offset = "0xA64EA40", VA = "0x18A64FE40", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA64FE30", Offset = "0xA64EA30", VA = "0x18A64FE30", Slot = "12")]
		void IVertexGeometry.Add([In] VertexGeometryDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexPositionNormalTangent : IVertexGeometry, IVertexReflection, IEquatable<VertexPositionNormalTangent>
	{
		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public VertexPositionNormalTangent <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public VertexPositionNormalTangent <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000F6")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000712")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000714")]
				[Cpp2IlInjected.Address(RVA = "0xA642530", Offset = "0xA641130", VA = "0x18A642530", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0xA6419E0", Offset = "0xA6405E0", VA = "0x18A6419E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA642260", Offset = "0xA640E60", VA = "0x18A642260", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xA641E30", Offset = "0xA640A30", VA = "0x18A641E30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA641E30", Offset = "0xA640A30", VA = "0x18A641E30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public Vector3 Normal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Vector4 Tangent;

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xA64F6D0", Offset = "0xA64E2D0", VA = "0x18A64F6D0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xA64F760", Offset = "0xA64E360", VA = "0x18A64F760")]
		public VertexPositionNormalTangent([In] Vector3 p, [In] Vector3 n, [In] Vector4 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xA64F790", Offset = "0xA64E390", VA = "0x18A64F790")]
		public VertexPositionNormalTangent(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xA64F910", Offset = "0xA64E510", VA = "0x18A64F910")]
		public static implicit operator VertexPositionNormalTangent([In] (Vector3 Pos, Vector3 Nrm, Vector4 Tgt) tuple)
		{
			return default(VertexPositionNormalTangent);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xA64F580", Offset = "0xA64E180", VA = "0x18A64F580", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA64A920", Offset = "0xA649520", VA = "0x18A64A920", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xA64F3F0", Offset = "0xA64DFF0", VA = "0x18A64F3F0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xA64F540", Offset = "0xA64E140", VA = "0x18A64F540", Slot = "14")]
		public readonly bool Equals(VertexPositionNormalTangent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA64F900", Offset = "0xA64E500", VA = "0x18A64F900")]
		public static bool operator ==([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xA64F940", Offset = "0xA64E540", VA = "0x18A64F940")]
		public static bool operator !=([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xA64F350", Offset = "0xA64DF50", VA = "0x18A64F350")]
		public static bool AreEqual([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2DD58E0", Offset = "0x2DD44E0", VA = "0x182DD58E0", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xA64A970", Offset = "0xA649570", VA = "0x18A64A970", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xF6C4A0", Offset = "0xF6B0A0", VA = "0x180F6C4A0", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xA64F600", Offset = "0xA64E200", VA = "0x18A64F600", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xA64EE60", Offset = "0xA64DA60", VA = "0x18A64EE60")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3900", Offset = "0x2DD2500", VA = "0x182DD3900", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xA64AB10", Offset = "0xA649710", VA = "0x18A64AB10", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA64F6C0", Offset = "0xA64E2C0", VA = "0x18A64F6C0", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xA64EFD0", Offset = "0xA64DBD0", VA = "0x18A64EFD0")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA64F570", Offset = "0xA64E170", VA = "0x18A64F570", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA64F560", Offset = "0xA64E160", VA = "0x18A64F560", Slot = "12")]
		void IVertexGeometry.Add([In] VertexGeometryDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexGeometryDelta : IVertexGeometry, IVertexReflection, IEquatable<VertexGeometryDelta>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public VertexGeometryDelta <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public VertexGeometryDelta <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000F8")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000736")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000738")]
				[Cpp2IlInjected.Address(RVA = "0xA63F5A0", Offset = "0xA63E1A0", VA = "0x18A63F5A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xA63F2A0", Offset = "0xA63DEA0", VA = "0x18A63F2A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0xA63F560", Offset = "0xA63E160", VA = "0x18A63F560", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0xA63F4B0", Offset = "0xA63E0B0", VA = "0x18A63F4B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0xA63F4B0", Offset = "0xA63E0B0", VA = "0x18A63F4B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public Vector3 PositionDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public Vector3 NormalDelta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public Vector3 TangentDelta;

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xA64AB80", Offset = "0xA649780", VA = "0x18A64AB80")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA64B3F0", Offset = "0xA649FF0", VA = "0x18A64B3F0")]
		public static implicit operator VertexGeometryDelta([In] Vector3 position)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xA64B390", Offset = "0xA649F90", VA = "0x18A64B390")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA64B350", Offset = "0xA649F50", VA = "0x18A64B350")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm, Vector3 tgt) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA64AF40", Offset = "0xA649B40", VA = "0x18A64AF40")]
		public VertexGeometryDelta(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xA64AD70", Offset = "0xA649970", VA = "0x18A64AD70")]
		public VertexGeometryDelta([In] Vector3 p, [In] Vector3 n, [In] Vector3 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA64B290", Offset = "0xA649E90", VA = "0x18A64B290")]
		internal VertexGeometryDelta([In] VertexPosition rootVal, [In] VertexPosition morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA64AC60", Offset = "0xA649860", VA = "0x18A64AC60")]
		internal VertexGeometryDelta([In] VertexPositionNormal rootVal, [In] VertexPositionNormal morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xA64ADB0", Offset = "0xA6499B0", VA = "0x18A64ADB0")]
		internal VertexGeometryDelta([In] VertexPositionNormalTangent rootVal, [In] VertexPositionNormalTangent morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA64B160", Offset = "0xA649D60", VA = "0x18A64B160")]
		internal VertexGeometryDelta([In] VertexGeometryDelta rootVal, [In] VertexGeometryDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA64A9D0", Offset = "0xA6495D0", VA = "0x18A64A9D0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xA64A920", Offset = "0xA649520", VA = "0x18A64A920", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA64A870", Offset = "0xA649470", VA = "0x18A64A870", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA64A850", Offset = "0xA649450", VA = "0x18A64A850", Slot = "14")]
		public readonly bool Equals(VertexGeometryDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA64B340", Offset = "0xA649F40", VA = "0x18A64B340")]
		public static bool operator ==([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA64B470", Offset = "0xA64A070", VA = "0x18A64B470")]
		public static bool operator !=([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xA64A790", Offset = "0xA649390", VA = "0x18A64A790")]
		public static bool AreEqual([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x2DD58E0", Offset = "0x2DD44E0", VA = "0x182DD58E0", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA64A970", Offset = "0xA649570", VA = "0x18A64A970", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA64A980", Offset = "0xA649580", VA = "0x18A64A980", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3900", Offset = "0x2DD2500", VA = "0x182DD3900", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xA64AB10", Offset = "0xA649710", VA = "0x18A64AB10", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA64AB30", Offset = "0xA649730", VA = "0x18A64AB30", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xA64A750", Offset = "0xA649350", VA = "0x18A64A750")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xA64AA50", Offset = "0xA649650", VA = "0x18A64AA50", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA64A630", Offset = "0xA649230", VA = "0x18A64A630")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA64A960", Offset = "0xA649560", VA = "0x18A64A960", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA64A950", Offset = "0xA649550", VA = "0x18A64A950", Slot = "12")]
		void IVertexGeometry.Add([In] VertexGeometryDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public interface IVertexMaterial : IVertexReflection
	{
		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Vector4 GetColor(int index);

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Vector2 GetTexCoord(int index);

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetColor(int setIndex, Vector4 color);

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SetTexCoord(int setIndex, Vector2 coord);

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(Slot = "6")]
		VertexMaterialDelta Subtract(IVertexMaterial baseValue);

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Add([In] VertexMaterialDelta delta);
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor1 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor1>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			public VertexColor1 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002D0")]
			public VertexColor1 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000FE")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600075A")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600075C")]
				[Cpp2IlInjected.Address(RVA = "0xA640010", Offset = "0xA63EC10", VA = "0x18A640010", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD60", Offset = "0xA63E960", VA = "0x18A63FD60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA63FFD0", Offset = "0xA63EBD0", VA = "0x18A63FFD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE50", Offset = "0xA63EA50", VA = "0x18A63FE50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE50", Offset = "0xA63EA50", VA = "0x18A63FE50", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Vector4 Color;

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x12B8AB0", Offset = "0x12B76B0", VA = "0x1812B8AB0")]
		public static implicit operator VertexColor1(Vector4 color)
		{
			return default(VertexColor1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xA646CC0", Offset = "0xA6458C0", VA = "0x18A646CC0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x152A0E0", Offset = "0x1528CE0", VA = "0x18152A0E0")]
		public VertexColor1(Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xA646D40", Offset = "0xA645940", VA = "0x18A646D40")]
		public VertexColor1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xA646BA0", Offset = "0xA6457A0", VA = "0x18A646BA0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xA646B20", Offset = "0xA645720", VA = "0x18A646B20", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA6469D0", Offset = "0xA6455D0", VA = "0x18A6469D0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA646A80", Offset = "0xA645680", VA = "0x18A646A80", Slot = "13")]
		public readonly bool Equals(VertexColor1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA646A80", Offset = "0xA645680", VA = "0x18A646A80")]
		public static bool operator ==([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA646EA0", Offset = "0xA645AA0", VA = "0x18A646EA0")]
		public static bool operator !=([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA6469A0", Offset = "0xA6455A0", VA = "0x18A6469A0")]
		public static bool AreEqual([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA646C10", Offset = "0xA645810", VA = "0x18A646C10", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA646920", Offset = "0xA645520", VA = "0x18A646920")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA644900", Offset = "0xA643500", VA = "0x18A644900", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA646AB0", Offset = "0xA6456B0", VA = "0x18A646AB0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA646B40", Offset = "0xA645740", VA = "0x18A646B40", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA646B90", Offset = "0xA645790", VA = "0x18A646B90", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor2 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor2>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			public VertexColor2 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public VertexColor2 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000102")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000776")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000103")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000778")]
				[Cpp2IlInjected.Address(RVA = "0xA640EF0", Offset = "0xA63FAF0", VA = "0x18A640EF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA640820", Offset = "0xA63F420", VA = "0x18A640820", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA640E70", Offset = "0xA63FA70", VA = "0x18A640E70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA6409B0", Offset = "0xA63F5B0", VA = "0x18A6409B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0xA6409B0", Offset = "0xA63F5B0", VA = "0x18A6409B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public Vector4 Color0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public Vector4 Color1;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA64A180", Offset = "0xA648D80", VA = "0x18A64A180")]
		public static implicit operator VertexColor2((Vector4 Color0, Vector4 Color1) tuple)
		{
			return default(VertexColor2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA649EE0", Offset = "0xA648AE0", VA = "0x18A649EE0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x62BF320", Offset = "0x62BDF20", VA = "0x1862BF320")]
		public VertexColor2(Vector4 color0, Vector4 color1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA649F60", Offset = "0xA648B60", VA = "0x18A649F60")]
		public VertexColor2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA649DB0", Offset = "0xA6489B0", VA = "0x18A649DB0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA649D00", Offset = "0xA648900", VA = "0x18A649D00", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA649B60", Offset = "0xA648760", VA = "0x18A649B60", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xA649C60", Offset = "0xA648860", VA = "0x18A649C60", Slot = "13")]
		public readonly bool Equals(VertexColor2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA64A170", Offset = "0xA648D70", VA = "0x18A64A170")]
		public static bool operator ==([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA64A1A0", Offset = "0xA648DA0", VA = "0x18A64A1A0")]
		public static bool operator !=([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA649AE0", Offset = "0xA6486E0", VA = "0x18A649AE0")]
		public static bool AreEqual([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xA649E20", Offset = "0xA648A20", VA = "0x18A649E20", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xA6499F0", Offset = "0xA6485F0", VA = "0x18A6499F0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA6473C0", Offset = "0xA645FC0", VA = "0x18A6473C0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xA649C80", Offset = "0xA648880", VA = "0x18A649C80", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xA649D50", Offset = "0xA648950", VA = "0x18A649D50", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xA649DA0", Offset = "0xA6489A0", VA = "0x18A649DA0", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexTexture1 : IVertexMaterial, IVertexReflection, IEquatable<VertexTexture1>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			public VertexTexture1 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			public VertexTexture1 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000106")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000792")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000107")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000794")]
				[Cpp2IlInjected.Address(RVA = "0xA640060", Offset = "0xA63EC60", VA = "0x18A640060", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC80", Offset = "0xA63E880", VA = "0x18A63FC80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xA63FF90", Offset = "0xA63EB90", VA = "0x18A63FF90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xA63FEF0", Offset = "0xA63EAF0", VA = "0x18A63FEF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA63FEF0", Offset = "0xA63EAF0", VA = "0x18A63FEF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public Vector2 TexCoord;

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0")]
		public static implicit operator VertexTexture1(Vector2 uv)
		{
			return default(VertexTexture1);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xA650CF0", Offset = "0xA64F8F0", VA = "0x18A650CF0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x13FFF50", Offset = "0x13FEB50", VA = "0x1813FFF50")]
		public VertexTexture1(Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA650D70", Offset = "0xA64F970", VA = "0x18A650D70")]
		public VertexTexture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA650BB0", Offset = "0xA64F7B0", VA = "0x18A650BB0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA650B10", Offset = "0xA64F710", VA = "0x18A650B10", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA6509F0", Offset = "0xA64F5F0", VA = "0x18A6509F0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xA650AA0", Offset = "0xA64F6A0", VA = "0x18A650AA0", Slot = "13")]
		public readonly bool Equals(VertexTexture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xA650E80", Offset = "0xA64FA80", VA = "0x18A650E80")]
		public static bool operator ==([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA650EB0", Offset = "0xA64FAB0", VA = "0x18A650EB0")]
		public static bool operator !=([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xA6509C0", Offset = "0xA64F5C0", VA = "0x18A6509C0")]
		public static bool AreEqual([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xA650C30", Offset = "0xA64F830", VA = "0x18A650C30", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xA650970", Offset = "0xA64F570", VA = "0x18A650970")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA650BA0", Offset = "0xA64F7A0", VA = "0x18A650BA0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA650AC0", Offset = "0xA64F6C0", VA = "0x18A650AC0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xA650B30", Offset = "0xA64F730", VA = "0x18A650B30", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xA650970", Offset = "0xA64F570", VA = "0x18A650970", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexTexture2 : IVertexMaterial, IVertexReflection, IEquatable<VertexTexture2>
	{
		[Cpp2IlInjected.Token(Token = "0x20000D9")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			public VertexTexture2 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public VertexTexture2 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700010A")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007AE")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007B0")]
				[Cpp2IlInjected.Address(RVA = "0xA640FE0", Offset = "0xA63FBE0", VA = "0x18A640FE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0xA6406A0", Offset = "0xA63F2A0", VA = "0x18A6406A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0xA640DF0", Offset = "0xA63F9F0", VA = "0x18A640DF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xA640C30", Offset = "0xA63F830", VA = "0x18A640C30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0xA640C30", Offset = "0xA63F830", VA = "0x18A640C30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public Vector2 TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public Vector2 TexCoord1;

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x12B8AB0", Offset = "0x12B76B0", VA = "0x1812B8AB0")]
		public static implicit operator VertexTexture2((Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexTexture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xA651390", Offset = "0xA64FF90", VA = "0x18A651390")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x3115A10", Offset = "0x3114610", VA = "0x183115A10")]
		public VertexTexture2(Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA651410", Offset = "0xA650010", VA = "0x18A651410")]
		public VertexTexture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA651270", Offset = "0xA64FE70", VA = "0x18A651270", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA651170", Offset = "0xA64FD70", VA = "0x18A651170", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA651010", Offset = "0xA64FC10", VA = "0x18A651010", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA650FF0", Offset = "0xA64FBF0", VA = "0x18A650FF0", Slot = "13")]
		public readonly bool Equals(VertexTexture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA651580", Offset = "0xA650180", VA = "0x18A651580")]
		public static bool operator ==([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA651590", Offset = "0xA650190", VA = "0x18A651590")]
		public static bool operator !=([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA650F70", Offset = "0xA64FB70", VA = "0x18A650F70")]
		public static bool AreEqual([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6512E0", Offset = "0xA64FEE0", VA = "0x18A6512E0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xA650EE0", Offset = "0xA64FAE0", VA = "0x18A650EE0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xA651250", Offset = "0xA64FE50", VA = "0x18A651250", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA651120", Offset = "0xA64FD20", VA = "0x18A651120", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA6511C0", Offset = "0xA64FDC0", VA = "0x18A6511C0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA651240", Offset = "0xA64FE40", VA = "0x18A651240", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor1Texture1 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor1Texture1>
	{
		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public VertexColor1Texture1 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public VertexColor1Texture1 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700010E")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007CA")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007CC")]
				[Cpp2IlInjected.Address(RVA = "0xA640F40", Offset = "0xA63FB40", VA = "0x18A640F40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0xA6400B0", Offset = "0xA63ECB0", VA = "0x18A6400B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0xA640D70", Offset = "0xA63F970", VA = "0x18A640D70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0xA640CD0", Offset = "0xA63F8D0", VA = "0x18A640CD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xA640CD0", Offset = "0xA63F8D0", VA = "0x18A640CD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public Vector4 Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public Vector2 TexCoord;

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x3051770", Offset = "0x3050370", VA = "0x183051770")]
		public static implicit operator VertexColor1Texture1((Vector4 Color, Vector2 Tex) tuple)
		{
			return default(VertexColor1Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA644A60", Offset = "0xA643660", VA = "0x18A644A60")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x6852CD0", Offset = "0x68518D0", VA = "0x186852CD0")]
		public VertexColor1Texture1(Vector4 color, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA644AE0", Offset = "0xA6436E0", VA = "0x18A644AE0")]
		public VertexColor1Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA644920", Offset = "0xA643520", VA = "0x18A644920", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA644820", Offset = "0xA643420", VA = "0x18A644820", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA644690", Offset = "0xA643290", VA = "0x18A644690", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA644790", Offset = "0xA643390", VA = "0x18A644790", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA644C90", Offset = "0xA643890", VA = "0x18A644C90")]
		public static bool operator ==([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA644CA0", Offset = "0xA6438A0", VA = "0x18A644CA0")]
		public static bool operator !=([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA644600", Offset = "0xA643200", VA = "0x18A644600")]
		public static bool AreEqual([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA6449A0", Offset = "0xA6435A0", VA = "0x18A6449A0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA644530", Offset = "0xA643130", VA = "0x18A644530")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA644900", Offset = "0xA643500", VA = "0x18A644900", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA644910", Offset = "0xA643510", VA = "0x18A644910", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6447B0", Offset = "0xA6433B0", VA = "0x18A6447B0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA644870", Offset = "0xA643470", VA = "0x18A644870", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xA6448F0", Offset = "0xA6434F0", VA = "0x18A6448F0", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor1Texture2 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor1Texture2>
	{
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public VertexColor1Texture2 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			public VertexColor1Texture2 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000112")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007E6")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000113")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60007E8")]
				[Cpp2IlInjected.Address(RVA = "0xA6424E0", Offset = "0xA6410E0", VA = "0x18A6424E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA6410D0", Offset = "0xA63FCD0", VA = "0x18A6410D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA6422A0", Offset = "0xA640EA0", VA = "0x18A6422A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0xA642020", Offset = "0xA640C20", VA = "0x18A642020", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0xA642020", Offset = "0xA640C20", VA = "0x18A642020", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public Vector4 Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public Vector2 TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public Vector2 TexCoord1;

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D830", Offset = "0x2D9C430", VA = "0x182D9D830")]
		public static implicit operator VertexColor1Texture2((Vector4 Color, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor1Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0xA645220", Offset = "0xA643E20", VA = "0x18A645220")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x825D810", Offset = "0x825C410", VA = "0x18825D810")]
		public VertexColor1Texture2(Vector4 color, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xA6452A0", Offset = "0xA643EA0", VA = "0x18A6452A0")]
		public VertexColor1Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA6450F0", Offset = "0xA643CF0", VA = "0x18A6450F0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xA644FB0", Offset = "0xA643BB0", VA = "0x18A644FB0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0xA644EA0", Offset = "0xA643AA0", VA = "0x18A644EA0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0xA644E80", Offset = "0xA643A80", VA = "0x18A644E80", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0xA6454B0", Offset = "0xA6440B0", VA = "0x18A6454B0")]
		public static bool operator ==([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6454C0", Offset = "0xA6440C0", VA = "0x18A6454C0")]
		public static bool operator !=([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA644DC0", Offset = "0xA6439C0", VA = "0x18A644DC0")]
		public static bool AreEqual([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA645160", Offset = "0xA643D60", VA = "0x18A645160", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA644CC0", Offset = "0xA6438C0", VA = "0x18A644CC0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA644900", Offset = "0xA643500", VA = "0x18A644900", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA6450D0", Offset = "0xA643CD0", VA = "0x18A6450D0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xA644F40", Offset = "0xA643B40", VA = "0x18A644F40", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xA645030", Offset = "0xA643C30", VA = "0x18A645030", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6450C0", Offset = "0xA643CC0", VA = "0x18A6450C0", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor2Texture1 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor2Texture1>
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public VertexColor2Texture1 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public VertexColor2Texture1 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000116")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000802")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000117")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000804")]
				[Cpp2IlInjected.Address(RVA = "0xA6423F0", Offset = "0xA640FF0", VA = "0x18A6423F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA641BF0", Offset = "0xA6407F0", VA = "0x18A641BF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA642220", Offset = "0xA640E20", VA = "0x18A642220", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0xA6420C0", Offset = "0xA640CC0", VA = "0x18A6420C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0xA6420C0", Offset = "0xA640CC0", VA = "0x18A6420C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public Vector4 Color0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public Vector4 Color1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public Vector2 TexCoord;

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xA647850", Offset = "0xA646450", VA = "0x18A647850")]
		public static implicit operator VertexColor2Texture1((Vector4 Color0, Vector4 Color1, Vector2 Tex) tuple)
		{
			return default(VertexColor2Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA647540", Offset = "0xA646140", VA = "0x18A647540")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x825DAE0", Offset = "0x825C6E0", VA = "0x18825DAE0")]
		public VertexColor2Texture1(Vector4 color0, Vector4 color1, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA6475D0", Offset = "0xA6461D0", VA = "0x18A6475D0")]
		public VertexColor2Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xA6473F0", Offset = "0xA645FF0", VA = "0x18A6473F0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA6472B0", Offset = "0xA645EB0", VA = "0x18A6472B0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6470D0", Offset = "0xA645CD0", VA = "0x18A6470D0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6470B0", Offset = "0xA645CB0", VA = "0x18A6470B0", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xA647840", Offset = "0xA646440", VA = "0x18A647840")]
		public static bool operator ==([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xA647870", Offset = "0xA646470", VA = "0x18A647870")]
		public static bool operator !=([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA647000", Offset = "0xA645C00", VA = "0x18A647000")]
		public static bool AreEqual([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA647470", Offset = "0xA646070", VA = "0x18A647470", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA646ED0", Offset = "0xA645AD0", VA = "0x18A646ED0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA6473C0", Offset = "0xA645FC0", VA = "0x18A6473C0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6473E0", Offset = "0xA645FE0", VA = "0x18A6473E0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA647230", Offset = "0xA645E30", VA = "0x18A647230", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xA647330", Offset = "0xA645F30", VA = "0x18A647330", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6473B0", Offset = "0xA645FB0", VA = "0x18A6473B0", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor2Texture2 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor2Texture2>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public VertexColor2Texture2 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public VertexColor2Texture2 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700011A")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600081E")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700011B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000820")]
				[Cpp2IlInjected.Address(RVA = "0xA6435D0", Offset = "0xA6421D0", VA = "0x18A6435D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA6428E0", Offset = "0xA6414E0", VA = "0x18A6428E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA6434D0", Offset = "0xA6420D0", VA = "0x18A6434D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA643420", Offset = "0xA642020", VA = "0x18A643420", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA643420", Offset = "0xA642020", VA = "0x18A643420", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public Vector4 Color0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public Vector4 Color1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public Vector2 TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public Vector2 TexCoord1;

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA648250", Offset = "0xA646E50", VA = "0x18A648250")]
		public static implicit operator VertexColor2Texture2((Vector4 Color0, Vector4 Color1, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor2Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xA647EF0", Offset = "0xA646AF0", VA = "0x18A647EF0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x8348390", Offset = "0x8346F90", VA = "0x188348390")]
		public VertexColor2Texture2(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xA647F80", Offset = "0xA646B80", VA = "0x18A647F80")]
		public VertexColor2Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xA647DA0", Offset = "0xA6469A0", VA = "0x18A647DA0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xA647C40", Offset = "0xA646840", VA = "0x18A647C40", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0xA647B10", Offset = "0xA646710", VA = "0x18A647B10", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA647AF0", Offset = "0xA6466F0", VA = "0x18A647AF0", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA648240", Offset = "0xA646E40", VA = "0x18A648240")]
		public static bool operator ==([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA648270", Offset = "0xA646E70", VA = "0x18A648270")]
		public static bool operator !=([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0xA647A00", Offset = "0xA646600", VA = "0x18A647A00")]
		public static bool AreEqual([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0xA647E20", Offset = "0xA646A20", VA = "0x18A647E20", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xA647890", Offset = "0xA646490", VA = "0x18A647890")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0xA6473C0", Offset = "0xA645FC0", VA = "0x18A6473C0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0xA647D80", Offset = "0xA646980", VA = "0x18A647D80", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xA647BC0", Offset = "0xA6467C0", VA = "0x18A647BC0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xA647CE0", Offset = "0xA6468E0", VA = "0x18A647CE0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA647D70", Offset = "0xA646970", VA = "0x18A647D70", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexMaterialDelta : IVertexMaterial, IVertexReflection, IEquatable<VertexMaterialDelta>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public VertexMaterialDelta <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			public VertexMaterialDelta <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700011F")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600084E")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000120")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000850")]
				[Cpp2IlInjected.Address(RVA = "0xA63FB00", Offset = "0xA63E700", VA = "0x18A63FB00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0xA63F5F0", Offset = "0xA63E1F0", VA = "0x18A63F5F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0xA63FAC0", Offset = "0xA63E6C0", VA = "0x18A63FAC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA63F9F0", Offset = "0xA63E5F0", VA = "0x18A63F9F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA63F9F0", Offset = "0xA63E5F0", VA = "0x18A63F9F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public Vector4 Color0Delta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public Vector4 Color1Delta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public Vector2 TexCoord0Delta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public Vector2 TexCoord1Delta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public Vector2 TexCoord2Delta;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public Vector2 TexCoord3Delta;

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		public static VertexMaterialDelta Zero
		{
			[Cpp2IlInjected.Token(Token = "0x600082A")]
			[Cpp2IlInjected.Address(RVA = "0xA64EC60", Offset = "0xA64D860", VA = "0x18A64EC60")]
			get
			{
				return default(VertexMaterialDelta);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD60", Offset = "0xD0B960", VA = "0x180D0CD60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0xD0CD70", Offset = "0xD0B970", VA = "0x180D0CD70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xA64CD20", Offset = "0xA64B920", VA = "0x18A64CD20")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xA64ED60", Offset = "0xA64D960", VA = "0x18A64ED60")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0xA64EE00", Offset = "0xA64DA00", VA = "0x18A64EE00")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta, Vector2 TextCoord2Delta, Vector2 TextCoord3Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xA64DFA0", Offset = "0xA64CBA0", VA = "0x18A64DFA0")]
		public VertexMaterialDelta(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xA64E370", Offset = "0xA64CF70", VA = "0x18A64E370")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0xA64D240", Offset = "0xA64BE40", VA = "0x18A64D240")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta, [In] Vector2 texCoord2Delta, [In] Vector2 texCoord3Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0xA64D870", Offset = "0xA64C470", VA = "0x18A64D870")]
		internal VertexMaterialDelta([In] VertexMaterialDelta rootVal, [In] VertexMaterialDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xA64CBA0", Offset = "0xA64B7A0", VA = "0x18A64CBA0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA64C960", Offset = "0xA64B560", VA = "0x18A64C960", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA64C810", Offset = "0xA64B410", VA = "0x18A64C810", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA64C7F0", Offset = "0xA64B3F0", VA = "0x18A64C7F0", Slot = "13")]
		public readonly bool Equals(VertexMaterialDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA64ED50", Offset = "0xA64D950", VA = "0x18A64ED50")]
		public static bool operator ==([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xA64EE40", Offset = "0xA64DA40", VA = "0x18A64EE40")]
		public static bool operator !=([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xA64C690", Offset = "0xA64B290", VA = "0x18A64C690")]
		public static bool AreEqual([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xA64CC40", Offset = "0xA64B840", VA = "0x18A64CC40", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xA648DC0", Offset = "0xA6479C0", VA = "0x18A648DC0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xA6473C0", Offset = "0xA645FC0", VA = "0x18A6473C0", Slot = "8")]
		void IVertexMaterial.SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xA6473C0", Offset = "0xA645FC0", VA = "0x18A6473C0")]
		private void SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xA64CB10", Offset = "0xA64B710", VA = "0x18A64CB10", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA649430", Offset = "0xA648030", VA = "0x18A649430")]
		private void SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA64C8E0", Offset = "0xA64B4E0", VA = "0x18A64C8E0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xA64CA40", Offset = "0xA64B640", VA = "0x18A64CA40", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA64DE90", Offset = "0xA64CA90", VA = "0x18A64DE90")]
		internal VertexMaterialDelta([In] VertexTexture1 rootVal, [In] VertexTexture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xA64D740", Offset = "0xA64C340", VA = "0x18A64D740")]
		internal VertexMaterialDelta([In] VertexTexture2 rootVal, [In] VertexTexture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA64D0F0", Offset = "0xA64BCF0", VA = "0x18A64D0F0")]
		internal VertexMaterialDelta([In] VertexTexture3 rootVal, [In] VertexTexture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA64D5E0", Offset = "0xA64C1E0", VA = "0x18A64D5E0")]
		internal VertexMaterialDelta([In] VertexTexture4 rootVal, [In] VertexTexture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA64EB40", Offset = "0xA64D740", VA = "0x18A64EB40")]
		internal VertexMaterialDelta([In] VertexColor1 rootVal, [In] VertexColor1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA64D2D0", Offset = "0xA64BED0", VA = "0x18A64D2D0")]
		internal VertexMaterialDelta([In] VertexColor1Texture1 rootVal, [In] VertexColor1Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA64DB20", Offset = "0xA64C720", VA = "0x18A64DB20")]
		internal VertexMaterialDelta([In] VertexColor1Texture2 rootVal, [In] VertexColor1Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA64CF60", Offset = "0xA64BB60", VA = "0x18A64CF60")]
		internal VertexMaterialDelta([In] VertexColor1Texture3 rootVal, [In] VertexColor1Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA64D430", Offset = "0xA64C030", VA = "0x18A64D430")]
		internal VertexMaterialDelta([In] VertexColor1Texture4 rootVal, [In] VertexColor1Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA64E5D0", Offset = "0xA64D1D0", VA = "0x18A64E5D0")]
		internal VertexMaterialDelta([In] VertexColor2 rootVal, [In] VertexColor2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA64E420", Offset = "0xA64D020", VA = "0x18A64E420")]
		internal VertexMaterialDelta([In] VertexColor2Texture1 rootVal, [In] VertexColor2Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA64E970", Offset = "0xA64D570", VA = "0x18A64E970")]
		internal VertexMaterialDelta([In] VertexColor2Texture2 rootVal, [In] VertexColor2Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xA64DCA0", Offset = "0xA64C8A0", VA = "0x18A64DCA0")]
		internal VertexMaterialDelta([In] VertexColor2Texture3 rootVal, [In] VertexColor2Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA64E760", Offset = "0xA64D360", VA = "0x18A64E760")]
		internal VertexMaterialDelta([In] VertexColor2Texture4 rootVal, [In] VertexColor2Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA649420", Offset = "0xA648020", VA = "0x18A649420", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexTexture3 : IVertexMaterial, IVertexReflection, IEquatable<VertexTexture3>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public VertexTexture3 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public VertexTexture3 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000123")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000869")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000124")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600086B")]
				[Cpp2IlInjected.Address(RVA = "0xA641080", Offset = "0xA63FC80", VA = "0x18A641080", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA640310", Offset = "0xA63EF10", VA = "0x18A640310", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0xA640EB0", Offset = "0xA63FAB0", VA = "0x18A640EB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0xA640A50", Offset = "0xA63F650", VA = "0x18A640A50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xA640A50", Offset = "0xA63F650", VA = "0x18A640A50", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public Vector2 TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Vector2 TexCoord1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public Vector2 TexCoord2;

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xA651AF0", Offset = "0xA6506F0", VA = "0x18A651AF0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x81F2260", Offset = "0x81F0E60", VA = "0x1881F2260")]
		public VertexTexture3(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xA651B70", Offset = "0xA650770", VA = "0x18A651B70")]
		public VertexTexture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA6519B0", Offset = "0xA6505B0", VA = "0x18A6519B0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA651870", Offset = "0xA650470", VA = "0x18A651870", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA651770", Offset = "0xA650370", VA = "0x18A651770", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA651750", Offset = "0xA650350", VA = "0x18A651750", Slot = "13")]
		public readonly bool Equals(VertexTexture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA651D30", Offset = "0xA650930", VA = "0x18A651D30")]
		public static bool operator ==([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA651D40", Offset = "0xA650940", VA = "0x18A651D40")]
		public static bool operator !=([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA651690", Offset = "0xA650290", VA = "0x18A651690")]
		public static bool AreEqual([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA651A30", Offset = "0xA650630", VA = "0x18A651A30", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA6515B0", Offset = "0xA6501B0", VA = "0x18A6515B0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xA651990", Offset = "0xA650590", VA = "0x18A651990", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA651820", Offset = "0xA650420", VA = "0x18A651820", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA6518E0", Offset = "0xA6504E0", VA = "0x18A6518E0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xA651980", Offset = "0xA650580", VA = "0x18A651980", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexTexture4 : IVertexMaterial, IVertexReflection, IEquatable<VertexTexture4>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public VertexTexture4 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public VertexTexture4 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000127")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000884")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000128")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000886")]
				[Cpp2IlInjected.Address(RVA = "0xA6423A0", Offset = "0xA640FA0", VA = "0x18A6423A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xA641480", Offset = "0xA640080", VA = "0x18A641480", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xA642320", Offset = "0xA640F20", VA = "0x18A642320", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA641EE0", Offset = "0xA640AE0", VA = "0x18A641EE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA641EE0", Offset = "0xA640AE0", VA = "0x18A641EE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public Vector2 TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public Vector2 TexCoord1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public Vector2 TexCoord2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Vector2 TexCoord3;

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000872")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CE00", VA = "0x180D5E200", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA652340", Offset = "0xA650F40", VA = "0x18A652340")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA6523C0", Offset = "0xA650FC0", VA = "0x18A6523C0")]
		public VertexTexture4(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA6523E0", Offset = "0xA650FE0", VA = "0x18A6523E0")]
		public VertexTexture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA652210", Offset = "0xA650E10", VA = "0x18A652210", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0xA652070", Offset = "0xA650C70", VA = "0x18A652070", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xA651F60", Offset = "0xA650B60", VA = "0x18A651F60", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0xA652000", Offset = "0xA650C00", VA = "0x18A652000", Slot = "13")]
		public readonly bool Equals(VertexTexture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xA6525F0", Offset = "0xA6511F0", VA = "0x18A6525F0")]
		public static bool operator ==([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xA652600", Offset = "0xA651200", VA = "0x18A652600")]
		public static bool operator !=([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xA651E70", Offset = "0xA650A70", VA = "0x18A651E70")]
		public static bool AreEqual([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA652280", Offset = "0xA650E80", VA = "0x18A652280", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA651D60", Offset = "0xA650960", VA = "0x18A651D60")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xA6521E0", Offset = "0xA650DE0", VA = "0x18A6521E0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xA652020", Offset = "0xA650C20", VA = "0x18A652020", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA652110", Offset = "0xA650D10", VA = "0x18A652110", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0xA6521D0", Offset = "0xA650DD0", VA = "0x18A6521D0", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor1Texture3 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor1Texture3>
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public VertexColor1Texture3 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public VertexColor1Texture3 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700012B")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600089F")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700012C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008A1")]
				[Cpp2IlInjected.Address(RVA = "0xA642440", Offset = "0xA641040", VA = "0x18A642440", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0xA641720", Offset = "0xA640320", VA = "0x18A641720", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA6422E0", Offset = "0xA640EE0", VA = "0x18A6422E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0xA642170", Offset = "0xA640D70", VA = "0x18A642170", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0xA642170", Offset = "0xA640D70", VA = "0x18A642170", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public Vector4 Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public Vector2 TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public Vector2 TexCoord1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public Vector2 TexCoord2;

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA645B30", Offset = "0xA644730", VA = "0x18A645B30")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA645BC0", Offset = "0xA6447C0", VA = "0x18A645BC0")]
		public VertexColor1Texture3(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA645BE0", Offset = "0xA6447E0", VA = "0x18A645BE0")]
		public VertexColor1Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA6459E0", Offset = "0xA6445E0", VA = "0x18A6459E0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA645860", Offset = "0xA644460", VA = "0x18A645860", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA645740", Offset = "0xA644340", VA = "0x18A645740", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA645720", Offset = "0xA644320", VA = "0x18A645720", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA645E40", Offset = "0xA644A40", VA = "0x18A645E40")]
		public static bool operator ==([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xA645E50", Offset = "0xA644A50", VA = "0x18A645E50")]
		public static bool operator !=([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA645620", Offset = "0xA644220", VA = "0x18A645620")]
		public static bool AreEqual([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xA645A60", Offset = "0xA644660", VA = "0x18A645A60", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xA6454E0", Offset = "0xA6440E0", VA = "0x18A6454E0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA644900", Offset = "0xA643500", VA = "0x18A644900", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA6459C0", Offset = "0xA6445C0", VA = "0x18A6459C0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA6457F0", Offset = "0xA6443F0", VA = "0x18A6457F0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xA645900", Offset = "0xA644500", VA = "0x18A645900", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xA6459B0", Offset = "0xA6445B0", VA = "0x18A6459B0", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor1Texture4 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor1Texture4>
	{
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public VertexColor1Texture4 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public VertexColor1Texture4 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700012F")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008BA")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000130")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008BC")]
				[Cpp2IlInjected.Address(RVA = "0xA6436C0", Offset = "0xA6422C0", VA = "0x18A6436C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0xA642580", Offset = "0xA641180", VA = "0x18A642580", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0xA643550", Offset = "0xA642150", VA = "0x18A643550", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0xA6432B0", Offset = "0xA641EB0", VA = "0x18A6432B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0xA6432B0", Offset = "0xA641EB0", VA = "0x18A6432B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public Vector4 Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public Vector2 TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public Vector2 TexCoord1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Vector2 TexCoord2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public Vector2 TexCoord3;

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x60008A8")]
			[Cpp2IlInjected.Address(RVA = "0xD5B4A0", Offset = "0xD5A0A0", VA = "0x180D5B4A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CE00", VA = "0x180D5E200", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA646580", Offset = "0xA645180", VA = "0x18A646580")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA6468C0", Offset = "0xA6454C0", VA = "0x18A6468C0")]
		public VertexColor1Texture4(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA646610", Offset = "0xA645210", VA = "0x18A646610")]
		public VertexColor1Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA646430", Offset = "0xA645030", VA = "0x18A646430", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xA646260", Offset = "0xA644E60", VA = "0x18A646260", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0xA646120", Offset = "0xA644D20", VA = "0x18A646120", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA6461D0", Offset = "0xA644DD0", VA = "0x18A6461D0", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0xA6468F0", Offset = "0xA6454F0", VA = "0x18A6468F0")]
		public static bool operator ==([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xA646900", Offset = "0xA645500", VA = "0x18A646900")]
		public static bool operator !=([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xA645FF0", Offset = "0xA644BF0", VA = "0x18A645FF0")]
		public static bool AreEqual([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xA6464B0", Offset = "0xA6450B0", VA = "0x18A6464B0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0xA645E70", Offset = "0xA644A70", VA = "0x18A645E70")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0xA644900", Offset = "0xA643500", VA = "0x18A644900", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xA646400", Offset = "0xA645000", VA = "0x18A646400", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xA6461F0", Offset = "0xA644DF0", VA = "0x18A6461F0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA646320", Offset = "0xA644F20", VA = "0x18A646320", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA6463F0", Offset = "0xA644FF0", VA = "0x18A6463F0", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor2Texture3 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor2Texture3>
	{
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public VertexColor2Texture3 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public VertexColor2Texture3 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000133")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008D5")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000134")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008D7")]
				[Cpp2IlInjected.Address(RVA = "0xA643670", Offset = "0xA642270", VA = "0x18A643670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0xA642E80", Offset = "0xA641A80", VA = "0x18A642E80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xA643590", Offset = "0xA642190", VA = "0x18A643590", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0xA643360", Offset = "0xA641F60", VA = "0x18A643360", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0xA643360", Offset = "0xA641F60", VA = "0x18A643360", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public Vector4 Color0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public Vector4 Color1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public Vector2 TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public Vector2 TexCoord1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public Vector2 TexCoord2;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA6489C0", Offset = "0xA6475C0", VA = "0x18A6489C0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA648D60", Offset = "0xA647960", VA = "0x18A648D60")]
		public VertexColor2Texture3(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA648A50", Offset = "0xA647650", VA = "0x18A648A50")]
		public VertexColor2Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA648860", Offset = "0xA647460", VA = "0x18A648860", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6486D0", Offset = "0xA6472D0", VA = "0x18A6486D0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA648590", Offset = "0xA647190", VA = "0x18A648590", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xA648570", Offset = "0xA647170", VA = "0x18A648570", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0xA648D90", Offset = "0xA647990", VA = "0x18A648D90")]
		public static bool operator ==([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xA648DA0", Offset = "0xA6479A0", VA = "0x18A648DA0")]
		public static bool operator !=([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xA648440", Offset = "0xA647040", VA = "0x18A648440")]
		public static bool AreEqual([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA6488F0", Offset = "0xA6474F0", VA = "0x18A6488F0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xA648290", Offset = "0xA646E90", VA = "0x18A648290")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0xA6473C0", Offset = "0xA645FC0", VA = "0x18A6473C0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xA648840", Offset = "0xA647440", VA = "0x18A648840", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xA648650", Offset = "0xA647250", VA = "0x18A648650", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xA648780", Offset = "0xA647380", VA = "0x18A648780", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xA648830", Offset = "0xA647430", VA = "0x18A648830", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[GeneratedCode("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexColor2Texture4 : IVertexMaterial, IVertexReflection, IEquatable<VertexColor2Texture4>
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public VertexColor2Texture4 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public VertexColor2Texture4 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000137")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008F0")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000138")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008F2")]
				[Cpp2IlInjected.Address(RVA = "0xA643C10", Offset = "0xA642810", VA = "0x18A643C10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0xA643710", Offset = "0xA642310", VA = "0x18A643710", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0xA643BD0", Offset = "0xA6427D0", VA = "0x18A643BD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0xA643B10", Offset = "0xA642710", VA = "0x18A643B10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0xA643B10", Offset = "0xA642710", VA = "0x18A643B10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public Vector4 Color0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public Vector4 Color1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public Vector2 TexCoord0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public Vector2 TexCoord1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public Vector2 TexCoord2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public Vector2 TexCoord3;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CE00", VA = "0x180D5E200", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6495C0", Offset = "0xA6481C0", VA = "0x18A6495C0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x837C6C0", Offset = "0x837B2C0", VA = "0x18837C6C0")]
		public VertexColor2Texture4(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xA649650", Offset = "0xA648250", VA = "0x18A649650")]
		public VertexColor2Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xA649460", Offset = "0xA648060", VA = "0x18A649460", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xA649270", Offset = "0xA647E70", VA = "0x18A649270", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xA649110", Offset = "0xA647D10", VA = "0x18A649110", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6491D0", Offset = "0xA647DD0", VA = "0x18A6491D0", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6499C0", Offset = "0xA6485C0", VA = "0x18A6499C0")]
		public static bool operator ==([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6499D0", Offset = "0xA6485D0", VA = "0x18A6499D0")]
		public static bool operator !=([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xA648FB0", Offset = "0xA647BB0", VA = "0x18A648FB0")]
		public static bool AreEqual([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0xA6494F0", Offset = "0xA6480F0", VA = "0x18A6494F0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xA648DC0", Offset = "0xA6479C0", VA = "0x18A648DC0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xA6473C0", Offset = "0xA645FC0", VA = "0x18A6473C0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xA649430", Offset = "0xA648030", VA = "0x18A649430", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6491F0", Offset = "0xA647DF0", VA = "0x18A6491F0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA649350", Offset = "0xA647F50", VA = "0x18A649350", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xA649420", Offset = "0xA648020", VA = "0x18A649420", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public delegate TvG? VertexGeometryPreprocessor<TvG>(TvG arg) where TvG : struct, IVertexGeometry;
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public delegate TvM? VertexMaterialPreprocessor<TvM>(TvM arg) where TvM : struct, IVertexMaterial;
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public delegate TvS? VertexSkinningPreprocessor<TvS>(TvS arg) where TvS : struct, IVertexSkinning;
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class VertexPreprocessor<TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private readonly List<VertexGeometryPreprocessor<TvG>> _GeometryPreprocessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private readonly List<VertexMaterialPreprocessor<TvM>> _MaterialPreprocessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private readonly List<VertexSkinningPreprocessor<TvS>> _SkinningPreprocessor;

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x857F0F0", Offset = "0x857DCF0", VA = "0x18857F0F0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x857F070", Offset = "0x857DC70", VA = "0x18857F070")]
		public void Append(VertexGeometryPreprocessor<TvG> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x857EFF0", Offset = "0x857DBF0", VA = "0x18857EFF0")]
		public void Append(VertexMaterialPreprocessor<TvM> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x857EF70", Offset = "0x857DB70", VA = "0x18857EF70")]
		public void Append(VertexSkinningPreprocessor<TvS> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x8583A70", Offset = "0x8582670", VA = "0x188583A70")]
		public void SetValidationPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x8582100", Offset = "0x8580D00", VA = "0x188582100")]
		public void SetSanitizerPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x85804A0", Offset = "0x857F0A0", VA = "0x1885804A0")]
		public bool PreprocessVertex(VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x8583F10", Offset = "0x8582B10", VA = "0x188583F10")]
		public VertexPreprocessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	internal static class VertexPreprocessorLambdas
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x40E1700", Offset = "0x40E0300", VA = "0x1840E1700")]
		public static TvG? ValidateVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x40E3650", Offset = "0x40E2250", VA = "0x1840E3650")]
		public static TvM? ValidateVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x40E7AC0", Offset = "0x40E66C0", VA = "0x1840E7AC0")]
		public static TvS? ValidateVertexSkinning<TvS>(TvS vertex) where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x40DC810", Offset = "0x40DB410", VA = "0x1840DC810")]
		public static TvG? SanitizeVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x40DEA30", Offset = "0x40DD630", VA = "0x1840DEA30")]
		public static TvM? SanitizeVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x40E0CD0", Offset = "0x40DF8D0", VA = "0x1840E0CD0")]
		public static TvS? SanitizeVertexSkinning<TvS>(TvS vertex) where TvS : struct, IVertexSkinning
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public interface IVertexReflection
	{
		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<KeyValuePair<string, AttributeFormat>> GetEncodingAttributes();
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public interface IVertexSkinning : IVertexReflection
	{
		[Cpp2IlInjected.Token(Token = "0x17000139")]
		int MaxBindings
		{
			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		Vector4 JointsLow
		{
			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		Vector4 JointsHigh
		{
			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		Vector4 WeightsLow
		{
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		Vector4 WeightsHigh
		{
			[Cpp2IlInjected.Token(Token = "0x6000918")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(Slot = "1")]
		(int, float) GetBinding(int index);

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetBindings([In] SparseWeight8 bindings);

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetBindings(params (int Index, float Weight)[] bindings);

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(Slot = "4")]
		SparseWeight8 GetBindings();
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexJoints4 : IVertexSkinning, IVertexReflection, IEquatable<VertexJoints4>
	{
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public VertexJoints4 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public VertexJoints4 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000143")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000931")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000144")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000933")]
				[Cpp2IlInjected.Address(RVA = "0xA641030", Offset = "0xA63FC30", VA = "0x18A641030", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0xA640520", Offset = "0xA63F120", VA = "0x18A640520", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0xA640E30", Offset = "0xA63FA30", VA = "0x18A640E30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0xA640B90", Offset = "0xA63F790", VA = "0x18A640B90", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0xA640B90", Offset = "0xA63F790", VA = "0x18A640B90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public Vector4 Joints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public Vector4 Weights;

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		public readonly int MaxBindings
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xD5E200", Offset = "0xD5CE00", VA = "0x180D5E200", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		readonly Vector4 IVertexSkinning.JointsLow
		{
			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0x12B8AB0", Offset = "0x12B76B0", VA = "0x1812B8AB0", Slot = "9")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		readonly Vector4 IVertexSkinning.JointsHigh
		{
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0xA64A600", Offset = "0xA649200", VA = "0x18A64A600", Slot = "10")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		readonly Vector4 IVertexSkinning.WeightsLow
		{
			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0xF00A10", Offset = "0xEFF610", VA = "0x180F00A10", Slot = "11")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		readonly Vector4 IVertexSkinning.WeightsHigh
		{
			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0xA64A600", Offset = "0xA649200", VA = "0x18A64A600", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xA64B890", Offset = "0xA64A490", VA = "0x18A64B890")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xA64BAE0", Offset = "0xA64A6E0", VA = "0x18A64BAE0")]
		public VertexJoints4(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xA64BB40", Offset = "0xA64A740", VA = "0x18A64BB40")]
		public VertexJoints4(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0xA64B910", Offset = "0xA64A510", VA = "0x18A64B910")]
		public VertexJoints4([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0xA64B820", Offset = "0xA64A420", VA = "0x18A64B820", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xA646B20", Offset = "0xA645720", VA = "0x18A646B20", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xA64B520", Offset = "0xA64A120", VA = "0x18A64B520", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xA64B500", Offset = "0xA64A100", VA = "0x18A64B500", Slot = "14")]
		public readonly bool Equals(VertexJoints4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0xA64BBB0", Offset = "0xA64A7B0", VA = "0x18A64BBB0")]
		public static bool operator ==([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xA64BBC0", Offset = "0xA64A7C0", VA = "0x18A64BBC0")]
		public static bool operator !=([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xA64B490", Offset = "0xA64A090", VA = "0x18A64B490")]
		public static bool AreEqual([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0xA64B700", Offset = "0xA64A300", VA = "0x18A64B700", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xA64B7E0", Offset = "0xA64A3E0", VA = "0x18A64B7E0")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0xA64B750", Offset = "0xA64A350", VA = "0x18A64B750", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0xA64B620", Offset = "0xA64A220", VA = "0x18A64B620", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xA64B7E0", Offset = "0xA64A3E0", VA = "0x18A64B7E0", Slot = "6")]
		void IVertexSkinning.SetBindings([In] SparseWeight8 bindings)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[DebuggerDisplay("{_GetDebuggerDisplay(),nq}")]
	public struct VertexJoints8 : IVertexSkinning, IVertexReflection, IEquatable<VertexJoints8>
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		[CompilerGenerated]
		private sealed class <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8 : IEnumerable<KeyValuePair<string, AttributeFormat>>, IEnumerable, IEnumerator<KeyValuePair<string, AttributeFormat>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			private KeyValuePair<string, AttributeFormat> <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public VertexJoints8 <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public VertexJoints8 <>3__<>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700014A")]
			KeyValuePair<string, AttributeFormat> IEnumerator<KeyValuePair<string, AttributeFormat>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600094E")]
				[Cpp2IlInjected.Address(RVA = "0x12B8A90", Offset = "0x12B7690", VA = "0x1812B8A90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, AttributeFormat>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700014B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000950")]
				[Cpp2IlInjected.Address(RVA = "0xA643620", Offset = "0xA642220", VA = "0x18A643620", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094C")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0xA642BB0", Offset = "0xA6417B0", VA = "0x18A642BB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0xA643510", Offset = "0xA642110", VA = "0x18A643510", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0xA6431F0", Offset = "0xA641DF0", VA = "0x18A6431F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xA6431F0", Offset = "0xA641DF0", VA = "0x18A6431F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public Vector4 Joints0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public Vector4 Joints1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public Vector4 Weights0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public Vector4 Weights1;

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public readonly int MaxBindings
		{
			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0xF229E0", Offset = "0xF215E0", VA = "0x180F229E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		readonly Vector4 IVertexSkinning.JointsLow
		{
			[Cpp2IlInjected.Token(Token = "0x6000942")]
			[Cpp2IlInjected.Address(RVA = "0x12B8AB0", Offset = "0x12B76B0", VA = "0x1812B8AB0", Slot = "9")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		readonly Vector4 IVertexSkinning.JointsHigh
		{
			[Cpp2IlInjected.Token(Token = "0x6000943")]
			[Cpp2IlInjected.Address(RVA = "0xF00A10", Offset = "0xEFF610", VA = "0x180F00A10", Slot = "10")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		readonly Vector4 IVertexSkinning.WeightsLow
		{
			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0xED3CD0", Offset = "0xED28D0", VA = "0x180ED3CD0", Slot = "11")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		readonly Vector4 IVertexSkinning.WeightsHigh
		{
			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0xF61530", Offset = "0xF60130", VA = "0x180F61530", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA64C150", Offset = "0xA64AD50", VA = "0x18A64C150")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA64C570", Offset = "0xA64B170", VA = "0x18A64C570")]
		public VertexJoints8(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA64C5F0", Offset = "0xA64B1F0", VA = "0x18A64C5F0")]
		public VertexJoints8(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA64C1E0", Offset = "0xA64ADE0", VA = "0x18A64C1E0")]
		public VertexJoints8([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA64C0C0", Offset = "0xA64ACC0", VA = "0x18A64C0C0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA646B20", Offset = "0xA645720", VA = "0x18A646B20", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA64BCD0", Offset = "0xA64A8D0", VA = "0x18A64BCD0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA64BCB0", Offset = "0xA64A8B0", VA = "0x18A64BCB0", Slot = "14")]
		public readonly bool Equals(VertexJoints8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA64C660", Offset = "0xA64B260", VA = "0x18A64C660")]
		public static bool operator ==([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA64C670", Offset = "0xA64B270", VA = "0x18A64C670")]
		public static bool operator !=([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA64BBE0", Offset = "0xA64A7E0", VA = "0x18A64BBE0")]
		public static bool AreEqual([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA64BF50", Offset = "0xA64AB50", VA = "0x18A64BF50", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA64BFB0", Offset = "0xA64ABB0", VA = "0x18A64BFB0")]
		public void SetBindings([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xA64C010", Offset = "0xA64AC10", VA = "0x18A64C010", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xA64BD90", Offset = "0xA64A990", VA = "0x18A64BD90", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA64BFB0", Offset = "0xA64ABB0", VA = "0x18A64BFB0", Slot = "6")]
		void IVertexSkinning.SetBindings([In] SparseWeight8 bindings)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	internal static class VertexUtils
	{
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private static readonly char[] _SubscriptNumbers;

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x40F82B0", Offset = "0x40F6EB0", VA = "0x1840F82B0")]
		public static MemoryAccessor CreateVertexMemoryAccessor<TVertex>(this IReadOnlyList<TVertex> vertices, string attributeName, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x40F8E40", Offset = "0x40F7A40", VA = "0x1840F8E40")]
		public static MemoryAccessor[] CreateVertexMemoryAccessors<TVertex>(this IReadOnlyList<TVertex> vertices, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x40FA530", Offset = "0x40F9130", VA = "0x1840FA530")]
		private static void FillAccessor<TVertex>(this MemoryAccessor dstAccessor, IReadOnlyList<TVertex> srcVertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xA652620", Offset = "0xA651220", VA = "0x18A652620")]
		public static MemoryAccessor CreateIndexMemoryAccessor(this IReadOnlyList<int> indices, EncodingType indexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xA652910", Offset = "0xA651510", VA = "0x18A652910")]
		public static MemoryAccessInfo[] GetVertexAttributes(this IVertexBuilder firstVertex, int vertexCount, PackedEncoding vertexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xA65E070", Offset = "0xA65CC70", VA = "0x18A65E070")]
		private static Converter<IVertexBuilder, object> _GetVertexBuilderAttributeFunc(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xA65F680", Offset = "0xA65E280", VA = "0x18A65F680")]
		private static object _GetVertexBuilderCustomAttributeFunc(IVertexMaterial vertex, string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x40FC590", Offset = "0x40FB190", VA = "0x1840FC590")]
		private static TColumn[] _GetColumn<TColumn, TVertex>(this IReadOnlyList<TVertex> vertices, Converter<IVertexBuilder, object> func) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xA65D130", Offset = "0xA65BD30", VA = "0x18A65D130")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(params string[] vertexAttributes)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x40F0FC0", Offset = "0x40EFBC0", VA = "0x1840F0FC0")]
		public static TvP ConvertToGeometry<TvP>(this IVertexGeometry src) where TvP : struct, IVertexGeometry
		{
			return (TvP)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x40F3B10", Offset = "0x40F2710", VA = "0x1840F3B10")]
		public static TvM ConvertToMaterial<TvM>(this IVertexMaterial src) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x40F7620", Offset = "0x40F6220", VA = "0x1840F7620")]
		public static TvS ConvertToSkinning<TvS>(this IVertexSkinning src) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xA6536B0", Offset = "0xA6522B0", VA = "0x18A6536B0")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(bool hasNormals, bool hasTangents, int numCols, int numUV, int numJoints)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xA65D7A0", Offset = "0xA65C3A0", VA = "0x18A65D7A0")]
		public static string _GetDebuggerDisplay(IVertexGeometry geo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0xA65DA80", Offset = "0xA65C680", VA = "0x18A65DA80")]
		public static string _GetDebuggerDisplay(IVertexMaterial mat)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0xA65DE30", Offset = "0xA65CA30", VA = "0x18A65DE30")]
		public static string _GetDebuggerDisplay(IVertexSkinning skin)
		{
			return null;
		}
	}
}
namespace SharpGLTF.Diagnostics
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal abstract class _CurveBuilderDebugProxy<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[DebuggerDisplay("{Key} => {Point}")]
		private struct _Point
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public float Key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public T Point;
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[DebuggerDisplay("               \ud83e\udc56 {Tangent}")]
		private struct _OutTangent
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public T Tangent;
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[DebuggerDisplay("               \ud83e\udc57 {Tangent}")]
		private struct _InTangent
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public T Tangent;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private readonly CurveBuilder<T> _Curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private readonly List<object> _Items;

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public object[] Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0x51541F0", Offset = "0x5152DF0", VA = "0x1851541F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x5154040", Offset = "0x5152C40", VA = "0x185154040")]
		public _CurveBuilderDebugProxy(CurveBuilder<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x5153180", Offset = "0x5151D80", VA = "0x185153180")]
		private void _CreateItems(CurveBuilder<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract T GetTangent(T a, T b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	internal sealed class _CurveBuilderDebugProxyBoolean : _CurveBuilderDebugProxy<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0xA666F10", Offset = "0xA665B10", VA = "0x18A666F10")]
		public _CurveBuilderDebugProxyBoolean(CurveBuilder<bool> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xA666ED0", Offset = "0xA665AD0", VA = "0x18A666ED0", Slot = "4")]
		protected override bool GetTangent(bool a, bool b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	internal sealed class _CurveBuilderDebugProxyVector3 : _CurveBuilderDebugProxy<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xA667070", Offset = "0xA665C70", VA = "0x18A667070")]
		public _CurveBuilderDebugProxyVector3(CurveBuilder<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0xA667000", Offset = "0xA665C00", VA = "0x18A667000", Slot = "4")]
		protected override Vector3 GetTangent(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	internal sealed class _CurveBuilderDebugProxyQuaternion : _CurveBuilderDebugProxy<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0xA666F60", Offset = "0xA665B60", VA = "0x18A666F60")]
		public _CurveBuilderDebugProxyQuaternion(CurveBuilder<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0xA660440", Offset = "0xA65F040", VA = "0x18A660440", Slot = "4")]
		protected override Quaternion GetTangent(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	internal sealed class _CurveBuilderDebugProxySparse : _CurveBuilderDebugProxy<SparseWeight8>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA666FB0", Offset = "0xA665BB0", VA = "0x18A666FB0")]
		public _CurveBuilderDebugProxySparse(CurveBuilder<SparseWeight8> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA6610D0", Offset = "0xA65FCD0", VA = "0x18A6610D0", Slot = "4")]
		protected override SparseWeight8 GetTangent(SparseWeight8 a, SparseWeight8 b)
		{
			return default(SparseWeight8);
		}
	}
}
namespace SharpGLTF.Collections
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	internal sealed class EmptyDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__15 : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private KeyValuePair<TKey, TValue> <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000152")]
			KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A27")]
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000153")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A29")]
				[Cpp2IlInjected.Address(RVA = "0x6673A00", Offset = "0x6672600", VA = "0x186673A00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A24")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0xFFC910", Offset = "0xFFB510", VA = "0x180FFC910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[CompilerGenerated]
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			private object <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000154")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A2D")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000155")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A2F")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x6675240", Offset = "0x6673E40", VA = "0x186675240", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0xFFC910", Offset = "0xFFB510", VA = "0x180FFC910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private static readonly EmptyDictionary<TKey, TValue> _Instance;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public static IReadOnlyDictionary<TKey, TValue> Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1B")]
			[Cpp2IlInjected.Address(RVA = "0x5B611E0", Offset = "0x5B5FDE0", VA = "0x185B611E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public TValue this[TKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x5B61310", Offset = "0x5B5FF10", VA = "0x185B61310", Slot = "6")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x5B61350", Offset = "0x5B5FF50", VA = "0x185B61350", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<TValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0x5B61390", Offset = "0x5B5FF90", VA = "0x185B61390", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x570F120", Offset = "0x570DD20", VA = "0x18570F120")]
		static EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x5B611A0", Offset = "0x5B5FDA0", VA = "0x185B611A0", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValue value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x5B61080", Offset = "0x5B5FC80", VA = "0x185B61080", Slot = "10")]
		[IteratorStateMachine(typeof(EmptyDictionary<, >.<GetEnumerator>d__15))]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x5B61140", Offset = "0x5B5FD40", VA = "0x185B61140", Slot = "11")]
		[IteratorStateMachine(typeof(EmptyDictionary<, >.<System-Collections-IEnumerable-GetEnumerator>d__16))]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public readonly struct Triple<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, IEquatable<Triple<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__14 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000413")]
			private T <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			public Triple<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000158")]
			T IEnumerator<T>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A3E")]
				[Cpp2IlInjected.Address(RVA = "0x4FAF1A0", Offset = "0x4FADDA0", VA = "0x184FAF1A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000159")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A40")]
				[Cpp2IlInjected.Address(RVA = "0x64DC990", Offset = "0x64DB590", VA = "0x1864DC990", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x5117D20", Offset = "0x5116920", VA = "0x185117D20")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0x6674FE0", Offset = "0x6673BE0", VA = "0x186674FE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x6674C70", Offset = "0x6673870", VA = "0x186674C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[CompilerGenerated]
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public Triple<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700015A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A44")]
				[Cpp2IlInjected.Address(RVA = "0x53B8FB0", Offset = "0x53B7BB0", VA = "0x1853B8FB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A46")]
				[Cpp2IlInjected.Address(RVA = "0x53B8FB0", Offset = "0x53B7BB0", VA = "0x1853B8FB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x5117D20", Offset = "0x5116920", VA = "0x185117D20")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x6674FE0", Offset = "0x6673BE0", VA = "0x186674FE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0x6E3B650", Offset = "0x6E3A250", VA = "0x186E3B650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public readonly T A;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public readonly T B;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public readonly T C;

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0xD738A0", Offset = "0xD724A0", VA = "0x180D738A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x7CB8ED0", Offset = "0x7CB7AD0", VA = "0x187CB8ED0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x7CB9120", Offset = "0x7CB7D20", VA = "0x187CB9120")]
		public static implicit operator Triple<T>([In] (T A, T B, T C) triple)
		{
			return default(Triple<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8CB0", Offset = "0x7CB78B0", VA = "0x187CB8CB0")]
		public Triple(T a, T b, T c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x7CB84C0", Offset = "0x7CB70C0", VA = "0x187CB84C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8230", Offset = "0x7CB6E30", VA = "0x187CB8230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x7CB7C30", Offset = "0x7CB6830", VA = "0x187CB7C30", Slot = "8")]
		public bool Equals(Triple<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x7CB9040", Offset = "0x7CB7C40", VA = "0x187CB9040")]
		public static bool operator ==([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x7CB9440", Offset = "0x7CB8040", VA = "0x187CB9440")]
		public static bool operator !=([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8360", Offset = "0x7CB6F60", VA = "0x187CB8360", Slot = "6")]
		[IteratorStateMachine(typeof(Triple<>.<GetEnumerator>d__14))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB8B50", Offset = "0x7CB7750", VA = "0x187CB8B50", Slot = "7")]
		[IteratorStateMachine(typeof(Triple<>.<System-Collections-IEnumerable-GetEnumerator>d__15))]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	internal class ValueListSet<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[DebuggerDisplay("Hash:{HashCode} Next:{Next} Value:{Value}")]
		private struct _Entry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public int HashCode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public int Next;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public T Value;
		}

		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private struct _ValueEnumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			private readonly ValueListSet<T> _Source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			private readonly int _Version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			private int _Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			private T _Current;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			public T Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A5F")]
				[Cpp2IlInjected.Address(RVA = "0x5166480", Offset = "0x5165080", VA = "0x185166480", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A60")]
				[Cpp2IlInjected.Address(RVA = "0x5165720", Offset = "0x5164320", VA = "0x185165720", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x5166060", Offset = "0x5164C60", VA = "0x185166060")]
			internal _ValueEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A61")]
			[Cpp2IlInjected.Address(RVA = "0x5163F70", Offset = "0x5162B70", VA = "0x185163F70", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A62")]
			[Cpp2IlInjected.Address(RVA = "0x5165020", Offset = "0x5163C20", VA = "0x185165020", Slot = "8")]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000111")]
		private readonly struct _IndexCollection : IEnumerable<int>, IEnumerable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			private readonly ValueListSet<T> _Source;

			[Cpp2IlInjected.Token(Token = "0x6000A63")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
			public _IndexCollection(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A64")]
			[Cpp2IlInjected.Address(RVA = "0x5158030", Offset = "0x5156C30", VA = "0x185158030", Slot = "4")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0x5158030", Offset = "0x5156C30", VA = "0x185158030", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct _IndexEnumerator : IEnumerator<int>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			private readonly ValueListSet<T> _Source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			private readonly int _Version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			private int _Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private int _Current;

			[Cpp2IlInjected.Token(Token = "0x17000162")]
			public int Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A68")]
				[Cpp2IlInjected.Address(RVA = "0xCEE110", Offset = "0xCECD10", VA = "0x180CEE110", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000163")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A69")]
				[Cpp2IlInjected.Address(RVA = "0x2413820", Offset = "0x2412420", VA = "0x182413820", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x5158570", Offset = "0x5157170", VA = "0x185158570")]
			internal _IndexEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6A")]
			[Cpp2IlInjected.Address(RVA = "0x51580E0", Offset = "0x5156CE0", VA = "0x1851580E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6B")]
			[Cpp2IlInjected.Address(RVA = "0x51584F0", Offset = "0x51570F0", VA = "0x1851584F0", Slot = "8")]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private IEqualityComparer<T> _Comparer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private _Entry[] _Entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private int[] _Buckets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private int _Count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private int _Version;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public IEqualityComparer<T> Comparer
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A00", Offset = "0xCF0600", VA = "0x180CF1A00", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0x7FB0FB0", Offset = "0x7FAFBB0", VA = "0x187FB0FB0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public IEnumerable<int> Indices
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x7FB01C0", Offset = "0x7FAEDC0", VA = "0x187FB01C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x7FAF850", Offset = "0x7FAE450", VA = "0x187FAF850")]
		public ValueListSet()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x7FAEC00", Offset = "0x7FAD800", VA = "0x187FAEC00")]
		public ValueListSet(int capacity, [Optional] IEqualityComparer<T> comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA0B30", Offset = "0x7F9F730", VA = "0x187FA0B30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x7FA5880", Offset = "0x7FA4480", VA = "0x187FA5880")]
		public bool Exists(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6380", Offset = "0x7FA4F80", VA = "0x187FA6380")]
		public int IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6630", Offset = "0x7FA5230", VA = "0x187FA6630")]
		public int Use([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x7F9F300", Offset = "0x7F9DF00", VA = "0x187F9F300")]
		public int Add([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x7FA1480", Offset = "0x7FA0080", VA = "0x187FA1480")]
		public bool Contains([In] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x7FA4690", Offset = "0x7FA3290", VA = "0x187FA4690")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x7FA2D50", Offset = "0x7FA1950", VA = "0x187FA2D50")]
		public void CopyTo(ValueListSet<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6170", Offset = "0x7FA4D70", VA = "0x187FA6170", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6170", Offset = "0x7FA4D70", VA = "0x187FA6170", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x7F9FAD0", Offset = "0x7F9E6D0", VA = "0x187F9FAD0")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x7FAA150", Offset = "0x7FA8D50", VA = "0x187FAA150")]
		private void _Initialize(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x7FA7960", Offset = "0x7FA6560", VA = "0x187FA7960")]
		private int _IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x7FAC1B0", Offset = "0x7FAADB0", VA = "0x187FAC1B0")]
		private int _Insert([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA6BF0", Offset = "0x7FA57F0", VA = "0x187FA6BF0")]
		private void _Grow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x7FAD000", Offset = "0x7FABC00", VA = "0x187FAD000")]
		private void _Resize(int newSize, bool forceNewHashCodes)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	internal class VertexList<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private sealed class _KeyComparer : IEqualityComparer<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			private readonly IReadOnlyList<T> _Items;

			[Cpp2IlInjected.Token(Token = "0x17000166")]
			public T QueryValue
			{
				[Cpp2IlInjected.Token(Token = "0x6000A78")]
				[Cpp2IlInjected.Address(RVA = "0x515A500", Offset = "0x5159100", VA = "0x18515A500")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000A79")]
				[Cpp2IlInjected.Address(RVA = "0x515A5B0", Offset = "0x51591B0", VA = "0x18515A5B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0x515A490", Offset = "0x5159090", VA = "0x18515A490")]
			public _KeyComparer(IReadOnlyList<T> items)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0x5159F70", Offset = "0x5158B70", VA = "0x185159F70", Slot = "4")]
			public bool Equals(int x, int y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0x515A280", Offset = "0x5158E80", VA = "0x18515A280", Slot = "5")]
			public int GetHashCode(int idx)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private List<T> _Vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private _KeyComparer _VertexComparer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private Dictionary<int, int> _VertexCache;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6D")]
			[Cpp2IlInjected.Address(RVA = "0x857DF40", Offset = "0x857CB40", VA = "0x18857DF40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6E")]
			[Cpp2IlInjected.Address(RVA = "0x857DF00", Offset = "0x857CB00", VA = "0x18857DF00", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x857DDC0", Offset = "0x857C9C0", VA = "0x18857DDC0")]
		public VertexList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x857D840", Offset = "0x857C440", VA = "0x18857D840", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x857D840", Offset = "0x857C440", VA = "0x18857D840", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x857DAC0", Offset = "0x857C6C0", VA = "0x18857DAC0")]
		public int Use([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x857D8F0", Offset = "0x857C4F0", VA = "0x18857D8F0")]
		public int IndexOf([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x857DB30", Offset = "0x857C730", VA = "0x18857DB30")]
		private int _Add([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x857D5E0", Offset = "0x857C1E0", VA = "0x18857D5E0")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x857D800", Offset = "0x857C400", VA = "0x18857D800")]
		public void CopyTo(VertexList<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x857DC60", Offset = "0x857C860", VA = "0x18857DC60")]
		private void _Set(VertexList<T> src)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	internal static class _PrimeNumberHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private const int _MaxPrimeArrayLength = 2146435069;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private const int _HashPrime = 101;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly int[] _Primes;

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0xA6673D0", Offset = "0xA665FD0", VA = "0x18A6673D0")]
		public static bool IsPrime(int candidate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0xA6671B0", Offset = "0xA665DB0", VA = "0x18A6671B0")]
		public static int GetPrime(int min)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0xA667140", Offset = "0xA665D40", VA = "0x18A667140")]
		public static int GetMinPrime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0xA6670C0", Offset = "0xA665CC0", VA = "0x18A6670C0")]
		public static int ExpandPrime(int oldSize)
		{
			return default(int);
		}
	}
}
namespace SharpGLTF.Animations
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	public class AnimatableProperty<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private Dictionary<string, ICurveSampler<T>> _Tracks;

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		public T Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0xF4F290", Offset = "0xF4DE90", VA = "0x180F4F290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x73726E0", Offset = "0x73712E0", VA = "0x1873726E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public IReadOnlyDictionary<string, ICurveSampler<T>> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x73728B0", Offset = "0x73714B0", VA = "0x1873728B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		internal AnimatableProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0x7372440", Offset = "0x7371040", VA = "0x187372440")]
		internal AnimatableProperty(AnimatableProperty<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x73686D0", Offset = "0x73672D0", VA = "0x1873686D0")]
		public AnimatableProperty<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x7369700", Offset = "0x7368300", VA = "0x187369700")]
		public void RemoveTrack(string track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x73689C0", Offset = "0x73675C0", VA = "0x1873689C0")]
		public T GetValueAt(string track, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x736C230", Offset = "0x736AE30", VA = "0x18736C230")]
		public void SetTrack(string track, ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x736D660", Offset = "0x736C260", VA = "0x18736D660")]
		public CurveBuilder<T> UseTrackBuilder(string track)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x736CD60", Offset = "0x736B960", VA = "0x18736CD60")]
		public void SetValue(params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x736DC60", Offset = "0x736C860", VA = "0x18736DC60")]
		private static T _Convert(float[] elements)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	public abstract class CurveBuilder<T> : ICurveSampler<T>, IConvertibleCurve<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private SortedDictionary<float, _CurveNode<T>> _Keys;

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		internal IReadOnlyDictionary<float, _CurveNode<T>> _DebugKeys
		{
			[Cpp2IlInjected.Token(Token = "0x6000A92")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public IReadOnlyCollection<float> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000A93")]
			[Cpp2IlInjected.Address(RVA = "0x53B7380", Offset = "0x53B5F80", VA = "0x1853B7380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x53B7600", Offset = "0x53B6200", VA = "0x1853B7600", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x53B6700", Offset = "0x53B5300", VA = "0x1853B6700")]
		protected CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x53B63B0", Offset = "0x53B4FB0", VA = "0x1853B63B0")]
		protected CurveBuilder(CurveBuilder<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A740", Offset = "0x4F69340", VA = "0x184F6A740", Slot = "6")]
		IConvertibleCurve<T> IConvertibleCurve<T>.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract CurveBuilder<T> Clone();

		[Cpp2IlInjected.Token(Token = "0x6000A95")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract bool AreEqual(T left, T right);

		[Cpp2IlInjected.Token(Token = "0x6000A96")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract T CloneValue(T value);

		[Cpp2IlInjected.Token(Token = "0x6000A97")]
		[Cpp2IlInjected.Address(Slot = "13")]
		protected abstract T CreateValue(IReadOnlyList<float> values);

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(Slot = "14")]
		public abstract T GetPoint(float offset);

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract T GetTangent(T fromValue, T toValue);

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x539E940", Offset = "0x539D540", VA = "0x18539E940")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x539FA20", Offset = "0x539E620", VA = "0x18539FA20")]
		public void RemoveKey(float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x53AB580", Offset = "0x53AA180", VA = "0x1853AB580")]
		public void SetPoint(float offset, bool isLinear, params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x53AB090", Offset = "0x53A9C90", VA = "0x1853AB090")]
		public void SetPoint(float offset, T value, bool isLinear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x53A6E60", Offset = "0x53A5A60", VA = "0x1853A6E60")]
		public void SetIncomingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x53AA310", Offset = "0x53A8F10", VA = "0x1853AA310")]
		public void SetOutgoingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x539E9A0", Offset = "0x539D5A0", VA = "0x18539E9A0")]
		private protected (_CurveNode<T>, _CurveNode<T>, float) FindSample(float offset)
		{
			return default((_CurveNode<T>, _CurveNode<T>, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x53A09A0", Offset = "0x539F5A0", VA = "0x1853A09A0")]
		public void SetCurve(ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x53A01D0", Offset = "0x539EDD0", VA = "0x1853A01D0")]
		public void SetCurve(IConvertibleCurve<T> convertible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0x53A30E0", Offset = "0x53A1CE0", VA = "0x1853A30E0")]
		public void SetCurve(IAnimationSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x53B56F0", Offset = "0x53B42F0", VA = "0x1853B56F0")]
		public CurveBuilder<T> WithPoint(float offset, T value, bool isLinear = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x53B4F40", Offset = "0x53B3B40", VA = "0x1853B4F40")]
		public CurveBuilder<T> WithIncomingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x53B5420", Offset = "0x53B4020", VA = "0x1853B5420")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x53B55B0", Offset = "0x53B41B0", VA = "0x1853B55B0")]
		public CurveBuilder<T> WithPoint(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x53B53A0", Offset = "0x53B3FA0", VA = "0x1853B53A0")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x53B4F80", Offset = "0x53B3B80", VA = "0x1853B4F80")]
		public CurveBuilder<T> WithIncomingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x53B43B0", Offset = "0x53B2FB0", VA = "0x1853B43B0", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x53AC160", Offset = "0x53AAD60", VA = "0x1853AC160", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x53AF100", Offset = "0x53ADD00", VA = "0x1853AF100", Slot = "9")]
		IReadOnlyDictionary<float, (T, T, T)> IConvertibleCurve<T>.ToSplineCurve()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[DebuggerDisplay("{ToDebuggerDisplayString(),nq}")]
	internal struct _CurveNode<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public int Degree;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public T IncomingTangent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public T Point;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public T OutgoingTangent;

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x5155780", Offset = "0x5154380", VA = "0x185155780")]
		private string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x5157540", Offset = "0x5156140", VA = "0x185157540")]
		private static string _ToString(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x5157C80", Offset = "0x5156880", VA = "0x185157C80")]
		public _CurveNode(T value, bool isLinear)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x5157950", Offset = "0x5156550", VA = "0x185157950")]
		public _CurveNode(T incoming, T value, T outgoing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x5154370", Offset = "0x5152F70", VA = "0x185154370")]
		public _CurveNode<T> Clone(Func<T, T> cloneValue)
		{
			return default(_CurveNode<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	internal static class CurveFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x38BE060", Offset = "0x38BCC60", VA = "0x1838BE060")]
		public static CurveBuilder<T> CreateCurveBuilder<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x38BE4C0", Offset = "0x38BD0C0", VA = "0x1838BE4C0")]
		public static CurveBuilder<T> CreateCurveBuilder<T>(ICurveSampler<T> curve) where T : struct
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[DebuggerTypeProxy(typeof(_CurveBuilderDebugProxyBoolean))]
	internal sealed class BooleanCurveBuilder : CurveBuilder<bool>, ICurveSampler<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0xA65FFD0", Offset = "0xA65EBD0", VA = "0x18A65FFD0")]
		public BooleanCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0xA660010", Offset = "0xA65EC10", VA = "0x18A660010")]
		private BooleanCurveBuilder(BooleanCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0xA65FD30", Offset = "0xA65E930", VA = "0x18A65FD30", Slot = "10")]
		public override CurveBuilder<bool> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0xA399760", Offset = "0xA398360", VA = "0x18A399760", Slot = "11")]
		protected override bool AreEqual(bool left, bool right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x140FA50", Offset = "0x140E650", VA = "0x18140FA50", Slot = "12")]
		protected override bool CloneValue(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(RVA = "0xA65FDB0", Offset = "0xA65E9B0", VA = "0x18A65FDB0", Slot = "13")]
		protected override bool CreateValue(IReadOnlyList<float> values)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0xA65FF90", Offset = "0xA65EB90", VA = "0x18A65FF90", Slot = "15")]
		protected override bool GetTangent(bool fromValue, bool toValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0xA65FED0", Offset = "0xA65EAD0", VA = "0x18A65FED0", Slot = "14")]
		public override bool GetPoint(float offset)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[DebuggerTypeProxy(typeof(_CurveBuilderDebugProxyVector3))]
	internal sealed class Vector3CurveBuilder : CurveBuilder<Vector3>, ICurveSampler<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC7")]
		[Cpp2IlInjected.Address(RVA = "0xA666E90", Offset = "0xA665A90", VA = "0x18A666E90")]
		public Vector3CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0xA666E40", Offset = "0xA665A40", VA = "0x18A666E40")]
		private Vector3CurveBuilder(Vector3CurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0xA666A20", Offset = "0xA665620", VA = "0x18A666A20", Slot = "10")]
		public override CurveBuilder<Vector3> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA6669D0", Offset = "0xA6655D0", VA = "0x18A6669D0", Slot = "11")]
		protected override bool AreEqual(Vector3 left, Vector3 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x10477D0", Offset = "0x10463D0", VA = "0x1810477D0", Slot = "12")]
		protected override Vector3 CloneValue(Vector3 value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0xA666AA0", Offset = "0xA6656A0", VA = "0x18A666AA0", Slot = "13")]
		protected override Vector3 CreateValue(IReadOnlyList<float> values)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA666DD0", Offset = "0xA6659D0", VA = "0x18A666DD0", Slot = "15")]
		protected override Vector3 GetTangent(Vector3 fromValue, Vector3 toValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA666C20", Offset = "0xA665820", VA = "0x18A666C20", Slot = "14")]
		public override Vector3 GetPoint(float offset)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[DebuggerTypeProxy(typeof(_CurveBuilderDebugProxyQuaternion))]
	internal sealed class QuaternionCurveBuilder : CurveBuilder<Quaternion>, ICurveSampler<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0xA660490", Offset = "0xA65F090", VA = "0x18A660490")]
		public QuaternionCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0xA6604D0", Offset = "0xA65F0D0", VA = "0x18A6604D0")]
		private QuaternionCurveBuilder(QuaternionCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0xA660090", Offset = "0xA65EC90", VA = "0x18A660090", Slot = "10")]
		public override CurveBuilder<Quaternion> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA660060", Offset = "0xA65EC60", VA = "0x18A660060", Slot = "11")]
		protected override bool AreEqual(Quaternion left, Quaternion right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x12ABB40", Offset = "0x12AA740", VA = "0x1812ABB40", Slot = "12")]
		protected override Quaternion CloneValue(Quaternion value)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0xA660110", Offset = "0xA65ED10", VA = "0x18A660110", Slot = "13")]
		protected override Quaternion CreateValue(IReadOnlyList<float> values)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0xA660440", Offset = "0xA65F040", VA = "0x18A660440", Slot = "15")]
		protected override Quaternion GetTangent(Quaternion fromValue, Quaternion toValue)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA6602C0", Offset = "0xA65EEC0", VA = "0x18A6602C0", Slot = "14")]
		public override Quaternion GetPoint(float offset)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[DebuggerTypeProxy(typeof(_CurveBuilderDebugProxySparse))]
	internal sealed class SparseCurveBuilder : CurveBuilder<SparseWeight8>, ICurveSampler<SparseWeight8>
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0xA661160", Offset = "0xA65FD60", VA = "0x18A661160")]
		public SparseCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0xA661110", Offset = "0xA65FD10", VA = "0x18A661110")]
		private SparseCurveBuilder(SparseCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0xA660E00", Offset = "0xA65FA00", VA = "0x18A660E00", Slot = "10")]
		public override CurveBuilder<SparseWeight8> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(RVA = "0xA660DC0", Offset = "0xA65F9C0", VA = "0x18A660DC0", Slot = "11")]
		protected override bool AreEqual(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x57026F0", Offset = "0x57012F0", VA = "0x1857026F0", Slot = "12")]
		protected override SparseWeight8 CloneValue(SparseWeight8 value)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0xA660E80", Offset = "0xA65FA80", VA = "0x18A660E80", Slot = "13")]
		protected override SparseWeight8 CreateValue(IReadOnlyList<float> values)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0xA6610D0", Offset = "0xA65FCD0", VA = "0x18A6610D0", Slot = "15")]
		protected override SparseWeight8 GetTangent(SparseWeight8 fromValue, SparseWeight8 toValue)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0xA660EC0", Offset = "0xA65FAC0", VA = "0x18A660EC0", Slot = "14")]
		public override SparseWeight8 GetPoint(float offset)
		{
			return default(SparseWeight8);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[DebuggerTypeProxy(typeof(_CurveBuilderDebugProxySparse))]
	internal sealed class SegmentCurveBuilder : CurveBuilder<ArraySegment<float>>, ICurveSampler<ArraySegment<float>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADF")]
		[Cpp2IlInjected.Address(RVA = "0xA660D80", Offset = "0xA65F980", VA = "0x18A660D80")]
		public SegmentCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE0")]
		[Cpp2IlInjected.Address(RVA = "0xA660D30", Offset = "0xA65F930", VA = "0x18A660D30")]
		private SegmentCurveBuilder(SegmentCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0xA660870", Offset = "0xA65F470", VA = "0x18A660870", Slot = "10")]
		public override CurveBuilder<ArraySegment<float>> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0xA660520", Offset = "0xA65F120", VA = "0x18A660520", Slot = "11")]
		protected override bool AreEqual(ArraySegment<float> left, ArraySegment<float> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE3")]
		[Cpp2IlInjected.Address(RVA = "0xA660760", Offset = "0xA65F360", VA = "0x18A660760", Slot = "12")]
		protected override ArraySegment<float> CloneValue(ArraySegment<float> value)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE4")]
		[Cpp2IlInjected.Address(RVA = "0xA6608F0", Offset = "0xA65F4F0", VA = "0x18A6608F0", Slot = "13")]
		protected override ArraySegment<float> CreateValue(IReadOnlyList<float> values)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0xA660C80", Offset = "0xA65F880", VA = "0x18A660C80", Slot = "15")]
		protected override ArraySegment<float> GetTangent(ArraySegment<float> fromValue, ArraySegment<float> toValue)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0xA660A30", Offset = "0xA65F630", VA = "0x18A660A30", Slot = "14")]
		public override ArraySegment<float> GetPoint(float offset)
		{
			return default(ArraySegment<float>);
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

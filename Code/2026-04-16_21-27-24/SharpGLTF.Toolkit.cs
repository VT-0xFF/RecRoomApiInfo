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
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected BaseBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		protected BaseBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCE9C40", Offset = "0xCE8A40", VA = "0x180CE9C40")]
		protected BaseBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4D90", Offset = "0xA5E3B90", VA = "0x18A5E4D90")]
		protected BaseBuilder(BaseBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4BA0", Offset = "0xA5E39A0", VA = "0x18A5E4BA0")]
		protected static int GetContentHashCode(BaseBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4A90", Offset = "0xA5E3890", VA = "0x18A5E4A90")]
		protected static bool AreEqualByContent(BaseBuilder x, BaseBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4CB0", Offset = "0xA5E3AB0", VA = "0x18A5E4CB0")]
		internal void SetNameAndExtrasFrom(BaseBuilder source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4C30", Offset = "0xA5E3A30", VA = "0x18A5E4C30")]
		internal void SetNameAndExtrasFrom(LogicalChildOfRoot source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4D30", Offset = "0xA5E3B30", VA = "0x18A5E4D30")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5E6A30", Offset = "0xA5E5830", VA = "0x18A5E6A30")]
		public static void NotNullOrEmpty(string target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5A00", Offset = "0xA5E4800", VA = "0x18A5E5A00")]
		public static void FileNameMustBeValid(string fileName, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5C70", Offset = "0xA5E4A70", VA = "0x18A5E5C70")]
		public static void FilePathMustBeValid(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5EC0", Offset = "0xA5E4CC0", VA = "0x18A5E5EC0")]
		public static void FilePathMustExist(string filePath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5960", Offset = "0xA5E4760", VA = "0x18A5E5960")]
		public static void DirectoryPathMustExist(string dirPath, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA5E66B0", Offset = "0xA5E54B0", VA = "0x18A5E66B0")]
		public static void MustExist(FileInfo finfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6590", Offset = "0xA5E5390", VA = "0x18A5E6590")]
		public static void MustExist(DirectoryInfo dinfo, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6B80", Offset = "0xA5E5980", VA = "0x18A5E6B80")]
		public static void NotNull(object target, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6B20", Offset = "0xA5E5920", VA = "0x18A5E6B20")]
		public static void NotNull(object target, string parameterName, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E63D0", Offset = "0xA5E51D0", VA = "0x18A5E63D0")]
		public static void MustBeNull(object target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0E90", Offset = "0x3ACFC90", VA = "0x183AD0E90")]
		public static void NotNullOrEmpty<T>(IEnumerable<T> target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF570", Offset = "0x3ACE370", VA = "0x183ACF570")]
		public static void MustBeEqualTo<TValue>(TValue value, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6430", Offset = "0xA5E5230", VA = "0x18A5E6430")]
		public static void MustBePositiveAndMultipleOf(int value, int padding, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0A30", Offset = "0x3ACF830", VA = "0x183AD0A30")]
		public static void MustBeLessThan<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD05D0", Offset = "0x3ACF3D0", VA = "0x183AD05D0")]
		public static void MustBeLessThanOrEqualTo<TValue>(TValue value, TValue max, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3AD0190", Offset = "0x3ACEF90", VA = "0x183AD0190")]
		public static void MustBeGreaterThan<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3ACFE90", Offset = "0x3ACEC90", VA = "0x183ACFE90")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(TValue value, TValue min, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF190", Offset = "0x3ACDF90", VA = "0x183ACF190")]
		public static void MustBeBetweenOrEqualTo<TValue>(TValue value, TValue minInclusive, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5FC0", Offset = "0xA5E4DC0", VA = "0x18A5E5FC0")]
		public static void IsTrue(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5F60", Offset = "0xA5E4D60", VA = "0x18A5E5F60")]
		public static void IsFalse(bool target, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6020", Offset = "0xA5E4E20", VA = "0x18A5E6020")]
		public static void IsValidURI(string parameterName, string gltfURI, params string[] validHeaders)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA5E68D0", Offset = "0xA5E56D0", VA = "0x18A5E68D0")]
		public static void MustShareLogicalParent(LogicalChildOfRoot a, LogicalChildOfRoot b, string parameterName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA5E67D0", Offset = "0xA5E55D0", VA = "0x18A5E67D0")]
		public static void MustShareLogicalParent(ModelRoot a, string aName, LogicalChildOfRoot b, string bName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void HasDynamicallyAccessedMembers(Type t, bool hasConstructors, bool hasMethods, bool hasProperties, bool hasFields, string parameterName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DebuggerStepThrough]
	internal static class GuardAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3ACE8A0", Offset = "0x3ACD6A0", VA = "0x183ACE8A0")]
		public static void NotNull<T>(IEnumerable<T> collection, string parameterName, string message = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA5E56D0", Offset = "0xA5E44D0", VA = "0x18A5E56D0")]
		public static void AreTrue(IEnumerable<bool> collection, string parameterName, [Optional] Func<int, string> messageFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDB50", Offset = "0x3ACC950", VA = "0x183ACDB50")]
		public static void MustBeEqualTo<TValue>(IEnumerable<TValue> collection, TValue expected, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD0C0", Offset = "0x3ACBEC0", VA = "0x183ACD0C0")]
		public static void MustBeGreaterThan<TValue>(IEnumerable<TValue> collection, TValue minExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD0C0", Offset = "0x3ACBEC0", VA = "0x183ACD0C0")]
		public static void MustBeLessThan<TValue>(IEnumerable<TValue> collection, TValue maxExclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD0C0", Offset = "0x3ACBEC0", VA = "0x183ACD0C0")]
		public static void MustBeLessThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue maxInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD0C0", Offset = "0x3ACBEC0", VA = "0x183ACD0C0")]
		public static void MustBeGreaterThanOrEqualTo<TValue>(IEnumerable<TValue> collection, TValue minInclusive, string parameterName) where TValue : IComparable<TValue>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC4D0", Offset = "0x3ACB2D0", VA = "0x183ACC4D0")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x66676B0", Offset = "0x66664B0", VA = "0x1866676B0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x66659D0", Offset = "0x66647D0", VA = "0x1866659D0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x6667CE0", Offset = "0x6666AE0", VA = "0x186667CE0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6E5B7E0", Offset = "0x6E5A5E0", VA = "0x186E5B7E0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x6E57CD0", Offset = "0x6E56AD0", VA = "0x186E57CD0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x6E5BCE0", Offset = "0x6E5AAE0", VA = "0x186E5BCE0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x513FB90", Offset = "0x513E990", VA = "0x18513FB90", Slot = "4")]
				get
				{
					return (TResult)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x513F730", Offset = "0x513E530", VA = "0x18513F730", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			public _ListSelect(IReadOnlyList<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x513F3E0", Offset = "0x513E1E0", VA = "0x18513F3E0", Slot = "6")]
			[IteratorStateMachine(typeof(_ListSelect<, >.<GetEnumerator>d__7))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x513F680", Offset = "0x513E480", VA = "0x18513F680", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <GetEnumerator>d__5(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x6662130", Offset = "0x6660F30", VA = "0x186662130", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x6660970", Offset = "0x665F770", VA = "0x186660970", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x66624C0", Offset = "0x66612C0", VA = "0x1866624C0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__6(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x6E52680", Offset = "0x6E51480", VA = "0x186E52680", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6E52320", Offset = "0x6E51120", VA = "0x186E52320", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0x6E52AA0", Offset = "0x6E518A0", VA = "0x186E52AA0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x5136890", Offset = "0x5135690", VA = "0x185136890", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			public _CollectionSelect(IReadOnlyCollection<TSource> list, Func<TSource, TResult> selector)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5136540", Offset = "0x5135340", VA = "0x185136540", Slot = "5")]
			[IteratorStateMachine(typeof(_CollectionSelect<, >.<GetEnumerator>d__5))]
			public IEnumerator<TResult> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5136710", Offset = "0x5135510", VA = "0x185136710", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x13EF890", Offset = "0x13EE690", VA = "0x1813EF890", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6031A0", Offset = "0xA601FA0", VA = "0x18A6031A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x64BEF30", Offset = "0x64BDD30", VA = "0x1864BEF30")]
			[DebuggerHidden]
			public <GetLinesIndices>d__66(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA6031F0", Offset = "0xA601FF0", VA = "0x18A6031F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA602E50", Offset = "0xA601C50", VA = "0x18A602E50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA6032B0", Offset = "0xA6020B0", VA = "0x18A6032B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA603160", Offset = "0xA601F60", VA = "0x18A603160", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA6030B0", Offset = "0xA601EB0", VA = "0x18A6030B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int)> IEnumerable<(int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA6030B0", Offset = "0xA601EB0", VA = "0x18A6030B0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1A050E0", Offset = "0x1A03EE0", VA = "0x181A050E0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA603C90", Offset = "0xA602A90", VA = "0x18A603C90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public <GetTrianglesIndices>d__67(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA603CE0", Offset = "0xA602AE0", VA = "0x18A603CE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA603300", Offset = "0xA602100", VA = "0x18A603300", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA603ED0", Offset = "0xA602CD0", VA = "0x18A603ED0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA603F20", Offset = "0xA602D20", VA = "0x18A603F20")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA603F70", Offset = "0xA602D70", VA = "0x18A603F70")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA603C50", Offset = "0xA602A50", VA = "0x18A603C50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA603BA0", Offset = "0xA6029A0", VA = "0x18A603BA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(int, int, int)> IEnumerable<(int, int, int)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA603BA0", Offset = "0xA6029A0", VA = "0x18A603BA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52B820", Offset = "0xA52A620", VA = "0x18A52B820")]
		internal static bool IsMultipleOf(this int value, int mult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA52D1F0", Offset = "0xA52BFF0", VA = "0x18A52D1F0")]
		internal static int WordPadded(this int length)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA52D320", Offset = "0xA52C120", VA = "0x18A52D320")]
		internal static bool _IsFinite(this float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA52D230", Offset = "0xA52C030", VA = "0x18A52D230")]
		internal static bool _IsFinite(this Vector2 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA52D350", Offset = "0xA52C150", VA = "0x18A52D350")]
		internal static bool _IsFinite(this Vector3 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA52D290", Offset = "0xA52C090", VA = "0x18A52D290")]
		internal static bool _IsFinite([In] this Vector4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA52D3C0", Offset = "0xA52C1C0", VA = "0x18A52D3C0")]
		internal static bool _IsFinite([In] this Matrix4x4 v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA52D290", Offset = "0xA52C090", VA = "0x18A52D290")]
		internal static bool _IsFinite(this Quaternion v)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA52D120", Offset = "0xA52BF20", VA = "0x18A52D120")]
		internal static Vector3 WithLength(this Vector3 v, float len)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA605E10", Offset = "0xA604C10", VA = "0x18A605E10")]
		internal static bool IsNormalized(this Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA605CF0", Offset = "0xA604AF0", VA = "0x18A605CF0")]
		internal static bool IsNormalized(this Quaternion rotation)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA52ABC0", Offset = "0xA5299C0", VA = "0x18A52ABC0")]
		internal static Quaternion AsQuaternion(this Vector4 v)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA606690", Offset = "0xA605490", VA = "0x18A606690")]
		internal static Quaternion Sanitized(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA52B7D0", Offset = "0xA52A5D0", VA = "0x18A52B7D0")]
		internal static bool IsInRange(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA52B770", Offset = "0xA52A570", VA = "0x18A52B770")]
		internal static bool IsInRange(this Vector4 value, Vector4 min, Vector4 max)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA52BA50", Offset = "0xA52A850", VA = "0x18A52BA50")]
		internal static bool IsRound(this Vector4 value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA607230", Offset = "0xA606030", VA = "0x18A607230")]
		internal static void ValidateNormal(this Vector3 normal, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA6073B0", Offset = "0xA6061B0", VA = "0x18A6073B0")]
		internal static void ValidateTangent(this Vector4 tangent, string msg)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA606000", Offset = "0xA604E00", VA = "0x18A606000")]
		internal static Vector3 SanitizeNormal(this Vector3 normal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA605F10", Offset = "0xA604D10", VA = "0x18A605F10")]
		internal static bool IsValidTangent(this Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA6062D0", Offset = "0xA6050D0", VA = "0x18A6062D0")]
		internal static Vector4 SanitizeTangent(this Vector4 tangent)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA605B60", Offset = "0xA604960", VA = "0x18A605B60")]
		internal static Matrix4x4 Inverse([In] this Matrix4x4 src)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DE800", Offset = "0xA5DD600", VA = "0x18A5DE800")]
		internal static bool IsValid([In] this Matrix4x4 matrix, Matrix4x4Factory.MatrixCheck check, float tolerance = 0f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA52C320", Offset = "0xA52B120", VA = "0x18A52C320")]
		internal static bool StartsWith(this string text, char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA605F90", Offset = "0xA604D90", VA = "0x18A605F90")]
		internal static string Replace(this string text, string oldText, string newText, StringComparison comparison)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA52B540", Offset = "0xA52A340", VA = "0x18A52B540")]
		internal static int IndexOf(this string text, string value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA52B480", Offset = "0xA52A280", VA = "0x18A52B480")]
		internal static int IndexOf(this string text, char value, StringComparison comparison)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4128BF0", Offset = "0x41279F0", VA = "0x184128BF0")]
		public static bool AreSameReference<T>(this (T x, T y) refs, [Out] bool result) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA52AD30", Offset = "0xA529B30", VA = "0x18A52AD30")]
		internal static bool Contains(this string self, string value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA52AEA0", Offset = "0xA529CA0", VA = "0x18A52AEA0")]
		internal static int GetHashCode(this string text, StringComparison comparisonType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4135890", Offset = "0x4134690", VA = "0x184135890")]
		internal static int GetContentHashCode<T>(this IEnumerable<T> collection, int count = 2147483647)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x412AAA0", Offset = "0x41298A0", VA = "0x18412AAA0")]
		internal static ArraySegment<T> Slice<T>(this T[] array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x412AC70", Offset = "0x4129A70", VA = "0x18412AC70")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x412AD50", Offset = "0x4129B50", VA = "0x18412AD50")]
		internal static ArraySegment<T> Slice<T>(this ArraySegment<T> array, int offset, int count)
		{
			return default(ArraySegment<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4128C10", Offset = "0x4127A10", VA = "0x184128C10")]
		internal static T[] CloneArray<T>(this T[] srcArray)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4129B50", Offset = "0x4128950", VA = "0x184129B50")]
		internal static void Fill<T>(this IList<T> collection, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4129A40", Offset = "0x4128840", VA = "0x184129A40")]
		internal static void Fill<T>(this T[] array, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x41291F0", Offset = "0x4127FF0", VA = "0x1841291F0")]
		internal static IReadOnlyList<T> EnsureList<T>(this IEnumerable<T> collection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x412A9C0", Offset = "0x41297C0", VA = "0x18412A9C0")]
		internal static bool IsEmpty<T>(this IReadOnlyList<T> list)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x412A490", Offset = "0x4129290", VA = "0x18412A490")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x412A8D0", Offset = "0x41296D0", VA = "0x18412A8D0")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, Predicate<T> predicate)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x412A630", Offset = "0x4129430", VA = "0x18412A630")]
		internal static int IndexOf<T>(this IReadOnlyList<T> collection, T[] subset) where T : IEquatable<T>
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x41290A0", Offset = "0x4127EA0", VA = "0x1841290A0")]
		internal static void CopyTo<T>(this T[] src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4135610", Offset = "0x4134410", VA = "0x184135610")]
		internal static void CopyTo<T>(this ArraySegment<T> src, int srcOffset, IList<T> dst, int dstOffset, int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4128870", Offset = "0x4127670", VA = "0x184128870")]
		internal static void AddRange<Tout, Tin>(this IList<Tout> dst, IEnumerable<Tin> src, Converter<Tin, Tout> cvt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4128CA0", Offset = "0x4127AA0", VA = "0x184128CA0")]
		internal static IEnumerable<T> ConcatElements<T>(this IEnumerable<T> collection, params T[] elements)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA6060D0", Offset = "0xA604ED0", VA = "0x18A6060D0")]
		public static void SanitizeNormals(this IList<Vector3> normals)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA606430", Offset = "0xA605230", VA = "0x18A606430")]
		public static void SanitizeTangents(this IList<Vector4> tangents)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x412AA20", Offset = "0x4129820", VA = "0x18412AA20")]
		public static IReadOnlyList<TResult> SelectList<TResult, TSource>(this IReadOnlyList<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x412AA20", Offset = "0x4129820", VA = "0x18412AA20")]
		public static IReadOnlyCollection<TResult> SelectCollection<TResult, TSource>(this IReadOnlyCollection<TSource> collection, Func<TSource, TResult> selector)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA606940", Offset = "0xA605740", VA = "0x18A606940")]
		public static string ToDebugString(this EncodingType encoding, DimensionType dimensions, bool normalized)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA6054C0", Offset = "0xA6042C0", VA = "0x18A6054C0")]
		public static int ByteLength(this IndexEncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA605410", Offset = "0xA604210", VA = "0x18A605410")]
		public static int ByteLength(this EncodingType encoding)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA6068C0", Offset = "0xA6056C0", VA = "0x18A6068C0")]
		public static EncodingType ToComponent(this IndexEncodingType t)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA607000", Offset = "0xA605E00", VA = "0x18A607000")]
		public static IndexEncodingType ToIndex(this EncodingType t)
		{
			return default(IndexEncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA605540", Offset = "0xA604340", VA = "0x18A605540")]
		public static int DimCount(this DimensionType dimension)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA606F30", Offset = "0xA605D30", VA = "0x18A606F30")]
		public static DimensionType ToDimension(this int len)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA606B40", Offset = "0xA605940", VA = "0x18A606B40")]
		public static DimensionType ToDimension(this Type t)
		{
			return default(DimensionType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA6058B0", Offset = "0xA6046B0", VA = "0x18A6058B0")]
		public static int GetPrimitiveVertexSize(this PrimitiveType ptype)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA605600", Offset = "0xA604400", VA = "0x18A605600")]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA6059D0", Offset = "0xA6047D0", VA = "0x18A6059D0")]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA605790", Offset = "0xA604590", VA = "0x18A605790")]
		[IteratorStateMachine(typeof(<GetLinesIndices>d__66))]
		public static IEnumerable<(int, int)> GetLinesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA605950", Offset = "0xA604750", VA = "0x18A605950")]
		[IteratorStateMachine(typeof(<GetTrianglesIndices>d__67))]
		public static IEnumerable<(int, int, int)> GetTrianglesIndices(this PrimitiveType ptype, IEnumerable<uint> sourceIndices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2379940", Offset = "0x2378740", VA = "0x182379940")]
		private static bool _IsDegeneratedSegment(uint a, uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA52D210", Offset = "0xA52C010", VA = "0x18A52D210")]
		private static bool _IsDegeneratedTriangle(uint a, uint b, uint c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x412AF80", Offset = "0x4129D80", VA = "0x18412AF80")]
		public static bool TryGetUnderlayingArray<T>(this ArraySegment<T> segment, [Out] T[] array)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA606800", Offset = "0xA605600", VA = "0x18A606800")]
		public static ArraySegment<byte> ToArraySegment(this MemoryStream m)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA605810", Offset = "0xA604610", VA = "0x18A605810")]
		public static byte[] GetPaddedContent(this byte[] content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA607180", Offset = "0xA605F80", VA = "0x18A607180")]
		public static byte[] TryParseBase64Unchecked(this string uri, params string[] prefixes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA6075B0", Offset = "0xA6063B0", VA = "0x18A6075B0")]
		private static byte[] _TryParseBase64Unchecked(string uri, string prefix)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA607080", Offset = "0xA605E80", VA = "0x18A607080")]
		public static Uri ToUri(this UriKind kind, string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA52ADD0", Offset = "0xA529BD0", VA = "0x18A52ADD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40CEDA0", Offset = "0x40CDBA0", VA = "0x1840CEDA0")]
		public static void CalculateSmoothNormals<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA6050A0", Offset = "0xA603EA0", VA = "0x18A6050A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x40E0830", Offset = "0x40DF630", VA = "0x1840E0830")]
		public static void CalculateTangents<T>(IEnumerable<T> primitives) where T : IMeshPrimitive
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA605260", Offset = "0xA604060", VA = "0x18A605260")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA601230", Offset = "0xA600030", VA = "0x18A601230", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <EvaluateLines>d__77(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA601280", Offset = "0xA600080", VA = "0x18A601280", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA600B80", Offset = "0xA5FF980", VA = "0x18A600B80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA601450", Offset = "0xA600250", VA = "0x18A601450")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA6014A0", Offset = "0xA6002A0", VA = "0x18A6014A0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA6011F0", Offset = "0xA5FFFF0", VA = "0x18A6011F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA601140", Offset = "0xA5FFF40", VA = "0x18A601140", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA601140", Offset = "0xA5FFF40", VA = "0x18A601140", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA601AE0", Offset = "0xA6008E0", VA = "0x18A601AE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x1D13E20", Offset = "0x1D12C20", VA = "0x181D13E20")]
			[DebuggerHidden]
			public <EvaluatePoints>d__75(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA601B30", Offset = "0xA600930", VA = "0x18A601B30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA601500", Offset = "0xA600300", VA = "0x18A601500", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA601D30", Offset = "0xA600B30", VA = "0x18A601D30")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA601D80", Offset = "0xA600B80", VA = "0x18A601D80")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA601AA0", Offset = "0xA6008A0", VA = "0x18A601AA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA6019F0", Offset = "0xA6007F0", VA = "0x18A6019F0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA6019F0", Offset = "0xA6007F0", VA = "0x18A6019F0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x5102FF0", Offset = "0x5101DF0", VA = "0x185102FF0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA602500", Offset = "0xA601300", VA = "0x18A602500", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x65C8910", Offset = "0x65C7710", VA = "0x1865C8910")]
			[DebuggerHidden]
			public <EvaluateTriangles>d__79(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA602550", Offset = "0xA601350", VA = "0x18A602550", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xA601DD0", Offset = "0xA600BD0", VA = "0x18A601DD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xA602730", Offset = "0xA601530", VA = "0x18A602730")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA602780", Offset = "0xA601580", VA = "0x18A602780")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xA6024C0", Offset = "0xA6012C0", VA = "0x18A6024C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA602410", Offset = "0xA601210", VA = "0x18A602410", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA602410", Offset = "0xA601210", VA = "0x18A602410", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F76B0", Offset = "0xA5F64B0", VA = "0x18A5F76B0")]
		public static Accessor CreateMorphTargetAccessor(this ModelRoot root, MemoryAccessor memAccessor, int sparsityPercent = 60)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7910", Offset = "0xA5F6710", VA = "0x18A5F7910")]
		public static Accessor CreateVertexAccessor(this ModelRoot root, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F70F40", Offset = "0x3F6FD40", VA = "0x183F70F40")]
		public static BufferView CreateBufferView<T>(this ModelRoot root, IReadOnlyList<T> data) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F98F0", Offset = "0xA5F86F0", VA = "0x18A5F98F0")]
		public static Animation UseAnimation(this ModelRoot root, string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDA50", Offset = "0xA5FC850", VA = "0x18A5FDA50")]
		public static Node WithScaleAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF1A0", Offset = "0xA5FDFA0", VA = "0x18A5FF1A0")]
		public static Node WithTranslationAnimation(this Node node, string animationName, ICurveSampler<Vector3> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC830", Offset = "0xA5FB630", VA = "0x18A5FC830")]
		public static Node WithMorphingAnimation(this Node node, string animationName, ICurveSampler<SparseWeight8> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F77710", Offset = "0x3F76510", VA = "0x183F77710")]
		public static Node WithMorphingAnimation<T>(this Node node, string animationName, ICurveSampler<T> sampler) where T : IReadOnlyList<float>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD710", Offset = "0xA5FC510", VA = "0x18A5FD710")]
		public static Node WithRotationAnimation(this Node node, string animationName, ICurveSampler<Quaternion> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFCE0", Offset = "0xA5FEAE0", VA = "0x18A5FFCE0")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, ICurveSampler<bool> sampler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDC60", Offset = "0xA5FCA60", VA = "0x18A5FDC60")]
		public static Node WithScaleAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD280", Offset = "0xA5FC080", VA = "0x18A5FD280")]
		public static Node WithRotationAnimation(this Node node, string animationName, params (float Key, Quaternion Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5FEE40", Offset = "0xA5FDC40", VA = "0x18A5FEE40")]
		public static Node WithTranslationAnimation(this Node node, string animationName, params (float Key, Vector3 Value)[] keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD920", Offset = "0xA5FC720", VA = "0x18A5FD920")]
		public static Node WithScaleAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD5E0", Offset = "0xA5FC3E0", VA = "0x18A5FD5E0")]
		public static Node WithRotationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5FED10", Offset = "0xA5FDB10", VA = "0x18A5FED10")]
		public static Node WithTranslationAnimation(this Node node, string animationName, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFE80", Offset = "0xA5FEC80", VA = "0x18A5FFE80")]
		public static Node WithVisibilityAnimation(this Node node, string animationName, IReadOnlyDictionary<float, bool> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA5FEC40", Offset = "0xA5FDA40", VA = "0x18A5FEC40")]
		public static PunctualLight WithSpotCone(this PunctualLight light, float innerConeAngle, float outerConeAngle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA550", Offset = "0xA5F9350", VA = "0x18A5FA550")]
		public static PunctualLight WithColor(this PunctualLight light, Vector3 color, float intensity = 1f, float range = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA660", Offset = "0xA5F9460", VA = "0x18A5FA660")]
		public static Material WithDefault(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA770", Offset = "0xA5F9570", VA = "0x18A5FA770")]
		public static Material WithDefault(this Material material, Vector4 diffuseColor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA950", Offset = "0xA5F9750", VA = "0x18A5FA950")]
		public static Material WithDoubleSide(this Material material, bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9F40", Offset = "0xA5F8D40", VA = "0x18A5F9F40")]
		[Obsolete("don't use vector4 based parameter. Use WithChannelColor and WithChannelFactor instead.")]
		public static Material WithChannelParameter(this Material material, string channelName, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9C50", Offset = "0xA5F8A50", VA = "0x18A5F9C50")]
		public static Material WithChannelColor(this Material material, string channelName, Vector4 color)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9DC0", Offset = "0xA5F8BC0", VA = "0x18A5F9DC0")]
		public static Material WithChannelFactor(this Material material, string channelName, string paramName, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA260", Offset = "0xA5F9060", VA = "0x18A5FA260")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, string imageFilePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA5FA0B0", Offset = "0xA5F8EB0", VA = "0x18A5FA0B0")]
		public static Material WithChannelTexture(this Material material, string channelName, int textureSet, Image image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCCA0", Offset = "0xA5FBAA0", VA = "0x18A5FCCA0")]
		public static Material WithPBRMetallicRoughness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCD70", Offset = "0xA5FBB70", VA = "0x18A5FCD70")]
		public static Material WithPBRMetallicRoughness(this Material material, Vector4 baseColor, string baseColorImageFilePath, [Optional] string metallicImageFilePath, float metallicFactor = 1f, float roughnessFactor = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD070", Offset = "0xA5FBE70", VA = "0x18A5FD070")]
		[Obsolete("SpecularGlossiness Extension has been declared deprecated by the Khronos Group. Use newer extensions instead.")]
		public static Material WithPBRSpecularGlossiness(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF3B0", Offset = "0xA5FE1B0", VA = "0x18A5FF3B0")]
		public static Material WithUnlit(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9B30", Offset = "0xA5F8930", VA = "0x18A5F9B30")]
		public static Image UseImageWithFile(this ModelRoot root, string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9A60", Offset = "0xA5F8860", VA = "0x18A5F9A60")]
		public static Image UseImageWithContent(this ModelRoot root, MemoryImage image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA5F71A0", Offset = "0xA5F5FA0", VA = "0x18A5F71A0")]
		public static Material CreateMaterial(this ModelRoot root, MaterialBuilder mb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8F80", Offset = "0xA5F7D80", VA = "0x18A5F8F80")]
		public static MaterialBuilder ToMaterialBuilder(this Material srcMaterial)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9590", Offset = "0xA5F8390", VA = "0x18A5F9590")]
		public static AlphaMode ToSchema2(this SharpGLTF.Materials.AlphaMode alpha)
		{
			return default(AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9640", Offset = "0xA5F8440", VA = "0x18A5F9640")]
		public static SharpGLTF.Materials.AlphaMode ToToolkit(this AlphaMode alpha)
		{
			return default(SharpGLTF.Materials.AlphaMode);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA5F5DE0", Offset = "0xA5F4BE0", VA = "0x18A5F5DE0")]
		public static void CopyTo(this Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA6003D0", Offset = "0xA5FF1D0", VA = "0x18A6003D0")]
		private static void _CopyMetallicRoughnessTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA6000F0", Offset = "0xA5FEEF0", VA = "0x18A6000F0")]
		private static void _CopyDefaultTo(Material srcMaterial, MaterialBuilder dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F5370", Offset = "0xA5F4170", VA = "0x18A5F5370")]
		public static void CopyChannelsTo(this Material srcMaterial, MaterialBuilder dstMaterial, params string[] channelKeys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5F5660", Offset = "0xA5F4460", VA = "0x18A5F5660")]
		public static void CopyTo(this MaterialChannel srcChannel, ChannelBuilder dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6750", Offset = "0xA5F5550", VA = "0x18A5F6750")]
		public static void CopyTo(this MaterialBuilder srcMaterial, Material dstMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5F5210", Offset = "0xA5F4010", VA = "0x18A5F5210")]
		[Obsolete]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params string[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5F4F50", Offset = "0xA5F3D50", VA = "0x18A5F4F50")]
		public static void CopyChannelsTo(this MaterialBuilder srcMaterial, Material dstMaterial, params KnownChannel[] channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5F6160", Offset = "0xA5F4F60", VA = "0x18A5F6160")]
		public static void CopyTo(this ChannelBuilder srcChannel, MaterialChannel dstChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFFB0", Offset = "0xA5FEDB0", VA = "0x18A5FFFB0")]
		private static Image _ConvertToImage(MaterialChannel dstChannel, ImageBuilder srcImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8670", Offset = "0xA5F7470", VA = "0x18A5F8670")]
		public static Vector4 GetDiffuseColor(this Material material, Vector4 defaultColor)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8AD0", Offset = "0xA5F78D0", VA = "0x18A5F8AD0")]
		public static Texture GetDiffuseTexture(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8990", Offset = "0xA5F7790", VA = "0x18A5F8990")]
		public static TextureTransform GetDiffuseTextureTransform(this Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA5F87C0", Offset = "0xA5F75C0", VA = "0x18A5F87C0")]
		public static Matrix3x2? GetDiffuseTextureMatrix(this Material material, Animation track, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA5F72D0", Offset = "0xA5F60D0", VA = "0x18A5F72D0")]
		public static Mesh CreateMesh(this ModelRoot root, IMeshBuilder<MaterialBuilder> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F72D10", Offset = "0x3F71B10", VA = "0x183F72D10")]
		public static Mesh CreateMesh<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialEvaluator, IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7510", Offset = "0xA5F6310", VA = "0x18A5F7510")]
		public static IReadOnlyList<Mesh> CreateMeshes(this ModelRoot root, params IMeshBuilder<MaterialBuilder>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3F749F0", Offset = "0x3F737F0", VA = "0x183F749F0")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F73D70", Offset = "0x3F72B70", VA = "0x183F73D70")]
		public static IReadOnlyList<Mesh> CreateMeshes<TMaterial>(this ModelRoot root, Converter<TMaterial, Material> materialConverter, SceneBuilderSchema2Settings settings, params IMeshBuilder<TMaterial>[] meshBuilders)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA5FADE0", Offset = "0xA5F9BE0", VA = "0x18A5FADE0")]
		public static MeshPrimitive WithIndicesAutomatic(this MeshPrimitive primitive, PrimitiveType primitiveType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA5FAA10", Offset = "0xA5F9810", VA = "0x18A5FAA10")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, IReadOnlyList<int> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3F780B0", Offset = "0x3F76EB0", VA = "0x183F780B0")]
		public static MeshPrimitive WithVertexAccessor<T>(this MeshPrimitive primitive, string attribute, IReadOnlyList<T> values, bool useExplicitByteStride = false) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFB80", Offset = "0xA5FE980", VA = "0x18A5FFB80")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPosition> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA5FFA20", Offset = "0xA5FE820", VA = "0x18A5FFA20")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IReadOnlyList<VertexPositionNormal> vertices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F786C0", Offset = "0x3F774C0", VA = "0x183F786C0")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F786C0", Offset = "0x3F774C0", VA = "0x183F786C0")]
		public static MeshPrimitive WithVertexAccessors<TvP, TvM, TvS>(this MeshPrimitive primitive, IReadOnlyList<(TvP Geo, TvM Mat, TvS Skin)> vertices) where TvP : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F78880", Offset = "0x3F77680", VA = "0x183F78880")]
		public static MeshPrimitive WithVertexAccessors<TVertex>(this MeshPrimitive primitive, IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF670", Offset = "0xA5FE470", VA = "0x18A5FF670")]
		public static MeshPrimitive WithVertexAccessors(this MeshPrimitive primitive, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA5FF460", Offset = "0xA5FE260", VA = "0x18A5FF460")]
		public static MeshPrimitive WithVertexAccessor(this MeshPrimitive primitive, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA5FACC0", Offset = "0xA5F9AC0", VA = "0x18A5FACC0")]
		public static MeshPrimitive WithIndicesAccessor(this MeshPrimitive primitive, PrimitiveType primitiveType, MemoryAccessor memAccessor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC550", Offset = "0xA5FB350", VA = "0x18A5FC550")]
		public static MeshPrimitive WithMorphTargetAccessors(this MeshPrimitive primitive, int targetIndex, IEnumerable<MemoryAccessor> memAccessors)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3F76E70", Offset = "0x3F75C70", VA = "0x183F76E70")]
		public static MeshGpuInstancing WithInstanceAccessor<T>(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<T> values) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA5FAEC0", Offset = "0xA5F9CC0", VA = "0x18A5FAEC0")]
		public static MeshGpuInstancing WithInstanceAccessors(this MeshGpuInstancing instancing, IReadOnlyList<AffineTransform> transforms)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB920", Offset = "0xA5FA720", VA = "0x18A5FB920")]
		public static MeshGpuInstancing WithInstanceCustomAccessors(this MeshGpuInstancing instancing, IReadOnlyList<JsonNode> extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA5FB6B0", Offset = "0xA5FA4B0", VA = "0x18A5FB6B0")]
		public static MeshGpuInstancing WithInstanceCustomAccessor(this MeshGpuInstancing instancing, string attribute, IReadOnlyList<JsonNode> values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3F78D30", Offset = "0x3F77B30", VA = "0x183F78D30")]
		private static List<T> _SelectAttribute<T>(IReadOnlyList<JsonNode> values, string propertyName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC3D0", Offset = "0xA5FB1D0", VA = "0x18A5FC3D0")]
		public static MeshPrimitive WithMaterial(this MeshPrimitive primitive, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7CC0", Offset = "0xA5F6AC0", VA = "0x18A5F7CC0")]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7C30", Offset = "0xA5F6A30", VA = "0x18A5F7C30")]
		[IteratorStateMachine(typeof(<EvaluatePoints>d__75))]
		public static IEnumerable<(IVertexBuilder, Material)> EvaluatePoints(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7A40", Offset = "0xA5F6840", VA = "0x18A5F7A40")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7BA0", Offset = "0xA5F69A0", VA = "0x18A5F7BA0")]
		[IteratorStateMachine(typeof(<EvaluateLines>d__77))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, Material)> EvaluateLines(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8090", Offset = "0xA5F6E90", VA = "0x18A5F8090")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8190", Offset = "0xA5F6F90", VA = "0x18A5F8190")]
		[IteratorStateMachine(typeof(<EvaluateTriangles>d__79))]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this MeshPrimitive prim, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3F74EF0", Offset = "0x3F73CF0", VA = "0x183F74EF0")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> EvaluateTriangles<TvG, TvM, TvS>(this Mesh mesh, [Optional] IGeometryTransform xform) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8C10", Offset = "0xA5F7A10", VA = "0x18A5F8C10")]
		public static VertexBufferColumns GetVertexColumns(this MeshPrimitive primitive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA600580", Offset = "0xA5FF380", VA = "0x18A600580")]
		private static void _Initialize(IReadOnlyDictionary<string, Accessor> vertexAccessors, VertexBufferColumns dstColumns)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3F6FBA0", Offset = "0x3F6E9A0", VA = "0x183F6FBA0")]
		public static void AddMesh<TMaterial, TvG, TvM, TvS>(this MeshBuilder<TMaterial, TvG, TvM, TvS> meshBuilder, Mesh srcMesh, Converter<Material, TMaterial> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3F75FE0", Offset = "0x3F74DE0", VA = "0x183F75FE0")]
		public static MeshBuilder<TMaterial, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TMaterial, TvG, TvM>(this Scene srcScene, Converter<Material, TMaterial> materialFunc, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x3F76630", Offset = "0x3F75430", VA = "0x183F76630")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> ToStaticMeshBuilder<TvG, TvM>(this Scene srcScene, RuntimeOptions options, Animation animation, float time) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA5F9010", Offset = "0xA5F7E10", VA = "0x18A5F9010")]
		public static IMeshBuilder<MaterialBuilder> ToMeshBuilder(this Mesh srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3F75D10", Offset = "0x3F74B10", VA = "0x183F75D10")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS>(this IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x3F75610", Offset = "0x3F74410", VA = "0x183F75610")]
		public static MeshBuilder<MaterialBuilder, TvG, TvM, TvS> ToMeshBuilder<TvG, TvM, TvS, TMaterial>(this IEnumerable<(VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, TMaterial Material)> triangles, Converter<TMaterial, MaterialBuilder> materialFunc) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3E10", Offset = "0xA5F2C10", VA = "0x18A5F3E10")]
		private static void AddPrimitiveGeometry(this IPrimitiveBuilder dstPrim, MeshPrimitive srcPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8E80", Offset = "0xA5F7C80", VA = "0x18A5F8E80")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8D50", Offset = "0xA5F7B50", VA = "0x18A5F8D50")]
		public static void SaveAsWavefront(this ModelRoot model, string filePath, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC160", Offset = "0xA5FAF60", VA = "0x18A5FC160")]
		public static Node WithLocalTransform(this Node node, AffineTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC240", Offset = "0xA5FB040", VA = "0x18A5FC240")]
		public static Node WithLocalTranslation(this Node node, Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBE50", Offset = "0xA5FAC50", VA = "0x18A5FBE50")]
		public static Node WithLocalRotation(this Node node, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA5FBFD0", Offset = "0xA5FADD0", VA = "0x18A5FBFD0")]
		public static Node WithLocalScale(this Node node, Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA5FC490", Offset = "0xA5FB290", VA = "0x18A5FC490")]
		public static Node WithMesh(this Node node, Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE4B0", Offset = "0xA5FD2B0", VA = "0x18A5FE4B0")]
		public static Node WithSkin(this Node node, Skin skin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE2C0", Offset = "0xA5FD0C0", VA = "0x18A5FE2C0")]
		public static Node WithSkinBinding(this Node node, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA5FDFC0", Offset = "0xA5FCDC0", VA = "0x18A5FDFC0")]
		public static Node WithSkinBinding(this Node node, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE570", Offset = "0xA5FD370", VA = "0x18A5FE570")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, Matrix4x4 meshPoseTransform, params Node[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA5FE8C0", Offset = "0xA5FD6C0", VA = "0x18A5FE8C0")]
		public static Node WithSkinnedMesh(this Node node, Mesh mesh, params (Node Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA5FD120", Offset = "0xA5FBF20", VA = "0x18A5FD120")]
		public static Node WithPerspectiveCamera(this Node node, float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB40", Offset = "0xA5FB940", VA = "0x18A5FCB40")]
		public static Node WithOrthographicCamera(this Node node, float xmag, float ymag, float znear, float zfar)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA5F84B0", Offset = "0xA5F72B0", VA = "0x18A5F84B0")]
		public static Node FindNode(this Scene scene, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA5F8220", Offset = "0xA5F7020", VA = "0x18A5F8220")]
		public static Node FindNode(this Node node, Predicate<Node> predicate)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7E20", Offset = "0xA5F6C20", VA = "0x18A5F7E20")]
		public static IEnumerable<(IVertexBuilder, IVertexBuilder, IVertexBuilder, Material)> EvaluateTriangles(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x3F74F40", Offset = "0x3F73D40", VA = "0x183F74F40")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, VertexEmpty>> EvaluateTriangles<TvG, TvM>(this Scene scene, [Optional] RuntimeOptions options, [Optional] Animation animation, float time = 0f) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF0E0", Offset = "0xA5EDEE0", VA = "0x18A5EF0E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6651D10", Offset = "0x6650B10", VA = "0x186651D10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x7186F80", Offset = "0x7185D80", VA = "0x187186F80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x6BDF970", Offset = "0x6BDE770", VA = "0x186BDF970")]
			[DebuggerHidden]
			public <_EvaluateTriangles>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x71871C0", Offset = "0x7185FC0", VA = "0x1871871C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x71859D0", Offset = "0x71847D0", VA = "0x1871859D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x7187400", Offset = "0x7186200", VA = "0x187187400")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7186960", Offset = "0x7185760", VA = "0x187186960", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<EvaluatedTriangle<TvG, TvM, TvS>> IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x7186D80", Offset = "0x7185B80", VA = "0x187186D80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6284170", Offset = "0x6282F70", VA = "0x186284170")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> GetTrianglesFromMesh(Mesh mesh, [Optional] IGeometryTransform xform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6286D60", Offset = "0x6285B60", VA = "0x186286D60")]
		private static List<(Material, VertexBufferColumns, IEnumerable<(int, int, int)>)> _GatherMeshGeometry(Mesh mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x62851B0", Offset = "0x6283FB0", VA = "0x1862851B0")]
		[IteratorStateMachine(typeof(EvaluatedTriangle<, , >.<_EvaluateTriangles>d__2))]
		private static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> _EvaluateTriangles(Material material, VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6289AA0", Offset = "0x62888A0", VA = "0x186289AA0")]
		public static implicit operator EvaluatedTriangle<TvG, TvM, TvS>((VertexBuilder<TvG, TvM, TvS> A, VertexBuilder<TvG, TvM, TvS> B, VertexBuilder<TvG, TvM, TvS> C, Material Material) tri)
		{
			return default(EvaluatedTriangle<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x62895C0", Offset = "0x62883C0", VA = "0x1862895C0")]
		public EvaluatedTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, Material m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6284B00", Offset = "0x6283900", VA = "0x186284B00")]
		public static IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> TransformTextureCoordsByMaterial(IEnumerable<EvaluatedTriangle<TvG, TvM, TvS>> triangles, [Optional] Animation track, float time = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6288820", Offset = "0x6287620", VA = "0x186288820")]
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
				[Cpp2IlInjected.Address(RVA = "0x10AD750", Offset = "0x10AC550", VA = "0x1810AD750")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001DE")]
				[Cpp2IlInjected.Address(RVA = "0x1345600", Offset = "0x1344400", VA = "0x181345600")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public float YMag
			{
				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0xE61B40", Offset = "0xE60940", VA = "0x180E61B40")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0xEF82A0", Offset = "0xEF70A0", VA = "0x180EF82A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBD60", Offset = "0xA5EAB60", VA = "0x18A5EBD60")]
			public Orthographic(float xmag, float ymag, float znear, float zfar)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBDC0", Offset = "0xA5EABC0", VA = "0x18A5EBDC0")]
			internal Orthographic(CameraOrthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBC00", Offset = "0xA5EAA00", VA = "0x18A5EBC00", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBE50", Offset = "0xA5EAC50", VA = "0x18A5EBE50")]
			private Orthographic(Orthographic ortho)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBD00", Offset = "0xA5EAB00", VA = "0x18A5EBD00", Slot = "9")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001E7")]
				[Cpp2IlInjected.Address(RVA = "0xCE7960", Offset = "0xCE6760", VA = "0x180CE7960")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public float VerticalFOV
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0xE61B30", Offset = "0xE60930", VA = "0x180E61B30")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x109AA50", Offset = "0x1099850", VA = "0x18109AA50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC0E0", Offset = "0xA5EAEE0", VA = "0x18A5EC0E0")]
			public Perspective(float? aspectRatio, float fovy, float znear, float zfar = 1f / 0f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC140", Offset = "0xA5EAF40", VA = "0x18A5EC140")]
			internal Perspective(CameraPerspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBF30", Offset = "0xA5EAD30", VA = "0x18A5EBF30", Slot = "8")]
			public override CameraBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC1D0", Offset = "0xA5EAFD0", VA = "0x18A5EC1D0")]
			private Perspective(Perspective persp)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC030", Offset = "0xA5EAE30", VA = "0x18A5EC030", Slot = "9")]
			protected override Matrix4x4 GetMatrix()
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA539F20", Offset = "0xA538D20", VA = "0x18A539F20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ZNear
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xD4D5A0", Offset = "0xD4C3A0", VA = "0x180D4D5A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x10A2ED0", Offset = "0x10A1CD0", VA = "0x1810A2ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float ZFar
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xD3D220", Offset = "0xD3C020", VA = "0x180D3D220")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xD3D210", Offset = "0xD3C010", VA = "0x180D3D210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA5E4F90", Offset = "0xA5E3D90", VA = "0x18A5E4F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Matrix4x4 Matrix
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA5E4FC0", Offset = "0xA5E3DC0", VA = "0x18A5E4FC0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract CameraBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4F50", Offset = "0xA5E3D50", VA = "0x18A5E4F50")]
		protected CameraBuilder(float znear, float zfar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5E4E80", Offset = "0xA5E3C80", VA = "0x18A5E4E80")]
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
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public EmptyContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5680", Offset = "0xA5E4480", VA = "0x18A5E5680", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public MeshContent(IMeshBuilder<MaterialBuilder> mesh)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7470", Offset = "0xA5E6270", VA = "0x18A5E7470", Slot = "5")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8E54D60", Offset = "0x8E53B60", VA = "0x188E54D60")]
		private MeshContent(MeshContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B6D2A0", Offset = "0x2B6C0A0", VA = "0x182B6D2A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA5E75C0", Offset = "0xA5E63C0", VA = "0x18A5E75C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA5E74E0", Offset = "0xA5E62E0", VA = "0x18A5E74E0", Slot = "6")]
		public bool Equals(IRenderableContent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5E76D0", Offset = "0xA5E64D0", VA = "0x18A5E76D0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public CameraContent(CameraBuilder camera)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5010", Offset = "0xA5E3E10", VA = "0x18A5E5010", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA5E53F0", Offset = "0xA5E41F0", VA = "0x18A5E53F0")]
		private CameraContent(CameraContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5E50A0", Offset = "0xA5E3EA0", VA = "0x18A5E50A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public LightContent(LightBuilder light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7090", Offset = "0xA5E5E90", VA = "0x18A5E7090", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA5E53F0", Offset = "0xA5E41F0", VA = "0x18A5E53F0")]
		private LightContent(LightContent other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7120", Offset = "0xA5E5F20", VA = "0x18A5E7120", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E6F40", Offset = "0xA5E5D40", VA = "0x18A5E6F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA5E6EA0", Offset = "0xA5E5CA0", VA = "0x18A5E6EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public ContentTransformer Content
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0xA5E6EC0", Offset = "0xA5E5CC0", VA = "0x18A5E6EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		internal InstanceBuilder(SceneBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6DC0", Offset = "0xA5E5BC0", VA = "0x18A5E6DC0")]
		public InstanceBuilder WithName(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6D90", Offset = "0xA5E5B90", VA = "0x18A5E6D90")]
		public InstanceBuilder WithExtras(JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6D20", Offset = "0xA5E5B20", VA = "0x18A5E6D20")]
		public void Remove()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6DF0", Offset = "0xA5E5BF0", VA = "0x18A5E6DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5E5560", Offset = "0xA5E4360", VA = "0x18A5E5560")]
			public Directional()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xA5E5670", Offset = "0xA5E4470", VA = "0x18A5E5670")]
			internal Directional(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0xA5E5460", Offset = "0xA5E4260", VA = "0x18A5E5460", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xA5E55A0", Offset = "0xA5E43A0", VA = "0x18A5E55A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xE61B30", Offset = "0xE60930", VA = "0x180E61B30")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x109AA50", Offset = "0x1099850", VA = "0x18109AA50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC4D0", Offset = "0xA5EB2D0", VA = "0x18A5EC4D0")]
			public Point()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC490", Offset = "0xA5EB290", VA = "0x18A5EC490")]
			internal Point(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC2B0", Offset = "0xA5EB0B0", VA = "0x18A5EC2B0", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA5EC3B0", Offset = "0xA5EB1B0", VA = "0x18A5EC3B0")]
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
				[Cpp2IlInjected.Address(RVA = "0xE61B30", Offset = "0xE60930", VA = "0x180E61B30")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x109AA50", Offset = "0x1099850", VA = "0x18109AA50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public float InnerConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0xDC8400", Offset = "0xDC7200", VA = "0x180DC8400")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0xDC8410", Offset = "0xDC7210", VA = "0x180DC8410")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public float OuterConeAngle
			{
				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0xD78520", Offset = "0xD77320", VA = "0x180D78520")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x11205A0", Offset = "0x111F3A0", VA = "0x1811205A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3D60", Offset = "0xA5F2B60", VA = "0x18A5F3D60")]
			public Spot()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3DB0", Offset = "0xA5F2BB0", VA = "0x18A5F3DB0")]
			internal Spot(PunctualLight light)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3B60", Offset = "0xA5F2960", VA = "0x18A5F3B60", Slot = "8")]
			public override LightBuilder Clone()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3C70", Offset = "0xA5F2A70", VA = "0x18A5F3C70")]
			private Spot(Spot other)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static Vector3 LocalDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0xA539F20", Offset = "0xA538D20", VA = "0x18A539F20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xFD6BA0", Offset = "0xFD59A0", VA = "0x180FD6BA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xFD68E0", Offset = "0xFD56E0", VA = "0x180FD68E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float Intensity
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0xE61B40", Offset = "0xE60940", VA = "0x180E61B40")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0xEF82A0", Offset = "0xEF70A0", VA = "0x180EF82A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E5560", Offset = "0xA5E4360", VA = "0x18A5E5560")]
		protected LightBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA5E6F60", Offset = "0xA5E5D60", VA = "0x18A5E6F60")]
		protected LightBuilder(PunctualLight light)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract LightBuilder Clone();

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA5E55A0", Offset = "0xA5E43A0", VA = "0x18A5E55A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public <Flatten>d__52(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xA602C10", Offset = "0xA601A10", VA = "0x18A602C10", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xA6027E0", Offset = "0xA6015E0", VA = "0x18A6027E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0xA602DB0", Offset = "0xA601BB0", VA = "0x18A602DB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0xA602E00", Offset = "0xA601C00", VA = "0x18A602E00")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0xA602BD0", Offset = "0xA6019D0", VA = "0x18A602BD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA602B30", Offset = "0xA601930", VA = "0x18A602B30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<NodeBuilder> IEnumerable<NodeBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xA602B30", Offset = "0xA601930", VA = "0x18A602B30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public NodeBuilder Root
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB0F0", Offset = "0xA5E9EF0", VA = "0x18A5EB0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IReadOnlyList<NodeBuilder> VisualChildren
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IEnumerable<string> AnimationTracksNames
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA5EA560", Offset = "0xA5E9360", VA = "0x18A5EA560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool HasAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xA5EA6F0", Offset = "0xA5E94F0", VA = "0x18A5EA6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool HasTransformAnimations
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA5EA750", Offset = "0xA5E9550", VA = "0x18A5EA750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public AnimatableProperty<Vector3> Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xCF4890", Offset = "0xCF3690", VA = "0x180CF4890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AnimatableProperty<Quaternion> Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xCF4840", Offset = "0xCF3640", VA = "0x180CF4840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public AnimatableProperty<Vector3> Translation
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xCF48F0", Offset = "0xCF36F0", VA = "0x180CF48F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Matrix4x4 LocalMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xA5EADC0", Offset = "0xA5E9BC0", VA = "0x18A5EADC0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB5D0", Offset = "0xA5EA3D0", VA = "0x18A5EB5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public AffineTransform LocalTransform
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xA5EAEA0", Offset = "0xA5E9CA0", VA = "0x18A5EAEA0")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB690", Offset = "0xA5EA490", VA = "0x18A5EB690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Matrix4x4 WorldMatrix
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB3D0", Offset = "0xA5EA1D0", VA = "0x18A5EB3D0")]
			get
			{
				return default(Matrix4x4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBB20", Offset = "0xA5EA920", VA = "0x18A5EBB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		internal Matrix4x4Double LocalMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0xA5EA860", Offset = "0xA5E9660", VA = "0x18A5EA860")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal Matrix4x4Double WorldMatrixPrecise
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB110", Offset = "0xA5E9F10", VA = "0x18A5EB110")]
			get
			{
				return default(Matrix4x4Double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public AnimatableProperty<bool> Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xD15EB0", Offset = "0xD14CB0", VA = "0x180D15EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool? IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xA5EA7F0", Offset = "0xA5E95F0", VA = "0x18A5EA7F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0xA5EB4E0", Offset = "0xA5EA2E0", VA = "0x18A5EB4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9D90", Offset = "0xA5E8B90", VA = "0x18A5E9D90")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA420", Offset = "0xA5E9220", VA = "0x18A5EA420")]
		public NodeBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA380", Offset = "0xA5E9180", VA = "0x18A5EA380")]
		public NodeBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA4A0", Offset = "0xA5E92A0", VA = "0x18A5EA4A0")]
		public NodeBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7D90", Offset = "0xA5E6B90", VA = "0x18A5E7D90")]
		public Dictionary<NodeBuilder, NodeBuilder> DeepClone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7A30", Offset = "0xA5E6830", VA = "0x18A5E7A30")]
		private NodeBuilder DeepClone(IDictionary<NodeBuilder, NodeBuilder> nodeMap)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA5E79A0", Offset = "0xA5E67A0", VA = "0x18A5E79A0")]
		public NodeBuilder CreateNode([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7750", Offset = "0xA5E6550", VA = "0x18A5E7750")]
		public void AddNode(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA5E85C0", Offset = "0xA5E73C0", VA = "0x18A5E85C0")]
		public static bool IsValidArmature(IEnumerable<NodeBuilder> joints)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7E00", Offset = "0xA5E6C00", VA = "0x18A5E7E00")]
		[IteratorStateMachine(typeof(<Flatten>d__52))]
		public static IEnumerable<NodeBuilder> Flatten(NodeBuilder container)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xA5EA1D0", Offset = "0xA5E8FD0", VA = "0x18A5EA1D0")]
		private void _UseDecomposedTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9100", Offset = "0xA5E7F00", VA = "0x18A5E9100")]
		public AnimatableProperty<Vector3> UseScale()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E91C0", Offset = "0xA5E7FC0", VA = "0x18A5E91C0")]
		public CurveBuilder<Vector3> UseScale(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9030", Offset = "0xA5E7E30", VA = "0x18A5E9030")]
		public AnimatableProperty<Quaternion> UseRotation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8FD0", Offset = "0xA5E7DD0", VA = "0x18A5E8FD0")]
		public CurveBuilder<Quaternion> UseRotation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9220", Offset = "0xA5E8020", VA = "0x18A5E9220")]
		public AnimatableProperty<Vector3> UseTranslation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0xA5E92F0", Offset = "0xA5E80F0", VA = "0x18A5E92F0")]
		public CurveBuilder<Vector3> UseTranslation(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8EF0", Offset = "0xA5E7CF0", VA = "0x18A5E8EF0")]
		public void SetScaleTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8F60", Offset = "0xA5E7D60", VA = "0x18A5E8F60")]
		public void SetTranslationTrack(string track, ICurveSampler<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8E80", Offset = "0xA5E7C80", VA = "0x18A5E8E80")]
		public void SetRotationTrack(string track, ICurveSampler<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8190", Offset = "0xA5E6F90", VA = "0x18A5E8190")]
		public AffineTransform GetLocalTransform(string animationTrack, float time)
		{
			return default(AffineTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA5E83E0", Offset = "0xA5E71E0", VA = "0x18A5E83E0")]
		public Matrix4x4 GetWorldMatrix(string animationTrack, float time)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA5E7E80", Offset = "0xA5E6C80", VA = "0x18A5E7E80")]
		public Matrix4x4 GetInverseBindMatrix([Optional] Matrix4x4? meshWorldMatrix)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA5E8AA0", Offset = "0xA5E78A0", VA = "0x18A5E8AA0")]
		public void SetLocalTransform(AffineTransform newLocalTransform, bool keepChildrenInPlace)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9350", Offset = "0xA5E8150", VA = "0x18A5E9350")]
		public AnimatableProperty<bool> UseVisibility()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9D30", Offset = "0xA5E8B30", VA = "0x18A5E9D30")]
		public NodeBuilder WithLocalTranslation(Vector3 translation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9730", Offset = "0xA5E8530", VA = "0x18A5E9730")]
		public NodeBuilder WithLocalScale(Vector3 scale)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E96D0", Offset = "0xA5E84D0", VA = "0x18A5E96D0")]
		public NodeBuilder WithLocalRotation(Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9A60", Offset = "0xA5E8860", VA = "0x18A5E9A60")]
		public NodeBuilder WithLocalTranslation(string animTrack, IReadOnlyDictionary<float, Vector3> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9400", Offset = "0xA5E8200", VA = "0x18A5E9400")]
		public NodeBuilder WithLocalRotation(string animTrack, IReadOnlyDictionary<float, Quaternion> keyframes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E9790", Offset = "0xA5E8590", VA = "0x18A5E9790")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public <CreateFrom>d__31(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA619810", Offset = "0xA618610", VA = "0x18A619810", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA619360", Offset = "0xA618160", VA = "0x18A619360", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xA6198F0", Offset = "0xA6186F0", VA = "0x18A6198F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA6197D0", Offset = "0xA6185D0", VA = "0x18A6197D0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xA619730", Offset = "0xA618530", VA = "0x18A619730", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SceneBuilder> IEnumerable<SceneBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0xA619730", Offset = "0xA618530", VA = "0x18A619730", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public IEnumerable<MaterialBuilder> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA5F39C0", Offset = "0xA5F27C0", VA = "0x18A5F39C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal IEnumerable<string> AnimationTrackNames
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3890", Offset = "0xA5F2690", VA = "0x18A5F3890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA5F37F0", Offset = "0xA5F25F0", VA = "0x18A5F37F0")]
		public SceneBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF150", Offset = "0xA5EDF50", VA = "0x18A5EF150")]
		public SceneBuilder DeepClone(bool cloneArmatures = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFA70", Offset = "0xA5EE870", VA = "0x18A5EFA70")]
		[Obsolete("Use LoadDefaultScene(...); or LoadAllScenes(...) instead.", true)]
		public static SceneBuilder Load(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFA70", Offset = "0xA5EE870", VA = "0x18A5EFA70")]
		public static SceneBuilder LoadDefaultScene(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF9A0", Offset = "0xA5EE7A0", VA = "0x18A5EF9A0")]
		public static SceneBuilder[] LoadAllScenes(string filePath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED440", Offset = "0xA5EC240", VA = "0x18A5ED440")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED920", Offset = "0xA5EC720", VA = "0x18A5ED920")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED660", Offset = "0xA5EC460", VA = "0x18A5ED660")]
		public InstanceBuilder AddRigidMesh(IMeshBuilder<MaterialBuilder> mesh, NodeBuilder node, AffineTransform instanceTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA5EDCA0", Offset = "0xA5ECAA0", VA = "0x18A5EDCA0")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, Matrix4x4 meshWorldMatrix, params NodeBuilder[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE010", Offset = "0xA5ECE10", VA = "0x18A5EE010")]
		public InstanceBuilder AddSkinnedMesh(IMeshBuilder<MaterialBuilder> mesh, params (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC510", Offset = "0xA5EB310", VA = "0x18A5EC510")]
		public InstanceBuilder AddCamera(CameraBuilder camera, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC980", Offset = "0xA5EB780", VA = "0x18A5EC980")]
		public InstanceBuilder AddCamera(CameraBuilder camera, Vector3 cameraPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA5EC760", Offset = "0xA5EB560", VA = "0x18A5EC760")]
		public InstanceBuilder AddCamera(CameraBuilder camera, AffineTransform cameraTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA5ECDF0", Offset = "0xA5EBBF0", VA = "0x18A5ECDF0")]
		public InstanceBuilder AddLight(LightBuilder light, AffineTransform lightTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED010", Offset = "0xA5EBE10", VA = "0x18A5ED010")]
		public InstanceBuilder AddLight(LightBuilder light, NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA5ED260", Offset = "0xA5EC060", VA = "0x18A5ED260")]
		public InstanceBuilder AddNode(NodeBuilder node)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF780", Offset = "0xA5EE580", VA = "0x18A5EF780")]
		public IReadOnlyList<NodeBuilder> FindArmatures()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA5EE3C0", Offset = "0xA5ED1C0", VA = "0x18A5EE3C0")]
		public void ApplyBasisTransform(Matrix4x4 basisTransform, string basisNodeName = "BasisTransform")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA5EDB00", Offset = "0xA5EC900", VA = "0x18A5EDB00")]
		public IReadOnlyList<InstanceBuilder> AddScene(SceneBuilder scene, Matrix4x4 sceneTransform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0050", Offset = "0xA5EEE50", VA = "0x18A5F0050", Slot = "8")]
		public ModelRoot ToGltf2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFB10", Offset = "0xA5EE910", VA = "0x18A5EFB10")]
		public ModelRoot ToGltf2(SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA5EFBE0", Offset = "0xA5EE9E0", VA = "0x18A5EFBE0")]
		public static ModelRoot ToGltf2(IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF010", Offset = "0xA5EDE10", VA = "0x18A5EF010")]
		public static SceneBuilder[] CreateFrom(ModelRoot model)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA5EF0E0", Offset = "0xA5EDEE0", VA = "0x18A5EF0E0")]
		public static SceneBuilder CreateFrom(Scene srcScene)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA5EEF90", Offset = "0xA5EDD90", VA = "0x18A5EEF90")]
		[IteratorStateMachine(typeof(<CreateFrom>d__31))]
		public static IEnumerable<SceneBuilder> CreateFrom(IEnumerable<Scene> srcScenes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1E80", Offset = "0xA5F0C80", VA = "0x18A5F1E80")]
		private static SceneBuilder _CreateFrom(Scene srcScene, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshInstances)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA5F25D0", Offset = "0xA5F13D0", VA = "0x18A5F25D0")]
		private static Dictionary<Node, IMeshBuilder<MaterialBuilder>> _GatherMeshInstances(IEnumerable<Node> srcNodes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0BC0", Offset = "0xA5EF9C0", VA = "0x18A5F0BC0")]
		private static void _AddMeshInstances(SceneBuilder dstScene, IEnumerable<Node> srcNodes, IReadOnlyDictionary<Node, NodeBuilder> nodesDict, IReadOnlyDictionary<Node, IMeshBuilder<MaterialBuilder>> meshesDict)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0170", Offset = "0xA5EEF70", VA = "0x18A5F0170")]
		private static void _AddCameraInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA5F07D0", Offset = "0xA5EF5D0", VA = "0x18A5F07D0")]
		private static void _AddLightInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA5F0540", Offset = "0xA5EF340", VA = "0x18A5F0540")]
		private static void _AddEmptyInstances(SceneBuilder dstScene, IReadOnlyDictionary<Node, NodeBuilder> dstNodes, IReadOnlyList<Node> srcInstances)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA5F16E0", Offset = "0xA5F04E0", VA = "0x18A5F16E0")]
		private static void _CopyToNodeBuilder(NodeBuilder dstNode, Node srcNode, IDictionary<Node, NodeBuilder> nodeMapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1B20", Offset = "0xA5F0920", VA = "0x18A5F1B20")]
		private static void _CopyTransformAnimation(NodeBuilder dstNode, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F1230", Offset = "0xA5F0030", VA = "0x18A5F1230")]
		private static void _CopyMorphingAnimation(InstanceBuilder dstInst, Node srcNode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3F04820", Offset = "0x3F03620", VA = "0x183F04820")]
		internal static void _VerifyCurveConversion<T>(IAnimationSampler<T> a, IConvertibleCurve<T> b, Func<T, T, bool> equalityComparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F2B00", Offset = "0xA5F1900", VA = "0x18A5F2B00")]
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
			[Cpp2IlInjected.Address(RVA = "0xA611BE0", Offset = "0xA6109E0", VA = "0x18A611BE0")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static SceneBuilderSchema2Settings WithGpuInstancing
		{
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0xA611C00", Offset = "0xA610A00", VA = "0x18A611C00")]
			get
			{
				return default(SceneBuilderSchema2Settings);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool UseStridedBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x10A2720", Offset = "0x10A1520", VA = "0x1810A2720")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x2717CC0", Offset = "0x2716AC0", VA = "0x182717CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool CompactVertexWeights
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x1120610", Offset = "0x111F410", VA = "0x181120610")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x1120640", Offset = "0x111F440", VA = "0x181120640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public int GpuMeshInstancingMinCount
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x30B62E0", Offset = "0x30B50E0", VA = "0x1830B62E0")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x30B62F0", Offset = "0x30B50F0", VA = "0x1830B62F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool MergeBuffers
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xEBF7C0", Offset = "0xEBE5C0", VA = "0x180EBF7C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xEBF7E0", Offset = "0xEBE5E0", VA = "0x180EBF7E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BE0", Offset = "0xCE79E0", VA = "0x180CE8BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCE8C40", Offset = "0xCE7A40", VA = "0x180CE8C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA614670", Offset = "0xA613470", VA = "0x18A614670")]
		public Mesh GetMesh(IMeshBuilder<MaterialBuilder> key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA614700", Offset = "0xA613500", VA = "0x18A614700")]
		public Node GetNode(NodeBuilder key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA614790", Offset = "0xA613590", VA = "0x18A614790")]
		public static bool HasContent(Node node, bool checkTransform = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6120F0", Offset = "0xA610EF0", VA = "0x18A6120F0")]
		public void AddGeometryResources(ModelRoot root, IEnumerable<SceneBuilder> srcScenes, SceneBuilderSchema2Settings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA611C20", Offset = "0xA610A20", VA = "0x18A611C20")]
		private void AddArmatureResources(IEnumerable<SceneBuilder> srcScenes, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA613A10", Offset = "0xA612810", VA = "0x18A613A10")]
		private void CreateArmature(NodeBuilder srcNode, Func<Node> nodeFactory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA614980", Offset = "0xA613780", VA = "0x18A614980")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<SparseWeight8> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA614CE0", Offset = "0xA613AE0", VA = "0x18A614CE0")]
		public static void SetMorphAnimation(Node dstNode, AnimatableProperty<ArraySegment<float>> animation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA613870", Offset = "0xA612670", VA = "0x18A613870")]
		public void AddScene(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA613230", Offset = "0xA612030", VA = "0x18A613230")]
		private void AddMeshes(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA612C30", Offset = "0xA611A30", VA = "0x18A612C30")]
		private void AddLightsAndCameras(Scene dstScene, SceneBuilder srcScene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA615150", Offset = "0xA613F50", VA = "0x18A615150")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBF7B0", Offset = "0xEBE5B0", VA = "0x180EBF7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public AffineTransform? Child
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x6858FE0", Offset = "0x6857DE0", VA = "0x186858FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA6180F0", Offset = "0xA616EF0", VA = "0x18A6180F0")]
		public static implicit operator TransformChainBuilder(NodeBuilder node)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA618140", Offset = "0xA616F40", VA = "0x18A618140")]
		public static implicit operator TransformChainBuilder(AffineTransform transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6181A0", Offset = "0xA616FA0", VA = "0x18A6181A0")]
		public static implicit operator TransformChainBuilder(Matrix4x4 transform)
		{
			return default(TransformChainBuilder);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA617F30", Offset = "0xA616D30", VA = "0x18A617F30")]
		public TransformChainBuilder(AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA617F00", Offset = "0xA616D00", VA = "0x18A617F00")]
		public TransformChainBuilder(NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA618010", Offset = "0xA616E10", VA = "0x18A618010")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
			internal DeepCloneContext(IReadOnlyDictionary<NodeBuilder, NodeBuilder> nmap)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA60A490", Offset = "0xA609290", VA = "0x18A60A490")]
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
			[Cpp2IlInjected.Address(RVA = "0xA60A410", Offset = "0xA609210", VA = "0x18A60A410")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public AnimatableProperty<ArraySegment<float>> Morphings
		{
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool HasRenderableContent
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xA60A3C0", Offset = "0xA6091C0", VA = "0x18A60A3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA60A2B0", Offset = "0xA6090B0", VA = "0x18A60A2B0")]
		protected ContentTransformer(object content)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ContentTransformer DeepClone(DeepCloneContext args);

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA60A170", Offset = "0xA608F70", VA = "0x18A60A170")]
		protected ContentTransformer(ContentTransformer other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA609D50", Offset = "0xA608B50", VA = "0x18A609D50")]
		public IMeshBuilder<MaterialBuilder> GetGeometryAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA609CD0", Offset = "0xA608AD0", VA = "0x18A609CD0")]
		public CameraBuilder GetCameraAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA609DB0", Offset = "0xA608BB0", VA = "0x18A609DB0")]
		public LightBuilder GetLightAsset()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract NodeBuilder GetArmatureRoot();

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA60A040", Offset = "0xA608E40", VA = "0x18A60A040")]
		public AnimatableProperty<ArraySegment<float>> UseMorphing()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA609E30", Offset = "0xA608C30", VA = "0x18A609E30")]
		public CurveBuilder<ArraySegment<float>> UseMorphing(string animationTrack)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract Matrix4x4 GetPoseWorldMatrix();

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA609B00", Offset = "0xA608900", VA = "0x18A609B00")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public NodeBuilder ParentNode
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AffineTransform ChildTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x93F4970", Offset = "0x93F3770", VA = "0x1893F4970")]
			get
			{
				return default(AffineTransform);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x93F49E0", Offset = "0x93F37E0", VA = "0x1893F49E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA60AAA0", Offset = "0xA6098A0", VA = "0x18A60AAA0")]
		internal FixedTransformer(object content, AffineTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA60A900", Offset = "0xA609700", VA = "0x18A60A900")]
		internal FixedTransformer(object content, NodeBuilder parentNode, AffineTransform childTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA60A960", Offset = "0xA609760", VA = "0x18A60A960")]
		protected FixedTransformer(FixedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA60A590", Offset = "0xA609390", VA = "0x18A60A590", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA60A700", Offset = "0xA609500", VA = "0x18A60A700", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA60A720", Offset = "0xA609520", VA = "0x18A60A720", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FF8D00", Offset = "0x4FF7B00", VA = "0x184FF8D00", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x97B07B0", Offset = "0x97AF5B0", VA = "0x1897B07B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x18A4370", Offset = "0x18A3170", VA = "0x1818A4370", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x97B0650", Offset = "0x97AF450", VA = "0x1897B0650", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public NodeBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA611AC0", Offset = "0xA6108C0", VA = "0x18A611AC0")]
		internal RigidTransformer(object content, NodeBuilder node)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA611B00", Offset = "0xA610900", VA = "0x18A611B00")]
		protected RigidTransformer(RigidTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA611800", Offset = "0xA610600", VA = "0x18A611800", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA611920", Offset = "0xA610720", VA = "0x18A611920", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA611940", Offset = "0xA610740", VA = "0x18A611940", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA611990", Offset = "0xA610790", VA = "0x18A611990", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "5")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public override JsonNode Extras
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA6169C0", Offset = "0xA6157C0", VA = "0x18A6169C0")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA616AA0", Offset = "0xA6158A0", VA = "0x18A616AA0")]
		internal SkinnedTransformer(IMeshBuilder<MaterialBuilder> mesh, (NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA616550", Offset = "0xA615350", VA = "0x18A616550")]
		protected SkinnedTransformer(SkinnedTransformer other, DeepCloneContext args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA615260", Offset = "0xA614060", VA = "0x18A615260", Slot = "4")]
		public override ContentTransformer DeepClone(DeepCloneContext args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA615AC0", Offset = "0xA6148C0", VA = "0x18A615AC0")]
		private void SetJoints(AffineTransform meshWorldTransform, NodeBuilder[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA615D90", Offset = "0xA614B90", VA = "0x18A615D90")]
		private void SetJoints((NodeBuilder Joint, Matrix4x4 InverseBindMatrix)[] joints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA615420", Offset = "0xA614220", VA = "0x18A615420")]
		public (NodeBuilder, Matrix4x4)[] GetJointBindings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA6152D0", Offset = "0xA6140D0", VA = "0x18A6152D0", Slot = "9")]
		public override NodeBuilder GetArmatureRoot()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA615920", Offset = "0xA614720", VA = "0x18A615920")]
		public IGeometryTransform GetWorldTransformer(string animationTrack, float time)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA6157C0", Offset = "0xA6145C0", VA = "0x18A6157C0", Slot = "10")]
		public override Matrix4x4 GetPoseWorldMatrix()
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA616190", Offset = "0xA614F90", VA = "0x18A616190", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public <CreateFrom>d__2(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA618FE0", Offset = "0xA617DE0", VA = "0x18A618FE0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA618280", Offset = "0xA617080", VA = "0x18A618280", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA619270", Offset = "0xA618070", VA = "0x18A619270")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA6192C0", Offset = "0xA6180C0", VA = "0x18A6192C0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xA619310", Offset = "0xA618110", VA = "0x18A619310")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA618FA0", Offset = "0xA617DA0", VA = "0x18A618FA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA618EF0", Offset = "0xA617CF0", VA = "0x18A618EF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Schema2SceneBuilder.IOperator<Scene>> IEnumerable<Schema2SceneBuilder.IOperator<Scene>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA618EF0", Offset = "0xA617CF0", VA = "0x18A618EF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6259E0", Offset = "0xA6247E0", VA = "0x18A6259E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA6250F0", Offset = "0xA623EF0", VA = "0x18A6250F0")]
		[IteratorStateMachine(typeof(<CreateFrom>d__2))]
		public static IEnumerable<Schema2SceneBuilder.IOperator<Scene>> CreateFrom(IEnumerable<FixedTransformer> instances, int gpuMinCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA6258D0", Offset = "0xA6246D0", VA = "0x18A6258D0")]
		private _MeshInstancing(NodeBuilder parentNode, IEnumerable<FixedTransformer> children, int gpuMinCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA624E60", Offset = "0xA623C60", VA = "0x18A624E60", Slot = "4")]
		public void ApplyTo(Scene dstScene, Schema2SceneBuilder context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xA625170", Offset = "0xA623F70", VA = "0x18A625170")]
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
			[Cpp2IlInjected.Address(RVA = "0xA624E00", Offset = "0xA623C00", VA = "0x18A624E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
		public _FixedIntance(FixedTransformer fixedXformer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA624C50", Offset = "0xA623A50", VA = "0x18A624C50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA624A80", Offset = "0xA623880", VA = "0x18A624A80", Slot = "4")]
			public bool Equals(ChannelBuilder x, ChannelBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xA619E80", Offset = "0xA618C80", VA = "0x18A619E80", Slot = "5")]
			public int GetHashCode(ChannelBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public KnownChannel Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330")]
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
			[Cpp2IlInjected.Address(RVA = "0xA607FB0", Offset = "0xA606DB0", VA = "0x18A607FB0")]
			get
			{
				return default(Vector4);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA607FF0", Offset = "0xA606DF0", VA = "0x18A607FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public MaterialValue.Collection Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA607F60", Offset = "0xA606D60", VA = "0x18A607F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA607C90", Offset = "0xA606A90", VA = "0x18A607C90")]
		private string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA607D70", Offset = "0xA606B70", VA = "0x18A607D70")]
		internal ChannelBuilder(MaterialBuilder parent, KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA6079B0", Offset = "0xA6067B0", VA = "0x18A6079B0")]
		public static bool AreEqualByContent(ChannelBuilder x, ChannelBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA607B20", Offset = "0xA606920", VA = "0x18A607B20")]
		public static int GetContentHashCode(ChannelBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA607BA0", Offset = "0xA6069A0", VA = "0x18A607BA0")]
		public TextureBuilder GetValidTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA607BC0", Offset = "0xA6069C0", VA = "0x18A607BC0")]
		public TextureBuilder UseTexture()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xD12D40", Offset = "0xD11B40", VA = "0x180D12D40")]
		public void RemoveTexture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA607AA0", Offset = "0xA6068A0", VA = "0x18A607AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xEDC830", Offset = "0xEDB630", VA = "0x180EDC830")]
			[CompilerGenerated]
			get
			{
				return default(MemoryImage);
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x4FF58D0", Offset = "0x4FF46D0", VA = "0x184FF58D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public string AlternateWriteFileName
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA60AFA0", Offset = "0xA609DA0", VA = "0x18A60AFA0")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA60B0E0", Offset = "0xA609EE0", VA = "0x18A60B0E0")]
		public static implicit operator ImageBuilder(ArraySegment<byte> image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA60B290", Offset = "0xA60A090", VA = "0x18A60B290")]
		public static implicit operator ImageBuilder(byte[] image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA60B1C0", Offset = "0xA609FC0", VA = "0x18A60B1C0")]
		public static implicit operator ImageBuilder(string filePath)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA60B360", Offset = "0xA60A160", VA = "0x18A60B360")]
		public static implicit operator ImageBuilder(MemoryImage content)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA60ACA0", Offset = "0xA609AA0", VA = "0x18A60ACA0")]
		public static ImageBuilder From(MemoryImage content, [Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA60AD60", Offset = "0xA609B60", VA = "0x18A60AD60")]
		public static ImageBuilder From(MemoryImage content, string name, JsonNode extras)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA60B060", Offset = "0xA609E60", VA = "0x18A60B060")]
		private ImageBuilder(MemoryImage content, string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA60AC20", Offset = "0xA609A20", VA = "0x18A60AC20")]
		internal ImageBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA60B0A0", Offset = "0xA609EA0", VA = "0x18A60B0A0")]
		private ImageBuilder(ImageBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA60AAE0", Offset = "0xA6098E0", VA = "0x18A60AAE0")]
		public static bool AreEqualByContent(ImageBuilder x, ImageBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xA60AE30", Offset = "0xA609C30", VA = "0x18A60AE30")]
		public static int GetContentHashCode(ImageBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA60AEC0", Offset = "0xA609CC0", VA = "0x18A60AEC0")]
		public static bool IsEmpty(ImageBuilder ib)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA60AF30", Offset = "0xA609D30", VA = "0x18A60AF30")]
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
			[Cpp2IlInjected.Address(RVA = "0xA624A00", Offset = "0xA623800", VA = "0x18A624A00", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA624AA0", Offset = "0xA6238A0", VA = "0x18A624AA0", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x171E810", Offset = "0x171D610", VA = "0x18171E810", Slot = "4")]
			public bool Equals(MaterialBuilder x, MaterialBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x7838920", Offset = "0x7837720", VA = "0x187838920", Slot = "5")]
			public int GetHashCode(MaterialBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16220", Offset = "0xD15020", VA = "0x180D16220")]
			[CompilerGenerated]
			get
			{
				return default(AlphaMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xDE2FE0", Offset = "0xDE1DE0", VA = "0x180DE2FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float AlphaCutoff
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xD16210", Offset = "0xD15010", VA = "0x180D16210")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xD15F40", Offset = "0xD14D40", VA = "0x180D15F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool DoubleSided
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0xF423C0", Offset = "0xF411C0", VA = "0x180F423C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0xF41D20", Offset = "0xF40B20", VA = "0x180F41D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string ShaderStyle
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0xA60F530", Offset = "0xA60E330", VA = "0x18A60F530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float IndexOfRefraction
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xD37FC0", Offset = "0xD36DC0", VA = "0x180D37FC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x14EA900", Offset = "0x14E9700", VA = "0x1814EA900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float Dispersion
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x1216D60", Offset = "0x1215B60", VA = "0x181216D60")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x2A9FD80", Offset = "0x2A9EB80", VA = "0x182A9FD80")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MaterialBuilder CompatibilityFallback
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA60F490", Offset = "0xA60E290", VA = "0x18A60F490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public static IEqualityComparer<MaterialBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0xA60F3F0", Offset = "0xA60E1F0", VA = "0x18A60F3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public static IEqualityComparer<MaterialBuilder> ReferenceComparer
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA60F440", Offset = "0xA60E240", VA = "0x18A60F440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA60E9E0", Offset = "0xA60D7E0", VA = "0x18A60E9E0")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xA60B870", Offset = "0xA60A670", VA = "0x18A60B870")]
		public static MaterialBuilder CreateDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA60F330", Offset = "0xA60E130", VA = "0x18A60F330")]
		public MaterialBuilder([Optional] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA60BEE0", Offset = "0xA60ACE0", VA = "0x18A60BEE0", Slot = "8")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA60B810", Offset = "0xA60A610", VA = "0x18A60B810")]
		public MaterialBuilder Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA60EFE0", Offset = "0xA60DDE0", VA = "0x18A60EFE0")]
		public MaterialBuilder(MaterialBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xCE95C0", Offset = "0xCE83C0", VA = "0x180CE95C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCEBDA0", Offset = "0xCEABA0", VA = "0x180CEBDA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA60B410", Offset = "0xA60A210", VA = "0x18A60B410")]
		public static bool AreEqualByContent(MaterialBuilder x, MaterialBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA60BB70", Offset = "0xA60A970", VA = "0x18A60BB70")]
		public static int GetContentHashCode(MaterialBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA60ECA0", Offset = "0xA60DAA0", VA = "0x18A60ECA0")]
		private void _SetShader(string shader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA60BA40", Offset = "0xA60A840", VA = "0x18A60BA40")]
		[Obsolete("Use GetChannel with KnownChannel whenever possible")]
		public ChannelBuilder GetChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA60C0C0", Offset = "0xA60AEC0", VA = "0x18A60C0C0")]
		[Obsolete("Use UseChannel with KnownChannel whenever possible")]
		public ChannelBuilder UseChannel(string channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA60B970", Offset = "0xA60A770", VA = "0x18A60B970")]
		public ChannelBuilder GetChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xA60BF40", Offset = "0xA60AD40", VA = "0x18A60BF40")]
		public ChannelBuilder UseChannel(KnownChannel channelKey)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA60BDE0", Offset = "0xA60ABE0", VA = "0x18A60BDE0")]
		public void RemoveChannel(KnownChannel key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA60C1F0", Offset = "0xA60AFF0", VA = "0x18A60C1F0")]
		internal void ValidateForSchema2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA60E1B0", Offset = "0xA60CFB0", VA = "0x18A60E1B0")]
		public MaterialBuilder WithShader(string shader)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA60E790", Offset = "0xA60D590", VA = "0x18A60E790")]
		public MaterialBuilder WithUnlitShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA60DD30", Offset = "0xA60CB30", VA = "0x18A60DD30")]
		public MaterialBuilder WithMetallicRoughnessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA60E360", Offset = "0xA60D160", VA = "0x18A60E360")]
		[Obsolete("SpecularGlossiness has been deprecated by Khronos")]
		public MaterialBuilder WithSpecularGlossinessShader()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA60C850", Offset = "0xA60B650", VA = "0x18A60C850")]
		public MaterialBuilder WithAlpha(AlphaMode alphaMode = AlphaMode.OPAQUE, float alphaCutoff = 0.5f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x9021900", Offset = "0x9020700", VA = "0x189021900")]
		public MaterialBuilder WithDoubleSide(bool enabled)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA60CDB0", Offset = "0xA60BBB0", VA = "0x18A60CDB0")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA60CCD0", Offset = "0xA60BAD0", VA = "0x18A60CCD0")]
		[Obsolete("Use WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, Object parameter)")]
		public MaterialBuilder WithChannelParam(string channelKey, Vector4 parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA60CB90", Offset = "0xA60B990", VA = "0x18A60CB90")]
		[Obsolete("Use WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)")]
		public MaterialBuilder WithChannelImage(string channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA60CD20", Offset = "0xA60BB20", VA = "0x18A60CD20")]
		public MaterialBuilder WithChannelParam(KnownChannel channelKey, KnownProperty propertyName, object parameter)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA60CBE0", Offset = "0xA60B9E0", VA = "0x18A60CBE0")]
		public MaterialBuilder WithChannelImage(KnownChannel channelKey, ImageBuilder primaryImage)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA60D650", Offset = "0xA60C450", VA = "0x18A60D650")]
		public MaterialBuilder WithFallback(MaterialBuilder fallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA60D9A0", Offset = "0xA60C7A0", VA = "0x18A60D9A0")]
		public MaterialBuilder WithMetallicRoughnessFallback(ImageBuilder baseColor, Vector4? rgba, ImageBuilder metallicRoughness, float? metallic, float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA60E030", Offset = "0xA60CE30", VA = "0x18A60E030")]
		public MaterialBuilder WithNormal(ImageBuilder imageFile, float scale = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA60E0F0", Offset = "0xA60CEF0", VA = "0x18A60E0F0")]
		public MaterialBuilder WithOcclusion(ImageBuilder imageFile, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA60D4E0", Offset = "0xA60C2E0", VA = "0x18A60D4E0")]
		public MaterialBuilder WithEmissive(Vector3 rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA60D320", Offset = "0xA60C120", VA = "0x18A60D320")]
		public MaterialBuilder WithEmissive(ImageBuilder imageFile, [Optional] Vector3? rgb, float strength = 1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA60C9B0", Offset = "0xA60B7B0", VA = "0x18A60C9B0")]
		public MaterialBuilder WithBaseColor(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA60CA70", Offset = "0xA60B870", VA = "0x18A60CA70")]
		public MaterialBuilder WithBaseColor(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA60DED0", Offset = "0xA60CCD0", VA = "0x18A60DED0")]
		public MaterialBuilder WithMetallicRoughness([Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA60DD70", Offset = "0xA60CB70", VA = "0x18A60DD70")]
		public MaterialBuilder WithMetallicRoughness(ImageBuilder imageFile, [Optional] float? metallic, [Optional] float? roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA60CE00", Offset = "0xA60BC00", VA = "0x18A60CE00")]
		public MaterialBuilder WithClearCoatNormal(ImageBuilder imageFile)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xA60CEF0", Offset = "0xA60BCF0", VA = "0x18A60CEF0")]
		public MaterialBuilder WithClearCoat(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xA60CE30", Offset = "0xA60BC30", VA = "0x18A60CE30")]
		public MaterialBuilder WithClearCoatRoughness(ImageBuilder imageFile, float roughness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA60E6D0", Offset = "0xA60D4D0", VA = "0x18A60E6D0")]
		public MaterialBuilder WithTransmission(ImageBuilder imageFile, float intensity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA60D080", Offset = "0xA60BE80", VA = "0x18A60D080")]
		public MaterialBuilder WithDiffuseTransmissionFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA60CFB0", Offset = "0xA60BDB0", VA = "0x18A60CFB0")]
		public MaterialBuilder WithDiffuseTransmissionColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA60E1D0", Offset = "0xA60CFD0", VA = "0x18A60E1D0")]
		public MaterialBuilder WithSpecularColor(ImageBuilder imageFile, [Optional] Vector3? rgb)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA60E2A0", Offset = "0xA60D0A0", VA = "0x18A60E2A0")]
		public MaterialBuilder WithSpecularFactor(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA60E920", Offset = "0xA60D720", VA = "0x18A60E920")]
		public MaterialBuilder WithVolumeThickness(ImageBuilder imageFile, float factor)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA60E7D0", Offset = "0xA60D5D0", VA = "0x18A60E7D0")]
		public MaterialBuilder WithVolumeAttenuation(Vector3 color, float distance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA60D850", Offset = "0xA60C650", VA = "0x18A60D850")]
		public MaterialBuilder WithIridescence(ImageBuilder imageFile, float factor = 0f, float ior = 1.3f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA60D700", Offset = "0xA60C500", VA = "0x18A60D700")]
		public MaterialBuilder WithIridescenceThickness(ImageBuilder imageFile, float min = 100f, float max = 400f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA60C860", Offset = "0xA60B660", VA = "0x18A60C860")]
		public MaterialBuilder WithAnisotropy(ImageBuilder imageFile, float strength = 0f, float rotation = 0f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA60D140", Offset = "0xA60BF40", VA = "0x18A60D140")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(Vector4 rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA60D200", Offset = "0xA60C000", VA = "0x18A60D200")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithBaseColor instead.")]
		public MaterialBuilder WithDiffuse(ImageBuilder imageFile, [Optional] Vector4? rgba)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA60E540", Offset = "0xA60D340", VA = "0x18A60E540")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness([Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA60E3A0", Offset = "0xA60D1A0", VA = "0x18A60E3A0")]
		[Obsolete("This channel is used by KHR_materials_pbrSpecularGlossiness extension, which has been deprecated by Khronos; use WithSpecularColor instead.")]
		public MaterialBuilder WithSpecularGlossiness(ImageBuilder imageFile, [Optional] Vector3? specular, [Optional] float? glossiness)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA60EB40", Offset = "0xA60D940", VA = "0x18A60EB40")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110")]
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
				[Cpp2IlInjected.Address(RVA = "0xA626040", Offset = "0xA624E40", VA = "0x18A626040")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public MaterialValue Value
			{
				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0xFF4200", Offset = "0xFF3000", VA = "0x180FF4200")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x600040F")]
				[Cpp2IlInjected.Address(RVA = "0xA6260E0", Offset = "0xA624EE0", VA = "0x18A6260E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xA625DD0", Offset = "0xA624BD0", VA = "0x18A625DD0")]
			internal _Property(KnownProperty key, float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA625E90", Offset = "0xA624C90", VA = "0x18A625E90")]
			internal _Property(KnownProperty key, Vector2 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA625D00", Offset = "0xA624B00", VA = "0x18A625D00")]
			internal _Property(KnownProperty key, Vector3 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA625F60", Offset = "0xA624D60", VA = "0x18A625F60")]
			internal _Property(KnownProperty key, Vector4 value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA625BD0", Offset = "0xA6249D0", VA = "0x18A625BD0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xA625B60", Offset = "0xA624960", VA = "0x18A625B60", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA625A30", Offset = "0xA624830", VA = "0x18A625A30", Slot = "4")]
			public bool Equals(_Property other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA6260A0", Offset = "0xA624EA0", VA = "0x18A6260A0")]
			public static bool operator ==(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xA6260C0", Offset = "0xA624EC0", VA = "0x18A6260C0")]
			public static bool operator !=(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xA625A30", Offset = "0xA624830", VA = "0x18A625A30")]
			public static bool AreEqual(_Property a, _Property b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA625C10", Offset = "0xA624A10", VA = "0x18A625C10")]
			public void SetDefault()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xA625C20", Offset = "0xA624A20", VA = "0x18A625C20", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xA608F30", Offset = "0xA607D30", VA = "0x18A608F30", Slot = "6")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0xA609920", Offset = "0xA608720", VA = "0x18A609920")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public MaterialValue this[string keyName]
			{
				[Cpp2IlInjected.Token(Token = "0x6000418")]
				[Cpp2IlInjected.Address(RVA = "0xA608DB0", Offset = "0xA607BB0", VA = "0x18A608DB0")]
				get
				{
					return default(MaterialValue);
				}
				[Cpp2IlInjected.Token(Token = "0x6000419")]
				[Cpp2IlInjected.Address(RVA = "0xA609840", Offset = "0xA608640", VA = "0x18A609840")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public IEnumerable<KnownProperty> Keys
			{
				[Cpp2IlInjected.Token(Token = "0x600041A")]
				[Cpp2IlInjected.Address(RVA = "0xA609020", Offset = "0xA607E20", VA = "0x18A609020", Slot = "7")]
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
				[Cpp2IlInjected.Address(RVA = "0xA609140", Offset = "0xA607F40", VA = "0x18A609140", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x282F4B0", Offset = "0x282E2B0", VA = "0x18282F4B0", Slot = "9")]
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
				[Cpp2IlInjected.Address(RVA = "0xA608C00", Offset = "0xA607A00", VA = "0x18A608C00")]
				get
				{
					return default(Vector4);
				}
				[Cpp2IlInjected.Token(Token = "0x600041E")]
				[Cpp2IlInjected.Address(RVA = "0xA609260", Offset = "0xA608060", VA = "0x18A609260")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xA608AC0", Offset = "0xA6078C0", VA = "0x18A608AC0")]
			private string _GetDebuggerDisplay()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
			internal Collection(_Property[] properties)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xA608790", Offset = "0xA607590", VA = "0x18A608790", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xA608020", Offset = "0xA606E20", VA = "0x18A608020")]
			public static bool AreEqual(Collection x, Collection y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA6082D0", Offset = "0xA6070D0", VA = "0x18A6082D0", Slot = "4")]
			public bool ContainsKey(KnownProperty key)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xA608990", Offset = "0xA607790", VA = "0x18A608990", Slot = "5")]
			public bool TryGetValue(KnownProperty key, [Out] MaterialValue value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA608650", Offset = "0xA607450", VA = "0x18A608650", Slot = "10")]
			public IEnumerator<KeyValuePair<KnownProperty, MaterialValue>> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA608850", Offset = "0xA607650", VA = "0x18A608850", Slot = "11")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0xA608800", Offset = "0xA607600", VA = "0x18A608800")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xA6083A0", Offset = "0xA6071A0", VA = "0x18A6083A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public <_CreateDefaultProperties>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xA61B4A0", Offset = "0xA61A2A0", VA = "0x18A61B4A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xA61BF70", Offset = "0xA61AD70", VA = "0x18A61BF70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA61BED0", Offset = "0xA61ACD0", VA = "0x18A61BED0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<_Property> IEnumerable<_Property>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xA61BED0", Offset = "0xA61ACD0", VA = "0x18A61BED0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA60FFD0", Offset = "0xA60EDD0", VA = "0x18A60FFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA60F5A0", Offset = "0xA60E3A0", VA = "0x18A60F5A0")]
		internal static Collection CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA60FED0", Offset = "0xA60ECD0", VA = "0x18A60FED0")]
		[IteratorStateMachine(typeof(<_CreateDefaultProperties>d__1))]
		private static IEnumerable<_Property> _CreateDefaultProperties(KnownChannel key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA6103D0", Offset = "0xA60F1D0", VA = "0x18A6103D0")]
		public static implicit operator MaterialValue(float value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xA610340", Offset = "0xA60F140", VA = "0x18A610340")]
		public static implicit operator MaterialValue(Vector2 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA610370", Offset = "0xA60F170", VA = "0x18A610370")]
		public static implicit operator MaterialValue(Vector3 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA6103A0", Offset = "0xA60F1A0", VA = "0x18A6103A0")]
		public static implicit operator MaterialValue(Vector4 value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA60F6B0", Offset = "0xA60E4B0", VA = "0x18A60F6B0")]
		public static MaterialValue CreateFrom(object value)
		{
			return default(MaterialValue);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA60FFB0", Offset = "0xA60EDB0", VA = "0x18A60FFB0")]
		private MaterialValue(float x)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xA60FF90", Offset = "0xA60ED90", VA = "0x18A60FF90")]
		private MaterialValue(float x, float y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xA60FF40", Offset = "0xA60ED40", VA = "0x18A60FF40")]
		private MaterialValue(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xA60FF60", Offset = "0xA60ED60", VA = "0x18A60FF60")]
		private MaterialValue(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xA60FA90", Offset = "0xA60E890", VA = "0x18A60FA90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xA60F990", Offset = "0xA60E790", VA = "0x18A60F990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xA60F540", Offset = "0xA60E340", VA = "0x18A60F540", Slot = "4")]
		public bool Equals(MaterialValue other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA60F540", Offset = "0xA60E340", VA = "0x18A60F540")]
		public static bool operator ==([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6103F0", Offset = "0xA60F1F0", VA = "0x18A6103F0")]
		public static bool operator !=([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xA60F540", Offset = "0xA60E340", VA = "0x18A60F540")]
		public static bool AreEqual([In] MaterialValue a, [In] MaterialValue b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA610160", Offset = "0xA60EF60", VA = "0x18A610160")]
		public static explicit operator float(MaterialValue value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA6102C0", Offset = "0xA60F0C0", VA = "0x18A6102C0")]
		public static explicit operator Vector2(MaterialValue value)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xA610240", Offset = "0xA60F040", VA = "0x18A610240")]
		public static explicit operator Vector3(MaterialValue value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xA6101C0", Offset = "0xA60EFC0", VA = "0x18A6101C0")]
		public static explicit operator Vector4(MaterialValue value)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA60FB80", Offset = "0xA60E980", VA = "0x18A60FB80")]
		public object ToTypeless()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA60FB40", Offset = "0xA60E940", VA = "0x18A60FB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA60FE60", Offset = "0xA60EC60", VA = "0x18A60FE60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA624A60", Offset = "0xA623860", VA = "0x18A624A60", Slot = "4")]
			public bool Equals(TextureBuilder x, TextureBuilder y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA624AF0", Offset = "0xA6238F0", VA = "0x18A624AF0", Slot = "5")]
			public int GetHashCode(TextureBuilder obj)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD03CD0", Offset = "0xD02AD0", VA = "0x180D03CD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xD5F4B0", Offset = "0xD5E2B0", VA = "0x180D5F4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public TextureMipMapFilter MinFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xD03CE0", Offset = "0xD02AE0", VA = "0x180D03CE0")]
			[CompilerGenerated]
			get
			{
				return default(TextureMipMapFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xD5F4C0", Offset = "0xD5E2C0", VA = "0x180D5F4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public TextureInterpolationFilter MagFilter
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xD5E1B0", Offset = "0xD5CFB0", VA = "0x180D5E1B0")]
			[CompilerGenerated]
			get
			{
				return default(TextureInterpolationFilter);
			}
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xD5F4A0", Offset = "0xD5E2A0", VA = "0x180D5F4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public TextureWrapMode WrapS
		{
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x1670D10", Offset = "0x166FB10", VA = "0x181670D10")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x1C6B6B0", Offset = "0x1C6A4B0", VA = "0x181C6B6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public TextureWrapMode WrapT
		{
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0xEE5F80", Offset = "0xEE4D80", VA = "0x180EE5F80")]
			[CompilerGenerated]
			get
			{
				return default(TextureWrapMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x1AA2FA0", Offset = "0x1AA1DA0", VA = "0x181AA2FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public ImageBuilder PrimaryImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA617B50", Offset = "0xA616950", VA = "0x18A617B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public ImageBuilder FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA617A30", Offset = "0xA616830", VA = "0x18A617A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public TextureTransformBuilder Transform
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public static IEqualityComparer<TextureBuilder> ContentComparer
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA6179E0", Offset = "0xA6167E0", VA = "0x18A6179E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0xA617640", Offset = "0xA616440", VA = "0x18A617640")]
		internal string _DebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA617900", Offset = "0xA616700", VA = "0x18A617900")]
		internal TextureBuilder(ChannelBuilder parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA616B50", Offset = "0xA615950", VA = "0x18A616B50")]
		public static bool AreEqualByContent(TextureBuilder x, TextureBuilder y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xA617020", Offset = "0xA615E20", VA = "0x18A617020")]
		public static int GetContentHashCode(TextureBuilder x)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xA616DD0", Offset = "0xA615BD0", VA = "0x18A616DD0")]
		internal void CopyTo(TextureBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0xA6171D0", Offset = "0xA615FD0", VA = "0x18A6171D0")]
		public TextureBuilder WithCoordinateSet(int cset)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0xA617300", Offset = "0xA616100", VA = "0x18A617300")]
		public TextureBuilder WithPrimaryImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA6171E0", Offset = "0xA615FE0", VA = "0x18A6171E0")]
		public TextureBuilder WithFallbackImage(ImageBuilder image)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xA6173F0", Offset = "0xA6161F0", VA = "0x18A6173F0")]
		public TextureBuilder WithSampler(TextureWrapMode ws, TextureWrapMode wt, TextureMipMapFilter min = TextureMipMapFilter.DEFAULT, TextureInterpolationFilter mag = TextureInterpolationFilter.DEFAULT)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xA617410", Offset = "0xA616210", VA = "0x18A617410")]
		public TextureBuilder WithTransform(float offsetX, float offsetY, float scaleX = 1f, float scaleY = 1f, float rotation = 0f, [Optional] int? coordSetOverride)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xA617550", Offset = "0xA616350", VA = "0x18A617550")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A6AE0", Offset = "0x32A58E0", VA = "0x1832A6AE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xE7DCE0", Offset = "0xE7CAE0", VA = "0x180E7DCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public Vector2 Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x1E7E310", Offset = "0x1E7D110", VA = "0x181E7E310")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xDDD2F0", Offset = "0xDDC0F0", VA = "0x180DDD2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public float Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xD4D5A0", Offset = "0xD4C3A0", VA = "0x180D4D5A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x10A2ED0", Offset = "0x10A1CD0", VA = "0x1810A2ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int? CoordinateSetOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x13EFA00", Offset = "0x13EE800", VA = "0x1813EFA00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x10A31E0", Offset = "0x10A1FE0", VA = "0x1810A31E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		internal bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xA617E30", Offset = "0xA616C30", VA = "0x18A617E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xA617DA0", Offset = "0xA616BA0", VA = "0x18A617DA0")]
		internal TextureTransformBuilder(Vector2 offset, Vector2 scale, float rotation = 0f, [Optional] int? coordSetOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0xA617CB0", Offset = "0xA616AB0", VA = "0x18A617CB0")]
		internal TextureTransformBuilder(TextureTransformBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA617B60", Offset = "0xA616960", VA = "0x18A617B60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA610650", Offset = "0xA60F450", VA = "0x18A610650", Slot = "2")]
			public override readonly int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA6105A0", Offset = "0xA60F3A0", VA = "0x18A6105A0", Slot = "0")]
			public override readonly bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA610450", Offset = "0xA60F250", VA = "0x18A610450", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA61FB20", Offset = "0xA61E920", VA = "0x18A61FB20")]
		public void AddTriangle(Material material, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> a, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> b, [In] VertexBuilder<VertexPositionNormal, VertexTexture1, VertexEmpty> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA6202E0", Offset = "0xA61F0E0", VA = "0x18A6202E0")]
		public void WriteFiles(string filePath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xA61FC60", Offset = "0xA61EA60", VA = "0x18A61FC60")]
		public IReadOnlyDictionary<string, ArraySegment<byte>> GetFiles(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xA6205B0", Offset = "0xA61F3B0", VA = "0x18A6205B0")]
		private Dictionary<string, Action<Stream>> _GetFileGenerators(string baseName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xA620990", Offset = "0xA61F790", VA = "0x18A620990")]
		private static Dictionary<Material, string> _GetMaterialsFileGenerator(IDictionary<string, Action<Stream>> fileGenerators, string baseName, IEnumerable<Material> materials)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xA6229C0", Offset = "0xA6217C0", VA = "0x18A6229C0")]
		private static void _WriteMaterialsFile(Stream fs, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0xA622B10", Offset = "0xA621910", VA = "0x18A622B10")]
		private static void _WriteMaterialsFile(StreamWriter sw, IEnumerable<Material> materials, Dictionary<Material, string> mmap, Dictionary<MemoryImage, string> imageNameByImage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xA621390", Offset = "0xA620190", VA = "0x18A621390")]
		private void _WriteGeometryFile(Stream s, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xA6214C0", Offset = "0xA6202C0", VA = "0x18A6214C0")]
		private void _WriteGeometryFile(StreamWriter sw, IReadOnlyDictionary<Material, string> materials, string mtlLib)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xA61F4D0", Offset = "0xA61E2D0", VA = "0x18A61F4D0")]
		public void AddModel(ModelRoot model)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA61F7E0", Offset = "0xA61E5E0", VA = "0x18A61F7E0")]
		public void AddModel(ModelRoot model, Animation animation, float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA6200A0", Offset = "0xA61EEA0", VA = "0x18A6200A0")]
		private static Material GetMaterialFromTriangle(SharpGLTF.Schema2.Material srcMaterial)
		{
			return default(Material);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xA6235F0", Offset = "0xA6223F0", VA = "0x18A6235F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA624450", Offset = "0xA623250", VA = "0x18A624450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xA6236A0", Offset = "0xA6224A0", VA = "0x18A6236A0")]
		public static ModelRoot LoadModelFromZip(string zipPath, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0xA6243E0", Offset = "0xA6231E0", VA = "0x18A6243E0")]
		public ZipReader(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0xA624310", Offset = "0xA623110", VA = "0x18A624310")]
		public ZipReader(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xA623670", Offset = "0xA622470", VA = "0x18A623670", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA623D60", Offset = "0xA622B60", VA = "0x18A623D60")]
		private IEnumerable<ZipArchiveEntry> _GetEntries()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xA623A30", Offset = "0xA622830", VA = "0x18A623A30")]
		public ModelRoot LoadModel([Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xA623970", Offset = "0xA622770", VA = "0x18A623970")]
		public ModelRoot LoadModel(string gltfFile, [Optional] ReadSettings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA623F70", Offset = "0xA622D70", VA = "0x18A623F70")]
		private ArraySegment<byte> _ReadAsset(string rawUri)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0xA623C20", Offset = "0xA622A20", VA = "0x18A623C20")]
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
		[Cpp2IlInjected.Address(RVA = "0xA624990", Offset = "0xA623790", VA = "0x18A624990")]
		public ZipWriter(string zipPath, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0xA6248C0", Offset = "0xA6236C0", VA = "0x18A6248C0")]
		public ZipWriter(Stream zipStream, bool leaveOpen = false, [Optional] Encoding encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xA623670", Offset = "0xA622470", VA = "0x18A623670", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0xA624570", Offset = "0xA623370", VA = "0x18A624570")]
		public void AddModel(string filePath, ModelRoot model, [Optional] WriteSettings settings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0xA624770", Offset = "0xA623570", VA = "0x18A624770")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F580C0", Offset = "0x6F56EC0", VA = "0x186F580C0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public VertexPreprocessor<TvG, TvM, TvS> VertexPreprocessor
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public IEnumerable<TMaterial> Materials
		{
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x6F582B0", Offset = "0x6F570B0", VA = "0x186F582B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyCollection<PrimitiveBuilder<TMaterial, TvG, TvM, TvS>> Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x6F53170", Offset = "0x6F51F70", VA = "0x186F53170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		IReadOnlyCollection<IPrimitiveReader<TMaterial>> IMeshBuilder<TMaterial>.Primitives
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x6F53170", Offset = "0x6F51F70", VA = "0x186F53170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6F57BB0", Offset = "0x6F569B0", VA = "0x186F57BB0")]
		public MeshBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6F576C0", Offset = "0x6F564C0", VA = "0x186F576C0")]
		public MeshBuilder(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6F53280", Offset = "0x6F52080", VA = "0x186F53280", Slot = "19")]
		object ICloneable.Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6F52450", Offset = "0x6F51250", VA = "0x186F52450", Slot = "17")]
		IMeshBuilder<TMaterial> IMeshBuilder<TMaterial>.Clone(Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6F52450", Offset = "0x6F51250", VA = "0x186F52450")]
		public MeshBuilder<TMaterial, TvG, TvM, TvS> Clone([Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F57BD0", Offset = "0x6F569D0", VA = "0x186F57BD0")]
		private MeshBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> other, [Optional] Func<TMaterial, TMaterial> materialCloneCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F54100", Offset = "0x6F52F00", VA = "0x186F54100")]
		public MorphTargetBuilder<TMaterial, TvG, TvS, TvM> UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F52810", Offset = "0x6F51610", VA = "0x186F52810", Slot = "16")]
		IMorphTargetBuilder IMeshBuilder<TMaterial>.UseMorphTarget(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F55920", Offset = "0x6F54720", VA = "0x186F55920")]
		private PrimitiveBuilder<TMaterial, TvG, TvM, TvS> _UsePrimitive((TMaterial Material, int PrimType) key)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F54560", Offset = "0x6F53360", VA = "0x186F54560")]
		public PrimitiveBuilder<TMaterial, TvG, TvM, TvS> UsePrimitive(TMaterial material, int primitiveVertexCount = 3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F52BF0", Offset = "0x6F519F0", VA = "0x186F52BF0", Slot = "15")]
		IPrimitiveBuilder IMeshBuilder<TMaterial>.UsePrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F501D0", Offset = "0x6F4EFD0", VA = "0x186F501D0")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, Matrix4x4 vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F51390", Offset = "0x6F50190", VA = "0x186F51390")]
		public void AddMesh(IMeshBuilder<TMaterial> mesh, [Optional] Func<TMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x39CEA10", Offset = "0x39CD810", VA = "0x1839CEA10")]
		public void AddMesh<TSourceMaterial>(IMeshBuilder<TSourceMaterial> mesh, Func<TSourceMaterial, TMaterial> materialTransform, [Optional] Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F53440", Offset = "0x6F52240", VA = "0x186F53440")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F55320", Offset = "0x6F54120", VA = "0x186F55320", Slot = "18")]
		public void Validate()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class MeshBuilder<TvG, TvM, TvS> : MeshBuilder<MaterialBuilder, TvG, TvM, TvS> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F4FF90", Offset = "0x6F4ED90", VA = "0x186F4FF90")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class MeshBuilder<TvG, TvM> : MeshBuilder<MaterialBuilder, TvG, TvM, VertexEmpty> where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6290720", Offset = "0x628F520", VA = "0x186290720")]
		public MeshBuilder([Optional] string name)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class MeshBuilder<TvG> : MeshBuilder<MaterialBuilder, TvG, VertexEmpty, VertexEmpty> where TvG : struct, IVertexGeometry
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x6290720", Offset = "0x628F520", VA = "0x186290720")]
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
		[Cpp2IlInjected.Address(RVA = "0xA610720", Offset = "0xA60F520", VA = "0x18A610720")]
		public static VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>[] GetMorphTargetVertices(this IPrimitiveMorphTargetReader morphTarget, int vertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4EA0", Offset = "0x3CF3CA0", VA = "0x183CF4EA0")]
		public static EncodingType GetOptimalIndexEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5A90", Offset = "0x3CF4890", VA = "0x183CF5A90")]
		public static EncodingType GetOptimalJointEncoding<TMaterial>(this IEnumerable<IMeshBuilder<TMaterial>> meshes)
		{
			return default(EncodingType);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4800", Offset = "0x3CF3600", VA = "0x183CF4800")]
		public static IMeshBuilder<TMaterial> CreateMeshBuilderFromVertexAttributes<TMaterial>(params string[] vertexAttributes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3BB0", Offset = "0x3CF29B0", VA = "0x183CF3BB0")]
		public static IReadOnlyDictionary<Vector3, Vector3> CalculateSmoothNormals<TMaterial>(this IMeshBuilder<TMaterial> srcMesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6080", Offset = "0x3CF4E80", VA = "0x183CF6080")]
		public static bool IsEmpty<TMaterial>(this IPrimitiveReader<TMaterial> primitive)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6410", Offset = "0x3CF5210", VA = "0x183CF6410")]
		public static bool IsEmpty<TMaterial>(this IMeshBuilder<TMaterial> mesh)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xA6108B0", Offset = "0xA60F6B0", VA = "0x18A6108B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7554BA0", Offset = "0x75539A0", VA = "0x187554BA0")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x7554EF0", Offset = "0x7553CF0", VA = "0x187554EF0")]
		internal PrimitiveMorphTargetBuilder(Func<int, VertexBuilder<TvG, TvM, VertexEmpty>> baseVertexFunc, PrimitiveMorphTargetBuilder<TvG, TvM> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7536770", Offset = "0x7535570", VA = "0x187536770", Slot = "4")]
		public IReadOnlyCollection<int> GetTargetIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x7539C70", Offset = "0x7538A70", VA = "0x187539C70", Slot = "6")]
		public VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty> GetVertexDelta(int vertexIndex)
		{
			return default(VertexBuilder<VertexGeometryDelta, VertexMaterialDelta, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x7547670", Offset = "0x7546470", VA = "0x187547670")]
		public void SetVertexDelta(int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x754C940", Offset = "0x754B740", VA = "0x18754C940", Slot = "5")]
		IVertexBuilder IPrimitiveMorphTargetReader.GetVertex(int vertexIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x753BE20", Offset = "0x753AC20", VA = "0x18753BE20")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex(int vertexIndex)
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7549F30", Offset = "0x7548D30", VA = "0x187549F30")]
		public void SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x75544E0", Offset = "0x75532E0", VA = "0x1875544E0")]
		private void _SetVertex(int vertexIndex, VertexBuilder<TvG, TvM, VertexEmpty> vertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7554120", Offset = "0x7552F20", VA = "0x187554120")]
		private void _RemoveVertex(int vertexIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x75534E0", Offset = "0x75522E0", VA = "0x1875534E0")]
		internal void TransformVertices(Func<VertexBuilder<TvG, TvM, VertexEmpty>, VertexBuilder<TvG, TvM, VertexEmpty>> vertexFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x753D290", Offset = "0x753C090", VA = "0x18753D290")]
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
			[Cpp2IlInjected.Address(RVA = "0x7021BC0", Offset = "0x70209C0", VA = "0x187021BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public IReadOnlyCollection<Vector3> Positions
		{
			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x7021B90", Offset = "0x7020990", VA = "0x187021B90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		IReadOnlyCollection<IVertexGeometry> IMorphTargetBuilder.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x701F4B0", Offset = "0x701E2B0", VA = "0x18701F4B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x7021540", Offset = "0x7020340", VA = "0x187021540")]
		internal MorphTargetBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, int morphTargetIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x70160F0", Offset = "0x7014EF0", VA = "0x1870160F0")]
		public IReadOnlyList<TvG> GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7017A20", Offset = "0x7016820", VA = "0x187017A20")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7017050", Offset = "0x7015E50", VA = "0x187017050")]
		public void SetVertexDelta(TvG meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x701B840", Offset = "0x701A640", VA = "0x18701B840")]
		public void SetVertex(TvG meshVertex, VertexBuilder<TvG, TvM, VertexEmpty> morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x7019C30", Offset = "0x7018A30", VA = "0x187019C30")]
		public void SetVertex(TvG meshVertex, TvG morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x701C380", Offset = "0x701B180", VA = "0x18701C380", Slot = "6")]
		IReadOnlyList<IVertexGeometry> IMorphTargetBuilder.GetVertices(Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x701E4B0", Offset = "0x701D2B0", VA = "0x18701E4B0", Slot = "7")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x701DDE0", Offset = "0x701CBE0", VA = "0x18701DDE0", Slot = "8")]
		void IMorphTargetBuilder.SetVertex(IVertexGeometry meshVertex, IVertexGeometry morphVertex, IVertexMaterial morphMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x701DC90", Offset = "0x701CA90", VA = "0x18701DC90", Slot = "9")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x701CF10", Offset = "0x701BD10", VA = "0x18701CF10", Slot = "10")]
		void IMorphTargetBuilder.SetVertexDelta(IVertexGeometry meshVertex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x7017CB0", Offset = "0x7016AB0", VA = "0x187017CB0", Slot = "11")]
		public void SetVertexDelta(Vector3 meshVertex, VertexGeometryDelta geometryDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7018930", Offset = "0x7017730", VA = "0x187018930", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xA611700", Offset = "0xA610500", VA = "0x18A611700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA610D90", Offset = "0xA60FB90", VA = "0x18A610D90")]
		public void AddAccessors(params MemoryAccessor[] accessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA610F60", Offset = "0xA60FD60", VA = "0x18A610F60")]
		public void MergeBuffers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA611680", Offset = "0xA610480", VA = "0x18A611680")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D82200", Offset = "0x3D81000", VA = "0x183D82200")]
		public void AdjustJointEncoding<TVertex>(IReadOnlyList<TVertex> vertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public <CreatePackedMeshes>d__0(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x64C8640", Offset = "0x64C7440", VA = "0x1864C8640", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x64C7BA0", Offset = "0x64C69A0", VA = "0x1864C7BA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x64C8790", Offset = "0x64C7590", VA = "0x1864C8790")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x64C8310", Offset = "0x64C7110", VA = "0x1864C8310", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<PackedMeshBuilder<TMaterial>> IEnumerable<PackedMeshBuilder<TMaterial>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x64C84C0", Offset = "0x64C72C0", VA = "0x1864C84C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x73BA200", Offset = "0x73B9000", VA = "0x1873BA200")]
		[IteratorStateMachine(typeof(PackedMeshBuilder<>.<CreatePackedMeshes>d__0))]
		internal static IEnumerable<PackedMeshBuilder<TMaterial>> CreatePackedMeshes(IEnumerable<IMeshBuilder<TMaterial>> meshBuilders, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x73BB730", Offset = "0x73BA530", VA = "0x1873BB730")]
		private static PackedMeshBuilder<TMaterial> Create(IMeshBuilder<TMaterial> srcMesh, PackedEncoding vertexEncodings, EncodingType indexEncoding, SceneBuilderSchema2Settings settings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x73BC9F0", Offset = "0x73BB7F0", VA = "0x1873BC9F0")]
		private PackedMeshBuilder(string name, JsonNode extras)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x73B9E00", Offset = "0x73B8C00", VA = "0x1873B9E00")]
		public PackedPrimitiveBuilder<TMaterial> AddPrimitive(TMaterial material, int primitiveVertexCount)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x73BA2D0", Offset = "0x73B90D0", VA = "0x1873BA2D0")]
		public Mesh CreateSchema2Mesh(ModelRoot root, Converter<TMaterial, Material> materialEvaluator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x73BC760", Offset = "0x73BB560", VA = "0x1873BC760")]
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
		[Cpp2IlInjected.Address(RVA = "0x73C4A70", Offset = "0x73C3870", VA = "0x1873C4A70")]
		public PackedPrimitiveBuilder(TMaterial material, int primitiveVertexCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x73C28D0", Offset = "0x73C16D0", VA = "0x1873C28D0")]
		public void SetStridedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x73C1E10", Offset = "0x73C0C10", VA = "0x1873C1E10")]
		public void SetStreamedVertices(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x73BEFF0", Offset = "0x73BDDF0", VA = "0x1873BEFF0")]
		public void SetIndices(IPrimitiveReader<TMaterial> srcPrim, EncodingType encoding)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x73C0580", Offset = "0x73BF380", VA = "0x1873C0580")]
		public void SetMorphTargets(IPrimitiveReader<TMaterial> srcPrim, PackedEncoding vertexEncodings, ISet<string> morphTargetAttributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x73BCF20", Offset = "0x73BBD20", VA = "0x1873BCF20")]
		private void AddMorphTarget(params MemoryAccessor[] morphTarget)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x73BD910", Offset = "0x73BC710", VA = "0x1873BD910")]
		internal void CopyToMesh(Mesh dstMesh, Converter<TMaterial, Material> materialEvaluator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x73BD2E0", Offset = "0x73BC0E0", VA = "0x1873BD2E0")]
		private void CopyMorphTargets(MeshPrimitive dstPrim)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x73BE5F0", Offset = "0x73BD3F0", VA = "0x1873BE5F0")]
		public static void MergeBuffers(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x73C3910", Offset = "0x73C2710", VA = "0x1873C3910")]
		private static void _MergeSequentialVertices(IEnumerable<MemoryAccessor[]> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x73C44C0", Offset = "0x73C32C0", VA = "0x1873C44C0")]
		private static void _MergeStridedVertices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x73C2E90", Offset = "0x73C1C90", VA = "0x1873C2E90")]
		private static void _MergeIndices(IEnumerable<PackedPrimitiveBuilder<TMaterial>> primitives)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	internal static class _PackedPrimitiveHelpers
	{
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x4136460", Offset = "0x4135260", VA = "0x184136460")]
		public static void _GatherMorphTargetAttributes<TMaterial>(this IPrimitiveReader<TMaterial> srcPrim, HashSet<string> attributes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x4136CA0", Offset = "0x4135AA0", VA = "0x184136CA0")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600057F")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000580")]
				[Cpp2IlInjected.Address(RVA = "0x6D16820", Offset = "0x6D15620", VA = "0x186D16820", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000581")]
				[Cpp2IlInjected.Address(RVA = "0x6D13370", Offset = "0x6D12170", VA = "0x186D13370", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0x6D173D0", Offset = "0x6D161D0", VA = "0x186D173D0")]
				private void <>m__Finally1()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000584")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			IVertexBuilder IReadOnlyList<IVertexBuilder>.this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600057C")]
				[Cpp2IlInjected.Address(RVA = "0x8530560", Offset = "0x852F360", VA = "0x188530560", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x852FF90", Offset = "0x852ED90", VA = "0x18852FF90", Slot = "10")]
			[IteratorStateMachine(typeof(PrimitiveBuilder<, , , >.VertexListWrapper.<System-Collections-Generic-IEnumerable<SharpGLTF-Geometry-IVertexBuilder>-GetEnumerator>d__2))]
			IEnumerator<IVertexBuilder> IEnumerable<IVertexBuilder>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x8531EF0", Offset = "0x8530CF0", VA = "0x188531EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public TMaterial Material
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0x741B830", Offset = "0x741A630", VA = "0x18741B830", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Func<IVertexBuilder> VertexFactory
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x741ABB0", Offset = "0x74199B0", VA = "0x18741ABB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public IReadOnlyList<VertexBuilder<TvG, TvM, TvS>> Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		IReadOnlyList<IVertexBuilder> IPrimitiveReader<TMaterial>.Vertices
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		IReadOnlyList<IPrimitiveMorphTargetReader> IPrimitiveReader<TMaterial>.MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public virtual IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x741A3E0", Offset = "0x74191E0", VA = "0x18741A3E0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public virtual IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x741A290", Offset = "0x7419090", VA = "0x18741A290", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public virtual IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x741A770", Offset = "0x7419570", VA = "0x18741A770", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public virtual IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x741A560", Offset = "0x7419360", VA = "0x18741A560", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		internal IReadOnlyList<PrimitiveMorphTargetBuilder<TvG, TvM>> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7418BE0", Offset = "0x74179E0", VA = "0x187418BE0")]
		internal PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x7419810", Offset = "0x7418610", VA = "0x187419810")]
		protected PrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		internal abstract PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material);

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7416650", Offset = "0x7415450", VA = "0x187416650")]
		internal PrimitiveMorphTargetBuilder<TvG, TvM> _UseMorphTarget(int morphTargetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x7415A60", Offset = "0x7414860", VA = "0x187415A60")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x74100B0", Offset = "0x740EEB0", VA = "0x1874100B0")]
		private static VertexBuilder<TvG, TvM, TvS> ConvertVertex(IVertexBuilder vertex)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x7413680", Offset = "0x7412480", VA = "0x187413680")]
		protected int UseVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7410830", Offset = "0x740F630", VA = "0x187410830", Slot = "6")]
		void IPrimitiveBuilder.SetVertexDelta(int morphTargetIndex, int vertexIndex, VertexGeometryDelta geometryDelta, VertexMaterialDelta materialDelta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x740FF30", Offset = "0x740ED30", VA = "0x18740FF30")]
		public bool ContainsVertex([In] VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x74098C0", Offset = "0x74086C0", VA = "0x1874098C0", Slot = "7")]
		public int AddPoint(IVertexBuilder a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x74078A0", Offset = "0x74066A0", VA = "0x1874078A0", Slot = "8")]
		public (int, int) AddLine(IVertexBuilder a, IVertexBuilder b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x740E7A0", Offset = "0x740D5A0", VA = "0x18740E7A0", Slot = "9")]
		public (int, int, int) AddTriangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x740CCB0", Offset = "0x740BAB0", VA = "0x18740CCB0", Slot = "10")]
		public (int, int, int, int) AddQuadrangle(IVertexBuilder a, IVertexBuilder b, IVertexBuilder c, IVertexBuilder d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x740B1E0", Offset = "0x7409FE0", VA = "0x18740B1E0")]
		internal void AddPrimitive(PrimitiveBuilder<TMaterial, TvG, TvM, TvS> primitive, Converter<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x39F6870", Offset = "0x39F5670", VA = "0x1839F6870")]
		internal void AddPrimitive<TAnyMaterial>(IPrimitiveReader<TAnyMaterial> primitive, Converter<IVertexBuilder, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x7410F10", Offset = "0x740FD10", VA = "0x187410F10")]
		public void TransformVertices(Func<VertexBuilder<TvG, TvM, TvS>, VertexBuilder<TvG, TvM, TvS>> vertexTransformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract IReadOnlyList<int> GetIndices();

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x7408C00", Offset = "0x7407A00", VA = "0x187408C00", Slot = "28")]
		public virtual int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x7407600", Offset = "0x7406400", VA = "0x187407600", Slot = "29")]
		public virtual (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x740DD20", Offset = "0x740CB20", VA = "0x18740DD20", Slot = "30")]
		public virtual (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x740B480", Offset = "0x740A280", VA = "0x18740B480", Slot = "31")]
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
				[Cpp2IlInjected.Address(RVA = "0xD4BB70", Offset = "0xD4A970", VA = "0x180D4BB70", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600059A")]
				[Cpp2IlInjected.Address(RVA = "0x73EA220", Offset = "0x73E9020", VA = "0x1873EA220", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
			public PointListWrapper(IReadOnlyList<T> vertices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x73E3420", Offset = "0x73E2220", VA = "0x1873E3420", Slot = "6")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x73E9BF0", Offset = "0x73E89F0", VA = "0x1873E9BF0", Slot = "7")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public override int VerticesPerPrimitive
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public override IReadOnlyList<int> Points
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x7400450", Offset = "0x73FF250", VA = "0x187400450", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x73FFD70", Offset = "0x73FEB70", VA = "0x1873FFD70")]
		internal PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x73FBAD0", Offset = "0x73FA8D0", VA = "0x1873FBAD0", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x73FF770", Offset = "0x73FE570", VA = "0x1873FF770")]
		private PointsPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, PointsPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x73F2ED0", Offset = "0x73F1CD0", VA = "0x1873F2ED0", Slot = "28")]
		public override int AddPoint(VertexBuilder<TvG, TvM, TvS> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x73FD0F0", Offset = "0x73FBEF0", VA = "0x1873FD0F0", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public override IReadOnlyList<(int A, int B)> Lines
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x690FA60", Offset = "0x690E860", VA = "0x18690FA60")]
		internal LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x68FE9F0", Offset = "0x68FD7F0", VA = "0x1868FE9F0", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x69137A0", Offset = "0x69125A0", VA = "0x1869137A0")]
		private LinesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, LinesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x68F8810", Offset = "0x68F7610", VA = "0x1868F8810", Slot = "29")]
		public override (int, int) AddLine(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b)
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x6906B50", Offset = "0x6905950", VA = "0x186906B50", Slot = "27")]
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
					[Cpp2IlInjected.Address(RVA = "0x1A050E0", Offset = "0x1A03EE0", VA = "0x181A050E0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x6667130", Offset = "0x6665F30", VA = "0x186667130", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005B6")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B7")]
				[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005B8")]
				[Cpp2IlInjected.Address(RVA = "0x6665040", Offset = "0x6663E40", VA = "0x186665040", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005BA")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005BC")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BD")]
				[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005BE")]
				[Cpp2IlInjected.Address(RVA = "0x6E52E10", Offset = "0x6E51C10", VA = "0x186E52E10", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005C0")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x7B9E760", Offset = "0x7B9D560", VA = "0x187B9E760", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BE")]
			public (int A, int B, int C) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x7B9FDE0", Offset = "0x7B9EBE0", VA = "0x187B9FDE0", Slot = "4")]
				get
				{
					return default((int, int, int));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			public TriangleList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x7B9E630", Offset = "0x7B9D430", VA = "0x187B9E630", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.TriangleList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x79E4C90", Offset = "0x79E3A90", VA = "0x1879E4C90", Slot = "7")]
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
					[Cpp2IlInjected.Address(RVA = "0x23A26F0", Offset = "0x23A14F0", VA = "0x1823A26F0", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0x6667220", Offset = "0x6666020", VA = "0x186667220", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005C7")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <GetEnumerator>d__7(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C8")]
				[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005C9")]
				[Cpp2IlInjected.Address(RVA = "0x6663AC0", Offset = "0x66628C0", VA = "0x186663AC0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005CB")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60005CD")]
				[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
				[DebuggerHidden]
				public <System-Collections-IEnumerable-GetEnumerator>d__8(int <>1__state)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CE")]
				[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "5")]
				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005CF")]
				[Cpp2IlInjected.Address(RVA = "0x6E56F50", Offset = "0x6E55D50", VA = "0x186E56F50", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60005D1")]
				[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x79E5640", Offset = "0x79E4440", VA = "0x1879E5640", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C4")]
			public (int A, int B, int C, int? D) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x60005C4")]
				[Cpp2IlInjected.Address(RVA = "0x79F3660", Offset = "0x79F2460", VA = "0x1879F3660", Slot = "4")]
				get
				{
					return default((int, int, int, int?));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			public SurfaceList(IReadOnlyList<(int, int, int)> tris, IReadOnlyList<(int, int, int, int)> quads)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x79E4BE0", Offset = "0x79E39E0", VA = "0x1879E4BE0", Slot = "6")]
			[IteratorStateMachine(typeof(TrianglesPrimitiveBuilder<, , , >.SurfaceList.<GetEnumerator>d__7))]
			public IEnumerator<(int, int, int, int?)> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x79E4C90", Offset = "0x79E3A90", VA = "0x1879E4C90", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public override IReadOnlyList<(int A, int B, int C)> Triangles
		{
			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1A30", Offset = "0x7BC0830", VA = "0x187BC1A30", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public override IReadOnlyList<(int A, int B, int C, int? D)> Surfaces
		{
			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x7BC19D0", Offset = "0x7BC07D0", VA = "0x187BC19D0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC12B0", Offset = "0x7BC00B0", VA = "0x187BC12B0")]
		internal TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BBFB00", Offset = "0x7BBE900", VA = "0x187BBFB00", Slot = "21")]
		internal override PrimitiveBuilder<TMaterial, TvG, TvM, TvS> Clone(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TMaterial material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1770", Offset = "0x7BC0570", VA = "0x187BC1770")]
		private TrianglesPrimitiveBuilder(MeshBuilder<TMaterial, TvG, TvM, TvS> mesh, TrianglesPrimitiveBuilder<TMaterial, TvG, TvM, TvS> other, TMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF1A0", Offset = "0x7BBDFA0", VA = "0x187BBF1A0", Slot = "30")]
		public override (int, int, int) AddTriangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE860", Offset = "0x7BBD660", VA = "0x187BBE860", Slot = "31")]
		public override (int, int, int, int) AddQuadrangle(VertexBuilder<TvG, TvM, TvS> a, VertexBuilder<TvG, TvM, TvS> b, VertexBuilder<TvG, TvM, TvS> c, VertexBuilder<TvG, TvM, TvS> d)
		{
			return default((int, int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0A70", Offset = "0x7BBF870", VA = "0x187BC0A70")]
		private (int, int, int) _AddTriangle([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b, [In] VertexBuilder<TvG, TvM, TvS> c)
		{
			return default((int, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0290", Offset = "0x7BBF090", VA = "0x187BC0290", Slot = "27")]
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
			[Cpp2IlInjected.Address(RVA = "0x700C230", Offset = "0x700B030", VA = "0x18700C230", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x700B0B0", Offset = "0x7009EB0", VA = "0x18700B0B0")]
		public static IReadOnlyDictionary<IPrimitiveReader<TMaterial>, MeshPrimitiveNormalsAndTangents<TMaterial>> GenerateNormalsTangents(IMeshBuilder<TMaterial> mesh)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		private MeshPrimitiveNormalsAndTangents(IPrimitiveReader<TMaterial> source)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x700B9E0", Offset = "0x700A7E0", VA = "0x18700B9E0", Slot = "13")]
		public IEnumerable<(int, int, int)> GetTriangleIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x700BBF0", Offset = "0x700A9F0", VA = "0x18700BBF0", Slot = "9")]
		public Vector3 GetVertexPosition(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x700BA30", Offset = "0x700A830", VA = "0x18700BA30", Slot = "10")]
		public Vector3 GetVertexNormal(int idx)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x700BD60", Offset = "0x700AB60", VA = "0x18700BD60")]
		public Vector4 GetVertexTangent(int idx)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x700BF10", Offset = "0x700AD10", VA = "0x18700BF10", Slot = "11")]
		public Vector2 GetVertexTexCoord(int idx)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x700C090", Offset = "0x700AE90", VA = "0x18700C090", Slot = "6")]
		public void SetVertexNormal(int idx, Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x700C160", Offset = "0x700AF60", VA = "0x18700C160", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0xA646C00", Offset = "0xA645A00", VA = "0x18A646C00", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			public _NormalTangentAgent(VertexBufferColumns vertices, IEnumerable<(int A, int B, int C)> indices)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720", Slot = "13")]
			public IEnumerable<(int, int, int)> GetTriangleIndices()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xA646810", Offset = "0xA645610", VA = "0x18A646810", Slot = "9")]
			public Vector3 GetVertexPosition(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA646720", Offset = "0xA645520", VA = "0x18A646720", Slot = "10")]
			public Vector3 GetVertexNormal(int idx)
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA646900", Offset = "0xA645700", VA = "0x18A646900", Slot = "11")]
			public Vector2 GetVertexTexCoord(int idx)
			{
				return default(Vector2);
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0xA646960", Offset = "0xA645760", VA = "0x18A646960", Slot = "6")]
			public void SetVertexNormal(int idx, Vector3 normal)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0xA646AB0", Offset = "0xA6458B0", VA = "0x18A646AB0", Slot = "12")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public IList<Vector3> Normals
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public IList<Vector4> Tangents
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public IList<Vector4> Colors0
		{
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public IList<Vector4> Colors1
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public IList<Vector2> TexCoords0
		{
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B50", Offset = "0xCE6950", VA = "0x180CE7B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public IList<Vector2> TexCoords1
		{
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xCE8260", Offset = "0xCE7060", VA = "0x180CE8260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public IList<Vector2> TexCoords2
		{
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000607")]
			[Cpp2IlInjected.Address(RVA = "0xCE8290", Offset = "0xCE7090", VA = "0x180CE8290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public IList<Vector2> TexCoords3
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B20", Offset = "0xCE6920", VA = "0x180CE7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xCE7900", Offset = "0xCE6700", VA = "0x180CE7900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public IList<Vector4> Joints0
		{
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7940", Offset = "0xCE6740", VA = "0x180CE7940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0xCE82A0", Offset = "0xCE70A0", VA = "0x180CE82A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public IList<Vector4> Joints1
		{
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0xCEB600", Offset = "0xCEA400", VA = "0x180CEB600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0xCEB5F0", Offset = "0xCEA3F0", VA = "0x180CEB5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public IList<Vector4> Weights0
		{
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B40", Offset = "0xCE6940", VA = "0x180CE7B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xCE7910", Offset = "0xCE6710", VA = "0x180CE7910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public IList<Vector4> Weights1
		{
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B60", Offset = "0xCE6960", VA = "0x180CE7B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xCE7AE0", Offset = "0xCE68E0", VA = "0x180CE7AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public IReadOnlyList<VertexBufferColumns> MorphTargets
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0xA61F430", Offset = "0xA61E230", VA = "0x18A61F430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public VertexBufferColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xA61F280", Offset = "0xA61E080", VA = "0x18A61F280")]
		public VertexBufferColumns(VertexBufferColumns other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x40CD8A0", Offset = "0x40CC6A0", VA = "0x1840CD8A0")]
		private static T[] _IsolateColumn<T>(IList<T> column)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA61C730", Offset = "0xA61B530", VA = "0x18A61C730")]
		public void IsolateColumns()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA61CA00", Offset = "0xA61B800", VA = "0x18A61CA00")]
		public VertexBufferColumns WithTransform(IGeometryTransform transform)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xA61CB00", Offset = "0xA61B900", VA = "0x18A61CB00")]
		private void _ApplyTransform(IGeometryTransform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xA61EEA0", Offset = "0xA61DCA0", VA = "0x18A61EEA0")]
		private void _FillMorphData(Vector2[] array, Converter<VertexBufferColumns, Vector2> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xA61F0C0", Offset = "0xA61DEC0", VA = "0x18A61F0C0")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector3> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA61EF80", Offset = "0xA61DD80", VA = "0x18A61EF80")]
		private void _FillMorphData(Vector3[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0xA61F1A0", Offset = "0xA61DFA0", VA = "0x18A61F1A0")]
		private void _FillMorphData(Vector4[] array, Converter<VertexBufferColumns, Vector4> selector)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0xA61BFB0", Offset = "0xA61ADB0", VA = "0x18A61BFB0")]
		public VertexBufferColumns AddMorphTarget()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA61C440", Offset = "0xA61B240", VA = "0x18A61C440")]
		public (Type, Func<IVertexBuilder>) GetCompatibleVertexType()
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x40CB2F0", Offset = "0x40CA0F0", VA = "0x1840CB2F0")]
		private TvG GetVertexGeometry<TvG>(int index) where TvG : struct, IVertexGeometry
		{
			return (TvG)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x40CBF20", Offset = "0x40CAD20", VA = "0x1840CBF20")]
		private TvM GetVertexMaterial<TvM>(int index) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x40CCC80", Offset = "0x40CBA80", VA = "0x1840CCC80")]
		private TvS GetVertexSkinning<TvS>(int index) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xA61C570", Offset = "0xA61B370", VA = "0x18A61C570")]
		public IVertexBuilder GetVertex(Func<IVertexBuilder> factory, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x40CD4B0", Offset = "0x40CC2B0", VA = "0x1840CD4B0")]
		public VertexBuilder<TvG, TvM, VertexEmpty> GetVertex<TvG, TvM>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial
		{
			return default(VertexBuilder<TvG, TvM, VertexEmpty>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x40CD6C0", Offset = "0x40CC4C0", VA = "0x1840CD6C0")]
		public VertexBuilder<TvG, TvM, TvS> GetVertex<TvG, TvM, TvS>(int index) where TvG : struct, IVertexGeometry where TvM : struct, IVertexMaterial where TvS : struct, IVertexSkinning
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xA61C0E0", Offset = "0xA61AEE0", VA = "0x18A61C0E0")]
		public static void CalculateSmoothNormals(IReadOnlyList<(VertexBufferColumns Vertices, IEnumerable<(int A, int B, int C)> Indices)> primitives)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xA61C290", Offset = "0xA61B090", VA = "0x18A61C290")]
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
			[Cpp2IlInjected.Address(RVA = "0x84106C0", Offset = "0x840F4C0", VA = "0x1884106C0")]
			readonly get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0x8412090", Offset = "0x8410E90", VA = "0x188412090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x840D2A0", Offset = "0x840C0A0", VA = "0x18840D2A0")]
		internal readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x840C9A0", Offset = "0x840B7A0", VA = "0x18840C9A0")]
		private static string _GetDebuggerDisplayTextFrom(object o)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x840B340", Offset = "0x840A140", VA = "0x18840B340")]
		private readonly string _GetDebugWarnings()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x8410040", Offset = "0x840EE40", VA = "0x188410040")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x840FEE0", Offset = "0x840ECE0", VA = "0x18840FEE0")]
		public VertexBuilder([In] TvG g, [In] TvM m, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x840FA80", Offset = "0x840E880", VA = "0x18840FA80")]
		public VertexBuilder([In] TvG g, [In] TvM m, [In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x8410540", Offset = "0x840F340", VA = "0x188410540")]
		public VertexBuilder([In] TvG g, [In] TvM m)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8410260", Offset = "0x840F060", VA = "0x188410260")]
		public VertexBuilder([In] TvG g, [In] TvS s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x840EDA0", Offset = "0x840DBA0", VA = "0x18840EDA0")]
		public VertexBuilder([In] TvG g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x840FC00", Offset = "0x840EA00", VA = "0x18840FC00")]
		public VertexBuilder([In] TvG g, params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x840F540", Offset = "0x840E340", VA = "0x18840F540")]
		public VertexBuilder(TvG g, SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x84114E0", Offset = "0x84102E0", VA = "0x1884114E0")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x8410D40", Offset = "0x840FB40", VA = "0x188410D40")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvM Mat) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x84118F0", Offset = "0x84106F0", VA = "0x1884118F0")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] (TvG Geo, TvS Skin) tuple)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x8411400", Offset = "0x8410200", VA = "0x188411400")]
		public static implicit operator VertexBuilder<TvG, TvM, TvS>([In] TvG g)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x83FCCD0", Offset = "0x83FBAD0", VA = "0x1883FCCD0")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x83FCE70", Offset = "0x83FBC70", VA = "0x1883FCE70")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x83FCAF0", Offset = "0x83FB8F0", VA = "0x1883FCAF0")]
		public static VertexBuilder<TvG, TvM, TvS> Create([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x83FA9F0", Offset = "0x83F97F0", VA = "0x1883FA9F0")]
		public static VertexBuilder<TvG, TvM, TvS> CreateFrom(IVertexBuilder src)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x83FE5C0", Offset = "0x83FD3C0", VA = "0x1883FE5C0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x83FE390", Offset = "0x83FD190", VA = "0x1883FE390", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x83FE570", Offset = "0x83FD370", VA = "0x1883FE570", Slot = "11")]
		public readonly bool Equals(VertexBuilder<TvG, TvM, TvS> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x84107A0", Offset = "0x840F5A0", VA = "0x1884107A0")]
		public static bool operator ==([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x8412040", Offset = "0x8410E40", VA = "0x188412040")]
		public static bool operator !=([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x83F9710", Offset = "0x83F8510", VA = "0x1883F9710")]
		public static bool AreEqual([In] VertexBuilder<TvG, TvM, TvS> a, [In] VertexBuilder<TvG, TvM, TvS> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x8401560", Offset = "0x8400360", VA = "0x188401560")]
		public readonly void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x3BC7D70", Offset = "0x3BC6B70", VA = "0x183BC7D70")]
		public static MeshBuilder<TMaterial, TvG, TvM, TvS> CreateCompatibleMesh<TMaterial>([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x83F9F30", Offset = "0x83F8D30", VA = "0x1883F9F30")]
		public static MeshBuilder<TvG, TvM, TvS> CreateCompatibleMesh([Optional] string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x416B870", Offset = "0x416A670", VA = "0x18416B870", Slot = "10")]
		IMeshBuilder<TMaterial> IVertexBuilder.CreateCompatibleMesh<TMaterial>(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x83FE6B0", Offset = "0x83FD4B0", VA = "0x1883FE6B0", Slot = "4")]
		readonly IVertexGeometry IVertexBuilder.GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x83FE790", Offset = "0x83FD590", VA = "0x1883FE790", Slot = "5")]
		readonly IVertexMaterial IVertexBuilder.GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x83FE910", Offset = "0x83FD710", VA = "0x1883FE910", Slot = "6")]
		readonly IVertexSkinning IVertexBuilder.GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x83FEFD0", Offset = "0x83FDDD0", VA = "0x1883FEFD0", Slot = "7")]
		void IVertexBuilder.SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x83FFD30", Offset = "0x83FEB30", VA = "0x1883FFD30", Slot = "8")]
		void IVertexBuilder.SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8400BE0", Offset = "0x83FF9E0", VA = "0x188400BE0", Slot = "9")]
		void IVertexBuilder.SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x84010F0", Offset = "0x83FFEF0", VA = "0x1884010F0")]
		public readonly VertexBuilder<TvG, TvM, TvS> TransformedBy([In] Matrix4x4 transform)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x8402B20", Offset = "0x8401920", VA = "0x188402B20")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8403550", Offset = "0x8402350", VA = "0x188403550")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8402140", Offset = "0x8400F40", VA = "0x188402140")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithGeometry([In] Vector3 position, [In] Vector3 normal, [In] Vector4 tangent)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8405060", Offset = "0x8403E60", VA = "0x188405060")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial(params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x84068C0", Offset = "0x84056C0", VA = "0x1884068C0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8405B90", Offset = "0x8404990", VA = "0x188405B90")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithMaterial([In] Vector4 color0, Vector4 color1, params Vector2[] uvs)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x84078A0", Offset = "0x84066A0", VA = "0x1884078A0")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning([In] SparseWeight8 sparse)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x8408490", Offset = "0x8407290", VA = "0x188408490")]
		public readonly VertexBuilder<TvG, TvM, TvS> WithSkinning(params (int Index, float Weight)[] bindings)
		{
			return default(VertexBuilder<TvG, TvM, TvS>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x84076A0", Offset = "0x84064A0", VA = "0x1884076A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA62B410", Offset = "0xA62A210", VA = "0x18A62B410")]
		public VertexBuilder(IVertexGeometry g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x1F2BCE0", Offset = "0x1F2AAE0", VA = "0x181F2BCE0")]
		public VertexBuilder(IVertexGeometry g, IVertexMaterial m, IVertexSkinning s)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x1496030", Offset = "0x1494E30", VA = "0x181496030", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7B0", Offset = "0xEBE5B0", VA = "0x180EBF7B0", Slot = "4")]
		public readonly IVertexGeometry GetGeometry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0xF1F720", Offset = "0xF1E520", VA = "0x180F1F720", Slot = "5")]
		public readonly IVertexMaterial GetMaterial()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "6")]
		public readonly IVertexSkinning GetSkinning()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0", Slot = "7")]
		public void SetGeometry(IVertexGeometry geometry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xF1F730", Offset = "0xF1E530", VA = "0x180F1F730", Slot = "8")]
		public void SetMaterial(IVertexMaterial material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0", Slot = "9")]
		public void SetSkinning(IVertexSkinning skinning)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xA62B360", Offset = "0xA62A160", VA = "0x18A62B360")]
		public readonly IVertexBuilder ConvertToType(Func<IVertexBuilder> factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x3BEFD40", Offset = "0x3BEEB40", VA = "0x183BEFD40", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public EncodingType Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330")]
			[CompilerGenerated]
			get
			{
				return default(EncodingType);
			}
			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0xCED350", Offset = "0xCEC150", VA = "0x180CED350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool Normalized
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0xE8E790", Offset = "0xE8D590", VA = "0x180E8E790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0xEB8230", Offset = "0xEB7030", VA = "0x180EB8230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA62B2C0", Offset = "0xA62A0C0", VA = "0x18A62B2C0")]
		public VertexAttributeAttribute(string attributeName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA62B300", Offset = "0xA62A100", VA = "0x18A62B300")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA626B50", Offset = "0xA625950", VA = "0x18A626B50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0xFFF0A0", Offset = "0xFFDEA0", VA = "0x180FFF0A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xA626B10", Offset = "0xA625910", VA = "0x18A626B10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xA626A70", Offset = "0xA625870", VA = "0x18A626A70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0xA626A70", Offset = "0xA625870", VA = "0x18A626A70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA631520", Offset = "0xA630320", VA = "0x18A631520", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xA631520", Offset = "0xA630320", VA = "0x18A631520", Slot = "19")]
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
			[Cpp2IlInjected.Address(RVA = "0xA631520", Offset = "0xA630320", VA = "0x18A631520", Slot = "20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA631520", Offset = "0xA630320", VA = "0x18A631520", Slot = "21")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public void Validate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA631450", Offset = "0xA630250", VA = "0x18A631450", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__1))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA6310E0", Offset = "0xA62FEE0", VA = "0x18A6310E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "22")]
		public bool Equals(VertexEmpty other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10")]
		public static bool operator ==([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70")]
		public static bool operator !=([In] VertexEmpty a, [In] VertexEmpty b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xA631270", Offset = "0xA630070", VA = "0x18A631270", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0xA6312C0", Offset = "0xA6300C0", VA = "0x18A6312C0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xA631310", Offset = "0xA630110", VA = "0x18A631310", Slot = "10")]
		VertexMaterialDelta IVertexMaterial.Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "11")]
		void IVertexMaterial.Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA6311D0", Offset = "0xA62FFD0", VA = "0x18A6311D0", Slot = "6")]
		Vector4 IVertexMaterial.GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0xA631220", Offset = "0xA630020", VA = "0x18A631220", Slot = "7")]
		Vector2 IVertexMaterial.GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0xA631130", Offset = "0xA62FF30", VA = "0x18A631130", Slot = "17")]
		public SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xA631190", Offset = "0xA62FF90", VA = "0x18A631190")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xA631150", Offset = "0xA62FF50", VA = "0x18A631150", Slot = "16")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xA6314C0", Offset = "0xA6302C0", VA = "0x18A6314C0", Slot = "14")]
		(int, float) IVertexSkinning.GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xA631510", Offset = "0xA630310", VA = "0x18A631510", Slot = "15")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA627EB0", Offset = "0xA626CB0", VA = "0x18A627EB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0xA627150", Offset = "0xA625F50", VA = "0x18A627150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0xA627CD0", Offset = "0xA626AD0", VA = "0x18A627CD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xA627A10", Offset = "0xA626810", VA = "0x18A627A10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xA627A10", Offset = "0xA626810", VA = "0x18A627A10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA637640", Offset = "0xA636440", VA = "0x18A637640")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB990", Offset = "0x2DCA790", VA = "0x182DCB990")]
		public VertexPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA6376C0", Offset = "0xA6364C0", VA = "0x18A6376C0")]
		public VertexPosition(float px, float py, float pz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0xA637700", Offset = "0xA636500", VA = "0x18A637700")]
		public VertexPosition(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE380", Offset = "0x2DCD180", VA = "0x182DCE380")]
		public static implicit operator VertexPosition([In] Vector3 position)
		{
			return default(VertexPosition);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0xA637490", Offset = "0xA636290", VA = "0x18A637490", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xA631840", Offset = "0xA630640", VA = "0x18A631840", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xA6373C0", Offset = "0xA6361C0", VA = "0x18A6373C0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xA637370", Offset = "0xA636170", VA = "0x18A637370", Slot = "14")]
		public readonly bool Equals(VertexPosition other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xA637370", Offset = "0xA636170", VA = "0x18A637370")]
		public static bool operator ==([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA637840", Offset = "0xA636640", VA = "0x18A637840")]
		public static bool operator !=([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xA637370", Offset = "0xA636170", VA = "0x18A637370")]
		public static bool AreEqual([In] VertexPosition a, [In] VertexPosition b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB990", Offset = "0x2DCA790", VA = "0x182DCB990", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		readonly void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xA637500", Offset = "0xA636300", VA = "0x18A637500", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xA637190", Offset = "0xA635F90", VA = "0x18A637190")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE380", Offset = "0x2DCD180", VA = "0x182DCE380", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xA637630", Offset = "0xA636430", VA = "0x18A637630", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x172E060", Offset = "0x172CE60", VA = "0x18172E060", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xA637200", Offset = "0xA636000", VA = "0x18A637200")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xA637480", Offset = "0xA636280", VA = "0x18A637480", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xA637190", Offset = "0xA635F90", VA = "0x18A637190", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6293B0", Offset = "0xA6281B0", VA = "0x18A6293B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xA628220", Offset = "0xA627020", VA = "0x18A628220", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0xA629280", Offset = "0xA628080", VA = "0x18A629280", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0xA628EA0", Offset = "0xA627CA0", VA = "0x18A628EA0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0xA628EA0", Offset = "0xA627CA0", VA = "0x18A628EA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA636EB0", Offset = "0xA635CB0", VA = "0x18A636EB0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xA637110", Offset = "0xA635F10", VA = "0x18A637110")]
		public VertexPositionNormal([In] Vector3 p, [In] Vector3 n)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA637080", Offset = "0xA635E80", VA = "0x18A637080")]
		public VertexPositionNormal(float px, float py, float pz, float nx, float ny, float nz)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xA636F30", Offset = "0xA635D30", VA = "0x18A636F30")]
		public VertexPositionNormal(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xA637140", Offset = "0xA635F40", VA = "0x18A637140")]
		public static implicit operator VertexPositionNormal([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexPositionNormal);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA636D70", Offset = "0xA635B70", VA = "0x18A636D70", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xA631840", Offset = "0xA630640", VA = "0x18A631840", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA636C20", Offset = "0xA635A20", VA = "0x18A636C20", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0xA636D30", Offset = "0xA635B30", VA = "0x18A636D30", Slot = "14")]
		public readonly bool Equals(VertexPositionNormal other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA637130", Offset = "0xA635F30", VA = "0x18A637130")]
		public static bool operator ==([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xA637170", Offset = "0xA635F70", VA = "0x18A637170")]
		public static bool operator !=([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA636BA0", Offset = "0xA6359A0", VA = "0x18A636BA0")]
		public static bool AreEqual([In] VertexPositionNormal a, [In] VertexPositionNormal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB990", Offset = "0x2DCA790", VA = "0x182DCB990", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0xA631890", Offset = "0xA630690", VA = "0x18A631890", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "9")]
		readonly void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0xA636DF0", Offset = "0xA635BF0", VA = "0x18A636DF0", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0xA636880", Offset = "0xA635680", VA = "0x18A636880")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE380", Offset = "0x2DCD180", VA = "0x182DCE380", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA631A30", Offset = "0xA630830", VA = "0x18A631A30", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x172E060", Offset = "0x172CE60", VA = "0x18172E060", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xA636950", Offset = "0xA635750", VA = "0x18A636950")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xA636D60", Offset = "0xA635B60", VA = "0x18A636D60", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0xA636D50", Offset = "0xA635B50", VA = "0x18A636D50", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA629450", Offset = "0xA628250", VA = "0x18A629450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0xA628900", Offset = "0xA627700", VA = "0x18A628900", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA629180", Offset = "0xA627F80", VA = "0x18A629180", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0xA628D50", Offset = "0xA627B50", VA = "0x18A628D50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA628D50", Offset = "0xA627B50", VA = "0x18A628D50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6365F0", Offset = "0xA6353F0", VA = "0x18A6365F0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xA636680", Offset = "0xA635480", VA = "0x18A636680")]
		public VertexPositionNormalTangent([In] Vector3 p, [In] Vector3 n, [In] Vector4 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6366B0", Offset = "0xA6354B0", VA = "0x18A6366B0")]
		public VertexPositionNormalTangent(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xA636830", Offset = "0xA635630", VA = "0x18A636830")]
		public static implicit operator VertexPositionNormalTangent([In] (Vector3 Pos, Vector3 Nrm, Vector4 Tgt) tuple)
		{
			return default(VertexPositionNormalTangent);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xA6364A0", Offset = "0xA6352A0", VA = "0x18A6364A0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA631840", Offset = "0xA630640", VA = "0x18A631840", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xA636310", Offset = "0xA635110", VA = "0x18A636310", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xA636460", Offset = "0xA635260", VA = "0x18A636460", Slot = "14")]
		public readonly bool Equals(VertexPositionNormalTangent other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA636820", Offset = "0xA635620", VA = "0x18A636820")]
		public static bool operator ==([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0xA636860", Offset = "0xA635660", VA = "0x18A636860")]
		public static bool operator !=([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xA636270", Offset = "0xA635070", VA = "0x18A636270")]
		public static bool AreEqual([In] VertexPositionNormalTangent a, [In] VertexPositionNormalTangent b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB990", Offset = "0x2DCA790", VA = "0x182DCB990", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xA631890", Offset = "0xA630690", VA = "0x18A631890", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xF62020", Offset = "0xF60E20", VA = "0x180F62020", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xA636520", Offset = "0xA635320", VA = "0x18A636520", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xA635D80", Offset = "0xA634B80", VA = "0x18A635D80")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE380", Offset = "0x2DCD180", VA = "0x182DCE380", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0xA631A30", Offset = "0xA630830", VA = "0x18A631A30", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xA6365E0", Offset = "0xA6353E0", VA = "0x18A6365E0", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xA635EF0", Offset = "0xA634CF0", VA = "0x18A635EF0")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA636490", Offset = "0xA635290", VA = "0x18A636490", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA636480", Offset = "0xA635280", VA = "0x18A636480", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6264C0", Offset = "0xA6252C0", VA = "0x18A6264C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xA6261C0", Offset = "0xA624FC0", VA = "0x18A6261C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0xA626480", Offset = "0xA625280", VA = "0x18A626480", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0xA6263D0", Offset = "0xA6251D0", VA = "0x18A6263D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0xA6263D0", Offset = "0xA6251D0", VA = "0x18A6263D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA631AA0", Offset = "0xA6308A0", VA = "0x18A631AA0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA632310", Offset = "0xA631110", VA = "0x18A632310")]
		public static implicit operator VertexGeometryDelta([In] Vector3 position)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xA6322B0", Offset = "0xA6310B0", VA = "0x18A6322B0")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xA632270", Offset = "0xA631070", VA = "0x18A632270")]
		public static implicit operator VertexGeometryDelta([In] (Vector3 Pos, Vector3 Nrm, Vector3 tgt) tuple)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA631E60", Offset = "0xA630C60", VA = "0x18A631E60")]
		public VertexGeometryDelta(IVertexGeometry src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xA631C90", Offset = "0xA630A90", VA = "0x18A631C90")]
		public VertexGeometryDelta([In] Vector3 p, [In] Vector3 n, [In] Vector3 t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA6321B0", Offset = "0xA630FB0", VA = "0x18A6321B0")]
		internal VertexGeometryDelta([In] VertexPosition rootVal, [In] VertexPosition morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA631B80", Offset = "0xA630980", VA = "0x18A631B80")]
		internal VertexGeometryDelta([In] VertexPositionNormal rootVal, [In] VertexPositionNormal morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xA631CD0", Offset = "0xA630AD0", VA = "0x18A631CD0")]
		internal VertexGeometryDelta([In] VertexPositionNormalTangent rootVal, [In] VertexPositionNormalTangent morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA632080", Offset = "0xA630E80", VA = "0x18A632080")]
		internal VertexGeometryDelta([In] VertexGeometryDelta rootVal, [In] VertexGeometryDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA6318F0", Offset = "0xA6306F0", VA = "0x18A6318F0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__13))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xA631840", Offset = "0xA630640", VA = "0x18A631840", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA631790", Offset = "0xA630590", VA = "0x18A631790", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xA631770", Offset = "0xA630570", VA = "0x18A631770", Slot = "14")]
		public readonly bool Equals(VertexGeometryDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA632260", Offset = "0xA631060", VA = "0x18A632260")]
		public static bool operator ==([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0xA632390", Offset = "0xA631190", VA = "0x18A632390")]
		public static bool operator !=([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0xA6316B0", Offset = "0xA6304B0", VA = "0x18A6316B0")]
		public static bool AreEqual([In] VertexGeometryDelta a, [In] VertexGeometryDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x2DCB990", Offset = "0x2DCA790", VA = "0x182DCB990", Slot = "7")]
		void IVertexGeometry.SetPosition([In] Vector3 position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA631890", Offset = "0xA630690", VA = "0x18A631890", Slot = "8")]
		void IVertexGeometry.SetNormal([In] Vector3 normal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA6318A0", Offset = "0xA6306A0", VA = "0x18A6318A0", Slot = "9")]
		void IVertexGeometry.SetTangent([In] Vector4 tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x2DCE380", Offset = "0x2DCD180", VA = "0x182DCE380", Slot = "4")]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0xA631A30", Offset = "0xA630830", VA = "0x18A631A30", Slot = "5")]
		public readonly bool TryGetNormal([Out] Vector3 normal)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0xA631A50", Offset = "0xA630850", VA = "0x18A631A50", Slot = "6")]
		public readonly bool TryGetTangent([Out] Vector4 tangent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0xA631670", Offset = "0xA630470", VA = "0x18A631670")]
		public void ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0xA631970", Offset = "0xA630770", VA = "0x18A631970", Slot = "11")]
		public readonly VertexGeometryDelta Subtract(IVertexGeometry baseValue)
		{
			return default(VertexGeometryDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA631550", Offset = "0xA630350", VA = "0x18A631550")]
		public void Add([In] VertexGeometryDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA631880", Offset = "0xA630680", VA = "0x18A631880", Slot = "10")]
		void IVertexGeometry.ApplyTransform([In] Matrix4x4 xform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xA631870", Offset = "0xA630670", VA = "0x18A631870", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA626F30", Offset = "0xA625D30", VA = "0x18A626F30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0xA626C80", Offset = "0xA625A80", VA = "0x18A626C80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0xA626EF0", Offset = "0xA625CF0", VA = "0x18A626EF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0xA626D70", Offset = "0xA625B70", VA = "0x18A626D70", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xA626D70", Offset = "0xA625B70", VA = "0x18A626D70", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x12AF420", Offset = "0x12AE220", VA = "0x1812AF420")]
		public static implicit operator VertexColor1(Vector4 color)
		{
			return default(VertexColor1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xA62DBE0", Offset = "0xA62C9E0", VA = "0x18A62DBE0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x15210E0", Offset = "0x151FEE0", VA = "0x1815210E0")]
		public VertexColor1(Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xA62DC60", Offset = "0xA62CA60", VA = "0x18A62DC60")]
		public VertexColor1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xA62DAC0", Offset = "0xA62C8C0", VA = "0x18A62DAC0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xA62DA40", Offset = "0xA62C840", VA = "0x18A62DA40", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA62D8F0", Offset = "0xA62C6F0", VA = "0x18A62D8F0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA62D9A0", Offset = "0xA62C7A0", VA = "0x18A62D9A0", Slot = "13")]
		public readonly bool Equals(VertexColor1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA62D9A0", Offset = "0xA62C7A0", VA = "0x18A62D9A0")]
		public static bool operator ==([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA62DDC0", Offset = "0xA62CBC0", VA = "0x18A62DDC0")]
		public static bool operator !=([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA62D8C0", Offset = "0xA62C6C0", VA = "0x18A62D8C0")]
		public static bool AreEqual([In] VertexColor1 a, [In] VertexColor1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA62DB30", Offset = "0xA62C930", VA = "0x18A62DB30", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA62D840", Offset = "0xA62C640", VA = "0x18A62D840")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA62B820", Offset = "0xA62A620", VA = "0x18A62B820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA62D9D0", Offset = "0xA62C7D0", VA = "0x18A62D9D0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA62DA60", Offset = "0xA62C860", VA = "0x18A62DA60", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA62DAB0", Offset = "0xA62C8B0", VA = "0x18A62DAB0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA627E10", Offset = "0xA626C10", VA = "0x18A627E10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xA627740", Offset = "0xA626540", VA = "0x18A627740", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA627D90", Offset = "0xA626B90", VA = "0x18A627D90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xA6278D0", Offset = "0xA6266D0", VA = "0x18A6278D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0xA6278D0", Offset = "0xA6266D0", VA = "0x18A6278D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA6310A0", Offset = "0xA62FEA0", VA = "0x18A6310A0")]
		public static implicit operator VertexColor2((Vector4 Color0, Vector4 Color1) tuple)
		{
			return default(VertexColor2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA630E00", Offset = "0xA62FC00", VA = "0x18A630E00")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x62D9170", Offset = "0x62D7F70", VA = "0x1862D9170")]
		public VertexColor2(Vector4 color0, Vector4 color1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA630E80", Offset = "0xA62FC80", VA = "0x18A630E80")]
		public VertexColor2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA630CD0", Offset = "0xA62FAD0", VA = "0x18A630CD0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA630C20", Offset = "0xA62FA20", VA = "0x18A630C20", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA630A80", Offset = "0xA62F880", VA = "0x18A630A80", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xA630B80", Offset = "0xA62F980", VA = "0x18A630B80", Slot = "13")]
		public readonly bool Equals(VertexColor2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA631090", Offset = "0xA62FE90", VA = "0x18A631090")]
		public static bool operator ==([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA6310C0", Offset = "0xA62FEC0", VA = "0x18A6310C0")]
		public static bool operator !=([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA630A00", Offset = "0xA62F800", VA = "0x18A630A00")]
		public static bool AreEqual([In] VertexColor2 a, [In] VertexColor2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xA630D40", Offset = "0xA62FB40", VA = "0x18A630D40", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xA630910", Offset = "0xA62F710", VA = "0x18A630910")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA62E2E0", Offset = "0xA62D0E0", VA = "0x18A62E2E0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xA630BA0", Offset = "0xA62F9A0", VA = "0x18A630BA0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xA630C70", Offset = "0xA62FA70", VA = "0x18A630C70", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xA630CC0", Offset = "0xA62FAC0", VA = "0x18A630CC0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA626F80", Offset = "0xA625D80", VA = "0x18A626F80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0xA626BA0", Offset = "0xA6259A0", VA = "0x18A626BA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0xA626EB0", Offset = "0xA625CB0", VA = "0x18A626EB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0xA626E10", Offset = "0xA625C10", VA = "0x18A626E10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA626E10", Offset = "0xA625C10", VA = "0x18A626E10", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xDEFAA0", Offset = "0xDEE8A0", VA = "0x180DEFAA0")]
		public static implicit operator VertexTexture1(Vector2 uv)
		{
			return default(VertexTexture1);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xA637C10", Offset = "0xA636A10", VA = "0x18A637C10")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x13F6F50", Offset = "0x13F5D50", VA = "0x1813F6F50")]
		public VertexTexture1(Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA637C90", Offset = "0xA636A90", VA = "0x18A637C90")]
		public VertexTexture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA637AD0", Offset = "0xA6368D0", VA = "0x18A637AD0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__5))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xA637A30", Offset = "0xA636830", VA = "0x18A637A30", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xA637910", Offset = "0xA636710", VA = "0x18A637910", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xA6379C0", Offset = "0xA6367C0", VA = "0x18A6379C0", Slot = "13")]
		public readonly bool Equals(VertexTexture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xA637DA0", Offset = "0xA636BA0", VA = "0x18A637DA0")]
		public static bool operator ==([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA637DD0", Offset = "0xA636BD0", VA = "0x18A637DD0")]
		public static bool operator !=([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xA6378E0", Offset = "0xA6366E0", VA = "0x18A6378E0")]
		public static bool AreEqual([In] VertexTexture1 a, [In] VertexTexture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xA637B50", Offset = "0xA636950", VA = "0x18A637B50", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xA637890", Offset = "0xA636690", VA = "0x18A637890")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA637AC0", Offset = "0xA6368C0", VA = "0x18A637AC0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xA6379E0", Offset = "0xA6367E0", VA = "0x18A6379E0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xA637A50", Offset = "0xA636850", VA = "0x18A637A50", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xA637890", Offset = "0xA636690", VA = "0x18A637890", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA627F00", Offset = "0xA626D00", VA = "0x18A627F00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0xA6275C0", Offset = "0xA6263C0", VA = "0x18A6275C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0xA627D10", Offset = "0xA626B10", VA = "0x18A627D10", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0xA627B50", Offset = "0xA626950", VA = "0x18A627B50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0xA627B50", Offset = "0xA626950", VA = "0x18A627B50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x12AF420", Offset = "0x12AE220", VA = "0x1812AF420")]
		public static implicit operator VertexTexture2((Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexTexture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xA6382B0", Offset = "0xA6370B0", VA = "0x18A6382B0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x310E060", Offset = "0x310CE60", VA = "0x18310E060")]
		public VertexTexture2(Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA638330", Offset = "0xA637130", VA = "0x18A638330")]
		public VertexTexture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA638190", Offset = "0xA636F90", VA = "0x18A638190", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA638090", Offset = "0xA636E90", VA = "0x18A638090", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0xA637F30", Offset = "0xA636D30", VA = "0x18A637F30", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0xA637F10", Offset = "0xA636D10", VA = "0x18A637F10", Slot = "13")]
		public readonly bool Equals(VertexTexture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA6384A0", Offset = "0xA6372A0", VA = "0x18A6384A0")]
		public static bool operator ==([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA6384B0", Offset = "0xA6372B0", VA = "0x18A6384B0")]
		public static bool operator !=([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA637E90", Offset = "0xA636C90", VA = "0x18A637E90")]
		public static bool AreEqual([In] VertexTexture2 a, [In] VertexTexture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA638200", Offset = "0xA637000", VA = "0x18A638200", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xA637E00", Offset = "0xA636C00", VA = "0x18A637E00")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xA638170", Offset = "0xA636F70", VA = "0x18A638170", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA638040", Offset = "0xA636E40", VA = "0x18A638040", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA6380E0", Offset = "0xA636EE0", VA = "0x18A6380E0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA638160", Offset = "0xA636F60", VA = "0x18A638160", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA627E60", Offset = "0xA626C60", VA = "0x18A627E60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0xA626FD0", Offset = "0xA625DD0", VA = "0x18A626FD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0xA627C90", Offset = "0xA626A90", VA = "0x18A627C90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0xA627BF0", Offset = "0xA6269F0", VA = "0x18A627BF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xA627BF0", Offset = "0xA6269F0", VA = "0x18A627BF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x3048B00", Offset = "0x3047900", VA = "0x183048B00")]
		public static implicit operator VertexColor1Texture1((Vector4 Color, Vector2 Tex) tuple)
		{
			return default(VertexColor1Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA62B980", Offset = "0xA62A780", VA = "0x18A62B980")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x6857BF0", Offset = "0x68569F0", VA = "0x186857BF0")]
		public VertexColor1Texture1(Vector4 color, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA62BA00", Offset = "0xA62A800", VA = "0x18A62BA00")]
		public VertexColor1Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA62B840", Offset = "0xA62A640", VA = "0x18A62B840", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA62B740", Offset = "0xA62A540", VA = "0x18A62B740", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA62B5B0", Offset = "0xA62A3B0", VA = "0x18A62B5B0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA62B6B0", Offset = "0xA62A4B0", VA = "0x18A62B6B0", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA62BBB0", Offset = "0xA62A9B0", VA = "0x18A62BBB0")]
		public static bool operator ==([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA62BBC0", Offset = "0xA62A9C0", VA = "0x18A62BBC0")]
		public static bool operator !=([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA62B520", Offset = "0xA62A320", VA = "0x18A62B520")]
		public static bool AreEqual([In] VertexColor1Texture1 a, [In] VertexColor1Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA62B8C0", Offset = "0xA62A6C0", VA = "0x18A62B8C0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA62B450", Offset = "0xA62A250", VA = "0x18A62B450")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xA62B820", Offset = "0xA62A620", VA = "0x18A62B820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA62B830", Offset = "0xA62A630", VA = "0x18A62B830", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA62B6D0", Offset = "0xA62A4D0", VA = "0x18A62B6D0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA62B790", Offset = "0xA62A590", VA = "0x18A62B790", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xA62B810", Offset = "0xA62A610", VA = "0x18A62B810", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA629400", Offset = "0xA628200", VA = "0x18A629400", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA627FF0", Offset = "0xA626DF0", VA = "0x18A627FF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA6291C0", Offset = "0xA627FC0", VA = "0x18A6291C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0xA628F40", Offset = "0xA627D40", VA = "0x18A628F40", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0xA628F40", Offset = "0xA627D40", VA = "0x18A628F40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D940E0", Offset = "0x2D92EE0", VA = "0x182D940E0")]
		public static implicit operator VertexColor1Texture2((Vector4 Color, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor1Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0xA62C140", Offset = "0xA62AF40", VA = "0x18A62C140")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x821B2A0", Offset = "0x821A0A0", VA = "0x18821B2A0")]
		public VertexColor1Texture2(Vector4 color, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xA62C1C0", Offset = "0xA62AFC0", VA = "0x18A62C1C0")]
		public VertexColor1Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA62C010", Offset = "0xA62AE10", VA = "0x18A62C010", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xA62BED0", Offset = "0xA62ACD0", VA = "0x18A62BED0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0xA62BDC0", Offset = "0xA62ABC0", VA = "0x18A62BDC0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0xA62BDA0", Offset = "0xA62ABA0", VA = "0x18A62BDA0", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0xA62C3D0", Offset = "0xA62B1D0", VA = "0x18A62C3D0")]
		public static bool operator ==([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xA62C3E0", Offset = "0xA62B1E0", VA = "0x18A62C3E0")]
		public static bool operator !=([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xA62BCE0", Offset = "0xA62AAE0", VA = "0x18A62BCE0")]
		public static bool AreEqual([In] VertexColor1Texture2 a, [In] VertexColor1Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xA62C080", Offset = "0xA62AE80", VA = "0x18A62C080", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA62BBE0", Offset = "0xA62A9E0", VA = "0x18A62BBE0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA62B820", Offset = "0xA62A620", VA = "0x18A62B820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA62BFF0", Offset = "0xA62ADF0", VA = "0x18A62BFF0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xA62BE60", Offset = "0xA62AC60", VA = "0x18A62BE60", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xA62BF50", Offset = "0xA62AD50", VA = "0x18A62BF50", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA62BFE0", Offset = "0xA62ADE0", VA = "0x18A62BFE0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA629310", Offset = "0xA628110", VA = "0x18A629310", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0xA628B10", Offset = "0xA627910", VA = "0x18A628B10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0xA629140", Offset = "0xA627F40", VA = "0x18A629140", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0xA628FE0", Offset = "0xA627DE0", VA = "0x18A628FE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0xA628FE0", Offset = "0xA627DE0", VA = "0x18A628FE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xA62E770", Offset = "0xA62D570", VA = "0x18A62E770")]
		public static implicit operator VertexColor2Texture1((Vector4 Color0, Vector4 Color1, Vector2 Tex) tuple)
		{
			return default(VertexColor2Texture1);
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA62E460", Offset = "0xA62D260", VA = "0x18A62E460")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x821B570", Offset = "0x821A370", VA = "0x18821B570")]
		public VertexColor2Texture1(Vector4 color0, Vector4 color1, Vector2 texcoord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA62E4F0", Offset = "0xA62D2F0", VA = "0x18A62E4F0")]
		public VertexColor2Texture1(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xA62E310", Offset = "0xA62D110", VA = "0x18A62E310", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA62E1D0", Offset = "0xA62CFD0", VA = "0x18A62E1D0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0xA62DFF0", Offset = "0xA62CDF0", VA = "0x18A62DFF0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xA62DFD0", Offset = "0xA62CDD0", VA = "0x18A62DFD0", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture1 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xA62E760", Offset = "0xA62D560", VA = "0x18A62E760")]
		public static bool operator ==([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xA62E790", Offset = "0xA62D590", VA = "0x18A62E790")]
		public static bool operator !=([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA62DF20", Offset = "0xA62CD20", VA = "0x18A62DF20")]
		public static bool AreEqual([In] VertexColor2Texture1 a, [In] VertexColor2Texture1 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA62E390", Offset = "0xA62D190", VA = "0x18A62E390", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA62DDF0", Offset = "0xA62CBF0", VA = "0x18A62DDF0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA62E2E0", Offset = "0xA62D0E0", VA = "0x18A62E2E0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA62E300", Offset = "0xA62D100", VA = "0x18A62E300", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0xA62E150", Offset = "0xA62CF50", VA = "0x18A62E150", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xA62E250", Offset = "0xA62D050", VA = "0x18A62E250", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xA62E2D0", Offset = "0xA62D0D0", VA = "0x18A62E2D0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA62A4F0", Offset = "0xA6292F0", VA = "0x18A62A4F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0xA629800", Offset = "0xA628600", VA = "0x18A629800", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0xA62A3F0", Offset = "0xA6291F0", VA = "0x18A62A3F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xA62A340", Offset = "0xA629140", VA = "0x18A62A340", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xA62A340", Offset = "0xA629140", VA = "0x18A62A340", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA62F170", Offset = "0xA62DF70", VA = "0x18A62F170")]
		public static implicit operator VertexColor2Texture2((Vector4 Color0, Vector4 Color1, Vector2 Tex0, Vector2 Tex1) tuple)
		{
			return default(VertexColor2Texture2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xA62EE10", Offset = "0xA62DC10", VA = "0x18A62EE10")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x830ABE0", Offset = "0x83099E0", VA = "0x18830ABE0")]
		public VertexColor2Texture2(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xA62EEA0", Offset = "0xA62DCA0", VA = "0x18A62EEA0")]
		public VertexColor2Texture2(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xA62ECC0", Offset = "0xA62DAC0", VA = "0x18A62ECC0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xA62EB60", Offset = "0xA62D960", VA = "0x18A62EB60", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0xA62EA30", Offset = "0xA62D830", VA = "0x18A62EA30", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA62EA10", Offset = "0xA62D810", VA = "0x18A62EA10", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture2 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA62F160", Offset = "0xA62DF60", VA = "0x18A62F160")]
		public static bool operator ==([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA62F190", Offset = "0xA62DF90", VA = "0x18A62F190")]
		public static bool operator !=([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0xA62E920", Offset = "0xA62D720", VA = "0x18A62E920")]
		public static bool AreEqual([In] VertexColor2Texture2 a, [In] VertexColor2Texture2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0xA62ED40", Offset = "0xA62DB40", VA = "0x18A62ED40", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xA62E7B0", Offset = "0xA62D5B0", VA = "0x18A62E7B0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0xA62E2E0", Offset = "0xA62D0E0", VA = "0x18A62E2E0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0xA62ECA0", Offset = "0xA62DAA0", VA = "0x18A62ECA0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xA62EAE0", Offset = "0xA62D8E0", VA = "0x18A62EAE0", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xA62EC00", Offset = "0xA62DA00", VA = "0x18A62EC00", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA62EC90", Offset = "0xA62DA90", VA = "0x18A62EC90", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA626A20", Offset = "0xA625820", VA = "0x18A626A20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084C")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0xA626510", Offset = "0xA625310", VA = "0x18A626510", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0xA6269E0", Offset = "0xA6257E0", VA = "0x18A6269E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA626910", Offset = "0xA625710", VA = "0x18A626910", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0xA626910", Offset = "0xA625710", VA = "0x18A626910", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA635B80", Offset = "0xA634980", VA = "0x18A635B80")]
			get
			{
				return default(VertexMaterialDelta);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		public readonly int MaxColors
		{
			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xD03CD0", Offset = "0xD02AD0", VA = "0x180D03CD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xD03CE0", Offset = "0xD02AE0", VA = "0x180D03CE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xA633C40", Offset = "0xA632A40", VA = "0x18A633C40")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xA635C80", Offset = "0xA634A80", VA = "0x18A635C80")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0xA635D20", Offset = "0xA634B20", VA = "0x18A635D20")]
		public static implicit operator VertexMaterialDelta([In] (Vector4 Color0Delta, Vector4 Color1Delta, Vector2 TextCoord0Delta, Vector2 TextCoord1Delta, Vector2 TextCoord2Delta, Vector2 TextCoord3Delta) tuple)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xA634EC0", Offset = "0xA633CC0", VA = "0x18A634EC0")]
		public VertexMaterialDelta(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xA635290", Offset = "0xA634090", VA = "0x18A635290")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0xA634160", Offset = "0xA632F60", VA = "0x18A634160")]
		public VertexMaterialDelta([In] Vector4 color0Delta, [In] Vector4 color1Delta, [In] Vector2 texCoord0Delta, [In] Vector2 texCoord1Delta, [In] Vector2 texCoord2Delta, [In] Vector2 texCoord3Delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0xA634790", Offset = "0xA633590", VA = "0x18A634790")]
		internal VertexMaterialDelta([In] VertexMaterialDelta rootVal, [In] VertexMaterialDelta morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xA633AC0", Offset = "0xA6328C0", VA = "0x18A633AC0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__15))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA633880", Offset = "0xA632680", VA = "0x18A633880", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA633730", Offset = "0xA632530", VA = "0x18A633730", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA633710", Offset = "0xA632510", VA = "0x18A633710", Slot = "13")]
		public readonly bool Equals(VertexMaterialDelta other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA635C70", Offset = "0xA634A70", VA = "0x18A635C70")]
		public static bool operator ==([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xA635D60", Offset = "0xA634B60", VA = "0x18A635D60")]
		public static bool operator !=([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xA6335B0", Offset = "0xA6323B0", VA = "0x18A6335B0")]
		public static bool AreEqual([In] VertexMaterialDelta a, [In] VertexMaterialDelta b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xA633B60", Offset = "0xA632960", VA = "0x18A633B60", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xA62FCE0", Offset = "0xA62EAE0", VA = "0x18A62FCE0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xA62E2E0", Offset = "0xA62D0E0", VA = "0x18A62E2E0", Slot = "8")]
		void IVertexMaterial.SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xA62E2E0", Offset = "0xA62D0E0", VA = "0x18A62E2E0")]
		private void SetColor(int setIndex, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xA633A30", Offset = "0xA632830", VA = "0x18A633A30", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA630350", Offset = "0xA62F150", VA = "0x18A630350")]
		private void SetTexCoord(int setIndex, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA633800", Offset = "0xA632600", VA = "0x18A633800", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xA633960", Offset = "0xA632760", VA = "0x18A633960", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA634DB0", Offset = "0xA633BB0", VA = "0x18A634DB0")]
		internal VertexMaterialDelta([In] VertexTexture1 rootVal, [In] VertexTexture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xA634660", Offset = "0xA633460", VA = "0x18A634660")]
		internal VertexMaterialDelta([In] VertexTexture2 rootVal, [In] VertexTexture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA634010", Offset = "0xA632E10", VA = "0x18A634010")]
		internal VertexMaterialDelta([In] VertexTexture3 rootVal, [In] VertexTexture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA634500", Offset = "0xA633300", VA = "0x18A634500")]
		internal VertexMaterialDelta([In] VertexTexture4 rootVal, [In] VertexTexture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA635A60", Offset = "0xA634860", VA = "0x18A635A60")]
		internal VertexMaterialDelta([In] VertexColor1 rootVal, [In] VertexColor1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA6341F0", Offset = "0xA632FF0", VA = "0x18A6341F0")]
		internal VertexMaterialDelta([In] VertexColor1Texture1 rootVal, [In] VertexColor1Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA634A40", Offset = "0xA633840", VA = "0x18A634A40")]
		internal VertexMaterialDelta([In] VertexColor1Texture2 rootVal, [In] VertexColor1Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA633E80", Offset = "0xA632C80", VA = "0x18A633E80")]
		internal VertexMaterialDelta([In] VertexColor1Texture3 rootVal, [In] VertexColor1Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA634350", Offset = "0xA633150", VA = "0x18A634350")]
		internal VertexMaterialDelta([In] VertexColor1Texture4 rootVal, [In] VertexColor1Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA6354F0", Offset = "0xA6342F0", VA = "0x18A6354F0")]
		internal VertexMaterialDelta([In] VertexColor2 rootVal, [In] VertexColor2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA635340", Offset = "0xA634140", VA = "0x18A635340")]
		internal VertexMaterialDelta([In] VertexColor2Texture1 rootVal, [In] VertexColor2Texture1 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA635890", Offset = "0xA634690", VA = "0x18A635890")]
		internal VertexMaterialDelta([In] VertexColor2Texture2 rootVal, [In] VertexColor2Texture2 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xA634BC0", Offset = "0xA6339C0", VA = "0x18A634BC0")]
		internal VertexMaterialDelta([In] VertexColor2Texture3 rootVal, [In] VertexColor2Texture3 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA635680", Offset = "0xA634480", VA = "0x18A635680")]
		internal VertexMaterialDelta([In] VertexColor2Texture4 rootVal, [In] VertexColor2Texture4 morphVal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA630340", Offset = "0xA62F140", VA = "0x18A630340", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA627FA0", Offset = "0xA626DA0", VA = "0x18A627FA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0xA627230", Offset = "0xA626030", VA = "0x18A627230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0xA627DD0", Offset = "0xA626BD0", VA = "0x18A627DD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0xA627970", Offset = "0xA626770", VA = "0x18A627970", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xA627970", Offset = "0xA626770", VA = "0x18A627970", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xA638A10", Offset = "0xA637810", VA = "0x18A638A10")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x81B5310", Offset = "0x81B4110", VA = "0x1881B5310")]
		public VertexTexture3(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xA638A90", Offset = "0xA637890", VA = "0x18A638A90")]
		public VertexTexture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA6388D0", Offset = "0xA6376D0", VA = "0x18A6388D0", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA638790", Offset = "0xA637590", VA = "0x18A638790", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA638690", Offset = "0xA637490", VA = "0x18A638690", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA638670", Offset = "0xA637470", VA = "0x18A638670", Slot = "13")]
		public readonly bool Equals(VertexTexture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA638C50", Offset = "0xA637A50", VA = "0x18A638C50")]
		public static bool operator ==([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA638C60", Offset = "0xA637A60", VA = "0x18A638C60")]
		public static bool operator !=([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA6385B0", Offset = "0xA6373B0", VA = "0x18A6385B0")]
		public static bool AreEqual([In] VertexTexture3 a, [In] VertexTexture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA638950", Offset = "0xA637750", VA = "0x18A638950", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA6384D0", Offset = "0xA6372D0", VA = "0x18A6384D0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xA6388B0", Offset = "0xA6376B0", VA = "0x18A6388B0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA638740", Offset = "0xA637540", VA = "0x18A638740", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA638800", Offset = "0xA637600", VA = "0x18A638800", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xA6388A0", Offset = "0xA6376A0", VA = "0x18A6388A0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA6292C0", Offset = "0xA6280C0", VA = "0x18A6292C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xA6283A0", Offset = "0xA6271A0", VA = "0x18A6283A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xA629240", Offset = "0xA628040", VA = "0x18A629240", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA628E00", Offset = "0xA627C00", VA = "0x18A628E00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA628E00", Offset = "0xA627C00", VA = "0x18A628E00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0xD550F0", Offset = "0xD53EF0", VA = "0x180D550F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0xA639260", Offset = "0xA638060", VA = "0x18A639260")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0xA6392E0", Offset = "0xA6380E0", VA = "0x18A6392E0")]
		public VertexTexture4(Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA639300", Offset = "0xA638100", VA = "0x18A639300")]
		public VertexTexture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA639130", Offset = "0xA637F30", VA = "0x18A639130", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0xA638F90", Offset = "0xA637D90", VA = "0x18A638F90", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xA638E80", Offset = "0xA637C80", VA = "0x18A638E80", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0xA638F20", Offset = "0xA637D20", VA = "0x18A638F20", Slot = "13")]
		public readonly bool Equals(VertexTexture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xA639510", Offset = "0xA638310", VA = "0x18A639510")]
		public static bool operator ==([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xA639520", Offset = "0xA638320", VA = "0x18A639520")]
		public static bool operator !=([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xA638D90", Offset = "0xA637B90", VA = "0x18A638D90")]
		public static bool AreEqual([In] VertexTexture4 a, [In] VertexTexture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA6391A0", Offset = "0xA637FA0", VA = "0x18A6391A0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA638C80", Offset = "0xA637A80", VA = "0x18A638C80")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0xA639100", Offset = "0xA637F00", VA = "0x18A639100", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xA638F40", Offset = "0xA637D40", VA = "0x18A638F40", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA639030", Offset = "0xA637E30", VA = "0x18A639030", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0xA6390F0", Offset = "0xA637EF0", VA = "0x18A6390F0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA629360", Offset = "0xA628160", VA = "0x18A629360", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0xA628640", Offset = "0xA627440", VA = "0x18A628640", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xA629200", Offset = "0xA628000", VA = "0x18A629200", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0xA629090", Offset = "0xA627E90", VA = "0x18A629090", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0xA629090", Offset = "0xA627E90", VA = "0x18A629090", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA62CA50", Offset = "0xA62B850", VA = "0x18A62CA50")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA62CAE0", Offset = "0xA62B8E0", VA = "0x18A62CAE0")]
		public VertexColor1Texture3(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA62CB00", Offset = "0xA62B900", VA = "0x18A62CB00")]
		public VertexColor1Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA62C900", Offset = "0xA62B700", VA = "0x18A62C900", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__7))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA62C780", Offset = "0xA62B580", VA = "0x18A62C780", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA62C660", Offset = "0xA62B460", VA = "0x18A62C660", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA62C640", Offset = "0xA62B440", VA = "0x18A62C640", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0xA62CD60", Offset = "0xA62BB60", VA = "0x18A62CD60")]
		public static bool operator ==([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xA62CD70", Offset = "0xA62BB70", VA = "0x18A62CD70")]
		public static bool operator !=([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA62C540", Offset = "0xA62B340", VA = "0x18A62C540")]
		public static bool AreEqual([In] VertexColor1Texture3 a, [In] VertexColor1Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xA62C980", Offset = "0xA62B780", VA = "0x18A62C980", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xA62C400", Offset = "0xA62B200", VA = "0x18A62C400")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xA62B820", Offset = "0xA62A620", VA = "0x18A62B820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0xA62C8E0", Offset = "0xA62B6E0", VA = "0x18A62C8E0", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0xA62C710", Offset = "0xA62B510", VA = "0x18A62C710", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xA62C820", Offset = "0xA62B620", VA = "0x18A62C820", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xA62C8D0", Offset = "0xA62B6D0", VA = "0x18A62C8D0", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA62A5E0", Offset = "0xA6293E0", VA = "0x18A62A5E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0xA6294A0", Offset = "0xA6282A0", VA = "0x18A6294A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0xA62A470", Offset = "0xA629270", VA = "0x18A62A470", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0xA62A1D0", Offset = "0xA628FD0", VA = "0x18A62A1D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0xA62A1D0", Offset = "0xA628FD0", VA = "0x18A62A1D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xD550F0", Offset = "0xD53EF0", VA = "0x180D550F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0xA62D4A0", Offset = "0xA62C2A0", VA = "0x18A62D4A0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0xA62D7E0", Offset = "0xA62C5E0", VA = "0x18A62D7E0")]
		public VertexColor1Texture4(Vector4 color, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA62D530", Offset = "0xA62C330", VA = "0x18A62D530")]
		public VertexColor1Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA62D350", Offset = "0xA62C150", VA = "0x18A62D350", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xA62D180", Offset = "0xA62BF80", VA = "0x18A62D180", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0xA62D040", Offset = "0xA62BE40", VA = "0x18A62D040", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xA62D0F0", Offset = "0xA62BEF0", VA = "0x18A62D0F0", Slot = "13")]
		public readonly bool Equals(VertexColor1Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0xA62D810", Offset = "0xA62C610", VA = "0x18A62D810")]
		public static bool operator ==([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xA62D820", Offset = "0xA62C620", VA = "0x18A62D820")]
		public static bool operator !=([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xA62CF10", Offset = "0xA62BD10", VA = "0x18A62CF10")]
		public static bool AreEqual([In] VertexColor1Texture4 a, [In] VertexColor1Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xA62D3D0", Offset = "0xA62C1D0", VA = "0x18A62D3D0", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0xA62CD90", Offset = "0xA62BB90", VA = "0x18A62CD90")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0xA62B820", Offset = "0xA62A620", VA = "0x18A62B820", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0xA62D320", Offset = "0xA62C120", VA = "0x18A62D320", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xA62D110", Offset = "0xA62BF10", VA = "0x18A62D110", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xA62D240", Offset = "0xA62C040", VA = "0x18A62D240", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA62D310", Offset = "0xA62C110", VA = "0x18A62D310", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA62A590", Offset = "0xA629390", VA = "0x18A62A590", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D4")]
			[Cpp2IlInjected.Address(RVA = "0xA629DA0", Offset = "0xA628BA0", VA = "0x18A629DA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xA62A4B0", Offset = "0xA6292B0", VA = "0x18A62A4B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008D8")]
			[Cpp2IlInjected.Address(RVA = "0xA62A280", Offset = "0xA629080", VA = "0x18A62A280", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0xA62A280", Offset = "0xA629080", VA = "0x18A62A280", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xA62F8E0", Offset = "0xA62E6E0", VA = "0x18A62F8E0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0xA62FC80", Offset = "0xA62EA80", VA = "0x18A62FC80")]
		public VertexColor2Texture3(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0xA62F970", Offset = "0xA62E770", VA = "0x18A62F970")]
		public VertexColor2Texture3(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0xA62F780", Offset = "0xA62E580", VA = "0x18A62F780", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0xA62F5F0", Offset = "0xA62E3F0", VA = "0x18A62F5F0", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0xA62F4B0", Offset = "0xA62E2B0", VA = "0x18A62F4B0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xA62F490", Offset = "0xA62E290", VA = "0x18A62F490", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture3 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0xA62FCB0", Offset = "0xA62EAB0", VA = "0x18A62FCB0")]
		public static bool operator ==([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0xA62FCC0", Offset = "0xA62EAC0", VA = "0x18A62FCC0")]
		public static bool operator !=([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0xA62F360", Offset = "0xA62E160", VA = "0x18A62F360")]
		public static bool AreEqual([In] VertexColor2Texture3 a, [In] VertexColor2Texture3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0xA62F810", Offset = "0xA62E610", VA = "0x18A62F810", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0xA62F1B0", Offset = "0xA62DFB0", VA = "0x18A62F1B0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0xA62E2E0", Offset = "0xA62D0E0", VA = "0x18A62E2E0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xA62F760", Offset = "0xA62E560", VA = "0x18A62F760", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xA62F570", Offset = "0xA62E370", VA = "0x18A62F570", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xA62F6A0", Offset = "0xA62E4A0", VA = "0x18A62F6A0", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0xA62F750", Offset = "0xA62E550", VA = "0x18A62F750", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA62AB30", Offset = "0xA629930", VA = "0x18A62AB30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0xA62A630", Offset = "0xA629430", VA = "0x18A62A630", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0xA62AAF0", Offset = "0xA6298F0", VA = "0x18A62AAF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0xA62AA30", Offset = "0xA629830", VA = "0x18A62AA30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0xA62AA30", Offset = "0xA629830", VA = "0x18A62AA30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD512A0", Offset = "0xD500A0", VA = "0x180D512A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public readonly int MaxTextCoords
		{
			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0xD550F0", Offset = "0xD53EF0", VA = "0x180D550F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xA6304E0", Offset = "0xA62F2E0", VA = "0x18A6304E0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x83330A0", Offset = "0x8331EA0", VA = "0x1883330A0")]
		public VertexColor2Texture4(Vector4 color0, Vector4 color1, Vector2 texcoord0, Vector2 texcoord1, Vector2 texcoord2, Vector2 texcoord3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xA630570", Offset = "0xA62F370", VA = "0x18A630570")]
		public VertexColor2Texture4(IVertexMaterial src)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xA630380", Offset = "0xA62F180", VA = "0x18A630380", Slot = "12")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__9))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xA630190", Offset = "0xA62EF90", VA = "0x18A630190", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xA630030", Offset = "0xA62EE30", VA = "0x18A630030", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xA6300F0", Offset = "0xA62EEF0", VA = "0x18A6300F0", Slot = "13")]
		public readonly bool Equals(VertexColor2Texture4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xA6308E0", Offset = "0xA62F6E0", VA = "0x18A6308E0")]
		public static bool operator ==([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xA6308F0", Offset = "0xA62F6F0", VA = "0x18A6308F0")]
		public static bool operator !=([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xA62FED0", Offset = "0xA62ECD0", VA = "0x18A62FED0")]
		public static bool AreEqual([In] VertexColor2Texture4 a, [In] VertexColor2Texture4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0xA630410", Offset = "0xA62F210", VA = "0x18A630410", Slot = "10")]
		public readonly VertexMaterialDelta Subtract(IVertexMaterial baseValue)
		{
			return default(VertexMaterialDelta);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xA62FCE0", Offset = "0xA62EAE0", VA = "0x18A62FCE0")]
		public void Add([In] VertexMaterialDelta delta)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xA62E2E0", Offset = "0xA62D0E0", VA = "0x18A62E2E0", Slot = "8")]
		void IVertexMaterial.SetColor(int index, Vector4 color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xA630350", Offset = "0xA62F150", VA = "0x18A630350", Slot = "9")]
		void IVertexMaterial.SetTexCoord(int index, Vector2 coord)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xA630110", Offset = "0xA62EF10", VA = "0x18A630110", Slot = "6")]
		public readonly Vector4 GetColor(int index)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xA630270", Offset = "0xA62F070", VA = "0x18A630270", Slot = "7")]
		public readonly Vector2 GetTexCoord(int index)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xA630340", Offset = "0xA62F140", VA = "0x18A630340", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x85344A0", Offset = "0x85332A0", VA = "0x1885344A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x8534420", Offset = "0x8533220", VA = "0x188534420")]
		public void Append(VertexGeometryPreprocessor<TvG> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x85343A0", Offset = "0x85331A0", VA = "0x1885343A0")]
		public void Append(VertexMaterialPreprocessor<TvM> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x8534320", Offset = "0x8533120", VA = "0x188534320")]
		public void Append(VertexSkinningPreprocessor<TvS> func)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x8538E20", Offset = "0x8537C20", VA = "0x188538E20")]
		public void SetValidationPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x85374B0", Offset = "0x85362B0", VA = "0x1885374B0")]
		public void SetSanitizerPreprocessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x8535850", Offset = "0x8534650", VA = "0x188535850")]
		public bool PreprocessVertex(VertexBuilder<TvG, TvM, TvS> vertex)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x85392C0", Offset = "0x85380C0", VA = "0x1885392C0")]
		public VertexPreprocessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	internal static class VertexPreprocessorLambdas
	{
		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x40D7380", Offset = "0x40D6180", VA = "0x1840D7380")]
		public static TvG? ValidateVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x40D8950", Offset = "0x40D7750", VA = "0x1840D8950")]
		public static TvM? ValidateVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x40DD740", Offset = "0x40DC540", VA = "0x1840DD740")]
		public static TvS? ValidateVertexSkinning<TvS>(TvS vertex) where TvS : struct, IVertexSkinning
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x40D2490", Offset = "0x40D1290", VA = "0x1840D2490")]
		public static TvG? SanitizeVertexGeometry<TvG>(TvG vertex) where TvG : struct, IVertexGeometry
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x40D46B0", Offset = "0x40D34B0", VA = "0x1840D46B0")]
		public static TvM? SanitizeVertexMaterial<TvM>(TvM vertex) where TvM : struct, IVertexMaterial
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x40D6950", Offset = "0x40D5750", VA = "0x1840D6950")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA627F50", Offset = "0xA626D50", VA = "0x18A627F50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0xA627440", Offset = "0xA626240", VA = "0x18A627440", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0xA627D50", Offset = "0xA626B50", VA = "0x18A627D50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0xA627AB0", Offset = "0xA6268B0", VA = "0x18A627AB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000935")]
			[Cpp2IlInjected.Address(RVA = "0xA627AB0", Offset = "0xA6268B0", VA = "0x18A627AB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD550F0", Offset = "0xD53EF0", VA = "0x180D550F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x12AF420", Offset = "0x12AE220", VA = "0x1812AF420", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xA631520", Offset = "0xA630320", VA = "0x18A631520", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xEF8290", Offset = "0xEF7090", VA = "0x180EF8290", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xA631520", Offset = "0xA630320", VA = "0x18A631520", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xA6327B0", Offset = "0xA6315B0", VA = "0x18A6327B0")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xA632A00", Offset = "0xA631800", VA = "0x18A632A00")]
		public VertexJoints4(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0xA632A60", Offset = "0xA631860", VA = "0x18A632A60")]
		public VertexJoints4(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0xA632830", Offset = "0xA631630", VA = "0x18A632830")]
		public VertexJoints4([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0xA632740", Offset = "0xA631540", VA = "0x18A632740", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__6))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xA62DA40", Offset = "0xA62C840", VA = "0x18A62DA40", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0xA632440", Offset = "0xA631240", VA = "0x18A632440", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0xA632420", Offset = "0xA631220", VA = "0x18A632420", Slot = "14")]
		public readonly bool Equals(VertexJoints4 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0xA632AD0", Offset = "0xA6318D0", VA = "0x18A632AD0")]
		public static bool operator ==([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xA632AE0", Offset = "0xA6318E0", VA = "0x18A632AE0")]
		public static bool operator !=([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0xA6323B0", Offset = "0xA6311B0", VA = "0x18A6323B0")]
		public static bool AreEqual([In] VertexJoints4 a, [In] VertexJoints4 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0xA632620", Offset = "0xA631420", VA = "0x18A632620", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0xA632700", Offset = "0xA631500", VA = "0x18A632700")]
		public void SetBindings([In] SparseWeight8 bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0xA632670", Offset = "0xA631470", VA = "0x18A632670", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0xA632540", Offset = "0xA631340", VA = "0x18A632540", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0xA632700", Offset = "0xA631500", VA = "0x18A632700", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x12AF400", Offset = "0x12AE200", VA = "0x1812AF400", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA62A540", Offset = "0xA629340", VA = "0x18A62A540", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x1397010", Offset = "0x1395E10", VA = "0x181397010")]
			[DebuggerHidden]
			public <SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094C")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0xA629AD0", Offset = "0xA6288D0", VA = "0x18A629AD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0xA62A430", Offset = "0xA629230", VA = "0x18A62A430", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0xA62A110", Offset = "0xA628F10", VA = "0x18A62A110", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<KeyValuePair<string, AttributeFormat>> IEnumerable<KeyValuePair<string, AttributeFormat>>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xA62A110", Offset = "0xA628F10", VA = "0x18A62A110", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xF04BB0", Offset = "0xF039B0", VA = "0x180F04BB0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x12AF420", Offset = "0x12AE220", VA = "0x1812AF420", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0xEF8290", Offset = "0xEF7090", VA = "0x180EF8290", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xEDC830", Offset = "0xEDB630", VA = "0x180EDC830", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xF71A30", Offset = "0xF70830", VA = "0x180F71A30", Slot = "12")]
			get
			{
				return default(Vector4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xA633070", Offset = "0xA631E70", VA = "0x18A633070")]
		private readonly string _GetDebuggerDisplay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xA633490", Offset = "0xA632290", VA = "0x18A633490")]
		public VertexJoints8(int jointIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xA633510", Offset = "0xA632310", VA = "0x18A633510")]
		public VertexJoints8(params (int JointIndex, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xA633100", Offset = "0xA631F00", VA = "0x18A633100")]
		public VertexJoints8([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xA632FE0", Offset = "0xA631DE0", VA = "0x18A632FE0", Slot = "13")]
		[IteratorStateMachine(typeof(<SharpGLTF-Geometry-VertexTypes-IVertexReflection-GetEncodingAttributes>d__8))]
		IEnumerable<KeyValuePair<string, AttributeFormat>> IVertexReflection.GetEncodingAttributes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xA62DA40", Offset = "0xA62C840", VA = "0x18A62DA40", Slot = "2")]
		public override readonly int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xA632BF0", Offset = "0xA6319F0", VA = "0x18A632BF0", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xA632BD0", Offset = "0xA6319D0", VA = "0x18A632BD0", Slot = "14")]
		public readonly bool Equals(VertexJoints8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xA633580", Offset = "0xA632380", VA = "0x18A633580")]
		public static bool operator ==([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xA633590", Offset = "0xA632390", VA = "0x18A633590")]
		public static bool operator !=([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xA632B00", Offset = "0xA631900", VA = "0x18A632B00")]
		public static bool AreEqual([In] VertexJoints8 a, [In] VertexJoints8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xA632E70", Offset = "0xA631C70", VA = "0x18A632E70", Slot = "8")]
		public readonly SparseWeight8 GetBindings()
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0xA632ED0", Offset = "0xA631CD0", VA = "0x18A632ED0")]
		public void SetBindings([In] SparseWeight8 weights)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0xA632F30", Offset = "0xA631D30", VA = "0x18A632F30", Slot = "7")]
		public void SetBindings(params (int Index, float Weight)[] bindings)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0xA632CB0", Offset = "0xA631AB0", VA = "0x18A632CB0", Slot = "5")]
		public readonly (int, float) GetBinding(int index)
		{
			return default((int, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0xA632ED0", Offset = "0xA631CD0", VA = "0x18A632ED0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x40EDF30", Offset = "0x40ECD30", VA = "0x1840EDF30")]
		public static MemoryAccessor CreateVertexMemoryAccessor<TVertex>(this IReadOnlyList<TVertex> vertices, string attributeName, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x40EEAC0", Offset = "0x40ED8C0", VA = "0x1840EEAC0")]
		public static MemoryAccessor[] CreateVertexMemoryAccessors<TVertex>(this IReadOnlyList<TVertex> vertices, PackedEncoding vertexEncoding) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x40F01B0", Offset = "0x40EEFB0", VA = "0x1840F01B0")]
		private static void FillAccessor<TVertex>(this MemoryAccessor dstAccessor, IReadOnlyList<TVertex> srcVertices) where TVertex : IVertexBuilder
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xA639540", Offset = "0xA638340", VA = "0x18A639540")]
		public static MemoryAccessor CreateIndexMemoryAccessor(this IReadOnlyList<int> indices, EncodingType indexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xA639830", Offset = "0xA638630", VA = "0x18A639830")]
		public static MemoryAccessInfo[] GetVertexAttributes(this IVertexBuilder firstVertex, int vertexCount, PackedEncoding vertexEncoding)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xA644F90", Offset = "0xA643D90", VA = "0x18A644F90")]
		private static Converter<IVertexBuilder, object> _GetVertexBuilderAttributeFunc(string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xA6465A0", Offset = "0xA6453A0", VA = "0x18A6465A0")]
		private static object _GetVertexBuilderCustomAttributeFunc(IVertexMaterial vertex, string attributeName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x40F2210", Offset = "0x40F1010", VA = "0x1840F2210")]
		private static TColumn[] _GetColumn<TColumn, TVertex>(this IReadOnlyList<TVertex> vertices, Converter<IVertexBuilder, object> func) where TVertex : IVertexBuilder
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xA644050", Offset = "0xA642E50", VA = "0x18A644050")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(params string[] vertexAttributes)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x40E6C40", Offset = "0x40E5A40", VA = "0x1840E6C40")]
		public static TvP ConvertToGeometry<TvP>(this IVertexGeometry src) where TvP : struct, IVertexGeometry
		{
			return (TvP)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x40E9790", Offset = "0x40E8590", VA = "0x1840E9790")]
		public static TvM ConvertToMaterial<TvM>(this IVertexMaterial src) where TvM : struct, IVertexMaterial
		{
			return (TvM)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x40ED2A0", Offset = "0x40EC0A0", VA = "0x1840ED2A0")]
		public static TvS ConvertToSkinning<TvS>(this IVertexSkinning src) where TvS : struct, IVertexSkinning
		{
			return (TvS)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0xA63A5D0", Offset = "0xA6393D0", VA = "0x18A63A5D0")]
		public static (Type, Func<IVertexBuilder>) GetVertexBuilderType(bool hasNormals, bool hasTangents, int numCols, int numUV, int numJoints)
		{
			return default((Type, Func<IVertexBuilder>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0xA6446C0", Offset = "0xA6434C0", VA = "0x18A6446C0")]
		public static string _GetDebuggerDisplay(IVertexGeometry geo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0xA6449A0", Offset = "0xA6437A0", VA = "0x18A6449A0")]
		public static string _GetDebuggerDisplay(IVertexMaterial mat)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0xA644D50", Offset = "0xA643B50", VA = "0x18A644D50")]
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
			[Cpp2IlInjected.Address(RVA = "0x5138F80", Offset = "0x5137D80", VA = "0x185138F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x5138DD0", Offset = "0x5137BD0", VA = "0x185138DD0")]
		public _CurveBuilderDebugProxy(CurveBuilder<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x5137F10", Offset = "0x5136D10", VA = "0x185137F10")]
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
		[Cpp2IlInjected.Address(RVA = "0xA64DE30", Offset = "0xA64CC30", VA = "0x18A64DE30")]
		public _CurveBuilderDebugProxyBoolean(CurveBuilder<bool> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0xA64DDF0", Offset = "0xA64CBF0", VA = "0x18A64DDF0", Slot = "4")]
		protected override bool GetTangent(bool a, bool b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	internal sealed class _CurveBuilderDebugProxyVector3 : _CurveBuilderDebugProxy<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0xA64DF90", Offset = "0xA64CD90", VA = "0x18A64DF90")]
		public _CurveBuilderDebugProxyVector3(CurveBuilder<Vector3> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A14")]
		[Cpp2IlInjected.Address(RVA = "0xA64DF20", Offset = "0xA64CD20", VA = "0x18A64DF20", Slot = "4")]
		protected override Vector3 GetTangent(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	internal sealed class _CurveBuilderDebugProxyQuaternion : _CurveBuilderDebugProxy<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A15")]
		[Cpp2IlInjected.Address(RVA = "0xA64DE80", Offset = "0xA64CC80", VA = "0x18A64DE80")]
		public _CurveBuilderDebugProxyQuaternion(CurveBuilder<Quaternion> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A16")]
		[Cpp2IlInjected.Address(RVA = "0xA647360", Offset = "0xA646160", VA = "0x18A647360", Slot = "4")]
		protected override Quaternion GetTangent(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	internal sealed class _CurveBuilderDebugProxySparse : _CurveBuilderDebugProxy<SparseWeight8>
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0xA64DED0", Offset = "0xA64CCD0", VA = "0x18A64DED0")]
		public _CurveBuilderDebugProxySparse(CurveBuilder<SparseWeight8> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0xA647FF0", Offset = "0xA646DF0", VA = "0x18A647FF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6651620", Offset = "0x6650420", VA = "0x186651620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A24")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A25")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A26")]
			[Cpp2IlInjected.Address(RVA = "0xFFF0A0", Offset = "0xFFDEA0", VA = "0x180FFF0A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A28")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__16(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x665B4D0", Offset = "0x665A2D0", VA = "0x18665B4D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0xFFF0A0", Offset = "0xFFDEA0", VA = "0x180FFF0A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B6E0B0", Offset = "0x5B6CEB0", VA = "0x185B6E0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public TValue this[TKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x5B6E1E0", Offset = "0x5B6CFE0", VA = "0x185B6E1E0", Slot = "6")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public IEnumerable<TKey> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x5B6E220", Offset = "0x5B6D020", VA = "0x185B6E220", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		public IEnumerable<TValue> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0x5B6E260", Offset = "0x5B6D060", VA = "0x185B6E260", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A19")]
		[Cpp2IlInjected.Address(RVA = "0x56A94D0", Offset = "0x56A82D0", VA = "0x1856A94D0")]
		static EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private EmptyDictionary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "4")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x5B6E070", Offset = "0x5B6CE70", VA = "0x185B6E070", Slot = "5")]
		public bool TryGetValue(TKey key, [Out] TValue value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x5B6DF50", Offset = "0x5B6CD50", VA = "0x185B6DF50", Slot = "10")]
		[IteratorStateMachine(typeof(EmptyDictionary<, >.<GetEnumerator>d__15))]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x5B6E010", Offset = "0x5B6CE10", VA = "0x185B6E010", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x5005770", Offset = "0x5004570", VA = "0x185005770", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64BE7E0", Offset = "0x64BD5E0", VA = "0x1864BE7E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x5106460", Offset = "0x5105260", VA = "0x185106460")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0x665B270", Offset = "0x665A070", VA = "0x18665B270", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x665AF00", Offset = "0x6659D00", VA = "0x18665AF00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x6657200", Offset = "0x6656000", VA = "0x186657200", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6657200", Offset = "0x6656000", VA = "0x186657200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x5106460", Offset = "0x5105260", VA = "0x185106460")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__15(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x665B270", Offset = "0x665A070", VA = "0x18665B270", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0x6E50C70", Offset = "0x6E4FA70", VA = "0x186E50C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A45")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xD6AAC0", Offset = "0xD698C0", VA = "0x180D6AAC0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x7C5B3E0", Offset = "0x7C5A1E0", VA = "0x187C5B3E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B630", Offset = "0x7C5A430", VA = "0x187C5B630")]
		public static implicit operator Triple<T>([In] (T A, T B, T C) triple)
		{
			return default(Triple<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B1C0", Offset = "0x7C59FC0", VA = "0x187C5B1C0")]
		public Triple(T a, T b, T c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A9D0", Offset = "0x7C597D0", VA = "0x187C5A9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A740", Offset = "0x7C59540", VA = "0x187C5A740", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A140", Offset = "0x7C58F40", VA = "0x187C5A140", Slot = "8")]
		public bool Equals(Triple<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B550", Offset = "0x7C5A350", VA = "0x187C5B550")]
		public static bool operator ==([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B950", Offset = "0x7C5A750", VA = "0x187C5B950")]
		public static bool operator !=([In] Triple<T> left, [In] Triple<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A870", Offset = "0x7C59670", VA = "0x187C5A870", Slot = "6")]
		[IteratorStateMachine(typeof(Triple<>.<GetEnumerator>d__14))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B060", Offset = "0x7C59E60", VA = "0x187C5B060", Slot = "7")]
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
				[Cpp2IlInjected.Address(RVA = "0x5148050", Offset = "0x5146E50", VA = "0x185148050", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A60")]
				[Cpp2IlInjected.Address(RVA = "0x5147E10", Offset = "0x5146C10", VA = "0x185147E10", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x5147F90", Offset = "0x5146D90", VA = "0x185147F90")]
			internal _ValueEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A61")]
			[Cpp2IlInjected.Address(RVA = "0x5147870", Offset = "0x5146670", VA = "0x185147870", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A62")]
			[Cpp2IlInjected.Address(RVA = "0x5147BF0", Offset = "0x51469F0", VA = "0x185147BF0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
			public _IndexCollection(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A64")]
			[Cpp2IlInjected.Address(RVA = "0x513CD20", Offset = "0x513BB20", VA = "0x18513CD20", Slot = "4")]
			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0x513CD20", Offset = "0x513BB20", VA = "0x18513CD20", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xCE5110", Offset = "0xCE3F10", VA = "0x180CE5110", Slot = "4")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000163")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000A69")]
				[Cpp2IlInjected.Address(RVA = "0x2409610", Offset = "0x2408410", VA = "0x182409610", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x513E680", Offset = "0x513D480", VA = "0x18513E680")]
			internal _IndexEnumerator(ValueListSet<T> source)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6A")]
			[Cpp2IlInjected.Address(RVA = "0x513D690", Offset = "0x513C490", VA = "0x18513D690", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A6B")]
			[Cpp2IlInjected.Address(RVA = "0x513E600", Offset = "0x513D400", VA = "0x18513E600", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BE0", Offset = "0xCE79E0", VA = "0x180CE8BE0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0x7F73570", Offset = "0x7F72370", VA = "0x187F73570", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public IEnumerable<int> Indices
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x7F72650", Offset = "0x7F71450", VA = "0x187F72650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x7F71CC0", Offset = "0x7F70AC0", VA = "0x187F71CC0")]
		public ValueListSet()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x7F70EC0", Offset = "0x7F6FCC0", VA = "0x187F70EC0")]
		public ValueListSet(int capacity, [Optional] IEqualityComparer<T> comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x7F61C30", Offset = "0x7F60A30", VA = "0x187F61C30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x7F66FF0", Offset = "0x7F65DF0", VA = "0x187F66FF0")]
		public bool Exists(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x7F67BA0", Offset = "0x7F669A0", VA = "0x187F67BA0")]
		public int IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x7F67E80", Offset = "0x7F66C80", VA = "0x187F67E80")]
		public int Use([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x7F602E0", Offset = "0x7F5F0E0", VA = "0x187F602E0")]
		public int Add([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x7F62690", Offset = "0x7F61490", VA = "0x187F62690")]
		public bool Contains([In] T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x7F65C90", Offset = "0x7F64A90", VA = "0x187F65C90")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x7F63FB0", Offset = "0x7F62DB0", VA = "0x187F63FB0")]
		public void CopyTo(ValueListSet<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0x7F678E0", Offset = "0x7F666E0", VA = "0x187F678E0", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x7F678E0", Offset = "0x7F666E0", VA = "0x187F678E0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x7F60BD0", Offset = "0x7F5F9D0", VA = "0x187F60BD0")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x7F6BE70", Offset = "0x7F6AC70", VA = "0x187F6BE70")]
		private void _Initialize(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A59")]
		[Cpp2IlInjected.Address(RVA = "0x7F69530", Offset = "0x7F68330", VA = "0x187F69530")]
		private int _IndexOf([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E1A0", Offset = "0x7F6CFA0", VA = "0x187F6E1A0")]
		private int _Insert([In] T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x7F684B0", Offset = "0x7F672B0", VA = "0x187F684B0")]
		private void _Grow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EFF0", Offset = "0x7F6DDF0", VA = "0x187F6EFF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x513F290", Offset = "0x513E090", VA = "0x18513F290")]
				[CompilerGenerated]
				get
				{
					return (T)null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000A79")]
				[Cpp2IlInjected.Address(RVA = "0x513F340", Offset = "0x513E140", VA = "0x18513F340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0x513F220", Offset = "0x513E020", VA = "0x18513F220")]
			public _KeyComparer(IReadOnlyList<T> items)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0x513ED00", Offset = "0x513DB00", VA = "0x18513ED00", Slot = "4")]
			public bool Equals(int x, int y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0x513F010", Offset = "0x513DE10", VA = "0x18513F010", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x85332F0", Offset = "0x85320F0", VA = "0x1885332F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6E")]
			[Cpp2IlInjected.Address(RVA = "0x85332B0", Offset = "0x85320B0", VA = "0x1885332B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x8533170", Offset = "0x8531F70", VA = "0x188533170")]
		public VertexList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x8532BF0", Offset = "0x85319F0", VA = "0x188532BF0", Slot = "6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x8532BF0", Offset = "0x85319F0", VA = "0x188532BF0", Slot = "7")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x8532E70", Offset = "0x8531C70", VA = "0x188532E70")]
		public int Use([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x8532CA0", Offset = "0x8531AA0", VA = "0x188532CA0")]
		public int IndexOf([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x8532EE0", Offset = "0x8531CE0", VA = "0x188532EE0")]
		private int _Add([In] T v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x8532990", Offset = "0x8531790", VA = "0x188532990")]
		public void ApplyTransform(Func<T, T> transformFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x8532BB0", Offset = "0x85319B0", VA = "0x188532BB0")]
		public void CopyTo(VertexList<T> dst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x8533010", Offset = "0x8531E10", VA = "0x188533010")]
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
		[Cpp2IlInjected.Address(RVA = "0xA64E2F0", Offset = "0xA64D0F0", VA = "0x18A64E2F0")]
		public static bool IsPrime(int candidate)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7D")]
		[Cpp2IlInjected.Address(RVA = "0xA64E0D0", Offset = "0xA64CED0", VA = "0x18A64E0D0")]
		public static int GetPrime(int min)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0xA64E060", Offset = "0xA64CE60", VA = "0x18A64E060")]
		public static int GetMinPrime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0xA64DFE0", Offset = "0xA64CDE0", VA = "0x18A64DFE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0xF3B8B0", Offset = "0xF3A6B0", VA = "0x180F3B8B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		public bool IsAnimated
		{
			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x7356260", Offset = "0x7355060", VA = "0x187356260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		public IReadOnlyDictionary<string, ICurveSampler<T>> Tracks
		{
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x7356320", Offset = "0x7355120", VA = "0x187356320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		internal AnimatableProperty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0x7356010", Offset = "0x7354E10", VA = "0x187356010")]
		internal AnimatableProperty(AnimatableProperty<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x7352B30", Offset = "0x7351930", VA = "0x187352B30")]
		public AnimatableProperty<T> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x7352DA0", Offset = "0x7351BA0", VA = "0x187352DA0")]
		public void RemoveTrack(string track)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x7352CD0", Offset = "0x7351AD0", VA = "0x187352CD0")]
		public T GetValueAt(string track, float offset)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x73533F0", Offset = "0x73521F0", VA = "0x1873533F0")]
		public void SetTrack(string track, ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x7353B90", Offset = "0x7352990", VA = "0x187353B90")]
		public CurveBuilder<T> UseTrackBuilder(string track)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x73537C0", Offset = "0x73525C0", VA = "0x1873537C0")]
		public void SetValue(params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x7353F90", Offset = "0x7352D90", VA = "0x187353F90")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5318CE0", Offset = "0x5317AE0", VA = "0x185318CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		public int MaxDegree
		{
			[Cpp2IlInjected.Token(Token = "0x6000A94")]
			[Cpp2IlInjected.Address(RVA = "0x5318D10", Offset = "0x5317B10", VA = "0x185318D10", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x53185E0", Offset = "0x53173E0", VA = "0x1853185E0")]
		protected CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x5318290", Offset = "0x5317090", VA = "0x185318290")]
		protected CurveBuilder(CurveBuilder<T> other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x5313DC0", Offset = "0x5312BC0", VA = "0x185313DC0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x530E6E0", Offset = "0x530D4E0", VA = "0x18530E6E0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x530ED00", Offset = "0x530DB00", VA = "0x18530ED00")]
		public void RemoveKey(float offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x5313CA0", Offset = "0x5312AA0", VA = "0x185313CA0")]
		public void SetPoint(float offset, bool isLinear, params float[] elements)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x5313A80", Offset = "0x5312880", VA = "0x185313A80")]
		public void SetPoint(float offset, T value, bool isLinear = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x53122B0", Offset = "0x53110B0", VA = "0x1853122B0")]
		public void SetIncomingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x53132B0", Offset = "0x53120B0", VA = "0x1853132B0")]
		public void SetOutgoingTangent(float offset, T tangent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x530E710", Offset = "0x530D510", VA = "0x18530E710")]
		private protected (_CurveNode<T>, _CurveNode<T>, float) FindSample(float offset)
		{
			return default((_CurveNode<T>, _CurveNode<T>, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x530F530", Offset = "0x530E330", VA = "0x18530F530")]
		public void SetCurve(ICurveSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x530ED60", Offset = "0x530DB60", VA = "0x18530ED60")]
		public void SetCurve(IConvertibleCurve<T> convertible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA3")]
		[Cpp2IlInjected.Address(RVA = "0x53107B0", Offset = "0x530F5B0", VA = "0x1853107B0")]
		public void SetCurve(IAnimationSampler<T> curve)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x5318050", Offset = "0x5316E50", VA = "0x185318050")]
		public CurveBuilder<T> WithPoint(float offset, T value, bool isLinear = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x5317CE0", Offset = "0x5316AE0", VA = "0x185317CE0")]
		public CurveBuilder<T> WithIncomingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x5317E90", Offset = "0x5316C90", VA = "0x185317E90")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, T tangent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x5317FC0", Offset = "0x5316DC0", VA = "0x185317FC0")]
		public CurveBuilder<T> WithPoint(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x5317E10", Offset = "0x5316C10", VA = "0x185317E10")]
		public CurveBuilder<T> WithOutgoingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x5317D20", Offset = "0x5316B20", VA = "0x185317D20")]
		public CurveBuilder<T> WithIncomingTangent(float offset, params float[] values)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x53177C0", Offset = "0x53165C0", VA = "0x1853177C0", Slot = "7")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToStepCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x5313DE0", Offset = "0x5312BE0", VA = "0x185313DE0", Slot = "8")]
		IReadOnlyDictionary<float, T> IConvertibleCurve<T>.ToLinearCurve()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x5315610", Offset = "0x5314410", VA = "0x185315610", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x513A510", Offset = "0x5139310", VA = "0x18513A510")]
		private string ToDebuggerDisplayString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x513C2D0", Offset = "0x513B0D0", VA = "0x18513C2D0")]
		private static string _ToString(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x513CA10", Offset = "0x513B810", VA = "0x18513CA10")]
		public _CurveNode(T value, bool isLinear)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x513C6E0", Offset = "0x513B4E0", VA = "0x18513C6E0")]
		public _CurveNode(T incoming, T value, T outgoing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABC")]
		[Cpp2IlInjected.Address(RVA = "0x5139100", Offset = "0x5137F00", VA = "0x185139100")]
		public _CurveNode<T> Clone(Func<T, T> cloneValue)
		{
			return default(_CurveNode<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	internal static class CurveFactory
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x38C5BA0", Offset = "0x38C49A0", VA = "0x1838C5BA0")]
		public static CurveBuilder<T> CreateCurveBuilder<T>() where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x38C6000", Offset = "0x38C4E00", VA = "0x1838C6000")]
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
		[Cpp2IlInjected.Address(RVA = "0xA646EF0", Offset = "0xA645CF0", VA = "0x18A646EF0")]
		public BooleanCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0xA646F30", Offset = "0xA645D30", VA = "0x18A646F30")]
		private BooleanCurveBuilder(BooleanCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0xA646C50", Offset = "0xA645A50", VA = "0x18A646C50", Slot = "10")]
		public override CurveBuilder<bool> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0xA380160", Offset = "0xA37EF60", VA = "0x18A380160", Slot = "11")]
		protected override bool AreEqual(bool left, bool right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x1406A50", Offset = "0x1405850", VA = "0x181406A50", Slot = "12")]
		protected override bool CloneValue(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(RVA = "0xA646CD0", Offset = "0xA645AD0", VA = "0x18A646CD0", Slot = "13")]
		protected override bool CreateValue(IReadOnlyList<float> values)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0xA646EB0", Offset = "0xA645CB0", VA = "0x18A646EB0", Slot = "15")]
		protected override bool GetTangent(bool fromValue, bool toValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0xA646DF0", Offset = "0xA645BF0", VA = "0x18A646DF0", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA64DDB0", Offset = "0xA64CBB0", VA = "0x18A64DDB0")]
		public Vector3CurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0xA64DD60", Offset = "0xA64CB60", VA = "0x18A64DD60")]
		private Vector3CurveBuilder(Vector3CurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0xA64D940", Offset = "0xA64C740", VA = "0x18A64D940", Slot = "10")]
		public override CurveBuilder<Vector3> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACA")]
		[Cpp2IlInjected.Address(RVA = "0xA64D8F0", Offset = "0xA64C6F0", VA = "0x18A64D8F0", Slot = "11")]
		protected override bool AreEqual(Vector3 left, Vector3 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x1043420", Offset = "0x1042220", VA = "0x181043420", Slot = "12")]
		protected override Vector3 CloneValue(Vector3 value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0xA64D9C0", Offset = "0xA64C7C0", VA = "0x18A64D9C0", Slot = "13")]
		protected override Vector3 CreateValue(IReadOnlyList<float> values)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACD")]
		[Cpp2IlInjected.Address(RVA = "0xA64DCF0", Offset = "0xA64CAF0", VA = "0x18A64DCF0", Slot = "15")]
		protected override Vector3 GetTangent(Vector3 fromValue, Vector3 toValue)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0xA64DB40", Offset = "0xA64C940", VA = "0x18A64DB40", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6473B0", Offset = "0xA6461B0", VA = "0x18A6473B0")]
		public QuaternionCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD0")]
		[Cpp2IlInjected.Address(RVA = "0xA6473F0", Offset = "0xA6461F0", VA = "0x18A6473F0")]
		private QuaternionCurveBuilder(QuaternionCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0xA646FB0", Offset = "0xA645DB0", VA = "0x18A646FB0", Slot = "10")]
		public override CurveBuilder<Quaternion> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0xA646F80", Offset = "0xA645D80", VA = "0x18A646F80", Slot = "11")]
		protected override bool AreEqual(Quaternion left, Quaternion right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x12A3120", Offset = "0x12A1F20", VA = "0x1812A3120", Slot = "12")]
		protected override Quaternion CloneValue(Quaternion value)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0xA647030", Offset = "0xA645E30", VA = "0x18A647030", Slot = "13")]
		protected override Quaternion CreateValue(IReadOnlyList<float> values)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0xA647360", Offset = "0xA646160", VA = "0x18A647360", Slot = "15")]
		protected override Quaternion GetTangent(Quaternion fromValue, Quaternion toValue)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0xA6471E0", Offset = "0xA645FE0", VA = "0x18A6471E0", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA648080", Offset = "0xA646E80", VA = "0x18A648080")]
		public SparseCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0xA648030", Offset = "0xA646E30", VA = "0x18A648030")]
		private SparseCurveBuilder(SparseCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0xA647D20", Offset = "0xA646B20", VA = "0x18A647D20", Slot = "10")]
		public override CurveBuilder<SparseWeight8> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(RVA = "0xA647CE0", Offset = "0xA646AE0", VA = "0x18A647CE0", Slot = "11")]
		protected override bool AreEqual(SparseWeight8 left, SparseWeight8 right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x569E6A0", Offset = "0x569D4A0", VA = "0x18569E6A0", Slot = "12")]
		protected override SparseWeight8 CloneValue(SparseWeight8 value)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0xA647DA0", Offset = "0xA646BA0", VA = "0x18A647DA0", Slot = "13")]
		protected override SparseWeight8 CreateValue(IReadOnlyList<float> values)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADD")]
		[Cpp2IlInjected.Address(RVA = "0xA647FF0", Offset = "0xA646DF0", VA = "0x18A647FF0", Slot = "15")]
		protected override SparseWeight8 GetTangent(SparseWeight8 fromValue, SparseWeight8 toValue)
		{
			return default(SparseWeight8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000ADE")]
		[Cpp2IlInjected.Address(RVA = "0xA647DE0", Offset = "0xA646BE0", VA = "0x18A647DE0", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xA647CA0", Offset = "0xA646AA0", VA = "0x18A647CA0")]
		public SegmentCurveBuilder()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE0")]
		[Cpp2IlInjected.Address(RVA = "0xA647C50", Offset = "0xA646A50", VA = "0x18A647C50")]
		private SegmentCurveBuilder(SegmentCurveBuilder other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0xA647790", Offset = "0xA646590", VA = "0x18A647790", Slot = "10")]
		public override CurveBuilder<ArraySegment<float>> Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0xA647440", Offset = "0xA646240", VA = "0x18A647440", Slot = "11")]
		protected override bool AreEqual(ArraySegment<float> left, ArraySegment<float> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE3")]
		[Cpp2IlInjected.Address(RVA = "0xA647680", Offset = "0xA646480", VA = "0x18A647680", Slot = "12")]
		protected override ArraySegment<float> CloneValue(ArraySegment<float> value)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE4")]
		[Cpp2IlInjected.Address(RVA = "0xA647810", Offset = "0xA646610", VA = "0x18A647810", Slot = "13")]
		protected override ArraySegment<float> CreateValue(IReadOnlyList<float> values)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0xA647BA0", Offset = "0xA6469A0", VA = "0x18A647BA0", Slot = "15")]
		protected override ArraySegment<float> GetTangent(ArraySegment<float> fromValue, ArraySegment<float> toValue)
		{
			return default(ArraySegment<float>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0xA647950", Offset = "0xA646750", VA = "0x18A647950", Slot = "14")]
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
